﻿using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelDeclarationSymbol : DeclarationSymbol, IModelSymbol
    {
        private IModelObject _modelObject;

        public ModelDeclarationSymbol(Symbol container, IModelObject modelObject)
            : base(container)
        {
            _modelObject = modelObject;
        }

        public ModelSymbolFactory SymbolFactory => ((ModelModuleSymbol)ContainingModule).SymbolFactory;
        public IModelObject ModelObject => _modelObject;
        public MetaDslx.Modeling.Model Model => _modelObject.Model;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public Type ModelObjectType => _modelObject.MetaType.AsType(tryResolveType: false);

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _modelObject.Name;
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
    }
}