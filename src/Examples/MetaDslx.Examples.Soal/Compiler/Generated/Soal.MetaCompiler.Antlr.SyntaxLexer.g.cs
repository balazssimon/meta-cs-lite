using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeAnalysis.Parsers.Antlr;

#nullable enable

namespace MetaDslx.Examples.Soal.Compiler.Syntax
{
    public partial class SoalSyntaxLexer : AntlrSyntaxLexer
    {
        public SoalSyntaxLexer(SourceText text, SoalParseOptions options) 
            : base(text, options)
        {
        }

        protected new SoalLexer AntlrLexer => (SoalLexer)base.AntlrLexer;

    }
}
