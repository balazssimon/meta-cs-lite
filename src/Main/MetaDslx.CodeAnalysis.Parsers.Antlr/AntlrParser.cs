using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MetaDslx.CodeAnalysis.Parsers.Antlr
{
    public abstract class AntlrParser : Parser
    {
        internal AntlrSyntaxParser _incrementalParser;

        public AntlrParser(ITokenStream input, TextWriter output, TextWriter errorOutput)
            : base(input, output, errorOutput)
        {
        }

        protected AntlrSyntaxParser IncrementalAntlrParser => _incrementalParser;

        public override void NotifyErrorListeners(IToken offendingToken, string msg, RecognitionException e)
        {
            /*if (_incrementalParser == null && e is NoViableAltException nvae) base.NotifyErrorListeners(nvae.StartToken, msg, e); 
            else*/ base.NotifyErrorListeners(offendingToken, msg, e);
        }
    }
}
