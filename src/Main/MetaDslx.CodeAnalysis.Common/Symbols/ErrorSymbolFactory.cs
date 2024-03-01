using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Errors
{
    public class ErrorSymbolFactory : SymbolFactory<ErrorSymbolInfo>
    {
        private readonly ConditionalWeakTable<Type, SymbolConstructor> s_constructors = new ConditionalWeakTable<Type, SymbolConstructor>();
        private readonly Compilation _compilation;

        public ErrorSymbolFactory(Compilation compilation) 
        {
            _compilation = compilation;
        }

        public Compilation Compilation => _compilation;

        public override string? GetName(ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.Name;
        }

        public override string? GetMetadataName(ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MetadataName;
        }

        public override ImmutableArray<Symbol> CreateContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<Symbol>.Empty;
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<TValue>.Empty;
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            // nop
        }

        protected override ErrorSymbolInfo? GetParentCore(ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        protected override Symbol? CreateSymbolCore(Symbol container, ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            //if (container is null) throw new ArgumentNullException(nameof(container));
            //if (container is ModuleSymbol) throw new ArgumentException("ModuleSymbol is unexpected here.", nameof(container));
            //if (container is AssemblySymbol) throw new ArgumentException("AssemblySymbol is unexpected here.", nameof(container));
            var symbolConstructor = GetConstructor(container, underlyingObject, diagnostics, cancellationToken);
            if (symbolConstructor is null) return null;
            return symbolConstructor.Invoke(container, underlyingObject);
        }

        private SymbolConstructor? GetConstructor(Symbol container, ErrorSymbolInfo underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (underlyingObject is null) return null;
            var symbolType = underlyingObject.SymbolType;
            if (symbolType is null)
            {
                if (diagnostics is not null) diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.Location, $"Error symbol '{underlyingObject.Name}' has no SymbolType."));
                return null;
            }
            if (s_constructors.TryGetValue(symbolType, out var symbolConstructor))
            {
                return symbolConstructor;
            }
            var symbolImplTypeName = GetSymbolImplementationTypeName(symbolType.Namespace, symbolType.Name);
            var symbolImplType = symbolType.Assembly.GetType(symbolImplTypeName);
            if (symbolImplType is null)
            {
                if (diagnostics is not null) diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.Location, $"Could not instantiate symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' could not be resolved as a type."));
                return s_constructors.GetValue(symbolType, t => null);
            }
            foreach (var ctr in symbolImplType.GetConstructors())
            {
                var containerIndex = -1;
                var errorIndex = -1;
                var parameters = ctr.GetParameters();
                for (var i = 0; i < parameters.Length; i++)
                {
                    var param = parameters[i];
                    if (param.Name == "container" && typeof(Symbol).IsAssignableFrom(param.ParameterType) && containerIndex < 0) containerIndex = i;
                    if (param.Name == "errorInfo" && typeof(ErrorSymbolInfo).IsAssignableFrom(param.ParameterType) && errorIndex < 0) errorIndex = i;
                }
                if (containerIndex >= 0 && errorIndex >= 0)
                {
                    symbolConstructor = s_constructors.GetValue(symbolType, t => new SymbolConstructor(ctr, parameters.Length, containerIndex, errorIndex));
                    break;
                }
            }
            if (symbolConstructor is null)
            {
                if (diagnostics is not null) diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, underlyingObject.Location, $"Could not instantiate error symbol '{symbolType.FullName}', because it's implementation '{symbolImplTypeName}' does not have a constructor with parameters 'container' and 'errorInfo'."));
                return s_constructors.GetValue(symbolType, t => null);
            }
            return symbolConstructor;
        }


        private class SymbolConstructor
        {
            private readonly ConstructorInfo _constructorInfo;
            private readonly int _paramCount;
            private readonly int _containerIndex;
            private readonly int _errorIndex;

            public SymbolConstructor(ConstructorInfo constructorInfo, int paramCount, int containerIndex, int errorIndex)
            {
                _constructorInfo = constructorInfo;
                _paramCount = paramCount;
                _containerIndex = containerIndex;
                _errorIndex = errorIndex;
            }

            public Symbol Invoke(Symbol container, ErrorSymbolInfo errorSymbolInfo)
            {
                var args = new object[_paramCount];
                args[_containerIndex] = container;
                args[_errorIndex] = errorSymbolInfo;
                var symbol = (Symbol)Activator.CreateInstance(_constructorInfo.DeclaringType, args);
                return symbol;
            }
        }

    }
}
