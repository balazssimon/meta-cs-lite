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
        private readonly Dictionary<Type, Func<Symbol, ErrorSymbolInfo, Symbol>> _constructors = new();

        public ErrorSymbolFactory()
        {
            Register<NamespaceSymbol>((s, ei) => new ErrorNamespaceSymbol(s, ei));
            Register<TypeSymbol>((s, ei) => new ErrorTypeSymbol(s, ei));
            Register<DeclarationSymbol>((s, ei) => new ErrorDeclarationSymbol(s, ei));
        }

        protected void Register<TSymbol>(Func<Symbol, ErrorSymbolInfo, Symbol> constructor)
            where TSymbol : Symbol
        {
            _constructors.Add(typeof(TSymbol), constructor);
        }

        public TSymbol? CreateSymbol<TSymbol>(Symbol container, ErrorSymbolInfo errorInfo)
            where TSymbol : Symbol
        {
            return CreateSymbol(typeof(TSymbol), container, errorInfo) as TSymbol;
        }

        public Symbol? CreateSymbol(Type symbolType, Symbol container, ErrorSymbolInfo errorInfo)
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
