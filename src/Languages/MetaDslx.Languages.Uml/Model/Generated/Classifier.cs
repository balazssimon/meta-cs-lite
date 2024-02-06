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

    public interface Classifier : global::MetaDslx.Languages.Uml.Model.Namespace, global::MetaDslx.Languages.Uml.Model.Type, global::MetaDslx.Languages.Uml.Model.TemplateableElement, global::MetaDslx.Languages.Uml.Model.RedefinableElement
    {
        global::MetaDslx.Modeling.ICollectionSlot<Property> Attribute { get; }
        global::MetaDslx.Modeling.ICollectionSlot<CollaborationUse> CollaborationUse { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Feature> Feature { get; }
        global::System.Collections.Generic.IList<Classifier> General { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Generalization> Generalization { get; }
        global::System.Collections.Generic.IList<NamedElement> InheritedMember { get; }
        bool IsAbstract { get; set; }
        bool IsFinalSpecialization { get; set; }
        new RedefinableTemplateSignature OwnedTemplateSignature { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<UseCase> OwnedUseCase { get; }
        global::MetaDslx.Modeling.ICollectionSlot<GeneralizationSet> PowertypeExtent { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> RedefinedClassifier { get; }
        CollaborationUse Representation { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Substitution> Substitution { get; }
        new ClassifierTemplateParameter TemplateParameter { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<UseCase> UseCase { get; }
    
        global::MetaDslx.Modeling.ICollectionSlot<Feature> AllFeatures(global::MetaDslx.Modeling.ICollectionSlot<Feature> result);
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> AllParents(global::MetaDslx.Modeling.ICollectionSlot<Classifier> result);
        bool ConformsTo(bool result, Type other);
        bool HasVisibilityOf(bool result, NamedElement n);
        global::MetaDslx.Modeling.ICollectionSlot<NamedElement> Inherit(global::MetaDslx.Modeling.ICollectionSlot<NamedElement> result, global::MetaDslx.Modeling.ICollectionSlot<NamedElement> inhs);
        global::MetaDslx.Modeling.ICollectionSlot<NamedElement> InheritableMembers(global::MetaDslx.Modeling.ICollectionSlot<NamedElement> result, Classifier c);
        bool IsTemplate(bool result);
        bool MaySpecializeType(bool result, Classifier c);
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> Parents(global::MetaDslx.Modeling.ICollectionSlot<Classifier> result);
        global::MetaDslx.Modeling.ICollectionSlot<Interface> DirectlyRealizedInterfaces(global::MetaDslx.Modeling.ICollectionSlot<Interface> result);
        global::MetaDslx.Modeling.ICollectionSlot<Interface> DirectlyUsedInterfaces(global::MetaDslx.Modeling.ICollectionSlot<Interface> result);
        global::MetaDslx.Modeling.ICollectionSlot<Interface> AllRealizedInterfaces(global::MetaDslx.Modeling.ICollectionSlot<Interface> result);
        global::MetaDslx.Modeling.ICollectionSlot<Interface> AllUsedInterfaces(global::MetaDslx.Modeling.ICollectionSlot<Interface> result);
        bool IsSubstitutableFor(Classifier contract, bool result);
        global::MetaDslx.Modeling.ICollectionSlot<Property> AllAttributes(global::MetaDslx.Modeling.ICollectionSlot<Property> result);
        global::MetaDslx.Modeling.ICollectionSlot<StructuralFeature> AllSlottableFeatures(global::MetaDslx.Modeling.ICollectionSlot<StructuralFeature> result);
    }
}
