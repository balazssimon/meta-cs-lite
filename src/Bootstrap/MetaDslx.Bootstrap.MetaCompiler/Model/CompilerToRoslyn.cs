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

            MakeBlockNames(crules);
            MakeBlockNames(cnamedBlocks);

            MergeRules();
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

        private void MakeBlockNames(IEnumerable<ParserRule> crules)
        {
            foreach (var crule in crules)
            {
                MakeBlockNames(crule.Name, crule.Alternatives);
            }
        }

        private void MakeBlockNames(IEnumerable<PBlock> cblocks)
        {
            foreach (var cblock in cblocks)
            {
                MakeBlockNames(cblock.Name, cblock.Alternatives);
            }
        }

        private void MakeBlockNames(string? parentName, IEnumerable<PAlternative> calts)
        {
            foreach (var calt in calts)
            {
                foreach (var elem in calt.Elements)
                {
                    if (elem.Value is PBlock cblock)
                    {
                        if (string.IsNullOrEmpty(cblock.Name))
                        {
                            cblock.Name = MakeBlockName(parentName, elem.SymbolProperty.FirstOrDefault().Name);
                            MakeBlockNames(cblock.Name, cblock.Alternatives);
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

        private void MergeRules()
        {
            MergeSingleAlts();
        }

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
