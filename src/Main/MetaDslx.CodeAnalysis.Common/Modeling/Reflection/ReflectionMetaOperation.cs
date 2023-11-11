using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MetaDslx.Modeling.Reflection
{
    public sealed class ReflectionMetaOperation : MetaOperation<Type, PropertyInfo, MethodInfo>
    {
        public ReflectionMetaOperation(MetaClass<Type, PropertyInfo, MethodInfo> declaringType, MethodInfo underlyingOperation)
            : base(declaringType, underlyingOperation)
        {
        }

        public override string Name => UnderlyingOperation.Name;

        public override string Signature => Name;
    }
}
