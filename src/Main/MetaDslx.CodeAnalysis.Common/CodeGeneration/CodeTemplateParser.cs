using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeGeneration;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;

namespace MetaDslx.CodeAnalysis.CodeGeneration
{
    public class CodeTemplateParser
    {
        private struct ControlStatement
        {
            public string Text;
            public bool IsExpression;
            public CodeTemplateToken BeginKeyword;
            public CodeTemplateToken EndKeyword;
            public string? Separator;

            public ControlStatement()
            {
                Text = "";
                IsExpression = false;
                BeginKeyword = CodeTemplateToken.None;
                EndKeyword = CodeTemplateToken.None;
                Separator = null;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private string _filePath;
        private string _templateCode;
        private string? _compiledCode;
        private CodeTemplateLexer _lexer;
        private CodeTemplateTokenStream _tokens;
        private CodeBuilder? _sb;
        private string? _generatorName;
        private (int,int) _generatorLineMap;
        private DiagnosticBag? _diagnosticBag;
        private ImmutableArray<Diagnostic> _diagnostics;

        public CodeTemplateParser(string filePath, string templateCode)
        {
            _filePath = filePath;
            _templateCode = templateCode;
        }

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        public string Compile()
        {
            if (_compiledCode != null) return _compiledCode;
            using (_lexer = new CodeTemplateLexer(_filePath, SourceText.From(_templateCode), true))
            {
                _tokens = new CodeTemplateTokenStream(_lexer);
                _sb = CodeBuilder.GetInstance();
                _diagnosticBag = DiagnosticBag.GetInstance();
                ParseNamespace();
                _compiledCode = _sb.ToStringAndFree();
                _sb = null;
                _diagnosticBag.AddRange(_lexer.GetDiagnostics());
                _diagnostics = _diagnosticBag.ToReadOnlyAndFree();
                _diagnosticBag = null;
            }
            return _compiledCode;
        }

        private void ParseNamespace()
        {
            SkipWs();
            var map = LineMap();
            if (MatchKeyword("namespace"))
            {
                _sb.Write("namespace");
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else _tokens.EatToken();
                    _sb.Write(token.Text);
                }
                _sb.WriteLine(LineMapComment(map));
                _sb.Write("{");
                _sb.Push();
                if (ParseGenerator())
                {
                    ParseControl();
                    while (ParseUsing());
                    _sb.WriteLine();
                    _sb.Write("public partial class");
                    _sb.Write(_generatorName);
                    _sb.WriteLine(LineMapComment(_generatorLineMap));
                    _sb.WriteLine("{");
                    _sb.Push();
                    ParseTemplate();
                    //while (ParseTemplate()) ;
                    _sb.Pop();
                    _sb.Write("}");
                }
                _sb.Pop();
                _sb.Write("}");
            }
        }

        private bool ParseGenerator()
        {
            SkipWs();
            _generatorLineMap = LineMap();
            if (MatchKeyword("generator"))
            {
                var gnsb = PooledStringBuilder.GetInstance();
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else _tokens.EatToken();
                    gnsb.Builder.Append(token.Text);
                }
                _generatorName = gnsb.ToStringAndFree();
                return true;
            }
            return false;
        }

        private bool ParseControl()
        {
            SkipWs();
            if (IsKeyword("control"))
            {
                var incCounter = true;
                var _controlBegin = "";
                var _controlEnd = "";
                var counter = 0;
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else _tokens.EatToken();
                    if (IsWhitespaceOrComment(token))
                    {
                        if (incCounter) ++counter;
                        incCounter = false;
                        continue;
                    }
                    if (counter == 1) _controlBegin += token.Text;
                    else if (counter == 2) _controlEnd += token.Text;
                    else if (counter == 3) Unexpected();
                    incCounter = true;
                }
                if (counter == 0)
                {
                    Error("Template control begin sequence is expected");
                }
                else if (counter == 1)
                {
                    Error("Template control end sequence is expected");
                }
                else
                {
                    _lexer.ControlBegin = _controlBegin;
                    _lexer.ControlEnd = _controlEnd;
                }
                return true;
            }
            return false;
        }

        private bool ParseUsing()
        {
            SkipWs();
            var map = LineMap();
            if (IsKeyword("using"))
            {
                _tokens.EatToken();
                _sb.Write("using");
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else _tokens.EatToken();
                    _sb.Write(token.Text);
                }
                _sb.Write(";");
                _sb.WriteLine(LineMapComment(map));
                return true;
            }
            return false;
        }

        private bool ParseTemplate()
        {
            SkipWs();
            var map = LineMap();
            if (IsKeyword("template"))
            {
                _tokens.EatToken();
                _sb.Write("public string");
                while (_tokens.State == CodeTemplateLexerState.TemplateHeader)
                {
                    var token = _tokens.CurrentToken;
                    if (_tokens.State == CodeTemplateLexerState.TemplateHeader)
                    {
                        _sb.Write(token.Text);
                    }
                    _tokens.EatToken();
                }
                SkipWs();
                _sb.WriteLine(LineMapComment(map));
                _sb.WriteLine("{");
                _sb.Push();
                _sb.WriteLine("var __cb = CodeBuilder.GetInstance();");
                string? indent = null;
                bool indentWritten = false;
                ParseTemplateContent(CodeTemplateToken.None, ref indent, ref indentWritten);
                _sb.WriteLine("return __cb.ToStringAndFree();");
                _sb.Pop();
                _sb.WriteLine("}");
                _sb.WriteLine();
                return true;
            }
            return false;
        }

        private void ParseTemplateContent(CodeTemplateToken beginKeyword, ref string? indent, ref bool indentWritten)
        {
            while (!_tokens.EndOfFile)
            {
                var token = _tokens.CurrentToken;
                if (IsTemplateEnd())
                {
                    if (beginKeyword.Kind == CodeTemplateTokenKind.Keyword)
                    {
                        if (indentWritten)
                        {
                            _sb.WriteLine("__cb.Pop();");
                            indentWritten = false;
                        }
                        _sb.Pop();
                        _sb.WriteLine("}");
                        Error($"[end {beginKeyword.Text}] is expected");
                    }
                    return;
                }
                else if (_tokens.State == CodeTemplateLexerState.TemplateOutput)
                {
                    ParseTemplateOutput(ref indent, ref indentWritten);
                }
                else if (_tokens.State == CodeTemplateLexerState.TemplateControl)
                {
                    if (ParseTemplateControl(beginKeyword, ref indent, ref indentWritten)) return;
                }
                else
                {
                    break;
                }
            }
        }

        private void ParseTemplateOutput(ref string? indent, ref bool indentWritten)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == CodeTemplateTokenKind.TemplateOutput)
            {
                if (_tokens.Column == 0 && string.IsNullOrWhiteSpace(token.Text))
                {
                    indent = token.EscapedTextForString;
                    indentWritten = false;
                }
                else
                {
                    if (!indentWritten && indent != null)
                    {
                        _sb.Write("__cb.Push(\"");
                        _sb.Write(indent);
                        _sb.WriteLine("\");");
                        indentWritten = true;
                    }
                    _sb.Write("__cb.Write(\"");
                    _sb.Write(token.EscapedTextForString);
                    _sb.WriteLine("\");");
                }
                _tokens.EatToken();
            }
            else if (token.Kind == CodeTemplateTokenKind.EndOfLine)
            {
                if (indentWritten)
                {
                    _sb.WriteLine("__cb.WriteLine();");
                    _sb.WriteLine("__cb.Pop();");
                    indentWritten = false;
                }
                indent = null;
                _tokens.EatToken();
            }
            else if (token.Kind == CodeTemplateTokenKind.TemplateControlBegin)
            {
                _tokens.EatToken();
            }
        }

        private bool ParseTemplateControl(CodeTemplateToken beginKeyword, ref string? indent, ref bool indentWritten)
        {
            var stmt = TryMatchControlStatement();
            if (!string.IsNullOrWhiteSpace(stmt.Text) || stmt.EndKeyword.Kind == CodeTemplateTokenKind.Keyword)
            {
                if (stmt.IsExpression)
                {
                    if (!indentWritten && indent != null)
                    {
                        _sb.Write("__cb.Push(\"");
                        _sb.Write(indent);
                        _sb.WriteLine("\");");
                        indentWritten = true;
                    }
                    _sb.Write("__cb.Write(");
                    _sb.Write(stmt.Text);
                    _sb.WriteLine(");");
                }
                else if (stmt.BeginKeyword.Kind != CodeTemplateTokenKind.None)
                {
                    var lexeme = stmt.BeginKeyword.Text;
                    if (stmt.Separator != null && (lexeme == "do" || lexeme == "for" || lexeme == "foreach" || lexeme == "while"))
                    {
                        _sb.WriteLine("var __first = true;");
                    }
                    _sb.WriteLine(stmt.Text);
                    _sb.WriteLine("{");
                    _sb.Push();
                    if (stmt.Separator != null && (lexeme == "do" || lexeme == "for" || lexeme == "foreach" || lexeme == "while"))
                    {
                        _sb.WriteLine("if (__first) __first = false;");
                        _sb.Write($"else __cb.Write(");
                        _sb.Write(stmt.Separator);
                        _sb.WriteLine(");");
                    }
                    ParseTemplateContent(stmt.BeginKeyword, ref indent, ref indentWritten);
                }
                else if (stmt.EndKeyword.Kind != CodeTemplateTokenKind.None)
                {
                    if (beginKeyword.Kind == CodeTemplateTokenKind.None)
                    {
                        Error($"[end {stmt.EndKeyword.Text}] is unexpected here");
                        return false;
                    }
                    else if (beginKeyword.Kind == CodeTemplateTokenKind.Keyword && stmt.EndKeyword.Text != beginKeyword.Text)
                    {
                        Error($"[end {beginKeyword.Text}] is expected but [end {stmt.EndKeyword.Text}] was found");
                    }
                    if (indentWritten)
                    {
                        _sb.WriteLine("__cb.Pop();");
                        indentWritten = false;
                    }
                    _sb.Pop();
                    _sb.WriteLine("}");
                    return true;
                }
                else
                {
                    _sb.WriteLine(stmt.Text);
                }
            }
            return false;
        }

        private void SkipWs()
        {
            while (IsWhitespaceOrComment()) _tokens.EatToken();
        }

        private ControlStatement TryMatchControlStatement()
        {
            SkipWs();
            ControlStatement result = new ControlStatement();
            var token = _tokens.CurrentToken;
            int parenthesisCounter = 0;
            int bracketCounter = 0;
            int bracesCounter = 0;
            if (token.Kind == CodeTemplateTokenKind.Keyword)
            {
                var lexeme = token.Text;
                if (lexeme == "if" || lexeme == "switch" || lexeme == "do" || lexeme == "for" || lexeme == "foreach" ||
                    lexeme == "while" || lexeme == "try" || lexeme == "catch" || lexeme == "finally" || lexeme == "lock")
                {
                    result.BeginKeyword = token;
                }
                else if (lexeme == "end")
                {
                    _tokens.EatToken();
                    while (IsWhitespaceOrComment()) _tokens.EatToken();
                    token = _tokens.CurrentToken;
                    if (token.Kind == CodeTemplateTokenKind.Keyword)
                    {
                        lexeme = token.Text;
                        if (lexeme == "if" || lexeme == "switch" || lexeme == "do" || lexeme == "for" || lexeme == "foreach" ||
                            lexeme == "while" || lexeme == "try" || lexeme == "lock")
                        {
                            result.EndKeyword = token;
                            _tokens.EatToken();
                            token = _tokens.CurrentToken;
                        }
                    }
                    bool error = false;
                    while (token.Kind != CodeTemplateTokenKind.EndOfFile && token.Kind != CodeTemplateTokenKind.TemplateControlEnd)
                    {
                        if (!IsWhitespaceOrComment() && !error)
                        {
                            Unexpected();
                            error = true;
                        }
                        _tokens.EatToken();
                        token = _tokens.CurrentToken;
                    }
                    return result;
                }
            }
            else
            {
                result.IsExpression = true;
            }
            bool collectSeparator = false;
            var sb = PooledStringBuilder.GetInstance();
            while (token.Kind != CodeTemplateTokenKind.None)
            {
                token = _tokens.CurrentToken;
                _tokens.EatToken();
                if (token.Kind == CodeTemplateTokenKind.EndOfFile || token.Kind == CodeTemplateTokenKind.TemplateControlEnd)
                {
                    if (collectSeparator)
                    {
                        result.Separator = sb.ToStringAndFree();
                    }
                    else
                    {
                        if (!result.IsExpression) sb.Builder.Append(";");
                        result.Text = sb.ToStringAndFree();
                    }
                    return result;
                }
                sb.Builder.Append(token.Text);
                if (token.Kind == CodeTemplateTokenKind.Other)
                {
                    if (!collectSeparator && token.Text == "=")
                    {
                        if (parenthesisCounter == 0 && bracketCounter == 0 && bracesCounter == 0)
                        {
                            var nextToken = _tokens.PeekToken();
                            if (!(nextToken.Kind == CodeTemplateTokenKind.Other && nextToken.Text == "="))
                            {
                                result.IsExpression = false;
                            }
                        }
                    }
                    if (token.Text == "(") ++parenthesisCounter;
                    if (token.Text == ")")
                    {
                        --parenthesisCounter;
                        if (result.BeginKeyword.Kind == CodeTemplateTokenKind.Keyword && !collectSeparator && TryMatchSeparator())
                        {
                            var lexeme = result.BeginKeyword.Text;
                            if (lexeme == "do" || lexeme == "for" || lexeme == "foreach" || lexeme == "while")
                            {
                                result.Text = sb.ToStringAndFree();
                                sb = PooledStringBuilder.GetInstance();
                                collectSeparator = true;
                            }
                            else
                            {
                                Unexpected();
                            }
                        }
                    }
                    if (token.Text == "[") ++bracketCounter;
                    if (token.Text == "]") --bracketCounter;
                    if (token.Text == "{") ++bracesCounter;
                    if (token.Text == "}") --bracesCounter;
                    if (token.Text == ";" && parenthesisCounter == 0 && bracketCounter == 0 && bracesCounter == 0)
                    {
                        if (collectSeparator) result.Separator = sb.ToStringAndFree();
                        else result.Text = sb.ToStringAndFree();
                        result.IsExpression = false;
                        return result;
                    }
                }
            }
            if (collectSeparator)
            {
                result.Separator = sb.ToStringAndFree();
            }
            else
            {
                if (!result.IsExpression) sb.Builder.Append(";");
                result.Text = sb.ToStringAndFree();
            }
            return result;
        }

        private bool TryMatchEndOfLine(bool allowSemicolon = true)
        {
            var token = _tokens.CurrentToken;
            if (allowSemicolon && token.Kind == CodeTemplateTokenKind.Other && token.Text == ";")
            {
                _tokens.EatToken();
                return true;
            }
            if (token.Kind == CodeTemplateTokenKind.EndOfLine)
            {
                _tokens.EatToken();
                return true;
            }
            if (token.Kind == CodeTemplateTokenKind.EndOfFile)
            {
                return true;
            }
            return false;
        }

        private bool TryMatchSeparator()
        {
            int index = 0;
            var token = _tokens.PeekToken(index++);
            if (IsKeyword(token, "separator"))
            {
                _tokens.EatToken();
                return true;
            }
            while (IsWhitespaceOrComment(token))
            {
                token = _tokens.PeekToken(index++);
                if (IsKeyword(token, "separator"))
                {
                    for (int i = 0; i < index; i++)
                    {
                        _tokens.EatToken();
                    }
                    return true;
                }
            }
            return false;
        }

        private bool IsTemplateEnd()
        {
            int index = 0;
            var token = _tokens.PeekToken(index++);
            while (IsWhitespaceOrComment(token)) token = _tokens.PeekToken(index++);
            if (IsKeyword(token, "end"))
            {
                token = _tokens.PeekToken(index++);
            }
            else
            {
                return false;
            }
            while (IsWhitespaceOrComment(token)) token = _tokens.PeekToken(index++);
            if (IsKeyword(token, "template"))
            {
                return true;
            }
            return false;
        }

        private bool IsKeyword(string text)
        {
            return IsKeyword(_tokens.CurrentToken, text);
        }

        private bool IsKeyword(CodeTemplateToken token, string text)
        {
            return token.Kind == CodeTemplateTokenKind.Keyword && token.Text == text;
        }

        private bool MatchKeyword(string text)
        {
            if (IsKeyword(text))
            {
                _tokens.EatToken();
                return true;
            }
            else
            {
                Expected(text);
                return false;
            }
        }

        private bool IsWhitespaceOrComment()
        {
            return IsWhitespaceOrComment(_tokens.CurrentToken);
        }

        private bool IsWhitespaceOrComment(CodeTemplateToken token)
        {
            return token.Kind == CodeTemplateTokenKind.EndOfLine || token.Kind == CodeTemplateTokenKind.Whitespace || token.Kind == CodeTemplateTokenKind.SingleLineComment || token.Kind == CodeTemplateTokenKind.MultiLineComment;
        }

        private void Error(string message)
        {
            var token = _tokens.CurrentToken;
            _diagnosticBag.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, Location.Create(_filePath, new TextSpan(token.Position, token.Text.Length), new LinePositionSpan(new LinePosition(_tokens.Line, _tokens.Column), new LinePosition(_tokens.Line, _tokens.Column + token.Text.Length))), message));
        }

        private void Expected(params string[] texts)
        {
            var token = _tokens.CurrentToken;
            var sb = PooledStringBuilder.GetInstance();
            foreach (var text in texts)
            {
                if (sb.Length > 0) sb.Builder.Append(" or ");
                sb.Builder.Append('\'');
                sb.Builder.Append(text);
                sb.Builder.Append('\'');
            }
            sb.Builder.Append($" is expected but '{token.EscapedText}' was found");
            Error(sb.ToStringAndFree());
        }

        private void Unexpected()
        {
            var token = _tokens.CurrentToken;
            Error($"'{token.EscapedText}' is unexpected here");
        }

        private (int line, int column) LineMap()
        {
            return (_tokens.Line, _tokens.Column);
        }

        private string LineMapComment((int line, int column) map)
        {
            return $" //#mgen#{map.line + 1}:{map.column + 1}";
        }
    }
}
