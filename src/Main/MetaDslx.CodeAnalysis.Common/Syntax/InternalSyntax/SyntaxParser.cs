using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class SyntaxParser : AbstractParser
    {
        private CancellationToken _cancellationToken;
        private int _position;
        private ParserState? _state;
        private ParseData _parseData;

        protected SyntaxParser(SyntaxLexer lexer, SyntaxNode? oldTree, ParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken) 
            : base(lexer)
        {
            _cancellationToken = cancellationToken;
            _position = 0;
            _state = null;
            if (oldParseData is not null)
            {
                _parseData = new ParseData(oldParseData.Version + 1, oldParseData.LexerStateManager, oldParseData.ParserStateManager, oldParseData.Directives, oldParseData.MinLexerLookahead, oldParseData.MaxLexerLookahead, oldParseData.IncrementalData);
            }
            else
            {
                _parseData = new ParseData(1, lexer.StateManager, CreateStateManager(), DirectiveStack.Empty, 0, 0, new ConditionalWeakTable<GreenNode, IncrementalNodeData>());
            }
        }

        public CancellationToken CancellationToken => _cancellationToken;

        public override int Position => _position;

        public override ParserState? State => _state;

        public ParseData ParseData => _parseData;
    }
}
