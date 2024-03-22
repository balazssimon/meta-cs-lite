namespace MetaDslx.Examples.Soal.Model
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

    internal interface ICustomSoalImplementation
    {
        /// <summary>
        /// Constructor for the meta model Soal
        /// </summary>
        void Soal(ISoal _this);
    
        void BuiltInType(BuiltInType _this);
    
        void Declaration(Declaration _this);
    
        void Documentation(Documentation _this);
    
        void DocumentationTag(DocumentationTag _this);
    
        void Element(Element _this);
    
        void EnumLiteral(EnumLiteral _this);
    
        void EnumType(EnumType _this);
    
        void Interface(Interface _this);
    
        void NamedElement(NamedElement _this);
    
        void NamedType(NamedType _this);
    
        void Operation(Operation _this);
    
        void Parameter(Parameter _this);
    
        void ParameterList(ParameterList _this);
    
        void Property(Property _this);
    
        void Resource(Resource _this);
    
        void Service(Service _this);
    
        void StructType(StructType _this);
    
        void Type(Type _this);
    
        void TypedElement(TypedElement _this);
    
        void TypeReference(TypeReference _this);
    
        void Variable(Variable _this);
    
    
        string BuiltInType_Name(BuiltInType _this);
    
        string DocumentationTag_Html(DocumentationTag _this);
    
        string NamedElement_UniqueName(NamedElement _this);
    
        MetaDslx.Examples.Soal.Model.Documentation NamedElement_Documentation(NamedElement _this);
    
        string NamedElement_HoverDocumentation(NamedElement _this);
    
        bool Operation_HasRequestParameters(Operation _this);
    
        bool Operation_HasResponseParameters(Operation _this);
    
        bool Operation_HasManyRequestParameters(Operation _this);
    
        bool Operation_HasManyResponseParameters(Operation _this);
    
        bool Operation_HasSingleResponseParameter(Operation _this);
    
        MetaDslx.Examples.Soal.Model.TypeReference Operation_SingleReturnType(Operation _this);
    
        string Resource_Name(Resource _this);
    
    
    }
}
