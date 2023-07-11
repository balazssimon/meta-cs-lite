using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelNamespaceSymbol : NamespaceSymbol
    {
        private IModelObject _modelObject;

        public ModelNamespaceSymbol(IModelObject modelObject)
        {
            _modelObject = modelObject;
        }

        public IModelObject ModelObject => _modelObject;
    }
}
