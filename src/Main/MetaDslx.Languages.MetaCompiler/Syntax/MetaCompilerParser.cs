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

    public class MetaCompilerParser
    {
        private string _filePath;
        private SourceText _templateCode;
        private Language? _language;
        private MetaCompilerLexer _lexer;
        private MetaCompilerTokenStream _tokens;
        private DiagnosticBag? _diagnosticBag;
        private ImmutableArray<Diagnostic> _diagnostics;

        public MetaCompilerParser(string filePath, SourceText templateCode)
        {
            _filePath = filePath;
            _templateCode = templateCode;
        }

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        public Language Parse()
        {
            if (_language != null) return _language;
            using (_lexer = new MetaCompilerLexer(_filePath, _templateCode))
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
            language.Namespace = ParseNamespace();
            language.Grammar = ParseGrammar();
            return language;
        }

        private string ParseNamespace()
        {
            if (MatchKeyword("namespace"))
            {
                while (!_tokens.EndOfFile)
                {
                    var sb = PooledStringBuilder.GetInstance();
                    foreach (var text in texts)
                    {
                        if (sb.Length > 0) sb.Builder.Append(" or ");
                        sb.Builder.Append('\'');
                        sb.Builder.Append(text);
                        sb.Builder.Append('\'');
                    }
                }
            }
        }

        private bool MatchKeyword(string keyword)
        {
            if (IsKeyword(keyword))
            {
                _tokens.EatToken();
                return true;
            }
            else
            {
                Expected(keyword);
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
