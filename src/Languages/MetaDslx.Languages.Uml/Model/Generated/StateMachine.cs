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
    /// StateMachines can be used to express event-driven behaviors of parts of a system. Behavior is modeled as a traversal of a graph of Vertices interconnected by one or more joined Transition arcs that are triggered by the dispatching of successive Event occurrences. During this traversal, the StateMachine may execute a sequence of Behaviors associated with various elements of the StateMachine.
    /// </summary>
    public interface StateMachine : global::MetaDslx.Languages.Uml.Model.Behavior
    {
        /// <summary>
        /// The connection points defined for this StateMachine. They represent the interface of the StateMachine when used as part of submachine State
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Pseudostate> ConnectionPoint { get; }
        /// <summary>
        /// The StateMachines of which this is an extension.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<StateMachine> ExtendedStateMachine { get; }
        /// <summary>
        /// The Regions owned directly by the StateMachine.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Region> Region { get; }
        /// <summary>
        /// References the submachine(s) in case of a submachine State. Multiple machines are referenced in case of a concurrent State.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<State> SubmachineState { get; }
    
        /// <summary>
        /// The operation LCA(s1,s2) returns the Region that is the least common ancestor of Vertices s1 and s2, based on the StateMachine containment hierarchy.
        /// </summary>
        /// <param name="s1">
        /// </param>
        /// <param name="s2">
        /// </param>
        /// <returns>
        /// </returns>
        Region LCA(Vertex s1, Vertex s2);
        /// <summary>
        /// The query ancestor(s1, s2) checks whether Vertex s2 is an ancestor of Vertex s1.
        /// </summary>
        /// <param name="s1">
        /// </param>
        /// <param name="s2">
        /// </param>
        /// <returns>
        /// </returns>
        bool Ancestor(Vertex s1, Vertex s2);
        /// <summary>
        /// The query isConsistentWith specifies that a StateMachine can be redefined by any other StateMachine for which the redefinition context is valid (see the isRedefinitionContextValid operation). Note that consistency requirements for the redefinition of Regions and connectionPoint Pseudostates owned by a StateMachine are specified by the isConsistentWith and isRedefinitionContextValid operations for Region and Vertex (and its subclass Pseudostate).
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
        /// <summary>
        /// The query isRedefinitionContextValid specifies whether the redefinition context of a StateMachine is properly related to the redefinition contexts of a StateMachine it redefines. The requirement is that the context BehavioredClassifier of a redefining StateMachine must specialize the context Classifier of the redefined StateMachine. If the redefining StateMachine does not have a context BehavioredClassifier, then then the redefining StateMachine also must not have a context BehavioredClassifier but must, instead, specialize the redefining StateMachine.
        /// </summary>
        /// <param name="redefinedElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsRedefinitionContextValid(RedefinableElement redefinedElement);
        /// <summary>
        /// This utility funciton is like the LCA, except that it returns the nearest composite State that contains both input Vertices.
        /// </summary>
        /// <param name="v1">
        /// </param>
        /// <param name="v2">
        /// </param>
        /// <returns>
        /// </returns>
        State LCAState(Vertex v1, Vertex v2);
    }
}
