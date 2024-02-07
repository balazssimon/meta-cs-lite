using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaGraph<TType, TProperty, TOperation>
    {
        private static readonly MetaPropertyComparer ComparePropertiesByName = new MetaPropertyComparer();
        private static readonly MetaOperationComparer CompareOperationsByName = new MetaOperationComparer();
        private static readonly MetaClassComparer CompareByInheritance = new MetaClassComparer(false);
        private static readonly MetaClassComparer CompareByInheritanceReverse = new MetaClassComparer(true);
        
        private HashSet<TType> _classTypes;
        private Dictionary<TType, MetaClass<TType, TProperty, TOperation>> _classMap;
        private ImmutableSortedSet<MetaClass<TType, TProperty, TOperation>> _classes;
        private DiagnosticBag _diagnostics;

        public MetaGraph(IEnumerable<TType> classTypes)
        {
            _classTypes = new HashSet<TType>(classTypes);
            _diagnostics = new DiagnosticBag();
        }

        public MetaClass<TType, TProperty, TOperation> GetMetaClass(TType classType)
        {
            return _classMap[classType];
        }

        public ImmutableArray<Diagnostic> Diagnostics => _diagnostics.ToReadOnly();

        public ImmutableSortedSet<MetaClass<TType, TProperty, TOperation>> ClassesInTopologicalOrder => Compute();

        public ImmutableSortedSet<MetaClass<TType, TProperty, TOperation>> Compute()
        {
            if (_classes is not null) return _classes;
            CreateClasses();
            CreateProperties();
            CreateOperations();
            foreach (var cls in _classes)
            {
                ComputeClass(cls);
            }
            foreach (var cls in _classes)
            {
                ComputeSlots(cls);
                ComputeOperations(cls);
            }
            Validate();
            return _classes;
        }

        private void CreateClasses()
        {
            var classMap = new Dictionary<TType, MetaClass<TType, TProperty, TOperation>>();
            var classes = ArrayBuilder<MetaClass<TType, TProperty, TOperation>>.GetInstance();
            foreach (var classType in _classTypes)
            {
                var cls = MakeClass(classType);
                if (cls is not null)
                {
                    classMap.Add(classType, cls);
                    classes.Add(cls);
                }
            }
            _classMap = classMap;
            _classes = SortClassesByInheritance(classes.ToImmutableAndFree());
        }

        private void CreateProperties()
        {
            var declaredProperties = ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>.GetInstance();
            foreach (var cls in _classes)
            {
                declaredProperties.Clear();
                foreach (var origProp in cls.OriginalDeclaredProperties)
                {
                    var prop = MakeProperty(cls, origProp);
                    if (prop is not null)
                    {
                        declaredProperties.Add(prop);
                        ComputePropertyType(prop, out var type, out var flags, out var keyType, out var keyFlags);
                        var symbolProperty = prop.SymbolProperty;
                        if (flags.HasFlag(ModelPropertyFlags.Derived)) flags |= ModelPropertyFlags.ReadOnly;
                        if (flags.HasFlag(ModelPropertyFlags.DerivedUnion)) flags |= ModelPropertyFlags.ReadOnly;
                        if (symbolProperty == "Name") flags |= ModelPropertyFlags.Name;
                        if (symbolProperty == "Type") flags |= ModelPropertyFlags.Type;
                        prop.Type = type;
                        prop.Flags = prop.OriginalFlags | flags;
                        prop.KeyType = keyType;
                        prop.KeyFlags = keyFlags;
                    }
                }
                declaredProperties.Sort(ComparePropertiesByName);
                cls.DeclaredProperties = declaredProperties.ToImmutable();
            }
            declaredProperties.Free();
        }

        private void CreateOperations()
        {
            var declaredOperations = ArrayBuilder<MetaOperation<TType, TProperty, TOperation>>.GetInstance();
            foreach (var cls in _classes)
            {
                declaredOperations.Clear();
                foreach (var origOp in cls.OriginalDeclaredOperations)
                {
                    var op = MakeOperation(cls, origOp);
                    if (op is not null)
                    {
                        declaredOperations.Add(op);
                    }
                }
                declaredOperations.Sort(CompareOperationsByName);
                cls.DeclaredOperations = declaredOperations.ToImmutable();
                foreach (var dop in declaredOperations)
                {
                    var overloads = declaredOperations.Where(op => op.Name == dop.Name).ToList();
                    if (overloads.Count >= 2)
                    {
                        var index = overloads.IndexOf(dop) + 1;
                        dop.UniqueName = $"{dop.Name}{index}";
                    }
                    else
                    {
                        dop.UniqueName = dop.Name;
                    }
                }
            }
            declaredOperations.Free();
        }

        private ImmutableSortedSet<MetaClass<TType, TProperty, TOperation>> SortClassesByInheritance(IEnumerable<MetaClass<TType, TProperty, TOperation>> classes)
        {
            foreach (var cls in classes)
            {
                var allBaseTypes = new List<MetaClass<TType, TProperty, TOperation>>() { cls };
                for (int i = 0; i < allBaseTypes.Count; ++i)
                {
                    var current = allBaseTypes[i];
                    foreach (var baseType in current.OriginalBaseTypes)
                    {
                        if (_classMap.TryGetValue(baseType, out var baseClass))
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
                var baseTypes = ArrayBuilder<MetaClass<TType, TProperty, TOperation>>.GetInstance();
                foreach (var baseType in cls.AllBaseTypes)
                {
                    if (cls.OriginalBaseTypes.Contains(baseType.UnderlyingType)) baseTypes.Add(baseType);
                }
                cls.BaseTypes = baseTypes.ToImmutableAndFree();
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

        private void ComputeClass(MetaClass<TType, TProperty, TOperation> cls)
        {
            var publicPropertiesByName = ImmutableDictionary.CreateBuilder<string, MetaProperty<TType, TProperty, TOperation>>();
            MetaProperty<TType, TProperty, TOperation>? nameProperty = null;
            MetaProperty<TType, TProperty, TOperation>? typeProperty = null;
            var publicProperties = ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>.GetInstance();
            var allDeclaredProperties = ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>.GetInstance();
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

            var publicOperations = ArrayBuilder<MetaOperation<TType, TProperty, TOperation>>.GetInstance();
            var allDeclaredOperations = ArrayBuilder<MetaOperation<TType, TProperty, TOperation>>.GetInstance();
            foreach (var op in cls.DeclaredOperations)
            {
                publicOperations.Add(op);
                allDeclaredOperations.Add(op);
            }
            foreach (var baseType in cls.AllBaseTypes)
            {
                foreach (var baseOp in baseType.DeclaredOperations)
                {
                    allDeclaredOperations.Add(baseOp);
                    if (!publicOperations.Any(op => op.Name == baseOp.Name))
                    {
                        publicOperations.Add(baseOp);
                    }
                }
            }
            cls.PublicOperations = publicOperations.ToImmutableAndFree();
            cls.AllDeclaredOperations = allDeclaredOperations.ToImmutableAndFree();
        }

        private void ComputePropertyType(MetaProperty<TType, TProperty, TOperation> property, out TType type, out ModelPropertyFlags flags, out TType keyType, out ModelPropertyFlags keyFlags)
        {
            keyType = default;
            keyFlags = ModelPropertyFlags.None;
            type = property.OriginalType;
            flags = property.OriginalFlags | UpdateFlagsWithType(ModelPropertyFlags.None, ref type);
            if (flags.HasFlag(ModelPropertyFlags.BuiltInType) || flags.HasFlag(ModelPropertyFlags.EnumType) || flags.HasFlag(ModelPropertyFlags.ModelObjectType))
            {
                flags |= ModelPropertyFlags.Single;
                if (!property.HasSetter) flags |= ModelPropertyFlags.ReadOnly;
            }
            else if (IsMapType(type, out keyType, out keyFlags, out var valueType, out var valueFlags))
            {
                keyFlags = UpdateFlagsWithType(keyFlags, ref keyType);
                valueFlags = UpdateFlagsWithType(valueFlags, ref valueType);
                if ((keyFlags.HasFlag(ModelPropertyFlags.BuiltInType) || keyFlags.HasFlag(ModelPropertyFlags.EnumType) || keyFlags.HasFlag(ModelPropertyFlags.ModelObjectType)) &&
                    valueFlags.HasFlag(ModelPropertyFlags.BuiltInType) || valueFlags.HasFlag(ModelPropertyFlags.EnumType) || valueFlags.HasFlag(ModelPropertyFlags.ModelObjectType))
                {
                    type = valueType;
                    flags = valueFlags;
                    flags |= ModelPropertyFlags.Map;
                }
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
            if (!flags.HasFlag(ModelPropertyFlags.Collection) && !flags.HasFlag(ModelPropertyFlags.Map))
            {
                flags |= ModelPropertyFlags.Single;
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
            if (_classTypes.Contains(type)) flags |= ModelPropertyFlags.ModelObjectType;
            return flags;
        }
        
        private void ComputeSlots(MetaClass<TType, TProperty, TOperation> cls)
        {
            var redefinedProperties = new Dictionary<MetaProperty<TType, TProperty, TOperation>, HashSet<MetaProperty<TType, TProperty, TOperation>>>();
            var subsettedProperties = new Dictionary<MetaProperty<TType, TProperty, TOperation>, HashSet<MetaProperty<TType, TProperty, TOperation>>>();
            var oppositeProperties = new Dictionary<MetaProperty<TType, TProperty, TOperation>, HashSet<MetaProperty<TType, TProperty, TOperation>>>();
            foreach (var prop in cls.AllDeclaredProperties)
            {
                foreach (var rprop in prop.GetRedefinedProperties())
                {
                    var redefinedProp = cls.AllDeclaredProperties.Where(p => rprop.DeclaringType.Equals(p.DeclaringType.UnderlyingType) && p.Name == rprop.PropertyName).FirstOrDefault();
                    if (redefinedProp is not null)
                    {
                        if (!redefinedProperties.TryGetValue(prop, out var propRedefined))
                        {
                            propRedefined = new HashSet<MetaProperty<TType, TProperty, TOperation>>();
                            redefinedProperties.Add(prop, propRedefined);
                        }
                        propRedefined.Add(redefinedProp);
                    }
                }
                foreach (var sprop in prop.GetSubsettedProperties())
                {
                    var subsettedProp = cls.AllDeclaredProperties.Where(p => sprop.DeclaringType.Equals(p.DeclaringType.UnderlyingType) && p.Name == sprop.PropertyName).FirstOrDefault();
                    if (subsettedProp is not null)
                    {
                        if (!subsettedProperties.TryGetValue(prop, out var propSubsetted))
                        {
                            propSubsetted = new HashSet<MetaProperty<TType, TProperty, TOperation>>();
                            subsettedProperties.Add(prop, propSubsetted);
                        }
                        propSubsetted.Add(subsettedProp);
                    }
                }
                foreach (var oprop in prop.GetOppositeProperties())
                {
                    if (oprop.DeclaringType is not null && _classMap.TryGetValue(oprop.DeclaringType, out var oppositeClass))
                    {
                        var oppositeProp = oppositeClass.AllDeclaredProperties.Where(p => oprop.DeclaringType.Equals(p.DeclaringType.UnderlyingType) && p.Name == oprop.PropertyName).FirstOrDefault();
                        if (oppositeProp is not null)
                        {
                            if (!oppositeProperties.TryGetValue(prop, out var propOpposite))
                            {
                                propOpposite = new HashSet<MetaProperty<TType, TProperty, TOperation>>();
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
            MetaClass<TType, TProperty, TOperation> cls,
            Dictionary<MetaProperty<TType, TProperty, TOperation>, HashSet<MetaProperty<TType, TProperty, TOperation>>> subsettedProperties,
            Dictionary<MetaProperty<TType, TProperty, TOperation>, HashSet<MetaProperty<TType, TProperty, TOperation>>> redefinedProperties,
            Dictionary<MetaProperty<TType, TProperty, TOperation>, HashSet<MetaProperty<TType, TProperty, TOperation>>> oppositeProperties)
        {
            var allDeclaredProperties = cls.AllDeclaredProperties;
            var subsettingProperties = new Dictionary<MetaProperty<TType, TProperty, TOperation>, ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>>();
            foreach (var prop in subsettedProperties.Keys)
            {
                foreach (var subsettedProp in subsettedProperties[prop])
                {
                    if (!subsettingProperties.TryGetValue(subsettedProp, out var propSubsetting))
                    {
                        propSubsetting = new ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>();
                        subsettingProperties.Add(subsettedProp, propSubsetting);
                    }
                    propSubsetting.Add(prop);
                }
            }
            var redefiningProperties = new Dictionary<MetaProperty<TType, TProperty, TOperation>, ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>>();
            foreach (var prop in redefinedProperties.Keys)
            {
                foreach (var redefinedProp in redefinedProperties[prop])
                {
                    if (!redefiningProperties.TryGetValue(redefinedProp, out var propRedefining))
                    {
                        propRedefining = new ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>();
                        redefiningProperties.Add(redefinedProp, propRedefining);
                    }
                    propRedefining.Add(prop);
                }
            }
            var components = new Dictionary<MetaProperty<TType, TProperty, TOperation>, int>();
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
            var propIds = new Dictionary<int, MetaProperty<TType, TProperty, TOperation>>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                if (!propIds.ContainsKey(propIndex))
                {
                    propIds.Add(propIndex, prop);
                }
            }
            var propToSlotProp = new Dictionary<MetaProperty<TType, TProperty, TOperation>, MetaProperty<TType, TProperty, TOperation>>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                propToSlotProp.Add(prop, propIds[propIndex]);
            }
            var slotPropToSlot = new Dictionary<MetaProperty<TType, TProperty, TOperation>, MetaPropertySlot<TType, TProperty, TOperation>>();
            var builder = ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>.GetInstance();
            var slots = ArrayBuilder<MetaPropertySlot<TType, TProperty, TOperation>>.GetInstance();
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
                var slotFlags = ComputeSlotFlags(slotProperties.Select(sp => sp.Flags));
                var slotKeyFlags = ComputeSlotFlags(slotProperties.Select(sp => sp.KeyFlags));
                var slotDefaultValue = slotProperties.Where(sp => sp.DefaultValue is not null).Select(sp => sp.DefaultValue).FirstOrDefault();
                var slot = MakePropertySlot(propIds[slotIndex], slotProperties, slotDefaultValue, slotFlags, slotKeyFlags);
                slots.Add(slot);
                slotPropToSlot.Add(propIds[slotIndex], slot);
            }
            builder.Free();
            cls.Slots = slots.ToImmutableAndFree();
            var modelPropertyInfos = ImmutableDictionary.CreateBuilder<MetaProperty<TType, TProperty, TOperation>, MetaPropertyInfo<TType, TProperty, TOperation>>();
            for (int i = 0; i < allDeclaredProperties.Length; ++i)
            {
                var prop = allDeclaredProperties[i];
                var oppositeProps = oppositeProperties.TryGetValue(prop, out var propOpposite) ? propOpposite.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TOperation>>.Empty;
                var redefinedProps = redefinedProperties.TryGetValue(prop, out var propRedefined) ? propRedefined.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TOperation>>.Empty;
                var redefiningProps = redefiningProperties.TryGetValue(prop, out var propRedefining) ? propRedefining.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TOperation>>.Empty;
                var subsettedProps = subsettedProperties.TryGetValue(prop, out var propSubsetted) ? propSubsetted.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TOperation>>.Empty;
                var subsettingProps = subsettingProperties.TryGetValue(prop, out var propSubsetting) ? propSubsetting.ToImmutableArray() : ImmutableArray<MetaProperty<TType, TProperty, TOperation>>.Empty;
                var hiddenProps = ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>.GetInstance();
                var hidingProps = ArrayBuilder<MetaProperty<TType, TProperty, TOperation>>.GetInstance();
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

        private ModelPropertyFlags ComputeSlotFlags(IEnumerable<ModelPropertyFlags> propertyFlags)
        {
            var flags = ModelPropertyFlags.None;
            foreach (ModelPropertyFlags flag in Enum.GetValues(typeof(ModelPropertyFlags)))
            {
                var allSet = true;
                var atLeastOneSet = false;
                foreach (var propertyFlag in propertyFlags)
                {
                    if (propertyFlag.HasFlag(flag))
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
                        flag == ModelPropertyFlags.Single ||
                        flag == ModelPropertyFlags.Collection ||
                        flag == ModelPropertyFlags.Map ||
                        flag == ModelPropertyFlags.MultiMap ||
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

        private void ComputeOperations(MetaClass<TType, TProperty, TOperation> cls)
        {
            var allDeclaredOperations = cls.AllDeclaredOperations;
            var modelOperationInfos = ImmutableDictionary.CreateBuilder<MetaOperation<TType, TProperty, TOperation>, MetaOperationInfo<TType, TProperty, TOperation>>();
            for (int i = 0; i < allDeclaredOperations.Length; ++i)
            {
                var op = allDeclaredOperations[i];
                var overridenOps = ArrayBuilder<MetaOperation<TType, TProperty, TOperation>>.GetInstance();
                var overridingOps = ArrayBuilder<MetaOperation<TType, TProperty, TOperation>>.GetInstance();
                for (int j = 0; j < allDeclaredOperations.Length; ++j)
                {
                    var hop = allDeclaredOperations[j];
                    if (j > i)
                    {
                        if (hop.Name == op.Name && hop.Signature == op.Signature) overridenOps.Add(hop);
                    }
                    else if (j < i)
                    {
                        if (hop.Name == op.Name && hop.Signature == op.Signature) overridingOps.Add(hop);
                    }
                }
                var opInfo = MakeOperationInfo(overridenOps.ToImmutableAndFree(), overridingOps.ToImmutableAndFree());
                modelOperationInfos.Add(op, opInfo);
            }
            cls.ModelOperationInfos = modelOperationInfos.ToImmutable();
        }

        private void Validate()
        {
            foreach (var cls in _classes)
            {
                foreach (var prop in cls.DeclaredProperties)
                {
                    var info = cls.ModelPropertyInfos[prop];
                    foreach (var oprop in info.OppositeProperties)
                    {
                        var ocls = oprop.DeclaringType;
                        var oinfo = ocls.ModelPropertyInfos[oprop];
                        if (!oinfo.OppositeProperties.Contains(prop))
                        {
                            var propName = $"{prop.DeclaringType.Name}.{prop.Name}";
                            var opropName = $"{oprop.DeclaringType.Name}.{oprop.Name}";
                            _diagnostics.Add(Diagnostic.Create(CommonErrorCode.WRN_NonMutualOpposite, prop.Location, propName, opropName));
                        }
                    }
                }
            }
        }

        protected abstract MetaClass<TType, TProperty, TOperation> MakeClass(TType classType);
        protected abstract MetaProperty<TType, TProperty, TOperation> MakeProperty(MetaClass<TType, TProperty, TOperation> declaringType, TProperty property);
        protected abstract MetaOperation<TType, TProperty, TOperation> MakeOperation(MetaClass<TType, TProperty, TOperation> declaringType, TOperation operation);
        protected abstract bool IsMapType(TType type, out TType? keyType, out ModelPropertyFlags keyFlags, out TType? valueType, out ModelPropertyFlags valueFlags);
        protected abstract bool IsCollectionType(TType type, out TType? itemType, out ModelPropertyFlags collectionFlags);
        protected abstract bool IsNullableType(TType type, out TType innerType);
        protected abstract bool IsEnumType(TType type);
        protected abstract bool IsValueType(TType type);
        protected abstract bool IsPrimitiveType(TType type);
        protected abstract MetaPropertySlot<TType, TProperty, TOperation> MakePropertySlot(MetaProperty<TType, TProperty, TOperation> slotProperty, ImmutableArray<MetaProperty<TType, TProperty, TOperation>> slotProperties, object? defaultValue, ModelPropertyFlags flags, ModelPropertyFlags keyFlags);
        protected abstract MetaPropertyInfo<TType, TProperty, TOperation> MakePropertyInfo(
            MetaPropertySlot<TType, TProperty, TOperation> slot,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> oppositeProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> subsettedProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> subsettingProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> redefinedProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> redefiningProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> hiddenProperties,
            ImmutableArray<MetaProperty<TType, TProperty, TOperation>> hidingProperties);
        protected abstract MetaOperationInfo<TType, TProperty, TOperation> MakeOperationInfo(
            ImmutableArray<MetaOperation<TType, TProperty, TOperation>> overridenOperations,
            ImmutableArray<MetaOperation<TType, TProperty, TOperation>> overridingOperations);

        private class MetaClassComparer : IComparer<MetaClass<TType, TProperty, TOperation>>
        {
            private bool _reverse;

            public MetaClassComparer(bool reverse)
            {
                _reverse = reverse;
            }

            public int Compare(MetaClass<TType, TProperty, TOperation> x, MetaClass<TType, TProperty, TOperation> y)
            {
                if (ReferenceEquals(x, y)) return 0;
                if (x.AllBaseTypes.Contains(y)) return _reverse ? -1 : 1;
                if (y.AllBaseTypes.Contains(x)) return _reverse ? 1 : -1;
                return string.Compare(x.Name, y.Name);
            }
        }

        private class MetaPropertyComparer : IComparer<MetaProperty<TType, TProperty, TOperation>>
        {
            public int Compare(MetaProperty<TType, TProperty, TOperation> x, MetaProperty<TType, TProperty, TOperation> y)
            {
                return string.Compare(x.Name, y.Name);
            }
        }

        private class MetaOperationComparer : IComparer<MetaOperation<TType, TProperty, TOperation>>
        {
            public int Compare(MetaOperation<TType, TProperty, TOperation> x, MetaOperation<TType, TProperty, TOperation> y)
            {
                var result = string.Compare(x.Name, y.Name);
                if (result != 0) return result;
                return string.Compare(x.Signature, y.Signature);
            }
        }
    }
}
