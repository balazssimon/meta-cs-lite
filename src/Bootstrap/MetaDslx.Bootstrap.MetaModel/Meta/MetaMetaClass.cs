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
    public class MetaMetaClass : MetaClass<MetaType, MetaProperty, Type>
    {
        public MetaMetaClass(MetaClass underlyingType) 
            : base(underlyingType)
        {
        }

        public MetaClass UnderlyingClass => (MetaClass)UnderlyingType;

        public override string Name => UnderlyingType.Name;

        public override Type? SymbolType => UnderlyingClass.SymbolType;

        protected override ImmutableArray<MetaType> OriginalBaseTypes => UnderlyingClass.BaseTypes.Cast<MetaType>().ToImmutableArray();

        protected override ImmutableArray<MetaProperty> OriginalDeclaredProperties => UnderlyingClass.Properties.ToImmutableArray();
    }
}
