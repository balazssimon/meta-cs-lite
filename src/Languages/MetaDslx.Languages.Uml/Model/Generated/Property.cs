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
    /// A Property is a StructuralFeature. A Property related by ownedAttribute to a Classifier (other than an association) represents an attribute and might also represent an association end. It relates an instance of the Classifier to a value or set of values of the type of the attribute. A Property related by memberEnd to an Association represents an end of the Association. The type of the Property is the type of the end of the Association. A Property has the capability of being a DeploymentTarget in a Deployment relationship. This enables modeling the deployment to hierarchical nodes that have Properties functioning as internal parts.  Property specializes ParameterableElement to specify that a Property can be exposed as a formal template parameter, and provided as an actual parameter in a binding of a template.
    /// </summary>
    public interface Property : global::MetaDslx.Languages.Uml.Model.ConnectableElement, global::MetaDslx.Languages.Uml.Model.DeploymentTarget, global::MetaDslx.Languages.Uml.Model.StructuralFeature
    {
        /// <summary>
        /// Specifies the kind of aggregation that applies to the Property.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.AggregationKind Aggregation { get; set; }
        /// <summary>
        /// The Association of which this Property is a member, if any.
        /// </summary>
        Association Association { get; set; }
        /// <summary>
        /// Designates the optional association end that owns a qualifier attribute.
        /// </summary>
        Property AssociationEnd { get; set; }
        /// <summary>
        /// The Class that owns this Property, if any.
        /// </summary>
        Class Class { get; set; }
        /// <summary>
        /// The DataType that owns this Property, if any.
        /// </summary>
        DataType Datatype { get; set; }
        /// <summary>
        /// A ValueSpecification that is evaluated to give a default value for the Property when an instance of the owning Classifier is instantiated.
        /// </summary>
        ValueSpecification DefaultValue { get; set; }
        /// <summary>
        /// The Interface that owns this Property, if any.
        /// </summary>
        Interface Interface { get; set; }
        /// <summary>
        /// If isComposite is true, the object containing the attribute is a container for the object or value contained in the attribute. This is a derived value, indicating whether the aggregation of the Property is composite or not.
        /// </summary>
        bool IsComposite { get; }
        /// <summary>
        /// Specifies whether the Property is derived, i.e., whether its value or values can be computed from other information.
        /// </summary>
        bool IsDerived { get; set; }
        /// <summary>
        /// Specifies whether the property is derived as the union of all of the Properties that are constrained to subset it.
        /// </summary>
        bool IsDerivedUnion { get; set; }
        /// <summary>
        /// True indicates this property can be used to uniquely identify an instance of the containing Class.
        /// </summary>
        bool IsID { get; set; }
        /// <summary>
        /// In the case where the Property is one end of a binary association this gives the other end.
        /// </summary>
        Property Opposite { get; }
        /// <summary>
        /// The owning association of this property, if any.
        /// </summary>
        Association OwningAssociation { get; set; }
        /// <summary>
        /// An optional list of ordered qualifier attributes for the end.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> Qualifier { get; }
        /// <summary>
        /// The properties that are redefined by this property, if any.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> RedefinedProperty { get; }
        /// <summary>
        /// The properties of which this Property is constrained to be a subset, if any.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> SubsettedProperty { get; }
    
        /// <summary>
        /// The query isAttribute() is true if the Property is defined as an attribute of some Classifier.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsAttribute();
        /// <summary>
        /// The query isCompatibleWith() determines if this Property is compatible with the specified ParameterableElement. This Property is compatible with ParameterableElement p if the kind of this Property is thesame as or a subtype of the kind of p. Further, if p is a TypedElement, then the type of this Property must be conformant with the type of p.
        /// </summary>
        /// <param name="p">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsCompatibleWith(ParameterableElement p);
        /// <summary>
        /// The query isConsistentWith() specifies, for any two Properties in a context in which redefinition is possible, whether redefinition would be logically consistent. A redefining Property is consistent with a redefined Property if the type of the redefining Property conforms to the type of the redefined Property, and the multiplicity of the redefining Property (if specified) is contained in the multiplicity of the redefined Property.
        /// </summary>
        /// <param name="redefiningElement">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsConsistentWith(RedefinableElement redefiningElement);
        /// <summary>
        /// The query isNavigable() indicates whether it is possible to navigate across the property.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsNavigable();
        /// <summary>
        /// The query subsettingContext() gives the context for subsetting a Property. It consists, in the case of an attribute, of the corresponding Classifier, and in the case of an association end, all of the Classifiers at the other ends.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Type> SubsettingContext();
    }
}
