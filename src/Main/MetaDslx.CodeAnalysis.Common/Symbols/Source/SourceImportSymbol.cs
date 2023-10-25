using MetaDslx.CodeAnalysis.Declarations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceImportSymbol : ImportSymbol, ISourceSymbol
    {
        private readonly MergedDeclaration _declaration;
        private ImmutableArray<SourceLocation> _locations;

        internal SourceImportSymbol(Symbol container, MergedDeclaration declaration)
            : base(container)
        {
            _declaration = declaration;
        }

        public new SourceModuleSymbol ContainingModule => (SourceModuleSymbol)base.ContainingModule;
        protected SourceSymbolFactory SymbolFactory => ContainingModule.SymbolFactory;
        public MergedDeclaration Declaration => _declaration;
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
        public override ImmutableArray<Location> Locations => ((ISourceSymbol)this).Locations.Cast<SourceLocation, Location>();
        ImmutableArray<SourceLocation> ISourceSymbol.Locations
        {
            get
            {
                if (_locations.IsDefault)
                {
                    var locations = _declaration.SyntaxReferences.Select(sr => sr.GetLocation() as SourceLocation).Where(l => l is not null).ToImmutableArray();
                    ImmutableInterlocked.InterlockedInitialize(ref _locations, locations);
                }
                return _locations;
            }
        }
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
            return SymbolFactory.CreateContainedSymbols(this);
        }

        protected override (ImmutableArray<AliasSymbol> aliases, ImmutableArray<NamespaceSymbol> namespaces, ImmutableArray<DeclaredSymbol> symbols) ComputeImports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var fileNames = SymbolFactory.GetSymbolPropertyValues<string>(this, nameof(FileNames), diagnostics, cancellationToken);
            var aliases = SymbolFactory.GetSymbolPropertyValues<AliasSymbol>(this, nameof(Aliases), diagnostics, cancellationToken);
            var namespaces = SymbolFactory.GetSymbolPropertyValues<NamespaceSymbol>(this, nameof(Namespaces), diagnostics, cancellationToken);
            var symbols = SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(this, nameof(Symbols), diagnostics, cancellationToken);
            // TODO:MetaDslx: file imports
            return (aliases, namespaces, symbols);
        }
    }
}
