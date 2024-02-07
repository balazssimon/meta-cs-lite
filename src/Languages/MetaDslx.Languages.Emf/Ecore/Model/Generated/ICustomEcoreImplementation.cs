#nullable enable

namespace MetaDslx.Languages.Ecore.Model
{
    using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
    using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
    using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal interface ICustomEcoreImplementation
    {
        /// <summary>
        /// Constructor for the meta model Ecore
        /// </summary>
        void Ecore(IEcore _this);
    
        void EModelElement(EModelElement _this);
    
        void EAnnotation(EAnnotation _this);
    
        void ENamedElement(ENamedElement _this);
    
        void ETypedElement(ETypedElement _this);
    
        void EStructuralFeature(EStructuralFeature _this);
    
        void EAttribute(EAttribute _this);
    
        void EClassifier(EClassifier _this);
    
        void EClass(EClass _this);
    
        void EDataType(EDataType _this);
    
        void EEnum(EEnum _this);
    
        void EEnumLiteral(EEnumLiteral _this);
    
        void EFactory(EFactory _this);
    
        void EGenericType(EGenericType _this);
    
        void EObject(EObject _this);
    
        void EOperation(EOperation _this);
    
        void EPackage(EPackage _this);
    
        void EParameter(EParameter _this);
    
        void EReference(EReference _this);
    
        void EStringToStringMapEntry(EStringToStringMapEntry _this);
    
        void ETypeParameter(ETypeParameter _this);
    
    
        bool ETypedElement_Many(ETypedElement _this);
    
        bool ETypedElement_Required(ETypedElement _this);
    
        __MetaSymbol EStructuralFeature_DefaultValue(EStructuralFeature _this);
    
        EDataType EAttribute_EAttributeType(EAttribute _this);
    
        __MetaType EClassifier_InstanceClass(EClassifier _this);
    
        __MetaSymbol EClassifier_DefaultValue(EClassifier _this);
    
        global::System.Collections.Generic.IList<EAttribute> EClass_EAllAttributes(EClass _this);
    
        global::System.Collections.Generic.IList<EReference> EClass_EAllReferences(EClass _this);
    
        global::System.Collections.Generic.IList<EReference> EClass_EReferences(EClass _this);
    
        global::System.Collections.Generic.IList<EAttribute> EClass_EAttributes(EClass _this);
    
        global::System.Collections.Generic.IList<EReference> EClass_EAllContainments(EClass _this);
    
        global::System.Collections.Generic.IList<EOperation> EClass_EAllOperations(EClass _this);
    
        global::System.Collections.Generic.IList<EStructuralFeature> EClass_EAllStructuralFeatures(EClass _this);
    
        global::System.Collections.Generic.IList<EClass> EClass_EAllSuperTypes(EClass _this);
    
        EAttribute EClass_EIDAttribute(EClass _this);
    
        global::System.Collections.Generic.IList<EGenericType> EClass_EAllGenericSuperTypes(EClass _this);
    
        EClassifier EGenericType_ERawType(EGenericType _this);
    
        bool EReference_Container(EReference _this);
    
        EClass EReference_EReferenceType(EReference _this);
    
    
        EAnnotation EModelElement_GetEAnnotation(EModelElement _this, string source);
    
        int EStructuralFeature_GetFeatureID(EStructuralFeature _this);
    
        __MetaType EStructuralFeature_GetContainerClass(EStructuralFeature _this);
    
        bool EClassifier_IsInstance(EClassifier _this, __MetaSymbol @object);
    
        int EClassifier_GetClassifierID(EClassifier _this);
    
        bool EClass_IsSuperTypeOf(EClass _this, EClass someClass);
    
        int EClass_GetFeatureCount(EClass _this);
    
        EStructuralFeature EClass_GetEStructuralFeature(EClass _this, int featureID);
    
        int EClass_GetFeatureID(EClass _this, EStructuralFeature feature);
    
        EStructuralFeature EClass_GetEStructuralFeature(EClass _this, string featureName);
    
        int EClass_GetOperationCount(EClass _this);
    
        EOperation EClass_GetEOperation(EClass _this, int operationID);
    
        int EClass_GetOperationID(EClass _this, EOperation operation);
    
        EOperation EClass_GetOverride(EClass _this, EOperation operation);
    
        EGenericType EClass_GetFeatureType(EClass _this, EStructuralFeature feature);
    
        EEnumLiteral EEnum_GetEEnumLiteral(EEnum _this, string name);
    
        EEnumLiteral EEnum_GetEEnumLiteral(EEnum _this, int value);
    
        EEnumLiteral EEnum_GetEEnumLiteralByLiteral(EEnum _this, string literal);
    
        EObject EFactory_Create(EFactory _this, EClass eClass);
    
        __MetaSymbol EFactory_CreateFromString(EFactory _this, EDataType eDataType, string literalValue);
    
        string EFactory_ConvertToString(EFactory _this, EDataType eDataType, __MetaSymbol instanceValue);
    
        bool EGenericType_IsInstance(EGenericType _this, __MetaSymbol @object);
    
        EClass EObject_EClass(EObject _this);
    
        bool EObject_EIsProxy(EObject _this);
    
        global::MetaDslx.Modeling.Model EObject_EResource(EObject _this);
    
        EObject EObject_EContainer(EObject _this);
    
        EStructuralFeature EObject_EContainingFeature(EObject _this);
    
        EReference EObject_EContainmentFeature(EObject _this);
    
        global::System.Collections.Generic.IList<EObject> EObject_EContents(EObject _this);
    
        global::System.Collections.Generic.IList<EObject> EObject_EAllContents(EObject _this);
    
        global::System.Collections.Generic.IList<EObject> EObject_ECrossReferences(EObject _this);
    
        __MetaSymbol EObject_EGet(EObject _this, EStructuralFeature feature);
    
        __MetaSymbol EObject_EGet(EObject _this, EStructuralFeature feature, bool resolve);
    
        void EObject_ESet(EObject _this, EStructuralFeature feature, __MetaSymbol newValue);
    
        bool EObject_EIsSet(EObject _this, EStructuralFeature feature);
    
        void EObject_EUnset(EObject _this, EStructuralFeature feature);
    
        __MetaSymbol EObject_EInvoke(EObject _this, EOperation operation, global::System.Collections.Generic.IList<object> arguments);
    
        int EOperation_GetOperationID(EOperation _this);
    
        bool EOperation_IsOverrideOf(EOperation _this, EOperation someOperation);
    
        EClassifier EPackage_GetEClassifier(EPackage _this, string name);
    
    }
}
