using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    using ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;

    public class CSharpSymbolFactory : SymbolFactory<ISymbol>
    {
        private readonly ConditionalWeakTable<Type, SymbolConstructor> s_constructors = new ConditionalWeakTable<Type, SymbolConstructor>();

        public CSharpSymbolFactory() 
        {
        }

        public override string? GetName(ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.Name;
        }

        public override string? GetMetadataName(ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MetadataName;
        }

        public override ImmutableArray<Symbol> CreateContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var csharpSymbol = container.CSharpSymbol as INamespaceOrTypeSymbol;
            if (csharpSymbol is null) return ImmutableArray<Symbol>.Empty;
            var members = csharpSymbol.GetMembers();
            if (members.Length == 0) return ImmutableArray<Symbol>.Empty;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in members)
            {
                var symbol = CreateSymbol<Symbol>(container, child, diagnostics, cancellationToken);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        protected override Symbol? CreateSymbolCore(Symbol container, ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
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

        private SymbolConstructor? GetConstructor(Symbol container, ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var csType = underlyingObject.GetType();
            if (s_constructors.TryGetValue(csType, out var symbolConstructor))
            {
                return symbolConstructor;
            }
            var symbolType = GetSymbolType(container, underlyingObject, diagnostics, cancellationToken);
            if (symbolType is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.Locations.FirstOrDefault().ToMetaDslx(), $"Could not map .NET symbol '{underlyingObject}' to MetaDslx symbol, because it's SymbolType is missing."));
                return s_constructors.GetValue(csType, t => null);
            }
            var symbolImplTypeName = $"{symbolType.Namespace}.Impl.{symbolType.Name}Impl";
            var symbolImplType = symbolType.Assembly.GetType(symbolImplTypeName);
            if (symbolImplType is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.Locations.FirstOrDefault().ToMetaDslx(), $"Could not instantiate symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' could not be resolved as a type."));
                return s_constructors.GetValue(csType, t => null);
            }
            foreach (var ctr in symbolImplType.GetConstructors())
            {
                var containerIndex = -1;
                var csharpIndex = -1;
                var modelObjectIndex = -1;
                var parameters = ctr.GetParameters();
                for (var i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];
                    if (param.Name == "container" && typeof(Symbol).IsAssignableFrom(param.ParameterType) && containerIndex < 0) containerIndex = i;
                    if (param.Name == "csharpSymbol" && typeof(ISymbol).IsAssignableFrom(param.ParameterType) && csharpIndex < 0) csharpIndex = i;
                    if (param.Name == "modelObject" && typeof(IModelObject).IsAssignableFrom(param.ParameterType) && modelObjectIndex < 0) modelObjectIndex = i;
                }
                if (containerIndex >= 0 && csharpIndex >= 0 && modelObjectIndex >= 0)
                {
                    var mobjInfo = GetModelClassInfo(container, underlyingObject, diagnostics, cancellationToken);
                    symbolConstructor = s_constructors.GetValue(csType, t => new SymbolConstructor(this, ctr, mobjInfo, parameters.Length, containerIndex, csharpIndex, modelObjectIndex));
                    break;
                }
            }
            if (symbolConstructor is null)
            {
                diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.Locations.FirstOrDefault().ToMetaDslx(), $"Could not instantiate symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' does not have a constructor with parameters 'container', 'csharpSymbol' and 'modelObject'."));
                return s_constructors.GetValue(csType, t => null);
            }
            return symbolConstructor;
        }

        protected override ISymbol? GetParentCore(ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.ContainingSymbol;
        }

        protected virtual Type GetSymbolType(Symbol container, ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var symbolType = typeof(DeclarationSymbol);
            if (underlyingObject is INamespaceSymbol) symbolType = typeof(NamespaceSymbol);
            if (underlyingObject is ITypeSymbol) symbolType = typeof(TypeSymbol);
            return symbolType;
        }

        protected virtual ModelClassInfo? GetModelClassInfo(Symbol container, ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        protected virtual IModelObject? CreateModelObject(Symbol container, ISymbol csharpSymbol, ModelClassInfo info)
        {
            if (info is null) return null;
            var mobj = info.Create(container.Model);
            if (mobj is not null)
            {
                mobj.MName = csharpSymbol.Name;
                if (container.ModelObject is not null)
                {
                    container.ModelObject.MChildren.Add(mobj);
                }
            }
            return mobj;
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<TValue>.Empty;
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            // nop
        }

        private class SymbolConstructor
        {
            private readonly CSharpSymbolFactory _factory;
            private readonly ConstructorInfo _constructorInfo;
            private readonly ModelClassInfo? _modelClassInfo;
            private readonly int _paramCount;
            private readonly int _containerIndex;
            private readonly int _csharpIndex;
            private readonly int _modelObjectIndex;

            public SymbolConstructor(CSharpSymbolFactory factory, ConstructorInfo constructorInfo, ModelClassInfo? modelClassInfo, int paramCount, int containerIndex, int csharpIndex, int modelObjectIndex)
            {
                _factory = factory;
                _constructorInfo = constructorInfo;
                _modelClassInfo = modelClassInfo;
                _paramCount = paramCount;
                _containerIndex = containerIndex;
                _csharpIndex = csharpIndex;
                _modelObjectIndex = modelObjectIndex;
            }

            public Symbol Invoke(Symbol container, ISymbol csharpSymbol)
            {
                var args = new object[_paramCount];
                args[_containerIndex] = container;
                args[_csharpIndex] = csharpSymbol;
                var mobj = _factory.CreateModelObject(container, csharpSymbol, _modelClassInfo);
                args[_modelObjectIndex] = mobj;
                var symbol = (Symbol)Activator.CreateInstance(_constructorInfo.DeclaringType, args);
                if (mobj is not null) mobj.MSymbol = symbol;
                return symbol;
            }
        }
    }
}
