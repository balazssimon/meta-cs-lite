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
    public class MetaGeneratorLexer : IDisposable
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

        public MetaGeneratorLexer(string filePath, SourceText text)
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

        public MetaGeneratorToken Lex(ref MetaGeneratorLexerState state)
        {
            var token = NextToken(ref state);
            if (token.Kind == MetaGeneratorTokenKind.EndOfLine)
            {
                ++_line;
                _column = 0;
            }
            else if (token.Kind == MetaGeneratorTokenKind.MultiLineComment || token.Kind == MetaGeneratorTokenKind.VerbatimString)
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

        private MetaGeneratorToken NextToken(ref MetaGeneratorLexerState state)
        {
            if (state == MetaGeneratorLexerState.Eof)
            {
                return MetaGeneratorToken.None;
            }
            if (_text.IsReallyAtEnd())
            {
                state = MetaGeneratorLexerState.Eof;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.EndOfFile, string.Empty, _text.LexemeStartPosition, state);
            }
            _text.Start();
            var token = MatchLineEnd(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchTemplateOutput(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchTemplateControlEnd(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchWhitespace(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchComment(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchIdentifier(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchNumber(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchString(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchOther(ref state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchLineEnd(ref MetaGeneratorLexerState state)
        {
            var ch = _text.PeekChar();
            if (ch == '\r' && _text.PeekChar(1) == '\n')
            {
                _text.AdvanceChar(2);
                if (state == MetaGeneratorLexerState.TemplateHeaderEnd) state = MetaGeneratorLexerState.TemplateOutput;
                if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlEndWs ||
                    state == MetaGeneratorLexerState.ControlBegin || state == MetaGeneratorLexerState.ControlEnd || 
                    state == MetaGeneratorLexerState.TemplateEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition, state);
            }
            if (ch == '\n')
            {
                _text.AdvanceChar(1);
                if (state == MetaGeneratorLexerState.TemplateHeaderEnd) state = MetaGeneratorLexerState.TemplateOutput;
                if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlEndWs ||
                    state == MetaGeneratorLexerState.ControlBegin || state == MetaGeneratorLexerState.ControlEnd ||
                    state == MetaGeneratorLexerState.TemplateEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchTemplateOutput(ref MetaGeneratorLexerState state)
        {
            if (state == MetaGeneratorLexerState.TemplateOutput)
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
                    return new MetaGeneratorToken(MetaGeneratorTokenKind.TemplateOutput, _text.GetText(false), _text.LexemeStartPosition, state);
                }
                if (isControlBegin)
                {
                    _text.AdvanceChar(_controlBegin.Length);
                    state = MetaGeneratorLexerState.TemplateControl;
                    _parenthesisCounter = 0;
                    _bracketsCounter = 0;
                    _bracesCounter = 0;
                    return new MetaGeneratorToken(MetaGeneratorTokenKind.TemplateControlBegin, _text.GetText(true), _text.LexemeStartPosition, state);
                }
                if (isTemplateEnd)
                {
                    state = MetaGeneratorLexerState.TemplateControl;
                }
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchWhitespace(ref MetaGeneratorLexerState state)
        {
            var ch = _text.PeekChar();
            if (ch == ' ' || ch == '\t')
            {
                while (ch == ' ' || ch == '\t')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                if (state == MetaGeneratorLexerState.ControlBegin) state = MetaGeneratorLexerState.ControlEndWs;
                if (state == MetaGeneratorLexerState.ControlEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.Whitespace, _text.GetText(_text.Width == 1), _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchComment(ref MetaGeneratorLexerState state)
        {
            var ch = _text.PeekChar();
            if (ch == '/' && _text.PeekChar(1) == '/')
            {
                while (!_text.IsReallyAtEnd() && ch != '\r' && ch != '\n')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlBegin) state = MetaGeneratorLexerState.None;
                if (state == MetaGeneratorLexerState.ControlEndWs || state == MetaGeneratorLexerState.ControlEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.SingleLineComment, _text.GetText(false), _text.LexemeStartPosition, state);
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
                if (state == MetaGeneratorLexerState.ControlBegin) state = hasNewLine ? MetaGeneratorLexerState.None : MetaGeneratorLexerState.ControlEndWs;
                if (state == MetaGeneratorLexerState.ControlEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.MultiLineComment, _text.GetText(false), _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchIdentifier(ref MetaGeneratorLexerState state)
        {
            var ch = _text.PeekChar();
            var nextCh = _text.PeekChar(1);
            if ((ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_') ||
                ch == '@' && (nextCh >= 'a' && nextCh <= 'z' || nextCh >= 'A' && nextCh <= 'Z' || nextCh == '_'))
            {
                var kind = MetaGeneratorTokenKind.Identifier;
                if (ch == '@')
                {
                    kind = MetaGeneratorTokenKind.VerbatimIdentifier;
                    _text.NextChar();
                }
                _text.NextChar();
                ch = _text.PeekChar();
                while (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_' || ch >= '0' && ch <= '9' || (kind == MetaGeneratorTokenKind.VerbatimIdentifier && ch == '-'))
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                var lexeme = _text.GetText(false);
                if (Keywords.Contains(lexeme) || ContextualKeywords.Contains(lexeme)) kind = MetaGeneratorTokenKind.Keyword;
                if (state == MetaGeneratorLexerState.None && TemplateKeywords.Contains(lexeme)) kind = MetaGeneratorTokenKind.Keyword;
                if (state == MetaGeneratorLexerState.TemplateControl && (TemplateControlKeywords.Contains(lexeme) || TemplateModifierKeywords.Contains(lexeme))) kind = MetaGeneratorTokenKind.Keyword;
                if (state == MetaGeneratorLexerState.ControlBeginWs && ControlShortcutKeywords.Contains(lexeme))
                {
                    kind = MetaGeneratorTokenKind.Keyword;
                    if (lexeme == "quots")
                    {
                        _controlBegin = "«";
                        _controlEnd = "»";
                    }
                }
                if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlEndWs ||
                    state == MetaGeneratorLexerState.ControlBegin || state == MetaGeneratorLexerState.ControlEnd) state = MetaGeneratorLexerState.None;
                if (kind == MetaGeneratorTokenKind.Keyword)
                {
                    if (state == MetaGeneratorLexerState.None && lexeme == "control")
                    {
                        state = MetaGeneratorLexerState.ControlBeginWs;
                        _controlBegin = "";
                        _controlEnd = "";
                    }
                    if (lexeme == "end")
                    {
                        if (state == MetaGeneratorLexerState.TemplateControl)
                        {
                            state = MetaGeneratorLexerState.End;
                        }
                    }
                    if (lexeme == "template")
                    {
                        if (state == MetaGeneratorLexerState.End)
                        {
                            state = MetaGeneratorLexerState.None;
                        }
                        else if (state == MetaGeneratorLexerState.None)
                        {
                            state = MetaGeneratorLexerState.TemplateHeader;
                        }
                    }
                    if (lexeme == "if" || lexeme == "switch" || lexeme == "do" || lexeme == "for" || lexeme == "foreach" || 
                        lexeme == "while" || lexeme == "try" || lexeme == "lock")
                    {
                        if (state == MetaGeneratorLexerState.End)
                        {
                            state = MetaGeneratorLexerState.TemplateControl;
                        }
                    }
                }
                return new MetaGeneratorToken(kind, lexeme, _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchNumber(ref MetaGeneratorLexerState state)
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
                if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlEndWs ||
                    state == MetaGeneratorLexerState.ControlBegin || state == MetaGeneratorLexerState.ControlEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.Number, _text.GetText(false), _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchString(ref MetaGeneratorLexerState state)
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
                if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlEndWs ||
                    state == MetaGeneratorLexerState.ControlBegin || state == MetaGeneratorLexerState.ControlEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.String, _text.GetText(false), _text.LexemeStartPosition, state);
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
                if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlEndWs ||
                    state == MetaGeneratorLexerState.ControlBegin || state == MetaGeneratorLexerState.ControlEnd) state = MetaGeneratorLexerState.None;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.VerbatimString, _text.GetText(false), _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchTemplateControlEnd(ref MetaGeneratorLexerState state)
        {
            if (state == MetaGeneratorLexerState.TemplateControl)
            {
                if (IsControlEnd())
                {
                    _text.AdvanceChar(_controlEnd.Length);
                    state = MetaGeneratorLexerState.TemplateOutput;
                    _parenthesisCounter = 0;
                    _bracketsCounter = 0;
                    _bracesCounter = 0;
                    return new MetaGeneratorToken(MetaGeneratorTokenKind.TemplateControlEnd, _text.GetText(true), _text.LexemeStartPosition, state);
                }
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchOther(ref MetaGeneratorLexerState state)
        {
            var ch = _text.NextChar();
            if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlBegin)
            {
                _controlBegin += ch;
                state = MetaGeneratorLexerState.ControlBegin;
            }
            if (state == MetaGeneratorLexerState.ControlEndWs || state == MetaGeneratorLexerState.ControlEnd)
            {
                _controlEnd += ch;
                state = MetaGeneratorLexerState.ControlEnd;
            }
            if (ch == '(') ++_parenthesisCounter;
            if (ch == ')')
            {
                --_parenthesisCounter;
                if (_parenthesisCounter == 0 && state == MetaGeneratorLexerState.TemplateHeader) state = MetaGeneratorLexerState.TemplateHeaderEnd;
            }
            if (ch == '[') ++_bracketsCounter;
            if (ch == ']') --_bracketsCounter;
            if (ch == '{') ++_bracesCounter;
            if (ch == '}') --_bracesCounter;
            return new MetaGeneratorToken(MetaGeneratorTokenKind.Other, _text.GetText(false), _text.LexemeStartPosition, state);
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
            "if", "case", "catch", "default", "do", "else", "finally", "for", "foreach", "lock", "switch", "try", "while"
        };

        public static readonly HashSet<string> BlockEndKeywords = new HashSet<string>()
        {
            "if", "for", "foreach", "lock", "switch", "try", "while"
        };

        public static readonly HashSet<string> BlockWithoutEndKeywords = new HashSet<string>()
        {
            "case", "catch", "default", "else", "finally"
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

        public static readonly HashSet<string> TemplateModifierKeywords = new HashSet<string>()
        {
            "@multi-line", "@single-line", "@skip-line-end"
        };

        public static readonly HashSet<string> ControlShortcutKeywords = new HashSet<string>()
        {
            "quots"
        };
    }
}
