#pragma warning disable CS8669

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

    public interface Grammar : global::MetaDslx.Languages.MetaCompiler.Model.Declaration
    {
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Block> Blocks { get; }
        MetaDslx.Languages.MetaCompiler.Model.Token? DefaultEndOfLine { get; set; }
        MetaDslx.Languages.MetaCompiler.Model.Token? DefaultIdentifier { get; set; }
        MetaDslx.Languages.MetaCompiler.Model.Token? DefaultSeparator { get; set; }
        MetaDslx.Languages.MetaCompiler.Model.Token? DefaultWhitespace { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.GrammarRule> GrammarRules { get; }
        MetaDslx.Languages.MetaCompiler.Model.Language Language { get; }
        MetaDslx.Languages.MetaCompiler.Model.Rule? MainRule { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Rule> Rules { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.TokenKind> TokenKinds { get; }
        global::MetaDslx.Modeling.ICollectionSlot<MetaDslx.Languages.MetaCompiler.Model.Token> Tokens { get; }
    
    }
}
