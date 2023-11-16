using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    internal class MetaEnumSymbol : MetaTypeSymbol
    {
        public MetaEnumSymbol(DeclaredSymbol container, MetaModel metaModel, MetaType metaType) 
            : base(container, metaModel, metaType)
        {
        }
    }
}
