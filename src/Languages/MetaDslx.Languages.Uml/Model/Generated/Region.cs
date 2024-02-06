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
    /// A Region is a top-level part of a StateMachine or a composite State, that serves as a container for the Vertices and Transitions of the StateMachine. A StateMachine or composite State may contain multiple Regions representing behaviors that may occur in parallel.
    /// </summary>
    public interface Region : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.RedefinableElement
    {
        /// <summary>
        /// The region of which this region is an extension.
        /// </summary>
        Region ExtendedRegion { get; set; }
        /// <summary>
        /// References the Classifier in which context this element may be redefined.
        /// </summary>
        new Classifier RedefinitionContext { get; }
        /// <summary>
        /// The State that owns the Region. If a Region is owned by a State, then it cannot also be owned by a StateMachine.
        /// </summary>
        State State { get; set; }
        /// <summary>
        /// The StateMachine that owns the Region. If a Region is owned by a StateMachine, then it cannot also be owned by a State.
        /// </summary>
        StateMachine StateMachine { get; set; }
        /// <summary>
        /// The set of Vertices that are owned by this Region.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Vertex> Subvertex { get; }
        /// <summary>
        /// The set of Transitions owned by the Region.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Transition> Transition { get; }
    
        /// <summary>
        /// The operation belongsToPSM () checks if the Region belongs to a ProtocolStateMachine.
        /// </summary>
        /// <returns>
        /// </returns>
        bool BelongsToPSM();
        /// <summary>
        /// The operation containingStateMachine() returns the StateMachine in which this Region is defined.
        /// </summary>
        /// <returns>
        /// </returns>
        StateMachine ContainingStateMachine();
        /// <summary>
        /// The query isConsistentWith specifies that a Region can be redefined by any Region for which the redefinition context is valid (see the isRedefinitionContextValid operation). Note that consistency requirements for the redefinition of Vertices and Transitions within a redefining Region are specified by the isConsistentWith and isRedefinitionContextValid operations for Vertex (and its subclasses) and Transition.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
        /// <summary>
        /// The query isRedefinitionContextValid() specifies whether the redefinition contexts of a Region are properly related to the redefinition contexts of the specified Region to allow this element to redefine the other. The containing StateMachine or State of a redefining Region must Redefine the containing StateMachine or State of the redefined Region.
        /// </summary>
        /// <param name="redefinedElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsRedefinitionContextValid(RedefinableElement redefinedElement);
    }
}
