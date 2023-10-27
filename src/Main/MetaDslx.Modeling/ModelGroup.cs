using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MetaDslx.Modeling
{
    public sealed class ModelGroup
    {
        private string? _name;
        private bool _readOnly;
        private ModelValidationOptions? _validationOptions;
        private List<Model> _references;
        private List<Model> _models;

        public ModelGroup()
        {
            _validationOptions = new ModelValidationOptions();
            _references = new List<Model>();
            _models = new List<Model>();
        }

        public string? Name
        {
            get => _name;
            set => _name = value;
        }

        public bool IsReadOnly
        {
            get => _readOnly;
            set
            {
                IsReadOnly = value;
                foreach (var model in _models)
                {
                    model.IsReadOnly = value;
                }
            }
        }

        public ModelValidationOptions ValidationOptions
        {
            get => _validationOptions;
        }

        public IEnumerable<Model> References => _references;

        public IEnumerable<Model> Models => _models;

        public IEnumerable<IModelObject> ModelObjects
        {
            get
            {
                foreach (var model in _models)
                {
                    foreach (var mobj in model.ModelObjects)
                    {
                        yield return mobj;
                    }
                }
            }
        }

        public IEnumerable<object> Objects => ModelObjects.Select(mobj => mobj.UnderlyingObject);

        public void AddReference(IEnumerable<Model> models)
        {
            CheckReadOnly();
            foreach (var model in models)
            {
                if (!_references.Contains(model))
                {
                    _references.Add(model);
                }
            }
        }

        public void AddReference(params Model[] models)
        {
            CheckReadOnly();
            foreach (var model in models)
            {
                if (!_references.Contains(model))
                {
                    _references.Add(model);
                }
            }
        }

        public void RemoveReference(Model model)
        {
            CheckReadOnly();
            _references.Remove(model);
        }

        public Model CreateModel(string? id = null, string? name = null)
        {
            var model = new Model(id, name);
            AddModel(model);
            return model;
        }

        public void AddModel(Model model)
        {
            CheckReadOnly();
            if (!_models.Contains(model))
            {
                try
                {
                    _models.Add(model);
                    model.ModelGroup = this;
                }
                catch
                {
                    _models.RemoveAt(_models.Count - 1);
                    throw;
                }
            }
        }

        public void RemoveModel(Model model)
        {
            CheckReadOnly();
            var index = _models.IndexOf(model);
            if (index >= 0)
            {
                try
                {
                    _models.Remove(model);
                    model.ModelGroup = null;
                }
                catch
                {
                    _models.Insert(index, model);
                    throw;
                }
            }
        }

        private void CheckReadOnly()
        {
            if (_readOnly) throw new ModelException($"The model group '{Name}' is read only");
        }

        public override string ToString()
        {
            return Name;
        }

    }
}
