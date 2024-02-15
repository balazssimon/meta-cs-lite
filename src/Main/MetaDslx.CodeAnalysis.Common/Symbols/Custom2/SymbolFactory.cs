using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract class SymbolFactory<T> : ISymbolFactory
    {
        private readonly ModuleSymbol _moduleSymbol;
        private readonly ConditionalWeakTable<object, Symbol> _symbols;

        public SymbolFactory(ModuleSymbol moduleSymbol)
        {
            _moduleSymbol = moduleSymbol;
            _symbols = new ConditionalWeakTable<object, Symbol>();
        }

        public ModuleSymbol ModuleSymbol => _moduleSymbol;

        public void AddSymbol(Symbol symbol)
        {
            if (symbol is SymbolInst si) _symbols.Add(si._underlyingObject, symbol);
            else if (symbol is SymbolImpl sim) _symbols.Add(sim.__Wrapped._underlyingObject, symbol);
        }

        public TSymbol? GetSymbol<TSymbol>(Symbol container, T underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol
        {
            if (_symbols.TryGetValue(underlyingObject, out var symbol))
            {
                if (symbol is TSymbol tsymbol) return tsymbol;
                else return default;
            }
            symbol = CreateSymbol<TSymbol>(container, underlyingObject, diagnostics, cancellationToken);
            if (symbol is not null)
            {
                _symbols.Add(underlyingObject, symbol);
                if (symbol is TSymbol tsymbol) return tsymbol;
            }
            return default;
        }

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

        public ImmutableArray<ImportSymbol> GetImportSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
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

        string? ISymbolFactory.GetName(object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return GetName((T)underlyingObject, diagnostics, cancellationToken);
        }

        string? ISymbolFactory.GetMetadataName(object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return GetMetadataName((T)underlyingObject, diagnostics, cancellationToken);
        }


        public abstract string? GetName(T underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        public abstract string? GetMetadataName(T underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        public abstract ImmutableArray<Symbol> GetContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        public abstract ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        public abstract void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        protected abstract TSymbol? CreateSymbol<TSymbol>(Symbol container, T underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol;
    }
}
