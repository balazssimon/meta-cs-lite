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
    /// An OpaqueAction is an Action whose functionality is not specified within UML.
    /// </summary>
    public interface OpaqueAction : global::MetaDslx.Languages.Uml.Model.Action
    {
        /// <summary>
        /// Provides a textual specification of the functionality of the Action, in one or more languages other than UML.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<string> Body { get; }
        /// <summary>
        /// The InputPins providing inputs to the OpaqueAction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InputPin> InputValue { get; }
        /// <summary>
        /// If provided, a specification of the language used for each of the body Strings.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<string> Language { get; }
        /// <summary>
        /// The OutputPins on which the OpaqueAction provides outputs.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> OutputValue { get; }
    
    }
}
