#pragma warning disable CS8669

namespace MetaDslx.Examples.Soal.Model.__Impl
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
            Soal.__CustomImpl.Element(this);
            Soal.__CustomImpl.NamedElement(this);
            Soal.__CustomImpl.Declaration(this);
            Soal.__CustomImpl.Operation(this);
        }
    
        public override __ModelClassInfo MInfo => __Info.Instance;
    
        public global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Examples.Soal.Model.StructType> Exceptions
        {
            get => MGetCollection<StructType>(Soal.Operation_Exceptions);
        }
    
        public bool HasManyRequestParameters
        {
            get => Soal.__CustomImpl.Operation_HasManyRequestParameters(this);
        }
    
        public bool HasManyResponseParameters
        {
            get => Soal.__CustomImpl.Operation_HasManyResponseParameters(this);
        }
    
        public bool HasRequestParameters
        {
            get => Soal.__CustomImpl.Operation_HasRequestParameters(this);
        }
    
        public bool HasResponseParameters
        {
            get => Soal.__CustomImpl.Operation_HasResponseParameters(this);
        }
    
        public bool HasSingleResponseParameter
        {
            get => Soal.__CustomImpl.Operation_HasSingleResponseParameter(this);
        }
    
        public bool IsAsync
        {
            get => MGet<bool>(Soal.Operation_IsAsync);
            set => MSet<bool>(Soal.Operation_IsAsync, value);
        }
    
        public MetaDslx.Examples.Soal.Model.OperationKind Kind
        {
            get => MGet<MetaDslx.Examples.Soal.Model.OperationKind>(Soal.Operation_Kind);
            set => MSet<MetaDslx.Examples.Soal.Model.OperationKind>(Soal.Operation_Kind, value);
        }
    
        public MetaDslx.Examples.Soal.Model.ParameterList RequestParameters
        {
            get => MGet<MetaDslx.Examples.Soal.Model.ParameterList>(Soal.Operation_RequestParameters);
            set => MSet<MetaDslx.Examples.Soal.Model.ParameterList>(Soal.Operation_RequestParameters, value);
        }
    
        public MetaDslx.Examples.Soal.Model.Resource Resource
        {
            get => MGet<MetaDslx.Examples.Soal.Model.Resource>(Soal.Operation_Resource);
            set => MSet<MetaDslx.Examples.Soal.Model.Resource>(Soal.Operation_Resource, value);
        }
    
        public MetaDslx.Examples.Soal.Model.ParameterList ResponseParameters
        {
            get => MGet<MetaDslx.Examples.Soal.Model.ParameterList>(Soal.Operation_ResponseParameters);
            set => MSet<MetaDslx.Examples.Soal.Model.ParameterList>(Soal.Operation_ResponseParameters, value);
        }
    
        public MetaDslx.Examples.Soal.Model.TypeReference SingleReturnType
        {
            get => Soal.__CustomImpl.Operation_SingleReturnType(this);
        }
    
        public MetaDslx.Examples.Soal.Model.Documentation Documentation
        {
            get => Soal.__CustomImpl.NamedElement_Documentation(this);
        }
    
        public string HoverDocumentation
        {
            get => Soal.__CustomImpl.NamedElement_HoverDocumentation(this);
        }
    
        public string Name
        {
            get => MGet<string>(Soal.NamedElement_Name);
            set => MSet<string>(Soal.NamedElement_Name, value);
        }
    
        public string UniqueName
        {
            get => Soal.__CustomImpl.NamedElement_UniqueName(this);
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
                _baseTypes = __ImmutableArray.Create<__ModelClassInfo>(Soal.DeclarationInfo);
                _allBaseTypes = __ImmutableArray.Create<__ModelClassInfo>(Soal.DeclarationInfo, Soal.NamedElementInfo, Soal.ElementInfo);
                _declaredProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Operation_Exceptions, Soal.Operation_HasManyRequestParameters, Soal.Operation_HasManyResponseParameters, Soal.Operation_HasRequestParameters, Soal.Operation_HasResponseParameters, Soal.Operation_HasSingleResponseParameter, Soal.Operation_IsAsync, Soal.Operation_Kind, Soal.Operation_RequestParameters, Soal.Operation_Resource, Soal.Operation_ResponseParameters, Soal.Operation_SingleReturnType);
                _allDeclaredProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Operation_Exceptions, Soal.Operation_HasManyRequestParameters, Soal.Operation_HasManyResponseParameters, Soal.Operation_HasRequestParameters, Soal.Operation_HasResponseParameters, Soal.Operation_HasSingleResponseParameter, Soal.Operation_IsAsync, Soal.Operation_Kind, Soal.Operation_RequestParameters, Soal.Operation_Resource, Soal.Operation_ResponseParameters, Soal.Operation_SingleReturnType, Soal.NamedElement_Documentation, Soal.NamedElement_HoverDocumentation, Soal.NamedElement_Name, Soal.NamedElement_UniqueName);
                _publicProperties = __ImmutableArray.Create<__ModelProperty>(Soal.Operation_Exceptions, Soal.Operation_HasManyRequestParameters, Soal.Operation_HasManyResponseParameters, Soal.Operation_HasRequestParameters, Soal.Operation_HasResponseParameters, Soal.Operation_HasSingleResponseParameter, Soal.Operation_IsAsync, Soal.Operation_Kind, Soal.Operation_RequestParameters, Soal.Operation_Resource, Soal.Operation_ResponseParameters, Soal.Operation_SingleReturnType, Soal.NamedElement_Documentation, Soal.NamedElement_HoverDocumentation, Soal.NamedElement_Name, Soal.NamedElement_UniqueName);
                var publicPropertiesByName = __ImmutableDictionary.CreateBuilder<string, __ModelProperty>();
                publicPropertiesByName.Add("Exceptions", Soal.Operation_Exceptions);
                publicPropertiesByName.Add("HasManyRequestParameters", Soal.Operation_HasManyRequestParameters);
                publicPropertiesByName.Add("HasManyResponseParameters", Soal.Operation_HasManyResponseParameters);
                publicPropertiesByName.Add("HasRequestParameters", Soal.Operation_HasRequestParameters);
                publicPropertiesByName.Add("HasResponseParameters", Soal.Operation_HasResponseParameters);
                publicPropertiesByName.Add("HasSingleResponseParameter", Soal.Operation_HasSingleResponseParameter);
                publicPropertiesByName.Add("IsAsync", Soal.Operation_IsAsync);
                publicPropertiesByName.Add("Kind", Soal.Operation_Kind);
                publicPropertiesByName.Add("RequestParameters", Soal.Operation_RequestParameters);
                publicPropertiesByName.Add("Resource", Soal.Operation_Resource);
                publicPropertiesByName.Add("ResponseParameters", Soal.Operation_ResponseParameters);
                publicPropertiesByName.Add("SingleReturnType", Soal.Operation_SingleReturnType);
                publicPropertiesByName.Add("Documentation", Soal.NamedElement_Documentation);
                publicPropertiesByName.Add("HoverDocumentation", Soal.NamedElement_HoverDocumentation);
                publicPropertiesByName.Add("Name", Soal.NamedElement_Name);
                publicPropertiesByName.Add("UniqueName", Soal.NamedElement_UniqueName);
                _publicPropertiesByName = publicPropertiesByName.ToImmutable();
                var modelPropertyInfos = __ImmutableDictionary.CreateBuilder<__ModelProperty, __ModelPropertyInfo>();
                modelPropertyInfos.Add(Soal.Operation_Exceptions, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_Exceptions, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_Exceptions), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_HasManyRequestParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_HasManyRequestParameters, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_HasManyRequestParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_HasManyResponseParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_HasManyResponseParameters, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_HasManyResponseParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_HasRequestParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_HasRequestParameters, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_HasRequestParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_HasResponseParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_HasResponseParameters, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_HasResponseParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_HasSingleResponseParameter, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_HasSingleResponseParameter, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_HasSingleResponseParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_IsAsync, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_IsAsync, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_IsAsync), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_Kind, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_Kind, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_Kind), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_RequestParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_RequestParameters, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_RequestParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_Resource, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_Resource, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_Resource), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_ResponseParameters, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_ResponseParameters, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_ResponseParameters), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.Operation_SingleReturnType, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.Operation_SingleReturnType, __ImmutableArray.Create<__ModelProperty>(Soal.Operation_SingleReturnType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.NamedElement_Documentation, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.NamedElement_Documentation, __ImmutableArray.Create<__ModelProperty>(Soal.NamedElement_Documentation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Lazy), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.NamedElement_HoverDocumentation, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.NamedElement_HoverDocumentation, __ImmutableArray.Create<__ModelProperty>(Soal.NamedElement_HoverDocumentation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.NamedElement_Name, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.NamedElement_Name, __ImmutableArray.Create<__ModelProperty>(Soal.NamedElement_Name), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                modelPropertyInfos.Add(Soal.NamedElement_UniqueName, new __ModelPropertyInfo(new __ModelPropertySlot(Soal.NamedElement_UniqueName, __ImmutableArray.Create<__ModelProperty>(Soal.NamedElement_UniqueName), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Lazy), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>(), __ImmutableArray.Create<__ModelProperty>()));
                _modelPropertyInfos = modelPropertyInfos.ToImmutable();
    
                _declaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _allDeclaredOperations = __ImmutableArray.Create<__ModelOperation>();
                _publicOperations = __ImmutableArray.Create<__ModelOperation>();
                var modelOperationInfos = __ImmutableDictionary.CreateBuilder<__ModelOperation, __ModelOperationInfo>();
                _modelOperationInfos = modelOperationInfos.ToImmutable();
            }
    
            public override __MetaModel MetaModel => Soal.MInstance;
            public override __MetaType MetaType => typeof(Operation);
    
            public override __MetaType SymbolType => typeof(global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol);
            public override __ModelProperty? NameProperty => Soal.NamedElement_Name;
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
                return "Soal.OperationInfo";
            }
        }
    }
}
