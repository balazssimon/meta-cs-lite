using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public struct ModelPropertyInfo
    {
        private ImmutableArray<ModelProperty> _oppositeProperties;
        private ImmutableArray<ModelProperty> _subsettedProperties;
        private ImmutableArray<ModelProperty> _subsettingProperties;
        private ImmutableArray<ModelProperty> _redefinedProperties;
        private ImmutableArray<ModelProperty> _redefiningProperties;

        public ModelPropertyInfo(
            ImmutableArray<ModelProperty> oppositeProperties = default, 
            ImmutableArray<ModelProperty> subsettedProperties = default, 
            ImmutableArray<ModelProperty> subsettingProperties = default, 
            ImmutableArray<ModelProperty> redefinedProperties = default, 
            ImmutableArray<ModelProperty> redefiningProperties = default)
        {
            _oppositeProperties = oppositeProperties.IsDefault ? ImmutableArray<ModelProperty>.Empty : oppositeProperties;
            _subsettedProperties = subsettedProperties.IsDefault ? ImmutableArray<ModelProperty>.Empty : subsettedProperties;
            _subsettingProperties = subsettingProperties.IsDefault ? ImmutableArray<ModelProperty>.Empty : subsettingProperties;
            _redefinedProperties = redefinedProperties.IsDefault ? ImmutableArray<ModelProperty>.Empty : redefinedProperties;
            _redefiningProperties = redefiningProperties.IsDefault ? ImmutableArray<ModelProperty>.Empty : redefiningProperties;
        }

        public ImmutableArray<ModelProperty> OppositeProperties => _oppositeProperties;
        public ImmutableArray<ModelProperty> SubsettedProperties => _subsettedProperties;
        public ImmutableArray<ModelProperty> SubsettingProperties => _subsettingProperties;
        public ImmutableArray<ModelProperty> RedefinedProperties => _redefinedProperties;
        public ImmutableArray<ModelProperty> RedefiningProperties => _redefiningProperties;
    }
}
