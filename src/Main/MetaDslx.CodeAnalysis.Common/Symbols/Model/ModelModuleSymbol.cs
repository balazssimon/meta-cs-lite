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
        private readonly MetaDslx.Modeling.Model _model;

        public ModelModuleSymbol(ModelSymbolFactory symbolFactory, MetaDslx.Modeling.Model model)
            : base(null)
        {
            _model = model;
            _symbolFactory = symbolFactory;
        }

        public ModelSymbolFactory SymbolFactory => _symbolFactory;
        public MetaDslx.Modeling.Model Model => _model;
        public IModelObject ModelObject => null;
        public Type ModelObjectType => default;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

        protected override NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var rootObjects = _model.ModelObjects.Where(obj => obj.Parent is null).Take(2).ToArray();
            if (rootObjects.Length == 1 && string.IsNullOrEmpty(rootObjects[0].Name) && 
                rootObjects[0].SymbolType.IsAssignableTo(typeof(NamespaceSymbol)))
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
