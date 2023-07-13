using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    internal sealed class MetaModelReference : MetadataReference
    {
        private readonly IMetaModel _metaModel;

        public MetaModelReference(IMetaModel metaModel, MetadataReferenceProperties properties)
            : base(properties)
        {
            _metaModel = metaModel;
        }

        public IMetaModel MetaModel => _metaModel;

        protected override MetadataReference WithPropertiesCore(MetadataReferenceProperties properties)
        {
            return new MetaModelReference(_metaModel, properties);
        }
    }
}
