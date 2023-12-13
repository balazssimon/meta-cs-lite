using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class SingleSlot : Slot, ISingleSlot, ISlotCore
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Box _box;

        public SingleSlot(ModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
            _box = new Box(this);
        }

        public override SlotKind Kind => SlotKind.Single;
        public override bool IsDefault => _box.IsDefault;

        public Box Box => _box;

        public object? Value
        {
            get => _box.Value;
            set => AddCore(value, null);
        }

        public override IEnumerable<Box> Boxes
        {
            get
            {
                yield return _box;
            }
        }

        public override void Clear()
        {
            RemoveCore(_box.Value, null);
        }

        public override bool Contains(object? item)
        {
            return _box.HasValue(item);
        }

        public Box? Init(object? value)
        {
            Model.CheckReadOnly($"Error initializing {this} with '{value}'");
            return AddCore(value, null);
        }

        void ISlotCore.AddCore(object? item, Box? oppositeBox)
        {
            AddCore(item, oppositeBox);
        }

        void ISlotCore.RemoveCore(object? item, Box? oppositeBox)
        {
            RemoveCore(item, oppositeBox);
        }

        private Box? AddCore(object? item, Box? oppositeBox)
        {
            if (oppositeBox is null) CheckReadOnly(GetAssignMessage(Property.SlotProperty, item));
            CheckValueType(item, mp => GetAssignMessage(mp, item));
            var oldValue = _box.Value;
            if (!_box.HasValue(item))
            {
                try
                {
                    _box.Clear();
                    ValueRemoved(_box, oldValue, oppositeBox);
                    _box.Value = item;
                    ValueAdded(_box, oppositeBox);
                    return _box;
                }
                catch (Exception ex)
                {
                    _box.Value = oldValue;
                    if (Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetAssignMessage(Property.SlotProperty, item)}", ex);
                    else throw;
                }
            }
            return null;
        }

        private Box? RemoveCore(object? item, Box? oppositeBox)
        {
            var oldValue = _box.Value;
            if (_box.HasValue(item))
            {
                if (oppositeBox is null) CheckReadOnly(GetRemoveMessage(Property.SlotProperty, item));
                try
                {
                    _box.Clear();
                    ValueRemoved(_box, oldValue, oppositeBox);
                    return _box;
                }
                catch (Exception ex)
                {
                    _box.Value = oldValue;
                    if (Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetRemoveMessage(Property.SlotProperty, item)}", ex);
                    else throw;
                }
            }
            return null;
        }

        protected string GetAssignMessage(ModelProperty property, object? value)
        {
            return $"Error assigning '{value}' to '{property.QualifiedName}' in '{Owner}'";
        }

        protected string GetRemoveMessage(ModelProperty property, object? value)
        {
            return $"Error removing '{value}' from '{property.QualifiedName}' in '{Owner}'";
        }
    }

    internal class SingleSlot<T> : ISingleSlot<T>, ISlotCore
    {
        private readonly ISingleSlot _wrappedSlot;

        public SingleSlot(ISingleSlot wrappedSlot)
        {
            _wrappedSlot = wrappedSlot;
        }

        public IModelObject Owner => _wrappedSlot.Owner;

        public ModelPropertySlot Property => _wrappedSlot.Property;

        public bool IsReadOnly => _wrappedSlot.IsReadOnly;

        public bool IsNullable => _wrappedSlot.IsNullable;

        public SlotKind Kind => SlotKind.Single;

        public bool IsDefault => _wrappedSlot.IsDefault;

        void ISlotCore.AddCore(object? item, Box? oppositeBox)
        {
            (_wrappedSlot as ISlotCore)?.AddCore(item, oppositeBox);
        }

        void ISlotCore.RemoveCore(object? item, Box? oppositeBox)
        {
            (_wrappedSlot as ISlotCore)?.RemoveCore(item, oppositeBox);
        }

        void ISlot.Clear()
        {
            _wrappedSlot.Clear();
        }

        bool ISlot.Contains(object? item)
        {
            return _wrappedSlot.Contains(item);
        }

        IEnumerable<Box> ISlot.Boxes => _wrappedSlot.Boxes;

        T ISingleSlot<T>.Value
        {
            get
            {
                if (_wrappedSlot.Value is null) return default;
                else return (T)_wrappedSlot.Value;
            }
            set => _wrappedSlot.Value = value;
        }

        object? ISingleSlot.Value
        {
            get => _wrappedSlot.Value;
            set => _wrappedSlot.Value = value;
        }

        Box ISingleSlot.Box => _wrappedSlot.Box;

        Box ISingleSlot.Init(object? value)
        {
            return _wrappedSlot.Init(value);
        }

    }
}
