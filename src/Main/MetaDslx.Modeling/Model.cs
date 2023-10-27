using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public sealed class Model
    {
        private string _id;
        private string? _name;
        private bool _readOnly;
        private ModelGroup? _modelGroup;
        private List<IModelObject> _modelObjects;
        private ModelValidationOptions _validationOptions;

        public Model(string? id = null, string? name = null)
        {
            _id = id ?? Guid.NewGuid().ToString();
            _name = name;
            _modelObjects = new List<IModelObject>();
            _validationOptions = new ModelValidationOptions();
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

        public bool IsReadOnly
        {
            get => _readOnly;
            set => _readOnly = value;
        }

        public ModelValidationOptions ValidationOptions => _validationOptions;

        public ModelGroup? ModelGroup
        {
            get => _modelGroup;
            set
            {
                if (_modelGroup != null && value != null) throw new ModelException($"Error changing the model group '{_modelGroup}' of '{this}' to {value}: to change the model group of a model, remove the model from the old group first.'");
                if (_modelGroup != null && _modelGroup.IsReadOnly) throw new ModelException($"Error changing the model group '{_modelGroup}' of '{this}' to {value}: the model group containing the model is read only.");
                if (!object.ReferenceEquals(_modelGroup, value))
                {
                    var originalModelGroup = _modelGroup;
                    try
                    {
                        if (originalModelGroup != null)
                        {
                            _modelGroup = null;
                            originalModelGroup.RemoveModel(this);
                        }
                        _modelGroup = value;
                        if (_modelGroup != null)
                        {
                            _modelGroup.AddModel(this);
                        }
                    }
                    catch (Exception ex)
                    {
                        _modelGroup = originalModelGroup;
                        if (ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error setting the model group of '{this}' to {value}", ex);
                        else throw;
                    }
                }
            }
        }

        public IEnumerable<IModelObject> Objects => _modelObjects;

        public void AddObject(IModelObject modelObject)
        {
            CheckReadOnly();
            if (!_modelObjects.Contains(modelObject))
            {
                try
                {
                    _modelObjects.Add(modelObject);
                    modelObject.Model = this;
                }
                catch (Exception ex)
                {
                    _modelObjects.RemoveAt(_modelObjects.Count - 1);
                    if (ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error adding object '{modelObject}' to the model '{this}'", ex);
                    else throw;
                }
            }
        }

        public void RemoveObject(IModelObject modelObject)
        {
            CheckReadOnly();
            var index = _modelObjects.IndexOf(modelObject);
            if (index >= 0)
            {
                try
                {
                    _modelObjects.Remove(modelObject);
                    modelObject.Model = null;
                }
                catch (Exception ex)
                {
                    _modelObjects.Insert(index, modelObject);
                    if (ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error removing object '{modelObject}' from the model '{this}'", ex);
                    else throw;
                }
            }
        }

        private void CheckReadOnly()
        {
            if (ValidationOptions.ValidateReadOnly && _readOnly) throw new ModelException("The model is read only");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
