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
        private CodeBuilder? _sb;
        private string? _generatorName;
        private DiagnosticBag? _diagnosticBag;
        private ImmutableArray<Diagnostic> _diagnostics;
        private LinePosition _inputStartPosition;
        private LinePosition _outputStartPosition;
        private LinePositionSpan _inputPositionSpan;
        private List<FilePositionMap> _positionMap;
        private Dictionary<string, LinePositionSpan> _namedPositionMap;
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
                _sb = CodeBuilder.GetInstance();
                _diagnosticBag = DiagnosticBag.GetInstance();
                _positionMap = new List<FilePositionMap>();
                _namedPositionMap = new Dictionary<string, LinePositionSpan>();
                _controlInfos = new List<ControlInfo>();
                _controlInfos.Add(new ControlInfo() { Position = new LinePosition(0, 0), Begin = "[", End = "]" });
                _templateInfos = new List<TemplateInfo>();
                ParseNamespace();
                WriteLineMap();
                _compiledCode = _sb.ToStringAndFree();
                _sb = null;
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
                        if (position >= output.Start && position <= output.End)
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
                _tokens.EatToken();
                _sb.Write("namespace");
                StartInputSpan();
                StartOutputSpan();
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else _tokens.EatToken();
                    _sb.Write(token.Text);
                }
                EndInputSpan();
                EndOutputSpan();
                _sb.WriteLine();
                _sb.Write("{");
                _sb.Push();
                if (ParseGenerator())
                {
                    while (ParseUsing()) ;
                    _sb.WriteLine();
                    _sb.Write("public partial class");
                    StartOutputSpan();
                    _sb.Write(_generatorName);
                    EndOutputSpan("GeneratorName");
                    _sb.AppendLine();
                    _sb.WriteLine("{");
                    _sb.Push();
                    while (ParseControlOrTemplate()) ;
                    if (!_tokens.EndOfFile) Expected("template", "control");
                    _sb.Pop();
                    _sb.Write("}");
                }
                _sb.Pop();
                _sb.Write("}");
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
                _tokens.EatToken();
                var gnsb = PooledStringBuilder.GetInstance();
                StartInputSpan();
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else _tokens.EatToken();
                    gnsb.Builder.Append(token.Text);
                }
                EndInputSpan("GeneratorName");
                _generatorName = gnsb.ToStringAndFree();
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
                _tokens.EatToken();
                _sb.Write("using");
                StartInputSpan();
                StartOutputSpan();
                while (true)
                {
                    var token = _tokens.CurrentToken;
                    if (TryMatchEndOfLine()) break;
                    else _tokens.EatToken();
                    _sb.Write(token.Text);
                }
                EndInputSpan();
                EndOutputSpan();
                _sb.WriteLine(";");
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
                    else _tokens.EatToken();
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
                if (_tokens.CurrentToken.Kind == CodeTemplateTokenKind.EndOfFile) _tokens.EatToken();
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
                var templateToken = _tokens.EatToken();
                _sb.Write("public string");
                StartInputSpan();
                StartOutputSpan();
                while (_tokens.State == CodeTemplateLexerState.TemplateHeader || _tokens.State == CodeTemplateLexerState.TemplateHeaderEnd)
                {
                    var token = _tokens.CurrentToken;
                    if (_tokens.State == CodeTemplateLexerState.TemplateHeader || _tokens.State == CodeTemplateLexerState.TemplateHeaderEnd)
                    {
                        _sb.Write(token.Text);
                    }
                    _tokens.EatToken();
                }
                EndInputSpan();
                EndOutputSpan();
                SkipWs();
                _sb.AppendLine();
                _sb.WriteLine("{");
                _sb.Push();
                _sb.WriteLine("var __cb = CodeBuilder.GetInstance();");
                ParserState state = new ParserState();
                state.BeginKeyword = templateToken;
                ParseTemplateContent(ref state);
                _sb.WriteLine("return __cb.ToStringAndFree();");
                _sb.Pop();
                _sb.WriteLine("}");
                _sb.WriteLine();
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
                        _sb.WriteLine("__cb.Pop();");
                        state.IsIndentWritten = false;
                    }
                    if (!state.IsEndWritten)
                    {
                        _sb.Pop();
                        _sb.WriteLine("}");
                        state.IsEndWritten = true;
                    }
                }
                if (_tokens.LinePosition == position)
                {
                    Unexpected();
                    _tokens.EatToken();
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
                _tokens.EatToken();
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
                        _sb.Write("__cb.Push(\"");
                        _sb.Write(state.Indent);
                        _sb.WriteLine("\");");
                        state.IsIndentWritten = true;
                    }
                    _sb.Write("__cb.Write(\"");
                    StartOutputSpan();
                    _sb.Write(token.EscapedTextForString);
                    EndOutputSpan();
                    _sb.WriteLine("\");");
                }
            }
            else if (token.Kind == CodeTemplateTokenKind.EndOfLine)
            {
                if (state.IsIndentWritten)
                {
                    _sb.WriteLine("__cb.WriteLine();");
                    _sb.WriteLine("__cb.Pop();");
                    state.IsIndentWritten = false;
                }
                state.Indent = null;
                _tokens.EatToken();
            }
            else if (token.Kind == CodeTemplateTokenKind.TemplateControlBegin)
            {
                state.IsControl = true;
                _tokens.EatToken();
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
                        _tokens.EatToken();
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
                _tokens.EatTokens(stmt.TokenCount);
                state.IsControl = false;
            }
            else if (stmt.Kind == ControlStatementKind.Expression)
            {
                if (!state.IsIndentWritten && state.Indent != null)
                {
                    _sb.Write("__cb.Push(\"");
                    _sb.Write(state.Indent);
                    _sb.WriteLine("\");");
                    state.IsIndentWritten = true;
                }
                _sb.Write("__cb.Write(");
                StartOutputSpan();
                StartInputSpan();
                for (int i = 0; i < stmt.TokenCount; i++)
                {
                    var token = _tokens.EatToken();
                    _sb.Write(token.Text);
                }
                EndInputSpan();
                EndOutputSpan();
                _sb.WriteLine(");");
            }
            else if (stmt.Kind == ControlStatementKind.Statement || stmt.Kind == ControlStatementKind.StatementWithSemicolon)
            {
                StartOutputSpan();
                StartInputSpan();
                for (int i = 0; i < stmt.TokenCount; i++)
                {
                    var token = _tokens.EatToken();
                    _sb.Write(token.Text);
                }
                EndInputSpan();
                EndOutputSpan();
                if (stmt.Kind == ControlStatementKind.Statement) _sb.WriteLine(";");
                else _sb.WriteLine();
            }
            else if (stmt.Kind == ControlStatementKind.BeginStatement)
            {
                if (CodeTemplateLexer.BlockWithoutEndKeywords.Contains(stmt.Keyword.Text))
                {
                    if (state.IsIndentWritten)
                    {
                        _sb.WriteLine("__cb.Pop();");
                        state.IsIndentWritten = false;
                    }
                    _sb.Pop();
                    _sb.WriteLine("}");
                }
                var first = state.GetNextVariableName("name");
                if (stmt.SeparatorTokenCount > 0)
                {
                    _sb.WriteLine($"var {first} = true;");
                }
                _sb.WritePrefix();
                StartOutputSpan();
                StartInputSpan();
                for (int i = 0; i < stmt.TokenCount; i++)
                {
                    var token = _tokens.EatToken();
                    _sb.Write(token.Text);
                }
                EndInputSpan();
                EndOutputSpan();
                _sb.WriteLine();
                _sb.WriteLine("{");
                _sb.Push();
                if (stmt.SeparatorTokenCount > 0)
                {
                    _sb.WriteLine($"if ({first}) {first} = false;");
                    _sb.Write($"else __cb.Write(");
                    StartOutputSpan();
                    StartInputSpan();
                    for (int i = 0; i < stmt.SeparatorTokenCount; i++)
                    {
                        var token = _tokens.EatToken();
                        _sb.Write(token.Text);
                    }
                    EndInputSpan();
                    EndOutputSpan();
                    _sb.WriteLine(");");
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
                    _tokens.EatToken();
                }
                state.IsEnd = true;
                state.IsTemplateEnd = stmt.Keyword.Text == "template";
            }
            else
            {
                throw new InvalidOperationException("Unknown ControlStatementKind: "+stmt.Kind);
            }
        }
        /*
        private void EndCurrentBlock(ParserState state, bool endBegin, bool error)
        {
            if (state.BeginKeyword.Kind == CodeTemplateTokenKind.Keyword)
            {
                if (state.IsIndentWritten)
                {
                    _sb.WriteLine("__cb.Pop();");
                    state.IsIndentWritten = false;
                }
                if (endBegin)
                {
                    var stack = state.BlockKeywordStack.Pop();
                    while (stack.Count > 0)
                    {
                        var block = stack.Pop();
                        if (block.Text != null)
                        {
                            if (CodeTemplateLexer.SwitchBlockKeywords.Contains(block.Text))
                            {
                                _sb.WriteLine("break;");
                                _sb.Pop();
                            }
                            else
                            {
                                _sb.Pop();
                                _sb.WriteLine("}");
                            }
                        }
                    }
                    if (state.BeginKeyword.Text != "try")
                    {
                        _sb.Pop();
                        _sb.WriteLine("}");
                    }
                    state.BeginKeywordStack.Pop();
                }
                else
                {
                    var stack = state.BlockKeywordStack.Peek();
                    if (stack.Count > 0)
                    {
                        var block = stack.Pop();
                        if (block.Text != null)
                        {
                            if (CodeTemplateLexer.SwitchBlockKeywords.Contains(block.Text))
                            {
                                _sb.WriteLine("break;");
                                _sb.Pop();
                            }
                            else
                            {
                                _sb.Pop();
                                _sb.WriteLine("}");
                            }
                        }
                    }
                }
                if (error) Error($"[end {state.BeginKeyword.Text}] is expected here");
            }
        }
        */
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

        private LinePosition StartInputSpan()
        {
            _inputStartPosition = _tokens.LinePosition;
            return _inputStartPosition;
        }

        private LinePositionSpan EndInputSpan(string? name = null)
        {
            _inputPositionSpan = new LinePositionSpan(_inputStartPosition, _tokens.LinePosition);
            if (name != null)
            {
                _namedPositionMap.Add(name, _inputPositionSpan);
            }
            _inputStartPosition = LinePosition.Zero;
            return _inputPositionSpan;
        }

        private LinePosition StartOutputSpan()
        {
            _outputStartPosition = _sb.LinePosition;
            return _outputStartPosition;
        }

        private LinePositionSpan EndOutputSpan(string? name = null, LinePositionSpan? inputSpan = null)
        {
            var inputPositionSpan = (LinePositionSpan)(inputSpan != null ? inputSpan : name != null ? _namedPositionMap[name] : _inputPositionSpan);
            var outputPositionSpan = new LinePositionSpan(_outputStartPosition, _sb.LinePosition);
            _outputStartPosition = LinePosition.Zero;
            var map = new FilePositionMap() { InputSpan = inputPositionSpan, OutputSpan = outputPositionSpan };
            _positionMap.Add(map);
            return outputPositionSpan;
        }

        private void WriteLineMap()
        {
            _sb.WriteLine();
            _sb.WriteLine("/*#line-map#");
            foreach (var map in _positionMap)
            {
                _sb.WriteLine(map.ToString());
            }
            _sb.WriteLine("*/");
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

        private struct FilePositionMap
        {
            public LinePositionSpan InputSpan;
            public LinePositionSpan OutputSpan;

            public override string ToString()
            {
                return $"{InputSpan.Start.Line}:{InputSpan.Start.Character}-{InputSpan.End.Line}:{InputSpan.End.Character}=>{OutputSpan.Start.Line}:{OutputSpan.Start.Character}-{OutputSpan.End.Line}:{OutputSpan.End.Character}";
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
            public List<LinePositionSpan> Outputs = new List<LinePositionSpan>();
        }
    }
}
