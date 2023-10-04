﻿using MetaDslx.CodeAnalysis;
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
            ParseNamespace();
            ParseUsings();
            ParseLanguageDeclaration();
            ParseGrammar();
            ResolveDefaults();
            ResolveRules();
            var ruleNames = new HashSet<string>();
            ResolveProperties();
            ResolveBlocks(ruleNames);
            ResolveAlternatives(ruleNames);
            ResolveLists();
            ResolveNames();
            _language.Grammar.MainRule = _language.Grammar.ParserRules.FirstOrDefault();
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
                if (rules[i] is ParserRule targetRule && targetRule.ReferencedBy.Count == 1)
                {
                    var sourceAlt = targetRule.ReferencedBy[0];
                    if (sourceAlt.Parent is ParserRule sourceRule && sourceAlt.Elements.Count == 1 && sourceAlt.Elements[0].Multiplicity == Multiplicity.ExactlyOne)
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
                    var tokens = targetRule.Alternatives.Where(alt => alt.Elements.Count == 1 && alt.Elements[0] is ParserRuleFixedStringElement).Select(alt => (ParserRuleFixedStringElement)alt.Elements[0]).ToList();
                    if (tokens.Count >= 2)
                    {
                        if (tokens.Count == targetRule.Alternatives.Count)
                        {
                            foreach (var sourceAlt in targetRule.ReferencedBy)
                            {
                                for (int j = 0; j < sourceAlt.Elements.Count; j++)
                                {
                                    var sourceElement = sourceAlt.Elements[j] as ParserRuleReferenceElement;
                                    if (sourceElement is not null && sourceElement.Rule == targetRule)
                                    {
                                        sourceAlt.Elements[j] = MakeFixedStringAlternativesElement(targetRule, sourceAlt, sourceElement, tokens);
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
                            foreach (var token in tokens)
                            {
                                token.Annotations.InsertRange(0, token.ParserRuleAlternative.Annotations);
                                targetRule.Alternatives.Remove(token.ParserRuleAlternative);
                            }
                            var tokensElement = MakeFixedStringAlternativesElement(null, tokensAlt, null, tokens);
                            tokensElement.Name = "tokens";
                            tokensAlt.Elements.Add(tokensElement);
                            targetRule.Alternatives.Add(tokensAlt);
                        }
                    }

                }
            }
        }

        private ParserRuleFixedStringAlternativesElement MakeFixedStringAlternativesElement(ParserRule? targetRule, ParserRuleAlternative sourceAlternative, ParserRuleElement? sourceElement, List<ParserRuleFixedStringElement> tokens)
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
            foreach (var token in tokens)
            {
                var alt = new ParserRuleFixedStringElement(sourceAlternative);
                alt.Annotations.AddRange(token.Annotations);
                alt.Name = token.Name;
                alt.ModelPropertyName = token.ModelPropertyName;
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
                    ResolveProperties(alt, alt.CSharpReturnType?.CoreType != null ? alt.CSharpReturnType : modelObjectType, ruleStack);
                }
            }
            finally
            {
                ruleStack.RemoveAt(ruleStack.Count - 1);
            }
        }

        private void ResolveProperties(ParserRuleAlternative alternative, CSharpTypeInfo modelObjectType, List<ParserRule> ruleStack)
        {
            foreach (var elem in alternative.Elements)
            {
                var prop = CSharpProperty(modelObjectType, elem.ModelPropertyName);
                elem.CSharpModelProperty = prop;
                if (!string.IsNullOrEmpty(elem.ModelPropertyName) && modelObjectType?.CoreType is not null && elem.CSharpModelProperty?.PropertyType?.CoreType is null)
                {
                    Error(elem.Location, $"Could not find property '{modelObjectType.CoreType.Name}.{elem.ModelPropertyName}'.");
                }
                if (elem.CSharpModelProperty?.PropertyType?.CoreType is not null && !elem.CSharpModelProperty.IsWritable)
                {
                    Error(elem.Location, $"Cannot assign value to property '{modelObjectType.CoreType.Name}.{elem.ModelPropertyName}', because is read only.");
                }
                var expr = alternative.ReturnValue;
                if (expr is not null)
                {
                    var expectedType = prop.PropertyType?.CoreType != null ? prop.PropertyType : modelObjectType;
                    if (expr.Type == typeof(object))
                    {
                        if (expectedType.ItemTypeKind.HasFlag(ItemTypeKind.EnumType) && expr.Qualifier.Length == 1)
                        {
                            expr.Value = expectedType.CoreType.GetMembers(expr.Qualifier[0]).FirstOrDefault();
                            expr.CSharpType = new CSharpTypeInfo(_language, expectedType.CoreType);
                        }
                        if (expr.Value is null && TryGetCSharpSymbol(elem.Location, expr.Qualifier, out var symbol))
                        {
                            expr.Value = symbol;
                            expr.CSharpType = new CSharpTypeInfo(_language, expectedType.CoreType);
                        }
                        if (expr.Value is null)
                        {
                            Error(expr.Location, $"Could not resolve '{expr.ValueText}'.");
                        }
                    }
                    CheckType(expectedType, expr, expr.Location);
                }
                ResolveProperties(elem, modelObjectType, ruleStack);
            }
        }

        private void ResolveProperties(ParserRuleElement elem, CSharpTypeInfo modelObjectType, List<ParserRule> ruleStack)
        {
            if (elem is ParserRuleReferenceElement refElem)
            {
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
            else if (elem is ParserRuleFixedStringAlternativesElement fixedAlts)
            {
                foreach (var alt in fixedAlts.Alternatives)
                {
                    ResolveProperties(alt, modelObjectType, ruleStack);
                }
            }
            else if (elem is ParserRuleListElement listElem)
            {
                ResolveProperties(listElem.RepeatedRule, modelObjectType, ruleStack);
                if (listElem.FirstItem is not null) ResolveProperties(listElem.FirstItem, modelObjectType, ruleStack);
                if (listElem.LastItem is not null) ResolveProperties(listElem.LastItem, modelObjectType, ruleStack);
                if (listElem.LastSeparator is not null) ResolveProperties(listElem.LastSeparator, modelObjectType, ruleStack);
            }
            else if (elem is ParserRuleBlockElement blockElem)
            {
                blockElem.CSharpReturnType = elem.CSharpModelProperty.PropertyType;
                foreach (var blockAlt in blockElem.Alternatives)
                {
                    ResolveProperties(blockAlt, blockElem.CSharpReturnType?.CoreType != null ? blockElem.CSharpReturnType : modelObjectType, ruleStack);
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
                    rule.CSharpReturnType = CSharpType(rule.Location, ImmutableArray.Create("string"));
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
            builder.AddRange(symbol.GetMembers(memberName).OfType<TSymbol>());
            foreach (var baseType in symbol.AllInterfaces)
            {
                if (builder.Count > 0) break;
                builder.AddRange(baseType.GetMembers(memberName).OfType<TSymbol>());
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
                var conversion = _compilation.ClassifyConversion(valueType.CoreType, property.PropertyType.CoreType);
                if (!conversion.IsImplicit)
                {
                    Error(location, $"Value of type '{valueType.CoreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' cannot be assigned to property '{property.ModelObjectType?.CoreType?.Name}.{property.PropertyName}' of type '{property.PropertyType.CoreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
                }
            }
        }
    }
}
