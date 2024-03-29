﻿using MetaDslx.Modeling;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling
{
    public class Model
    {
        private string _id;
        private string? _name;
        private bool _readOnly;
        private bool _sealed;
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
            set
            {
                CheckReadOnly();
                _id = value;
            }
        }

        public string? Name
        {
            get => _name;
            set
            {
                CheckReadOnly();
                _name = value;
            }
        }

        public bool IsReadOnly
        {
            get => _readOnly;
            set
            {
                if (_sealed) throw new ModelException("The model is sealed.");
                _readOnly = value;
            }
        }

        public bool IsSealed
        {
            get => _sealed;
            set
            {
                if (_sealed && !value) throw new ModelException("The model is sealed.");
                _sealed = value;
                if (_sealed) _readOnly = true;
            }
        }

        public ModelValidationOptions ValidationOptions => _validationOptions;

        public ModelGroup? ModelGroup
        {
            get => _modelGroup;
            set
            {
                CheckReadOnly();
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
                            originalModelGroup.DetachModel(this);
                        }
                        _modelGroup = value;
                        if (_modelGroup != null)
                        {
                            _modelGroup.AttachModel(this);
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
        public IEnumerable<IModelObject> RootObjects => _modelObjects.Where(mobj => mobj.MParent is null);

        public bool AttachObject(IModelObject? modelObject)
        {
            if (modelObject is null) return false;
            CheckReadOnly();
            if (!_modelObjects.Contains(modelObject))
            {
                try
                {
                    _modelObjects.Add(modelObject);
                    modelObject.MModel = this;
                    return true;
                }
                catch (Exception ex)
                {
                    _modelObjects.RemoveAt(_modelObjects.Count - 1);
                    if (ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error adding object '{modelObject}' to the model '{this}'", ex);
                    else throw;
                }
            }
            return false;
        }

        public bool DetachObject(IModelObject? modelObject)
        {
            if (modelObject is null) return false;
            CheckReadOnly();
            var index = _modelObjects.IndexOf(modelObject);
            if (index >= 0)
            {
                try
                {
                    _modelObjects.Remove(modelObject);
                    modelObject.MModel = null;
                    return true;
                }
                catch (Exception ex)
                {
                    _modelObjects.Insert(index, modelObject);
                    if (ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error removing object '{modelObject}' from the model '{this}'", ex);
                    else throw;
                }
            }
            return false;
        }

        public void DeleteObject(IModelObject? modelObject, CancellationToken cancellationToken = default)
        {
            if (modelObject is null) return;
            var objectsToDelete = modelObject.GetAllContainedObjects<IModelObject>(includeSelf: true, cancellationToken: cancellationToken);
            foreach (var mobj in objectsToDelete)
            {
                if (DetachObject(mobj))
                {
                    var references = mobj.MReferences.ToImmutableArray();
                    foreach (var reference in references)
                    {
                        reference.Slot.Remove(mobj);
                    }
                }
            }
        }

        public void ReplaceObject(IModelObject oldObject, IModelObject? newObject, CancellationToken cancellationToken = default)
        {
            var references = oldObject.MReferences.ToImmutableArray();
            foreach (var reference in references)
            {
                reference.Slot.Replace(oldObject, newObject);
            }
        }

        internal void CheckReadOnly(string? message = null)
        {
            if (_sealed) throw new ModelException(message is null ? $"The model '{_name}' is sealed." : $"{message}: the model '{_name}' is sealed.");
            if (ValidationOptions.ValidateReadOnly && _readOnly) throw new ModelException(message is null ? $"The model '{_name}' is read only." : $"{message}: the model '{_name}' is read only.");
        }

        internal protected virtual ValueInfo CreateValueInfo(object? forValue)
        {
            return new ValueInfo(forValue);
        }

        public override string ToString()
        {
            return _name;
        }
    }
}
