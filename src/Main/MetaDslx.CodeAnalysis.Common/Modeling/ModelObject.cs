using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling
{
    public abstract class ModelObject : IModelObject, IReferenceableModelObject
    {
        private static readonly ConditionalWeakTable<ModelObject, ValueInfo> s_valueInfos = new ConditionalWeakTable<ModelObject, ValueInfo>();

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private string? _id;
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

        public Model? MModel
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

        public IModelObject? MParent
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
                            originalParent.MChildren.Remove(this);
                            foreach (var prop in originalParent.MProperties)
                            {
                                if (prop.IsContainment)
                                {
                                    var slot = originalParent.MGetSlot(prop);
                                    slot.Remove(this);
                                }
                            }
                        }
                        _parent = value;
                        if (_parent != null)
                        {
                            _parent.MChildren.Add(this);
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

        public string? MId
        {
            get => _id;
            set
            {
                _model?.CheckReadOnly($"Error changing the id '{_id}' of '{this}' to {value}");
                _id = value;
            }
        }

        public IList<IModelObject> MChildren => _children;

        public IEnumerable<ModelProperty> MProperties
        {
            get
            {
                foreach (var prop in MInfo.PublicProperties)
                {
                    yield return prop;
                }
                foreach (var prop in MAttachedProperties)
                {
                    yield return prop;
                }
            }
        }

        public IEnumerable<ModelProperty> MAttachedProperties
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

        public string? MName
        {
            get
            {
                var nameSlot = ((IModelObject)this).MGetSlot(MInfo.NameProperty)?.AsSingle();
                string? name = null;
                if (nameSlot != null) name = nameSlot.Value?.ToString();
                return name;
            }
            set
            {
                var nameSlot = ((IModelObject)this).MGetSlot(MInfo.NameProperty)?.AsSingle();
                if (nameSlot != null) nameSlot.Value = value;
            }
        }

        public T MGet<T>(ModelProperty property)
        {
            var slot = ((IModelObject)this).MGetSlot(property)?.AsSingle<T>();
            if (slot is not null) return slot.Value;
            else return default;
        }

        public void MSet<T>(ModelProperty property, T value)
        {
            var slot = ((IModelObject)this).MGetSlot(property)?.AsSingle<T>();
            if (slot is not null) slot.Value = value;
        }

        public ICollectionSlot<T> MGetCollection<T>(ModelProperty property)
        {
            return ((IModelObject)this).MGetSlot(property)?.AsCollection<T>();
        }

        public override string ToString()
        {
            var metaTypeName = MInfo.MetaType;
            var name = this.MName;
            var typeProp = MInfo.TypeProperty;
            string? type = null;
            if (typeProp != null) type = ((IModelObject)this).MGetSlot(typeProp)?.ToString();
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type)) return $"{name}: {type}";
            else if (!string.IsNullOrWhiteSpace(name)) return $"{name}";
            else if (!string.IsNullOrWhiteSpace(type)) return $":{type}";
            else return $"({metaTypeName})";
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract IEnumerable<ModelProperty> StoredPropertiesCore { get; }

        ISlot? IModelObject.MGetSlot(string propertyName)
        {
            var property = MInfo.GetProperty(propertyName);
            if (property is null) return null;
            var propertySlot = MInfo.GetSlot(property);
            return MGetSlot(propertySlot);
        }

        ISlot? IModelObject.MGetSlot(ModelProperty? property)
        {
            if (property is null) return null;
            var propertySlot = MInfo.GetSlot(property);
            return MGetSlot(propertySlot);
        }

        ISlot IModelObject.MAttachSlot(ModelProperty property)
        {
            if (property is null) throw new ArgumentNullException(nameof(property));
            var propertySlot = MInfo.GetSlot(property);
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

        public IModelObject MClone()
        {
            var map = new Dictionary<IModelObject, IModelObject>();
            var copy = MakeCopyMap(this, map);
            if (copy is not null) CopyProperties(this, map);
            return copy;
        }

        private IModelObject? MakeCopyMap(IModelObject parent, Dictionary<IModelObject, IModelObject> copyMap)
        {
            var copy = parent?.MInfo?.Create(_model);
            copyMap.Add(parent, copy);
            foreach (var child in parent.MChildren)
            {
                MakeCopyMap(child, copyMap);
            }
            return copy;
        }

        private void CopyProperties(IModelObject parent, Dictionary<IModelObject, IModelObject> copyMap)
        {
            if (copyMap.TryGetValue(parent, out var copy))
            {
                foreach (var prop in parent.MInfo.AllDeclaredProperties)
                {
                    var opposites = parent.MInfo.GetOppositeProperties(prop);
                    var hasOpposites = !prop.IsContainment && opposites.Length > 0;
                    var oldSlot = parent.MGetSlot(prop);
                    if (oldSlot.IsReadOnly) continue;
                    var newSlot = copy.MGetSlot(prop);
                    foreach (var oldValue in oldSlot.Values)
                    {
                        if (oldValue is null)
                        {
                            if (!oldSlot.IsDefault) newSlot.Add(null);
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
            foreach (var child in parent.MChildren)
            {
                CopyProperties(child, copyMap);
            }
        }

        public IEnumerable<Box> MReferences => (IEnumerable<Box>?)_references ?? ImmutableArray<Box>.Empty;

        public Location? MLocation
        {
            get => TryGetValueInfo()?.Location ?? Location.None;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Location = value;
                else if (value is not null && value != Location.None && value != SourceLocation.None) GetValueInfo().Location = value;
            }
        }

        public SourceLocation? MSourceLocation
        {
            get => TryGetValueInfo()?.SourceLocation ?? SourceLocation.None;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.SourceLocation = value;
                else if (value is not null && value != SourceLocation.None) GetValueInfo().SourceLocation = value;
            }
        }

        public Symbol? MSymbol
        {
            get => TryGetValueInfo()?.Symbol;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Symbol = value;
                else if (value is not null) GetValueInfo().Symbol = value;
            }
        }

        public SyntaxNodeOrToken MSyntax
        {
            get => TryGetValueInfo()?.Syntax ?? default;
            set
            {
                var info = TryGetValueInfo();
                if (info is not null) info.Syntax = value;
                else if (!value.IsNull) GetValueInfo().Syntax = value;
            }
        }

        public Microsoft.CodeAnalysis.ISymbol? MCSharpSymbol
        {
            get => TryGetValueInfo()?.CSharpSymbol;
        }

        public object? MTag
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
            return s_valueInfos.GetValue(this, mobj => MModel.CreateValueInfo(mobj));
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

        public void MReplaceObject(IModelObject oldObject, IModelObject? newObject, CancellationToken cancellationToken)
        {
            var references = oldObject.MReferences.ToImmutableArray();
            var mobjs = this.GetAllContainedObjects<IModelObject>(includeSelf: true, cancellationToken: cancellationToken);
            foreach (var reference in references)
            {
                if (mobjs.Contains(reference.Owner))
                {
                    reference.Slot.Replace(oldObject, newObject);
                }
            }
        }
    }
}
