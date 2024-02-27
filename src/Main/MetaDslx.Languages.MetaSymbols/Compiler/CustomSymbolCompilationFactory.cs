using MetaDslx.CodeAnalysis.Symbols.CSharp;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaSymbols.Compiler
{
    internal class CustomSymbolCompilationFactory : SymbolCompilationFactory
    {
        public override CSharpSymbolFactory CreateCSharpSymbolFactory()
        {
            return new CSharpSymbolFactory(ImmutableArray.Create(new SymbolModelFactory()));
        }
    }
}
