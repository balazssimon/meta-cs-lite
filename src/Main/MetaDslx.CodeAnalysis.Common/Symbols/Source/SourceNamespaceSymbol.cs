using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceNamespaceSymbol : NamespaceSymbol, ISourceSymbol, IModelSymbol
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
        public override ModuleSymbol ContainingModule => _module;

        public MetaDslx.Modeling.Model Model => _modelObject.Model;
        public IModelObject ModelObject => _modelObject;

        public MergedDeclaration Declaration => _declaration;
        protected SourceSymbolFactory SymbolFactory => ((SourceModuleSymbol)ContainingModule).SymbolFactory;
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
            return SymbolFactory.CreateContainedSymbols(this);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetMemberSymbols(this);
        }

        protected override ImmutableArray<ImportSymbol> CompleteProperty_Imports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetImportSymbols(this);
        }

        protected override ImmutableArray<TypeSymbol> CompleteProperty_TypeArguments(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(this, nameof(TypeArguments), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<AttributeSymbol>(this, nameof(Attributes), diagnostics, cancellationToken);
        }

        protected override void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolFactory.ComputeNonSymbolProperties(this, diagnostics, cancellationToken);
        }
    }
}
