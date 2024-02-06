#nullable enable

namespace MetaDslx.Languages.Uml.Model
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

    public interface Operation : global::MetaDslx.Languages.Uml.Model.TemplateableElement, global::MetaDslx.Languages.Uml.Model.ParameterableElement, global::MetaDslx.Languages.Uml.Model.BehavioralFeature
    {
        Constraint BodyCondition { get; set; }
        Class Class { get; set; }
        DataType Datatype { get; set; }
        Interface Interface { get; set; }
        bool IsOrdered { get; }
        bool IsQuery { get; set; }
        bool IsUnique { get; }
        int Lower { get; }
        new global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Postcondition { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Constraint> Precondition { get; }
        new global::MetaDslx.Modeling.ICollectionSlot<Type> RaisedException { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Operation> RedefinedOperation { get; }
        new OperationTemplateParameter TemplateParameter { get; set; }
        Type Type { get; }
        int Upper { get; }
    
        bool IsConsistentWith(bool result, RedefinableElement redefiningElement);
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> ReturnResult(global::MetaDslx.Modeling.ICollectionSlot<Parameter> result);
    }
}
