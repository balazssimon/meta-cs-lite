﻿using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public interface IAntlr4SyntaxFactory
    {
        Antlr4Lexer CreateAntlr4Lexer(ICharStream input);
        Antlr4Parser CreateAntlr4Parser(ITokenStream input);
    }
}
