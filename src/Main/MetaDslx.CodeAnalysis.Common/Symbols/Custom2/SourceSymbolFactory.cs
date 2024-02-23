using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceSymbolFactory : SymbolFactory<MergedDeclaration>
    {
        private static readonly ConditionalWeakTable<Type, SymbolConstructor> s_constructors = new ConditionalWeakTable<Type, SymbolConstructor>();

        public SourceSymbolFactory()
        {
        }

        public override string? GetName(MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.Name;
        }

        public override string? GetMetadataName(MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MetadataName;
        }

        public override ImmutableArray<Symbol> CreateContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var declaration = container.MergedDeclaration;
            if (declaration is null || declaration.Children.Length == 0) return ImmutableArray<Symbol>.Empty;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in declaration.Children)
            {
                var symbol = CreateSymbol<Symbol>(container, child, diagnostics, cancellationToken);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        protected override Symbol? CreateSymbolCore(Symbol container, MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken) 
        {
            if (container is null) throw new ArgumentNullException(nameof(container));
            if (container is ModuleSymbol) throw new ArgumentException("ModuleSymbol is unexpected here.", nameof(container));
            if (container is AssemblySymbol) throw new ArgumentException("AssemblySymbol is unexpected here.", nameof(container));
            if (container.Model is null) throw new ArgumentException("Model of the container symbol must not be null.", nameof(container));
            var containingModule = container.ContainingModule;
            if (containingModule is null) throw new ArgumentException("Containing module of the container symbol must not be null.", nameof(container));
            if (containingModule.ModelFactory is null) throw new ArgumentException("Model factory of the containing module of the container symbol must not be null.", nameof(container));
            var symbolConstructor = GetConstructor(container, underlyingObject, diagnostics, cancellationToken);
            if (symbolConstructor is null) return null;
            return symbolConstructor.Invoke(container, underlyingObject);
        }

        private SymbolConstructor? GetConstructor(Symbol container, MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var mobjType = underlyingObject.ModelObjectType;
            if (mobjType is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.FirstLocation, $"Declaration {underlyingObject.Name} has no ModelObjectType."));
                return null;
            }
            if (s_constructors.TryGetValue(mobjType, out var symbolConstructor))
            {
                return symbolConstructor;
            }
            var symbolType = mobjType;
            ModelClassInfo? mobjInfo = null;
            if (!typeof(Symbol).IsAssignableFrom(mobjType))
            {
                mobjInfo = container.ContainingModule.ModelFactory.GetInfo(mobjType);
                if (mobjInfo is null)
                {
                    diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.FirstLocation, $"Could not instantiate model object '{mobjType.FullName}', because it's ModelClassInfo could not be retrieved."));
                    return s_constructors.GetValue(mobjType, t => null);
                }
                symbolType = mobjInfo?.SymbolType.AsType();
                if (symbolType is null)
                {
                    diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.FirstLocation, $"Could not instantiate model object '{mobjType.FullName}', because it's SymbolType is missing."));
                    return s_constructors.GetValue(mobjType, t => null);
                }
            }
            var symbolImplTypeName = $"{symbolType.Namespace}.Impl.{symbolType.Name}Impl";
            var symbolImplType = symbolType.Assembly.GetType(symbolImplTypeName);
            if (symbolImplType is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.FirstLocation, $"Could not instantiate symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' could not be resolved as a type."));
                return s_constructors.GetValue(mobjType, t => null);
            }
            foreach (var ctr in symbolImplType.GetConstructors())
            {
                var containerIndex = -1;
                var declarationIndex = -1;
                var modelObjectIndex = -1;
                var parameters = ctr.GetParameters();
                for (var i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];
                    if (param.Name == "container" && typeof(Symbol).IsAssignableFrom(param.ParameterType) && containerIndex < 0) containerIndex = i;
                    if (param.Name == "declaration" && typeof(MergedDeclaration).IsAssignableFrom(param.ParameterType) && declarationIndex < 0) declarationIndex = i;
                    if (param.Name == "modelObject" && typeof(IModelObject).IsAssignableFrom(param.ParameterType) && modelObjectIndex < 0) modelObjectIndex = i;
                }
                if (containerIndex >= 0 && declarationIndex >= 0 && modelObjectIndex >= 0)
                {
                    symbolConstructor = s_constructors.GetValue(mobjType, t => new SymbolConstructor(this, ctr, mobjInfo, parameters.Length, containerIndex, declarationIndex, modelObjectIndex));
                    break;
                }
            }
            if (symbolConstructor is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.FirstLocation, $"Could not instantiate source symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' does not have a constructor with parameters 'container', 'declaration' and 'modelObject'."));
                return s_constructors.GetValue(mobjType, t => null);
            }
            return symbolConstructor;
        }

        protected override MergedDeclaration? GetParentCore(MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        protected virtual IModelObject? CreateModelObject(Symbol container, MergedDeclaration declaration, ModelClassInfo info)
        {
            if (info is null) return null;
            var mobj = info.Create(container.Model);
            if (mobj is not null)
            {
                mobj.MName = declaration.Name;
                if (container.ModelObject is not null)
                {
                    container.ModelObject.MChildren.Add(mobj);
                    if (declaration.QualifierProperty is not null)
                    {
                        var qslot = container.ModelObject.MGetSlot(declaration.QualifierProperty);
                        var box = qslot?.Add(mobj);
                        box.Syntax = declaration.SyntaxReferences.FirstOrDefault();
                    }
                }
            }
            return mobj;
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        private class SymbolConstructor
        {
            private readonly SourceSymbolFactory _factory;
            private readonly ConstructorInfo _constructorInfo;
            private readonly ModelClassInfo? _modelClassInfo;
            private readonly int _paramCount;
            private readonly int _containerIndex;
            private readonly int _declarationIndex;
            private readonly int _modelObjectIndex;

            public SymbolConstructor(SourceSymbolFactory factory, ConstructorInfo constructorInfo, ModelClassInfo? modelClassInfo, int paramCount, int containerIndex, int declarationIndex, int modelObjectIndex) 
            {
                _factory = factory;
                _constructorInfo = constructorInfo;
                _modelClassInfo = modelClassInfo;
                _paramCount = paramCount;
                _containerIndex = containerIndex;
                _declarationIndex = declarationIndex;
                _modelObjectIndex = modelObjectIndex;
            }

            public Symbol Invoke(Symbol container, MergedDeclaration declaration)
            {
                var args = new object[_paramCount];
                args[_containerIndex] = container;
                args[_declarationIndex] = declaration;
                var mobj = _factory.CreateModelObject(container, declaration, _modelClassInfo);
                args[_modelObjectIndex] = mobj;
                var symbol = (Symbol)Activator.CreateInstance(_constructorInfo.DeclaringType, args);
                if (mobj is not null) mobj.MSymbol = symbol;
                return symbol;
            }
        }
    }
}
