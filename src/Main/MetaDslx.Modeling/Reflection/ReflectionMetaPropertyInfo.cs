using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaPropertyInfo : MetaPropertyInfo<Type, PropertyInfo>
    {
        public ReflectionMetaPropertyInfo(MetaPropertySlot<Type, PropertyInfo> slot, ImmutableArray<MetaProperty<Type, PropertyInfo>> oppositeProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo>> subsettedProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo>> subsettingProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo>> redefinedProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo>> redefiningProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties)
        {
        }
    }
}
