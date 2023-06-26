using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaCompiler.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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
            var invalidArgIndex = -1;
            foreach (var ctr in csharpClass.Constructors)
            {
                if (ctr.Parameters.Length == 0 || ctr.Parameters[0].HasExplicitDefaultValue) hasDefaultConstructor = true;
                foreach (var param in ctr.Parameters)
                {
                    paramNames.Add(param.Name);
                }
            }
            foreach (var ctr in csharpClass.Constructors)
            {
                var positionalIndex = 0;
                var positionalArgs = true;
                var goodCandidate = true;
                for (int argIndex = 0; argIndex < annotation.ConstructorArguments.Count; ++argIndex)
                {
                    var arg = annotation.ConstructorArguments[argIndex];
                    if (!string.IsNullOrWhiteSpace(arg.Name) && !paramNames.Contains(arg.Name))
                    {
                        invalidArgIndex = argIndex;
                        break;
                    }
                    if (positionalArgs && positionalIndex < ctr.Parameters.Length)
                    {
                        if (arg.Name is null || arg.Name == ctr.Parameters[positionalIndex].Name)
                        {
                            ++positionalIndex;
                        }
                        else
                        {
                            positionalArgs = false;
                            if (!ctr.Parameters[positionalIndex].HasExplicitDefaultValue)
                            {
                                goodCandidate = false;
                                break;
                            }
                        }
                    }
                    if (!positionalArgs)
                    {
                        if (string.IsNullOrWhiteSpace(arg.Name))
                        {
                            goodCandidate = false;
                            break;
                        }
                        else
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
                }
                if (positionalArgs && (positionalIndex > ctr.Parameters.Length || positionalIndex < ctr.Parameters.Length && !ctr.Parameters[positionalIndex].HasExplicitDefaultValue))
                {
                    goodCandidate = false;
                }
                if (goodCandidate)
                {
                    candidates.Add(ctr);
                }
            }
            if (invalidArgIndex >= 0)
            {
                var arg = annotation.ConstructorArguments[invalidArgIndex];
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                foreach (var name in paramNames.OrderBy(n => n))
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(name);
                }
                Error(arg.Location, $"'{arg.Name}' is an invalid argument for '{annotation.QualifiedName}'. Possible arguments are: {builder.ToStringAndFree()}");
            }
            else if (candidates.Count == 0 && annotation.ConstructorArguments.Count == 0)
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
                    Error(annotation.Location, $"Some arguments are missing for the annotation '{annotation.QualifiedName}'. Possible arguments are: {builder.ToStringAndFree()}");
                }
            }
            else
            {
                var goodCandidates = ArrayBuilder<IMethodSymbol>.GetInstance();
                var hasErrors = false;
                foreach (var ctr in candidates)
                {
                    if (IsGoodCandidate(ctr, annotation, addDiagnostics: false, out var ctrHasErrors)) goodCandidates.Add(ctr);
                    if (ctrHasErrors) hasErrors = true;
                } 
                if (goodCandidates.Count == 1)
                {
                    annotation.CSharpConstructor = goodCandidates[0];
                    if (hasErrors) IsGoodCandidate(annotation.CSharpConstructor, annotation, addDiagnostics: true, out var _);
                }
                else
                {
                    if (candidates.Count == 1 && goodCandidates.Count == 0) IsGoodCandidate(candidates[0], annotation, addDiagnostics: true, out var _);
                    else Error(annotation.Location, $"Could not resolve a unique constructor for the annotation '{annotation.QualifiedName}'");
                }
                goodCandidates.Free();
            }
            candidates.Free();
        }

        private bool IsGoodCandidate(IMethodSymbol ctr, Annotation annotation, bool addDiagnostics, out bool hasErrors)
        {
            hasErrors = false;
            var positionalIndex = 0;
            var positionalArgs = true;
            foreach (var arg in annotation.ConstructorArguments)
            {
                IParameterSymbol? param = null;
                if (positionalArgs)
                {
                    if (positionalIndex < ctr.Parameters.Length)
                    {
                        if (arg.Name is null || arg.Name == ctr.Parameters[positionalIndex].Name)
                        {
                            param = ctr.Parameters[positionalIndex++];
                        }
                    }
                    else
                    {
                        if (addDiagnostics) Error(arg.Location, $"Too many arguments are specified for the annotation");
                        hasErrors = true;
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
                if (param is not null)
                {
                    var nullable = false;
                    var paramType = param.Type;
                    var paramTypeName = paramType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                    if (param.Type is INamedTypeSymbol namedType && namedType.IsGenericType && namedType.TypeArguments.Length == 1 &&
                        namedType.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Nullable<>")
                    {
                        nullable = true;
                        paramType = namedType.TypeArguments[0];
                    }
                    else if (param.Type.NullableAnnotation == Microsoft.CodeAnalysis.NullableAnnotation.Annotated)
                    {
                        nullable = true;
                        paramType = param.Type.OriginalDefinition;
                    }
                    var innerParamTypeName = paramType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                    arg.CSharpType = param.Type;
                    if (string.IsNullOrWhiteSpace(arg.ValueText) || arg.ValueText == "null")
                    {
                        arg.Value = null;
                        if (!nullable)
                        {
                            if (addDiagnostics) Error(arg.Location, $"'null' is an invalid value for {paramTypeName}");
                            hasErrors = true;
                        }
                    }
                    else
                    {
                        if (innerParamTypeName == "System.Type")
                        {
                            var typeSymbols = ResolveSymbols(arg.Location, arg.ValueText.Split('.').ToImmutableArray()).OfType<INamedTypeSymbol>().ToImmutableArray();
                            if (typeSymbols.Length == 0)
                            {
                                if (addDiagnostics) Error(arg.Location, $"The type '{arg.ValueText}' could not be found (are you missing a using directive or an assembly reference?).");
                                hasErrors = true;
                            }
                            else if (typeSymbols.Length == 1)
                            {
                                arg.Value = typeSymbols[0];
                            }
                            else
                            {
                                if (addDiagnostics) Error(arg.Location, $"'{arg.ValueText}' is an ambiguous reference between '{typeSymbols[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{typeSymbols[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
                                hasErrors = true;
                            }
                        }
                        else if (paramType is INamedTypeSymbol enumType && enumType.BaseType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Enum")
                        {
                            var enumLiterals = enumType.GetMembers(arg.ValueText);
                            if (enumLiterals.Length == 0)
                            {
                                if (addDiagnostics)
                                {
                                    var builder = PooledStringBuilder.GetInstance();
                                    var sb = builder.Builder;
                                    foreach (var member in enumType.GetMembers())
                                    {
                                        if (sb.Length > 0) sb.Append(", ");
                                        sb.Append(member.Name);
                                    }
                                    Error(arg.Location, $"'{arg.ValueText}' is an invalid enum literal for '{paramTypeName}'. Valid literals are: {builder.ToStringAndFree()}");
                                }
                                hasErrors = true;
                            }
                            else if (enumLiterals.Length == 1)
                            {
                                arg.Value = arg.ValueText;
                            }
                            else
                            {
                                if (addDiagnostics) Error(arg.Location, $"'{arg.ValueText}' enum literal is not unique in '{paramTypeName}'");
                                hasErrors = true;
                            }
                        }
                        else if (TryParseValue(innerParamTypeName, arg.ValueText, out var primitiveValue))
                        {
                            arg.Value = primitiveValue;
                        }
                        else
                        {
                            if (addDiagnostics) Error(arg.Location, $"The type '{paramTypeName}' is invalid for annotation parameters and properties");
                            hasErrors = true;
                            return false;
                        }
                    }
                }
                else
                {
                    hasErrors = false;
                    return false;
                }
            }
            return true;
        }

        private bool TryParseValue(string typeName, string valueText, out object? value)
        {
            value = null;
            if (valueText == "null")
            {
                value = null;
                switch (typeName)
                {
                    case "System.Nullable<bool>?":
                    case "System.Nullable<byte>?":
                    case "System.Nullable<short>?":
                    case "System.Nullable<ushort>?":
                    case "System.Nullable<int>?":
                    case "System.Nullable<uint>?":
                    case "System.Nullable<long>?":
                    case "System.Nullable<ulong>?":
                    case "System.Nullable<float>?":
                    case "System.Nullable<double>?":
                    case "System.Nullable<char>?":
                    case "System.Nullable<string>?":
                        return true;
                    default: 
                        return false;
                }
            }
            else
            {
                switch (typeName)
                {
                    case "bool": case "System.Nullable<bool>?": if (bool.TryParse(valueText, out var boolValue)) { value = boolValue; return true; } else { return false; };
                    case "byte": case "System.Nullable<byte>?": if (byte.TryParse(valueText, out var byteValue)) { value = byteValue; return true; } else { return false; };
                    case "short": case "System.Nullable<short>?": if (short.TryParse(valueText, out var shortValue)) { value = shortValue; return true; } else { return false; };
                    case "ushort": case "System.Nullable<ushort>?": if (ushort.TryParse(valueText, out var ushortValue)) { value = ushortValue; return true; } else { return false; };
                    case "int": case "System.Nullable<int>?": if (int.TryParse(valueText, out var intValue)) { value = intValue; return true; } else { return false; };
                    case "uint": case "System.Nullable<uint>?": if (uint.TryParse(valueText, out var uintValue)) { value = uintValue; return true; } else { return false; };
                    case "long": case "System.Nullable<long>?": if (long.TryParse(valueText, out var longValue)) { value = longValue; return true; } else { return false; };
                    case "ulong": case "System.Nullable<ulong>?": if (ulong.TryParse(valueText, out var ulongValue)) { value = ulongValue; return true; } else { return false; };
                    case "float": case "System.Nullable<float>?": if (float.TryParse(valueText, out var floatValue)) { value = floatValue; return true; } else { return false; };
                    case "double": case "System.Nullable<double>?": if (double.TryParse(valueText, out var doubleValue)) { value = doubleValue; return true; } else { return false; };
                    case "char": case "System.Nullable<char>?": if (valueText.StartsWith("'") && valueText.EndsWith("'")) { value = StringUtils.DecodeChar(valueText); return true; } else { return false; };
                    case "string": case "System.Nullable<string>?": if (valueText.StartsWith("\"") && valueText.EndsWith("\"")) { value = StringUtils.DecodeString(valueText); return true; } else if (StringUtils.IsIdentifier(valueText)) { value = valueText; return true; } else { return false; };
                    default: return false;
                }
            }
        }

        private void Error(Location location, string message)
        {
            _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, location, message));
        }
    }
}
