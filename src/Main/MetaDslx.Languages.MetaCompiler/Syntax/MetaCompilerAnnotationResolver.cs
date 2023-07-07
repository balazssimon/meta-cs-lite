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
    using AnnotationTargets = MetaDslx.CodeAnalysis.Annotations.AnnotationTargets;
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;
    using IArrayTypeSymbol = Microsoft.CodeAnalysis.IArrayTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using SymbolDisplayFormat = Microsoft.CodeAnalysis.SymbolDisplayFormat;

    internal class MetaCompilerAnnotationResolver
    {
        internal const string MetaDslxAnnotationsNamespace = "MetaDslx.CodeAnalysis.Annotations";
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
                    Error(annotation.Location, $"Annotation '{csharpSymbol.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' must be a descendant of '{MetaDslxAnnotationsNamespace}.Annotation'.");
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
                if (baseTypeName == $"{MetaDslxAnnotationsNamespace}.Annotation") return true;
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
                if (attrName == $"{MetaDslxAnnotationsNamespace}.AnnotationUsageAttribute")
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
                    if (TryConstructor(ctr, annotation, assignValues: false, ref hasErrors)) goodCandidates.Add(ctr);
                } 
                if (goodCandidates.Count == 1)
                {
                    annotation.CSharpConstructor = goodCandidates[0];
                    TryConstructor(annotation.CSharpConstructor, annotation, assignValues: true, ref hasErrors);
                }
                else
                {
                    if (candidates.Count == 1 && goodCandidates.Count == 0) TryConstructor(candidates[0], annotation, assignValues: true, ref hasErrors);
                    else Error(annotation.Location, $"Could not resolve a unique constructor for the annotation '{annotation.QualifiedName}'");
                }
                goodCandidates.Free();
            }
            candidates.Free();
            foreach (var prop in annotation.Properties)
            {
                var members = annotation.CSharpClass.GetMembers(prop.Name);
                var foundProp = false;
                var hasErrors = false;
                foreach (var member in members)
                {
                    if (member is IPropertySymbol propSymbol)
                    {
                        foundProp = true;
                        ResolveArrayType(prop, propSymbol.Type);
                        TryResolveValues(prop, addDiagnostics: true, ref hasErrors);
                        if (propSymbol.SetMethod is null && !prop.ValueKind.HasFlag(AnnotationValueKind.GenericCollection))
                        {
                            Error(prop.Location, $"'{prop.Name}' is not settable");
                        }
                    }
                }
                if (!foundProp)
                {
                    var builder = PooledStringBuilder.GetInstance();
                    var sb = builder.Builder;
                    foreach (var name in annotation.CSharpClass.GetMembers().OfType<IPropertySymbol>().OrderBy(p => p.Name))
                    {
                        if (sb.Length > 0) sb.Append(", ");
                        sb.Append(name);
                    }
                    Error(prop.Location, $"'{prop.Name}' is an invalid property name for '{annotation.QualifiedName}'. Valid property names are: {builder.ToStringAndFree()}");
                }
            }
        }

        private bool TryConstructor(IMethodSymbol ctr, Annotation annotation, bool assignValues, ref bool hasErrors)
        {
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
                            arg.Name = ctr.Parameters[positionalIndex].Name;
                            param = ctr.Parameters[positionalIndex++];
                        }
                    }
                    else
                    {
                        if (assignValues) Error(arg.Location, $"{annotation.ConstructorArguments.Count} arguments are specified for the annotation, but only {ctr.Parameters.Length} are expected");
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
                if (param is not null && param.Type is not null)
                {
                    ResolveArrayType(arg, param.Type);
                    if (!TryResolveValues(arg, assignValues, ref hasErrors)) return false;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private bool ResolveArrayType(AnnotationProperty prop, ITypeSymbol expectedType)
        {
            prop.CSharpType = expectedType;
            var coreType = expectedType;
            if (expectedType is INamedTypeSymbol namedType && namedType.IsGenericType && namedType.TypeArguments.Length == 1 &&
                namedType.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Nullable<>")
            {
                coreType = namedType.TypeArguments[0];
            }
            else if (expectedType.NullableAnnotation == Microsoft.CodeAnalysis.NullableAnnotation.Annotated)
            {
                coreType = expectedType.OriginalDefinition;
            }
            if (coreType is IArrayTypeSymbol arrayType)
            {
                prop.ValueKind = AnnotationValueKind.Array;
                return ResolveItemType(prop, arrayType.ElementType);
            }
            else if (coreType is INamedTypeSymbol genericType && genericType.IsGenericType && genericType.TypeArguments.Length == 1)
            {
                var originalTypeName = genericType.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (WellKnownImmutableCollectionTypes.Contains(originalTypeName))
                {
                    switch (originalTypeName)
                    {
                        case "System.Collections.Immutable.ImmutableArray<>":
                            prop.ValueKind = AnnotationValueKind.ImmutableArray;
                            break;
                        case "System.Collections.Immutable.ImmutableList<>":
                            prop.ValueKind = AnnotationValueKind.ImmutableList;
                            break;
                        case "System.Collections.Immutable.ImmutableHashSet<>":
                            prop.ValueKind = AnnotationValueKind.ImmutableHashSet;
                            break;
                        case "System.Collections.Immutable.ImmutableSortedSet<>":
                            prop.ValueKind = AnnotationValueKind.ImmutableSortedSet;
                            break;
                        default:
                            Debug.Assert(false);
                            break;
                    }
                    return ResolveItemType(prop, genericType.TypeArguments[0]);
                }
                else if (WellKnownGenericCollectionTypes.Contains(originalTypeName) || 
                    genericType.AllInterfaces.Any(itf => itf.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Collections.Generic.ICollection<>"))
                {
                    prop.ValueKind = AnnotationValueKind.GenericCollection;
                    return ResolveItemType(prop, genericType.TypeArguments[0]);
                }
                else
                {
                    prop.ValueKind = AnnotationValueKind.Single;
                    return ResolveItemType(prop, expectedType);
                }
            }
            else
            {
                prop.ValueKind = AnnotationValueKind.Single;
                return ResolveItemType(prop, expectedType);
            }
        }

        private bool ResolveItemType(AnnotationProperty prop, ITypeSymbol expectedType)
        {
            prop.CSharpItemType = expectedType;
            var nullable = false;
            var coreType = expectedType;
            if (expectedType is INamedTypeSymbol namedType && namedType.IsGenericType && namedType.TypeArguments.Length == 1 &&
                namedType.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Nullable<>")
            {
                nullable = true;
                coreType = namedType.TypeArguments[0];
            }
            else if (expectedType.NullableAnnotation == Microsoft.CodeAnalysis.NullableAnnotation.Annotated)
            {
                nullable = true;
                coreType = expectedType.OriginalDefinition;
            }
            prop.CSharpCoreType = coreType;
            if (nullable)
            {
                prop.ItemTypeKind |= AnnotationItemTypeKind.Nullable;
            }
            var coreTypeName = coreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
            if (coreTypeName == "System.Type")
            {
                prop.ItemTypeKind |= AnnotationItemTypeKind.SystemType;
            }
            else if (coreType is INamedTypeSymbol enumType && enumType.BaseType?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Enum")
            {
                prop.ItemTypeKind |= AnnotationItemTypeKind.EnumType;
            }
            else
            {
                switch (coreTypeName)
                {
                    case "bool":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.BoolType;
                        break;
                    case "byte":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.ByteType;
                        break;
                    case "sbyte":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.SByteType;
                        break;
                    case "short":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.ShortType;
                        break;
                    case "ushort":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.UShortType;
                        break;
                    case "int":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.IntType;
                        break;
                    case "uint":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.UIntType;
                        break;
                    case "long":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.LongType;
                        break;
                    case "ulong":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.ULongType;
                        break;
                    case "float":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.FloatType;
                        break;
                    case "double":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.DoubleType;
                        break;
                    case "char":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.CharType;
                        break;
                    case "string":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.PrimitiveType | AnnotationItemTypeKind.StringType;
                        break;
                    case "object":
                        prop.ItemTypeKind |= AnnotationItemTypeKind.ObjectType;
                        break;
                    default: 
                        return false;
                }
            }
            return true;
        }

        private bool TryResolveValues(AnnotationProperty prop, bool addDiagnostics, ref bool hasErrors)
        {
            if (prop.CSharpCoreType is null) return false;
            var builder = ArrayBuilder<object?>.GetInstance();
            var success = true;
            foreach (var valueText in prop.ValueTexts)
            {
                if (TryResolveValue(prop, valueText, addDiagnostics, ref hasErrors, out var argValue))
                {
                    builder.Add(argValue);
                }
                else
                {
                    success = false;
                }
            }
            if (!prop.IsArray)
            {
                if (prop.ValueTexts.Length == 0)
                {
                    if (addDiagnostics) Error(prop.Location, $"Missing value. Exactly one value must be specified for {prop.CSharpType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}");
                    hasErrors = true;
                }
                else if (prop.ValueTexts.Length > 1)
                {
                    if (addDiagnostics) Error(prop.Location, $"Invalid array of values. Exactly one value must be specified for {prop.CSharpType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}");
                    hasErrors = true;
                }
            }
            prop.Values = builder.ToImmutableAndFree();
            return success;
        }

        private bool TryResolveValue(AnnotationProperty prop, string valueText, bool addDiagnostics, ref bool hasErrors, out object? value)
        {
            value = null;
            if (string.IsNullOrWhiteSpace(valueText) || valueText == "null")
            {
                if (!prop.ItemTypeKind.HasFlag(AnnotationItemTypeKind.Nullable))
                {
                    if (addDiagnostics) Error(prop.Location, $"'null' is an invalid value for {prop.CSharpItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}");
                    hasErrors = true;
                }
            }
            else
            {
                if (prop.ItemTypeKind.HasFlag(AnnotationItemTypeKind.SystemType))
                {
                    var typeSymbols = ResolveSymbols(prop.Location, valueText.Split('.').ToImmutableArray()).OfType<INamedTypeSymbol>().ToImmutableArray();
                    if (typeSymbols.Length == 0)
                    {
                        if (addDiagnostics) Error(prop.Location, $"The type '{valueText}' could not be found (are you missing a using directive or an assembly reference?).");
                        hasErrors = true;
                    }
                    else if (typeSymbols.Length == 1)
                    {
                        value = typeSymbols[0];
                    }
                    else
                    {
                        if (addDiagnostics) Error(prop.Location, $"'{valueText}' is an ambiguous reference between '{typeSymbols[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{typeSymbols[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
                        hasErrors = true;
                    }
                }
                else if (prop.ItemTypeKind.HasFlag(AnnotationItemTypeKind.EnumType))
                {
                    var enumType = prop.CSharpCoreType as INamedTypeSymbol;
                    var enumLiterals = enumType.GetMembers(valueText);
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
                            Error(prop.Location, $"'{valueText}' is an invalid enum literal for '{prop.CSharpItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'. Valid literals are: {builder.ToStringAndFree()}");
                        }
                        hasErrors = true;
                    }
                    else if (enumLiterals.Length == 1)
                    {
                        value = valueText;
                    }
                    else
                    {
                        if (addDiagnostics) Error(prop.Location, $"'{valueText}' enum literal is not unique in '{prop.CSharpItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'");
                        hasErrors = true;
                    }
                }
                else if (prop.ItemTypeKind.HasFlag(AnnotationItemTypeKind.ObjectType))
                {
                    value = valueText;
                }
                else if (TryParseValue(prop.ItemTypeKind, valueText, out var primitiveValue))
                {
                    value = primitiveValue;
                }
                else
                {
                    if (addDiagnostics) Error(prop.Location, $"'{prop.CSharpItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' is an invalid type for annotation parameters and properties. The type must be either a primitive type, a string, an enum or System.Type.");
                    hasErrors = true;
                    return false;
                }
            }
            return true;
        }

        private bool TryParseValue(AnnotationItemTypeKind kind, string valueText, out object? value)
        {
            value = null;
            if (valueText == "null")
            {
                value = null;
                return kind.HasFlag(AnnotationItemTypeKind.Nullable);
            }
            else
            {
                var coreKind = kind & ~AnnotationItemTypeKind.PrimitiveType & ~AnnotationItemTypeKind.Nullable;
                switch (coreKind)
                {
                    case AnnotationItemTypeKind.BoolType: if (bool.TryParse(valueText, out var boolValue)) { value = boolValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.ByteType: if (byte.TryParse(valueText, out var byteValue)) { value = byteValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.SByteType: if (sbyte.TryParse(valueText, out var sbyteValue)) { value = sbyteValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.ShortType: if (short.TryParse(valueText, out var shortValue)) { value = shortValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.UShortType: if (ushort.TryParse(valueText, out var ushortValue)) { value = ushortValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.IntType: if (int.TryParse(valueText, out var intValue)) { value = intValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.UIntType: if (uint.TryParse(valueText, out var uintValue)) { value = uintValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.LongType: if (long.TryParse(valueText, out var longValue)) { value = longValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.ULongType: if (ulong.TryParse(valueText, out var ulongValue)) { value = ulongValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.FloatType: if (float.TryParse(valueText, out var floatValue)) { value = floatValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.DoubleType: if (double.TryParse(valueText, out var doubleValue)) { value = doubleValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.DecimalType: if (decimal.TryParse(valueText, out var decimalValue)) { value = decimalValue; return true; } else { return false; };
                    case AnnotationItemTypeKind.CharType: if (valueText.StartsWith("'") && valueText.EndsWith("'")) { value = StringUtils.DecodeChar(valueText); return true; } else { return false; };
                    case AnnotationItemTypeKind.StringType: if (valueText.StartsWith("\"") && valueText.EndsWith("\"")) { value = StringUtils.DecodeString(valueText); return true; } else if (StringUtils.IsIdentifier(valueText)) { value = valueText; return true; } else { return false; };
                    default: return false;
                }
            }
        }

        private void Error(Location location, string message)
        {
            _diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_SyntaxError, location, message));
        }

        private static readonly string[] WellKnownImmutableCollectionTypes = new string[]
        {
            "System.Collections.Immutable.ImmutableArray<>",
            "System.Collections.Immutable.ImmutableList<>",
            "System.Collections.Immutable.ImmutableHashSet<>",
            "System.Collections.Immutable.ImmutableSortedSet<>",
        };

        private static readonly string[] WellKnownGenericCollectionTypes = new string[]
        {
            "System.Collections.Generic.List<>",
            "System.Collections.Generic.LinkedList<>",
            "System.Collections.Generic.HashSet<>",
            "System.Collections.Generic.SortedSet<>",
        };
    }
}
