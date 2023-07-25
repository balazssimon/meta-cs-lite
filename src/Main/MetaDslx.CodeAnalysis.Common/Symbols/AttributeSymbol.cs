using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class AttributeSymbol : Symbol
    {
        protected AttributeSymbol(Symbol container) 
            : base(container)
        {
        }
    }
}
