using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public static class SymbolUtils
    {
        public static TSymbol? GetInnermostContainingSymbol<TSymbol>(this Symbol? symbol, bool includeSelf = false, CancellationToken cancellationToken = default)
            where TSymbol : Symbol
        {
            if (symbol is null) return default;
            var container = includeSelf ? symbol : symbol.ContainingSymbol;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is TSymbol ts) return ts;
                container = container.ContainingSymbol;
            }
            return default;
        }

        public static TSymbol? GetOutermostContainingSymbol<TSymbol>(this Symbol? symbol, bool includeSelf = false, CancellationToken cancellationToken = default)
            where TSymbol : Symbol
        {
            if (symbol is null) return default;
            TSymbol? result = default;
            var container = includeSelf ? symbol : symbol.ContainingSymbol;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is TSymbol ts) result = ts;
                container = container.ContainingSymbol;
            }
            return result;
        }

        public static ImmutableArray<TSymbol> GetAllContainingSymbolsInwards<TSymbol>(this Symbol? symbol, bool includeSelf = false, CancellationToken cancellationToken = default)
            where TSymbol : Symbol
        {
            if (symbol is null) return ImmutableArray<TSymbol>.Empty;
            var result = ArrayBuilder<TSymbol>.GetInstance();
            var container = includeSelf ? symbol : symbol.ContainingSymbol;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is TSymbol ts) result.Add(ts);
                container = container.ContainingSymbol;
            }
            result.ReverseContents();
            return result.ToImmutableAndFree();
        }

        public static ImmutableArray<TSymbol> GetAllContainingSymbolsOutwards<TSymbol>(this Symbol? symbol, bool includeSelf = false, CancellationToken cancellationToken = default)
            where TSymbol : Symbol
        {
            if (symbol is null) return ImmutableArray<TSymbol>.Empty;
            var result = ArrayBuilder<TSymbol>.GetInstance();
            var container = includeSelf ? symbol : symbol.ContainingSymbol;
            while (container is not null)
            {
                cancellationToken.ThrowIfCancellationRequested();
                if (container is TSymbol ts) result.Add(ts);
                container = container.ContainingSymbol;
            }
            return result.ToImmutableAndFree();
        }
        
        public static ImmutableArray<TSymbol> GetAllContainedSymbols<TSymbol>(this Symbol? symbol, bool includeSelf = false, CancellationToken cancellationToken = default)
            where TSymbol : Symbol
        {
            if (symbol is null) return ImmutableArray<TSymbol>.Empty;
            var result = ArrayBuilder<TSymbol>.GetInstance();
            var queue = ArrayBuilder<Symbol>.GetInstance();
            queue.Add(symbol);
            int i = 0;
            while (i < queue.Count)
            {
                cancellationToken.ThrowIfCancellationRequested();
                var current = queue[i];
                if (current is TSymbol ts)
                {
                    if (includeSelf || i > 0) result.Add(ts);
                }
                queue.AddRange(current.ContainedSymbols);
            }
            queue.Free();
            return result.ToImmutableAndFree();
        }

    }
}
