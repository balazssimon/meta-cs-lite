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

        public IdentifierBuilder(string name, string metadataName, SourceLocation nameLocation)
        {
            _name = name;
            _metadataName = metadataName;
            _nameLocation = nameLocation;
        }

        public string Name => _name;
        public string MetadataName => _metadataName;
        public SourceLocation NameLocation => _nameLocation;
    }
}
