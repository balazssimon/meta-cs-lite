using Antlr4.Runtime;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public abstract class AntlrSyntaxLexer : SyntaxLexer, IAntlrErrorListener<int>
    {
        private readonly AntlrInputStream _stream;
        private readonly AntlrLexer _lexer;
        private readonly SyntaxFacts _syntaxFacts;
        private bool _resetting;
        private bool _hitEof;

        public AntlrSyntaxLexer(SourceText text, ParseOptions options)
            : base(text, options)
        {
            _stream = new AntlrInputStream(this, this.TextWindow);
            _lexer = ((IAntlrSyntaxFactory)Language.InternalSyntaxFactory).CreateAntlrLexer(_stream);
            _lexer.RemoveErrorListeners();
            _lexer.AddErrorListener(this);
            _syntaxFacts = Language.SyntaxFacts;
        }

        public AntlrLexer AntlrLexer => _lexer;

        internal AntlrInputStream InputStream => _stream;

        internal bool Resetting => _resetting;

        protected override (int rawKind, bool isTrivia, bool cache) ScanLexeme()
        {
            var token = _lexer.NextToken();
            var kind = AntlrSyntaxKind.FromAntlr(token.Type);
            if (kind == (int)InternalSyntaxKind.Eof)
            {
                if (_hitEof) return ((int)InternalSyntaxKind.None, false, false);
                else _hitEof = true;
            }
            var cache = _syntaxFacts.IsFixedToken(kind);
            return (kind, token.Channel != 0, cache);
        }

        public void SyntaxError(TextWriter output, IRecognizer recognizer, int offendingSymbol, int line, int charPositionInLine, string msg, RecognitionException e)
        {
            //TextWindow.NextChar();
            this.AddError(new SyntaxDiagnosticInfo(TextWindow.LexemeStartPosition, TextWindow.Width, ErrorCode.ERR_SyntaxError, msg));
            if (TextWindow.Width > 0)
            {
                this.AppendLexeme((int)InternalSyntaxKind.BadToken, true, false);
                this.StartLexeme();
            }
        }

        protected override LexerStateManager? CreateStateManager()
        {
            return new AntlrLexerStateManager(this);
        }

        protected class AntlrLexerStateManager : LexerStateManager
        {
            public AntlrLexerStateManager(AntlrSyntaxLexer lexer)
                : base(lexer)
            {
            }

            public new AntlrSyntaxLexer Lexer => (AntlrSyntaxLexer)base.Lexer;
            public AntlrLexer AntlrLexer => Lexer.AntlrLexer;

            protected override int ComputeStateHash()
            {
                var antlrLexer = AntlrLexer;
                var hash = Hash.Combine(antlrLexer.CurrentMode, antlrLexer.ModeStack.Count);
                foreach (var item in antlrLexer.ModeStack)
                {
                    hash = Hash.Combine(hash, item);
                }
                hash = Hash.Combine(hash, antlrLexer.HitEOF.GetHashCode());
                return hash;
            }

            protected override bool IsInState(LexerState? state)
            {
                var antlrLexer = AntlrLexer;
                if (state == null) return !antlrLexer.HitEOF && antlrLexer.CurrentMode == 0 && antlrLexer.ModeStack.Count == 0;
                var antlrState = (AntlrLexerState)state;
                if (antlrLexer.HitEOF != antlrState.HitEof) return false;
                if (antlrLexer.CurrentMode != antlrState.Mode) return false;
                if (antlrState.ModeStackReversed == null) return antlrLexer.ModeStack.Count == 0;
                if (antlrLexer.ModeStack.Count != antlrState.ModeStackReversed.Length) return false;
                int i = 0;
                foreach (var item in antlrLexer.ModeStack)
                {
                    if (item != antlrState.ModeStackReversed[i]) return false;
                    ++i;
                }
                return true;
            }

            protected override void RestoreState(LexerState? state)
            {
                var antlrState = state as AntlrLexerState;
                var antlrLexer = AntlrLexer;
                Lexer._resetting = true;
                antlrLexer.Reset();
                Lexer._resetting = false;
                if (antlrState != null)
                {
                    if (antlrState.ModeStackReversed != null)
                    {
                        foreach (var m in antlrState.ModeStackReversed)
                        {
                            antlrLexer.ModeStack.Push(m);
                        }
                    }
                    antlrLexer.CurrentMode = antlrState.Mode;
                    antlrLexer.HitEOF = antlrState.HitEof;
                }
                Lexer._hitEof = false;
            }

            protected override LexerState? SaveState(int hashCode)
            {
                var antlrLexer = AntlrLexer;
                if (!AntlrLexer.HitEOF && antlrLexer.CurrentMode == 0 && antlrLexer.ModeStack.Count == 0) return null;
                else return new AntlrLexerState(hashCode, AntlrLexer.HitEOF, AntlrLexer.CurrentMode, AntlrLexer.ModeStack.Count == 0 ? null : AntlrLexer.ModeStack.ToArray());
            }
        }

    }
}
