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

    internal class PrimitiveType_Impl : __MetaModelObject, PrimitiveType
    {
        private PrimitiveType_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Mof.NamedElement_Visibility)?.Add((global::MetaDslx.Languages.Mof.Model.VisibilityKind)MetaDslx.Languages.Mof.Model.VisibilityKind.Public);
            Mof.__CustomImpl.Element(this);
            Mof.__CustomImpl.NamedElement(this);
            Mof.__CustomImpl.PackageableElement(this);
            Mof.__CustomImpl.Type(this);
            Mof.__CustomImpl.Namespace(this);
            Mof.__CustomImpl.Classifier(this);
            Mof.__CustomImpl.DataType(this);
            Mof.__CustomImpl.PrimitiveType(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<Generalization> Generalization
        {
            get => MGetCollection<Generalization>(Mof.Classifier_Generalization);
        }
    
        public bool IsAbstract
        {
            get => MGet<bool>(Mof.Classifier_IsAbstract);
            set => MSet<bool>(Mof.Classifier_IsAbstract, value);
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
    
        public Package Package
        {
            get => MGet<Package>(Mof.Type_Package);
            set => MSet<Package>(Mof.Type_Package, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<TypedElement> TypedElement
        {
            get => MGetCollection<TypedElement>(Mof.Type_TypedElement);
        }
    
        public Package OwningPackage
        {
            get => MGet<Package>(Mof.PackageableElement_OwningPackage);
            set => MSet<Package>(Mof.PackageableElement_OwningPackage, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Mof.DataTypeInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Mof.DataTypeInfo, Mof.ClassifierInfo, Mof.NamespaceInfo, Mof.TypeInfo, Mof.PackageableElementInfo, Mof.NamedElementInfo, Mof.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>();
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Classifier_Generalization, Mof.Classifier_IsAbstract, Mof.Namespace_Member, Mof.Namespace_OwnedMember, Mof.Namespace_OwnedRule, Mof.Namespace_PackageImport, Mof.Type_Package, Mof.Type_TypedElement, Mof.PackageableElement_OwningPackage, Mof.NamedElement_MemberNamespace, Mof.NamedElement_Name, Mof.NamedElement_Namespace, Mof.NamedElement_QualifiedName, Mof.NamedElement_Visibility, Mof.Element_Comment, Mof.Element_OwnedComment, Mof.Element_OwnedElement, Mof.Element_Owner, Mof.Element_Relationship, Mof.Element_Tag);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Classifier_Generalization, Mof.Classifier_IsAbstract, Mof.Namespace_Member, Mof.Namespace_OwnedMember, Mof.Namespace_OwnedRule, Mof.Namespace_PackageImport, Mof.Type_Package, Mof.Type_TypedElement, Mof.PackageableElement_OwningPackage, Mof.NamedElement_MemberNamespace, Mof.NamedElement_Name, Mof.NamedElement_Namespace, Mof.NamedElement_QualifiedName, Mof.NamedElement_Visibility, Mof.Element_Comment, Mof.Element_OwnedComment, Mof.Element_OwnedElement, Mof.Element_Owner, Mof.Element_Relationship, Mof.Element_Tag);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Generalization", Mof.Classifier_Generalization);
                publicPropertiesByName.Add("IsAbstract", Mof.Classifier_IsAbstract);
                publicPropertiesByName.Add("Member", Mof.Namespace_Member);
                publicPropertiesByName.Add("OwnedMember", Mof.Namespace_OwnedMember);
                publicPropertiesByName.Add("OwnedRule", Mof.Namespace_OwnedRule);
                publicPropertiesByName.Add("PackageImport", Mof.Namespace_PackageImport);
                publicPropertiesByName.Add("Package", Mof.Type_Package);
                publicPropertiesByName.Add("TypedElement", Mof.Type_TypedElement);
                publicPropertiesByName.Add("OwningPackage", Mof.PackageableElement_OwningPackage);
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
                modelPropertyInfos.Add(Mof.Classifier_Generalization, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Classifier_Generalization, __ImmutableArray.Create<__ModelProperty>(Mof.Classifier_Generalization), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Generalization_Specific), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Classifier_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Classifier_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Mof.Classifier_IsAbstract), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_Member, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_Member, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_Member), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_MemberNamespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_OwnedMember, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_OwnedMember, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_OwnedMember), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Namespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_OwnedRule, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_OwnedRule, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_OwnedRule), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Constraint_Context), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Namespace_PackageImport, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Namespace_PackageImport, __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_PackageImport), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.PackageImport_ImportingNamespace), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Type_Package, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Type_Package, __ImmutableArray.Create<__ModelProperty>(Mof.Type_Package, Mof.PackageableElement_OwningPackage), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Package_OwnedType), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Mof.PackageableElement_OwningPackage), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Type_TypedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Type_TypedElement, __ImmutableArray.Create<__ModelProperty>(Mof.Type_TypedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.TypedElement_Type), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.PackageableElement_OwningPackage, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Type_Package, __ImmutableArray.Create<__ModelProperty>(Mof.Type_Package, Mof.PackageableElement_OwningPackage), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Package_PackagedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Mof.Type_Package), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_MemberNamespace, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_MemberNamespace, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_MemberNamespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Visibility), MetaDslx.Languages.Mof.Model.VisibilityKind.Public, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Comment, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Comment, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Comment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Comment_AnnotatedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Comment_OwningElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
            public override __MetaType MetaType => typeof(PrimitiveType);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
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
                var result = new PrimitiveType_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Mof.PrimitiveTypeInfo";
            }
        }
    }
}
