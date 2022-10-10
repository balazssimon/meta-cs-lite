using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModel
    {
        string Id { get; set; }
        string Name { get; set; }
        bool IsReadOnly { get; set; }
        ModelValidationFlags ValidationFlags { get; set; }
        IModelGroup ModelGroup { get; set; }
        IEnumerable<IModelObject> Objects { get; }
        void AddObject(IModelObject modelObject);
        void RemoveObject(IModelObject modelObject);
    }
}
