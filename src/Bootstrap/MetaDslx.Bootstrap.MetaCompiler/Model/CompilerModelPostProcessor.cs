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
        private Dictionary<string, TokenKind> _tokenKinds;
        private Dictionary<string, Token> _fixedTokens;
        private TokenKind _keywordKind;
        private GrammarRule _defaultReferenceRule;
        private CompilerModelFactory f;


        public CompilerModelPostProcessor(Language language)
        {
            _language = language;
            _grammar = _language?.Grammar;
            _model = _language.MModel;
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
            if (_grammar is null) return;
            f = new CompilerModelFactory(_model);
            _ruleNames = new HashSet<string>();
            _tokenKinds = new Dictionary<string, TokenKind>();
            _fixedTokens = new Dictionary<string, Token>();
            _keywordKind = AddTokenKind("Keyword", typeof(KeywordTokenKind).FullName!);
            AddTokens();
            SetDefaults();
            AddRules();
            MergeSeparatedLists();
            MergeSingleTokenAlts();
            MergeSingleAlts();
            AddCSharpNames();
            AddAntlrNames();
            ComputeContainsBinders();
        }

        private void AddTokens()
        {
            var allTokens = _grammar.GetAllContainedObjects<Token>();
            AddFixedTokens(allTokens);
            AddFixedTokensFromRules();
            AddNonFixedTokens(allTokens);
        }

        private void AddFixedTokens(ImmutableArray<Token> allTokens)
        {
            foreach (var fixedToken in allTokens.Where(t => t.IsFixed))
            {
                AddTokenKindFor(fixedToken);
                if (!fixedToken.ReturnType.IsNull)
                {
                    var valueBinder = f.Binder();
                    valueBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.ValueBinder).FullName!;
                    var valueType = f.BinderArgument();
                    valueType.Name = "type";
                    valueType.TypeName = typeof(Type).FullName!;
                    valueType.IsArray = false;
                    valueType.Values.Add(fixedToken.ReturnType.FullName);
                    valueBinder.Arguments.Add(valueType);
                    fixedToken.Binders.Add(valueBinder);
                }
                var fixedText = fixedToken.FixedText;
                if (!string.IsNullOrEmpty(fixedText))
                {
                    if (_fixedTokens.TryGetValue(fixedText, out var existingFixedToken))
                    {
                        _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, fixedToken.MLocation, $"There is already another token called '{existingFixedToken.Name}' with text '{fixedText}'."));
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
                    _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, fixedToken.MLocation, $"Token '{fixedToken.Name}' is empty."));
                }
            }
        }

        private void AddFixedTokensFromRules()
        {
            foreach (var fixedValue in _grammar.GetAllContainedObjects<Fixed>())
            {
                var elem = fixedValue.MParent as Element;
                if (elem is not null)
                {
                    if (!_fixedTokens.TryGetValue(fixedValue.Text, out var fixedToken))
                    {
                        fixedToken = f.Token();
                        fixedToken.CSharpName = MakeFixedTokenName(fixedValue.Text);
                        fixedToken.Name = fixedToken.CSharpName;
                        if (fixedValue.Text.IsIdentifier()) fixedToken.TokenKind = _keywordKind;
                        var ftAlt = f.LAlternative();
                        fixedToken.Alternatives.Add(ftAlt);
                        var ftElem = f.LElement();
                        ftAlt.Elements.Add(ftElem);
                        var ftFixed = f.LFixed();
                        ftElem.Value = ftFixed;
                        ftFixed.Text = fixedValue.Text;
                        _fixedTokens.Add(fixedValue.Text, fixedToken);
                        _grammar.Tokens.Add(fixedToken);
                    }
                    var tokenRef = f.RuleRef();
                    tokenRef.GrammarRule = fixedToken;
                    elem.Value = tokenRef;
                    tokenRef.MSourceLocation = fixedValue.MSourceLocation;
                    _model.DeleteObject(fixedValue, _cancellationToken);
                }
            }
        }

        private void AddNonFixedTokens(ImmutableArray<Token> allTokens)
        {
            foreach (var token in allTokens.Where(t => !t.IsFixed))
            {
                AddTokenKindFor(token);
                if (!token.ReturnType.IsNull)
                {
                    var valueBinder = f.Binder();
                    valueBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.ValueBinder).FullName!;
                    var valueType = f.BinderArgument();
                    valueType.Name = "type";
                    valueType.TypeName = typeof(Type).FullName!;
                    valueType.IsArray = false;
                    valueType.Values.Add(token.ReturnType.FullName);
                    valueBinder.Arguments.Add(valueType);
                    token.Binders.Add(valueBinder);
                }
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
            var allRules = _grammar.GrammarRules.OfType<Rule>().ToList();
            foreach (var rule in allRules)
            {
                _grammar.Rules.Add(rule);
                AddBinders(rule.Binders, rule.Annotations);
                AddAlternatives(rule.Alternatives);
            }
            var unusedRules = true;
            var first = true;
            while (unusedRules)
            {
                unusedRules = false;
                for (int i = allRules.Count - 1; i >= 0; --i)
                {
                    var rule = allRules[i];
                    if (rule == _grammar.MainRule) continue;
                    var ruleRefCount = GetRuleRefs(rule).Length;
                    if (ruleRefCount == 0)
                    {
                        if (first)
                        {
                            _diagnostics.Add(Diagnostic.Create(ErrorCode.WRN_SyntaxWarning, rule.MLocation, $"Rule '{rule.Name}' is never used."));
                        }
                        _model.DeleteObject(rule);
                        allRules.RemoveAt(i);
                        unusedRules = true;
                    }
                }
                first = false;
            }
        }

        private void AddAlternatives(IList<Alternative> alternatives)
        {
            foreach (var alt in alternatives)
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
                        if (celem.Value.Multiplicity == Multiplicity.ExactlyOne && string.IsNullOrEmpty(celem.Name))
                        {
                            if (celem.Value is RuleRef rr && rr.Rule is not null) skipDefineBinder = true;
                        }
                    }
                    if (!skipDefineBinder)
                    {
                        var defBinder = f.Binder();
                        var isPrimitive = alt.ReturnType.MetaKeyword != null;
                        if (isPrimitive) defBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.ValueBinder).FullName!;
                        else defBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.DefineBinder).FullName!;
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
                var name = elem.Name;
                AddBinders(elem.Binders, elem.Annotations);
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
                    if (elem.Assignment == Assignment.QuestionAssign || elem.Assignment == Assignment.NegatedAssign)
                    {
                        var propValue = f.BinderArgument();
                        propValue.Name = "value";
                        propValue.TypeName = typeof(object).FullName!;
                        propValue.IsArray = false;
                        propValue.Values.Add("true");
                        propBinder.Arguments.Add(propValue);
                    }
                    elem.Binders.Add(propBinder);
                }
                var value = elem.Value;
                AddBinders(value.Binders, value.Annotations);
                if (value is RuleRef rr)
                {
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
                else if (value is Block blk)
                {
                    _grammar.Blocks.Add(blk);
                    AddAlternatives(blk.Alternatives);
                }
            }
        }

        private ImmutableArray<Element> GetRuleRefs(Rule rule)
        {
            var result = ArrayBuilder<Element>.GetInstance();
            foreach (var ruleRef in rule.MReferences)
            {
                if (ruleRef.Owner is RuleRef && ruleRef.Owner.MParent is Element elem)
                {
                    result.Add(elem);
                }
            }
            return result.ToImmutableAndFree();
        }

        private void MergeSeparatedLists()
        {
            foreach (var rule in _grammar.Rules)
            {
                foreach (var alt in rule.Alternatives)
                {
                    MergeSeparatedLists(alt);
                }
            }
            foreach (var block in _grammar.Blocks)
            {
                foreach (var alt in block.Alternatives)
                {
                    MergeSeparatedLists(alt);
                }
            }
        }

        private void MergeSeparatedLists(Alternative alt)
        {
            for (int k = 0; k < alt.Elements.Count; ++k)
            {
                var elem = alt.Elements[k];
                if (string.IsNullOrEmpty(elem.Name) && elem.Value.Multiplicity.IsList() && elem.Value is Block blk && blk.Alternatives.Count == 1)
                {
                    SeparatedList? list = null;
                    Rule? item = null;
                    Token? separator = null;
                    string? name = null;
                    var repeatedAlt = blk.Alternatives[0];
                    if (repeatedAlt.Elements.Count == 2)
                    {
                        var repeatedElem1 = repeatedAlt.Elements[0];
                        var repeatedElem2 = repeatedAlt.Elements[1];
                        if (repeatedElem1.Value.Multiplicity.IsSingle() && repeatedElem1.Value is RuleRef rr1 &&
                            repeatedElem2.Value.Multiplicity.IsSingle() && repeatedElem2.Value is RuleRef rr2)
                        {
                            if (rr1.Token is not null && rr2.Rule is not null)
                            {
                                list = f.SeparatedList();
                                list.RepeatedSeparatorFirst = true;
                                list.RepeatedSeparator = repeatedElem1;
                                list.RepeatedItem = repeatedElem2;
                                separator = rr1.Token;
                                item = rr2.Rule;
                                name = repeatedElem2.Name ?? rr2.Rule.Name;
                            }
                            else if (rr1.Rule is not null && rr2.Token is not null)
                            {
                                list = f.SeparatedList();
                                list.RepeatedSeparatorFirst = false;
                                list.RepeatedSeparator = repeatedElem2;
                                list.RepeatedItem = repeatedElem1;
                                separator = rr2.Token;
                                item = rr1.Rule;
                                name = repeatedElem1.Name ?? rr1.Rule.Name;
                            }
                        }
                    }
                    if (list is not null && item is not null)
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
                                var prevElemName = prevElem.Name ?? (prevElem.Value as RuleRef)?.Rule?.Name;
                                if (prevElemName == name && prevElem.Value.Multiplicity == Multiplicity.ExactlyOne && prevElem.Value is RuleRef prevRule && prevRule.Rule == item)
                                {
                                    prevElem.Name = prevElemName;
                                    firstItems.Add(prevElem);
                                    firstIndex = k - 1;
                                    list.SeparatorFirst = false;
                                    searchPrevElemens = true;
                                }
                            }
                            else
                            {
                                if (prevElem.Value.Multiplicity == Multiplicity.ExactlyOne && prevElem.Value is RuleRef prevToken && prevToken.Token == separator)
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
                                    var prevElem1Name = prevElem1.Name ?? (prevElem1.Value as RuleRef)?.Rule?.Name;
                                    if (prevElem1Name == name && prevElem1.Value.Multiplicity == Multiplicity.ExactlyOne && prevElem1.Value is RuleRef prevRule1 && prevRule1.Rule == item &&
                                        prevElem2.Value.Multiplicity == Multiplicity.ExactlyOne && prevElem2.Value is RuleRef prevToken2 && prevToken2.Token == separator)
                                    {
                                        prevElem1.Name = prevElem1Name;
                                        firstItems.Insert(0, prevElem1);
                                        firstSeparators.Insert(0, prevElem2);
                                        firstIndex = k - l * 2;
                                        list.SeparatorFirst = false;
                                        searchPrevElemens = true;
                                    }
                                }
                                else
                                {
                                    var prevElem2Name = prevElem2.Name ?? (prevElem2.Value as RuleRef)?.Rule?.Name;
                                    if (prevElem2Name == name && prevElem2.Value.Multiplicity == Multiplicity.ExactlyOne && prevElem2.Value is RuleRef prevRule2 && prevRule2.Rule == item &&
                                        prevElem1.Value.Multiplicity == Multiplicity.ExactlyOne && prevElem1.Value is RuleRef prevToken1 && prevToken1.Token == separator)
                                    {
                                        prevElem2.Name = prevElem2Name;
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
                                    if (nextElem.Value.Multiplicity.IsSingle() && nextElem.Value is RuleRef nextToken && nextToken.Token == separator)
                                    {
                                        lastSeparators.Add(nextElem);
                                        lastIndex = k + l;
                                        searchNextElemens = nextElem.Value.Multiplicity == Multiplicity.ExactlyOne;
                                    }
                                }
                                else
                                {
                                    var nextElemName = nextElem.Name ?? (nextElem.Value as RuleRef)?.Rule?.Name;
                                    if (nextElemName == name && nextElem.Value.Multiplicity.IsSingle() && nextElem.Value is RuleRef nextRule && nextRule.Rule == item)
                                    {
                                        nextElem.Name = nextElemName;
                                        lastItems.Add(nextElem);
                                        lastIndex = k + l;
                                        searchNextElemens = nextElem.Value.Multiplicity == Multiplicity.ExactlyOne;
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
                        var listElem = f.Element();
                        listElem.Name = name;
                        listElem.Value = list;
                        alt.Elements.Insert(firstIndex, listElem);
                    }
                }
            }
        }

        private void MergeSingleTokenAlts()
        {
            foreach (var rule in _grammar.Rules)
            {
                var tokenAlts = MergeSingleTokenAlts(rule.Alternatives);
                if (tokenAlts is not null)
                {
                    var tokenElem = f.Element();
                    tokenElem.Name = "Token";
                    tokenElem.Value = tokenAlts;
                    var tokenAlt = f.Alternative();
                    tokenAlt.Elements.Add(tokenElem);
                    rule.Alternatives.Clear();
                    rule.Alternatives.Add(tokenAlt);
                }
            }
            foreach (var block in _grammar.Blocks)
            {
                var elem = block.MParent as Element;
                if (elem is not null)
                {
                    var tokenAlts = MergeSingleTokenAlts(block.Alternatives);
                    if (tokenAlts is not null)
                    {
                        InsertBinders(tokenAlts.Binders, block.Binders);
                        elem.Value = tokenAlts;
                        _model.DeleteObject(block);
                    }
                }
            }
        }

        private TokenAlts? MergeSingleTokenAlts(IList<Alternative> alternatives)
        {
            if (alternatives.Count < 2) return null;
            var singleTokenAlts = alternatives.Where(IsSingleTokenAlt).ToImmutableArray();
            if (singleTokenAlts.Length != alternatives.Count) return null;
            var tokenAlts = f.TokenAlts();
            foreach (var singleTokenAlt in singleTokenAlts)
            {
                var singleElem = singleTokenAlt.Elements[0];
                var singleToken = (RuleRef)singleElem.Value;
                singleToken.MParent = null;
                tokenAlts.Tokens.Add(singleToken);
                InsertBinders(singleToken.Binders, singleElem.Binders);
                InsertBinders(singleToken.Binders, singleTokenAlt.Binders);
                _model.DeleteObject(singleTokenAlt);
            }
            return tokenAlts;
        }

        private static bool IsSingleTokenAlt(Alternative alt)
        {
            if (alt.Elements.Count != 1) return false;
            var elem = alt.Elements[0];
            if (elem.Value.Multiplicity.IsSingle() && string.IsNullOrEmpty(elem.Name) && elem.Value is RuleRef rr && rr.Token is not null)
            {
                return true;
            }
            return false;
        }

        private void MergeSingleAlts()
        {
            foreach (var rule in _grammar.Rules)
            {
                var ruleRefs = GetRuleRefs(rule);
                if (ruleRefs.Length == 1)
                {
                    var refElem = ruleRefs[0];
                    if (refElem is null || !string.IsNullOrEmpty(refElem.Name) || refElem.Value.Multiplicity != Multiplicity.ExactlyOne) continue;
                    var refAlt = refElem.MParent as Alternative;
                    if (refAlt is null || !string.IsNullOrEmpty(refAlt.Name) || refAlt.Elements.Count != 1) continue;
                    rule.BaseRule = refAlt;
                }
            }
            foreach (var block in _grammar.Blocks)
            {
                var ruleRefs = GetRuleRefs(block);
                if (ruleRefs.Length == 1)
                {
                    var refElem = ruleRefs[0];
                    if (refElem is null || !string.IsNullOrEmpty(refElem.Name) || refElem.Value.Multiplicity != Multiplicity.ExactlyOne) continue;
                    var refAlt = refElem.MParent as Alternative;
                    if (refAlt is null || !string.IsNullOrEmpty(refAlt.Name) || refAlt.Elements.Count != 1) continue;
                    block.BaseRule = refAlt;
                }
            }
        }

        private void InsertBinders(ICollectionSlot<Binder> target, ICollectionSlot<Binder> source)
        {
            var binders = source.ToArray();
            foreach (var binder in binders)
            {
                binder.MParent = null;
            }
            target.InsertRange(0, binders);
        }

        private void InsertAlternativesAt(ICollectionSlot<Alternative> target, int index, ICollectionSlot<Alternative> source)
        {
            var alts = source.ToArray();
            foreach (var alt in alts)
            {
                alt.MParent = null;
            }
            target.InsertRange(index, alts);
        }


        private void AddCSharpNames()
        {
            foreach (var rule in _grammar.Rules)
            {
                if (rule.CSharpName is null) rule.CSharpName = AddRuleName(rule.Name, tryWithoutIndex: true);
                AddCSharpNames(rule.CSharpName, rule.Alternatives, clearUsedElementNames: true);
            }
        }

        private void AddCSharpNames(string contextName, IList<Alternative> alternatives, bool clearUsedElementNames)
        {
            var altIndex = 0;
            foreach (var alt in alternatives)
            {
                ++altIndex;
                if (alt.CSharpName is null)
                {
                    if (string.IsNullOrEmpty(alt.Name))
                    {
                        if (alternatives.Count == 1) alt.CSharpName = contextName;
                        else alt.CSharpName = AddRuleName(contextName + "Alt", tryWithoutIndex: false, indexHint: altIndex);
                    }
                    else
                    {
                        alt.CSharpName = AddRuleName(alt.Name, tryWithoutIndex: true);
                    }
                }
                var usedElementNames = PooledHashSet<string>.GetInstance();
                usedElementNames.Add("kind");
                usedElementNames.Add("annotations");
                usedElementNames.Add("diagnostics");
                AddCSharpNames(alt.CSharpName, alt, usedElementNames);
                usedElementNames.Free();
            }
        }

        private void AddCSharpNames(string? contextName, Alternative alt, HashSet<string> usedElementNames)
        {
            var altElementNames = PooledHashSet<string>.GetInstance();
            var multiElementNames = PooledHashSet<string>.GetInstance();
            foreach (var elem in alt.Elements)
            {
                AddCSharpNames(contextName, elem);
                if (!string.IsNullOrEmpty(elem.Name))
                {
                    if (altElementNames.Contains(elem.Name)) multiElementNames.Add(elem.Name);
                    altElementNames.Add(elem.Name);
                }
            }
            altElementNames.Free();
            foreach (var elem in alt.Elements)
            {
                AddCSharpNames(elem, usedElementNames, multiElementNames);
            }
            multiElementNames.Free();
        }

        private void AddCSharpNames(string? contextName, Element elem)
        {
            if (elem.Value is Block blk)
            {
                if (elem.Name is null) elem.Name = "Block";
                blk.CSharpName = AddRuleName(contextName + "Block", tryWithoutIndex: false);
                AddCSharpNames(blk.CSharpName, blk.Alternatives, clearUsedElementNames: false);
            }
            if (elem.Value is SeparatedList sl)
            {
                if (elem.Name is null) elem.Name = "List";
                var repeatedBlock = (Block)sl.RepeatedBlock.Value;
                var repeatedBlockName = contextName + elem.Name + "Block";
                repeatedBlock.CSharpName = AddRuleName(repeatedBlockName, tryWithoutIndex: true);
                AddCSharpNames(repeatedBlock.CSharpName, repeatedBlock.Alternatives, clearUsedElementNames: false);
            }
            if (elem.Value is Eof)
            {
                elem.Name = "EndOfFileToken";
            }
            if (elem.Name is null)
            {
                if (elem.Value is RuleRef rr)
                {
                    if (elem.Value.Multiplicity.IsList()) elem.Name = rr.GrammarRule?.Name + "List";
                    else elem.Name = rr.GrammarRule?.Name;
                }
                else if (elem.Value is TokenAlts)
                {
                    elem.Name = "Tokens";
                }
            }
        }

        private void AddCSharpNames(Element elem, HashSet<string> usedElementNames, HashSet<string> multiElementNames)
        {
            elem.CSharpName = AddElementName(elem.Name, elem.Name is not null && !multiElementNames.Contains(elem.Name), usedElementNames);
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

        private string AddElementName(string? defaultName, bool tryWithoutIndex, HashSet<string> usedElementNames)
        {
            if (string.IsNullOrEmpty(defaultName))
            {
                defaultName = "Element";
                tryWithoutIndex = false;
            }
            if (tryWithoutIndex && !usedElementNames.Contains(defaultName, StringComparer.InvariantCultureIgnoreCase))
            {
                usedElementNames.Add(defaultName);
                return defaultName;
            }
            var index = 0;
            while (true)
            {
                ++index;
                var name = $"{defaultName}{index}";
                if (!usedElementNames.Contains(name, StringComparer.OrdinalIgnoreCase))
                {
                    usedElementNames.Add(name);
                    return name;
                }
            }
        }

        private void AddAntlrNames()
        {
            var usedElementNames = PooledHashSet<string>.GetInstance();
            foreach (var token in _grammar.Tokens)
            {
                token.AntlrName = $"LR_{token.CSharpName}";
            }
            foreach (var fragment in _grammar.GrammarRules.OfType<Fragment>())
            {
                fragment.AntlrName = $"FR_{fragment.Name}";
            }
            foreach (var rule in _grammar.Rules)
            {
                if (rule.AntlrName is null) rule.AntlrName = $"pr_{rule.CSharpName}";
                usedElementNames.Clear();
                AddAntlrNames(rule, usedElementNames);
            }
            foreach (var block in _grammar.Blocks)
            {
                if (block.AntlrName is null) block.AntlrName = $"pr_{block.CSharpName}";
                usedElementNames.Clear();
                AddAntlrNames(block, usedElementNames);
            }
            usedElementNames.Free();
        }

        private void AddAntlrNames(Rule rule, HashSet<string> usedElementNames)
        {
            foreach (var alt in rule.Alternatives)
            {
                if (alt.AntlrName is null) alt.AntlrName = rule.Alternatives.Count == 1 ? rule.AntlrName : $"pr_{alt.CSharpName}";
                AddAntlrNames(alt, usedElementNames);
            }
        }

        private void AddAntlrNames(Block block, HashSet<string> usedElementNames)
        {
            foreach (var alt in block.Alternatives)
            {
                if (alt.AntlrName is null) alt.AntlrName = block.Alternatives.Count == 1 ? block.AntlrName : $"pr_{alt.CSharpName}";
                AddAntlrNames(alt, usedElementNames);
            }
        }

        private void AddAntlrNames(Alternative alt, HashSet<string> usedElementNames)
        {
            foreach (var elem in alt.Elements)
            {
                if (elem.AntlrName is null)
                {
                    if (elem.Value is SeparatedList sl)
                    {
                        elem.AntlrName = AddElementName($"e_sl_{elem.Name}", true, usedElementNames);
                        foreach (var item in sl.FirstItems) item.AntlrName = AddElementName($"e_{item.Name}", false, usedElementNames);
                        foreach (var item in sl.FirstSeparators) item.AntlrName = AddElementName($"e_{item.Name}", false, usedElementNames);
                        sl.RepeatedItem.AntlrName = AddElementName($"e_{sl.RepeatedItem.Name}", false, usedElementNames);
                        sl.RepeatedSeparator.AntlrName = AddElementName($"e_{sl.RepeatedSeparator.Name}", false, usedElementNames);
                        foreach (var item in sl.LastItems) item.AntlrName = AddElementName($"e_{item.Name}", false, usedElementNames);
                        foreach (var item in sl.LastSeparators) item.AntlrName = AddElementName($"e_{item.Name}", false, usedElementNames);
                    }
                    else
                    {
                        elem.AntlrName = AddElementName($"e_{elem.Name}", true, usedElementNames);
                    }
                }
            }
        }

        private void ComputeContainsBinders()
        {
            var rules = new List<Rule>();
            rules.AddRange(_grammar.Rules);
            rules.AddRange(_grammar.Blocks);
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
                rr.ContainsBinders = rr.GrammarRule?.ContainsBinders ?? false;
                elem.ContainsBinders |= rr.ContainsBinders;
            }
            if (elem.Value is Block blk)
            {
                elem.ContainsBinders |= blk.ContainsBinders;
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
            var mainRule = true;
            foreach (var grammarRule in _grammar.GrammarRules)
            {
                var isDefaultRef = grammarRule.Annotations.Any(a => a.AttributeClass.Name == nameof(DefaultReferenceAnnotation) && a.AttributeClass.FullName == DefaultReferenceFullName);
                if (isDefaultRef)
                {
                    if (_defaultReferenceRule is null)
                    {
                        _defaultReferenceRule = grammarRule;
                    }
                    else
                    {
                        _diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_AmbiguousDefaultReference, SourceLocation.None, _defaultReferenceRule.Name, grammarRule.Name));
                    }
                }
                if (grammarRule is Token token)
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
                else if (mainRule && grammarRule is Rule rule)
                {
                    mainRule = false;
                    _grammar.MainRule = rule;
                }
            }
            if (_defaultReferenceRule is null)
            {
                _diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_MissingDefaultReference, SourceLocation.None));
            }
        }

    }
}
