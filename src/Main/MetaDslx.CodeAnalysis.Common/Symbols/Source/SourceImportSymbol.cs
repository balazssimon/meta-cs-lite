using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceImportSymbol : ImportSymbol, ISourceSymbol
    {
        private readonly MergedDeclaration _declaration;

        public SourceImportSymbol(Symbol container, MergedDeclaration declaration)
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
        
        protected override (ImmutableArray<string> files, ImmutableArray<AliasSymbol> aliases, ImmutableArray<NamespaceSymbol> namespaces, ImmutableArray<DeclaredSymbol> symbols) ComputeImports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var files = SymbolFactory.GetSymbolPropertyValues<string>(this, nameof(Files), diagnostics, cancellationToken);
            var aliases = SymbolFactory.GetSymbolPropertyValues<AliasSymbol>(this, nameof(Aliases), diagnostics, cancellationToken);
            var namespaces = SymbolFactory.GetSymbolPropertyValues<NamespaceSymbol>(this, nameof(Namespaces), diagnostics, cancellationToken);
            var symbols = SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(this, nameof(Symbols), diagnostics, cancellationToken);
            return (files, aliases, namespaces, symbols);
        }
    }
}
