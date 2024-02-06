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

    public interface Property : global::MetaDslx.Languages.Uml.Model.ConnectableElement, global::MetaDslx.Languages.Uml.Model.DeploymentTarget, global::MetaDslx.Languages.Uml.Model.StructuralFeature
    {
        global::MetaDslx.Languages.Uml.Model.AggregationKind Aggregation { get; set; }
        Association Association { get; set; }
        Property AssociationEnd { get; set; }
        Class Class { get; set; }
        DataType Datatype { get; set; }
        ValueSpecification DefaultValue { get; set; }
        Interface Interface { get; set; }
        bool IsComposite { get; }
        bool IsDerived { get; set; }
        bool IsDerivedUnion { get; set; }
        bool IsID { get; set; }
        Property Opposite { get; }
        Association OwningAssociation { get; set; }
        global::MetaDslx.Modeling.ICollectionSlot<Property> Qualifier { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Property> RedefinedProperty { get; }
        global::MetaDslx.Modeling.ICollectionSlot<Property> SubsettedProperty { get; }
    
        bool IsAttribute(bool result);
        bool IsCompatibleWith(bool result, ParameterableElement p);
        bool IsConsistentWith(bool result, RedefinableElement redefiningElement);
        bool IsNavigable(bool result);
        global::System.Collections.Generic.IList<Type> SubsettingContext(global::System.Collections.Generic.IList<Type> result);
    }
}
