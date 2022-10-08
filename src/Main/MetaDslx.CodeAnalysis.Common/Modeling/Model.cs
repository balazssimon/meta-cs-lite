﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    public class Model : IModel
    {
        private string _id;
        private string? _name;
        private bool _readOnly;
        private ModelGroup? _modelGroup;
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

        public bool IsReadOnly
        {
            get => _readOnly;
            set => _readOnly = value;
        }

        public ModelGroup? ModelGroup
        {
            get => _modelGroup;
            set
            {
                if (_modelGroup != null && value != null) throw new ArgumentException(nameof(value), $"Model '{this}' is already contained by the model group '{_modelGroup}. To change the group of a model, remove the model from the old group first.'");
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
                    catch
                    {
                        _modelGroup = originalModelGroup;
                        throw;
                    }
                }
            }
        }

        public IEnumerable<IModelObject> Objects => _modelObjects;

        IModelGroup IModel.ModelGroup 
        {
            get => this.ModelGroup; 
            set => this.ModelGroup = (ModelGroup)value; 
        }

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
                catch
                {
                    _modelObjects.RemoveAt(_modelObjects.Count - 1);
                    throw;
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
                catch
                {
                    _modelObjects.Insert(index, modelObject);
                    throw;
                }
            }
        }

        private void CheckReadOnly()
        {
            if (_readOnly) throw new ModelException("The model is read only");
        }

        public override string ToString()
        {
            return _name;
        }
    }
}