using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaPropertySlot : MetaPropertySlot<Type, PropertyInfo>
    {
        public ReflectionMetaPropertySlot(MetaProperty<Type, PropertyInfo> slotProperty, ImmutableArray<MetaProperty<Type, PropertyInfo>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
