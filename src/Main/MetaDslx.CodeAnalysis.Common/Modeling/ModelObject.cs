using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class ModelObject : IModelObject, IReferenceableModelObject
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string _id;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Model? _model;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IModelObject? _parent;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ChildList _children;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private HashSet<Box>? _references;

        public ModelObject(string? id = null)
        {
            _id = id ?? Guid.NewGuid().ToString();
            _children = new ChildList(this);
        }

        protected abstract ModelClassInfo MInfo { get; }

        Model? IModelObject.Model
        {
            get => _model;
            set
            {
                if (_model != null && value != null && !object.ReferenceEquals(_model, value)) throw new ModelException($"Error changing the model '{_model}' of '{this}' to {value}: to change the model of an object, remove the object from the old model first.'");
                _model?.CheckReadOnly($"Error changing the model '{_model}' of '{this}' to {value}");
                if (!object.ReferenceEquals(_model, value))
                {
                    var originalModel = _model;
                    try
                    {
                        if (originalModel != null)
                        {
                            _model = null;
                            originalModel.RemoveObject(this);
                        }
                        _model = value;
                        if (_model != null)
                        {
                            _model.AddObject(this);
                        }
                    }
                    catch (Exception ex)
                    {
                        _model = originalModel;
                        throw new ModelException($"Error setting the model of '{this}' to {value}", ex);
                    }
                }
            }
        }

        IModelObject? IModelObject.Parent
        {
            get => _parent;
            set
            {
                if (_parent != null && value != null && !object.ReferenceEquals(_parent, value)) throw new ModelException($"Error changing the parent '{_parent}' of '{this}' to {value}: to change the parent of an object, remove the object from the old parent first.'");
                _model?.CheckReadOnly($"Error changing the parent '{_parent}' of '{this}' to {value}");
                if (!object.ReferenceEquals(_parent, value))
                {
                    var originalParent = _parent;
                    try
                    {
                        if (originalParent != null)
                        {
                            _parent = null;
                            originalParent.Children.Remove(this);
                        }
                        _parent = value;
                        if (_parent != null)
                        {
                            _parent.Children.Add(this);
                        }
                    }
                    catch (Exception ex)
                    {
                        _parent = originalParent;
                        throw new ModelException($"Error setting the parent of '{this}' to {value}", ex);
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        string IModelObject.Id
        {
            get => _id;
            set
            {
                _model?.CheckReadOnly($"Error changing the id '{_id}' of '{this}' to {value}");
                _id = value;
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        MetaModel IModelObject.MetaModel => MInfo.MetaModel;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        MetaType IModelObject.MetaType => MInfo.MetaType;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelClassInfo IModelObject.Info => MInfo;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IList<IModelObject> IModelObject.Children => _children;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.DeclaredProperties => MInfo.DeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.AllDeclaredProperties => MInfo.AllDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.PublicProperties => MInfo.PublicProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]

        IEnumerable<ModelProperty> IModelObject.Properties
        {
            get
            {
                foreach (var prop in MInfo.PublicProperties)
                {
                    yield return prop;
                }
                foreach (var prop in ((IModelObject)this).AttachedProperties)
                {
                    yield return prop;
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.AttachedProperties
        {
            get
            {
                foreach (var prop in StoredPropertiesCore)
                {
                    if (!MInfo.AllDeclaredProperties.Contains(prop))
                    {
                        yield return prop;
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        string? IModelObject.Name
        {
            get
            {
                var nameProp = MInfo.NameProperty;
                string? name = null;
                if (nameProp != null) name = ((IModelObject)this).Get(nameProp)?.AsSingle()?.Get()?.ToString();
                return name;
            }
            set
            {
                var nameProp = MInfo.NameProperty;
                if (nameProp != null) ((IModelObject)this).Get(nameProp)?.AsSingle()?.Set(value);
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.NameProperty => MInfo.NameProperty;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.TypeProperty => MInfo.TypeProperty;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        MetaType IModelObject.SymbolType => MInfo.SymbolType;

        public T MGet<T>(ModelProperty property)
        {
            var slot = ((IModelObject)this).Get(property)?.AsSingle<T>();
            if (slot is not null) return slot.Get();
            else return default;
        }

        public IList<T> MGetCollection<T>(ModelProperty property)
        {
            var slot = ((IModelObject)this).Get(property)?.AsCollection<T>();
            if (slot is not null) return slot as IList<T>;
            else return default;
        }

        public void MAdd<T>(ModelProperty property, T value)
        {
            ((IModelObject)this).Get(property)?.Add(value);
        }

        public void MRemove<T>(ModelProperty property, T value)
        {
            ((IModelObject)this).Get(property)?.Remove(value);
        }

        public override string ToString()
        {
            var metaTypeName = MInfo.MetaType;
            var name = ((IModelObject)this).Name;
            var typeProp = MInfo.TypeProperty;
            string? type = null;
            if (typeProp != null) type = ((IModelObject)this).Get(typeProp)?.ToString();
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type)) return $"{name}: {type}";
            else if (!string.IsNullOrWhiteSpace(name)) return $"{name}";
            else if (!string.IsNullOrWhiteSpace(type)) return $":{type}";
            else return $"({metaTypeName})";
        }

        private ModelPropertySlot? GetSlot(ModelProperty property)
        {
            return MInfo.GetSlot(property);
        }

        ModelProperty? IModelObject.GetProperty(string name)
        {
            return MInfo.PublicProperties.FirstOrDefault(p => p.Name == name);
        }

        ImmutableArray<ModelProperty> IModelObject.GetOppositeProperties(ModelProperty property)
        {
            return MInfo.GetOppositeProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetSubsettedProperties(ModelProperty property)
        {
            return MInfo.GetSubsettedProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetSubsettingProperties(ModelProperty property)
        {
            return MInfo.GetSubsettingProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetRedefinedProperties(ModelProperty property)
        {
            return MInfo.GetRedefinedProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetRedefiningProperties(ModelProperty property)
        {
            return MInfo.GetRedefiningProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetHiddenProperties(ModelProperty property)
        {
            return MInfo.GetHiddenProperties(property);
        }

        ImmutableArray<ModelProperty> IModelObject.GetHidingProperties(ModelProperty property)
        {
            return MInfo.GetHidingProperties(property);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract IEnumerable<ModelProperty> StoredPropertiesCore { get; }

        ImmutableArray<ModelOperation> IModelObject.DeclaredOperations => MInfo.DeclaredOperations;

        ImmutableArray<ModelOperation> IModelObject.AllDeclaredOperations => MInfo.AllDeclaredOperations;

        ImmutableArray<ModelOperation> IModelObject.PublicOperations => MInfo.PublicOperations;

        ImmutableArray<ModelOperation> IModelObject.GetOverridenOperations(ModelOperation operation)
        {
            return MInfo.GetOverridenOperations(operation);
        }

        ImmutableArray<ModelOperation> IModelObject.GetOverridingOperations(ModelOperation operation)
        {
            return MInfo.GetOverridingOperations(operation);
        }

        ISlot? IModelObject.Get(ModelProperty property)
        {
            if (MInfo.AllDeclaredProperties.Contains(property)) return ((IModelObject)this).Attach(property); 
            else return null;
        }

        ISlot IModelObject.Attach(ModelProperty property)
        {
            var propertySlot = GetSlot(property);
            if (this.TryGetSlotValueCore(propertySlot, out var slot)) return slot;
            if (propertySlot.IsMap)
            {
                slot = new MapSlot(this, propertySlot);
                SetSlotValueCore(propertySlot, slot);
                return slot;
            }
            if (propertySlot.IsCollection)
            {
                slot = new CollectionSlot(this, propertySlot);
                SetSlotValueCore(propertySlot, slot);
                return slot;
            }
            if (propertySlot.IsSingleItem)
            {
                slot = new SingleSlot(this, propertySlot);
                SetSlotValueCore(propertySlot, slot);
                return slot;
            }
            return null;
        }

        protected abstract void SetSlotValueCore(ModelPropertySlot propertySlot, ISlot? slot);
        protected abstract bool TryGetSlotValueCore(ModelPropertySlot propertySlot, out ISlot? slot);

        public abstract IModelObject Clone();

        IEnumerable<Box> IModelObject.References => (IEnumerable<Box>?)_references ?? ImmutableArray<Box>.Empty;

        void IReferenceableModelObject.AddReference(Box box)
        {
            if (box?.Value != this) throw new ArgumentException("Box must refer to this object.", nameof(box));
            if (_references is null) _references = new HashSet<Box>();
            _references.Add(box);
        }

        void IReferenceableModelObject.RemoveReference(Box box)
        {
            _references?.Remove(box);
        }
    }
}
