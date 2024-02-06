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
    /// ActivityGroup is an abstract class for defining sets of ActivityNodes and ActivityEdges in an Activity.
    /// </summary>
    public interface ActivityGroup : global::MetaDslx.Languages.Uml.Model.NamedElement
    {
        /// <summary>
        /// ActivityEdges immediately contained in the ActivityGroup.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> ContainedEdge { get; }
        /// <summary>
        /// ActivityNodes immediately contained in the ActivityGroup.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> ContainedNode { get; }
        /// <summary>
        /// The Activity containing the ActivityGroup, if it is directly owned by an Activity.
        /// </summary>
        Activity InActivity { get; set; }
        /// <summary>
        /// Other ActivityGroups immediately contained in this ActivityGroup.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityGroup> Subgroup { get; }
        /// <summary>
        /// The ActivityGroup immediately containing this ActivityGroup, if it is directly owned by another ActivityGroup.
        /// </summary>
        ActivityGroup SuperGroup { get; set; }
    
        /// <summary>
        /// The Activity that directly or indirectly contains this ActivityGroup.
        /// </summary>
        /// <returns>
        /// </returns>
        Activity ContainingActivity();
    }
}
