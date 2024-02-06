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
    /// An ObjectNode is an abstract ActivityNode that may hold tokens within the object flow in an Activity. ObjectNodes also support token selection, limitation on the number of tokens held, specification of the state required for tokens being held, and carrying control values.
    /// </summary>
    public interface ObjectNode : global::MetaDslx.Languages.Uml.Model.TypedElement, global::MetaDslx.Languages.Uml.Model.ActivityNode
    {
        /// <summary>
        /// The States required to be associated with the values held by tokens on this ObjectNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<State> InState { get; }
        /// <summary>
        /// Indicates whether the type of the ObjectNode is to be treated as representing control values that may traverse ControlFlows.
        /// </summary>
        bool IsControlType { get; set; }
        /// <summary>
        /// Indicates how the tokens held by the ObjectNode are ordered for selection to traverse ActivityEdges outgoing from the ObjectNode.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.ObjectNodeOrderingKind Ordering { get; set; }
        /// <summary>
        /// A Behavior used to select tokens to be offered on outgoing ActivityEdges.
        /// </summary>
        Behavior Selection { get; set; }
        /// <summary>
        /// The maximum number of tokens that may be held by this ObjectNode. Tokens cannot flow into the ObjectNode if the upperBound is reached. If no upperBound is specified, then there is no limit on how many tokens the ObjectNode can hold.
        /// </summary>
        ValueSpecification UpperBound { get; set; }
    
    }
}
