using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Model
{
    using Compilation = Microsoft.CodeAnalysis.Compilation;

    internal class MetaProperty
    {
        private MetaClass _metaClass;
        private IPropertySymbol _propertySymbol;
        private ModelPropertyFlags _flags;
        private ITypeSymbol? _type;
        private object? _defaultValue;
        private string _csharpType;
        private ImmutableArray<MetaProperty> _oppositeProperties;
        private ImmutableArray<MetaProperty> _subsettedProperties;
        private ImmutableArray<MetaProperty> _redefinedProperties;

        public MetaProperty(MetaClass metaClass, IPropertySymbol propertySymbol)
        {
            _metaClass = metaClass;
            _propertySymbol = propertySymbol;
            _csharpType = _propertySymbol.Type.ToDisplayString();
            foreach (var attr in propertySymbol.GetAttributes())
            {
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DefaultValueAttribute")
                {
                    var arg = attr.ConstructorArguments[0];
                    if (arg.Type != null)
                    {
                        var conversion = metaClass.Compilation.ClassifyCommonConversion(arg.Type, _propertySymbol.Type);
                        if (conversion.Exists)
                        {
                            _defaultValue = arg.Value;
                        }
                        else
                        {
                            // TODO: error
                        }
                    }
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.NameAttribute")
                {
                    _flags |= ModelPropertyFlags.Name;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.TypeAttribute")
                {
                    _flags |= ModelPropertyFlags.Type;
                }
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
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.ReadOnlyAttribute")
                {
                    _flags |= ModelPropertyFlags.ReadOnly;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DerivedAttribute")
                {
                    _flags |= ModelPropertyFlags.Derived | ModelPropertyFlags.ReadOnly;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.DerivedUnionAttribute")
                {
                    _flags |= ModelPropertyFlags.DerivedUnion | ModelPropertyFlags.Derived | ModelPropertyFlags.ReadOnly;
                }
            }
        }

        public Compilation Compilation => _metaClass.Compilation;
        public SourceProductionContext Context => _metaClass.Context;
        public MetaModelInfo MetaModel => _metaClass.MetaModel;
        public MetaClass MetaClass => _metaClass;
        public IPropertySymbol PropertySymbol => _propertySymbol;
        public object? DefaultValue => _defaultValue;
        public string Name => _propertySymbol.Name;
        public string PropertyName => $"MProperty_{_metaClass.Name}_{_propertySymbol.Name}";
        public string QualifiedPropertyName => $"{_metaClass.Name}.MProperty_{_metaClass.Name}_{_propertySymbol.Name}";
        public string FullyQualifiedPropertyName => $"global::{MetaModel.NamespaceName}.{_metaClass.Name}.MProperty_{_metaClass.Name}_{_propertySymbol.Name}";
        public string CSharpType => _csharpType;
        public string CSharpDefaultValue
        {
            get
            {
                if (_defaultValue == null) return $"default({CSharpType})";
                var type = _defaultValue.GetType();
                if (type == typeof(bool)) return ((bool)_defaultValue) ? "true" : "false";
                if (type == typeof(string))
                {
                    var escapedValue = ((string)_defaultValue).Replace("\\", "\\\\").Replace("\"", "\\\"").Replace("\t", "\\t").Replace("\r", "\\r").Replace("\n", "\\n");
                    return $"\"{escapedValue}\"";
                }
                if (type.IsPrimitive) return _defaultValue.ToString();
                return _defaultValue.ToString();
            }
        }

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
            var type = _propertySymbol.Type;
            var flags = UpdateFlagsWithType(ModelPropertyFlags.None, ref type);
            if (type is INamedTypeSymbol propType)
            {
                if (flags.HasFlag(ModelPropertyFlags.BuiltInType) || flags.HasFlag(ModelPropertyFlags.EnumType) || flags.HasFlag(ModelPropertyFlags.ModelObjectType))
                {
                    _type = type;
                    _flags |= flags;
                    _flags |= ModelPropertyFlags.SingleItem;
                    if (_propertySymbol.IsReadOnly) _flags |= ModelPropertyFlags.ReadOnly;
                }
                else if (propType.IsGenericType && propType.TypeArguments.Length == 1)
                {
                    var innerType = propType.TypeArguments[0];
                    var innerFlags = UpdateFlagsWithType(ModelPropertyFlags.None, ref innerType);
                    if (innerType is INamedTypeSymbol innerNamedType)
                    {
                        if (!_propertySymbol.IsReadOnly)
                        {
                            // TODO: error, must not have setter
                        }
                        if (innerFlags.HasFlag(ModelPropertyFlags.BuiltInType) || innerFlags.HasFlag(ModelPropertyFlags.EnumType) || innerFlags.HasFlag(ModelPropertyFlags.ModelObjectType))
                        {
                            var fullTypeName = propType.ConstructedFrom.ToDisplayString();
                            if (fullTypeName == "System.Collections.Generic.IList<T>")
                            {
                                _type = innerNamedType;
                                _flags |= innerFlags;
                                _flags |= ModelPropertyFlags.Collection;
                            }
                            else if (fullTypeName == "System.Collections.Generic.ICollection<T>")
                            {
                                _type = innerNamedType;
                                _flags |= innerFlags;
                                _flags |= ModelPropertyFlags.Collection;
                            }
                            else if (fullTypeName == "System.Collections.Generic.ISet<T>")
                            {
                                _type = innerNamedType;
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
            }
            if (_type == null)
            {
                _type = type;
                _flags |= flags;
                //_flags |= ModelPropertyFlags.Collection;
                if (!_flags.HasFlag(ModelPropertyFlags.Untracked))
                {
                    _flags |= ModelPropertyFlags.Untracked;
                    // TODO: error, must be untracked or primitive or meta class or collection
                }
            }
        }

        private ModelPropertyFlags UpdateFlagsWithType(ModelPropertyFlags flags, ref ITypeSymbol type)
        {
            if (type.NullableAnnotation == NullableAnnotation.Annotated)
            {
                flags |= ModelPropertyFlags.NullableType;
                if (type.TypeKind == TypeKind.Struct && type is INamedTypeSymbol nts && nts.Name == "Nullable" && nts.TypeArguments.Length == 1)
                {
                    type = nts.TypeArguments[0];
                }
            }
            if (type.IsValueType) flags |= ModelPropertyFlags.ValueType;
            if (type.IsReferenceType) flags |= ModelPropertyFlags.ReferenceType;
            if (type.TypeKind == TypeKind.Enum) flags |= ModelPropertyFlags.EnumType;
            if (IsBuiltInType(type)) flags |= ModelPropertyFlags.BuiltInType;
            if (IsMetaClass(type)) flags |= ModelPropertyFlags.ModelObjectType;
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

        public ImmutableArray<MetaProperty> OppositeProperties
        {
            get
            {
                if (_oppositeProperties.IsDefault)
                {
                    ImmutableInterlocked.InterlockedExchange(ref _oppositeProperties, CollectPropertiesFromAttribute("MetaDslx.Modeling.OppositeAttribute", allowSameProperty: true, onlySelfOrAncestors: false));
                }
                return _oppositeProperties;
            }
        }

        public ImmutableArray<MetaProperty> SubsettedProperties
        {
            get
            {
                if (_subsettedProperties.IsDefault)
                {
                    ImmutableInterlocked.InterlockedExchange(ref _subsettedProperties, CollectPropertiesFromAttribute("MetaDslx.Modeling.SubsetsAttribute", allowSameProperty: false, onlySelfOrAncestors: true));
                }
                return _subsettedProperties;
            }
        }

        public ImmutableArray<MetaProperty> RedefinedProperties
        {
            get
            {
                if (_redefinedProperties.IsDefault)
                {
                    ImmutableInterlocked.InterlockedExchange(ref _redefinedProperties, CollectPropertiesFromAttribute("MetaDslx.Modeling.RedefinesAttribute", allowSameProperty: false, onlySelfOrAncestors: true));
                }
                return _redefinedProperties;
            }
        }

        public ImmutableArray<MetaProperty> GetSubsettingProperties(MetaClass cls)
        {
            var result = ArrayBuilder<MetaProperty>.GetInstance();
            foreach (var prop in cls.AllDeclaredProperties)
            {
                if (prop.SubsettedProperties.Contains(this)) result.Add(prop);
            }
            return result.ToImmutableAndFree();
        }

        public ImmutableArray<MetaProperty> GetRedefiningProperties(MetaClass cls)
        {
            var result = ArrayBuilder<MetaProperty>.GetInstance();
            foreach (var prop in cls.AllDeclaredProperties)
            {
                if (prop.RedefinedProperties.Contains(this)) result.Add(prop);
            }
            return result.ToImmutableAndFree();
        }

        private ImmutableArray<MetaProperty> CollectPropertiesFromAttribute(string attributeName, bool allowSameProperty, bool onlySelfOrAncestors)
        {
            var result = ArrayBuilder<MetaProperty>.GetInstance();
            foreach (var attr in _propertySymbol.GetAttributes())
            {
                if (attr.AttributeClass?.ToDisplayString() == attributeName)
                {
                    var referencedPropertyType = attr.ConstructorArguments[0].Value as INamedTypeSymbol;
                    var referencedPropertyName = attr.ConstructorArguments[1].Value as string;
                    if (referencedPropertyType != null && referencedPropertyName != null)
                    {
                        var referencedClass = MetaModel.GetMetaClass(referencedPropertyType);
                        if (referencedClass != null)
                        {
                            if (onlySelfOrAncestors && !object.ReferenceEquals(referencedClass, this) && !MetaClass.BaseTypes.Contains(referencedClass))
                            {
                                // TODO: error
                                continue;
                            }
                            var referencedProperty = referencedClass.DeclaredProperties.FirstOrDefault(p => p.Name == referencedPropertyName);
                            if (referencedProperty != null)
                            {
                                if (!allowSameProperty && object.ReferenceEquals(referencedProperty, this))
                                {
                                    // TODO: error
                                    continue;
                                }
                                result.Add(referencedProperty);
                            }
                        }
                    }
                }
            }
            return result.ToImmutableAndFree();
        }

        public override string ToString()
        {
            return $"{MetaClass.Name}.{Name}";
        }
    }
}
