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
    using Roslyn.Utilities;
    using System.Linq;
    using System.Xml.Linq;
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;
    using IArrayTypeSymbol = Microsoft.CodeAnalysis.IArrayTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using SymbolDisplayFormat = Microsoft.CodeAnalysis.SymbolDisplayFormat;

    public class MetaCompilerParser
    {
        private CSharpTypeInfo SystemTypeTypeInfo;

        private readonly CSharpCompilation _compilation;
        private readonly string _filePath;
        private readonly SourceText _compilerCode;
        private Language? _language;
        private List<Annotation> _annotations = new List<Annotation>();
        private MetaCompilerLexer _lexer;
        private MetaCompilerTokenStream _tokens;
        private DiagnosticBag? _diagnosticBag;
        private ImmutableArray<Diagnostic> _diagnostics;
        private Dictionary<ImmutableArray<string>, CSharpTypeInfo> _typeCache = new Dictionary<ImmutableArray<string>, CSharpTypeInfo>();

        public MetaCompilerParser(CSharpCompilation compilation, string filePath, SourceText compilerCode)
        {
            _compilation = compilation;
            _filePath = filePath;
            _compilerCode = compilerCode;
        }

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics;

        public Language Parse(bool resolveAnnotations)
        {
            if (_language != null) return _language;
            using (_lexer = new MetaCompilerLexer(_filePath, _compilerCode))
            {
                _tokens = new MetaCompilerTokenStream(_lexer);
                _diagnosticBag = DiagnosticBag.GetInstance();
                ParseLanguage();
                if (resolveAnnotations)
                {
                    _language.ResolveAnnotations();
                }
                _diagnosticBag.AddRange(_language.Diagnostics);
                _diagnostics = _diagnosticBag.ToReadOnlyAndFree();
                _diagnosticBag = null;
            }
            return _language;
        }

        private void ParseLanguage()
        {
            _language = new Language(_compilation);
            SystemTypeTypeInfo = CSharpType(Location.None, ImmutableArray.Create("System", "Type"));
            ParseNamespace();
            ParseUsings();
            ParseLanguageDeclaration();
            ParseGrammar();
            ResolveDefaults();
            ResolveRules();
            var ruleNames = new HashSet<string>();
            ResolveBlocks(ruleNames);
            ResolveAlternatives(ruleNames);
            ResolveLists();
            ResolveNames();
            ResolveProperties();
            MakeAnnotations();
            var mainRule = _language.Grammar.ParserRules.FirstOrDefault();
            _language.Grammar.MainRule = mainRule;
            if (mainRule is not null)
            {
                var found = false;
                foreach (var annot in mainRule.Annotations)
                {
                    if (annot.CSharpClass?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == $"{MetaDslxTypes.MetaDslxBindersNamespace}.RootBinder")
                    {
                        _language.Grammar.RootType = annot.ConstructorArguments.Where(a => a.Name == "type").FirstOrDefault()?.Values.FirstOrDefault() as INamedTypeSymbol;
                        found = true;
                    }
                }
                if (!found)
                {
                    _language.Grammar.RootType = mainRule.CSharpReturnType.Type as INamedTypeSymbol;
                }
            }
        }

        private void ResolveRules()
        {
            var ruleNames = new HashSet<string>();
            var rules = _language.Grammar.Rules.ToList();
            foreach (var rule in rules)
            {
                if (rule is LexerRule lr)
                {
                    if (!ruleNames.Add(lr.Name))
                    {
                        Error(lr.Location, $"Language '{_language.Name}' already defines a rule '{lr.Name}'.");
                    }
                    foreach (var alt in lr.Alternatives)
                    {
                        ResolveRules(alt);
                    }
                }
                if (rule is ParserRule pr)
                {
                    if (!ruleNames.Add(pr.Name))
                    {
                        Error(pr.Location, $"Language '{_language.Name}' already defines a rule '{pr.Name}'.");
                    }
                    foreach (var alt in pr.Alternatives)
                    {
                        ResolveRules(alt);
                    }
                }
            }
        }

        private void ResolveRules(LexerRuleAlternative alt)
        {
            foreach (var elem in alt.Elements)
            {
                if (elem is LexerRuleReferenceElement refElem)
                {
                    refElem.Rule = _language.Grammar.Rules.OfType<LexerRule>().FirstOrDefault(r => refElem.RuleName == r.Name);
                    if (refElem.Rule is null)
                    {
                        Error(refElem.Location, $"Lexer rule '{refElem.RuleName}' cannot be found (are you missing a using directive?).");
                    }
                }
                else if (elem is LexerRuleBlockElement blockElem)
                {
                    foreach (var blockAlt in blockElem.Alternatives)
                    {
                        ResolveRules(blockAlt);
                    }
                }
            }
        }

        private void ResolveRules(ParserRuleAlternative alt)
        {
            foreach (var elem in alt.Elements)
            {
                if (elem is ParserRuleReferenceElement refElem)
                {
                    if (string.IsNullOrEmpty(refElem.RuleName) && !refElem.ReferencedCSharpTypes.IsDefault)
                    {
                        refElem.Rule = _language.Grammar.DefaultReference;
                        refElem.RuleName = string.Empty;
                        if (refElem.Rule is null)
                        {
                            Error(refElem.Location, $"Rule with annotation [DefaultReference] cannot be found (are you missing a using directive?).");
                        }
                    }
                    else if (!string.IsNullOrEmpty(refElem.RuleName))
                    {
                        refElem.Rule = _language.Grammar.Rules.FirstOrDefault(r => refElem.RuleName == r.Name);
                    }
                    else
                    {
                        refElem.RuleName = string.Empty;
                    }
                    if (refElem.Rule is null)
                    {
                        Error(refElem.Location, $"Rule '{refElem.RuleName}' cannot be found (are you missing a using directive?).");
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
                    else if (refElem.Rule is ParserRule parserRule)
                    {
                        parserRule.ReferencedBy.Add(alt);
                    }
                }
                else if (elem is ParserRuleBlockElement blockElem)
                {
                    foreach (var blockAlt in blockElem.Alternatives)
                    {
                        ResolveRules(blockAlt);
                    }
                }
                else if (elem is ParserRuleFixedStringElement fixedStringElem)
                {
                    var lexerRule = ResolveFixedLexerRule(_language.Grammar, fixedStringElem.Value);
                    if (lexerRule is null)
                    {
                        lexerRule = new LexerRule(_language.Grammar) { Location = fixedStringElem.Location };
                        var singleAlt = new LexerRuleAlternative();
                        singleAlt.Elements.Add(new LexerRuleFixedStringElement() { ValueText = fixedStringElem.ValueText });
                        lexerRule.Alternatives.Add(singleAlt);
                        lexerRule.Name = MakeFixedLexerRuleName(_language.Grammar, fixedStringElem.Value);
                        _language.Grammar.Rules.Add(lexerRule);
                        if (StringUtilities.IsIdentifier(fixedStringElem.ValueText))
                        {
                            lexerRule.CSharpTokenKind = CSharpType(lexerRule.Location, ImmutableArray.Create("MetaDslx", "CodeAnalysis", "Syntax", "KeywordTokenKind"));
                        }
                        else
                        {
                            lexerRule.CSharpTokenKind = CSharpType(lexerRule.Location, ImmutableArray.Create("MetaDslx", "CodeAnalysis", "Syntax", "OtherTokenKind"));
                        }
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

        private void ResolveBlocks(HashSet<string> ruleNames)
        {
            var rules = _language.Grammar.Rules;
            ruleNames.UnionWith(rules.OfType<ParserRule>().Select(r => r.Name));
            for (int i = 0; i < rules.Count; ++i)
            {
                if (rules[i] is ParserRule pr)
                {
                    ResolveBlocks(pr.Name, pr.Alternatives, ruleNames);
                }
            }
        }

        private void ResolveBlocks(string parentName, List<ParserRuleAlternative> alternatives, HashSet<string> usedNames)
        {
            if (alternatives.Count == 1)
            {
                if (string.IsNullOrEmpty(alternatives[0].Name))
                {
                    alternatives[0].Name = parentName;
                }
            }
            else
            {
                foreach (var alt in alternatives)
                {
                    var index = 0;
                    var altName = $"{parentName}Alt{++index}";
                    while (usedNames.Contains(altName)) altName = $"{parentName}Alt{++index}";
                    alt.Name = altName;
                    usedNames.Add(alt.Name);
                }
            }
            foreach (var alt in alternatives)
            {
                for (int i = 0; i < alt.Elements.Count; ++i)
                {
                    var blockElem = alt.Elements[i] as ParserRuleBlockElement;
                    if (blockElem is not null)
                    {
                        var index = 0;
                        var ruleName = $"{alt.Name}Block{++index}";
                        while (usedNames.Contains(ruleName)) ruleName = $"{alt.Name}Block{++index}";
                        var rule = new ParserRule(_language.Grammar);
                        rule.Name = ruleName;
                        rule.IsPart = true;
                        usedNames.Add(rule.Name);
                        rule.Location = blockElem.Location;
                        rule.Annotations.AddRange(blockElem.Annotations);
                        rule.Alternatives.AddRange(blockElem.Alternatives);
                        _language.Grammar.Rules.Add(rule);
                        var refElem = new ParserRuleReferenceElement(alt);
                        refElem.Annotations.AddRange(blockElem.NameAnnotations);
                        refElem.Name = blockElem.Name;
                        refElem.ModelPropertyName = blockElem.ModelPropertyName;
                        refElem.NameLocation = blockElem.NameLocation;
                        refElem.Location = blockElem.Location;
                        refElem.AssignmentOperator = blockElem.AssignmentOperator;
                        refElem.Rule = rule;
                        refElem.IsNegated = blockElem.IsNegated;
                        refElem.Multiplicity = blockElem.Multiplicity;
                        alt.Elements[i] = refElem;
                        rule.ReferencedBy.Add(alt);
                    }
                }
            }
        }

        private void ResolveAlternatives(HashSet<string> ruleNames)
        {
            var rules = _language.Grammar.Rules;
            for (int i = 0; i < rules.Count; ++i)
            {
                if (rules[i] is ParserRule targetRule && !targetRule.IsPart && targetRule.ReferencedBy.Count == 1)
                {
                    var sourceAlt = targetRule.ReferencedBy[0];
                    if (sourceAlt.Parent is ParserRule sourceRule && sourceAlt.Elements.Count == 1 && 
                        sourceAlt.Elements[0].Multiplicity == Multiplicity.ExactlyOne &&
                        string.IsNullOrEmpty(sourceAlt.Elements[0].ModelPropertyName))
                    {
                        var sourceAltIndex = sourceRule.Alternatives.IndexOf(sourceAlt);
                        if (sourceAltIndex >= 0)
                        {
                            if (targetRule.Alternatives.Count == 1)
                            {
                                targetRule.Alternatives[0].Name = targetRule.Name;
                            }
                            sourceRule.Alternatives.RemoveAt(sourceAltIndex);
                            sourceRule.Alternatives.InsertRange(sourceAltIndex, targetRule.Alternatives);
                            foreach (var alt in targetRule.Alternatives)
                            {
                                alt.Parent = sourceRule;
                                if (alt.CSharpReturnType?.Type is null) alt.CSharpReturnType = targetRule.CSharpReturnType;
                                alt.Annotations.InsertRange(0, targetRule.Annotations);
                            }
                            targetRule.ReferencedBy.Clear();
                            rules.Remove(targetRule);
                            --i;
                        }
                    }
                }
            }
            for (int i = 0; i < rules.Count; ++i)
            {
                if (rules[i] is ParserRule targetRule)
                {
                    var tokenAlts = targetRule.Alternatives.Where(alt => alt.Elements.Count == 1 && alt.Elements[0] is ParserRuleFixedStringElement).ToList();
                    if (tokenAlts.Count >= 2)
                    {
                        if (tokenAlts.Count == targetRule.Alternatives.Count)
                        {
                            foreach (var sourceAlt in targetRule.ReferencedBy)
                            {
                                for (int j = 0; j < sourceAlt.Elements.Count; j++)
                                {
                                    var sourceElement = sourceAlt.Elements[j] as ParserRuleReferenceElement;
                                    if (sourceElement is not null && sourceElement.Rule == targetRule)
                                    {
                                        sourceAlt.Elements[j] = MakeFixedStringAlternativesElement(targetRule, sourceAlt, sourceElement, tokenAlts);
                                    }
                                }
                            }
                            targetRule.ReferencedBy.Clear();
                            rules.Remove(targetRule);
                            --i;
                        }
                        else
                        {
                            var tokensAlt = new ParserRuleAlternative(targetRule);
                            var tokensAltName = $"{targetRule.Name}Tokens";
                            var tokensAltNameIndex = 0;
                            while (ruleNames.Contains(tokensAltName)) tokensAltName = $"{targetRule.Name}Tokens{++tokensAltNameIndex}";
                            tokensAlt.Name = tokensAltName;
                            ruleNames.Add(tokensAlt.Name);
                            tokensAlt.CSharpReturnType = targetRule.CSharpReturnType;
                            foreach (var tokenAlt in tokenAlts)
                            {
                                var token = (ParserRuleFixedStringElement)tokenAlt.Elements[0];
                                token.Annotations.InsertRange(0, tokenAlt.Annotations);
                                targetRule.Alternatives.Remove(tokenAlt);
                            }
                            var tokensElement = MakeFixedStringAlternativesElement(null, tokensAlt, null, tokenAlts);
                            tokensElement.Name = "tokens";
                            tokensAlt.Elements.Add(tokensElement);
                            targetRule.Alternatives.Add(tokensAlt);
                        }
                    }

                }
            }
        }

        private ParserRuleFixedStringAlternativesElement MakeFixedStringAlternativesElement(ParserRule? targetRule, ParserRuleAlternative sourceAlternative, ParserRuleElement? sourceElement, List<ParserRuleAlternative> tokenAlts)
        {
            var result = new ParserRuleFixedStringAlternativesElement(sourceAlternative);
            if (sourceElement is not null) result.Annotations.AddRange(sourceElement.Annotations);
            if (targetRule is not null) result.Annotations.AddRange(targetRule.Annotations);
            if (sourceElement is not null)
            {
                result.Name = sourceElement.Name;
                result.ModelPropertyName = sourceElement.ModelPropertyName;
                result.NameLocation = sourceElement.NameLocation;
                result.NameAnnotations.AddRange(sourceElement.NameAnnotations);
                result.Location = sourceElement.Location;
                result.AssignmentOperator = sourceElement.AssignmentOperator;
                result.IsNegated = sourceElement.IsNegated;
                result.Multiplicity = sourceElement.Multiplicity;
            }
            foreach (var tokenAlt in tokenAlts)
            {
                var token = (ParserRuleFixedStringElement)tokenAlt.Elements[0];
                var alt = new ParserRuleFixedStringElement(sourceAlternative);
                alt.Annotations.AddRange(token.Annotations);
                alt.Name = token.Name;
                alt.ModelPropertyName = token.ModelPropertyName;
                alt.ReturnValue = token.ReturnValue != null ? token.ReturnValue : tokenAlt.ReturnValue;
                alt.CSharpReturnType = token.CSharpReturnType;
                if (alt.CSharpReturnType?.Type is null) alt.CSharpReturnType = tokenAlt?.CSharpReturnType;
                if (alt.CSharpReturnType?.Type is null) alt.CSharpReturnType = targetRule?.CSharpReturnType;
                if (alt.CSharpReturnType?.Type is null) alt.CSharpReturnType = sourceAlternative?.CSharpReturnType;
                alt.NameLocation = token.NameLocation;
                alt.NameAnnotations.AddRange(token.NameAnnotations);
                alt.Location = token.Location;
                alt.AssignmentOperator = token.AssignmentOperator;
                alt.IsNegated = token.IsNegated;
                alt.Multiplicity = token.Multiplicity;
                alt.LexerRule = token.LexerRule;
                result.Alternatives.Add(alt);
            }
            return result;
        }

        private void ResolveLists()
        {
            foreach (var rule in _language.Grammar.Rules)
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
            for (int i = 0; i < alt.Elements.Count; i++)
            {
                var first = alt.Elements[i];
                if (first is ParserRuleReferenceElement firstRef && firstRef.Rule is ParserRule firstRule && !firstRef.IsNegated)
                {
                    if (firstRef.Multiplicity.IsList())
                    {
                        if (IsSeparatedList(firstRule, out var separatorFirst, out var item, out var itemElement, out var separatorElement))
                        {
                            if (separatorFirst)
                            {
                                // (, item)*
                                var listElem = new ParserRuleListElement(alt);
                                listElem.ListKind = ListKind.SeparatorItem;
                                listElem.RepeatedRule = firstRef;
                                listElem.RepeatedSeparator = separatorElement;
                                listElem.RepeatedItem = itemElement;
                                alt.Elements[i] = listElem;
                            }
                            else
                            {
                                var hasSecond = false;
                                if (i + 1 < alt.Elements.Count)
                                {
                                    var second = alt.Elements[i + 1];
                                    if (second is ParserRuleReferenceElement secondRef && secondRef.Rule is ParserRule secondRule && !secondRef.Multiplicity.IsList() && !secondRef.IsNegated && secondRef.Name == itemElement.Name && secondRule == item)
                                    {
                                        hasSecond = true;
                                        var hasThird = false;
                                        if (secondRef.Multiplicity == Multiplicity.ExactlyOne && i + 2 < alt.Elements.Count)
                                        {
                                            var third = alt.Elements[i + 2];
                                            if (third.IsToken && !third.Multiplicity.IsList() && !third.IsNegated)
                                            {
                                                if (separatorElement is ParserRuleFixedStringElement firstSep && third is ParserRuleFixedStringElement secondSep && firstSep.Name == secondSep.Name && firstSep.LexerRule == secondSep.LexerRule)
                                                {
                                                    // (item ,)* item ,
                                                    hasThird = true;
                                                    var listElem = new ParserRuleListElement(alt);
                                                    listElem.ListKind = ListKind.WithLastItemSeparator;
                                                    listElem.RepeatedRule = firstRef;
                                                    listElem.RepeatedSeparator = separatorElement;
                                                    listElem.RepeatedItem = itemElement;
                                                    listElem.LastItem = secondRef;
                                                    listElem.LastSeparator = secondSep;
                                                    alt.Elements.RemoveAt(i + 2);
                                                    alt.Elements.RemoveAt(i + 1);
                                                    alt.Elements[i] = listElem;
                                                }
                                            }
                                        }
                                        if (!hasThird)
                                        {
                                            // (item ,)* item
                                            var listElem = new ParserRuleListElement(alt);
                                            listElem.ListKind = ListKind.WithLastItem;
                                            listElem.RepeatedRule = firstRef;
                                            listElem.RepeatedSeparator = separatorElement;
                                            listElem.RepeatedItem = itemElement;
                                            listElem.LastItem = secondRef;
                                            alt.Elements.RemoveAt(i + 1);
                                            alt.Elements[i] = listElem;
                                        }
                                    }
                                }
                                if (!hasSecond)
                                {
                                    // (item ,)*
                                    var listElem = new ParserRuleListElement(alt);
                                    listElem.ListKind = ListKind.ItemSeparator;
                                    listElem.RepeatedRule = firstRef;
                                    listElem.RepeatedSeparator = separatorElement;
                                    listElem.RepeatedItem = itemElement;
                                    alt.Elements[i] = listElem;
                                }
                            }
                        }
                    }
                    else
                    {
                        if (i + 1 < alt.Elements.Count)
                        {
                            var second = alt.Elements[i + 1];
                            if (second is ParserRuleReferenceElement secondRef && secondRef.Rule is ParserRule secondRule && secondRef.Multiplicity.IsList() && !secondRef.IsNegated)
                            {
                                if (IsSeparatedList(secondRule, out var separatorFirst, out var item, out var itemElement, out var separatorElement) && separatorFirst && firstRef.Name == itemElement.Name && firstRule == item)
                                {
                                    var hasThird = false;
                                    if (i + 2 < alt.Elements.Count)
                                    {
                                        var third = alt.Elements[i + 2];
                                        if (third.IsToken && !third.Multiplicity.IsList() && !third.IsNegated)
                                        {
                                            if (separatorElement is ParserRuleFixedStringElement firstSep && third is ParserRuleFixedStringElement secondSep && firstRef.Name == third.Name && firstSep.LexerRule == secondSep.LexerRule)
                                            {
                                                // item (, item)* ,
                                                hasThird = true;
                                                var listElem = new ParserRuleListElement(alt);
                                                listElem.ListKind = ListKind.WithFirstItemSeparator;
                                                listElem.RepeatedRule = secondRef;
                                                listElem.RepeatedSeparator = separatorElement;
                                                listElem.RepeatedItem = itemElement;
                                                listElem.FirstItem = firstRef;
                                                listElem.LastSeparator = secondSep;
                                                alt.Elements.RemoveAt(i + 2);
                                                alt.Elements.RemoveAt(i + 1);
                                                alt.Elements[i] = listElem;
                                            }
                                        }
                                    }
                                    if (!hasThird)
                                    {
                                        // item (, item)*
                                        var listElem = new ParserRuleListElement(alt);
                                        listElem.ListKind = ListKind.WithFirstItem;
                                        listElem.RepeatedRule = secondRef;
                                        listElem.RepeatedSeparator = separatorElement;
                                        listElem.RepeatedItem = itemElement;
                                        listElem.FirstItem = firstRef;
                                        alt.Elements.RemoveAt(i + 1);
                                        alt.Elements[i] = listElem;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        private bool IsSeparatedList(ParserRule rule, out bool separatorFirst, out ParserRule? item, out ParserRuleReferenceElement? itemElement, out ParserRuleElement? separatorElement)
        {
            separatorFirst = true;
            item = null;
            itemElement = null;
            separatorElement = null;
            if (rule.Alternatives.Count != 1) return false;
            var alt = rule.Alternatives[0];
            if (alt.Elements.Count != 2) return false;
            var first = alt.Elements[0];
            var second = alt.Elements[1];
            return IsSeparatedList(first, second, out separatorFirst, out item, out itemElement, out separatorElement);
        }

        private bool IsSeparatedList(ParserRuleElement first, ParserRuleElement second, out bool separatorFirst, out ParserRule? item, out ParserRuleReferenceElement? itemElement, out ParserRuleElement? separatorElement)
        {
            separatorFirst = true;
            item = null;
            itemElement = null;
            separatorElement = null;
            if (first.Multiplicity == Multiplicity.ExactlyOne && !first.IsNegated &&
                second.Multiplicity == Multiplicity.ExactlyOne && !second.IsNegated)
            {
                if (first.IsToken && second is ParserRuleReferenceElement secondRef && secondRef.Rule is ParserRule secondRule)
                {
                    item = secondRule;
                    itemElement = secondRef;
                    separatorElement = first;
                    separatorFirst = true;
                    return true;
                }
                if (second.IsToken && first is ParserRuleReferenceElement firstRef && firstRef.Rule is ParserRule firstRule)
                {
                    item = firstRule;
                    itemElement = firstRef;
                    separatorElement = second;
                    separatorFirst = false;
                    return true;
                }
            }
            return false;
        }

        private void ResolveNames()
        {
            var usedElementNames = new HashSet<string>();
            foreach (var rule in _language.Grammar.ParserRules)
            {
                if (rule.Alternatives.Count == 1)
                {
                    rule.Alternatives[0].Name = rule.Name;
                }
                ResolveElementNames(rule.Alternatives, usedElementNames, true);
            }
        }

        private void ResolveElementNames(List<ParserRuleAlternative> alternatives, HashSet<string> usedElementNames, bool clearUsedElementNames)
        {
            foreach (var alt in alternatives)
            {
                if (clearUsedElementNames)
                {
                    usedElementNames.Clear();
                    usedElementNames.Add("diagnostics");
                    usedElementNames.Add("annotations");
                    usedElementNames.Add("fullWidth");
                    usedElementNames.Add("isDirective");
                    usedElementNames.Add("isList");
                    usedElementNames.Add("isToken");
                    usedElementNames.Add("isTrivia");
                    usedElementNames.Add("language");
                    usedElementNames.Add("kind");
                    usedElementNames.Add("kindText");
                    usedElementNames.Add("rawKind");
                    usedElementNames.Add("slotCount");
                }
                ResolveElementNames(alt, usedElementNames);
            }
        }

        private void ResolveElementNames(ParserRuleAlternative alternative, HashSet<string> usedElementNames)
        {
            foreach (var elem in alternative.Elements)
            {
                ResolveElementNames(elem, usedElementNames);
            }
        }

        private void ResolveElementNames(ParserRuleElement elem, HashSet<string> usedElementNames)
        {
            if (string.IsNullOrEmpty(elem.Name) || usedElementNames.Contains(elem.Name))
            {
                var defaultName = elem.Name;
                if (string.IsNullOrEmpty(defaultName)) defaultName = elem.DefaultName;
                if (string.IsNullOrEmpty(defaultName)) defaultName = "element";
                var name = defaultName;
                var index = 0;
                while (usedElementNames.Contains(name)) name = $"{defaultName}{++index}";
                elem.Name = name;
                if (elem.IsList) elem.AssignmentOperator = AssignmentOperator.PlusAssign;
            }
            usedElementNames.Add(elem.Name);
            if (elem is ParserRuleReferenceElement refElem && elem.Name == refElem.Name)
            {
                var index = 0;
                var name = $"{elem.Name}Antlr{++index}";
                while (usedElementNames.Contains(name)) name = $"{elem.Name}Antlr{++index}";
                elem.AntlrName = name;
            }
            else if (elem is ParserRuleFixedStringAlternativesElement fixedAlts)
            {
                foreach (var alt in fixedAlts.Alternatives)
                {
                    ResolveElementNames(alt, usedElementNames);
                }
            }
            else if (elem is ParserRuleListElement listElem)
            {
                ResolveElementNames(listElem.RepeatedRule, usedElementNames);
                if (listElem.FirstItem is not null) ResolveElementNames(listElem.FirstItem, usedElementNames);
                if (listElem.LastItem is not null) ResolveElementNames(listElem.LastItem, usedElementNames);
                if (listElem.LastSeparator is not null) ResolveElementNames(listElem.LastSeparator, usedElementNames);
            }
            else
            {
                elem.AntlrName = elem.Name;
            }
        }

        private void ResolveProperties()
        {
            var ruleStack = new List<ParserRule>();
            foreach (var rule in _language.Grammar.ParserRules)
            {
                if (!rule.IsPart) ResolveProperties(rule, rule.CSharpReturnType, ruleStack);
            }
        }

        private void ResolveProperties(ParserRule rule, CSharpTypeInfo modelObjectType, List<ParserRule> ruleStack)
        {
            if (ruleStack.Contains(rule)) return;
            ruleStack.Add(rule);
            try
            {
                foreach (var alt in rule.Alternatives)
                {
                    ResolveProperties(alt, alt.CSharpReturnType?.Type is null ? modelObjectType : alt.CSharpReturnType, null, ruleStack);
                }
            }
            finally
            {
                ruleStack.RemoveAt(ruleStack.Count - 1);
            }
        }

        private void ResolveProperties(ParserRuleAlternative alternative, CSharpTypeInfo modelObjectType, CSharpPropertyInfo property, List<ParserRule> ruleStack)
        {
            foreach (var elem in alternative.Elements)
            {
                var prop = ResolveProperty(modelObjectType, elem.ModelPropertyName, elem.NameLocation, ruleStack);
                elem.CSharpModelProperty = prop;
                ResolveProperties(elem, modelObjectType, prop, ruleStack);
            }
            ResolveReturnValue(alternative.ReturnValue, modelObjectType, property, ruleStack);
        }

        private void ResolveProperties(ParserRuleElement elem, CSharpTypeInfo modelObjectType, CSharpPropertyInfo property, List<ParserRule> ruleStack)
        {
            if (elem is ParserRuleReferenceElement refElem)
            {
                if (refElem.CSharpModelProperty is null)
                {
                    var prop = ResolveProperty(modelObjectType, refElem.ModelPropertyName, refElem.NameLocation, ruleStack);
                    refElem.CSharpModelProperty = prop?.PropertyType?.Type is null ? property : prop;
                }
                if (refElem.Rule is ParserRule parserRule)
                {
                    if (parserRule.IsPart)
                    {
                        ResolveProperties(parserRule, modelObjectType, ruleStack);
                    }
                    else
                    {
                        if (refElem.ReferencedCSharpTypes.IsDefaultOrEmpty)
                        {
                            CheckType(elem.CSharpModelProperty, parserRule.CSharpReturnType, elem.Location);
                        }
                        else
                        {
                            foreach (var type in refElem.ReferencedCSharpTypes)
                            {
                                CheckType(elem.CSharpModelProperty, type, elem.Location);
                            }
                        }
                    }
                }
                else
                {
                    CheckType(elem.CSharpModelProperty, refElem.Rule?.CSharpReturnType, elem.Location);
                }
            }
            else if (elem is ParserRuleFixedStringElement fixedElem)
            {
                ResolveReturnValue(fixedElem.ReturnValue, modelObjectType, property, ruleStack);
            }
            else if (elem is ParserRuleFixedStringAlternativesElement fixedAlts)
            {
                foreach (var alt in fixedAlts.Alternatives)
                {
                    var altModelObjectType = alt.CSharpReturnType?.Type is null ? modelObjectType : alt.CSharpReturnType;
                    var prop = ResolveProperty(altModelObjectType, alt.ModelPropertyName, alt.NameLocation, ruleStack);
                    alt.CSharpModelProperty = prop?.PropertyType?.Type is null ? property : prop;
                    ResolveProperties(alt, altModelObjectType, alt.CSharpModelProperty, ruleStack);
                }
            }
            else if (elem is ParserRuleListElement listElem)
            {
                ResolveProperties(listElem.RepeatedRule, modelObjectType, property, ruleStack);
                if (listElem.FirstItem is not null) ResolveProperties(listElem.FirstItem, modelObjectType, property, ruleStack);
                if (listElem.LastItem is not null) ResolveProperties(listElem.LastItem, modelObjectType, property, ruleStack);
                if (listElem.LastSeparator is not null) ResolveProperties(listElem.LastSeparator, modelObjectType, property, ruleStack);
            }
            else if (elem is ParserRuleBlockElement blockElem)
            {
                if (blockElem.CSharpReturnType?.Type is null) blockElem.CSharpReturnType = elem.CSharpModelProperty.PropertyType;
                var blockModelObjectType = blockElem.CSharpReturnType?.Type is null ? modelObjectType : blockElem.CSharpReturnType;
                var prop = ResolveProperty(blockModelObjectType, blockElem.ModelPropertyName, blockElem.NameLocation, ruleStack);
                blockElem.CSharpModelProperty = prop?.PropertyType?.Type is null ? property : prop;
                foreach (var blockAlt in blockElem.Alternatives)
                {
                    ResolveProperties(blockAlt, blockModelObjectType, blockElem.CSharpModelProperty, ruleStack);
                }
            }
        }

        private CSharpPropertyInfo ResolveProperty(CSharpTypeInfo modelObjectType, string propertyName, Location location, List<ParserRule> ruleStack)
        {
            var prop = CSharpProperty(modelObjectType, propertyName);
            if (!string.IsNullOrEmpty(propertyName) && modelObjectType?.Type is not null && prop?.PropertyType?.Type is null)
            {
                Error(location, $"Could not find property '{modelObjectType.CoreType.Name}.{propertyName}'.");
            }
            if (prop?.PropertyType?.Type is not null && !prop.IsWritable && !modelObjectType.IsSymbol)
            {
                Error(location, $"Cannot assign value to property '{modelObjectType.CoreType.Name}.{propertyName}', because it is read only.");
            }
            return prop;
        }

        private void ResolveReturnValue(Expression expression, CSharpTypeInfo modelObjectType, CSharpPropertyInfo property, List<ParserRule> ruleStack)
        {
            if (expression is not null)
            {
                var expectedType = property?.PropertyType?.Type is null ? modelObjectType : property.PropertyType;
                if (expression.Type == typeof(object))
                {
                    if (expectedType.ItemTypeKind.HasFlag(ItemTypeKind.EnumType) && expression.Qualifier.Length == 1)
                    {
                        expression.Value = expectedType.CoreType.GetMembers(expression.Qualifier[0]).FirstOrDefault();
                        expression.CSharpType = new CSharpTypeInfo(_language, expectedType.CoreType);
                    }
                    if (expression.Value is null && TryGetCSharpSymbol(expression.Location, expression.Qualifier, out var symbol))
                    {
                        expression.Value = symbol;
                        expression.CSharpType = new CSharpTypeInfo(_language, expectedType.CoreType);
                    }
                    if (expression.Value is null)
                    {
                        Error(expression.Location, $"Could not resolve '{expression.ValueText}'.");
                    }
                }
                CheckType(expectedType, expression, expression.Location);
            }
        }

        private void MakeAnnotations()
        {
            foreach (var rule in _language.Grammar.LexerRules)
            {
                MakeAnnotations(rule);
            }
            foreach (var rule in _language.Grammar.ParserRules)
            {
                MakeAnnotations(rule);
            }
        }

        private void MakeAnnotations(LexerRule rule)
        {
            if (rule.CSharpReturnType?.Type is not null)
            {
                var annot = new Annotation(rule.Grammar);
                annot.Name = ImmutableArray.Create("Value");
                annot.Location = rule.Location;
                var annotProp =
                    new AnnotationProperty(annot)
                    {
                        Name = "type",
                        ValueTexts = ImmutableArray.Create(rule.CSharpReturnType.Type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)),
                    };
                annot.ConstructorArguments.Add(annotProp);
                rule.Annotations.Add(annot);
            }
        }

        private void MakeAnnotations(ParserRule rule)
        {
            foreach (var alt in rule.Alternatives)
            {
                MakeAnnotations(alt);
            }
        }

        private void MakeAnnotations(ParserRuleAlternative alternative)
        {
            var returnType = alternative.CSharpReturnType ?? alternative.Parent.CSharpReturnType;
            if (returnType?.Type is not null && alternative.ReturnValue is null)
            {
                var addAnnotation = true;
                if (alternative.Elements.Count == 0)
                {
                    addAnnotation = alternative.CSharpReturnType is not null;
                }
                else if (alternative.Elements.Count == 1)
                {
                    var elem = alternative.Elements[0];
                    if (elem is ParserRuleReferenceElement refElem)
                    {
                        if (!refElem.ReferencedCSharpTypes.IsDefaultOrEmpty)
                        {
                            addAnnotation = false;
                        }
                        else if (refElem.Rule is ParserRule refRule && !refRule.IsPart)
                        {
                            CheckType(returnType, refRule.CSharpReturnType, refElem.RuleName, refElem.Location);
                            addAnnotation = false;
                        }
                    }
                    else if (elem is ParserRuleFixedStringAlternativesElement fixedAltsElem)
                    {
                        addAnnotation = false;
                    }
                }
                if (addAnnotation)
                {
                    var annot = new Annotation(alternative.Grammar);
                    annot.Name = ImmutableArray.Create("Define");
                    annot.Location = alternative.Location;
                    var typeName = returnType.Type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                    annot.ConstructorArguments.Add(new AnnotationProperty(annot) { Name = "type", ValueTexts = ImmutableArray.Create(typeName) });
                    alternative.Annotations.Add(annot);
                }
            }
            foreach (var elem in alternative.Elements)
            {
                MakeAnnotations(elem);
            }
        }

        private void MakeAnnotations(ParserRuleElement elem)
        {
            if (elem.CSharpModelProperty?.PropertyType?.Type is not null && !string.IsNullOrWhiteSpace(elem.ModelPropertyName))
            {
                var annot = new Annotation(elem.Grammar);
                annot.Name = ImmutableArray.Create("Property");
                annot.Location = elem.NameLocation;
                var nameProp = new AnnotationProperty(annot) { Name = "name", ValueTexts = ImmutableArray.Create(elem.ModelPropertyName) };
                annot.ConstructorArguments.Add(nameProp);
                if (elem.AssignmentOperator == AssignmentOperator.QuestionAssign)
                {
                    var valueProp = new AnnotationProperty(annot) { Name = "value" };
                    valueProp.ValueTexts = ImmutableArray.Create("true");
                    annot.ConstructorArguments.Add(valueProp);
                    elem.Annotations.Add(annot);
                }
                else if (elem.AssignmentOperator == AssignmentOperator.NegatedAssign)
                {
                    var valueProp = new AnnotationProperty(annot) { Name = "value" };
                    valueProp.ValueTexts = ImmutableArray.Create("true");
                    annot.IsNegated = true;
                    annot.ConstructorArguments.Add(valueProp);
                    elem.Annotations.Add(annot);
                }
                else
                {
                    elem.NameAnnotations.Add(annot);
                }
            }
            if (elem is ParserRuleReferenceElement refElem)
            {
                if (!refElem.ReferencedCSharpTypes.IsDefaultOrEmpty)
                {
                    var annot = new Annotation(elem.Grammar);
                    annot.Name = ImmutableArray.Create("Use");
                    annot.Location = elem.NameLocation;
                    var annotProp =
                        new AnnotationProperty(annot)
                        {
                            Name = "types"
                        };
                    annotProp.ValueTexts = refElem.ReferencedCSharpTypes.Where(t => t.Type is not null).Select(t => t.Type?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)).ToImmutableArray();
                    annot.ConstructorArguments.Add(annotProp);
                    elem.Annotations.Add(annot);
                }
            }
            else if (elem is ParserRuleFixedStringElement fixedElem)
            {
                if (fixedElem.ReturnValue?.CSharpType?.Type is not null)
                {
                    var annot = new Annotation(elem.Grammar);
                    annot.Name = ImmutableArray.Create("Constant");
                    annot.Location = elem.NameLocation;
                    var annotProp = 
                        new AnnotationProperty(annot) 
                        { 
                            Name = "value", 
                            ValueTexts = ImmutableArray.Create(fixedElem.ReturnValue.ToCSharpValue())
                        };
                    annot.ConstructorArguments.Add(annotProp);
                    elem.Annotations.Add(annot);
                }
                else if (fixedElem.CSharpReturnType?.Type is not null)
                {
                    var annot = new Annotation(elem.Grammar);
                    annot.Name = ImmutableArray.Create("Value");
                    annot.Location = elem.NameLocation;
                    var annotProp =
                        new AnnotationProperty(annot)
                        {
                            Name = "type",
                            ValueTexts = ImmutableArray.Create(fixedElem.CSharpReturnType.Type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)),
                        };
                    annot.ConstructorArguments.Add(annotProp);
                    elem.Annotations.Add(annot);
                }
            }
            else if (elem is ParserRuleFixedStringAlternativesElement fixedAlts)
            {
                foreach (var alt in fixedAlts.Alternatives)
                {
                    MakeAnnotations(alt);
                }
            }
            else if (elem is ParserRuleListElement listElem)
            {
                MakeAnnotations(listElem.RepeatedRule);
                if (listElem.FirstItem is not null) MakeAnnotations(listElem.FirstItem);
                if (listElem.LastItem is not null) MakeAnnotations(listElem.LastItem);
                if (listElem.LastSeparator is not null) MakeAnnotations(listElem.LastSeparator);
            }
            else if (elem is ParserRuleBlockElement blockElem)
            {
                foreach (var blockAlt in blockElem.Alternatives)
                {
                    MakeAnnotations(blockAlt);
                }
            }
        }

        private void ResolveDefaults()
        {
            var grammar = _language.Grammar;
            LexerRule? _defaultWhitespace = null;
            LexerRule? _defaultEndOfLine = null;
            LexerRule? _defaultIdentifier = null;
            LexerRule? _defaultSeparator = null;
            Rule? _defaultReference = null;
            foreach (var rule in grammar.Rules)
            {
                ResolveDefaultRule(ref _defaultReference, rule, "DefaultReference");
                if (rule is LexerRule lexerRule)
                {
                    ResolveDefaultTokenKind(ref _defaultWhitespace, lexerRule, "DefaultWhitespace");
                    ResolveDefaultTokenKind(ref _defaultEndOfLine, lexerRule, "DefaultEndOfLine");
                    ResolveDefaultTokenKind(ref _defaultIdentifier, lexerRule, "DefaultIdentifier");
                    ResolveDefaultTokenKind(ref _defaultSeparator, lexerRule, "DefaultSeparator");
                }
            }
            grammar.DefaultWhitespace = _defaultWhitespace;
            grammar.DefaultEndOfLine = _defaultEndOfLine;
            grammar.DefaultIdentifier = _defaultIdentifier;
            grammar.DefaultSeparator = _defaultSeparator;
            grammar.DefaultReference = _defaultReference;
            if (grammar.DefaultWhitespace is null) Error(_language.Location, $"Token with kind [DefaultWhitespace] cannot be found (are you missing a using directive?).");
            if (grammar.DefaultEndOfLine is null) Error(_language.Location, $"Token with kind [DefaultEndOfLine] cannot be found (are you missing a using directive?).");
            if (grammar.DefaultIdentifier is null) Error(_language.Location, $"Token with kind [DefaultIdentifier] cannot be found (are you missing a using directive?).");
            if (grammar.DefaultSeparator is null) Error(_language.Location, $"Token with kind [DefaultSeparator] cannot be found (are you missing a using directive?).");
            if (grammar.DefaultReference is null) Error(_language.Location, $"Rule with annotation [DefaultReference] cannot be found (are you missing a using directive?).");
        }

        private void ResolveDefaultRule<TRule>(ref TRule? rule, TRule defaultRule, string kindName)
            where TRule : Rule
        {
            if (defaultRule.Annotations.Any(a => a.Name.LastOrDefault() == kindName))
            {
                if (rule is null)
                {
                    rule = defaultRule;
                }
                else
                {
                    Error(defaultRule.Location, $"There is already another rule with [{kindName}] defined in the grammar called '{rule.Name}'. There must be exactly one default rule with this annotation.");
                }
            }
        }

        private void ResolveDefaultTokenKind(ref LexerRule? lexerRule, LexerRule defaultRule, string kindName)
        {
            var tokenKindName = defaultRule.CSharpTokenKind?.Type?.Name;
            if (tokenKindName == $"{kindName}TokenKind")
            {
                if (lexerRule is null)
                {
                    lexerRule = defaultRule;
                }
                else
                {
                    Error(defaultRule.Location, $"There is already another token of kind [{kindName}] defined in the grammar called '{lexerRule.Name}'. There must be exactly one default token with this kind.");
                }
            }
        }

        private Annotation? GetAnnotation(IEnumerable<Annotation> annotations, string annotationName)
        {
            if (string.IsNullOrEmpty(annotationName)) return null;
            foreach (var annotation in annotations)
            {
                var name = annotation.CSharpClass?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (name == annotationName) return annotation;
            }
            return null;
        }

        private bool HasAnnotation(IEnumerable<Annotation> annotations, string annotationName)
        {
            return GetAnnotation(annotations, annotationName) is not null;
        }

        private void ParseNamespace()
        {
            if (MatchKeyword("namespace"))
            {
                _language.Namespace = ParseQualifier(".");
                MatchSemicolon();
            }
        }

        private void ParseUsings()
        {
            while (IsKeyword("using"))
            {
                var token = _tokens.NextToken();
                var usingKind = UsingKind.None;
                if (token.Kind == MetaCompilerTokenKind.Keyword)
                {
                    if (token.Text == "_language") usingKind = UsingKind.Language;
                    else Expected("_language");
                    _tokens.NextToken();
                }
                var usingDecl = new Using(_language);
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
                _language.Usings.Add(usingDecl);
                MatchSemicolon();
            }
        }

        private void ParseLanguageDeclaration()
        {
            if (MatchKeyword("language"))
            {
                var token = _tokens.CurrentToken;
                if (token.Kind == MetaCompilerTokenKind.Identifier)
                {
                    _language.Name = token.Text;
                    _language.Location = _tokens.CurrentLocation;
                    _tokens.NextToken();
                    MatchSemicolon();
                }
                else
                {
                    Error("Identifier expected");
                }
            }
        }

        private void ParseGrammar()
        {
            _language.Grammar = new Grammar(_language);
            while (true)
            {
                var advanced = false;
                ParseAnnotations();
                if (TryParseLexerRule(_language.Grammar)) advanced = true;
                if (TryParseParserRule(_language.Grammar)) advanced = true;
                if (!advanced) break;
            }
        }

        private void ParseAnnotations()
        {
            var token = _tokens.CurrentToken;
            var parseNext = token.Text == "[";
            while (!_tokens.EndOfFile && parseNext)
            {
                parseNext = false;
                token = _tokens.NextToken();
                var annotation = new Annotation(_language.Grammar);
                _annotations.Add(annotation);
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
                    parseNext = token.Text == "[";
                }
                if (token.Text == ",")
                {
                    parseNext = true;
                }
            }
        }

        private void ParseAnnotationProperties(Annotation annotation)
        {
            var allowComma = false;
            while (!_tokens.EndOfFile)
            {
                var token = _tokens.CurrentToken;
                var nextToken = _tokens.PeekToken(1);
                if (token.Text == ")" || token.Text == "]")
                {
                    return;
                }
                else if (token.Kind == MetaCompilerTokenKind.Other && token.Text == ",")
                {
                    if (!allowComma) Unexpected();
                    _tokens.NextToken();
                    allowComma = false;
                }
                else
                {
                    var property = new AnnotationProperty(annotation);
                    if (token.Kind == MetaCompilerTokenKind.Identifier && nextToken.Text == ":")
                    {
                        annotation.ConstructorArguments.Add(property);
                        _tokens.NextToken();
                        property.Location = _tokens.CurrentLocation;
                        property.Name = token.Text;
                        _tokens.NextToken();
                    }
                    else
                    {
                        annotation.ConstructorArguments.Add(property);
                        property.Location = _tokens.CurrentLocation;
                    }
                    var expressions = MatchAnnotationExpressionsUntil(",", ")", "]");
                    property.ValueTexts = expressions.Values;
                    property.IsArray = expressions.IsArray;
                    allowComma = true;
                }
            }
        }

        private bool TryParseLexerRule(Grammar grammar)
        {
            bool isToken = false;
            bool isFragment = false;
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Keyword)
            {
                isToken = token.Text == "token";
                isFragment = token.Text == "fragment";
                if (isToken || isFragment) token = _tokens.NextToken();
            }
            if ((isToken || isFragment) && token.Kind == MetaCompilerTokenKind.Identifier)
            {
                var rule = new LexerRule(grammar);
                grammar.Rules.Add(rule);
                rule.IsFragment = isFragment;
                rule.Location = _tokens.CurrentLocation;
                rule.Name = token.Text;
                rule.Annotations.AddRange(_annotations);
                _annotations.Clear();
                token = _tokens.NextToken();
                if (token.Text == "[")
                {
                    _tokens.NextToken();
                    rule.CSharpTokenKind = ParseCSharpType("TokenKind");
                    MatchOther("]");
                }
                else
                {
                    rule.CSharpTokenKind = CSharpType(rule.Location, ImmutableArray.Create("MetaDslx", "CodeAnalysis", "Syntax", "OtherTokenKind"));
                }
                rule.CSharpTokenKind.Resolve();
                token = _tokens.CurrentToken;
                if (token.Text == "returns")
                {
                    _tokens.NextToken();
                    rule.CSharpReturnType = ParseCSharpType();
                }
                else
                {
                    rule.CSharpReturnType = CSharpType(rule.Location, ImmutableArray<string>.Empty);
                }
                rule.CSharpReturnType.Resolve();
                token = _tokens.CurrentToken;
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
                        reference.RuleName = token.Text;
                        element = reference;
                        _tokens.NextToken();
                    }
                    else if (!negated && token.Text == "=" && nextToken1.Text == ">")
                    {
                        _tokens.EatTokens(2);
                        alt.ReturnValue = ParseConstantExpression();
                        return;
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
            bool isPart = false;
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Keyword)
            {
                isPart = token.Text == "part";
                if (isPart) token = _tokens.NextToken();
            }
            if (token.Kind == MetaCompilerTokenKind.Identifier)
            {
                var rule = new ParserRule(grammar);
                grammar.Rules.Add(rule);
                rule.IsPart = isPart;
                rule.Location = _tokens.CurrentLocation;
                rule.Name = token.Text;
                rule.Annotations.AddRange(_annotations);
                _annotations.Clear();
                token = _tokens.NextToken();
                if (token.Text == "returns")
                {
                    if (isPart)
                    {
                        Error("Rule parts cannot have return types.");
                    }
                    _tokens.NextToken();
                    rule.CSharpReturnType = ParseCSharpType();
                }
                else 
                {
                    if (isPart)
                    {
                        rule.CSharpReturnType = CSharpType(rule.Location, ImmutableArray<string>.Empty);
                    }
                    else
                    {
                        rule.CSharpReturnType = CSharpType(rule.Location, ImmutableArray.Create(rule.Name));
                    }
                }
                rule.CSharpReturnType.Resolve();
                token = _tokens.CurrentToken;
                if (token.Text == ":")
                {
                    ParseParserRuleAlternatives(rule, rule.Alternatives, end: ";");
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

        private void ParseParserRuleAlternatives(IParserRuleAlternativeParent parent, List<ParserRuleAlternative> alternatives, string end)
        {
            _tokens.NextToken();
            while (true)
            {
                var alt = new ParserRuleAlternative(parent);
                alternatives.Add(alt);
                ParseParserRuleAlternative(alt, end);
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

        private void ParseParserRuleAlternative(ParserRuleAlternative alt, string end)
        {
            var token = _tokens.CurrentToken;
            if (token.Text == "{")
            {
                _tokens.NextToken();
                ParseAnnotations();
                alt.Location = _tokens.CurrentLocation;
                alt.CSharpReturnType = ParseCSharpType();
                alt.Name = alt.CSharpReturnType?.Type?.Name;
                token = _tokens.CurrentToken;
                if (token.Text == "}")
                {
                    _tokens.NextToken();
                }
                else
                {
                    Expected("}");
                }
                alt.Annotations.AddRange(_annotations);
                _annotations.Clear();
            }
            while (!_tokens.EndOfFile && token.Text != end && token.Text != "|")
            {
                ParseAnnotations();
                token = _tokens.CurrentToken;
                string? propertyName = null;
                Location? propertyLocation = null;
                var propertyAssignment = AssignmentOperator.Assign;
                var propertyAnnotations = new List<Annotation>();
                var negated = false;
                var nextToken1 = _tokens.PeekToken(1);
                var nextToken2 = _tokens.PeekToken(2);
                if (nextToken2.Position > nextToken1.Position + nextToken1.Text.Length) nextToken2 = MetaCompilerToken.None;
                if (token.Kind == MetaCompilerTokenKind.Identifier && ((nextToken1.Text == "=" && nextToken2.Text != ">") || ((nextToken1.Text == "?" || nextToken1.Text == "!" || nextToken1.Text == "+") && nextToken2.Text == "=")))
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
                    element = ParseParserRuleBlockElement(alt);
                }
                else
                {
                    nextToken1 = _tokens.PeekToken(1);
                    if (token.Text == ".")
                    {
                        element = new ParserRuleWildcardElement(alt);
                        _tokens.NextToken();
                    }
                    else if (token.Text == "#")
                    {
                        var reference = new ParserRuleReferenceElement(alt);
                        reference.Location = _tokens.CurrentLocation;
                        reference.RuleName = default;
                        element = reference;
                        token = _tokens.NextToken();
                        if (token.Text == "{")
                        {
                            token = _tokens.NextToken();
                            var builder = ArrayBuilder<CSharpTypeInfo>.GetInstance();
                            var expectType = true;
                            while (!_tokens.EndOfFile && token.Text != end)
                            {
                                var position = _tokens.Position;
                                if (expectType)
                                {
                                    builder.Add(ParseCSharpType());
                                    expectType = false;
                                }
                                token = _tokens.CurrentToken;
                                if (!expectType)
                                {
                                    if (token.Text == ",")
                                    {
                                        _tokens.NextToken();
                                        expectType = true;
                                    }
                                    else if (token.Text == "|")
                                    {
                                        break;
                                    }
                                }
                                if (_tokens.Position == position) break;
                                token = _tokens.CurrentToken;
                            }
                            reference.ReferencedCSharpTypes = builder.ToImmutableAndFree();
                            if (token.Text == "|")
                            {
                                token = _tokens.NextToken();
                                if (token.Kind == MetaCompilerTokenKind.Identifier)
                                {
                                    reference.RuleName = token.Text;
                                    _tokens.NextToken();
                                }
                                else
                                {
                                    Error("Identifier expected.");
                                }
                            }
                            MatchOther("}");
                        }
                        else
                        {
                            reference.ReferencedCSharpTypes = ImmutableArray.Create(ParseCSharpType());
                        }
                    }
                    else if (token.Kind == MetaCompilerTokenKind.String || token.Kind == MetaCompilerTokenKind.VerbatimString || token.Kind == MetaCompilerTokenKind.Character)
                    {
                        var str = new ParserRuleFixedStringElement(alt);
                        str.ValueText = token.Text;
                        element = str;
                        _tokens.NextToken();
                    }
                    else if (token.Kind == MetaCompilerTokenKind.Keyword && token.Text == "eof")
                    {
                        element = new ParserRuleEofElement(alt);
                        _tokens.NextToken();
                    }
                    else if (token.Kind == MetaCompilerTokenKind.Identifier)
                    {
                        var reference = new ParserRuleReferenceElement(alt);
                        reference.Location = _tokens.CurrentLocation;
                        reference.RuleName = token.Text;
                        element = reference;
                        _tokens.NextToken();
                    }
                    else if (!negated && token.Text == "=" && nextToken1.Text == ">")
                    {
                        _tokens.EatTokens(2);
                        alt.ReturnValue = ParseConstantExpression();
                        return;
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
                element.ModelPropertyName = propertyName.ToPascalCase();
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

        private ParserRuleElement ParseParserRuleBlockElement(ParserRuleAlternative alt)
        {
            var block = new ParserRuleBlockElement(alt);
            ParseParserRuleAlternatives(block, block.Alternatives, end: ")");
            var token = _tokens.CurrentToken;
            if (token.Text == ")") _tokens.NextToken();
            return block;
        }

        private CSharpTypeInfo ParseCSharpType(params string[] suffixes)
        {
            var location = _tokens.CurrentLocation;
            var qualifier = ParseCSharpTypeQualifier(".");
            return CSharpType(location, qualifier, suffixes);
        }

        private ImmutableArray<string> ParseCSharpTypeQualifier(string separator)
        {
            if (TryParseCSharpTypeQualifier(separator, true, out var result)) return result;
            else return ImmutableArray<string>.Empty;
        }

        private bool TryParseCSharpTypeQualifier(string separator, bool addDiagnostics, out ImmutableArray<string> qualifier)
        {
            var token = _tokens.CurrentToken;
            if (token.Kind == MetaCompilerTokenKind.Keyword && MetaCompilerLexer.TypeKeywords.Contains(token.Text))
            {
                _tokens.NextToken();
                qualifier = ImmutableArray.Create(token.Text);
                return true;
            }

            return TryParseQualifier(separator, addDiagnostics, out qualifier);
        }

        private ImmutableArray<string> ParseQualifier(string separator)
        {
            if (TryParseQualifier(separator, true, out var qualifier)) return qualifier;
            else return ImmutableArray<string>.Empty;
        }

        private bool TryParseQualifier(string separator, bool addDiagnostics, out ImmutableArray<string> qualifier)
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
                        if (addDiagnostics) Error("Identifier expected");
                        qualifier = result.ToImmutableAndFree();
                        return false;
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
                            if (_tokens.PeekToken(i).Text != separator[i].ToString())
                            {
                                qualifier = result.ToImmutableAndFree();
                                return true;
                            }
                        }
                        _tokens.EatTokens(separator.Length);
                        idExpected = true;
                        continue;
                    }
                    qualifier = result.ToImmutableAndFree();
                    return true;
                }
            }
            qualifier = result.ToImmutableAndFree();
            return qualifier.Length > 0;
        }

        private Expression ParseConstantExpression()
        {
            var result = new Expression();
            result.Location = _tokens.CurrentLocation;
            if (TryParseCSharpTypeQualifier(".", false, out var qualifier))
            {
                result.Qualifier = qualifier;
                result.ValueText = string.Join(".", qualifier);
                result.Type = typeof(object);
            }
            else
            {
                var token = _tokens.CurrentToken;
                if (token.Kind == MetaCompilerTokenKind.Keyword && (token.Text == "true" || token.Text == "false"))
                {
                    result.ValueText = token.Text;
                    result.Value = token.Text == "true";
                    result.Type = typeof(bool);
                    result.CSharpType = CSharpType(_tokens.CurrentLocation, ImmutableArray.Create("bool"));
                    _tokens.NextToken();
                }
                else if (token.Kind == MetaCompilerTokenKind.Number)
                {
                    result.ValueText = token.Text;
                    if (token.Text.Contains("."))
                    {
                        result.Type = typeof(double);
                        result.CSharpType = CSharpType(_tokens.CurrentLocation, ImmutableArray.Create("double"));
                        if (double.TryParse(token.Text, out var doubleValue))
                        {
                            result.Value = doubleValue;
                        }
                        else
                        {
                            Error("Invalid double value.");
                        }
                    }
                    else
                    {
                        result.Type = typeof(int);
                        result.CSharpType = CSharpType(_tokens.CurrentLocation, ImmutableArray.Create("int"));
                        if (int.TryParse(token.Text, out var intValue))
                        {
                            result.Value = intValue;
                        }
                        else
                        {
                            Error("Invalid integer value.");
                        }
                    }
                    _tokens.NextToken();
                }
                else if (token.Kind == MetaCompilerTokenKind.Character)
                {
                    result.ValueText = token.Text;
                    result.Type = typeof(char);
                    result.Value = StringUtilities.DecodeChar(token.Text);
                    result.CSharpType = CSharpType(_tokens.CurrentLocation, ImmutableArray.Create("char"));
                    _tokens.NextToken();
                }
                else if (token.Kind == MetaCompilerTokenKind.String || token.Kind == MetaCompilerTokenKind.VerbatimString)
                {
                    result.ValueText = token.Text;
                    result.Type = typeof(string);
                    result.Value = StringUtilities.DecodeString(token.Text);
                    result.CSharpType = CSharpType(_tokens.CurrentLocation, ImmutableArray.Create("string"));
                    _tokens.NextToken();
                }
                else
                {
                    Unexpected();
                }
            }
            return result;
        }

        private (ImmutableArray<string> Values, bool IsArray) MatchAnnotationExpressionsUntil(params string[] untilOther)
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            int parenthesisCounter = 0;
            int bracketsCounter = 0;
            int bracesCounter = 0;
            try
            {
                var items = ArrayBuilder<string>.GetInstance();
                _tokens.IgnoreWhitespaceAndComments = false;
                var token = _tokens.CurrentToken;
                var isArray = token.Text == "{";
                while (!_tokens.EndOfFile && (parenthesisCounter > 0 || bracketsCounter > 0 || bracesCounter > 0 || !untilOther.Contains(token.Text)))
                {
                    if (token.Text == "(") ++parenthesisCounter;
                    if (token.Text == ")") --parenthesisCounter;
                    if (token.Text == "[") ++bracketsCounter;
                    if (token.Text == "]") --bracketsCounter;
                    if (token.Text == "{") ++bracesCounter;
                    if (token.Text == "}") --bracesCounter;
                    if (isArray && parenthesisCounter == 0 && bracketsCounter == 0)
                    {
                        if (bracesCounter == 1)
                        {
                            if (token.Text == ",")
                            {
                                items.Add(sb.ToString().Trim());
                                sb.Clear();
                            }
                            else if (token.Text != "{")
                            {
                                sb.Append(token.Text);
                            }
                        }
                        else if (bracesCounter == 0 && token.Text == "}")
                        {
                            items.Add(sb.ToString().Trim());
                            sb.Clear();
                            break;
                        }
                        else 
                        {
                            sb.Append(token.Text);
                        }
                    }
                    else
                    {
                        sb.Append(token.Text);
                    }
                    token = _tokens.NextToken();
                }
                if (!isArray)
                {
                    var valueText = sb.ToString().Trim();
                    if (!string.IsNullOrEmpty(valueText))
                    {
                        items.Add(valueText);
                    }
                }
                return (items.ToImmutableAndFree(), isArray);
            }
            finally
            {
                _tokens.IgnoreWhitespaceAndComments = true;
                builder.Free();
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

        private void Error(Location? location, string message)
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

        private CSharpTypeInfo CSharpType(Location location, ImmutableArray<string> qualifier, params string[] suffixes)
        {
            if (_typeCache.TryGetValue(qualifier, out var result)) return result;
            var typeSymbol = qualifier.Length > 0 ? _language.ResolveSymbols(location, true, "type", qualifier, suffixes).OfType<ITypeSymbol>().FirstOrDefault() : null;
            result = new CSharpTypeInfo(_language, typeSymbol);
            _typeCache.Add(qualifier, result);
            return result;
        }

        private bool TryGetCSharpSymbol(Location location, ImmutableArray<string> qualifier, out ISymbol? symbol)
        {
            var candidates = _language.ResolveSymbols(location, false, "name", qualifier);
            if (candidates.Length == 1)
            {
                symbol = candidates[0];
                return true;
            }
            else
            {
                symbol = candidates.FirstOrDefault();
                return false;
            }
        }

        private CSharpPropertyInfo CSharpProperty(CSharpTypeInfo modelObjectType, string propertyName)
        {
            var propertySymbol = GetAllMembers<IPropertySymbol>(modelObjectType?.CoreType, propertyName).FirstOrDefault();
            var propertyType = propertySymbol?.Type;
            return new CSharpPropertyInfo(modelObjectType, propertyName, propertyType, propertySymbol?.SetMethod != null);
        }

        private ImmutableArray<TSymbol> GetAllMembers<TSymbol>(ITypeSymbol? symbol, string? memberName)
            where TSymbol : ISymbol
        {
            if (symbol is null || string.IsNullOrEmpty(memberName)) return ImmutableArray<TSymbol>.Empty;
            var builder = ArrayBuilder<TSymbol>.GetInstance();
            var type = symbol;
            while (type is not null)
            {
                builder.AddRange(type.GetMembers(memberName).OfType<TSymbol>());
                if (builder.Count > 0) break;
                type = type.BaseType;
            }
            if (builder.Count == 0)
            {
                foreach (var baseType in symbol.AllInterfaces)
                {
                    builder.AddRange(baseType.GetMembers(memberName).OfType<TSymbol>());
                    if (builder.Count > 0) break;
                }
            }
            return builder.ToImmutableAndFree();
        }

        private void CheckType(CSharpTypeInfo expectedType, Expression expr, Location location)
        {
            if (expectedType?.Type is not null && expr?.CSharpType?.Type is not null)
            {
                var conversion = _compilation.ClassifyConversion(expr.CSharpType.CoreType, expectedType.CoreType);
                if (!conversion.IsImplicit)
                {
                    Error(location, $"Value '{expr.ValueText}' of type '{expr.CSharpType.CoreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' cannot be assigned to '{expectedType.CoreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
                }
            }
        }

        private void CheckType(CSharpPropertyInfo property, CSharpTypeInfo valueType, Location location)
        {
            if (property?.PropertyType?.Type is not null && valueType?.Type is not null)
            {
                var propertyTypeName = property.PropertyType.Type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                var valueTypeName = valueType.CoreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (propertyTypeName == "MetaDslx.CodeAnalysis.MetaType")
                {
                    if (valueType.IsTypeSymbol || valueType.IsModelObject ||
                        valueTypeName == "System.Type" || valueTypeName == "MetaDslx.CodeAnalysis.MetaType" || 
                        valueTypeName == "string" || valueTypeName == "System.String") return;
                }
                if (propertyTypeName == "MetaDslx.CodeAnalysis.MetaSymbol")
                {
                    if (valueType.IsSymbol || valueType.IsModelObject ||
                        valueTypeName == "MetaDslx.CodeAnalysis.MetaSymbol") return;
                }
                var conversion = _compilation.ClassifyConversion(valueType.CoreType, property.PropertyType.CoreType);
                if (!conversion.IsImplicit)
                {
                    Error(location, $"Value of type '{valueTypeName}' cannot be assigned to property '{property.ModelObjectType?.CoreType?.Name}.{property.PropertyName}' of type '{propertyTypeName}'.");
                }
            }
        }

        private void CheckType(CSharpTypeInfo expectedType, CSharpTypeInfo actualType, string expression, Location location)
        {
            if (expectedType?.Type is not null && actualType?.Type is not null)
            {
                var conversion = _compilation.ClassifyConversion(actualType.CoreType, expectedType.CoreType);
                if (!conversion.IsImplicit)
                {
                    Error(location, $"'{expression}' of type '{actualType.CoreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' cannot be assigned to '{expectedType.CoreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
                }
            }
        }

    }
}
