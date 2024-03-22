#pragma warning disable CS8669

namespace MetaDslx.Languages.MetaCompiler.Model.__Impl
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

    internal class AnnotationArgument_Impl : __MetaModelObject, AnnotationArgument
    {
        private AnnotationArgument_Impl(string? id)
            : base(id)
        {
            Compiler.__CustomImpl.AnnotationArgument(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.CodeAnalysis.MetaSymbol> NamedParameter
        {
            get => MGetCollection<__MetaSymbol>(Compiler.AnnotationArgument_NamedParameter);
        }
    
        public MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol Parameter
        {
            get => MGet<MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol>(Compiler.AnnotationArgument_Parameter);
            set => MSet<MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol>(Compiler.AnnotationArgument_Parameter, value);
        }
    
        public MetaDslx.CodeAnalysis.MetaType ParameterType
        {
            get => MGet<MetaDslx.CodeAnalysis.MetaType>(Compiler.AnnotationArgument_ParameterType);
            set => MSet<MetaDslx.CodeAnalysis.MetaType>(Compiler.AnnotationArgument_ParameterType, value);
        }
    
        public MetaDslx.Languages.MetaCompiler.Model.Expression Value
        {
            get => MGet<MetaDslx.Languages.MetaCompiler.Model.Expression>(Compiler.AnnotationArgument_Value);
            set => MSet<MetaDslx.Languages.MetaCompiler.Model.Expression>(Compiler.AnnotationArgument_Value, value);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>();
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter, Compiler.AnnotationArgument_Parameter, Compiler.AnnotationArgument_ParameterType, Compiler.AnnotationArgument_Value);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("NamedParameter", Compiler.AnnotationArgument_NamedParameter);
                publicPropertiesByName.Add("Parameter", Compiler.AnnotationArgument_Parameter);
                publicPropertiesByName.Add("ParameterType", Compiler.AnnotationArgument_ParameterType);
                publicPropertiesByName.Add("Value", Compiler.AnnotationArgument_Value);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Compiler.AnnotationArgument_NamedParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_NamedParameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_NamedParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.AnnotationArgument_Parameter, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Parameter, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Parameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.AnnotationArgument_ParameterType, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_ParameterType, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_ParameterType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Compiler.AnnotationArgument_Value, new __ModelPropertyInfo(new __ModelPropertySlot(Compiler.AnnotationArgument_Value, __ImmutableArray.Create<__ModelProperty>(Compiler.AnnotationArgument_Value), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Compiler.MInstance;
            public override __MetaType MetaType => typeof(AnnotationArgument);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.Languages.MetaCompiler.Symbols.AnnotationArgumentSymbol);
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
                var result = new AnnotationArgument_Impl(id);
                if (model is not null) model.AttachObject(result);
                return result;
            }
    
            public override string ToString()
            {
                return "Compiler.AnnotationArgumentInfo";
            }
        }
    }
}
