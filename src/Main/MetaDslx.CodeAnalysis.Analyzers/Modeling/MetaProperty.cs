using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal class MetaProperty
    {
        private MetaClass _metaClass;
        private IPropertySymbol _propertySymbol;
        private ModelPropertyFlags _flags;
        private ITypeSymbol? _type;

        public MetaProperty(MetaClass metaClass, IPropertySymbol propertySymbol)
        {
            _metaClass = metaClass;
            _propertySymbol = propertySymbol;
            foreach (var attr in propertySymbol.GetAttributes())
            {
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.UntrackedAttribute")
                {
                    _flags |= ModelPropertyFlags.Untracked;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.NonUniqueAttribute")
                {
                    _flags |= ModelPropertyFlags.NonUnique;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.UnorderedAttribute")
                {
                    _flags |= ModelPropertyFlags.Unordered;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.ContainmentAttribute")
                {
                    _flags |= ModelPropertyFlags.Containment;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.ReadonlyAttribute")
                {
                    _flags |= ModelPropertyFlags.Readonly;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DerivedAttribute")
                {
                    _flags |= ModelPropertyFlags.Derived;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DerivedUnionAttribute")
                {
                    _flags |= ModelPropertyFlags.DerivedUnion;
                }
            }
        }

        public SourceProductionContext Context => _metaClass.Context;
        public MetaModel MetaModel => _metaClass.MetaModel;
        public MetaClass MetaClass => _metaClass;
        public IPropertySymbol PropertySymbol => _propertySymbol;
        public string Name => _propertySymbol.Name;
        public string PropertyName => $"MProperty_{_metaClass.Name}_{_propertySymbol.Name}";
        public string QualifiedPropertyName => $"{_metaClass.Name}.MProperty_{_metaClass.Name}_{_propertySymbol.Name}";
        public string FullyQualifiedPropertyName => $"global::{MetaModel.NamespaceName}.{_metaClass.Name}.MProperty_{_metaClass.Name}_{_propertySymbol.Name}";
        public string CSharpType => _propertySymbol.Type.ToDisplayString();

        public ModelPropertyFlags Flags
        {
            get
            {
                if (_type == null) ComputeType();
                return _flags;
            }
        }

        public ITypeSymbol Type
        {
            get
            {
                if (_type == null) ComputeType();
                return _type!;
            }
        }

        private void ComputeType()
        {
            if (_type != null) return;
            //Debugger.Launch();
            var flags = UpdateFlagsWithType(ModelPropertyFlags.None, _propertySymbol.Type);
            if (_propertySymbol.Type is INamedTypeSymbol propType)
            {
                if (flags.HasFlag(ModelPropertyFlags.BuiltInType) || flags.HasFlag(ModelPropertyFlags.MetaClassType))
                {
                    _type = _propertySymbol.Type;
                    _flags |= flags;
                    if (_propertySymbol.IsReadOnly) _flags |= ModelPropertyFlags.Readonly;
                }
                else if (propType.IsGenericType && propType.TypeArguments.Length == 1 && propType.TypeArguments[0] is INamedTypeSymbol innerType)
                {
                    var innerFlags = UpdateFlagsWithType(ModelPropertyFlags.None, innerType);
                    if (!_propertySymbol.IsReadOnly)
                    {
                        // TODO: error, must not have setter
                    }
                    if (innerFlags.HasFlag(ModelPropertyFlags.BuiltInType) || innerFlags.HasFlag(ModelPropertyFlags.MetaClassType))
                    {
                        var fullTypeName = propType.ConstructedFrom.ToDisplayString();
                        if (fullTypeName == "System.Collections.Generic.IList<T>")
                        {
                            _type = innerType;
                            _flags |= innerFlags;
                            _flags |= ModelPropertyFlags.Collection;
                        }
                        else if (fullTypeName == "System.Collections.Generic.ICollection<T>")
                        {
                            _type = innerType;
                            _flags |= innerFlags;
                            _flags |= ModelPropertyFlags.Collection;
                        }
                        else if (fullTypeName == "System.Collections.Generic.ISet<T>")
                        {
                            _type = innerType;
                            _flags |= innerFlags;
                            _flags |= ModelPropertyFlags.Collection;
                            if (_flags.HasFlag(ModelPropertyFlags.NonUnique))
                            {
                                // TODO: error
                            }
                        }
                    }
                }
            }
            if (_type == null)
            {
                _type = _propertySymbol.Type;
                _flags |= flags;
                if (!_flags.HasFlag(ModelPropertyFlags.Untracked))
                {
                    _flags |= ModelPropertyFlags.Untracked;
                    // TODO: error, must be untracked or primitive or meta class or collection
                }
            }
        }

        private ModelPropertyFlags UpdateFlagsWithType(ModelPropertyFlags flags, ITypeSymbol type)
        {
            if (type.NullableAnnotation == NullableAnnotation.Annotated) flags |= ModelPropertyFlags.NullableType;
            if (type.IsValueType) flags |= ModelPropertyFlags.ValueType;
            if (type.IsReferenceType) flags |= ModelPropertyFlags.ReferenceType;
            if (IsBuiltInType(type)) flags |= ModelPropertyFlags.BuiltInType;
            if (IsMetaClass(type)) flags |= ModelPropertyFlags.MetaClassType;
            return flags;
        }

        private bool IsMetaClass(ITypeSymbol? type)
        {
            if (type == null) return false;
            return MetaModel.MetaClasses.Any(cls => SymbolEqualityComparer.Default.Equals(cls.ClassInterface, type));
        }

        private bool IsBuiltInType(ITypeSymbol? type)
        {
            if (type == null) return false;
            switch (type.ToDisplayString(NullableFlowState.NotNull))
            {
                case "bool":
                case "byte":
                case "sbyte":
                case "char":
                case "decimal":
                case "double":
                case "float":
                case "int":
                case "uint":
                case "nint":
                case "nuint":
                case "long":
                case "ulong":
                case "short":
                case "ushort":
                case "string":
                    return true;
                default:
                    break;
            }
            return false;
        }


    }
}
