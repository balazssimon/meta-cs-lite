using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;
using MetaDslx.Modeling.Meta;

namespace MetaDslx.Modeling.Reflection
{
    internal class ReflectionMetaClass : MetaClass<Type, PropertyInfo, Type>
    {
        public ReflectionMetaClass(Type underlyingType)
            : base(underlyingType)
        {

        }

        public override string Name => UnderlyingType.Name;

        public override Type? SymbolType
        {
            get
            {
                var symbolAttr = UnderlyingType.GetCustomAttribute<SymbolAttribute>(true);
                return symbolAttr?.SymbolType;
            }
        }

        protected internal override ImmutableArray<Type> OriginalBaseTypes
        {
            get
            {
                return ImmutableArray.Create(UnderlyingType.BaseType);
            }
        }

        protected internal override ImmutableArray<PropertyInfo> OriginalDeclaredProperties
        {
            get
            {
                return UnderlyingType.GetProperties(BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly).ToImmutableArray();
            }
        }

        public override string ToString()
        {
            return UnderlyingType.Name;
        }
    }
}
