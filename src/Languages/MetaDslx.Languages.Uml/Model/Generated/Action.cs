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

    public interface Action : global::MetaDslx.Languages.Uml.Model.ExecutableNode
    {
        Classifier Context { get; }
        global::MetaDslx.Modeling.ICollectionSlot<InputPin> Input { get; }
        bool IsLocallyReentrant { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> LocalPostcondition { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> LocalPrecondition { get; }
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> Output { get; }
    
        global::MetaDslx.Modeling.ICollectionSlot<Action> AllActions(global::MetaDslx.Modeling.ICollectionSlot<Action> result);
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> AllOwnedNodes(global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> result);
        Behavior ContainingBehavior(Behavior result);
    }
}
