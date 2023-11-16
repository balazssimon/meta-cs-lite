using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    public interface IMetaTypeSymbol : IMetaSymbol
    {
        MetaType MetaType { get; }
    }
}
