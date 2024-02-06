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

    public interface Package : global::MetaDslx.Languages.Uml.Model.PackageableElement, global::MetaDslx.Languages.Uml.Model.TemplateableElement, global::MetaDslx.Languages.Uml.Model.Namespace
    {
        global::MetaDslx.Modeling.ICollectionSlot<Package> NestedPackage { get; }
        Package NestingPackage { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Stereotype> OwnedStereotype { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Type> OwnedType { get; }
        global::MetaDslx.Modeling.ICollectionSlot<PackageableElement> PackagedElement { get; }
        global::MetaDslx.Modeling.ICollectionSlot<PackageMerge> PackageMerge { get; }
        global::MetaDslx.Modeling.ICollectionSlot<ProfileApplication> ProfileApplication { get; }
        string URI { get; set; }
    
        global::System.Collections.Generic.IList<Stereotype> AllApplicableStereotypes();
        Profile ContainingProfile();
        bool MakesVisible(NamedElement el);
        bool MustBeOwned();
        global::System.Collections.Generic.IList<PackageableElement> VisibleMembers();
    }
}
