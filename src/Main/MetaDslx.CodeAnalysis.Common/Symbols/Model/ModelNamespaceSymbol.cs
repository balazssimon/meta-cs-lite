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
        private ModuleSymbol _module;

        public ModelNamespaceSymbol(Symbol container, IModelObject modelObject)
            : base(container)
        {
            _modelObject = modelObject;
            _module = container is ModuleSymbol moduleSymbol ? moduleSymbol : container.ContainingModule;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(_module);

        public IModelObject ModelObject => _modelObject;
        public IModel Model => _modelObject.Model;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _modelObject.Name;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ((ModelModuleSymbol)ContainingModule).SymbolFactory.GetSymbols<Symbol>(_modelObject.Children);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ((ModelModuleSymbol)ContainingModule).SymbolFactory.GetSymbolPropertyValues<DeclaredSymbol>(_modelObject, nameof(Members));
        }
    }
}
