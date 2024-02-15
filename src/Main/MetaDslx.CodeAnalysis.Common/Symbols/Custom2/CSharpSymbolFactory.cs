using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    public class CSharpSymbolFactory : SymbolFactory<ISymbol>
    {
        public CSharpSymbolFactory(ModuleSymbol moduleSymbol) 
            : base(moduleSymbol)
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

        public override ImmutableArray<Symbol> GetContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var csharpSymbol = container.CSharpSymbol as INamespaceOrTypeSymbol;
            if (csharpSymbol is null) return ImmutableArray<Symbol>.Empty;
            var members = csharpSymbol.GetMembers();
            if (members.Length == 0) return ImmutableArray<Symbol>.Empty;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in members)
            {
                var symbol = GetSymbol<Symbol>(container, child, diagnostics, cancellationToken);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        protected override TSymbol? CreateSymbol<TSymbol>(Symbol container, ISymbol underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken) where TSymbol : default
        {
            throw new NotImplementedException();
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<TValue>.Empty;
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
        }
    }
}
