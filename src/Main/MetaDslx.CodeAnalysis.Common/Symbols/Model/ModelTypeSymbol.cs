using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelTypeSymbol : TypeSymbol, IModelSymbol
    {
        private IModelObject _modelObject;

        public ModelTypeSymbol(Symbol container, IModelObject modelObject)
            : base(container)
        {
            _modelObject = modelObject;
        }

        public ModelSymbolFactory SymbolFactory => ((ModelModuleSymbol)ContainingModule).SymbolFactory;
        public IModelObject ModelObject => _modelObject;
        public MetaDslx.Modeling.Model Model => _modelObject.MModel;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public Type ModelObjectType => _modelObject.MInfo.MetaType.AsType(tryResolveType: false);

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _modelObject.MName;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<string>(_modelObject, nameof(MetadataName), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateChildSymbols(_modelObject);
        }

        protected override ImmutableArray<DeclarationSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetMemberSymbols(_modelObject);
        }

        protected override ImmutableArray<TypeSymbol> CompleteProperty_TypeArguments(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(_modelObject, nameof(TypeArguments), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<AttributeSymbol>(_modelObject, nameof(Attributes), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<TypeParameterSymbol> CompleteProperty_TypeParameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<TypeParameterSymbol>(_modelObject, nameof(TypeParameters), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<TypeSymbol> CompleteProperty_BaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(_modelObject, nameof(BaseTypes), diagnostics, cancellationToken);
        }
    }
}
