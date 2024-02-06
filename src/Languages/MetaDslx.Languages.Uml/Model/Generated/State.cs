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
    /// A State models a situation during which some (usually implicit) invariant condition holds.
    /// </summary>
    public interface State : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.Vertex
    {
        /// <summary>
        /// The entry and exit connection points used in conjunction with this (submachine) State, i.e., as targets and sources, respectively, in the Region with the submachine State. A connection point reference references the corresponding definition of a connection point Pseudostate in the StateMachine referenced by the submachine State.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ConnectionPointReference> Connection { get; }
        /// <summary>
        /// The entry and exit Pseudostates of a composite State. These can only be entry or exit Pseudostates, and they must have different names. They can only be defined for composite States.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Pseudostate> ConnectionPoint { get; }
        /// <summary>
        /// A list of Triggers that are candidates to be retained by the StateMachine if they trigger no Transitions out of the State (not consumed). A deferred Trigger is retained until the StateMachine reaches a State configuration where it is no longer deferred.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Trigger> DeferrableTrigger { get; }
        /// <summary>
        /// An optional Behavior that is executed while being in the State. The execution starts when this State is entered, and ceases either by itself when done, or when the State is exited, whichever comes first.
        /// </summary>
        Behavior DoActivity { get; set; }
        /// <summary>
        /// An optional Behavior that is executed whenever this State is entered regardless of the Transition taken to reach the State. If defined, entry Behaviors are always executed to completion prior to any internal Behavior or Transitions performed within the State.
        /// </summary>
        Behavior Entry { get; set; }
        /// <summary>
        /// An optional Behavior that is executed whenever this State is exited regardless of which Transition was taken out of the State. If defined, exit Behaviors are always executed to completion only after all internal and transition Behaviors have completed execution.
        /// </summary>
        Behavior Exit { get; set; }
        /// <summary>
        /// A state with isComposite=true is said to be a composite State. A composite State is a State that contains at least one Region.
        /// </summary>
        bool IsComposite { get; }
        /// <summary>
        /// A State with isOrthogonal=true is said to be an orthogonal composite State An orthogonal composite State contains two or more Regions.
        /// </summary>
        bool IsOrthogonal { get; }
        /// <summary>
        /// A State with isSimple=true is said to be a simple State A simple State does not have any Regions and it does not refer to any submachine StateMachine.
        /// </summary>
        bool IsSimple { get; }
        /// <summary>
        /// A State with isSubmachineState=true is said to be a submachine State Such a State refers to another StateMachine(submachine).
        /// </summary>
        bool IsSubmachineState { get; }
        /// <summary>
        /// The Regions owned directly by the State.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Region> Region { get; }
        /// <summary>
        /// Specifies conditions that are always true when this State is the current State. In ProtocolStateMachines state invariants are additional conditions to the preconditions of the outgoing Transitions, and to the postcondition of the incoming Transitions.
        /// </summary>
        Constraint StateInvariant { get; set; }
        /// <summary>
        /// The StateMachine that is to be inserted in place of the (submachine) State.
        /// </summary>
        StateMachine Submachine { get; set; }
    
        /// <summary>
        /// The query containingStateMachine() returns the StateMachine that contains the State either directly or transitively.
        /// </summary>
        /// <returns>
        /// </returns>
        StateMachine ContainingStateMachine();
        /// <summary>
        /// The query isConsistentWith specifies that a non-final State can only be redefined by a non-final State (this is overridden by FinalState to allow a FinalState to be redefined by a FinalState) and, if the redefined State is a submachine State, then the redefining State must be a submachine state whose submachine is a redefinition of the submachine of the redefined State. Note that consistency requirements for the redefinition of Regions and connectionPoint Pseudostates within a composite State and connection ConnectionPoints of a submachine State are specified by the isConsistentWith and isRedefinitionContextValid operations for Region and Vertex (and its subclasses, Pseudostate and ConnectionPointReference).
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
    }
}
