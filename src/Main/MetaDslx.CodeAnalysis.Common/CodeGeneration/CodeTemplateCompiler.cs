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
    public class CodeTemplateCompiler
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
        private CodeTemplateLexerState _lexerState;
        private ParserState _state;
        private CodeBuilder? _sb;
        private DiagnosticBag? _diagnosticBag;
        private CodeTemplateToken _token;
        private int _position;
        private int _line;
        private int _column;
        private ImmutableArray<Diagnostic> _diagnostics;

        public CodeTemplateCompiler(string filePath, string templateCode)
        {
            _filePath = filePath;
            _templateCode = templateCode;
        }

        public string Compile()
        {
            if (_compiledCode != null) return _compiledCode;
            string? generatorName = null;
            _line = 0;
            _column = 0;
            using (_lexer = new CodeTemplateLexer(_filePath, SourceText.From(_templateCode), true))
            {
                _lexerState = CodeTemplateLexerState.None;
                _sb = CodeBuilder.GetInstance();
                _diagnosticBag = DiagnosticBag.GetInstance();
                _state = ParserState.None;
                while (true)
                {
                    _token = NextToken();
                    if (_token.Kind == CodeTemplateTokenKind.None || _token.Kind == CodeTemplateTokenKind.EndOfFile) break;
                    if (IsWhitespaceOrComment())
                    {
                        _sb.Write(_token.Text);
                        continue;
                    }
                    if (_state == ParserState.None)
                    {
                        if (MatchKeyword("namespace"))
                        {
                            _sb.WriteLine(_token.Text);
                            _state = ParserState.BeginNamespace;
                        }
                        else
                        {
                            Expected("namespace");
                        }
                        continue;
                    }
                    if (_state == ParserState.BeginNamespace)
                    {
                        if (_token.Kind == CodeTemplateTokenKind.Other && _token.Text == ";")
                        {
                            _sb.WriteLine("{");
                            _sb.Push();
                            _state = ParserState.EndNamespace;
                        }
                        else
                        {
                            _sb.Write(_token.Text);
                        }
                        continue;
                    }
                    if (_state == ParserState.EndNamespace)
                    {
                        if (MatchKeyword("generator"))
                        {
                            _state = ParserState.BeginGenerator;
                            generatorName = "";
                        }
                        else
                        {
                            Expected("generator");
                        }
                        continue;
                    }
                    if (_state == ParserState.BeginGenerator)
                    {
                        if (_token.Kind == CodeTemplateTokenKind.Other && _token.Text == ";")
                        {
                            _state = ParserState.EndGenerator;
                        }
                        else
                        {
                            generatorName += _token.Text;
                        }
                        continue;
                    }
                    if (_state == ParserState.EndGenerator)
                    {
                        if (IsKeyword("control"))
                        {
                            _state = ParserState.BeginControl;
                        }
                        else if (IsKeyword("using"))
                        {
                            _state = ParserState.BeginUsing;
                        }
                        else
                        {
                            Expected("generator");
                        }
                        continue;
                    }
                    if (_state == ParserState.BeginControl)
                    {
                        if (_token.Kind == CodeTemplateTokenKind.Other && _token.Text == ";")
                        {
                            _state = ParserState.EndControl;
                        }
                        continue;
                    }
                    if (_state == ParserState.EndGenerator || _state == ParserState.EndControl || _state == ParserState.EndUsing)
                    {
                        if (IsKeyword("using"))
                        {
                            _state = ParserState.BeginUsing;
                        }
                        else if (IsKeyword("template"))
                        {
                            _sb.WriteLine($"public class {generatorName}");
                            _sb.WriteLine("{");
                            _sb.Push();
                            _sb.Write("public string");
                            _state = ParserState.BeginTemplate;
                        }
                        else if (_state == ParserState.EndGenerator)
                        {
                            Expected("control", "using", "template");
                        }
                        else
                        {
                            Expected("using", "template"); 
                        }
                        continue;
                    }
                    if (_state == ParserState.BeginUsing)
                    {
                        _sb.Write(_token.Text);
                        if (_token.Kind == CodeTemplateTokenKind.Other && _token.Text == ";")
                        {
                            _state = ParserState.EndUsing;
                        }
                        continue;
                    }
                    if (_state == ParserState.BeginTemplate)
                    {
                        _sb.Write(_token.Text);
                        if (_lexerState == CodeTemplateLexerState.TemplateHeaderEnd)
                        {
                            _sb.WriteLine("{");
                            _sb.Push();
                            _sb.WriteLine("var _sb = CodeBuilder.GetInstance();");
                            _state = ParserState.TemplateBody;
                        }
                        continue;
                    }
                    if (_state == ParserState.TemplateBody)
                    {
                        if (_lexerState == CodeTemplateLexerState.TemplateEnd)
                        {
                            _sb.AppendLine();
                            _sb.WriteLine("return _sb.ToStringAndFree();");
                            _sb.WriteLine("}");
                            _sb.Pop();
                        }
                        else if (_lexerState == CodeTemplateLexerState.TemplateOutput)
                        {
                            if (_token.Kind == CodeTemplateTokenKind.EndOfLine)
                            {
                                _sb.WriteLine("_sb.WriteLine();");
                            }
                            else
                            {
                                _sb.WriteLine($"_sb.Write(\"{_token.Text}\");");
                            }
                        }
                        else if (IsKeyword("end"))
                        {
                            _sb.AppendLine();
                            _sb.WriteLine("}");
                            _sb.Pop();
                        }
                        else if (_token.Kind != CodeTemplateTokenKind.TemplateControlBegin && _token.Kind != CodeTemplateTokenKind.TemplateControlEnd)
                        {
                            _sb.Write(_token.Text);
                        }
                        continue;
                    }
                }
                _sb.Pop();
                _sb.WriteLine("}");
                _sb.Pop();
                _sb.WriteLine("}");
                _compiledCode = _sb.ToStringAndFree();
                _sb = null;
                _diagnosticBag.AddRange(_lexer.GetDiagnostics());
                _diagnostics = _diagnosticBag.ToReadOnlyAndFree();
                _diagnosticBag = null;
            }
            return _compiledCode;
        }

        private CodeTemplateToken NextToken()
        {
            if (_lexer != null)
            {
                var token = _lexer.Lex(ref _lexerState);
                _line = _lexer.Line;
                _column = _lexer.Column;
                return token;
            }
            return CodeTemplateToken.None;
        }

        private bool IsKeyword(string text)
        {
            return _token.Kind == CodeTemplateTokenKind.Keyword && _token.Text == text;
        }

        private bool MatchKeyword(string text)
        {
            if (IsKeyword(text))
            {
                return true;
            }
            else
            {
                Error($"{text} is expected but {_token.Text} is found");
                return false;
            }
        }

        private bool IsWhitespaceOrComment()
        {
            return _token.Kind == CodeTemplateTokenKind.EndOfLine || _token.Kind == CodeTemplateTokenKind.Whitespace || _token.Kind == CodeTemplateTokenKind.SingleLineComment || _token.Kind == CodeTemplateTokenKind.MultiLineComment;
        }

        private void Error(string message)
        {
            _diagnosticBag.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, Location.Create(_filePath, new TextSpan(_token.Position, _token.Text.Length), new LinePositionSpan(new LinePosition(_line, _column), new LinePosition(_line, _column))), message));
        }

        private void Expected(params string[] texts)
        {
            var sb = PooledStringBuilder.GetInstance();
            foreach (var text in texts)
            {
                if (sb.Length > 0) sb.Builder.Append(" or ");
                sb.Builder.Append('\'');
                sb.Builder.Append(text);
                sb.Builder.Append('\'');
            }
            sb.Builder.Append($"is expected but '{_token.Text}' is found");
            Error(sb.ToStringAndFree());
        }
    }
}
