using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Xml.Linq;

namespace MetaDslx.Modeling
{
    public abstract class Slot : ISlot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly IModelObject _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private readonly ModelPropertySlot _property;

        public Slot(IModelObject owner, ModelPropertySlot property)
        {
            _owner = owner;
            _property = property;
        }

        public Model Model => _owner.Model;
        public IModelObject Owner => _owner;
        public ModelPropertySlot Property => _property;
        public bool IsSingle => _property.IsSingleItem;
        public bool IsCollection => _property.IsCollection;
        public bool IsMap => _property.IsMap;
        public bool IsReadOnly => _property.IsReadOnly;
        public bool IsNullable => _property.IsNullable;

        public ICollectionSlot? AsCollection()
        {
            return this as ICollectionSlot;
        }

        public ICollectionSlot<T>? AsCollection<T>()
        {
            throw new NotImplementedException();
        }

        public IMapSlot? AsMap()
        {
            return this as IMapSlot;
        }

        public IMapSlot<TKey, TValue>? AsMap<TKey, TValue>()
        {
            throw new NotImplementedException();
        }

        public ISingleSlot? AsSingle()
        {
            return this as ISingleSlot;
        }

        public ISingleSlot<T>? AsSingle<T>()
        {
            var single = this.AsSingle();
            if (single is null) return null;
            else return new SingleSlot<T>(single);
        }


        protected Box CreateBox()
        {
            return new Box(this);
        }

        protected Box CreateBox(object? value)
        {
            var result = new Box(this);
            result.Value = value;
            return result;
        }

        public abstract bool IsDefault { get; }
        public abstract bool Contains(object? item);
        public abstract Box Add(object? item, Box? oppositeBox = null);
        public abstract Box Remove(object? item, Box? oppositeBox = null);

        protected void CheckReadOnly(string message)
        {
            Model.CheckReadOnly(message);
            Property.ThrowModelException(mp => mp.IsReadOnly, mp => message is null ? $"The property '{mp.QualifiedName}' in '{Owner}' is read only." : $"{message}: the property '{mp.QualifiedName}' in '{Owner}' is read only.");
        }

        protected void CheckValueType(object? value)
        {
            if (value is not null)
            {
                var valueType = value is IModelObject mobj ? mobj.MetaType.AsType() : value.GetType();
                Property.ThrowModelException(mp => valueType is null || !mp.Type.IsAssignableFrom(valueType), mp => $"{GetAddMessage(mp, value)}: the value type '{valueType}' is not assignable to the property type '{mp.Type}'.");
            }
            else if (Model.ValidationOptions.ValidateNullable)
            {
                Property.ThrowModelException(mp => !mp.IsNullable, mp => $"{GetAddMessage(mp, value)}: value cannot be null.");
            }
        }

        protected string GetAddMessage(ModelProperty property, object? value)
        {
            if (property.IsSingleItem) return $"Error assigning '{value}' to '{property.QualifiedName}' in '{Owner}'";
            else return $"Error adding '{value}' to '{property.QualifiedName}' in '{Owner}'";
        }

        protected string GetRemoveMessage(ModelProperty property, object? value)
        {
            if (property.IsSingleItem) return $"Error assigning '{value}' to '{property.QualifiedName}' in '{Owner}'";
            else return $"Error removing '{value}' from '{property.QualifiedName}' in '{Owner}'";
        }

        protected void ValueAdded(Box box, Box? oppositeBox)
        {
            if (box.Value is null || Property.IsUntracked) return;
            if (Property.IsModelObjectType && box.Value is IModelObject mobj)
            {
                (mobj as IReferenceableModelObject)?.AddReference(box);
                if (Property.IsContainment)
                {
                    mobj.Parent = Owner;
                }
                foreach (var slotProperty in Property.SlotProperties)
                {
                    if (oppositeBox is null)
                    {
                        foreach (var oppositeProperty in Owner.GetOppositeProperties(slotProperty))
                        {
                            var oppositeSlot = mobj.Get(oppositeProperty);
                            oppositeSlot?.Add(Owner, box);
                        }
                    }
                    foreach (var subsettedProperty in Owner.GetSubsettedProperties(slotProperty))
                    {
                        var subsettedSlot = Owner.Get(subsettedProperty);
                        subsettedSlot?.Add(mobj, oppositeBox);
                    }
                }
            }
        }

        protected void ValueRemoved(Box box, object? oldValue, Box? oppositeBox)
        {
            if (oldValue is null || Property.IsUntracked) return;
            if (Property.IsModelObjectType && oldValue is IModelObject mobj)
            {
                (mobj as IReferenceableModelObject)?.RemoveReference(box);
                if (Property.IsContainment && !this.Contains(mobj))
                {
                    mobj.Parent = null;
                }
                foreach (var slotProperty in Property.SlotProperties)
                {
                    if (oppositeBox is null)
                    {
                        foreach (var oppositeProperty in Owner.GetOppositeProperties(slotProperty))
                        {
                            var oppositeSlot = mobj.Get(oppositeProperty);
                            oppositeSlot?.Remove(Owner, box);
                        }
                    }
                    foreach (var subsettingProperty in Owner.GetSubsettingProperties(slotProperty))
                    {
                        var subsettingSlot = Owner.Get(subsettingProperty);
                        subsettingSlot?.Remove(mobj, oppositeBox);
                    }
                }
            }
        }

        public override string ToString()
        {
            return $"'{Property.QualifiedName}' in '{Owner}'";
        }

    }
}
