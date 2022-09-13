using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Antlr4
{
    public class Antlr4LexerBasedTokenStream : IDisposable, ITokenSource, ITokenStream, ITokenFactory
    {
        private const int DefaultWindowLength = 32;

        private readonly Antlr4SyntaxLexer _lexer;

        private int _basis;                       // Start index of the window
        private int _offset;                      // Offset index from the start of the window
        private Antlr4SyntaxToken[] _window;      // Moveable window of tokens
        private int _windowCount;                 // # of valid tokens in token buffer
        private int _position;                    // Character position in the source text
        private bool _reachedEnd;                 // Indicates whether the end of the source text has been reached

        private int _minResetIndex;              // The first reset index relative to the window start
        private List<int> _resetStack;

        private int _line;
        private int _column;

        private Antlr4SyntaxToken? _previousToken;
        private Antlr4SyntaxToken? _lastTokenRead;
        private Antlr4SyntaxToken? _eofToken;

        private int _minLookahead;
        private int _maxLookahead;

        private static readonly Antlr4SyntaxToken[] s_disposedWindow = new Antlr4SyntaxToken[0];
        private static readonly ObjectPool<Antlr4SyntaxToken[]> s_windowPool = new ObjectPool<Antlr4SyntaxToken[]>(() => new Antlr4SyntaxToken[DefaultWindowLength]);
        private static readonly List<int> s_disposedResetStack = new List<int>();
        private static readonly ObjectPool<List<int>> s_resetStackPool = new ObjectPool<List<int>>(() => new List<int>());

        public Antlr4LexerBasedTokenStream(Antlr4SyntaxLexer lexer)
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
        }

        public void Dispose()
        {
            if (_window != null)
            {
                s_windowPool.Free(_window);
                _window = s_disposedWindow;
                s_resetStackPool.Free(_resetStack);
                _resetStack = s_disposedResetStack;
            }
        }

        public ITokenSource TokenSource => this;

        public int Index => _basis + _offset;

        public int Position => _position;

        public int Size => throw new NotImplementedException();

        public string SourceName => _lexer.Antlr4Lexer.SourceName;

        public int Line => _line + 1;

        public int Column => _column + 1;

        public ICharStream InputStream => _lexer.InputStream;

        public ITokenFactory TokenFactory { get => this; set => throw new NotImplementedException(); }

        public void Consume()
        {
            _previousToken = PeekToken(0);
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

        private Antlr4SyntaxToken GetToken(int index)
        {
            var indexInWindow = index - _basis;
            Debug.Assert(indexInWindow >= 0 && indexInWindow < _windowCount);
            return _window[indexInWindow];
        }

        private Antlr4SyntaxToken PeekToken(int delta)
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
                    Antlr4SyntaxToken[] oldWindow = _window;
                    var newWindowCount = Math.Max(_offset + delta, _window.Length * 2);
                    Antlr4SyntaxToken[] newWindow = new Antlr4SyntaxToken[newWindowCount];
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
                    var nextAntlr4Token = new Antlr4SyntaxToken(nextToken, _windowCount, _position, _line, _column);
                    _lastTokenRead = nextAntlr4Token;
                    _window[_windowCount++] = nextAntlr4Token;
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

        IToken ITokenFactory.Create(Tuple<ITokenSource, ICharStream> source, int type, string text, int channel, int start, int stop, int line, int charPositionInLine)
        {
            var green = _lexer.Language.InternalSyntaxFactory.MissingToken(Antlr4SyntaxKind.FromAntlr4(type));
            return new Antlr4SyntaxToken(green, -1, start, line, charPositionInLine);
        }

        IToken ITokenFactory.Create(int type, string text)
        {
            throw new NotImplementedException();
        }
    }
}
