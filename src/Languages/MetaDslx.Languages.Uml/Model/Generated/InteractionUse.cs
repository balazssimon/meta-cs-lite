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
    /// An InteractionUse refers to an Interaction. The InteractionUse is a shorthand for copying the contents of the referenced Interaction where the InteractionUse is. To be accurate the copying must take into account substituting parameters with arguments and connect the formal Gates with the actual ones.
    /// </summary>
    public interface InteractionUse : global::MetaDslx.Languages.Uml.Model.InteractionFragment
    {
        /// <summary>
        /// The actual gates of the InteractionUse.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Gate> ActualGate { get; }
        /// <summary>
        /// The actual arguments of the Interaction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ValueSpecification> Argument { get; }
        /// <summary>
        /// Refers to the Interaction that defines its meaning.
        /// </summary>
        Interaction RefersTo { get; set; }
        /// <summary>
        /// The value of the executed Interaction.
        /// </summary>
        ValueSpecification ReturnValue { get; set; }
        /// <summary>
        /// The recipient of the return value.
        /// </summary>
        Property ReturnValueRecipient { get; set; }
    
    }
}
