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
    
        /// <summary>
        /// Constructor for the class MetaDeclaration
        /// </summary>
        public virtual void MetaDeclaration(MetaDeclaration _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaConstant
        /// </summary>
        public virtual void MetaConstant(MetaConstant _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaModel
        /// </summary>
        public virtual void MetaModel(MetaModel _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaNamespace
        /// </summary>
        public virtual void MetaNamespace(MetaNamespace _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaType
        /// </summary>
        public virtual void MetaType(MetaType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaArrayType
        /// </summary>
        public virtual void MetaArrayType(MetaArrayType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaClass
        /// </summary>
        public virtual void MetaClass(MetaClass _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaEnum
        /// </summary>
        public virtual void MetaEnum(MetaEnum _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaEnumLiteral
        /// </summary>
        public virtual void MetaEnumLiteral(MetaEnumLiteral _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaNullableType
        /// </summary>
        public virtual void MetaNullableType(MetaNullableType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaOperation
        /// </summary>
        public virtual void MetaOperation(MetaOperation _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaParameter
        /// </summary>
        public virtual void MetaParameter(MetaParameter _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaPrimitiveType
        /// </summary>
        public virtual void MetaPrimitiveType(MetaPrimitiveType _this)
        {
        }
    
        /// <summary>
        /// Constructor for the class MetaProperty
        /// </summary>
        public virtual void MetaProperty(MetaProperty _this)
        {
        }
    
    
        /// <summary>
        /// Computation of the derived property MetaDeclaration.FullName
        /// </summary>
        public abstract string? MetaDeclaration_FullName(MetaDeclaration _this);
    
        /// <summary>
        /// Computation of the derived property MetaModel.NamespaceName
        /// </summary>
        public abstract string MetaModel_NamespaceName(MetaModel _this);
    
    
    }
}
