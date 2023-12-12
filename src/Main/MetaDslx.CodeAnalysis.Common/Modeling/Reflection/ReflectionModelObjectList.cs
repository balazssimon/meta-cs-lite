using Autofac.Features.Indexed;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    internal sealed class ReflectionModelObjectList : ICollectionSlot, IModelCollectionCore
    {
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ReflectionModelObject _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private ModelPropertySlot _slot;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        private PropertyInfo _property;

        public ReflectionModelObjectList(ReflectionModelObject owner, ModelPropertySlot slot)
        {
            _owner = owner;
            _slot = slot;
            var type = _owner.UnderlyingObject.GetType();
            var slotInfo = type.GetProperty(slot.SlotProperty.Name, BindingFlags.Instance | BindingFlags.Public);
            if (slotInfo is not null && typeof(IEnumerable).IsAssignableFrom(slotInfo.PropertyType))
            {
                _property = slotInfo;
            }
            else
            {
                foreach (var prop in slot.SlotProperties)
                {
                    var propInfo = type.GetProperty(prop.Name, BindingFlags.Instance | BindingFlags.Public);
                    if (propInfo is not null && typeof(IEnumerable).IsAssignableFrom(slotInfo.PropertyType))
                    {
                        _property = propInfo;
                        break;
                    }
                }
            }
            if (_property is null) throw new ArgumentException(nameof(slot), "Slot must be a collection.");
        }

        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public IModelObject Owner => _owner;
        [DebuggerBrowsable(DebuggerBrowsableState.Never)]
        public ModelPropertySlot Slot => _slot;

        public IEnumerable? Items => _property?.GetValue(_owner.UnderlyingObject) as IEnumerable;

        public bool IsReadOnly => _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly);
        public bool IsNonUnique => _slot.Flags.HasFlag(ModelPropertyFlags.NonUnique);
        public bool IsNullable => _slot.Flags.HasFlag(ModelPropertyFlags.NullableType);
        public bool IsSingleItem => _slot.Flags.HasFlag(ModelPropertyFlags.SingleItem);

        public object? SingleItem
        {
            get
            {
                var items = Items;
                if (items is null) return null;
                return _slot.Flags.HasFlag(ModelPropertyFlags.SingleItem) && GetCount(items) == 1 ? FirstValue(items) : null;
            }
            set
            {
                if (_slot.Flags.HasFlag(ModelPropertyFlags.SingleItem))
                {
                    var items = Items;
                    if (items is null) return;
                    if (GetCount(items) != 1 || value != FirstValue(items))
                    {
                        Clear();
                        Add(value);
                    }
                }
                else
                {
                    _slot.ThrowModelException(mp => mp.IsSingleItem, mp => $"Error assigning '{value}' to '{mp.QualifiedName}' in '{Owner}': this collection is not a single item collection.");
                }
            }
        }

        public int Count => GetCount(Items);

        public void Add(object? item)
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error adding '{item}' to '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error adding '{item}' to '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            AddCore(ToItem(item), false);
        }

        public void Remove(object? item)
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error removing '{item}' from '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error removing '{item}' from '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            RemoveCore(ToItem(item), false);
        }

        public bool Contains(object? item)
        {
            var value = ToValue(item);
            return ContainsValue(Items, value);
        }

        public IEnumerator GetEnumerator()
        {
            foreach (var value in Items)
            {
                yield return ToItem(value);
            }
        }

        public void Clear()
        {
            if (Owner.Model.IsReadOnly) throw new ModelException($"Error clearing '{_slot.SlotProperty.QualifiedName}' in '{Owner}': the model '{Owner.Model}' is read only.");
            if (Owner.Model.ValidationOptions.ValidateReadOnly && _slot.Flags.HasFlag(ModelPropertyFlags.ReadOnly))
            {
                _slot.ThrowModelException(mp => mp.IsReadOnly, mp => $"Error clearing '{mp.QualifiedName}' in '{Owner}': the property is read only.");
            }
            while (Items.GetEnumerator().MoveNext()) RemoveCore(ToItem(FirstValue(Items)), false);
        }

        public void AddCore(object? item, bool fromOpposite)
        {
            if (Owner.Model.ValidationOptions.ValidateNullable && !IsNullable && item == null)
            {
                _slot.ThrowModelException(mp => mp.IsNullable, mp => $"Error adding '{item}' to '{mp.QualifiedName}' in '{Owner}': the item cannot be null.");
            }
            var valueAdded = false;
            var items = Items;
            var value = ToValue(item);
            try
            {
                if (IsNonUnique || !ContainsValue(items, value))
                {
                    if (IsSingleItem && GetCount(items) >= 1)
                    {
                        _slot.ThrowModelException(mp => mp.IsSingleItem, mp => $"Error adding '{value}' to '{mp.QualifiedName}' in '{Owner}': this collection can only contain a single item.");
                    }
                    AddValue(items, value);
                    valueAdded = true;
                    _owner.ValueAdded(_slot, item, fromOpposite);
                }
            }
            catch (Exception ex)
            {
                if (valueAdded) RemoveValue(items, value);
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error adding '{value}' to '{_slot.SlotProperty.QualifiedName}' in '{Owner}'", ex);
                else throw;
            }
        }

        public void RemoveCore(object? item, bool fromOpposite)
        {
            var valueRemoved = false;
            var items = Items;
            var value = ToValue(item);
            try
            {
                RemoveValue(items, value);
                valueRemoved = true;
                if (IsNonUnique || !ContainsValue(items, value))
                {
                    _owner.ValueRemoved(_slot, item, fromOpposite);
                }
            }
            catch (Exception ex)
            {
                if (valueRemoved) AddValue(items, value);
                if (Owner.Model.ValidationOptions.FullPropertyModificationStackInExceptions) throw new ModelException($"Error removing '{value}' from '{_slot.SlotProperty.QualifiedName}' in '{Owner}'", ex);
                else throw;
            }
        }

        private int GetCount(IEnumerable items)
        {
            if (items is null) return 0;
            var type = items.GetType();
            var prop = type.GetProperty("Count");
            if (prop == null) return 0;
            return (int)prop.GetValue(items);
        }

        private object? FirstValue(IEnumerable items)
        {
            var enumerator = items.GetEnumerator();
            if (enumerator.MoveNext()) return enumerator.Current;
            else return null;
        }

        private bool ContainsValue(IEnumerable items, object? value)
        {
            if (items is null) return false;
            var type = items.GetType();
            var method = type.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => m.Name == "Contains" && m.GetParameters().Length == 1 && m.ReturnType == typeof(bool)).FirstOrDefault();
            if (method == null) return false;
            return (bool)method.Invoke(items, new object[] { value });
        }

        private void AddValue(IEnumerable items, object? value)
        {
            if (items is null) return;
            var type = items.GetType();
            var method = type.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => m.Name == "Add" && m.GetParameters().Length == 1).FirstOrDefault();
            if (method == null) return;
            method.Invoke(items, new object[] { value });
        }

        private void RemoveValue(IEnumerable items, object? value)
        {
            if (items is null) return;
            var type = items.GetType();
            var method = type.GetMethods(BindingFlags.Instance | BindingFlags.Public).Where(m => m.Name == "Remove" && m.GetParameters().Length == 1).FirstOrDefault();
            if (method == null) return;
            method.Invoke(items, new object[] { value });
        }

        private Type GetType(object item)
        {
            return item is IModelObject mobj ? mobj.MetaType.AsType() : item.GetType();
        }

        private object? ToValue(object? item)
        {
            return _owner.ToValue(item);
        }

        private object? ToItem(object? value)
        {
            return _owner.ToModelObject(value);
        }

        public IList<TTo> CastTo<TTo>()
        {
            throw new NotImplementedException();
        }
    }
}
