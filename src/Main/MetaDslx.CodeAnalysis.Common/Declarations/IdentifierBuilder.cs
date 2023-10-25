using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public struct IdentifierBuilder
    {
        private readonly string _name;
        private readonly string _metadataName;
        private readonly SourceLocation _nameLocation;
        private readonly Type? _qualifierType;
        private readonly string? _qualifierProperty;

        public IdentifierBuilder(string name, string metadataName, SourceLocation nameLocation, Type? qualifierType, string? qualifierProperty)
        {
            _name = name;
            _metadataName = metadataName;
            _nameLocation = nameLocation;
            _qualifierType = qualifierType;
            _qualifierProperty = qualifierProperty;
        }

        public string Name => _name;
        public string MetadataName => _metadataName;
        public SourceLocation NameLocation => _nameLocation;
        public Type? QualifierType => _qualifierType;
        public string? QualifierProperty => _qualifierProperty;
    }
}
