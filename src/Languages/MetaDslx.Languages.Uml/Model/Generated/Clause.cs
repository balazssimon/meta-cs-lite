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
    /// A Clause is an Element that represents a single branch of a ConditionalNode, including a test and a body section. The body section is executed only if (but not necessarily if) the test section evaluates to true.
    /// </summary>
    public interface Clause : global::MetaDslx.Languages.Uml.Model.Element
    {
        /// <summary>
        /// The set of ExecutableNodes that are executed if the test evaluates to true and the Clause is chosen over other Clauses within the ConditionalNode that also have tests that evaluate to true.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExecutableNode> Body { get; }
        /// <summary>
        /// The OutputPins on Actions within the body section whose values are moved to the result OutputPins of the containing ConditionalNode after execution of the body.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<OutputPin> BodyOutput { get; }
        /// <summary>
        /// An OutputPin on an Action in the test section whose Boolean value determines the result of the test.
        /// </summary>
        OutputPin Decider { get; set; }
        /// <summary>
        /// A set of Clauses whose tests must all evaluate to false before this Clause can evaluate its test.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Clause> PredecessorClause { get; }
        /// <summary>
        /// A set of Clauses that may not evaluate their tests unless the test for this Clause evaluates to false.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Clause> SuccessorClause { get; }
        /// <summary>
        /// The set of ExecutableNodes that are executed in order to provide a test result for the Clause.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExecutableNode> Test { get; }
    
    }
}
