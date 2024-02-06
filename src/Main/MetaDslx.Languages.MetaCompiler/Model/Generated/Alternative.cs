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

    public interface Alternative : global::MetaDslx.Languages.MetaCompiler.Model.Declaration, global::MetaDslx.Languages.MetaCompiler.Model.CSharpElement
    {
        global::MetaDslx.Modeling.ICollectionSlot<Element> Elements { get; }
        string GreenConstructorArguments { get; }
        string GreenConstructorParameters { get; }
        string GreenName { get; }
        string GreenUpdateArguments { get; }
        string GreenUpdateParameters { get; }
        bool HasRedToGreenOptionalArguments { get; }
        string RedName { get; }
        string RedOptionalUpdateParameters { get; }
        string RedToGreenArgumentList { get; }
        string RedToGreenOptionalArgumentList { get; }
        string RedUpdateArguments { get; }
        string RedUpdateParameters { get; }
        __MetaType ReturnType { get; set; }
        Expression ReturnValue { get; set; }
    
    }
}
