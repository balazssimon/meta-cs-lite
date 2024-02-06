#nullable enable

namespace MetaDslx.Languages.MetaModel.Model
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

    internal interface ICustomMetaImplementation
    {
        /// <summary>
        /// Constructor for the meta model Meta
        /// </summary>
        void Meta(IMeta _this);
    
        /// <summary>
        /// Constructor for the class MetaDeclaration
        /// </summary>
        void MetaDeclaration(MetaDeclaration _this);
    
        /// <summary>
        /// Constructor for the class MetaConstant
        /// </summary>
        void MetaConstant(MetaConstant _this);
    
        /// <summary>
        /// Constructor for the class MetaModel
        /// </summary>
        void MetaModel(MetaModel _this);
    
        /// <summary>
        /// Constructor for the class MetaNamespace
        /// </summary>
        void MetaNamespace(MetaNamespace _this);
    
        /// <summary>
        /// Constructor for the class MetaType
        /// </summary>
        void MetaType(MetaType _this);
    
        /// <summary>
        /// Constructor for the class MetaArrayType
        /// </summary>
        void MetaArrayType(MetaArrayType _this);
    
        /// <summary>
        /// Constructor for the class MetaClass
        /// </summary>
        void MetaClass(MetaClass _this);
    
        /// <summary>
        /// Constructor for the class MetaEnum
        /// </summary>
        void MetaEnum(MetaEnum _this);
    
        /// <summary>
        /// Constructor for the class MetaEnumLiteral
        /// </summary>
        void MetaEnumLiteral(MetaEnumLiteral _this);
    
        /// <summary>
        /// Constructor for the class MetaNullableType
        /// </summary>
        void MetaNullableType(MetaNullableType _this);
    
        /// <summary>
        /// Constructor for the class MetaOperation
        /// </summary>
        void MetaOperation(MetaOperation _this);
    
        /// <summary>
        /// Constructor for the class MetaParameter
        /// </summary>
        void MetaParameter(MetaParameter _this);
    
        /// <summary>
        /// Constructor for the class MetaPrimitiveType
        /// </summary>
        void MetaPrimitiveType(MetaPrimitiveType _this);
    
        /// <summary>
        /// Constructor for the class MetaProperty
        /// </summary>
        void MetaProperty(MetaProperty _this);
    
    
        /// <summary>
        /// Computation of the derived property MetaDeclaration.FullName
        /// </summary>
        string? MetaDeclaration_FullName(MetaDeclaration _this);
    
        /// <summary>
        /// Computation of the derived property MetaModel.NamespaceName
        /// </summary>
        string MetaModel_NamespaceName(MetaModel _this);
    
    
    }
}
