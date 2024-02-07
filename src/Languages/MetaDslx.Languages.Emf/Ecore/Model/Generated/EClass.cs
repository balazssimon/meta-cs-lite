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

    public interface EClass : global::MetaDslx.Languages.Ecore.Model.EClassifier
    {
        bool Abstract { get; set; }
        global::System.Collections.Generic.IList<EAttribute> EAllAttributes { get; }
        global::System.Collections.Generic.IList<EReference> EAllContainments { get; }
        global::System.Collections.Generic.IList<EGenericType> EAllGenericSuperTypes { get; }
        global::System.Collections.Generic.IList<EOperation> EAllOperations { get; }
        global::System.Collections.Generic.IList<EReference> EAllReferences { get; }
        global::System.Collections.Generic.IList<EStructuralFeature> EAllStructuralFeatures { get; }
        global::System.Collections.Generic.IList<EClass> EAllSuperTypes { get; }
        global::System.Collections.Generic.IList<EAttribute> EAttributes { get; }
        global::MetaDslx.Modeling.ICollectionSlot<EGenericType> EGenericSuperTypes { get; }
        EAttribute EIDAttribute { get; }
        global::MetaDslx.Modeling.ICollectionSlot<EOperation> EOperations { get; }
        global::System.Collections.Generic.IList<EReference> EReferences { get; }
        global::MetaDslx.Modeling.ICollectionSlot<EStructuralFeature> EStructuralFeatures { get; }
        global::MetaDslx.Modeling.ICollectionSlot<EClass> ESuperTypes { get; }
        bool Interface { get; set; }
    
        bool IsSuperTypeOf(EClass someClass);
        int GetFeatureCount();
        EStructuralFeature GetEStructuralFeature(int featureID);
        int GetFeatureID(EStructuralFeature feature);
        EStructuralFeature GetEStructuralFeature(string featureName);
        int GetOperationCount();
        EOperation GetEOperation(int operationID);
        int GetOperationID(EOperation operation);
        EOperation GetOverride(EOperation operation);
        EGenericType GetFeatureType(EStructuralFeature feature);
    }
}
