using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaGraph : MetaGraph<Type, PropertyInfo, MethodInfo>
    {
        public ReflectionMetaGraph(IEnumerable<Type> classTypes) 
            : base(classTypes)
        {
        }

        protected override bool IsCollectionType(Type type, out Type? itemType, out ModelPropertyFlags collectionFlags)
        {
            itemType = null;
            collectionFlags = ModelPropertyFlags.None;
            if (type.GenericTypeArguments.Length == 1)
            {
                itemType = type.GenericTypeArguments[0];
                if (type.Namespace == "System.Collections.Generic")
                {
                    if (type.Name == "IList`1" || type.Name == "List`1" || type.Name == "LinkedList`1")
                    {
                        collectionFlags |= ModelPropertyFlags.NonUnique;
                    }
                    if (type.Name == "ISet`1" || type.Name == "HashSet`1" || type.Name == "SortedSet`1")
                    {
                        collectionFlags |= ModelPropertyFlags.Unordered;
                    }
                    type = itemType;
                    return true;
                }
                else if (type.GetInterfaces().Any(intf => intf == typeof(IList<>)))
                {
                    type = itemType;
                    collectionFlags |= ModelPropertyFlags.NonUnique;
                    return true;
                }
                else if (type.GetInterfaces().Any(intf => intf == typeof(ISet<>)))
                {
                    type = itemType;
                    collectionFlags |= ModelPropertyFlags.Unordered;
                    return true;
                }
                else if (type.GetInterfaces().Any(intf => intf == typeof(ICollection<>)))
                {
                    type = itemType;
                    collectionFlags |= ModelPropertyFlags.NonUnique | ModelPropertyFlags.Unordered;
                    return true;
                }
            }
            itemType = null;
            collectionFlags = ModelPropertyFlags.None;
            return false;
        }

        protected override bool IsEnumType(Type type)
        {
            return type.IsEnum;
        }

        protected override bool IsNullableType(Type type, out Type innerType)
        {
            innerType = type;
            if (type.Namespace == "System" && type.Name == "Nullable`1" && type.GenericTypeArguments.Length == 1)
            {
                innerType = type.GenericTypeArguments[0];
                return true;
            }
            if (type.CustomAttributes.Any(x => x.AttributeType.Name == "NullableAttribute"))
            {
                return true;
            }
            return false;
        }

        protected override bool IsPrimitiveType(Type type)
        {
            return type.IsPrimitive || type == typeof(string) || type == typeof(decimal);
        }

        protected override bool IsValueType(Type type)
        {
            return type.IsValueType;
        }

        protected override MetaClass<Type, PropertyInfo, MethodInfo> MakeClass(Type classType)
        {
            return new ReflectionMetaClass(classType);
        }

        protected override MetaOperation<Type, PropertyInfo, MethodInfo> MakeOperation(MetaClass<Type, PropertyInfo, MethodInfo> declaringType, MethodInfo operation)
        {
            return new ReflectionMetaOperation(declaringType, operation);
        }

        protected override MetaOperationInfo<Type, PropertyInfo, MethodInfo> MakeOperationInfo(ImmutableArray<MetaOperation<Type, PropertyInfo, MethodInfo>> overridenOperations, ImmutableArray<MetaOperation<Type, PropertyInfo, MethodInfo>> overridingOperations)
        {
            return new ReflectionMetaOperationInfo(overridenOperations, overridingOperations);
        }

        protected override MetaProperty<Type, PropertyInfo, MethodInfo> MakeProperty(MetaClass<Type, PropertyInfo, MethodInfo> declaringType, PropertyInfo property)
        {
            return new ReflectionMetaProperty(declaringType, property);
        }

        protected override MetaPropertyInfo<Type, PropertyInfo, MethodInfo> MakePropertyInfo(MetaPropertySlot<Type, PropertyInfo, MethodInfo> slot, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> oppositeProperties, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> subsettedProperties, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> subsettingProperties, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> redefinedProperties, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> redefiningProperties, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> hiddenProperties, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> hidingProperties)
        {
            return new ReflectionMetaPropertyInfo(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties);
        }

        protected override MetaPropertySlot<Type, PropertyInfo, MethodInfo> MakePropertySlot(MetaProperty<Type, PropertyInfo, MethodInfo> slotProperty, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            return new ReflectionMetaPropertySlot(slotProperty, slotProperties, defaultValue, flags);
        }
    }
}
