using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis
{
    using TypeKind = Microsoft.CodeAnalysis.TypeKind;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using NullableAnnotation = Microsoft.CodeAnalysis.NullableAnnotation;

    public struct MetaType : IEquatable<MetaType>
    {
        private const string EnumFullName = "global::System.Enum";

        private object? _original;

        private MetaType(string? name)
        {
            _original = name ?? (object)typeof(Null);
        }

        private MetaType(Type? type)
        {
            _original = type ?? typeof(Null);
        }

        private MetaType(TypeSymbol? typeSymbol)
        {
            _original = typeSymbol ?? (object)typeof(Null);
        }

        private MetaType(IModelObject? modelObject)
        {
            _original = modelObject ?? (object)typeof(Null);
        }

        public static MetaType FromName(string? name) => new MetaType(name);
        public static MetaType FromType(Type? type) => new MetaType(type);
        public static MetaType FromTypeSymbol(TypeSymbol? typeSymbol) => new MetaType(typeSymbol);
        public static MetaType FromModelObject(IModelObject? modelObject) => new MetaType(modelObject);

        public bool InterlockedInitialize(MetaType value)
        {
            return Interlocked.CompareExchange(ref _original, value._original, null) == null;
        }

        public bool IsDefault => OriginalType == null;
        public bool IsDefaultOrNull => IsDefault || IsNull;
        public bool IsNull => (_original as Type) == typeof(Null);
        public bool IsName => _original is string;
        public bool IsType => _original is Type;
        public bool IsTypeSymbol => _original is TypeSymbol;
        public bool IsModelObject => _original is IModelObject || _original is IModelSymbol ms && ms.ModelObject is not null;

        public object? Original => _original;
        public Type? OriginalType => _original as Type;
        public TypeSymbol? OriginalTypeSymbol => _original as TypeSymbol;
        public IModelObject? OriginalModelObject
        {
            get
            {
                if (_original is IModelObject modelObject) return modelObject;
                if (_original is IModelSymbol modelSymbol) return modelSymbol?.ModelObject;
                return null;
            }
        }

        public string Name
        {
            get
            {
                if (IsDefaultOrNull) return null;
                if (IsType) return OriginalType.Name;
                if (IsTypeSymbol) return OriginalTypeSymbol.Name;
                if (IsModelObject) return OriginalModelObject.MName;
                if (FullName is null) return null;
                var index = FullName.LastIndexOf('.');
                if (index >= 0) return FullName.Substring(index);
                else return FullName;
            }
        }

        public string MetadataName
        {
            get
            {
                if (IsDefaultOrNull) return null;
                switch (this.SpecialType)
                {
                    case SpecialType.None:
                        return null;
                    case SpecialType.System_Object:
                        return "System.Object";
                    case SpecialType.System_Enum:
                        return "System.Enum";
                    case SpecialType.System_MulticastDelegate:
                        return "System.MulticastDelegate";
                    case SpecialType.System_Delegate:
                        return "System.Delegate";
                    case SpecialType.System_ValueType:
                        return "System.ValueType";
                    case SpecialType.System_Void:
                        return "System.Void";
                    case SpecialType.System_Boolean:
                        return "System.Boolean";
                    case SpecialType.System_Char:
                        return "System.Char";
                    case SpecialType.System_SByte:
                        return "System.SByte";
                    case SpecialType.System_Byte:
                        return "System.Byte";
                    case SpecialType.System_Int16:
                        return "System.Int16";
                    case SpecialType.System_UInt16:
                        return "System.UInt16";
                    case SpecialType.System_Int32:
                        return "System.Int32";
                    case SpecialType.System_UInt32:
                        return "System.UInt32";
                    case SpecialType.System_Int64:
                        return "System.Int64";
                    case SpecialType.System_UInt64:
                        return "System.UInt64";
                    case SpecialType.System_Decimal:
                        return "System.Decimal";
                    case SpecialType.System_Single:
                        return "System.Single";
                    case SpecialType.System_Double:
                        return "System.Double";
                    case SpecialType.System_String:
                        return "System.String";
                    case SpecialType.System_IntPtr:
                        return "System.IntPtr";
                    case SpecialType.System_UIntPtr:
                        return "System.UIntPtr";
                    case SpecialType.System_Array:
                        return "System.Array";
                    case SpecialType.System_Collections_IEnumerable:
                        return "System.Collections.IEnumerable";
                    case SpecialType.System_Collections_Generic_IEnumerable_T:
                        return "System.Collections.Generic.IEnumerable`1";
                    case SpecialType.System_Collections_Generic_IList_T:
                        return "System.Collections.Generic.IList`1";
                    case SpecialType.System_Collections_Generic_ICollection_T:
                        return "System.Collections.Generic.ICollection`1";
                    case SpecialType.System_Collections_IEnumerator:
                        return "System.Collections.IEnumerator";
                    case SpecialType.System_Collections_Generic_IEnumerator_T:
                        return "System.Collections.Generic.IEnumerator`1";
                    case SpecialType.System_Collections_Generic_IReadOnlyList_T:
                        return "System.Collections.Generic.IReadOnlyList`1";
                    case SpecialType.System_Collections_Generic_IReadOnlyCollection_T:
                        return "System.Collections.Generic.IReadOnlyCollection`1";
                    case SpecialType.System_Nullable_T:
                        return "System.Nullable`1";
                    case SpecialType.System_DateTime:
                        return "System.DateTime";
                    case SpecialType.System_Runtime_CompilerServices_IsVolatile:
                        return "System.Runtime.CompilerServices.IsVolatile";
                    case SpecialType.System_IDisposable:
                        return "System.IDisposable";
                    case SpecialType.System_TypedReference:
                        return "System.TypedReference";
                    case SpecialType.System_ArgIterator:
                        return "System.ArgIterator";
                    case SpecialType.System_RuntimeArgumentHandle:
                        return "System.RuntimeArgumentHandle";
                    case SpecialType.System_RuntimeFieldHandle:
                        return "System.RuntimeFieldHandle";
                    case SpecialType.System_RuntimeMethodHandle:
                        return "System.RuntimeMethodHandle";
                    case SpecialType.System_RuntimeTypeHandle:
                        return "System.RuntimeTypeHandle";
                    case SpecialType.System_IAsyncResult:
                        return "System.IAsyncResult";
                    case SpecialType.System_AsyncCallback:
                        return "System.AsyncCallback";
                    case SpecialType.System_Runtime_CompilerServices_RuntimeFeature:
                        return "System.Runtime.CompilerServices.RuntimeFeature";
                    case SpecialType.System_Runtime_CompilerServices_PreserveBaseOverridesAttribute:
                        return "System.Runtime.CompilerServices.PreserveBaseOverridesAttribute";
                    case SpecialType.System_Type:
                        return "System.Type";
                    case SpecialType.MetaDslx_CodeAnalysis_MetaType:
                        return "MetaDslx.CodeAnalysis.MetaType";
                    case SpecialType.MetaDslx_CodeAnalysis_MetaSymbol:
                        return "MetaDslx.CodeAnalysis.MetaSymbol";
                    case SpecialType.MetaDslx_Modeling_Model:
                        return "MetaDslx.Modeling.Model";
                    case SpecialType.MetaDslx_Modeling_ModelGroup:
                        return "MetaDslx.Modeling.ModelGroup";
                    case SpecialType.MetaDslx_Modeling_MetaModel:
                        return "MetaDslx.Modeling.MetaModel";
                    case SpecialType.MetaDslx_Modeling_IModelObject:
                        return "MetaDslx.Modeling.IModelObject";
                    case SpecialType.MetaDslx_Modeling_ModelObject:
                        return "MetaDslx.Modeling.ModelObject";
                    case SpecialType.MetaDslx_Modeling_ModelProperty:
                        return "MetaDslx.Modeling.ModelProperty";
                    case SpecialType.MetaDslx_Modeling_IModelCollection:
                        return "MetaDslx.Modeling.IModelCollection";
                    case SpecialType.MetaDslx_CodeAnalysis_Symbol:
                        return "MetaDslx.CodeAnalysis.Symbol";
                    case SpecialType.MetaDslx_CodeAnalysis_AssemblySymbol:
                        return "MetaDslx.CodeAnalysis.AssemblySymbol";
                    case SpecialType.MetaDslx_CodeAnalysis_ModuleSymbol:
                        return "MetaDslx.CodeAnalysis.ModuleSymbol";
                    case SpecialType.MetaDslx_CodeAnalysis_TypeSymbol:
                        return "MetaDslx.CodeAnalysis.TypeSymbol";
                    case SpecialType.MetaDslx_CodeAnalysis_NamespaceSymbol:
                        return "MetaDslx.CodeAnalysis.NamespaceSymbol";
                    default:
                        break;
                }
                if (IsName) return (string)_original;
                if (IsType) return OriginalType.FullName;
                if (IsTypeSymbol) return SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(OriginalTypeSymbol);
                if (IsModelObject) return MetaSymbol.GetModelObjectFullName(OriginalModelObject);
                return null;
            }
        }

        public string FullName
        {
            get
            {
                if (IsDefaultOrNull) return null;
                string? result = null;
                if (result is null && IsName) result = (string)_original;
                if (result is null && IsType) result = OriginalType.FullName;
                if (result is null && IsTypeSymbol) result = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(OriginalTypeSymbol);
                if (result is null && IsModelObject) result = MetaSymbol.GetModelObjectFullName(OriginalModelObject);
                switch (result)
                {
                    case "void":
                        return "System.Void";
                    case "object":
                        return "System.Object";
                    case "bool":
                        return "System.Boolean";
                    case "char":
                        return "System.Char";
                    case "string":
                        return "System.String";
                    case "byte":
                        return "System.Byte";
                    case "sbyte":
                        return "System.SByte";
                    case "short":
                        return "System.Int16";
                    case "ushort":
                        return "System.UInt16";
                    case "int":
                        return "System.Int32";
                    case "uint":
                        return "System.UInt32";
                    case "long":
                        return "System.Int64";
                    case "ulong":
                        return "System.UInt64";
                    case "float":
                        return "System.Single";
                    case "double":
                        return "System.Double";
                    case "decimal":
                        return "System.Decimal";
                    case "type":
                        return "MetaDslx.CodeAnalysis.MetaType";
                    case "symbol":
                        return "MetaDslx.CodeAnalysis.MetaSymbol";
                    default:
                        return result;
                }
            }
        }

        public string? MetaKeyword
        {
            get
            {
                switch (FullName)
                {
                    case "void":
                    case "System.Void":
                        return "void";
                    case "object":
                    case "System.Object":
                        return "object";
                    case "bool":
                    case "System.Boolean":
                        return "bool";
                    case "char":
                    case "System.Char":
                        return "char";
                    case "string":
                    case "System.String":
                        return "string";
                    case "byte":
                    case "System.Byte":
                        return "byte";
                    case "sbyte":
                    case "System.SByte":
                        return "sbyte";
                    case "short":
                    case "System.Int16":
                        return "short";
                    case "ushort":
                    case "System.UInt16":
                        return "ushort";
                    case "int":
                    case "System.Int32":
                        return "int";
                    case "uint":
                    case "System.UInt32":
                        return "uint";
                    case "long":
                    case "System.Int64":
                        return "long";
                    case "ulong":
                    case "System.UInt64":
                        return "ulong";
                    case "float":
                    case "System.Single":
                        return "float";
                    case "double":
                    case "System.Double":
                        return "double";
                    case "decimal":
                    case "System.Decimal":
                        return "decimal";
                    case "type":
                    case "MetaDslx.CodeAnalysis.MetaType":
                        return "type";
                    case "symbol":
                    case "MetaDslx.CodeAnalysis.MetaSymbol":
                        return "symbol";
                    default:
                        return null;
                }
            }
        }

        public string? CSharpKeyword
        {
            get
            {
                switch (FullName)
                {
                    case "void":
                    case "System.Void":
                        return "void";
                    case "object":
                    case "System.Object":
                        return "object";
                    case "bool":
                    case "System.Boolean":
                        return "bool";
                    case "char":
                    case "System.Char":
                        return "char";
                    case "string":
                    case "System.String":
                        return "string";
                    case "byte":
                    case "System.Byte":
                        return "byte";
                    case "sbyte":
                    case "System.SByte":
                        return "sbyte";
                    case "short":
                    case "System.Int16":
                        return "short";
                    case "ushort":
                    case "System.UInt16":
                        return "ushort";
                    case "int":
                    case "System.Int32":
                        return "int";
                    case "uint":
                    case "System.UInt32":
                        return "uint";
                    case "long":
                    case "System.Int64":
                        return "long";
                    case "ulong":
                    case "System.UInt64":
                        return "ulong";
                    case "float":
                    case "System.Single":
                        return "float";
                    case "double":
                    case "System.Double":
                        return "double";
                    case "decimal":
                    case "System.Decimal":
                        return "decimal";
                    default:
                        return null;
                }
            }
        }

        public SpecialType SpecialType
        {
            get
            {
                switch (FullName)
                {
                    case "void":
                    case "System.Void":
                        return SpecialType.System_Void;
                    case "object":
                    case "System.Object":
                        return SpecialType.System_Object;
                    case "enum":
                    case "System.Enum":
                        return SpecialType.System_Enum;
                    case "System.ValueType":
                        return SpecialType.System_ValueType;
                    case "System.Delegate":
                        return SpecialType.System_Delegate;
                    case "System.MulticastDelegate":
                        return SpecialType.System_MulticastDelegate;
                    case "bool":
                    case "System.Boolean":
                        return SpecialType.System_Boolean;
                    case "char":
                    case "System.Char":
                        return SpecialType.System_Char;
                    case "string":
                    case "System.String":
                        return SpecialType.System_String;
                    case "byte":
                    case "System.Byte":
                        return SpecialType.System_Byte;
                    case "sbyte":
                    case "System.SByte":
                        return SpecialType.System_SByte;
                    case "short":
                    case "System.Int16":
                        return SpecialType.System_Int16;
                    case "ushort":
                    case "System.UInt16":
                        return SpecialType.System_UInt16;
                    case "int":
                    case "System.Int32":
                        return SpecialType.System_Int32;
                    case "uint":
                    case "System.UInt32":
                        return SpecialType.System_UInt32;
                    case "long":
                    case "System.Int64":
                        return SpecialType.System_Int64;
                    case "ulong":
                    case "System.UInt64":
                        return SpecialType.System_UInt64;
                    case "float":
                    case "System.Single":
                        return SpecialType.System_Single;
                    case "double":
                    case "System.Double":
                        return SpecialType.System_Double;
                    case "decimal":
                    case "System.Decimal":
                        return SpecialType.System_Decimal;
                    case "System.IntPtr":
                        return SpecialType.System_IntPtr;
                    case "System.UIntPtr":
                        return SpecialType.System_UIntPtr;
                    case "System.Array":
                        return SpecialType.System_Array;
                    case "System.Collections.IEnumerable":
                        return SpecialType.System_Collections_IEnumerable;
                    case "System.Collections.Generic.IEnumerable`1":
                        return SpecialType.System_Collections_Generic_IEnumerable_T;
                    case "System.Collections.Generic.IList`1":
                        return SpecialType.System_Collections_Generic_IList_T;
                    case "System.Collections.Generic.ICollection`1":
                        return SpecialType.System_Collections_Generic_ICollection_T;
                    case "System.Collections.IEnumerator":
                        return SpecialType.System_Collections_IEnumerator;
                    case "System.Collections.Generic.IEnumerator`1":
                        return SpecialType.System_Collections_Generic_IEnumerator_T;
                    case "System.Collections.Generic.IReadOnlyList`1":
                        return SpecialType.System_Collections_Generic_IReadOnlyList_T;
                    case "System.Collections.Generic.IReadOnlyCollection`1":
                        return SpecialType.System_Collections_Generic_IReadOnlyCollection_T;
                    case "System.Nullable`1":
                        return SpecialType.System_Nullable_T;
                    case "System.DateTime":
                        return SpecialType.System_DateTime;
                    case "System.IDisposable":
                        return SpecialType.System_IDisposable;
                    case "System.Type":
                        return SpecialType.System_Type;
                    case "type":
                    case "MetaDslx.CodeAnalysis.MetaType":
                        return SpecialType.MetaDslx_CodeAnalysis_MetaType;
                    case "symbol":
                    case "MetaDslx.CodeAnalysis.MetaSymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_MetaSymbol;
                    case "MetaDslx.CodeAnalysis.Symbols.Symbol":
                        return SpecialType.MetaDslx_CodeAnalysis_Symbol;
                    case "MetaDslx.CodeAnalysis.Symbols.AssemblySymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_AssemblySymbol;
                    case "MetaDslx.CodeAnalysis.Symbols.ModuleSymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_ModuleSymbol;
                    case "MetaDslx.CodeAnalysis.Symbols.TypeSymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_TypeSymbol;
                    case "MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_NamespaceSymbol;
                    case "MetaDslx.Modeling.Model":
                        return SpecialType.MetaDslx_Modeling_Model;
                    case "MetaDslx.Modeling.ModelGroup":
                        return SpecialType.MetaDslx_Modeling_ModelGroup;
                    case "MetaDslx.Modeling.MetaModel":
                        return SpecialType.MetaDslx_Modeling_MetaModel;
                    case "MetaDslx.Modeling.IModelObject":
                        return SpecialType.MetaDslx_Modeling_IModelObject;
                    case "MetaDslx.Modeling.ModelObject":
                        return SpecialType.MetaDslx_Modeling_ModelObject;
                    case "MetaDslx.Modeling.ModelProperty":
                        return SpecialType.MetaDslx_Modeling_ModelProperty;
                    case "MetaDslx.Modeling.IModelCollection":
                        return SpecialType.MetaDslx_Modeling_IModelCollection;
                    default:
                        return SpecialType.None;
                }
            }
        }

        public bool IsPrimitive
        {
            get
            {
                switch (SpecialType)
                {
                    case SpecialType.System_Void:
                    case SpecialType.System_Boolean:
                    case SpecialType.System_Char:
                    case SpecialType.System_SByte:
                    case SpecialType.System_Byte:
                    case SpecialType.System_Int16:
                    case SpecialType.System_UInt16:
                    case SpecialType.System_Int32:
                    case SpecialType.System_UInt32:
                    case SpecialType.System_Int64:
                    case SpecialType.System_UInt64:
                    case SpecialType.System_Decimal:
                    case SpecialType.System_Single:
                    case SpecialType.System_Double:
                    case SpecialType.System_String:
                        return true;
                    default:
                        return false;
                }
            }
        }

        public bool IsEnum
        {
            get
            {
                var type = AsType();
                if (type is not null) return type.IsEnum;
                var csts = OriginalTypeSymbol as CSharpTypeSymbol;
                if (csts is not null) return csts.CSharpSymbol.TypeKind == Microsoft.CodeAnalysis.TypeKind.Enum || csts.CSharpSymbol.BaseType?.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.FullyQualifiedFormat) == EnumFullName;
                return false;
            }
        }

        public bool TryGetEnumValue(string name, out MetaSymbol value, DiagnosticBag diagnostics = null, CancellationToken cancellationToken = default)
        {
            var type = AsType();
            if (type is not null && type.IsEnum)
            {
                try
                {
                    value = MetaSymbol.FromValue(Enum.Parse(type, name));
                    return true;
                }
                catch
                {
                    value = default;
                    return false;
                }
            }
            var csts = OriginalTypeSymbol as CSharpTypeSymbol;
            if (csts is not null && (csts.CSharpSymbol.TypeKind == TypeKind.Enum || csts.CSharpSymbol.BaseType?.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.FullyQualifiedFormat) == EnumFullName))
            {
                var literal = csts.CSharpSymbol.GetMembers(name).FirstOrDefault();
                if (literal is not null)
                {
                    bool freeDiagnostics = diagnostics is null;
                    if (freeDiagnostics) diagnostics = DiagnosticBag.GetInstance();
                    var symbol = csts.SymbolFactory.GetSymbol(literal, diagnostics, cancellationToken);
                    if (freeDiagnostics) diagnostics.Free();
                    value = symbol;
                    return symbol is not null && !symbol.IsError;
                }
            }
            value = default;
            return false;
        }

        public bool IsValueType
        {
            get
            {
                var type = AsType();
                if (type is not null) return type.IsValueType;
                var csts = OriginalTypeSymbol as CSharpTypeSymbol;
                if (csts is not null) return csts.CSharpSymbol.IsValueType;
                return false;
            }
        }

        public bool IsNullable
        {
            get
            {
                var type = AsType();
                if (type is not null)
                {
                    if (type.Namespace == "System" && type.Name == "Nullable`1" && type.GenericTypeArguments.Length == 1)
                    {
                        return true;
                    }
                    if (type.CustomAttributes.Any(x => x.AttributeType.Name == "NullableAttribute"))
                    {
                        return true;
                    }
                }
                var csts = OriginalTypeSymbol as CSharpTypeSymbol;
                var msts = csts?.CSharpSymbol as ITypeSymbol;
                if (msts is not null && msts.NullableAnnotation == NullableAnnotation.Annotated)
                {
                    if (msts.TypeKind == TypeKind.Struct && msts is INamedTypeSymbol nts && nts.Name == "Nullable" && nts.TypeArguments.Length == 1)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        public bool TryExtractNullableType(out MetaType innerType, DiagnosticBag diagnostics = null, CancellationToken cancellationToken = default)
        {
            var type = AsType();
            if (type is not null)
            {
                if (type.Namespace == "System" && type.Name == "Nullable`1" && type.GenericTypeArguments.Length == 1)
                {
                    innerType = type.GenericTypeArguments[0];
                    return true;
                }
                if (type.CustomAttributes.Any(x => x.AttributeType.Name == "NullableAttribute"))
                {
                    innerType = type;
                    return true;
                }
            }
            var csts = OriginalTypeSymbol as CSharpTypeSymbol;
            var msts = csts?.CSharpSymbol as ITypeSymbol;
            if (msts is not null && msts.NullableAnnotation == NullableAnnotation.Annotated)
            {
                if (msts.TypeKind == TypeKind.Struct && msts is INamedTypeSymbol nts && nts.Name == "Nullable" && nts.TypeArguments.Length == 1)
                {
                    bool freeDiagnostics = diagnostics is null;
                    if (freeDiagnostics) diagnostics = DiagnosticBag.GetInstance();
                    var symbol = csts.SymbolFactory.GetSymbol<TypeSymbol>(nts.TypeArguments[0], diagnostics, cancellationToken);
                    if (freeDiagnostics) diagnostics.Free();
                    if (symbol is not null && !symbol.IsError)
                    {
                        innerType = symbol;
                        return true;
                    }
                    else
                    {
                        innerType = default;
                        return false;
                    }
                }
            }
            innerType = this;
            return false;
        }

        public bool IsCollection
        {
            get
            {
                var type = AsType();
                if (type is not null)
                {
                    if (type.GenericTypeArguments.Length == 1)
                    {
                        if (type.FullName == "System.Nullable")
                        {
                            return false;
                        }
                        else if (type.Namespace == "System.Collections.Generic")
                        {
                            return true;
                        }
                        else if (type.Namespace == "System.Collections.Immutable")
                        {
                            return true;
                        }
                        else if (type.GetInterfaces().Any(intf => intf == typeof(IList<>)))
                        {
                            return true;
                        }
                        else if (type.GetInterfaces().Any(intf => intf == typeof(ISet<>)))
                        {
                            return true;
                        }
                        else if (type.GetInterfaces().Any(intf => intf == typeof(ICollection<>)))
                        {
                            return true;
                        }
                    }
                }
                var csts = OriginalTypeSymbol as CSharpTypeSymbol;
                var msts = csts?.CSharpSymbol as INamedTypeSymbol;
                if (msts is not null && msts.IsGenericType && msts.TypeArguments.Length == 1)
                {
                    if (msts.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.FullyQualifiedFormat).StartsWith("global::System.Nullable<")) return false;
                    else return true;
                }
                return false;
            }
        }

        public bool TryExtractCollectionType(out MetaType itemType, DiagnosticBag diagnostics = null, CancellationToken cancellationToken = default)
        {
            var type = AsType();
            if (type is not null)
            {
                if (type.GenericTypeArguments.Length == 1)
                {
                    if (type.Namespace == "System.Collections.Generic")
                    {
                        itemType = type.GenericTypeArguments[0];
                        return true;
                    }
                    else if (type.Namespace == "System.Collections.Immutable")
                    {
                        itemType = type.GenericTypeArguments[0];
                        return true;
                    }
                    else if (type.GetInterfaces().Any(intf => intf == typeof(IList<>)))
                    {
                        itemType = type.GenericTypeArguments[0];
                        return true;
                    }
                    else if (type.GetInterfaces().Any(intf => intf == typeof(ISet<>)))
                    {
                        itemType = type.GenericTypeArguments[0];
                        return true;
                    }
                    else if (type.GetInterfaces().Any(intf => intf == typeof(ICollection<>)))
                    {
                        itemType = type.GenericTypeArguments[0];
                        return true;
                    }
                }
            }
            var csts = OriginalTypeSymbol as CSharpTypeSymbol;
            var msts = csts?.CSharpSymbol as INamedTypeSymbol;
            if (msts is not null && msts.IsGenericType && msts.TypeArguments.Length == 1)
            {
                bool freeDiagnostics = diagnostics is null;
                if (freeDiagnostics) diagnostics = DiagnosticBag.GetInstance();
                var symbol = csts.SymbolFactory.GetSymbol<TypeSymbol>(msts.TypeArguments[0], diagnostics, cancellationToken);
                if (freeDiagnostics) diagnostics.Free();
                if (symbol is not null && !symbol.IsError)
                {
                    itemType = symbol;
                    return true;
                }
                else
                {
                    itemType = default;
                    return false;
                }
            }
            itemType = this;
            return false;
        }

        public bool TryGetCoreType(out MetaType coreType, DiagnosticBag diagnostics = null, CancellationToken cancellationToken = default)
        {
            if (this.IsCollection)
            {
                if (this.TryExtractCollectionType(out var itemType, diagnostics, cancellationToken))
                {
                    if (this.IsNullable)
                    {
                        return itemType.TryExtractNullableType(out coreType, diagnostics, cancellationToken);
                    }
                    else
                    {
                        coreType = itemType;
                        return true;
                    }
                }
                else
                {
                    coreType = this;
                    return false;
                }
            }
            else if (this.IsNullable)
            {
                return this.TryExtractNullableType(out coreType, diagnostics, cancellationToken);
            }
            else
            {
                coreType = this;
                return true;
            }
        }

        public object? Extract(bool tryResolveType = false)
        {
            var type = AsType(tryResolveType);
            if (type is not null) return type;
            if (IsTypeSymbol) return OriginalTypeSymbol;
            if (IsModelObject) return OriginalModelObject;
            return FullName;
        }

        public Type? AsType(bool tryResolveType = false)
        {
            var result = AsSpecialType();
            if (result is not null) return result;
            if (IsType) return OriginalType;
            if (!tryResolveType) return null;
            var fullName = this.FullName;
            return AppDomain.CurrentDomain.GetAssemblies().Reverse()
                .Select(assembly => assembly.GetType(fullName))
                .FirstOrDefault(t => t != null);
        }

        public Type? AsSpecialType()
        {
            switch (FullName)
            {
                case "void":
                case "System.Void":
                    return typeof(void);
                case "object":
                case "System.Object":
                    return typeof(object);
                case "enum":
                case "System.Enum":
                    return typeof(System.Enum);
                case "System.ValueType":
                    return typeof(System.ValueType);
                case "System.Delegate":
                    return typeof(System.Delegate);
                case "System.MulticastDelegate":
                    return typeof(System.MulticastDelegate);
                case "bool":
                case "System.Boolean":
                    return typeof(bool);
                case "char":
                case "System.Char":
                    return typeof(char);
                case "string":
                case "System.String":
                    return typeof(string);
                case "byte":
                case "System.Byte":
                    return typeof(byte);
                case "sbyte":
                case "System.SByte":
                    return typeof(sbyte);
                case "short":
                case "System.Int16":
                    return typeof(short);
                case "ushort":
                case "System.UInt16":
                    return typeof(ushort);
                case "int":
                case "System.Int32":
                    return typeof(int);
                case "uint":
                case "System.UInt32":
                    return typeof(uint);
                case "long":
                case "System.Int64":
                    return typeof(long);
                case "ulong":
                case "System.UInt64":
                    return typeof(ulong);
                case "float":
                case "System.Single":
                    return typeof(float);
                case "double":
                case "System.Double":
                    return typeof(double);
                case "decimal":
                case "System.Decimal":
                    return typeof(decimal);
                case "System.IntPtr":
                    return typeof(System.IntPtr);
                case "System.UIntPtr":
                    return typeof(System.UIntPtr);
                case "System.Array":
                    return typeof(System.Array);
                case "System.Collections.IEnumerable":
                    return typeof(System.Collections.IEnumerable);
                case "System.Collections.Generic.IEnumerable`1":
                    return typeof(System.Collections.Generic.IEnumerable<>);
                case "System.Collections.Generic.IList`1":
                    return typeof(System.Collections.Generic.IList<>);
                case "System.Collections.Generic.ICollection`1":
                    return typeof(System.Collections.Generic.ICollection<>);
                case "System.Collections.IEnumerator":
                    return typeof(System.Collections.IEnumerator);
                case "System.Collections.Generic.IEnumerator`1":
                    return typeof(System.Collections.Generic.IEnumerator<>);
                case "System.Collections.Generic.IReadOnlyList`1":
                    return typeof(System.Collections.Generic.IReadOnlyList<>);
                case "System.Collections.Generic.IReadOnlyCollection`1":
                    return typeof(System.Collections.Generic.IReadOnlyCollection<>);
                case "System.Nullable`1":
                    return typeof(System.Nullable<>);
                case "System.DateTime":
                    return typeof(System.DateTime);
                case "System.IDisposable":
                    return typeof(System.IDisposable);
                case "System.Type":
                    return typeof(System.Type);
                case "type":
                case "MetaDslx.CodeAnalysis.MetaType":
                    return typeof(MetaDslx.CodeAnalysis.MetaType);
                case "symbol":
                case "MetaDslx.CodeAnalysis.MetaSymbol":
                    return typeof(MetaDslx.CodeAnalysis.MetaSymbol);
                case "MetaDslx.CodeAnalysis.Symbols.Symbol":
                    return typeof(MetaDslx.CodeAnalysis.Symbols.Symbol);
                case "MetaDslx.CodeAnalysis.Symbols.AssemblySymbol":
                    return typeof(MetaDslx.CodeAnalysis.Symbols.AssemblySymbol);
                case "MetaDslx.CodeAnalysis.Symbols.ModuleSymbol":
                    return typeof(MetaDslx.CodeAnalysis.Symbols.ModuleSymbol);
                case "MetaDslx.CodeAnalysis.Symbols.TypeSymbol":
                    return typeof(MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
                case "MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol":
                    return typeof(MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
                case "MetaDslx.Modeling.Model":
                    return typeof(MetaDslx.Modeling.Model);
                case "MetaDslx.Modeling.ModelGroup":
                    return typeof(MetaDslx.Modeling.ModelGroup);
                case "MetaDslx.Modeling.MetaModel":
                    return typeof(MetaDslx.Modeling.MetaModel);
                case "MetaDslx.Modeling.IModelObject":
                    return typeof(MetaDslx.Modeling.IModelObject);
                case "MetaDslx.Modeling.ModelObject":
                    return typeof(MetaDslx.Modeling.ModelObject);
                case "MetaDslx.Modeling.ModelProperty":
                    return typeof(MetaDslx.Modeling.ModelProperty);
                case "MetaDslx.Modeling.IModelCollection":
                    return typeof(MetaDslx.Modeling.ICollectionSlot);
                default:
                    return null;
            }
        }

        public Type? AsType(string assemblyName)
        {
            if (assemblyName is null) return OriginalType;
            return Type.GetType($"{FullName}, {assemblyName}");
        }

        public Type? AsType(Assembly assembly)
        {
            if (assembly is null) return OriginalType;
            return assembly.GetType(FullName);
        }

        public TypeSymbol? AsTypeSymbol(Compilation compilation)
        {
            if (IsTypeSymbol) return OriginalTypeSymbol;
            return compilation.ResolveType(FullName);
        }

        public IModelObject? AsModelObject(Compilation compilation)
        {
            throw new NotImplementedException();
        }

        public IModelObject? AsModelObject(Model model)
        {
            throw new NotImplementedException();
        }

        public IModelObject? AsModelObject(ModelGroup modelGroup)
        {
            throw new NotImplementedException();
        }

        public bool IsAssignableFrom(Type? type)
        {
            if (type is null) return false;
            var currentType = AsType();
            if ((currentType == typeof(Type) || currentType == typeof(MetaType)) && typeof(TypeSymbol).IsAssignableFrom(type)) return true;
            return currentType is not null && currentType.IsAssignableFrom(type);
        }

        public bool IsAssignableTo(Type? type)
        {
            if (type is null) return false;
            var currentType = AsType();
            return currentType is not null && type.IsAssignableFrom(currentType);
        }

        public bool IsAssignableFrom(MetaType type)
        {
            if (type.IsDefaultOrNull) return false;
            if (this.Equals(type)) return true;
            if (type.IsTypeSymbol)
            {
                if (this.SpecialType == SpecialType.System_Type || this.SpecialType == SpecialType.MetaDslx_CodeAnalysis_MetaType) return true;
                var fullName = this.FullName;
                var typeSymbol = type.OriginalTypeSymbol;
                return typeSymbol.AllBaseTypes.Any(bt => SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(bt) == fullName);
            }
            else
            {
                return IsAssignableFrom(type.AsType());
            }
        }

        public bool IsAssignableTo(MetaType type)
        {
            if (type.IsDefaultOrNull) return false;
            return type.IsAssignableFrom(this);
        }

        public bool Equals(MetaType other)
        {
            var lhsSpecialType = this.SpecialType;
            var rhsSpecialType = other.SpecialType;
            if (lhsSpecialType != SpecialType.None || rhsSpecialType != SpecialType.None) return lhsSpecialType == rhsSpecialType;
            else if (this.IsModelObject && other.IsModelObject) return this.OriginalModelObject == other.OriginalModelObject;
            else return FullName == other.FullName;
        }

        public override bool Equals(object obj)
        {
            if (obj is MetaType mt) return Equals(mt);
            else return this.IsDefault && obj is null;
        }

        public override int GetHashCode()
        {
            var specialType = this.SpecialType;
            if (specialType != SpecialType.None) return specialType.GetHashCode();
            if (this.IsModelObject) return this.OriginalModelObject.GetHashCode();
            return FullName?.GetHashCode() ?? base.GetHashCode();
        }

        public override string ToString()
        {
            var specialName = this.MetaKeyword;
            if (specialName is not null) return specialName;
            else return FullName;
        }

        public static bool operator==(MetaType lhs, MetaType rhs)
        {
            return lhs.Equals(rhs);
        }

        public static bool operator !=(MetaType lhs, MetaType rhs)
        {
            return !lhs.Equals(rhs);
        }

        public static implicit operator MetaType(string fullTypeName)
        {
            return MetaType.FromName(fullTypeName);
        }

        public static implicit operator MetaType(Type? type)
        {
            return MetaType.FromType(type);
        }

        public static implicit operator MetaType(TypeSymbol typeSymbol)
        {
            return MetaType.FromTypeSymbol(typeSymbol);
        }

        internal static string GetModelObjectFullName(IModelObject modelObject)
        {
            var symbolType = modelObject?.MInfo?.SymbolType.AsType();
            if (typeof(TypeSymbol).IsAssignableFrom(symbolType))
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                var current = modelObject;
                var valid = !string.IsNullOrEmpty(current.MName);
                sb.Append(current.MName);
                while (valid && current is not null)
                {
                    var parent = current.MParent;
                    if (!string.IsNullOrEmpty(parent?.MName))
                    {
                        sb.Insert(0, ".");
                        sb.Insert(0, parent.MName);
                    }
                    else
                    {
                        valid = false;
                    }
                    current = parent;
                }
                if (valid)
                {
                    return builder.ToStringAndFree();
                }
                else
                {
                    builder.Free();
                    return null;
                }
            }
            return null;
        }

        private class Null
        {
        }
    }
}
