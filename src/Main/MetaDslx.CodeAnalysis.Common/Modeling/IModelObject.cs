using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelObject
    {
        IModel? MModel { get; }
        ImmutableArray<ModelProperty> MDeclaredProperties { get; }
        ImmutableArray<ModelProperty> MAllDeclaredProperties { get; }
        ImmutableArray<ModelProperty> MPublicProperties { get; }
        IEnumerable<ModelProperty> MProperties { get; }
        IEnumerable<ModelProperty> MAttachedProperties { get; }
        ModelProperty? MNameProperty { get; }
        ModelProperty? MTypeProperty { get; }
        IModelObject? MParent { get; }
        IList<IModelObject> MChildren { get; }
        void MSetModel(IModel? model);
        void MInit(ModelProperty property, object? value);
        object? MGet(ModelProperty property);
        void MAdd(ModelProperty property, object? item);
        void MRemove(ModelProperty property, object? item);
    }
}
