using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    public class CompilerModelPostProcessor
    {
        private readonly MetaDslx.Modeling.Model _model;
        private CancellationToken _cancellationToken;
        private Language _language;
        private Grammar _grammar;
        private DiagnosticBag _diagnostics;
        private HashSet<string> _ruleNames;
        private Dictionary<string, Token> _fixedTokens;
        private CompilerModelFactory f;

        public CompilerModelPostProcessor(MetaDslx.Modeling.Model model)
        {
            _model = model;
        }

        public MetaDslx.Modeling.Model Model => _model;

        public ImmutableArray<Diagnostic> GetDiagnostics()
        {
            return _diagnostics?.ToReadOnly() ?? ImmutableArray<Diagnostic>.Empty;
        }

        public void Execute(CancellationToken cancellationToken)
        {
            if (_diagnostics is not null) return;
            _cancellationToken = cancellationToken;
            _diagnostics = new DiagnosticBag();
            _language = _model.Objects.OfType<Language>().FirstOrDefault();
            _grammar = _language?.Grammar;
            if (_grammar is null) return;
            f = new CompilerModelFactory(_model);
            _ruleNames = new HashSet<string>();
            _fixedTokens = new Dictionary<string, Token>();
            AddTokens();
        }

        private void AddTokens()
        {
            AddFixedTokens();
            AddFixedTokensFromRules(_model.Objects.OfType<Rule>().ToImmutableArray());
            AddNonFixedTokens();
        }

        private void AddFixedTokens()
        {
            foreach (var fixedToken in _grammar.GrammarRules.OfType<Token>().Where(t => t.IsFixed))
            {
                var fixedText = fixedToken.FixedText;
                if (!string.IsNullOrEmpty(fixedText))
                {
                    if (_fixedTokens.TryGetValue(fixedText, out var existingFixedToken))
                    {
                        _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, ((IModelObject)fixedToken).Location, $"There is already another token called '{existingFixedToken.Name}' with text '{fixedText}'."));
                    }
                    else
                    {
                        _fixedTokens.Add(fixedText, fixedToken);
                    }
                    fixedToken.CSharpName = AddRuleName(fixedToken.Name ?? MakeFixedTokenName(fixedText), tryWithoutIndex: true);
                    _grammar.Tokens.Add(fixedToken);
                }
                else
                {
                    _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, ((IModelObject)fixedToken).Location, $"Token '{fixedToken.Name}' is empty."));
                }
            }
        }

        private void AddFixedTokensFromRules(ImmutableArray<Rule> rules)
        {
            foreach (var rule in rules)
            {
                foreach (var alt in rule.Alternatives)
                {
                    foreach (var elem in alt.Elements)
                    {
                        if (elem.Value is Keyword keyword)
                        {
                            if (!_fixedTokens.TryGetValue(keyword.Text, out var fixedToken))
                            {
                                fixedToken = f.Token();
                                fixedToken.CSharpName = MakeFixedTokenName(keyword.Text);
                                fixedToken.Name = fixedToken.CSharpName;
                                // TODO: fixedToken.TokenKind;
                                var ftAlt = f.LAlternative();
                                fixedToken.Alternatives.Add(ftAlt);
                                var ftElem = f.LElement();
                                ftAlt.Elements.Add(ftElem);
                                var ftFixed = f.LFixed();
                                ftElem.Value = ftFixed;
                                ftFixed.Text = keyword.Text;
                                _fixedTokens.Add(keyword.Text, fixedToken);
                                _grammar.Tokens.Add(fixedToken);
                            }
                            var tokenRef = f.RuleRef();
                            tokenRef.GrammarRule = fixedToken;
                            elem.Value = tokenRef;
                            ((IModelObject)tokenRef).SourceLocation = ((IModelObject)keyword).SourceLocation;
                            _model.DeleteObject((IModelObject)keyword, _cancellationToken);
                        }
                    }
                }
            }
        }

        private void AddNonFixedTokens()
        {
            foreach (var token in _grammar.GrammarRules.OfType<Token>().Where(t => !t.IsFixed))
            {
                token.CSharpName = AddRuleName(token.Name ?? MakeTokenName(), tryWithoutIndex: true);
                _grammar.Tokens.Add(token);
            }
        }

        private string AddRuleName(string ruleName, bool tryWithoutIndex)
        {
            if (tryWithoutIndex && !_ruleNames.Contains(ruleName, StringComparer.OrdinalIgnoreCase))
            {
                _ruleNames.Add(ruleName);
                return ruleName;
            }
            var index = 0;
            while (true)
            {
                ++index;
                var name = $"{ruleName}{index}";
                if (!_ruleNames.Contains(name, StringComparer.OrdinalIgnoreCase))
                {
                    _ruleNames.Add(name);
                    return name;
                }
            }
        }

        private string MakeTokenName()
        {
            return AddRuleName("TToken", tryWithoutIndex: false);
        }

        private string MakeFixedTokenName(string value)
        {
            if (string.IsNullOrWhiteSpace(value)) return MakeTokenName();
            var keyword = PooledStringBuilder.GetInstance();
            var keywordBuilder = keyword.Builder;
            var other = PooledStringBuilder.GetInstance();
            var otherBuilder = other.Builder;
            var isKeyword = true;
            var first = true;
            keywordBuilder.Append('K');
            otherBuilder.Append('T');
            foreach (var ch in value)
            {
                if (ch >= 'a' && ch <= 'z' || ch >= 'A' && ch <= 'Z' || ch == '_' || !first && ch >= '0' && ch <= '9')
                {
                    keywordBuilder.Append(first ? char.ToUpper(ch) : ch);
                    otherBuilder.Append(first ? char.ToUpper(ch) : ch);
                }
                else
                {
                    isKeyword = false;
                    var otherName = GetOtherCharacterName(ch);
                    if (otherName is not null) otherBuilder.Append(otherName);
                    else otherBuilder.Append('_');
                }
                first = false;
            }
            var result = other.ToStringAndFree();
            if (isKeyword) result = keyword.ToStringAndFree();
            else keyword.Free();
            if (result.Length == 1) return MakeTokenName();
            return AddRuleName(result, tryWithoutIndex: true);
        }

        private static string? GetOtherCharacterName(char ch)
        {
            switch (ch)
            {
                case '!': return "Excl";
                case '"': return "Quote";
                case '#': return "Hash";
                case '$': return "Dollar";
                case '%': return "Percent";
                case '&': return "Amp";
                case '\'': return "Apos";
                case '(': return "LParen";
                case ')': return "RParen";
                case '*': return "Asterisk";
                case '+': return "Plus";
                case ',': return "Comma";
                case '-': return "Minus";
                case '.': return "Dot";
                case '/': return "Slash";
                case ':': return "Colon";
                case ';': return "Semicolon";
                case '<': return "Lt";
                case '=': return "Eq";
                case '>': return "Gt";
                case '?': return "Question";
                case '@': return "At";
                case '[': return "LBracket";
                case '\\': return "Backslash";
                case ']': return "RBracket";
                case '^': return "Hat";
                case '_': return "Underscore";
                case '`': return "Accent";
                case '{': return "LBrace";
                case '|': return "Bar";
                case '}': return "RBrace";
                case '~': return "Tilde";
                default: return null;
            }
        }

        private void AddBinders(IList<Binder> binders, IList<Annotation> annotations)
        {
            foreach (var annot in annotations.Where(a => a.AttributeClass.Name?.EndsWith("Binder") ?? false))
            {
                var binder = f.Binder();
                binders.Add(binder);
                binder.TypeName = annot.AttributeClass.FullName;
                foreach (var carg in annot.Arguments)
                {
                    var name = carg.Parameter?.Name;
                    if (name is not null)
                    {
                        var rarg = f.BinderArgument();
                        rarg.Name = name;
                        rarg.IsArray = carg.ParameterType.IsCollection;
                        carg.ParameterType.TryGetCoreType(out var coreType);
                        rarg.TypeName = coreType.FullName;
                        if (carg.Value is ArrayExpression array)
                        {
                            foreach (var item in array.Items)
                            {
                                rarg.Values.Add(GetAnnotationArgumentValue(item?.Value ?? default));
                            }
                        }
                        else
                        {
                            rarg.Values.Add(GetAnnotationArgumentValue(carg.Value?.Value ?? default));
                        }
                        binder.Arguments.Add(rarg);
                    }
                }
            }
        }

        private string GetAnnotationArgumentValue(MetaSymbol value)
        {
            if (value.OriginalSymbol is not null)
            {
                return SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(value.OriginalSymbol);
            }
            else
            {
                return value.ToString();
            }
        }
    }
}
