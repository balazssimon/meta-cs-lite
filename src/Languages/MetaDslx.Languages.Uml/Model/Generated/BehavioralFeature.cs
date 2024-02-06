#nullable enable

namespace MetaDslx.Languages.Uml.Model
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

    public interface BehavioralFeature : global::MetaDslx.Languages.Uml.Model.Feature, global::MetaDslx.Languages.Uml.Model.Namespace
    {
        global::MetaDslx.Languages.Uml.Model.CallConcurrencyKind Concurrency { get; set; }
        bool IsAbstract { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Behavior> Method { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter { get; }
        global::MetaDslx.Modeling.ICollectionSlot<ParameterSet> OwnedParameterSet { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Type> RaisedException { get; }
    
        bool IsDistinguishableFrom(bool result, NamedElement n, Namespace ns);
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> InputParameters(global::MetaDslx.Modeling.ICollectionSlot<Parameter> result);
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> OutputParameters(global::MetaDslx.Modeling.ICollectionSlot<Parameter> result);
    }
}
