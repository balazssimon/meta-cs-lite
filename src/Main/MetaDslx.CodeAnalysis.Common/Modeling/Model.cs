using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class Model : IModel
    {
        private List<IModelObject> _modelObjects;

        public Model()
        {
            _modelObjects = new List<IModelObject>();
        }

        public IEnumerable<IModelObject> ModelObjects => _modelObjects;

        void IModel.AddObject(IModelObject modelObject)
        {
            _modelObjects.Add(modelObject);
            modelObject.MSetModel(this);
        }

        void IModel.RemoveObject(IModelObject modelObject)
        {
            _modelObjects.Remove(modelObject);
            modelObject.MSetModel(null);
        }
    }
}
