using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols.Source;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    internal class CustomCompilerSourceSymbolFactory : SourceSymbolFactory
    {
        public CustomCompilerSourceSymbolFactory(Compilation compilation) 
            : base(compilation) 
        {
            /*Register((s, d, mo) => new AnnotationSymbol(s, d, mo));
            Register((s, d, mo) => new AnnotationArgumentSymbol(s, d, mo));
            Register((s, d, mo) => new ParserRuleSymbol(s, d, mo));
            Register((s, d, mo) => new TokenSymbol(s, d, mo));
            Register((s, d, mo) => new PAlternativeSymbol(s, d, mo));
            Register((s, d, mo) => new PElementSymbol(s, d, mo));
            Register((s, d, mo) => new PBlockSymbol(s, d, mo));
            Register((s, d, mo) => new PReferenceSymbol(s, d, mo));
            Register((s, d, mo) => new ExpressionSymbol(s, d, mo));*/
        }
    }
}
