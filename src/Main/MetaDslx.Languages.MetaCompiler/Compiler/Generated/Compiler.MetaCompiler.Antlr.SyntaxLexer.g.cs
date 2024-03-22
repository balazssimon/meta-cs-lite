using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeAnalysis.Parsers.Antlr;

#pragma warning disable CS8669

namespace MetaDslx.Languages.MetaCompiler.Compiler.Syntax
{
    public partial class CompilerSyntaxLexer : AntlrSyntaxLexer
    {
        public CompilerSyntaxLexer(SourceText text, CompilerParseOptions options) 
            : base(text, options)
        {
        }

        protected new CompilerLexer AntlrLexer => (CompilerLexer)base.AntlrLexer;

    }
}
