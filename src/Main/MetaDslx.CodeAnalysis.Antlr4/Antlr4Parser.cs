using Antlr4.Runtime;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public abstract class Antlr4Parser : Parser
    {
        internal Antlr4SyntaxParser _incrementalParser;

        public Antlr4Parser(ITokenStream input, TextWriter output, TextWriter errorOutput)
            : base(input, output, errorOutput)
        {
        }

        protected Antlr4SyntaxParser IncrementalAntlr4Parser => _incrementalParser;

        public override void NotifyErrorListeners(IToken offendingToken, string msg, RecognitionException e)
        {
            /*if (_incrementalParser == null && e is NoViableAltException nvae) base.NotifyErrorListeners(nvae.StartToken, msg, e); 
            else*/ base.NotifyErrorListeners(offendingToken, msg, e);
        }
    }
}
