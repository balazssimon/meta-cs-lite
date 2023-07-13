using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModel
{
    public class MetaModelModuleSymbol : ModuleSymbol
    {
        private IMetaModel _metaModel;

        public MetaModelModuleSymbol(IMetaModel metaModel)
        {
            _metaModel = metaModel;
        }

        public IMetaModel MetaModel => _metaModel;
    }
}
