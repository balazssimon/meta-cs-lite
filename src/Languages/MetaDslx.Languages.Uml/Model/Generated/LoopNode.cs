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
    /// A LoopNode is a StructuredActivityNode that represents an iterative loop with setup, test, and body sections.
    /// </summary>
    public interface LoopNode : global::MetaDslx.Languages.Uml.Model.StructuredActivityNode
    {
        /// <summary>
        /// The OutputPins on Actions within the bodyPart, the values of which are moved to the loopVariable OutputPins after the completion of each execution of the bodyPart, before the next iteration of the loop begins or before the loop exits.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> BodyOutput { get; }
        /// <summary>
        /// The set of ExecutableNodes that perform the repetitive computations of the loop. The bodyPart is executed as long as the test section produces a true value.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExecutableNode> BodyPart { get; }
        /// <summary>
        /// An OutputPin on an Action in the test section whose Boolean value determines whether to continue executing the loop bodyPart.
        /// </summary>
        OutputPin Decider { get; set; }
        /// <summary>
        /// If true, the test is performed before the first execution of the bodyPart. If false, the bodyPart is executed once before the test is performed.
        /// </summary>
        bool IsTestedFirst { get; set; }
        /// <summary>
        /// A list of OutputPins that hold the values of the loop variables during an execution of the loop. When the test fails, the values are moved to the result OutputPins of the loop.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> LoopVariable { get; }
        /// <summary>
        /// A list of InputPins whose values are moved into the loopVariable Pins before the first iteration of the loop.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<InputPin> LoopVariableInput { get; }
        /// <summary>
        /// A list of OutputPins that receive the loopVariable values after the last iteration of the loop and constitute the output of the LoopNode.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> Result { get; }
        /// <summary>
        /// The set of ExecutableNodes executed before the first iteration of the loop, in order to initialize values or perform other setup computations.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExecutableNode> SetupPart { get; }
        /// <summary>
        /// The set of ExecutableNodes executed in order to provide the test result for the loop.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExecutableNode> Test { get; }
    
        /// <summary>
        /// Return only this LoopNode. This prevents Actions within the LoopNode from having their OutputPins used as bodyOutputs or decider Pins in containing LoopNodes or ConditionalNodes.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Action> AllActions();
        /// <summary>
        /// Return the loopVariable OutputPins in addition to other source nodes for the LoopNode as a StructuredActivityNode.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<ActivityNode> SourceNodes();
    }
}
