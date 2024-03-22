using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeAnalysis.Parsers.Antlr;

#pragma warning disable CS8669

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax
{
    public partial class SymbolSyntaxLexer : AntlrSyntaxLexer
    {
        public SymbolSyntaxLexer(SourceText text, SymbolParseOptions options) 
            : base(text, options)
        {
        }

        protected new SymbolLexer AntlrLexer => (SymbolLexer)base.AntlrLexer;

    }
}
