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

    internal class Eof_Impl : __MetaModelObject, Eof
    {
        private Eof_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.CSharpElement(this);
            Compiler.__CustomImpl.ElementValue(this);
            Compiler.__CustomImpl.Eof(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public string? GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Eof_GreenSyntaxCondition(this);
        }
    
        public string GreenType
        {
            get => Compiler.__CustomImpl.Eof_GreenType(this);
        }
    
        public string RedType
        {
            get => Compiler.__CustomImpl.Eof_RedType(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        string? ElementValue.GreenSyntaxCondition
        {
            get => Compiler.__CustomImpl.Eof_GreenSyntaxCondition(this);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        string ElementValue.GreenType
        {
            get => Compiler.__CustomImpl.Eof_GreenType(this);
        }
    
        public global::MetaDslx.Bootstrap.MetaCompiler3.Model.Multiplicity Multiplicity
        {
            get => MGet<global::MetaDslx.Bootstrap.MetaCompiler3.Model.Multiplicity>(Compiler.ElementValue_Multiplicity);
            set => MSet<global::MetaDslx.Bootstrap.MetaCompiler3.Model.Multiplicity>(Compiler.ElementValue_Multiplicity, value);
        }
    
        [global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)]
        string ElementValue.RedType
        {
            get => Compiler.__CustomImpl.Eof_RedType(this);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Annotation> Annotations
        {
            get => MGetCollection<Annotation>(Compiler.CSharpElement_Annotations);
        }
    
        public string AntlrName
        {
            get => MGet<string>(Compiler.CSharpElement_AntlrName);
            set => MSet<string>(Compiler.CSharpElement_AntlrName, value);
        }
    
        public global::MetaDslx.Modeling.ICollectionSlot<Binder> Binders
        {
            get => MGetCollection<Binder>(Compiler.CSharpElement_Binders);
        }
    
        public bool ContainsBinders
        {
            get => MGet<bool>(Compiler.CSharpElement_ContainsBinders);
            set => MSet<bool>(Compiler.CSharpElement_ContainsBinders, value);
        }
    
        public string CSharpName
        {
            get => MGet<string>(Compiler.CSharpElement_CSharpName);
            set => MSet<string>(Compiler.CSharpElement_CSharpName, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Compiler.ElementValueInfo, Compiler.CSharpElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition, Compiler.Eof_GreenType, Compiler.Eof_RedType);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition, Compiler.Eof_GreenType, Compiler.Eof_RedType, Compiler.ElementValue_GreenSyntaxCondition, Compiler.ElementValue_GreenType, Compiler.ElementValue_Multiplicity, Compiler.ElementValue_RedType, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition, Compiler.Eof_GreenType, Compiler.Eof_RedType, Compiler.ElementValue_Multiplicity, Compiler.CSharpElement_Annotations, Compiler.CSharpElement_AntlrName, Compiler.CSharpElement_Binders, Compiler.CSharpElement_ContainsBinders, Compiler.CSharpElement_CSharpName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("GreenSyntaxCondition", Compiler.Eof_GreenSyntaxCondition);
                publicPropertiesByName.Add("GreenType", Compiler.Eof_GreenType);
                publicPropertiesByName.Add("RedType", Compiler.Eof_RedType);
                publicPropertiesByName.Add("Multiplicity", Compiler.ElementValue_Multiplicity);
                publicPropertiesByName.Add("Annotations", Compiler.CSharpElement_Annotations);
                publicPropertiesByName.Add("AntlrName", Compiler.CSharpElement_AntlrName);
                publicPropertiesByName.Add("Binders", Compiler.CSharpElement_Binders);
                publicPropertiesByName.Add("ContainsBinders", Compiler.CSharpElement_ContainsBinders);
                publicPropertiesByName.Add("CSharpName", Compiler.CSharpElement_CSharpName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.Eof_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Eof_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Eof_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Eof_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.Eof_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.Eof_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_RedType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenSyntaxCondition, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenSyntaxCondition, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenSyntaxCondition), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenSyntaxCondition)));
                modelPropertyInfos.Add(Compiler.ElementValue_GreenType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_GreenType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_GreenType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_GreenType)));
                modelPropertyInfos.Add(Compiler.ElementValue_Multiplicity, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_Multiplicity, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_Multiplicity), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.ElementValue_RedType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.ElementValue_RedType, __ImmutableArray.Create<__ModelProperty>(Compiler.ElementValue_RedType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(Compiler.Eof_RedType)));
                modelPropertyInfos.Add(Compiler.CSharpElement_Annotations, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Annotations, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Annotations), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_AntlrName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_AntlrName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_AntlrName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_Binders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_Binders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_Binders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_ContainsBinders, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_ContainsBinders, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_ContainsBinders), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.CSharpElement_CSharpName, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.CSharpElement_CSharpName, __ImmutableArray.Create<__ModelProperty>(Compiler.CSharpElement_CSharpName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(Eof);
    
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
                var result = new Eof_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.EofInfo";
            }
        }
    }
}