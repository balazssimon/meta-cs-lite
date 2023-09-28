using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class SyntaxParser : IDisposable
    {
        public readonly Language Language;
        public readonly ParseOptions ParseOptions;
        protected readonly SyntaxLexer Lexer;
        private CancellationToken _cancellationToken;
        private IncrementalParseData _parseData;

        public SyntaxParser(SyntaxLexer lexer, IncrementalParseData? oldParseData, IEnumerable<TextChangeRange>? changes, CancellationToken cancellationToken)
        {
            Language = lexer.Language;
            Lexer = lexer;
            ParseOptions = lexer.ParseOptions;
            _cancellationToken = cancellationToken;
            _parseData = ComputeIncrementalParseData(oldParseData, changes);
        }

        public CancellationToken CancellationToken => _cancellationToken;

        protected ParserStateManager? StateManager => _parseData.ParserStateManager;

        public abstract int Position { get; }

        public abstract ParserState? State { get; }

        public void Dispose()
        {
            Lexer.Dispose();
        }

        public IncrementalParseData Parse()
        {
            var rootNode = ParseRoot();
            _parseData.RootNode = rootNode;
            _parseData.LexerLookAhead = Lexer.LookAhead;
            _parseData.LexerLookBack = Lexer.LookBack;
            return _parseData;
        }

        protected abstract SyntaxNode ParseRoot();

        protected abstract ParserStateManager? CreateStateManager();

        private IncrementalParseData ComputeIncrementalParseData(IncrementalParseData? oldParseData, IEnumerable<TextChangeRange>? changes)
        {
            if (oldParseData is not null)
            {
                return new IncrementalParseData(oldParseData);
            }
            else
            {
                return new IncrementalParseData(1, Lexer.StateManager, CreateStateManager(), DirectiveStack.Empty, 0, 0, new ConditionalWeakTable<GreenNode, IncrementalNodeData>());
            }
        }
    }
}
