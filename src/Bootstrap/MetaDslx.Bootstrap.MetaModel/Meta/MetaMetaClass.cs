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
    public class MetaMetaClass : MetaClass<MetaType, MetaProperty, TypeSymbol>
    {
        public MetaMetaClass(MetaClass underlyingType) 
            : base(underlyingType)
        {
        }

        public MetaClass UnderlyingClass => (MetaClass)UnderlyingType;

        public override string Name => UnderlyingType.Name;

        public override TypeSymbol? SymbolType
        {
            get => UnderlyingClass.SymbolType;
            set => UnderlyingClass.SymbolType = value;
        }

        public override ImmutableArray<MetaType> OriginalBaseTypes => UnderlyingClass.BaseTypes.Cast<MetaType>().ToImmutableArray();

        public override ImmutableArray<MetaProperty> OriginalDeclaredProperties => UnderlyingClass.Properties.ToImmutableArray();
    }
}
