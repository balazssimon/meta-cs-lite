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
    /// A Class classifies a set of objects and specifies the features that characterize the structure and behavior of those objects.  A Class may have an internal structure and Ports.
    /// </summary>
    public interface Class : global::MetaDslx.Languages.Uml.Model.BehavioredClassifier, global::MetaDslx.Languages.Uml.Model.EncapsulatedClassifier
    {
        /// <summary>
        /// This property is used when the Class is acting as a metaclass. It references the Extensions that specify additional properties of the metaclass. The property is derived from the Extensions whose memberEnds are typed by the Class.
        /// </summary>
        global::System.Collections.Generic.IList<Extension> Extension { get; }
        /// <summary>
        /// If true, the Class does not provide a complete declaration and cannot be instantiated. An abstract Class is typically used as a target of Associations or Generalizations.
        /// </summary>
        new bool IsAbstract { get; set; }
        /// <summary>
        /// Determines whether an object specified by this Class is active or not. If true, then the owning Class is referred to as an active Class. If false, then such a Class is referred to as a passive Class.
        /// </summary>
        bool IsActive { get; set; }
        /// <summary>
        /// The Classifiers owned by the Class that are not ownedBehaviors.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> NestedClassifier { get; }
        /// <summary>
        /// The attributes (i.e., the Properties) owned by the Class.
        /// </summary>
        new global::MetaDslx.Modeling.ICollectionSlot<Property> OwnedAttribute { get; }
        /// <summary>
        /// The Operations owned by the Class.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Operation> OwnedOperation { get; }
        /// <summary>
        /// The Receptions owned by the Class.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Reception> OwnedReception { get; }
        /// <summary>
        /// The superclasses of a Class, derived from its Generalizations.
        /// </summary>
        global::System.Collections.Generic.IList<Class> SuperClass { get; }
    
    }
}
