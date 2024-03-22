#pragma warning disable CS8669

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

    internal abstract class CustomSoalImplementationBase : ICustomSoalImplementation
    {
        /// <summary>
        /// Constructor for the meta model Soal
        /// </summary>
        public virtual void Soal(ISoal _this)
        {
        }
    
        public virtual void BuiltInType(BuiltInType _this)
        {
        }
    
        public virtual void Declaration(Declaration _this)
        {
        }
    
        public virtual void Documentation(Documentation _this)
        {
        }
    
        public virtual void DocumentationTag(DocumentationTag _this)
        {
        }
    
        public virtual void Element(Element _this)
        {
        }
    
        public virtual void EnumLiteral(EnumLiteral _this)
        {
        }
    
        public virtual void EnumType(EnumType _this)
        {
        }
    
        public virtual void Interface(Interface _this)
        {
        }
    
        public virtual void NamedElement(NamedElement _this)
        {
        }
    
        public virtual void NamedType(NamedType _this)
        {
        }
    
        public virtual void Operation(Operation _this)
        {
        }
    
        public virtual void Parameter(Parameter _this)
        {
        }
    
        public virtual void ParameterList(ParameterList _this)
        {
        }
    
        public virtual void Property(Property _this)
        {
        }
    
        public virtual void Resource(Resource _this)
        {
        }
    
        public virtual void Service(Service _this)
        {
        }
    
        public virtual void StructType(StructType _this)
        {
        }
    
        public virtual void Type(Type _this)
        {
        }
    
        public virtual void TypedElement(TypedElement _this)
        {
        }
    
        public virtual void TypeReference(TypeReference _this)
        {
        }
    
        public virtual void Variable(Variable _this)
        {
        }
    
    
        public abstract string BuiltInType_Name(BuiltInType _this);
    
        public abstract string DocumentationTag_Html(DocumentationTag _this);
    
        public abstract string NamedElement_UniqueName(NamedElement _this);
    
        public abstract MetaDslx.Examples.Soal.Model.Documentation NamedElement_Documentation(NamedElement _this);
    
        public abstract string NamedElement_HoverDocumentation(NamedElement _this);
    
        public abstract bool Operation_HasRequestParameters(Operation _this);
    
        public abstract bool Operation_HasResponseParameters(Operation _this);
    
        public abstract bool Operation_HasManyRequestParameters(Operation _this);
    
        public abstract bool Operation_HasManyResponseParameters(Operation _this);
    
        public abstract bool Operation_HasSingleResponseParameter(Operation _this);
    
        public abstract MetaDslx.Examples.Soal.Model.TypeReference Operation_SingleReturnType(Operation _this);
    
        public abstract string Resource_Name(Resource _this);
    
    
    }
}
