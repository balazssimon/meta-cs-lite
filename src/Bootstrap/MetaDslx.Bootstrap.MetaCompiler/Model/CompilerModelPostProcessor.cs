using Antlr4.Runtime;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Roslyn.Utilities;
using System.Xml.Linq;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    public class CompilerModelPostProcessor
    {
        private static readonly string DefaultReferenceFullName = typeof(DefaultReferenceAnnotation).FullName!;

        private readonly MetaDslx.Modeling.Model _model;
        private CancellationToken _cancellationToken;
        private Language _language;
        private Grammar _grammar;
        private DiagnosticBag _diagnostics;
        private HashSet<string> _ruleNames;
        private Dictionary<Rule, List<Element>> _ruleRefs;
        private Dictionary<string, TokenKind> _tokenKinds;
        private Dictionary<string, Token> _fixedTokens;
        private TokenKind _keywordKind;
        private GrammarRule _defaultReferenceRule;
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
            _ruleRefs = new Dictionary<Rule, List<Element>>();
            _tokenKinds = new Dictionary<string, TokenKind>();
            _fixedTokens = new Dictionary<string, Token>();
            _keywordKind = AddTokenKind("Keyword", typeof(KeywordTokenKind).FullName!);
            AddTokens();
            CheckDefaultReference();
            SetDefaults();
            AddRules();
            MergeSingleTokenAlts();
            MergeSeparatedLists();
            AddCSharpNames();
            ComputeContainsBinders();
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
                AddTokenKindFor(fixedToken);
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
                                if (keyword.Text.IsIdentifier()) fixedToken.TokenKind = _keywordKind;
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
                AddTokenKindFor(token);
                token.CSharpName = AddRuleName(token.Name ?? MakeTokenName(), tryWithoutIndex: true);
                _grammar.Tokens.Add(token);
            }
        }

        private void AddTokenKindFor(Token token)
        {
            var tokenKindSymbol = token.Annotations.Where(a => a.AttributeClass.Name?.EndsWith("TokenKind") ?? false).FirstOrDefault()?.AttributeClass ?? default;
            var tokenKindName = tokenKindSymbol.Name;
            var tokenKindFullName = tokenKindSymbol.FullName;
            if (tokenKindName is not null && tokenKindName.EndsWith("TokenKind") && !string.IsNullOrEmpty(tokenKindFullName))
            {
                tokenKindName = tokenKindName.Substring(0, tokenKindName.Length - 9);
                if (!_tokenKinds.TryGetValue(tokenKindFullName, out var tokenKind)) 
                {
                    tokenKind = AddTokenKind(tokenKindName, tokenKindFullName);
                }
                token.TokenKind = tokenKind;
            }
        }

        private TokenKind AddTokenKind(string name, string fullName)
        {
            var result = f.TokenKind();
            result.Name = name;
            result.TypeName = fullName;
            _grammar.TokenKinds.Add(result);
            _tokenKinds.Add(fullName, result);
            return result;
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

        private void CheckDefaultReference()
        {
            foreach (var rule in _grammar.GrammarRules)
            {
                var isDefaultRef = rule.Annotations.Any(a => a.AttributeClass.Name == nameof(DefaultReferenceAnnotation) && a.AttributeClass.FullName == DefaultReferenceFullName);
                if (isDefaultRef)
                {
                    if (_defaultReferenceRule is null)
                    {
                        _defaultReferenceRule = rule;
                    }
                    else
                    {
                        _diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_AmbiguousDefaultReference, SourceLocation.None, ((IModelObject)_defaultReferenceRule).Name, ((IModelObject)rule).Name));
                    }
                }
            }
            if (_defaultReferenceRule is null)
            {
                _diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_MissingDefaultReference, SourceLocation.None));
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

        private void AddRules()
        {
            var allRules = _model.Objects.OfType<Rule>().ToImmutableArray();
            foreach (var rule in allRules)
            {
                AddBinders(rule.Binders, rule.Annotations);
                AddAlternatives(rule);
            }
            foreach (var rule in allRules)
            {
                if (rule is Block blk && ((IModelObject)blk).Parent is Element elem)
                {
                    var blockRef = f.RuleRef();
                    blockRef.GrammarRule = blk;
                    elem.Value = blockRef;
                }
                _grammar.Rules.Add(rule);
            }
        }

        private void AddAlternatives(Rule rule)
        {
            foreach (var alt in rule.Alternatives)
            {
                AddBinders(alt.Binders, alt.Annotations);
                if (alt.ReturnValue is not null)
                {
                    var constBinder = f.Binder();
                    constBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.ConstantBinder).FullName!;
                    var constValue = f.BinderArgument();
                    constValue.Name = "value";
                    constValue.TypeName = typeof(object).FullName!;
                    constValue.IsArray = false;
                    var value = alt.ReturnValue.Value;
                    if (value.IsModelObject || value.IsSymbol) constValue.Values.Add(value.FullName ?? string.Empty);
                    else constValue.Values.Add(value.OriginalValue?.ToString() ?? string.Empty);
                    constBinder.Arguments.Add(constValue);
                    alt.Binders.Add(constBinder);
                }
                else if (!alt.ReturnType.IsNull)
                {
                    var skipDefineBinder = false;
                    if (alt.Elements.Count == 1)
                    {
                        var celem = alt.Elements[0];
                        if (celem.Multiplicity == Multiplicity.ExactlyOne && string.IsNullOrEmpty(celem.SymbolProperty.FirstOrDefault().Name))
                        {
                            if (celem.Value is RuleRef) skipDefineBinder = true;
                            if (celem.Value is Block pb && !pb.ReturnType.IsNull) skipDefineBinder = true;
                        }
                    }
                    if (!skipDefineBinder)
                    {
                        var defBinder = f.Binder();
                        defBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.DefineBinder).FullName!;
                        var defType = f.BinderArgument();
                        defType.Name = "type";
                        defType.TypeName = typeof(Type).FullName!;
                        defType.IsArray = false;
                        defType.Values.Add(alt.ReturnType.FullName);
                        defBinder.Arguments.Add(defType);
                        alt.Binders.Add(defBinder);
                    }
                }
                AddElements(alt);
            }
        }

        private void AddElements(Alternative alt)
        {
            foreach (var elem in alt.Elements)
            {
                var name = elem.SymbolProperty.FirstOrDefault().Name;
                elem.Name = name;
                AddBinders(elem.Binders, elem.NameAnnotations);
                if (!string.IsNullOrEmpty(name))
                {
                    var propBinder = f.Binder();
                    propBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.PropertyBinder).FullName!;
                    propBinder.IsNegated = elem.Assignment == Assignment.NegatedAssign;
                    var propName = f.BinderArgument();
                    propName.Name = "name";
                    propName.TypeName = typeof(string).FullName!;
                    propName.IsArray = false;
                    propName.Values.Add(name);
                    propBinder.Arguments.Add(propName);
                    elem.Binders.Add(propBinder);
                }
                var value = elem.Value;
                AddBinders(value.Binders, elem.ValueAnnotations);
                if (value is RuleRef rr)
                {
                    if (rr.Rule is not null)
                    {
                        if (!_ruleRefs.TryGetValue(rr.Rule, out var ruleRefs))
                        {
                            ruleRefs = new List<Element>();
                            _ruleRefs.Add(rr.Rule, ruleRefs);
                        }
                        ruleRefs.Add(elem);
                    }
                    if (rr.ReferencedTypes.Count > 0)
                    {
                        if (rr.GrammarRule is null) rr.GrammarRule = _defaultReferenceRule;
                        var useBinder = f.Binder();
                        useBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.UseBinder).FullName!;
                        var useTypes = f.BinderArgument();
                        useTypes.Name = "types";
                        useTypes.TypeName = typeof(Type).FullName!;
                        useTypes.IsArray = true;
                        foreach (var type in rr.ReferencedTypes)
                        {
                            useTypes.Values.Add(type.FullName);
                        }
                        useBinder.Arguments.Add(useTypes);
                        value.Binders.Add(useBinder);
                    }
                }
            }
        }

        private void MergeSingleTokenAlts()
        {
            var rules = _model.Objects.OfType<Rule>().ToList();
            for (int i = 0; i < rules.Count; ++i)
            {
                var rule = rules[i];
                var singleTokenAlts = rule.Alternatives.Where(IsSingleTokenAlt).ToImmutableArray();
                if (singleTokenAlts.Length < 2) continue;
                var tokens = ArrayBuilder<RuleRef>.GetInstance();
                var tokenAlts = f.TokenAlts();
                foreach (var singleTokenAlt in singleTokenAlts)
                {
                    var singleElem = singleTokenAlt.Elements[0];
                    var singleToken = (RuleRef)singleElem.Value;
                    ((IModelObject)singleToken).Parent = null;
                    tokens.Add(singleToken);
                    InsertBinders(singleToken.Binders, singleTokenAlt.Binders);
                    rule.Alternatives.Remove(singleTokenAlt);
                    _model.DeleteObject((IModelObject)singleTokenAlt);
                }
                tokenAlts.Tokens.AddRange(tokens);
                tokens.Free();
                if (rule.Alternatives.Count == 0)
                {
                    InsertBinders(tokenAlts.Binders, rule.Binders);
                    if (_ruleRefs.TryGetValue(rule, out var ruleRefs))
                    {
                        foreach (var ruleRef in ruleRefs)
                        {
                            ruleRef.Value = (TokenAlts)((IModelObject)tokenAlts).Clone();
                        }
                        _ruleRefs.Remove(rule);
                    }
                    _model.DeleteObject((IModelObject)tokenAlts);
                    _model.DeleteObject((IModelObject)rule);
                }
                else
                {
                    var tokensElem = f.Element();
                    tokensElem.Value = tokenAlts;
                    var tokensAlt = f.Alternative();
                    tokensAlt.Elements.Add(tokensElem);
                    rule.Alternatives.Insert(0, tokensAlt);
                }
            }
        }

        private static bool IsSingleTokenAlt(Alternative alt)
        {
            if (alt.Elements.Count != 1) return false;
            var elem = alt.Elements[0];
            if (elem.Multiplicity.IsSingle() && elem.Value is RuleRef rr && rr.Token is not null)
            {
                return true;
            }
            return false;
        }
        
        private void MergeSeparatedLists()
        {
            var rules = _model.Objects.OfType<Rule>().ToList();
            for (int i = 0; i < rules.Count; ++i)
            {
                var rule = rules[i];
                for (int j = 0; j < rule.Alternatives.Count; ++j)
                {
                    var alt = rule.Alternatives[j];
                    for (int k = 0; k < alt.Elements.Count; ++k)
                    {
                        var elem = alt.Elements[k];
                        if (elem.Multiplicity.IsList() && elem.Value is RuleRef ruleRef && ruleRef.Rule is not null && ruleRef.Rule.Alternatives.Count == 1)
                        {
                            SeparatedList? list = null;
                            Rule? item = null;
                            Token? separator = null;
                            string? name = null;
                            var repeatedAlt = ruleRef.Rule.Alternatives[0];
                            if (repeatedAlt.Elements.Count == 2)
                            {
                                var repeatedElem1 = repeatedAlt.Elements[0];
                                var repeatedElem2 = repeatedAlt.Elements[1];
                                if (repeatedElem1.Multiplicity.IsSingle() && repeatedElem1.Value is RuleRef rr1 && 
                                    repeatedElem2.Multiplicity.IsSingle() && repeatedElem2.Value is RuleRef rr2)
                                {
                                    if (rr1.Token is not null && rr2.Rule is not null)
                                    {
                                        list = f.SeparatedList();
                                        list.RepeatedSeparatorFirst = true;
                                        list.RepeatedSeparator = repeatedElem1;
                                        list.RepeatedItem = repeatedElem2;
                                        separator = rr1.Token;
                                        item = rr2.Rule;
                                        name = repeatedElem2.Name;
                                    }
                                    else if (rr1.Rule is not null && rr2.Token is not null)
                                    {
                                        list = f.SeparatedList();
                                        list.RepeatedSeparatorFirst = false;
                                        list.RepeatedSeparator = repeatedElem2;
                                        list.RepeatedItem = repeatedElem1;
                                        separator = rr2.Token;
                                        item = rr1.Rule;
                                        name = repeatedElem1.Name;
                                    }
                                }
                            }
                            if (list is not null)
                            {
                                list.SeparatorFirst = list.RepeatedSeparatorFirst;
                                var firstIndex = k;
                                var lastIndex = k;
                                var firstItems = ArrayBuilder<Element>.GetInstance();
                                var firstSeparators = ArrayBuilder<Element>.GetInstance();
                                var lastItems = ArrayBuilder<Element>.GetInstance();
                                var lastSeparators = ArrayBuilder<Element>.GetInstance();
                                if (k > 0)
                                {
                                    var searchPrevElemens = false;
                                    var prevElem = alt.Elements[k - 1];
                                    if (list.RepeatedSeparatorFirst)
                                    {
                                        if (prevElem.Name == name && prevElem.Multiplicity == Multiplicity.ExactlyOne && prevElem.Value is RuleRef prevRule && prevRule.Rule == item)
                                        {
                                            firstItems.Add(prevElem);
                                            firstIndex = k - 1;
                                            list.SeparatorFirst = false;
                                            searchPrevElemens = true;
                                        }
                                    }
                                    else
                                    {
                                        if (prevElem.Multiplicity == Multiplicity.ExactlyOne && prevElem.Value is RuleRef prevToken && prevToken.Token == separator)
                                        {
                                            firstSeparators.Add(prevElem);
                                            firstIndex = k - 1;
                                            list.SeparatorFirst = true;
                                            searchPrevElemens = true;
                                        }
                                    }
                                    var l = 1;
                                    while (searchPrevElemens && k - l * 2 >= 0)
                                    {
                                        searchPrevElemens = false;
                                        var prevElem1 = alt.Elements[k - l * 2];
                                        var prevElem2 = alt.Elements[k - l * 2 + 1];
                                        if (list.RepeatedSeparatorFirst)
                                        {
                                            if (prevElem1.Name == name && prevElem1.Multiplicity == Multiplicity.ExactlyOne && prevElem1.Value is RuleRef prevRule1 && prevRule1.Rule == item &&
                                                prevElem2.Multiplicity == Multiplicity.ExactlyOne && prevElem2.Value is RuleRef prevToken2 && prevToken2.Token == separator)
                                            {
                                                firstItems.Insert(0, prevElem1);
                                                firstSeparators.Insert(0, prevElem2);
                                                firstIndex = k - l * 2;
                                                list.SeparatorFirst = false;
                                                searchPrevElemens = true;
                                            }
                                        }
                                        else
                                        {
                                            if (prevElem2.Name == name && prevElem2.Multiplicity == Multiplicity.ExactlyOne && prevElem2.Value is RuleRef prevRule2 && prevRule2.Rule == item &&
                                                prevElem1.Multiplicity == Multiplicity.ExactlyOne && prevElem1.Value is RuleRef prevToken1 && prevToken1.Token == separator)
                                            {
                                                firstItems.Insert(0, prevElem2);
                                                firstSeparators.Insert(0, prevElem1);
                                                firstIndex = k - l * 2;
                                                list.SeparatorFirst = true;
                                                searchPrevElemens = true;
                                            }
                                        }
                                        ++l;
                                    }
                                }
                                if (k < alt.Elements.Count - 1)
                                {
                                    var searchNextElemens = true;
                                    var l = 1;
                                    while (searchNextElemens && k + l < alt.Elements.Count)
                                    {
                                        searchNextElemens = false;
                                        var nextElem = alt.Elements[k + l];
                                        var mustBeSeparator = list.RepeatedSeparatorFirst ? l % 2 == 1 : l % 2 == 0;
                                        if (mustBeSeparator)
                                        {
                                            if (nextElem.Multiplicity.IsSingle() && nextElem.Value is RuleRef nextToken && nextToken.Token == separator)
                                            {
                                                lastSeparators.Add(nextElem);
                                                lastIndex = k + l;
                                                searchNextElemens = nextElem.Multiplicity == Multiplicity.ExactlyOne;
                                            }
                                        }
                                        else
                                        {
                                            if (nextElem.Name == name && nextElem.Multiplicity.IsSingle() && nextElem.Value is RuleRef nextRule && nextRule.Rule == item)
                                            {
                                                lastItems.Add(nextElem);
                                                lastIndex = k + l;
                                                searchNextElemens = nextElem.Multiplicity == Multiplicity.ExactlyOne;
                                            }
                                        }
                                        ++l;
                                    }
                                }
                                alt.Elements.RemoveRange(firstIndex, lastIndex - firstIndex + 1);
                                list.FirstItems.AddRange(firstItems);
                                firstItems.Free();
                                list.FirstSeparators.AddRange(firstSeparators);
                                firstSeparators.Free();
                                list.RepeatedBlock = elem;
                                list.LastItems.AddRange(lastItems);
                                lastItems.Free();
                                list.LastSeparators.AddRange(lastSeparators);
                                lastSeparators.Free();
                                if (string.IsNullOrEmpty(ruleRef.Rule.Name))
                                {
                                    _grammar.Rules.Remove(ruleRef.Rule);
                                }
                                if (alt.Elements.Count == 0 && rule.Alternatives.Count == 1)
                                {
                                    InsertBinders(list.Binders, alt.Binders);
                                    InsertBinders(list.Binders, rule.Binders);
                                    if (_ruleRefs.TryGetValue(rule, out var listRuleRefs))
                                    {
                                        foreach (var listRuleRef in listRuleRefs)
                                        {
                                            listRuleRef.Value = (SeparatedList)((IModelObject)list).Clone();
                                        }
                                        _ruleRefs.Remove(rule);
                                    }
                                    _model.DeleteObject((IModelObject)list);
                                    _model.DeleteObject((IModelObject)rule);
                                }
                                else
                                {
                                    var listElem = f.Element();
                                    listElem.Name = name;
                                    listElem.Value = list;
                                    alt.Elements.Insert(firstIndex, listElem);
                                }
                            }
                        }
                    }
                }
            }
        }
        
        // TODO: optional
        private void MergeSingleAlts()
        {
            var rules = _model.Objects.OfType<Rule>().ToList();
            var merged = true;
            while (merged)
            {
                merged = false;
                for (int i = 0; i < rules.Count; ++i)
                {
                    var rule = rules[i];
                    for (int j = rule.Alternatives.Count - 1; j >= 0; --j)
                    {
                        var alt = rule.Alternatives[j];
                        if (alt.Elements.Count == 1)
                        {
                            var singleElem = alt.Elements[0];
                            if (singleElem.Multiplicity == Multiplicity.ExactlyOne && singleElem.Value is RuleRef rr)
                            {
                                var rrRule = rr.Rule;
                                if (_ruleRefs.TryGetValue(rrRule, out var ruleRefs) && ruleRefs.Count == 1)
                                {
                                    merged = true;
                                    if (rrRule.Alternatives.Count == 1)
                                    {
                                        var rrAlt = rrRule.Alternatives[0];
                                        if (string.IsNullOrEmpty(rrAlt.Name))
                                        {
                                            if (!string.IsNullOrEmpty(alt.Name)) rrAlt.Name = alt.Name;
                                            else if (!string.IsNullOrEmpty(singleElem.Name)) rrAlt.Name = singleElem.Name;
                                            else if (!string.IsNullOrEmpty(rrRule.Name)) rrAlt.Name = rrRule.Name;
                                        }
                                        InsertBinders(rrAlt.Binders, rrRule.Binders);
                                        InsertBinders(rrAlt.Binders, singleElem.Value.Binders);
                                        InsertBinders(rrAlt.Binders, singleElem.Binders);
                                        InsertBinders(rrAlt.Binders, alt.Binders);
                                        rrRule.Alternatives.Clear();
                                        rule.Alternatives[j] = rrAlt;
                                        _model.DeleteObject((IModelObject)alt);
                                        _ruleRefs.Remove(rrRule);
                                    }
                                    else
                                    {
                                        rule.Alternatives.RemoveAt(j);
                                        foreach (var refAlt in rrRule.Alternatives)
                                        {
                                            InsertBinders(refAlt.Binders, rrRule.Binders);
                                            InsertBinders(refAlt.Binders, singleElem.Value.Binders);
                                            InsertBinders(refAlt.Binders, singleElem.Binders);
                                            InsertBinders(refAlt.Binders, alt.Binders);
                                        }
                                        InsertAlternativesAt(rule.Alternatives, j, rrRule.Alternatives);
                                        _model.DeleteObject((IModelObject)alt);
                                        _ruleRefs.Remove(rrRule);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
        
        private void InsertBinders(ICollectionSlot<Binder> target, ICollectionSlot<Binder> source)
        {
            foreach (var binder in source)
            {
                ((IModelObject)binder).Parent = null;
            }
            target.InsertRange(0, source);
        }

        private void InsertAlternativesAt(ICollectionSlot<Alternative> target, int index, ICollectionSlot<Alternative> source)
        {
            foreach (var alt in source)
            {
                ((IModelObject)alt).Parent = null;
            }
            target.InsertRange(index, source);
        }


        private void AddCSharpNames()
        {
            var usedElementNames = PooledHashSet<string>.GetInstance();
            foreach (var rule in _grammar.Rules.Where(r => !string.IsNullOrEmpty(r.Name)))
            {
                usedElementNames.Clear();
                usedElementNames.Add("kind");
                usedElementNames.Add("annotations");
                usedElementNames.Add("diagnostics");
                AddCSharpNames(rule, usedElementNames);
            }
            usedElementNames.Free();
        }

        private void AddCSharpNames(Rule rule, HashSet<string> usedElementNames)
        {
            rule.CSharpName = AddRuleName(rule.Name, tryWithoutIndex: true);
            var altIndex = 0;
            foreach (var alt in rule.Alternatives)
            {
                ++altIndex;
                if (string.IsNullOrEmpty(alt.Name))
                {
                    if (rule.Alternatives.Count == 1) alt.CSharpName = rule.CSharpName;
                    else alt.CSharpName = AddRuleName(rule.CSharpName + "Alt", tryWithoutIndex: false, indexHint: altIndex);
                }
                else
                {
                    alt.CSharpName = AddRuleName(alt.Name, tryWithoutIndex: true);
                }
                AddCSharpNames(alt.CSharpName, alt, usedElementNames);
            }
        }

        private void AddCSharpNames(string? contextName, Alternative alt, HashSet<string> usedElementNames)
        {
            foreach (var elem in alt.Elements)
            {
                AddCSharpNames(contextName, elem, usedElementNames);
            }
        }

        private void AddCSharpNames(string? contextName, Element elem, HashSet<string> usedElementNames)
        {
            if (elem.Value is Block blk && string.IsNullOrEmpty(blk.Name))
            {
                blk.Name = elem.Name ?? contextName + "Block";
                AddCSharpNames(blk, usedElementNames);
            }
            if (elem.Value is RuleRef rr && rr.Rule is Block rrBlk && string.IsNullOrEmpty(rrBlk.Name))
            {
                rrBlk.Name = elem.Name ?? contextName + "Block";
                AddCSharpNames(rrBlk, usedElementNames);
            }
            if (elem.Value is SeparatedList sl)
            {
                if (string.IsNullOrEmpty(elem.Name)) elem.Name = ((RuleRef)sl.RepeatedItem.Value).Rule?.Name + "List";
                var repeatedBlock = (Block)((RuleRef)sl.RepeatedBlock.Value).Rule!;
                if (string.IsNullOrEmpty(repeatedBlock.Name)) repeatedBlock.Name = elem.Name + "Block";
                AddCSharpNames(repeatedBlock, usedElementNames);
            }
            elem.CSharpName = AddElementName(contextName, elem, usedElementNames);
        }

        private string AddRuleName(string? ruleName, bool tryWithoutIndex, int indexHint = -1)
        {
            if (string.IsNullOrEmpty(ruleName)) ruleName = "Rule";
            if (tryWithoutIndex && !_ruleNames.Contains(ruleName, StringComparer.OrdinalIgnoreCase))
            {
                _ruleNames.Add(ruleName);
                return ruleName;
            }
            if (indexHint >= 0)
            {
                var name = $"{ruleName}{indexHint}";
                if (!_ruleNames.Contains(name, StringComparer.OrdinalIgnoreCase))
                {
                    _ruleNames.Add(name);
                    return name;
                }
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

        private string AddElementName(string? contextName, Element element, HashSet<string> usedElementNames)
        {
            var defaultName = element.Name;
            if (element.Value is Eof) defaultName = "EndOfFileToken";
            if (string.IsNullOrEmpty(defaultName))
            {
                if (element.Value is RuleRef rr)
                {
                    if (element.Multiplicity.IsList()) defaultName = rr.GrammarRule?.Name + "List";
                    else defaultName = rr.GrammarRule?.Name;
                }
                else if (element.Value is TokenAlts)
                {
                    defaultName = "Tokens";
                }
                else if (element.Value is SeparatedList)
                {
                    defaultName = "List";
                }
                else if (element.Value is Block) defaultName = "Block";
                if (string.IsNullOrEmpty(defaultName)) defaultName = "Element";
            }
            int i = 0;
            var name = defaultName;
            while (usedElementNames.Contains(name, StringComparer.InvariantCultureIgnoreCase))
            {
                ++i;
                name = $"{defaultName}{i}";
            }
            usedElementNames.Add(name);
            return name;
        }

        private void ComputeContainsBinders()
        {
            var rules = _model.Objects.OfType<Rule>().ToList();
            var updated = true;
            while (updated)
            {
                updated = false;
                foreach (var rule in rules)
                {
                    if (!rule.ContainsBinders && rule.Binders.Count > 0)
                    {
                        rule.ContainsBinders = true;
                        updated = true;
                    }
                    foreach (var alt in rule.Alternatives)
                    {
                        if (!alt.ContainsBinders && alt.Binders.Count > 0)
                        {
                            alt.ContainsBinders = true;
                            rule.ContainsBinders = true;
                            updated = true;
                        }
                        foreach (var elem in alt.Elements)
                        {
                            var oldContainsBinders = elem.ContainsBinders;
                            ComputeContainsBinders(elem);
                            if (!oldContainsBinders && elem.ContainsBinders)
                            {
                                alt.ContainsBinders = true;
                                rule.ContainsBinders = true;
                                updated = true;
                            }
                        }
                    }
                }
            }
        }

        private void ComputeContainsBinders(Element elem)
        {
            if (elem.Binders.Count > 0) elem.ContainsBinders = true;
            if (elem.Value is not null && elem.Value.Binders.Count > 0) elem.ContainsBinders = true;
            if (elem.Value is RuleRef rr)
            {
                rr.ContainsBinders = rr.Rule?.ContainsBinders ?? false;
                elem.ContainsBinders |= rr.ContainsBinders;
            }
            if (elem.Value is TokenAlts tas)
            {
                tas.ContainsBinders = tas.Tokens.Any(t => t.Binders.Count > 0);
                elem.ContainsBinders |= tas.ContainsBinders;
            }
            if (elem.Value is SeparatedList sl)
            {
                foreach (var e in sl.FirstItems) ComputeContainsBinders(e);
                if (sl.FirstItems.Any(e => e.ContainsBinders)) sl.ContainsBinders = true;
                foreach (var e in sl.FirstSeparators) ComputeContainsBinders(e);
                if (sl.FirstSeparators.Any(e => e.ContainsBinders)) sl.ContainsBinders = true;
                foreach (var e in sl.LastItems) ComputeContainsBinders(e);
                if (sl.LastItems.Any(e => e.ContainsBinders)) sl.ContainsBinders = true;
                foreach (var e in sl.LastSeparators) ComputeContainsBinders(e);
                if (sl.LastSeparators.Any(e => e.ContainsBinders)) sl.ContainsBinders = true;
                ComputeContainsBinders(sl.RepeatedBlock);
                if (sl.RepeatedBlock.ContainsBinders) sl.ContainsBinders = true;
                ComputeContainsBinders(sl.RepeatedItem);
                if (sl.RepeatedItem.ContainsBinders) sl.ContainsBinders = true;
                ComputeContainsBinders(sl.RepeatedSeparator);
                if (sl.RepeatedSeparator.ContainsBinders) sl.ContainsBinders = true;
                elem.ContainsBinders |= sl.ContainsBinders;
            }
        }

        private void SetDefaults()
        {
            foreach (var token in _grammar.Tokens)
            {
                if (token.TokenKind?.TypeName == typeof(DefaultWhitespaceTokenKind).FullName)
                {
                    _grammar.DefaultWhitespace = token;
                }
                if (token.TokenKind?.TypeName == typeof(DefaultEndOfLineTokenKind).FullName)
                {
                    _grammar.DefaultEndOfLine = token;
                }
                if (token.TokenKind?.TypeName == typeof(DefaultSeparatorTokenKind).FullName)
                {
                    _grammar.DefaultSeparator = token;
                }
                if (token.TokenKind?.TypeName == typeof(DefaultIdentifierTokenKind).FullName)
                {
                    _grammar.DefaultIdentifier = token;
                }
            }
            _grammar.MainRule = _grammar.Rules.FirstOrDefault();
        }

    }
}
