using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IMultiModelFactory
    {
        ImmutableArray<IMetaModel> MetaModels { get; }
        IModelObject? Create(Model model, Type modelObjectType, string? id = null);
        IModelObject? Create(Model model, string modelObjectType, string? id = null);
    }
}
