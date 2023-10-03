using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaCompiler.Syntax;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
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

    public enum AnnotationKind
    {
        None,
        Binder,
        Annotation
    }

    public class Annotation : IElementWithLocation
    {
        private bool _resolved;
        private INamedTypeSymbol? _csharpClass;
        private IMethodSymbol? _csharpConstructor;

        public Annotation(Grammar grammar)
        {
            this.Grammar = grammar;
        }

        public Grammar Grammar { get; private set; }
        public Language Language => Grammar.Language;
        public AnnotationKind Kind { get; set; }
        public ImmutableArray<string> Name { get; set; }
        public string QualifiedName => string.Join(".", Name);
        public List<AnnotationProperty> ConstructorArguments { get; } = new List<AnnotationProperty>();
        //public List<AnnotationProperty> Properties { get; } = new List<AnnotationProperty>();
        public Location Location { get; set; }
        public INamedTypeSymbol? CSharpClass
        {
            get
            {
                this.Resolve();
                return _csharpClass;
            }
        }
        public IMethodSymbol? CSharpConstructor
        {
            get
            {
                this.Resolve();
                return _csharpConstructor;
            }
        }
        public bool IsRoot => CSharpClass?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == $"{MetaDslxTypes.MetaDslxBindersNamespace}.RootBinder";

        public void Resolve()
        {
            if (_resolved) return;
            _resolved = true;
            if (this.Name.IsDefaultOrEmpty)
            {
                Error(Location, "Binder or annotation name is missing.");
                return;
            }
            var candidates = Language.ResolveSymbols(Location, false, null, Name, "Annotation", "Binder").OfType<INamedTypeSymbol>().ToImmutableArray();
            foreach (var csharpSymbol in candidates)
            {
                if (!IsMetaCompilerAnnotation(csharpSymbol))
                {
                    Error(Location, $"'{csharpSymbol.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' must be either a descendant of '{MetaDslxTypes.MetaDslxBindersNamespace}.Binder' or '{MetaDslxTypes.MetaDslxAnnotationsNamespace}.Annotation', and its name should end with 'Binder' or 'Annotation', respectively.");
                }
            }
            INamedTypeSymbol? result = null;
            if (candidates.Length == 1)
            {
                result = candidates[0];
                _csharpClass = result;
                if (result.Name.EndsWith("Binder")) Kind = AnnotationKind.Binder;
                if (result.Name.EndsWith("Annotation")) Kind = AnnotationKind.Annotation;
                ResolveAnnotationProperties();
            }
            else if (candidates.Length == 0)
            {
                Language.Error(Location, $"The binder or annotation name '{QualifiedName}' could not be found (are you missing a using directive or an assembly reference?).");
            }
            else
            {
                Language.Error(Location, $"'{QualifiedName}' is an ambiguous reference between '{candidates[0].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' and '{candidates[1].ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'.");
            }
            return;
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
                if (isAnnotation && baseTypeName == $"{MetaDslxTypes.MetaDslxAnnotationsNamespace}.Annotation" ||
                    isBinder && baseTypeName == $"{MetaDslxTypes.MetaDslxBindersNamespace}.Binder") return true;
                baseType = baseType.BaseType;
            }
            return false;
        }

        private void ResolveAnnotationProperties()
        {
            if (CSharpClass is null) return;
            var paramNames = PooledHashSet<string>.GetInstance();
            var csharpClass = CSharpClass;
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
                for (int argIndex = 0; argIndex < ConstructorArguments.Count; ++argIndex)
                {
                    var arg = ConstructorArguments[argIndex];
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
                var arg = ConstructorArguments[invalidArgIndex];
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                foreach (var name in paramNames.OrderBy(n => n))
                {
                    if (sb.Length > 0) sb.Append(", ");
                    sb.Append(name);
                }
                Error(arg.Location, $"'{arg.Name}' is an invalid argument for '{QualifiedName}'. Possible arguments are: {builder.ToStringAndFree()}");
            }
            else if (candidates.Count == 0 && ConstructorArguments.Count == 0)
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
                    Error(Location, $"Some arguments are missing for '{QualifiedName}'. Possible arguments are: {builder.ToStringAndFree()}");
                }
            }
            else
            {
                var goodCandidates = ArrayBuilder<IMethodSymbol>.GetInstance();
                var hasErrors = false;
                foreach (var ctr in candidates)
                {
                    if (TryConstructor(ctr, assignValues: false, ref hasErrors)) goodCandidates.Add(ctr);
                }
                if (goodCandidates.Count == 1)
                {
                    _csharpConstructor = goodCandidates[0];
                    TryConstructor(CSharpConstructor, assignValues: true, ref hasErrors);
                }
                else
                {
                    if (candidates.Count == 1 && goodCandidates.Count == 0) TryConstructor(candidates[0], assignValues: true, ref hasErrors);
                    else Error(Location, $"Could not resolve a unique constructor for '{QualifiedName}'");
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
                        if (propSymbol.SetMethod is null && !prop.ValueKind.HasFlag(TypeKind.GenericCollection))
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

        private bool TryConstructor(IMethodSymbol ctr, bool assignValues, ref bool hasErrors)
        {
            var positionalIndex = 0;
            var positionalArgs = true;
            foreach (var arg in ConstructorArguments)
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
                        if (assignValues) Error(arg.Location, $"{ConstructorArguments.Count} arguments are specified, but only {ctr.Parameters.Length} are expected");
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
                    var csharpTypeInfo = new CSharpTypeInfo(Language, param.Type);
                    if (assignValues) arg.CSharpTypeInfo = csharpTypeInfo;
                    if (csharpTypeInfo.TryResolveValues(arg.ValueTexts, arg.Location, assignValues, out var values))
                    {
                        if (assignValues) arg.Values = values;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private void Error(Location location, string message)
        {
            Language.Error(location, message);
        }


        public override string ToString()
        {
            return QualifiedName;
        }
    }

    public class AnnotationProperty : IElementWithLocation
    {
        private Annotation _annotation;
        private bool _resolved;
        private CSharpTypeInfo? _csharpTypeInfo;
        private ImmutableArray<object> _values;

        public AnnotationProperty(Annotation annotation)
        {
            _annotation = annotation;
        }

        public string? Name { get; set; }
        public Location Location { get; set; }
        public bool IsArray { get; set; }
        public ImmutableArray<string?> ValueTexts { get; set; }

        public CSharpTypeInfo CSharpTypeInfo
        {
            get
            {
                Resolve();
                return _csharpTypeInfo;
            }
            internal set
            {
                _csharpTypeInfo = value;
            }
        }
        public ImmutableArray<object?> Values
        {
            get
            {
                Resolve();
                return _values;
            }
            internal set
            {
                _values = value;
            }
        }

        private void Resolve()
        {
            if (_resolved) return;
            _resolved = true;
            _annotation.Resolve();
        }

        public string CSharpValue
        {
            get
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                var separator = "";
                switch (CSharpTypeInfo.TypeKind)
                {
                    case TypeKind.Array:
                    case TypeKind.ImmutableArray:
                    case TypeKind.ImmutableList:
                    case TypeKind.ImmutableHashSet:
                    case TypeKind.ImmutableSortedSet:
                        sb.Append("new ");
                        sb.Append(CSharpTypeInfo.ItemType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat));
                        sb.Append("[] ");
                        break;
                    default:
                        break;
                }
                switch (CSharpTypeInfo.TypeKind)
                {
                    case TypeKind.Single:
                        if (!Values.IsDefaultOrEmpty && Values.Length >= 1) AppendItemValue(sb, Values[0]);
                        break;
                    case TypeKind.Array:
                    case TypeKind.ImmutableArray:
                    case TypeKind.ImmutableList:
                    case TypeKind.ImmutableHashSet:
                    case TypeKind.ImmutableSortedSet:
                    case TypeKind.GenericCollection:
                        sb.Append("{");
                        if (!Values.IsDefaultOrEmpty)
                        {
                            foreach (var value in Values)
                            {
                                sb.Append(separator);
                                AppendItemValue(sb, value);
                                separator = ", ";
                            }
                        }
                        sb.Append("}");
                        break;
                    default:
                        break;
                }
                switch (CSharpTypeInfo.TypeKind)
                {
                    case TypeKind.ImmutableArray:
                    case TypeKind.ImmutableList:
                    case TypeKind.ImmutableHashSet:
                    case TypeKind.ImmutableSortedSet:
                        sb.Append(".To");
                        sb.Append(CSharpTypeInfo.TypeKind.ToString());
                        sb.Append("()");
                        break;
                    default:
                        break;
                }
                return builder.ToStringAndFree();
            }
        }

        private void AppendItemValue(StringBuilder sb, object? value)
        {
            if (value is null)
            {
                if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.Nullable)) sb.Append("null");
                else sb.Append("default");
            }
            else if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.SystemType))
            {
                sb.Append("typeof(");
                var nts = value as INamedTypeSymbol;
                if (nts != null)
                {
                    sb.Append(nts.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat));
                }
                sb.Append(")");
            }
            else if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.EnumType))
            {
                sb.Append(CSharpTypeInfo.CoreType.ToDisplayString(SymbolDisplayFormat.FullyQualifiedFormat));
                sb.Append(".");
                sb.Append(value.ToString());
            }
            else if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.BoolType))
            {
                if (value is bool boolValue && boolValue) sb.Append("true");
                else sb.Append("false");
            }
            else if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.CharType))
            {
                if (value is char charValue) sb.Append(StringUtilities.EncodeChar(charValue));
                else sb.Append("'\\0'");
            }
            else if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.StringType))
            {
                if (value is string stringValue) sb.Append(StringUtilities.EncodeString(stringValue));
                else sb.Append("\"\"");
            }
            else if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.ByteType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.SByteType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.ShortType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.UShortType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.IntType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.UIntType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.LongType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.ULongType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.FloatType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.DoubleType) ||
                CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.DecimalType))
            {
                sb.Append(value.ToString());
            }
            else if (CSharpTypeInfo.ItemTypeKind.HasFlag(ItemTypeKind.ObjectType))
            {
                sb.Append(value.ToString());
            }
            else
            {
                Debug.Assert(false);
            }
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            if (IsArray) sb.Append("{");
            foreach (var valueText in ValueTexts)
            {
                if (IsArray && sb.Length > 1) sb.Append(", ");
                sb.Append(valueText);
            }
            if (IsArray) sb.Append("}");
            return $"{Name}={builder.ToStringAndFree()}";
        }
    }

}
