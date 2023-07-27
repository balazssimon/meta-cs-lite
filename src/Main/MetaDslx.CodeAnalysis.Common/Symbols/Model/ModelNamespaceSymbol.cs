using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelNamespaceSymbol : NamespaceSymbol, IModelSymbol
    {
        private IModelObject _modelObject;

        public ModelNamespaceSymbol(Symbol container, IModelObject modelObject)
            : base(container)
        {
            _modelObject = modelObject;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(ContainingModule);

        public ModelSymbolFactory SymbolFactory => ((ModelModuleSymbol)ContainingModule).SymbolFactory;
        public IModelObject ModelObject => _modelObject;
        public IModel Model => _modelObject.Model;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

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
            return SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(_modelObject, nameof(Members));
        }
    }
}
