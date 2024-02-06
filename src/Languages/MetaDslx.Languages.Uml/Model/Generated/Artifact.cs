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
    /// An artifact is the specification of a physical piece of information that is used or produced by a software development process, or by deployment and operation of a system. Examples of artifacts include model files, source files, scripts, and binary executable files, a table in a database system, a development deliverable, or a word-processing document, a mail message.
    /// An artifact is the source of a deployment to a node.
    /// </summary>
    public interface Artifact : global::MetaDslx.Languages.Uml.Model.Classifier, global::MetaDslx.Languages.Uml.Model.DeployedArtifact
    {
        /// <summary>
        /// A concrete name that is used to refer to the Artifact in a physical context. Example: file system name, universal resource locator.
        /// </summary>
        string FileName { get; set; }
        /// <summary>
        /// The set of model elements that are manifested in the Artifact. That is, these model elements are utilized in the construction (or generation) of the artifact.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Manifestation> Manifestation { get; }
        /// <summary>
        /// The Artifacts that are defined (nested) within the Artifact. The association is a specialization of the ownedMember association from Namespace to NamedElement.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Artifact> NestedArtifact { get; }
        /// <summary>
        /// The attributes or association ends defined for the Artifact. The association is a specialization of the ownedMember association.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> OwnedAttribute { get; }
        /// <summary>
        /// The Operations defined for the Artifact. The association is a specialization of the ownedMember association.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Operation> OwnedOperation { get; }
    
    }
}
