using MetaDslx.Modeling.Meta;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    internal sealed class MetaModelReference : MetadataReference
    {
        private readonly MetaModel _metaModel;

        public MetaModelReference(MetaModel metaModel, MetadataReferenceProperties properties)
            : base(properties)
        {
            _metaModel = metaModel;
        }

        public MetaModel MetaModel => _metaModel;

        protected override MetadataReference WithPropertiesCore(MetadataReferenceProperties properties)
        {
            return new MetaModelReference(_metaModel, properties);
        }
    }
}
