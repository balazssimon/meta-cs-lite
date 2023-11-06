using MetaDslx.CodeAnalysis.Symbols;
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
    internal class MetaMetaProperty : MetaProperty<MetaType, MetaProperty>
    {
        private readonly ModelPropertyFlags _originalFlags;

        public MetaMetaProperty(MetaClass<MetaType, MetaProperty> declaringType, MetaProperty underlyingProperty) 
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

        public override MetaType OriginalType => UnderlyingProperty.Type;

        public override ModelPropertyFlags OriginalFlags => _originalFlags;

        protected override IEnumerable<(MetaType DeclaringType, string PropertyName)> GetOppositeProperties()
        {
            if (UnderlyingProperty.Opposite is not null)
            {
                yield return ((MetaType)UnderlyingProperty.Opposite.Parent, UnderlyingProperty.Opposite.Name);
            }
            else
            {
                yield break;
            }
        }

        protected override IEnumerable<(MetaType DeclaringType, string PropertyName)> GetRedefinedProperties()
        {
            yield break;
        }

        protected override IEnumerable<(MetaType DeclaringType, string PropertyName)> GetSubsettedProperties()
        {
            yield break;
        }
    }
}
