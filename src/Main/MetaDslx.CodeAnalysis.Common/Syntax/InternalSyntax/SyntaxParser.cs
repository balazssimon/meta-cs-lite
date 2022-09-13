using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Linq;
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
        private List<SyntaxDiagnosticInfo> _errors;

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
            _errors = new List<SyntaxDiagnosticInfo>();
        }

        public CancellationToken CancellationToken => _cancellationToken;

        public override int Position => _position;

        public override ParserState? State => _state;

        public ParseData ParseData => _parseData;

        public IEnumerable<SyntaxDiagnosticInfo> Errors => _errors;

        protected void AddError(SyntaxDiagnosticInfo error)
        {
            _errors.Add(error);
        }

        public SyntaxDiagnosticInfo[]? GetErrorsForToken(int position, InternalSyntaxToken token)
        {
            var errors = _errors.Where(error => error.Offset >= position && (error.Offset < position + token.FullWidth || token.RawKind == (int)InternalSyntaxKind.Eof));
            errors = errors.Select(error => error.WithOffset(error.Offset - position));
            if (errors.Any()) return errors.ToArray();
            else return null;
        }
    }
}
