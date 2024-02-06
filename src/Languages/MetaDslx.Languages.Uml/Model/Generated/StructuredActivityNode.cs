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

    public interface StructuredActivityNode : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.ActivityGroup, global::MetaDslx.Languages.Uml.Model.Action
    {
        new Activity Activity { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Edge { get; }
        bool MustIsolate { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> Node { get; }
        global::MetaDslx.Modeling.ICollectionSlot<InputPin> StructuredNodeInput { get; }
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> StructuredNodeOutput { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Variable> Variable { get; }
    
        global::MetaDslx.Modeling.ICollectionSlot<Action> AllActions(global::MetaDslx.Modeling.ICollectionSlot<Action> result);
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> AllOwnedNodes(global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> result);
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> SourceNodes(global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> result);
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> TargetNodes(global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> result);
        Activity ContainingActivity(Activity result);
    }
}
