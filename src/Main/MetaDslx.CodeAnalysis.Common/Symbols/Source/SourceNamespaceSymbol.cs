using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceNamespaceSymbol : NamespaceSymbol, ISourceSymbol
    {
        private readonly MergedDeclaration _declaration;
        private readonly IModelObject _modelObject;

        public SourceNamespaceSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container)
        {
            _declaration = declaration;
            _modelObject = modelObject;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(ContainingModule);

        public IModel Model => _modelObject.Model;
        public IModelObject ModelObject => _modelObject;

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
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            // TODO: make a SymbolFactory class to create symbols
            foreach (var childDecl in _declaration.Children)
            {
                
            }
            return symbols.ToImmutableAndFree();
        }
    }
}
