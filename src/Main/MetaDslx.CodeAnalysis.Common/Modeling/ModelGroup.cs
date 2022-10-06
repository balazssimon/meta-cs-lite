using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Modeling
{
    public class ModelGroup : IModelGroup
    {
        private bool _readOnly;
        private List<IModel> _references;
        private List<IModel> _models;

        public ModelGroup()
        {
            _references = new List<IModel>();
            _models = new List<IModel>();
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

        void IModelGroup.AddReference(IModel model)
        {
            CheckReadOnly();
            if (!_references.Contains(model))
            {
                _references.Add(model);
            }
        }

        void IModelGroup.RemoveReference(IModel model)
        {
            CheckReadOnly();
            _references.Remove(model);
        }

        void IModelGroup.AddModel(IModel model)
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

        void IModelGroup.RemoveModel(IModel model)
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
            if (_readOnly) throw new ModelException("The model group is read only");
        }

    }
}
