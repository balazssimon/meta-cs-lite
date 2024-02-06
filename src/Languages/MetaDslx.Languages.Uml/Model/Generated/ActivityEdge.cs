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
    /// An ActivityEdge is an abstract class for directed connections between two ActivityNodes.
    /// </summary>
    public interface ActivityEdge : global::MetaDslx.Languages.Uml.Model.RedefinableElement
    {
        /// <summary>
        /// The Activity containing the ActivityEdge, if it is directly owned by an Activity.
        /// </summary>
        Activity Activity { get; set; }
        /// <summary>
        /// A ValueSpecification that is evaluated to determine if a token can traverse the ActivityEdge. If an ActivityEdge has no guard, then there is no restriction on tokens traversing the edge.
        /// </summary>
        ValueSpecification Guard { get; set; }
        /// <summary>
        /// ActivityGroups containing the ActivityEdge.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityGroup> InGroup { get; }
        /// <summary>
        /// ActivityPartitions containing the ActivityEdge.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityPartition> InPartition { get; }
        /// <summary>
        /// The StructuredActivityNode containing the ActivityEdge, if it is owned by a StructuredActivityNode.
        /// </summary>
        StructuredActivityNode InStructuredNode { get; set; }
        /// <summary>
        /// The InterruptibleActivityRegion for which this ActivityEdge is an interruptingEdge.
        /// </summary>
        InterruptibleActivityRegion Interrupts { get; set; }
        /// <summary>
        /// ActivityEdges from a generalization of the Activity containing this ActivityEdge that are redefined by this ActivityEdge.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> RedefinedEdge { get; }
        /// <summary>
        /// The ActivityNode from which tokens are taken when they traverse the ActivityEdge.
        /// </summary>
        ActivityNode Source { get; set; }
        /// <summary>
        /// The ActivityNode to which tokens are put when they traverse the ActivityEdge.
        /// </summary>
        ActivityNode Target { get; set; }
        /// <summary>
        /// The minimum number of tokens that must traverse the ActivityEdge at the same time. If no weight is specified, this is equivalent to specifying a constant value of 1.
        /// </summary>
        ValueSpecification Weight { get; set; }
    
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
    }
}
