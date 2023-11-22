using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public sealed class SourceAliasSymbol : AliasSymbol, ISourceSymbol
    {
        private readonly MergedDeclaration _declaration;

        internal SourceAliasSymbol(Symbol container, MergedDeclaration declaration)
            : base(container)
        {
            _declaration = declaration;
        }

        public new SourceModuleSymbol ContainingModule => (SourceModuleSymbol)base.ContainingModule;
        protected SourceSymbolFactory SymbolFactory => ContainingModule.SymbolFactory;
        public MergedDeclaration Declaration => _declaration;
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
        public SyntaxNodeOrToken DeclaringSyntaxReference => DeclaringSyntaxReferences.FirstOrDefault();
        public override ImmutableArray<Location> Locations => ((ISourceSymbol)this).Locations.Cast<SourceLocation, Location>();
        ImmutableArray<SourceLocation> ISourceSymbol.Locations => _declaration.NameLocations.Length > 0 ? _declaration.NameLocations : DeclaringSyntaxReferences.Select(sr => sr.GetLocation() as SourceLocation).ToImmutableArray();
        SourceLocation ISourceSymbol.Location => ((ISourceSymbol)this).Locations.FirstOrDefault();

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _declaration.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _declaration.MetadataName;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateContainedSymbols(this, diagnostics);
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<AttributeSymbol>(this, nameof(Attributes), diagnostics, cancellationToken);
        }

        protected override Symbol CompleteProperty_Target(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<Symbol>(this, nameof(Target), diagnostics, cancellationToken);
        }

    }
}
