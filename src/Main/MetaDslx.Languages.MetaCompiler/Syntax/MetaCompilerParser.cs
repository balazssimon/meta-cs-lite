using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Syntax
{
    using MetaDslx.CodeAnalysis.PooledObjects;
    using MetaDslx.Languages.MetaCompiler.Model;
    using System.Linq;

    public class MetaCompilerParser
    {
        private string _filePath;
        private SourceText _compilerCode;
        private Language? _language;
        private List<Annotation> _annotations = new List<Annotation>();
        private MetaCompilerLexer _lexer;
        private MetaCompilerTokenStream _tokens;
        private DiagnosticBag? _diagnosticBag;
        private ImmutableArray<Diagnostic> _diagnostics;

        public MetaCompilerParser(string filePath, SourceText compilerCode)
        {
            _filePath = filePath;
            _compilerCode = compilerCode;
        }

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        public Language Parse()
        {
            if (_language != null) return _language;
            using (_lexer = new MetaCompilerLexer(_filePath, _compilerCode))
            {
                _tokens = new MetaCompilerTokenStream(_lexer);
                _diagnosticBag = DiagnosticBag.GetInstance();
                _language = ParseLanguage();
                _diagnostics = _diagnosticBag.ToReadOnlyAndFree();
                _diagnosticBag = null;
            }
            return _language;
        }

        private Language ParseLanguage()
        {
            var language = new Language();
            ParseNamespace(language);
            ParseUsings(language);
            ParseGrammar(language);
            return language;
        }

        private void ParseNamespace(Language language)
        {
            if (MatchKeyword("namespace"))
            {
                language.Namespace = ParseQualifier();
                MatchSemicolon();
            }
        }

        private void ParseUsings(Language language)
        {
            while (IsKeyword("using"))
            {
                _tokens.NextToken();
                language.Usings.Add(ParseQualifier());
                MatchSemicolon();
            }
        }

        private void ParseGrammar(Language language)
        {
            language.Grammar = new Grammar();
            while (true)
            {
                var advanced = false;
                ParseAnnotations();
                if (TryParseLexerRule(language.Grammar)) advanced = true;
                if (TryParseParserRule(language.Grammar)) advanced = true;
                if (!advanced) break;
            }
        }

        private void ParseAnnotations()
        {
            var token = _tokens.CurrentToken;
            while (!_tokens.EndOfFile && token.Kind == MetaCompilerTokenKind.Other && token.Text == "[")
            {
                token = _tokens.NextToken();
                var annotation = new Annotation();
                _annotations.Add(annotation);
                annotation.Kind = AnnotationKind.None;
                if (token.Kind == MetaCompilerTokenKind.Keyword)
                {
                    switch (token.Text)
                    {
                        case "def":
                            annotation.Kind = AnnotationKind.Def;
                            break;
                        case "use":
                            annotation.Kind = AnnotationKind.Use;
                            break;
                        default:
                            Expected("def", "use");
                            break;
                    }
                    _tokens.NextToken();
                }
                annotation.Name = ParseQualifier();
                token = _tokens.CurrentToken;
                if (token.Kind == MetaCompilerTokenKind.Other && token.Text == "(")
                {
                    _tokens.NextToken();
                    ParseAnnotationProperties(annotation);
                    MatchOther(")");
                    token = _tokens.CurrentToken;
                }
                if (token.Kind == MetaCompilerTokenKind.Other && token.Text == "]")
                {
                    token = _tokens.NextToken();
                }
            }
        }

        private void ParseAnnotationProperties(Annotation annotation)
        {
            bool propertyExpected = true;
            while (!_tokens.EndOfFile)
            {
                var token = _tokens.CurrentToken;
                if (propertyExpected)
                {
                    if (token.Kind == MetaCompilerTokenKind.Identifier)
                    {
                        var property = new AnnotationProperty();
                        annotation.Properties.Add(property);
                        property.Name = token.Text;
                        token = _tokens.NextToken();
                        if (token.Kind == MetaCompilerTokenKind.Other && token.Text == "=")
                        {
                            _tokens.NextToken();
                            property.Value = MatchCSharpExpressionUntil(",", ")", "]", ";");
                        }
                        else
                        {
                            Expected("=");
                        }
                        propertyExpected = false;
                    }
                    else
                    {
                        Error("Property name expected");
                        _tokens.NextToken();
                    }
                }
                else 
                {
                    if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ",")
                    {
                        propertyExpected = true;
                        _tokens.NextToken();
                    }
                    else if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ")")
                    {
                        return;
                    }
                    else
                    {
                        Expected(",", ")", "identifier");
                        _tokens.NextToken();
                    }
                }
            }
        }

        private bool TryParseLexerRule(Grammar grammar)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Identifier && token.Text.Length > 0 && char.IsUpper(token.Text[0]))
            {
                _tokens.NextToken();
                var rule = new LexerRule();
                grammar.Rules.Add(rule);
                rule.Name = token.Text;
                rule.Annotations.AddRange(_annotations);
                _annotations.Clear();
                token = _tokens.CurrentToken;
                if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ":")
                {
                    _tokens.NextToken();
                    while (true)
                    {
                        var alt = new LexerRuleAlternative();
                        rule.Alternatives.Add(alt);
                        ParseLexerRuleAlternative(alt);
                        token = _tokens.CurrentToken;
                        if (token.Kind == MetaCompilerTokenKind.Other && token.Text == "|")
                        {
                            _tokens.NextToken();
                            continue;
                        }
                        else if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ";")
                        {
                            _tokens.NextToken();
                            break;
                        }
                        else
                        {
                            Expected("|", ";");
                            break;
                        }
                    }
                }
                else
                {
                    Expected(":");
                }
                return true;
            }
            return false;
        }

        private void ParseLexerRuleAlternative(LexerRuleAlternative alt)
        {

        }

        private bool TryParseParserRule(Grammar grammar)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Identifier && token.Text.Length > 0 && char.IsLower(token.Text[0]))
            {
                _tokens.NextToken();
                var rule = new ParserRule();
                grammar.Rules.Add(rule);
                rule.Name = token.Text;
                rule.Annotations.AddRange(_annotations);
                _annotations.Clear();
                if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ":")
                {
                    _tokens.NextToken();
                    while (true)
                    {
                        var alt = new ParserRuleAlternative();
                        rule.Alternatives.Add(alt);
                        ParseParserRuleAlternative(alt);
                        token = _tokens.CurrentToken;
                        if (token.Kind == MetaCompilerTokenKind.Other && token.Text == "|")
                        {
                            _tokens.NextToken();
                            continue;
                        }
                        else if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ";")
                        {
                            _tokens.NextToken();
                            break;
                        }
                        else
                        {
                            Expected("|", ";");
                            break;
                        }
                    }
                }
                else
                {
                    Expected(":");
                }
                return true;
            }
            return false;
        }

        private void ParseParserRuleAlternative(ParserRuleAlternative alt)
        {
            ParseAnnotations();
            var token = _tokens.PeekToken(0);
            var hashmark = _tokens.PeekToken(1);
            if (token.Kind == MetaCompilerTokenKind.Identifier && hashmark.Kind == MetaCompilerTokenKind.Other && hashmark.Text == "#")
            {
                alt.Name = token.Text;
                _tokens.EatTokens(2);
                alt.Annotations.AddRange(_annotations);
                _annotations.Clear();
            }

        }

        private ImmutableArray<string> ParseQualifier()
        {
            var result = ArrayBuilder<string>.GetInstance();
            var idExpected = true;
            while (!_tokens.EndOfFile)
            {
                var token = _tokens.CurrentToken;
                if (idExpected)
                {
                    if (token.Kind == MetaCompilerTokenKind.Identifier)
                    {
                        _tokens.NextToken();
                        result.Add(token.Text);
                        idExpected = false;
                    }
                    else
                    {
                        Error("Identifier expected");
                        break;
                    }
                }
                else 
                {
                    if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ".")
                    {
                        _tokens.NextToken();
                        idExpected = true;
                    }
                    else
                    {
                        break;
                    }
                }
            }
            return result.ToImmutableAndFree();
        }

        private string MatchCSharpExpressionUntil(params string[] untilOther)
        {
            var sb = PooledStringBuilder.GetInstance();
            int parenthesisCounter = 0;
            int bracketsCounter = 0;
            int bracesCounter = 0;
            _tokens.IgnoreWhitespaceAndComments = false;
            try
            {
                var token = _tokens.CurrentToken;
                while (!_tokens.EndOfFile && (parenthesisCounter > 0 || bracketsCounter > 0 || bracesCounter > 0 || token.Kind != MetaCompilerTokenKind.Other || !untilOther.Contains(token.Text)))
                {
                    sb.Builder.Append(token.Text);
                    if (token.Text == "(") ++parenthesisCounter;
                    if (token.Text == ")") --parenthesisCounter;
                    if (token.Text == "[") ++bracketsCounter;
                    if (token.Text == "]") --bracketsCounter;
                    if (token.Text == "{") ++bracesCounter;
                    if (token.Text == "}") --bracesCounter;
                    token = _tokens.NextToken();
                }
                return sb.ToStringAndFree().Trim();
            }
            finally
            {
                _tokens.IgnoreWhitespaceAndComments = true;
            }
        }

        private bool MatchKeyword(string keyword)
        {
            if (IsKeyword(keyword))
            {
                _tokens.NextToken();
                return true;
            }
            else
            {
                Expected(keyword);
                return false;
            }
        }

        private bool MatchSemicolon()
        {
            return MatchOther(";");
        }

        private bool MatchOther(string text)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Other && token.Text == text)
            {
                _tokens.NextToken();
                return true;
            }
            else
            {
                Expected(text);
                return false;
            }
        }

        private bool IsKeyword(string text)
        {
            return IsKeyword(_tokens.CurrentToken, text);
        }

        private bool IsKeyword(MetaCompilerToken token, string text)
        {
            return token.Kind == MetaCompilerTokenKind.Keyword && token.Text == text;
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
    }
}
