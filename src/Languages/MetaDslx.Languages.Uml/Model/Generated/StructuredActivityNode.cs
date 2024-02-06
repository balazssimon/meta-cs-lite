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
    /// A StructuredActivityNode is an Action that is also an ActivityGroup and whose behavior is specified by the ActivityNodes and ActivityEdges it so contains. Unlike other kinds of ActivityGroup, a StructuredActivityNode owns the ActivityNodes and ActivityEdges it contains, and so a node or edge can only be directly contained in one StructuredActivityNode, though StructuredActivityNodes may be nested.
    /// </summary>
    public interface StructuredActivityNode : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.ActivityGroup, global::MetaDslx.Languages.Uml.Model.Action
    {
        /// <summary>
        /// The Activity immediately containing the StructuredActivityNode, if it is not contained in another StructuredActivityNode.
        /// </summary>
        new Activity Activity { get; set; }
        /// <summary>
        /// The ActivityEdges immediately contained in the StructuredActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Edge { get; }
        /// <summary>
        /// If true, then any object used by an Action within the StructuredActivityNode cannot be accessed by any Action outside the node until the StructuredActivityNode as a whole completes. Any concurrent Actions that would result in accessing such objects are required to have their execution deferred until the completion of the StructuredActivityNode.
        /// </summary>
        bool MustIsolate { get; set; }
        /// <summary>
        /// The ActivityNodes immediately contained in the StructuredActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> Node { get; }
        /// <summary>
        /// The InputPins owned by the StructuredActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InputPin> StructuredNodeInput { get; }
        /// <summary>
        /// The OutputPins owned by the StructuredActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> StructuredNodeOutput { get; }
        /// <summary>
        /// The Variables defined in the scope of the StructuredActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Variable> Variable { get; }
    
        /// <summary>
        /// Returns this StructuredActivityNode and all Actions contained in it.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Action> AllActions();
        /// <summary>
        /// Returns all the ActivityNodes contained directly or indirectly within this StructuredActivityNode, in addition to the Pins of the StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<ActivityNode> AllOwnedNodes();
        /// <summary>
        /// Return those ActivityNodes contained immediately within the StructuredActivityNode that may act as sources of edges owned by the StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<ActivityNode> SourceNodes();
        /// <summary>
        /// Return those ActivityNodes contained immediately within the StructuredActivityNode that may act as targets of edges owned by the StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<ActivityNode> TargetNodes();
        /// <summary>
        /// The Activity that directly or indirectly contains this StructuredActivityNode (considered as an Action).
        /// </summary>
        /// <returns>
        /// </returns>
        Activity ContainingActivity();
    }
}
