using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class AssemblySymbol : Symbol
    {
        protected AssemblySymbol() 
            : base(null)
        {
        }

        public abstract ImmutableArray<ModuleSymbol> Modules { get; }

        public virtual bool IsCorLibrary => false;
    }
}
