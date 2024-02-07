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

    internal abstract class CustomEcoreImplementationBase : ICustomEcoreImplementation
    {
        /// <summary>
        /// Constructor for the meta model Ecore
        /// </summary>
        public virtual void Ecore(IEcore _this)
        {
        }
    
        public virtual void EModelElement(EModelElement _this)
        {
        }
    
        public virtual void EAnnotation(EAnnotation _this)
        {
        }
    
        public virtual void ENamedElement(ENamedElement _this)
        {
        }
    
        public virtual void ETypedElement(ETypedElement _this)
        {
        }
    
        public virtual void EStructuralFeature(EStructuralFeature _this)
        {
        }
    
        public virtual void EAttribute(EAttribute _this)
        {
        }
    
        public virtual void EClassifier(EClassifier _this)
        {
        }
    
        public virtual void EClass(EClass _this)
        {
        }
    
        public virtual void EDataType(EDataType _this)
        {
        }
    
        public virtual void EEnum(EEnum _this)
        {
        }
    
        public virtual void EEnumLiteral(EEnumLiteral _this)
        {
        }
    
        public virtual void EFactory(EFactory _this)
        {
        }
    
        public virtual void EGenericType(EGenericType _this)
        {
        }
    
        public virtual void EObject(EObject _this)
        {
        }
    
        public virtual void EOperation(EOperation _this)
        {
        }
    
        public virtual void EPackage(EPackage _this)
        {
        }
    
        public virtual void EParameter(EParameter _this)
        {
        }
    
        public virtual void EReference(EReference _this)
        {
        }
    
        public virtual void EStringToStringMapEntry(EStringToStringMapEntry _this)
        {
        }
    
        public virtual void ETypeParameter(ETypeParameter _this)
        {
        }
    
    
        public abstract bool ETypedElement_Many(ETypedElement _this);
    
        public abstract bool ETypedElement_Required(ETypedElement _this);
    
        public abstract __MetaSymbol EStructuralFeature_DefaultValue(EStructuralFeature _this);
    
        public abstract EDataType EAttribute_EAttributeType(EAttribute _this);
    
        public abstract __MetaType EClassifier_InstanceClass(EClassifier _this);
    
        public abstract __MetaSymbol EClassifier_DefaultValue(EClassifier _this);
    
        public abstract global::System.Collections.Generic.IList<EAttribute> EClass_EAllAttributes(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EReference> EClass_EAllReferences(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EReference> EClass_EReferences(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EAttribute> EClass_EAttributes(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EReference> EClass_EAllContainments(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EOperation> EClass_EAllOperations(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EStructuralFeature> EClass_EAllStructuralFeatures(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EClass> EClass_EAllSuperTypes(EClass _this);
    
        public abstract EAttribute EClass_EIDAttribute(EClass _this);
    
        public abstract global::System.Collections.Generic.IList<EGenericType> EClass_EAllGenericSuperTypes(EClass _this);
    
        public abstract EClassifier EGenericType_ERawType(EGenericType _this);
    
        public abstract bool EReference_Container(EReference _this);
    
        public abstract EClass EReference_EReferenceType(EReference _this);
    
    
        public abstract EAnnotation EModelElement_GetEAnnotation(EModelElement _this, string source);
    
        public abstract int EStructuralFeature_GetFeatureID(EStructuralFeature _this);
    
        public abstract __MetaType EStructuralFeature_GetContainerClass(EStructuralFeature _this);
    
        public abstract bool EClassifier_IsInstance(EClassifier _this, __MetaSymbol @object);
    
        public abstract int EClassifier_GetClassifierID(EClassifier _this);
    
        public abstract bool EClass_IsSuperTypeOf(EClass _this, EClass someClass);
    
        public abstract int EClass_GetFeatureCount(EClass _this);
    
        public abstract EStructuralFeature EClass_GetEStructuralFeature(EClass _this, int featureID);
    
        public abstract int EClass_GetFeatureID(EClass _this, EStructuralFeature feature);
    
        public abstract EStructuralFeature EClass_GetEStructuralFeature(EClass _this, string featureName);
    
        public abstract int EClass_GetOperationCount(EClass _this);
    
        public abstract EOperation EClass_GetEOperation(EClass _this, int operationID);
    
        public abstract int EClass_GetOperationID(EClass _this, EOperation operation);
    
        public abstract EOperation EClass_GetOverride(EClass _this, EOperation operation);
    
        public abstract EGenericType EClass_GetFeatureType(EClass _this, EStructuralFeature feature);
    
        public abstract EEnumLiteral EEnum_GetEEnumLiteral(EEnum _this, string name);
    
        public abstract EEnumLiteral EEnum_GetEEnumLiteral(EEnum _this, int value);
    
        public abstract EEnumLiteral EEnum_GetEEnumLiteralByLiteral(EEnum _this, string literal);
    
        public abstract EObject EFactory_Create(EFactory _this, EClass eClass);
    
        public abstract __MetaSymbol EFactory_CreateFromString(EFactory _this, EDataType eDataType, string literalValue);
    
        public abstract string EFactory_ConvertToString(EFactory _this, EDataType eDataType, __MetaSymbol instanceValue);
    
        public abstract bool EGenericType_IsInstance(EGenericType _this, __MetaSymbol @object);
    
        public abstract EClass EObject_EClass(EObject _this);
    
        public abstract bool EObject_EIsProxy(EObject _this);
    
        public abstract global::MetaDslx.Modeling.Model EObject_EResource(EObject _this);
    
        public abstract EObject EObject_EContainer(EObject _this);
    
        public abstract EStructuralFeature EObject_EContainingFeature(EObject _this);
    
        public abstract EReference EObject_EContainmentFeature(EObject _this);
    
        public abstract global::System.Collections.Generic.IList<EObject> EObject_EContents(EObject _this);
    
        public abstract global::System.Collections.Generic.IList<EObject> EObject_EAllContents(EObject _this);
    
        public abstract global::System.Collections.Generic.IList<EObject> EObject_ECrossReferences(EObject _this);
    
        public abstract __MetaSymbol EObject_EGet(EObject _this, EStructuralFeature feature);
    
        public abstract __MetaSymbol EObject_EGet(EObject _this, EStructuralFeature feature, bool resolve);
    
        public abstract void EObject_ESet(EObject _this, EStructuralFeature feature, __MetaSymbol newValue);
    
        public abstract bool EObject_EIsSet(EObject _this, EStructuralFeature feature);
    
        public abstract void EObject_EUnset(EObject _this, EStructuralFeature feature);
    
        public abstract __MetaSymbol EObject_EInvoke(EObject _this, EOperation operation, global::System.Collections.Generic.IList<object> arguments);
    
        public abstract int EOperation_GetOperationID(EOperation _this);
    
        public abstract bool EOperation_IsOverrideOf(EOperation _this, EOperation someOperation);
    
        public abstract EClassifier EPackage_GetEClassifier(EPackage _this, string name);
    
    }
}
