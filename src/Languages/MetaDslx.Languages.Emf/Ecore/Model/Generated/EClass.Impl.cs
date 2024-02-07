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

    internal class EClass_Impl : __MetaModelObject, EClass
    {
        private EClass_Impl(string? id)
            : base(id)
        {
            Ecore.__CustomImpl.EModelElement(this);
            Ecore.__CustomImpl.ENamedElement(this);
            Ecore.__CustomImpl.EClassifier(this);
            Ecore.__CustomImpl.EClass(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public bool Abstract
        {
            get => MGet<bool>(Ecore.EClass_Abstract);
            set => MSet<bool>(Ecore.EClass_Abstract, value);
        }
    
        public global::System.Collections.Generic.IList<EAttribute> EAllAttributes
        {
            get => Ecore.__CustomImpl.EClass_EAllAttributes(this);
        }
    
        public global::System.Collections.Generic.IList<EReference> EAllContainments
        {
            get => Ecore.__CustomImpl.EClass_EAllContainments(this);
        }
    
        public global::System.Collections.Generic.IList<EGenericType> EAllGenericSuperTypes
        {
            get => Ecore.__CustomImpl.EClass_EAllGenericSuperTypes(this);
        }
    
        public global::System.Collections.Generic.IList<EOperation> EAllOperations
        {
            get => Ecore.__CustomImpl.EClass_EAllOperations(this);
        }
    
        public global::System.Collections.Generic.IList<EReference> EAllReferences
        {
            get => Ecore.__CustomImpl.EClass_EAllReferences(this);
        }
    
        public global::System.Collections.Generic.IList<EStructuralFeature> EAllStructuralFeatures
        {
            get => Ecore.__CustomImpl.EClass_EAllStructuralFeatures(this);
        }
    
        public global::System.Collections.Generic.IList<EClass> EAllSuperTypes
        {
            get => Ecore.__CustomImpl.EClass_EAllSuperTypes(this);
        }
    
        public global::System.Collections.Generic.IList<EAttribute> EAttributes
        {
            get => Ecore.__CustomImpl.EClass_EAttributes(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EGenericType> EGenericSuperTypes
        {
            get => MGetCollection<EGenericType>(Ecore.EClass_EGenericSuperTypes);
        }
    
        public EAttribute EIDAttribute
        {
            get => Ecore.__CustomImpl.EClass_EIDAttribute(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EOperation> EOperations
        {
            get => MGetCollection<EOperation>(Ecore.EClass_EOperations);
        }
    
        public global::System.Collections.Generic.IList<EReference> EReferences
        {
            get => Ecore.__CustomImpl.EClass_EReferences(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EStructuralFeature> EStructuralFeatures
        {
            get => MGetCollection<EStructuralFeature>(Ecore.EClass_EStructuralFeatures);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EClass> ESuperTypes
        {
            get => MGetCollection<EClass>(Ecore.EClass_ESuperTypes);
        }
    
        public bool Interface
        {
            get => MGet<bool>(Ecore.EClass_Interface);
            set => MSet<bool>(Ecore.EClass_Interface, value);
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
    
    
        EOperation EClass.GetEOperation(int operationID) => Ecore.__CustomImpl.EClass_GetEOperation(this, operationID);
        EStructuralFeature EClass.GetEStructuralFeature(int featureID) => Ecore.__CustomImpl.EClass_GetEStructuralFeature(this, featureID);
        EStructuralFeature EClass.GetEStructuralFeature(string featureName) => Ecore.__CustomImpl.EClass_GetEStructuralFeature(this, featureName);
        int EClass.GetFeatureCount() => Ecore.__CustomImpl.EClass_GetFeatureCount(this);
        int EClass.GetFeatureID(EStructuralFeature feature) => Ecore.__CustomImpl.EClass_GetFeatureID(this, feature);
        EGenericType EClass.GetFeatureType(EStructuralFeature feature) => Ecore.__CustomImpl.EClass_GetFeatureType(this, feature);
        int EClass.GetOperationCount() => Ecore.__CustomImpl.EClass_GetOperationCount(this);
        int EClass.GetOperationID(EOperation operation) => Ecore.__CustomImpl.EClass_GetOperationID(this, operation);
        EOperation EClass.GetOverride(EOperation operation) => Ecore.__CustomImpl.EClass_GetOverride(this, operation);
        bool EClass.IsSuperTypeOf(EClass someClass) => Ecore.__CustomImpl.EClass_IsSuperTypeOf(this, someClass);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.EClassifierInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.EClassifierInfo, Ecore.ENamedElementInfo, Ecore.EModelElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_Abstract, Ecore.EClass_EAllAttributes, Ecore.EClass_EAllContainments, Ecore.EClass_EAllGenericSuperTypes, Ecore.EClass_EAllOperations, Ecore.EClass_EAllReferences, Ecore.EClass_EAllStructuralFeatures, Ecore.EClass_EAllSuperTypes, Ecore.EClass_EAttributes, Ecore.EClass_EGenericSuperTypes, Ecore.EClass_EIDAttribute, Ecore.EClass_EOperations, Ecore.EClass_EReferences, Ecore.EClass_EStructuralFeatures, Ecore.EClass_ESuperTypes, Ecore.EClass_Interface);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_Abstract, Ecore.EClass_EAllAttributes, Ecore.EClass_EAllContainments, Ecore.EClass_EAllGenericSuperTypes, Ecore.EClass_EAllOperations, Ecore.EClass_EAllReferences, Ecore.EClass_EAllStructuralFeatures, Ecore.EClass_EAllSuperTypes, Ecore.EClass_EAttributes, Ecore.EClass_EGenericSuperTypes, Ecore.EClass_EIDAttribute, Ecore.EClass_EOperations, Ecore.EClass_EReferences, Ecore.EClass_EStructuralFeatures, Ecore.EClass_ESuperTypes, Ecore.EClass_Interface, Ecore.EClassifier_DefaultValue, Ecore.EClassifier_EPackage, Ecore.EClassifier_ETypeParameters, Ecore.EClassifier_InstanceClass, Ecore.EClassifier_InstanceClassName, Ecore.EClassifier_InstanceTypeName, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_Abstract, Ecore.EClass_EAllAttributes, Ecore.EClass_EAllContainments, Ecore.EClass_EAllGenericSuperTypes, Ecore.EClass_EAllOperations, Ecore.EClass_EAllReferences, Ecore.EClass_EAllStructuralFeatures, Ecore.EClass_EAllSuperTypes, Ecore.EClass_EAttributes, Ecore.EClass_EGenericSuperTypes, Ecore.EClass_EIDAttribute, Ecore.EClass_EOperations, Ecore.EClass_EReferences, Ecore.EClass_EStructuralFeatures, Ecore.EClass_ESuperTypes, Ecore.EClass_Interface, Ecore.EClassifier_DefaultValue, Ecore.EClassifier_EPackage, Ecore.EClassifier_ETypeParameters, Ecore.EClassifier_InstanceClass, Ecore.EClassifier_InstanceClassName, Ecore.EClassifier_InstanceTypeName, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Abstract", Ecore.EClass_Abstract);
                publicPropertiesByName.Add("EAllAttributes", Ecore.EClass_EAllAttributes);
                publicPropertiesByName.Add("EAllContainments", Ecore.EClass_EAllContainments);
                publicPropertiesByName.Add("EAllGenericSuperTypes", Ecore.EClass_EAllGenericSuperTypes);
                publicPropertiesByName.Add("EAllOperations", Ecore.EClass_EAllOperations);
                publicPropertiesByName.Add("EAllReferences", Ecore.EClass_EAllReferences);
                publicPropertiesByName.Add("EAllStructuralFeatures", Ecore.EClass_EAllStructuralFeatures);
                publicPropertiesByName.Add("EAllSuperTypes", Ecore.EClass_EAllSuperTypes);
                publicPropertiesByName.Add("EAttributes", Ecore.EClass_EAttributes);
                publicPropertiesByName.Add("EGenericSuperTypes", Ecore.EClass_EGenericSuperTypes);
                publicPropertiesByName.Add("EIDAttribute", Ecore.EClass_EIDAttribute);
                publicPropertiesByName.Add("EOperations", Ecore.EClass_EOperations);
                publicPropertiesByName.Add("EReferences", Ecore.EClass_EReferences);
                publicPropertiesByName.Add("EStructuralFeatures", Ecore.EClass_EStructuralFeatures);
                publicPropertiesByName.Add("ESuperTypes", Ecore.EClass_ESuperTypes);
                publicPropertiesByName.Add("Interface", Ecore.EClass_Interface);
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
                modelPropertyInfos.Add(Ecore.EClass_Abstract, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_Abstract, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_Abstract), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAllAttributes, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAllAttributes, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAllAttributes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAllContainments, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAllContainments, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAllContainments), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAllGenericSuperTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAllGenericSuperTypes, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAllGenericSuperTypes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAllOperations, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAllOperations, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAllOperations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAllReferences, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAllReferences, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAllReferences), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAllStructuralFeatures, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAllStructuralFeatures, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAllStructuralFeatures), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAllSuperTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAllSuperTypes, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAllSuperTypes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EAttributes, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EAttributes, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EAttributes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EGenericSuperTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EGenericSuperTypes, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EGenericSuperTypes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EIDAttribute, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EIDAttribute, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EIDAttribute), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EOperations, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EOperations, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EOperations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EOperation_EContainingClass), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EReferences, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EReferences, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EReferences), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_EStructuralFeatures, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_EStructuralFeatures, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EStructuralFeatures), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_EContainingClass), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_ESuperTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_ESuperTypes, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_ESuperTypes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClass_Interface, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClass_Interface, __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_Interface), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_EPackage, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_EPackage, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_EPackage), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_EClassifiers), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_ETypeParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_ETypeParameters, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_ETypeParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_InstanceClass, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_InstanceClass, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_InstanceClass), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_InstanceClassName, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_InstanceClassName, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_InstanceClassName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EClassifier_InstanceTypeName, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EClassifier_InstanceTypeName, __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_InstanceTypeName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ENamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ENamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Ecore.ENamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EModelElement_EAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EModelElement_EAnnotations, __ImmutableArray.Create<__ModelProperty>(Ecore.EModelElement_EAnnotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EAnnotation_EModelElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EClass_GetEOperation, Ecore.EClass_GetEStructuralFeature1, Ecore.EClass_GetEStructuralFeature2, Ecore.EClass_GetFeatureCount, Ecore.EClass_GetFeatureID, Ecore.EClass_GetFeatureType, Ecore.EClass_GetOperationCount, Ecore.EClass_GetOperationID, Ecore.EClass_GetOverride, Ecore.EClass_IsSuperTypeOf);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EClass_GetEOperation, Ecore.EClass_GetEStructuralFeature1, Ecore.EClass_GetEStructuralFeature2, Ecore.EClass_GetFeatureCount, Ecore.EClass_GetFeatureID, Ecore.EClass_GetFeatureType, Ecore.EClass_GetOperationCount, Ecore.EClass_GetOperationID, Ecore.EClass_GetOverride, Ecore.EClass_IsSuperTypeOf, Ecore.EClassifier_GetClassifierID, Ecore.EClassifier_IsInstance, Ecore.EModelElement_GetEAnnotation);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EClass_GetEOperation, Ecore.EClass_GetEStructuralFeature1, Ecore.EClass_GetEStructuralFeature2, Ecore.EClass_GetFeatureCount, Ecore.EClass_GetFeatureID, Ecore.EClass_GetFeatureType, Ecore.EClass_GetOperationCount, Ecore.EClass_GetOperationID, Ecore.EClass_GetOverride, Ecore.EClass_IsSuperTypeOf, Ecore.EClassifier_GetClassifierID, Ecore.EClassifier_IsInstance, Ecore.EModelElement_GetEAnnotation);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Ecore.EClass_GetEOperation, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetEStructuralFeature1, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetEStructuralFeature2, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetFeatureCount, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetFeatureID, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetFeatureType, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetOperationCount, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetOperationID, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_GetOverride, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClass_IsSuperTypeOf, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClassifier_GetClassifierID, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EClassifier_IsInstance, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EModelElement_GetEAnnotation, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Ecore.MInstance;
            public override __MetaType MetaType => typeof(EClass);
    
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
                var result = new EClass_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Ecore.EClassInfo";
            }
        }
    }
}
