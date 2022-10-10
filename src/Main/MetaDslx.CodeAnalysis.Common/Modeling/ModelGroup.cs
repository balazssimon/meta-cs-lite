using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelGroup : IModelGroup
    {
        private string? _name;
        private bool _readOnly;
        private ModelValidationOptions? _validationOptions;
        private List<IModel> _references;
        private List<IModel> _models;

        public ModelGroup()
        {
            _validationOptions = new ModelValidationOptions();
            _references = new List<IModel>();
            _models = new List<IModel>();
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

        public IEnumerable<IModel> References => _references;

        public IEnumerable<IModel> Models => _models;

        public IEnumerable<IModelObject> Objects
        {
            get
            {
                foreach (var model in _models)
                {
                    foreach (var mobj in model.Objects)
                    {
                        yield return mobj;
                    }
                }
            }
        }

        public void AddReference(IEnumerable<IModel> models)
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

        public void AddReference(params IModel[] models)
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

        public void RemoveReference(IModel model)
        {
            CheckReadOnly();
            _references.Remove(model);
        }

        public IModel CreateModel(string? id = null, string? name = null)
        {
            var model = new Model(id, name);
            AddModel(model);
            return model;
        }

        public void AddModel(IModel model)
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

        public void RemoveModel(IModel model)
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
