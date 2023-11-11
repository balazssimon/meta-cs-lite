using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaPropertyInfo : MetaPropertyInfo<Type, PropertyInfo, MethodInfo>
    {
        public ReflectionMetaPropertyInfo(MetaPropertySlot<Type, PropertyInfo, MethodInfo> slot, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> oppositeProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> subsettedProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> subsettingProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> redefinedProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> redefiningProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> hiddenProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> hidingProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties)
        {
        }
    }
}
