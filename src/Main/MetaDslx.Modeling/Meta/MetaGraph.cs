using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaGraph<TType, TProperty, TSymbol>
    {
        private static readonly MetaClassComparer CompareByInheritance = new MetaClassComparer(false);
        private static readonly MetaClassComparer CompareByInheritanceReverse = new MetaClassComparer(true);

        private Dictionary<TType, MetaClass<TType, TProperty, TSymbol>?> _classTypes;
        private ImmutableSortedSet<MetaClass<TType, TProperty, TSymbol>> _classes;

        public MetaGraph(IEnumerable<TType> classTypes)
        {
            _classTypes = new Dictionary<TType, MetaClass<TType, TProperty, TSymbol>?>();
            foreach (var classType in classTypes)
            {
                _classTypes.Add(classType, null);
            }
        }

        public MetaClass<TType, TProperty, TSymbol> GetMetaClass(TType classType)
        {
            return _classTypes[classType];
        }

        public ImmutableSortedSet<MetaClass<TType, TProperty, TSymbol>> Compute()
        {
            if (_classes is not null) return _classes;
            CreateClasses();
            CreateProperties();
            foreach (var cls in _classes)
            {
                ComputeClass(cls);
            }
            foreach (var cls in _classes)
            {
                ComputeSlots(cls);
            }
            return _classes;
        }

        private void CreateClasses()
        {
            var classes = ArrayBuilder<MetaClass<TType, TProperty, TSymbol>>.GetInstance();
            foreach (var classType in _classTypes.Keys)
            {
                var cls = MakeClass(classType);
                _classTypes[classType] = cls;
                classes.Add(cls);
            }
            _classes = SortClassesByInheritance(classes.ToImmutableAndFree());
        }

        private void CreateProperties()
        {
            var declaredProperties = ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>.GetInstance();
            foreach (var cls in _classes)
            {
                declaredProperties.Clear();
                foreach (var origProp in cls.OriginalDeclaredProperties)
                {
                    var prop = MakeProperty(cls, origProp);
                    declaredProperties.Add(prop);
                    ComputePropertyType(prop, out var type, out var flags);
                    var symbolProperty = prop.SymbolProperty;
                    if (flags.HasFlag(ModelPropertyFlags.Derived)) flags |= ModelPropertyFlags.ReadOnly;
                    if (flags.HasFlag(ModelPropertyFlags.DerivedUnion)) flags |= ModelPropertyFlags.ReadOnly;
                    if (symbolProperty == "Name") flags |= ModelPropertyFlags.Name;
                    if (symbolProperty == "Type") flags |= ModelPropertyFlags.Type;
                    prop.Type = type;
                    prop.Flags = prop.OriginalFlags | flags;
                }
                cls.DeclaredProperties = declaredProperties.ToImmutable();
            }
            declaredProperties.Free();
        }

        private ImmutableSortedSet<MetaClass<TType, TProperty, TSymbol>> SortClassesByInheritance(IEnumerable<MetaClass<TType, TProperty, TSymbol>> classes)
        {
            foreach (var cls in classes)
            {
                var allBaseTypes = new List<MetaClass<TType, TProperty, TSymbol>>() { cls };
                for (int i = 0; i < allBaseTypes.Count; ++i)
                {
                    var current = allBaseTypes[i];
                    foreach (var baseType in current.OriginalBaseTypes)
                    {
                        if (_classTypes.TryGetValue(baseType, out var baseClass))
                        {
                            if (!allBaseTypes.Contains(baseClass)) allBaseTypes.Add(baseClass);
                        }
                    }
                }
                allBaseTypes.Remove(cls);
                cls.AllBaseTypes = allBaseTypes.ToImmutableArray();
            }
            foreach (var cls in classes)
            {
                cls.AllBaseTypes = cls.AllBaseTypes.Sort(CompareByInheritanceReverse);
                if (cls.SymbolType is null)
                {
                    foreach (var baseType in cls.AllBaseTypes)
                    {
                        if (baseType.SymbolType is not null)
                        {
                            cls.SymbolType = baseType.SymbolType;
                            break;
                        }
                    }
                }
            }
            return classes.ToImmutableSortedSet(CompareByInheritance);
        }

        private void ComputeClass(MetaClass<TType, TProperty, TSymbol> cls)
        {
            var publicPropertiesByName = ImmutableDictionary.CreateBuilder<string, MetaProperty<TType, TProperty, TSymbol>>();
            MetaProperty<TType, TProperty, TSymbol>? nameProperty = null;
            MetaProperty<TType, TProperty, TSymbol>? typeProperty = null;
            var publicProperties = ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>.GetInstance();
            var allDeclaredProperties = ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>.GetInstance();
            foreach (var prop in cls.DeclaredProperties)
            {
                publicPropertiesByName.Add(prop.Name, prop);
                publicProperties.Add(prop);
                allDeclaredProperties.Add(prop);
            }
            foreach (var baseType in cls.AllBaseTypes)
            {
                foreach (var baseProp in baseType.DeclaredProperties)
                {
                    allDeclaredProperties.Add(baseProp);
                    if (!publicPropertiesByName.ContainsKey(baseProp.Name))
                    {
                        publicPropertiesByName.Add(baseProp.Name, baseProp);
                        publicProperties.Add(baseProp);
                    }
                }
            }
            foreach (var prop in allDeclaredProperties)
            {
                if (nameProperty is null && prop.Flags.HasFlag(ModelPropertyFlags.Name)) nameProperty = prop;
                if (typeProperty is null && prop.Flags.HasFlag(ModelPropertyFlags.Type)) typeProperty = prop;
            }
            cls.NameProperty = nameProperty;
            cls.TypeProperty = typeProperty;
            cls.PublicProperties = publicProperties.ToImmutableAndFree();
            cls.AllDeclaredProperties = allDeclaredProperties.ToImmutableAndFree();
            cls.PublicPropertiesByName = publicPropertiesByName.ToImmutable();
        }

        private void ComputePropertyType(MetaProperty<TType, TProperty, TSymbol> property, out TType type, out ModelPropertyFlags flags)
        {
            type = property.OriginalType;
            flags = property.OriginalFlags | UpdateFlagsWithType(ModelPropertyFlags.None, ref type);
            if (flags.HasFlag(ModelPropertyFlags.BuiltInType) || flags.HasFlag(ModelPropertyFlags.EnumType) || flags.HasFlag(ModelPropertyFlags.ModelObjectType))
            {
                flags |= ModelPropertyFlags.SingleItem;
                if (!property.HasSetter) flags |= ModelPropertyFlags.ReadOnly;
            }
            else if (IsCollectionType(type, out var itemType, out var collectionFlags))
            {
                var itemFlags = UpdateFlagsWithType(ModelPropertyFlags.None, ref itemType);
                if (itemFlags.HasFlag(ModelPropertyFlags.BuiltInType) || itemFlags.HasFlag(ModelPropertyFlags.EnumType) || itemFlags.HasFlag(ModelPropertyFlags.ModelObjectType))
                {
                    type = itemType;
                    flags = itemFlags;
                    flags |= ModelPropertyFlags.Collection | collectionFlags;
                }
            }
            if (type == null)
            {
                type = property.OriginalType;
                flags |= ModelPropertyFlags.Untracked;
            }
        }

        private ModelPropertyFlags UpdateFlagsWithType(ModelPropertyFlags flags, ref TType type)
        {
            if (type is null) return ModelPropertyFlags.None;
            if (IsNullableType(type, out var innerType))
            {
                flags |= ModelPropertyFlags.NullableType;
                type = innerType;
            }
            if (IsValueType(type)) flags |= ModelPropertyFlags.ValueType;
            else flags |= ModelPropertyFlags.ReferenceType;
            if (IsEnumType(type)) flags |= ModelPropertyFlags.EnumType;
            if (IsPrimitiveType(type)) flags |= ModelPropertyFlags.BuiltInType;
            if (_classTypes.Keys.Contains(type)) flags |= ModelPropertyFlags.ModelObjectType;
            return flags;
        }
        
        private void ComputeSlots(MetaClass<TType, TProperty, TSymbol> cls)
        {
            var redefinedProperties = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, HashSet<MetaProperty<TType, TProperty, TSymbol>>>();
            var subsettedProperties = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, HashSet<MetaProperty<TType, TProperty, TSymbol>>>();
            var oppositeProperties = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, HashSet<MetaProperty<TType, TProperty, TSymbol>>>();
            foreach (var prop in cls.AllDeclaredProperties)
            {
                foreach (var rprop in prop.GetRedefinedProperties())
                {
                    var redefinedProp = cls.AllDeclaredProperties.Where(p => ReferenceEquals(p.DeclaringType.UnderlyingType, rprop.DeclaringType) && p.Name == rprop.PropertyName).FirstOrDefault();
                    if (redefinedProp is not null)
                    {
                        if (!redefinedProperties.TryGetValue(prop, out var propRedefined))
                        {
                            propRedefined = new HashSet<MetaProperty<TType, TProperty, TSymbol>>();
                            redefinedProperties.Add(prop, propRedefined);
                        }
                        propRedefined.Add(redefinedProp);
                    }
                }
                foreach (var sprop in prop.GetSubsettedProperties())
                {
                    var subsettedProp = cls.AllDeclaredProperties.Where(p => ReferenceEquals(p.DeclaringType.UnderlyingType, sprop.DeclaringType) && p.Name == sprop.PropertyName).FirstOrDefault();
                    if (subsettedProp is not null)
                    {
                        if (!subsettedProperties.TryGetValue(prop, out var propSubsetted))
                        {
                            propSubsetted = new HashSet<MetaProperty<TType, TProperty, TSymbol>>();
                            subsettedProperties.Add(prop, propSubsetted);
                        }
                        propSubsetted.Add(subsettedProp);
                    }
                }
                foreach (var oprop in prop.GetOppositeProperties())
                {
                    if (oprop.DeclaringType is not null && _classTypes.TryGetValue(oprop.DeclaringType, out var oppositeClass))
                    {
                        var oppositeProp = oppositeClass.AllDeclaredProperties.Where(p => ReferenceEquals(p.DeclaringType.UnderlyingType, oprop.DeclaringType) && p.Name == oprop.PropertyName).FirstOrDefault();
                        if (oppositeProp is not null)
                        {
                            if (!oppositeProperties.TryGetValue(prop, out var propOpposite))
                            {
                                propOpposite = new HashSet<MetaProperty<TType, TProperty, TSymbol>>();
                                oppositeProperties.Add(prop, propOpposite);
                            }
                            propOpposite.Add(oppositeProp);
                        }
                    }
                }
            }
            ComputeSlots(cls, subsettedProperties, redefinedProperties, oppositeProperties);
        }

        private void ComputeSlots(
            MetaClass<TType, TProperty, TSymbol> cls,
            Dictionary<MetaProperty<TType, TProperty, TSymbol>, HashSet<MetaProperty<TType, TProperty, TSymbol>>> subsettedProperties,
            Dictionary<MetaProperty<TType, TProperty, TSymbol>, HashSet<MetaProperty<TType, TProperty, TSymbol>>> redefinedProperties,
            Dictionary<MetaProperty<TType, TProperty, TSymbol>, HashSet<MetaProperty<TType, TProperty, TSymbol>>> oppositeProperties)
        {
            var allDeclaredProperties = cls.AllDeclaredProperties;
            var subsettingProperties = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>>();
            foreach (var prop in subsettedProperties.Keys)
            {
                foreach (var subsettedProp in subsettedProperties[prop])
                {
                    if (!subsettingProperties.TryGetValue(subsettedProp, out var propSubsetting))
                    {
                        propSubsetting = new ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>();
                        subsettingProperties.Add(subsettedProp, propSubsetting);
                    }
                    propSubsetting.Add(prop);
                }
            }
            var redefiningProperties = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>>();
            foreach (var prop in redefinedProperties.Keys)
            {
                foreach (var redefinedProp in redefinedProperties[prop])
                {
                    if (!redefiningProperties.TryGetValue(redefinedProp, out var propRedefining))
                    {
                        propRedefining = new ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>();
                        redefiningProperties.Add(redefinedProp, propRedefining);
                    }
                    propRedefining.Add(prop);
                }
            }
            var components = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, int>();
            var index = 0;
            foreach (var prop in allDeclaredProperties)
            {
                components.Add(prop, index++);
            }
            var combined = true;
            while (combined)
            {
                combined = false;
                foreach (var prop in allDeclaredProperties)
                {
                    var propIndex = components[prop];
                    if (redefinedProperties.TryGetValue(prop, out var propRedefined))
                    {
                        foreach (var redefProp in propRedefined)
                        {
                            var redefPropIndex = components[redefProp];
                            if (redefPropIndex != propIndex)
                            {
                                var minIndex = Math.Min(propIndex, redefPropIndex);
                                foreach (var mergedProp in allDeclaredProperties)
                                {
                                    var mergedPropIndex = components[mergedProp];
                                    if (mergedPropIndex == propIndex || mergedPropIndex == redefPropIndex)
                                    {
                                        components[mergedProp] = minIndex;
                                    }
                                }
                                combined = true;
                            }
                        }
                    }
                }
            }
            var propIds = new Dictionary<int, MetaProperty<TType, TProperty, TSymbol>>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                if (!propIds.ContainsKey(propIndex))
                {
                    propIds.Add(propIndex, prop);
                }
            }
            var propToSlotProp = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, MetaProperty<TType, TProperty, TSymbol>>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                propToSlotProp.Add(prop, propIds[propIndex]);
            }
            var slotPropToSlot = new Dictionary<MetaProperty<TType, TProperty, TSymbol>, MetaPropertySlot<TType, TProperty, TSymbol>>();
            var builder = ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>.GetInstance();
            var slots = ArrayBuilder<MetaPropertySlot<TType, TProperty, TSymbol>>.GetInstance();
            foreach (var slotIndex in propIds.Keys)
            {
                foreach (var prop in allDeclaredProperties)
                {
                    var propIndex = components[prop];
                    if (propIndex == slotIndex)
                    {
                        builder.Add(prop);
                    }
                }
                var slotProperties = builder.ToImmutableAndClear();
                var slotFlags = ComputeSlotFlags(slotProperties);
                var slot = MakePropertySlot(propIds[slotIndex], slotProperties, propIds[slotIndex].DefaultValue, slotFlags);
                slots.Add(slot);
                slotPropToSlot.Add(propIds[slotIndex], slot);
            }
            builder.Free();
            cls.Slots = slots.ToImmutableAndFree();
            var modelPropertyInfos = ImmutableDictionary.CreateBuilder<MetaProperty<TType, TProperty, TSymbol>, MetaPropertyInfo<TType, TProperty, TSymbol>>();
            for (int i = 0; i < allDeclaredProperties.Length; ++i)
            {
                var prop = allDeclaredProperties[i];
                var oppositeProps = oppositeProperties.TryGetValue(prop, out var propOpposite) ? propOpposite.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TSymbol>>.Empty;
                var redefinedProps = redefinedProperties.TryGetValue(prop, out var propRedefined) ? propRedefined.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TSymbol>>.Empty;
                var redefiningProps = redefiningProperties.TryGetValue(prop, out var propRedefining) ? propRedefining.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TSymbol>>.Empty;
                var subsettedProps = subsettedProperties.TryGetValue(prop, out var propSubsetted) ? propSubsetted.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TSymbol>>.Empty;
                var subsettingProps = subsettingProperties.TryGetValue(prop, out var propSubsetting) ? propSubsetting.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TSymbol>>.Empty;
                var hiddenProps = ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>.GetInstance();
                var hidingProps = ArrayBuilder<MetaProperty<TType, TProperty, TSymbol>>.GetInstance();
                for (int j = 0; j < allDeclaredProperties.Length; ++j)
                {
                    var hprop = allDeclaredProperties[j];
                    if (j > i)
                    {
                        if (hprop.Name == prop.Name) hiddenProps.Add(hprop);
                    }
                    else if (j < i)
                    {
                        if (hprop.Name == prop.Name) hidingProps.Add(hprop);
                    }
                }
                var propInfo = MakePropertyInfo(slotPropToSlot[propToSlotProp[prop]], oppositeProps, subsettedProps, subsettingProps, redefinedProps, redefiningProps, hiddenProps.ToImmutableAndFree(), hidingProps.ToImmutableAndFree());
                modelPropertyInfos.Add(prop, propInfo);
            }
            cls.ModelPropertyInfos = modelPropertyInfos.ToImmutable();
        }

        private ModelPropertyFlags ComputeSlotFlags(ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> properties)
        {
            var flags = ModelPropertyFlags.None;
            foreach (ModelPropertyFlags flag in Enum.GetValues(typeof(ModelPropertyFlags)))
            {
                var allSet = true;
                var atLeastOneSet = false;
                foreach (var prop in properties)
                {
                    if (prop.Flags.HasFlag(flag))
                    {
                        atLeastOneSet = true;
                    }
                    else
                    {
                        allSet = false;
                    }
                }
                if (atLeastOneSet)
                {
                    if (flag == ModelPropertyFlags.ValueType ||
                        flag == ModelPropertyFlags.ReferenceType ||
                        flag == ModelPropertyFlags.BuiltInType ||
                        flag == ModelPropertyFlags.ModelObjectType ||
                        flag == ModelPropertyFlags.Containment ||
                        flag == ModelPropertyFlags.SingleItem ||
                        flag == ModelPropertyFlags.Collection ||
                        flag == ModelPropertyFlags.ReadOnly ||
                        flag == ModelPropertyFlags.Derived ||
                        flag == ModelPropertyFlags.DerivedUnion)
                    {
                        flags |= flag;
                    }
                }
                if (allSet)
                {
                    if (flag == ModelPropertyFlags.Untracked ||
                        flag == ModelPropertyFlags.NullableType ||
                        flag == ModelPropertyFlags.Unordered ||
                        flag == ModelPropertyFlags.NonUnique)
                    {
                        flags |= flag;
                    }
                }
            }
            return flags;
        }

        protected abstract MetaClass<TType, TProperty, TSymbol> MakeClass(TType classType);
        protected abstract MetaProperty<TType, TProperty, TSymbol> MakeProperty(MetaClass<TType, TProperty, TSymbol> declaringType, TProperty property);
        protected abstract bool IsCollectionType(TType type, out TType? itemType, out ModelPropertyFlags collectionFlags);
        protected abstract bool IsNullableType(TType type, out TType innerType);
        protected abstract bool IsEnumType(TType type);
        protected abstract bool IsValueType(TType type);
        protected abstract bool IsPrimitiveType(TType type);
        protected abstract MetaPropertySlot<TType, TProperty, TSymbol> MakePropertySlot(MetaProperty<TType, TProperty, TSymbol> slotProperty, ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> slotProperties, object? defaultValue, ModelPropertyFlags flags);
        protected abstract MetaPropertyInfo<TType, TProperty, TSymbol> MakePropertyInfo(MetaPropertySlot<TType, TProperty, TSymbol> slot,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> oppositeProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> subsettedProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> subsettingProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> redefinedProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> redefiningProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> hiddenProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TSymbol>> hidingProperties);

        private class MetaClassComparer : IComparer<MetaClass<TType, TProperty, TSymbol>>
        {
            private bool _reverse;

            public MetaClassComparer(bool reverse)
            {
                _reverse = reverse;
            }

            public int Compare(MetaClass<TType, TProperty, TSymbol> x, MetaClass<TType, TProperty, TSymbol> y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (x.AllBaseTypes.Contains(y)) return _reverse ? -1 : 1;
                if (y.AllBaseTypes.Contains(x)) return _reverse ? 1 : -1;
                return string.Compare(x.Name, y.Name);
            }
        }
    }
}
