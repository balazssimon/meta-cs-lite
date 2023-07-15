using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelGroup
    {
        string? Name { get; set; }
        ModelValidationOptions ValidationOptions { get; }
        IEnumerable<IModel> References { get; }
        IEnumerable<IModel> Models { get; }
        IEnumerable<IModelObject> Objects { get; }

        void AddReference(IEnumerable<IModel> model);
        void AddReference(params IModel[] model);
        void RemoveReference(IModel model);
        IModel CreateModel(string? id = null, string? name = null);
        void AddModel(IModel model);
        void RemoveModel(IModel model);
    }
}
