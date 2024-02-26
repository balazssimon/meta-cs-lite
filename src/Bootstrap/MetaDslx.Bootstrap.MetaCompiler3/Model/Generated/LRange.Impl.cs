#nullable enable

namespace MetaDslx.Bootstrap.MetaCompiler3.Model.__Impl
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

    internal class LRange_Impl : __MetaModelObject, LRange
    {
        private LRange_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.LElementValue(this);
            Compiler.__CustomImpl.LRange(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public string EndChar
        {
            get => MGet<string>(Compiler.LRange_EndChar);
            set => MSet<string>(Compiler.LRange_EndChar, value);
        }
    
        public string? FixedText
        {
            get => Compiler.__CustomImpl.LRange_FixedText(this);
        }
    
        public bool IsFixed
        {
            get => Compiler.__CustomImpl.LRange_IsFixed(this);
        }
    
        public string StartChar
        {
            get => MGet<string>(Compiler.LRange_StartChar);
            set => MSet<string>(Compiler.LRange_StartChar, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        string? LElementValue.FixedText
        {
            get => Compiler.__CustomImpl.LRange_FixedText(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        bool LElementValue.IsFixed
        {
            get => Compiler.__CustomImpl.LRange_IsFixed(this);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.LElementValueInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar, Compiler.LElementValue_FixedText, Compiler.LElementValue_IsFixed);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar, Compiler.LRange_FixedText, Compiler.LRange_IsFixed, Compiler.LRange_StartChar);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("EndChar", Compiler.LRange_EndChar);
                publicPropertiesByName.Add("FixedText", Compiler.LRange_FixedText);
                publicPropertiesByName.Add("IsFixed", Compiler.LRange_IsFixed);
                publicPropertiesByName.Add("StartChar", Compiler.LRange_StartChar);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.LRange_EndChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_EndChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_EndChar), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LRange_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LRange_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LRange_StartChar, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LRange_StartChar, __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_StartChar), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.LElementValue_FixedText, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_FixedText, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_FixedText), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_FixedText)));
                modelPropertyInfos.Add(Compiler.LElementValue_IsFixed, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.LElementValue_IsFixed, __ImmutableArray.Create<__ModelProperty>(Compiler.LElementValue_IsFixed), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.LRange_IsFixed)));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(LRange);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.Symbol);
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
                var result = new LRange_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.LRangeInfo";
            }
        }
    }
}
