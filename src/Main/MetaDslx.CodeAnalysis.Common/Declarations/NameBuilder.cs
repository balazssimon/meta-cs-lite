using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Declarations
{
    public struct NameBuilder
    {
        private readonly Type? _qualifierType;
        private readonly string? _qualifierProperty;

        public NameBuilder(Type? qualifierType, string? qualifierProperty)
        {
            _qualifierType = qualifierType;
            _qualifierProperty = qualifierProperty;
        }

        public Type? QualifierType => _qualifierType;
        public string? QualifierProperty => _qualifierProperty;
    }
}
