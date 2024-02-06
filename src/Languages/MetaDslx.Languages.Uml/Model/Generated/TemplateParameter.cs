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
    /// A TemplateParameter exposes a ParameterableElement as a formal parameter of a template.
    /// </summary>
    public interface TemplateParameter : global::MetaDslx.Languages.Uml.Model.Element
    {
        /// <summary>
        /// The ParameterableElement that is the default for this formal TemplateParameter.
        /// </summary>
        ParameterableElement Default { get; set; }
        /// <summary>
        /// The ParameterableElement that is owned by this TemplateParameter for the purpose of providing a default.
        /// </summary>
        ParameterableElement OwnedDefault { get; set; }
        /// <summary>
        /// The ParameterableElement that is owned by this TemplateParameter for the purpose of exposing it as the parameteredElement.
        /// </summary>
        ParameterableElement OwnedParameteredElement { get; set; }
        /// <summary>
        /// The ParameterableElement exposed by this TemplateParameter.
        /// </summary>
        ParameterableElement ParameteredElement { get; set; }
        /// <summary>
        /// The TemplateSignature that owns this TemplateParameter.
        /// </summary>
        TemplateSignature Signature { get; set; }
    
    }
}
