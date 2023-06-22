using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Annotations;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Syntax
{
    using MetaDslx.CodeAnalysis.PooledObjects;
    using MetaDslx.Languages.MetaCompiler.Model;
    using Roslyn.Utilities;
    using System.Data;
    using System.Linq;
    using System.Xml.Linq;
    using AnnotationTargets = Annotations.AnnotationTargets;
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
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

        public MetaCompilerParser(CSharpCompilation compilation, string filePath, SourceText compilerCode)
        {
            _compilation = compilation;
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
            var ruleNames = new HashSet<string>();
            ResolveBlocks(language, ruleNames);
            ResolveAlternatives(language, ruleNames);
            ResolveLists(language);
            ResolveNames(language);
            ResolveAnnotations(language);
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
                    else if (refElem.Rule is ParserRule parserRule)
                    {
                        parserRule.ReferencedBy.Add(alt);
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
                        lexerRule = new LexerRule(language.Grammar) { Location = fixedStringElem.Location };
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

        private void ResolveBlocks(Language language, HashSet<string> ruleNames)
        {
            var rules = language.Grammar.Rules;
            ruleNames.UnionWith(rules.OfType<ParserRule>().Select(r => r.Name));
            for (int i = 0; i < rules.Count; ++i)
            {
                if (rules[i] is ParserRule pr)
                {
                    ResolveBlocks(language, pr.Name, pr.Alternatives, ruleNames);
                }
            }
        }

        private void ResolveBlocks(Language language, string parentName, List<ParserRuleAlternative> alternatives, HashSet<string> usedNames)
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
                    if (string.IsNullOrEmpty(alt.Name))
                    {
                        var index = 0;
                        var altName = $"{parentName}Alt{++index}";
                        while (usedNames.Contains(altName)) altName = $"{parentName}Alt{++index}";
                        alt.Name = altName;
                        usedNames.Add(alt.Name);
                    }
                }
            }
            foreach (var alt in alternatives)
            {
                for (int i = 0; i < alt.Elements.Count; ++i)
                {
                    var blockElem = alt.Elements[i] as ParserRuleBlockElement;
                    if (blockElem is not null)
                    {
                        var blockName = string.IsNullOrEmpty(blockElem.Name) ? "Block" : blockElem.Name.ToPascalCase();
                        var index = 0;
                        var ruleName = $"{alt.Name}{blockName}{++index}";
                        while (usedNames.Contains(ruleName)) ruleName = $"{alt.Name}{blockName}{++index}";
                        var rule = new ParserRule(language.Grammar);
                        rule.Name = ruleName;
                        rule.Location = blockElem.Location;
                        rule.Annotations.AddRange(blockElem.Annotations);
                        rule.Alternatives.AddRange(blockElem.Alternatives);
                        language.Grammar.Rules.Add(rule);
                        usedNames.Add(rule.Name);
                        var refElem = new ParserRuleReferenceElement(alt);
                        refElem.Annotations.AddRange(blockElem.NameAnnotations);
                        refElem.Name = blockElem.Name;
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

        private void ResolveAlternatives(Language language, HashSet<string> ruleNames)
        {
            var rules = language.Grammar.Rules;
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
                            if (targetRule.Alternatives.Count == 1 && string.IsNullOrEmpty(targetRule.Alternatives[0].Name))
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

        private void ResolveNames(Language language)
        {
            var usedElementNames = new HashSet<string>();
            foreach (var rule in language.Grammar.ParserRules)
            {
                ResolveElementNames(rule.Alternatives, usedElementNames, true);
            }
        }

        private void ResolveElementNames(List<ParserRuleAlternative> alternatives, HashSet<string> usedElementNames, bool clearUsedElementNames)
        {
            foreach (var alt in alternatives)
            {
                if (clearUsedElementNames) usedElementNames.Clear();
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
            if (string.IsNullOrEmpty(elem.Name))
            {
                var name = $"{elem.DefaultName}";
                var index = 0;
                while (usedElementNames.Contains(name)) name = $"{elem.DefaultName}{++index}";
                elem.Name = name;
                if (elem.IsList) elem.AssignmentOperator = AssignmentOperator.PlusAssign;
            }
            else if (usedElementNames.Contains(elem.Name))
            {
                Error(elem.NameLocation, $"Element name '{elem.Name}' is defined multiple times.");
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

        private void ResolveAnnotations(Language language)
        {
            var grammar = language.Grammar;
            foreach (var use in language.Usings)
            {
                ResolveUsingNamespace(language, use);
            }
            foreach (var rule in grammar.LexerRules)
            {
                ResolveAnnotations(language, AnnotationTargets.LexerRule, rule.Annotations);
            }
            foreach (var rule in grammar.ParserRules)
            {
                ResolveAnnotations(language, AnnotationTargets.ParserRule, rule.Annotations);
            }
            LexerRule? _defaultWhitespace = null;
            LexerRule? _defaultEndOfLine = null;
            LexerRule? _defaultIdentifier = null;
            LexerRule? _defaultSeparator = null;
            foreach (var rule in grammar.LexerRules)
            {
                var isDefault = HasAnnotation(rule.Annotations, "MetaDslx.Languages.MetaCompiler.Annotations.DefaultAnnotation");
                if (isDefault)
                {
                    ResolveDefaultLexerRule(language, ref _defaultWhitespace, rule, "MetaDslx.Languages.MetaCompiler.Annotations.WhitespaceAnnotation");
                    ResolveDefaultLexerRule(language, ref _defaultEndOfLine, rule, "MetaDslx.Languages.MetaCompiler.Annotations.EndOfLineAnnotation");
                    ResolveDefaultLexerRule(language, ref _defaultIdentifier, rule, "MetaDslx.Languages.MetaCompiler.Annotations.IdentifierAnnotation");
                    ResolveDefaultLexerRule(language, ref _defaultSeparator, rule, "MetaDslx.Languages.MetaCompiler.Annotations.SeparatorAnnotation");
                }
            }
            grammar.DefaultWhitespace = _defaultWhitespace;
            grammar.DefaultEndOfLine = _defaultEndOfLine;
            grammar.DefaultIdentifier = _defaultIdentifier;
            grammar.DefaultSeparator = _defaultSeparator;
            if (grammar.DefaultWhitespace is null) Error(language.Location, $"Missing lexer rule with annotations [Default] and [Whitespace].");
            if (grammar.DefaultEndOfLine is null) Error(language.Location, $"Missing lexer rule with annotations [Default] and [EndOfLine].");
            if (grammar.DefaultIdentifier is null) Error(language.Location, $"Missing lexer rule with annotations [Default] and [Identifier].");
            if (grammar.DefaultSeparator is null) Error(language.Location, $"Missing lexer rule with annotations [Default] and [Separator].");
            grammar.MainRule = grammar.ParserRules.FirstOrDefault();
        }

        private INamespaceSymbol? ResolveUsingNamespace(Language language, Using use)
        {
            if (use.Reference.IsDefaultOrEmpty)
            {
                Error(use.ReferenceLocation, "Namespace name is missing.");
                return null;
            }
            var csharpNs = _compilation.GlobalNamespace;
            if (csharpNs is null) return null;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var name in use.Reference)
            {
                if (sb.Length > 0) sb.Append(".");
                csharpNs = csharpNs.GetNamespaceMembers().Where(ns => ns.Name == name).FirstOrDefault();
                if (csharpNs is null) 
                {
                    if (sb.Length > 0) Error(use.ReferenceLocation, $"The namespace '{name}' does not exist in '{sb}' (are you missing an assembly reference?).");
                    else Error(use.ReferenceLocation, $"The namespace name '{name}' could not be found (are you missing an assembly reference?).");
                    break;
                }
                sb.Append(name);
            }
            builder.Free();
            use.CSharpNamespace = csharpNs;
            return csharpNs;
        }

        private void ResolveAnnotations(Language language, AnnotationTargets target, IEnumerable<Annotation> annotations)
        {
            foreach (var annotation in annotations)
            {
                ResolveAnnotation(language, target, annotation);
            }
        }

        private INamedTypeSymbol? ResolveAnnotation(Language language, AnnotationTargets target, Annotation annotation)
        {
            if (annotation.Name.IsDefaultOrEmpty)
            {
                Error(annotation.Location, "Annotation name is missing.");
                return null;
            }
            var candidates = ArrayBuilder<INamedTypeSymbol>.GetInstance();
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var use in language.Usings)
            {
                var csharpNs = use.CSharpNamespace;
                if (csharpNs is not null)
                {
                    sb.Clear();
                    for (int i = 0; i < annotation.Name.Length; ++i)
                    {
                        var name = annotation.Name[i];
                        if (sb.Length > 0) sb.Append(".");
                        if (i + 1 < annotation.Name.Length)
                        {
                            csharpNs = csharpNs.GetNamespaceMembers().Where(ns => ns.Name == name).FirstOrDefault();
                            if (csharpNs is null)
                            {
                                if (sb.Length > 0) Error(annotation.Location, $"The namespace '{name}' does not exist in '{sb}' (are you missing an assembly reference?).");
                                else Error(annotation.Location, $"The namespace name '{name}' could not be found (are you missing an assembly reference?).");
                                break;
                            }
                        }
                        else
                        {
                            var csharpClass = csharpNs.GetTypeMembers($"{name}Annotation").FirstOrDefault();
                            if (IsMetaCompilerAnnotation(csharpClass))
                            {
                                candidates.Add(csharpClass);
                            }
                        }
                        sb.Append(name);
                    }
                }
            }
            builder.Free();
            INamedTypeSymbol? result = null;
            if (candidates.Count == 1)
            {
                result = candidates[0];
                annotation.CSharpClass = result;
                var targets = GetMetaCompilerAnnotationUsage(result);
                if (!targets.HasFlag(target))
                {
                    Error(annotation.Location, $"The annotation '{annotation.QualifiedName}' cannot be applied to a {target}.");
                    result = null;
                }
            }
            else if (candidates.Count == 0)
            {
                Error(annotation.Location, $"The annotation name '{annotation.QualifiedName}' could not be found (are you missing a using directive or an assembly reference?).");
            }
            else
            {
                Error(annotation.Location, $"'{annotation.QualifiedName}' is an ambiguous reference between '{candidates[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{candidates[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
            }
            candidates.Free();
            return result;
        }

        private bool IsMetaCompilerAnnotation(INamedTypeSymbol? csharpClass)
        {
            if (csharpClass is null) return false;
            var baseType = csharpClass;
            while (baseType is not null)
            {
                var baseTypeName = baseType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (baseTypeName == "MetaDslx.Languages.MetaCompiler.Annotations.Annotation") return true;
                baseType = baseType.BaseType;
            }
            return false;
        }

        private AnnotationTargets GetMetaCompilerAnnotationUsage(INamedTypeSymbol? csharpClass)
        {
            if (csharpClass is null) return AnnotationTargets.None;
            foreach (var attr in csharpClass.GetAttributes())
            {
                var attrName = attr.AttributeClass?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (attrName == "MetaDslx.Languages.MetaCompiler.Annotations.AnnotationUsageAttribute")
                {
                    // TODO: Roslyn returns an empty array...
                    if (attr.ConstructorArguments.Length > 0)
                    {
                        var targets = attr.ConstructorArguments[0];
                        return (AnnotationTargets)targets.Value;
                    }
                }
            }
            return AnnotationTargets.LexerRule | AnnotationTargets.ParserRule;
        }

        private void ResolveDefaultLexerRule(Language language, ref LexerRule? lexerRule, LexerRule defaultRule, string annotationName)
        {
            var isMatch = HasAnnotation(defaultRule.Annotations, annotationName);
            if (isMatch)
            {
                if (lexerRule is null)
                {
                    lexerRule = defaultRule;
                }
                else
                {
                    Error(defaultRule.Location, $"There is already another {annotationName} lexer rule called '{lexerRule.Name}' defined in the grammar. There must be exactly one lexer rule with this annotation.");
                }
            }
        }

        private bool HasAnnotation(IEnumerable<Annotation> annotations, string annotationName)
        {
            if (string.IsNullOrEmpty(annotationName)) return false;
            foreach (var annotation in annotations)
            {
                var name = annotation.CSharpClass?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (name == annotationName) return true;
            }
            return false;
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
            language.Grammar = new Grammar(language);
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
                var rule = new LexerRule(grammar);
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
                var rule = new ParserRule(grammar);
                grammar.Rules.Add(rule);
                rule.Location = _tokens.CurrentLocation;
                rule.Name = token.Text;
                rule.Annotations.AddRange(_annotations);
                _annotations.Clear();
                token = _tokens.NextToken();
                if (token.Text == ":")
                {
                    ParseParserRuleAlternatives(rule, rule.Alternatives, ";");
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
                var propertyAssignment = AssignmentOperator.Assign;
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
                    element = ParseParserRuleBlockElement(alt);
                }
                else
                {
                    if (token.Text == ".")
                    {
                        element = new ParserRuleWildcardElement(alt);
                        _tokens.NextToken();
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

        private ParserRuleElement ParseParserRuleBlockElement(ParserRuleAlternative alt)
        {
            var block = new ParserRuleBlockElement(alt);
            ParseParserRuleAlternatives(block, block.Alternatives, ")");
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
