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
    /// A Vertex is an abstraction of a node in a StateMachine graph. It can be the source or destination of any number of Transitions.
    /// </summary>
    public interface Vertex : global::MetaDslx.Languages.Uml.Model.NamedElement, global::MetaDslx.Languages.Uml.Model.RedefinableElement
    {
        /// <summary>
        /// The Region that contains this Vertex.
        /// </summary>
        Region Container { get; set; }
        /// <summary>
        /// Specifies the Transitions entering this Vertex.
        /// </summary>
        global::System.Collections.Generic.IList<Transition> Incoming { get; }
        /// <summary>
        /// Specifies the Transitions departing from this Vertex.
        /// </summary>
        global::System.Collections.Generic.IList<Transition> Outgoing { get; }
        /// <summary>
        /// The Vertex of which this Vertex is a redefinition.
        /// </summary>
        Vertex RedefinedVertex { get; set; }
        /// <summary>
        /// References the Classifier in which context this element may be redefined.
        /// </summary>
        new Classifier RedefinitionContext { get; }
    
        /// <summary>
        /// The operation containingStateMachine() returns the StateMachine in which this Vertex is defined.
        /// </summary>
        /// <returns>
        /// </returns>
        StateMachine ContainingStateMachine();
        /// <summary>
        /// This utility operation returns true if the Vertex is contained in the State s (input argument).
        /// </summary>
        /// <param name="s">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsContainedInState(State s);
        /// <summary>
        /// This utility query returns true if the Vertex is contained in the Region r (input argument).
        /// </summary>
        /// <param name="r">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsContainedInRegion(Region r);
        /// <summary>
        /// The query isRedefinitionContextValid specifies that the redefinition context of a redefining Vertex is properly related to the redefinition context of the redefined Vertex if the owner of the redefining Vertex is a redefinition of the owner of the redefined Vertex. Note that the owner of a Vertex may be a Region, a StateMachine (for a connectionPoint Pseudostate), or a State (for a connectionPoint Pseudostate or a connection ConnectionPointReference), all of which are RedefinableElements.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
    }
}
