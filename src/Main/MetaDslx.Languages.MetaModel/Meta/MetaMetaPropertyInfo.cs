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
    public sealed class MetaMetaPropertyInfo : MetaPropertyInfo<object, MetaProperty, MetaOperation>
    {
        public MetaMetaPropertyInfo(MetaPropertySlot<object, MetaProperty, MetaOperation> slot, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> oppositeProperties = default, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> subsettedProperties = default, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> subsettingProperties = default, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> redefinedProperties = default, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> redefiningProperties = default, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> hiddenProperties = default, ImmutableArray<MetaProperty<object, MetaProperty, MetaOperation>> hidingProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties)
        {
        }
    }
}
