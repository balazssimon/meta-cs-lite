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

    internal class EParameter_Impl : __MetaModelObject, EParameter
    {
        private EParameter_Impl(string? id)
            : base(id)
        {
            ((__IModelObject)this).MGetSlot(Ecore.ETypedElement_Ordered)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Ecore.ETypedElement_Unique)?.Add((bool)true);
            ((__IModelObject)this).MGetSlot(Ecore.ETypedElement_UpperBound)?.Add((int)1);
            Ecore.__CustomImpl.EModelElement(this);
            Ecore.__CustomImpl.ENamedElement(this);
            Ecore.__CustomImpl.ETypedElement(this);
            Ecore.__CustomImpl.EParameter(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public EOperation EOperation
        {
            get => MGet<EOperation>(Ecore.EParameter_EOperation);
            set => MSet<EOperation>(Ecore.EParameter_EOperation, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.ETypedElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.ETypedElementInfo, Ecore.ENamedElementInfo, Ecore.EModelElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EParameter_EOperation);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EParameter_EOperation, Ecore.ETypedElement_EGenericType, Ecore.ETypedElement_EType, Ecore.ETypedElement_LowerBound, Ecore.ETypedElement_Many, Ecore.ETypedElement_Ordered, Ecore.ETypedElement_Required, Ecore.ETypedElement_Unique, Ecore.ETypedElement_UpperBound, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EParameter_EOperation, Ecore.ETypedElement_EGenericType, Ecore.ETypedElement_EType, Ecore.ETypedElement_LowerBound, Ecore.ETypedElement_Many, Ecore.ETypedElement_Ordered, Ecore.ETypedElement_Required, Ecore.ETypedElement_Unique, Ecore.ETypedElement_UpperBound, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("EOperation", Ecore.EParameter_EOperation);
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
                modelPropertyInfos.Add(Ecore.EParameter_EOperation, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EParameter_EOperation, __ImmutableArray.Create<__ModelProperty>(Ecore.EParameter_EOperation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Ecore.EOperation_EParameters), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
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
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EModelElement_GetEAnnotation);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EModelElement_GetEAnnotation);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Ecore.EModelElement_GetEAnnotation, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Ecore.MInstance;
            public override __MetaType MetaType => typeof(EParameter);
    
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
                var result = new EParameter_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Ecore.EParameterInfo";
            }
        }
    }
}
