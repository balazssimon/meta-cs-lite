﻿using MetaDslx.CodeAnalysis.PooledObjects;
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
                    case "MetaDslx.CodeAnalysis.Symbol":
                        return SpecialType.MetaDslx_CodeAnalysis_Symbol;
                    case "MetaDslx.CodeAnalysis.AssemblySymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_AssemblySymbol;
                    case "MetaDslx.CodeAnalysis.ModuleSymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_ModuleSymbol;
                    case "MetaDslx.CodeAnalysis.TypeSymbol":
                        return SpecialType.MetaDslx_CodeAnalysis_TypeSymbol;
                    case "MetaDslx.CodeAnalysis.NamespaceSymbol":
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

        public object? Extract(bool tryResolveType = true)
        {
            var type = tryResolveType ? AsType() : OriginalType;
            if (type is not null) return type;
            if (IsTypeSymbol) return OriginalTypeSymbol;
            if (IsModelObject) return OriginalModelObject;
            return FullName;
        }

        public Type? AsType()
        {
            if (IsType) return OriginalType;
            var fullName = this.FullName;
            return AppDomain.CurrentDomain.GetAssemblies().Reverse()
                .Select(assembly => assembly.GetType(fullName))
                .FirstOrDefault(t => t != null);
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
            if (typeof(TypeSymbol).IsAssignableFrom(modelObject?.Info?.SymbolType))
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
