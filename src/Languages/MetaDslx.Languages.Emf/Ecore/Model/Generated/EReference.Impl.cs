#nullable enable

namespace MetaDslx.Languages.Ecore.Model.__Impl
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

    internal class EReference_Impl : __MetaModelObject, EReference
    {
        private EReference_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Ecore.EReference_ResolveProxies)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Ecore.EStructuralFeature_Changeable)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Ecore.ETypedElement_Ordered)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Ecore.ETypedElement_Unique)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Ecore.ETypedElement_UpperBound)?.Add((int)1);
            Ecore.__CustomImpl.EModelElement(this);
            Ecore.__CustomImpl.ENamedElement(this);
            Ecore.__CustomImpl.ETypedElement(this);
            Ecore.__CustomImpl.EStructuralFeature(this);
            Ecore.__CustomImpl.EReference(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public bool Container
        {
            get => Ecore.__CustomImpl.EReference_Container(this);
        }
    
        public bool Containment
        {
            get => MGet<bool>(Ecore.EReference_Containment);
            set => MSet<bool>(Ecore.EReference_Containment, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EAttribute> EKeys
        {
            get => MGetCollection<EAttribute>(Ecore.EReference_EKeys);
        }
    
        public EReference EOpposite
        {
            get => MGet<EReference>(Ecore.EReference_EOpposite);
            set => MSet<EReference>(Ecore.EReference_EOpposite, value);
        }
    
        public EClass EReferenceType
        {
            get => Ecore.__CustomImpl.EReference_EReferenceType(this);
        }
    
        public bool ResolveProxies
        {
            get => MGet<bool>(Ecore.EReference_ResolveProxies);
            set => MSet<bool>(Ecore.EReference_ResolveProxies, value);
        }
    
        public bool Changeable
        {
            get => MGet<bool>(Ecore.EStructuralFeature_Changeable);
            set => MSet<bool>(Ecore.EStructuralFeature_Changeable, value);
        }
    
        public __MetaSymbol DefaultValue
        {
            get => Ecore.__CustomImpl.EStructuralFeature_DefaultValue(this);
        }
    
        public string DefaultValueLiteral
        {
            get => MGet<string>(Ecore.EStructuralFeature_DefaultValueLiteral);
            set => MSet<string>(Ecore.EStructuralFeature_DefaultValueLiteral, value);
        }
    
        public bool Derived
        {
            get => MGet<bool>(Ecore.EStructuralFeature_Derived);
            set => MSet<bool>(Ecore.EStructuralFeature_Derived, value);
        }
    
        public EClass EContainingClass
        {
            get => MGet<EClass>(Ecore.EStructuralFeature_EContainingClass);
            set => MSet<EClass>(Ecore.EStructuralFeature_EContainingClass, value);
        }
    
        public bool Transient
        {
            get => MGet<bool>(Ecore.EStructuralFeature_Transient);
            set => MSet<bool>(Ecore.EStructuralFeature_Transient, value);
        }
    
        public bool Unsettable
        {
            get => MGet<bool>(Ecore.EStructuralFeature_Unsettable);
            set => MSet<bool>(Ecore.EStructuralFeature_Unsettable, value);
        }
    
        public bool Volatile
        {
            get => MGet<bool>(Ecore.EStructuralFeature_Volatile);
            set => MSet<bool>(Ecore.EStructuralFeature_Volatile, value);
        }
    
        public EGenericType EGenericType
        {
            get => MGet<EGenericType>(Ecore.ETypedElement_EGenericType);
            set => MSet<EGenericType>(Ecore.ETypedElement_EGenericType, value);
        }
    
        public EClassifier EType
        {
            get => MGet<EClassifier>(Ecore.ETypedElement_EType);
            set => MSet<EClassifier>(Ecore.ETypedElement_EType, value);
        }
    
        public int LowerBound
        {
            get => MGet<int>(Ecore.ETypedElement_LowerBound);
            set => MSet<int>(Ecore.ETypedElement_LowerBound, value);
        }
    
        public bool Many
        {
            get => Ecore.__CustomImpl.ETypedElement_Many(this);
        }
    
        public bool Ordered
        {
            get => MGet<bool>(Ecore.ETypedElement_Ordered);
            set => MSet<bool>(Ecore.ETypedElement_Ordered, value);
        }
    
        public bool Required
        {
            get => Ecore.__CustomImpl.ETypedElement_Required(this);
        }
    
        public bool Unique
        {
            get => MGet<bool>(Ecore.ETypedElement_Unique);
            set => MSet<bool>(Ecore.ETypedElement_Unique, value);
        }
    
        public int UpperBound
        {
            get => MGet<int>(Ecore.ETypedElement_UpperBound);
            set => MSet<int>(Ecore.ETypedElement_UpperBound, value);
        }
    
        public string Name
        {
            get => MGet<string>(Ecore.ENamedElement_Name);
            set => MSet<string>(Ecore.ENamedElement_Name, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EAnnotation> EAnnotations
        {
            get => MGetCollection<EAnnotation>(Ecore.EModelElement_EAnnotations);
        }
    
    
        __MetaType EStructuralFeature.GetContainerClass() => Ecore.__CustomImpl.EStructuralFeature_GetContainerClass(this);
        int EStructuralFeature.GetFeatureID() => Ecore.__CustomImpl.EStructuralFeature_GetFeatureID(this);
        EAnnotation EModelElement.GetEAnnotation(string source) => Ecore.__CustomImpl.EModelElement_GetEAnnotation(this, source);
    
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.EStructuralFeatureInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.EStructuralFeatureInfo, Ecore.ETypedElementInfo, Ecore.ENamedElementInfo, Ecore.EModelElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_Container, Ecore.EReference_Containment, Ecore.EReference_EKeys, Ecore.EReference_EOpposite, Ecore.EReference_EReferenceType, Ecore.EReference_ResolveProxies);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_Container, Ecore.EReference_Containment, Ecore.EReference_EKeys, Ecore.EReference_EOpposite, Ecore.EReference_EReferenceType, Ecore.EReference_ResolveProxies, Ecore.EStructuralFeature_Changeable, Ecore.EStructuralFeature_DefaultValue, Ecore.EStructuralFeature_DefaultValueLiteral, Ecore.EStructuralFeature_Derived, Ecore.EStructuralFeature_EContainingClass, Ecore.EStructuralFeature_Transient, Ecore.EStructuralFeature_Unsettable, Ecore.EStructuralFeature_Volatile, Ecore.ETypedElement_EGenericType, Ecore.ETypedElement_EType, Ecore.ETypedElement_LowerBound, Ecore.ETypedElement_Many, Ecore.ETypedElement_Ordered, Ecore.ETypedElement_Required, Ecore.ETypedElement_Unique, Ecore.ETypedElement_UpperBound, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_Container, Ecore.EReference_Containment, Ecore.EReference_EKeys, Ecore.EReference_EOpposite, Ecore.EReference_EReferenceType, Ecore.EReference_ResolveProxies, Ecore.EStructuralFeature_Changeable, Ecore.EStructuralFeature_DefaultValue, Ecore.EStructuralFeature_DefaultValueLiteral, Ecore.EStructuralFeature_Derived, Ecore.EStructuralFeature_EContainingClass, Ecore.EStructuralFeature_Transient, Ecore.EStructuralFeature_Unsettable, Ecore.EStructuralFeature_Volatile, Ecore.ETypedElement_EGenericType, Ecore.ETypedElement_EType, Ecore.ETypedElement_LowerBound, Ecore.ETypedElement_Many, Ecore.ETypedElement_Ordered, Ecore.ETypedElement_Required, Ecore.ETypedElement_Unique, Ecore.ETypedElement_UpperBound, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Container", Ecore.EReference_Container);
                publicPropertiesByName.Add("Containment", Ecore.EReference_Containment);
                publicPropertiesByName.Add("EKeys", Ecore.EReference_EKeys);
                publicPropertiesByName.Add("EOpposite", Ecore.EReference_EOpposite);
                publicPropertiesByName.Add("EReferenceType", Ecore.EReference_EReferenceType);
                publicPropertiesByName.Add("ResolveProxies", Ecore.EReference_ResolveProxies);
                publicPropertiesByName.Add("Changeable", Ecore.EStructuralFeature_Changeable);
                publicPropertiesByName.Add("DefaultValue", Ecore.EStructuralFeature_DefaultValue);
                publicPropertiesByName.Add("DefaultValueLiteral", Ecore.EStructuralFeature_DefaultValueLiteral);
                publicPropertiesByName.Add("Derived", Ecore.EStructuralFeature_Derived);
                publicPropertiesByName.Add("EContainingClass", Ecore.EStructuralFeature_EContainingClass);
                publicPropertiesByName.Add("Transient", Ecore.EStructuralFeature_Transient);
                publicPropertiesByName.Add("Unsettable", Ecore.EStructuralFeature_Unsettable);
                publicPropertiesByName.Add("Volatile", Ecore.EStructuralFeature_Volatile);
                publicPropertiesByName.Add("EGenericType", Ecore.ETypedElement_EGenericType);
                publicPropertiesByName.Add("EType", Ecore.ETypedElement_EType);
                publicPropertiesByName.Add("LowerBound", Ecore.ETypedElement_LowerBound);
                publicPropertiesByName.Add("Many", Ecore.ETypedElement_Many);
                publicPropertiesByName.Add("Ordered", Ecore.ETypedElement_Ordered);
                publicPropertiesByName.Add("Required", Ecore.ETypedElement_Required);
                publicPropertiesByName.Add("Unique", Ecore.ETypedElement_Unique);
                publicPropertiesByName.Add("UpperBound", Ecore.ETypedElement_UpperBound);
                publicPropertiesByName.Add("Name", Ecore.ENamedElement_Name);
                publicPropertiesByName.Add("EAnnotations", Ecore.EModelElement_EAnnotations);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Ecore.EReference_Container, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EReference_Container, __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_Container), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EReference_Containment, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EReference_Containment, __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_Containment), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EReference_EKeys, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EReference_EKeys, __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_EKeys), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EReference_EOpposite, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EReference_EOpposite, __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_EOpposite), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EReference_EReferenceType, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EReference_EReferenceType, __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_EReferenceType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EReference_ResolveProxies, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EReference_ResolveProxies, __ImmutableArray.Create<__ModelProperty>(Ecore.EReference_ResolveProxies), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_Changeable, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_Changeable, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_Changeable), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_DefaultValue, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_DefaultValue, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_DefaultValue), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_DefaultValueLiteral, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_DefaultValueLiteral, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_DefaultValueLiteral), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_Derived, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_Derived, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_Derived), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_EContainingClass, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_EContainingClass, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_EContainingClass), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Ecore.EClass_EStructuralFeatures), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_Transient, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_Transient, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_Transient), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_Unsettable, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_Unsettable, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_Unsettable), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EStructuralFeature_Volatile, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EStructuralFeature_Volatile, __ImmutableArray.Create<__ModelProperty>(Ecore.EStructuralFeature_Volatile), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_EGenericType, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_EGenericType, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_EGenericType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_EType, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_EType, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_EType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_LowerBound, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_LowerBound, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_LowerBound), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_Many, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_Many, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_Many), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_Ordered, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_Ordered, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_Ordered), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_Required, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_Required, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_Required), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_Unique, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_Unique, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_Unique), true, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ETypedElement_UpperBound, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ETypedElement_UpperBound, __ImmutableArray.Create<__ModelProperty>(Ecore.ETypedElement_UpperBound), 1, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ENamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ENamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Ecore.ENamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EModelElement_EAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EModelElement_EAnnotations, __ImmutableArray.Create<__ModelProperty>(Ecore.EModelElement_EAnnotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EAnnotation_EModelElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EStructuralFeature_GetContainerClass, Ecore.EStructuralFeature_GetFeatureID, Ecore.EModelElement_GetEAnnotation);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EStructuralFeature_GetContainerClass, Ecore.EStructuralFeature_GetFeatureID, Ecore.EModelElement_GetEAnnotation);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Ecore.EStructuralFeature_GetContainerClass, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EStructuralFeature_GetFeatureID, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EModelElement_GetEAnnotation, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Ecore.MInstance;
            public override __MetaType MetaType => typeof(EReference);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Ecore.ENamedElement_Name;
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
                var result = new EReference_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Ecore.EReferenceInfo";
            }
        }
    }
}
