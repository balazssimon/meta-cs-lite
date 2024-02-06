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
    /// A package can have one or more profile applications to indicate which profiles have been applied. Because a profile is a package, it is possible to apply a profile not only to packages, but also to profiles.
    /// Package specializes TemplateableElement and PackageableElement specializes ParameterableElement to specify that a package can be used as a template and a PackageableElement as a template parameter.
    /// A package is used to group elements, and provides a namespace for the grouped elements.
    /// </summary>
    public interface Package : global::MetaDslx.Languages.Uml.Model.PackageableElement, global::MetaDslx.Languages.Uml.Model.TemplateableElement, global::MetaDslx.Languages.Uml.Model.Namespace
    {
        /// <summary>
        /// References the packaged elements that are Packages.
        /// </summary>
        global::System.Collections.Generic.IList<Package> NestedPackage { get; }
        /// <summary>
        /// References the Package that owns this Package.
        /// </summary>
        Package NestingPackage { get; set; }
        /// <summary>
        /// References the Stereotypes that are owned by the Package.
        /// </summary>
        global::System.Collections.Generic.IList<Stereotype> OwnedStereotype { get; }
        /// <summary>
        /// References the packaged elements that are Types.
        /// </summary>
        global::System.Collections.Generic.IList<Type> OwnedType { get; }
        /// <summary>
        /// Specifies the packageable elements that are owned by this Package.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<PackageableElement> PackagedElement { get; }
        /// <summary>
        /// References the PackageMerges that are owned by this Package.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<PackageMerge> PackageMerge { get; }
        /// <summary>
        /// References the ProfileApplications that indicate which profiles have been applied to the Package.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ProfileApplication> ProfileApplication { get; }
        /// <summary>
        /// Provides an identifier for the package that can be used for many purposes. A URI is the universally unique identification of the package following the IETF URI specification, RFC 2396 http://www.ietf.org/rfc/rfc2396.txt and it must comply with those syntax rules.
        /// </summary>
        string URI { get; set; }
    
        /// <summary>
        /// The query allApplicableStereotypes() returns all the directly or indirectly owned stereotypes, including stereotypes contained in sub-profiles.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Stereotype> AllApplicableStereotypes();
        /// <summary>
        /// The query containingProfile() returns the closest profile directly or indirectly containing this package (or this package itself, if it is a profile).
        /// </summary>
        /// <returns>
        /// </returns>
        Profile ContainingProfile();
        /// <summary>
        /// The query makesVisible() defines whether a Package makes an element visible outside itself. Elements with no visibility and elements with public visibility are made visible.
        /// </summary>
        /// <param name="el">
        /// </param>
        /// <returns>
        /// </returns>
        bool MakesVisible(NamedElement el);
        /// <summary>
        /// The query mustBeOwned() indicates whether elements of this type must have an owner.
        /// </summary>
        /// <returns>
        /// </returns>
        bool MustBeOwned();
        /// <summary>
        /// The query visibleMembers() defines which members of a Package can be accessed outside it.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<PackageableElement> VisibleMembers();
    }
}
