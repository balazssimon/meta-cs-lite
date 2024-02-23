using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelSymbolFactory : SymbolFactory<IModelObject>
    {
        private readonly ConditionalWeakTable<Type, SymbolConstructor> s_constructors = new ConditionalWeakTable<Type, SymbolConstructor>();
        private readonly Compilation _compilation;

        public ModelSymbolFactory(Compilation compilation) 
        {
            _compilation = compilation;
        }

        public Compilation Compilation => _compilation;

        public override string? GetName(IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MName;
        }

        public override string? GetMetadataName(IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MName;
        }

        public override ImmutableArray<Symbol> CreateContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var mobj = container.ModelObject;
            if (mobj is null || mobj.MChildren.Count == 0) return ImmutableArray<Symbol>.Empty;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in mobj.MChildren)
            {
                var symbol = CreateSymbol<Symbol>(container, child, diagnostics, cancellationToken);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        protected override IModelObject? GetParentCore(IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MParent;
        }

        protected override Symbol? CreateSymbolCore(Symbol container, IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (container is null) throw new ArgumentNullException(nameof(container));
            if (container is ModuleSymbol) throw new ArgumentException("ModuleSymbol is unexpected here.", nameof(container));
            if (container is AssemblySymbol) throw new ArgumentException("AssemblySymbol is unexpected here.", nameof(container));
            //if (container.Model is null) throw new ArgumentException("Model of the container symbol must not be null.", nameof(container));
            var containingModule = container.ContainingModule;
            if (containingModule is null) throw new ArgumentException("Containing module of the container symbol must not be null.", nameof(container));
            //if (containingModule.ModelFactory is null) throw new ArgumentException("Model factory of the containing module of the container symbol must not be null.", nameof(container));
            var symbolConstructor = GetConstructor(container, underlyingObject, diagnostics, cancellationToken);
            if (symbolConstructor is null) return null;
            return symbolConstructor.Invoke(container, underlyingObject);
        }

        private SymbolConstructor? GetConstructor(Symbol container, IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var mobjType = underlyingObject.MInfo.MetaType.AsType();
            if (mobjType is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.MLocation, $"Model object '{underlyingObject.MName}' has no MetaType."));
                return null;
            }
            if (s_constructors.TryGetValue(mobjType, out var symbolConstructor))
            {
                return symbolConstructor;
            }
            var symbolType = underlyingObject.MInfo.SymbolType.AsType();
            if (symbolType is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.MLocation, $"Model object '{underlyingObject.MName}' has no SymbolType."));
                return null;
            }
            var symbolImplTypeName = $"{symbolType.Namespace}.Impl.{symbolType.Name}Impl";
            var symbolImplType = symbolType.Assembly.GetType(symbolImplTypeName);
            if (symbolImplType is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.MLocation, $"Could not instantiate symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' could not be resolved as a type."));
                return s_constructors.GetValue(mobjType, t => null);
            }
            foreach (var ctr in symbolImplType.GetConstructors())
            {
                var containerIndex = -1;
                var modelObjectIndex = -1;
                var parameters = ctr.GetParameters();
                for (var i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];
                    if (param.Name == "container" && typeof(Symbol).IsAssignableFrom(param.ParameterType) && containerIndex < 0) containerIndex = i;
                    if (param.Name == "modelObject" && typeof(IModelObject).IsAssignableFrom(param.ParameterType) && modelObjectIndex < 0) modelObjectIndex = i;
                }
                if (containerIndex >= 0 && modelObjectIndex >= 0)
                {
                    symbolConstructor = s_constructors.GetValue(mobjType, t => new SymbolConstructor(ctr, parameters.Length, containerIndex, modelObjectIndex));
                    break;
                }
            }
            if (symbolConstructor is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.MLocation, $"Could not instantiate source symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' does not have a constructor with parameters 'container', 'declaration' and 'modelObject'."));
                return s_constructors.GetValue(mobjType, t => null);
            }
            return symbolConstructor;
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var modelObject = symbol.ModelObject;
            if (modelObject is null) return ImmutableArray<TValue>.Empty;
            var builder = ArrayBuilder<TValue>.GetInstance();
            foreach (var prop in modelObject.MInfo.PublicProperties.Where(prop => prop.SymbolProperty == symbolProperty))
            {
                var slot = modelObject.MGetSlot(prop);
                if (slot is null) continue;
                if (typeof(Symbol).IsAssignableFrom(typeof(TValue)))
                {
                    foreach (var box in slot.Boxes)
                    {
                        var item = box.Value;
                        cancellationToken.ThrowIfCancellationRequested();
                        if (item is null) continue;
                        Symbol? symbolItem = null;
                        if (item is IModelObject mobj) symbolItem = GetSymbol(mobj, diagnostics, cancellationToken);
                        else if (item is MetaType mtype) symbolItem = mtype.AsTypeSymbol(_compilation);
                        else if (item is Type type) symbolItem = symbolItem = _compilation.ResolveType(type.FullName);
                        if (symbolItem is TValue typedSymbol)
                        {
                            builder.Add(typedSymbol);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, null, symbolItem, symbolItem?.GetType(), symbolProperty, typeof(TValue)));
                        }
                    }
                }
                else
                {
                    foreach (var box in slot.Boxes)
                    {
                        var item = box.Value;
                        cancellationToken.ThrowIfCancellationRequested();
                        var value = item;
                        if (item is MetaType mtype)
                        {
                            if (typeof(TValue) == typeof(Type)) value = mtype.AsType();
                            if (typeof(TValue) == typeof(string)) value = mtype.FullName;
                            if (typeof(IModelObject).IsAssignableFrom(typeof(TValue))) value = mtype.OriginalModelObject;
                        }
                        if (value is TValue typedValue)
                        {
                            builder.Add(typedValue);
                        }
                        else
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_InvalidSymbolPropertyValue, null, item, item?.GetType(), symbolProperty, typeof(TValue)));
                        }
                    }
                }
            }
            return builder.ToImmutableAndFree();
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            // nop
        }
        private class SymbolConstructor
        {
            private readonly ConstructorInfo _constructorInfo;
            private readonly int _paramCount;
            private readonly int _containerIndex;
            private readonly int _modelObjectIndex;

            public SymbolConstructor(ConstructorInfo constructorInfo, int paramCount, int containerIndex, int modelObjectIndex)
            {
                _constructorInfo = constructorInfo;
                _paramCount = paramCount;
                _containerIndex = containerIndex;
                _modelObjectIndex = modelObjectIndex;
            }

            public Symbol Invoke(Symbol container, IModelObject mobj)
            {
                var args = new object[_paramCount];
                args[_containerIndex] = container;
                args[_modelObjectIndex] = mobj;
                var symbol = (Symbol)Activator.CreateInstance(_constructorInfo.DeclaringType, args);
                //if (mobj is not null) mobj.MSymbol = symbol;
                return symbol;
            }
        }

    }
}
