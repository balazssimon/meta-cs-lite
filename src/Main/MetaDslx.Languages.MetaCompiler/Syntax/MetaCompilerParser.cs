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
    using System.Data;
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
            ParseLanguageDeclaration(language);
            ParseGrammar(language);
            ResolveRules(language);
            ResolveLists(language);
            return language;
        }

        private void ResolveRules(Language language)
        {
            var ruleNames = new HashSet<string>();
            var rules = language.Grammar.Rules.ToList();
            foreach (var rule in rules)
            {
                if (rule is LexerRule lr)
                {
                    if (!ruleNames.Add(lr.Name))
                    {
                        Error(lr.Location, $"Language '{language.Name}' already defines a rule '{lr.Name}'.");
                    }
                    foreach (var alt in lr.Alternatives)
                    {
                        ResolveRules(language, alt);
                    }
                }
                if (rule is ParserRule pr)
                {
                    if (!ruleNames.Add(pr.Name))
                    {
                        Error(pr.Location, $"Language '{language.Name}' already defines a rule '{pr.Name}'.");
                    }
                    foreach (var alt in pr.Alternatives)
                    {
                        if (alt.Name is not null && !ruleNames.Add(alt.Name))
                        {
                            Error(alt.Location, $"Language '{language.Name}' already defines a rule '{alt.Name}'.");
                        }
                        ResolveRules(language, alt);
                    }
                }
            }
        }

        private void ResolveRules(Language language, LexerRuleAlternative alt)
        {
            foreach (var elem in alt.Elements)
            {
                if (elem is LexerRuleReferenceElement refElem)
                {
                    refElem.Rule = language.Grammar.Rules.OfType<LexerRule>().FirstOrDefault(r => refElem.RuleName.Length == 1 && refElem.RuleName[0] == r.Name);
                    if (refElem.Rule is null)
                    {
                        Error(refElem.Location, $"Lexer rule '{string.Join(".", refElem.RuleName)}' cannot be found (are you missing a using directive?).");
                    }
                }
                else if (elem is LexerRuleBlockElement blockElem)
                {
                    foreach (var blockAlt in blockElem.Alternatives)
                    {
                        ResolveRules(language, blockAlt);
                    }
                }
            }
        }

        private void ResolveRules(Language language, ParserRuleAlternative alt)
        {
            foreach (var elem in alt.Elements)
            {
                if (elem is ParserRuleReferenceElement refElem)
                {
                    refElem.Rule = language.Grammar.Rules.FirstOrDefault(r => refElem.RuleName.Length == 1 && refElem.RuleName[0] == r.Name);
                    if (refElem.Rule is null)
                    {
                        Error(refElem.Location, $"Rule '{string.Join(".", refElem.RuleName)}' cannot be found (are you missing a using directive?).");
                    }
                    else if (refElem.Rule is LexerRule lexerRule)
                    {
                        if (lexerRule.IsFragment)
                        {
                            Error(refElem.Location, $"Lexer rule '{string.Join(".", refElem.RuleName)}' is a fragment, it cannot be referenced from a parser rule.");
                        }
                        if (lexerRule.IsHidden)
                        {
                            Error(refElem.Location, $"Lexer rule '{string.Join(".", refElem.RuleName)}' is hidden, it cannot be referenced from a parser rule.");
                        }
                    }
                }
                else if (elem is ParserRuleBlockElement blockElem)
                {
                    foreach (var blockAlt in blockElem.Alternatives)
                    {
                        ResolveRules(language, blockAlt);
                    }
                }
                else if (elem is ParserRuleFixedStringElement fixedStringElem)
                {
                    var lexerRule = ResolveFixedLexerRule(language.Grammar, fixedStringElem.Value);
                    if (lexerRule is null)
                    {
                        lexerRule = new LexerRule() { Location = fixedStringElem.Location };
                        var singleAlt = new LexerRuleAlternative();
                        singleAlt.Elements.Add(new LexerRuleFixedStringElement() { ValueText = fixedStringElem.ValueText });
                        lexerRule.Alternatives.Add(singleAlt);
                        lexerRule.Name = MakeFixedLexerRuleName(language.Grammar, fixedStringElem.Value);
                        language.Grammar.Rules.Add(lexerRule);
                    }
                    fixedStringElem.LexerRule = lexerRule;
                }
            }
        }

        private LexerRule? ResolveFixedLexerRule(Grammar grammar, string value)
        {
            var rules = grammar.Rules.OfType<LexerRule>().Where(lr => lr.FixedValue == value).ToImmutableArray();
            if (rules.Length >= 1) return rules[0];
            else return null;
        }

        private string MakeFixedLexerRuleName(Grammar grammar, string value)
        {
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
            if (HasRuleName(grammar, result))
            {
                var index = 0;
                while (true)
                {
                    ++index;
                    var name = $"{result}{index}";
                    if (!HasRuleName(grammar, name)) return name;
                }
            }
            return result;
        }

        private bool HasRuleName(Grammar grammar, string name)
        {
            foreach (var rule in grammar.Rules)
            {
                if (rule.Name == name) return true;
            }
            return false;
        }

        private string? GetOtherCharacterName(char ch)
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

        private void ResolveLists(Language language)
        {
            foreach (var rule in language.Grammar.Rules)
            {
                if (rule is ParserRule pr)
                {
                    foreach (var alt in pr.Alternatives)
                    {
                        ResolveLists(alt);
                    }
                }
            }
        }

        private void ResolveLists(ParserRuleAlternative alt)
        {
            for (int i = 0; i < alt.Elements.Count - 1; i++)
            {
                var elem = alt.Elements[i];
                var nextElem = alt.Elements[i + 1];
                if (elem is ParserRuleReferenceElement firstRef && elem.Multiplicity == Multiplicity.ExactlyOne && firstRef.Rule is ParserRule firstRule && 
                    nextElem is ParserRuleBlockElement block && block.Alternatives.Count == 1 && block.Alternatives[0].Elements.Count == 2 &&
                    (block.Multiplicity == Multiplicity.ZeroOrMore || block.Multiplicity == Multiplicity.OneOrMore || 
                    block.Multiplicity == Multiplicity.NonGreedyZeroOrMore || block.Multiplicity == Multiplicity.NonGreedyOneOrMore))
                {
                    var sep = block.Alternatives[0].Elements[0];
                    var next = block.Alternatives[0].Elements[1];
                    if (next is ParserRuleReferenceElement nextRef && nextRef.Rule is ParserRule nextRule)
                    {
                        if (firstRule == nextRule)
                        {
                            LexerRule? separator = null;
                            if (sep is ParserRuleReferenceElement sepRef && sepRef.Rule is LexerRule sepLexerRule && sepLexerRule.IsFixed)
                            {
                                separator = sepLexerRule;
                            }
                            else if (sep is ParserRuleFixedStringElement sepFixed)
                            {
                                separator = sepFixed.LexerRule;
                            }
                            if (separator is not null)
                            {
                                var list = new ParserRuleListElement();
                                list.Block = block;
                                list.First = firstRef;
                                list.Separator = separator;
                                list.Next = nextRef;
                                list.Annotations.AddRange(block.Annotations);
                                list.Name = block.Name;
                                list.NameAnnotations.AddRange(block.NameAnnotations);
                                alt.Elements.RemoveAt(i + 1);
                                alt.Elements[i] = list;
                            }
                        }
                    }
                }
            }
        }

        private void ParseNamespace(Language language)
        {
            if (MatchKeyword("namespace"))
            {
                language.Namespace = ParseQualifier(".");
                MatchSemicolon();
            }
        }

        private void ParseUsings(Language language)
        {
            while (IsKeyword("using"))
            {
                var token = _tokens.NextToken();
                var usingKind = UsingKind.None;
                if (token.Kind == MetaCompilerTokenKind.Keyword)
                {
                    if (token.Text == "language") usingKind = UsingKind.Language;
                    else Expected("language");
                    _tokens.NextToken();
                }
                var usingDecl = new Using();
                usingDecl.Kind = usingKind;
                var aliasOrReferenceLocation = _tokens.CurrentLocation;
                var aliasOrReference = ParseQualifier(".");
                token = _tokens.CurrentToken;
                if (token.Text == "=")
                {
                    _tokens.NextToken();
                    usingDecl.ReferenceLocation = _tokens.CurrentLocation;
                    usingDecl.Reference = ParseQualifier(".");
                    if (aliasOrReference.Length != 1)
                    {
                        Error(aliasOrReferenceLocation, "Alias name was expected, but a qualified name was found.");
                    }
                    usingDecl.AliasLocation = aliasOrReferenceLocation;
                    usingDecl.Alias = aliasOrReference.FirstOrDefault();
                }
                else
                {
                    usingDecl.Reference = aliasOrReference;
                    usingDecl.ReferenceLocation = aliasOrReferenceLocation;
                }
                language.Usings.Add(usingDecl);
                MatchSemicolon();
            }
        }

        private void ParseLanguageDeclaration(Language language)
        {
            if (MatchKeyword("language"))
            {
                var token = _tokens.CurrentToken;
                if (token.Kind == MetaCompilerTokenKind.Identifier)
                {
                    language.Name = token.Text;
                    language.Location = _tokens.CurrentLocation;
                    _tokens.NextToken();
                    MatchSemicolon();
                }
                else
                {
                    Error("Identifier expected");
                }
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
            while (!_tokens.EndOfFile && token.Text == "[")
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
                annotation.Location = _tokens.CurrentLocation;
                annotation.Name = ParseQualifier(".");
                token = _tokens.CurrentToken;
                if (token.Text == "(")
                {
                    _tokens.NextToken();
                    ParseAnnotationProperties(annotation);
                    MatchOther(")");
                    token = _tokens.CurrentToken;
                }
                if (token.Text == "]")
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
                        property.Location = _tokens.CurrentLocation;
                        property.Name = token.Text;
                        token = _tokens.NextToken();
                        if (token.Text == "=")
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
                        Error("Identifier expected");
                        _tokens.NextToken();
                    }
                }
                else 
                {
                    if (token.Text == ",")
                    {
                        propertyExpected = true;
                        _tokens.NextToken();
                    }
                    else if (token.Text == ")")
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
            bool isFragment = false;
            bool isHidden = false;
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Keyword)
            {
                isFragment = token.Text == "fragment";
                isHidden = token.Text == "hidden";
                if (isFragment || isHidden) token = _tokens.NextToken();
            }
            if (token.Kind == MetaCompilerTokenKind.Identifier && token.Text.Length > 0 && char.IsUpper(token.Text[0]))
            {
                var rule = new LexerRule();
                grammar.Rules.Add(rule);
                rule.IsFragment = isFragment;
                rule.IsHidden = isHidden;
                rule.Location = _tokens.CurrentLocation;
                rule.Name = token.Text;
                rule.Annotations.AddRange(_annotations);
                _annotations.Clear();
                token = _tokens.NextToken();
                if (token.Text == ":")
                {
                    ParseLexerRuleAlternatives(rule.Alternatives, ";");
                    token = _tokens.CurrentToken;
                    if (token.Text == ";") _tokens.NextToken();
                }
                else
                {
                    Expected(":");
                }
                return true;
            }
            return false;
        }

        private void ParseLexerRuleAlternatives(List<LexerRuleAlternative> alternatives, string end)
        {
            _tokens.NextToken();
            while (true)
            {
                var alt = new LexerRuleAlternative();
                alternatives.Add(alt);
                ParseLexerRuleAlternative(alt, end);
                var token = _tokens.CurrentToken;
                if (token.Text == "|")
                {
                    _tokens.NextToken();
                    continue;
                }
                else if (token.Text == end)
                {
                    _tokens.NextToken();
                    break;
                }
                else
                {
                    Expected("|", end);
                    break;
                }
            }
        }

        private void ParseLexerRuleAlternative(LexerRuleAlternative alt, string end)
        {
            var token = _tokens.CurrentToken;
            while (!_tokens.EndOfFile && token.Text != end && token.Text != "|")
            {
                var negated = false;
                if (token.Text == "~")
                {
                    negated = true;
                    token = _tokens.NextToken();
                }
                LexerRuleElement? element;
                if (token.Text == "(")
                {
                    element = ParseLexerRuleBlockElement();
                }
                else
                {
                    var nextToken1 = _tokens.PeekToken(1);
                    var nextToken2 = _tokens.PeekToken(2);
                    var nextToken3 = _tokens.PeekToken(3);
                    if (nextToken2.Position > nextToken1.Position + nextToken1.Text.Length) nextToken2 = MetaCompilerToken.None;
                    if (token.Kind == MetaCompilerTokenKind.Character && nextToken1.Text == "." && nextToken2.Text == "." && nextToken3.Kind == MetaCompilerTokenKind.Character)
                    {
                        var range = new LexerRuleRangeElement();
                        range.StartText = token.Text;
                        range.EndText = nextToken3.Text;
                        element = range;
                        _tokens.EatTokens(4);
                    }
                    else if (token.Kind == MetaCompilerTokenKind.String || token.Kind == MetaCompilerTokenKind.VerbatimString || token.Kind == MetaCompilerTokenKind.Character)
                    {
                        var str = new LexerRuleFixedStringElement();
                        str.ValueText = token.Text;
                        element = str;
                        _tokens.NextToken();
                    }
                    else if (token.Text == ".")
                    {
                        element = new LexerRuleWildcardElement();
                        _tokens.NextToken();
                    }
                    else if (token.Kind == MetaCompilerTokenKind.Identifier)
                    {
                        var reference = new LexerRuleReferenceElement();
                        reference.Location = _tokens.CurrentLocation;
                        reference.RuleName = ParseQualifier("::");
                        element = reference;
                    }
                    else
                    {
                        Unexpected();
                        token = _tokens.NextToken();
                        continue;
                    }
                }
                element.IsNegated = negated;
                alt.Elements.Add(element);
                token = _tokens.CurrentToken;
                var nextToken = _tokens.PeekToken(1);
                element.Multiplicity = Multiplicity.ExactlyOne;
                if (nextToken.Text == "?")
                {
                    if (token.Text == "?") element.Multiplicity = Multiplicity.NonGreedyZeroOrOne;
                    if (token.Text == "*") element.Multiplicity = Multiplicity.NonGreedyZeroOrMore;
                    if (token.Text == "+") element.Multiplicity = Multiplicity.NonGreedyOneOrMore;
                    if (element.Multiplicity != Multiplicity.ExactlyOne) _tokens.EatTokens(2);
                }
                else
                {
                    if (token.Text == "?") element.Multiplicity = Multiplicity.ZeroOrOne;
                    if (token.Text == "*") element.Multiplicity = Multiplicity.ZeroOrMore;
                    if (token.Text == "+") element.Multiplicity = Multiplicity.OneOrMore;
                    if (element.Multiplicity != Multiplicity.ExactlyOne) _tokens.EatTokens(1);
                }
                token = _tokens.CurrentToken;
            }
        }

        private LexerRuleElement ParseLexerRuleBlockElement()
        {
            var block = new LexerRuleBlockElement();
            ParseLexerRuleAlternatives(block.Alternatives, ")");
            var token = _tokens.CurrentToken;
            if (token.Text == ")") _tokens.NextToken();
            return block;
        }

        private bool TryParseParserRule(Grammar grammar)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Identifier && token.Text.Length > 0 && char.IsLower(token.Text[0]))
            {
                var rule = new ParserRule();
                grammar.Rules.Add(rule);
                rule.Location = _tokens.CurrentLocation;
                rule.Name = token.Text;
                rule.Annotations.AddRange(_annotations);
                _annotations.Clear();
                token = _tokens.NextToken();
                if (token.Text == ":")
                {
                    ParseParserRuleAlternatives(rule.Alternatives, ";");
                    token = _tokens.CurrentToken;
                    if (token.Text == ";") _tokens.NextToken();
                }
                else
                {
                    Expected(":");
                }
                return true;
            }
            return false;
        }

        private void ParseParserRuleAlternatives(List<ParserRuleAlternative> alternatives, string end)
        {
            _tokens.NextToken();
            while (true)
            {
                var alt = new ParserRuleAlternative();
                alternatives.Add(alt);
                ParseAnnotations();
                var token = _tokens.PeekToken(0);
                var hashmark = _tokens.PeekToken(1);
                if (token.Kind == MetaCompilerTokenKind.Identifier && hashmark.Text == "#")
                {
                    alt.Location = _tokens.CurrentLocation;
                    alt.Name = token.Text;
                    _tokens.EatTokens(2);
                    alt.Annotations.AddRange(_annotations);
                    _annotations.Clear();
                }
                ParseParserRuleAlternative(alt, end);
                token = _tokens.CurrentToken;
                if (token.Text == "|")
                {
                    _tokens.NextToken();
                    continue;
                }
                else if (token.Text == end)
                {
                    _tokens.NextToken();
                    break;
                }
                else
                {
                    Expected("|", end);
                    break;
                }
            }
        }

        private void ParseParserRuleAlternative(ParserRuleAlternative alt, string end)
        {
            ParseAnnotations();
            var token = _tokens.CurrentToken;
            while (!_tokens.EndOfFile && token.Text != end && token.Text != "|")
            {
                string? propertyName = null;
                Location? propertyLocation = null;
                var propertyAssignment = AssignmentOperator.None;
                var propertyAnnotations = new List<Annotation>();
                var negated = false;
                var nextToken1 = _tokens.PeekToken(1);
                var nextToken2 = _tokens.PeekToken(2);
                if (nextToken2.Position > nextToken1.Position + nextToken1.Text.Length) nextToken2 = MetaCompilerToken.None;
                if (token.Kind == MetaCompilerTokenKind.Identifier && (nextToken1.Text == "=" || (nextToken2.Text == "=" && (nextToken1.Text == "?" || nextToken1.Text == "!" || nextToken1.Text == "+"))))
                {
                    propertyLocation = _tokens.CurrentLocation;
                    propertyName = token.Text;
                    propertyAssignment = AssignmentOperator.Assign;
                    if (nextToken1.Text == "=")
                    {
                        _tokens.EatTokens(2);
                    }
                    else if (nextToken2.Text == "=")
                    {
                        if (nextToken1.Text == "?") propertyAssignment = AssignmentOperator.QuestionAssign;
                        if (nextToken1.Text == "!") propertyAssignment = AssignmentOperator.NegatedAssign;
                        if (nextToken1.Text == "+") propertyAssignment = AssignmentOperator.PlusAssign;
                        _tokens.EatTokens(3);
                    }
                    propertyAnnotations.AddRange(_annotations);
                    _annotations.Clear();
                }
                ParseAnnotations();
                var elementAnnotations = new List<Annotation>(_annotations);
                _annotations.Clear();
                token = _tokens.CurrentToken;
                ParserRuleElement? element;
                if (token.Text == "~")
                {
                    negated = true;
                    token = _tokens.NextToken();
                }
                if (token.Text == "(")
                {
                    element = ParseParserRuleBlockElement();
                }
                else
                {
                    if (token.Text == ".")
                    {
                        element = new ParserRuleWildcardElement();
                        _tokens.NextToken();
                    }
                    else if (token.Kind == MetaCompilerTokenKind.String || token.Kind == MetaCompilerTokenKind.VerbatimString || token.Kind == MetaCompilerTokenKind.Character)
                    {
                        var str = new ParserRuleFixedStringElement();
                        str.ValueText = token.Text;
                        element = str;
                        _tokens.NextToken();
                    }
                    else if (token.Kind == MetaCompilerTokenKind.Keyword && token.Text == "eof")
                    {
                        element = new ParserRuleEofElement();
                        _tokens.NextToken();
                    }
                    else if (token.Kind == MetaCompilerTokenKind.Identifier)
                    {
                        var reference = new ParserRuleReferenceElement();
                        reference.Location = _tokens.CurrentLocation;
                        reference.RuleName = ParseQualifier("::");
                        element = reference;
                    }
                    else
                    {
                        Unexpected();
                        token = _tokens.NextToken();
                        continue;
                    }
                }
                element.IsNegated = negated;
                element.NameLocation = propertyLocation;
                element.Name = propertyName;
                element.NameAnnotations.AddRange(propertyAnnotations);
                element.AssignmentOperator = propertyAssignment;
                element.Annotations.AddRange(elementAnnotations);
                _annotations.Clear();
                alt.Elements.Add(element);
                token = _tokens.CurrentToken;
                nextToken1 = _tokens.PeekToken(1);
                element.Multiplicity = Multiplicity.ExactlyOne;
                if (nextToken1.Text == "?")
                {
                    if (token.Text == "?") element.Multiplicity = Multiplicity.NonGreedyZeroOrOne;
                    if (token.Text == "*") element.Multiplicity = Multiplicity.NonGreedyZeroOrMore;
                    if (token.Text == "+") element.Multiplicity = Multiplicity.NonGreedyOneOrMore;
                    if (element.Multiplicity != Multiplicity.ExactlyOne) _tokens.EatTokens(2);
                }
                else
                {
                    if (token.Text == "?") element.Multiplicity = Multiplicity.ZeroOrOne;
                    if (token.Text == "*") element.Multiplicity = Multiplicity.ZeroOrMore;
                    if (token.Text == "+") element.Multiplicity = Multiplicity.OneOrMore;
                    if (element.Multiplicity != Multiplicity.ExactlyOne) _tokens.EatTokens(1);
                }
                token = _tokens.CurrentToken;
            }
        }

        private ParserRuleElement ParseParserRuleBlockElement()
        {
            var block = new ParserRuleBlockElement();
            ParseParserRuleAlternatives(block.Alternatives, ")");
            var token = _tokens.CurrentToken;
            if (token.Text == ")") _tokens.NextToken();
            return block;
        }

        private ImmutableArray<string> ParseQualifier(string separator)
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
                        return result.ToImmutableAndFree();
                    }
                }
                else 
                {
                    if (separator.Length == 1 && token.Text == separator)
                    {
                        _tokens.NextToken();
                        idExpected = true;
                        continue;
                    }
                    else if (separator.Length > 1)
                    {
                        for (int i = 0; i < separator.Length; i++)
                        {
                            if (_tokens.PeekToken(i).Text != separator[i].ToString()) return result.ToImmutableAndFree();
                        }
                        _tokens.EatTokens(separator.Length);
                        idExpected = true;
                        continue;
                    }
                    return result.ToImmutableAndFree();
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
            try
            {
                _tokens.IgnoreWhitespaceAndComments = false;
                var token = _tokens.CurrentToken;
                while (!_tokens.EndOfFile && (parenthesisCounter > 0 || bracketsCounter > 0 || bracesCounter > 0 || !untilOther.Contains(token.Text)))
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
            Error(_tokens.CurrentLocation, message);
        }

        private void Error(Location location, string message)
        {
            var token = _tokens.CurrentToken;
            _diagnosticBag.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, location, message));
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
