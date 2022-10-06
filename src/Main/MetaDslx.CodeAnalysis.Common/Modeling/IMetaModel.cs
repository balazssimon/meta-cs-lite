using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IMetaModel
    {
        string Name { get; }
        ModelVersion Version { get; }
        string Uri { get; }
        string Prefix { get; }
        IModelFactory CreateFactory(IModel model);
    }
}
