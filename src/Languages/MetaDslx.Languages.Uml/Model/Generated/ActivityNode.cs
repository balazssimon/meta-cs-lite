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
    /// ActivityNode is an abstract class for points in the flow of an Activity connected by ActivityEdges.
    /// </summary>
    public interface ActivityNode : global::MetaDslx.Languages.Uml.Model.RedefinableElement
    {
        /// <summary>
        /// The Activity containing the ActivityNode, if it is directly owned by an Activity.
        /// </summary>
        Activity Activity { get; set; }
        /// <summary>
        /// ActivityEdges that have the ActivityNode as their target.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Incoming { get; }
        /// <summary>
        /// ActivityGroups containing the ActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityGroup> InGroup { get; }
        /// <summary>
        /// InterruptibleActivityRegions containing the ActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InterruptibleActivityRegion> InInterruptibleRegion { get; }
        /// <summary>
        /// ActivityPartitions containing the ActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityPartition> InPartition { get; }
        /// <summary>
        /// The StructuredActivityNode containing the ActvityNode, if it is directly owned by a StructuredActivityNode.
        /// </summary>
        StructuredActivityNode InStructuredNode { get; set; }
        /// <summary>
        /// ActivityEdges that have the ActivityNode as their source.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Outgoing { get; }
        /// <summary>
        /// ActivityNodes from a generalization of the Activity containining this ActivityNode that are redefined by this ActivityNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> RedefinedNode { get; }
    
        /// <summary>
        /// The Activity that directly or indirectly contains this ActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        Activity ContainingActivity();
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
    }
}
