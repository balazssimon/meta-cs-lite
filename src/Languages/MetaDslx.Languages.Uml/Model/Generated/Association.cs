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
    /// A link is a tuple of values that refer to typed objects.  An Association classifies a set of links, each of which is an instance of the Association.  Each value in the link refers to an instance of the type of the corresponding end of the Association.
    /// </summary>
    public interface Association : global::MetaDslx.Languages.Uml.Model.Relationship, global::MetaDslx.Languages.Uml.Model.Classifier
    {
        /// <summary>
        /// The Classifiers that are used as types of the ends of the Association.
        /// </summary>
        global::System.Collections.Generic.IList<Type> EndType { get; }
        /// <summary>
        /// Specifies whether the Association is derived from other model elements such as other Associations.
        /// </summary>
        bool IsDerived { get; set; }
        /// <summary>
        /// Each end represents participation of instances of the Classifier connected to the end in links of the Association.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> MemberEnd { get; }
        /// <summary>
        /// The navigable ends that are owned by the Association itself.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> NavigableOwnedEnd { get; }
        /// <summary>
        /// The ends that are owned by the Association itself.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> OwnedEnd { get; }
    
    }
}
