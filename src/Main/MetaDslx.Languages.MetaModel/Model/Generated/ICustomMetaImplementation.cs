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
    
        void MetaClass(MetaClass _this);
    
        void MetaConstant(MetaConstant _this);
    
        void MetaDeclaration(MetaDeclaration _this);
    
        void MetaEnum(MetaEnum _this);
    
        void MetaEnumLiteral(MetaEnumLiteral _this);
    
        void MetaModel(MetaModel _this);
    
        void MetaOperation(MetaOperation _this);
    
        void MetaParameter(MetaParameter _this);
    
        void MetaProperty(MetaProperty _this);
    
        void MetaTypeReference(MetaTypeReference _this);
    
    
        string MetaDeclaration_Namespace(MetaDeclaration _this);
    
        string? MetaDeclaration_FullName(MetaDeclaration _this);
    
    
    }
}
