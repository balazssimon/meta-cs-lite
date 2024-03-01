#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Model.__Impl
{
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MetaModelObject = global::MetaDslx.Modeling.MetaModelObject;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelPropertyInfo = global::MetaDslx.Modeling.ModelPropertyInfo;
    using __ModelPropertySlot = global::MetaDslx.Modeling.ModelPropertySlot;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal class MetaProperty_Impl : __MetaModelObject, MetaProperty
    {
        private MetaProperty_Impl(string? id)
            : base(id)
        {
            Meta.__CustomImpl.MetaDeclaration(this);
            Meta.__CustomImpl.MetaProperty(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public object? DefaultValue
        {
            get => MGet<object?>(Meta.MetaProperty_DefaultValue);
            set => MSet<object?>(Meta.MetaProperty_DefaultValue, value);
        }
    
        public bool IsContainment
        {
            get => MGet<bool>(Meta.MetaProperty_IsContainment);
            set => MSet<bool>(Meta.MetaProperty_IsContainment, value);
        }
    
        public bool IsDerived
        {
            get => MGet<bool>(Meta.MetaProperty_IsDerived);
            set => MSet<bool>(Meta.MetaProperty_IsDerived, value);
        }
    
        public bool IsReadOnly
        {
            get => MGet<bool>(Meta.MetaProperty_IsReadOnly);
            set => MSet<bool>(Meta.MetaProperty_IsReadOnly, value);
        }
    
        public bool IsUnion
        {
            get => MGet<bool>(Meta.MetaProperty_IsUnion);
            set => MSet<bool>(Meta.MetaProperty_IsUnion, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Bootstrap.MetaModel.Model.MetaProperty> OppositeProperties
        {
            get => MGetCollection<MetaProperty>(Meta.MetaProperty_OppositeProperties);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Bootstrap.MetaModel.Model.MetaProperty> RedefinedProperties
        {
            get => MGetCollection<MetaProperty>(Meta.MetaProperty_RedefinedProperties);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Bootstrap.MetaModel.Model.MetaProperty> SubsettedProperties
        {
            get => MGetCollection<MetaProperty>(Meta.MetaProperty_SubsettedProperties);
        }
    
        public MetaDslx.CodeAnalysis.MetaSymbol SymbolProperty
        {
            get => MGet<MetaDslx.CodeAnalysis.MetaSymbol>(Meta.MetaProperty_SymbolProperty);
            set => MSet<MetaDslx.CodeAnalysis.MetaSymbol>(Meta.MetaProperty_SymbolProperty, value);
        }
    
        public MetaDslx.Bootstrap.MetaModel.Model.MetaTypeReference Type
        {
            get => MGet<MetaDslx.Bootstrap.MetaModel.Model.MetaTypeReference>(Meta.MetaProperty_Type);
            set => MSet<MetaDslx.Bootstrap.MetaModel.Model.MetaTypeReference>(Meta.MetaProperty_Type, value);
        }
    
        public string? FullName
        {
            get => Meta.__CustomImpl.MetaDeclaration_FullName(this);
        }
    
        public string? Name
        {
            get => MGet<string?>(Meta.MetaDeclaration_Name);
            set => MSet<string?>(Meta.MetaDeclaration_Name, value);
        }
    
        public string Namespace
        {
            get => Meta.__CustomImpl.MetaDeclaration_Namespace(this);
        }
    
    
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Meta.MetaDeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_IsReadOnly, Meta.MetaProperty_IsUnion, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_IsReadOnly, Meta.MetaProperty_IsUnion, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Namespace);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue, Meta.MetaProperty_IsContainment, Meta.MetaProperty_IsDerived, Meta.MetaProperty_IsReadOnly, Meta.MetaProperty_IsUnion, Meta.MetaProperty_OppositeProperties, Meta.MetaProperty_RedefinedProperties, Meta.MetaProperty_SubsettedProperties, Meta.MetaProperty_SymbolProperty, Meta.MetaProperty_Type, Meta.MetaDeclaration_FullName, Meta.MetaDeclaration_Name, Meta.MetaDeclaration_Namespace);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("DefaultValue", Meta.MetaProperty_DefaultValue);
                publicPropertiesByName.Add("IsContainment", Meta.MetaProperty_IsContainment);
                publicPropertiesByName.Add("IsDerived", Meta.MetaProperty_IsDerived);
                publicPropertiesByName.Add("IsReadOnly", Meta.MetaProperty_IsReadOnly);
                publicPropertiesByName.Add("IsUnion", Meta.MetaProperty_IsUnion);
                publicPropertiesByName.Add("OppositeProperties", Meta.MetaProperty_OppositeProperties);
                publicPropertiesByName.Add("RedefinedProperties", Meta.MetaProperty_RedefinedProperties);
                publicPropertiesByName.Add("SubsettedProperties", Meta.MetaProperty_SubsettedProperties);
                publicPropertiesByName.Add("SymbolProperty", Meta.MetaProperty_SymbolProperty);
                publicPropertiesByName.Add("Type", Meta.MetaProperty_Type);
                publicPropertiesByName.Add("FullName", Meta.MetaDeclaration_FullName);
                publicPropertiesByName.Add("Name", Meta.MetaDeclaration_Name);
                publicPropertiesByName.Add("Namespace", Meta.MetaDeclaration_Namespace);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Meta.MetaProperty_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_IsContainment, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsContainment, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsContainment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_IsDerived, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsDerived, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsDerived), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_IsReadOnly, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsReadOnly, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsReadOnly), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_IsUnion, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_IsUnion, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_IsUnion), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_OppositeProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_OppositeProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_OppositeProperties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_RedefinedProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_RedefinedProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_RedefinedProperties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_SubsettedProperties, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SubsettedProperties, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SubsettedProperties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_SymbolProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_SymbolProperty, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_SymbolProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaProperty_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaProperty_Type, __ImmutableArray.Create<__ModelProperty>(Meta.MetaProperty_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_FullName, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Name, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Meta.MetaDeclaration_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Meta.MetaDeclaration_Namespace, __ImmutableArray.Create<__ModelProperty>(Meta.MetaDeclaration_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Meta.MInstance;
            public override __MetaType MetaType => typeof(MetaProperty);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Meta.MetaDeclaration_Name;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new MetaProperty_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Meta.MetaPropertyInfo";
            }
        }
    }
}
