using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis
{
    internal sealed class CSharpMetadataReference : MetadataReference
    {
        private readonly Microsoft.CodeAnalysis.MetadataReference _reference;

        public CSharpMetadataReference(Microsoft.CodeAnalysis.MetadataReference reference)
            : base(reference.Properties.ToMetaDslx())
        {
            _reference = reference;
        }

        public Microsoft.CodeAnalysis.MetadataReference CSharpReference => _reference;

        protected override MetadataReference WithPropertiesCore(MetadataReferenceProperties properties)
        {
            return new CSharpMetadataReference(_reference.WithProperties(_reference.Properties.WithAliases(properties.Aliases)));
        }
    }
}
