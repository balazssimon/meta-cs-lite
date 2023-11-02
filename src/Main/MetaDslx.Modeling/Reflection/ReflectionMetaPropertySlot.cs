using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaPropertySlot : MetaPropertySlot<Type, PropertyInfo, Type>
    {
        public ReflectionMetaPropertySlot(MetaProperty<Type, PropertyInfo, Type> slotProperty, ImmutableArray<MetaProperty<Type, PropertyInfo, Type>> slotProperties, object? defaultValue, ModelPropertyFlags flags)
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
