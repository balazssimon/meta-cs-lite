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
    public sealed class MetaMetaClass : MetaClass<object, MetaProperty, MetaOperation>
    {
        private object? _symbolType;

        public MetaMetaClass(MetaClass underlyingType) 
            : base(underlyingType)
        {
            _symbolType = underlyingType.SymbolType;
        }

        public MetaClass UnderlyingClass => (MetaClass)UnderlyingType;

        public override string Name => UnderlyingClass.Name;

        public override object? SymbolType
        {
            get => _symbolType;
            set => _symbolType = value;
        }

        public override ImmutableArray<object> OriginalBaseTypes => UnderlyingClass.BaseTypes.Cast<object>().ToImmutableArray();

        public override ImmutableArray<MetaProperty> OriginalDeclaredProperties => UnderlyingClass.Properties.ToImmutableArray();

        public override ImmutableArray<MetaOperation> OriginalDeclaredOperations => UnderlyingClass.Operations.ToImmutableArray();

    }
}
