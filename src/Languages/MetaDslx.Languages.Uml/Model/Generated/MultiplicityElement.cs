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
    /// A multiplicity is a definition of an inclusive interval of non-negative integers beginning with a lower bound and ending with a (possibly infinite) upper bound. A MultiplicityElement embeds this information to specify the allowable cardinalities for an instantiation of the Element.
    /// </summary>
    public interface MultiplicityElement : global::MetaDslx.Languages.Uml.Model.Element
    {
        /// <summary>
        /// For a multivalued multiplicity, this attribute specifies whether the values in an instantiation of this MultiplicityElement are sequentially ordered.
        /// </summary>
        bool IsOrdered { get; set; }
        /// <summary>
        /// For a multivalued multiplicity, this attributes specifies whether the values in an instantiation of this MultiplicityElement are unique.
        /// </summary>
        bool IsUnique { get; set; }
        /// <summary>
        /// The lower bound of the multiplicity interval.
        /// </summary>
        int Lower { get; }
        /// <summary>
        /// The specification of the lower bound for this multiplicity.
        /// </summary>
        ValueSpecification LowerValue { get; set; }
        /// <summary>
        /// The upper bound of the multiplicity interval.
        /// </summary>
        int Upper { get; }
        /// <summary>
        /// The specification of the upper bound for this multiplicity.
        /// </summary>
        ValueSpecification UpperValue { get; set; }
    
        /// <summary>
        /// The operation compatibleWith takes another multiplicity as input. It returns true if the other multiplicity is wider than, or the same as, self.
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        bool CompatibleWith(MultiplicityElement other);
        /// <summary>
        /// The query includesMultiplicity() checks whether this multiplicity includes all the cardinalities allowed by the specified multiplicity.
        /// </summary>
        /// <param name="M">
        /// </param>
        /// <returns>
        /// </returns>
        bool IncludesMultiplicity(MultiplicityElement M);
        /// <summary>
        /// The operation is determines if the upper and lower bound of the ranges are the ones given.
        /// </summary>
        /// <param name="lowerbound">
        /// </param>
        /// <param name="upperbound">
        /// </param>
        /// <returns>
        /// </returns>
        bool Is(int lowerbound, int upperbound);
        /// <summary>
        /// The query isMultivalued() checks whether this multiplicity has an upper bound greater than one.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsMultivalued();
        /// <summary>
        /// The query lowerBound() returns the lower bound of the multiplicity as an integer, which is the integerValue of lowerValue, if this is given, and 1 otherwise.
        /// </summary>
        /// <returns>
        /// </returns>
        int LowerBound();
        /// <summary>
        /// The query upperBound() returns the upper bound of the multiplicity for a bounded multiplicity as an unlimited natural, which is the unlimitedNaturalValue of upperValue, if given, and 1, otherwise.
        /// </summary>
        /// <returns>
        /// </returns>
        int UpperBound();
    }
}
