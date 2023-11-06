﻿using MetaDslx.Bootstrap.MetaModel.Core;
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
    public class MetaMetaClass : MetaClass<MetaType, MetaProperty>
    {
        private string? _symbolType;

        public MetaMetaClass(MetaClass underlyingType) 
            : base(underlyingType)
        {
            _symbolType = underlyingType.SymbolType is null ? null : SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(underlyingType.SymbolType);
        }

        public MetaClass UnderlyingClass => (MetaClass)UnderlyingType;

        public override string Name => UnderlyingType.Name;

        public override string? SymbolType
        {
            get => _symbolType;
            set => _symbolType = value;
        }

        public override ImmutableArray<MetaType> OriginalBaseTypes => UnderlyingClass.BaseTypes.Cast<MetaType>().ToImmutableArray();

        public override ImmutableArray<MetaProperty> OriginalDeclaredProperties => UnderlyingClass.Properties.ToImmutableArray();
    }
}