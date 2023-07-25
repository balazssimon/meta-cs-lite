using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class NamespaceSymbol : DeclaredSymbol
    {
        protected NamespaceSymbol(Symbol container) 
            : base(container)
        {
        }
    }
}
