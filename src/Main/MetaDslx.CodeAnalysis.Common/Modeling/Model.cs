using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class Model : IModel
    {
        private string _id;
        private string? _name;
        private List<IModelObject> _modelObjects;

        public Model(string? id = null, string? name = null)
        {
            _id = id ?? Guid.NewGuid().ToString();
            _name = name;
            _modelObjects = new List<IModelObject>();
        }

        public string Id
        {
            get => _id;
            set => _id = value;
        }

        public string? Name
        {
            get => _name;
            set => _name = value;
        }
        public IEnumerable<IModelObject> ModelObjects => _modelObjects;

        void IModel.AddObject(IModelObject modelObject)
        {
            if (!_modelObjects.Contains(modelObject))
            {
                try
                {
                    _modelObjects.Add(modelObject);
                    modelObject.Model = this;
                }
                catch
                {
                    _modelObjects.RemoveAt(_modelObjects.Count - 1);
                    throw;
                }
            }
        }

        void IModel.RemoveObject(IModelObject modelObject)
        {
            var index = _modelObjects.IndexOf(modelObject);
            if (index >= 0)
            {
                try
                {
                    _modelObjects.Remove(modelObject);
                    modelObject.Model = null;
                }
                catch
                {
                    _modelObjects.Insert(index, modelObject);
                    throw;
                }
            }
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
