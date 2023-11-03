using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaModel.Meta
{
    public class MetaMetaPropertyInfo : MetaPropertyInfo<MetaType, MetaProperty, TypeSymbol>
    {
        public MetaMetaPropertyInfo(MetaPropertySlot<MetaType, MetaProperty, TypeSymbol> slot, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> oppositeProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> subsettedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> subsettingProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> redefinedProperties = default, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> redefiningProperties = default) 
            : base(slot, oppositeProperties, subsettedProperties, subsettingProperties, redefinedProperties, redefiningProperties)
        {
        }
    }
}
