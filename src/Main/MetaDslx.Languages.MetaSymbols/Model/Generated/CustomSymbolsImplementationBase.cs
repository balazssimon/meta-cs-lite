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

    internal abstract class CustomSymbolsImplementationBase : ICustomSymbolsImplementation
    {
        /// <summary>
        /// Constructor for the meta model Symbols
        /// </summary>
        public virtual void Symbols(ISymbols _this)
        {
        }
    
        public virtual void Declaration(Declaration _this)
        {
        }
    
        public virtual void Namespace(Namespace _this)
        {
        }
    
        public virtual void Operation(Operation _this)
        {
        }
    
        public virtual void Parameter(Parameter _this)
        {
        }
    
        public virtual void Property(Property _this)
        {
        }
    
        public virtual void Symbol(Symbol _this)
        {
        }
    
        public virtual void TypeReference(TypeReference _this)
        {
        }
    
    
        public abstract string? Declaration_FullName(Declaration _this);
    
        public abstract string Symbol_NamespaceName(Symbol _this);
    
    
    }
}