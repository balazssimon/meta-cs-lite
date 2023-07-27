using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IMultiModelFactory
    {
        ImmutableArray<IMetaModel> MetaModels { get; }
        IModelObject? Create(IModel model, Type? modelObjectType, string? id = null);
        IModelObject? Create(IModel model, string? modelObjectType, string? id = null);
    }
}
