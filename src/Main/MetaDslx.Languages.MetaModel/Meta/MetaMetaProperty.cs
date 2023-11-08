﻿using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Languages.MetaModel.Meta
{
    public sealed class MetaMetaProperty : MetaProperty<object, MetaProperty, MetaOperation>
    {
        private readonly ModelPropertyFlags _originalFlags;

        public MetaMetaProperty(MetaClass<object, MetaProperty, MetaOperation> declaringType, MetaProperty underlyingProperty) 
            : base(declaringType, underlyingProperty)
        {
            var flags = ModelPropertyFlags.None;
            if (underlyingProperty.IsContainment) flags |= ModelPropertyFlags.Containment;
            if (underlyingProperty.IsDerived) flags |= ModelPropertyFlags.Derived;
            if (underlyingProperty.Type is MetaPrimitiveType mpt && mpt.Name == "type") flags |= ModelPropertyFlags.TypeSymbolType;
            _originalFlags = flags;
        }

        public override string Name => UnderlyingProperty.Name;

        public override bool HasSetter => true;

        public override object? DefaultValue => null;

        public override string? SymbolProperty => UnderlyingProperty.SymbolProperty;

        public override object OriginalType => UnderlyingProperty.Type;

        public override ModelPropertyFlags OriginalFlags => _originalFlags;

        protected override IEnumerable<(object DeclaringType, string PropertyName)> GetOppositeProperties()
        {
            foreach (var prop in UnderlyingProperty.OppositeProperties)
            {
                yield return ((MetaType)prop.Parent, prop.Name);
            }
        }

        protected override IEnumerable<(object DeclaringType, string PropertyName)> GetRedefinedProperties()
        {
            foreach (var prop in UnderlyingProperty.RedefinedProperties)
            {
                yield return ((MetaType)prop.Parent, prop.Name);
            }
        }

        protected override IEnumerable<(object DeclaringType, string PropertyName)> GetSubsettedProperties()
        {
            foreach (var prop in UnderlyingProperty.SubsettedProperties)
            {
                yield return ((MetaType)prop.Parent, prop.Name);
            }
        }
    }
}
