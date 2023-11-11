using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    public struct MetaType : IEquatable<MetaType>
    {
        private readonly object? _original;

        private MetaType(string name)
        {
            _original = name;
        }

        private MetaType(Type type)
        {
            _original = type;
        }

        private MetaType(TypeSymbol typeSymbol)
        {
            _original = typeSymbol;
        }

        private MetaType(IModelObject modelObject)
        {
            _original = modelObject;
        }

        public static MetaType FromName(string name) => new MetaType(name);
        public static MetaType FromType(Type type) => new MetaType(type);
        public static MetaType FromTypeSymbol(TypeSymbol typeSymbol) => new MetaType(typeSymbol);
        public static MetaType FromModelObject(IModelObject modelObject) => new MetaType(modelObject);

        public bool IsNull => _original is null;
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
                if (IsNull) return null;
                if (IsType) return OriginalType.Name;
                if (IsTypeSymbol) return OriginalTypeSymbol.Name;
                if (IsModelObject) return OriginalModelObject.Name;
                if (FullName is null) return null;
                var index = FullName.LastIndexOf('.');
                if (index >= 0) return FullName.Substring(index);
                else return FullName;
            }
        }

        public string FullName
        {
            get
            {
                if (IsNull) return null;
                if (IsName) return (string)_original;
                if (IsType) return OriginalType.FullName;
                if (IsTypeSymbol) return SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(OriginalTypeSymbol);
                if (IsModelObject) return MetaSymbol.GetModelObjectFullName(OriginalModelObject);
                return null;
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
                    return typeof(MetaDslx.Modeling.IModelCollection);
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
            if (compilation is null) return OriginalTypeSymbol;
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
            return IsAssignableFrom(type.AsType());
        }

        public bool IsAssignableTo(MetaType type)
        {
            return IsAssignableTo(type.AsType());
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
            else return this.IsNull && obj is null;
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
            return FullName;
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

        public static implicit operator MetaType(Type type)
        {
            return MetaType.FromType(type);
        }

        public static implicit operator MetaType(TypeSymbol typeSymbol)
        {
            return MetaType.FromTypeSymbol(typeSymbol);
        }

        internal static string GetModelObjectFullName(IModelObject modelObject)
        {
            var symbolType = modelObject?.Info?.SymbolType.AsType();
            if (typeof(TypeSymbol).IsAssignableFrom(symbolType))
            {
                var builder = PooledStringBuilder.GetInstance();
                var sb = builder.Builder;
                var current = modelObject;
                var valid = !string.IsNullOrEmpty(current.Name);
                sb.Append(current.Name);
                while (valid && current is not null)
                {
                    var parent = current.Parent;
                    if (!string.IsNullOrEmpty(parent?.Name))
                    {
                        sb.Insert(0, ".");
                        sb.Insert(0, parent.Name);
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
    }
}
