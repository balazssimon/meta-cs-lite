using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaOperation<TType, TProperty, TOperation>
    {
        public MetaOperation(MetaClass<TType, TProperty, TOperation> declaringType, TOperation underlyingOperation)
        {
            DeclaringType = declaringType;
            UnderlyingOperation = underlyingOperation;
        }

        public MetaClass<TType, TProperty, TOperation> DeclaringType { get; }
        public TOperation UnderlyingOperation { get; }

        public abstract string Name { get; }
        public abstract string Signature { get; }
    }
}
