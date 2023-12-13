using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public class ModelPropertySlot
    {
        private readonly ModelProperty _slotProperty;
        private readonly ImmutableArray<ModelProperty> _slotProperties;
        private readonly object? _defaultValue;
        private readonly ModelPropertyFlags _flags;
        private Func<IModelObject, object>? _mapKeySelector;

        public ModelPropertySlot(ModelProperty slotProperty, ImmutableArray<ModelProperty> slotProperties, object? defaultValue, ModelPropertyFlags flags)
        {
            _slotProperty = slotProperty;
            _slotProperties = slotProperties;
            _defaultValue = defaultValue;
            _flags = flags;
        }

        public ModelProperty SlotProperty => _slotProperty;
        public ImmutableArray<ModelProperty> SlotProperties => _slotProperties;
        public string QualifiedName => _slotProperty.QualifiedName;
        public object? DefaultValue => _defaultValue;
        public ModelPropertyFlags Flags => _flags;
        public Func<IModelObject, object>? MapKeySelector => _mapKeySelector;
        public bool IsContainment => _flags.HasFlag(ModelPropertyFlags.Containment);
        public bool IsSingle => _flags.HasFlag(ModelPropertyFlags.Single);
        public bool IsCollection => _flags.HasFlag(ModelPropertyFlags.Collection);
        public bool IsMap => _flags.HasFlag(ModelPropertyFlags.Map);
        public bool IsMultiMap => _flags.HasFlag(ModelPropertyFlags.MultiMap);
        public bool IsNullable => _flags.HasFlag(ModelPropertyFlags.NullableType);
        public bool IsReadOnly => _flags.HasFlag(ModelPropertyFlags.ReadOnly);
        public bool IsUnordered => _flags.HasFlag(ModelPropertyFlags.Unordered);
        public bool IsNonUnique => _flags.HasFlag(ModelPropertyFlags.NonUnique);
        public bool IsUntracked => _flags.HasFlag(ModelPropertyFlags.Untracked);
        public bool IsModelObjectType => _flags.HasFlag(ModelPropertyFlags.ModelObjectType);

        internal void ThrowModelException(Func<ModelProperty, bool> condition, Func<ModelProperty, string> message)
        {
            foreach (var slotProperty in _slotProperties)
            {
                if (condition(slotProperty)) throw new ModelException(string.Format(message(slotProperty), slotProperty.QualifiedName));
            }
        }
    }
}
