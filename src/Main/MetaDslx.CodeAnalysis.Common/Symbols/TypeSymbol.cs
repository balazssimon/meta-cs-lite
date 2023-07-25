using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class TypeSymbol : DeclaredSymbol
    {
        protected TypeSymbol(Symbol container)
            : base(container)
        {
        }
    }
}
