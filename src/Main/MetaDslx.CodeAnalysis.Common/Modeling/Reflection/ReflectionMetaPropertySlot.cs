using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaPropertySlot : MetaPropertySlot<Type, PropertyInfo, MethodInfo>
    {
        public ReflectionMetaPropertySlot(MetaProperty<Type, PropertyInfo, MethodInfo> slotProperty, ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> slotProperties, MetaSymbol defaultValue, ModelPropertyFlags flags)
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
