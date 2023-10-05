using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.Languages.MetaCompiler.Model
{
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
    using SpecialType = Microsoft.CodeAnalysis.SpecialType;

    public class Language : IElementWithLocation
    {
        private readonly CSharpCompilation _compilation;

        public Language(CSharpCompilation compilation)
        {
            this.Diagnostics = new DiagnosticBag();
            _compilation = compilation;

        }

        public CSharpCompilation Compilation => _compilation;
        public ImmutableArray<string> Namespace { get; set; }
        public string QualifiedNamespace => string.Join(".", Namespace);
        public List<Using> Usings { get; } = new List<Using>();
        public string Name { get; set; }
        public Location Location { get; set; }
        public Grammar Grammar { get; set; }
        public DiagnosticBag Diagnostics { get; }

        public ImmutableArray<ISymbol> ResolveSymbols(Location location, bool addDiagnostics, string? diagnosticName, ImmutableArray<string> qualifiedName, params string[] suffixes)
        {
            if (qualifiedName.IsDefaultOrEmpty) return ImmutableArray<ISymbol>.Empty;
            if (qualifiedName.Length == 1)
            {
                ISymbol? result = null;
                switch (qualifiedName[0])
                {
                    case "bool": result = _compilation.GetSpecialType(SpecialType.System_Boolean); break;
                    case "string": result = _compilation.GetSpecialType(SpecialType.System_String); break;
                    case "char": result = _compilation.GetSpecialType(SpecialType.System_Char); break;
                    case "byte": result = _compilation.GetSpecialType(SpecialType.System_Byte); break;
                    case "sbyte": result = _compilation.GetSpecialType(SpecialType.System_SByte); break;
                    case "short": result = _compilation.GetSpecialType(SpecialType.System_Int16); break;
                    case "ushort": result = _compilation.GetSpecialType(SpecialType.System_UInt16); break;
                    case "int": result = _compilation.GetSpecialType(SpecialType.System_Int32); break;
                    case "uint": result = _compilation.GetSpecialType(SpecialType.System_UInt32); break;
                    case "long": result = _compilation.GetSpecialType(SpecialType.System_Int64); break;
                    case "ulong": result = _compilation.GetSpecialType(SpecialType.System_UInt64); break;
                    case "float": result = _compilation.GetSpecialType(SpecialType.System_Single); break;
                    case "double": result = _compilation.GetSpecialType(SpecialType.System_Double); break;
                    case "decimal": result = _compilation.GetSpecialType(SpecialType.System_Decimal); break;
                    default:
                        break;
                }
                if (result is not null) return ImmutableArray.Create(result);
            }
            var candidates = ArrayBuilder<ISymbol>.GetInstance();
            ResolveSymbols(location, addDiagnostics, diagnosticName, qualifiedName, suffixes, null, _compilation.GlobalNamespace, candidates);
            foreach (var use in this.Usings)
            {
                ResolveSymbols(location, addDiagnostics, diagnosticName, qualifiedName, suffixes, use.Alias, use.CSharpSymbol, candidates);
            }
            if (addDiagnostics)
            {
                if (candidates.Count == 0)
                {
                    if (suffixes.Length == 0)
                    {
                        Error(location, $"The {diagnosticName} '{string.Join(".", qualifiedName)}' could not be found (are you missing a using directive or an assembly reference?).");
                    }
                    else
                    {
                        foreach (var suffix in suffixes)
                        {
                            Error(location, $"The {diagnosticName} '{string.Join(".", qualifiedName)}{suffix}' could not be found (are you missing a using directive or an assembly reference?).");
                        }
                    }
                }
                else if (candidates.Count >= 2)
                {
                    Error(location, $"'{string.Join(".", qualifiedName)}' is an ambiguous reference between '{candidates[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{candidates[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
                }
            }
            return candidates.ToImmutableAndFree();
        }

        private void ResolveSymbols(Location location, bool addDiagnostics, string? diagnosticName, ImmutableArray<string> qualifiedName, string[] suffixes, string? alias, INamespaceOrTypeSymbol? container, ArrayBuilder<ISymbol> candidates)
        {
            if (container is not null)
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                try
                {
                    var startIndex = 0;
                    if (!string.IsNullOrEmpty(alias))
                    {
                        if (qualifiedName[0] == alias)
                        {
                            if (qualifiedName.Length == 1)
                            {
                                candidates.Add(container);
                                return;
                            }
                            else
                            {
                                startIndex = 1;
                                sb.Append(qualifiedName[0]);
                            }
                        }
                        else
                        {
                            return;
                        }
                    }
                    var csharpSymbol = container;
                    for (int i = startIndex; i < qualifiedName.Length; ++i)
                    {
                        var name = qualifiedName[i];
                        if (sb.Length > 0) sb.Append(".");
                        if (i + 1 < qualifiedName.Length)
                        {
                            csharpSymbol = csharpSymbol.GetMembers().Where(ns => ns.Name == name).OfType<INamespaceOrTypeSymbol>().FirstOrDefault();
                            if (csharpSymbol is null)
                            {
                                return;
                            }
                        }
                        else
                        {
                            if (suffixes.Length == 0)
                            {
                                candidates.AddRange(csharpSymbol.GetMembers($"{name}"));
                            }
                            else
                            {
                                foreach (var suffix in suffixes)
                                {
                                    candidates.AddRange(csharpSymbol.GetMembers($"{name}{suffix}"));
                                }
                            }
                        }
                        sb.Append(name);
                    }
                }
                finally
                {
                    builder.Free();
                }
            }
        }

        public void ResolveAnnotations()
        {
            var grammar = this.Grammar;
            foreach (var rule in grammar.LexerRules)
            {
                ResolveAnnotations(rule.Annotations);
            }
            foreach (var rule in grammar.ParserRules)
            {
                ResolveAnnotations(rule.Annotations);
                foreach (var alt in rule.Alternatives)
                {
                    ResolveAnnotations(alt.Annotations);
                    foreach (var elem in alt.Elements)
                    {
                        ResolveAnnotations(elem.NameAnnotations);
                        ResolveAnnotations(elem.Annotations);
                        if (elem is ParserRuleFixedStringAlternativesElement fixedAltsElement)
                        {
                            foreach (var fixedAlt in fixedAltsElement.Alternatives)
                            {
                                ResolveAnnotations(fixedAlt.NameAnnotations);
                                ResolveAnnotations(fixedAlt.Annotations);
                            }
                        }
                        if (elem is ParserRuleListElement listElement)
                        {
                            foreach (var listElem in listElement.AllElements)
                            {
                                ResolveAnnotations(listElem.NameAnnotations);
                                ResolveAnnotations(listElem.Annotations);
                            }
                        }
                    }
                }
            }
            ResolveAnnotationContainment();
        }

        private void ResolveAnnotations(IEnumerable<Annotation> annotations)
        {
            foreach (var annotation in annotations)
            {
                annotation.Resolve();
            }
        }

        private void ResolveAnnotationContainment()
        {
            foreach (var rule in Grammar.Rules)
            {
                if (rule.Annotations.Any(a => a.Kind == AnnotationKind.Annotation)) rule.ContainsAnnotations = true;
                if (rule.Annotations.Any(a => a.Kind == AnnotationKind.Binder)) rule.ContainsBinders = true;
            }
            foreach (var rule in Grammar.ParserRules)
            {
                foreach (var alt in rule.Alternatives)
                {
                    if (alt.Annotations.Any(a => a.Kind == AnnotationKind.Annotation))
                    {
                        alt.ContainsAnnotations = true;
                        rule.ContainsAnnotations = true;
                    }
                    if (alt.Annotations.Any(a => a.Kind == AnnotationKind.Binder))
                    {
                        alt.ContainsBinders = true;
                        rule.ContainsBinders = true;
                    }
                }
            }
            bool updated = true;
            while (updated)
            {
                updated = false;
                foreach (var rule in Grammar.ParserRules)
                {
                    foreach (var alt in rule.Alternatives)
                    {
                        foreach (var elem in alt.Elements)
                        {
                            bool containsAnnotations = elem.ContainsAnnotations;
                            bool containsBinders = elem.ContainsBinders;
                            if (CheckAnnotationContainment(elem, ref containsAnnotations, ref containsBinders)) updated = true;
                            if (containsAnnotations)
                            {
                                alt.ContainsAnnotations = true;
                                rule.ContainsAnnotations = true;
                            }
                            if (containsBinders)
                            {
                                alt.ContainsBinders = true;
                                rule.ContainsBinders = true;
                            }
                        }
                    }
                }
            }
        }

        private bool CheckAnnotationContainment(ParserRuleElement? elem, ref bool containsAnnotations, ref bool containsBinders)
        {
            if (elem is null) return false;
            bool result = false;
            if (elem.Annotations.Any(a => a.Kind == AnnotationKind.Annotation)) containsAnnotations = true;
            if (elem.Annotations.Any(a => a.Kind == AnnotationKind.Binder)) containsBinders = true;
            if (elem is ParserRuleReferenceElement refElem)
            {
                if (refElem.Rule?.ContainsAnnotations ?? false) containsAnnotations = true;
                if (refElem.Rule?.ContainsBinders ?? false) containsBinders = true;
            }
            else if (elem is ParserRuleFixedStringAlternativesElement fixedAltsElem)
            {
                foreach (var fixedAlt in fixedAltsElem.Alternatives)
                {
                    if (CheckAnnotationContainment(fixedAlt, ref containsAnnotations, ref containsBinders)) result = true;
                }
            }
            else if (elem is ParserRuleListElement listElem)
            {
                if (CheckAnnotationContainment(listElem.FirstItem, ref containsAnnotations, ref containsBinders)) result = true;
                if (CheckAnnotationContainment(listElem.RepeatedRule, ref containsAnnotations, ref containsBinders)) result = true;
                if (CheckAnnotationContainment(listElem.RepeatedItem, ref containsAnnotations, ref containsBinders)) result = true;
                if (CheckAnnotationContainment(listElem.RepeatedSeparator, ref containsAnnotations, ref containsBinders)) result = true;
                if (CheckAnnotationContainment(listElem.LastItem, ref containsAnnotations, ref containsBinders)) result = true;
                if (CheckAnnotationContainment(listElem.LastSeparator, ref containsAnnotations, ref containsBinders)) result = true;
            }
            if (!elem.ContainsAnnotations && containsAnnotations)
            {
                elem.ContainsAnnotations = true;
                result = true;
            }
            if (!elem.ContainsBinders && containsBinders)
            {
                elem.ContainsBinders = true;
                result = true;
            }
            return result;
        }

        public void Error(Location location, string message)
        {
            Diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, location, message));
        }
    }
}
