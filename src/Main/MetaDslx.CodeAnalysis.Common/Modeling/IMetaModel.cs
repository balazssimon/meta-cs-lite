using MetaDslx.CodeAnalysis.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IMetaModel
    {
        string Name { get; }
        string FullName { get; }
        ModelVersion Version { get; }
        string Uri { get; }
        string Prefix { get; }
       
        IMetaModelInfo Info { get; }
        IMultiModelFactory CreateFactory();
        IModelFactory CreateFactory(IModel model);
    }
}
