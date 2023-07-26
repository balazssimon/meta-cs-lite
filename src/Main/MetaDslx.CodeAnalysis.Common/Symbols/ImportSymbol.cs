using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class ImportSymbol : DeclaredSymbol
    {
        protected ImportSymbol(Symbol container) 
            : base(container)
        {
        }
    }
}
