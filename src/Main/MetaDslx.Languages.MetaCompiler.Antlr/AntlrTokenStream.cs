using Antlr4.Runtime;
using Antlr4.Runtime.Misc;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Antlr
{
    public class AntlrTokenStream : ITokenStream, ITokenSource, ITokenFactory
    {
        private AntlrSyntaxLexer _lexer;
        private int _line;
        private int _column;
        private int _index;
        private int _greenIndex;
        private int _greenPosition;
        private int _lexerErrorPosition;
        private int _parserErrorPosition;
        private List<AntlrSyntaxToken> _tokens;
        private List<AntlrSyntaxToken> _allTokens;
        private int _lookAhead;
        private int _lookBack;
        private int _resetCounter;

        public AntlrTokenStream(AntlrSyntaxLexer lexer)
        {
            _lexer = lexer;
            _line = 0;
            _column = 0;
            _greenIndex = 0;
            _index = 0;
            _tokens = new List<AntlrSyntaxToken>();
            _allTokens = new List<AntlrSyntaxToken>();
            _lookAhead = 0;
            _lookBack = 0;
            _resetCounter = 0;
        }

        public int Line => _line;

        public int Column => _column;

        public ICharStream InputStream => _lexer.InputStream;

        public string SourceName => IntStreamConstants.UnknownSourceName;

        public ITokenFactory TokenFactory { get => this; set => throw new NotSupportedException(); }

        public ITokenSource TokenSource => this;

        public int Index => _index;

        public int Size => throw new NotSupportedException();

        public int LookAhead => _lookAhead;

        public int LookBack => _lookBack;

        public void Consume()
        {
            ++_index;
            _lookAhead = 0;
            _lookBack = 0;
        }

        [return: NotNull]
        public IToken Get(int i)
        {
            CacheTokens(i);
            if (i >= 0 && i < _tokens.Count) return _tokens[i];
            else if (_tokens.Count > 0) return _tokens[_tokens.Count - 1];
            else return null;
        }

        [return: NotNull]
        public string GetText(Interval interval)
        {
            var builder = PooledStringBuilder.GetInstance();
            for (int i = interval.a; i <= interval.b; i++)
            {
                builder.Builder.Append(_allTokens[i].Text);
            }
            return builder.ToStringAndFree();
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
            return GetText(new Interval(start.TokenIndex, stop.TokenIndex));
        }

        public int LA(int i)
        {
            return LT(i)?.Type ?? IntStreamConstants.EOF;
        }

        [return: NotNull]
        public IToken LT(int i)
        {
            if (i > 0 && i - 1 > _lookAhead) _lookAhead = i - 1;
            if (i < 0 && i < _lookBack) _lookBack = i;
            if (i > 0) return Get(_index + i - 1);
            else if (i < 0) return Get(_index + i);
            else return null;
        }

        public int Mark()
        {
            return ++_resetCounter;
        }

        [return: NotNull]
        public IToken NextToken()
        {
            var token = LT(1);
            this.Consume();
            return token;
        }

        public void Release(int marker)
        {
            if (marker != _resetCounter) throw new ArgumentException("Invalid marker to release.", nameof(marker));
            --_resetCounter;
        }

        public void Seek(int index)
        {
            _index = index;
        }

        [return: NotNull]
        public IToken Create(Tuple<ITokenSource, ICharStream> source, int type, string text, int channel, int start, int stop, int line, int charPositionInLine)
        {
            return new AntlrSyntaxToken(type, channel, InputStream.GetText(new Interval(start, stop)), -1, start, line, charPositionInLine, 0, 0);
        }

        [return: NotNull]
        public IToken Create(int type, string text)
        {
            return new AntlrSyntaxToken(type, 0, text ?? string.Empty, -1, 0, 0, 0, 0, 0);
        }

        private void CacheTokens(int index)
        {
            if (index >= _tokens.Count) ReadMoreTokens(index - _tokens.Count + 1);
        }

        private void ReadMoreTokens(int count)
        {
            if (_tokens.Count > 0 && _tokens[_tokens.Count - 1].Type == IntStreamConstants.EOF) return;
            while (count > 0)
            {
                var next = (AntlrSyntaxToken)_lexer.AntlrLexer.NextToken();
                next.TokenIndex = _allTokens.Count;
                if (next.Channel == 0)
                {
                    _tokens.Add(next);
                    --count;
                }
                _allTokens.Add(next);
                if (next.Type == IntStreamConstants.EOF)
                {
                    break;
                }
            }
        }

        public InternalSyntaxToken ConsumeGreenToken(IToken token, AntlrSyntaxParser parser)
        {
            var factory = parser.Language.InternalSyntaxFactory;
            var startPosition = _greenPosition;
            var currentIndex = token.TokenIndex;
            if (currentIndex < 0)
            {
                var missing = factory.MissingToken(AntlrSyntaxKind.FromAntlr(token.Type));
                return missing;
            }
            SyntaxListBuilder? builder = null;
            GreenNode? leadingTrivia = null;
            if (currentIndex > _greenIndex)
            {
                if (builder == null) builder = new SyntaxListBuilder(currentIndex - _greenIndex);
                while (_greenIndex < currentIndex && _greenIndex < _allTokens.Count)
                {
                    var antlrToken = _allTokens[_greenIndex];
                    var greenToken = factory.Trivia(AntlrSyntaxKind.FromAntlr(antlrToken.Type), antlrToken.Text);
                    if (antlrToken.Channel == 0) builder.Add(factory.SkippedTokensTrivia(greenToken));
                    else builder.Add(greenToken);
                    ++_greenIndex;
                }
                leadingTrivia = builder.ToListNode();
                builder.Clear();
            }
            ++_greenIndex;
            GreenNode? trailingTrivia = null;
            if (_greenIndex < _allTokens.Count && _allTokens[_greenIndex].Channel != 0) 
            {
                if (builder == null) builder = SyntaxListBuilder.Create();
                while (_greenIndex < _allTokens.Count && _allTokens[_greenIndex].Channel != 0)
                {
                    var antlrToken = _allTokens[_greenIndex];
                    var greenToken = factory.Trivia(AntlrSyntaxKind.FromAntlr(antlrToken.Type), antlrToken.Text);
                    builder.Add(greenToken);
                    ++_greenIndex;
                    if (antlrToken.Text.Contains("\r") || antlrToken.Text.Contains("\n")) break;
                }
                trailingTrivia = builder.ToListNode();
                builder.Clear();
            }
            var green = factory.Token(leadingTrivia, AntlrSyntaxKind.FromAntlr(token.Type), token.Text, trailingTrivia);
            _greenPosition += green.FullWidth;
            var errors = ArrayBuilder<SyntaxDiagnosticInfo>.GetInstance();
            for (int i = _lexerErrorPosition; i < _lexer.Diagnostics.Count; ++i)
            {
                var diag = _lexer.Diagnostics[i];
                if (diag.Offset >= startPosition && diag.Offset < _greenPosition || green.RawKind == (int)InternalSyntaxKind.Eof)
                {
                    _lexerErrorPosition = i + 1;
                    errors.Add(diag.WithOffset(diag.Offset - startPosition));
                }
            }
            for (int i = _parserErrorPosition; i < parser.Diagnostics.Count; ++i)
            {
                var diag = parser.Diagnostics[i];
                if (diag.Offset >= startPosition && diag.Offset < _greenPosition || green.RawKind == (int)InternalSyntaxKind.Eof)
                {
                    _parserErrorPosition = i + 1;
                    errors.Add(diag.WithOffset(diag.Offset - startPosition));
                }
            }
            if (errors.Count > 0)
            {
                green = (InternalSyntaxToken)green.WithDiagnostics(errors.ToArray());
            }
            errors.Free();
            return green;
        }
    }
}
