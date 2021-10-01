using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class AbstractParser : IDisposable
    {
        public readonly Language Language;
        public readonly ParseOptions ParseOptions;
        protected readonly AbstractLexer Lexer;
        private Lazy<ParserStateManager?> _stateManager;

        public AbstractParser(AbstractLexer lexer)
        {
            Language = lexer.Language;
            Lexer = lexer;
            ParseOptions = lexer.ParseOptions;
            _stateManager = new Lazy<ParserStateManager?>(CreateStateManager, false);
        }

        protected ParserStateManager? StateManager => _stateManager.Value;

        public abstract int Position { get; }

        public abstract ParserState? State { get; }

        public void Dispose()
        {
            Lexer.Dispose();
        }

        public abstract InternalSyntaxNode Parse();

        public abstract (InternalSyntaxNode?, IncrementalNodeData) IncrementalParse();

        protected abstract ParserStateManager? CreateStateManager();
    }
}
