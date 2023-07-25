using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class AssemblySymbol : Symbol
    {
        protected AssemblySymbol() 
            : base(null)
        {
        }
    }
}
