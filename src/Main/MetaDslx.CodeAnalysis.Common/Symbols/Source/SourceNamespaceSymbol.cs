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
        private readonly ModuleSymbol _module;

        public SourceNamespaceSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container)
        {
            _declaration = declaration;
            _modelObject = modelObject;
            _module = container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(_module);

        public IModel Model => _modelObject.Model;
        public IModelObject ModelObject => _modelObject;

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
            return ((SourceModuleSymbol)ContainingModule).SymbolFactory.CreateContainedSymbols(this);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (this.IsGlobalNamespace) return ContainedSymbols.OfType<DeclaredSymbol>().ToImmutableArray();
            else return ((SourceModuleSymbol)ContainingModule).SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(this, nameof(Members), diagnostics, cancellationToken);
        }
    }
}
