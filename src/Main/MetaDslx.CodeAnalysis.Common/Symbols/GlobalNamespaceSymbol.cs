using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal sealed class GlobalNamespaceSymbol : NamespaceSymbol
    {
        public GlobalNamespaceSymbol(ModuleSymbol containingModule) 
            : base(containingModule)
        {
        }

        public override NamespaceExtent Extent => new NamespaceExtent(this.ContainingModule);

        public override ImmutableArray<Location> Locations => this.ContainingModule.Locations;

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            // TODO:MetaDslx
            return base.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<DeclaredSymbol>().ToImmutableArray();
        }
    }
}
