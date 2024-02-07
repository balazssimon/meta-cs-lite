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

    internal class EGenericType_Impl : __MetaModelObject, EGenericType
    {
        private EGenericType_Impl(string? id)
            : base(id)
        {
            Ecore.__CustomImpl.EGenericType(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public EClassifier EClassifier
        {
            get => MGet<EClassifier>(Ecore.EGenericType_EClassifier);
            set => MSet<EClassifier>(Ecore.EGenericType_EClassifier, value);
        }
    
        public EGenericType ELowerBound
        {
            get => MGet<EGenericType>(Ecore.EGenericType_ELowerBound);
            set => MSet<EGenericType>(Ecore.EGenericType_ELowerBound, value);
        }
    
        public EClassifier ERawType
        {
            get => Ecore.__CustomImpl.EGenericType_ERawType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<EGenericType> ETypeArguments
        {
            get => MGetCollection<EGenericType>(Ecore.EGenericType_ETypeArguments);
        }
    
        public ETypeParameter ETypeParameter
        {
            get => MGet<ETypeParameter>(Ecore.EGenericType_ETypeParameter);
            set => MSet<ETypeParameter>(Ecore.EGenericType_ETypeParameter, value);
        }
    
        public EGenericType EUpperBound
        {
            get => MGet<EGenericType>(Ecore.EGenericType_EUpperBound);
            set => MSet<EGenericType>(Ecore.EGenericType_EUpperBound, value);
        }
    
    
        bool EGenericType.IsInstance(__MetaSymbol @object) => Ecore.__CustomImpl.EGenericType_IsInstance(this, @object);
    
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_EClassifier, Ecore.EGenericType_ELowerBound, Ecore.EGenericType_ERawType, Ecore.EGenericType_ETypeArguments, Ecore.EGenericType_ETypeParameter, Ecore.EGenericType_EUpperBound);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_EClassifier, Ecore.EGenericType_ELowerBound, Ecore.EGenericType_ERawType, Ecore.EGenericType_ETypeArguments, Ecore.EGenericType_ETypeParameter, Ecore.EGenericType_EUpperBound);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_EClassifier, Ecore.EGenericType_ELowerBound, Ecore.EGenericType_ERawType, Ecore.EGenericType_ETypeArguments, Ecore.EGenericType_ETypeParameter, Ecore.EGenericType_EUpperBound);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("EClassifier", Ecore.EGenericType_EClassifier);
                publicPropertiesByName.Add("ELowerBound", Ecore.EGenericType_ELowerBound);
                publicPropertiesByName.Add("ERawType", Ecore.EGenericType_ERawType);
                publicPropertiesByName.Add("ETypeArguments", Ecore.EGenericType_ETypeArguments);
                publicPropertiesByName.Add("ETypeParameter", Ecore.EGenericType_ETypeParameter);
                publicPropertiesByName.Add("EUpperBound", Ecore.EGenericType_EUpperBound);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Ecore.EGenericType_EClassifier, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EGenericType_EClassifier, __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_EClassifier), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EGenericType_ELowerBound, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EGenericType_ELowerBound, __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_ELowerBound), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EGenericType_ERawType, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EGenericType_ERawType, __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_ERawType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EGenericType_ETypeArguments, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EGenericType_ETypeArguments, __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_ETypeArguments), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EGenericType_ETypeParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EGenericType_ETypeParameter, __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_ETypeParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Ecore.EGenericType_EUpperBound, new __ModelPropertyInfo(new __ModelPropertySlot(Ecore.EGenericType_EUpperBound, __ImmutableArray.Create<__ModelProperty>(Ecore.EGenericType_EUpperBound), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EGenericType_IsInstance);
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EGenericType_IsInstance);
                _publicOperations = __ImmutableArray.Create<__ModelOperation>(Ecore.EGenericType_IsInstance);
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                    modelOperationInfos.Add(Ecore.EGenericType_IsInstance, new __ModelOperationInfo(__ImmutableArray.Create<__ModelOperation>(), __ImmutableArray.Create<__ModelOperation>()));
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Ecore.MInstance;
            public override __MetaType MetaType => typeof(EGenericType);
    
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
                var result = new EGenericType_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Ecore.EGenericTypeInfo";
            }
        }
    }
}
