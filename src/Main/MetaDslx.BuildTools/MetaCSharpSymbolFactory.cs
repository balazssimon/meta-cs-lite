using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Languages.MetaSymbols.Compiler;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.BuildTools
{
    internal class MetaCSharpSymbolFactory : CSharpSymbolFactory
    {
        public MetaCSharpSymbolFactory() 
            : base(ImmutableArray.Create<CSharpModelFactory>(new SymbolCSharpModelFactory()))
        {
        }
    }
}
