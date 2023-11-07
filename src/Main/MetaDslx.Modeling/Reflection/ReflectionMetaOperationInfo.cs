using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    public sealed class ReflectionMetaOperationInfo : MetaOperationInfo<Type, PropertyInfo, MethodInfo>
    {
        public ReflectionMetaOperationInfo(ImmutableArray<MetaOperation<Type, PropertyInfo, MethodInfo>> overridenProperties = default, ImmutableArray<MetaOperation<Type, PropertyInfo, MethodInfo>> overridingProperties = default)
            : base(overridenProperties, overridingProperties)
        {
        }
    }
}
