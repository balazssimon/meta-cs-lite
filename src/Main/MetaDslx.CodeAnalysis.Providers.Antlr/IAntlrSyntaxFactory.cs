using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public interface IAntlrSyntaxFactory
    {
        AntlrLexer CreateAntlrLexer(ICharStream input);
        AntlrParser CreateAntlrParser(ITokenStream input);
    }
}
