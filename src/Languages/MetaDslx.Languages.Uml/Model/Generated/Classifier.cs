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
    /// A Classifier represents a classification of instances according to their Features.
    /// </summary>
    public interface Classifier : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.Type, global::MetaDslx.Languages.Uml.Model.TemplateableElement, global::MetaDslx.Languages.Uml.Model.RedefinableElement
    {
        /// <summary>
        /// All of the Properties that are direct (i.e., not inherited or imported) attributes of the Classifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Property> Attribute { get; }
        /// <summary>
        /// The CollaborationUses owned by the Classifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<CollaborationUse> CollaborationUse { get; }
        /// <summary>
        /// Specifies each Feature directly defined in the classifier. Note that there may be members of the Classifier that are of the type Feature but are not included, e.g., inherited features.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Feature> Feature { get; }
        /// <summary>
        /// The generalizing Classifiers for this Classifier.
        /// </summary>
        global::System.Collections.Generic.IList<Classifier> General { get; }
        /// <summary>
        /// The Generalization relationships for this Classifier. These Generalizations navigate to more general Classifiers in the generalization hierarchy.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Generalization> Generalization { get; }
        /// <summary>
        /// All elements inherited by this Classifier from its general Classifiers.
        /// </summary>
        global::System.Collections.Generic.IList<NamedElement> InheritedMember { get; }
        /// <summary>
        /// If true, the Classifier can only be instantiated by instantiating one of its specializations. An abstract Classifier is intended to be used by other Classifiers e.g., as the target of Associations or Generalizations.
        /// </summary>
        bool IsAbstract { get; set; }
        /// <summary>
        /// If true, the Classifier cannot be specialized.
        /// </summary>
        bool IsFinalSpecialization { get; set; }
        /// <summary>
        /// The Class owning the Classifier.
        /// </summary>
        Class NestingClass { get; set; }
        /// <summary>
        /// The optional RedefinableTemplateSignature specifying the formal template parameters.
        /// </summary>
        new RedefinableTemplateSignature OwnedTemplateSignature { get; set; }
        /// <summary>
        /// The UseCases owned by this classifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<UseCase> OwnedUseCase { get; }
        /// <summary>
        /// The GeneralizationSet of which this Classifier is a power type.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<GeneralizationSet> PowertypeExtent { get; }
        /// <summary>
        /// The Classifiers redefined by this Classifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> RedefinedClassifier { get; }
        /// <summary>
        /// A CollaborationUse which indicates the Collaboration that represents this Classifier.
        /// </summary>
        CollaborationUse Representation { get; set; }
        /// <summary>
        /// The Substitutions owned by this Classifier.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Substitution> Substitution { get; }
        /// <summary>
        /// TheClassifierTemplateParameter that exposes this element as a formal parameter.
        /// </summary>
        new ClassifierTemplateParameter TemplateParameter { get; set; }
        /// <summary>
        /// The set of UseCases for which this Classifier is the subject.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<UseCase> UseCase { get; }
    
        /// <summary>
        /// The query allFeatures() gives all of the Features in the namespace of the Classifier. In general, through mechanisms such as inheritance, this will be a larger set than feature.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Feature> AllFeatures();
        /// <summary>
        /// The query allParents() gives all of the direct and indirect ancestors of a generalized Classifier.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Classifier> AllParents();
        /// <summary>
        /// The query conformsTo() gives true for a Classifier that defines a type that conforms to another. This is used, for example, in the specification of signature conformance for operations.
        /// </summary>
        /// <param name="other">
        /// </param>
        /// <returns>
        /// </returns>
        bool ConformsTo(Type other);
        /// <summary>
        /// The query hasVisibilityOf() determines whether a NamedElement is visible in the classifier. Non-private members are visible. It is only called when the argument is something owned by a parent.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <returns>
        /// </returns>
        bool HasVisibilityOf(NamedElement n);
        /// <summary>
        /// The query inherit() defines how to inherit a set of elements passed as its argument.  It excludes redefined elements from the result.
        /// </summary>
        /// <param name="inhs">
        /// </param>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<NamedElement> Inherit(global::System.Collections.Generic.IList<NamedElement> inhs);
        /// <summary>
        /// The query inheritableMembers() gives all of the members of a Classifier that may be inherited in one of its descendants, subject to whatever visibility restrictions apply.
        /// </summary>
        /// <param name="c">
        /// </param>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<NamedElement> InheritableMembers(Classifier c);
        /// <summary>
        /// The query isTemplate() returns whether this Classifier is actually a template.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsTemplate();
        /// <summary>
        /// The query maySpecializeType() determines whether this classifier may have a generalization relationship to classifiers of the specified type. By default a classifier may specialize classifiers of the same or a more general type. It is intended to be redefined by classifiers that have different specialization constraints.
        /// </summary>
        /// <param name="c">
        /// </param>
        /// <returns>
        /// </returns>
        bool MaySpecializeType(Classifier c);
        /// <summary>
        /// The query parents() gives all of the immediate ancestors of a generalized Classifier.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Classifier> Parents();
        /// <summary>
        /// The Interfaces directly realized by this Classifier
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Interface> DirectlyRealizedInterfaces();
        /// <summary>
        /// The Interfaces directly used by this Classifier
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Interface> DirectlyUsedInterfaces();
        /// <summary>
        /// The Interfaces realized by this Classifier and all of its generalizations
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Interface> AllRealizedInterfaces();
        /// <summary>
        /// The Interfaces used by this Classifier and all of its generalizations
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Interface> AllUsedInterfaces();
        /// <param name="contract">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsSubstitutableFor(Classifier contract);
        /// <summary>
        /// The query allAttributes gives an ordered set of all owned and inherited attributes of the Classifier. All owned attributes appear before any inherited attributes, and the attributes inherited from any more specific parent Classifier appear before those of any more general parent Classifier. However, if the Classifier has multiple immediate parents, then the relative ordering of the sets of attributes from those parents is not defined.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Property> AllAttributes();
        /// <summary>
        /// All StructuralFeatures related to the Classifier that may have Slots, including direct attributes, inherited attributes, private attributes in generalizations, and memberEnds of Associations, but excluding redefined StructuralFeatures.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<StructuralFeature> AllSlottableFeatures();
    }
}
