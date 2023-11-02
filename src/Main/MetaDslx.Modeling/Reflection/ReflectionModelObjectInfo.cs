using MetaDslx.CodeAnalysis.PooledObjects;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling.Reflection
{
    internal sealed class ReflectionModelObjectInfo : ModelObjectInfo
    {
        private static readonly Type[] EmptyTypes = new Type[0];
        private static readonly object[] EmptyObjects = new object[0];

        private readonly ReflectionMetaModel _metaModel;
        private readonly Type _metaType;
        private Type? _symbolType;
        private ModelProperty? _nameProperty;
        private ModelProperty? _typeProperty;
        private ImmutableArray<ModelProperty> _declaredProperties;
        private ImmutableArray<ModelProperty> _allDeclaredProperties;
        private ImmutableArray<ModelProperty> _publicProperties;
        private ImmutableDictionary<string, ModelProperty>? _publicPropertiesByName;
        private ImmutableDictionary<ModelProperty, ModelPropertyInfo>? _modelPropertyInfos;

        public ReflectionModelObjectInfo(
            ReflectionMetaModel metaModel,
            Type metaType,
            Type? symbolType,
            ModelProperty? nameProperty,
            ModelProperty? typeProperty,
            ImmutableArray<ModelProperty> declaredProperties,
            ImmutableArray<ModelProperty> allDeclaredProperties,
            ImmutableArray<ModelProperty> publicProperties,
            ImmutableDictionary<string, ModelProperty>? publicPropertiesByName,
            ImmutableDictionary<ModelProperty, ModelPropertyInfo>? modelPropertyInfos)
        {
            _metaModel = metaModel;
            _metaType = metaType;
            _symbolType = symbolType;
            _nameProperty = nameProperty;
            _typeProperty = typeProperty;
            _declaredProperties = declaredProperties;
            _allDeclaredProperties = allDeclaredProperties;
            _publicProperties = publicProperties;
            _publicPropertiesByName = publicPropertiesByName;
            _modelPropertyInfos = modelPropertyInfos;
        }

        public override MetaModel MetaModel => _metaModel;
        public override Type MetaType => _metaType;
        public override Type? SymbolType => _symbolType;
        public override ModelProperty? NameProperty => _nameProperty;
        public override ModelProperty? TypeProperty => _typeProperty;
        public override ImmutableArray<ModelProperty> DeclaredProperties => _declaredProperties;
        public override ImmutableArray<ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
        public override ImmutableArray<ModelProperty> PublicProperties => _publicProperties;

        protected override ImmutableDictionary<string, ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
        protected override ImmutableDictionary<ModelProperty, ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;

        public override IModelObject? Create(Model? model = null, string? id = null)
        {
            var ctr = _metaType.GetConstructor(EmptyTypes);
            if (ctr is not null)
            {
                var mobj = new ReflectionModelObject(ctr.Invoke(EmptyObjects), this, id);
                if (model is not null) model.AddObject(mobj);
                return mobj;
            }
            else
            {
                return null;
            }
        }
    }
}
