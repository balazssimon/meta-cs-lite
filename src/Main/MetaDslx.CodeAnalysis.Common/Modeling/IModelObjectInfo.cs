using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelObjectInfo
    {
        IMetaModelInfo MetaModelInfo { get; }
        IMetaModel MetaModel { get; }
        IModelObject? MetaClass { get; }
        Type MetaType { get; }
        Type? SymbolType { get; }
        ModelProperty? NameProperty { get; }
        ModelProperty? TypeProperty { get; }
        ImmutableArray<ModelProperty> DeclaredProperties { get; }
        ImmutableArray<ModelProperty> AllDeclaredProperties { get; }
        ImmutableArray<ModelProperty> PublicProperties { get; }
        ModelProperty? GetProperty(string name);
        ImmutableArray<ModelProperty> GetOppositeProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetSubsettedProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetSubsettingProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetRedefinedProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetRedefiningProperties(ModelProperty property);
    }
}
