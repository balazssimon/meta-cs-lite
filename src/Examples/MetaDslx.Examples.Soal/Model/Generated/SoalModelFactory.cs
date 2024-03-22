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

    public class SoalModelFactory : __ModelFactory
    {
        public SoalModelFactory(__Model model)
            : base(model, Soal.MInstance)
        {
        }
    
        internal SoalModelFactory(__Model model, Soal metaModel)
            : base(model, metaModel)
        {
        }
    
        public BuiltInType BuiltInType(string? id = null)
        {
            return (BuiltInType)Soal.BuiltInTypeInfo.Create(base.Model, id)!;
        }
    
        public Documentation Documentation(string? id = null)
        {
            return (Documentation)Soal.DocumentationInfo.Create(base.Model, id)!;
        }
    
        public DocumentationTag DocumentationTag(string? id = null)
        {
            return (DocumentationTag)Soal.DocumentationTagInfo.Create(base.Model, id)!;
        }
    
        public EnumLiteral EnumLiteral(string? id = null)
        {
            return (EnumLiteral)Soal.EnumLiteralInfo.Create(base.Model, id)!;
        }
    
        public EnumType EnumType(string? id = null)
        {
            return (EnumType)Soal.EnumTypeInfo.Create(base.Model, id)!;
        }
    
        public Interface Interface(string? id = null)
        {
            return (Interface)Soal.InterfaceInfo.Create(base.Model, id)!;
        }
    
        public Operation Operation(string? id = null)
        {
            return (Operation)Soal.OperationInfo.Create(base.Model, id)!;
        }
    
        public Parameter Parameter(string? id = null)
        {
            return (Parameter)Soal.ParameterInfo.Create(base.Model, id)!;
        }
    
        public ParameterList ParameterList(string? id = null)
        {
            return (ParameterList)Soal.ParameterListInfo.Create(base.Model, id)!;
        }
    
        public Property Property(string? id = null)
        {
            return (Property)Soal.PropertyInfo.Create(base.Model, id)!;
        }
    
        public Resource Resource(string? id = null)
        {
            return (Resource)Soal.ResourceInfo.Create(base.Model, id)!;
        }
    
        public Service Service(string? id = null)
        {
            return (Service)Soal.ServiceInfo.Create(base.Model, id)!;
        }
    
        public StructType StructType(string? id = null)
        {
            return (StructType)Soal.StructTypeInfo.Create(base.Model, id)!;
        }
    
        public TypeReference TypeReference(string? id = null)
        {
            return (TypeReference)Soal.TypeReferenceInfo.Create(base.Model, id)!;
        }
    
        public Variable Variable(string? id = null)
        {
            return (Variable)Soal.VariableInfo.Create(base.Model, id)!;
        }
    
    }
    
    public class SoalModelMultiFactory : __MultiModelFactory
    {
        public SoalModelMultiFactory()
            : base(new __MetaModel[] { Soal.MInstance })
        {
        }
    
        public BuiltInType BuiltInType(__Model model, string? id = null)
        {
            return (BuiltInType)Soal.BuiltInTypeInfo.Create(model, id)!;
        }
    
        public Documentation Documentation(__Model model, string? id = null)
        {
            return (Documentation)Soal.DocumentationInfo.Create(model, id)!;
        }
    
        public DocumentationTag DocumentationTag(__Model model, string? id = null)
        {
            return (DocumentationTag)Soal.DocumentationTagInfo.Create(model, id)!;
        }
    
        public EnumLiteral EnumLiteral(__Model model, string? id = null)
        {
            return (EnumLiteral)Soal.EnumLiteralInfo.Create(model, id)!;
        }
    
        public EnumType EnumType(__Model model, string? id = null)
        {
            return (EnumType)Soal.EnumTypeInfo.Create(model, id)!;
        }
    
        public Interface Interface(__Model model, string? id = null)
        {
            return (Interface)Soal.InterfaceInfo.Create(model, id)!;
        }
    
        public Operation Operation(__Model model, string? id = null)
        {
            return (Operation)Soal.OperationInfo.Create(model, id)!;
        }
    
        public Parameter Parameter(__Model model, string? id = null)
        {
            return (Parameter)Soal.ParameterInfo.Create(model, id)!;
        }
    
        public ParameterList ParameterList(__Model model, string? id = null)
        {
            return (ParameterList)Soal.ParameterListInfo.Create(model, id)!;
        }
    
        public Property Property(__Model model, string? id = null)
        {
            return (Property)Soal.PropertyInfo.Create(model, id)!;
        }
    
        public Resource Resource(__Model model, string? id = null)
        {
            return (Resource)Soal.ResourceInfo.Create(model, id)!;
        }
    
        public Service Service(__Model model, string? id = null)
        {
            return (Service)Soal.ServiceInfo.Create(model, id)!;
        }
    
        public StructType StructType(__Model model, string? id = null)
        {
            return (StructType)Soal.StructTypeInfo.Create(model, id)!;
        }
    
        public TypeReference TypeReference(__Model model, string? id = null)
        {
            return (TypeReference)Soal.TypeReferenceInfo.Create(model, id)!;
        }
    
        public Variable Variable(__Model model, string? id = null)
        {
            return (Variable)Soal.VariableInfo.Create(model, id)!;
        }
    
    }
}
