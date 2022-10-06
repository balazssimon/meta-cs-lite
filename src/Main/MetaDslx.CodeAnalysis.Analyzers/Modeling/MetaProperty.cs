using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.NameAttribute")
                {
                    _flags |= ModelPropertyFlags.Name;
                }
                if (attr.AttributeClass?.ToDisplayString() == "MetaDslx.Modeling.TypeAttribute")
                {
                    _flags |= ModelPropertyFlags.Type;
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
        public string CSharpType => _csharpType;

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
    }
}
