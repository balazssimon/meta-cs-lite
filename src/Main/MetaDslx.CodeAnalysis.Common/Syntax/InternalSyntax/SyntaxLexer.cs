using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class SyntaxLexer : IDisposable
    {
        public readonly Language Language;
        public readonly ParseOptions ParseOptions;
        protected readonly SlidingTextWindow TextWindow;
        private LexerStateManager? _stateManager;

        protected SyntaxLexer(SourceText text, ParseOptions parseOptions)
        {
            Language = parseOptions.Language;
            TextWindow = new SlidingTextWindow(text);
            ParseOptions = parseOptions;
            _stateManager = CreateStateManager();
        }

        internal protected LexerStateManager? StateManager => _stateManager;

        public SourceText SourceText => TextWindow.SourceText;

        public abstract int Position { get; }

        public abstract LexerState? State { get; }

        public abstract int LookAhead { get; }

        public abstract int LookBack { get; }

        public virtual void Dispose()
        {
            this.TextWindow.Dispose();
        }

        public abstract (InternalSyntaxToken? NextToken, IncrementalTokenData IncrementalTokenData) Lex();

        protected abstract LexerStateManager? CreateStateManager();

        public void ResetTo(int position, LexerState? state)
        {
            TextWindow.ResetTo(position);
            StateManager?.InternalRestoreState(state);
        }
    }
}
