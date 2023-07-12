using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelFactory
    {
        IModel Model { get; }
        IMetaModel MetaModel { get; }
        IModelObject Create(Type type, string? id = null);
        IModelObject Create(string type, string? id = null);
        Type GetSymbolType(Type type);
        Type GetSymbolType(string type);
    }
}
