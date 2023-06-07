using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    internal class ComputedLanguage
    {
        private readonly Language _language;
        private ComputedGrammar _grammar;

        public ComputedLanguage(Language language)
        {
            _language = language;
        }

        public ComputedGrammar Grammar
        {
            get
            {
                if (_grammar is null) _grammar = new ComputedGrammar(this, _language.Grammar);
                return _grammar;
            }
        }
    }

    internal class ComputedGrammar
    {
        private readonly ComputedLanguage _language;
        private readonly Grammar _grammar;
        private Dictionary<string, ComputedLexerRule> _fixedLexerRules;
        private List<ComputedLexerRule> _lexerRules;
        private List<ComputedParserRule> _parserRules;

        public ComputedGrammar(ComputedLanguage language, Grammar grammar)
        {
            _language = language;
            _grammar = grammar;
        }

        public ComputedLexerRule? GetLexerRule(LexerRule? rule)
        {
            throw new NotImplementedException();
        }

        public ComputedParserRule? GetParserRule(ParserRule? rule)
        {
            throw new NotImplementedException();
        }

        private void ComputeRules()
        {
            if (_parserRules is not null) return;
            _fixedLexerRules = new Dictionary<string, ComputedLexerRule>();
            _lexerRules = new List<ComputedLexerRule>();
            _parserRules = new List<ComputedParserRule>();
            foreach (var rule in _grammar.Rules)
            {

            }
        }
    }

    internal class ComputedLexerRule
    {
        private readonly ComputedGrammar _grammar;
        private readonly LexerRule _lexerRule;
        private string? _regexString;
        private Regex? _regex;

        public ComputedLexerRule(ComputedGrammar grammar, LexerRule lexerRule)
        {
            _grammar = grammar;
            _lexerRule = lexerRule;
        }

        public bool IsHidden => _lexerRule.IsHidden;
        public bool IsFragment => _lexerRule.IsFragment;
        public bool IsFixed => _lexerRule.IsFixed;
        public string? FixedValue => _lexerRule.FixedValue;

        public string? RegexString
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Regex? Regex
        {
            get
            {
                if (_regex is null && RegexString is not null)
                {
                    _regex = new Regex(RegexString);
                }
                return _regex;
            }
        }
    }

    internal class ComputedLexerRuleAlternative
    {
        private readonly ComputedGrammar _grammar;
        private readonly LexerRuleAlternative _alternative;

        public ComputedLexerRuleAlternative(ComputedGrammar grammar, LexerRuleAlternative alternative)
        {
            _grammar = grammar;
            _alternative = alternative;
        }
    }

    internal class ComputedLexerRuleElement
    {
        private readonly ComputedGrammar _grammar;
        private readonly LexerRuleElement _element;
        private string? _regexString;

        public ComputedLexerRuleElement(ComputedGrammar grammar, LexerRuleElement element)
        {
            _grammar = grammar;
            _element = element;
        }

        public string RegexString
        {
            get
            {
                if (_regexString is null)
                {
                    var sb = PooledStringBuilder.GetInstance();
                    switch (_element)
                    {
                        case LexerRuleReferenceElement re:
                            var rule = _grammar.GetLexerRule(re.Rule);
                            sb.Builder.Append(rule.RegexString);
                            break;
                        case LexerRuleFixedStringElement fse:
                            sb.Builder.Append(fse.Value);
                            break;
                        case LexerRuleWildcardElement we:
                            sb.Builder.Append(".");
                            break;
                        case LexerRuleBlockElement be:
                            sb.Builder.Append("(");
                            foreach (var alt in be.Alternatives)
                            {
                                // TODO
                            }
                            sb.Builder.Append(")");
                            break;
                        case LexerRuleRangeElement rng:

                            break;
                        default:
                            break;
                    }
                }
                return _regexString;
            }
        }
    }

    internal class ComputedParserRule
    {
        private readonly ComputedGrammar _grammar;
        private readonly ParserRule _parserRule;

        public ComputedParserRule(ComputedGrammar grammar, ParserRule parserRule)
        {
            _grammar = grammar;
            _parserRule = parserRule;
        }
    }

    internal class ComputedParserRuleAlternative
    {
        private readonly ComputedGrammar _grammar;
        private readonly ParserRuleAlternative _alternative;

        public ComputedParserRuleAlternative(ComputedGrammar grammar, ParserRuleAlternative alternative)
        {
            _grammar = grammar;
            _alternative = alternative;
        }
    }

    internal class ComputedParserRuleElement
    {
        private readonly ComputedGrammar _grammar;
        private readonly ParserRuleElement _element;

        public ComputedParserRuleElement(ComputedGrammar grammar, ParserRuleElement element)
        {
            _grammar = grammar;
            _element = element;
        }
    }
}
