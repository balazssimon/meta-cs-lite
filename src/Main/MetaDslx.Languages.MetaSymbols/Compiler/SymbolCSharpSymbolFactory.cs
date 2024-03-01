using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    internal class SymbolCSharpSymbolFactory : CSharpSymbolFactory
    {
        public SymbolCSharpSymbolFactory()
            : base(ImmutableArray.Create(new SymbolCSharpModelFactory()))
        {
        }
    }
}
