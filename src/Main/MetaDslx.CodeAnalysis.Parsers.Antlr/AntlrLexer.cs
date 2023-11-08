using Antlr4.Runtime;
using Antlr4.Runtime.Atn;
using Antlr4.Runtime.Misc;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MetaDslx.CodeAnalysis.Parsers.Antlr
{
    public abstract class AntlrLexer : Lexer
    {
        protected AntlrLexer(ICharStream input, TextWriter output, TextWriter errorOutput)
            : base(input, output, errorOutput)
        {
        }

    }

}
