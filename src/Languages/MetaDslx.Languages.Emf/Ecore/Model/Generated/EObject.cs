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

    public interface EObject : __IModelObject
    {
    
        EClass EClass();
        bool EIsProxy();
        global::MetaDslx.Modeling.Model EResource();
        EObject EContainer();
        EStructuralFeature EContainingFeature();
        EReference EContainmentFeature();
        global::System.Collections.Generic.IList<EObject> EContents();
        global::System.Collections.Generic.IList<EObject> EAllContents();
        global::System.Collections.Generic.IList<EObject> ECrossReferences();
        __MetaSymbol EGet(EStructuralFeature feature);
        __MetaSymbol EGet(EStructuralFeature feature, bool resolve);
        void ESet(EStructuralFeature feature, __MetaSymbol newValue);
        bool EIsSet(EStructuralFeature feature);
        void EUnset(EStructuralFeature feature);
        __MetaSymbol EInvoke(EOperation operation, global::System.Collections.Generic.IList<object> arguments);
    }
}
