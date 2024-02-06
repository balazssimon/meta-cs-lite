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
    /// Behavior is a specification of how its context BehavioredClassifier changes state over time. This specification may be either a definition of possible behavior execution or emergent behavior, or a selective illustration of an interesting subset of possible executions. The latter form is typically used for capturing examples, such as a trace of a particular execution.
    /// </summary>
    public interface Behavior : global::MetaDslx.Languages.Uml.Model.Class
    {
        /// <summary>
        /// The BehavioredClassifier that is the context for the execution of the Behavior. A Behavior that is directly owned as a nestedClassifier does not have a context. Otherwise, to determine the context of a Behavior, find the first BehavioredClassifier reached by following the chain of owner relationships from the Behavior, if any. If there is such a BehavioredClassifier, then it is the context, unless it is itself a Behavior with a non-empty context, in which case that is also the context for the original Behavior. For example, following this algorithm, the context of an entry Behavior in a StateMachine is the BehavioredClassifier that owns the StateMachine. The features of the context BehavioredClassifier as well as the Elements visible to the context Classifier are visible to the Behavior.
        /// </summary>
        BehavioredClassifier Context { get; }
        /// <summary>
        /// Tells whether the Behavior can be invoked while it is still executing from a previous invocation.
        /// </summary>
        bool IsReentrant { get; set; }
        /// <summary>
        /// References a list of Parameters to the Behavior which describes the order and type of arguments that can be given when the Behavior is invoked and of the values which will be returned when the Behavior completes its execution.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter { get; }
        /// <summary>
        /// The ParameterSets owned by this Behavior.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ParameterSet> OwnedParameterSet { get; }
        /// <summary>
        /// An optional set of Constraints specifying what is fulfilled after the execution of the Behavior is completed, if its precondition was fulfilled before its invocation.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Postcondition { get; }
        /// <summary>
        /// An optional set of Constraints specifying what must be fulfilled before the Behavior is invoked.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Precondition { get; }
        /// <summary>
        /// References the Behavior that this Behavior redefines. A subtype of Behavior may redefine any other subtype of Behavior. If the Behavior implements a BehavioralFeature, it replaces the redefined Behavior. If the Behavior is a classifierBehavior, it extends the redefined Behavior.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Behavior> RedefinedBehavior { get; }
        /// <summary>
        /// Designates a BehavioralFeature that the Behavior implements. The BehavioralFeature must be owned by the BehavioredClassifier that owns the Behavior or be inherited by it. The Parameters of the BehavioralFeature and the implementing Behavior must match. A Behavior does not need to have a specification, in which case it either is the classifierBehavior of a BehavioredClassifier or it can only be invoked by another Behavior of the Classifier.
        /// </summary>
        BehavioralFeature Specification { get; set; }
    
        /// <summary>
        /// The first BehavioredClassifier reached by following the chain of owner relationships from the Behavior, if any.
        /// </summary>
        /// <param name="from">
        /// </param>
        /// <returns>
        /// </returns>
        BehavioredClassifier BehavioredClassifier(Element from);
        /// <summary>
        /// The in and inout ownedParameters of the Behavior.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Parameter> InputParameters();
        /// <summary>
        /// The out, inout and return ownedParameters.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Parameter> OutputParameters();
    }
}
