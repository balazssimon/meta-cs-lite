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

    internal abstract class CustomMetaImplementationBase : ICustomMetaImplementation
    {
        /// <summary>
        /// Constructor for the meta model Meta
        /// </summary>
        public virtual void Meta(IMeta _this)
        {
        }
    
        public virtual void MetaClass(MetaClass _this)
        {
        }
    
        public virtual void MetaConstant(MetaConstant _this)
        {
        }
    
        public virtual void MetaDeclaration(MetaDeclaration _this)
        {
        }
    
        public virtual void MetaEnum(MetaEnum _this)
        {
        }
    
        public virtual void MetaEnumLiteral(MetaEnumLiteral _this)
        {
        }
    
        public virtual void MetaModel(MetaModel _this)
        {
        }
    
        public virtual void MetaOperation(MetaOperation _this)
        {
        }
    
        public virtual void MetaParameter(MetaParameter _this)
        {
        }
    
        public virtual void MetaProperty(MetaProperty _this)
        {
        }
    
        public virtual void MetaTypeReference(MetaTypeReference _this)
        {
        }
    
    
        public abstract string MetaDeclaration_Namespace(MetaDeclaration _this);
    
        public abstract string? MetaDeclaration_FullName(MetaDeclaration _this);
    
    
    }
}
