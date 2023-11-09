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
    public sealed class MetaMetaPropertySlot : MetaPropertySlot<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>
    {
        public MetaMetaPropertySlot(MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> slotProperty, ImmutableArray<MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> slotProperties, object? defaultValue, ModelPropertyFlags flags) 
            : base(slotProperty, slotProperties, defaultValue, flags)
        {
        }
    }
}
