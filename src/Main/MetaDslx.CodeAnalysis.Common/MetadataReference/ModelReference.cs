using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    internal sealed class ModelReference : MetadataReference
    {
        private readonly IModel _model;

        public ModelReference(IModel model, MetadataReferenceProperties properties)
            : base(properties)
        {
            _model = model;
        }

        public IModel Model => _model;

        protected override MetadataReference WithPropertiesCore(MetadataReferenceProperties properties)
        {
            return new ModelReference(_model, properties);
        }
    }
}
