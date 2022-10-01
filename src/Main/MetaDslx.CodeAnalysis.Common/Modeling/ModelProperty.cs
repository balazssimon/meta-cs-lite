using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public sealed class ModelProperty
    {
        private Type _declaringType;
        private string _name;
        private ModelPropertyKind _kind;
        private Type _type;
        private bool _isContainment;
        private ImmutableArray<ModelProperty> _oppositeProperties;

        public ModelProperty(Type declaringType, string name, ModelPropertyKind kind, Type type, bool isContainment)
        {
            _declaringType = declaringType;
            _name = name;
            _kind = kind;
            _type = type;
            _isContainment = isContainment;
        }

        public Type DeclaringType => _declaringType;
        public string Name => _name;
        public ModelPropertyKind Kind => _kind;
        public Type Type => _type;
        public bool IsContainment => _isContainment;
        public bool IsUnique => _kind == ModelPropertyKind.SingleValue || _kind == ModelPropertyKind.List || _kind == ModelPropertyKind.Set;
        public bool IsCollection => _kind != ModelPropertyKind.SingleValue;
        public ImmutableArray<ModelProperty> OpositeProperties => _oppositeProperties;

        internal void SetOppositeProperties(ImmutableArray<ModelProperty> oppositeProperties)
        {
            ImmutableInterlocked.InterlockedCompareExchange(ref _oppositeProperties, oppositeProperties, default(ImmutableArray<ModelProperty>));
        }
    }
}
