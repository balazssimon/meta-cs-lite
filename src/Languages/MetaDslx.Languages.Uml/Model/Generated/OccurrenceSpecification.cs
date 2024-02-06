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
    /// An OccurrenceSpecification is the basic semantic unit of Interactions. The sequences of occurrences specified by them are the meanings of Interactions.
    /// </summary>
    public interface OccurrenceSpecification : global::MetaDslx.Languages.Uml.Model.InteractionFragment
    {
        /// <summary>
        /// References the Lifeline on which the OccurrenceSpecification appears.
        /// </summary>
        new Lifeline Covered { get; set; }
        /// <summary>
        /// References the GeneralOrderings that specify EventOcurrences that must occur after this OccurrenceSpecification.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<GeneralOrdering> ToAfter { get; }
        /// <summary>
        /// References the GeneralOrderings that specify EventOcurrences that must occur before this OccurrenceSpecification.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<GeneralOrdering> ToBefore { get; }
    
    }
}
