using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public struct ModelOperationInfo
    {
        public ModelOperationInfo(
            ImmutableArray<ModelOperation> overridenOperations = default,
            ImmutableArray<ModelOperation> overridingOperations = default)
        {
            OverridenOperations = overridenOperations;
            OverridingOperations = overridingOperations;
        }

        public ImmutableArray<ModelOperation> OverridenOperations { get; }
        public ImmutableArray<ModelOperation> OverridingOperations { get; }
    }
}
