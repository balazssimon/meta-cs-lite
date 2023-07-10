using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaCompiler.Model;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Numerics;
using System.Runtime.ConstrainedExecution;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Syntax
{
    using Language = MetaDslx.Languages.MetaCompiler.Model.Language;
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
        internal const string MetaDslxBindersNamespace = "MetaDslx.CodeAnalysis.Binding";
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

        private void ResolveAnnotations(IEnumerable<Annotation> annotations)
        {
            foreach (var annotation in annotations)
            {
                ResolveAnnotation(annotation);
            }
        }

        private INamedTypeSymbol? ResolveAnnotation(Annotation annotation)
        {
            if (annotation.Name.IsDefaultOrEmpty)
            {
                Error(annotation.Location, "Binder or annotation name is missing.");
                return null;
            }
            var candidates = ResolveSymbols(annotation.Location, annotation.Name, "Annotation", "Binder").OfType<INamedTypeSymbol>().ToImmutableArray();
            foreach (var csharpSymbol in candidates)
            {
                if (!IsMetaCompilerAnnotation(csharpSymbol))
                {
                    Error(annotation.Location, $"'{csharpSymbol.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' must be either a descendant of '{MetaDslxBindersNamespace}.Binder' or '{MetaDslxAnnotationsNamespace}.Annotation', and its name should end with 'Binder' or 'Annotation', respectively.");
                }
            }
            INamedTypeSymbol? result = null;
            if (candidates.Length == 1)
            {
                result = candidates[0];
                annotation.CSharpClass = result;
                if (result.Name.EndsWith("Binder")) annotation.Kind = AnnotationKind.Binder;
                if (result.Name.EndsWith("Annotation")) annotation.Kind = AnnotationKind.Annotation;
                ResolveAnnotationProperties(annotation);
            }
            else if (candidates.Length == 0)
            {
                Error(annotation.Location, $"The binder or annotation name '{annotation.QualifiedName}' could not be found (are you missing a using directive or an assembly reference?).");
            }
            else
            {
                Error(annotation.Location, $"'{annotation.QualifiedName}' is an ambiguous reference between '{candidates[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{candidates[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
            }
            return result;
        }

        private ImmutableArray<INamespaceOrTypeSymbol> ResolveSymbols(Location location, ImmutableArray<string> qualifiedName, params string[] suffixes)
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
                            if (suffixes.Length == 0)
                            {
                                candidates.AddRange(csharpSymbol.GetMembers($"{name}").OfType<INamespaceOrTypeSymbol>());
                            }
                            else
                            {
                                foreach (var suffix in suffixes)
                                {
                                    candidates.AddRange(csharpSymbol.GetMembers($"{name}{suffix}").OfType<INamespaceOrTypeSymbol>());
                                }
                            }
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
            var isBinder = csharpClass.Name.EndsWith("Binder");
            var isAnnotation = csharpClass.Name.EndsWith("Annotation");
            var baseType = csharpClass;
            while (baseType is not null)
            {
                var baseTypeName = baseType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (isAnnotation && baseTypeName == $"{MetaDslxAnnotationsNamespace}.Annotation" ||
                    isBinder && baseTypeName == $"{MetaDslxBindersNamespace}.Binder") return true;
                baseType = baseType.BaseType;
            }
            return false;
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
                    Error(annotation.Location, $"Some arguments are missing for '{annotation.QualifiedName}'. Possible arguments are: {builder.ToStringAndFree()}");
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
                    else Error(annotation.Location, $"Could not resolve a unique constructor for '{annotation.QualifiedName}'");
                }
                goodCandidates.Free();
            }
            candidates.Free();
            /*foreach (var prop in annotation.Properties)
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
                    foreach (var name in annotation.CSharpClass.GetMembers().OfType<IPropertySymbol>().Where(p => p.SetMethod is not null).OrderBy(p => p.Name))
                    {
                        if (sb.Length > 0) sb.Append(", ");
                        sb.Append(name);
                    }
                    Error(prop.Location, $"'{prop.Name}' is an invalid property name for '{annotation.QualifiedName}'. Valid property names are: {builder.ToStringAndFree()}");
                }
            }*/
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
                        if (assignValues) Error(arg.Location, $"{annotation.ConstructorArguments.Count} arguments are specified, but only {ctr.Parameters.Length} are expected");
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
                /*else if (WellKnownGenericCollectionTypes.Contains(originalTypeName) || 
                    genericType.AllInterfaces.Any(itf => itf.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Collections.Generic.ICollection<>"))
                {
                    prop.ValueKind = AnnotationValueKind.GenericCollection;
                    return ResolveItemType(prop, genericType.TypeArguments[0]);
                }*/
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
                    if (addDiagnostics) Error(prop.Location, $"'{prop.CSharpItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' is an invalid type for binder and annotation parameters. The type must be either a primitive type, a string, an enum or System.Type.");
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

        private void ResolveAnnotationContainment()
        {
            foreach (var rule in _language.Grammar.Rules)
            {
                if (rule.Annotations.Any(a => a.Kind == AnnotationKind.Annotation)) rule.ContainsAnnotations = true;
                if (rule.Annotations.Any(a => a.Kind == AnnotationKind.Binder)) rule.ContainsBinders = true;
            }
            foreach (var rule in _language.Grammar.ParserRules)
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
                foreach (var rule in _language.Grammar.ParserRules)
                {
                    foreach (var alt in rule.Alternatives)
                    {
                        foreach (var elem in alt.Elements)
                        {
                            bool containsAnnotations = elem.ContainsAnnotations;
                            bool containsBinders = elem.ContainsBinders;
                            if (CheckAnnotationContainment(elem, ref containsAnnotations, ref containsBinders)) updated = true;
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

        /*private static readonly string[] WellKnownGenericCollectionTypes = new string[]
        {
            "System.Collections.Generic.List<>",
            "System.Collections.Generic.LinkedList<>",
            "System.Collections.Generic.HashSet<>",
            "System.Collections.Generic.SortedSet<>",
        };*/
    }
}
