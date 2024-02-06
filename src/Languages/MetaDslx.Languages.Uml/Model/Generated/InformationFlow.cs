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
    /// InformationFlows describe circulation of information through a system in a general manner. They do not specify the nature of the information, mechanisms by which it is conveyed, sequences of exchange or any control conditions. During more detailed modeling, representation and realization links may be added to specify which model elements implement an InformationFlow and to show how information is conveyed.  InformationFlows require some kind of “information channel” for unidirectional transmission of information items from sources to targets.  They specify the information channel’s realizations, if any, and identify the information that flows along them.  Information moving along the information channel may be represented by abstract InformationItems and by concrete Classifiers.
    /// </summary>
    public interface InformationFlow : global::MetaDslx.Languages.Uml.Model.DirectedRelationship, global::MetaDslx.Languages.Uml.Model.PackageableElement
    {
        /// <summary>
        /// Specifies the information items that may circulate on this information flow.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> Conveyed { get; }
        /// <summary>
        /// Defines from which source the conveyed InformationItems are initiated.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<NamedElement> InformationSource { get; }
        /// <summary>
        /// Defines to which target the conveyed InformationItems are directed.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<NamedElement> InformationTarget { get; }
        /// <summary>
        /// Determines which Relationship will realize the specified flow.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Relationship> Realization { get; }
        /// <summary>
        /// Determines which ActivityEdges will realize the specified flow.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> RealizingActivityEdge { get; }
        /// <summary>
        /// Determines which Connectors will realize the specified flow.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Connector> RealizingConnector { get; }
        /// <summary>
        /// Determines which Messages will realize the specified flow.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Message> RealizingMessage { get; }
    
    }
}
