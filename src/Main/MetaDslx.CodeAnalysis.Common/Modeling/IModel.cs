using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModel
    {
        string Name { get; set; }
        IEnumerable<IModelObject> ModelObjects { get; }
        void AddObject(IModelObject modelObject);
        void RemoveObject(IModelObject modelObject);
    }
}
