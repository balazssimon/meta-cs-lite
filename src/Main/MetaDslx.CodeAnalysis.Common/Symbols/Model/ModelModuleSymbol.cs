using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelModuleSymbol : ModuleSymbol, IModelSymbol
    {
        private readonly ModelSymbolFactory _symbolFactory;
        private readonly IModel _model;

        public ModelModuleSymbol(ModelSymbolFactory symbolFactory, IModel model)
            : base(null)
        {
            _model = model;
            _symbolFactory = symbolFactory;
        }

        public ModelSymbolFactory SymbolFactory => _symbolFactory;
        public IModel Model => _model;
        public IModelObject ModelObject => null;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

        protected override NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var rootObjects = _model.Objects.Where(obj => obj.Parent is null).Take(2).ToArray();
            if (rootObjects.Length == 1 && string.IsNullOrEmpty(rootObjects[0].Name) && 
                rootObjects[0].SymbolType is not null && typeof(NamespaceSymbol).IsAssignableFrom(rootObjects[0].SymbolType))
            {
                return _symbolFactory.GetSymbol<NamespaceSymbol>(rootObjects[0]);
            }
            else
            {
                return new ModelRootNamespaceSymbol(this, _model);
            }
        }
    }
}
