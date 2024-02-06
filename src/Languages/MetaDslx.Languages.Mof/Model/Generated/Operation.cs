#nullable enable

namespace MetaDslx.Languages.Mof.Model
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

    public interface Operation : global::MetaDslx.Languages.Mof.Model.BehavioralFeature
    {
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> BodyCondition { get; }
        Class Class { get; set; }
        bool IsAbstract { get; set; }
        bool IsOrdered { get; }
        bool IsQuery { get; set; }
        bool IsUnique { get; }
        long Lower { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Postcondition { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Precondition { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Type> RaisedException { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Operation> RedefinedOperation { get; }
        long Upper { get; }
    
    }
}
