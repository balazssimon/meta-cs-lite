using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Errors
{
    public class ErrorSymbolFactory
    {
        private readonly Dictionary<Type, Func<Symbol, DiagnosticInfo, Symbol>> _constructors = new();

        public ErrorSymbolFactory()
        {
            Register<NamespaceSymbol>((s, di) => new ErrorNamespaceSymbol(s, di));
            Register<NamedTypeSymbol>((s, di) => new ErrorNamedTypeSymbol(s, di));
            Register<DeclaredSymbol>((s, di) => new ErrorDeclaredSymbol(s, di));
        }

        protected void Register<TSymbol>(Func<Symbol, DiagnosticInfo, Symbol> constructor)
            where TSymbol : Symbol
        {
            _constructors.Add(typeof(TSymbol), constructor);
        }

        public TSymbol? CreateSymbol<TSymbol>(Symbol container, DiagnosticInfo errorInfo)
            where TSymbol : Symbol
        {
            return CreateSymbol(typeof(TSymbol), container, errorInfo) as TSymbol;
        }

        public Symbol? CreateSymbol(Type symbolType, Symbol container, DiagnosticInfo errorInfo)
        {
            if (_constructors.TryGetValue(symbolType, out var constructor))
            {
                return constructor(container, errorInfo);
            }
            else
            {
                return null;
            }
        }

    }
}
