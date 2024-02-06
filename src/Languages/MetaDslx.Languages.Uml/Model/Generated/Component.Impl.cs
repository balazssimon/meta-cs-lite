#nullable enable

namespace MetaDslx.Languages.Uml.Model.__Impl
{
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MetaModelObject = global::MetaDslx.Modeling.MetaModelObject;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelPropertyInfo = global::MetaDslx.Modeling.ModelPropertyInfo;
    using __ModelPropertySlot = global::MetaDslx.Modeling.ModelPropertySlot;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal class Component_Impl : __MetaModelObject, Component
    {
        private Component_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.Component_IsIndirectlyInstantiated)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Uml.Class_IsAbstract)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Class_IsActive)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Classifier_IsFinalSpecialization)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.RedefinableElement_IsLeaf)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.PackageableElement_Visibility)?.Add((global::MetaDslx.Languages.Uml.Model.VisibilityKind)MetaDslx.Languages.Uml.Model.VisibilityKind.Public);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.ParameterableElement(this);
            Uml.__CustomImpl.NamedElement(this);
            Uml.__CustomImpl.PackageableElement(this);
            Uml.__CustomImpl.Type(this);
            Uml.__CustomImpl.TemplateableElement(this);
            Uml.__CustomImpl.RedefinableElement(this);
            Uml.__CustomImpl.Namespace(this);
            Uml.__CustomImpl.Classifier(this);
            Uml.__CustomImpl.StructuredClassifier(this);
            Uml.__CustomImpl.EncapsulatedClassifier(this);
            Uml.__CustomImpl.BehavioredClassifier(this);
            Uml.__CustomImpl.Class(this);
            Uml.__CustomImpl.Component(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public bool IsIndirectlyInstantiated
        {
            get => MGet<bool>(Uml.Component_IsIndirectlyInstantiated);
            set => MSet<bool>(Uml.Component_IsIndirectlyInstantiated, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<PackageableElement> PackagedElement
        {
            get => MGetCollection<PackageableElement>(Uml.Component_PackagedElement);
        }
    
        public global::System.Collections.Generic.IList<Interface> Provided
        {
            get => Uml.__CustomImpl.Component_Provided(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ComponentRealization> Realization
        {
            get => MGetCollection<ComponentRealization>(Uml.Component_Realization);
        }
    
        public global::System.Collections.Generic.IList<Interface> Required
        {
            get => Uml.__CustomImpl.Component_Required(this);
        }
    
        public global::System.Collections.Generic.IList<Extension> Extension
        {
            get => Uml.__CustomImpl.Class_Extension(this);
        }
    
        public bool IsAbstract
        {
            get => MGet<bool>(Uml.Class_IsAbstract);
            set => MSet<bool>(Uml.Class_IsAbstract, value);
        }
    
        public bool IsActive
        {
            get => MGet<bool>(Uml.Class_IsActive);
            set => MSet<bool>(Uml.Class_IsActive, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Classifier> NestedClassifier
        {
            get => MGetCollection<Classifier>(Uml.Class_NestedClassifier);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Property> OwnedAttribute
        {
            get => MGetCollection<Property>(Uml.Class_OwnedAttribute);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Operation> OwnedOperation
        {
            get => MGetCollection<Operation>(Uml.Class_OwnedOperation);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Reception> OwnedReception
        {
            get => MGetCollection<Reception>(Uml.Class_OwnedReception);
        }
    
        public global::System.Collections.Generic.IList<Class> SuperClass
        {
            get => Uml.__CustomImpl.Class_SuperClass(this);
        }
    
        public Behavior ClassifierBehavior
        {
            get => MGet<Behavior>(Uml.BehavioredClassifier_ClassifierBehavior);
            set => MSet<Behavior>(Uml.BehavioredClassifier_ClassifierBehavior, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<InterfaceRealization> InterfaceRealization
        {
            get => MGetCollection<InterfaceRealization>(Uml.BehavioredClassifier_InterfaceRealization);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Behavior> OwnedBehavior
        {
            get => MGetCollection<Behavior>(Uml.BehavioredClassifier_OwnedBehavior);
        }
    
        public global::System.Collections.Generic.IList<Port> OwnedPort
        {
            get => Uml.__CustomImpl.EncapsulatedClassifier_OwnedPort(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::MetaDslx.Modeling.ICollectionSlot<Property> StructuredClassifier.OwnedAttribute
        {
            get => MGetCollection<Property>(Uml.StructuredClassifier_OwnedAttribute);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Connector> OwnedConnector
        {
            get => MGetCollection<Connector>(Uml.StructuredClassifier_OwnedConnector);
        }
    
        public global::System.Collections.Generic.IList<Property> Part
        {
            get => Uml.__CustomImpl.StructuredClassifier_Part(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ConnectableElement> Role
        {
            get => MGetCollection<ConnectableElement>(Uml.StructuredClassifier_Role);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Property> Attribute
        {
            get => MGetCollection<Property>(Uml.Classifier_Attribute);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<CollaborationUse> CollaborationUse
        {
            get => MGetCollection<CollaborationUse>(Uml.Classifier_CollaborationUse);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Feature> Feature
        {
            get => MGetCollection<Feature>(Uml.Classifier_Feature);
        }
    
        public global::System.Collections.Generic.IList<Classifier> General
        {
            get => Uml.__CustomImpl.Classifier_General(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Generalization> Generalization
        {
            get => MGetCollection<Generalization>(Uml.Classifier_Generalization);
        }
    
        public global::System.Collections.Generic.IList<NamedElement> InheritedMember
        {
            get => Uml.__CustomImpl.Classifier_InheritedMember(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        bool Classifier.IsAbstract
        {
            get => MGet<bool>(Uml.Classifier_IsAbstract);
            set => MSet<bool>(Uml.Classifier_IsAbstract, value);
        }
    
        public bool IsFinalSpecialization
        {
            get => MGet<bool>(Uml.Classifier_IsFinalSpecialization);
            set => MSet<bool>(Uml.Classifier_IsFinalSpecialization, value);
        }
    
        public Class NestingClass
        {
            get => MGet<Class>(Uml.Classifier_NestingClass);
            set => MSet<Class>(Uml.Classifier_NestingClass, value);
        }
    
        public RedefinableTemplateSignature OwnedTemplateSignature
        {
            get => MGet<RedefinableTemplateSignature>(Uml.Classifier_OwnedTemplateSignature);
            set => MSet<RedefinableTemplateSignature>(Uml.Classifier_OwnedTemplateSignature, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<UseCase> OwnedUseCase
        {
            get => MGetCollection<UseCase>(Uml.Classifier_OwnedUseCase);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<GeneralizationSet> PowertypeExtent
        {
            get => MGetCollection<GeneralizationSet>(Uml.Classifier_PowertypeExtent);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Classifier> RedefinedClassifier
        {
            get => MGetCollection<Classifier>(Uml.Classifier_RedefinedClassifier);
        }
    
        public CollaborationUse Representation
        {
            get => MGet<CollaborationUse>(Uml.Classifier_Representation);
            set => MSet<CollaborationUse>(Uml.Classifier_Representation, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Substitution> Substitution
        {
            get => MGetCollection<Substitution>(Uml.Classifier_Substitution);
        }
    
        public ClassifierTemplateParameter TemplateParameter
        {
            get => MGet<ClassifierTemplateParameter>(Uml.Classifier_TemplateParameter);
            set => MSet<ClassifierTemplateParameter>(Uml.Classifier_TemplateParameter, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<UseCase> UseCase
        {
            get => MGetCollection<UseCase>(Uml.Classifier_UseCase);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ElementImport> ElementImport
        {
            get => MGetCollection<ElementImport>(Uml.Namespace_ElementImport);
        }
    
        public global::System.Collections.Generic.IList<PackageableElement> ImportedMember
        {
            get => Uml.__CustomImpl.Namespace_ImportedMember(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<NamedElement> Member
        {
            get => MGetCollection<NamedElement>(Uml.Namespace_Member);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<NamedElement> OwnedMember
        {
            get => MGetCollection<NamedElement>(Uml.Namespace_OwnedMember);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> OwnedRule
        {
            get => MGetCollection<Constraint>(Uml.Namespace_OwnedRule);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<PackageImport> PackageImport
        {
            get => MGetCollection<PackageImport>(Uml.Namespace_PackageImport);
        }
    
        public bool IsLeaf
        {
            get => MGet<bool>(Uml.RedefinableElement_IsLeaf);
            set => MSet<bool>(Uml.RedefinableElement_IsLeaf, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<RedefinableElement> RedefinedElement
        {
            get => MGetCollection<RedefinableElement>(Uml.RedefinableElement_RedefinedElement);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Classifier> RedefinitionContext
        {
            get => MGetCollection<Classifier>(Uml.RedefinableElement_RedefinitionContext);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        TemplateSignature TemplateableElement.OwnedTemplateSignature
        {
            get => MGet<TemplateSignature>(Uml.TemplateableElement_OwnedTemplateSignature);
            set => MSet<TemplateSignature>(Uml.TemplateableElement_OwnedTemplateSignature, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<TemplateBinding> TemplateBinding
        {
            get => MGetCollection<TemplateBinding>(Uml.TemplateableElement_TemplateBinding);
        }
    
        public Package Package
        {
            get => MGet<Package>(Uml.Type_Package);
            set => MSet<Package>(Uml.Type_Package, value);
        }
    
        public global::MetaDslx.Languages.Uml.Model.VisibilityKind Visibility
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.PackageableElement_Visibility);
            set => MSet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.PackageableElement_Visibility, value);
        }
    
        public global::System.Collections.Generic.IList<Dependency> ClientDependency
        {
            get => Uml.__CustomImpl.NamedElement_ClientDependency(this);
        }
    
        public string Name
        {
            get => MGet<string>(Uml.NamedElement_Name);
            set => MSet<string>(Uml.NamedElement_Name, value);
        }
    
        public StringExpression NameExpression
        {
            get => MGet<StringExpression>(Uml.NamedElement_NameExpression);
            set => MSet<StringExpression>(Uml.NamedElement_NameExpression, value);
        }
    
        public Namespace Namespace
        {
            get => MGet<Namespace>(Uml.NamedElement_Namespace);
            set => MSet<Namespace>(Uml.NamedElement_Namespace, value);
        }
    
        public string QualifiedName
        {
            get => Uml.__CustomImpl.NamedElement_QualifiedName(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::MetaDslx.Languages.Uml.Model.VisibilityKind NamedElement.Visibility
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility);
            set => MSet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility, value);
        }
    
        public TemplateParameter OwningTemplateParameter
        {
            get => MGet<TemplateParameter>(Uml.ParameterableElement_OwningTemplateParameter);
            set => MSet<TemplateParameter>(Uml.ParameterableElement_OwningTemplateParameter, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        TemplateParameter ParameterableElement.TemplateParameter
        {
            get => MGet<TemplateParameter>(Uml.ParameterableElement_TemplateParameter);
            set => MSet<TemplateParameter>(Uml.ParameterableElement_TemplateParameter, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Comment> OwnedComment
        {
            get => MGetCollection<Comment>(Uml.Element_OwnedComment);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> OwnedElement
        {
            get => MGetCollection<Element>(Uml.Element_OwnedElement);
        }
    
        public Element Owner
        {
            get => MGet<Element>(Uml.Element_Owner);
            set => MSet<Element>(Uml.Element_Owner, value);
        }
    
    
        global::System.Collections.Generic.IList<ConnectableElement> StructuredClassifier.AllRoles() => Uml.__CustomImpl.StructuredClassifier_AllRoles(this);
        global::System.Collections.Generic.IList<Property> Classifier.AllAttributes() => Uml.__CustomImpl.Classifier_AllAttributes(this);
        global::System.Collections.Generic.IList<Feature> Classifier.AllFeatures() => Uml.__CustomImpl.Classifier_AllFeatures(this);
        global::System.Collections.Generic.IList<Classifier> Classifier.AllParents() => Uml.__CustomImpl.Classifier_AllParents(this);
        global::System.Collections.Generic.IList<Interface> Classifier.AllRealizedInterfaces() => Uml.__CustomImpl.Classifier_AllRealizedInterfaces(this);
        global::System.Collections.Generic.IList<StructuralFeature> Classifier.AllSlottableFeatures() => Uml.__CustomImpl.Classifier_AllSlottableFeatures(this);
        global::System.Collections.Generic.IList<Interface> Classifier.AllUsedInterfaces() => Uml.__CustomImpl.Classifier_AllUsedInterfaces(this);
        bool Classifier.ConformsTo(Type other) => Uml.__CustomImpl.Classifier_ConformsTo(this, other);
        global::System.Collections.Generic.IList<Interface> Classifier.DirectlyRealizedInterfaces() => Uml.__CustomImpl.Classifier_DirectlyRealizedInterfaces(this);
        global::System.Collections.Generic.IList<Interface> Classifier.DirectlyUsedInterfaces() => Uml.__CustomImpl.Classifier_DirectlyUsedInterfaces(this);
        bool Classifier.HasVisibilityOf(NamedElement n) => Uml.__CustomImpl.Classifier_HasVisibilityOf(this, n);
        global::System.Collections.Generic.IList<NamedElement> Classifier.Inherit(global::System.Collections.Generic.IList<NamedElement> inhs) => Uml.__CustomImpl.Classifier_Inherit(this, inhs);
        global::System.Collections.Generic.IList<NamedElement> Classifier.InheritableMembers(Classifier c) => Uml.__CustomImpl.Classifier_InheritableMembers(this, c);
        bool Classifier.IsSubstitutableFor(Classifier contract) => Uml.__CustomImpl.Classifier_IsSubstitutableFor(this, contract);
        bool Classifier.IsTemplate() => Uml.__CustomImpl.Classifier_IsTemplate(this);
        bool Classifier.MaySpecializeType(Classifier c) => Uml.__CustomImpl.Classifier_MaySpecializeType(this, c);
        global::System.Collections.Generic.IList<Classifier> Classifier.Parents() => Uml.__CustomImpl.Classifier_Parents(this);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ExcludeCollisions(global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ExcludeCollisions(this, imps);
        global::System.Collections.Generic.IList<string> Namespace.GetNamesOfMember(NamedElement element) => Uml.__CustomImpl.Namespace_GetNamesOfMember(this, element);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ImportMembers(global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ImportMembers(this, imps);
        bool Namespace.MembersAreDistinguishable() => Uml.__CustomImpl.Namespace_MembersAreDistinguishable(this);
        bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement) => Uml.__CustomImpl.RedefinableElement_IsConsistentWith(this, redefiningElement);
        bool RedefinableElement.IsRedefinitionContextValid(RedefinableElement redefinedElement) => Uml.__CustomImpl.RedefinableElement_IsRedefinitionContextValid(this, redefinedElement);
        bool TemplateableElement.IsTemplate() => Uml.__CustomImpl.Classifier_IsTemplate(this);
        global::System.Collections.Generic.IList<ParameterableElement> TemplateableElement.ParameterableElements() => Uml.__CustomImpl.TemplateableElement_ParameterableElements(this);
        bool Type.ConformsTo(Type other) => Uml.__CustomImpl.Classifier_ConformsTo(this, other);
        global::System.Collections.Generic.IList<Namespace> NamedElement.AllNamespaces() => Uml.__CustomImpl.NamedElement_AllNamespaces(this);
        global::System.Collections.Generic.IList<Package> NamedElement.AllOwningPackages() => Uml.__CustomImpl.NamedElement_AllOwningPackages(this);
        bool NamedElement.IsDistinguishableFrom(NamedElement n, Namespace ns) => Uml.__CustomImpl.NamedElement_IsDistinguishableFrom(this, n, ns);
        string NamedElement.Separator() => Uml.__CustomImpl.NamedElement_Separator(this);
        bool ParameterableElement.IsCompatibleWith(ParameterableElement p) => Uml.__CustomImpl.ParameterableElement_IsCompatibleWith(this, p);
        bool ParameterableElement.IsTemplateParameter() => Uml.__CustomImpl.ParameterableElement_IsTemplateParameter(this);
        global::System.Collections.Generic.IList<Element> Element.AllOwnedElements() => Uml.__CustomImpl.Element_AllOwnedElements(this);
        bool Element.MustBeOwned() => Uml.__CustomImpl.Element_MustBeOwned(this);
    
        internal class __Info : __ModelClassInfo
        {
            public static readonly __Info Instance = new __Info();
    
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _baseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _allBaseTypes;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _declaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _allDeclaredProperties;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelProperty> _publicProperties;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> _publicPropertiesByName;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> _modelPropertyInfos;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _declaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _allDeclaredOperations;
            private readonly global::System.Collections.Immutable.ImmutableArray<__ModelOperation> _publicOperations;
            private readonly global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> _modelOperationInfos;
    
            private __Info() 
            {
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.ClassInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.ClassInfo, Uml.BehavioredClassifierInfo, Uml.EncapsulatedClassifierInfo, Uml.StructuredClassifierInfo, Uml.ClassifierInfo, Uml.NamespaceInfo, Uml.RedefinableElementInfo, Uml.TemplateableElementInfo, Uml.TypeInfo, Uml.PackageableElementInfo, Uml.NamedElementInfo, Uml.ParameterableElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Component_IsIndirectlyInstantiated, Uml.Component_PackagedElement, Uml.Component_Provided, Uml.Component_Realization, Uml.Component_Required);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Component_IsIndirectlyInstantiated, Uml.Component_PackagedElement, Uml.Component_Provided, Uml.Component_Realization, Uml.Component_Required, Uml.Class_Extension, Uml.Class_IsAbstract, Uml.Class_IsActive, Uml.Class_NestedClassifier, Uml.Class_OwnedAttribute, Uml.Class_OwnedOperation, Uml.Class_OwnedReception, Uml.Class_SuperClass, Uml.BehavioredClassifier_ClassifierBehavior, Uml.BehavioredClassifier_InterfaceRealization, Uml.BehavioredClassifier_OwnedBehavior, Uml.EncapsulatedClassifier_OwnedPort, Uml.StructuredClassifier_OwnedAttribute, Uml.StructuredClassifier_OwnedConnector, Uml.StructuredClassifier_Part, Uml.StructuredClassifier_Role, Uml.Classifier_Attribute, Uml.Classifier_CollaborationUse, Uml.Classifier_Feature, Uml.Classifier_General, Uml.Classifier_Generalization, Uml.Classifier_InheritedMember, Uml.Classifier_IsAbstract, Uml.Classifier_IsFinalSpecialization, Uml.Classifier_NestingClass, Uml.Classifier_OwnedTemplateSignature, Uml.Classifier_OwnedUseCase, Uml.Classifier_PowertypeExtent, Uml.Classifier_RedefinedClassifier, Uml.Classifier_Representation, Uml.Classifier_Substitution, Uml.Classifier_TemplateParameter, Uml.Classifier_UseCase, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.TemplateableElement_OwnedTemplateSignature, Uml.TemplateableElement_TemplateBinding, Uml.Type_Package, Uml.PackageableElement_Visibility, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.ParameterableElement_OwningTemplateParameter, Uml.ParameterableElement_TemplateParameter, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Component_IsIndirectlyInstantiated, Uml.Component_PackagedElement, Uml.Component_Provided, Uml.Component_Realization, Uml.Component_Required, Uml.Class_Extension, Uml.Class_IsAbstract, Uml.Class_IsActive, Uml.Class_NestedClassifier, Uml.Class_OwnedAttribute, Uml.Class_OwnedOperation, Uml.Class_OwnedReception, Uml.Class_SuperClass, Uml.BehavioredClassifier_ClassifierBehavior, Uml.BehavioredClassifier_InterfaceRealization, Uml.BehavioredClassifier_OwnedBehavior, Uml.EncapsulatedClassifier_OwnedPort, Uml.StructuredClassifier_OwnedConnector, Uml.StructuredClassifier_Part, Uml.StructuredClassifier_Role, Uml.Classifier_Attribute, Uml.Classifier_CollaborationUse, Uml.Classifier_Feature, Uml.Classifier_General, Uml.Classifier_Generalization, Uml.Classifier_InheritedMember, Uml.Classifier_IsFinalSpecialization, Uml.Classifier_NestingClass, Uml.Classifier_OwnedTemplateSignature, Uml.Classifier_OwnedUseCase, Uml.Classifier_PowertypeExtent, Uml.Classifier_RedefinedClassifier, Uml.Classifier_Representation, Uml.Classifier_Substitution, Uml.Classifier_TemplateParameter, Uml.Classifier_UseCase, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.TemplateableElement_TemplateBinding, Uml.Type_Package, Uml.PackageableElement_Visibility, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.ParameterableElement_OwningTemplateParameter, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("IsIndirectlyInstantiated", Uml.Component_IsIndirectlyInstantiated);
                publicPropertiesByName.Add("PackagedElement", Uml.Component_PackagedElement);
                publicPropertiesByName.Add("Provided", Uml.Component_Provided);
                publicPropertiesByName.Add("Realization", Uml.Component_Realization);
                publicPropertiesByName.Add("Required", Uml.Component_Required);
                publicPropertiesByName.Add("Extension", Uml.Class_Extension);
                publicPropertiesByName.Add("IsAbstract", Uml.Class_IsAbstract);
                publicPropertiesByName.Add("IsActive", Uml.Class_IsActive);
                publicPropertiesByName.Add("NestedClassifier", Uml.Class_NestedClassifier);
                publicPropertiesByName.Add("OwnedAttribute", Uml.Class_OwnedAttribute);
                publicPropertiesByName.Add("OwnedOperation", Uml.Class_OwnedOperation);
                publicPropertiesByName.Add("OwnedReception", Uml.Class_OwnedReception);
                publicPropertiesByName.Add("SuperClass", Uml.Class_SuperClass);
                publicPropertiesByName.Add("ClassifierBehavior", Uml.BehavioredClassifier_ClassifierBehavior);
                publicPropertiesByName.Add("InterfaceRealization", Uml.BehavioredClassifier_InterfaceRealization);
                publicPropertiesByName.Add("OwnedBehavior", Uml.BehavioredClassifier_OwnedBehavior);
                publicPropertiesByName.Add("OwnedPort", Uml.EncapsulatedClassifier_OwnedPort);
                publicPropertiesByName.Add("OwnedConnector", Uml.StructuredClassifier_OwnedConnector);
                publicPropertiesByName.Add("Part", Uml.StructuredClassifier_Part);
                publicPropertiesByName.Add("Role", Uml.StructuredClassifier_Role);
                publicPropertiesByName.Add("Attribute", Uml.Classifier_Attribute);
                publicPropertiesByName.Add("CollaborationUse", Uml.Classifier_CollaborationUse);
                publicPropertiesByName.Add("Feature", Uml.Classifier_Feature);
                publicPropertiesByName.Add("General", Uml.Classifier_General);
                publicPropertiesByName.Add("Generalization", Uml.Classifier_Generalization);
                publicPropertiesByName.Add("InheritedMember", Uml.Classifier_InheritedMember);
                publicPropertiesByName.Add("IsFinalSpecialization", Uml.Classifier_IsFinalSpecialization);
                publicPropertiesByName.Add("NestingClass", Uml.Classifier_NestingClass);
                publicPropertiesByName.Add("OwnedTemplateSignature", Uml.Classifier_OwnedTemplateSignature);
                publicPropertiesByName.Add("OwnedUseCase", Uml.Classifier_OwnedUseCase);
                publicPropertiesByName.Add("PowertypeExtent", Uml.Classifier_PowertypeExtent);
                publicPropertiesByName.Add("RedefinedClassifier", Uml.Classifier_RedefinedClassifier);
                publicPropertiesByName.Add("Representation", Uml.Classifier_Representation);
                publicPropertiesByName.Add("Substitution", Uml.Classifier_Substitution);
                publicPropertiesByName.Add("TemplateParameter", Uml.Classifier_TemplateParameter);
                publicPropertiesByName.Add("UseCase", Uml.Classifier_UseCase);
                publicPropertiesByName.Add("ElementImport", Uml.Namespace_ElementImport);
                publicPropertiesByName.Add("ImportedMember", Uml.Namespace_ImportedMember);
                publicPropertiesByName.Add("Member", Uml.Namespace_Member);
                publicPropertiesByName.Add("OwnedMember", Uml.Namespace_OwnedMember);
                publicPropertiesByName.Add("OwnedRule", Uml.Namespace_OwnedRule);
                publicPropertiesByName.Add("PackageImport", Uml.Namespace_PackageImport);
                publicPropertiesByName.Add("IsLeaf", Uml.RedefinableElement_IsLeaf);
                publicPropertiesByName.Add("RedefinedElement", Uml.RedefinableElement_RedefinedElement);
                publicPropertiesByName.Add("RedefinitionContext", Uml.RedefinableElement_RedefinitionContext);
                publicPropertiesByName.Add("TemplateBinding", Uml.TemplateableElement_TemplateBinding);
                publicPropertiesByName.Add("Package", Uml.Type_Package);
                publicPropertiesByName.Add("Visibility", Uml.PackageableElement_Visibility);
                publicPropertiesByName.Add("ClientDependency", Uml.NamedElement_ClientDependency);
                publicPropertiesByName.Add("Name", Uml.NamedElement_Name);
                publicPropertiesByName.Add("NameExpression", Uml.NamedElement_NameExpression);
                publicPropertiesByName.Add("Namespace", Uml.NamedElement_Namespace);
                publicPropertiesByName.Add("QualifiedName", Uml.NamedElement_QualifiedName);
                publicPropertiesByName.Add("OwningTemplateParameter", Uml.ParameterableElement_OwningTemplateParameter);
                publicPropertiesByName.Add("OwnedComment", Uml.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Uml.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Uml.Element_Owner);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Uml.Component_IsIndirectlyInstantiated, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Component_IsIndirectlyInstantiated, __ImmutableArray.Create<__ModelProperty>(Uml.Component_IsIndirectlyInstantiated), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Component_PackagedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Component_PackagedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Component_PackagedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Component_Provided, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Component_Provided, __ImmutableArray.Create<__ModelProperty>(Uml.Component_Provided), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Component_Realization, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Component_Realization, __ImmutableArray.Create<__ModelProperty>(Uml.Component_Realization), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ComponentRealization_Abstraction), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Component_Required, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Component_Required, __ImmutableArray.Create<__ModelProperty>(Uml.Component_Required), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_Extension, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_Extension, __ImmutableArray.Create<__ModelProperty>(Uml.Class_Extension), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Extension_Metaclass), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Uml.Class_IsAbstract, Uml.Classifier_IsAbstract), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_IsAbstract), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_IsAbstract), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_IsActive, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_IsActive, __ImmutableArray.Create<__ModelProperty>(Uml.Class_IsActive), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_NestedClassifier, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_NestedClassifier, __ImmutableArray.Create<__ModelProperty>(Uml.Class_NestedClassifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_NestingClass), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_OwnedAttribute, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_OwnedAttribute, __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedAttribute, Uml.StructuredClassifier_OwnedAttribute), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Property_Class), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Attribute, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_OwnedOperation, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_OwnedOperation, __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedOperation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Operation_Class), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Feature, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_OwnedReception, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_OwnedReception, __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedReception), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Feature, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Class_SuperClass, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_SuperClass, __ImmutableArray.Create<__ModelProperty>(Uml.Class_SuperClass, Uml.Classifier_General), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_General), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioredClassifier_ClassifierBehavior, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.BehavioredClassifier_ClassifierBehavior, __ImmutableArray.Create<__ModelProperty>(Uml.BehavioredClassifier_ClassifierBehavior), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioredClassifier_OwnedBehavior), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioredClassifier_InterfaceRealization, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.BehavioredClassifier_InterfaceRealization, __ImmutableArray.Create<__ModelProperty>(Uml.BehavioredClassifier_InterfaceRealization), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.InterfaceRealization_ImplementingClassifier), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.NamedElement_ClientDependency), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.BehavioredClassifier_OwnedBehavior, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.BehavioredClassifier_OwnedBehavior, __ImmutableArray.Create<__ModelProperty>(Uml.BehavioredClassifier_OwnedBehavior), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioredClassifier_ClassifierBehavior), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.EncapsulatedClassifier_OwnedPort, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.EncapsulatedClassifier_OwnedPort, __ImmutableArray.Create<__ModelProperty>(Uml.EncapsulatedClassifier_OwnedPort), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredClassifier_OwnedAttribute, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_OwnedAttribute, __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedAttribute, Uml.StructuredClassifier_OwnedAttribute), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Attribute, Uml.Namespace_OwnedMember, Uml.StructuredClassifier_Role), __ImmutableArray.Create<__ModelProperty>(Uml.EncapsulatedClassifier_OwnedPort), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedAttribute)));
                modelPropertyInfos.Add(Uml.StructuredClassifier_OwnedConnector, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredClassifier_OwnedConnector, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_OwnedConnector), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Feature, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredClassifier_Part, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredClassifier_Part, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_Part), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredClassifier_Role, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredClassifier_Role, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_Role), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_Attribute, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_Attribute, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Attribute), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Feature), __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedAttribute, Uml.StructuredClassifier_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_CollaborationUse, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_CollaborationUse, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_CollaborationUse), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Representation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_Feature, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_Feature, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Feature), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Feature_FeaturingClassifier), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(Uml.Class_OwnedOperation, Uml.Class_OwnedReception, Uml.StructuredClassifier_OwnedConnector, Uml.Classifier_Attribute), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_General, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_SuperClass, __ImmutableArray.Create<__ModelProperty>(Uml.Class_SuperClass, Uml.Classifier_General), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Class_SuperClass), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_Generalization, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_Generalization, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Generalization), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Generalization_Specific), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_InheritedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_InheritedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_InheritedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Class_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Uml.Class_IsAbstract, Uml.Classifier_IsAbstract), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Class_IsAbstract), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Class_IsAbstract)));
                modelPropertyInfos.Add(Uml.Classifier_IsFinalSpecialization, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_IsFinalSpecialization, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_IsFinalSpecialization), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_NestingClass, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_NestingClass, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_NestingClass), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Class_NestedClassifier), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_OwnedTemplateSignature, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_OwnedTemplateSignature, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_OwnedTemplateSignature, Uml.TemplateableElement_OwnedTemplateSignature), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableTemplateSignature_Classifier), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateableElement_OwnedTemplateSignature), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateableElement_OwnedTemplateSignature), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_OwnedUseCase, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_OwnedUseCase, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_OwnedUseCase), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_PowertypeExtent, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_PowertypeExtent, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_PowertypeExtent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.GeneralizationSet_Powertype), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_RedefinedClassifier, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_RedefinedClassifier, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_RedefinedClassifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_Representation, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_Representation, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Representation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_CollaborationUse), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_Substitution, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_Substitution, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_Substitution), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Substitution_SubstitutingClassifier), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.NamedElement_ClientDependency), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.ClassifierTemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Classifier_UseCase, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_UseCase, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_UseCase), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.UseCase_Subject), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ElementImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ElementImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ElementImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ElementImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ImportedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ImportedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ImportedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_Member, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_Member, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredClassifier_Role, Uml.Classifier_Feature, Uml.Classifier_InheritedMember, Uml.Namespace_ImportedMember, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(Uml.Component_PackagedElement, Uml.Class_NestedClassifier, Uml.Class_OwnedAttribute, Uml.Class_OwnedOperation, Uml.Class_OwnedReception, Uml.BehavioredClassifier_OwnedBehavior, Uml.StructuredClassifier_OwnedAttribute, Uml.StructuredClassifier_OwnedConnector, Uml.Classifier_OwnedUseCase, Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedRule, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedRule, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Constraint_Context), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_PackageImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_PackageImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_PackageImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.PackageImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_IsLeaf, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_IsLeaf, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_IsLeaf), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinedElement, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_RedefinedClassifier), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinitionContext, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinitionContext, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinitionContext), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.TemplateableElement_OwnedTemplateSignature, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_OwnedTemplateSignature, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_OwnedTemplateSignature, Uml.TemplateableElement_OwnedTemplateSignature), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateSignature_Template), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_OwnedTemplateSignature), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_OwnedTemplateSignature)));
                modelPropertyInfos.Add(Uml.TemplateableElement_TemplateBinding, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.TemplateableElement_TemplateBinding, __ImmutableArray.Create<__ModelProperty>(Uml.TemplateableElement_TemplateBinding), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateBinding_BoundElement), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Type_Package, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Type_Package, __ImmutableArray.Create<__ModelProperty>(Uml.Type_Package), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Package_OwnedType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.PackageableElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.PackageableElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility, Uml.NamedElement_Visibility), MetaDslx.Languages.Uml.Model.VisibilityKind.Public, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_ClientDependency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_ClientDependency, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_ClientDependency), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Dependency_Client), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.BehavioredClassifier_InterfaceRealization, Uml.Classifier_Substitution), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_NameExpression, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_NameExpression, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_NameExpression), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_NestingClass), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.PackageableElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility, Uml.NamedElement_Visibility), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.PackageableElement_Visibility)));
                modelPropertyInfos.Add(Uml.ParameterableElement_OwningTemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ParameterableElement_OwningTemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_OwnedParameteredElement), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner, Uml.ParameterableElement_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ParameterableElement_TemplateParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Classifier_TemplateParameter, __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_TemplateParameter, Uml.ParameterableElement_TemplateParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.TemplateParameter_ParameteredElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_TemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Classifier_TemplateParameter)));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Component_Realization, Uml.BehavioredClassifier_InterfaceRealization, Uml.Classifier_CollaborationUse, Uml.Classifier_Generalization, Uml.Classifier_Substitution, Uml.Namespace_ElementImport, Uml.Namespace_OwnedMember, Uml.Namespace_PackageImport, Uml.TemplateableElement_OwnedTemplateSignature, Uml.TemplateableElement_TemplateBinding, Uml.NamedElement_NameExpression, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace, Uml.ParameterableElement_OwningTemplateParameter), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.StructuredClassifier_AllRoles, Uml.Classifier_AllAttributes, Uml.Classifier_AllFeatures, Uml.Classifier_AllParents, Uml.Classifier_AllRealizedInterfaces, Uml.Classifier_AllSlottableFeatures, Uml.Classifier_AllUsedInterfaces, Uml.Classifier_ConformsTo, Uml.Classifier_DirectlyRealizedInterfaces, Uml.Classifier_DirectlyUsedInterfaces, Uml.Classifier_HasVisibilityOf, Uml.Classifier_Inherit, Uml.Classifier_InheritableMembers, Uml.Classifier_IsSubstitutableFor, Uml.Classifier_IsTemplate, Uml.Classifier_MaySpecializeType, Uml.Classifier_Parents, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.RedefinableElement_IsConsistentWith, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.TemplateableElement_IsTemplate, Uml.TemplateableElement_ParameterableElements, Uml.Type_ConformsTo, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.StructuredClassifier_AllRoles, Uml.Classifier_AllAttributes, Uml.Classifier_AllFeatures, Uml.Classifier_AllParents, Uml.Classifier_AllRealizedInterfaces, Uml.Classifier_AllSlottableFeatures, Uml.Classifier_AllUsedInterfaces, Uml.Classifier_ConformsTo, Uml.Classifier_DirectlyRealizedInterfaces, Uml.Classifier_DirectlyUsedInterfaces, Uml.Classifier_HasVisibilityOf, Uml.Classifier_Inherit, Uml.Classifier_InheritableMembers, Uml.Classifier_IsSubstitutableFor, Uml.Classifier_IsTemplate, Uml.Classifier_MaySpecializeType, Uml.Classifier_Parents, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.RedefinableElement_IsConsistentWith, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.TemplateableElement_ParameterableElements, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.ParameterableElement_IsCompatibleWith, Uml.ParameterableElement_IsTemplateParameter, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.StructuredClassifier_AllRoles, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_AllAttributes, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_AllFeatures, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_AllParents, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_AllRealizedInterfaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_AllSlottableFeatures, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_AllUsedInterfaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_ConformsTo, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.Type_ConformsTo), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_DirectlyRealizedInterfaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_DirectlyUsedInterfaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_HasVisibilityOf, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_Inherit, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_InheritableMembers, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_IsSubstitutableFor, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_IsTemplate, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.TemplateableElement_IsTemplate), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_MaySpecializeType, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Classifier_Parents, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ExcludeCollisions, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_GetNamesOfMember, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ImportMembers, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_MembersAreDistinguishable, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsRedefinitionContextValid, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.TemplateableElement_IsTemplate, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.Classifier_IsTemplate)));
                    modelOperationInfos.Add(Uml.TemplateableElement_ParameterableElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Type_ConformsTo, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.Classifier_ConformsTo)));
                    modelOperationInfos.Add(Uml.NamedElement_AllNamespaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllOwningPackages, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_IsDistinguishableFrom, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_Separator, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsCompatibleWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ParameterableElement_IsTemplateParameter, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(Component);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
            public override __ModelProperty? NameProperty => null;
            public override __ModelProperty? TypeProperty => null;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> BaseTypes => _baseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> AllBaseTypes => _allBaseTypes;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> DeclaredProperties => _declaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> AllDeclaredProperties => _allDeclaredProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelProperty> PublicProperties => _publicProperties;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> DeclaredOperations => _declaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> AllDeclaredOperations => _allDeclaredOperations;
            public override global::System.Collections.Immutable.ImmutableArray<__ModelOperation> PublicOperations => _publicOperations;
    
            protected override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelProperty> PublicPropertiesByName => _publicPropertiesByName;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty, __ModelPropertyInfo> ModelPropertyInfos => _modelPropertyInfos;
            protected override global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation, __ModelOperationInfo> ModelOperationInfos => _modelOperationInfos;
    
            public override __IModelObject? Create(__Model? model = null, string? id = null)
            {
                var result = new Component_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.ComponentInfo";
            }
        }
    }
}
