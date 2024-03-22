using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using Antlr4.Runtime;

#pragma warning disable CS8669

namespace MetaDslx.Examples.Soal.Compiler.Syntax.InternalSyntax
{
    public partial class SoalInternalSyntaxFactory : IAntlrSyntaxFactory
    {
        AntlrLexer IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream input)
        {
            return new SoalLexer(input);
        }

        AntlrParser IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream input)
        {
            return new SoalParser(input);
        }
    }
}
