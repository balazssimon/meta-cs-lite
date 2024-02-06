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
    /// A Namespace is an Element in a model that owns and/or imports a set of NamedElements that can be identified by name.
    /// </summary>
    public interface Namespace : global::MetaDslx.Languages.Uml.Model.NamedElement
    {
        /// <summary>
        /// References the ElementImports owned by the Namespace.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ElementImport> ElementImport { get; }
        /// <summary>
        /// References the PackageableElements that are members of this Namespace as a result of either PackageImports or ElementImports.
        /// </summary>
        global::System.Collections.Generic.IList<PackageableElement> ImportedMember { get; }
        /// <summary>
        /// A collection of NamedElements identifiable within the Namespace, either by being owned or by being introduced by importing or inheritance.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<NamedElement> Member { get; }
        /// <summary>
        /// A collection of NamedElements owned by the Namespace.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<NamedElement> OwnedMember { get; }
        /// <summary>
        /// Specifies a set of Constraints owned by this Namespace.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> OwnedRule { get; }
        /// <summary>
        /// References the PackageImports owned by the Namespace.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<PackageImport> PackageImport { get; }
    
        /// <summary>
        /// The query excludeCollisions() excludes from a set of PackageableElements any that would not be distinguishable from each other in this Namespace.
        /// </summary>
        /// <param name="imps">
        /// </param>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<PackageableElement> ExcludeCollisions(global::System.Collections.Generic.IList<PackageableElement> imps);
        /// <summary>
        /// The query getNamesOfMember() gives a set of all of the names that a member would have in a Namespace, taking importing into account. In general a member can have multiple names in a Namespace if it is imported more than once with different aliases.
        /// </summary>
        /// <param name="element">
        /// </param>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<string> GetNamesOfMember(NamedElement element);
        /// <summary>
        /// The query importMembers() defines which of a set of PackageableElements are actually imported into the Namespace. This excludes hidden ones, i.e., those which have names that conflict with names of ownedMembers, and it also excludes PackageableElements that would have the indistinguishable names when imported.
        /// </summary>
        /// <param name="imps">
        /// </param>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<PackageableElement> ImportMembers(global::System.Collections.Generic.IList<PackageableElement> imps);
        /// <summary>
        /// The Boolean query membersAreDistinguishable() determines whether all of the Namespace&apos;s members are distinguishable within it.
        /// </summary>
        /// <returns>
        /// </returns>
        bool MembersAreDistinguishable();
    }
}
