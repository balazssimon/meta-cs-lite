#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Model.__Impl
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
            Symbols.__CustomImpl.Declaration(this);
            Symbols.__CustomImpl.Operation(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public string CacheCondition
        {
            get => MGet<string>(Symbols.Operation_CacheCondition);
            set => MSet<string>(Symbols.Operation_CacheCondition, value);
        }
    
        public bool CacheResult
        {
            get => MGet<bool>(Symbols.Operation_CacheResult);
            set => MSet<bool>(Symbols.Operation_CacheResult, value);
        }
    
        public bool IsPhase
        {
            get => MGet<bool>(Symbols.Operation_IsPhase);
            set => MSet<bool>(Symbols.Operation_IsPhase, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Parameter> Parameters
        {
            get => MGetCollection<Parameter>(Symbols.Operation_Parameters);
        }
    
        public TypeReference ReturnType
        {
            get => MGet<TypeReference>(Symbols.Operation_ReturnType);
            set => MSet<TypeReference>(Symbols.Operation_ReturnType, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Declaration> Declarations
        {
            get => MGetCollection<Declaration>(Symbols.Declaration_Declarations);
        }
    
        public string? FullName
        {
            get => Symbols.__CustomImpl.Declaration_FullName(this);
        }
    
        public string? Name
        {
            get => MGet<string?>(Symbols.Declaration_Name);
            set => MSet<string?>(Symbols.Declaration_Name, value);
        }
    
        public Declaration? Parent
        {
            get => MGet<Declaration?>(Symbols.Declaration_Parent);
            set => MSet<Declaration?>(Symbols.Declaration_Parent, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Symbols.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Symbols.DeclarationInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_CacheCondition, Symbols.Operation_CacheResult, Symbols.Operation_IsPhase, Symbols.Operation_Parameters, Symbols.Operation_ReturnType);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_CacheCondition, Symbols.Operation_CacheResult, Symbols.Operation_IsPhase, Symbols.Operation_Parameters, Symbols.Operation_ReturnType, Symbols.Declaration_Declarations, Symbols.Declaration_FullName, Symbols.Declaration_Name, Symbols.Declaration_Parent);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_CacheCondition, Symbols.Operation_CacheResult, Symbols.Operation_IsPhase, Symbols.Operation_Parameters, Symbols.Operation_ReturnType, Symbols.Declaration_Declarations, Symbols.Declaration_FullName, Symbols.Declaration_Name, Symbols.Declaration_Parent);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("CacheCondition", Symbols.Operation_CacheCondition);
                publicPropertiesByName.Add("CacheResult", Symbols.Operation_CacheResult);
                publicPropertiesByName.Add("IsPhase", Symbols.Operation_IsPhase);
                publicPropertiesByName.Add("Parameters", Symbols.Operation_Parameters);
                publicPropertiesByName.Add("ReturnType", Symbols.Operation_ReturnType);
                publicPropertiesByName.Add("Declarations", Symbols.Declaration_Declarations);
                publicPropertiesByName.Add("FullName", Symbols.Declaration_FullName);
                publicPropertiesByName.Add("Name", Symbols.Declaration_Name);
                publicPropertiesByName.Add("Parent", Symbols.Declaration_Parent);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Symbols.Operation_CacheCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Operation_CacheCondition, __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_CacheCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Operation_CacheResult, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Operation_CacheResult, __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_CacheResult), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Operation_IsPhase, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Operation_IsPhase, __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_IsPhase), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Operation_Parameters, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Operation_Parameters, __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_Parameters, Symbols.Declaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Operation_ReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Operation_ReturnType, __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_ReturnType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Declaration_Declarations, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Operation_Parameters, __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_Parameters, Symbols.Declaration_Declarations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_Parent), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Symbols.Operation_Parameters), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Declaration_Parent, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Declaration_Parent, __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_Parent), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_Declarations), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Symbols.MInstance;
            public override __MetaType MetaType => typeof(Operation);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Symbols.Declaration_Name;
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
                return "Symbols.OperationInfo";
            }
        }
    }
}
