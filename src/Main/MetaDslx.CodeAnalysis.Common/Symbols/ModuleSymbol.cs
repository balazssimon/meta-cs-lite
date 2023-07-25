using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class ModuleSymbol : Symbol
    {
        protected ModuleSymbol(Symbol container) 
            : base(container)
        {
        }
    }
}
