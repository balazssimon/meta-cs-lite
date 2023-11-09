using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
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

    public enum TypeKind
    {
        Single,
        Array,
        ImmutableArray,
        ImmutableList,
        ImmutableHashSet,
        ImmutableSortedSet,
        GenericCollection
    }

    [Flags]
    public enum ItemTypeKind
    {
        None = 0,
        Nullable = 0x00001,
        SystemType = 0x00002,
        EnumType = 0x00004,
        PrimitiveType = 0x00008,
        BoolType = 0x00010,
        CharType = 0x00020,
        StringType = 0x00040,
        ByteType = 0x00080,
        SByteType = 0x00100,
        ShortType = 0x00200,
        UShortType = 0x00400,
        IntType = 0x00800,
        UIntType = 0x01000,
        LongType = 0x02000,
        ULongType = 0x04000,
        FloatType = 0x08000,
        DoubleType = 0x10000,
        DecimalType = 0x20000,
        ObjectType = 0x40000,
        OtherType = 0x80000
    }

    public class CSharpTypeInfo
    {
        private Language _language;
        private bool _resolved;
        private ITypeSymbol? _type;
        private TypeKind _typeKind;
        private ItemTypeKind _itemTypeKind;
        private ITypeSymbol? _itemType;
        private ITypeSymbol? _coreType;
        private bool _isSymbol;
        private bool _isTypeSymbol;
        private bool _isModelObject;

        public CSharpTypeInfo(Language language, ITypeSymbol? type)
        {
            _language = language;
            _type = type;
        }

        public Language Language => _language;
        public ITypeSymbol? Type => _type;

        public bool IsDefault => _type == null;

        public TypeKind TypeKind
        {
            get
            {
                Resolve();
                return _typeKind;
            }
        }

        public ItemTypeKind ItemTypeKind
        {
            get
            {
                Resolve();
                return _itemTypeKind;
            }
        }

        public ITypeSymbol? ItemType
        {
            get
            {
                Resolve();
                return _itemType;
            }
        }

        public ITypeSymbol? CoreType
        {
            get
            {
                Resolve();
                return _coreType;
            }
        }

        public bool IsSymbol
        {
            get
            {
                Resolve();
                return _isSymbol;
            }
        }

        public bool IsTypeSymbol
        {
            get
            {
                Resolve();
                return _isTypeSymbol;
            }
        }

        public bool IsModelObject
        {
            get
            {
                Resolve();
                return _isModelObject;
            }
        }

        public void Resolve()
        {
            if (_resolved || _type is null || _language is null) return;
            _resolved = true;
            var coreType = _type;
            if (_type is INamedTypeSymbol namedType && namedType.IsGenericType && namedType.TypeArguments.Length == 1 &&
                namedType.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Nullable<>")
            {
                coreType = namedType.TypeArguments[0];
            }
            else if (_type.NullableAnnotation == Microsoft.CodeAnalysis.NullableAnnotation.Annotated)
            {
                coreType = _type.OriginalDefinition;
            }
            _itemType = _type;
            if (coreType is IArrayTypeSymbol arrayType)
            {
                _typeKind = TypeKind.Array;
                _itemType = arrayType.ElementType;
            }
            else if (coreType is INamedTypeSymbol genericType && genericType.IsGenericType && genericType.TypeArguments.Length == 1)
            {
                var originalTypeName = genericType.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (WellKnownImmutableCollectionTypes.Contains(originalTypeName))
                {
                    switch (originalTypeName)
                    {
                        case "System.Collections.Immutable.ImmutableArray<>":
                            _typeKind = TypeKind.ImmutableArray;
                            break;
                        case "System.Collections.Immutable.ImmutableList<>":
                            _typeKind = TypeKind.ImmutableList;
                            break;
                        case "System.Collections.Immutable.ImmutableHashSet<>":
                            _typeKind = TypeKind.ImmutableHashSet;
                            break;
                        case "System.Collections.Immutable.ImmutableSortedSet<>":
                            _typeKind = TypeKind.ImmutableSortedSet;
                            break;
                        default:
                            _typeKind = TypeKind.Single;
                            Debug.Assert(false);
                            break;
                    }
                    _itemType = genericType.TypeArguments[0];
                }
                else if (WellKnownGenericCollectionTypes.Contains(originalTypeName) ||
                    genericType.AllInterfaces.Any(itf => itf.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Collections.Generic.ICollection<>"))
                {
                    _typeKind = TypeKind.GenericCollection;
                    _itemType = genericType.TypeArguments[0];
                }
                else
                {
                    _typeKind = TypeKind.Single;
                    _itemType = _type;
                }
            }
            else
            {
                _typeKind = TypeKind.Single;
                _itemType = _type;
            }
            ResolveItemType();
            var type = _coreType;
            while (type is not null)
            {
                var typeName = type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
                if (typeName == MetaDslxTypes.MetaDslxTypeSymbolType)
                {
                    _isSymbol = true;
                    _isTypeSymbol = true;
                    break;
                }
                else if (typeName == MetaDslxTypes.MetaDslxSymbolType)
                {
                    _isSymbol = true;
                    break;
                }
                else
                {
                    type = type.BaseType;
                }
            }
            _isModelObject = _coreType.AllInterfaces.Any(intf => intf.Name == "IModelObjectCore");
        }

        private bool ResolveItemType()
        {
            var nullable = false;
            _coreType = _itemType;
            if (_itemType is INamedTypeSymbol namedType && namedType.IsGenericType && namedType.TypeArguments.Length == 1 &&
                namedType.OriginalDefinition.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Nullable<>")
            {
                nullable = true;
                _coreType = namedType.TypeArguments[0];
            }
            else if (_itemType.NullableAnnotation == Microsoft.CodeAnalysis.NullableAnnotation.Annotated)
            {
                nullable = true;
                _coreType = _itemType.OriginalDefinition;
            }
            _itemTypeKind = ItemTypeKind.None;
            if (nullable)
            {
                _itemTypeKind |= ItemTypeKind.Nullable;
            }
            var coreTypeName = _coreType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat);
            if (coreTypeName == "System.Type")
            {
                _itemTypeKind |= ItemTypeKind.SystemType;
            }
            else if (_coreType is INamedTypeSymbol enumType && enumType.BaseType?.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat) == "System.Enum")
            {
                _itemTypeKind |= ItemTypeKind.EnumType;
            }
            else
            {
                switch (coreTypeName)
                {
                    case "bool":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.BoolType;
                        break;
                    case "byte":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.ByteType;
                        break;
                    case "sbyte":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.SByteType;
                        break;
                    case "short":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.ShortType;
                        break;
                    case "ushort":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.UShortType;
                        break;
                    case "int":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.IntType;
                        break;
                    case "uint":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.UIntType;
                        break;
                    case "long":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.LongType;
                        break;
                    case "ulong":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.ULongType;
                        break;
                    case "float":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.FloatType;
                        break;
                    case "double":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.DoubleType;
                        break;
                    case "char":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.CharType;
                        break;
                    case "string":
                        _itemTypeKind |= ItemTypeKind.PrimitiveType | ItemTypeKind.StringType;
                        break;
                    case "object":
                        _itemTypeKind |= ItemTypeKind.ObjectType;
                        break;
                    default:
                        _itemTypeKind |= ItemTypeKind.OtherType;
                        break;
                }
            }
            return true;
        }

        public bool TryResolveValues(ImmutableArray<string> valueTexts, Location location, bool addDiagnostics, string? diagnosticContext, out ImmutableArray<object> values)
        {
            if (CoreType is null) return false;
            var builder = ArrayBuilder<object?>.GetInstance();
            var success = true;
            foreach (var valueText in valueTexts)
            {
                if (TryResolveValue(valueText, location, addDiagnostics, diagnosticContext, out var argValue))
                {
                    builder.Add(argValue);
                }
                else
                {
                    success = false;
                }
            }
            if (TypeKind == TypeKind.Single)
            {
                if (valueTexts.Length == 0)
                {
                    if (addDiagnostics) _language.Error(location, $"Missing value. Exactly one value must be specified for {Type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}");
                    success = false;
                }
                else if (valueTexts.Length > 1)
                {
                    if (addDiagnostics) _language.Error(location, $"Invalid array of values. Exactly one value must be specified for {Type.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}");
                    success = false;
                }
            }
            values = builder.ToImmutableAndFree();
            return success;
        }

        public bool TryResolveValue(string valueText, Location location, bool addDiagnostics, string? diagnosticContext, out object? value)
        {
            value = null;
            if (string.IsNullOrWhiteSpace(valueText) || valueText == "null")
            {
                if (!ItemTypeKind.HasFlag(ItemTypeKind.Nullable))
                {
                    if (addDiagnostics) _language.Error(location, $"{diagnosticContext}'null' is an invalid value for {ItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}");
                    return false;
                }
            }
            else
            {
                if (ItemTypeKind.HasFlag(ItemTypeKind.SystemType))
                {
                    var typeSymbols = _language.ResolveSymbols(location, addDiagnostics, "type", valueText.Split('.').ToImmutableArray()).OfType<INamedTypeSymbol>().ToImmutableArray();
                    if (typeSymbols.Length == 1) value = typeSymbols[0];
                    return typeSymbols.Length == 1;
                }
                else if (ItemTypeKind.HasFlag(ItemTypeKind.EnumType))
                {
                    var enumType = CoreType as INamedTypeSymbol;
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
                            _language.Error(location, $"{diagnosticContext}'{valueText}' is an invalid enum literal for '{ItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'. Valid literals are: {builder.ToStringAndFree()}");
                        }
                        return false;
                    }
                    else if (enumLiterals.Length == 1)
                    {
                        value = valueText;
                        return true;
                    }
                    else
                    {
                        if (addDiagnostics) _language.Error(location, $"{diagnosticContext}'{valueText}' enum literal is not unique in '{ItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}'");
                        return false;
                    }
                }
                else if (ItemTypeKind.HasFlag(ItemTypeKind.ObjectType))
                {
                    value = valueText;
                    return true;
                }
                else if (TryParseValue(valueText, out var primitiveValue))
                {
                    value = primitiveValue;
                    return true;
                }
                else
                {
                    if (addDiagnostics) _language.Error(location, $"{diagnosticContext}'{ItemType.ToDisplayString(SymbolDisplayFormat.CSharpErrorMessageFormat)}' is an invalid type for binder and annotation parameters. The type must be either a primitive type, a string, an enum or System.Type.");
                    return false;
                }
            }
            return true;
        }

        public bool TryParseValue(string valueText, out object? value)
        {
            value = null;
            if (valueText == "null")
            {
                value = null;
                return ItemTypeKind.HasFlag(ItemTypeKind.Nullable);
            }
            else
            {
                var coreKind = ItemTypeKind & ~ItemTypeKind.PrimitiveType & ~ItemTypeKind.Nullable;
                switch (coreKind)
                {
                    case ItemTypeKind.BoolType: if (bool.TryParse(valueText, out var boolValue)) { value = boolValue; return true; } else { return false; };
                    case ItemTypeKind.ByteType: if (byte.TryParse(valueText, out var byteValue)) { value = byteValue; return true; } else { return false; };
                    case ItemTypeKind.SByteType: if (sbyte.TryParse(valueText, out var sbyteValue)) { value = sbyteValue; return true; } else { return false; };
                    case ItemTypeKind.ShortType: if (short.TryParse(valueText, out var shortValue)) { value = shortValue; return true; } else { return false; };
                    case ItemTypeKind.UShortType: if (ushort.TryParse(valueText, out var ushortValue)) { value = ushortValue; return true; } else { return false; };
                    case ItemTypeKind.IntType: if (int.TryParse(valueText, out var intValue)) { value = intValue; return true; } else { return false; };
                    case ItemTypeKind.UIntType: if (uint.TryParse(valueText, out var uintValue)) { value = uintValue; return true; } else { return false; };
                    case ItemTypeKind.LongType: if (long.TryParse(valueText, out var longValue)) { value = longValue; return true; } else { return false; };
                    case ItemTypeKind.ULongType: if (ulong.TryParse(valueText, out var ulongValue)) { value = ulongValue; return true; } else { return false; };
                    case ItemTypeKind.FloatType: if (float.TryParse(valueText, out var floatValue)) { value = floatValue; return true; } else { return false; };
                    case ItemTypeKind.DoubleType: if (double.TryParse(valueText, out var doubleValue)) { value = doubleValue; return true; } else { return false; };
                    case ItemTypeKind.DecimalType: if (decimal.TryParse(valueText, out var decimalValue)) { value = decimalValue; return true; } else { return false; };
                    case ItemTypeKind.CharType: if (valueText.StartsWith("'") && valueText.EndsWith("'")) { value = StringUtilities.DecodeChar(valueText); return true; } else { return false; };
                    case ItemTypeKind.StringType: if (valueText.StartsWith("\"") && valueText.EndsWith("\"")) { value = StringUtilities.DecodeString(valueText); return true; } else if (StringUtilities.IsIdentifier(valueText)) { value = valueText; return true; } else { return false; };
                    default: return false;
                }
            }
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
            "System.Collections.Generic.ICollection<>",
            "System.Collections.Generic.IList<>",
            "System.Collections.Generic.List<>",
            "System.Collections.Generic.LinkedList<>",
            "System.Collections.Generic.HashSet<>",
            "System.Collections.Generic.SortedSet<>",
        };

    }
}
