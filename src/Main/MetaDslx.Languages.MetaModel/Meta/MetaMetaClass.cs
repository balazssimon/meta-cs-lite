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
    public sealed class MetaMetaClass : MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>
    {
        private object? _symbolType;

        public MetaMetaClass(MetaDslx.CodeAnalysis.MetaType underlyingType) 
            : base(underlyingType)
        {
            _symbolType = UnderlyingClass.SymbolType?.IsNull ?? true ? (object?)null : (object?)UnderlyingClass.SymbolType;
        }

        public MetaClass UnderlyingClass => (MetaClass)UnderlyingType.OriginalModelObject;

        public override string Name => UnderlyingClass.Name;

        public override object? SymbolType
        {
            get => _symbolType;
            set => _symbolType = value;
        }

        public override ImmutableArray<MetaDslx.CodeAnalysis.MetaType> OriginalBaseTypes => UnderlyingClass.BaseTypes.Select(bt => MetaDslx.CodeAnalysis.MetaType.FromModelObject((IModelObject)bt)).ToImmutableArray();

        public override ImmutableArray<MetaProperty> OriginalDeclaredProperties => UnderlyingClass.Properties.ToImmutableArray();

        public override ImmutableArray<MetaOperation> OriginalDeclaredOperations => UnderlyingClass.Operations.ToImmutableArray();

    }
}
