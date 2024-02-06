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
    /// A NamedElement is an Element in a model that may have a name. The name may be given directly and/or via the use of a StringExpression.
    /// </summary>
    public interface NamedElement : global::MetaDslx.Languages.Uml.Model.Element
    {
        /// <summary>
        /// Indicates the Dependencies that reference this NamedElement as a client.
        /// </summary>
        global::System.Collections.Generic.IList<Dependency> ClientDependency { get; }
        /// <summary>
        /// The name of the NamedElement.
        /// </summary>
        string Name { get; set; }
        /// <summary>
        /// The StringExpression used to define the name of this NamedElement.
        /// </summary>
        StringExpression NameExpression { get; set; }
        /// <summary>
        /// Specifies the Namespace that owns the NamedElement.
        /// </summary>
        Namespace Namespace { get; set; }
        /// <summary>
        /// A name that allows the NamedElement to be identified within a hierarchy of nested Namespaces. It is constructed from the names of the containing Namespaces starting at the root of the hierarchy and ending with the name of the NamedElement itself.
        /// </summary>
        string QualifiedName { get; }
        /// <summary>
        /// Determines whether and how the NamedElement is visible outside its owning Namespace.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.VisibilityKind Visibility { get; set; }
    
        /// <summary>
        /// The query allNamespaces() gives the sequence of Namespaces in which the NamedElement is nested, working outwards.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Namespace> AllNamespaces();
        /// <summary>
        /// The query allOwningPackages() returns the set of all the enclosing Namespaces of this NamedElement, working outwards, that are Packages, up to but not including the first such Namespace that is not a Package.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Package> AllOwningPackages();
        /// <summary>
        /// The query isDistinguishableFrom() determines whether two NamedElements may logically co-exist within a Namespace. By default, two named elements are distinguishable if (a) they have types neither of which is a kind of the other or (b) they have different names.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsDistinguishableFrom(NamedElement n, Namespace ns);
        /// <summary>
        /// The query separator() gives the string that is used to separate names when constructing a qualifiedName.
        /// </summary>
        /// <returns>
        /// </returns>
        string Separator();
    }
}
