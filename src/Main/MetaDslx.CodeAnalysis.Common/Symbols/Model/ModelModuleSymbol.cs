using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelModuleSymbol : ModuleSymbol
    {
        private IModel _model;

        public ModelModuleSymbol(IModel model)
        {
            _model = model;
        }

        public IModel Model => _model;
    }
}
