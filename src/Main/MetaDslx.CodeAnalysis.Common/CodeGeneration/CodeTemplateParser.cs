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
        private enum ParserState
        {
            None,
            BeginNamespace,
            EndNamespace,
            BeginGenerator,
            EndGenerator,
            BeginControl,
            EndControl,
            BeginUsing,
            EndUsing,
            BeginTemplate,
            TemplateBody,
            EndTemplate,
        }

        private string _filePath;
        private string _templateCode;
        private string? _compiledCode;
        private CodeTemplateLexer _lexer;
        private CodeTemplateTokenStream _tokens;
        private ParserState _state;
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
                _sb.Write("namespace ");
                while (true)
                {
                    var token = _tokens.NextToken();
                    if (TryMatchEndOfLine()) break;
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
                    _sb.Write("public partial class ");
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
                    var token = _tokens.NextToken();
                    if (TryMatchEndOfLine()) break;
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
                    var token = _tokens.NextToken();
                    if (TryMatchEndOfLine()) break;
                    if (IsWhitespaceOrComment())
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
                _sb.Write("using");
                while (true)
                {
                    var token = _tokens.NextToken();
                    if (TryMatchEndOfLine()) break;
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
                _sb.Write("public string ");
                while (_tokens.State == CodeTemplateLexerState.TemplateHeader)
                {
                    var token = _tokens.NextToken();
                    if (_tokens.State == CodeTemplateLexerState.TemplateHeader)
                    {
                        _sb.Write(token.Text);
                    }
                }
                _sb.WriteLine(LineMapComment(map));
                _sb.WriteLine("{");
                _sb.Push();
                _sb.WriteLine("var __cb = CodeBuilder.GetInstance();");
                ParseTemplateOutput();
                _sb.WriteLine("return __cb.ToStringAndFree();");
                _sb.Pop();
                _sb.WriteLine("}");
                _sb.WriteLine();
                return true;
            }
            return false;
        }

        private void ParseTemplateOutput()
        {
            string? indent = null;
            var hasExpression = false;
            while (!_tokens.EndOfFile)
            {
                var token = _tokens.NextToken();
                if (token.Kind == CodeTemplateTokenKind.TemplateOutput)
                {
                    if (_tokens.Column == 0 && string.IsNullOrWhiteSpace(token.Text))
                    {
                        indent = token.EscapedTextForString;
                    }
                    else
                    {
                        _sb.Write("__cb.Write(\"");
                        _sb.Write(token.EscapedTextForString);
                        _sb.WriteLine("\");");
                        hasExpression = true;
                    }
                }
                else if (token.Kind == CodeTemplateTokenKind.EndOfLine)
                {
                    if (hasExpression)
                    {
                        _sb.WriteLine("__cb.WriteLine();");
                        hasExpression = false;
                    }
                    indent = null;
                }
                else if (token.Kind == CodeTemplateTokenKind.TemplateControlBegin)
                {
                    if (ParseTemplateControl(indent))
                    {
                        hasExpression = true;
                    }
                }
            }
        }

        private bool ParseTemplateControl(string? indent)
        {
            var hasExpression = false;
            var indentWritten = false;
            _tokens.EatToken();
            while (true)
            {
                var stmt = TryMatchControlStatement();
                if (stmt.TokenCount > 0)
                {
                    if (stmt.IsExpression)
                    {
                        if (!indentWritten)
                        {
                            if (indent != null)
                            {
                                _sb.Write("__cb.Push(\"");
                                _sb.Write(indent);
                                _sb.WriteLine("\");");
                            }
                            indentWritten = true;
                        }
                        _sb.Write("__cb.Write(");
                        for (int i = 0; i < stmt.TokenCount; i++)
                        {
                            var token = _tokens.EatToken();
                            _sb.Write(token.Text);
                        }
                        _sb.WriteLine(");");
                        hasExpression = true;
                    }
                    else
                    {
                        for (int i = 0; i < stmt.TokenCount; i++)
                        {
                            var token = _tokens.EatToken();
                            _sb.Write(token.Text);
                        }
                        _sb.WriteLine();
                    }
                }
                else
                {
                    if (indentWritten && indent != null)
                    {
                        _sb.WriteLine("__cb.Pop();");
                    }
                    return hasExpression;
                }
            }
        }

        private void SkipWs()
        {
            while (IsWhitespaceOrComment()) _tokens.EatToken();
        }

        private (int TokenCount, bool IsExpression) TryMatchControlStatement()
        {
            SkipWs();
            var token = _tokens.CurrentToken;
            int parenthesisCounter = 0;
            int bracketCounter = 0;
            int bracesCounter = 0;
            int tokenCounter = 0;
            bool isExpression = token.Kind != CodeTemplateTokenKind.Keyword;
            while (token.Kind != CodeTemplateTokenKind.None)
            {
                token = _tokens.PeekToken(tokenCounter);
                if (token.Kind == CodeTemplateTokenKind.EndOfFile || token.Kind == CodeTemplateTokenKind.TemplateControlEnd)
                {
                    return (tokenCounter, isExpression);
                }
                if (token.Kind == CodeTemplateTokenKind.Other)
                {
                    if (token.Text == ";" && parenthesisCounter == 0 && bracketCounter == 0 && bracesCounter == 0) return (tokenCounter + 1, false);
                    if (token.Text == "(") ++parenthesisCounter;
                    if (token.Text == ")") --parenthesisCounter;
                    if (token.Text == "[") ++bracketCounter;
                    if (token.Text == "]") --bracketCounter;
                    if (token.Text == "{") ++bracesCounter;
                    if (token.Text == "}") --bracesCounter;
                }
                ++tokenCounter;
            }
            return (0, isExpression);
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
            sb.Builder.Append($" is expected but '{token.EscapedText}' is found");
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
