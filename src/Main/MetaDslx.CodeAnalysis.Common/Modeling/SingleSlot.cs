using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Modeling
{
    public sealed class SingleSlot<T> : Slot<T>, ISingleSlot<T>, ISlot
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

        public T Value
        {
            get => (T)_box.Value;
            set => AddCore(value, null);
        }

        public override IEnumerable<T> Values
        {
            get
            {
                yield return (T)_box.Value;
            }
        }

        public override IEnumerable<Box> Boxes
        {
            get
            {
                yield return _box;
            }
        }

        IEnumerable<object?> ISlot.Values => this.Values.Select(v => v as object);

        public override void Clear()
        {
            RemoveCore((T)_box.Value, null);
        }

        public override bool Contains(T item)
        {
            return _box.HasValue(item);
        }

        public Box? Init(T value)
        {
            Model.CheckReadOnly($"Error initializing {this} with '{value}'");
            return AddCore(value, null);
        }

        protected override Box? AddCore(T item, Box? oppositeBox)
        {
            if (oppositeBox is null) CheckReadOnly(GetAssignMessage(Property.SlotProperty, item));
            CheckValueType(item, mp => GetAssignMessage(mp, item));
            var oldValue = (T)_box.Value;
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

        protected override Box? RemoveCore(T item, Box? oppositeBox)
        {
            var oldValue = (T)_box.Value;
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

        protected override Box? ReplaceCore(T oldItem, T newItem)
        {
            CheckReadOnly(GetAssignMessage(Property.SlotProperty, newItem));
            CheckValueType(newItem, mp => GetAssignMessage(mp, newItem));
            var oldValue = (T)_box.Value;
            if (_box.HasValue(oldItem) && !_box.HasValue(newItem))
            {
                try
                {
                    _box.Clear();
                    ValueRemoved(_box, oldValue, null);
                    _box.Value = newItem;
                    ValueAdded(_box, null);
                    return _box;
                }
                catch (Exception ex)
                {
                    _box.Value = oldValue;
                    if (Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetAssignMessage(Property.SlotProperty, newItem)}", ex);
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

        public override string ToString()
        {
            return Value?.ToString();
        }

        bool ISlot.Contains(object? item)
        {
            return this.Contains((T)item);
        }

        Box? ISlot.Add(object? item)
        {
            return ((ISlot<T>)this).Add((T)item);
        }

        Box? ISlot.Remove(object? item)
        {
            return ((ISlot<T>)this).Remove((T)item);
        }

        Box? ISlot.Replace(object? oldItem, object? newItem)
        {
            return ((ISlot<T>)this).Replace((T)oldItem, (T)newItem);
        }
    }

    internal class SingleSlot : Slot, ISingleSlot
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

        public override IEnumerable<object?> Values
        {
            get
            {
                yield return _box.Value;
            }
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

        protected override Box? AddCore(object? item, Box? oppositeBox)
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

        protected override Box? RemoveCore(object? item, Box? oppositeBox)
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

        protected override Box? ReplaceCore(object? oldItem, object? newItem)
        {
            CheckReadOnly(GetAssignMessage(Property.SlotProperty, newItem));
            CheckValueType(newItem, mp => GetAssignMessage(mp, newItem));
            var oldValue = _box.Value;
            if (_box.HasValue(oldItem) && !_box.HasValue(newItem))
            {
                try
                {
                    _box.Clear();
                    ValueRemoved(_box, oldValue, null);
                    _box.Value = newItem;
                    ValueAdded(_box, null);
                    return _box;
                }
                catch (Exception ex)
                {
                    _box.Value = oldValue;
                    if (Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetAssignMessage(Property.SlotProperty, newItem)}", ex);
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

        public override string ToString()
        {
            return Value?.ToString();
        }
    }

    internal class SingleSlotWrapper<T> : ISingleSlot<T>
    {
        private readonly ISingleSlot _wrappedSlot;

        public SingleSlotWrapper(ISingleSlot wrappedSlot)
        {
            _wrappedSlot = wrappedSlot;
        }

        public IModelObject Owner => _wrappedSlot.Owner;

        public ModelPropertySlot Property => _wrappedSlot.Property;

        public bool IsReadOnly => _wrappedSlot.IsReadOnly;

        public bool IsNullable => _wrappedSlot.IsNullable;

        public SlotKind Kind => _wrappedSlot.Kind;

        public bool IsDefault => _wrappedSlot.IsDefault;

        void ISlot<T>.Clear()
        {
            _wrappedSlot.Clear();
        }

        bool ISlot<T>.Contains(T item)
        {
            return _wrappedSlot.Contains(item);
        }

        IEnumerable<Box> ISlot<T>.Boxes => _wrappedSlot.Boxes;

        IEnumerable<T> ISlot<T>.Values => _wrappedSlot.Values.Cast<T>();

        T ISingleSlot<T>.Value
        {
            get
            {
                if (_wrappedSlot.Value is null) return default;
                else return (T)_wrappedSlot.Value;
            }
            set => _wrappedSlot.Value = value;
        }

        Box ISingleSlot<T>.Box => _wrappedSlot.Box;

        Box ISingleSlot<T>.Init(T value)
        {
            return _wrappedSlot.Init(value);
        }

        Box? ISlot<T>.Add(T item)
        {
            return _wrappedSlot.Add(item);
        }

        Box? ISlot<T>.Remove(T item)
        {
            return _wrappedSlot.Remove(item);
        }

        Box? ISlot<T>.Replace(T oldItem, T newItem)
        {
            return _wrappedSlot.Replace(oldItem, newItem);
        }

        ISingleSlot? ISlot<T>.AsSingle()
        {
            return _wrappedSlot.AsSingle();
        }

        ISingleSlot<TAs>? ISlot<T>.AsSingle<TAs>()
        {
            return _wrappedSlot.AsSingle<TAs>();
        }

        ICollectionSlot? ISlot<T>.AsCollection()
        {
            return _wrappedSlot.AsCollection();
        }

        ICollectionSlot<TAs>? ISlot<T>.AsCollection<TAs>()
        {
            return _wrappedSlot.AsCollection<TAs>();
        }

        public override string ToString()
        {
            return _wrappedSlot.ToString();
        }
    }
}
