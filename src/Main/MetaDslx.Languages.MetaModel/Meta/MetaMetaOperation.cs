using MetaDslx.CodeAnalysis;
using MetaDslx.Languages.MetaModel.Model;
using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaModel.Meta
{
    public sealed class MetaMetaOperation : MetaOperation<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation>
    {
        public MetaMetaOperation(MetaClass<MetaDslx.CodeAnalysis.MetaType, MetaProperty, MetaOperation> declaringType, MetaOperation underlyingOperation)
            : base(declaringType, underlyingOperation)
        {
        }

        public override Location? Location => UnderlyingOperation.MLocation;

        public override string Name => UnderlyingOperation.Name;

        public override string Signature => $"{Name}({UnderlyingOperation.Parameters.Count})";
    }
}
