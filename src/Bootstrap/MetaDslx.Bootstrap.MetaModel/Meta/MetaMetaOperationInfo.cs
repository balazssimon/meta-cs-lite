using MetaDslx.Bootstrap.MetaModel.Model;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Bootstrap.MetaModel.Meta
{
    public sealed class MetaMetaOperationInfo : MetaOperationInfo<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>
    {
        public MetaMetaOperationInfo(ImmutableArray<MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> overridenOperations = default, ImmutableArray<MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>> overridingOperations = default)
            : base(overridenOperations, overridingOperations)
        {
        }
    }
}
