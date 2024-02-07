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

    internal class SequenceNode_Impl : __MetaModelObject, SequenceNode
    {
        private SequenceNode_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Uml.StructuredActivityNode_MustIsolate)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.Action_IsLocallyReentrant)?.Add((bool)false);
            ((__IModelObject)this).MGetSlot(Uml.RedefinableElement_IsLeaf)?.Add((bool)false);
            Uml.__CustomImpl.Element(this);
            Uml.__CustomImpl.NamedElement(this);
            Uml.__CustomImpl.RedefinableElement(this);
            Uml.__CustomImpl.Namespace(this);
            Uml.__CustomImpl.ActivityNode(this);
            Uml.__CustomImpl.ExecutableNode(this);
            Uml.__CustomImpl.ActivityGroup(this);
            Uml.__CustomImpl.Action(this);
            Uml.__CustomImpl.StructuredActivityNode(this);
            Uml.__CustomImpl.SequenceNode(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<ExecutableNode> ExecutableNode
        {
            get => MGetCollection<ExecutableNode>(Uml.SequenceNode_ExecutableNode);
        }
    
        public Activity Activity
        {
            get => MGet<Activity>(Uml.StructuredActivityNode_Activity);
            set => MSet<Activity>(Uml.StructuredActivityNode_Activity, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Edge
        {
            get => MGetCollection<ActivityEdge>(Uml.StructuredActivityNode_Edge);
        }
    
        public bool MustIsolate
        {
            get => MGet<bool>(Uml.StructuredActivityNode_MustIsolate);
            set => MSet<bool>(Uml.StructuredActivityNode_MustIsolate, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> Node
        {
            get => MGetCollection<ActivityNode>(Uml.StructuredActivityNode_Node);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<InputPin> StructuredNodeInput
        {
            get => MGetCollection<InputPin>(Uml.StructuredActivityNode_StructuredNodeInput);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<OutputPin> StructuredNodeOutput
        {
            get => MGetCollection<OutputPin>(Uml.StructuredActivityNode_StructuredNodeOutput);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Variable> Variable
        {
            get => MGetCollection<Variable>(Uml.StructuredActivityNode_Variable);
        }
    
        public Classifier Context
        {
            get => Uml.__CustomImpl.Action_Context(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<InputPin> Input
        {
            get => MGetCollection<InputPin>(Uml.Action_Input);
        }
    
        public Interaction Interaction
        {
            get => MGet<Interaction>(Uml.Action_Interaction);
            set => MSet<Interaction>(Uml.Action_Interaction, value);
        }
    
        public bool IsLocallyReentrant
        {
            get => MGet<bool>(Uml.Action_IsLocallyReentrant);
            set => MSet<bool>(Uml.Action_IsLocallyReentrant, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> LocalPostcondition
        {
            get => MGetCollection<Constraint>(Uml.Action_LocalPostcondition);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> LocalPrecondition
        {
            get => MGetCollection<Constraint>(Uml.Action_LocalPrecondition);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<OutputPin> Output
        {
            get => MGetCollection<OutputPin>(Uml.Action_Output);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> ContainedEdge
        {
            get => MGetCollection<ActivityEdge>(Uml.ActivityGroup_ContainedEdge);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> ContainedNode
        {
            get => MGetCollection<ActivityNode>(Uml.ActivityGroup_ContainedNode);
        }
    
        public Activity InActivity
        {
            get => MGet<Activity>(Uml.ActivityGroup_InActivity);
            set => MSet<Activity>(Uml.ActivityGroup_InActivity, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityGroup> Subgroup
        {
            get => MGetCollection<ActivityGroup>(Uml.ActivityGroup_Subgroup);
        }
    
        public ActivityGroup SuperGroup
        {
            get => MGet<ActivityGroup>(Uml.ActivityGroup_SuperGroup);
            set => MSet<ActivityGroup>(Uml.ActivityGroup_SuperGroup, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ExceptionHandler> Handler
        {
            get => MGetCollection<ExceptionHandler>(Uml.ExecutableNode_Handler);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        Activity ActivityNode.Activity
        {
            get => MGet<Activity>(Uml.ActivityNode_Activity);
            set => MSet<Activity>(Uml.ActivityNode_Activity, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Incoming
        {
            get => MGetCollection<ActivityEdge>(Uml.ActivityNode_Incoming);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityGroup> InGroup
        {
            get => MGetCollection<ActivityGroup>(Uml.ActivityNode_InGroup);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<InterruptibleActivityRegion> InInterruptibleRegion
        {
            get => MGetCollection<InterruptibleActivityRegion>(Uml.ActivityNode_InInterruptibleRegion);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityPartition> InPartition
        {
            get => MGetCollection<ActivityPartition>(Uml.ActivityNode_InPartition);
        }
    
        public StructuredActivityNode InStructuredNode
        {
            get => MGet<StructuredActivityNode>(Uml.ActivityNode_InStructuredNode);
            set => MSet<StructuredActivityNode>(Uml.ActivityNode_InStructuredNode, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityEdge> Outgoing
        {
            get => MGetCollection<ActivityEdge>(Uml.ActivityNode_Outgoing);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<ActivityNode> RedefinedNode
        {
            get => MGetCollection<ActivityNode>(Uml.ActivityNode_RedefinedNode);
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
    
    
        global::System.Collections.Generic.IList<Action> StructuredActivityNode.AllActions() => Uml.__CustomImpl.StructuredActivityNode_AllActions(this);
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode.AllOwnedNodes() => Uml.__CustomImpl.StructuredActivityNode_AllOwnedNodes(this);
        Activity StructuredActivityNode.ContainingActivity() => Uml.__CustomImpl.StructuredActivityNode_ContainingActivity(this);
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode.SourceNodes() => Uml.__CustomImpl.StructuredActivityNode_SourceNodes(this);
        global::System.Collections.Generic.IList<ActivityNode> StructuredActivityNode.TargetNodes() => Uml.__CustomImpl.StructuredActivityNode_TargetNodes(this);
        global::System.Collections.Generic.IList<Action> Action.AllActions() => Uml.__CustomImpl.StructuredActivityNode_AllActions(this);
        global::System.Collections.Generic.IList<ActivityNode> Action.AllOwnedNodes() => Uml.__CustomImpl.StructuredActivityNode_AllOwnedNodes(this);
        Behavior Action.ContainingBehavior() => Uml.__CustomImpl.Action_ContainingBehavior(this);
        Activity ActivityGroup.ContainingActivity() => Uml.__CustomImpl.StructuredActivityNode_ContainingActivity(this);
        Activity ActivityNode.ContainingActivity() => Uml.__CustomImpl.StructuredActivityNode_ContainingActivity(this);
        bool ActivityNode.IsConsistentWith(RedefinableElement redefiningElement) => Uml.__CustomImpl.ActivityNode_IsConsistentWith(this, redefiningElement);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ExcludeCollisions(global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ExcludeCollisions(this, imps);
        global::System.Collections.Generic.IList<string> Namespace.GetNamesOfMember(NamedElement element) => Uml.__CustomImpl.Namespace_GetNamesOfMember(this, element);
        global::System.Collections.Generic.IList<PackageableElement> Namespace.ImportMembers(global::System.Collections.Generic.IList<PackageableElement> imps) => Uml.__CustomImpl.Namespace_ImportMembers(this, imps);
        bool Namespace.MembersAreDistinguishable() => Uml.__CustomImpl.Namespace_MembersAreDistinguishable(this);
        bool RedefinableElement.IsConsistentWith(RedefinableElement redefiningElement) => Uml.__CustomImpl.ActivityNode_IsConsistentWith(this, redefiningElement);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.StructuredActivityNodeInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Uml.StructuredActivityNodeInfo, Uml.ActionInfo, Uml.ActivityGroupInfo, Uml.ExecutableNodeInfo, Uml.ActivityNodeInfo, Uml.NamespaceInfo, Uml.RedefinableElementInfo, Uml.NamedElementInfo, Uml.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.SequenceNode_ExecutableNode);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Uml.SequenceNode_ExecutableNode, Uml.StructuredActivityNode_Activity, Uml.StructuredActivityNode_Edge, Uml.StructuredActivityNode_MustIsolate, Uml.StructuredActivityNode_Node, Uml.StructuredActivityNode_StructuredNodeInput, Uml.StructuredActivityNode_StructuredNodeOutput, Uml.StructuredActivityNode_Variable, Uml.Action_Context, Uml.Action_Input, Uml.Action_Interaction, Uml.Action_IsLocallyReentrant, Uml.Action_LocalPostcondition, Uml.Action_LocalPrecondition, Uml.Action_Output, Uml.ActivityGroup_ContainedEdge, Uml.ActivityGroup_ContainedNode, Uml.ActivityGroup_InActivity, Uml.ActivityGroup_Subgroup, Uml.ActivityGroup_SuperGroup, Uml.ExecutableNode_Handler, Uml.ActivityNode_Activity, Uml.ActivityNode_Incoming, Uml.ActivityNode_InGroup, Uml.ActivityNode_InInterruptibleRegion, Uml.ActivityNode_InPartition, Uml.ActivityNode_InStructuredNode, Uml.ActivityNode_Outgoing, Uml.ActivityNode_RedefinedNode, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Uml.SequenceNode_ExecutableNode, Uml.StructuredActivityNode_Activity, Uml.StructuredActivityNode_Edge, Uml.StructuredActivityNode_MustIsolate, Uml.StructuredActivityNode_Node, Uml.StructuredActivityNode_StructuredNodeInput, Uml.StructuredActivityNode_StructuredNodeOutput, Uml.StructuredActivityNode_Variable, Uml.Action_Context, Uml.Action_Input, Uml.Action_Interaction, Uml.Action_IsLocallyReentrant, Uml.Action_LocalPostcondition, Uml.Action_LocalPrecondition, Uml.Action_Output, Uml.ActivityGroup_ContainedEdge, Uml.ActivityGroup_ContainedNode, Uml.ActivityGroup_InActivity, Uml.ActivityGroup_Subgroup, Uml.ActivityGroup_SuperGroup, Uml.ExecutableNode_Handler, Uml.ActivityNode_Incoming, Uml.ActivityNode_InGroup, Uml.ActivityNode_InInterruptibleRegion, Uml.ActivityNode_InPartition, Uml.ActivityNode_InStructuredNode, Uml.ActivityNode_Outgoing, Uml.ActivityNode_RedefinedNode, Uml.Namespace_ElementImport, Uml.Namespace_ImportedMember, Uml.Namespace_Member, Uml.Namespace_OwnedMember, Uml.Namespace_OwnedRule, Uml.Namespace_PackageImport, Uml.RedefinableElement_IsLeaf, Uml.RedefinableElement_RedefinedElement, Uml.RedefinableElement_RedefinitionContext, Uml.NamedElement_ClientDependency, Uml.NamedElement_Name, Uml.NamedElement_NameExpression, Uml.NamedElement_Namespace, Uml.NamedElement_QualifiedName, Uml.NamedElement_Visibility, Uml.Element_OwnedComment, Uml.Element_OwnedElement, Uml.Element_Owner);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("ExecutableNode", Uml.SequenceNode_ExecutableNode);
                publicPropertiesByName.Add("Activity", Uml.StructuredActivityNode_Activity);
                publicPropertiesByName.Add("Edge", Uml.StructuredActivityNode_Edge);
                publicPropertiesByName.Add("MustIsolate", Uml.StructuredActivityNode_MustIsolate);
                publicPropertiesByName.Add("Node", Uml.StructuredActivityNode_Node);
                publicPropertiesByName.Add("StructuredNodeInput", Uml.StructuredActivityNode_StructuredNodeInput);
                publicPropertiesByName.Add("StructuredNodeOutput", Uml.StructuredActivityNode_StructuredNodeOutput);
                publicPropertiesByName.Add("Variable", Uml.StructuredActivityNode_Variable);
                publicPropertiesByName.Add("Context", Uml.Action_Context);
                publicPropertiesByName.Add("Input", Uml.Action_Input);
                publicPropertiesByName.Add("Interaction", Uml.Action_Interaction);
                publicPropertiesByName.Add("IsLocallyReentrant", Uml.Action_IsLocallyReentrant);
                publicPropertiesByName.Add("LocalPostcondition", Uml.Action_LocalPostcondition);
                publicPropertiesByName.Add("LocalPrecondition", Uml.Action_LocalPrecondition);
                publicPropertiesByName.Add("Output", Uml.Action_Output);
                publicPropertiesByName.Add("ContainedEdge", Uml.ActivityGroup_ContainedEdge);
                publicPropertiesByName.Add("ContainedNode", Uml.ActivityGroup_ContainedNode);
                publicPropertiesByName.Add("InActivity", Uml.ActivityGroup_InActivity);
                publicPropertiesByName.Add("Subgroup", Uml.ActivityGroup_Subgroup);
                publicPropertiesByName.Add("SuperGroup", Uml.ActivityGroup_SuperGroup);
                publicPropertiesByName.Add("Handler", Uml.ExecutableNode_Handler);
                publicPropertiesByName.Add("Incoming", Uml.ActivityNode_Incoming);
                publicPropertiesByName.Add("InGroup", Uml.ActivityNode_InGroup);
                publicPropertiesByName.Add("InInterruptibleRegion", Uml.ActivityNode_InInterruptibleRegion);
                publicPropertiesByName.Add("InPartition", Uml.ActivityNode_InPartition);
                publicPropertiesByName.Add("InStructuredNode", Uml.ActivityNode_InStructuredNode);
                publicPropertiesByName.Add("Outgoing", Uml.ActivityNode_Outgoing);
                publicPropertiesByName.Add("RedefinedNode", Uml.ActivityNode_RedefinedNode);
                publicPropertiesByName.Add("ElementImport", Uml.Namespace_ElementImport);
                publicPropertiesByName.Add("ImportedMember", Uml.Namespace_ImportedMember);
                publicPropertiesByName.Add("Member", Uml.Namespace_Member);
                publicPropertiesByName.Add("OwnedMember", Uml.Namespace_OwnedMember);
                publicPropertiesByName.Add("OwnedRule", Uml.Namespace_OwnedRule);
                publicPropertiesByName.Add("PackageImport", Uml.Namespace_PackageImport);
                publicPropertiesByName.Add("IsLeaf", Uml.RedefinableElement_IsLeaf);
                publicPropertiesByName.Add("RedefinedElement", Uml.RedefinableElement_RedefinedElement);
                publicPropertiesByName.Add("RedefinitionContext", Uml.RedefinableElement_RedefinitionContext);
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
                modelPropertyInfos.Add(Uml.SequenceNode_ExecutableNode, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.SequenceNode_ExecutableNode, __ImmutableArray.Create<__ModelProperty>(Uml.SequenceNode_ExecutableNode, Uml.StructuredActivityNode_Node), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Node), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredActivityNode_Activity, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_Activity, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Activity, Uml.ActivityGroup_InActivity, Uml.ActivityNode_Activity), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Activity_StructuredNode), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_InActivity, Uml.ActivityNode_Activity), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_Activity), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredActivityNode_Edge, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_Edge, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Edge), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityEdge_InStructuredNode), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_ContainedEdge, Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredActivityNode_MustIsolate, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_MustIsolate, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_MustIsolate), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredActivityNode_Node, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.SequenceNode_ExecutableNode, __ImmutableArray.Create<__ModelProperty>(Uml.SequenceNode_ExecutableNode, Uml.StructuredActivityNode_Node), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InStructuredNode), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_ContainedNode, Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.SequenceNode_ExecutableNode), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredActivityNode_StructuredNodeInput, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_StructuredNodeInput, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_StructuredNodeInput), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Action_Input), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredActivityNode_StructuredNodeOutput, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_StructuredNodeOutput, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_StructuredNodeOutput), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Action_Output), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.StructuredActivityNode_Variable, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_Variable, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Variable), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Variable_Scope), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Action_Context, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Action_Context, __ImmutableArray.Create<__ModelProperty>(Uml.Action_Context), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Action_Input, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Action_Input, __ImmutableArray.Create<__ModelProperty>(Uml.Action_Input), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_StructuredNodeInput), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Action_Interaction, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Action_Interaction, __ImmutableArray.Create<__ModelProperty>(Uml.Action_Interaction), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Interaction_Action), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Action_IsLocallyReentrant, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Action_IsLocallyReentrant, __ImmutableArray.Create<__ModelProperty>(Uml.Action_IsLocallyReentrant), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Action_LocalPostcondition, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Action_LocalPostcondition, __ImmutableArray.Create<__ModelProperty>(Uml.Action_LocalPostcondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Action_LocalPrecondition, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Action_LocalPrecondition, __ImmutableArray.Create<__ModelProperty>(Uml.Action_LocalPrecondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Action_Output, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Action_Output, __ImmutableArray.Create<__ModelProperty>(Uml.Action_Output), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_StructuredNodeOutput), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityGroup_ContainedEdge, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityGroup_ContainedEdge, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_ContainedEdge), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityEdge_InGroup), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Edge), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityGroup_ContainedNode, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityGroup_ContainedNode, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_ContainedNode), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InGroup), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Node), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityGroup_InActivity, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_Activity, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Activity, Uml.ActivityGroup_InActivity, Uml.ActivityNode_Activity), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Activity_Group), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Activity), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityGroup_Subgroup, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityGroup_Subgroup, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_Subgroup), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_SuperGroup), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityGroup_SuperGroup, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityGroup_SuperGroup, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_SuperGroup), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_Subgroup), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ExecutableNode_Handler, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ExecutableNode_Handler, __ImmutableArray.Create<__ModelProperty>(Uml.ExecutableNode_Handler), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ExceptionHandler_ProtectedNode), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityNode_Activity, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.StructuredActivityNode_Activity, __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Activity, Uml.ActivityGroup_InActivity, Uml.ActivityNode_Activity), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Activity_Node), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Activity), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Activity)));
                modelPropertyInfos.Add(Uml.ActivityNode_Incoming, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityNode_Incoming, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_Incoming), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityEdge_Target), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityNode_InGroup, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityNode_InGroup, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InGroup), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_ContainedNode), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InInterruptibleRegion, Uml.ActivityNode_InPartition, Uml.ActivityNode_InStructuredNode), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityNode_InInterruptibleRegion, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityNode_InInterruptibleRegion, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InInterruptibleRegion), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.InterruptibleActivityRegion_Node), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InGroup), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityNode_InPartition, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityNode_InPartition, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InPartition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityPartition_Node), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InGroup), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityNode_InStructuredNode, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityNode_InStructuredNode, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InStructuredNode), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Node), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_InGroup, Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityNode_Outgoing, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityNode_Outgoing, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_Outgoing), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityEdge_Source), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.ActivityNode_RedefinedNode, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.ActivityNode_RedefinedNode, __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_RedefinedNode), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ElementImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ElementImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ElementImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.ElementImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_ImportedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_ImportedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ImportedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_Member, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_Member, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_Member), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_ImportedMember, Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedMember, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement, Uml.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Variable, Uml.Namespace_OwnedRule), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_OwnedRule, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_OwnedRule, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedRule), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.Constraint_Context), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Namespace_PackageImport, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Namespace_PackageImport, __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_PackageImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Uml.PackageImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_IsLeaf, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_IsLeaf, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_IsLeaf), false, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinedElement, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityNode_RedefinedNode), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.RedefinableElement_RedefinitionContext, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.RedefinableElement_RedefinitionContext, __ImmutableArray.Create<__ModelProperty>(Uml.RedefinableElement_RedefinitionContext), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_ClientDependency, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_ClientDependency, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_ClientDependency), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Uml.Dependency_Client), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_NameExpression, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_NameExpression, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_NameExpression), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(Uml.Action_Interaction), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Uml.NamedElement_Visibility), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.DerivedUnion), __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.StructuredActivityNode_Edge, Uml.StructuredActivityNode_Node, Uml.Action_Input, Uml.Action_LocalPostcondition, Uml.Action_LocalPrecondition, Uml.Action_Output, Uml.ActivityGroup_Subgroup, Uml.ExecutableNode_Handler, Uml.Namespace_ElementImport, Uml.Namespace_OwnedMember, Uml.Namespace_PackageImport, Uml.NamedElement_NameExpression, Uml.Element_OwnedComment), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Uml.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Uml.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Uml.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Uml.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Uml.ActivityGroup_InActivity, Uml.ActivityGroup_SuperGroup, Uml.ActivityNode_Activity, Uml.ActivityNode_InStructuredNode, Uml.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Uml.StructuredActivityNode_AllActions, Uml.StructuredActivityNode_AllOwnedNodes, Uml.StructuredActivityNode_ContainingActivity, Uml.StructuredActivityNode_SourceNodes, Uml.StructuredActivityNode_TargetNodes, Uml.Action_AllActions, Uml.Action_AllOwnedNodes, Uml.Action_ContainingBehavior, Uml.ActivityGroup_ContainingActivity, Uml.ActivityNode_ContainingActivity, Uml.ActivityNode_IsConsistentWith, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.RedefinableElement_IsConsistentWith, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Uml.StructuredActivityNode_AllActions, Uml.StructuredActivityNode_AllOwnedNodes, Uml.StructuredActivityNode_ContainingActivity, Uml.StructuredActivityNode_SourceNodes, Uml.StructuredActivityNode_TargetNodes, Uml.Action_ContainingBehavior, Uml.ActivityNode_IsConsistentWith, Uml.Namespace_ExcludeCollisions, Uml.Namespace_GetNamesOfMember, Uml.Namespace_ImportMembers, Uml.Namespace_MembersAreDistinguishable, Uml.RedefinableElement_IsRedefinitionContextValid, Uml.NamedElement_AllNamespaces, Uml.NamedElement_AllOwningPackages, Uml.NamedElement_IsDistinguishableFrom, Uml.NamedElement_Separator, Uml.Element_AllOwnedElements, Uml.Element_MustBeOwned);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Uml.StructuredActivityNode_AllActions, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.Action_AllActions), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.StructuredActivityNode_AllOwnedNodes, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.Action_AllOwnedNodes), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.StructuredActivityNode_ContainingActivity, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.ActivityGroup_ContainingActivity, Uml.ActivityNode_ContainingActivity), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.StructuredActivityNode_SourceNodes, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.StructuredActivityNode_TargetNodes, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Action_AllActions, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.StructuredActivityNode_AllActions)));
                    modelOperationInfos.Add(Uml.Action_AllOwnedNodes, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.StructuredActivityNode_AllOwnedNodes)));
                    modelOperationInfos.Add(Uml.Action_ContainingBehavior, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.ActivityGroup_ContainingActivity, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.ActivityNode_ContainingActivity), __ImmutableArray.Create<__ModelOperation>(Uml.StructuredActivityNode_ContainingActivity)));
                    modelOperationInfos.Add(Uml.ActivityNode_ContainingActivity, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.StructuredActivityNode_ContainingActivity, Uml.ActivityGroup_ContainingActivity)));
                    modelOperationInfos.Add(Uml.ActivityNode_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(Uml.RedefinableElement_IsConsistentWith), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ExcludeCollisions, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_GetNamesOfMember, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_ImportMembers, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.Namespace_MembersAreDistinguishable, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Uml.RedefinableElement_IsConsistentWith, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>(Uml.ActivityNode_IsConsistentWith)));
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
            public override __MetaType MetaType => typeof(SequenceNode);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Uml.NamedElement_Name;
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
                var result = new SequenceNode_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Uml.SequenceNodeInfo";
            }
        }
    }
}
