#nullable enable

namespace MetaDslx.Languages.Ecore.Model.__Impl
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

    internal class EEnum_Impl : __MetaModelObject, EEnum
    {
        private EEnum_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Ecore.EDataType_Serializable)?.Add((bool)true);
            Ecore.__CustomImpl.EModelElement(this);
            Ecore.__CustomImpl.ENamedElement(this);
            Ecore.__CustomImpl.EClassifier(this);
            Ecore.__CustomImpl.EDataType(this);
            Ecore.__CustomImpl.EEnum(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<EEnumLiteral> ELiterals
        {
            get => MGetCollection<EEnumLiteral>(Ecore.EEnum_ELiterals);
        }
    
        public bool Serializable
        {
            get => MGet<bool>(Ecore.EDataType_Serializable);
            set => MSet<bool>(Ecore.EDataType_Serializable, value);
        }
    
        public __MetaSymbol DefaultValue
        {
            get => Ecore.__CustomImpl.EClassifier_DefaultValue(this);
        }
    
        public EPackage EPackage
        {
            get => MGet<EPackage>(Ecore.EClassifier_EPackage);
            set => MSet<EPackage>(Ecore.EClassifier_EPackage, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ETypeParameter> ETypeParameters
        {
            get => MGetCollection<ETypeParameter>(Ecore.EClassifier_ETypeParameters);
        }
    
        public __MetaType InstanceClass
        {
            get => Ecore.__CustomImpl.EClassifier_InstanceClass(this);
        }
    
        public __MetaType InstanceClassName
        {
            get => MGet<__MetaType>(Ecore.EClassifier_InstanceClassName);
            set => MSet<__MetaType>(Ecore.EClassifier_InstanceClassName, value);
        }
    
        public string InstanceTypeName
        {
            get => MGet<string>(Ecore.EClassifier_InstanceTypeName);
            set => MSet<string>(Ecore.EClassifier_InstanceTypeName, value);
        }
    
        public string Name
        {
            get => MGet<string>(Ecore.ENamedElement_Name);
            set => MSet<string>(Ecore.ENamedElement_Name, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EAnnotation> EAnnotations
        {
            get => MGetCollection<EAnnotation>(Ecore.EModelElement_EAnnotations);
        }
    
    
        EEnumLiteral EEnum.GetEEnumLiteral(int value) => Ecore.__CustomImpl.EEnum_GetEEnumLiteral(this, value);
        EEnumLiteral EEnum.GetEEnumLiteral(string name) => Ecore.__CustomImpl.EEnum_GetEEnumLiteral(this, name);
        EEnumLiteral EEnum.GetEEnumLiteralByLiteral(string literal) => Ecore.__CustomImpl.EEnum_GetEEnumLiteralByLiteral(this, literal);
        int EClassifier.GetClassifierID() => Ecore.__CustomImpl.EClassifier_GetClassifierID(this);
        bool EClassifier.IsInstance(__MetaSymbol @object) => Ecore.__CustomImpl.EClassifier_IsInstance(this, @object);
        EAnnotation EModelElement.GetEAnnotation(string source) => Ecore.__CustomImpl.EModelElement_GetEAnnotation(this, source);
    
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.EDataTypeInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.EDataTypeInfo, Ecore.EClassifierInfo, Ecore.ENamedElementInfo, Ecore.EModelElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EEnum_ELiterals);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EEnum_ELiterals, Ecore.EDataType_Serializable, Ecore.EClassifier_DefaultValue, Ecore.EClassifier_EPackage, Ecore.EClassifier_ETypeParameters, Ecore.EClassifier_InstanceClass, Ecore.EClassifier_InstanceClassName, Ecore.EClassifier_InstanceTypeName, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EEnum_ELiterals, Ecore.EDataType_Serializable, Ecore.EClassifier_DefaultValue, Ecore.EClassifier_EPackage, Ecore.EClassifier_ETypeParameters, Ecore.EClassifier_InstanceClass, Ecore.EClassifier_InstanceClassName, Ecore.EClassifier_InstanceTypeName, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("ELiterals", Ecore.EEnum_ELiterals);
                publicPropertiesByName.Add("Serializable", Ecore.EDataType_Serializable);
                publicPropertiesByName.Add("DefaultValue", Ecore.EClassifier_DefaultValue);
                publicPropertiesByName.Add("EPackage", Ecore.EClassifier_EPackage);
                publicPropertiesByName.Add("ETypeParameters", Ecore.EClassifier_ETypeParameters);
                publicPropertiesByName.Add("InstanceClass", Ecore.EClassifier_InstanceClass);
                publicPropertiesByName.Add("InstanceClassName", Ecore.EClassifier_InstanceClassName);
                publicPropertiesByName.Add("InstanceTypeName", Ecore.EClassifier_InstanceTypeName);
                publicPropertiesByName.Add("Name", Ecore.ENamedElement_Name);
                publicPropertiesByName.Add("EAnnotations", Ecore.EModelElement_EAnnotations);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Ecore.EEnum_ELiterals, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EEnum_ELiterals, __ImmutableArray.Create<__ModelProperty>(Ecore.EEnum_ELiterals), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EEnumLiteral_EEnum), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EDataType_Serializable, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EDataType_Serializable, __ImmutableArray.Create<__ModelProperty>(Ecore.EDataType_Serializable), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_EPackage, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_EPackage, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_EPackage), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_EClassifiers), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_ETypeParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_ETypeParameters, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_ETypeParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_InstanceClass, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_InstanceClass, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_InstanceClass), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_InstanceClassName, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_InstanceClassName, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_InstanceClassName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_InstanceTypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_InstanceTypeName, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_InstanceTypeName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ENamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ENamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Ecore.ENamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EModelElement_EAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EModelElement_EAnnotations, __ImmutableArray.Create<__ModelProperty>(Ecore.EModelElement_EAnnotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EAnnotation_EModelElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EEnum_GetEEnumLiteral1, Ecore.EEnum_GetEEnumLiteral2, Ecore.EEnum_GetEEnumLiteralByLiteral);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EEnum_GetEEnumLiteral1, Ecore.EEnum_GetEEnumLiteral2, Ecore.EEnum_GetEEnumLiteralByLiteral, Ecore.EClassifier_GetClassifierID, Ecore.EClassifier_IsInstance, Ecore.EModelElement_GetEAnnotation);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EEnum_GetEEnumLiteral1, Ecore.EEnum_GetEEnumLiteral2, Ecore.EEnum_GetEEnumLiteralByLiteral, Ecore.EClassifier_GetClassifierID, Ecore.EClassifier_IsInstance, Ecore.EModelElement_GetEAnnotation);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Ecore.EEnum_GetEEnumLiteral1, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EEnum_GetEEnumLiteral2, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EEnum_GetEEnumLiteralByLiteral, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClassifier_GetClassifierID, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClassifier_IsInstance, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EModelElement_GetEAnnotation, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Ecore.MInstance;
            public override __MetaType MetaType => typeof(EEnum);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
            public override __ModelProperty? NameProperty => Ecore.ENamedElement_Name;
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
                var result = new EEnum_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Ecore.EEnumInfo";
            }
        }
    }
}
