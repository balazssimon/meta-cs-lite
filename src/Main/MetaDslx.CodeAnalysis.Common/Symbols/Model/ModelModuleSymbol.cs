using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelModuleSymbol : ModuleSymbol, IModelSymbol
    {
        private IModel _model;

        public ModelModuleSymbol(IModel model)
            : base(null)
        {
            _model = model;
        }

        public IModel Model => _model;

        public IModelObject ModelObject => null;

        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

    }
}
