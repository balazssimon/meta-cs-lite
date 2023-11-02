using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaPropertyInfo : MetaPropertyInfo<Type, PropertyInfo, Type>
    {
        public ReflectionMetaPropertyInfo(MetaPropertySlot<Type, PropertyInfo, Type> slot, ImmutableArray<MetaProperty<Type, PropertyInfo, Type>> oppositeProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, Type>> subsettedProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, Type>> subsettingProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, Type>> redefinedProperties = default, ImmutableArray<MetaProperty<Type, PropertyInfo, Type>> redefiningProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties)
        {
        }
    }
}
