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

    internal class EPackage_Impl : __MetaModelObject, EPackage
    {
        private EPackage_Impl(string? id)
            : base(id)
        {
            Ecore.__CustomImpl.EModelElement(this);
            Ecore.__CustomImpl.ENamedElement(this);
            Ecore.__CustomImpl.EPackage(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<EClassifier> EClassifiers
        {
            get => MGetCollection<EClassifier>(Ecore.EPackage_EClassifiers);
        }
    
        public EFactory EFactoryInstance
        {
            get => MGet<EFactory>(Ecore.EPackage_EFactoryInstance);
            set => MSet<EFactory>(Ecore.EPackage_EFactoryInstance, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EPackage> ESubpackages
        {
            get => MGetCollection<EPackage>(Ecore.EPackage_ESubpackages);
        }
    
        public EPackage ESuperPackage
        {
            get => MGet<EPackage>(Ecore.EPackage_ESuperPackage);
            set => MSet<EPackage>(Ecore.EPackage_ESuperPackage, value);
        }
    
        public string NsPrefix
        {
            get => MGet<string>(Ecore.EPackage_NsPrefix);
            set => MSet<string>(Ecore.EPackage_NsPrefix, value);
        }
    
        public string NsURI
        {
            get => MGet<string>(Ecore.EPackage_NsURI);
            set => MSet<string>(Ecore.EPackage_NsURI, value);
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
    
    
        EClassifier EPackage.GetEClassifier(string name) => Ecore.__CustomImpl.EPackage_GetEClassifier(this, name);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.ENamedElementInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Ecore.ENamedElementInfo, Ecore.EModelElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_EClassifiers, Ecore.EPackage_EFactoryInstance, Ecore.EPackage_ESubpackages, Ecore.EPackage_ESuperPackage, Ecore.EPackage_NsPrefix, Ecore.EPackage_NsURI);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_EClassifiers, Ecore.EPackage_EFactoryInstance, Ecore.EPackage_ESubpackages, Ecore.EPackage_ESuperPackage, Ecore.EPackage_NsPrefix, Ecore.EPackage_NsURI, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_EClassifiers, Ecore.EPackage_EFactoryInstance, Ecore.EPackage_ESubpackages, Ecore.EPackage_ESuperPackage, Ecore.EPackage_NsPrefix, Ecore.EPackage_NsURI, Ecore.ENamedElement_Name, Ecore.EModelElement_EAnnotations);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("EClassifiers", Ecore.EPackage_EClassifiers);
                publicPropertiesByName.Add("EFactoryInstance", Ecore.EPackage_EFactoryInstance);
                publicPropertiesByName.Add("ESubpackages", Ecore.EPackage_ESubpackages);
                publicPropertiesByName.Add("ESuperPackage", Ecore.EPackage_ESuperPackage);
                publicPropertiesByName.Add("NsPrefix", Ecore.EPackage_NsPrefix);
                publicPropertiesByName.Add("NsURI", Ecore.EPackage_NsURI);
                publicPropertiesByName.Add("Name", Ecore.ENamedElement_Name);
                publicPropertiesByName.Add("EAnnotations", Ecore.EModelElement_EAnnotations);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Ecore.EPackage_EClassifiers, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EPackage_EClassifiers, __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_EClassifiers), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EClassifier_EPackage), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EPackage_EFactoryInstance, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EPackage_EFactoryInstance, __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_EFactoryInstance), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Ecore.EFactory_EPackage), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EPackage_ESubpackages, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EPackage_ESubpackages, __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_ESubpackages), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_ESuperPackage), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EPackage_ESuperPackage, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EPackage_ESuperPackage, __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_ESuperPackage), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_ESubpackages), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EPackage_NsPrefix, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EPackage_NsPrefix, __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_NsPrefix), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EPackage_NsURI, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EPackage_NsURI, __ImmutableArray.Create<__ModelProperty>(Ecore.EPackage_NsURI), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.ENamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.ENamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Ecore.ENamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EModelElement_EAnnotations, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EModelElement_EAnnotations, __ImmutableArray.Create<__ModelProperty>(Ecore.EModelElement_EAnnotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Ecore.EAnnotation_EModelElement), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EPackage_GetEClassifier);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EPackage_GetEClassifier, Ecore.EModelElement_GetEAnnotation);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EPackage_GetEClassifier, Ecore.EModelElement_GetEAnnotation);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Ecore.EPackage_GetEClassifier, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                    modelOperationInfos.Add(Ecore.EModelElement_GetEAnnotation, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Ecore.MInstance;
            public override __MetaType MetaType => typeof(EPackage);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol);
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
                var result = new EPackage_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Ecore.EPackageInfo";
            }
        }
    }
}
