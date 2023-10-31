using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling
{
    internal sealed class ReflectionModelObjectInfo : ModelObjectInfo
    {
        private static readonly Type[] EmptyTypes = new Type[0];
        private static readonly object[] EmptyObjects = new object[0];
        private static readonly object lockObject = new object();

        private readonly ReflectionMetaModel _metaModel;
        private readonly Type _metaType;
        private Dictionary<string, ModelProperty>? _publicPropertiesByName;
        private Dictionary<ModelProperty, ModelPropertyInfo>? _modelPropertyInfos;
        private Type? _symbolType;
        private ModelProperty? _nameProperty;
        private ModelProperty? _typeProperty;
        private ImmutableArray<ModelProperty> _declaredProperties;
        private ImmutableArray<ModelProperty> _allDeclaredProperties;
        private ImmutableArray<ModelProperty> _publicProperties;

        public ReflectionModelObjectInfo(ReflectionMetaModel metaModel, Type metaType)
        {
            _metaModel = metaModel;
            _metaType = metaType;
            var symbolAttr = metaType.GetCustomAttribute<SymbolAttribute>(true);
            if (symbolAttr is not null) _symbolType = symbolAttr.SymbolType;
        }

        public override MetaModel MetaModel => _metaModel;
        public override Type MetaType => _metaType;
        public override Type? SymbolType => _symbolType;

        public override IModelObject? Create(Model? model = null, string? id = null)
        {
            var ctr = _metaType.GetConstructor(EmptyTypes);
            if (ctr is not null)
            {
                var mobj = new ReflectionModelObject(ctr.Invoke(EmptyObjects), this, id);
                if (model is not null) model.AddObject(mobj);
                return mobj;
            }
            else
            {
                return null;
            }
        }

        protected override Dictionary<string, ModelProperty> PublicPropertiesByName
        {
            get
            {
                ComputeProperties();
                return _publicPropertiesByName;
            }
        }

        public override ModelProperty? NameProperty
        {
            get
            {
                ComputeProperties();
                return _nameProperty;
            }
        }

        public override ModelProperty? TypeProperty
        {
            get
            {
                ComputeProperties();
                return _typeProperty;
            }
        }

        public override ImmutableArray<ModelProperty> DeclaredProperties
        {
            get
            {
                ComputeProperties();
                return _declaredProperties;
            }
        }

        public override ImmutableArray<ModelProperty> AllDeclaredProperties
        {
            get
            {
                ComputeProperties();
                return _allDeclaredProperties;
            }
        }

        public override ImmutableArray<ModelProperty> PublicProperties
        {
            get
            {
                ComputeProperties();
                return _publicProperties;
            }
        }

        protected override Dictionary<ModelProperty, ModelPropertyInfo> ModelPropertyInfos
        {
            get
            {
                ComputeSlots();
                return _modelPropertyInfos;
            }
        }

        private void ComputeProperties()
        {
            if (_publicPropertiesByName is not null) return;
            var publicPropertiesByName = new Dictionary<string, ModelProperty>();
            ModelProperty? nameProperty = null;
            ModelProperty? typeProperty = null;
            var publicProperties = ArrayBuilder<ModelProperty>.GetInstance();
            var declaredProperties = ArrayBuilder<ModelProperty>.GetInstance();
            var allDeclaredProperties = ArrayBuilder<ModelProperty>.GetInstance();
            foreach (var prop in _metaType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
            {
                var modelProperty = MakeProperty(prop, ref nameProperty, ref typeProperty);
                publicPropertiesByName.Add(prop.Name, modelProperty);
                publicProperties.Add(modelProperty);
                declaredProperties.Add(modelProperty);
            }
            allDeclaredProperties.AddRange(declaredProperties);
            var baseType = _metaType.BaseType;
            while (baseType is not null)
            {
                if (_metaModel.TryGetInfo(baseType, out var baseInfo))
                {
                    foreach (var baseProp in baseInfo.AllDeclaredProperties)
                    {
                        allDeclaredProperties.Add(baseProp);
                        if (!publicPropertiesByName.ContainsKey(baseProp.Name))
                        {
                            publicPropertiesByName.Add(baseProp.Name, baseProp);
                            publicProperties.Add(baseProp);
                            if (nameProperty is null && baseProp.IsName) nameProperty = baseProp;
                            if (typeProperty is null && baseProp.IsType) typeProperty = baseProp;
                        }
                    }
                    break;
                }
                else
                {
                    foreach (var baseProp in baseType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly))
                    {
                        var modelProperty = MakeProperty(baseProp, ref nameProperty, ref typeProperty);
                        if (!publicPropertiesByName.ContainsKey(baseProp.Name))
                        {
                            publicPropertiesByName.Add(baseProp.Name, modelProperty);
                            publicProperties.Add(modelProperty);
                        }
                        allDeclaredProperties.Add(modelProperty);
                    }
                }
                baseType = baseType.BaseType;
            }
            if (_publicPropertiesByName is null)
            {
                lock (lockObject)
                {
                    if (_publicPropertiesByName is null)
                    {
                        _nameProperty = nameProperty;
                        _typeProperty = typeProperty;
                        _publicProperties = publicProperties.ToImmutable();
                        _declaredProperties = declaredProperties.ToImmutable();
                        _allDeclaredProperties = allDeclaredProperties.ToImmutable();
                        _publicPropertiesByName = publicPropertiesByName;
                    }
                }
            }
            publicProperties.Free();
            declaredProperties.Free();
            allDeclaredProperties.Free();
        }

        private ModelProperty MakeProperty(PropertyInfo prop, ref ModelProperty? nameProperty, ref ModelProperty? typeProperty)
        {
            ComputePropertyType(prop, out var type, out var flags);
            bool hasDefaultValue = false;
            object? defaultValue = null;
            string? symbolProperty = null;
            foreach (var attr in prop.GetCustomAttributes(true))
            {
                if (attr is DefaultValueAttribute defaultAttr)
                {
                    if (!hasDefaultValue && defaultAttr.Value is not null && type.IsAssignableFrom(defaultAttr.Value.GetType()))
                    {
                        hasDefaultValue = true;
                        defaultValue = defaultAttr.Value;
                    }
                }
                else if (attr is NameAttribute)
                {
                    flags |= ModelPropertyFlags.Name;
                }
                else if (attr is TypeAttribute)
                {
                    flags |= ModelPropertyFlags.Type;
                }
                else if (attr is UntrackedAttribute)
                {
                    flags |= ModelPropertyFlags.Untracked;
                }
                else if (attr is NonUniqueAttribute)
                {
                    flags |= ModelPropertyFlags.NonUnique;
                }
                else if (attr is UnorderedAttribute)
                {
                    flags |= ModelPropertyFlags.Unordered;
                }
                else if (attr is ContainmentAttribute)
                {
                    flags |= ModelPropertyFlags.Containment;
                }
                else if (attr is ReadOnlyAttribute)
                {
                    flags |= ModelPropertyFlags.ReadOnly;
                }
                else if (attr is DerivedAttribute)
                {
                    flags |= ModelPropertyFlags.Derived;
                }
                else if (attr is DerivedUnionAttribute)
                {
                    flags |= ModelPropertyFlags.DerivedUnion | ModelPropertyFlags.Derived | ModelPropertyFlags.ReadOnly;
                }
                else if (attr is SymbolPropertyAttribute symbolPropAttr)
                {
                    if (symbolProperty is null) symbolProperty = symbolPropAttr.PropertyName;
                }
            }
            var modelProperty = new ModelProperty(prop.DeclaringType, prop.Name, type, defaultValue, flags, symbolProperty);
            if (nameProperty is null && flags.HasFlag(ModelPropertyFlags.Name)) nameProperty = modelProperty;
            if (typeProperty is null && flags.HasFlag(ModelPropertyFlags.Type)) typeProperty = modelProperty;
            return modelProperty;
        }

        private void ComputePropertyType(PropertyInfo property, out Type type, out ModelPropertyFlags flags)
        {
            type = property.PropertyType;
            flags = UpdateFlagsWithType(ModelPropertyFlags.None, ref type);
            if (flags.HasFlag(ModelPropertyFlags.BuiltInType) || flags.HasFlag(ModelPropertyFlags.EnumType) || flags.HasFlag(ModelPropertyFlags.ModelObjectType))
            {
                flags |= ModelPropertyFlags.SingleItem;
                if (!property.CanWrite) flags |= ModelPropertyFlags.ReadOnly;
            }
            else if (type.GenericTypeArguments.Length == 1)
            {
                var innerType = type.GenericTypeArguments[0];
                var innerFlags = UpdateFlagsWithType(ModelPropertyFlags.None, ref innerType);
                if (innerFlags.HasFlag(ModelPropertyFlags.BuiltInType) || innerFlags.HasFlag(ModelPropertyFlags.EnumType) || innerFlags.HasFlag(ModelPropertyFlags.ModelObjectType))
                {
                    if (type.Namespace == "System.Collections.Generic")
                    {
                        if (type.Name == "IList`1" || type.Name == "List`1" || type.Name == "LinkedList`1")
                        {
                            flags |= ModelPropertyFlags.NonUnique;
                        }
                        if (type.Name == "ISet`1" || type.Name == "HashSet`1" || type.Name == "SortedSet`1")
                        {
                            flags |= ModelPropertyFlags.Unordered;
                        }
                        type = innerType;
                        flags = innerFlags;
                        flags |= ModelPropertyFlags.Collection;
                    }
                    else if (type.GetInterfaces().Any(intf => intf == typeof(IList<>)))
                    {
                        type = innerType;
                        flags = innerFlags;
                        flags |= ModelPropertyFlags.Collection | ModelPropertyFlags.NonUnique;
                    }
                    else if (type.GetInterfaces().Any(intf => intf == typeof(ISet<>)))
                    {
                        type = innerType;
                        flags = innerFlags;
                        flags |= ModelPropertyFlags.Collection | ModelPropertyFlags.Unordered;
                    }
                    else if (type.GetInterfaces().Any(intf => intf == typeof(ICollection<>)))
                    {
                        type = innerType;
                        flags = innerFlags;
                        flags |= ModelPropertyFlags.Collection | ModelPropertyFlags.NonUnique | ModelPropertyFlags.Unordered;
                    }
                    else
                    {
                        type = null;
                    }
                }
            }
            if (type == null)
            {
                type = property.PropertyType;
                flags |= ModelPropertyFlags.Untracked;
            }
        }

        private ModelPropertyFlags UpdateFlagsWithType(ModelPropertyFlags flags, ref Type type)
        {
            if (type.Namespace == "System" && type.Name == "Nullable`1" && type.GenericTypeArguments.Length == 1)
            {
                flags |= ModelPropertyFlags.NullableType;
                type = type.GenericTypeArguments[0];
            }
            if (type.CustomAttributes.Any(x => x.AttributeType.Name == "NullableAttribute")) flags |= ModelPropertyFlags.NullableType;
            if (type.IsValueType) flags |= ModelPropertyFlags.ValueType;
            else flags |= ModelPropertyFlags.ReferenceType;
            if (type.IsEnum) flags |= ModelPropertyFlags.EnumType;
            if (type.IsPrimitive || type == typeof(string) || type == typeof(decimal)) flags |= ModelPropertyFlags.BuiltInType;
            if (_metaModel.Contains(type)) flags |= ModelPropertyFlags.ModelObjectType;
            return flags;
        }

        private void ComputeSlots()
        {
            if (_modelPropertyInfos is not null) return;
            var redefinedProperties = new Dictionary<ModelProperty, HashSet<ModelProperty>>();
            var subsettedProperties = new Dictionary<ModelProperty, HashSet<ModelProperty>>();
            var oppositeProperties = new Dictionary<ModelProperty, HashSet<ModelProperty>>();
            foreach (var prop in AllDeclaredProperties)
            {
                var propInfo = prop.DeclaringType.GetProperty(prop.Name, BindingFlags.Instance | BindingFlags.Public | BindingFlags.DeclaredOnly);
                if (propInfo is null) continue;
                foreach (var attr in propInfo.GetCustomAttributes<RedefinesAttribute>())
                {
                    if (attr.Type.IsAssignableFrom(prop.DeclaringType))
                    {
                        var redefinedProp = AllDeclaredProperties.Where(p => p.DeclaringType == attr.Type && p.Name == attr.Property).FirstOrDefault();
                        if (redefinedProp is not null)
                        {
                            if (!redefinedProperties.TryGetValue(prop, out var propRedefined))
                            {
                                propRedefined = new HashSet<ModelProperty>();
                                redefinedProperties.Add(prop, propRedefined);
                            }
                            propRedefined.Add(redefinedProp);
                        }
                    }
                }
                foreach (var attr in propInfo.GetCustomAttributes<SubsetsAttribute>())
                {
                    if (attr.Type.IsAssignableFrom(prop.DeclaringType))
                    {
                        var subsettedProp = AllDeclaredProperties.Where(p => p.DeclaringType == attr.Type && p.Name == attr.Property).FirstOrDefault();
                        if (subsettedProp is not null)
                        {
                            if (!subsettedProperties.TryGetValue(prop, out var propSubsetted))
                            {
                                propSubsetted = new HashSet<ModelProperty>();
                                subsettedProperties.Add(prop, propSubsetted);
                            }
                            propSubsetted.Add(subsettedProp);
                        }
                    }
                }
                foreach (var attr in propInfo.GetCustomAttributes<OppositeAttribute>())
                {
                    if (_metaModel.TryGetInfo(attr.Type, out var oppositeTypeInfo))
                    {
                        var oppositeProp = oppositeTypeInfo.AllDeclaredProperties.Where(p => p.DeclaringType == attr.Type && p.Name == attr.Property).FirstOrDefault();
                        if (oppositeProp is not null)
                        {
                            if (!oppositeProperties.TryGetValue(prop, out var propOpposite))
                            {
                                propOpposite = new HashSet<ModelProperty>();
                                oppositeProperties.Add(prop, propOpposite);
                            }
                            propOpposite.Add(oppositeProp);
                        }
                    }
                }
            }
            var modelPropertyInfos = ModelPropertyGraph.Compute(AllDeclaredProperties, subsettedProperties, redefinedProperties, oppositeProperties);
            Interlocked.CompareExchange(ref _modelPropertyInfos, modelPropertyInfos, null);
        }
    }
}
