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
    /// A ConnectionPointReference represents a usage (as part of a submachine State) of an entry/exit point Pseudostate defined in the StateMachine referenced by the submachine State.
    /// </summary>
    public interface ConnectionPointReference : global::MetaDslx.Languages.Uml.Model.Vertex
    {
        /// <summary>
        /// The entryPoint Pseudostates corresponding to this connection point.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Pseudostate> Entry { get; }
        /// <summary>
        /// The exitPoints kind Pseudostates corresponding to this connection point.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Pseudostate> Exit { get; }
        /// <summary>
        /// The State in which the ConnectionPointReference is defined.
        /// </summary>
        State State { get; set; }
    
        /// <summary>
        /// The query isConsistentWith() specifies a ConnectionPointReference can only be redefined by a ConnectionPointReference.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
    }
}
