﻿using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaGraph<TType, TProperty>
    {
        private static readonly MetaClassComparer CompareByInheritance = new MetaClassComparer(false);
        private static readonly MetaClassComparer CompareByInheritanceReverse = new MetaClassComparer(true);

        private Dictionary<TType, MetaClass<TType, TProperty>?> _classTypes;
        private ImmutableSortedSet<MetaClass<TType, TProperty>> _classes;

        public MetaGraph(IEnumerable<TType> classTypes)
        {
            _classTypes = new Dictionary<TType, MetaClass<TType, TProperty>?>();
            foreach (var classType in classTypes)
            {
                _classTypes.Add(classType, null);
            }
        }

        public MetaClass<TType, TProperty> GetMetaClass(TType classType)
        {
            return _classTypes[classType];
        }

        public ImmutableSortedSet<MetaClass<TType, TProperty>> Compute()
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
            var classes = ArrayBuilder<MetaClass<TType, TProperty>>.GetInstance();
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
            var declaredProperties = ArrayBuilder<MetaProperty<TType, TProperty>>.GetInstance();
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

        private ImmutableSortedSet<MetaClass<TType, TProperty>> SortClassesByInheritance(IEnumerable<MetaClass<TType, TProperty>> classes)
        {
            foreach (var cls in classes)
            {
                var allBaseTypes = new List<MetaClass<TType, TProperty>>() { cls };
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

        private void ComputeClass(MetaClass<TType, TProperty> cls)
        {
            var publicPropertiesByName = ImmutableDictionary.CreateBuilder<string, MetaProperty<TType, TProperty>>();
            MetaProperty<TType, TProperty>? nameProperty = null;
            MetaProperty<TType, TProperty>? typeProperty = null;
            var publicProperties = ArrayBuilder<MetaProperty<TType, TProperty>>.GetInstance();
            var allDeclaredProperties = ArrayBuilder<MetaProperty<TType, TProperty>>.GetInstance();
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

        private void ComputePropertyType(MetaProperty<TType, TProperty> property, out TType type, out ModelPropertyFlags flags)
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
        
        private void ComputeSlots(MetaClass<TType, TProperty> cls)
        {
            var redefinedProperties = new Dictionary<MetaProperty<TType, TProperty>, HashSet<MetaProperty<TType, TProperty>>>();
            var subsettedProperties = new Dictionary<MetaProperty<TType, TProperty>, HashSet<MetaProperty<TType, TProperty>>>();
            var oppositeProperties = new Dictionary<MetaProperty<TType, TProperty>, HashSet<MetaProperty<TType, TProperty>>>();
            foreach (var prop in cls.AllDeclaredProperties)
            {
                foreach (var rprop in prop.GetRedefinedProperties())
                {
                    var redefinedProp = cls.AllDeclaredProperties.Where(p => ReferenceEquals(p.DeclaringType.UnderlyingType, rprop.DeclaringType) && p.Name == rprop.PropertyName).FirstOrDefault();
                    if (redefinedProp is not null)
                    {
                        if (!redefinedProperties.TryGetValue(prop, out var propRedefined))
                        {
                            propRedefined = new HashSet<MetaProperty<TType, TProperty>>();
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
                            propSubsetted = new HashSet<MetaProperty<TType, TProperty>>();
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
                                propOpposite = new HashSet<MetaProperty<TType, TProperty>>();
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
            MetaClass<TType, TProperty> cls,
            Dictionary<MetaProperty<TType, TProperty>, HashSet<MetaProperty<TType, TProperty>>> subsettedProperties,
            Dictionary<MetaProperty<TType, TProperty>, HashSet<MetaProperty<TType, TProperty>>> redefinedProperties,
            Dictionary<MetaProperty<TType, TProperty>, HashSet<MetaProperty<TType, TProperty>>> oppositeProperties)
        {
            var allDeclaredProperties = cls.AllDeclaredProperties;
            var subsettingProperties = new Dictionary<MetaProperty<TType, TProperty>, ArrayBuilder<MetaProperty<TType, TProperty>>>();
            foreach (var prop in subsettedProperties.Keys)
            {
                foreach (var subsettedProp in subsettedProperties[prop])
                {
                    if (!subsettingProperties.TryGetValue(subsettedProp, out var propSubsetting))
                    {
                        propSubsetting = new ArrayBuilder<MetaProperty<TType, TProperty>>();
                        subsettingProperties.Add(subsettedProp, propSubsetting);
                    }
                    propSubsetting.Add(prop);
                }
            }
            var redefiningProperties = new Dictionary<MetaProperty<TType, TProperty>, ArrayBuilder<MetaProperty<TType, TProperty>>>();
            foreach (var prop in redefinedProperties.Keys)
            {
                foreach (var redefinedProp in redefinedProperties[prop])
                {
                    if (!redefiningProperties.TryGetValue(redefinedProp, out var propRedefining))
                    {
                        propRedefining = new ArrayBuilder<MetaProperty<TType, TProperty>>();
                        redefiningProperties.Add(redefinedProp, propRedefining);
                    }
                    propRedefining.Add(prop);
                }
            }
            var components = new Dictionary<MetaProperty<TType, TProperty>, int>();
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
            var propIds = new Dictionary<int, MetaProperty<TType, TProperty>>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                if (!propIds.ContainsKey(propIndex))
                {
                    propIds.Add(propIndex, prop);
                }
            }
            var propToSlotProp = new Dictionary<MetaProperty<TType, TProperty>, MetaProperty<TType, TProperty>>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                propToSlotProp.Add(prop, propIds[propIndex]);
            }
            var slotPropToSlot = new Dictionary<MetaProperty<TType, TProperty>, MetaPropertySlot<TType, TProperty>>();
            var builder = ArrayBuilder<MetaProperty<TType, TProperty>>.GetInstance();
            var slots = ArrayBuilder<MetaPropertySlot<TType, TProperty>>.GetInstance();
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
            var modelPropertyInfos = ImmutableDictionary.CreateBuilder<MetaProperty<TType, TProperty>, MetaPropertyInfo<TType, TProperty>>();
            for (int i = 0; i < allDeclaredProperties.Length; ++i)
            {
                var prop = allDeclaredProperties[i];
                var oppositeProps = oppositeProperties.TryGetValue(prop, out var propOpposite) ? propOpposite.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty>>.Empty;
                var redefinedProps = redefinedProperties.TryGetValue(prop, out var propRedefined) ? propRedefined.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty>>.Empty;
                var redefiningProps = redefiningProperties.TryGetValue(prop, out var propRedefining) ? propRedefining.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty>>.Empty;
                var subsettedProps = subsettedProperties.TryGetValue(prop, out var propSubsetted) ? propSubsetted.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty>>.Empty;
                var subsettingProps = subsettingProperties.TryGetValue(prop, out var propSubsetting) ? propSubsetting.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty>>.Empty;
                var hiddenProps = ArrayBuilder<MetaProperty<TType, TProperty>>.GetInstance();
                var hidingProps = ArrayBuilder<MetaProperty<TType, TProperty>>.GetInstance();
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

        private ModelPropertyFlags ComputeSlotFlags(ImmutableArray<MetaProperty<TType, TProperty>> properties)
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

        protected abstract MetaClass<TType, TProperty> MakeClass(TType classType);
        protected abstract MetaProperty<TType, TProperty> MakeProperty(MetaClass<TType, TProperty> declaringType, TProperty property);
        protected abstract bool IsCollectionType(TType type, out TType? itemType, out ModelPropertyFlags collectionFlags);
        protected abstract bool IsNullableType(TType type, out TType innerType);
        protected abstract bool IsEnumType(TType type);
        protected abstract bool IsValueType(TType type);
        protected abstract bool IsPrimitiveType(TType type);
        protected abstract MetaPropertySlot<TType, TProperty> MakePropertySlot(MetaProperty<TType, TProperty> slotProperty, ImmutableArray<MetaProperty<TType, TProperty>> slotProperties, object? defaultValue, ModelPropertyFlags flags);
        protected abstract MetaPropertyInfo<TType, TProperty> MakePropertyInfo(MetaPropertySlot<TType, TProperty> slot,
            ImmutableArray<MetaProperty<TType, TProperty>> oppositeProperties,
            ImmutableArray<MetaProperty<TType, TProperty>> subsettedProperties,
            ImmutableArray<MetaProperty<TType, TProperty>> subsettingProperties,
            ImmutableArray<MetaProperty<TType, TProperty>> redefinedProperties,
            ImmutableArray<MetaProperty<TType, TProperty>> redefiningProperties,
            ImmutableArray<MetaProperty<TType, TProperty>> hiddenProperties,
            ImmutableArray<MetaProperty<TType, TProperty>> hidingProperties);

        private class MetaClassComparer : IComparer<MetaClass<TType, TProperty>>
        {
            private bool _reverse;

            public MetaClassComparer(bool reverse)
            {
                _reverse = reverse;
            }

            public int Compare(MetaClass<TType, TProperty> x, MetaClass<TType, TProperty> y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (x.AllBaseTypes.Contains(y)) return _reverse ? -1 : 1;
                if (y.AllBaseTypes.Contains(x)) return _reverse ? 1 : -1;
                return string.Compare(x.Name, y.Name);
            }
        }
    }
}