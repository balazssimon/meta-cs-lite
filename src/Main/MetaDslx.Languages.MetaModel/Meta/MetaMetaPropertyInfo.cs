using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaModel.Meta
{
    public sealed class MetaMetaPropertyInfo : MetaPropertyInfo<MetaType, MetaProperty, MetaOperation>
    {
        public MetaMetaPropertyInfo(MetaPropertySlot<MetaType, MetaProperty, MetaOperation> slot, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> oppositeProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> subsettedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> subsettingProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> redefinedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> redefiningProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> hiddenProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, MetaOperation>> hidingProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties)
        {
        }
    }
}
