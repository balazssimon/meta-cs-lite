using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModel
    {
        IEnumerable<IModelObject> ModelObjects { get; }
        void AddObject(IModelObject modelObject);
        void RemoveObject(IModelObject modelObject);
    }
}
