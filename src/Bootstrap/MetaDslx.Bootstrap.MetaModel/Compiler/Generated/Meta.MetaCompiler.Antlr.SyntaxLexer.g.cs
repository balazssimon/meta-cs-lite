using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeAnalysis.Parsers.Antlr;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{
    public partial class MetaSyntaxLexer : AntlrSyntaxLexer
    {
        public MetaSyntaxLexer(SourceText text, MetaParseOptions options) 
            : base(text, options)
        {
        }

        protected new MetaLexer AntlrLexer => (MetaLexer)base.AntlrLexer;

    }
}
