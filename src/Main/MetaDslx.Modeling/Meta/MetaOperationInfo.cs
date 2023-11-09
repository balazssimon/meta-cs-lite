using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling.Meta
{
    public abstract class MetaOperationInfo<TType, TProperty, TOperation>
    {
        public MetaOperationInfo(
            ImmutableArray<MetaOperation<TType, TProperty, TOperation>> overridenOperations,
            ImmutableArray<MetaOperation<TType, TProperty, TOperation>> overridingOperations)
        {
            OverridenOperations = overridenOperations;
            OverridingOperations = overridingOperations;
        }

        public ImmutableArray<MetaOperation<TType, TProperty, TOperation>> OverridenOperations { get; }
        public ImmutableArray<MetaOperation<TType, TProperty, TOperation>> OverridingOperations { get; }
    }
}
