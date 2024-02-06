#nullable enable

namespace MetaDslx.Languages.Mof.Model.__Impl
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

    internal class Operation_Impl : __MetaModelObject, Operation
    {
        private Operation_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Mof.NamedElement_Visibility)?.Add((global::MetaDslx.Languages.Mof.Model.VisibilityKind)MetaDslx.Languages.Mof.Model.VisibilityKind.Public);
            Mof.__CustomImpl.Element(this);
            Mof.__CustomImpl.NamedElement(this);
            Mof.__CustomImpl.Namespace(this);
            Mof.__CustomImpl.Feature(this);
            Mof.__CustomImpl.BehavioralFeature(this);
            Mof.__CustomImpl.Operation(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> BodyCondition
        {
            get => MGetCollection<Constraint>(Mof.Operation_BodyCondition);
        }
    
        public Class Class
        {
            get => MGet<Class>(Mof.Operation_Class);
            set => MSet<Class>(Mof.Operation_Class, value);
        }
    
        public bool IsAbstract
        {
            get => MGet<bool>(Mof.Operation_IsAbstract);
            set => MSet<bool>(Mof.Operation_IsAbstract, value);
        }
    
        public bool IsOrdered
        {
            get => Mof.__CustomImpl.Operation_IsOrdered(this);
        }
    
        public bool IsQuery
        {
            get => MGet<bool>(Mof.Operation_IsQuery);
            set => MSet<bool>(Mof.Operation_IsQuery, value);
        }
    
        public bool IsUnique
        {
            get => Mof.__CustomImpl.Operation_IsUnique(this);
        }
    
        public long Lower
        {
            get => Mof.__CustomImpl.Operation_Lower(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter
        {
            get => MGetCollection<Parameter>(Mof.Operation_OwnedParameter);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> Postcondition
        {
            get => MGetCollection<Constraint>(Mof.Operation_Postcondition);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> Precondition
        {
            get => MGetCollection<Constraint>(Mof.Operation_Precondition);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Type> RaisedException
        {
            get => MGetCollection<Type>(Mof.Operation_RaisedException);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Operation> RedefinedOperation
        {
            get => MGetCollection<Operation>(Mof.Operation_RedefinedOperation);
        }
    
        public long Upper
        {
            get => Mof.__CustomImpl.Operation_Upper(this);
        }
    
        public bool IsReadOnly
        {
            get => MGet<bool>(Mof.BehavioralFeature_IsReadOnly);
            set => MSet<bool>(Mof.BehavioralFeature_IsReadOnly, value);
        }
    
        public global::System.Collections.Generic.IList<NamedElement> Member
        {
            get => Mof.__CustomImpl.Namespace_Member(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<NamedElement> OwnedMember
        {
            get => MGetCollection<NamedElement>(Mof.Namespace_OwnedMember);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Constraint> OwnedRule
        {
            get => MGetCollection<Constraint>(Mof.Namespace_OwnedRule);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<PackageImport> PackageImport
        {
            get => MGetCollection<PackageImport>(Mof.Namespace_PackageImport);
        }
    
        public Namespace MemberNamespace
        {
            get => Mof.__CustomImpl.NamedElement_MemberNamespace(this);
        }
    
        public string Name
        {
            get => MGet<string>(Mof.NamedElement_Name);
            set => MSet<string>(Mof.NamedElement_Name, value);
        }
    
        public Namespace Namespace
        {
            get => MGet<Namespace>(Mof.NamedElement_Namespace);
            set => MSet<Namespace>(Mof.NamedElement_Namespace, value);
        }
    
        public string QualifiedName
        {
            get => Mof.__CustomImpl.NamedElement_QualifiedName(this);
        }
    
        public global::MetaDslx.Languages.Mof.Model.VisibilityKind Visibility
        {
            get => MGet<global::MetaDslx.Languages.Mof.Model.VisibilityKind>(Mof.NamedElement_Visibility);
            set => MSet<global::MetaDslx.Languages.Mof.Model.VisibilityKind>(Mof.NamedElement_Visibility, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Comment> Comment
        {
            get => MGetCollection<Comment>(Mof.Element_Comment);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Comment> OwnedComment
        {
            get => MGetCollection<Comment>(Mof.Element_OwnedComment);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Element> OwnedElement
        {
            get => MGetCollection<Element>(Mof.Element_OwnedElement);
        }
    
        public Element Owner
        {
            get => MGet<Element>(Mof.Element_Owner);
            set => MSet<Element>(Mof.Element_Owner, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Relationship> Relationship
        {
            get => MGetCollection<Relationship>(Mof.Element_Relationship);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Tag> Tag
        {
            get => MGetCollection<Tag>(Mof.Element_Tag);
        }
    
    
    
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Mof.BehavioralFeatureInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Mof.BehavioralFeatureInfo, Mof.FeatureInfo, Mof.NamespaceInfo, Mof.NamedElementInfo, Mof.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Operation_BodyCondition, Mof.Operation_Class, Mof.Operation_IsAbstract, Mof.Operation_IsOrdered, Mof.Operation_IsQuery, Mof.Operation_IsUnique, Mof.Operation_Lower, Mof.Operation_OwnedParameter, Mof.Operation_Postcondition, Mof.Operation_Precondition, Mof.Operation_RaisedException, Mof.Operation_RedefinedOperation, Mof.Operation_Upper);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Operation_BodyCondition, Mof.Operation_Class, Mof.Operation_IsAbstract, Mof.Operation_IsOrdered, Mof.Operation_IsQuery, Mof.Operation_IsUnique, Mof.Operation_Lower, Mof.Operation_OwnedParameter, Mof.Operation_Postcondition, Mof.Operation_Precondition, Mof.Operation_RaisedException, Mof.Operation_RedefinedOperation, Mof.Operation_Upper, Mof.BehavioralFeature_IsReadOnly, Mof.Namespace_Member, Mof.Namespace_OwnedMember, Mof.Namespace_OwnedRule, Mof.Namespace_PackageImport, Mof.NamedElement_MemberNamespace, Mof.NamedElement_Name, Mof.NamedElement_Namespace, Mof.NamedElement_QualifiedName, Mof.NamedElement_Visibility, Mof.Element_Comment, Mof.Element_OwnedComment, Mof.Element_OwnedElement, Mof.Element_Owner, Mof.Element_Relationship, Mof.Element_Tag);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Operation_BodyCondition, Mof.Operation_Class, Mof.Operation_IsAbstract, Mof.Operation_IsOrdered, Mof.Operation_IsQuery, Mof.Operation_IsUnique, Mof.Operation_Lower, Mof.Operation_OwnedParameter, Mof.Operation_Postcondition, Mof.Operation_Precondition, Mof.Operation_RaisedException, Mof.Operation_RedefinedOperation, Mof.Operation_Upper, Mof.BehavioralFeature_IsReadOnly, Mof.Namespace_Member, Mof.Namespace_OwnedMember, Mof.Namespace_OwnedRule, Mof.Namespace_PackageImport, Mof.NamedElement_MemberNamespace, Mof.NamedElement_Name, Mof.NamedElement_Namespace, Mof.NamedElement_QualifiedName, Mof.NamedElement_Visibility, Mof.Element_Comment, Mof.Element_OwnedComment, Mof.Element_OwnedElement, Mof.Element_Owner, Mof.Element_Relationship, Mof.Element_Tag);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("BodyCondition", Mof.Operation_BodyCondition);
                publicPropertiesByName.Add("Class", Mof.Operation_Class);
                publicPropertiesByName.Add("IsAbstract", Mof.Operation_IsAbstract);
                publicPropertiesByName.Add("IsOrdered", Mof.Operation_IsOrdered);
                publicPropertiesByName.Add("IsQuery", Mof.Operation_IsQuery);
                publicPropertiesByName.Add("IsUnique", Mof.Operation_IsUnique);
                publicPropertiesByName.Add("Lower", Mof.Operation_Lower);
                publicPropertiesByName.Add("OwnedParameter", Mof.Operation_OwnedParameter);
                publicPropertiesByName.Add("Postcondition", Mof.Operation_Postcondition);
                publicPropertiesByName.Add("Precondition", Mof.Operation_Precondition);
                publicPropertiesByName.Add("RaisedException", Mof.Operation_RaisedException);
                publicPropertiesByName.Add("RedefinedOperation", Mof.Operation_RedefinedOperation);
                publicPropertiesByName.Add("Upper", Mof.Operation_Upper);
                publicPropertiesByName.Add("IsReadOnly", Mof.BehavioralFeature_IsReadOnly);
                publicPropertiesByName.Add("Member", Mof.Namespace_Member);
                publicPropertiesByName.Add("OwnedMember", Mof.Namespace_OwnedMember);
                publicPropertiesByName.Add("OwnedRule", Mof.Namespace_OwnedRule);
                publicPropertiesByName.Add("PackageImport", Mof.Namespace_PackageImport);
                publicPropertiesByName.Add("MemberNamespace", Mof.NamedElement_MemberNamespace);
                publicPropertiesByName.Add("Name", Mof.NamedElement_Name);
                publicPropertiesByName.Add("Namespace", Mof.NamedElement_Namespace);
                publicPropertiesByName.Add("QualifiedName", Mof.NamedElement_QualifiedName);
                publicPropertiesByName.Add("Visibility", Mof.NamedElement_Visibility);
                publicPropertiesByName.Add("Comment", Mof.Element_Comment);
                publicPropertiesByName.Add("OwnedComment", Mof.Element_OwnedComment);
                publicPropertiesByName.Add("OwnedElement", Mof.Element_OwnedElement);
                publicPropertiesByName.Add("Owner", Mof.Element_Owner);
                publicPropertiesByName.Add("Relationship", Mof.Element_Relationship);
                publicPropertiesByName.Add("Tag", Mof.Element_Tag);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Mof.Operation_BodyCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_BodyCondition, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_BodyCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Constraint_BodyContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_Class, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_Class, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_Class), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Class_OwnedOperation), __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_IsAbstract), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_IsOrdered, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_IsOrdered, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_IsOrdered), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_IsQuery, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_IsQuery, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_IsQuery), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_IsUnique, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_IsUnique, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_IsUnique), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_Lower, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_Lower, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_Lower), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_OwnedParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_OwnedParameter, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_OwnedParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Parameter_Operation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_Postcondition, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_Postcondition, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_Postcondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Constraint_PostContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_Precondition, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_Precondition, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_Precondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Constraint_PreContext), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_RaisedException, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_RaisedException, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_RaisedException), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_RedefinedOperation, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_RedefinedOperation, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_RedefinedOperation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Operation_Upper, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Operation_Upper, __ImmutableArray.Create<__ModelProperty>(Mof.Operation_Upper), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.BehavioralFeature_IsReadOnly, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.BehavioralFeature_IsReadOnly, __ImmutableArray.Create<__ModelProperty>(Mof.BehavioralFeature_IsReadOnly), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_Member, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_Member, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_Member), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_MemberNamespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_OwnedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_OwnedMember, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_OwnedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_OwnedRule, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_OwnedRule, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_OwnedRule), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Constraint_Context), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_PackageImport, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_PackageImport, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_PackageImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.PackageImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_MemberNamespace, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_MemberNamespace, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_MemberNamespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Visibility), MetaDslx.Languages.Mof.Model.VisibilityKind.Public, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Comment, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Comment, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Comment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Comment_AnnotatedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Comment_OwningElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Mof.Operation_Class), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Relationship, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Relationship, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Relationship), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Relationship_RelatedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Tag, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Tag, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Tag), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Tag_Element), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Mof.MInstance;
            public override __MetaType MetaType => typeof(Operation);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Mof.NamedElement_Name;
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
                var result = new Operation_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Mof.OperationInfo";
            }
        }
    }
}
