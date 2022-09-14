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
        private enum State
        {
            None,
            MatchedNamespace,
            MatchedGenerator,
            MatchedControl,
            MatchedUsings,
            MatchedTemplate,
            TemplateName,
            TemplateParams,
            TemplateOutput,
            TemplateControl
        }

        private static readonly Regex IdentifierRegex = new Regex("[a-zA-Z_][a-zA-Z_0-9]*");
        private static readonly Regex StringRegex = new Regex(@"""[^""\\]*(?:\\.[^""\\]*)*(""|\r\n|\n)");

        private string _fileName;
        private string _templateCode;
        private string? _compiledCode;
        private CodeBuilder? _sb;
        private DiagnosticBag? _diagnosticBag;
        private State _state;
        private int _position;
        private int _line;
        private int _column;
        private string? _text;
        private char _openChar = '[';
        private char _closeChar = ']';
        private ImmutableArray<Diagnostic> _diagnostics;

        public CodeTemplateCompiler(string fileName, string templateCode)
        {
            _fileName = fileName;
            _templateCode = templateCode;
        }

        public string Compile()
        {
            if (_compiledCode != null) return _compiledCode;
            string? generatorName = null;
            _sb = CodeBuilder.GetInstance();
            _diagnosticBag = DiagnosticBag.GetInstance();
            _state = State.None;
            _position = 0;
            _line = 0;
            _column = 0;
            using (var reader = new StringReader(_templateCode))
            {
                while (true)
                {
                    var line = reader.ReadLine();
                    if (line == null) break;
                    _text = line;
                    while (_text != null)
                    {
                        if (_state != State.TemplateOutput)
                        {
                            if (string.IsNullOrWhiteSpace(_text))
                            {
                                Skip(line);
                                _text = null;
                                break;
                            }
                        }
                        var prevLength = _text.Length;
                        if (_text != null && _state == State.None)
                        {
                            if (!string.IsNullOrEmpty(_text) && Match("namespace "))
                            {
                                if (_text.EndsWith(';')) _text = _text.TrimEnd(';');
                                _sb.WriteLine($"namespace {_text}");
                                _sb.WriteLine("{");
                                _sb.Push();
                                _state = State.MatchedNamespace;
                                _text = null;
                                Skip(line);
                            }
                        }
                        if (_text != null && _state == State.MatchedNamespace)
                        {
                            if (!string.IsNullOrEmpty(_text) && Match("generator "))
                            {
                                if (_text.EndsWith(';')) _text = _text.TrimEnd(';');
                                generatorName = _text;
                                _state = State.MatchedGenerator;
                                _text = null;
                                Skip(line);
                            }
                        }
                        if (_text != null && _state == State.MatchedGenerator)
                        {
                            if (!string.IsNullOrEmpty(_text) && TryMatch("control "))
                            {
                                _text = _text.Trim();
                                if (_text.Length == 3 && _text[0] != ' ' && _text[1] == ' ' && _text[2] != ' ')
                                {
                                    _openChar = _text[0];
                                    _closeChar = _text[2];
                                }
                                else
                                {
                                    Error($"Invalid control characters '{_text}'. Control characters must be separated by a single space.");
                                }
                                _state = State.MatchedControl;
                                _text = null;
                                Skip(line);
                            }
                        }
                        if (_text != null && (_state == State.MatchedGenerator || _state == State.MatchedControl || _state == State.MatchedUsings))
                        {
                            if (_state != State.MatchedUsings)
                            {
                                _sb.WriteLine($"public class {generatorName}");
                                _sb.WriteLine("{");
                                _sb.Push();
                            }
                            if (TryMatch("using "))
                            {
                                if (_text.EndsWith(';')) _text = _text.TrimEnd(';');
                                _sb.WriteLine($"using {_text};");
                                _state = State.MatchedUsings;
                                _text = null;
                                Skip(line);
                            }
                            else if (TryMatch("template "))
                            {
                                _state = State.TemplateName;
                            }
                            else
                            {
                                if (_state == State.MatchedGenerator) Error("'control' or 'using' or 'template' expected.");
                                else Error("'using' or 'template' expected.");
                            }
                        }
                        if (_text != null && _state == State.MatchedTemplate)
                        {
                            if (TryMatch("template "))
                            {
                                _state = State.TemplateName;
                            }
                            else
                            {
                                Error("'template' expected.");
                            }
                        }
                        if (_text != null && _state == State.TemplateName)
                        {
                            var index = _text.IndexOf('(');
                            if (index >= 0)
                            {
                                _sb.WriteLine($"public string {_text}");
                                _sb.WriteLine("{");
                                _sb.Push();
                                _state = State.TemplateOutput;
                                _text = null;
                                Skip(line);
                            }
                            else
                            {
                                Error($"'(' is expected."); // TODO
                                _text = null;
                            }
                        }
                        if (_text != null && _state == State.TemplateOutput)
                        {
                            if (TryMatch("end template"))
                            {
                                _sb.Pop();
                                _sb.WriteLine("}");
                                _sb.WriteLine();
                                _state = State.MatchedTemplate;
                                _text = null;
                                Skip(line);
                            }
                        }
                        if (_text != null && _text.Length == prevLength)
                        {
                            Error($"Unexpected character sequence '{_text}'");
                            _text = null;
                        }
                    }
                    ++_line;
                    _column = 0;
                }
            }
            _sb.Pop();
            _sb.WriteLine("}");
            _sb.Pop();
            _sb.WriteLine("}");
            _compiledCode = _sb.ToStringAndFree();
            _sb = null;
            _diagnostics = _diagnosticBag.ToReadOnlyAndFree();
            _diagnosticBag = null;
            return _compiledCode;
        }

        private void Error(string message)
        {
            _diagnosticBag.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, Location.Create(_fileName, new TextSpan(_position, 1), new LinePositionSpan(new LinePosition(_line, _column), new LinePosition(_line, _column)))));
        }

        private void Skip(string token)
        {
            _column += token.Length;
            _position += token.Length;
        }

        private bool TryMatch(string token)
        {
            if (_text != null && _text.StartsWith(token))
            {
                _text = _text.Substring(token.Length);
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Match(string token)
        {
            if (!TryMatch(token))
            {
                Error($"'{token.Trim()}' expected.");
                return false;
            }
            return true;
        }

    }
}
