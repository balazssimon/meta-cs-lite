#pragma warning disable CS8669

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

    internal class Symbol_Impl : __MetaModelObject, Symbol
    {
        private Symbol_Impl(string? id)
            : base(id)
        {
            Symbols.__CustomImpl.Declaration(this);
            Symbols.__CustomImpl.Symbol(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaSymbols.Model.Symbol> BaseTypes
        {
            get => MGetCollection<Symbol>(Symbols.Symbol_BaseTypes);
        }
    
        public bool IsAbstract
        {
            get => MGet<bool>(Symbols.Symbol_IsAbstract);
            set => MSet<bool>(Symbols.Symbol_IsAbstract, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaSymbols.Model.Operation> Operations
        {
            get => MGetCollection<Operation>(Symbols.Symbol_Operations);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaSymbols.Model.Property> Properties
        {
            get => MGetCollection<Property>(Symbols.Symbol_Properties);
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
    
        public string Namespace
        {
            get => Symbols.__CustomImpl.Declaration_Namespace(this);
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
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Symbols.Symbol_BaseTypes, Symbols.Symbol_IsAbstract, Symbols.Symbol_Operations, Symbols.Symbol_Properties);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Symbols.Symbol_BaseTypes, Symbols.Symbol_IsAbstract, Symbols.Symbol_Operations, Symbols.Symbol_Properties, Symbols.Declaration_FullName, Symbols.Declaration_Name, Symbols.Declaration_Namespace);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Symbols.Symbol_BaseTypes, Symbols.Symbol_IsAbstract, Symbols.Symbol_Operations, Symbols.Symbol_Properties, Symbols.Declaration_FullName, Symbols.Declaration_Name, Symbols.Declaration_Namespace);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("BaseTypes", Symbols.Symbol_BaseTypes);
                publicPropertiesByName.Add("IsAbstract", Symbols.Symbol_IsAbstract);
                publicPropertiesByName.Add("Operations", Symbols.Symbol_Operations);
                publicPropertiesByName.Add("Properties", Symbols.Symbol_Properties);
                publicPropertiesByName.Add("FullName", Symbols.Declaration_FullName);
                publicPropertiesByName.Add("Name", Symbols.Declaration_Name);
                publicPropertiesByName.Add("Namespace", Symbols.Declaration_Namespace);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Symbols.Symbol_BaseTypes, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Symbol_BaseTypes, __ImmutableArray.Create<__ModelProperty>(Symbols.Symbol_BaseTypes), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Symbol_IsAbstract, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Symbol_IsAbstract, __ImmutableArray.Create<__ModelProperty>(Symbols.Symbol_IsAbstract), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Symbol_Operations, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Symbol_Operations, __ImmutableArray.Create<__ModelProperty>(Symbols.Symbol_Operations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Symbol_Properties, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Symbol_Properties, __ImmutableArray.Create<__ModelProperty>(Symbols.Symbol_Properties), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Declaration_FullName, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Declaration_FullName, __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_FullName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Declaration_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Declaration_Name, __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Symbols.Declaration_Namespace, new __ModelPropertyInfo(new __ModelPropertySlot(Symbols.Declaration_Namespace, __ImmutableArray.Create<__ModelProperty>(Symbols.Declaration_Namespace), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Symbols.MInstance;
            public override __MetaType MetaType => typeof(Symbol);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol);
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
                var result = new Symbol_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Symbols.SymbolInfo";
            }
        }
    }
}
