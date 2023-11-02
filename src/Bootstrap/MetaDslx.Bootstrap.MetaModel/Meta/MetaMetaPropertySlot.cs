using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Meta
{
    public class MetaMetaPropertySlot : MetaPropertySlot<MetaType, MetaProperty, Type>
    {
        public MetaMetaPropertySlot(MetaProperty<MetaType, MetaProperty, Type> slotProperty, ImmutableArray<MetaProperty<MetaType, MetaProperty, Type>> slotProperties, object? defaultValue, ModelPropertyFlags flags) 
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
