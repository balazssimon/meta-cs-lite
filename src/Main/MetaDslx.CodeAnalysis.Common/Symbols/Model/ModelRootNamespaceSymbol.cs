using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelRootNamespaceSymbol : NamespaceSymbol
    {
        private IModel _model;

        public ModelRootNamespaceSymbol(Symbol container, IModel model)
            : base(container)
        {
            _model = model;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(ContainingModule);

        public ModelSymbolFactory SymbolFactory => ((ModelModuleSymbol)ContainingModule).SymbolFactory;
        public IModelObject ModelObject => null;
        public IModel Model => _model;

        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return string.Empty;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<Symbol>(_model.Objects.Where(mo => mo.Parent is null));
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<DeclaredSymbol>(_model.Objects.Where(mo => mo.Parent is null));
        }
    }
}
