using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class Model : IModel
    {
        private string? _name;
        private List<IModelObject> _modelObjects;

        public Model(string? name = null)
        {
            _modelObjects = new List<IModelObject>();
            _name = name;
        }

        public string? Name
        {
            get => _name;
            set => _name = value;
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

        public override string ToString()
        {
            return _name;
        }
    }
}
