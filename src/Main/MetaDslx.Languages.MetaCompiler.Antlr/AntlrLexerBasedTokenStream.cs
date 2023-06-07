using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public class AntlrLexerBasedTokenStream : IDisposable, ITokenSource, ITokenStream, ITokenFactory
    {
        private const int DefaultWindowLength = 32;

        private readonly AntlrSyntaxLexer _lexer;

        private int _basis;                       // Start index of the window
        private int _offset;                      // Offset index from the start of the window
        private AntlrSyntaxToken[] _window;      // Moveable window of tokens
        private int _windowCount;                 // # of valid tokens in token buffer
        private int _position;                    // Character position in the source text
        private bool _reachedEnd;                 // Indicates whether the end of the source text has been reached

        private int _minResetIndex;              // The first reset index relative to the window start
        private List<int> _resetStack;

        private int _line;
        private int _column;

        private AntlrSyntaxToken? _previousToken;
        private AntlrSyntaxToken? _lastTokenRead;
        private AntlrSyntaxToken? _eofToken;

        private int _minLookahead;
        private int _maxLookahead;

        private List<AntlrSyntaxToken> _unprocessedTokens;
        private int _realPosition;

        private static readonly AntlrSyntaxToken[] s_disposedWindow = new AntlrSyntaxToken[0];
        private static readonly ObjectPool<AntlrSyntaxToken[]> s_windowPool = new ObjectPool<AntlrSyntaxToken[]>(() => new AntlrSyntaxToken[DefaultWindowLength]);
        private static readonly List<int> s_disposedResetStack = new List<int>();
        private static readonly ObjectPool<List<int>> s_resetStackPool = new ObjectPool<List<int>>(() => new List<int>());
        private static readonly List<AntlrSyntaxToken> s_disposedUnprocessedTokens = new List<AntlrSyntaxToken>();
        private static readonly ObjectPool<List<AntlrSyntaxToken>> s_unprocessedTokensPool = new ObjectPool<List<AntlrSyntaxToken>>(() => new List<AntlrSyntaxToken>());

        public AntlrLexerBasedTokenStream(AntlrSyntaxLexer lexer)
        {
            _lexer = lexer;
            _basis = 0;
            _offset = 0;
            _position = 0;
            _window = s_windowPool.Allocate();
            _windowCount = 0;
            _reachedEnd = false;
            _minResetIndex = -1;
            _resetStack = s_resetStackPool.Allocate();
            _previousToken = null;
            _minLookahead = int.MaxValue;
            _maxLookahead = int.MinValue;
            _unprocessedTokens = s_unprocessedTokensPool.Allocate();
        }

        public void Dispose()
        {
            if (_window != null)
            {
                s_windowPool.Free(_window);
                _window = s_disposedWindow;
                _resetStack.Clear();
                s_resetStackPool.Free(_resetStack);
                _resetStack = s_disposedResetStack;
                _unprocessedTokens.Clear();
                s_unprocessedTokensPool.Free(_unprocessedTokens);
                _unprocessedTokens = s_disposedUnprocessedTokens;
            }
        }

        public ITokenSource TokenSource => this;

        public int Index => _basis + _offset;

        public int Position => _position;

        public int RealPosition => _realPosition;

        public int Size => throw new NotImplementedException();

        public string SourceName => _lexer.AntlrLexer.SourceName;

        public int Line => _line + 1;

        public int Column => _column + 1;

        public ICharStream InputStream => _lexer.InputStream;

        public ITokenFactory TokenFactory { get => this; set => throw new NotImplementedException(); }

        public void Consume()
        {
            _previousToken = PeekToken(0);
            _unprocessedTokens.Add(_previousToken);
            ++_offset;
        }

        [return: NotNull]
        public IToken Get(int i)
        {
            var index = i - _basis;
            if (index >= 0) return LT(index + 1);
            else return LT(index);
        }

        [return: NotNull]
        public string GetText(Interval interval)
        {
            return GetText(GetToken(interval.a), GetToken(interval.b));
        }

        [return: NotNull]
        public string GetText()
        {
            return _lexer.SourceText.ToString();
        }

        [return: NotNull]
        public string GetText(RuleContext ctx)
        {
            return GetText(ctx.SourceInterval);
        }

        [return: NotNull]
        public string GetText(IToken start, IToken stop)
        {
            if (start.TokenIndex == stop.TokenIndex) return start.Text;
            var sb = PooledStringBuilder.GetInstance();
            var writer = new StringWriter(sb.Builder, System.Globalization.CultureInfo.InvariantCulture);
            for (int i = start.TokenIndex; i <= stop.TokenIndex; i++)
            {
                var token = GetToken(i);
                var green = token.Green;
                green.WriteTo(writer, i > start.TokenIndex, i < stop.TokenIndex);
            }
            return sb.ToStringAndFree();
        }

        public int LA(int i)
        {
            return LT(i)?.Type ?? IntStreamConstants.EOF;
        }

        [return: NotNull]
        public IToken LT(int k)
        {
            if (k == -1) return _previousToken;
            if (k < 0) return PeekToken(k);
            if (k > 0) return PeekToken(k - 1);
            return null;
        }

        public int Mark()
        {
            var result = Index;
            _resetStack.Add(result);
            if (_minResetIndex < 0 || result < _minResetIndex) _minResetIndex = result;
            return result;
        }

        public void Release(int marker)
        {
            var top = _resetStack[_resetStack.Count - 1];
            Debug.Assert(top == marker);
            _resetStack.RemoveAt(_resetStack.Count - 1);
            if (_resetStack.Count == 0) _minResetIndex = -1;
        }

        public void Seek(int index)
        {
            _offset = index - _basis;
            Debug.Assert(_offset >= 0);
        }

        private AntlrSyntaxToken GetToken(int index)
        {
            var indexInWindow = index - _basis;
            Debug.Assert(indexInWindow >= 0 && indexInWindow < _windowCount);
            return _window[indexInWindow];
        }

        private AntlrSyntaxToken PeekToken(int delta)
        {
            _minLookahead = Math.Min(_minLookahead, delta);
            _maxLookahead = Math.Max(_maxLookahead, delta);

            if (_offset + delta >= _windowCount && !MoreTokens(delta))
            {
                return _eofToken;
            }

            // N.B. MoreChars may update the offset.
            return _window[_offset + delta];
        }

        private bool MoreTokens(int delta)
        {
            if (delta < 0) throw new ArgumentOutOfRangeException(nameof(delta), $"Delta value cannot be negative.");
            if (_windowCount <= _offset + delta)
            {
                if (_reachedEnd)
                {
                    return false;
                }

                // if token scanning is sufficiently into the token buffer, 
                // then refocus the window onto the token
                if (_minResetIndex >= 0 && _minResetIndex - _basis > (_windowCount / 4))
                {
                    var move = _minResetIndex - _basis;
                    Array.Copy(_window, _minResetIndex, _window, 0, _windowCount - move);
                    _windowCount -= move;
                    _offset -= move;
                    _basis += move;
                }

                if (_offset + delta >= _window.Length)
                {
                    // grow char array, since we need more contiguous space
                    AntlrSyntaxToken[] oldWindow = _window;
                    var newWindowCount = Math.Max(_offset + delta, _window.Length * 2);
                    AntlrSyntaxToken[] newWindow = new AntlrSyntaxToken[newWindowCount];
                    Array.Copy(oldWindow, 0, newWindow, 0, _windowCount);
                    s_windowPool.ForgetTrackedObject(oldWindow, newWindow);
                    _window = newWindow;
                }

                while (_windowCount <= _offset + delta)
                {
                    var nextToken = _lexer.Lex();
                    if (nextToken == null) break;
                    var errors = _lexer.Errors.Where(error => error.Offset >= _position && error.Offset < _position + nextToken.FullWidth);
                    if (errors.Any())
                    {
                        nextToken = nextToken.WithDiagnosticsGreen(errors.Select(error => error.WithOffset(error.Offset - _position)).ToArray());
                    }
                    var nextAntlrToken = new AntlrSyntaxToken(nextToken, _windowCount, _position, _line, _column);
                    _lastTokenRead = nextAntlrToken;
                    _window[_windowCount++] = nextAntlrToken;
                    if (_lastTokenRead.Type == TokenConstants.EOF) _eofToken = _lastTokenRead;
                    _position += nextToken.FullWidth;
                    AdjustLineAndColumn(nextToken.ToFullString());
                }
                return _windowCount > _offset + delta;
            }
            return true;
        }

        private void AdjustLineAndColumn(string text)
        {
            bool skipN = false;
            foreach (var ch in text)
            {
                if (ch == '\n' && skipN) continue;
                if (ch == '\r' || ch == '\n')
                {
                    ++_line;
                    _column = 0;
                    skipN = ch == '\r';
                }
                else
                {
                    ++_column;
                    skipN = false;
                }
            }
        }

        [return: NotNull]
        public IToken NextToken()
        {
            throw new NotImplementedException();
        }

        public InternalSyntaxToken ConsumeRealToken(AntlrSyntaxToken token, AntlrSyntaxParser parser)
        {
            var currentRealPosition = _realPosition;
            var green = token.Green;
            SyntaxListBuilder? skippedTokens = null;
            while (_unprocessedTokens.Count > 0)
            {
                var currentToken = _unprocessedTokens[0];
                _unprocessedTokens.RemoveAt(0);
                _realPosition += currentToken.Green.FullWidth;
                if (!object.ReferenceEquals(token, currentToken))
                {
                    if (skippedTokens == null) skippedTokens = new SyntaxListBuilder(4);
                    skippedTokens.Add(currentToken.Green);
                }
                else
                {
                    break;
                }
            }
            if (skippedTokens != null && skippedTokens.Count > 0)
            {
                green = AddSkippedSyntax(green, skippedTokens.ToListNode());
            }
            var errors = parser.GetErrorsForToken(currentRealPosition, green);
            if (errors != null && errors.Length > 0)
            {
                green = green.WithAdditionalDiagnosticsGreen(errors);
            }
            return green;
        }

        /// <summary>
        /// Converts skippedSyntax node into tokens and adds these as trivia on the target token.
        /// Also adds the first error (in depth-first preorder) found in the skipped syntax tree to the target token.
        /// </summary>
        internal InternalSyntaxToken AddSkippedSyntax(InternalSyntaxToken target, GreenNode skippedSyntax)
        {
            var diagnostics = ArrayBuilder<SyntaxDiagnosticInfo>.GetInstance();
            var builder = new SyntaxListBuilder(4);
            int currentOffset = 0;
            foreach (var node in skippedSyntax.EnumerateNodes())
            {
                InternalSyntaxToken? token = node as InternalSyntaxToken;
                if (token != null)
                {
                    builder.Add(token.GetLeadingTrivia());

                    // separate trivia from the tokens
                    InternalSyntaxToken tk = (InternalSyntaxToken)token.WithLeadingTrivia(null).WithTrailingTrivia(null);

                    // adjust relative offsets of diagnostics attached to the token:
                    int leadingWidth = token.GetLeadingTriviaWidth();
                    if (leadingWidth > 0)
                    {
                        var tokenDiagnostics = tk.GetDiagnostics();
                        for (int i = 0; i < tokenDiagnostics.Length; i++)
                        {
                            var d = (SyntaxDiagnosticInfo)tokenDiagnostics[i];
                            var newDiag = new SyntaxDiagnosticInfo(d.Offset - leadingWidth, d.Width, d.Descriptor, d.Arguments);
                            if (token.Width > 0) tokenDiagnostics[i] = newDiag;
                            else diagnostics.Add(newDiag);
                        }
                    }

                    if (token.Width > 0)
                    {
                        builder.Add(_lexer.Language.InternalSyntaxFactory.SkippedTokensTrivia(tk));
                    }

                    builder.Add(token.GetTrailingTrivia());

                    currentOffset += token.FullWidth;
                }
                else if (node.ContainsDiagnostics)
                {
                    var nodeDiagnostics = node.GetDiagnostics();
                    for (int i = 0; i < nodeDiagnostics.Length; i++)
                    {
                        var d = (SyntaxDiagnosticInfo)nodeDiagnostics[i];
                        var newDiag = new SyntaxDiagnosticInfo(currentOffset + d.Offset, d.Width, d.Descriptor, d.Arguments);
                        diagnostics.Add(newDiag);
                    }
                }
            }

            int triviaWidth = currentOffset;
            var trivia = builder.ToListNode();

            // Since we're adding triviaWidth before the token, we have to add that much to
            // the offset of each of its diagnostics.
            if (triviaWidth > 0)
            {
                var targetDiagnostics = target.GetDiagnostics();
                for (int i = 0; i < targetDiagnostics.Length; i++)
                {
                    var d = (SyntaxDiagnosticInfo)targetDiagnostics[i];
                    targetDiagnostics[i] = new SyntaxDiagnosticInfo(d.Offset + triviaWidth, d.Width, d.Descriptor, d.Arguments);
                }
            }

            var leadingTrivia = target.GetLeadingTrivia();
            target = (InternalSyntaxToken)target.WithLeadingTrivia(SyntaxList.Concat(trivia, leadingTrivia));
            diagnostics.Free();
            return target;
        }

        public InternalSyntaxToken ConsumeMissingToken(int rawKind, AntlrSyntaxParser parser)
        {
            return _lexer.Language.InternalSyntaxFactory.MissingToken(rawKind);
        }

        [return: NotNull]
        public IToken Create(Tuple<ITokenSource, ICharStream> source, int type, string text, int channel, int start, int stop, int line, int charPositionInLine)
        {
            var green = _lexer.Language.InternalSyntaxFactory.MissingToken(AntlrSyntaxKind.FromAntlr(type));
            return new AntlrSyntaxToken(green, -1, -1, line, charPositionInLine);
        }

        [return: NotNull]
        public IToken Create(int type, string text)
        {
            throw new NotImplementedException();
        }
    }
}
