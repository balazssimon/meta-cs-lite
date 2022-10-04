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
        private Type _type;
        private ModelPropertyFlags _flags;

        public ModelProperty(Type declaringType, string name, Type type, ModelPropertyFlags flags)
        {
            _declaringType = declaringType;
            _name = name;
            _type = type;
            _flags = flags;
        }

        public Type DeclaringType => _declaringType;
        public string Name => _name;
        public ModelPropertyFlags Flags => _flags;
        public Type Type => _type;
        public bool IsContainment => _flags.HasFlag(ModelPropertyFlags.Containment);
        public bool IsNonUnique => _flags.HasFlag(ModelPropertyFlags.NonUnique);
        public bool IsCollection => _flags.HasFlag(ModelPropertyFlags.Collection);
        public bool IsReadonly => _flags.HasFlag(ModelPropertyFlags.Readonly);

        public override string ToString()
        {
            return $"{DeclaringType.Name}.{Name}";
        }
    }
}
