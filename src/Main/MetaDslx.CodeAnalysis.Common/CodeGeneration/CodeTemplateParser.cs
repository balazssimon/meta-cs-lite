using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
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
        private string _filePath;
        private SourceText _templateCode;
        private string? _compiledCode;
        private CodeTemplateLexer _lexer;
        private CodeTemplateTokenStream _tokens;
        private CodeBuilder? _osb;
        private CodeBuilder? _isb;
        private bool _collectInput;
        private string? _generatorName;
        private DiagnosticBag? _diagnosticBag;
        private ImmutableArray<Diagnostic> _diagnostics;
        private (int Position, LinePosition LinePosition) _inputStartPosition;
        private (TextSpan TextSpan, LinePositionSpan LinePositionSpan) _inputSpan;
        private Dictionary<string, (TextSpan TextSpan, LinePositionSpan LinePositionSpan)> _namedPositionMap;
        private TemplateInfo? _currentTemplateInfo;
        private List<ControlInfo> _controlInfos;
        private List<TemplateInfo> _templateInfos;

        public CodeTemplateParser(string filePath, SourceText templateCode)
        {
            _filePath = filePath;
            _templateCode = templateCode;
        }

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        public string Compile()
        {
            if (_compiledCode != null) return _compiledCode;
            using (_lexer = new CodeTemplateLexer(_filePath, _templateCode))
            {
                _tokens = new CodeTemplateTokenStream(_lexer);
                _osb = CodeBuilder.GetInstance();
                _isb = CodeBuilder.GetInstance();
                _diagnosticBag = DiagnosticBag.GetInstance();
                _namedPositionMap = new Dictionary<string, (TextSpan TextSpan, LinePositionSpan LinePositionSpan)>();
                _controlInfos = new List<ControlInfo>();
                _controlInfos.Add(new ControlInfo() { Position = new LinePosition(0, 0), Begin = "[", End = "]" });
                _templateInfos = new List<TemplateInfo>();
                ParseNamespace();
                _compiledCode = _osb.ToStringAndFree();
                _osb = null;
                _isb.Free();
                _isb = null;
                _diagnostics = _diagnosticBag.ToReadOnlyAndFree();
                _diagnosticBag = null;
            }
            return _compiledCode;
        }

        public bool IsPositionInsideTemplateOutput(int line, int character)
        {
            var position = new LinePosition(line, character);
            foreach (var info in _templateInfos)
            {
                if (position >= info.Span.Start && position <= info.Span.End)
                {
                    foreach (var output in info.Outputs)
                    {
                        if (position >= output.LinePositionSpan.Start && position <= output.LinePositionSpan.End)
                        {
                            return true;
                        }
                    }
                }
            }
            return false;
        }

        public (string, string) GetControlBeginEndForPosition(int line, int character)
        {
            var position = new LinePosition(line, character);
            var prevInfo = default(ControlInfo);
            foreach (var info in _controlInfos)
            {
                if (info.Position > position) break;
                prevInfo = info;
            }
            return (string.IsNullOrEmpty(prevInfo.Begin) ? "[" : prevInfo.Begin, string.IsNullOrEmpty(prevInfo.End) ? "]" : prevInfo.End);
        }

        private void ParseNamespace()
        {
            SkipWs();
            if (IsKeyword("namespace"))
            {
                EatToken();
                StartInputSpan();
                while (true)
                {
                    if (TryMatchEndOfLine()) break;
                    else EatToken();
                }
                EndInputSpan();
                StartOutputSpan(_osb.Prefix.Length + 9);
                _osb.Write("namespace");
                _osb.Write(_isb.ToString());
                EndOutputSpan();
                _osb.WriteLine();
                _osb.Write("{");
                _osb.Push();
                if (ParseGenerator())
                {
                    while (ParseUsing()) ;
                    _osb.WriteLine();
                    StartOutputSpan(_osb.Prefix.Length + 20);
                    _osb.Write("public partial class");
                    _osb.Write(_generatorName);
                    EndOutputSpan("GeneratorName");
                    _osb.AppendLine();
                    _osb.WriteLine("{");
                    _osb.Push();
                    while (ParseControlOrTemplate()) ;
                    if (!_tokens.EndOfFile) Expected("template", "control");
                    _osb.Pop();
                    _osb.Write("}");
                }
                _osb.Pop();
                _osb.Write("}");
            }
            else
            {
                Expected("namespace");
            }
        }

        private bool ParseGenerator()
        {
            SkipWs();
            if (IsKeyword("generator"))
            {
                EatToken();
                StartInputSpan();
                while (true)
                {
                    if (TryMatchEndOfLine()) break;
                    else EatToken();
                }
                EndInputSpan("GeneratorName");
                _generatorName = _isb.ToString();
                return true;
            }
            else
            {
                Expected("generator");
            }
            return false;
        }

        private bool ParseUsing()
        {
            SkipWs();
            if (IsKeyword("using"))
            {
                StartInputSpan();
                while (true)
                {
                    if (TryMatchEndOfLine(true)) break;
                    else EatToken();
                }
                EndInputSpan();
                StartOutputSpan(_osb.Prefix.Length);
                var inputText = _isb.ToString();
                _osb.WriteLine(inputText);
                EndOutputSpan();
                if (!inputText.EndsWith(";"))
                {
                    _osb.WriteLine(";");
                }
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
                var controlBegin = "";
                var controlEnd = "";
                var counter = 0;
                var controlInfo = new ControlInfo() { Position = _tokens.LinePosition };
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else EatToken();
                    if (IsWhitespaceOrComment(token))
                    {
                        if (incCounter) ++counter;
                        incCounter = false;
                        continue;
                    }
                    if (counter == 1) controlBegin += token.Text;
                    else if (counter == 2) controlEnd += token.Text;
                    else if (counter == 3) Unexpected();
                    incCounter = true;
                }
                if (counter == 0)
                {
                    Error("Template control begin sequence is expected");
                }
                else if (counter == 1 && !CodeTemplateLexer.ControlShortcutKeywords.Contains(controlBegin))
                {
                    Error("Template control end sequence is expected");
                }
                else
                {
                    controlInfo.Begin = _tokens.ControlBegin;
                    controlInfo.End = _tokens.ControlEnd;
                    _controlInfos.Add(controlInfo);
                }
                return true;
            }
            return false;
        }

        private bool ParseControlOrTemplate()
        {
            if (ParseControl() || ParseTemplate())
            {
                return true;
            }
            else
            {
                if (_tokens.CurrentToken.Kind == CodeTemplateTokenKind.EndOfFile) EatToken();
                return false;
            }
        }

        private bool ParseTemplate()
        {
            SkipWs();
            if (IsKeyword("template"))
            {
                _currentTemplateInfo = new TemplateInfo();
                var templateStartPosition = _tokens.LinePosition;
                var templateToken = _tokens.CurrentToken;
                EatToken();
                StartInputSpan();
                while (_tokens.State == CodeTemplateLexerState.TemplateHeader || _tokens.State == CodeTemplateLexerState.TemplateHeaderEnd)
                {
                    EatToken();
                }
                EndInputSpan();
                StartOutputSpan(_osb.Prefix.Length + 13);
                _osb.Write("public string");
                _osb.Write(_isb.ToString());
                EndOutputSpan();
                SkipWs();
                _osb.AppendLine();
                _osb.WriteLine("{");
                _osb.Push();
                _osb.WriteLine("var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();");
                ParserState state = new ParserState();
                state.BeginKeyword = templateToken;
                ParseTemplateContent(ref state);
                _osb.WriteLine("return __cb.ToStringAndFree();");
                _osb.Pop();
                _osb.WriteLine("}");
                _osb.WriteLine();
                var templateEndPosition = _tokens.LinePosition;
                _currentTemplateInfo.Span = new LinePositionSpan(templateStartPosition, templateEndPosition);
                _templateInfos.Add(_currentTemplateInfo);
                _currentTemplateInfo = null;
                return true;
            }
            return false;
        }

        private void ParseTemplateContent(ref ParserState state)
        {
            while (!_tokens.EndOfFile && !state.IsEnd)
            {
                var position = _tokens.LinePosition;
                if (state.IsControl)
                {
                    ParseTemplateControl(ref state);
                }
                else 
                {
                    ParseTemplateOutput(ref state);
                }
                if (state.IsEnd)
                {
                    if (state.IsIndentWritten)
                    {
                        _osb.WriteLine("__cb.Pop();");
                        state.IsIndentWritten = false;
                    }
                    if (!state.IsEndWritten && state.BeginKeyword.Text != "template")
                    {
                        _osb.Pop();
                        _osb.WriteLine("}");
                        state.IsEndWritten = true;
                    }
                }
                if (_tokens.LinePosition == position)
                {
                    Unexpected();
                    EatToken();
                }
            }
        }

        private void ParseTemplateOutput(ref ParserState state)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == CodeTemplateTokenKind.TemplateOutput)
            {
                StartInputSpan();
                var lineStart = _tokens.Character == 0;
                EatToken();
                var templateOutputSpan = EndInputSpan();
                if (_currentTemplateInfo != null)
                {
                    _currentTemplateInfo.Outputs.Add(templateOutputSpan);
                }
                if (lineStart && string.IsNullOrWhiteSpace(token.Text))
                {
                    state.Indent = token.EscapedTextForString;
                    state.IsIndentWritten = false;
                }
                else
                {
                    if (!state.IsIndentWritten && state.Indent != null)
                    {
                        _osb.Write("__cb.Push(\"");
                        _osb.Write(state.Indent);
                        _osb.WriteLine("\");");
                        state.IsIndentWritten = true;
                    }
                    StartOutputSpan(_osb.Prefix.Length + 12);
                    _osb.Write("__cb.Write(\"");
                    _osb.Write(token.EscapedTextForString);
                    _osb.WriteLine("\");");
                    EndOutputSpan();
                }
            }
            else if (token.Kind == CodeTemplateTokenKind.EndOfLine)
            {
                if (state.IsIndentWritten)
                {
                    _osb.WriteLine("__cb.WriteLine();");
                    _osb.WriteLine("__cb.Pop();");
                    state.IsIndentWritten = false;
                }
                state.Indent = null;
                EatToken();
            }
            else if (token.Kind == CodeTemplateTokenKind.TemplateControlBegin)
            {
                state.IsControl = true;
                EatToken();
            }
            else if (token.Kind == CodeTemplateTokenKind.Keyword && token.Text == "end")
            {
                var stmt = TryMatchControlStatement();
                if (stmt.Kind == ControlStatementKind.EndStatement && stmt.Keyword.Text == "template")
                {
                    for (int i = 0; i < stmt.TokenCount; i++)
                    {
                        token = _tokens.CurrentToken;
                        if (token.Position == stmt.Keyword.Position)
                        {
                            if (stmt.Keyword.Text != state.BeginKeyword.Text)
                            {
                                Expected(state.BeginKeyword.Text);
                            }
                        }
                        EatToken();
                    }
                    state.IsEnd = true;
                    state.IsTemplateEnd = true;
                }
            }
        }

        private void ParseTemplateControl(ref ParserState state)
        {
            var stmt = TryMatchControlStatement();
            if (stmt.TokenCount <= 0) return;
            if (stmt.Kind == ControlStatementKind.TemplateControlEnd)
            {
                EatTokens(stmt.TokenCount);
                state.IsControl = false;
            }
            else if (stmt.Kind == ControlStatementKind.Expression)
            {
                if (!state.IsIndentWritten && state.Indent != null)
                {
                    _osb.Write("__cb.Push(\"");
                    _osb.Write(state.Indent);
                    _osb.WriteLine("\");");
                    state.IsIndentWritten = true;
                }
                StartInputSpan();
                EatTokens(stmt.TokenCount);
                EndInputSpan();
                StartOutputSpan(_osb.Prefix.Length + 11);
                _osb.Write("__cb.Write(");
                _osb.Write(_isb.ToString());
                _osb.WriteLine(");");
                EndOutputSpan();
            }
            else if (stmt.Kind == ControlStatementKind.Statement || stmt.Kind == ControlStatementKind.StatementWithSemicolon)
            {
                StartInputSpan();
                EatTokens(stmt.TokenCount);
                EndInputSpan();
                StartOutputSpan(_osb.Prefix.Length);
                _osb.Write(_isb.ToString());
                EndOutputSpan();
                if (stmt.Kind == ControlStatementKind.Statement) _osb.WriteLine(";");
                else _osb.WriteLine();
            }
            else if (stmt.Kind == ControlStatementKind.BeginStatement)
            {
                if (CodeTemplateLexer.BlockWithoutEndKeywords.Contains(stmt.Keyword.Text))
                {
                    if (state.IsIndentWritten)
                    {
                        _osb.WriteLine("__cb.Pop();");
                        state.IsIndentWritten = false;
                    }
                    _osb.Pop();
                    _osb.WriteLine("}");
                }
                var first = state.GetNextVariableName("name");
                if (stmt.SeparatorTokenCount > 0)
                {
                    _osb.WriteLine($"var {first} = true;");
                }
                StartInputSpan();
                EatTokens(stmt.TokenCount);
                EndInputSpan();
                StartOutputSpan(_osb.Prefix.Length);
                _osb.Write(_isb.ToString());
                EndOutputSpan();
                _osb.WriteLine();
                _osb.WriteLine("{");
                _osb.Push();
                if (stmt.SeparatorTokenCount > 0)
                {
                    _osb.WriteLine($"if ({first}) {first} = false;");
                    StartInputSpan();
                    EatTokens(stmt.SeparatorTokenCount);
                    EndInputSpan();
                    StartOutputSpan(_osb.Prefix.Length + 16);
                    _osb.Write($"else __cb.Write(");
                    _osb.Write(_isb.Prefix.Length);
                    _osb.WriteLine(");");
                    EndOutputSpan();
                }
                if (!CodeTemplateLexer.BlockWithoutEndKeywords.Contains(stmt.Keyword.Text))
                {
                    var innerState = new ParserState();
                    innerState.BeginKeyword = stmt.Keyword;
                    innerState.BlockKeyword = stmt.Keyword;
                    innerState.IsControl = true;
                    ParseTemplateContent(ref innerState);
                    if (innerState.IsTemplateEnd)
                    {
                        state.IsEnd = true;
                        state.IsTemplateEnd = true;
                    }
                }
            }
            else if (stmt.Kind == ControlStatementKind.EndStatement)
            {
                for (int i = 0; i < stmt.TokenCount; i++)
                {
                    var token = _tokens.CurrentToken;
                    if (token.Position == stmt.Keyword.Position)
                    {
                        if (stmt.Keyword.Text != state.BeginKeyword.Text)
                        {
                            Expected(state.BeginKeyword.Text);
                        }
                    }
                    EatToken();
                }
                state.IsEnd = true;
                state.IsTemplateEnd = stmt.Keyword.Text == "template";
            }
            else
            {
                throw new InvalidOperationException("Unknown ControlStatementKind: "+stmt.Kind);
            }
        }

        private void EatToken()
        {
            var token = _tokens.EatToken();
            if (_collectInput) _isb.Write(token.Text);
        }

        private void EatTokens(int count)
        {
            for (int i = 0; i < count; ++i)
            {
                EatToken();
            }
        }

        private void SkipWs()
        {
            while (IsWhitespaceOrComment()) _tokens.EatToken();
        }

        private CodeTemplateToken SkipWs(ref int index)
        {
            while (IsWhitespaceOrComment(_tokens.PeekToken(index))) ++index;
            return _tokens.PeekToken(index++);
        }

        private ControlStatement TryMatchControlStatement()
        {
            ControlStatement result = new ControlStatement();
            var index = 0;
            var token = SkipWs(ref index);

            if (token.Kind == CodeTemplateTokenKind.TemplateControlEnd)
            {
                result.Kind = ControlStatementKind.TemplateControlEnd;
                result.TokenCount = index;
                return result;
            }

            if (token.Kind == CodeTemplateTokenKind.Keyword && token.Text == "end")
            {
                result.Kind = ControlStatementKind.EndStatement;
                result.Keyword = SkipWs(ref index);
                result.TokenCount = index;
                return result;
            }

            if (token.Kind == CodeTemplateTokenKind.Keyword && CodeTemplateLexer.BlockKeywords.Contains(token.Text))
            {
                result.Kind = ControlStatementKind.BeginStatement;
                result.Keyword = token;
            }
            else
            {
                result.Kind = ControlStatementKind.Expression;
            }

            int parenthesisCounter = 0;
            int bracketCounter = 0;
            int bracesCounter = 0;
            bool collectSeparator = false;
            while (token.Kind != CodeTemplateTokenKind.None)
            {
                token = _tokens.PeekToken(index++);
                if (token.Kind == CodeTemplateTokenKind.EndOfFile || token.Kind == CodeTemplateTokenKind.TemplateControlEnd)
                {
                    if (collectSeparator) result.SeparatorTokenCount = index - 1;
                    else result.TokenCount = index - 1;
                    return result;
                }
                if (token.Kind == CodeTemplateTokenKind.Other)
                {
                    if (parenthesisCounter == 0 && bracketCounter == 0 && bracesCounter == 0)
                    {
                        if (token.Text == "=")
                        {
                            var nextToken = _tokens.PeekToken(index);
                            if (!(nextToken.Kind == CodeTemplateTokenKind.Other && nextToken.Text == "="))
                            {
                                if (result.Kind == ControlStatementKind.Expression) result.Kind = ControlStatementKind.Statement;
                            }
                        }
                        if (token.Text == ";")
                        {
                            if (result.Kind == ControlStatementKind.Expression || result.Kind == ControlStatementKind.Statement) result.Kind = ControlStatementKind.StatementWithSemicolon;
                            if (collectSeparator) result.SeparatorTokenCount = index - 1;
                            else result.TokenCount = index - 1;
                            return result;
                        }
                    }
                    if (token.Text == "(") ++parenthesisCounter;
                    if (token.Text == ")")
                    {
                        --parenthesisCounter;
                        if (parenthesisCounter == 0 && bracketCounter == 0 && bracesCounter == 0 && !collectSeparator)
                        {
                            if (result.Keyword.Kind == CodeTemplateTokenKind.Keyword && CodeTemplateLexer.LoopKeywords.Contains(result.Keyword.Text))
                            {
                                var separatorIndex = index;
                                var separatorKeyword = SkipWs(ref separatorIndex);
                                if (separatorKeyword.Kind == CodeTemplateTokenKind.Keyword && separatorKeyword.Text == "separator")
                                {
                                    result.TokenCount = index;
                                    collectSeparator = true;
                                }
                            }
                        }
                    }
                    if (token.Text == "[") ++bracketCounter;
                    if (token.Text == "]") --bracketCounter;
                    if (token.Text == "{") ++bracesCounter;
                    if (token.Text == "}") --bracesCounter;
                }
            }
            if (collectSeparator) result.SeparatorTokenCount = index - 1;
            else result.TokenCount = index - 1;
            return result;
        }

        private bool TryMatchEndOfLine(bool allowSemicolon = true)
        {
            var token = _tokens.CurrentToken;
            if (allowSemicolon && token.Kind == CodeTemplateTokenKind.Other && token.Text == ";")
            {
                EatToken();
                return true;
            }
            if (token.Kind == CodeTemplateTokenKind.EndOfLine)
            {
                EatToken();
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
            _diagnosticBag.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, Location.Create(_filePath, new TextSpan(_tokens.Position, token.Text.Length), new LinePositionSpan(new LinePosition(_tokens.Line, _tokens.Character), new LinePosition(_tokens.Line, _tokens.Character + token.Text.Length))), message));
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

        private (int Position, LinePosition LinePosition) StartInputSpan()
        {
            _isb.Clear();
            _collectInput = true;
            _inputStartPosition = (_tokens.Position, _tokens.LinePosition);
            return _inputStartPosition;
        }

        private (TextSpan TextSpan, LinePositionSpan LinePositionSpan) EndInputSpan(string? name = null)
        {
            _inputSpan = (TextSpan.FromBounds(_inputStartPosition.Position, _tokens.Position), new LinePositionSpan(_inputStartPosition.LinePosition, _tokens.LinePosition));
            if (name != null)
            {
                _namedPositionMap.Add(name, _inputSpan);
            }
            _inputStartPosition = (0, LinePosition.Zero);
            _collectInput = false;
            return _inputSpan;
        }

        private void StartOutputSpan(int ignoreChars)
        {
            _osb.AppendLine();
            var start = _inputSpan.LinePositionSpan.Start;
            var end = _inputSpan.LinePositionSpan.End;
            _osb.WriteLine($"#line ({start.Line + 1},{start.Character + 1})-({end.Line + 1},{end.Character + 1}) {ignoreChars} \"{_filePath}\"");
        }

        private void EndOutputSpan(string? name = null)
        {
            _osb.AppendLine();
            _osb.WriteLine("#line hidden");
        }

        private enum ControlStatementKind
        {
            None,
            Expression,
            Statement,
            StatementWithSemicolon,
            BeginStatement,
            EndStatement,
            TemplateControlEnd
        }

        private struct ControlStatement
        {
            public ControlStatementKind Kind;
            public CodeTemplateToken Keyword;
            public int TokenCount;
            public int SeparatorTokenCount;

            public ControlStatement()
            {
                Kind = ControlStatementKind.None;
                Keyword = CodeTemplateToken.None;
                TokenCount = 0;
                SeparatorTokenCount = 0;
            }

            public override string ToString()
            {
                return $"{Kind}: {Keyword}";
            }
        }

        private ref struct ParserState
        {
            public CodeTemplateToken BeginKeyword;
            public CodeTemplateToken BlockKeyword;
            public string? Indent;
            public bool IsIndentWritten;
            public bool IsEndWritten;
            public bool IsControl;
            public bool IsEnd;
            public bool IsTemplateEnd;
            private int TempCounter;

            public string GetNextVariableName(string name)
            {
                return $"__{name}{++TempCounter}";
            }
        }

        private struct PositionMap
        {
            public (TextSpan TextSpan, LinePositionSpan LinePositionSpan) InputSpan;
            public (TextSpan TextSpan, LinePositionSpan LinePositionSpan) OutputSpan;

            public override string ToString()
            {
                return $"{InputSpan.LinePositionSpan.Start.Line}:{InputSpan.LinePositionSpan.Start.Character}-{InputSpan.LinePositionSpan.End.Line}:{InputSpan.LinePositionSpan.End.Character}=>{OutputSpan.LinePositionSpan.Start.Line}:{OutputSpan.LinePositionSpan.Start.Character}-{OutputSpan.LinePositionSpan.End.Line}:{OutputSpan.LinePositionSpan.End.Character}";
            }
        }


        private struct ControlInfo
        {
            public LinePosition Position;
            public string Begin;
            public string End;
        }

        private class TemplateInfo
        {
            public LinePositionSpan Span;
            public List<(TextSpan TextSpan, LinePositionSpan LinePositionSpan)> Outputs = new List<(TextSpan TextSpan, LinePositionSpan LinePositionSpan)>();
        }
    }
}
