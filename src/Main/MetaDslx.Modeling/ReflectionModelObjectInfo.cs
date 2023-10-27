using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Modeling
{
    internal class ReflectionModelObjectInfo : ModelObjectInfo
    {
        private static readonly Type[] EmptyTypes = new Type[0];
        private static readonly object[] EmptyObjects = new object[0];

        private readonly ReflectionMetaModel _metaModel;
        private readonly Type _metaType;

        public ReflectionModelObjectInfo(ReflectionMetaModel metaModel, Type metaType)
        {
            _metaModel = metaModel;
            _metaType = metaType;
        }

        public override MetaModel MetaModel => _metaModel;
        public override Type MetaType => _metaType;

        public override IModelObject Create(string? id = null)
        {
            var ctr = _metaType.GetConstructor(EmptyTypes);
            if (ctr is not null) return new ReflectionModelObject(ctr.Invoke(EmptyObjects), id);
            else return null;
        }

        protected override Dictionary<string, ModelProperty> PublicPropertiesByName => throw new NotImplementedException();

        protected override Dictionary<ModelProperty, ModelPropertyInfo> ModelPropertyInfos => throw new NotImplementedException();
    }
}
