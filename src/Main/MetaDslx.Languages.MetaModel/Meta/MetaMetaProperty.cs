using MetaDslx.CodeAnalysis;
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
    public sealed class MetaMetaProperty : MetaProperty<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>
    {
        private readonly ModelPropertyFlags _originalFlags;

        public MetaMetaProperty(MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> declaringType, MetaProperty underlyingProperty) 
            : base(declaringType, underlyingProperty)
        {
            var flags = ModelPropertyFlags.None;
            if (underlyingProperty.IsContainment) flags |= ModelPropertyFlags.Containment;
            if (underlyingProperty.IsDerived) flags |= ModelPropertyFlags.Derived;
            if (underlyingProperty.IsReadOnly) flags |= ModelPropertyFlags.ReadOnly;
            if (underlyingProperty.SymbolProperty == "Name") flags |= ModelPropertyFlags.Name;
            if (underlyingProperty.SymbolProperty == "Type") flags |= ModelPropertyFlags.Type;
            _originalFlags = flags;
        }

        public override string Name => UnderlyingProperty.Name;

        public override bool HasSetter => true;

        public override object? DefaultValue => UnderlyingProperty.DefaultValue;

        public override string? SymbolProperty => UnderlyingProperty.SymbolProperty;

        public override MetaDslx.CodeAnalysis.MetaType OriginalType => UnderlyingProperty.Type;

        public override ModelPropertyFlags OriginalFlags => _originalFlags;

        protected override IEnumerable<(MetaDslx.CodeAnalysis.MetaType DeclaringType, string PropertyName)> GetOppositeProperties()
        {
            foreach (var prop in UnderlyingProperty.OppositeProperties)
            {
                yield return (MetaDslx.CodeAnalysis.MetaType.FromModelObject((IModelObject)prop.Parent), prop.Name);
            }
        }

        protected override IEnumerable<(MetaDslx.CodeAnalysis.MetaType DeclaringType, string PropertyName)> GetRedefinedProperties()
        {
            foreach (var prop in UnderlyingProperty.RedefinedProperties)
            {
                yield return (MetaDslx.CodeAnalysis.MetaType.FromModelObject((IModelObject)prop.Parent), prop.Name);
            }
        }

        protected override IEnumerable<(MetaDslx.CodeAnalysis.MetaType DeclaringType, string PropertyName)> GetSubsettedProperties()
        {
            foreach (var prop in UnderlyingProperty.SubsettedProperties)
            {
                yield return (MetaDslx.CodeAnalysis.MetaType.FromModelObject((IModelObject)prop.Parent), prop.Name);
            }
        }
    }
}
