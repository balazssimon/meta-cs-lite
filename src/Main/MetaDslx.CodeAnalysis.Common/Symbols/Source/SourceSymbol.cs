using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceSymbol : Symbol, ISourceSymbol, IModelSymbol
    {
        private readonly MergedDeclaration _declaration;
        private readonly IModelObject _modelObject;

        public SourceSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container)
        {
            _declaration = declaration;
            _modelObject = modelObject;
        }

        public MetaDslx.Modeling.Model Model => _modelObject.Model;
        public IModelObject ModelObject => _modelObject;

        public new SourceModuleSymbol ContainingModule => (SourceModuleSymbol)base.ContainingModule;
        protected SourceSymbolFactory SymbolFactory => ContainingModule.SymbolFactory;
        public MergedDeclaration Declaration => _declaration;
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
        public override ImmutableArray<Location> Locations => _declaration.NameLocations.Cast<SourceLocation, Location>();
        ImmutableArray<SourceLocation> ISourceSymbol.Locations => _declaration.NameLocations;
        public Type ModelObjectType => _declaration.ModelObjectType;

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

        protected override void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolFactory.ComputeNonSymbolProperties(this, diagnostics, cancellationToken);
        }
    }
}
