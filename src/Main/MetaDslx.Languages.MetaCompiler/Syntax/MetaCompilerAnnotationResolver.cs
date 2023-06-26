using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaCompiler.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Syntax
{
    using Language = MetaDslx.Languages.MetaCompiler.Model.Language;
    using AnnotationTargets = Annotations.AnnotationTargets;
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;
    using SymbolDisplayFormat = Microsoft.CodeAnalysis.SymbolDisplayFormat;

    internal class MetaCompilerAnnotationResolver
    {
        private readonly CSharpCompilation _compilation;
        private readonly Language _language;
        private readonly DiagnosticBag _diagnostics;

        public MetaCompilerAnnotationResolver(CSharpCompilation compilation, Language language, DiagnosticBag diagnostics)
        {
            _compilation = compilation;
            _language = language;
            _diagnostics = diagnostics;
        }

        public void ResolveAnnotations()
        {
            var grammar = _language.Grammar;
            foreach (var use in _language.Usings)
            {
                ResolveUsingNamespace(use);
            }
            foreach (var rule in grammar.LexerRules)
            {
                ResolveAnnotations(AnnotationTargets.LexerRuleName, rule.Annotations);
            }
            foreach (var rule in grammar.ParserRules)
            {
                ResolveAnnotations(AnnotationTargets.ParserRuleName, rule.Annotations);
                foreach (var alt in rule.Alternatives)
                {
                    ResolveAnnotations(AnnotationTargets.ParserRuleAlternativeName, alt.Annotations);
                    foreach (var elem in alt.Elements)
                    {
                        ResolveAnnotations(AnnotationTargets.ParserRuleElementName, elem.NameAnnotations);
                        ResolveAnnotations(AnnotationTargets.ParserRuleElementValue, elem.Annotations);
                        if (elem is ParserRuleFixedStringAlternativesElement fixedAltsElement)
                        {
                            foreach (var fixedAlt in fixedAltsElement.Alternatives)
                            {
                                ResolveAnnotations(AnnotationTargets.ParserRuleElementName, fixedAlt.NameAnnotations);
                                ResolveAnnotations(AnnotationTargets.ParserRuleElementValue, fixedAlt.Annotations);
                            }
                        }
                        if (elem is ParserRuleListElement listElement)
                        {
                            foreach (var listElem in listElement.AllElements)
                            {
                                ResolveAnnotations(AnnotationTargets.ParserRuleElementName, listElem.NameAnnotations);
                                ResolveAnnotations(AnnotationTargets.ParserRuleElementValue, listElem.Annotations);
                            }
                        }
                    }
                }
            }
        }

        private INamespaceOrTypeSymbol? ResolveUsingNamespace(Using use)
        {
            if (use.Reference.IsDefaultOrEmpty)
            {
                Error(use.ReferenceLocation, "Namespace name is missing.");
                return null;
            }
            INamespaceOrTypeSymbol? csharpSymbol = _compilation.GlobalNamespace;
            if (csharpSymbol is null) return null;
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var name in use.Reference)
            {
                if (sb.Length > 0) sb.Append(".");
                csharpSymbol = csharpSymbol.GetMembers().Where(ns => ns.Name == name).OfType<INamespaceOrTypeSymbol>().FirstOrDefault();
                if (csharpSymbol is null)
                {
                    if (sb.Length > 0) Error(use.ReferenceLocation, $"The type or namespace '{name}' does not exist in '{sb}' (are you missing an assembly reference?).");
                    else Error(use.ReferenceLocation, $"The type or namespace '{name}' could not be found (are you missing an assembly reference?).");
                    break;
                }
                sb.Append(name);
            }
            builder.Free();
            use.CSharpSymbol = csharpSymbol;
            return csharpSymbol;
        }

        private void ResolveAnnotations(AnnotationTargets target, IEnumerable<Annotation> annotations)
        {
            foreach (var annotation in annotations)
            {
                ResolveAnnotation(target, annotation);
            }
        }

        private INamedTypeSymbol? ResolveAnnotation(AnnotationTargets target, Annotation annotation)
        {
            if (annotation.Name.IsDefaultOrEmpty)
            {
                Error(annotation.Location, "Annotation name is missing.");
                return null;
            }
            var candidates = ResolveSymbols(annotation.Location, annotation.Name, "Annotation").OfType<INamedTypeSymbol>().ToImmutableArray();
            foreach (var csharpSymbol in candidates)
            {
                if (!IsMetaCompilerAnnotation(csharpSymbol))
                {
                    Error(annotation.Location, $"Annotation '{csharpSymbol.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' must be a descendant of 'MetaDslx.Languages.MetaCompiler.Annotations.Annotation'.");
                }
            }
            INamedTypeSymbol? result = null;
            if (candidates.Length == 1)
            {
                result = candidates[0];
                var targets = GetMetaCompilerAnnotationUsage(result);
                if (!targets.HasFlag(target))
                {
                    Error(annotation.Location, $"The annotation '{annotation.QualifiedName}' cannot be applied to a {target}.");
                    result = null;
                }
                annotation.CSharpClass = result;
                ResolveAnnotationProperties(annotation);
            }
            else if (candidates.Length == 0)
            {
                Error(annotation.Location, $"The annotation name '{annotation.QualifiedName}' could not be found (are you missing a using directive or an assembly reference?).");
            }
            else
            {
                Error(annotation.Location, $"'{annotation.QualifiedName}' is an ambiguous reference between '{candidates[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{candidates[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
            }
            return result;
        }

        private ImmutableArray<INamespaceOrTypeSymbol> ResolveSymbols(Location location, ImmutableArray<string> qualifiedName, string suffix = default)
        {
            if (qualifiedName.Length == 0) return ImmutableArray<INamespaceOrTypeSymbol>.Empty;
            var candidates = ArrayBuilder<INamespaceOrTypeSymbol>.GetInstance();
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            foreach (var use in _language.Usings)
            {
                sb.Clear();
                var csharpSymbol = use.CSharpSymbol;
                if (csharpSymbol is not null)
                {
                    var startIndex = 0;
                    if (!string.IsNullOrEmpty(use.Alias))
                    {
                        if (qualifiedName[0] == use.Alias)
                        {
                            if (qualifiedName.Length == 1)
                            {
                                candidates.Add(csharpSymbol);
                                continue;
                            }
                            else
                            {
                                startIndex = 1;
                                sb.Append(qualifiedName[0]);
                            }
                        }
                        else
                        {
                            continue;
                        }
                    }
                    for (int i = startIndex; i < qualifiedName.Length; ++i)
                    {
                        var name = qualifiedName[i];
                        if (sb.Length > 0) sb.Append(".");
                        if (i + 1 < qualifiedName.Length)
                        {
                            csharpSymbol = csharpSymbol.GetMembers().Where(ns => ns.Name == name).OfType<INamespaceOrTypeSymbol>().FirstOrDefault();
                            if (csharpSymbol is null)
                            {
                                if (sb.Length > 0) Error(location, $"The type or namespace '{name}' does not exist in '{sb}' (are you missing an assembly reference?).");
                                else Error(location, $"The type or namespace '{name}' could not be found (are you missing an assembly reference?).");
                                break;
                            }
                        }
                        else
                        {
                            candidates.AddRange(csharpSymbol.GetMembers($"{name}{suffix}").OfType<INamespaceOrTypeSymbol>());
                        }
                        sb.Append(name);
                    }
                }
            }
            builder.Free();
            return candidates.ToImmutableAndFree();
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
            return AnnotationTargets.All;
        }

        private void ResolveAnnotationProperties(Annotation annotation)
        {
            if (annotation.CSharpClass is null) return;
            var paramNames = PooledHashSet<string>.GetInstance();
            var csharpClass = annotation.CSharpClass;
            var candidates = ArrayBuilder<IMethodSymbol>.GetInstance();
            var hasDefaultConstructor = csharpClass.Constructors.Length == 0;
            foreach (var ctr in csharpClass.Constructors)
            {
                var positionalIndex = 0;
                var positionalArgs = true;
                var goodCandidate = true;
                if (ctr.Parameters.Length == 0 || ctr.Parameters[0].HasExplicitDefaultValue) hasDefaultConstructor = true;
                foreach (var param in ctr.Parameters)
                {
                    paramNames.Add(param.Name);
                }
                foreach (var arg in annotation.ConstructorArguments)
                {
                    if (positionalArgs && positionalIndex < ctr.Parameters.Length)
                    {
                        if (arg.Name is null || arg.Name == ctr.Parameters[positionalIndex].Name)
                        {
                            ++positionalIndex;
                        }
                        else
                        {
                            positionalArgs = false;
                            for (int i = positionalIndex; i < ctr.Parameters.Length; i++)
                            {
                                if (!ctr.Parameters[i].HasExplicitDefaultValue)
                                {
                                    goodCandidate = false;
                                    break;
                                }
                            }
                        }
                    }
                    else if (arg.Name is not null)
                    {
                        var goodArg = false;
                        for (int i = positionalIndex; i < ctr.Parameters.Length; i++)
                        {
                            if (ctr.Parameters[i].Name == arg.Name)
                            {
                                goodArg = true;
                                break;
                            }
                        }
                        if (!goodArg)
                        {
                            goodCandidate = false;
                            break;
                        }
                    }
                }
                if (positionalArgs && positionalIndex < ctr.Parameters.Length && !ctr.Parameters[positionalIndex].HasExplicitDefaultValue)
                {
                    goodCandidate = false;
                }
                if (goodCandidate)
                {
                    candidates.Add(ctr);
                }
            }
            if (candidates.Count == 0)
            {
                if (!hasDefaultConstructor)
                {
                    var builder = PooledStringBuilder.GetInstance();
                    var sb = builder.Builder;
                    foreach (var name in paramNames.OrderBy(n => n))
                    {
                        if (sb.Length > 0) sb.Append(", ");
                        sb.Append(name);
                    }
                    Error(annotation.Location, $"Missing arguments for the annotation '{annotation.QualifiedName}': {builder.ToStringAndFree()}");
                }
            }
            else if (candidates.Count == 1)
            {
                var ctr = candidates[0];
                var positionalIndex = 0;
                var positionalArgs = true;
                foreach (var arg in annotation.ConstructorArguments)
                {
                    IParameterSymbol? param = null;
                    if (positionalArgs && positionalIndex < ctr.Parameters.Length)
                    {
                        if (arg.Name is null || arg.Name == ctr.Parameters[positionalIndex].Name)
                        {
                            param = ctr.Parameters[positionalIndex++];
                        }
                    }
                    if (param is null && arg.Name is not null)
                    {
                        for (int i = positionalIndex; i < ctr.Parameters.Length; i++)
                        {
                            if (ctr.Parameters[i].Name == arg.Name)
                            {
                                param = ctr.Parameters[i];
                                break;
                            }
                        }
                    }
                    Debug.Assert(param is not null);
                    if (param is not null)
                    {
                        var paramTypeName = param.Type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                        if (paramTypeName == "System.Type" || paramTypeName == "System.Type?")
                        {
                            if (!string.IsNullOrWhiteSpace(arg.Value))
                            {
                                var typeSymbols = ResolveSymbols(arg.Location, arg.Value.Split('.').ToImmutableArray()).OfType<INamedTypeSymbol>().ToImmutableArray();
                                if (typeSymbols.Length == 0)
                                {
                                    Error(arg.Location, $"The type '{arg.Value}' could not be found (are you missing a using directive or an assembly reference?).");
                                }
                                else
                                {
                                    Error(arg.Location, $"'{arg.Value}' is an ambiguous reference between '{candidates[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{candidates[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
                                }
                            }
                            else
                            {
                                Error(arg.Location, "Type name is missing.");
                            }
                        }
                    }
                }
            }
            else
            {
                Error(annotation.Location, $"Could not resolve a unique constructor for the annotation '{annotation.QualifiedName}'");
            }
        }

        private void Error(Location location, string message)
        {
            _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, location, message));
        }
    }
}
