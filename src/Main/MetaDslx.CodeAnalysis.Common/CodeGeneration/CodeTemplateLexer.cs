using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Text.RegularExpressions;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public class CodeTemplateLexer : IDisposable
    {
        private string _filePath;
        private SlidingTextWindow _text;
        
        private int _line;
        private int _column;

        private int _parenthesisCounter = 0;
        private int _bracketsCounter = 0;
        private int _bracesCounter = 0;

        private string _controlBegin = "[";
        private string _controlEnd = "]";

        private DiagnosticBag? _diagnosticBag;

        public CodeTemplateLexer(string filePath, SourceText text, bool collectErrors)
        {
            _filePath = filePath;
            _text = new SlidingTextWindow(text);
            if (collectErrors) _diagnosticBag = new DiagnosticBag();
        }

        public int Position => _text.Position;
        public int Line => _line;
        public int Column => _column;
        public string ControlBegin { get => _controlBegin; internal set => _controlBegin = value; }
        public string ControlEnd { get => _controlEnd; internal set => _controlEnd = value; }

        public void Dispose()
        {
            _text.Dispose();
        }

        public ImmutableArray<Diagnostic> GetDiagnostics()
        {
            return _diagnosticBag.ToReadOnly();
        }

        public CodeTemplateToken Lex(ref CodeTemplateLexerState state)
        {
            var token = NextToken(ref state);
            if (token.Kind == CodeTemplateTokenKind.EndOfLine)
            {
                ++_line;
                _column = 0;
            }
            else if (token.Kind == CodeTemplateTokenKind.MultiLineComment || token.Kind == CodeTemplateTokenKind.VerbatimString)
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

        private CodeTemplateToken NextToken(ref CodeTemplateLexerState state)
        {
            if (state == CodeTemplateLexerState.Eof)
            {
                return CodeTemplateToken.None;
            }
            if (_text.IsReallyAtEnd())
            {
                state = CodeTemplateLexerState.Eof;
                return new CodeTemplateToken(CodeTemplateTokenKind.EndOfFile, string.Empty, _text.LexemeStartPosition);
            }
            _text.Start();
            var token = MatchLineEnd(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchTemplateOutput(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchTemplateControlEnd(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchWhitespace();
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchComment();
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchIdentifier(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchNumber();
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchString();
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchOther(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchLineEnd(ref CodeTemplateLexerState state)
        {
            var ch = _text.PeekChar();
            if (ch == '\r' && _text.PeekChar(1) == '\n')
            {
                _text.AdvanceChar(2);
                if (state == CodeTemplateLexerState.TemplateHeaderEnd) state = CodeTemplateLexerState.TemplateOutput;
                if (state == CodeTemplateLexerState.TemplateEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition);
            }
            if (ch == '\n')
            {
                _text.AdvanceChar(1);
                if (state == CodeTemplateLexerState.TemplateHeaderEnd) state = CodeTemplateLexerState.TemplateOutput;
                if (state == CodeTemplateLexerState.TemplateEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchTemplateOutput(ref CodeTemplateLexerState state)
        {
            if (state == CodeTemplateLexerState.TemplateOutput)
            {
                var hasOutput = false;
                var ch = _text.PeekChar();
                var isControlBegin = IsControlBegin();
                var isTemplateEnd = IsTemplateEnd();
                while (!_text.IsReallyAtEnd() && !isControlBegin && !isTemplateEnd && ch != '\r' && ch != '\n')
                {
                    hasOutput = true;
                    _text.NextChar();
                    ch = _text.PeekChar();
                    isControlBegin = IsControlBegin();
                    isTemplateEnd = IsTemplateEnd();
                }
                if (hasOutput)
                {
                    return new CodeTemplateToken(CodeTemplateTokenKind.TemplateOutput, _text.GetText(false), _text.LexemeStartPosition);
                }
                if (isControlBegin)
                {
                    _text.AdvanceChar(_controlBegin.Length);
                    state = CodeTemplateLexerState.TemplateControl;
                    _parenthesisCounter = 0;
                    _bracketsCounter = 0;
                    _bracesCounter = 0;
                    return new CodeTemplateToken(CodeTemplateTokenKind.TemplateControlBegin, _text.GetText(true), _text.LexemeStartPosition);
                }
                if (isTemplateEnd)
                {
                    state = CodeTemplateLexerState.TemplateControl;
                }
            }
            return CodeTemplateToken.None;
        }

        private bool IsControlBegin()
        {
            var ch = _text.PeekChar();
            if (ch == _controlBegin[0])
            {
                for (int i = 1; i < _controlBegin.Length; ++i)
                {
                    if (_text.PeekChar(i) != _controlBegin[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private bool IsTemplateEnd()
        {
            var ch = _text.PeekChar();
            if (_column == 0 && ch == 'e' && _text.PeekChar(1) == 'n' && _text.PeekChar(2) == 'd' && _text.PeekChar(3) == ' ' &&
                _text.PeekChar(4) == 't' && _text.PeekChar(5) == 'e' && _text.PeekChar(6) == 'm' && _text.PeekChar(7) == 'p' &&
                _text.PeekChar(8) == 'l' && _text.PeekChar(9) == 'a' && _text.PeekChar(10) == 't' && _text.PeekChar(11) == 'e')
            {
                int peekIndex = 12;
                ch = _text.PeekChar(peekIndex++);
                while (ch == ' ' || ch == '\t')
                {
                    ch = _text.PeekChar(peekIndex++);
                }
                if (ch == SlidingTextWindow.InvalidCharacter || ch == '\r' || ch == '\n')
                {
                    return true;
                }
            }
            return false;
        }

        private CodeTemplateToken MatchWhitespace()
        {
            var ch = _text.PeekChar();
            if (ch == ' ' || ch == '\t')
            {
                while (ch == ' ' || ch == '\t')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                return new CodeTemplateToken(CodeTemplateTokenKind.Whitespace, _text.GetText(_text.Width == 1), _text.LexemeStartPosition);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchComment()
        {
            var ch = _text.PeekChar();
            if (ch == '/' && _text.PeekChar(1) == '/')
            {
                while (!_text.IsReallyAtEnd() && ch != '\r' && ch != '\n')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                return new CodeTemplateToken(CodeTemplateTokenKind.SingleLineComment, _text.GetText(false), _text.LexemeStartPosition);
            }
            if (ch == '/' && _text.PeekChar(1) == '*')
            {
                _text.AdvanceChar(2);
                while (!_text.IsReallyAtEnd() && (_text.PeekChar(0) != '*' || _text.PeekChar(1) != '/'))
                {
                    _text.NextChar();
                }
                if (_text.PeekChar(0) == '*' && _text.PeekChar(1) == '/')
                {
                    _text.AdvanceChar(2);
                }
                return new CodeTemplateToken(CodeTemplateTokenKind.MultiLineComment, _text.GetText(false), _text.LexemeStartPosition);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchIdentifier(ref CodeTemplateLexerState state)
        {
            var ch = _text.PeekChar();
            var nextCh = _text.PeekChar(1);
            if ((ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_') ||
                ch == '@' && (nextCh >= 'a' && nextCh <= 'z' || nextCh >= 'A' && nextCh <= 'Z' || nextCh == '_'))
            {
                var kind = CodeTemplateTokenKind.Identifier;
                if (ch == '@')
                {
                    kind = CodeTemplateTokenKind.VerbatimIdentifier;
                    _text.NextChar();
                }
                _text.NextChar();
                ch = _text.PeekChar();
                while (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_' || ch >= '0' && ch <= '9')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                var lexeme = _text.GetText(false);
                if (s_Keywords.Contains(lexeme) || s_ContextualKeywords.Contains(lexeme)) kind = CodeTemplateTokenKind.Keyword;
                if (state == CodeTemplateLexerState.None && s_TemplateKeywords.Contains(lexeme)) kind = CodeTemplateTokenKind.Keyword;
                if (state == CodeTemplateLexerState.TemplateControl && s_TemplateControlKeywords.Contains(lexeme)) kind = CodeTemplateTokenKind.Keyword;
                if (kind == CodeTemplateTokenKind.Keyword)
                {
                    if (lexeme == "end")
                    {
                        if (state == CodeTemplateLexerState.TemplateControl)
                        {
                            state = CodeTemplateLexerState.End;
                        }
                        else
                        {
                            Error($"'end' is unexpected here");
                        }
                    }
                    if (lexeme == "template")
                    {
                        if (state == CodeTemplateLexerState.End)
                        {
                            state = CodeTemplateLexerState.None;
                        }
                        else if (state == CodeTemplateLexerState.None)
                        {
                            state = CodeTemplateLexerState.TemplateHeader;
                        }
                    }
                    if (lexeme == "if" || lexeme == "switch" || lexeme == "do" || lexeme == "for" || lexeme == "foreach" || 
                        lexeme == "while" || lexeme == "try" || lexeme == "lock")
                    {
                        if (state == CodeTemplateLexerState.End)
                        {
                            state = CodeTemplateLexerState.TemplateControl;
                        }
                    }
                }
                return new CodeTemplateToken(kind, lexeme, _text.LexemeStartPosition);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchNumber()
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
                return new CodeTemplateToken(CodeTemplateTokenKind.Number, _text.GetText(false), _text.LexemeStartPosition);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchString()
        {
            var ch = _text.PeekChar();
            var nextCh = _text.PeekChar(1);
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
                return new CodeTemplateToken(CodeTemplateTokenKind.String, _text.GetText(false), _text.LexemeStartPosition);
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
                return new CodeTemplateToken(CodeTemplateTokenKind.VerbatimString, _text.GetText(false), _text.LexemeStartPosition);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchTemplateControlEnd(ref CodeTemplateLexerState state)
        {
            if (state == CodeTemplateLexerState.TemplateControl)
            {
                if (IsControlEnd())
                {
                    _text.AdvanceChar(_controlEnd.Length);
                    state = CodeTemplateLexerState.TemplateOutput;
                    _parenthesisCounter = 0;
                    _bracketsCounter = 0;
                    _bracesCounter = 0;
                    return new CodeTemplateToken(CodeTemplateTokenKind.TemplateControlEnd, _text.GetText(true), _text.LexemeStartPosition);
                }
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchOther(ref CodeTemplateLexerState state)
        {
            var ch = _text.NextChar();
            if (ch == '(') ++_parenthesisCounter;
            if (ch == ')')
            {
                --_parenthesisCounter;
                if (_parenthesisCounter < 0) Error("')' is unexpected here");
                else if (_parenthesisCounter == 0 && state == CodeTemplateLexerState.TemplateHeader) state = CodeTemplateLexerState.TemplateHeaderEnd;
            }
            if (ch == '[') ++_bracketsCounter;
            if (ch == ']')
            {
                --_bracketsCounter;
                if (_bracketsCounter < 0) Error("']' is unexpected here");
            }
            if (ch == '{') ++_bracesCounter;
            if (ch == '}')
            {
                --_bracesCounter;
                if (_bracesCounter < 0) Error("'}' is unexpected here");
            }
            return new CodeTemplateToken(CodeTemplateTokenKind.Other, _text.GetText(false), _text.LexemeStartPosition);
        }

        private bool IsControlEnd()
        {
            if (_parenthesisCounter > 0 || _bracketsCounter > 0 || _bracesCounter > 0) return false;
            var ch = _text.PeekChar();
            if (ch == _controlEnd[0])
            {
                for (int i = 1; i < _controlEnd.Length; ++i)
                {
                    if (_text.PeekChar(i) != _controlEnd[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private void Error(string message)
        {
            if (_diagnosticBag != null)
            {
                _diagnosticBag.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, Location.Create(_filePath, new TextSpan(_text.Position, 1), new LinePositionSpan(new LinePosition(_line, _column), new LinePosition(_line, _column))), message));
            }
        }

        private static readonly HashSet<string> s_Keywords = new HashSet<string>()
        {
            "abstract", "as", "base", "bool", "break", "byte", "case", "catch", "char", "checked", "class", "const", "continue", 
            "decimal", "default", "delegate", "do", "double", "else", "enum", "event", "explicit", "extern", "false", "finally", 
            "fixed", "float", "for", "foreach", "goto", "if", "implicit", "in", "int", "interface", "internal", "is", "lock", 
            "long", "namespace", "new", "null", "object", "operator", "out", "override", "params", "private", "protected", 
            "public", "readonly", "ref", "return", "sbyte", "sealed", "short", "sizeof", "stackalloc", "static", "string", 
            "struct", "switch", "this", "throw", "true", "try", "typeof", "uint", "ulong", "unchecked", "unsafe", "ushort", 
            "using", "virtual", "void", "volatile", "while", "add", "and", "alias", "ascending", "args", "async", "await", "by", 
            "descending", "dynamic", "equals", "from", "get", "global", "group", "init", "into", "join", "let", "managed", 
            "nameof", "nint", "not", "notnull", "nuint", "on", "or", "orderby", "partial", "partial", "record", "remove", 
            "required", "select", "set", "unmanaged", "value", "var", "when", "where", "with", "yield", 
            "control", "generator", "template", "end"
        };

        private static readonly HashSet<string> s_ContextualKeywords = new HashSet<string>()
        {
            /*"add",*/ "and", "alias", "ascending", "args", "async", "await", "by",
            "descending", "dynamic", "equals", "from", /*"get",*/ "global", "group", /*"init",*/ "into", "join", "let", "managed",
            "nameof", "nint", "not", "notnull", "nuint", "on", "or", "orderby", "partial", "partial", "record", /*"remove",*/
            "required", "select", /*"set",*/ "unmanaged", "value", "var", "when", "where", "with", "yield",
            "control", "generator", "template", "end"
        };

        private static readonly HashSet<string> s_TemplateKeywords = new HashSet<string>()
        {
            "control", "generator", "template"
        };

        private static readonly HashSet<string> s_TemplateControlKeywords = new HashSet<string>()
        {
            "end", "template", "separator"
        };
    }
}
