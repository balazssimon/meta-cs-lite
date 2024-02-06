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
    /// A Lifeline represents an individual participant in the Interaction. While parts and structural features may have multiplicity greater than 1, Lifelines represent only one interacting entity.
    /// </summary>
    public interface Lifeline : global::MetaDslx.Languages.Uml.Model.NamedElement
    {
        /// <summary>
        /// References the InteractionFragments in which this Lifeline takes part.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InteractionFragment> CoveredBy { get; }
        /// <summary>
        /// References the Interaction that represents the decomposition.
        /// </summary>
        PartDecomposition DecomposedAs { get; set; }
        /// <summary>
        /// References the Interaction enclosing this Lifeline.
        /// </summary>
        Interaction Interaction { get; set; }
        /// <summary>
        /// References the ConnectableElement within the classifier that contains the enclosing interaction.
        /// </summary>
        ConnectableElement Represents { get; set; }
        /// <summary>
        /// If a Part has multiplicity, multiple lifelines might be used to show it.
        /// </summary>
        /// <summary>
        /// If the referenced ConnectableElement is multivalued, then this specifies the specific individual part within that set.
        /// </summary>
        ValueSpecification Selector { get; set; }
    
    }
}
