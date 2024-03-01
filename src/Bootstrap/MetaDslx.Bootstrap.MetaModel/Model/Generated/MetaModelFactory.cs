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

    public class MetaModelFactory : __ModelFactory
    {
        public MetaModelFactory(__Model model)
            : base(model, Meta.MInstance)
        {
        }
    
        internal MetaModelFactory(__Model model, Meta metaModel)
            : base(model, metaModel)
        {
        }
    
        public MetaClass MetaClass(string? id = null)
        {
            return (MetaClass)Meta.MetaClassInfo.Create(base.Model, id)!;
        }
    
        public MetaConstant MetaConstant(string? id = null)
        {
            return (MetaConstant)Meta.MetaConstantInfo.Create(base.Model, id)!;
        }
    
        public MetaDeclaration MetaDeclaration(string? id = null)
        {
            return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(base.Model, id)!;
        }
    
        public MetaEnum MetaEnum(string? id = null)
        {
            return (MetaEnum)Meta.MetaEnumInfo.Create(base.Model, id)!;
        }
    
        public MetaEnumLiteral MetaEnumLiteral(string? id = null)
        {
            return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(base.Model, id)!;
        }
    
        public MetaModel MetaModel(string? id = null)
        {
            return (MetaModel)Meta.MetaModelInfo.Create(base.Model, id)!;
        }
    
        public MetaOperation MetaOperation(string? id = null)
        {
            return (MetaOperation)Meta.MetaOperationInfo.Create(base.Model, id)!;
        }
    
        public MetaParameter MetaParameter(string? id = null)
        {
            return (MetaParameter)Meta.MetaParameterInfo.Create(base.Model, id)!;
        }
    
        public MetaProperty MetaProperty(string? id = null)
        {
            return (MetaProperty)Meta.MetaPropertyInfo.Create(base.Model, id)!;
        }
    
        public MetaTypeReference MetaTypeReference(string? id = null)
        {
            return (MetaTypeReference)Meta.MetaTypeReferenceInfo.Create(base.Model, id)!;
        }
    
    }
    
    public class MetaModelMultiFactory : __MultiModelFactory
    {
        public MetaModelMultiFactory()
            : base(new __MetaModel[] { Meta.MInstance })
        {
        }
    
        public MetaClass MetaClass(__Model model, string? id = null)
        {
            return (MetaClass)Meta.MetaClassInfo.Create(model, id)!;
        }
    
        public MetaConstant MetaConstant(__Model model, string? id = null)
        {
            return (MetaConstant)Meta.MetaConstantInfo.Create(model, id)!;
        }
    
        public MetaDeclaration MetaDeclaration(__Model model, string? id = null)
        {
            return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(model, id)!;
        }
    
        public MetaEnum MetaEnum(__Model model, string? id = null)
        {
            return (MetaEnum)Meta.MetaEnumInfo.Create(model, id)!;
        }
    
        public MetaEnumLiteral MetaEnumLiteral(__Model model, string? id = null)
        {
            return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(model, id)!;
        }
    
        public MetaModel MetaModel(__Model model, string? id = null)
        {
            return (MetaModel)Meta.MetaModelInfo.Create(model, id)!;
        }
    
        public MetaOperation MetaOperation(__Model model, string? id = null)
        {
            return (MetaOperation)Meta.MetaOperationInfo.Create(model, id)!;
        }
    
        public MetaParameter MetaParameter(__Model model, string? id = null)
        {
            return (MetaParameter)Meta.MetaParameterInfo.Create(model, id)!;
        }
    
        public MetaProperty MetaProperty(__Model model, string? id = null)
        {
            return (MetaProperty)Meta.MetaPropertyInfo.Create(model, id)!;
        }
    
        public MetaTypeReference MetaTypeReference(__Model model, string? id = null)
        {
            return (MetaTypeReference)Meta.MetaTypeReferenceInfo.Create(model, id)!;
        }
    
    }
}
