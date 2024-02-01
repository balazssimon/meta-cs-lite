using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using Antlr4.Runtime;

#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler3.Compiler.Syntax.InternalSyntax
{
    public partial class CompilerInternalSyntaxFactory : IAntlrSyntaxFactory
    {
        AntlrLexer IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream input)
        {
            return new CompilerLexer(input);
        }

        AntlrParser IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream input)
        {
            return new CompilerParser(input);
        }
    }
}
