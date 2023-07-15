using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelFactory
    {
        IModel Model { get; }
        IMetaModel MetaModel { get; }
        IModelObject? Create(Type modelObjectType, string? id = null);
        IModelObject? Create(string modelObjectTypeName, string? id = null);
    }
}
