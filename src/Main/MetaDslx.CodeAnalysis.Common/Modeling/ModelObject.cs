using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class ModelObject : IModelObject, IReferenceableModelObject
    {
        private static readonly ConditionalWeakTable<ModelObject, ValueInfo> s_valueInfos = new ConditionalWeakTable<ModelObject, ValueInfo>();

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

        public abstract ModelClassInfo MInfo { get; }

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
                            originalModel.DetachObject(this);
                        }
                        _model = value;
                        if (_model != null)
                        {
                            _model.AttachObject(this);
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
                var nameSlot = ((IModelObject)this).GetSlot(MInfo.NameProperty)?.AsSingle();
                string? name = null;
                if (nameSlot != null) name = nameSlot.Value?.ToString();
                return name;
            }
            set
            {
                var nameSlot = ((IModelObject)this).GetSlot(MInfo.NameProperty)?.AsSingle();
                if (nameSlot != null) nameSlot.Value = value;
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
            var slot = ((IModelObject)this).GetSlot(property)?.AsSingle<T>();
            if (slot is not null) return slot.Value;
            else return default;
        }

        public void MSet<T>(ModelProperty property, T value)
        {
            var slot = ((IModelObject)this).GetSlot(property)?.AsSingle<T>();
            if (slot is not null) slot.Value = value;
        }

        public ICollectionSlot<T> MGetCollection<T>(ModelProperty property)
        {
            return ((IModelObject)this).GetSlot(property)?.AsCollection<T>();
        }

        public override string ToString()
        {
            var metaTypeName = MInfo.MetaType;
            var name = ((IModelObject)this).Name;
            var typeProp = MInfo.TypeProperty;
            string? type = null;
            if (typeProp != null) type = ((IModelObject)this).GetSlot(typeProp)?.ToString();
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

        ISlot? IModelObject.GetSlot(string propertyName)
        {
            var property = ((IModelObject)this).GetProperty(propertyName);
            if (property is null) return null;
            var propertySlot = GetSlot(property);
            return MGetSlot(propertySlot);
        }

        ISlot? IModelObject.GetSlot(ModelProperty? property)
        {
            if (property is null) return null;
            var propertySlot = GetSlot(property);
            return MGetSlot(propertySlot);
        }

        ISlot IModelObject.AttachSlot(ModelProperty property)
        {
            if (property is null) throw new ArgumentNullException(nameof(property));
            var propertySlot = GetSlot(property);
            return MAttachSlot(propertySlot);
        }

        protected abstract ISlot? MGetSlot(ModelPropertySlot propertySlot);
        protected abstract ISlot? MAttachSlot(ModelPropertySlot propertySlot);

        protected virtual ISlot? MCreateSlot(ModelPropertySlot propertySlot)
        {
            /*if (propertySlot.IsMap)
            {
                slot = new MapSlot(this, propertySlot);
                SetSlotValueCore(propertySlot, slot);
                return slot;
            }*/
            if (propertySlot.IsCollection)
            {
                return new CollectionSlot(this, propertySlot);
            }
            if (propertySlot.IsSingle)
            {
                return new SingleSlot(this, propertySlot);
            }
            return null;
        }

        public IModelObject? Clone()
        {
            var map = new Dictionary<IModelObject, IModelObject>();
            var copy = MakeCopyMap(this, map);
            if (copy is not null) CopyProperties(this, map);
            return copy;
        }

        private IModelObject? MakeCopyMap(IModelObject parent, Dictionary<IModelObject, IModelObject> copyMap)
        {
            var copy = parent?.Info?.Create(_model);
            copyMap.Add(parent, copy);
            foreach (var child in parent.Children)
            {
                MakeCopyMap(child, copyMap);
            }
            return copy;
        }

        private void CopyProperties(IModelObject parent, Dictionary<IModelObject, IModelObject> copyMap)
        {
            if (copyMap.TryGetValue(parent, out var copy))
            {
                foreach (var prop in parent.Info.AllDeclaredProperties)
                {
                    var opposites = parent.Info.GetOppositeProperties(prop);
                    var hasOpposites = !prop.IsContainment && opposites.Length > 0;
                    var oldSlot = parent.GetSlot(prop);
                    var newSlot = copy.GetSlot(prop);
                    foreach (var oldValue in oldSlot.Values)
                    {
                        if (oldValue is null)
                        {
                            newSlot.Add(null);
                        }
                        else
                        {
                            var newIsCopy = false;
                            var newValue = oldValue;
                            if (oldValue is IModelObject oldMObj && copyMap.TryGetValue(oldMObj, out var newMObj))
                            {
                                newValue = newMObj;
                                newIsCopy = true;
                            }
                            if (newValue is not null && (!hasOpposites || newIsCopy))
                            {
                                newSlot.Add(newValue);
                            }
                        }
                    }
                }
            }
            foreach (var child in parent.Children)
            {
                CopyProperties(child, copyMap);
            }
        }

        IEnumerable<Box> IModelObject.References => (IEnumerable<Box>?)_references ?? ImmutableArray<Box>.Empty;
        public Location? Location
        {
            get => TryGetValueInfo()?.Location ?? Location.None;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Location = value;
                else if (value is not null && value != Location.None && value != SourceLocation.None) GetValueInfo().Location = value;
            }
        }

        public SourceLocation? SourceLocation
        {
            get => TryGetValueInfo()?.SourceLocation ?? SourceLocation.None;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.SourceLocation = value;
                else if (value is not null && value != SourceLocation.None) GetValueInfo().SourceLocation = value;
            }
        }

        public Symbol? Symbol
        {
            get => TryGetValueInfo()?.Symbol;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Symbol = value;
                else if (value is not null) GetValueInfo().Symbol = value;
            }
        }

        public SyntaxNodeOrToken Syntax
        {
            get => TryGetValueInfo()?.Syntax ?? default;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Syntax = value;
                else if (!value.IsNull) GetValueInfo().Syntax = value;
            }
        }

        public Microsoft.CodeAnalysis.ISymbol? CSharpSymbol
        {
            get => TryGetValueInfo()?.CSharpSymbol;
        }

        public object? Tag
        {
            get => TryGetValueInfo()?.Tag;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Tag = value;
                else if (value is not null) GetValueInfo().Tag = value;
            }
        }

        protected virtual ValueInfo? TryGetValueInfo()
        {
            if (s_valueInfos.TryGetValue(this, out var valueInfo)) return valueInfo;
            else return null;
        }

        protected virtual ValueInfo GetValueInfo()
        {
            return s_valueInfos.GetValue(this, mobj => ((IModelObject)this).Model.CreateValueInfo(mobj));
        }

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
