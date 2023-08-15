using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelDeclaredSymbol : DeclaredSymbol, IModelSymbol
    {
        private IModelObject _modelObject;

        public ModelDeclaredSymbol(Symbol container, IModelObject modelObject)
            : base(container)
        {
            _modelObject = modelObject;
        }

        public ModelSymbolFactory SymbolFactory => ((ModelModuleSymbol)ContainingModule).SymbolFactory;
        public IModelObject ModelObject => _modelObject;
        public IModel Model => _modelObject.Model;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public Type ModelObjectType => _modelObject.MetaType;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _modelObject.Name;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<Symbol>(_modelObject.Children);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(_modelObject, nameof(Members), diagnostics, cancellationToken);
        }
    }
}
