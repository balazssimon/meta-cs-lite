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
    /// A ValueSpecification is the specification of a (possibly empty) set of values. A ValueSpecification is a ParameterableElement that may be exposed as a formal TemplateParameter and provided as the actual parameter in the binding of a template.
    /// </summary>
    public interface ValueSpecification : global::MetaDslx.Languages.Uml.Model.TypedElement, global::MetaDslx.Languages.Uml.Model.PackageableElement
    {
    
        /// <summary>
        /// The query booleanValue() gives a single Boolean value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        bool BooleanValue();
        /// <summary>
        /// The query integerValue() gives a single Integer value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        int IntegerValue();
        /// <summary>
        /// The query isCompatibleWith() determines if this ValueSpecification is compatible with the specified ParameterableElement. This ValueSpecification is compatible with ParameterableElement p if the kind of this ValueSpecification is the same as or a subtype of the kind of p. Further, if p is a TypedElement, then the type of this ValueSpecification must be conformant with the type of p.
        /// </summary>
        /// <param name="p">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsCompatibleWith(ParameterableElement p);
        /// <summary>
        /// The query isComputable() determines whether a value specification can be computed in a model. This operation cannot be fully defined in OCL. A conforming implementation is expected to deliver true for this operation for all ValueSpecifications that it can compute, and to compute all of those for which the operation is true. A conforming implementation is expected to be able to compute at least the value of all LiteralSpecifications.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsComputable();
        /// <summary>
        /// The query isNull() returns true when it can be computed that the value is null.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsNull();
        /// <summary>
        /// The query realValue() gives a single Real value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        double RealValue();
        /// <summary>
        /// The query stringValue() gives a single String value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        string StringValue();
        /// <summary>
        /// The query unlimitedValue() gives a single UnlimitedNatural value when one can be computed.
        /// </summary>
        /// <returns>
        /// </returns>
        int UnlimitedValue();
    }
}
