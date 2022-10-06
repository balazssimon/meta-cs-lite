using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelGroup
    {
        IEnumerable<IModel> References { get; }
        IEnumerable<IModel> Models { get; }
        IEnumerable<IModelObject> Objects { get; }

        void AddReference(IModel model);
        void RemoveReference(IModel model);
        void AddModel(IModel model);
        void RemoveModel(IModel model);
    }
}
