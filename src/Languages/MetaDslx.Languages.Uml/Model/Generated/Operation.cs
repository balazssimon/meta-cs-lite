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
    /// An Operation is a BehavioralFeature of a Classifier that specifies the name, type, parameters, and constraints for invoking an associated Behavior. An Operation may invoke both the execution of method behaviors as well as other behavioral responses. Operation specializes TemplateableElement in order to support specification of template operations and bound operations. Operation specializes ParameterableElement to specify that an operation can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
    /// </summary>
    public interface Operation : global::MetaDslx.Languages.Uml.Model.TemplateableElement, global::MetaDslx.Languages.Uml.Model.ParameterableElement, global::MetaDslx.Languages.Uml.Model.BehavioralFeature
    {
        /// <summary>
        /// An optional Constraint on the result values of an invocation of this Operation.
        /// </summary>
        Constraint BodyCondition { get; set; }
        /// <summary>
        /// The Class that owns this operation, if any.
        /// </summary>
        Class Class { get; set; }
        /// <summary>
        /// The DataType that owns this Operation, if any.
        /// </summary>
        DataType Datatype { get; set; }
        /// <summary>
        /// The Interface that owns this Operation, if any.
        /// </summary>
        Interface Interface { get; set; }
        /// <summary>
        /// Specifies whether the return parameter is ordered or not, if present.  This information is derived from the return result for this Operation.
        /// </summary>
        bool IsOrdered { get; }
        /// <summary>
        /// Specifies whether an execution of the BehavioralFeature leaves the state of the system unchanged (isQuery=true) or whether side effects may occur (isQuery=false).
        /// </summary>
        bool IsQuery { get; set; }
        /// <summary>
        /// Specifies whether the return parameter is unique or not, if present. This information is derived from the return result for this Operation.
        /// </summary>
        bool IsUnique { get; }
        /// <summary>
        /// Specifies the lower multiplicity of the return parameter, if present. This information is derived from the return result for this Operation.
        /// </summary>
        int Lower { get; }
        /// <summary>
        /// The parameters owned by this Operation.
        /// </summary>
        new global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter { get; }
        /// <summary>
        /// An optional set of Constraints specifying the state of the system when the Operation is completed.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Postcondition { get; }
        /// <summary>
        /// An optional set of Constraints on the state of the system when the Operation is invoked.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Precondition { get; }
        /// <summary>
        /// The Types representing exceptions that may be raised during an invocation of this operation.
        /// </summary>
        new global::MetaDslx.Modeling.ICollectionSlot<Type> RaisedException { get; }
        /// <summary>
        /// The Operations that are redefined by this Operation.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Operation> RedefinedOperation { get; }
        /// <summary>
        /// The OperationTemplateParameter that exposes this element as a formal parameter.
        /// </summary>
        new OperationTemplateParameter TemplateParameter { get; set; }
        /// <summary>
        /// The return type of the operation, if present. This information is derived from the return result for this Operation.
        /// </summary>
        Type Type { get; }
        /// <summary>
        /// The upper multiplicity of the return parameter, if present. This information is derived from the return result for this Operation.
        /// </summary>
        int Upper { get; }
    
        /// <summary>
        /// The query isConsistentWith() specifies, for any two Operations in a context in which redefinition is possible, whether redefinition would be consistent. A redefining operation is consistent with a redefined operation if
        /// it has the same number of owned parameters, and for each parameter the following holds:
        ///
        /// - Direction, ordering and uniqueness are the same.
        /// - The corresponding types are covariant, contravariant or invariant.
        /// - The multiplicities are compatible, depending on the parameter direction.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
        /// <summary>
        /// The query returnResult() returns the set containing the return parameter of the Operation if one exists, otherwise, it returns an empty set
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Parameter> ReturnResult();
    }
}
