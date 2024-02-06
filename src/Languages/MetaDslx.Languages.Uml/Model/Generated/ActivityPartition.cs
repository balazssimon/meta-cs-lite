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
    /// An ActivityPartition is a kind of ActivityGroup for identifying ActivityNodes that have some characteristic in common.
    /// </summary>
    public interface ActivityPartition : global::MetaDslx.Languages.Uml.Model.ActivityGroup
    {
        /// <summary>
        /// ActivityEdges immediately contained in the ActivityPartition.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Edge { get; }
        /// <summary>
        /// Indicates whether the ActivityPartition groups other ActivityPartitions along a dimension.
        /// </summary>
        bool IsDimension { get; set; }
        /// <summary>
        /// Indicates whether the ActivityPartition represents an entity to which the partitioning structure does not apply.
        /// </summary>
        bool IsExternal { get; set; }
        /// <summary>
        /// ActivityNodes immediately contained in the ActivityPartition.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> Node { get; }
        /// <summary>
        /// An Element represented by the functionality modeled within the ActivityPartition.
        /// </summary>
        Element Represents { get; set; }
        /// <summary>
        /// Other ActivityPartitions immediately contained in this ActivityPartition (as its subgroups).
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityPartition> Subpartition { get; }
        /// <summary>
        /// Other ActivityPartitions immediately containing this ActivityPartition (as its superGroups).
        /// </summary>
        ActivityPartition SuperPartition { get; set; }
    
    }
}
