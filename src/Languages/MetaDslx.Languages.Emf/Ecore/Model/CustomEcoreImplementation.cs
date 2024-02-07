using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.Ecore.Model
{
    internal class CustomEcoreImplementation : CustomEcoreImplementationBase
    {
        public override EDataType EAttribute_EAttributeType(EAttribute _this)
        {
            throw new NotImplementedException();
        }

        public override MetaSymbol EClassifier_DefaultValue(EClassifier _this)
        {
            throw new NotImplementedException();
        }

        public override int EClassifier_GetClassifierID(EClassifier _this)
        {
            throw new NotImplementedException();
        }

        public override MetaType EClassifier_InstanceClass(EClassifier _this)
        {
            throw new NotImplementedException();
        }

        public override bool EClassifier_IsInstance(EClassifier _this, MetaSymbol @object)
        {
            throw new NotImplementedException();
        }

        public override IList<EAttribute> EClass_EAllAttributes(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EReference> EClass_EAllContainments(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EGenericType> EClass_EAllGenericSuperTypes(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EOperation> EClass_EAllOperations(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EReference> EClass_EAllReferences(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EStructuralFeature> EClass_EAllStructuralFeatures(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EClass> EClass_EAllSuperTypes(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EAttribute> EClass_EAttributes(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override EAttribute EClass_EIDAttribute(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EReference> EClass_EReferences(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override EOperation EClass_GetEOperation(EClass _this, int operationID)
        {
            throw new NotImplementedException();
        }

        public override EStructuralFeature EClass_GetEStructuralFeature(EClass _this, int featureID)
        {
            throw new NotImplementedException();
        }

        public override EStructuralFeature EClass_GetEStructuralFeature(EClass _this, string featureName)
        {
            throw new NotImplementedException();
        }

        public override int EClass_GetFeatureCount(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override int EClass_GetFeatureID(EClass _this, EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public override EGenericType EClass_GetFeatureType(EClass _this, EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public override int EClass_GetOperationCount(EClass _this)
        {
            throw new NotImplementedException();
        }

        public override int EClass_GetOperationID(EClass _this, EOperation operation)
        {
            throw new NotImplementedException();
        }

        public override EOperation EClass_GetOverride(EClass _this, EOperation operation)
        {
            throw new NotImplementedException();
        }

        public override bool EClass_IsSuperTypeOf(EClass _this, EClass someClass)
        {
            throw new NotImplementedException();
        }

        public override EEnumLiteral EEnum_GetEEnumLiteral(EEnum _this, string name)
        {
            throw new NotImplementedException();
        }

        public override EEnumLiteral EEnum_GetEEnumLiteral(EEnum _this, int value)
        {
            throw new NotImplementedException();
        }

        public override EEnumLiteral EEnum_GetEEnumLiteralByLiteral(EEnum _this, string literal)
        {
            throw new NotImplementedException();
        }

        public override string EFactory_ConvertToString(EFactory _this, EDataType eDataType, MetaSymbol instanceValue)
        {
            throw new NotImplementedException();
        }

        public override EObject EFactory_Create(EFactory _this, EClass eClass)
        {
            throw new NotImplementedException();
        }

        public override MetaSymbol EFactory_CreateFromString(EFactory _this, EDataType eDataType, string literalValue)
        {
            throw new NotImplementedException();
        }

        public override EClassifier EGenericType_ERawType(EGenericType _this)
        {
            throw new NotImplementedException();
        }

        public override bool EGenericType_IsInstance(EGenericType _this, MetaSymbol @object)
        {
            throw new NotImplementedException();
        }

        public override EAnnotation EModelElement_GetEAnnotation(EModelElement _this, string source)
        {
            throw new NotImplementedException();
        }

        public override IList<EObject> EObject_EAllContents(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override EClass EObject_EClass(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override EObject EObject_EContainer(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override EStructuralFeature EObject_EContainingFeature(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override EReference EObject_EContainmentFeature(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EObject> EObject_EContents(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override IList<EObject> EObject_ECrossReferences(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override MetaSymbol EObject_EGet(EObject _this, EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public override MetaSymbol EObject_EGet(EObject _this, EStructuralFeature feature, bool resolve)
        {
            throw new NotImplementedException();
        }

        public override MetaSymbol EObject_EInvoke(EObject _this, EOperation operation, IList<object> arguments)
        {
            throw new NotImplementedException();
        }

        public override bool EObject_EIsProxy(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override bool EObject_EIsSet(EObject _this, EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public override Modeling.Model EObject_EResource(EObject _this)
        {
            throw new NotImplementedException();
        }

        public override void EObject_ESet(EObject _this, EStructuralFeature feature, MetaSymbol newValue)
        {
            throw new NotImplementedException();
        }

        public override void EObject_EUnset(EObject _this, EStructuralFeature feature)
        {
            throw new NotImplementedException();
        }

        public override int EOperation_GetOperationID(EOperation _this)
        {
            throw new NotImplementedException();
        }

        public override bool EOperation_IsOverrideOf(EOperation _this, EOperation someOperation)
        {
            throw new NotImplementedException();
        }

        public override EClassifier EPackage_GetEClassifier(EPackage _this, string name)
        {
            throw new NotImplementedException();
        }

        public override bool EReference_Container(EReference _this)
        {
            throw new NotImplementedException();
        }

        public override EClass EReference_EReferenceType(EReference _this)
        {
            throw new NotImplementedException();
        }

        public override MetaSymbol EStructuralFeature_DefaultValue(EStructuralFeature _this)
        {
            throw new NotImplementedException();
        }

        public override MetaType EStructuralFeature_GetContainerClass(EStructuralFeature _this)
        {
            throw new NotImplementedException();
        }

        public override int EStructuralFeature_GetFeatureID(EStructuralFeature _this)
        {
            throw new NotImplementedException();
        }

        public override bool ETypedElement_Many(ETypedElement _this)
        {
            throw new NotImplementedException();
        }

        public override bool ETypedElement_Required(ETypedElement _this)
        {
            throw new NotImplementedException();
        }
    }
}
