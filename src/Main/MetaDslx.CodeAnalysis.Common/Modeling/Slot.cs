using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
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
        public bool IsReadOnly => _property.IsReadOnly;
        public bool IsNullable => _property.IsNullable;

        public abstract SlotKind Kind { get; }
        public abstract bool IsDefault { get; }
        public abstract bool Contains(object? item);
        public abstract void Clear();
        public abstract IEnumerable<Box> Boxes { get; }

        protected void CheckReadOnly(string message)
        {
            Model.CheckReadOnly(message);
            Property.ThrowModelException(mp => mp.IsReadOnly, mp => $"{message}: the property '{mp.QualifiedName}' in '{Owner}' is read only.");
        }

        protected void CheckValueType(object? value, Func<ModelProperty, string> message)
        {
            if (value is not null)
            {
                var valueType = value is IModelObject mobj ? mobj.MetaType.AsType() : value.GetType();
                Property.ThrowModelException(mp => valueType is null || !mp.Type.IsAssignableFrom(valueType), mp => $"{message(mp)}: the value type '{valueType}' is not assignable to the property type '{mp.Type}'.");
            }
            else if (Model.ValidationOptions.ValidateNullable)
            {
                Property.ThrowModelException(mp => !mp.IsNullable, mp => $"{message(mp)}: value cannot be null.");
            }
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
                            var oppositeSlot = mobj.GetSlot(oppositeProperty) as ISlotCore;
                            oppositeSlot?.AddCore(Owner, box);
                        }
                    }
                    foreach (var subsettedProperty in Owner.GetSubsettedProperties(slotProperty))
                    {
                        var subsettedSlot = Owner.GetSlot(subsettedProperty) as ISlotCore;
                        subsettedSlot?.AddCore(mobj, oppositeBox);
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
                            var oppositeSlot = mobj.GetSlot(oppositeProperty) as ISlotCore;
                            oppositeSlot?.RemoveCore(Owner, box);
                        }
                    }
                    foreach (var subsettingProperty in Owner.GetSubsettingProperties(slotProperty))
                    {
                        var subsettingSlot = Owner.GetSlot(subsettingProperty) as ISlotCore;
                        subsettingSlot?.RemoveCore(mobj, oppositeBox);
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
