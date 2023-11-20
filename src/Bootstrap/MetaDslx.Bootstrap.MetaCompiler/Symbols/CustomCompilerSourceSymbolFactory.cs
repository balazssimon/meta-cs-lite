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
            Register((s, d, mo) => new ParserRuleSymbol(s, d, mo));
            Register((s, d, mo) => new PAlternativeSymbol(s, d, mo));
            Register((s, d, mo) => new PElementSymbol(s, d, mo));
            Register((s, d, mo) => new PBlockSymbol(s, d, mo));
            Register((s, d, mo) => new PReferenceSymbol(s, d, mo));
            Register((s, d, mo) => new ExpressionSymbol(s, d, mo));
        }
    }
}
