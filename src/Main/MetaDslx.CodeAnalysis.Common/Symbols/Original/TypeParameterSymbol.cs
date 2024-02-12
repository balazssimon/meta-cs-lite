using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class TypeParameterSymbol : TypeSymbol
    {
        protected TypeParameterSymbol(Symbol container) 
            : base(container)
        {
        }
    }
}
