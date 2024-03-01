using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public interface ISymbolFactory
    {
        void AddSymbol(Symbol symbol);
        string? GetName(object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        string? GetMetadataName(object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        Symbol? CreateSymbol(Symbol container, object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        TSymbol? CreateSymbol<TSymbol>(Symbol container, object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol;
        ImmutableArray<TSymbol> CreateSymbols<TSymbol>(Symbol container, IEnumerable<object> underlyingObjects, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol;
        Symbol? GetSymbol(object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        TSymbol? GetSymbol<TSymbol>(object underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol;
        ImmutableArray<TSymbol> GetSymbols<TSymbol>(IEnumerable<object> underlyingObjects, DiagnosticBag diagnostics, CancellationToken cancellationToken)
            where TSymbol : Symbol;
        ImmutableArray<Symbol> CreateContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        ImmutableArray<ImportSymbol> GetImportSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        ImmutableArray<DeclarationSymbol> GetMemberSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        TValue GetSymbolPropertyValue<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken);
        void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken);

    }
}
