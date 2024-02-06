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
    /// StructuredClassifiers may contain an internal structure of connected elements each of which plays a role in the overall Behavior modeled by the StructuredClassifier.
    /// </summary>
    public interface StructuredClassifier : global::MetaDslx.Languages.Uml.Model.Classifier
    {
        /// <summary>
        /// The Properties owned by the StructuredClassifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> OwnedAttribute { get; }
        /// <summary>
        /// The connectors owned by the StructuredClassifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Connector> OwnedConnector { get; }
        /// <summary>
        /// The Properties specifying instances that the StructuredClassifier owns by composition. This collection is derived, selecting those owned Properties where isComposite is true.
        /// </summary>
        global::System.Collections.Generic.IList<Property> Part { get; }
        /// <summary>
        /// The roles that instances may play in this StructuredClassifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ConnectableElement> Role { get; }
    
        /// <summary>
        /// All features of type ConnectableElement, equivalent to all direct and inherited roles.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<ConnectableElement> AllRoles();
    }
}
