using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    internal class MetaClassSymbol : MetaTypeSymbol
    {
        public MetaClassSymbol(DeclaredSymbol container, MetaModel metaModel, MetaType metaType)
            : base(container, metaModel, metaType)
        {
        }
    }
}
