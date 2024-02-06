#nullable enable

namespace MetaDslx.Languages.MetaCompiler.Model
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

    public interface Element : global::MetaDslx.Languages.MetaCompiler.Model.CSharpElement
    {
        global::MetaDslx.Languages.MetaCompiler.Model.Assignment Assignment { get; set; }
        string FieldName { get; }
        string GreenFieldType { get; }
        string GreenParameterValue { get; }
        string GreenPropertyType { get; }
        string GreenPropertyValue { get; }
        string? GreenSyntaxCondition { get; }
        string? GreenSyntaxNullCondition { get; }
        bool IsList { get; }
        bool IsOptionalUpdateParameter { get; }
        bool IsToken { get; }
        string? Name { get; set; }
        string ParameterName { get; }
        string PropertyName { get; }
        string RedFieldType { get; }
        string RedParameterValue { get; }
        string RedPropertyType { get; }
        string RedPropertyValue { get; }
        string? RedSyntaxCondition { get; }
        string? RedSyntaxNullCondition { get; }
        string RedToGreenArgument { get; }
        string RedToGreenOptionalArgument { get; }
        ElementValue Value { get; set; }
        string? VisitCall { get; }
    
    }
}
