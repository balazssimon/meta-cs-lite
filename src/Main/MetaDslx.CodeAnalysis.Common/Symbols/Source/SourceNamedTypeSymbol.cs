using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceNamedTypeSymbol : NamedTypeSymbol, ISourceSymbol
    {
        private readonly MergedDeclaration _declaration;
        private readonly IModelObject _modelObject;

        public SourceNamedTypeSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container)
        {
            _declaration = declaration;
            _modelObject = modelObject;
        }

        public IModel Model => _modelObject.Model;
        public IModelObject ModelObject => _modelObject;

        public new SourceModuleSymbol ContainingModule => (SourceModuleSymbol)base.ContainingModule;
        public MergedDeclaration Declaration => _declaration;
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
        public override ImmutableArray<Location> Locations => _declaration.NameLocations;

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
            return ContainingModule.SymbolFactory.CreateContainedSymbols(this);
        }
    }
}
