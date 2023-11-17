using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaClassInfo : ModelClassInfo
    {
        private readonly ImportedMetaModel _metaModel;
        private readonly MetaType _metaType;
        private object? _symbolType;
        private ModelProperty? _nameProperty;
        private ModelProperty? _typeProperty;
        private ImmutableArray<ModelProperty> _declaredProperties;
        private ImmutableArray<ModelProperty> _allDeclaredProperties;
        private ImmutableArray<ModelProperty> _publicProperties;
        private ImmutableDictionary<string, ModelProperty>? _publicPropertiesByName;
        private ImmutableDictionary<ModelProperty, ModelPropertyInfo>? _modelPropertyInfos;

        public ImportedMetaClassInfo(
            ImportedMetaModel metaModel,
            MetaType metaType,
            object? symbolType,
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
        public override MetaType MetaType => _metaType;
        public override MetaType SymbolType => _symbolType is not null ? Type.GetType($"{_symbolType}, MetaDslx.CodeAnalysis.Common") : null;
        public override ModelProperty? NameProperty => _nameProperty;
        public override ModelProperty? TypeProperty => _typeProperty;
        public override ImmutableArray<ModelProperty> DeclaredProperties => _declaredProperties;
        public override ImmutableArray<ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
        public override ImmutableArray<ModelProperty> PublicProperties => _publicProperties;

        protected override ImmutableDictionary<string, ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
        protected override ImmutableDictionary<ModelProperty, ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;

        public override ImmutableArray<ModelOperation> DeclaredOperations => ImmutableArray<ModelOperation>.Empty;
        public override ImmutableArray<ModelOperation> AllDeclaredOperations => ImmutableArray<ModelOperation>.Empty;
        public override ImmutableArray<ModelOperation> PublicOperations => ImmutableArray<ModelOperation>.Empty;

        protected override ImmutableDictionary<ModelOperation, ModelOperationInfo> ModelOperationInfos => ImmutableDictionary<ModelOperation, ModelOperationInfo>.Empty;

        public override ImmutableArray<ModelClassInfo> BaseTypes => throw new NotImplementedException();

        public override ImmutableArray<ModelClassInfo> AllBaseTypes => throw new NotImplementedException();

        public override IModelObject? Create(MetaDslx.Modeling.Model? model = null, string? id = null)
        {
            return null;
        }

        public override string ToString()
        {
            return _metaType.Name;
        }
    }
}
