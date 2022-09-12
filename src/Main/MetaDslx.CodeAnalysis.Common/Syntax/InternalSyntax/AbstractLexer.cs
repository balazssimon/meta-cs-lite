using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class AbstractLexer : IDisposable
    {
        public readonly Language Language;
        public readonly ParseOptions ParseOptions;
        protected readonly SlidingTextWindow TextWindow;
        private Lazy<LexerStateManager?> _stateManager;

        protected AbstractLexer(SourceText text, ParseOptions parseOptions)
        {
            Language = parseOptions.Language;
            TextWindow = new SlidingTextWindow(text);
            ParseOptions = parseOptions;
            _stateManager = new Lazy<LexerStateManager?>(CreateStateManager, false);
        }

        internal protected LexerStateManager? StateManager => _stateManager.Value;

        public SourceText SourceText => TextWindow.SourceText;

        public abstract int Position { get; }

        public abstract LexerState? State { get; }

        public virtual void Dispose()
        {
            this.TextWindow.Dispose();
        }

        public abstract InternalSyntaxToken? Lex();

        public abstract (InternalSyntaxToken?, IncrementalTokenData) IncrementalLex();

        protected abstract LexerStateManager? CreateStateManager();

        public virtual void ResetTo(int position, LexerState? state)
        {
            TextWindow.ResetTo(position);
            StateManager?.InternalRestoreState(state);
        }
    }
}
