using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelMemberSymbol : MemberSymbol
    {
        private IModelObject _modelObject;

        public ModelMemberSymbol(IModelObject modelObject)
        {
            _modelObject = modelObject;
        }

        public IModelObject ModelObject => _modelObject;
    }
}
