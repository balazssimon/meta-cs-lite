using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

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

        public IModelObject ModelObject => _modelObject;
        public IModel Model => _modelObject.Model;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;

    }
}
