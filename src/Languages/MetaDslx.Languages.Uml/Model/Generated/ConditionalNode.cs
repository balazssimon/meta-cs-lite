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
    /// A ConditionalNode is a StructuredActivityNode that chooses one among some number of alternative collections of ExecutableNodes to execute.
    /// </summary>
    public interface ConditionalNode : global::MetaDslx.Languages.Uml.Model.StructuredActivityNode
    {
        /// <summary>
        /// The set of Clauses composing the ConditionalNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Clause> Clause { get; }
        /// <summary>
        /// If true, the modeler asserts that the test for at least one Clause of the ConditionalNode will succeed.
        /// </summary>
        bool IsAssured { get; set; }
        /// <summary>
        /// If true, the modeler asserts that the test for at most one Clause of the ConditionalNode will succeed.
        /// </summary>
        bool IsDeterminate { get; set; }
        /// <summary>
        /// The OutputPins that onto which are moved values from the bodyOutputs of the Clause selected for execution.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> Result { get; }
    
        /// <summary>
        /// Return only this ConditionalNode. This prevents Actions within the ConditionalNode from having their OutputPins used as bodyOutputs or decider Pins in containing LoopNodes or ConditionalNodes.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Action> AllActions();
    }
}
