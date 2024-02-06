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

    public interface Property : global::MetaDslx.Languages.Mof.Model.StructuralFeature
    {
        global::MetaDslx.Languages.Mof.Model.AggregationKind Aggregation { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Association> Association { get; }
        Class Class { get; set; }
        string Default { get; }
        ValueSpecification DefaultValue { get; set; }
        bool IsComposite { get; }
        bool IsDerived { get; set; }
        bool IsDerivedUnion { get; set; }
        bool IsID { get; set; }
        Property Opposite { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Association> OwningAssociation { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Property> RedefinedProperty { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Property> SubsettedProperty { get; }
    
    }
}
