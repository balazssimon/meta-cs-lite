using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using Antlr4.Runtime;

#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Compiler.Syntax.InternalSyntax
{
    public partial class MetaInternalSyntaxFactory : IAntlrSyntaxFactory
    {
        AntlrLexer IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream input)
        {
            return new MetaLexer(input);
        }

        AntlrParser IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream input)
        {
            return new MetaParser(input);
        }
    }
}
