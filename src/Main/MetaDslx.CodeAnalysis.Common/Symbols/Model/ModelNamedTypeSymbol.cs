using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelNamedTypeSymbol : NamedTypeSymbol
    {
        private IModelObject _modelObject;

        public ModelNamedTypeSymbol(IModelObject modelObject)
        {
            _modelObject = modelObject;
        }

        public IModelObject ModelObject => _modelObject;
    }
}
