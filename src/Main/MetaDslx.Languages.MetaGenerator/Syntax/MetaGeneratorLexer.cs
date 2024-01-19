using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Text.RegularExpressions;

namespace MetaDslx.Languages.MetaGenerator.Syntax
{
    public class MetaGeneratorLexer : IDisposable
    {
        private string _filePath;
        private SlidingTextWindow _text;
        private MetaGeneratorLexerState _state;
        private List<MetaGeneratorToken> _tokens;
        private bool _computeRelativeIndent;
        private bool _absoluteIndent;
        private List<MetaGeneratorToken> _indentStack;

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
            _state = MetaGeneratorLexerState.None;
            _tokens = new List<MetaGeneratorToken>();
            _absoluteIndent = false;
            _indentStack = new List<MetaGeneratorToken>();
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

        public MetaGeneratorToken Lex()
        {
            var token = FetchNextToken();
            if (token.Kind == MetaGeneratorTokenKind.EndOfLine || token.Kind == MetaGeneratorTokenKind.IgnoredEndOfLine)
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

        private MetaGeneratorToken FetchNextToken()
        {
            if (_state == MetaGeneratorLexerState.TemplateOutputLineStart && _tokens.Count == 0)
            {
                FetchTemplateOutputLine();
            }
            if (_tokens.Count > 0)
            {
                var token = _tokens[0];
                _tokens.RemoveAt(0);
                return token;
            }
            else
            {
                return NextToken();
            }
        }

        private void FetchTemplateOutputLine()
        {
            if (_tokens.Count > 0) return;
            bool computeRelativeIndent = _computeRelativeIndent;
            bool absoluteIndent = _absoluteIndent;
            bool isInControl = false;
            bool skip = false;
            bool emptyLine = true;
            var kind = ControlStatementKind.None;
            int parenthesisCounter = 0;
            int bracketCounter = 0;
            int bracesCounter = 0;
            int statementCount = 0;
            int expressionCount = 0;
            _computeRelativeIndent = false;
            while (true)
            {
                var token = NextToken();
                if (token.Kind != MetaGeneratorTokenKind.None)
                {
                    _tokens.Add(token);
                }
                if (token.Kind == MetaGeneratorTokenKind.EndOfFile ||
                    token.Kind == MetaGeneratorTokenKind.EndOfLine ||
                    token.Kind == MetaGeneratorTokenKind.IgnoredEndOfLine)
                {
                    break;
                }
            }
            if (_tokens.Count == 0) return;
            for (int i = 0; i < _tokens.Count; i++)
            {
                var token = _tokens[i];
                if (!isInControl && token.Kind == MetaGeneratorTokenKind.Keyword && token.Text == "end")
                {
                    emptyLine = false;
                    return;
                }
                if (token.Kind == MetaGeneratorTokenKind.TemplateOutputText)
                {
                    emptyLine = false;
                    ++expressionCount;
                    continue;
                }
                if (token.Kind == MetaGeneratorTokenKind.TemplateControlBegin)
                {
                    isInControl = true;
                    skip = false;
                    kind = ControlStatementKind.Expression;
                    continue;
                }
                if (isInControl && !skip)
                {
                    switch (token.Kind)
                    {
                        case MetaGeneratorTokenKind.None:
                        case MetaGeneratorTokenKind.EndOfFile:
                        case MetaGeneratorTokenKind.Whitespace:
                        case MetaGeneratorTokenKind.EndOfLine:
                        case MetaGeneratorTokenKind.IgnoredEndOfLine:
                        case MetaGeneratorTokenKind.SingleLineComment:
                        case MetaGeneratorTokenKind.MultiLineComment:
                            continue;
                        default:
                            break;
                    }
                    if (token.Kind == MetaGeneratorTokenKind.Keyword && token.Text == "end")
                    {
                        kind = ControlStatementKind.EndStatement;
                        skip = true;
                        continue;
                    }
                    if (token.Kind == MetaGeneratorTokenKind.Keyword && BlockKeywords.Contains(token.Text))
                    {
                        kind = ControlStatementKind.BeginStatement;
                        skip = true;
                        continue;
                    }
                    if (token.Kind == MetaGeneratorTokenKind.FormatterKeyword && TemplateFormatterKeywords.Contains(token.Text))
                    {
                        kind = ControlStatementKind.Statement;
                        skip = true;
                        continue;
                    }
                    if (token.Kind == MetaGeneratorTokenKind.Other)
                    {
                        if (parenthesisCounter == 0 && bracketCounter == 0 && bracesCounter == 0)
                        {
                            if (token.Text == "=")
                            {
                                var nextToken = i + 1 < _tokens.Count ? _tokens[i + 1] : MetaGeneratorToken.None;
                                if (nextToken.Kind == MetaGeneratorTokenKind.Other && nextToken.Text == "=")
                                {
                                    ++i;
                                    continue;
                                }
                                else if (kind == ControlStatementKind.Expression)
                                {
                                    kind = ControlStatementKind.Statement;
                                    skip = true;
                                    continue;
                                }
                            }
                            if (token.Text == ";")
                            {
                                if (kind == ControlStatementKind.Expression || kind == ControlStatementKind.Statement)
                                {
                                    kind = ControlStatementKind.StatementWithSemicolon;
                                    skip = true;
                                    continue;
                                }
                            }
                        }
                        if (token.Text == "(") ++parenthesisCounter;
                        if (token.Text == ")") --parenthesisCounter;
                        if (token.Text == "[") ++bracketCounter;
                        if (token.Text == "]") --bracketCounter;
                        if (token.Text == "{") ++bracesCounter;
                        if (token.Text == "}") --bracesCounter;
                    }
                }
                if (token.Kind == MetaGeneratorTokenKind.TemplateControlEnd)
                {
                    isInControl = false;
                    switch (kind)
                    {
                        case ControlStatementKind.Expression:
                            ++expressionCount;
                            emptyLine = false;
                            break;
                        case ControlStatementKind.Statement:
                        case ControlStatementKind.StatementWithSemicolon:
                        case ControlStatementKind.BeginStatement:
                        case ControlStatementKind.EndStatement:
                            ++statementCount;
                            emptyLine = false;
                            break;
                        default:
                            break;
                    }
                    continue;
                }
            }
            var lastKind = kind;
            if (lastKind == ControlStatementKind.BeginStatement)
            {
                _computeRelativeIndent = true;
            }
            var lastToken = _tokens[_tokens.Count - 1];
            if (lastToken.Kind == MetaGeneratorTokenKind.EndOfLine && expressionCount == 0 && !emptyLine)
            {
                lastToken.Kind = MetaGeneratorTokenKind.IgnoredEndOfLine;
                _tokens[_tokens.Count - 1] = lastToken;
            }
            var firstToken = _tokens[0];
            if (firstToken.Kind == MetaGeneratorTokenKind.TemplateOutputWhitespace)
            {
                if (expressionCount == 0 && !emptyLine)
                {
                    firstToken.Kind = MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace;
                    _tokens[0] = firstToken;
                }
            }
            else
            {
                firstToken = new MetaGeneratorToken(expressionCount > 0 ? MetaGeneratorTokenKind.TemplateOutputWhitespace : MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace, "", firstToken.Position, MetaGeneratorLexerState.TemplateOutput);
                _tokens.Insert(0, firstToken);
            }
            bool replaceFirstToken = !absoluteIndent && expressionCount > 0 && firstToken.Text.Length > 0;
            if (replaceFirstToken) _tokens.RemoveAt(0);
            bool recomputeIndentStack = computeRelativeIndent;// || expressionCount == 0 && statementCount > 0;
            var newIndentStack = recomputeIndentStack ? ArrayBuilder<MetaGeneratorToken>.GetInstance() : null;
            var whitespacePosition = firstToken.Position;
            var firstWhitespace = firstToken.Text;
            bool isValid = true;
            for (int i = 0; i < _indentStack.Count; ++i)
            {
                var indent = _indentStack[i];
                if (firstWhitespace.StartsWith(indent.Text))
                {
                    if (replaceFirstToken) _tokens.Insert(i, new MetaGeneratorToken(indent.Kind, indent.Text, whitespacePosition, MetaGeneratorLexerState.TemplateOutput));
                    if (recomputeIndentStack) newIndentStack.Add(indent);
                    whitespacePosition += indent.Text.Length;
                    firstWhitespace = firstWhitespace.Substring(indent.Text.Length);
                    if (firstWhitespace.Length == 0) break;
                }
                else if (indent.Text.StartsWith(firstWhitespace))
                {
                    if (replaceFirstToken) _tokens.Insert(i, new MetaGeneratorToken(indent.Kind, firstWhitespace, whitespacePosition, MetaGeneratorLexerState.TemplateOutput));
                    if (recomputeIndentStack) newIndentStack.Add(new MetaGeneratorToken(indent.Kind, firstWhitespace, whitespacePosition, MetaGeneratorLexerState.TemplateOutput));
                    whitespacePosition += firstWhitespace.Length;
                    firstWhitespace = string.Empty;
                    break;
                }
                else
                {
                    if (replaceFirstToken) _tokens.Insert(i, new MetaGeneratorToken(MetaGeneratorTokenKind.TemplateOutputInvalidWhitespace, firstWhitespace, whitespacePosition, MetaGeneratorLexerState.TemplateOutput));
                    if (recomputeIndentStack) newIndentStack.Add(new MetaGeneratorToken(MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace, firstWhitespace, whitespacePosition, MetaGeneratorLexerState.TemplateOutput));
                    whitespacePosition += firstWhitespace.Length;
                    firstWhitespace = string.Empty;
                    isValid = false;
                    break;
                }
            }
            if (isValid && firstWhitespace.Length > 0)
            {
                if (replaceFirstToken) _tokens.Insert(_indentStack.Count, new MetaGeneratorToken(recomputeIndentStack ? MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace : MetaGeneratorTokenKind.TemplateOutputWhitespace, firstWhitespace, whitespacePosition, MetaGeneratorLexerState.TemplateOutput));
                if (recomputeIndentStack) newIndentStack.Add(new MetaGeneratorToken(MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace, firstWhitespace, whitespacePosition, MetaGeneratorLexerState.TemplateOutput));
            }
            if (recomputeIndentStack)
            {
                _indentStack.Clear();
                _indentStack.AddRange(newIndentStack);
                newIndentStack.Free();
            }
            if (lastToken.Kind == MetaGeneratorTokenKind.EndOfLine)
            {
                var hasWhitespace = false;
                for (int i = 0; i < _tokens.Count; ++i)
                {
                    if (_tokens[i].Kind.IsTemplateWhitespace())
                    {
                        if (_tokens[i].Kind != MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace) hasWhitespace = true;
                    }
                    else
                    {
                        break;
                    }
                }
                if (!hasWhitespace)
                {
                    _tokens.Insert(0, new MetaGeneratorToken(MetaGeneratorTokenKind.TemplateOutputWhitespace, "", firstToken.Position, MetaGeneratorLexerState.TemplateOutput));
                }
            }
            else if (lastToken.Kind == MetaGeneratorTokenKind.IgnoredEndOfLine)
            {
                for (int i = 0; i < _tokens.Count; ++i)
                {
                    if (_tokens[i].Kind.IsTemplateWhitespace())
                    {
                        if (_tokens[i].Kind != MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace)
                        {
                            var token = _tokens[i];
                            token.Kind = MetaGeneratorTokenKind.TemplateOutputIgnoredWhitespace;
                            _tokens[i] = token;
                        }
                    }
                    else
                    {
                        break;
                    }
                }
            }
            if (lastKind == ControlStatementKind.BeginStatement) _computeRelativeIndent = true;
        }

        private MetaGeneratorToken NextToken()
        {
            if (_state == MetaGeneratorLexerState.Eof)
            {
                return MetaGeneratorToken.None;
            }
            if (_text.IsReallyAtEnd())
            {
                _state = MetaGeneratorLexerState.Eof;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.EndOfFile, string.Empty, _text.LexemeStartPosition, _state);
            }
            _text.Start();
            var token = MatchLineEnd(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchTemplateOutput(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchTemplateFormatter(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchTemplateControlEnd(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchWhitespace(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchComment(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchIdentifier(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchNumber(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchString(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            token = MatchOther(ref _state);
            if (token.Kind != MetaGeneratorTokenKind.None) return token;
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchLineEnd(ref MetaGeneratorLexerState state)
        {
            var ch = _text.PeekChar();
            var lexemeLength = 0;
            if (ch == '\r' && _text.PeekChar(1) == '\n') lexemeLength = 2;
            else if (ch == '\n') lexemeLength = 1;
            if (lexemeLength > 0)
            {
                _text.AdvanceChar(lexemeLength);
                if (state == MetaGeneratorLexerState.TemplateHeaderEnd)
                {
                    state = MetaGeneratorLexerState.TemplateOutputLineStart;
                    _computeRelativeIndent = true;
                    _absoluteIndent = false;
                    _indentStack.Clear();
                }
                else if (state == MetaGeneratorLexerState.TemplateOutput)
                {
                    state = MetaGeneratorLexerState.TemplateOutputLineStart;
                }
                else if (state == MetaGeneratorLexerState.ControlBeginWs || state == MetaGeneratorLexerState.ControlEndWs ||
                    state == MetaGeneratorLexerState.ControlBegin || state == MetaGeneratorLexerState.ControlEnd ||
                    state == MetaGeneratorLexerState.TemplateEnd)
                {
                    state = MetaGeneratorLexerState.None;
                }
                return new MetaGeneratorToken(MetaGeneratorTokenKind.EndOfLine, _text.GetText(true), _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchTemplateOutput(ref MetaGeneratorLexerState state)
        {
            if (state == MetaGeneratorLexerState.TemplateOutputLineStart || state == MetaGeneratorLexerState.TemplateOutput)
            {
                var kind = MetaGeneratorTokenKind.None;
                var ch = _text.PeekChar();
                var isControlBegin = IsControlBegin();
                var isTemplateEnd = IsTemplateEnd();
                while (!_text.IsReallyAtEnd() && !isControlBegin && !isTemplateEnd && ch != '\r' && ch != '\n')
                {
                    if (ch == ' ' || ch == '\t')
                    {
                        if (kind == MetaGeneratorTokenKind.TemplateOutputText) break;
                        else kind = MetaGeneratorTokenKind.TemplateOutputWhitespace;
                    }
                    else
                    {
                        if (kind == MetaGeneratorTokenKind.TemplateOutputWhitespace) break;
                        else kind = MetaGeneratorTokenKind.TemplateOutputText;
                    }
                    _text.NextChar();
                    ch = _text.PeekChar();
                    isControlBegin = IsControlBegin();
                    isTemplateEnd = IsTemplateEnd();
                }
                if (kind != MetaGeneratorTokenKind.None)
                {
                    state = MetaGeneratorLexerState.TemplateOutput;
                    return new MetaGeneratorToken(kind, _text.GetText(false), _text.LexemeStartPosition, state);
                }
                if (isControlBegin)
                {
                    _text.AdvanceChar(_controlBegin.Length);
                    if (IsTemplateFormatter()) state = MetaGeneratorLexerState.TemplateFormatter;
                    else state = MetaGeneratorLexerState.TemplateControl;
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

        private bool IsTemplateFormatter()
        {
            var isControlEnd = IsControlEnd(1);
            if (!isControlEnd) return false;
            var ch = _text.PeekChar();
            switch (ch)
            {
                case '=':
                case '-':
                case '\\':
                case '>':
                case '<':
                    return true;
                default:
                    return false;
            }
        }

        private MetaGeneratorToken MatchTemplateFormatter(ref MetaGeneratorLexerState state)
        {
            if (state != MetaGeneratorLexerState.TemplateFormatter) return MetaGeneratorToken.None;
            if (IsTemplateFormatter())
            {
                _text.NextChar();
                var lexeme = _text.GetText(true);
                if (lexeme == AbsoluteIndentKeyword) _absoluteIndent = true;
                if (lexeme == RelativeIndentKeyword) _absoluteIndent = false;
                state = MetaGeneratorLexerState.TemplateControl;
                return new MetaGeneratorToken(MetaGeneratorTokenKind.FormatterKeyword, lexeme, _text.LexemeStartPosition, state);
            }
            return MetaGeneratorToken.None;
        }

        private MetaGeneratorToken MatchIdentifier(ref MetaGeneratorLexerState state)
        {
            var ch = _text.PeekChar();
            var nextCh = _text.PeekChar(1);
            if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_' ||
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
                while (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_' || ch >= '0' && ch <= '9')
                {
                    _text.NextChar();
                    ch = _text.PeekChar();
                }
                var lexeme = _text.GetText(false);
                if (Keywords.Contains(lexeme) || ContextualKeywords.Contains(lexeme)) kind = MetaGeneratorTokenKind.Keyword;
                if (state == MetaGeneratorLexerState.None && TemplateKeywords.Contains(lexeme)) kind = MetaGeneratorTokenKind.Keyword;
                if (state == MetaGeneratorLexerState.TemplateControl && TemplateControlKeywords.Contains(lexeme)) kind = MetaGeneratorTokenKind.Keyword;
                if (state == MetaGeneratorLexerState.ControlBeginWs && ControlShortcutKeywords.Contains(lexeme))
                {
                    kind = MetaGeneratorTokenKind.Keyword;
                    if (lexeme == DefaultKeyword)
                    {
                        _controlBegin = "[";
                        _controlEnd = "]";
                    }
                    else if (lexeme == QuotsKeyword)
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

        private bool IsControlBegin(int delta = 0)
        {
            var ch = _text.PeekChar(delta);
            if (_controlBegin.Length > 0 && ch == _controlBegin[0])
            {
                for (int i = 1; i < _controlBegin.Length; ++i)
                {
                    if (_text.PeekChar(delta+i) != _controlBegin[i])
                    {
                        return false;
                    }
                }
                return true;
            }
            return false;
        }

        private bool IsControlEnd(int delta = 0)
        {
            if (_parenthesisCounter > 0 || _bracketsCounter > 0 || _bracesCounter > 0) return false;
            var ch = _text.PeekChar(delta);
            if (_controlEnd.Length > 0 && ch == _controlEnd[0])
            {
                for (int i = 1; i < _controlEnd.Length; ++i)
                {
                    if (_text.PeekChar(delta+i) != _controlEnd[i])
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

        public const string SeparatorKeyword = "separator";

        public static readonly HashSet<string> TemplateControlKeywords = new HashSet<string>()
        {
            "end", "template", SeparatorKeyword
        };

        public const string MultiLineKeyword = "=";
        public const string SingleLineKeyword = "-";
        public const string SkipLineEndKeyword = "\\";
        public const string RelativeIndentKeyword = ">";
        public const string AbsoluteIndentKeyword = "<";

        public static readonly HashSet<string> TemplateFormatterKeywords = new HashSet<string>()
        {
            MultiLineKeyword, SingleLineKeyword, SkipLineEndKeyword, RelativeIndentKeyword, AbsoluteIndentKeyword,
        };

        public const string QuotsKeyword = "chevrons";
        public const string DefaultKeyword = "default";

        public static readonly HashSet<string> ControlShortcutKeywords = new HashSet<string>()
        {
            DefaultKeyword, QuotsKeyword
        };
    }
}
