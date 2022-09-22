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
        private string _filePath;
        private string _templateCode;
        private string? _compiledCode;
        private CodeTemplateLexer _lexer;
        private CodeTemplateTokenStream _tokens;
        private CodeBuilder? _sb;
        private string? _generatorName;
        private DiagnosticBag? _diagnosticBag;
        private ImmutableArray<Diagnostic> _diagnostics;
        private LinePosition _inputStartPosition;
        private LinePosition _outputStartPosition;
        private FileLinePositionSpan _inputPositionSpan;
        private List<FilePositionMap> _positionMap;
        private Dictionary<string, FileLinePositionSpan> _namedPositionMap;

        public CodeTemplateParser(string filePath, string templateCode)
        {
            _filePath = filePath;
            _templateCode = templateCode;
        }

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        public string Compile()
        {
            if (_compiledCode != null) return _compiledCode;
            using (_lexer = new CodeTemplateLexer(_filePath, SourceText.From(_templateCode)))
            {
                _tokens = new CodeTemplateTokenStream(_lexer);
                _sb = CodeBuilder.GetInstance();
                _diagnosticBag = DiagnosticBag.GetInstance();
                _positionMap = new List<FilePositionMap>();
                _namedPositionMap = new Dictionary<string, FileLinePositionSpan>();
                ParseNamespace();
                WriteLineMap();
                _compiledCode = _sb.ToStringAndFree();
                _sb = null;
                _diagnostics = _diagnosticBag.ToReadOnlyAndFree();
                _diagnosticBag = null;
            }
            return _compiledCode;
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
                    ParseControl();
                    while (ParseUsing()) ;
                    _sb.WriteLine();
                    _sb.Write("public partial class");
                    StartOutputSpan();
                    _sb.Write(_generatorName);
                    EndOutputSpan("GeneratorName");
                    _sb.AppendLine();
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
                return true;
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

        private bool ParseTemplate()
        {
            SkipWs();
            if (IsKeyword("template"))
            {
                _tokens.EatToken();
                _sb.Write("public string");
                StartInputSpan();
                StartOutputSpan();
                while (_tokens.State == CodeTemplateLexerState.TemplateHeader)
                {
                    var token = _tokens.CurrentToken;
                    if (_tokens.State == CodeTemplateLexerState.TemplateHeader)
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
                ParseTemplateContent(state);
                _sb.WriteLine("return __cb.ToStringAndFree();");
                _sb.Pop();
                _sb.WriteLine("}");
                _sb.WriteLine();
                return true;
            }
            return false;
        }

        private void ParseTemplateContent(ParserState state)
        {
            while (!_tokens.EndOfFile)
            {
                if (IsTemplateEnd())
                {
                    if (state.BeginKeyword.Kind == CodeTemplateTokenKind.Keyword)
                    {
                        EndCurrentBlock(state, true, true);
                    }
                    return;
                }
                else if (_tokens.State == CodeTemplateLexerState.TemplateOutput)
                {
                    ParseTemplateOutput(state);
                }
                else if (_tokens.State == CodeTemplateLexerState.TemplateControl)
                {
                    if (ParseTemplateControl(state)) return;
                }
                else
                {
                    break;
                }
            }
        }

        private void ParseTemplateOutput(ParserState state)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == CodeTemplateTokenKind.TemplateOutput)
            {
                StartInputSpan();
                var lineStart = _tokens.Character == 0;
                _tokens.EatToken();
                EndInputSpan();
                if (lineStart && string.IsNullOrWhiteSpace(token.Text))
                {
                    state.Indent = token.EscapedTextForString;
                    state.IndentWritten = false;
                }
                else
                {
                    if (!state.IndentWritten && state.Indent != null)
                    {
                        _sb.Write("__cb.Push(\"");
                        _sb.Write(state.Indent);
                        _sb.WriteLine("\");");
                        state.IndentWritten = true;
                    }
                    StartOutputSpan();
                    _sb.Write("__cb.Write(\"");
                    _sb.Write(token.EscapedTextForString);
                    _sb.WriteLine("\");");
                    EndOutputSpan();
                }
            }
            else if (token.Kind == CodeTemplateTokenKind.EndOfLine)
            {
                if (state.IndentWritten)
                {
                    _sb.WriteLine("__cb.WriteLine();");
                    _sb.WriteLine("__cb.Pop();");
                    state.IndentWritten = false;
                }
                state.Indent = null;
                _tokens.EatToken();
            }
            else if (token.Kind == CodeTemplateTokenKind.TemplateControlBegin)
            {
                _tokens.EatToken();
            }
        }

        private bool ParseTemplateControl(ParserState state)
        {
            var stmt = TryMatchControlStatement();
            if (!string.IsNullOrWhiteSpace(stmt.Text) || stmt.EndKeyword.Kind == CodeTemplateTokenKind.Keyword)
            {
                if (stmt.IsExpression)
                {
                    if (!state.IndentWritten && state.Indent != null)
                    {
                        _sb.Write("__cb.Push(\"");
                        _sb.Write(state.Indent);
                        _sb.WriteLine("\");");
                        state.IndentWritten = true;
                    }
                    _sb.Write("__cb.Write(");
                    StartOutputSpan();
                    _sb.Write(stmt.Text);
                    EndOutputSpan(inputSpan: stmt.StatementSpan);
                    _sb.WriteLine(");");
                }
                else if (stmt.BeginKeyword.Kind != CodeTemplateTokenKind.None)
                {
                    var lexeme = stmt.BeginKeyword.Text;
                    if (CodeTemplateLexer.BlockWithoutEndKeywords.Contains(lexeme))
                    {
                        EndCurrentBlock(state, false, false);
                    }
                    else
                    {
                        state.BlockKeywordStack.Push(new Stack<CodeTemplateToken>());
                    }
                    if (stmt.Separator != null && CodeTemplateLexer.LoopKeywords.Contains(lexeme))
                    {
                        _sb.WriteLine("var __first = true;");
                    }
                    _sb.WritePrefix(force: false);
                    StartOutputSpan();
                    _sb.Write(stmt.Text);
                    EndOutputSpan(inputSpan: stmt.StatementSpan);
                    _sb.WriteLine();
                    if (!CodeTemplateLexer.SwitchBlockKeywords.Contains(lexeme)) _sb.WriteLine("{");
                    _sb.Push();
                    if (stmt.Separator != null && CodeTemplateLexer.LoopKeywords.Contains(lexeme))
                    {
                        _sb.WriteLine("if (__first) __first = false;");
                        _sb.Write($"else __cb.Write(");
                        StartOutputSpan();
                        _sb.Write(stmt.Separator);
                        EndOutputSpan(inputSpan: stmt.SeparatorSpan);
                        _sb.WriteLine(");");
                    }
                    if (CodeTemplateLexer.BlockWithoutEndKeywords.Contains(lexeme))
                    {
                        state.BlockKeywordStack.Peek().Push(stmt.BeginKeyword);
                    }
                    else
                    {
                        state.BeginKeywordStack.Push(stmt.BeginKeyword);
                        if (lexeme == "try")
                        {
                            state.BlockKeywordStack.Peek().Push(stmt.BeginKeyword);
                        }
                        ParseTemplateContent(state);
                    }
                }
                else if (stmt.EndKeyword.Kind != CodeTemplateTokenKind.None)
                {
                    if (state.BeginKeyword.Kind == CodeTemplateTokenKind.None)
                    {
                        Error($"[end {stmt.EndKeyword.Text}] is unexpected here");
                        return false;
                    }
                    if (state.BeginKeyword.Kind == CodeTemplateTokenKind.Keyword)
                    {
                        if (stmt.EndKeyword.Text != state.BeginKeyword.Text)
                        {
                            Error($"[end {state.BeginKeyword.Text}] is expected but [end {stmt.EndKeyword.Text}] was found");
                        }
                    }
                    EndCurrentBlock(state, true, false);
                    return true;
                }
                else
                {
                    _sb.WritePrefix(force: false);
                    StartOutputSpan();
                    _sb.Write(stmt.Text);
                    EndOutputSpan(inputSpan: stmt.StatementSpan);
                    _sb.WriteLine();
                }
            }
            return false;
        }

        private void EndCurrentBlock(ParserState state, bool endBegin, bool error)
        {
            if (state.BeginKeyword.Kind == CodeTemplateTokenKind.Keyword)
            {
                if (state.IndentWritten)
                {
                    _sb.WriteLine("__cb.Pop();");
                    state.IndentWritten = false;
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

        private void SkipWs()
        {
            while (IsWhitespaceOrComment()) _tokens.EatToken();
        }

        private ControlStatement TryMatchControlStatement()
        {
            SkipWs();
            StartInputSpan();
            ControlStatement result = new ControlStatement();
            var token = _tokens.CurrentToken;
            int parenthesisCounter = 0;
            int bracketCounter = 0;
            int bracesCounter = 0;
            if (token.Kind == CodeTemplateTokenKind.Keyword)
            {
                var lexeme = token.Text;
                if (CodeTemplateLexer.BlockKeywords.Contains(lexeme))
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
                        if (CodeTemplateLexer.BlockEndKeywords.Contains(lexeme))
                        {
                            result.EndKeyword = token;
                            _tokens.EatToken();
                            token = _tokens.CurrentToken;
                        }
                    }
                    result.StatementSpan = EndInputSpan();
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
                    break;
                }
                sb.Builder.Append(token.Text);
                if (token.Kind == CodeTemplateTokenKind.Other)
                {
                    if (parenthesisCounter == 0 && bracketCounter == 0 && bracesCounter == 0)
                    {
                        if (!collectSeparator && token.Text == "=")
                        {
                            var nextToken = _tokens.PeekToken();
                            if (!(nextToken.Kind == CodeTemplateTokenKind.Other && nextToken.Text == "="))
                            {
                                result.IsExpression = false;
                            }
                        }
                        if (token.Text == ";")
                        {
                            if (collectSeparator)
                            {
                                result.Separator = sb.ToStringAndFree();
                                result.SeparatorSpan = EndInputSpan();
                            }
                            else
                            {
                                result.Text = sb.ToStringAndFree();
                                result.StatementSpan = EndInputSpan();
                            }
                            result.IsExpression = false;
                            return result;
                        }
                    }
                    if (token.Text == "(") ++parenthesisCounter;
                    if (token.Text == ")")
                    {
                        --parenthesisCounter;
                        var separatorSkip = FindSeparator();
                        if (result.BeginKeyword.Kind == CodeTemplateTokenKind.Keyword && !collectSeparator && separatorSkip > 0)
                        {
                            var lexeme = result.BeginKeyword.Text;
                            if (CodeTemplateLexer.LoopKeywords.Contains(lexeme))
                            {
                                result.Text = sb.ToStringAndFree();
                                result.StatementSpan = EndInputSpan();
                                sb = PooledStringBuilder.GetInstance();
                                collectSeparator = true;
                                for (int i = 0; i < separatorSkip; i++)
                                {
                                    _tokens.EatToken();
                                }
                                StartInputSpan();
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
                }
            }
            if (collectSeparator)
            {
                result.Separator = sb.ToStringAndFree();
                result.SeparatorSpan = EndInputSpan();
            }
            else
            {
                if (!result.IsExpression && !CodeTemplateLexer.BlockKeywords.Contains(result.BeginKeyword.Text) &&
                    !CodeTemplateLexer.BlockEndKeywords.Contains(result.EndKeyword.Text)) sb.Builder.Append(";");
                result.Text = sb.ToStringAndFree();
                result.StatementSpan = EndInputSpan();
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

        private int FindSeparator()
        {
            int index = 0;
            bool found = false;
            while (true)
            {
                var token = _tokens.PeekToken(index);
                if (IsWhitespaceOrComment(token))
                {
                    ++index;
                    continue;
                }
                else if (!found && IsKeyword(token, "separator"))
                {
                    found = true;
                }
                else
                {
                    break;
                }
                ++index;
            }
            if (found) return index;
            else return -1;
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
            _diagnosticBag.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, Location.Create(_filePath, new TextSpan(token.Position, token.Text.Length), new LinePositionSpan(new LinePosition(_tokens.Line, _tokens.Character), new LinePosition(_tokens.Line, _tokens.Character + token.Text.Length))), message));
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

        private FileLinePositionSpan EndInputSpan(string? name = null)
        {
            _inputPositionSpan = new FileLinePositionSpan(_filePath, _inputStartPosition, _tokens.LinePosition);
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

        private FileLinePositionSpan EndOutputSpan(string? name = null, FileLinePositionSpan? inputSpan = null)
        {
            var inputPositionSpan = (FileLinePositionSpan)(inputSpan != null ? inputSpan : name != null ? _namedPositionMap[name] : _inputPositionSpan);
            var outputPositionSpan = new FileLinePositionSpan(_filePath, _outputStartPosition, _sb.LinePosition);
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

        private struct ControlStatement
        {
            public string Text;
            public bool IsExpression;
            public CodeTemplateToken BeginKeyword;
            public CodeTemplateToken EndKeyword;
            public string? Separator;
            public FileLinePositionSpan StatementSpan;
            public FileLinePositionSpan SeparatorSpan;

            public ControlStatement()
            {
                Text = "";
                IsExpression = false;
                BeginKeyword = CodeTemplateToken.None;
                EndKeyword = CodeTemplateToken.None;
                Separator = null;
                StatementSpan = default;
                SeparatorSpan = default;
            }

            public override string ToString()
            {
                return Text;
            }
        }

        private class ParserState
        {
            public Stack<CodeTemplateToken> BeginKeywordStack = new Stack<CodeTemplateToken>();
            public Stack<Stack<CodeTemplateToken>> BlockKeywordStack = new Stack<Stack<CodeTemplateToken>>();
            public CodeTemplateToken BeginKeyword
            {
                get
                {
                    if (BeginKeywordStack.TryPeek(out var top))
                    {
                        return top;
                    }
                    else
                    {
                        return default;
                    }
                }
            }
            public CodeTemplateToken BlockKeyword
            {
                get
                {
                    if (BlockKeywordStack.TryPeek(out var stack) && stack.TryPeek(out var top))
                    {
                        return top;
                    }
                    else
                    {
                        return default;
                    }
                }
            }
            public string? Indent;
            public bool IndentWritten;
        }

        private struct FilePositionMap
        {
            public FileLinePositionSpan InputSpan;
            public FileLinePositionSpan OutputSpan;

            public override string ToString()
            {
                return $"{InputSpan.StartLinePosition.Line}:{InputSpan.StartLinePosition.Character}-{InputSpan.EndLinePosition.Line}:{InputSpan.EndLinePosition.Character}=>{OutputSpan.StartLinePosition.Line}:{OutputSpan.StartLinePosition.Character}-{OutputSpan.EndLinePosition.Line}:{OutputSpan.EndLinePosition.Character}";
            }
        }
    }
}
