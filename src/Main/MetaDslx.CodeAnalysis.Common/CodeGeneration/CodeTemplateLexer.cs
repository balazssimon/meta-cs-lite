#if !VSIX
using MetaDslx.CodeAnalysis.Text;
#endif
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
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

#if VSIX
        internal CodeTemplateLexer(string filePath, string text)
#else
        public CodeTemplateLexer(string filePath, SourceText text)
#endif
        {
            _filePath = filePath;
            _text = new SlidingTextWindow(text);
        }

        public string FilePath => _filePath;
        public int Position => _text.Position;
        public int Line => _line;
        public int Column => _column;
        public string ControlBegin => _controlBegin;
        public string ControlEnd => _controlEnd;
        public int MaxLookahead => _text.MaxLookahead;

        public void Dispose()
        {
            _text.Dispose();
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
                return new CodeTemplateToken(CodeTemplateTokenKind.EndOfFile, string.Empty, _text.LexemeStartPosition, state);
            }
            _text.Start();
            var token = MatchLineEnd(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchTemplateOutput(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchTemplateControlEnd(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchWhitespace(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchComment(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchIdentifier(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchNumber(ref state);
            if (token.Kind != CodeTemplateTokenKind.None) return token;
            token = MatchString(ref state);
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
                if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlEndWs ||
                    state == CodeTemplateLexerState.ControlBegin || state == CodeTemplateLexerState.ControlEnd || 
                    state == CodeTemplateLexerState.TemplateEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition, state);
            }
            if (ch == '\n')
            {
                _text.AdvanceChar(1);
                if (state == CodeTemplateLexerState.TemplateHeaderEnd) state = CodeTemplateLexerState.TemplateOutput;
                if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlEndWs ||
                    state == CodeTemplateLexerState.ControlBegin || state == CodeTemplateLexerState.ControlEnd ||
                    state == CodeTemplateLexerState.TemplateEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition, state);
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
                    return new CodeTemplateToken(CodeTemplateTokenKind.TemplateOutput, _text.GetText(false), _text.LexemeStartPosition, state);
                }
                if (isControlBegin)
                {
                    _text.AdvanceChar(_controlBegin.Length);
                    state = CodeTemplateLexerState.TemplateControl;
                    _parenthesisCounter = 0;
                    _bracketsCounter = 0;
                    _bracesCounter = 0;
                    return new CodeTemplateToken(CodeTemplateTokenKind.TemplateControlBegin, _text.GetText(true), _text.LexemeStartPosition, state);
                }
                if (isTemplateEnd)
                {
                    state = CodeTemplateLexerState.TemplateControl;
                }
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchWhitespace(ref CodeTemplateLexerState state)
        {
            var ch = _text.PeekChar();
            if (ch == ' ' || ch == '\t')
            {
                while (ch == ' ' || ch == '\t')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                if (state == CodeTemplateLexerState.ControlBegin) state = CodeTemplateLexerState.ControlEndWs;
                if (state == CodeTemplateLexerState.ControlEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.Whitespace, _text.GetText(_text.Width == 1), _text.LexemeStartPosition, state);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchComment(ref CodeTemplateLexerState state)
        {
            var ch = _text.PeekChar();
            if (ch == '/' && _text.PeekChar(1) == '/')
            {
                while (!_text.IsReallyAtEnd() && ch != '\r' && ch != '\n')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlBegin) state = CodeTemplateLexerState.None;
                if (state == CodeTemplateLexerState.ControlEndWs || state == CodeTemplateLexerState.ControlEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.SingleLineComment, _text.GetText(false), _text.LexemeStartPosition, state);
            }
            if (ch == '/' && _text.PeekChar(1) == '*')
            {
                var hasNewLine = false;
                _text.AdvanceChar(2);
                while (!_text.IsReallyAtEnd() && (_text.PeekChar(0) != '*' || _text.PeekChar(1) != '/'))
                {
                    ch = _text.NextChar();
                    if (ch == '\r' || ch == '\n') hasNewLine = true;
                }
                if (_text.PeekChar(0) == '*' && _text.PeekChar(1) == '/')
                {
                    _text.AdvanceChar(2);
                }
                if (state == CodeTemplateLexerState.ControlBegin) state = hasNewLine ? CodeTemplateLexerState.None : CodeTemplateLexerState.ControlEndWs;
                if (state == CodeTemplateLexerState.ControlEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.MultiLineComment, _text.GetText(false), _text.LexemeStartPosition, state);
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
                if (Keywords.Contains(lexeme) || ContextualKeywords.Contains(lexeme)) kind = CodeTemplateTokenKind.Keyword;
                if (state == CodeTemplateLexerState.None && TemplateKeywords.Contains(lexeme)) kind = CodeTemplateTokenKind.Keyword;
                if (state == CodeTemplateLexerState.TemplateControl && TemplateControlKeywords.Contains(lexeme)) kind = CodeTemplateTokenKind.Keyword;
                if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlEndWs ||
                    state == CodeTemplateLexerState.ControlBegin || state == CodeTemplateLexerState.ControlEnd) state = CodeTemplateLexerState.None;
                if (kind == CodeTemplateTokenKind.Keyword)
                {
                    if (state == CodeTemplateLexerState.None && lexeme == "control")
                    {
                        state = CodeTemplateLexerState.ControlBeginWs;
                        _controlBegin = "";
                        _controlEnd = "";
                    }
                    if (lexeme == "end")
                    {
                        if (state == CodeTemplateLexerState.TemplateControl)
                        {
                            state = CodeTemplateLexerState.End;
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
                return new CodeTemplateToken(kind, lexeme, _text.LexemeStartPosition, state);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchNumber(ref CodeTemplateLexerState state)
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
                if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlEndWs ||
                    state == CodeTemplateLexerState.ControlBegin || state == CodeTemplateLexerState.ControlEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.Number, _text.GetText(false), _text.LexemeStartPosition, state);
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchString(ref CodeTemplateLexerState state)
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
                if (ch == '"') _text.NextChar();
                if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlEndWs ||
                    state == CodeTemplateLexerState.ControlBegin || state == CodeTemplateLexerState.ControlEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.String, _text.GetText(false), _text.LexemeStartPosition, state);
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
                if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlEndWs ||
                    state == CodeTemplateLexerState.ControlBegin || state == CodeTemplateLexerState.ControlEnd) state = CodeTemplateLexerState.None;
                return new CodeTemplateToken(CodeTemplateTokenKind.VerbatimString, _text.GetText(false), _text.LexemeStartPosition, state);
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
                    return new CodeTemplateToken(CodeTemplateTokenKind.TemplateControlEnd, _text.GetText(true), _text.LexemeStartPosition, state);
                }
            }
            return CodeTemplateToken.None;
        }

        private CodeTemplateToken MatchOther(ref CodeTemplateLexerState state)
        {
            var ch = _text.NextChar();
            if (state == CodeTemplateLexerState.ControlBeginWs || state == CodeTemplateLexerState.ControlBegin)
            {
                _controlBegin += ch;
                state = CodeTemplateLexerState.ControlBegin;
            }
            if (state == CodeTemplateLexerState.ControlEndWs || state == CodeTemplateLexerState.ControlEnd)
            {
                _controlEnd += ch;
                state = CodeTemplateLexerState.ControlEnd;
            }
            if (ch == '(') ++_parenthesisCounter;
            if (ch == ')')
            {
                --_parenthesisCounter;
                if (_parenthesisCounter == 0 && state == CodeTemplateLexerState.TemplateHeader) state = CodeTemplateLexerState.TemplateHeaderEnd;
            }
            if (ch == '[') ++_bracketsCounter;
            if (ch == ']') --_bracketsCounter;
            if (ch == '{') ++_bracesCounter;
            if (ch == '}') --_bracesCounter;
            return new CodeTemplateToken(CodeTemplateTokenKind.Other, _text.GetText(false), _text.LexemeStartPosition, state);
        }

        private bool IsControlBegin()
        {
            var ch = _text.PeekChar();
            if (_controlBegin.Length > 0 && ch == _controlBegin[0])
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

        private bool IsControlEnd()
        {
            if (_parenthesisCounter > 0 || _bracketsCounter > 0 || _bracesCounter > 0) return false;
            var ch = _text.PeekChar();
            if (_controlEnd.Length > 0 && ch == _controlEnd[0])
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

        public static readonly HashSet<string> Keywords = new HashSet<string>()
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

        public static readonly HashSet<string> BlockKeywords = new HashSet<string>()
        {
            "if", "case", "catch", "default", "do", "finally", "for", "foreach", "lock", "switch", "try", "while"
        };

        public static readonly HashSet<string> BlockEndKeywords = new HashSet<string>()
        {
            "if", "for", "foreach", "lock", "switch", "try", "while"
        };

        public static readonly HashSet<string> BlockWithoutEndKeywords = new HashSet<string>()
        {
            "case", "catch", "default", "finally"
        };

        public static readonly HashSet<string> SwitchBlockKeywords = new HashSet<string>()
        {
            "case", "default"
        };

        public static readonly HashSet<string> TryBlockKeywords = new HashSet<string>()
        {
            "catch", "finally"
        };

        public static readonly HashSet<string> LoopKeywords = new HashSet<string>()
        {
            "do", "for", "foreach", "while"
        };

        public static readonly HashSet<string> ContextualKeywords = new HashSet<string>()
        {
            /*"add",*/ "and", "alias", "ascending", "args", "async", "await", "by",
            "descending", "dynamic", "equals", "from", /*"get",*/ "global", "group", /*"init",*/ "into", "join", "let", "managed",
            "nameof", "nint", "not", "notnull", "nuint", "on", "or", "orderby", "partial", "partial", "record", /*"remove",*/
            "required", "select", /*"set",*/ "unmanaged", "value", "var", "when", "where", "with", "yield",
            "control", "generator", "template", "end"
        };

        public static readonly HashSet<string> TemplateKeywords = new HashSet<string>()
        {
            "control", "generator", "template"
        };

        public static readonly HashSet<string> TemplateControlKeywords = new HashSet<string>()
        {
            "end", "template", "separator"
        };
    }
}
