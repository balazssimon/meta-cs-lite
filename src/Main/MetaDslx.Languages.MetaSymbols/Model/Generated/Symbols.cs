#nullable enable

namespace MetaDslx.Languages.MetaSymbols.Model
{
    using __MetaMetaModel = global::MetaDslx.Languages.MetaModel.Model.Meta;
    using __MetaModelFactory = global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;
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

    internal interface ISymbols
    {
    }
    
    public sealed class Symbols : __MetaModel, ISymbols
    {
        // If there is an error at the following line, create a new class called 'CustomSymbolsImplementation'
        // inheriting from the class 'CustomSymbolsImplementationBase' and provide the custom implementation
        // for the derived properties and operations defined in the metamodel
        internal static readonly CustomSymbolsImplementationBase __CustomImpl = new CustomSymbolsImplementation();
    
        private static readonly Symbols _instance;
        public static Symbols MInstance => _instance;
    
        private static readonly __ModelProperty _Declaration_Name;
        private static readonly __ModelProperty _Declaration_Parent;
        private static readonly __ModelProperty _Declaration_Declarations;
        private static readonly __ModelProperty _Declaration_FullName;
        private static readonly __ModelProperty _Symbol_IsAbstract;
        private static readonly __ModelProperty _Symbol_BaseTypes;
        private static readonly __ModelProperty _Symbol_Properties;
        private static readonly __ModelProperty _Symbol_Operations;
        private static readonly __ModelProperty _Symbol_NamespaceName;
        private static readonly __ModelProperty _TypeReference_Type;
        private static readonly __ModelProperty _TypeReference_IsNullable;
        private static readonly __ModelProperty _TypeReference_Dimensions;
        private static readonly __ModelProperty _Property_Type;
        private static readonly __ModelProperty _Property_IsPlain;
        private static readonly __ModelProperty _Property_IsAbstract;
        private static readonly __ModelProperty _Property_IsDerived;
        private static readonly __ModelProperty _Property_IsCached;
        private static readonly __ModelProperty _Property_IsWeak;
        private static readonly __ModelProperty _Property_DefaultValue;
        private static readonly __ModelProperty _Property_Phase;
        private static readonly __ModelProperty _Operation_IsAbstract;
        private static readonly __ModelProperty _Operation_IsPhase;
        private static readonly __ModelProperty _Operation_IsCached;
        private static readonly __ModelProperty _Operation_CacheCondition;
        private static readonly __ModelProperty _Operation_ReturnType;
        private static readonly __ModelProperty _Operation_Parameters;
        private static readonly __ModelProperty _Parameter_Type;
    
        static Symbols()
        {
            _Declaration_Declarations = new __ModelProperty(typeof(Declaration), "Declarations", typeof(Declaration), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Declaration_FullName = new __ModelProperty(typeof(Declaration), "FullName", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Declaration_Name = new __ModelProperty(typeof(Declaration), "Name", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.Name, "Name");
            _Declaration_Parent = new __ModelProperty(typeof(Declaration), "Parent", typeof(Declaration), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Operation_CacheCondition = new __ModelProperty(typeof(Operation), "CacheCondition", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Operation_IsAbstract = new __ModelProperty(typeof(Operation), "IsAbstract", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Operation_IsCached = new __ModelProperty(typeof(Operation), "IsCached", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Operation_IsPhase = new __ModelProperty(typeof(Operation), "IsPhase", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Operation_Parameters = new __ModelProperty(typeof(Operation), "Parameters", typeof(Parameter), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Operation_ReturnType = new __ModelProperty(typeof(Operation), "ReturnType", typeof(TypeReference), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Parameter_Type = new __ModelProperty(typeof(Parameter), "Type", typeof(TypeReference), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Property_DefaultValue = new __ModelProperty(typeof(Property), "DefaultValue", typeof(object), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Property_IsAbstract = new __ModelProperty(typeof(Property), "IsAbstract", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Property_IsCached = new __ModelProperty(typeof(Property), "IsCached", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Property_IsDerived = new __ModelProperty(typeof(Property), "IsDerived", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Property_IsPlain = new __ModelProperty(typeof(Property), "IsPlain", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Property_IsWeak = new __ModelProperty(typeof(Property), "IsWeak", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Property_Phase = new __ModelProperty(typeof(Property), "Phase", typeof(Property), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Property_Type = new __ModelProperty(typeof(Property), "Type", typeof(TypeReference), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Single, null);
            _Symbol_BaseTypes = new __ModelProperty(typeof(Symbol), "BaseTypes", typeof(Symbol), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Collection, "BaseTypes");
            _Symbol_IsAbstract = new __ModelProperty(typeof(Symbol), "IsAbstract", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Symbol_NamespaceName = new __ModelProperty(typeof(Symbol), "NamespaceName", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single | __ModelPropertyFlags.ReadOnly | __ModelPropertyFlags.Derived, null);
            _Symbol_Operations = new __ModelProperty(typeof(Symbol), "Operations", typeof(Operation), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _Symbol_Properties = new __ModelProperty(typeof(Symbol), "Properties", typeof(Property), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ReferenceType | __ModelPropertyFlags.NullableType | __ModelPropertyFlags.ModelObjectType | __ModelPropertyFlags.Containment | __ModelPropertyFlags.Collection, null);
            _TypeReference_Dimensions = new __ModelProperty(typeof(TypeReference), "Dimensions", typeof(int), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _TypeReference_IsNullable = new __ModelProperty(typeof(TypeReference), "IsNullable", typeof(bool), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _TypeReference_Type = new __ModelProperty(typeof(TypeReference), "Type", typeof(__MetaType), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _instance = new Symbols();
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
    
    
        private Symbols()
        {
            _enumTypes = __ImmutableArray.Create<__MetaType>();
            _enumInfos = __ImmutableArray.Create<__ModelEnumInfo>();
            var enumInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelEnumInfo>();
            _enumInfosByType = enumInfosByType.ToImmutable();
            var enumInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelEnumInfo>();
            _enumInfosByName = enumInfosByName.ToImmutable();
    
            _classTypes = __ImmutableArray.Create<__MetaType>(typeof(Declaration), typeof(Namespace), typeof(Operation), typeof(Parameter), typeof(Property), typeof(Symbol), typeof(TypeReference));
            _classInfos = __ImmutableArray.Create<__ModelClassInfo>(DeclarationInfo, NamespaceInfo, OperationInfo, ParameterInfo, PropertyInfo, SymbolInfo, TypeReferenceInfo);
            var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
            classInfosByType.Add(typeof(Declaration), DeclarationInfo);
            classInfosByType.Add(typeof(Namespace), NamespaceInfo);
            classInfosByType.Add(typeof(Operation), OperationInfo);
            classInfosByType.Add(typeof(Parameter), ParameterInfo);
            classInfosByType.Add(typeof(Property), PropertyInfo);
            classInfosByType.Add(typeof(Symbol), SymbolInfo);
            classInfosByType.Add(typeof(TypeReference), TypeReferenceInfo);
            _classInfosByType = classInfosByType.ToImmutable();
            var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
            classInfosByName.Add("Declaration", DeclarationInfo);
            classInfosByName.Add("Namespace", NamespaceInfo);
            classInfosByName.Add("Operation", OperationInfo);
            classInfosByName.Add("Parameter", ParameterInfo);
            classInfosByName.Add("Property", PropertyInfo);
            classInfosByName.Add("Symbol", SymbolInfo);
            classInfosByName.Add("TypeReference", TypeReferenceInfo);
            _classInfosByName = classInfosByName.ToImmutable();
            _model = new __Model();
            var cf = new SymbolsModelFactory(_model, this);
            _model.IsSealed = true;
        }
    
        public override string MName => nameof(Symbols);
        public override string MNamespace => "MetaDslx.Languages.MetaSymbols.Model";
        public override __ModelVersion MVersion => default;
        public override string MUri => "MetaDslx.Languages.MetaSymbols.Model.Symbols";
        public override string MPrefix => "s";
        public override __Model MModel => _model;
    
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> MEnumInfosByType => _enumInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> MEnumInfosByName => _enumInfosByName;
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> MClassInfosByType => _classInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> MClassInfosByName => _classInfosByName;
    
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MEnumTypes => _enumTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> MEnumInfos => _enumInfos;
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MClassTypes => _classTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> MClassInfos => _classInfos;
    
    
    
        public static __ModelClassInfo DeclarationInfo => __Impl.Declaration_Impl.__Info.Instance;
        public static __ModelProperty Declaration_Name => _Declaration_Name;
        public static __ModelProperty Declaration_Parent => _Declaration_Parent;
        public static __ModelProperty Declaration_Declarations => _Declaration_Declarations;
        public static __ModelProperty Declaration_FullName => _Declaration_FullName;
        public static __ModelClassInfo NamespaceInfo => __Impl.Namespace_Impl.__Info.Instance;
        public static __ModelClassInfo OperationInfo => __Impl.Operation_Impl.__Info.Instance;
        public static __ModelProperty Operation_IsAbstract => _Operation_IsAbstract;
        public static __ModelProperty Operation_IsPhase => _Operation_IsPhase;
        public static __ModelProperty Operation_IsCached => _Operation_IsCached;
        public static __ModelProperty Operation_CacheCondition => _Operation_CacheCondition;
        public static __ModelProperty Operation_ReturnType => _Operation_ReturnType;
        public static __ModelProperty Operation_Parameters => _Operation_Parameters;
        public static __ModelClassInfo ParameterInfo => __Impl.Parameter_Impl.__Info.Instance;
        public static __ModelProperty Parameter_Type => _Parameter_Type;
        public static __ModelClassInfo PropertyInfo => __Impl.Property_Impl.__Info.Instance;
        public static __ModelProperty Property_Type => _Property_Type;
        public static __ModelProperty Property_IsPlain => _Property_IsPlain;
        public static __ModelProperty Property_IsAbstract => _Property_IsAbstract;
        public static __ModelProperty Property_IsDerived => _Property_IsDerived;
        public static __ModelProperty Property_IsCached => _Property_IsCached;
        public static __ModelProperty Property_IsWeak => _Property_IsWeak;
        public static __ModelProperty Property_DefaultValue => _Property_DefaultValue;
        public static __ModelProperty Property_Phase => _Property_Phase;
        public static __ModelClassInfo SymbolInfo => __Impl.Symbol_Impl.__Info.Instance;
        public static __ModelProperty Symbol_IsAbstract => _Symbol_IsAbstract;
        public static __ModelProperty Symbol_BaseTypes => _Symbol_BaseTypes;
        public static __ModelProperty Symbol_Properties => _Symbol_Properties;
        public static __ModelProperty Symbol_Operations => _Symbol_Operations;
        public static __ModelProperty Symbol_NamespaceName => _Symbol_NamespaceName;
        public static __ModelClassInfo TypeReferenceInfo => __Impl.TypeReference_Impl.__Info.Instance;
        public static __ModelProperty TypeReference_Type => _TypeReference_Type;
        public static __ModelProperty TypeReference_IsNullable => _TypeReference_IsNullable;
        public static __ModelProperty TypeReference_Dimensions => _TypeReference_Dimensions;
    }
}
