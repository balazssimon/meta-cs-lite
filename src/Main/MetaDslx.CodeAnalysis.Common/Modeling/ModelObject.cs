using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class ModelObject : IModelObject
    {
        private static readonly ModelProperty MParentProperty = new ModelProperty(typeof(ModelObject), "MParent", ModelPropertyKind.SingleValue, typeof(IModelObject), false);
        private static readonly ModelProperty MChildrenProperty = new ModelProperty(typeof(ModelObject), "MChildren", ModelPropertyKind.List, typeof(IModelObject), true);

        static ModelObject()
        {
            MParentProperty.SetOppositeProperties(ImmutableArray.Create(MChildrenProperty));
            MChildrenProperty.SetOppositeProperties(ImmutableArray.Create(MParentProperty));
        }

        private IModel? _model;
        private IModelObject? _parent;
        private ModelObjectList<IModelObject> _children;
        private Dictionary<ModelProperty, object?> _properties;

        public ModelObject()
        {
            _properties = new Dictionary<ModelProperty, object?>();
            _children = new ModelObjectList<IModelObject>(this, MChildrenProperty);
        }

        protected abstract ImmutableArray<ModelProperty> MProperties { get; }

        IModelObject? IModelObject.MParent => _parent;

        IList<IModelObject> IModelObject.MChildren => _children;

        IModel? IModelObject.MModel => _model;

        ImmutableArray<ModelProperty> IModelObject.MProperties => this.MProperties;

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

        object? IModelObject.MGet(ModelProperty property)
        {
            if (property.IsCollection) throw new ArgumentException("Property must not be a collection.", nameof(property));
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
            if (property.IsCollection) throw new ArgumentException("Property must not be a collection.", nameof(property));
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
            if (value != null && !property.Type.IsAssignableFrom(value.GetType())) throw new ArgumentException($"The type '{value.GetType()}' of '{value}' is not assignable to the type '{property.Type}' of '{property}'.");
            _properties[property] = value;
        }
    }
}
