using Antlr4.Runtime;
using MetaDslx.Bootstrap.MetaCompiler.Roslyn;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaCompiler.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Roslyn.Utilities;
using System.Data;
using System.Diagnostics;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using MetaDslx.CodeAnalysis.Syntax;
using MetaDslx.CodeAnalysis;
using System.Collections.Immutable;
using MetaDslx.Modeling;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    using Model = MetaDslx.Modeling.Model;

    public class CompilerToRoslyn
    {
        private static readonly string DefaultReferenceFullName = typeof(DefaultReferenceAnnotation).FullName!;

        private readonly Model _cmodel;
        private readonly Model _rmodel;
        private readonly RoslynModelFactory f;
        private readonly Language? _clang;
        private Roslyn.Language _rlang;
        private object? _defaultReferenceRule;
        private HashSet<string> _ruleNames;
        private Dictionary<string, Roslyn.Token> _fixedTokens;
        private Dictionary<object, Roslyn.Token> _tokenMap;
        private Dictionary<object, Roslyn.Rule> _ruleMap;
        private Dictionary<Roslyn.Rule, List<Element>> _ruleRefs;
        private DiagnosticBag _diagnostics;
        
        public CompilerToRoslyn(Model compilerModel)
        {
            _cmodel = compilerModel;
            _rmodel = new Model();
            f = new RoslynModelFactory(_rmodel);
            _clang = _cmodel.Objects.OfType<Language>().FirstOrDefault();
        }

        public Model Convert()
        {
            if (_clang is null) return _rmodel;
            if (_rlang is not null) return _rmodel;
            _ruleNames = new HashSet<string>();
            _fixedTokens = new Dictionary<string, Roslyn.Token>();
            _tokenMap = new Dictionary<object, Roslyn.Token>();
            _ruleMap = new Dictionary<object, Roslyn.Rule>();
            _ruleRefs = new Dictionary<Roslyn.Rule, List<Element>>();
            _diagnostics = new DiagnosticBag();

            var cfixedTokens = _cmodel.Objects.OfType<LexerRule>().Where(lr => !lr.IsFragment && lr.IsFixed);
            var cnonFixedTokens = _cmodel.Objects.OfType<LexerRule>().Where(lr => !lr.IsFragment && !lr.IsFixed);
            var crules = _cmodel.Objects.OfType<ParserRule>();
            var cblocks = _cmodel.Objects.OfType<PBlock>();
            var cnamedBlocks = _cmodel.Objects.OfType<PBlock>().Where(blk => !string.IsNullOrEmpty(blk.Name));

            _rlang = f.Language();
            _rlang.Name = _clang.Name;
            _ruleNames = new HashSet<string>();
            _ruleNames.UnionWith(_cmodel.Objects.OfType<LexerRule>().Where(lr => !string.IsNullOrEmpty(lr.Name)).Select(lr => lr.Name!));
            AddTokens(cfixedTokens, false);
            AddTokensFromRules(crules);
            AddTokensFromRules(cblocks);
            AddTokens(cnonFixedTokens, false);

            AddRules(crules);
            AddBlocks(cblocks);
            AddAlts(crules);
            AddAlts(cblocks);

            MergeSingleTokenAlts();
            MergeSeparatedLists();
            //MergeSingleAlts();

            MakeBlockNames();
            return _rmodel;
        }

        public ImmutableArray<Diagnostic> GetDiagnostics()
        {
            return _diagnostics.ToReadOnly();
        }

        private void AddTokens(IEnumerable<LexerRule> ctokens, bool checkNames)
        {
            foreach (var ctoken in ctokens)
            {
                var rtoken = AddToken(ctoken, checkNames);
                _tokenMap.Add(ctoken, rtoken);
            }
        }

        private Token AddToken(string fixedText)
        {
            if (_fixedTokens.TryGetValue(fixedText, out var ftoken)) return ftoken;
            var rtoken = f.Token();
            _rlang.Tokens.Add(rtoken);
            rtoken.Name = MakeFixedTokenName(fixedText);
            rtoken.IsTrivia = false;
            rtoken.IsFixed = true;
            rtoken.FixedText = fixedText;
            _fixedTokens.Add(fixedText, rtoken);
            return rtoken;
        }

        private Token AddToken(LexerRule ctoken, bool checkNames)
        {
            if (ctoken.IsFixed && _fixedTokens.TryGetValue(ctoken.FixedText, out var ftoken)) return ftoken;
            var rtoken = f.Token();
            _rlang.Tokens.Add(rtoken);
            var name = ctoken.Name;
            if (string.IsNullOrEmpty(name) || checkNames && _ruleNames.Contains(name))
            {
                if (ctoken.IsFixed) name = MakeFixedTokenName(ctoken.FixedText);
                else name = MakeTokenName();
            }
            rtoken.Name = name;
            if (rtoken.IsFixed) _fixedTokens.Add(rtoken.FixedText, rtoken);
            rtoken.IsTrivia = ctoken.IsHidden;
            rtoken.IsFixed = ctoken.IsFixed;
            rtoken.FixedText = ctoken.FixedText;
            var rtokenKindSymbol = ctoken.Annotations.Where(a => a.AttributeClass?.Name?.EndsWith("TokenKind") ?? false).FirstOrDefault()?.AttributeClass;
            if (rtokenKindSymbol is not null)
            {
                var kind = _rlang.TokenKinds.FirstOrDefault(tk => tk.Name == rtokenKindSymbol.Name);
                if (kind is null)
                {
                    kind = f.TokenKind();
                    kind.Name = rtokenKindSymbol.Name;
                    kind.TypeName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(rtokenKindSymbol);
                    _rlang.TokenKinds.Add(kind);
                }
                rtoken.TokenKind = kind;
            }
            CheckDefaultReference(rtoken, ctoken.Annotations);
            return rtoken;
        }

        private void CheckDefaultReference(object? cobj, IList<Annotation> annotations)
        {
            var isDefaultRef = annotations.Any(a => a.AttributeClass?.Name == nameof(DefaultReferenceAnnotation) && SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(a.AttributeClass) == DefaultReferenceFullName);
            if (isDefaultRef)
            {
                if (_defaultReferenceRule is null)
                {
                    _defaultReferenceRule = cobj;
                }
                else
                {
                    _diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_AmbiguousDefaultReference, SourceLocation.None, ((IModelObject)_defaultReferenceRule).Name, ((IModelObject)cobj).Name));
                }
            }
        }

        private void AddBinders(IList<Binder> rbinders, IList<Annotation> cannotations)
        {
            foreach (var cbinder in cannotations.Where(a => a.AttributeClass?.Name?.EndsWith("Binder") ?? false))
            {
                var rbinder = f.Binder();
                rbinders.Add(rbinder);
                rbinder.TypeName = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(cbinder.AttributeClass);
                foreach (var carg in cbinder.Arguments)
                {
                    var name = carg.Parameter?.Name;
                    if (name is not null)
                    {
                        var rarg = f.BinderArgument();
                        rarg.Name = name;
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
                        rbinder.Arguments.Add(rarg);
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

        private string MakeTokenName()
        {
            var result = "TToken";
            var index = 0;
            while (true)
            {
                ++index;
                var name = $"{result}{index}";
                if (!_ruleNames.Contains(name))
                {
                    _ruleNames.Add(name);
                    return name;
                }
            }
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

        private void AddRules(IEnumerable<ParserRule> crules)
        {
            foreach (var crule in crules)
            {
                var rrule = f.Rule();
                _rlang.Rules.Add(rrule);
                rrule.Name = crule.Name;
                _ruleMap.Add(crule, rrule);
                AddBinders(rrule.Binders, crule.Annotations);
                CheckDefaultReference(rrule, crule.Annotations);
            }
        }

        private void AddBlocks(IEnumerable<PBlock> cblocks)
        {
            foreach (var cblock in cblocks)
            {
                var rrule = f.Rule();
                _rlang.Rules.Add(rrule);
                rrule.Name = cblock.Name ?? string.Empty;
                _ruleMap.Add(cblock, rrule);
                AddBinders(rrule.Binders, cblock.Annotations);
                CheckDefaultReference(rrule, cblock.Annotations);
            }
        }

        private void AddTokensFromRules(IEnumerable<ParserRule> crules)
        {
            foreach (var crule in crules)
            {
                foreach (var alt in crule.Alternatives)
                {
                    foreach (var elem in alt.Elements)
                    {
                        if (elem.Value is PKeyword ckeyword)
                        {
                            var rtoken = AddToken(ckeyword.Text);
                            _tokenMap.Add(ckeyword, rtoken);
                        }
                    }
                }
            }
        }

        private void AddTokensFromRules(IEnumerable<PBlock> cblocks)
        {
            foreach (var cblock in cblocks)
            {
                foreach (var alt in cblock.Alternatives)
                {
                    foreach (var elem in alt.Elements)
                    {
                        if (elem.Value is PKeyword ckeyword)
                        {
                            var rtoken = AddToken(ckeyword.Text);
                            _tokenMap.Add(ckeyword, rtoken);
                        }
                    }
                }
            }
        }

        private void MakeBlockNames()
        {
            foreach (var rule in _rmodel.Objects.OfType<Roslyn.Rule>())
            {
                MakeBlockNames(rule.Name, rule.Alternatives);
            }
        }

        private void MakeBlockNames(string? parentName, IEnumerable<Alternative> alts)
        {
            foreach (var alt in alts)
            {
                foreach (var elem in alt.Elements)
                {
                    if (elem.Value is RuleRef ruleRef)
                    {
                        var rule = ruleRef.Rule;
                        if (string.IsNullOrEmpty(ruleRef.Rule.Name))
                        {
                            rule.Name = MakeBlockName(parentName, elem.Name);
                            MakeBlockNames(rule.Name, rule.Alternatives);
                        }
                    }
                }
            }
        }

        private string MakeBlockName(string? parentName, string? elementName)
        {
            var result = (parentName.ToPascalCase() ?? string.Empty) + (elementName.ToPascalCase() ?? "Block");
            if (string.IsNullOrEmpty(result)) result = "Block";
            return AddRuleName(result, tryWithoutIndex: false);
        }

        private void AddAlts(IEnumerable<ParserRule> crules)
        {
            foreach (var crule in crules)
            {
                var rrule = _ruleMap[crule];
                AddAlts(rrule, crule.Alternatives);
            }
        }

        private void AddAlts(IEnumerable<PBlock> cblocks)
        {
            foreach (var cblock in cblocks)
            {
                var rrule = _ruleMap[cblock];
                AddAlts(rrule, cblock.Alternatives);
            }
        }

        private void AddAlts(Roslyn.Rule rrule, IList<PAlternative> calts)
        {
            foreach (var calt in calts)
            {
                var ralt = f.Alternative();
                rrule.Alternatives.Add(ralt);
                ralt.Name = MakeAltName(rrule.Name, calt.Name, calts.Count == 1);
                AddBinders(ralt.Binders, calt.Annotations);
                if (calt.ReturnValue is not null)
                {
                    var constBinder = f.Binder();
                    constBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.ConstantBinder).FullName!;
                    var constValue = f.BinderArgument();
                    constValue.Name = "value";
                    var value = calt.ReturnValue.Value;
                    if (value.IsModelObject || value.IsSymbol) constValue.Values.Add(value.FullName);
                    else constValue.Values.Add(value.OriginalValue?.ToString());
                    constBinder.Arguments.Add(constValue);
                    ralt.Binders.Add(constBinder);
                }
                else if (!calt.ReturnType.IsNull)
                {
                    var skipDefineBinder = false;
                    if (calt.Elements.Count == 1)
                    {
                        var celem = calt.Elements[0];
                        if (celem.Multiplicity == Multiplicity.ExactlyOne && string.IsNullOrEmpty(celem.SymbolProperty.FirstOrDefault().Name))
                        {
                            if (celem.Value is PReference) skipDefineBinder = true;
                            if (celem.Value is PBlock pb && !pb.ReturnType.IsNull) skipDefineBinder = true;
                        }
                    }
                    if (!skipDefineBinder)
                    {
                        var defBinder = f.Binder();
                        defBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.DefineBinder).FullName!;
                        var defType = f.BinderArgument();
                        defType.Name = "type";
                        defType.Values.Add(calt.ReturnType.FullName);
                        defBinder.Arguments.Add(defType);
                        ralt.Binders.Add(defBinder);
                    }
                }
                AddElements(ralt, calt.Elements);
            }
        }

        private void AddElements(Alternative ralt, IList<PElement> celements)
        {
            foreach (var celem in celements)
            {
                var relem = f.Element();
                ralt.Elements.Add(relem);
                var name = celem.SymbolProperty.FirstOrDefault().Name;
                AddBinders(relem.Binders, celem.NameAnnotations);
                if (name is not null)
                {
                    relem.Name = name;
                    var propBinder = f.Binder();
                    propBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.PropertyBinder).FullName!;
                    var propName = f.BinderArgument();
                    propName.Name = "name";
                    propName.Values.Add(name);
                    propBinder.Arguments.Add(propName);
                    relem.Binders.Add(propBinder);
                }
                relem.Assignment = celem.Assignment;
                relem.Multiplicity = celem.Multiplicity;
                var cvalue = celem.Value;
                ElementValue? rvalue = null;
                if (cvalue is PReference cpref)
                {
                    if (cpref.Rule is LexerRule clr)
                    {
                        var v = f.TokenRef();
                        v.Token = _tokenMap[clr];
                        rvalue = v;
                    }
                    else if (cpref.Rule is ParserRule cpr)
                    {
                        var v = f.RuleRef();
                        v.Rule = _ruleMap[cpr];
                        rvalue = v;
                    }
                    else if (cpref.Rule is PBlock cpb)
                    {
                        var v = f.RuleRef();
                        v.Rule = _ruleMap[cpb];
                        rvalue = v;
                    }
                    else if (cpref.ReferencedTypes.Count > 0)
                    {
                        if (_defaultReferenceRule is Token drt)
                        {
                            var v = f.TokenRef();
                            v.Token = drt;
                            rvalue = v;
                        }
                        else if (_defaultReferenceRule is Roslyn.Rule drr)
                        {
                            var v = f.RuleRef();
                            v.Rule = drr;
                            rvalue = v;
                        }
                    }
                    if (rvalue is null)
                    {
                        _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, SourceLocation.None, "Invalid PReference rule."));
                    }
                    else
                    {
                        relem.Value = rvalue;
                        AddBinders(rvalue.Binders, celem.ValueAnnotations);
                        if (cpref.ReferencedTypes.Count > 0)
                        {
                            var useBinder = f.Binder();
                            useBinder.TypeName = typeof(MetaDslx.CodeAnalysis.Binding.UseBinder).FullName!;
                            var useTypes = f.BinderArgument();
                            useTypes.Name = "types";
                            foreach (var type in cpref.ReferencedTypes)
                            {
                                useTypes.Values.Add(type.FullName);
                            }
                            useBinder.Arguments.Add(useTypes);
                            rvalue.Binders.Add(useBinder);
                        }
                    }
                }
                else
                {
                    if (cvalue is PEof)
                    {
                        var v = f.Eof();
                        rvalue = v;
                    }
                    else if (cvalue is PKeyword pk)
                    {
                        var v = f.TokenRef();
                        v.Token = _tokenMap[pk];
                        rvalue = v;
                    }
                    else if (cvalue is PBlock cpb)
                    {
                        var v = f.RuleRef();
                        v.Rule = _ruleMap[cpb];
                        rvalue = v;
                    }
                    else
                    {
                        _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, SourceLocation.None, "Invalid PElementValue."));
                    }
                    if (rvalue is not null)
                    {
                        relem.Value = rvalue;
                        AddBinders(rvalue.Binders, celem.ValueAnnotations);
                    }
                }
                if (rvalue is RuleRef rr)
                {
                    if (!_ruleRefs.TryGetValue(rr.Rule, out var ruleRefs))
                    {
                        ruleRefs = new List<Element>();
                        _ruleRefs.Add(rr.Rule, ruleRefs);
                    }
                    ruleRefs.Add(relem);
                }
            }
        }

        private string MakeAltName(string parentName, string? altName, bool singleAlt)
        {
            if (singleAlt) return altName.ToPascalCase() ?? parentName.ToPascalCase();
            if (!string.IsNullOrEmpty(altName)) return AddRuleName(altName, tryWithoutIndex: true);
            else return AddRuleName(parentName + "Alt", tryWithoutIndex: false);
        }

        private string AddRuleName(string ruleName, bool tryWithoutIndex)
        {
            if (tryWithoutIndex && !_ruleNames.Contains(ruleName))
            {
                _ruleNames.Add(ruleName);
                return ruleName;
            }
            var index = 0;
            while (true)
            {
                ++index;
                var name = $"{ruleName}{index}";
                if (!_ruleNames.Contains(name))
                {
                    _ruleNames.Add(name);
                    return name;
                }
            }
        }

        private void MergeSingleTokenAlts()
        {
            var rules = _rmodel.Objects.OfType<Roslyn.Rule>().ToList();
            for (int i = 0; i < rules.Count; ++i)
            {
                var rule = rules[i];
                var singleTokenAlts = rule.Alternatives.Where(IsSingleTokenAlt).ToImmutableArray();
                if (singleTokenAlts.Length == 0) continue;
                var tokens = ArrayBuilder<TokenRef>.GetInstance();
                var tokenAlts = f.TokenAlts();
                foreach (var singleTokenAlt in singleTokenAlts)
                {
                    var singleElem = singleTokenAlt.Elements[0];
                    var singleToken = (TokenRef)singleElem.Value;
                    ((IModelObject)singleToken).Parent = null;
                    tokens.Add(singleToken);
                    InsertBinders(singleToken.Binders, singleTokenAlt.Binders);
                    rule.Alternatives.Remove(singleTokenAlt);
                    _rmodel.RemoveObject((IModelObject)singleTokenAlt);
                    _rmodel.RemoveObject((IModelObject)singleElem);
                }
                tokenAlts.Tokens.AddRange(tokens);
                tokens.Free();
                var tokensElem = f.Element();
                tokensElem.Value = tokenAlts;
                var tokensAlt = f.Alternative();
                tokensAlt.Elements.Add(tokensElem);
                rule.Alternatives.Insert(0, tokensAlt);
            }
        }

        private static bool IsSingleTokenAlt(Alternative alt)
        {
            if (alt.Elements.Count != 1) return false;
            var elem = alt.Elements[0];
            if (elem.Multiplicity.IsSingle() && elem.Value is TokenRef)
            {
                return true;
            }
            return false;
        }

        private void MergeSeparatedLists()
        {
            var rules = _rmodel.Objects.OfType<Roslyn.Rule>().ToList();
            for (int i = 0; i < rules.Count; ++i)
            {
                var rule = rules[i];
                for (int j = 0; j < rule.Alternatives.Count; ++j)
                {
                    var alt = rule.Alternatives[j];
                    for (int k = 0; k < alt.Elements.Count; ++k)
                    {
                        var elem = alt.Elements[k];
                        if (elem.Multiplicity.IsList() && elem.Value is RuleRef ruleRef && ruleRef.Rule.Alternatives.Count == 1)
                        {
                            SeparatedList? list = null;
                            Roslyn.Rule? item = null;
                            Token? separator = null;
                            string? name = null;
                            var repeatedAlt = ruleRef.Rule.Alternatives[0];
                            if (repeatedAlt.Elements.Count == 2)
                            {
                                var repeatedElem1 = repeatedAlt.Elements[0];
                                var repeatedElem2 = repeatedAlt.Elements[1];
                                if (repeatedElem1.Multiplicity.IsSingle() && repeatedElem2.Multiplicity.IsSingle())
                                {
                                    if (repeatedElem1.Value is TokenRef repeatedToken1 && repeatedElem2.Value is RuleRef repeatedRule1)
                                    {
                                        list = f.SeparatedList();
                                        list.SeparatorFirst = true;
                                        list.RepeatedSeparator = repeatedElem1;
                                        list.RepeatedItem = repeatedElem2;
                                        separator = repeatedToken1.Token;
                                        item = repeatedRule1.Rule;
                                        name = repeatedElem2.Name;
                                    }
                                    else if (repeatedElem1.Value is RuleRef repeatedRule2 && repeatedElem2.Value is TokenRef repeatedToken2)
                                    {
                                        list = f.SeparatedList();
                                        list.SeparatorFirst = false;
                                        list.RepeatedSeparator = repeatedElem2;
                                        list.RepeatedItem = repeatedElem1;
                                        separator = repeatedToken2.Token;
                                        item = repeatedRule2.Rule;
                                        name = repeatedElem1.Name;
                                    }
                                }
                            }
                            if (list is not null)
                            {
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
                                    if (list.SeparatorFirst)
                                    {
                                        if (prevElem.Name == name && prevElem.Multiplicity == Multiplicity.ExactlyOne && prevElem.Value is RuleRef prevRule && prevRule.Rule == item)
                                        {
                                            firstItems.Add(prevElem);
                                            firstIndex = k - 1;
                                            searchPrevElemens = true;
                                        }
                                    }
                                    else
                                    {
                                        if (prevElem.Multiplicity == Multiplicity.ExactlyOne && prevElem.Value is TokenRef prevToken && prevToken.Token == separator)
                                        {
                                            firstSeparators.Add(prevElem);
                                            firstIndex = k - 1;
                                            searchPrevElemens = true;
                                        }
                                    }
                                    var l = 1;
                                    while (searchPrevElemens && k - l * 2 >= 0)
                                    {
                                        searchPrevElemens = false;
                                        var prevElem1 = alt.Elements[k - l * 2];
                                        var prevElem2 = alt.Elements[k - l * 2 + 1];
                                        if (list.SeparatorFirst)
                                        {
                                            if (prevElem1.Name == name && prevElem1.Multiplicity == Multiplicity.ExactlyOne && prevElem1.Value is RuleRef prevRule1 && prevRule1.Rule == item &&
                                                prevElem2.Multiplicity == Multiplicity.ExactlyOne && prevElem2.Value is TokenRef prevToken2 && prevToken2.Token == separator)
                                            {
                                                firstItems.Insert(0, prevElem1);
                                                firstSeparators.Insert(0, prevElem2);
                                                firstIndex = k - l * 2;
                                                searchPrevElemens = true;
                                            }
                                        }
                                        else
                                        {
                                            if (prevElem2.Name == name && prevElem2.Multiplicity == Multiplicity.ExactlyOne && prevElem2.Value is RuleRef prevRule2 && prevRule2.Rule == item &&
                                                prevElem1.Multiplicity == Multiplicity.ExactlyOne && prevElem1.Value is TokenRef prevToken1 && prevToken1.Token == separator)
                                            {
                                                firstItems.Insert(0, prevElem2);
                                                firstSeparators.Insert(0, prevElem1);
                                                firstIndex = k - l * 2;
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
                                        var mustBeSeparator = list.SeparatorFirst ? l % 2 == 1 : l % 2 == 0;
                                        if (mustBeSeparator)
                                        {
                                            if (nextElem.Multiplicity.IsSingle() && nextElem.Value is TokenRef nextToken && nextToken.Token == separator)
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
                                for (var m = firstIndex; m <= lastIndex; ++m)
                                {
                                    alt.Elements.RemoveAt(firstIndex);
                                }
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
            }
        }

        // TODO: optional
        private void MergeSingleAlts()
        {
            var rules = _rmodel.Objects.OfType<Roslyn.Rule>().ToList();
            var merged = true;
            while (merged)
            {
                merged = false;
                for (int i = 0; i < rules.Count; ++i)
                {
                    var rule = rules[i];
                    for (int j = 0; j < rule.Alternatives.Count; ++j)
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
                                        _rlang.Rules.Remove(rrRule);
                                        _rmodel.RemoveObject((IModelObject)rrRule);
                                        _rmodel.RemoveObject((IModelObject)singleElem.Value);
                                        _rmodel.RemoveObject((IModelObject)singleElem);
                                        _rmodel.RemoveObject((IModelObject)alt);
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
                                        _rlang.Rules.Remove(rrRule);
                                        _rmodel.RemoveObject((IModelObject)rrRule);
                                        _rmodel.RemoveObject((IModelObject)singleElem.Value);
                                        _rmodel.RemoveObject((IModelObject)singleElem);
                                        _rmodel.RemoveObject((IModelObject)alt);
                                        _ruleRefs.Remove(rrRule);
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private void InsertBinders(IList<Binder> target, IList<Binder> source)
        {
            foreach (var binder in source)
            {
                ((IModelObject)binder).Parent = null;
            }
            target.InsertRangeAt(0, source);
        }

        private void InsertAlternativesAt(IList<Alternative> target, int index, IList<Alternative> source)
        {
            foreach (var alt in source)
            {
                ((IModelObject)alt).Parent = null;
            }
            target.InsertRangeAt(index, source);
        }
    }
}
