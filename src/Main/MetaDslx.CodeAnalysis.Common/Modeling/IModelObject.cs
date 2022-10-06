using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelObject
    {
        string Id { get; set; }
        IModel? Model { get; set; }
        ImmutableArray<ModelProperty> DeclaredProperties { get; }
        ImmutableArray<ModelProperty> AllDeclaredProperties { get; }
        ImmutableArray<ModelProperty> PublicProperties { get; }
        IEnumerable<ModelProperty> Properties { get; }
        IEnumerable<ModelProperty> AttachedProperties { get; }
        ModelProperty? NameProperty { get; }
        ModelProperty? TypeProperty { get; }
        IModelObject? Parent { get; }
        IList<IModelObject> Children { get; }
        void Init(ModelProperty property, object? value);
        object? Get(ModelProperty property);
        void Add(ModelProperty property, object? item);
        void Remove(ModelProperty property, object? item);
    }
}
