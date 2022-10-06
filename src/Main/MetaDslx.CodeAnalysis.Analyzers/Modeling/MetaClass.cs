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
    internal class MetaClass
    {
        internal const string MetaClassAttributeName = "MetaDslx.Modeling.MetaClassAttribute";

        private MetaModel _metaModel;
        private INamedTypeSymbol _classInterface;
        private bool _isAbstract;
        private ImmutableArray<MetaClass> _baseTypes;
        private ImmutableArray<MetaProperty> _declaredProperties;
        private ImmutableArray<MetaProperty> _allDeclaredProperties;
        private ImmutableArray<MetaProperty> _publicProperties;
        private Dictionary<MetaProperty, MetaProperty>? _slotProperties;
        private Dictionary<MetaProperty, MetaSlot>? _slots;

        public MetaClass(MetaModel metaModel, INamedTypeSymbol classInterface)
        {
            _metaModel = metaModel;
            _classInterface = classInterface;
            foreach (var attr in classInterface.GetAttributes())
            {
                var attrName = attr.AttributeClass?.ToDisplayString();
                if (attrName == MetaClassAttributeName)
                {
                    foreach (var arg in attr.NamedArguments)
                    {
                        if (arg.Key == "IsAbstract" && arg.Value.Value != null)
                        {
                            _isAbstract = (bool)arg.Value.Value;
                        }
                    }
                }
            }
        }

        public SourceProductionContext Context => _metaModel.Context;
        public MetaModel MetaModel => _metaModel;
        public INamedTypeSymbol ClassInterface => _classInterface;

        public ImmutableArray<MetaClass> BaseTypes
        {
            get
            {
                if (_baseTypes.IsDefault)
                {
                    var baseTypes = ArrayBuilder<MetaClass>.GetInstance();
                    foreach (var intf in _classInterface.AllInterfaces)
                    {
                        var baseType = _metaModel.GetMetaClass(intf);
                        if (baseType != null)
                        {
                            baseTypes.Add(baseType);
                        }
                    }
                    ImmutableInterlocked.InterlockedExchange(ref _baseTypes, baseTypes.ToImmutableAndFree());
                }
                return _baseTypes;
            }
        }

        public string Name => _classInterface.Name;
        public string ImplName => _classInterface.Name + "Impl";
        public bool IsAbstract => _isAbstract;
        public bool IsRoot => BaseTypes.Length == 0;

        public ImmutableArray<MetaProperty> DeclaredProperties
        {
            get
            {
                if (_declaredProperties.IsDefault)
                {
                    ImmutableInterlocked.InterlockedExchange(ref _declaredProperties, ComputeDeclaredProperties());
                }
                return _declaredProperties;
            }
        }

        public ImmutableArray<MetaProperty> AllDeclaredProperties
        {
            get
            {
                if (_allDeclaredProperties.IsDefault) ComputeAllProperties();
                return _allDeclaredProperties;
            }
        }

        public ImmutableArray<MetaProperty> PublicProperties
        {
            get
            {
                if (_publicProperties.IsDefault) ComputeAllProperties();
                return _publicProperties;
            }
        }

        private ImmutableArray<MetaProperty> ComputeDeclaredProperties()
        {
            var declaredProperties = ArrayBuilder<MetaProperty>.GetInstance();
            foreach (var member in _classInterface.GetMembers())
            {
                if (member is IPropertySymbol propertySymbol)
                {
                    if (SymbolEqualityComparer.Default.Equals(propertySymbol.ContainingType, _classInterface))
                    {
                        declaredProperties.Add(new MetaProperty(this, propertySymbol));
                    }
                }
            }
            return declaredProperties.ToImmutableAndFree();
        }

        private void ComputeAllProperties()
        {
            var allDeclaredProperties = ArrayBuilder<MetaProperty>.GetInstance();
            var publicProperties = ArrayBuilder<MetaProperty>.GetInstance();
            allDeclaredProperties.AddRange(DeclaredProperties);
            publicProperties.AddRange(DeclaredProperties);
            foreach (var baseType in _classInterface.AllInterfaces)
            {
                var baseMetaClass = _metaModel.GetMetaClass(baseType);
                if (baseMetaClass != null)
                {
                    foreach (var prop in baseMetaClass.DeclaredProperties)
                    {
                        allDeclaredProperties.Add(prop);
                        if (!publicProperties.Any(p => p.Name == prop.Name))
                        {
                            publicProperties.Add(prop);
                        }
                    }
                }
            }
            ImmutableInterlocked.InterlockedExchange(ref _allDeclaredProperties, allDeclaredProperties.ToImmutableAndFree());
            ImmutableInterlocked.InterlockedExchange(ref _publicProperties, publicProperties.ToImmutableAndFree());
        }

        public MetaProperty GetSlotProperty(MetaProperty property)
        {
            if (_slots == null) ComputeSlots();
            return _slotProperties!.TryGetValue(property, out var result) ? result : property;
        }

        public MetaSlot GetSlot(MetaProperty property)
        {
            if (_slots == null) ComputeSlots();
            var slotProperty = GetSlotProperty(property);
            return _slots!.TryGetValue(slotProperty, out var result) ? result : new MetaSlot(property, ImmutableArray.Create(property), property.Flags);
        }

        public IEnumerable<MetaSlot> GetSlots()
        {
            if (_slots == null) ComputeSlots();
            return _slots!.Values;
        }

        private void ComputeSlots()
        {
            if (_slots != null) return;
            var components = new Dictionary<MetaProperty, int>();
            var index = 0;
            foreach (var prop in AllDeclaredProperties)
            {
                components.Add(prop, index++);
            }
            var combined = true;
            while (combined)
            {
                combined = false;
                foreach (var prop in AllDeclaredProperties)
                {
                    var propIndex = components[prop];
                    foreach (var redefProp in prop.RedefinedProperties)
                    {
                        var redefPropIndex = components[redefProp];
                        if (redefPropIndex != propIndex)
                        {
                            var minIndex = Math.Min(propIndex, redefPropIndex);
                            foreach (var mergedProp in AllDeclaredProperties)
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
            var slots = new Dictionary<int, MetaProperty>();
            foreach (var prop in AllDeclaredProperties)
            {
                var propIndex = components[prop];
                if (!slots.ContainsKey(propIndex))
                {
                    slots.Add(propIndex, prop);
                }
            }
            _slotProperties = new Dictionary<MetaProperty, MetaProperty>();
            foreach (var prop in AllDeclaredProperties)
            {
                var propIndex = components[prop];
                _slotProperties.Add(prop, slots[propIndex]);
            }
            _slots = new Dictionary<MetaProperty, MetaSlot>();
            var builder = ArrayBuilder<MetaProperty>.GetInstance();
            foreach (var slotIndex in slots.Keys)
            {
                foreach (var prop in AllDeclaredProperties)
                {
                    var propIndex = components[prop];
                    if (propIndex == slotIndex)
                    {
                        builder.Add(prop);
                    }
                }
                var slotProperties = builder.ToImmutableAndClear();
                var slotFlags = ComputeSlotFlags(slotProperties);
                _slots.Add(slots[slotIndex], new MetaSlot(slots[slotIndex], slotProperties, slotFlags));
            }
            builder.Free();
        }

        private ModelPropertyFlags ComputeSlotFlags(ImmutableArray<MetaProperty> properties)
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
                        flag == ModelPropertyFlags.MetaClassType ||
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

        public override string ToString()
        {
            return Name;
        }
    }
}
