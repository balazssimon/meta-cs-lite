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
    /// An Interaction is a unit of Behavior that focuses on the observable exchange of information between connectable elements.
    /// </summary>
    public interface Interaction : global::MetaDslx.Languages.Uml.Model.InteractionFragment, global::MetaDslx.Languages.Uml.Model.Behavior
    {
        /// <summary>
        /// Actions owned by the Interaction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Action> Action { get; }
        /// <summary>
        /// Specifies the gates that form the message interface between this Interaction and any InteractionUses which reference it.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Gate> FormalGate { get; }
        /// <summary>
        /// The ordered set of fragments in the Interaction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InteractionFragment> Fragment { get; }
        /// <summary>
        /// Specifies the participants in this Interaction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Lifeline> Lifeline { get; }
        /// <summary>
        /// The Messages contained in this Interaction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Message> Message { get; }
    
    }
}
