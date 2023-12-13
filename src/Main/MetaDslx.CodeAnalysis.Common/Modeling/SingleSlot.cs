using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class SingleSlot : Slot, ISingleSlot
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private Box _box;

        public SingleSlot(ModelObject owner, ModelPropertySlot property)
            : base(owner, property)
        {
            _box = new Box(this);
        }

        public override bool IsDefault => _box.IsDefault;

        public void Clear()
        {
            Remove(_box.Value, null);
        }

        public override bool Contains(object? item)
        {
            return _box.Value == item;
        }

        public object? Get()
        {
            return _box.Value;
        }

        public Box GetBox()
        {
            return _box;
        }

        public Box Init(object? value)
        {
            Model.CheckReadOnly($"Error initializing {this} with '{value}'");
            return Add(value, null);
        }

        public Box? Set(object? value)
        {
            return Add(value, null);
        }

        public override Box Add(object? item, Box? oppositeBox)
        {
            if (oppositeBox is null) CheckReadOnly($"Error assigning '{item}' to {this}");
            CheckValueType(item);
            var oldValue = _box.Value;
            if (oldValue != item)
            {
                try
                {
                    _box.Clear();
                    ValueRemoved(_box, oldValue, oppositeBox);
                    _box.Value = item;
                    ValueAdded(_box, oppositeBox);
                }
                catch (Exception ex)
                {
                    _box.Value = oldValue;
                    if (Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetAddMessage(Property.SlotProperty, item)}", ex);
                    else throw;
                }
            }
            return _box;
        }

        public override Box Remove(object? item, Box? oppositeBox)
        {
            if (oppositeBox is null) CheckReadOnly($"Error removing '{item}' from {this}");
            var oldValue = _box.Value;
            if (oldValue == item)
            {
                try
                {
                    _box.Clear();
                    ValueRemoved(_box, oldValue, oppositeBox);
                }
                catch (Exception ex)
                {
                    _box.Value = oldValue;
                    if (Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"{GetRemoveMessage(Property.SlotProperty, item)}", ex);
                    else throw;
                }
            }
            return _box;
        }
    }

    internal class SingleSlot<T> : ISingleSlot<T>
    {
        private readonly ISingleSlot _singleSlot;

        public SingleSlot(ISingleSlot singleSlot)
        {
            _singleSlot = singleSlot;
        }

        public IModelObject Owner => _singleSlot.Owner;

        public ModelPropertySlot Property => _singleSlot.Property;

        public bool IsSingle => _singleSlot.IsSingle;

        public bool IsCollection => _singleSlot.IsCollection;

        public bool IsMap => _singleSlot.IsMap;

        public bool IsReadOnly => _singleSlot.IsReadOnly;

        public bool IsNullable => _singleSlot.IsNullable;

        public bool IsDefault => _singleSlot.IsDefault;

        Box ISlot.Add(object? item, Box? oppositeBox)
        {
            return _singleSlot.Add(item, oppositeBox);
        }

        ICollectionSlot? ISlot.AsCollection()
        {
            return null;
        }

        ICollectionSlot<T1>? ISlot.AsCollection<T1>()
        {
            return null;
        }

        IMapSlot? ISlot.AsMap()
        {
            return null;
        }

        IMapSlot<TKey, TValue>? ISlot.AsMap<TKey, TValue>()
        {
            return null;
        }

        ISingleSlot? ISlot.AsSingle()
        {
            return _singleSlot;
        }

        ISingleSlot<T1>? ISlot.AsSingle<T1>()
        {
            if (typeof(T1) == typeof(T)) return (ISingleSlot<T1>)this;
            return new SingleSlot<T1>(_singleSlot);
        }

        void ISingleSlot.Clear()
        {
            _singleSlot.Clear();
        }

        bool ISlot.Contains(object? item)
        {
            return _singleSlot.Contains(item);
        }

        T ISingleSlot<T>.Get()
        {
            return (T)_singleSlot.Get();
        }

        object? ISingleSlot.Get()
        {
            return _singleSlot.Get();
        }

        Box ISingleSlot.GetBox()
        {
            return _singleSlot.GetBox();
        }

        Box ISingleSlot.Init(object? value)
        {
            return _singleSlot.Init(value);
        }

        Box ISlot.Remove(object? item, Box? oppositeBox)
        {
            return _singleSlot.Remove(item, oppositeBox);
        }

        Box ISingleSlot<T>.Set(T value)
        {
            return _singleSlot.Set(value);
        }

        Box ISingleSlot.Set(object? value)
        {
            return _singleSlot.Set(value);
        }
    }
}
