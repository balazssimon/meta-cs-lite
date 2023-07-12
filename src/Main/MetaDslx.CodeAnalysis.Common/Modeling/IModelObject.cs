using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelObject
    {
        string Id { get; set; }
        IMetaModel MetaModel { get; }
        IModelObject? MetaClass { get; }
        Type MetaType { get; }
        IModel? Model { get; set; }
        string? Name { get; }
        IModelObject? Parent { get; }
        IList<IModelObject> Children { get; }
        void Init(ModelProperty property, object? value);
        bool IsDefault(ModelProperty property);
        object? Get(ModelProperty property);
        void Add(ModelProperty property, object? item);
        void Remove(ModelProperty property, object? item);

        ModelProperty? NameProperty { get; }
        ModelProperty? TypeProperty { get; }
        Type? SymbolType { get; }
        ImmutableArray<ModelProperty> DeclaredProperties { get; }
        ImmutableArray<ModelProperty> AllDeclaredProperties { get; }
        ImmutableArray<ModelProperty> PublicProperties { get; }
        IEnumerable<ModelProperty> Properties { get; }
        IEnumerable<ModelProperty> AttachedProperties { get; }
        ModelProperty? GetProperty(string name);
        ImmutableArray<ModelProperty> GetOppositeProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetSubsettedProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetSubsettingProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetRedefinedProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetRedefiningProperties(ModelProperty property);
    }
}
