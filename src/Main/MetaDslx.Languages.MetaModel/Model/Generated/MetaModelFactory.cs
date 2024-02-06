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
    
        public MetaDeclaration MetaDeclaration(string? id = null)
        {
            return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(Model, id)!;
        }
    
        public MetaConstant MetaConstant(string? id = null)
        {
            return (MetaConstant)Meta.MetaConstantInfo.Create(Model, id)!;
        }
    
        public MetaModel MetaModel(string? id = null)
        {
            return (MetaModel)Meta.MetaModelInfo.Create(Model, id)!;
        }
    
        public MetaNamespace MetaNamespace(string? id = null)
        {
            return (MetaNamespace)Meta.MetaNamespaceInfo.Create(Model, id)!;
        }
    
        public MetaArrayType MetaArrayType(string? id = null)
        {
            return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(Model, id)!;
        }
    
        public MetaClass MetaClass(string? id = null)
        {
            return (MetaClass)Meta.MetaClassInfo.Create(Model, id)!;
        }
    
        public MetaEnum MetaEnum(string? id = null)
        {
            return (MetaEnum)Meta.MetaEnumInfo.Create(Model, id)!;
        }
    
        public MetaEnumLiteral MetaEnumLiteral(string? id = null)
        {
            return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(Model, id)!;
        }
    
        public MetaNullableType MetaNullableType(string? id = null)
        {
            return (MetaNullableType)Meta.MetaNullableTypeInfo.Create(Model, id)!;
        }
    
        public MetaOperation MetaOperation(string? id = null)
        {
            return (MetaOperation)Meta.MetaOperationInfo.Create(Model, id)!;
        }
    
        public MetaParameter MetaParameter(string? id = null)
        {
            return (MetaParameter)Meta.MetaParameterInfo.Create(Model, id)!;
        }
    
        public MetaPrimitiveType MetaPrimitiveType(string? id = null)
        {
            return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(Model, id)!;
        }
    
        public MetaProperty MetaProperty(string? id = null)
        {
            return (MetaProperty)Meta.MetaPropertyInfo.Create(Model, id)!;
        }
    
    }
    
    public class MetaModelMultiFactory : __MultiModelFactory
    {
        public MetaModelMultiFactory()
            : base(new __MetaModel[] { Meta.MInstance })
        {
        }
    
        public MetaDeclaration MetaDeclaration(__Model model, string? id = null)
        {
            return (MetaDeclaration)Meta.MetaDeclarationInfo.Create(model, id)!;
        }
    
        public MetaConstant MetaConstant(__Model model, string? id = null)
        {
            return (MetaConstant)Meta.MetaConstantInfo.Create(model, id)!;
        }
    
        public MetaModel MetaModel(__Model model, string? id = null)
        {
            return (MetaModel)Meta.MetaModelInfo.Create(model, id)!;
        }
    
        public MetaNamespace MetaNamespace(__Model model, string? id = null)
        {
            return (MetaNamespace)Meta.MetaNamespaceInfo.Create(model, id)!;
        }
    
        public MetaArrayType MetaArrayType(__Model model, string? id = null)
        {
            return (MetaArrayType)Meta.MetaArrayTypeInfo.Create(model, id)!;
        }
    
        public MetaClass MetaClass(__Model model, string? id = null)
        {
            return (MetaClass)Meta.MetaClassInfo.Create(model, id)!;
        }
    
        public MetaEnum MetaEnum(__Model model, string? id = null)
        {
            return (MetaEnum)Meta.MetaEnumInfo.Create(model, id)!;
        }
    
        public MetaEnumLiteral MetaEnumLiteral(__Model model, string? id = null)
        {
            return (MetaEnumLiteral)Meta.MetaEnumLiteralInfo.Create(model, id)!;
        }
    
        public MetaNullableType MetaNullableType(__Model model, string? id = null)
        {
            return (MetaNullableType)Meta.MetaNullableTypeInfo.Create(model, id)!;
        }
    
        public MetaOperation MetaOperation(__Model model, string? id = null)
        {
            return (MetaOperation)Meta.MetaOperationInfo.Create(model, id)!;
        }
    
        public MetaParameter MetaParameter(__Model model, string? id = null)
        {
            return (MetaParameter)Meta.MetaParameterInfo.Create(model, id)!;
        }
    
        public MetaPrimitiveType MetaPrimitiveType(__Model model, string? id = null)
        {
            return (MetaPrimitiveType)Meta.MetaPrimitiveTypeInfo.Create(model, id)!;
        }
    
        public MetaProperty MetaProperty(__Model model, string? id = null)
        {
            return (MetaProperty)Meta.MetaPropertyInfo.Create(model, id)!;
        }
    
    }
}
