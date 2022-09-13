using Antlr4.Runtime;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public abstract class Antlr4SyntaxParser : SyntaxParser, IAntlrErrorListener<IToken>
    {
        private readonly Antlr4LexerBasedTokenStream _tokenStream;
        private readonly Antlr4Parser _parser;
        private readonly Dictionary<RuleContext, GreenNode> _nodeCache;

        protected Antlr4SyntaxParser(Antlr4SyntaxLexer lexer, SyntaxNode? oldTree, ParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken)
            : base(lexer, oldTree, oldParseData, changes, cancellationToken)
        {
            _tokenStream = new Antlr4LexerBasedTokenStream(lexer);
            _parser = ((IAntlr4SyntaxFactory)Language.InternalSyntaxFactory).CreateAntlr4Parser(_tokenStream);
            _parser.RemoveErrorListeners();
            _parser.AddErrorListener(this);
            _parser.ErrorHandler = new DefaultErrorStrategy();
            _nodeCache = new Dictionary<RuleContext, GreenNode>();
        }

        public Antlr4Parser Antlr4Parser => _parser;
        public new Antlr4SyntaxLexer Lexer => (Antlr4SyntaxLexer)base.Lexer;

        public bool IsIncremental => false;
        public SyntaxNode? CurrentNode => null;

        protected void BeginRoot()
        {
        }

        protected void EndRoot(ref GreenNode green)
        {
        }

        protected void BeginNode()
        {
        }

        protected void EndNode(ref GreenNode green)
        {
        }

        protected GreenNode EatNode()
        {
            return null;
        }

        protected GreenNode EatToken()
        {
            return null;
        }

        protected void RestoreParserState(ParserState state)
        {

        }

        protected void CacheGreenNode(RuleContext context, GreenNode green)
        {
            _nodeCache.Add(context, green);
        }

        protected bool TryGetGreenNode(RuleContext context, out GreenNode green)
        {
            return _nodeCache.TryGetValue(context, out green);
        }

        public override (SyntaxNode?, IncrementalNodeData) IncrementalParse()
        {
            throw new NotImplementedException();
        }

        protected override ParserStateManager? CreateStateManager()
        {
            return new Antlr4ParserStateManager(this);
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
            this.AddError(new SyntaxDiagnosticInfo(position, width, ErrorCode.ERR_SyntaxError, msg));
        }

        public InternalSyntaxToken ConsumeRealToken(Antlr4SyntaxToken token)
        {
            return _tokenStream.ConsumeRealToken(token, this);
        }

        public InternalSyntaxToken ConsumeMissingToken(int rawKind)
        {
            return _tokenStream.ConsumeMissingToken(rawKind, this);
        }

        protected class Antlr4ParserStateManager : ParserStateManager
        {
            public Antlr4ParserStateManager(Antlr4SyntaxParser parser)
                : base(parser)
            {
            }

            public new Antlr4SyntaxParser Parser => (Antlr4SyntaxParser)base.Parser;
            public Antlr4Parser Antlr4Parser => Parser.Antlr4Parser;

            protected override int ComputeStateHash()
            {
                return this.Antlr4Parser.State.GetHashCode();
            }

            protected override bool IsInState(ParserState? state)
            {
                var antlr4Parser = Antlr4Parser;
                if (state == null) return antlr4Parser.State == -1;
                var antlr4State = (Antlr4ParserState)state;
                if (antlr4Parser.State != antlr4State.State) return false;
                return true;
            }

            protected override void RestoreState(ParserState? state)
            {
                var antlr4State = state as Antlr4ParserState;
                var antlr4Parser = Antlr4Parser;
                if (antlr4State != null)
                {
                    antlr4Parser.State = antlr4State.State;
                }
                else
                {
                    antlr4Parser.State = -1;
                }
            }

            protected override ParserState? SaveState(int hashCode)
            {
                var antlr4Parser = Antlr4Parser;
                if (antlr4Parser.State == -1) return null;
                else return new Antlr4ParserState(hashCode, antlr4Parser.State);
            }
        }

    }
}
