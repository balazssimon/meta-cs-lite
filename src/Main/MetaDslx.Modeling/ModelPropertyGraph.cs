using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public static class ModelPropertyGraph
    {
        public static Dictionary<ModelProperty, ModelPropertyInfo> Compute(
            ImmutableArray<ModelProperty> allDeclaredProperties,
            Dictionary<ModelProperty, HashSet<ModelProperty>> subsettedProperties,
            Dictionary<ModelProperty, HashSet<ModelProperty>> redefinedProperties,
            Dictionary<ModelProperty, HashSet<ModelProperty>> oppositeProperties)
        {
            var subsettingProperties = new Dictionary<ModelProperty, ArrayBuilder<ModelProperty>>();
            foreach (var prop in subsettedProperties.Keys)
            {
                foreach (var subsettedProp in subsettedProperties[prop])
                {
                    if (!subsettingProperties.TryGetValue(subsettedProp, out var propSubsetting))
                    {
                        propSubsetting = new ArrayBuilder<ModelProperty>();
                        subsettingProperties.Add(subsettedProp, propSubsetting);
                    }
                    propSubsetting.Add(prop);
                }
            }
            var redefiningProperties = new Dictionary<ModelProperty, ArrayBuilder<ModelProperty>>();
            foreach (var prop in redefinedProperties.Keys)
            {
                foreach (var redefinedProp in redefinedProperties[prop])
                {
                    if (!redefiningProperties.TryGetValue(redefinedProp, out var propRedefining))
                    {
                        propRedefining = new ArrayBuilder<ModelProperty>();
                        redefiningProperties.Add(redefinedProp, propRedefining);
                    }
                    propRedefining.Add(prop);
                }
            }
            var components = new Dictionary<ModelProperty, int>();
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
            var propIds = new Dictionary<int, ModelProperty>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                if (!propIds.ContainsKey(propIndex))
                {
                    propIds.Add(propIndex, prop);
                }
            }
            var propToSlotProp = new Dictionary<ModelProperty, ModelProperty>();
            foreach (var prop in allDeclaredProperties)
            {
                var propIndex = components[prop];
                propToSlotProp.Add(prop, propIds[propIndex]);
            }
            var slotPropToSlot = new Dictionary<ModelProperty, ModelPropertySlot>();
            var builder = ArrayBuilder<ModelProperty>.GetInstance();
            var slots = ArrayBuilder<ModelPropertySlot>.GetInstance();
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
                var slot = new ModelPropertySlot(propIds[slotIndex], slotProperties, propIds[slotIndex].DefaultValue, slotFlags);
                slots.Add(slot);
                slotPropToSlot.Add(propIds[slotIndex], slot);
            }
            builder.Free();
            var modelPropertyInfos = new Dictionary<ModelProperty, ModelPropertyInfo>();
            foreach (var prop in allDeclaredProperties)
            {
                var oppositeProps = oppositeProperties.TryGetValue(prop, out var propOpposite) ? propOpposite.ToImmutableArray() : ImmutableArray<ModelProperty>.Empty;
                var redefinedProps = redefinedProperties.TryGetValue(prop, out var propRedefined) ? propRedefined.ToImmutableArray() : ImmutableArray<ModelProperty>.Empty;
                var redefiningProps = redefiningProperties.TryGetValue(prop, out var propRedefining) ? propRedefining.ToImmutableArray() : ImmutableArray<ModelProperty>.Empty;
                var subsettedProps = subsettedProperties.TryGetValue(prop, out var propSubsetted) ? propSubsetted.ToImmutableArray() : ImmutableArray<ModelProperty>.Empty;
                var subsettingProps = subsettingProperties.TryGetValue(prop, out var propSubsetting) ? propSubsetting.ToImmutableArray() : ImmutableArray<ModelProperty>.Empty;
                var propInfo = new ModelPropertyInfo(slotPropToSlot[propToSlotProp[prop]], oppositeProps, subsettedProps, subsettingProps, redefinedProps, redefiningProps);
                modelPropertyInfos.Add(prop, propInfo);
            }
            return modelPropertyInfos;
        }

        private static ModelPropertyFlags ComputeSlotFlags(ImmutableArray<ModelProperty> properties)
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

    }
}
