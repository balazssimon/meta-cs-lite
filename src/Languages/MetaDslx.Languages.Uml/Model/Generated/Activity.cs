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
    /// An Activity is the specification of parameterized Behavior as the coordinated sequencing of subordinate units.
    /// </summary>
    public interface Activity : global::MetaDslx.Languages.Uml.Model.Behavior
    {
        /// <summary>
        /// ActivityEdges expressing flow between the nodes of the Activity.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Edge { get; }
        /// <summary>
        /// Top-level ActivityGroups in the Activity.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityGroup> Group { get; }
        /// <summary>
        /// If true, this Activity must not make any changes to objects. The default is false (an Activity may make nonlocal changes). (This is an assertion, not an executable property. It may be used by an execution engine to optimize model execution. If the assertion is violated by the Activity, then the model is ill-formed.)
        /// </summary>
        bool IsReadOnly { get; set; }
        /// <summary>
        /// If true, all invocations of the Activity are handled by the same execution.
        /// </summary>
        bool IsSingleExecution { get; set; }
        /// <summary>
        /// ActivityNodes coordinated by the Activity.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> Node { get; }
        /// <summary>
        /// Top-level ActivityPartitions in the Activity.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityPartition> Partition { get; }
        /// <summary>
        /// Top-level StructuredActivityNodes in the Activity.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<StructuredActivityNode> StructuredNode { get; }
        /// <summary>
        /// Top-level Variables defined by the Activity.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Variable> Variable { get; }
    
    }
}
