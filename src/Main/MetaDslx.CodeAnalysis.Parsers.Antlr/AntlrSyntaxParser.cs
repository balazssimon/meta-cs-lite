using Antlr4.Runtime;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Parsers.Antlr
{
    public abstract class AntlrSyntaxParser : SyntaxParser, IAntlrErrorListener<IToken>
    {
        private readonly AntlrTokenStream _tokenStream;
        private readonly AntlrParser _parser;
        private List<SyntaxDiagnosticInfo> _diagnostics;
        private readonly Dictionary<RuleContext, GreenNode> _nodeCache;

        protected AntlrSyntaxParser(AntlrSyntaxLexer lexer, IncrementalParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken)
            : base(lexer, oldParseData, changes, cancellationToken)
        {
            _diagnostics = new List<SyntaxDiagnosticInfo>();
            _tokenStream = new AntlrTokenStream(lexer);
            _parser = ((IAntlrSyntaxFactory)Language.InternalSyntaxFactory).CreateAntlrParser(_tokenStream);
            _parser.RemoveErrorListeners();
            _parser.AddErrorListener(this);
            _parser.ErrorHandler = new DefaultErrorStrategy();
            _nodeCache = new Dictionary<RuleContext, GreenNode>();
        }

        public AntlrParser AntlrParser => _parser;

        public new AntlrSyntaxLexer Lexer => (AntlrSyntaxLexer)base.Lexer;

        public override int Position => 0;

        public override ParserState? State => null;

        public List<SyntaxDiagnosticInfo> Diagnostics => _diagnostics;

        protected void CacheGreenNode(RuleContext context, GreenNode green)
        {
            _nodeCache.Add(context, green);
        }

        protected bool TryGetGreenNode(RuleContext context, out GreenNode green)
        {
            return _nodeCache.TryGetValue(context, out green);
        }

        protected override SyntaxNode ParseRoot()
        {
            throw new NotImplementedException();
        }

        protected override ParserStateManager? CreateStateManager()
        {
            return new AntlrParserStateManager(this);
        }

        public void SyntaxError(TextWriter output, IRecognizer recognizer, IToken offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            IToken startToken;
            IToken endToken;
            if (e is NoViableAltException nvae)
            {
                startToken = nvae.StartToken;
                endToken = nvae.OffendingToken;
            }
            else
            {
                startToken = offendingSymbol;
                endToken = offendingSymbol;
            }
            var position = startToken.StartIndex;
            var width = Math.Max(endToken.StopIndex - startToken.StartIndex + 1, 0);
            _diagnostics.Add(new SyntaxDiagnosticInfo(position, width, ErrorCode.ERR_SyntaxError, msg));
        }

        protected class AntlrParserStateManager : ParserStateManager
        {
            public AntlrParserStateManager(AntlrSyntaxParser parser)
                : base(parser)
            {
            }

            public new AntlrSyntaxParser Parser => (AntlrSyntaxParser)base.Parser;
            public AntlrParser AntlrParser => Parser.AntlrParser;

            protected override int ComputeStateHash()
            {
                return this.AntlrParser.State.GetHashCode();
            }

            protected override bool IsInState(ParserState? state)
            {
                var antlrParser = AntlrParser;
                if (state == null) return antlrParser.State == -1;
                var antlrState = (AntlrParserState)state;
                if (antlrParser.State != antlrState.State) return false;
                return true;
            }

            protected override void RestoreState(ParserState? state)
            {
                var antlrState = state as AntlrParserState;
                var antlrParser = AntlrParser;
                if (antlrState != null)
                {
                    antlrParser.State = antlrState.State;
                }
                else
                {
                    antlrParser.State = -1;
                }
            }

            protected override ParserState? SaveState(int hashCode)
            {
                var antlrParser = AntlrParser;
                if (antlrParser.State == -1) return null;
                else return new AntlrParserState(hashCode, antlrParser.State);
            }
        }

    }
}
