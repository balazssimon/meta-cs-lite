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
    /// A Transition represents an arc between exactly one source Vertex and exactly one Target vertex (the source and targets may be the same Vertex). It may form part of a compound transition, which takes the StateMachine from one steady State configuration to another, representing the full response of the StateMachine to an occurrence of an Event that triggered it.
    /// </summary>
    public interface Transition : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.RedefinableElement
    {
        /// <summary>
        /// Designates the Region that owns this Transition.
        /// </summary>
        Region Container { get; set; }
        /// <summary>
        /// Specifies an optional behavior to be performed when the Transition fires.
        /// </summary>
        Behavior Effect { get; set; }
        /// <summary>
        /// A guard is a Constraint that provides a fine-grained control over the firing of the Transition. The guard is evaluated when an Event occurrence is dispatched by the StateMachine. If the guard is true at that time, the Transition may be enabled, otherwise, it is disabled. Guards should be pure expressions without side effects. Guard expressions with side effects are ill formed.
        /// </summary>
        Constraint Guard { get; set; }
        /// <summary>
        /// Indicates the precise type of the Transition.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.TransitionKind Kind { get; set; }
        /// <summary>
        /// The Transition that is redefined by this Transition.
        /// </summary>
        Transition RedefinedTransition { get; set; }
        /// <summary>
        /// References the Classifier in which context this element may be redefined.
        /// </summary>
        new Classifier RedefinitionContext { get; }
        /// <summary>
        /// Designates the originating Vertex (State or Pseudostate) of the Transition.
        /// </summary>
        Vertex Source { get; set; }
        /// <summary>
        /// Designates the target Vertex that is reached when the Transition is taken.
        /// </summary>
        Vertex Target { get; set; }
        /// <summary>
        /// Specifies the Triggers that may fire the transition.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Trigger> Trigger { get; }
    
        /// <summary>
        /// The query containingStateMachine() returns the StateMachine that contains the Transition either directly or transitively.
        /// </summary>
        /// <returns>
        /// </returns>
        StateMachine ContainingStateMachine();
        /// <summary>
        /// The query isConsistentWith specifies that a redefining Transition is consistent with a redefined Transition provided that the source Vertex of the redefining Transition redefines the source Vertex of the redefined Transition.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
    }
}
