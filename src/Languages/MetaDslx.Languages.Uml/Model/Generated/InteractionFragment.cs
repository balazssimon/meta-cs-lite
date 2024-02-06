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
    /// InteractionFragment is an abstract notion of the most general interaction unit. An InteractionFragment is a piece of an Interaction. Each InteractionFragment is conceptually like an Interaction by itself.
    /// </summary>
    public interface InteractionFragment : global::MetaDslx.Languages.Uml.Model.NamedElement
    {
        /// <summary>
        /// References the Lifelines that the InteractionFragment involves.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Lifeline> Covered { get; }
        /// <summary>
        /// The Interaction enclosing this InteractionFragment.
        /// </summary>
        Interaction EnclosingInteraction { get; set; }
        /// <summary>
        /// The operand enclosing this InteractionFragment (they may nest recursively).
        /// </summary>
        InteractionOperand EnclosingOperand { get; set; }
        /// <summary>
        /// The general ordering relationships contained in this fragment.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<GeneralOrdering> GeneralOrdering { get; }
    
    }
}
