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
    /// Interfaces declare coherent services that are implemented by BehavioredClassifiers that implement the Interfaces via InterfaceRealizations.
    /// </summary>
    public interface Interface : global::MetaDslx.Languages.Uml.Model.Classifier
    {
        /// <summary>
        /// References all the Classifiers that are defined (nested) within the Interface.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> NestedClassifier { get; }
        /// <summary>
        /// The attributes (i.e., the Properties) owned by the Interface.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> OwnedAttribute { get; }
        /// <summary>
        /// The Operations owned by the Interface.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Operation> OwnedOperation { get; }
        /// <summary>
        /// Receptions that objects providing this Interface are willing to accept.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Reception> OwnedReception { get; }
        /// <summary>
        /// References a ProtocolStateMachine specifying the legal sequences of the invocation of the BehavioralFeatures described in the Interface.
        /// </summary>
        ProtocolStateMachine Protocol { get; set; }
        /// <summary>
        /// References all the Interfaces redefined by this Interface.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Interface> RedefinedInterface { get; }
    
    }
}
