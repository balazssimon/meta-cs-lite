using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Meta
{
    public class MetaMetaPropertyInfo : MetaPropertyInfo<MetaType, MetaProperty, Type>
    {
        public MetaMetaPropertyInfo(MetaPropertySlot<MetaType, MetaProperty, Type> slot, ImmutableArray<MetaProperty<MetaType, MetaProperty, Type>> oppositeProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, Type>> subsettedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, Type>> subsettingProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, Type>> redefinedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, Type>> redefiningProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties)
        {
        }
    }
}
