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
    /// An OpaqueExpression is a ValueSpecification that specifies the computation of a collection of values either in terms of a UML Behavior or based on a textual statement in a language other than UML
    /// </summary>
    public interface OpaqueExpression : global::MetaDslx.Languages.Uml.Model.ValueSpecification
    {
        /// <summary>
        /// Specifies the behavior of the OpaqueExpression as a UML Behavior.
        /// </summary>
        Behavior Behavior { get; set; }
        /// <summary>
        /// A textual definition of the behavior of the OpaqueExpression, possibly in multiple languages.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<string> Body { get; }
        /// <summary>
        /// Specifies the languages used to express the textual bodies of the OpaqueExpression.  Languages are matched to body Strings by order. The interpretation of the body depends on the languages. If the languages are unspecified, they may be implicit from the expression body or the context.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<string> Language { get; }
        /// <summary>
        /// If an OpaqueExpression is specified using a UML Behavior, then this refers to the single required return Parameter of that Behavior. When the Behavior completes execution, the values on this Parameter give the result of evaluating the OpaqueExpression.
        /// </summary>
        Parameter Result { get; }
    
        /// <summary>
        /// The query isIntegral() tells whether an expression is intended to produce an Integer.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsIntegral();
        /// <summary>
        /// The query isNonNegative() tells whether an integer expression has a non-negative value.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsNonNegative();
        /// <summary>
        /// The query isPositive() tells whether an integer expression has a positive value.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsPositive();
        /// <summary>
        /// The query value() gives an integer value for an expression intended to produce one.
        /// </summary>
        /// <returns>
        /// </returns>
        int Value();
    }
}
