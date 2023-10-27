using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    internal sealed class ModelReference : MetadataReference
    {
        private readonly Model _model;

        public ModelReference(Model model, MetadataReferenceProperties properties)
            : base(properties)
        {
            _model = model;
        }

        public Model Model => _model;

        protected override MetadataReference WithPropertiesCore(MetadataReferenceProperties properties)
        {
            return new ModelReference(_model, properties);
        }
    }
}
