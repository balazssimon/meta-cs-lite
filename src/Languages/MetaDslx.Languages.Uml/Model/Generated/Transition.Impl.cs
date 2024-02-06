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

    internal class Transition_Impl : __MetaModelObject, Transition
    {
        private Transition_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.Transition_Kind)?.Add((global::MetaDslx.Languages.Uml.Model.TransitionKind)MetaDslx.Languages.Uml.Model.TransitionKind.External);
            ((__IModelObject)this).MGetSlot(Uml.RedefinableElement_IsLeaf)?.Add((bool)false);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.NamedElement(this);
            Uml.__CustomImpl.RedefinableElement(this);
            Uml.__CustomImpl.Namespace(this);
            Uml.__CustomImpl.Transition(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public Region Container
        {
            get => MGet<Region>(Uml.Transition_Container);
            set => MSet<Region>(Uml.Transition_Container, value);
        }
    
        public Behavior Effect
        {
            get => MGet<Behavior>(Uml.Transition_Effect);
            set => MSet<Behavior>(Uml.Transition_Effect, value);
        }
    
        public Constraint Guard
        {
            get => MGet<Constraint>(Uml.Transition_Guard);
            set => MSet<Constraint>(Uml.Transition_Guard, value);
        }
    
        public global::MetaDslx.Languages.Uml.Model.TransitionKind Kind
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.TransitionKind>(Uml.Transition_Kind);
            set => MSet<global::MetaDslx.Languages.Uml.Model.TransitionKind>(Uml.Transition_Kind, value);
        }
    
        public Transition RedefinedTransition
        {
            get => MGet<Transition>(Uml.Transition_RedefinedTransition);
            set => MSet<Transition>(Uml.Transition_RedefinedTransition, value);
        }
    
        public Classifier RedefinitionContext
        {
            get => Uml.__CustomImpl.Transition_RedefinitionContext(this);
        }
    
        public Vertex Source
        {
            get => MGet<Vertex>(Uml.Transition_Source);
            set => MSet<Vertex>(Uml.Transition_Source, value);
        }
    
        public Vertex Target
        {
            get => MGet<Vertex>(Uml.Transition_Target);
            set => MSet<Vertex>(Uml.Transition_Target, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Trigger> Trigger
        {
            get => MGetCollection<Trigger>(Uml.Transition_Trigger);
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
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> RedefinableElement.RedefinitionContext
        {
            get => MGetCollection<Classifier>(Uml.RedefinableElement_RedefinitionContext);
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
    
        public global::MetaDslx.Languages.Uml.Model.VisibilityKind Visibility
        {
            get => MGet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility);
            set => MSet<global::MetaDslx.Languages.Uml.Model.VisibilityKind>(Uml.NamedElement_Visibility, value);
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
    
    
        StateMachine Transition.ContainingStateMachine() => Uml.__CustomImpl.Transition_ContainingStateMachine(this);
        bool Transition.IsConsistentWith(RedefinableElement redefiningElement) => Uml.__CustomImpl.Transition_IsConsistentWith(this, redefiningElement);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ExcludeCollisions(global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ExcludeCollisions(this, imps);
        global::System.Collections.Generic.IList<string> Namespace.GetNamesOfMember(NamedElement element) => Uml.__CustomImpl.Namespace_GetNamesOfMember(this, element);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ImportMembers(global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ImportMembers(this, imps);
        bool Namespace.MembersAreDistinguishable() => Uml.__CustomImpl.Namespace_MembersAreDistinguishable(this);
        bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement) => Uml.__CustomImpl.Transition_IsConsistentWith(this, redefiningElement);
        bool RedefinableElement.IsRedefinitionContextValid(RedefinableElement redefinedElement) => Uml.__CustomImpl.RedefinableElement_IsRedefinitionContextValid(this, redefinedElement);
        global::System.Collections.Generic.IList<Namespace> NamedElement.AllNamespaces() => Uml.__CustomImpl.NamedElement_AllNamespaces(this);
        global::System.Collections.Generic.IList<Package> NamedElement.AllOwningPackages() => Uml.__CustomImpl.NamedElement_AllOwningPackages(this);
        bool NamedElement.IsDistinguishableFrom(NamedElement n, Namespace ns) => Uml.__CustomImpl.NamedElement_IsDistinguishableFrom(this, n, ns);
        string NamedElement.Separator() => Uml.__CustomImpl.NamedElement_Separator(this);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.NamespaceInfo, Uml.RedefinableElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.NamespaceInfo, Uml.RedefinableElementInfo, Uml.NamedElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Container, Uml.Transition_Effect, Uml.Transition_Guard, Uml.Transition_Kind, Uml.Transition_RedefinedTransition, Uml.Transition_RedefinitionContext, Uml.Transition_Source, Uml.Transition_Target, Uml.Transition_Trigger);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Container, Uml.Transition_Effect, Uml.Transition_Guard, Uml.Transition_Kind, Uml.Transition_RedefinedTransition, Uml.Transition_RedefinitionContext, Uml.Transition_Source, Uml.Transition_Target, Uml.Transition_Trigger, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Container, Uml.Transition_Effect, Uml.Transition_Guard, Uml.Transition_Kind, Uml.Transition_RedefinedTransition, Uml.Transition_RedefinitionContext, Uml.Transition_Source, Uml.Transition_Target, Uml.Transition_Trigger, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Container", Uml.Transition_Container);
                publicPropertiesByName.Add("Effect", Uml.Transition_Effect);
                publicPropertiesByName.Add("Guard", Uml.Transition_Guard);
                publicPropertiesByName.Add("Kind", Uml.Transition_Kind);
                publicPropertiesByName.Add("RedefinedTransition", Uml.Transition_RedefinedTransition);
                publicPropertiesByName.Add("RedefinitionContext", Uml.Transition_RedefinitionContext);
                publicPropertiesByName.Add("Source", Uml.Transition_Source);
                publicPropertiesByName.Add("Target", Uml.Transition_Target);
                publicPropertiesByName.Add("Trigger", Uml.Transition_Trigger);
                publicPropertiesByName.Add("ElementImport", Uml.Namespace_ElementImport);
                publicPropertiesByName.Add("ImportedMember", Uml.Namespace_ImportedMember);
                publicPropertiesByName.Add("Member", Uml.Namespace_Member);
                publicPropertiesByName.Add("OwnedMember", Uml.Namespace_OwnedMember);
                publicPropertiesByName.Add("OwnedRule", Uml.Namespace_OwnedRule);
                publicPropertiesByName.Add("PackageImport", Uml.Namespace_PackageImport);
                publicPropertiesByName.Add("IsLeaf", Uml.RedefinableElement_IsLeaf);
                publicPropertiesByName.Add("RedefinedElement", Uml.RedefinableElement_RedefinedElement);
                publicPropertiesByName.Add("ClientDependency", Uml.NamedElement_ClientDependency);
                publicPropertiesByName.Add("Name", Uml.NamedElement_Name);
                publicPropertiesByName.Add("NameExpression", Uml.NamedElement_NameExpression);
                publicPropertiesByName.Add("Namespace", Uml.NamedElement_Namespace);
                publicPropertiesByName.Add("QualifiedName", Uml.NamedElement_QualifiedName);
                publicPropertiesByName.Add("Visibility", Uml.NamedElement_Visibility);
                publicPropertiesByName.Add("OwnedComment", Uml.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Uml.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Uml.Element_Owner);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Uml.Transition_Container, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_Container, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Container), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Region_Transition), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_Effect, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_Effect, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Effect), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_Guard, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_Guard, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Guard), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_Kind, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_Kind, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Kind), MetaDslx.Languages.Uml.Model.TransitionKind.External, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_RedefinedTransition, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_RedefinedTransition, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_RedefinedTransition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_RedefinitionContext, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_RedefinitionContext, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_RedefinitionContext, Uml.RedefinableElement_RedefinitionContext), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Collection | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinitionContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinitionContext), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_Source, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_Source, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Source), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Vertex_Outgoing), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_Target, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_Target, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Target), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Vertex_Incoming), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Transition_Trigger, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_Trigger, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Trigger), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ElementImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ElementImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ElementImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ElementImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ImportedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ImportedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ImportedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_Member, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_Member, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ImportedMember, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedRule, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedRule, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Constraint_Context), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Guard), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_PackageImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_PackageImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_PackageImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.PackageImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_IsLeaf, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_IsLeaf, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_IsLeaf), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinedElement, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Transition_RedefinedTransition), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinitionContext, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Transition_RedefinitionContext, __ImmutableArray.Create<__ModelProperty>(Uml.Transition_RedefinitionContext, Uml.RedefinableElement_RedefinitionContext), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Collection | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Transition_RedefinitionContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Transition_RedefinitionContext)));
                modelPropertyInfos.Add(Uml.NamedElement_ClientDependency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_ClientDependency, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_ClientDependency), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Dependency_Client), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_NameExpression, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_NameExpression, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_NameExpression), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Container), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Transition_Effect, Uml.Transition_Trigger, Uml.Namespace_ElementImport, Uml.Namespace_OwnedMember, Uml.Namespace_PackageImport, Uml.NamedElement_NameExpression, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Transition_ContainingStateMachine, Uml.Transition_IsConsistentWith);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Transition_ContainingStateMachine, Uml.Transition_IsConsistentWith, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.RedefinableElement_IsConsistentWith, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.Transition_ContainingStateMachine, Uml.Transition_IsConsistentWith, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.Transition_ContainingStateMachine, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Transition_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.RedefinableElement_IsConsistentWith), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ExcludeCollisions, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_GetNamesOfMember, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ImportMembers, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_MembersAreDistinguishable, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.Transition_IsConsistentWith)));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsRedefinitionContextValid, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllNamespaces, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_AllOwningPackages, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_IsDistinguishableFrom, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.NamedElement_Separator, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_AllOwnedElements, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Element_MustBeOwned, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Uml.MInstance;
            public override __MetaType MetaType => typeof(Transition);
    
            public override __MetaType SymbolType => default;
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
                var result = new Transition_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.TransitionInfo";
            }
        }
    }
}
