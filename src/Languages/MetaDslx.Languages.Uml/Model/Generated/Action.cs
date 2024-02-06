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

    /// <summary>
    /// An Action is the fundamental unit of executable functionality. The execution of an Action represents some transformation or processing in the modeled system. Actions provide the ExecutableNodes within Activities and may also be used within Interactions.
    /// </summary>
    public interface Action : global::MetaDslx.Languages.Uml.Model.ExecutableNode
    {
        /// <summary>
        /// The context Classifier of the Behavior that contains this Action, or the Behavior itself if it has no context.
        /// </summary>
        Classifier Context { get; }
        /// <summary>
        /// The ordered set of InputPins representing the inputs to the Action.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InputPin> Input { get; }
        /// <summary>
        /// If true, the Action can begin a new, concurrent execution, even if there is already another execution of the Action ongoing. If false, the Action cannot begin a new execution until any previous execution has completed.
        /// </summary>
        bool IsLocallyReentrant { get; set; }
        /// <summary>
        /// A Constraint that must be satisfied when execution of the Action is completed.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> LocalPostcondition { get; }
        /// <summary>
        /// A Constraint that must be satisfied when execution of the Action is started.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> LocalPrecondition { get; }
        /// <summary>
        /// The ordered set of OutputPins representing outputs from the Action.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> Output { get; }
    
        /// <summary>
        /// Return this Action and all Actions contained directly or indirectly in it. By default only the Action itself is returned, but the operation is overridden for StructuredActivityNodes.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Action> AllActions();
        /// <summary>
        /// Returns all the ActivityNodes directly or indirectly owned by this Action. This includes at least all the Pins of the Action.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<ActivityNode> AllOwnedNodes();
        /// <returns>
        /// </returns>
        Behavior ContainingBehavior();
    }
}
