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

    /// <summary>
    /// A Parameter is a specification of an argument used to pass information into or out of an invocation of a BehavioralFeature.  Parameters can be treated as ConnectableElements within Collaborations.
    /// </summary>
    public interface Parameter : global::MetaDslx.Languages.Uml.Model.MultiplicityElement, global::MetaDslx.Languages.Uml.Model.ConnectableElement
    {
        /// <summary>
        /// A String that represents a value to be used when no argument is supplied for the Parameter.
        /// </summary>
        string Default { get; }
        /// <summary>
        /// Specifies a ValueSpecification that represents a value to be used when no argument is supplied for the Parameter.
        /// </summary>
        ValueSpecification DefaultValue { get; set; }
        /// <summary>
        /// Indicates whether a parameter is being sent into or out of a behavioral element.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.ParameterDirectionKind Direction { get; set; }
        /// <summary>
        /// Specifies the effect that executions of the owner of the Parameter have on objects passed in or out of the parameter.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.ParameterEffectKind Effect { get; set; }
        /// <summary>
        /// Tells whether an output parameter may emit a value to the exclusion of the other outputs.
        /// </summary>
        bool IsException { get; set; }
        /// <summary>
        /// Tells whether an input parameter may accept values while its behavior is executing, or whether an output parameter may post values while the behavior is executing.
        /// </summary>
        bool IsStream { get; set; }
        /// <summary>
        /// The Operation owning this parameter.
        /// </summary>
        Operation Operation { get; set; }
        /// <summary>
        /// The ParameterSets containing the parameter. See ParameterSet.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ParameterSet> ParameterSet { get; }
    
    }
}
