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

    public interface State : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.Vertex
    {
        global::MetaDslx.Modeling.ICollectionSlot<ConnectionPointReference> Connection { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Pseudostate> ConnectionPoint { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Trigger> DeferrableTrigger { get; }
        Behavior DoActivity { get; set; }
        Behavior Entry { get; set; }
        Behavior Exit { get; set; }
        bool IsComposite { get; }
        bool IsOrthogonal { get; }
        bool IsSimple { get; }
        bool IsSubmachineState { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Region> Region { get; }
        Constraint StateInvariant { get; set; }
        StateMachine Submachine { get; set; }
    
        StateMachine ContainingStateMachine(StateMachine result);
        bool IsConsistentWith(bool result, RedefinableElement redefiningElement);
    }
}
