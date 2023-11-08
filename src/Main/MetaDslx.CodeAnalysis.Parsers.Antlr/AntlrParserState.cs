using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Parsers.Antlr
{
    public class AntlrParserState : ParserState
    {
        public readonly int State;

        public AntlrParserState(int hashCode, int state)
            : base(hashCode)
        {
            State = state;
        }

        public override string ToString()
        {
            return $"state={State}";
        }
    }
}
