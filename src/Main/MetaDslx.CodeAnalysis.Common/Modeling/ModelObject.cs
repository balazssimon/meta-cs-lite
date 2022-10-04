using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.Modeling
{
    public abstract class ModelObject : IModelObject
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly ModelProperty MParentProperty = new ModelProperty(typeof(ModelObject), "MParent", typeof(IModelObject), ModelPropertyFlags.NullableType | ModelPropertyFlags.ReferenceType | ModelPropertyFlags.MetaClassType);
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private static readonly ModelProperty MChildrenProperty = new ModelProperty(typeof(ModelObject), "MChildren", typeof(IModelObject), ModelPropertyFlags.ReferenceType | ModelPropertyFlags.MetaClassType | ModelPropertyFlags.Collection | ModelPropertyFlags.Containment);

        static ModelObject()
        {
            MParentProperty.SetOppositeProperties(ImmutableArray.Create(MChildrenProperty));
            MChildrenProperty.SetOppositeProperties(ImmutableArray.Create(MParentProperty));
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IModel? _model;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private IModelObject? _parent;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ModelObjectList<IModelObject> _children;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Dictionary<ModelProperty, object?> _properties;

        public ModelObject()
        {
            _properties = new Dictionary<ModelProperty, object?>();
            _children = new ModelObjectList<IModelObject>(this, MChildrenProperty);
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ImmutableArray<ModelProperty> MDeclaredProperties { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ImmutableArray<ModelProperty> MAllDeclaredProperties { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ImmutableArray<ModelProperty> MPublicProperties { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ModelProperty? MNameProperty { get; }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        protected abstract ModelProperty? MTypeProperty { get; }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IModelObject? IModelObject.MParent => _parent;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IList<IModelObject> IModelObject.MChildren => _children;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IModel? IModelObject.MModel => _model;

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.MDeclaredProperties => this.MDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.MAllDeclaredProperties => this.MAllDeclaredProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ImmutableArray<ModelProperty> IModelObject.MPublicProperties => this.MPublicProperties;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.MProperties
        {
            get
            {
                foreach (var prop in MPublicProperties)
                {
                    yield return prop;
                }
                foreach (var prop in ((IModelObject)this).MAttachedProperties)
                {
                    yield return prop;
                }
            }
        }
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        IEnumerable<ModelProperty> IModelObject.MAttachedProperties
        {
            get
            {
                foreach (var prop in _properties.Keys)
                {
                    if (!MAllDeclaredProperties.Contains(prop))
                    {
                        yield return prop;
                    }
                }
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.MNameProperty => MNameProperty;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        ModelProperty? IModelObject.MTypeProperty => MTypeProperty;

        void IModelObject.MAdd(ModelProperty property, object? item)
        {
            if (!property.IsCollection) throw new ArgumentException($"Property '{property.Name}' must be a collection.", nameof(property));
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (!property.Type.IsAssignableFrom(item.GetType())) throw new ArgumentException($"The type '{item.GetType()}' of '{item}' is not assignable to the type '{property.Type}' of '{property}'.");
            if (!_properties.TryGetValue(property, out var collection))
            {
                throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor.");
            }
            if (collection is IModelCollection modelCollection)
            {
                modelCollection.MAdd(item);
            }
            else
            {
                throw new InvalidOperationException($"The value of the collection property '{property.Name}' must be initialized with an IModelCollection implementation.");
            }
        }

        public T MGet<T>(ModelProperty property)
        {
            var value = ((IModelObject)this).MGet(property);
            if (value == null) return default(T);
            else return (T)value;
        }

        public void MSet<T>(ModelProperty property, T value)
        {
            ((IModelObject)this).MSet(property, value);
        }

        object? IModelObject.MGet(ModelProperty property)
        {
            if (_properties.TryGetValue(property, out var value)) return value;
            else return null;
        }

        void IModelObject.MRemove(ModelProperty property, object? item)
        {
            if (!property.IsCollection) throw new ArgumentException($"Property '{property.Name}' must be a collection.", nameof(property));
            if (item == null) throw new ArgumentNullException(nameof(item));
            if (!property.Type.IsAssignableFrom(item.GetType())) throw new ArgumentException($"The type '{item.GetType()}' of '{item}' is not assignable to the type '{property.Type}' of '{property}'.");
            if (!_properties.TryGetValue(property, out var collection))
            {
                throw new InvalidOperationException($"Collection property '{property.Name}' must be initialized in the constructor.");
            }
            if (collection is IModelCollection modelCollection)
            {
                modelCollection.MRemove(item);
            }
            else
            {
                throw new InvalidOperationException($"The value of the collection property '{property.Name}' must be initialized with an IModelCollection implementation.");
            }
        }

        void IModelObject.MSet(ModelProperty property, object? value)
        {
            if (value != null && !property.Type.IsAssignableFrom(value.GetType())) throw new ArgumentException($"The type '{value.GetType()}' of '{value}' is not assignable to the type '{property.Type}' of '{property}'.");
            if (property.IsReadonly) throw new ArgumentException($"Property '{property.Name}' is readonly, its value cannot be set.", nameof(property));
            if (property.IsCollection) throw new ArgumentException($"Property '{property.Name}' is a collection, its value cannot be set.", nameof(property));
            if (_properties.TryGetValue(property, out var oldValue))
            {
                if (oldValue == null && value == null) return;
                if (oldValue != null && oldValue.Equals(value)) return;
                _properties[property] = null;
                if (oldValue != null) ValueRemoved(property, oldValue);
                _properties[property] = value;
                if (value != null) ValueAdded(property, value);
            }
            else
            {
                _properties[property] = value;
                if (value != null) ValueAdded(property, value);
            }
        }

        internal void ValueAdded(ModelProperty property, object? value)
        {

        }

        internal void ValueRemoved(ModelProperty property, object? value)
        {

        }

        void IModelObject.MSetModel(IModel? model)
        {
            if (_model != null && model != null) throw new ArgumentException(nameof(model), $"Model object '{this}' is already contained by the model '{_model}.'");
            _model = model;
        }

        void IModelObject.MInit(ModelProperty property, object? value)
        {
            //if (value != null && !property.Type.IsAssignableFrom(value.GetType())) throw new ArgumentException($"The type '{value.GetType()}' of '{value}' is not assignable to the type '{property.Type}' of '{property}'.");
            _properties[property] = value;
        }

        public override string ToString()
        {
            var metaTypeName = this.GetType().Name;
            if (metaTypeName.EndsWith("Impl")) metaTypeName = metaTypeName.Substring(0, metaTypeName.Length - 4);
            var nameProp = MNameProperty;
            string? name = null;
            if (nameProp != null) name = ((IModelObject)this).MGet(nameProp)?.ToString();
            var typeProp = MTypeProperty;
            string? type = null;
            if (typeProp != null) type = ((IModelObject)this).MGet(typeProp)?.ToString();
            if (!string.IsNullOrWhiteSpace(name) && !string.IsNullOrWhiteSpace(type)) return $"{name}: {type}";
            else if (!string.IsNullOrWhiteSpace(name)) return $"{name}";
            else if (!string.IsNullOrWhiteSpace(type)) return $":{type}";
            else return $"({metaTypeName})";
        }
    }
}
