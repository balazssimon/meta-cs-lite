using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class NamedTypeSymbol : TypeSymbol
    {
        protected NamedTypeSymbol(Symbol container) 
            : base(container)
        {
        }
    }
}
