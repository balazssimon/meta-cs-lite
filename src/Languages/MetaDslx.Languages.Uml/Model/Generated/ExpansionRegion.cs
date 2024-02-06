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
    /// An ExpansionRegion is a StructuredActivityNode that executes its content multiple times corresponding to elements of input collection(s).
    /// </summary>
    public interface ExpansionRegion : global::MetaDslx.Languages.Uml.Model.StructuredActivityNode
    {
        /// <summary>
        /// The ExpansionNodes that hold the input collections for the ExpansionRegion.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExpansionNode> InputElement { get; }
        /// <summary>
        /// The mode in which the ExpansionRegion executes its contents. If parallel, executions are concurrent. If iterative, executions are sequential. If stream, a stream of values flows into a single execution.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.ExpansionKind Mode { get; set; }
        /// <summary>
        /// The ExpansionNodes that form the output collections of the ExpansionRegion.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExpansionNode> OutputElement { get; }
    
    }
}
