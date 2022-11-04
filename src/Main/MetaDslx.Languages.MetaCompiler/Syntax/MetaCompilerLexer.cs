using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Syntax
{
    public class MetaCompilerLexer : IDisposable
    {
        private string _filePath;
        private SlidingTextWindow _text;

        private int _line;
        private int _column;
        private bool _eof;

        public MetaCompilerLexer(string filePath, SourceText text)
        {
            _filePath = filePath;
            _text = new SlidingTextWindow(text);
        }

        public string FilePath => _filePath;
        public int Position => _text.Position;
        public int Line => _line;
        public int Column => _column;
        public bool EndOfFile => _eof;

        public void Dispose()
        {
            _text.Dispose();
        }

        public MetaCompilerToken Lex()
        {
            var token = NextToken();
            if (token.Kind == MetaCompilerTokenKind.EndOfLine)
            {
                ++_line;
                _column = 0;
            }
            else if (token.Kind == MetaCompilerTokenKind.MultiLineComment || token.Kind == MetaCompilerTokenKind.VerbatimString)
            {
                for (int i = 0; i < token.Text.Length; i++)
                {
                    var ch = token.Text[i];
                    if (ch == '\n')
                    {
                        ++_line;
                        _column = 0;
                    }
                    else
                    {
                        ++_column;
                    }
                }
            }
            else
            {
                _column += token.Text.Length;
            }
            return token;
        }

        private MetaCompilerToken NextToken()
        {
            if (_eof)
            {
                return MetaCompilerToken.None;
            }
            if (_text.IsReallyAtEnd())
            {
                _eof = true;
                return new MetaCompilerToken(MetaCompilerTokenKind.EndOfFile, string.Empty, _text.LexemeStartPosition);
            }
            _text.Start();
            var token = MatchLineEnd();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            token = MatchWhitespace();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            token = MatchComment();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            token = MatchIdentifier();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            token = MatchNumber();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            token = MatchString();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            token = MatchControlCode();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            token = MatchOther();
            if (token.Kind != MetaCompilerTokenKind.None) return token;
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchLineEnd()
        {
            var ch = _text.PeekChar();
            if (ch == '\r' && _text.PeekChar(1) == '\n')
            {
                _text.AdvanceChar(2);
                return new MetaCompilerToken(MetaCompilerTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition);
            }
            if (ch == '\n')
            {
                _text.AdvanceChar(1);
                return new MetaCompilerToken(MetaCompilerTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition);
            }
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchWhitespace()
        {
            var ch = _text.PeekChar();
            if (ch == ' ' || ch == '\t')
            {
                while (ch == ' ' || ch == '\t')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                return new MetaCompilerToken(MetaCompilerTokenKind.Whitespace, _text.GetText(_text.Width == 1), _text.LexemeStartPosition);
            }
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchComment()
        {
            var ch = _text.PeekChar();
            if (ch == '/' && _text.PeekChar(1) == '/')
            {
                while (!_text.IsReallyAtEnd() && ch != '\r' && ch != '\n')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                return new MetaCompilerToken(MetaCompilerTokenKind.SingleLineComment, _text.GetText(false), _text.LexemeStartPosition);
            }
            if (ch == '/' && _text.PeekChar(1) == '*')
            {
                _text.AdvanceChar(2);
                while (!_text.IsReallyAtEnd() && (_text.PeekChar(0) != '*' || _text.PeekChar(1) != '/'))
                {
                    ch = _text.NextChar();
                }
                if (_text.PeekChar(0) == '*' && _text.PeekChar(1) == '/')
                {
                    _text.AdvanceChar(2);
                }
                return new MetaCompilerToken(MetaCompilerTokenKind.MultiLineComment, _text.GetText(false), _text.LexemeStartPosition);
            }
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchIdentifier()
        {
            var ch = _text.PeekChar();
            var nextCh = _text.PeekChar(1);
            if ((ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_') ||
                (ch == '@') && (nextCh >= 'a' && nextCh <= 'z' || nextCh >= 'A' && nextCh <= 'Z' || nextCh == '_'))
            {
                var kind = MetaCompilerTokenKind.Identifier;
                if (ch == '@') _text.NextChar();
                _text.NextChar();
                ch = _text.PeekChar();
                while (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_' || ch >= '0' && ch <= '9')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                var lexeme = _text.GetText(false);
                if (Keywords.Contains(lexeme)) kind = MetaCompilerTokenKind.Keyword;
                return new MetaCompilerToken(kind, lexeme, _text.LexemeStartPosition);
            }
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchNumber()
        {
            var ch = _text.PeekChar();
            var nextCh = _text.PeekChar(1);
            if (ch >= '0' && ch <= '9' || ch == '-' && nextCh >= '0' && nextCh <= '9')
            {
                if (ch == '-') _text.NextChar();
                _text.NextChar();
                ch = _text.PeekChar();
                while (ch >= '0' && ch <= '9')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                if (ch == '.' || ch == 'x' || ch == 'X')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                    while (ch >= '0' && ch <= '9')
                    {
                        _text.NextChar();
                        ch = _text.PeekChar();
                    }
                }
                return new MetaCompilerToken(MetaCompilerTokenKind.Number, _text.GetText(false), _text.LexemeStartPosition);
            }
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchString()
        {
            var ch = _text.PeekChar();
            var nextCh = _text.PeekChar(1);
            if (ch == '\'')
            {
                _text.NextChar();
                ch = _text.PeekChar();
                var count = 0;
                var unicode = ch == 'u' || ch == 'U';
                while (!_text.IsReallyAtEnd() && ch != '\'' && ch != '\r' && ch != '\n')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                    if (unicode)
                    {
                        if (count >= 4 || !(ch >= '0' && ch <= '9' || ch >= 'a' && ch <= 'f' || ch >= 'A' && ch <= 'F')) unicode = false;
                    }
                    if (ch == '\\')
                    {
                        _text.NextChar();
                        ch = _text.PeekChar();
                    }
                    ++count;
                }
                if (ch == '\'') _text.NextChar();
                return new MetaCompilerToken(count == 1 || unicode ? MetaCompilerTokenKind.Character : MetaCompilerTokenKind.String, _text.GetText(false), _text.LexemeStartPosition);
            }
            if (ch == '"')
            {
                _text.NextChar();
                ch = _text.PeekChar();
                while (!_text.IsReallyAtEnd() && ch != '"' && ch != '\r' && ch != '\n')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                    if (ch == '\\')
                    {
                        _text.NextChar();
                        ch = _text.PeekChar();
                    }
                }
                if (ch == '"') _text.NextChar();
                return new MetaCompilerToken(MetaCompilerTokenKind.String, _text.GetText(false), _text.LexemeStartPosition);
            }
            if (ch == '@' && nextCh == '"')
            {
                _text.AdvanceChar(2);
                ch = _text.PeekChar();
                while (!_text.IsReallyAtEnd())
                {
                    if (ch == '"')
                    {
                        if (_text.PeekChar(1) == '"')
                        {
                            _text.AdvanceChar(2);
                            ch = _text.PeekChar();
                        }
                        else
                        {
                            _text.NextChar();
                            break;
                        }
                    }
                    else
                    {
                        _text.NextChar();
                        ch = _text.PeekChar();
                    }
                }
                return new MetaCompilerToken(MetaCompilerTokenKind.VerbatimString, _text.GetText(false), _text.LexemeStartPosition);
            }
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchControlCode()
        {
            var ch = _text.PeekChar();
            if (ch == '{')
            {
                int parenthesisCounter = 0;
                int bracketsCounter = 0;
                int bracesCounter = 1;
                _text.NextChar();
                while (!_text.IsReallyAtEnd() && (parenthesisCounter > 0 || bracketsCounter > 0 || bracesCounter > 0))
                {
                    ch = _text.NextChar();
                    if (ch == '(') ++parenthesisCounter;
                    if (ch == ')') --parenthesisCounter;
                    if (ch == '[') ++bracketsCounter;
                    if (ch == ']') --bracketsCounter;
                    if (ch == '{') ++bracesCounter;
                    if (ch == '}') --bracesCounter;
                }
                return new MetaCompilerToken(MetaCompilerTokenKind.ControlCode, _text.GetText(false), _text.LexemeStartPosition);
            }
            return MetaCompilerToken.None;
        }

        private MetaCompilerToken MatchOther()
        {
            var ch = _text.NextChar();
            return new MetaCompilerToken(MetaCompilerTokenKind.Other, _text.GetText(false), _text.LexemeStartPosition);
        }

        public static readonly HashSet<string> Keywords = new HashSet<string>()
        {
            "namespace", "using", "language", "fragment", "hidden", "def", "use", "eof"
        };

    }

}
