using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaModel.Meta
{
    public sealed class MetaMetaPropertySlot : MetaPropertySlot<MetaType, MetaProperty>
    {
        public MetaMetaPropertySlot(MetaProperty<MetaType, MetaProperty> slotProperty, ImmutableArray<MetaProperty<MetaType, MetaProperty>> slotProperties, object? defaultValue, ModelPropertyFlags flags) 
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
