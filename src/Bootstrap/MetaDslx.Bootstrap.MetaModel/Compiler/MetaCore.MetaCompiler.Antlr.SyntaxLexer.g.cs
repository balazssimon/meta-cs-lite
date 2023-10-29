using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Antlr;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax
{
    public partial class MetaCoreSyntaxLexer : AntlrSyntaxLexer
    {
        public MetaCoreSyntaxLexer(SourceText text, MetaCoreParseOptions options) 
            : base(text, options)
        {
        }

        protected new MetaCoreLexer AntlrLexer => (MetaCoreLexer)base.AntlrLexer;

    }
}
