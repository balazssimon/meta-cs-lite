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
        private readonly IModelObject _modelObject;

        internal SourceAliasSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container)
        {
            _declaration = declaration;
            _modelObject = modelObject;
        }

        public IModel Model => _modelObject.Model;
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
            return SymbolFactory.CreateContainedSymbols(this);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetMemberSymbols(this);
        }

        protected override ImmutableArray<TypeSymbol> CompleteProperty_TypeArguments(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(this, nameof(TypeArguments), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<ImportSymbol> CompleteProperty_Imports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<ImportSymbol>(this, nameof(Imports), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<AttributeSymbol>(this, nameof(Attributes), diagnostics, cancellationToken);
        }

        protected override Symbol CompleteProperty_Target(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var values = SymbolFactory.GetSymbolPropertyValues<Symbol>(this, nameof(Target), diagnostics, cancellationToken);
            return values.FirstOrDefault();
        }

        protected override void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            SymbolFactory.ComputeNonSymbolProperties(this, diagnostics, cancellationToken);
        }
    }
}
