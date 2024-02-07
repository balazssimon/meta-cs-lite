#nullable enable

namespace MetaDslx.Languages.Ecore.Model
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

    public class EcoreModelFactory : __ModelFactory
    {
        public EcoreModelFactory(__Model model)
            : base(model, Ecore.MInstance)
        {
        }
    
        internal EcoreModelFactory(__Model model, Ecore metaModel)
            : base(model, metaModel)
        {
        }
    
        public EAnnotation EAnnotation(string? id = null)
        {
            return (EAnnotation)Ecore.EAnnotationInfo.Create(base.Model, id)!;
        }
    
        public EAttribute EAttribute(string? id = null)
        {
            return (EAttribute)Ecore.EAttributeInfo.Create(base.Model, id)!;
        }
    
        public EClass EClass(string? id = null)
        {
            return (EClass)Ecore.EClassInfo.Create(base.Model, id)!;
        }
    
        public EDataType EDataType(string? id = null)
        {
            return (EDataType)Ecore.EDataTypeInfo.Create(base.Model, id)!;
        }
    
        public EEnum EEnum(string? id = null)
        {
            return (EEnum)Ecore.EEnumInfo.Create(base.Model, id)!;
        }
    
        public EEnumLiteral EEnumLiteral(string? id = null)
        {
            return (EEnumLiteral)Ecore.EEnumLiteralInfo.Create(base.Model, id)!;
        }
    
        public EFactory EFactory(string? id = null)
        {
            return (EFactory)Ecore.EFactoryInfo.Create(base.Model, id)!;
        }
    
        public EGenericType EGenericType(string? id = null)
        {
            return (EGenericType)Ecore.EGenericTypeInfo.Create(base.Model, id)!;
        }
    
        public EObject EObject(string? id = null)
        {
            return (EObject)Ecore.EObjectInfo.Create(base.Model, id)!;
        }
    
        public EOperation EOperation(string? id = null)
        {
            return (EOperation)Ecore.EOperationInfo.Create(base.Model, id)!;
        }
    
        public EPackage EPackage(string? id = null)
        {
            return (EPackage)Ecore.EPackageInfo.Create(base.Model, id)!;
        }
    
        public EParameter EParameter(string? id = null)
        {
            return (EParameter)Ecore.EParameterInfo.Create(base.Model, id)!;
        }
    
        public EReference EReference(string? id = null)
        {
            return (EReference)Ecore.EReferenceInfo.Create(base.Model, id)!;
        }
    
        public EStringToStringMapEntry EStringToStringMapEntry(string? id = null)
        {
            return (EStringToStringMapEntry)Ecore.EStringToStringMapEntryInfo.Create(base.Model, id)!;
        }
    
        public ETypeParameter ETypeParameter(string? id = null)
        {
            return (ETypeParameter)Ecore.ETypeParameterInfo.Create(base.Model, id)!;
        }
    
    }
    
    public class EcoreModelMultiFactory : __MultiModelFactory
    {
        public EcoreModelMultiFactory()
            : base(new __MetaModel[] { Ecore.MInstance })
        {
        }
    
        public EAnnotation EAnnotation(__Model model, string? id = null)
        {
            return (EAnnotation)Ecore.EAnnotationInfo.Create(model, id)!;
        }
    
        public EAttribute EAttribute(__Model model, string? id = null)
        {
            return (EAttribute)Ecore.EAttributeInfo.Create(model, id)!;
        }
    
        public EClass EClass(__Model model, string? id = null)
        {
            return (EClass)Ecore.EClassInfo.Create(model, id)!;
        }
    
        public EDataType EDataType(__Model model, string? id = null)
        {
            return (EDataType)Ecore.EDataTypeInfo.Create(model, id)!;
        }
    
        public EEnum EEnum(__Model model, string? id = null)
        {
            return (EEnum)Ecore.EEnumInfo.Create(model, id)!;
        }
    
        public EEnumLiteral EEnumLiteral(__Model model, string? id = null)
        {
            return (EEnumLiteral)Ecore.EEnumLiteralInfo.Create(model, id)!;
        }
    
        public EFactory EFactory(__Model model, string? id = null)
        {
            return (EFactory)Ecore.EFactoryInfo.Create(model, id)!;
        }
    
        public EGenericType EGenericType(__Model model, string? id = null)
        {
            return (EGenericType)Ecore.EGenericTypeInfo.Create(model, id)!;
        }
    
        public EObject EObject(__Model model, string? id = null)
        {
            return (EObject)Ecore.EObjectInfo.Create(model, id)!;
        }
    
        public EOperation EOperation(__Model model, string? id = null)
        {
            return (EOperation)Ecore.EOperationInfo.Create(model, id)!;
        }
    
        public EPackage EPackage(__Model model, string? id = null)
        {
            return (EPackage)Ecore.EPackageInfo.Create(model, id)!;
        }
    
        public EParameter EParameter(__Model model, string? id = null)
        {
            return (EParameter)Ecore.EParameterInfo.Create(model, id)!;
        }
    
        public EReference EReference(__Model model, string? id = null)
        {
            return (EReference)Ecore.EReferenceInfo.Create(model, id)!;
        }
    
        public EStringToStringMapEntry EStringToStringMapEntry(__Model model, string? id = null)
        {
            return (EStringToStringMapEntry)Ecore.EStringToStringMapEntryInfo.Create(model, id)!;
        }
    
        public ETypeParameter ETypeParameter(__Model model, string? id = null)
        {
            return (ETypeParameter)Ecore.ETypeParameterInfo.Create(model, id)!;
        }
    
    }
}
