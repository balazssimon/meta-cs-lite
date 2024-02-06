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

    internal class Property_Impl : __MetaModelObject, Property
    {
        private Property_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Mof.MultiplicityElement_IsUnique)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Mof.NamedElement_Visibility)?.Add((global::MetaDslx.Languages.Mof.Model.VisibilityKind)MetaDslx.Languages.Mof.Model.VisibilityKind.Public);
            Mof.__CustomImpl.Element(this);
            Mof.__CustomImpl.NamedElement(this);
            Mof.__CustomImpl.TypedElement(this);
            Mof.__CustomImpl.MultiplicityElement(this);
            Mof.__CustomImpl.Feature(this);
            Mof.__CustomImpl.StructuralFeature(this);
            Mof.__CustomImpl.Property(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Languages.Mof.Model.AggregationKind Aggregation
        {
            get => MGet<global::MetaDslx.Languages.Mof.Model.AggregationKind>(Mof.Property_Aggregation);
            set => MSet<global::MetaDslx.Languages.Mof.Model.AggregationKind>(Mof.Property_Aggregation, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Association> Association
        {
            get => MGetCollection<Association>(Mof.Property_Association);
        }
    
        public Class Class
        {
            get => MGet<Class>(Mof.Property_Class);
            set => MSet<Class>(Mof.Property_Class, value);
        }
    
        public string Default
        {
            get => Mof.__CustomImpl.Property_Default(this);
        }
    
        public ValueSpecification DefaultValue
        {
            get => MGet<ValueSpecification>(Mof.Property_DefaultValue);
            set => MSet<ValueSpecification>(Mof.Property_DefaultValue, value);
        }
    
        public bool IsComposite
        {
            get => Mof.__CustomImpl.Property_IsComposite(this);
        }
    
        public bool IsDerived
        {
            get => MGet<bool>(Mof.Property_IsDerived);
            set => MSet<bool>(Mof.Property_IsDerived, value);
        }
    
        public bool IsDerivedUnion
        {
            get => MGet<bool>(Mof.Property_IsDerivedUnion);
            set => MSet<bool>(Mof.Property_IsDerivedUnion, value);
        }
    
        public bool IsID
        {
            get => MGet<bool>(Mof.Property_IsID);
            set => MSet<bool>(Mof.Property_IsID, value);
        }
    
        public Property Opposite
        {
            get => Mof.__CustomImpl.Property_Opposite(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Association> OwningAssociation
        {
            get => MGetCollection<Association>(Mof.Property_OwningAssociation);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Property> RedefinedProperty
        {
            get => MGetCollection<Property>(Mof.Property_RedefinedProperty);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Property> SubsettedProperty
        {
            get => MGetCollection<Property>(Mof.Property_SubsettedProperty);
        }
    
        public bool IsReadOnly
        {
            get => MGet<bool>(Mof.StructuralFeature_IsReadOnly);
            set => MSet<bool>(Mof.StructuralFeature_IsReadOnly, value);
        }
    
        public bool IsOrdered
        {
            get => MGet<bool>(Mof.MultiplicityElement_IsOrdered);
            set => MSet<bool>(Mof.MultiplicityElement_IsOrdered, value);
        }
    
        public bool IsUnique
        {
            get => MGet<bool>(Mof.MultiplicityElement_IsUnique);
            set => MSet<bool>(Mof.MultiplicityElement_IsUnique, value);
        }
    
        public long Lower
        {
            get => Mof.__CustomImpl.MultiplicityElement_Lower(this);
        }
    
        public ValueSpecification LowerValue
        {
            get => MGet<ValueSpecification>(Mof.MultiplicityElement_LowerValue);
            set => MSet<ValueSpecification>(Mof.MultiplicityElement_LowerValue, value);
        }
    
        public long Upper
        {
            get => Mof.__CustomImpl.MultiplicityElement_Upper(this);
        }
    
        public ValueSpecification UpperValue
        {
            get => MGet<ValueSpecification>(Mof.MultiplicityElement_UpperValue);
            set => MSet<ValueSpecification>(Mof.MultiplicityElement_UpperValue, value);
        }
    
        public Type Type
        {
            get => MGet<Type>(Mof.TypedElement_Type);
            set => MSet<Type>(Mof.TypedElement_Type, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Mof.StructuralFeatureInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Mof.StructuralFeatureInfo, Mof.FeatureInfo, Mof.MultiplicityElementInfo, Mof.TypedElementInfo, Mof.NamedElementInfo, Mof.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Property_Aggregation, Mof.Property_Association, Mof.Property_Class, Mof.Property_Default, Mof.Property_DefaultValue, Mof.Property_IsComposite, Mof.Property_IsDerived, Mof.Property_IsDerivedUnion, Mof.Property_IsID, Mof.Property_Opposite, Mof.Property_OwningAssociation, Mof.Property_RedefinedProperty, Mof.Property_SubsettedProperty);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Property_Aggregation, Mof.Property_Association, Mof.Property_Class, Mof.Property_Default, Mof.Property_DefaultValue, Mof.Property_IsComposite, Mof.Property_IsDerived, Mof.Property_IsDerivedUnion, Mof.Property_IsID, Mof.Property_Opposite, Mof.Property_OwningAssociation, Mof.Property_RedefinedProperty, Mof.Property_SubsettedProperty, Mof.StructuralFeature_IsReadOnly, Mof.MultiplicityElement_IsOrdered, Mof.MultiplicityElement_IsUnique, Mof.MultiplicityElement_Lower, Mof.MultiplicityElement_LowerValue, Mof.MultiplicityElement_Upper, Mof.MultiplicityElement_UpperValue, Mof.TypedElement_Type, Mof.NamedElement_MemberNamespace, Mof.NamedElement_Name, Mof.NamedElement_Namespace, Mof.NamedElement_QualifiedName, Mof.NamedElement_Visibility, Mof.Element_Comment, Mof.Element_OwnedComment, Mof.Element_OwnedElement, Mof.Element_Owner, Mof.Element_Relationship, Mof.Element_Tag);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Mof.Property_Aggregation, Mof.Property_Association, Mof.Property_Class, Mof.Property_Default, Mof.Property_DefaultValue, Mof.Property_IsComposite, Mof.Property_IsDerived, Mof.Property_IsDerivedUnion, Mof.Property_IsID, Mof.Property_Opposite, Mof.Property_OwningAssociation, Mof.Property_RedefinedProperty, Mof.Property_SubsettedProperty, Mof.StructuralFeature_IsReadOnly, Mof.MultiplicityElement_IsOrdered, Mof.MultiplicityElement_IsUnique, Mof.MultiplicityElement_Lower, Mof.MultiplicityElement_LowerValue, Mof.MultiplicityElement_Upper, Mof.MultiplicityElement_UpperValue, Mof.TypedElement_Type, Mof.NamedElement_MemberNamespace, Mof.NamedElement_Name, Mof.NamedElement_Namespace, Mof.NamedElement_QualifiedName, Mof.NamedElement_Visibility, Mof.Element_Comment, Mof.Element_OwnedComment, Mof.Element_OwnedElement, Mof.Element_Owner, Mof.Element_Relationship, Mof.Element_Tag);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Aggregation", Mof.Property_Aggregation);
                publicPropertiesByName.Add("Association", Mof.Property_Association);
                publicPropertiesByName.Add("Class", Mof.Property_Class);
                publicPropertiesByName.Add("Default", Mof.Property_Default);
                publicPropertiesByName.Add("DefaultValue", Mof.Property_DefaultValue);
                publicPropertiesByName.Add("IsComposite", Mof.Property_IsComposite);
                publicPropertiesByName.Add("IsDerived", Mof.Property_IsDerived);
                publicPropertiesByName.Add("IsDerivedUnion", Mof.Property_IsDerivedUnion);
                publicPropertiesByName.Add("IsID", Mof.Property_IsID);
                publicPropertiesByName.Add("Opposite", Mof.Property_Opposite);
                publicPropertiesByName.Add("OwningAssociation", Mof.Property_OwningAssociation);
                publicPropertiesByName.Add("RedefinedProperty", Mof.Property_RedefinedProperty);
                publicPropertiesByName.Add("SubsettedProperty", Mof.Property_SubsettedProperty);
                publicPropertiesByName.Add("IsReadOnly", Mof.StructuralFeature_IsReadOnly);
                publicPropertiesByName.Add("IsOrdered", Mof.MultiplicityElement_IsOrdered);
                publicPropertiesByName.Add("IsUnique", Mof.MultiplicityElement_IsUnique);
                publicPropertiesByName.Add("Lower", Mof.MultiplicityElement_Lower);
                publicPropertiesByName.Add("LowerValue", Mof.MultiplicityElement_LowerValue);
                publicPropertiesByName.Add("Upper", Mof.MultiplicityElement_Upper);
                publicPropertiesByName.Add("UpperValue", Mof.MultiplicityElement_UpperValue);
                publicPropertiesByName.Add("Type", Mof.TypedElement_Type);
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
                modelPropertyInfos.Add(Mof.Property_Aggregation, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_Aggregation, __ImmutableArray.Create<__ModelProperty>(Mof.Property_Aggregation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_Association, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_Association, __ImmutableArray.Create<__ModelProperty>(Mof.Property_Association), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Association_MemberEnd), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Mof.Property_OwningAssociation), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_Class, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_Class, __ImmutableArray.Create<__ModelProperty>(Mof.Property_Class), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Class_OwnedAttribute), __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_Default, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_Default, __ImmutableArray.Create<__ModelProperty>(Mof.Property_Default), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Mof.Property_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.ValueSpecification_OwningProperty), __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_IsComposite, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_IsComposite, __ImmutableArray.Create<__ModelProperty>(Mof.Property_IsComposite), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_IsDerived, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_IsDerived, __ImmutableArray.Create<__ModelProperty>(Mof.Property_IsDerived), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_IsDerivedUnion, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_IsDerivedUnion, __ImmutableArray.Create<__ModelProperty>(Mof.Property_IsDerivedUnion), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_IsID, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_IsID, __ImmutableArray.Create<__ModelProperty>(Mof.Property_IsID), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_Opposite, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_Opposite, __ImmutableArray.Create<__ModelProperty>(Mof.Property_Opposite), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_OwningAssociation, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_OwningAssociation, __ImmutableArray.Create<__ModelProperty>(Mof.Property_OwningAssociation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Association_OwnedEnd), __ImmutableArray.Create<__ModelProperty>(Mof.Property_Association), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_RedefinedProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_RedefinedProperty, __ImmutableArray.Create<__ModelProperty>(Mof.Property_RedefinedProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Property_SubsettedProperty, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Property_SubsettedProperty, __ImmutableArray.Create<__ModelProperty>(Mof.Property_SubsettedProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.StructuralFeature_IsReadOnly, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.StructuralFeature_IsReadOnly, __ImmutableArray.Create<__ModelProperty>(Mof.StructuralFeature_IsReadOnly), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.MultiplicityElement_IsOrdered, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.MultiplicityElement_IsOrdered, __ImmutableArray.Create<__ModelProperty>(Mof.MultiplicityElement_IsOrdered), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.MultiplicityElement_IsUnique, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.MultiplicityElement_IsUnique, __ImmutableArray.Create<__ModelProperty>(Mof.MultiplicityElement_IsUnique), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.MultiplicityElement_Lower, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.MultiplicityElement_Lower, __ImmutableArray.Create<__ModelProperty>(Mof.MultiplicityElement_Lower), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.MultiplicityElement_LowerValue, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.MultiplicityElement_LowerValue, __ImmutableArray.Create<__ModelProperty>(Mof.MultiplicityElement_LowerValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.ValueSpecification_OwningLower), __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.MultiplicityElement_Upper, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.MultiplicityElement_Upper, __ImmutableArray.Create<__ModelProperty>(Mof.MultiplicityElement_Upper), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.MultiplicityElement_UpperValue, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.MultiplicityElement_UpperValue, __ImmutableArray.Create<__ModelProperty>(Mof.MultiplicityElement_UpperValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.ValueSpecification_OwningUpper), __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.TypedElement_Type, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.TypedElement_Type, __ImmutableArray.Create<__ModelProperty>(Mof.TypedElement_Type), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Type_TypedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_MemberNamespace, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_MemberNamespace, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_MemberNamespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_Member), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Namespace, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Namespace_OwnedMember), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_QualifiedName, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_QualifiedName, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_QualifiedName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.NamedElement_Visibility, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.NamedElement_Visibility, __ImmutableArray.Create<__ModelProperty>(Mof.NamedElement_Visibility), MetaDslx.Languages.Mof.Model.VisibilityKind.Public, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Comment, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Comment, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Comment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Comment_AnnotatedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_OwnedComment, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_OwnedComment, __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedComment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Comment_OwningElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_OwnedElement, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_OwnedElement, __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Mof.Property_DefaultValue, Mof.MultiplicityElement_LowerValue, Mof.MultiplicityElement_UpperValue), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Mof.Element_Owner, new __ModelPropertyInfo(new __ModelPropertySlot(Mof.Element_Owner, __ImmutableArray.Create<__ModelProperty>(Mof.Element_Owner), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Mof.Element_OwnedElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Mof.Property_Class), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
            public override __MetaType MetaType => typeof(Property);
    
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
                var result = new Property_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Mof.PropertyInfo";
            }
        }
    }
}
