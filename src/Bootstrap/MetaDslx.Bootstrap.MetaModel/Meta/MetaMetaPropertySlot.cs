using MetaDslx.Bootstrap.MetaModel.Core;
using MetaDslx.CodeAnalysis.Symbols;
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
    public class MetaMetaPropertySlot : MetaPropertySlot<MetaType, MetaProperty, TypeSymbol>
    {
        public MetaMetaPropertySlot(MetaProperty<MetaType, MetaProperty, TypeSymbol> slotProperty, ImmutableArray<MetaProperty<MetaType, MetaProperty, TypeSymbol>> slotProperties, object? defaultValue, ModelPropertyFlags flags) 
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
