using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Parsers.Antlr;
using Antlr4.Runtime;

#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Compiler.Syntax.InternalSyntax
{
    public partial class SymbolInternalSyntaxFactory : IAntlrSyntaxFactory
    {
        AntlrLexer IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream input)
        {
            return new SymbolLexer(input);
        }

        AntlrParser IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream input)
        {
            return new SymbolParser(input);
        }
    }
}
