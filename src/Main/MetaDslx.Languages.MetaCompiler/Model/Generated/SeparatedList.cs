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

    public interface SeparatedList : global::MetaDslx.Languages.MetaCompiler.Model.ElementValue
    {
        global::MetaDslx.Modeling.ICollectionSlot<Element> FirstItems { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Element> FirstSeparators { get; }
        new string? GreenSyntaxCondition { get; }
        new string GreenType { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Element> LastItems { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Element> LastSeparators { get; }
        new string RedType { get; }
        Element RepeatedBlock { get; set; }
        Element RepeatedItem { get; set; }
        Element RepeatedSeparator { get; set; }
        bool RepeatedSeparatorFirst { get; set; }
        bool SeparatorFirst { get; set; }
    
    }
}
