using MetaDslx.CodeAnalysis.Text;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public abstract class SyntaxLexer : AbstractLexer
    {
        private static readonly BufferedLexeme DefaultLexeme = new BufferedLexeme((int)InternalSyntaxKind.None, string.Empty, null);

        private readonly List<BufferedLexeme> _buffer;
        private readonly TextKeyedCache<InternalSyntaxToken> _tokenCache = TextKeyedCache<InternalSyntaxToken>.GetInstance();
        private readonly TextKeyedCache<InternalSyntaxTrivia> _triviaCache = TextKeyedCache<InternalSyntaxTrivia>.GetInstance();
        private readonly CachingIdentityFactory<string, int> _keywordKindMap;
        internal const int MaxKeywordLength = 10;
        private readonly SyntaxListBuilder _leadingTriviaCache = new SyntaxListBuilder(10);
        private readonly SyntaxListBuilder _trailingTriviaCache = new SyntaxListBuilder(10);
        private int _position;
        private LexerState? _state;
        private List<SyntaxDiagnosticInfo> _errors;

        protected SyntaxLexer(SourceText text, ParseOptions parseOptions) 
            : base(text, parseOptions)
        {
            _buffer = new List<BufferedLexeme>();
            _tokenCache = TextKeyedCache<InternalSyntaxToken>.GetInstance();
            _triviaCache = TextKeyedCache<InternalSyntaxTrivia>.GetInstance();
            _keywordKindMap = Language.InternalSyntaxFactory.KeywordKindPool.Allocate();
            _position = 0;
            _state = null;
            _errors = new List<SyntaxDiagnosticInfo>();
        }

        public override int Position => _position;

        public override LexerState? State => _state;

        /// <summary>
        /// Scans a token or syntax trivia. End of line should be scanned as a separate trivia.
        /// </summary>
        /// <returns>The syntax kind of the token or trivia and whether to try to cache the result.</returns>
        protected abstract (int rawKind, bool isTrivia, bool cache) ScanLexeme();

        protected abstract InternalSyntaxToken CreateToken(GreenNode? leadingTrivia, int rawKind, string text, GreenNode? trailingTrivia);

        protected abstract InternalSyntaxTrivia CreateTrivia(int rawKind, string text);

        public override InternalSyntaxToken? Lex()
        {
            return this.LexSyntaxToken();
        }

        public override (InternalSyntaxToken?, IncrementalTokenData) IncrementalLex()
        {
            var startState = _state;
            var token = this.LexSyntaxToken();
            var endState = _state;
            return (token, new IncrementalTokenData(startState, endState, TextWindow.MinLookahead, TextWindow.MaxLookahead));
        }

        public override void ResetTo(int position, LexerState? state)
        {
            base.ResetTo(position, state);
            _position = position;
            _state = state;
            _buffer.Clear();
        }

        protected void StartLexeme()
        {
            TextWindow.Start();
        }

        private BufferedLexeme PeekLexeme()
        {
            if (_buffer.Count == 0)
            {
                this.StartLexeme();
                var lexeme = this.ScanLexeme();
                if (lexeme.rawKind != (int)InternalSyntaxKind.None)
                {
                    if (lexeme.rawKind == (int)InternalSyntaxKind.Eof && TextWindow.Width > 0)
                    {
                        this.AppendLexeme((int)InternalSyntaxKind.BadToken, true, false);
                    }
                    this.AppendLexeme(lexeme.rawKind, lexeme.isTrivia, lexeme.cache);
                }
            }
            if (_buffer.Count == 0) return DefaultLexeme;
            else return _buffer[0];
        }

        private void EatLexeme()
        {
            if (_buffer.Count > 0)
            {
                var lexeme = _buffer[0];
                _state = lexeme.EndState;
                _position += lexeme.Width;
                _buffer.RemoveAt(0);
            }
        }

        private BufferedLexeme NextLexeme()
        {
            var result = PeekLexeme();
            EatLexeme();
            return result;
        }

        /// <summary>
        /// Appends a token or syntax trivia. This method can be used if ScanLexeme
        /// would have to produce more than one Lexemes. 
        /// End of line should be scanned as a separate trivia.
        /// </summary>
        /// <param name="rawKind">The raw kind of the token or trivia.</param>
        /// <param name="isTrivia">Indicates whether this is a trivia or a token.</param>
        /// <param name="cache">Indicates whether to cache the token or trivia.</param>
        protected void AppendLexeme(int rawKind, bool isTrivia, bool cache)
        {
            object? textOrGreenNode = null;
            if (isTrivia)
            {
                textOrGreenNode = CreateTrivia(rawKind, cache);
            }
            else
            {
                if (cache) textOrGreenNode = CachedSyntaxToken(rawKind);
            }
            if (textOrGreenNode == null) textOrGreenNode = TextWindow.GetText(intern: cache);
            StateManager?.InternalChanged();
            _buffer.Add(new BufferedLexeme(rawKind, textOrGreenNode, StateManager?.State));
        }

        private InternalSyntaxToken? CachedSyntaxToken(int rawKind)
        {
            InternalSyntaxToken? token = null;
            var width = TextWindow.Width;
            if (width <= Language.SyntaxFacts.MaxCachedTokenSize)
            {
                var start = TextWindow.LexemeRelativeStart;
                int hashCode = Hash.FnvOffsetBias;
                for (int i = 0; i < width; i++)
                {
                    var ch = TextWindow.CharacterWindow[start + i];
                    hashCode = Hash.CombineFNVHash(hashCode, ch);
                }
                token = LookupToken(rawKind, TextWindow.CharacterWindow, TextWindow.LexemeRelativeStart, width, hashCode);
                return token;
            }
            return token;
        }

        private InternalSyntaxTrivia CreateTrivia(int rawKind, bool cache)
        {
            int hashCode = Hash.FnvOffsetBias;  // FNV base
            bool onlySpaces = true;
            bool onlyWhiteSpace = true;
            var width = TextWindow.Width;
            var start = TextWindow.LexemeRelativeStart;
            for (int i = 0; i < width; i++)
            {
                var ch = TextWindow.CharacterWindow[start + i];
                switch (ch)
                {
                    case '\t':       // Horizontal tab
                    case '\v':       // Vertical Tab
                    case '\f':       // Form-feed
                    case '\u001A':
                        onlySpaces = false;
                        goto case ' ';

                    case ' ':
                        hashCode = Hash.CombineFNVHash(hashCode, ch);
                        break;

                    case '\r':      // Carriage Return
                    case '\n':      // Line-feed
                        onlySpaces = false;
                        break;

                    default:
                        if (ch > 127 && char.IsWhiteSpace(ch))
                        {
                            goto case '\t';
                        }
                        else
                        {
                            onlySpaces = false;
                            onlyWhiteSpace = false;
                            i = width;
                        }
                        break;
                }

            }

            InternalSyntaxTrivia trivia;
            if (width == 1 && onlySpaces)
            {
                trivia = Language.InternalSyntaxFactory.Space;
            }
            else if (onlyWhiteSpace)
            {
                if (cache && width < Language.SyntaxFacts.MaxCachedTokenSize)
                {
                    trivia = LookupTrivia(rawKind, TextWindow.CharacterWindow, TextWindow.LexemeRelativeStart, width, hashCode);
                }
                else
                {
                    trivia = CreateTrivia(rawKind, TextWindow.GetText(intern: cache));
                }
            }
            else
            {
                trivia = CreateTrivia(rawKind, TextWindow.GetText(intern: cache));
            }
            return trivia;
        }

        private InternalSyntaxToken? LexSyntaxToken()
        {
            _leadingTriviaCache.Clear();
            this.LexSyntaxTrivia(isTrailing: false, triviaList: _leadingTriviaCache);
            var leading = _leadingTriviaCache;

            var lexeme = this.NextLexeme();
            if (lexeme.RawKind == (int)InternalSyntaxKind.None) return null;

            _trailingTriviaCache.Clear();
            this.LexSyntaxTrivia(isTrailing: true, triviaList: _trailingTriviaCache);
            var trailing = _trailingTriviaCache;

            var result = Create(lexeme, leading.ToListNode(), trailing.ToListNode());
            return result;
        }

        private InternalSyntaxToken Create(BufferedLexeme lexeme, GreenNode? leadingTrivia, GreenNode? trailingTrivia)
        {
            InternalSyntaxToken token;
            switch (lexeme.RawKind)
            {
                case (int)InternalSyntaxKind.Eof:
                    token = leadingTrivia != null ? (InternalSyntaxToken)Language.InternalSyntaxFactory.EndOfFile.WithLeadingTrivia(leadingTrivia) : Language.InternalSyntaxFactory.EndOfFile;
                    break;
                case (int)InternalSyntaxKind.None:
                    token = Language.InternalSyntaxFactory.BadToken(leadingTrivia, lexeme.Text, trailingTrivia);
                    break;
                default:
                    if (lexeme.IsText)
                    {
                        token = CreateToken(leadingTrivia, lexeme.RawKind, lexeme.Text, trailingTrivia);
                    }
                    else
                    {
                        Debug.Assert(lexeme.IsToken);
                        token = lexeme.Token!;
                        if (leadingTrivia != null || token.HasLeadingTrivia) token = (InternalSyntaxToken)token.WithLeadingTrivia(leadingTrivia);
                        if (trailingTrivia != null || token.HasTrailingTrivia) token = (InternalSyntaxToken)token.WithTrailingTrivia(trailingTrivia);
                    }
                    break;
            }
            return token;
        }


        private void LexSyntaxTrivia(bool isTrailing, SyntaxListBuilder triviaList)
        {
            while (true)
            {
                var lexeme = this.PeekLexeme();
                if (!lexeme.IsTrivia) return;
                var trivia = lexeme.Trivia!;
                EatLexeme();
                triviaList.Add(trivia);
                if (isTrailing && Language.SyntaxFacts.IsTriviaWithEndOfLine(trivia)) return;
            }
        }

        protected bool TryGetKeywordKind(string key, out int rawKind)
        {
            if (key.Length > MaxKeywordLength)
            {
                rawKind = (int)InternalSyntaxKind.None;
                return false;
            }

            rawKind = _keywordKindMap.GetOrMakeValue(key);
            return rawKind != (int)InternalSyntaxKind.None;
        }

        private InternalSyntaxToken LookupToken(
            int rawKind,
            char[] textBuffer,
            int keyStart,
            int keyLength,
            int hashCode)
        {
            var value = _tokenCache.FindItem(textBuffer, keyStart, keyLength, hashCode);

            if (value == null)
            {
                value = this.CreateToken(null, rawKind, TextWindow.GetInternedText(), null);
                _tokenCache.AddItem(textBuffer, keyStart, keyLength, hashCode, value);
            }

            return value;
        }

        private InternalSyntaxTrivia LookupTrivia(
            int rawKind,
            char[] textBuffer,
            int keyStart,
            int keyLength,
            int hashCode)
        {
            var value = _triviaCache.FindItem(textBuffer, keyStart, keyLength, hashCode);

            if (value == null)
            {
                value = this.CreateTrivia(rawKind, false);
                _triviaCache.AddItem(textBuffer, keyStart, keyLength, hashCode, value);
            }

            return value;
        }

        protected void AddError(SyntaxDiagnosticInfo error)
        {
            _errors.Add(error);
        }

        private struct BufferedLexeme
        {
            public readonly int RawKind;
            private readonly object TextOrGreenNode;
            public readonly LexerState? EndState;

            public BufferedLexeme(int rawKind, object textOrGreenNode, LexerState? endState)
            {
                RawKind = rawKind;
                TextOrGreenNode = textOrGreenNode;
                EndState = endState;
            }

            public bool IsToken => TextOrGreenNode is InternalSyntaxToken;
            public bool IsTrivia => TextOrGreenNode is InternalSyntaxTrivia;
            public bool IsText => TextOrGreenNode is string;
            public InternalSyntaxToken? Token => TextOrGreenNode as InternalSyntaxToken;
            public InternalSyntaxTrivia? Trivia => TextOrGreenNode as InternalSyntaxTrivia;
            public string Text => TextOrGreenNode is GreenNode green ? green.ToFullString() : TextOrGreenNode is string text ? text : string.Empty;

            public int Width => TextOrGreenNode is GreenNode green ? green.FullWidth : TextOrGreenNode is string text ? text.Length : 0;

            public override string ToString()
            {
                return TextOrGreenNode.ToString();
            }
        }

    }
}
