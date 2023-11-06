using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using MetaDslx.Modeling.Meta;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaProperty : MetaProperty<Type, PropertyInfo>
    {
        private readonly ModelPropertyFlags _originalFlags;
        private readonly object? _defaultValue;
        private readonly string? _symbolProperty;

        public ReflectionMetaProperty(MetaClass<Type, PropertyInfo> declaringType, PropertyInfo underlyingProperty)
            : base(declaringType, underlyingProperty)
        {
            bool hasDefaultValue = false;
            object? defaultValue = null;
            string? symbolProperty = null;
            var flags = ModelPropertyFlags.None;
            foreach (var attr in underlyingProperty.GetCustomAttributes(true))
            {
                if (attr is DefaultValueAttribute defaultAttr)
                {
                    if (!hasDefaultValue && defaultAttr.Value is not null && declaringType.UnderlyingType.IsAssignableFrom(defaultAttr.Value.GetType()))
                    {
                        hasDefaultValue = true;
                        defaultValue = defaultAttr.Value;
                    }
                }
                else if (attr is TypeSymbolTypeAttribute)
                {
                    flags |= ModelPropertyFlags.TypeSymbolType;
                }
                else if (attr is NameAttribute)
                {
                    flags |= ModelPropertyFlags.Name;
                }
                else if (attr is TypeAttribute)
                {
                    flags |= ModelPropertyFlags.Type;
                }
                else if (attr is UntrackedAttribute)
                {
                    flags |= ModelPropertyFlags.Untracked;
                }
                else if (attr is NonUniqueAttribute)
                {
                    flags |= ModelPropertyFlags.NonUnique;
                }
                else if (attr is UnorderedAttribute)
                {
                    flags |= ModelPropertyFlags.Unordered;
                }
                else if (attr is ContainmentAttribute)
                {
                    flags |= ModelPropertyFlags.Containment;
                }
                else if (attr is ReadOnlyAttribute)
                {
                    flags |= ModelPropertyFlags.ReadOnly;
                }
                else if (attr is DerivedAttribute)
                {
                    flags |= ModelPropertyFlags.Derived;
                }
                else if (attr is DerivedUnionAttribute)
                {
                    flags |= ModelPropertyFlags.DerivedUnion;
                }
                else if (attr is SymbolPropertyAttribute symbolPropAttr)
                {
                    if (symbolProperty is null) symbolProperty = symbolPropAttr.PropertyName;
                }
            }
            _symbolProperty = symbolProperty;
            _defaultValue = defaultValue;
            _originalFlags = flags;
        }

        public override string Name => UnderlyingProperty.Name;

        public override bool HasSetter => UnderlyingProperty.CanWrite;

        public override object? DefaultValue => _defaultValue;

        public override string? SymbolProperty => _symbolProperty;

        public override Type OriginalType => UnderlyingProperty.PropertyType;

        public override ModelPropertyFlags OriginalFlags => _originalFlags;

        protected internal override IEnumerable<(Type DeclaringType, string PropertyName)> GetRedefinedProperties()
        {
            foreach (var attr in UnderlyingProperty.GetCustomAttributes<RedefinesAttribute>())
            {
                if (attr.Type.IsAssignableFrom(UnderlyingProperty.DeclaringType))
                {
                    yield return (attr.Type, attr.Property);
                }
            }
        }

        protected internal override IEnumerable<(Type DeclaringType, string PropertyName)> GetSubsettedProperties()
        {
            foreach (var attr in UnderlyingProperty.GetCustomAttributes<SubsetsAttribute>())
            {
                if (attr.Type.IsAssignableFrom(UnderlyingProperty.DeclaringType))
                {
                    yield return (attr.Type, attr.Property);
                }
            }
        }

        protected internal override IEnumerable<(Type DeclaringType, string PropertyName)> GetOppositeProperties()
        {
            foreach (var attr in UnderlyingProperty.GetCustomAttributes<OppositeAttribute>())
            {
                yield return (attr.Type, attr.Property);
            }
        }

        public override string ToString()
        {
            return $"{DeclaringType.Name}.{UnderlyingProperty.Name}";
        }
    }
}
