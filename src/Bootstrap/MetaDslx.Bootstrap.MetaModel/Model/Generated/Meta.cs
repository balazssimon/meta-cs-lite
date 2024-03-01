#nullable enable

namespace MetaDslx.Bootstrap.MetaModel.Model
{
    using __MetaMetaModel = global::MetaDslx.Bootstrap.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Bootstrap.MetaModel.Model.MetaModelFactory;
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __ModelFactory = global::MetaDslx.Modeling.ModelFactory;
    using __MultiModelFactory = global::MetaDslx.Modeling.MultiModelFactory;
    using __ModelVersion = global::MetaDslx.Modeling.ModelVersion;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal interface IMeta
    {
    }
    
    public sealed class Meta : __MetaModel, IMeta
    {
        // If there is an error at the following line, create a new class called 'CustomMetaImplementation'
        // inheriting from the class 'CustomMetaImplementationBase' and provide the custom implementation
        // for the derived properties and operations defined in the metamodel
        internal static readonly CustomMetaImplementationBase __CustomImpl = new CustomMetaImplementation();
    
        private static readonly Meta _instance;
        public static Meta MInstance => _instance;
    
        private static readonly __ModelProperty _MetaDeclaration_Name;
        private static readonly __ModelProperty _MetaDeclaration_Namespace;
        private static readonly __ModelProperty _MetaDeclaration_FullName;
        private static readonly __ModelProperty _MetaModel_Uri;
        private static readonly __ModelProperty _MetaConstant_Type;
        private static readonly __ModelProperty _MetaEnum_Literals;
        private static readonly __ModelProperty _MetaClass_SymbolType;
        private static readonly __ModelProperty _MetaClass_IsAbstract;
        private static readonly __ModelProperty _MetaClass_BaseTypes;
        private static readonly __ModelProperty _MetaClass_Properties;
        private static readonly __ModelProperty _MetaClass_Operations;
        private static readonly __ModelProperty _MetaProperty_Type;
        private static readonly __ModelProperty _MetaProperty_SymbolProperty;
        private static readonly __ModelProperty _MetaProperty_IsContainment;
        private static readonly __ModelProperty _MetaProperty_IsDerived;
        private static readonly __ModelProperty _MetaProperty_IsReadOnly;
        private static readonly __ModelProperty _MetaProperty_IsUnion;
        private static readonly __ModelProperty _MetaProperty_DefaultValue;
        private static readonly __ModelProperty _MetaProperty_OppositeProperties;
        private static readonly __ModelProperty _MetaProperty_SubsettedProperties;
        private static readonly __ModelProperty _MetaProperty_RedefinedProperties;
        private static readonly __ModelProperty _MetaOperation_ReturnType;
        private static readonly __ModelProperty _MetaOperation_Parameters;
        private static readonly __ModelProperty _MetaParameter_Type;
        private static readonly __ModelProperty _MetaTypeReference_IsNullable;
        private static readonly __ModelProperty _MetaTypeReference_IsArray;
        private static readonly __ModelProperty _MetaTypeReference_Type;
    
        static Meta()
        {
            _MetaDeclaration_FullName = new __ModelProperty(typeof(MetaDeclaration), "FullName", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _MetaDeclaration_Name = new __ModelProperty(typeof(MetaDeclaration), "Name", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Name, "Name");
            _MetaDeclaration_Namespace = new __ModelProperty(typeof(MetaDeclaration), "Namespace", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _MetaClass_BaseTypes = new __ModelProperty(typeof(MetaClass), "BaseTypes", typeof(MetaClass), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, "BaseTypes");
            _MetaClass_IsAbstract = new __ModelProperty(typeof(MetaClass), "IsAbstract", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaClass_Operations = new __ModelProperty(typeof(MetaClass), "Operations", typeof(MetaOperation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaClass_Properties = new __ModelProperty(typeof(MetaClass), "Properties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaClass_SymbolType = new __ModelProperty(typeof(MetaClass), "SymbolType", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaConstant_Type = new __ModelProperty(typeof(MetaConstant), "Type", typeof(MetaTypeReference), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _MetaEnum_Literals = new __ModelProperty(typeof(MetaEnum), "Literals", typeof(MetaEnumLiteral), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaModel_Uri = new __ModelProperty(typeof(MetaModel), "Uri", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaOperation_Parameters = new __ModelProperty(typeof(MetaOperation), "Parameters", typeof(MetaParameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _MetaOperation_ReturnType = new __ModelProperty(typeof(MetaOperation), "ReturnType", typeof(MetaTypeReference), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _MetaParameter_Type = new __ModelProperty(typeof(MetaParameter), "Type", typeof(MetaTypeReference), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _MetaProperty_DefaultValue = new __ModelProperty(typeof(MetaProperty), "DefaultValue", typeof(object), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_IsContainment = new __ModelProperty(typeof(MetaProperty), "IsContainment", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_IsDerived = new __ModelProperty(typeof(MetaProperty), "IsDerived", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_IsReadOnly = new __ModelProperty(typeof(MetaProperty), "IsReadOnly", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_IsUnion = new __ModelProperty(typeof(MetaProperty), "IsUnion", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_OppositeProperties = new __ModelProperty(typeof(MetaProperty), "OppositeProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_RedefinedProperties = new __ModelProperty(typeof(MetaProperty), "RedefinedProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_SubsettedProperties = new __ModelProperty(typeof(MetaProperty), "SubsettedProperties", typeof(MetaProperty), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, null);
            _MetaProperty_SymbolProperty = new __ModelProperty(typeof(MetaProperty), "SymbolProperty", typeof(__MetaSymbol), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaProperty_Type = new __ModelProperty(typeof(MetaProperty), "Type", typeof(MetaTypeReference), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _MetaTypeReference_IsArray = new __ModelProperty(typeof(MetaTypeReference), "IsArray", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaTypeReference_IsNullable = new __ModelProperty(typeof(MetaTypeReference), "IsNullable", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _MetaTypeReference_Type = new __ModelProperty(typeof(MetaTypeReference), "Type", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _instance = new Meta();
        }
    
        private readonly __Model _model;
    
        private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _enumTypes;
        private readonly global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> _enumInfos;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> _enumInfosByType;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> _enumInfosByName;
    
        private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _classTypes;
        private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _classInfos;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> _classInfosByType;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> _classInfosByName;
    
    
        private Meta()
        {
            _enumTypes = __ImmutableArray.Create<__MetaType>();
            _enumInfos = __ImmutableArray.Create<__ModelEnumInfo>();
            var enumInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelEnumInfo>();
            _enumInfosByType = enumInfosByType.ToImmutable();
            var enumInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelEnumInfo>();
            _enumInfosByName = enumInfosByName.ToImmutable();
    
            _classTypes = __ImmutableArray.Create<__MetaType>(typeof(MetaDeclaration), typeof(MetaClass), typeof(MetaConstant), typeof(MetaEnum), typeof(MetaEnumLiteral), typeof(MetaModel), typeof(MetaOperation), typeof(MetaParameter), typeof(MetaProperty), typeof(MetaTypeReference));
            _classInfos = __ImmutableArray.Create<__ModelClassInfo>(MetaDeclarationInfo, MetaClassInfo, MetaConstantInfo, MetaEnumInfo, MetaEnumLiteralInfo, MetaModelInfo, MetaOperationInfo, MetaParameterInfo, MetaPropertyInfo, MetaTypeReferenceInfo);
            var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
            classInfosByType.Add(typeof(MetaDeclaration), MetaDeclarationInfo);
            classInfosByType.Add(typeof(MetaClass), MetaClassInfo);
            classInfosByType.Add(typeof(MetaConstant), MetaConstantInfo);
            classInfosByType.Add(typeof(MetaEnum), MetaEnumInfo);
            classInfosByType.Add(typeof(MetaEnumLiteral), MetaEnumLiteralInfo);
            classInfosByType.Add(typeof(MetaModel), MetaModelInfo);
            classInfosByType.Add(typeof(MetaOperation), MetaOperationInfo);
            classInfosByType.Add(typeof(MetaParameter), MetaParameterInfo);
            classInfosByType.Add(typeof(MetaProperty), MetaPropertyInfo);
            classInfosByType.Add(typeof(MetaTypeReference), MetaTypeReferenceInfo);
            _classInfosByType = classInfosByType.ToImmutable();
            var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
            classInfosByName.Add("MetaDeclaration", MetaDeclarationInfo);
            classInfosByName.Add("MetaClass", MetaClassInfo);
            classInfosByName.Add("MetaConstant", MetaConstantInfo);
            classInfosByName.Add("MetaEnum", MetaEnumInfo);
            classInfosByName.Add("MetaEnumLiteral", MetaEnumLiteralInfo);
            classInfosByName.Add("MetaModel", MetaModelInfo);
            classInfosByName.Add("MetaOperation", MetaOperationInfo);
            classInfosByName.Add("MetaParameter", MetaParameterInfo);
            classInfosByName.Add("MetaProperty", MetaPropertyInfo);
            classInfosByName.Add("MetaTypeReference", MetaTypeReferenceInfo);
            _classInfosByName = classInfosByName.ToImmutable();
            _model = new __Model();
            var cf = new MetaModelFactory(_model, this);
            var f = new __MetaModelFactory(_model);
            __CustomImpl.Meta(this);
            _model.IsSealed = true;
        }
    
        public override string MName => nameof(Meta);
        public override string MNamespace => "MetaDslx.Bootstrap.MetaModel.Model";
        public override __ModelVersion MVersion => default;
        public override string MUri => "MetaDslx.Bootstrap.MetaModel.Model.Meta";
        public override string MPrefix => "m";
        public override __Model MModel => _model;
    
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> MEnumInfosByType => _enumInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> MEnumInfosByName => _enumInfosByName;
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> MClassInfosByType => _classInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> MClassInfosByName => _classInfosByName;
    
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MEnumTypes => _enumTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> MEnumInfos => _enumInfos;
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MClassTypes => _classTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> MClassInfos => _classInfos;
    
    
    
        public static __ModelClassInfo MetaDeclarationInfo => __Impl.MetaDeclaration_Impl.__Info.Instance;
        public static __ModelProperty MetaDeclaration_Name => _MetaDeclaration_Name;
        public static __ModelProperty MetaDeclaration_Namespace => _MetaDeclaration_Namespace;
        public static __ModelProperty MetaDeclaration_FullName => _MetaDeclaration_FullName;
        public static __ModelClassInfo MetaClassInfo => __Impl.MetaClass_Impl.__Info.Instance;
        public static __ModelProperty MetaClass_SymbolType => _MetaClass_SymbolType;
        public static __ModelProperty MetaClass_IsAbstract => _MetaClass_IsAbstract;
        public static __ModelProperty MetaClass_BaseTypes => _MetaClass_BaseTypes;
        public static __ModelProperty MetaClass_Properties => _MetaClass_Properties;
        public static __ModelProperty MetaClass_Operations => _MetaClass_Operations;
        public static __ModelClassInfo MetaConstantInfo => __Impl.MetaConstant_Impl.__Info.Instance;
        public static __ModelProperty MetaConstant_Type => _MetaConstant_Type;
        public static __ModelClassInfo MetaEnumInfo => __Impl.MetaEnum_Impl.__Info.Instance;
        public static __ModelProperty MetaEnum_Literals => _MetaEnum_Literals;
        public static __ModelClassInfo MetaEnumLiteralInfo => __Impl.MetaEnumLiteral_Impl.__Info.Instance;
        public static __ModelClassInfo MetaModelInfo => __Impl.MetaModel_Impl.__Info.Instance;
        public static __ModelProperty MetaModel_Uri => _MetaModel_Uri;
        public static __ModelClassInfo MetaOperationInfo => __Impl.MetaOperation_Impl.__Info.Instance;
        public static __ModelProperty MetaOperation_ReturnType => _MetaOperation_ReturnType;
        public static __ModelProperty MetaOperation_Parameters => _MetaOperation_Parameters;
        public static __ModelClassInfo MetaParameterInfo => __Impl.MetaParameter_Impl.__Info.Instance;
        public static __ModelProperty MetaParameter_Type => _MetaParameter_Type;
        public static __ModelClassInfo MetaPropertyInfo => __Impl.MetaProperty_Impl.__Info.Instance;
        public static __ModelProperty MetaProperty_Type => _MetaProperty_Type;
        public static __ModelProperty MetaProperty_SymbolProperty => _MetaProperty_SymbolProperty;
        public static __ModelProperty MetaProperty_IsContainment => _MetaProperty_IsContainment;
        public static __ModelProperty MetaProperty_IsDerived => _MetaProperty_IsDerived;
        public static __ModelProperty MetaProperty_IsReadOnly => _MetaProperty_IsReadOnly;
        public static __ModelProperty MetaProperty_IsUnion => _MetaProperty_IsUnion;
        public static __ModelProperty MetaProperty_DefaultValue => _MetaProperty_DefaultValue;
        public static __ModelProperty MetaProperty_OppositeProperties => _MetaProperty_OppositeProperties;
        public static __ModelProperty MetaProperty_SubsettedProperties => _MetaProperty_SubsettedProperties;
        public static __ModelProperty MetaProperty_RedefinedProperties => _MetaProperty_RedefinedProperties;
        public static __ModelClassInfo MetaTypeReferenceInfo => __Impl.MetaTypeReference_Impl.__Info.Instance;
        public static __ModelProperty MetaTypeReference_IsNullable => _MetaTypeReference_IsNullable;
        public static __ModelProperty MetaTypeReference_IsArray => _MetaTypeReference_IsArray;
        public static __ModelProperty MetaTypeReference_Type => _MetaTypeReference_Type;
    }
}
