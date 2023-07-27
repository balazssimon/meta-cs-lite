﻿using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    public class CSharpSymbolFactory
    {
        private readonly Dictionary<Type, Func<Symbol, ISymbol, Symbol>> _constructors = new();
        private readonly List<(Type, Type)> _types = new();
        private readonly ConcurrentDictionary<object, Symbol> _symbols = new();

        public CSharpSymbolFactory()
        {
            Register<NamespaceSymbol, INamespaceSymbol>((s, cs) => new CSharpNamespaceSymbol(s, cs));
            Register<NamedTypeSymbol, INamedTypeSymbol>((s, cs) => new CSharpNamedTypeSymbol(s, cs));
            Register<DeclaredSymbol, ISymbol>((s, cs) => new CSharpDeclaredSymbol(s, cs));
        }

        protected void Register<TSymbol, TISymbol>(Func<Symbol, TISymbol, TSymbol> constructor)
            where TSymbol : Symbol
            where TISymbol: ISymbol
        {
            _constructors.Add(typeof(TSymbol), (s, cs) => constructor(s, (TISymbol)cs));
            _types.Add((typeof(TISymbol), typeof(TSymbol)));
        }

        protected Type? GetSymbolType(Type csharpSymbolType)
        {
            foreach (var typePair in _types)
            {
                if (typePair.Item1.IsAssignableFrom(csharpSymbolType)) return typePair.Item2;
            }
            return null;
        }

        internal void AddSymbol(ISymbol csharpSymbol, Symbol symbol)
        {
            _symbols.TryAdd(csharpSymbol, symbol);
        }

        public Symbol? GetSymbol(ISymbol? csharpSymbol)
        {
            if (csharpSymbol is null) return null;
            if (_symbols.TryGetValue(csharpSymbol, out var oldSymbol))
            {
                return oldSymbol;
            }
            else
            {
                var symbolType = GetSymbolType(csharpSymbol.GetType());
                if (symbolType is null) return null;
                var container = GetSymbol(csharpSymbol.ContainingSymbol);
                if (container is null) return null;
                return CreateSymbol(symbolType, container, csharpSymbol);
            }
        }

        public TSymbol? GetSymbol<TSymbol>(ISymbol? csharpSymbol)
            where TSymbol : Symbol
        {
            return GetSymbol(csharpSymbol) as TSymbol;
        }

        public ImmutableArray<TSymbol> GetSymbols<TSymbol>(IEnumerable<ISymbol?> csharpSymbols)
            where TSymbol : Symbol
        {
            var builder = ArrayBuilder<TSymbol>.GetInstance();
            foreach (var csharpSymbol in csharpSymbols)
            {
                var symbol = GetSymbol(csharpSymbol);
                if (symbol is TSymbol typedSymbol) builder.Add(typedSymbol);
            }
            return builder.ToImmutableAndFree();
        }

        protected Symbol? CreateSymbol(Type symbolType, Symbol container, ISymbol csharpSymbol)
        {
            if (_symbols.TryGetValue(csharpSymbol, out var oldSymbol))
            {
                return oldSymbol;
            }
            else if (_constructors.TryGetValue(symbolType, out var constructor))
            {
                var newSymbol = constructor(container, csharpSymbol);
                return _symbols.GetOrAdd(csharpSymbol, newSymbol);
            }
            else
            {
                return null;
            }
        }
    }
}