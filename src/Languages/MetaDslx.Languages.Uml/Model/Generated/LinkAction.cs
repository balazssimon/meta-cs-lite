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
    /// LinkAction is an abstract class for all Actions that identify the links to be acted on using LinkEndData.
    /// </summary>
    public interface LinkAction : global::MetaDslx.Languages.Uml.Model.Action
    {
        /// <summary>
        /// The LinkEndData identifying the values on the ends of the links acting on by this LinkAction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<LinkEndData> EndData { get; }
        /// <summary>
        /// InputPins used by the LinkEndData of the LinkAction.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InputPin> InputValue { get; }
    
        /// <summary>
        /// Returns the Association acted on by this LinkAction.
        /// </summary>
        /// <returns>
        /// </returns>
        Association Association();
    }
}
