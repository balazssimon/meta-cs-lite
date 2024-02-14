using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract class SymbolFactory<T> : ISymbolFactory
    {
        private readonly ModuleSymbol _moduleSymbol;

        public SymbolFactory(ModuleSymbol moduleSymbol)
        {
            _moduleSymbol = moduleSymbol;
        }

        public ModuleSymbol ModuleSymbol => _moduleSymbol;

        public abstract void AddSymbol(Symbol symbol);

        public abstract TSymbol? GetSymbol<TSymbol>(Symbol container, T underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol;

        public abstract ImmutableArray<Symbol> GetContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken);

        public abstract ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken);

        public abstract void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken);

        public ImmutableArray<TSymbol> GetSymbols<TSymbol>(Symbol container, IEnumerable<T> underlyingObjects, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol
        {
            var builder = ArrayBuilder<TSymbol>.GetInstance();
            foreach (var underlyingObject in underlyingObjects)
            {
                var symbol = GetSymbol<TSymbol>(container, underlyingObject, diagnostics, cancellationToken);
                if (symbol is TSymbol typedSymbol) builder.Add(typedSymbol);
            }
            return builder.ToImmutableAndFree();
        }

        public ImmutableArray<ImportSymbol> GetImportSymbols(Symbol container)
        {
            if (container.ContainedSymbols.Length == 0) return ImmutableArray<ImportSymbol>.Empty;
            else return container.ContainedSymbols.OfType<ImportSymbol>().ToImmutableArray();
        }

        public ImmutableArray<DeclarationSymbol> GetMemberSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (container.ContainedSymbols.Length == 0) return ImmutableArray<DeclarationSymbol>.Empty;
            else return container.ContainedSymbols.OfType<DeclarationSymbol>().ToImmutableArray();
        }

        public TValue GetSymbolPropertyValue<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var values = GetSymbolPropertyValues<TValue>(symbol, symbolProperty, diagnostics, cancellationToken);
            if (values.Length == 1) return values[0];
            else if (values.Length == 0) return default;
            else
            {
                var first = values[0];
                for (int i = 1; i < values.Length; i++)
                {
                    var next = values[i];
                    if (first is null)
                    {
                        if (next is not null)
                        {
                            first = next;
                        }
                    }
                    else
                    {
                        if (!first.Equals(next))
                        {
                            diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_AmbigValue, null, symbolProperty, first, next));
                        }
                    }
                }
                return first;
            }
        }

        TSymbol? ISymbolFactory.GetSymbol<TSymbol>(Symbol container, object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken) where TSymbol : default
        {
            return GetSymbol<TSymbol>(container, (T)underlyingObject, diagnostics, cancellationToken);
        }

        ImmutableArray<TSymbol> ISymbolFactory.GetSymbols<TSymbol>(Symbol container, IEnumerable<object> underlyingObjects, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return GetSymbols<TSymbol>(container, underlyingObjects.Select(uo => (T)uo), diagnostics, cancellationToken);
        }
    }
}
