using MetaDslx.CodeAnalysis.Symbols.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class CustomCompilerSourceSymbolFactory : SourceSymbolFactory
    {
        public CustomCompilerSourceSymbolFactory(SourceModuleSymbol module) 
            : base(module)
        {
            Register<ParserRuleSymbol>((s, d, mo) => new ParserRuleSymbol(s, d, mo));
            Register<PElementSymbol>((s, d, mo) => new PElementSymbol(s, d, mo));
        }
    }
}
