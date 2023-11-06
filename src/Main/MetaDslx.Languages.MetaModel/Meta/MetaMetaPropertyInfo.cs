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
    public sealed class MetaMetaPropertyInfo : MetaPropertyInfo<MetaType, MetaProperty>
    {
        public MetaMetaPropertyInfo(MetaPropertySlot<MetaType, MetaProperty> slot, ImmutableArray<MetaProperty<MetaType, MetaProperty>> oppositeProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty>> subsettedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty>> subsettingProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty>> redefinedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty>> redefiningProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty>> hiddenProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty>> hidingProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties, hiddenProperties, hidingProperties)
        {
        }
    }
}
