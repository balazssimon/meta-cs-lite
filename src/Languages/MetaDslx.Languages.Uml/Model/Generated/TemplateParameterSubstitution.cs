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
    /// A TemplateParameterSubstitution relates the actual parameter to a formal TemplateParameter as part of a template binding.
    /// </summary>
    public interface TemplateParameterSubstitution : global::MetaDslx.Languages.Uml.Model.Element
    {
        /// <summary>
        /// The ParameterableElement that is the actual parameter for this TemplateParameterSubstitution.
        /// </summary>
        ParameterableElement Actual { get; set; }
        /// <summary>
        /// The formal TemplateParameter that is associated with this TemplateParameterSubstitution.
        /// </summary>
        TemplateParameter Formal { get; set; }
        /// <summary>
        /// The ParameterableElement that is owned by this TemplateParameterSubstitution as its actual parameter.
        /// </summary>
        ParameterableElement OwnedActual { get; set; }
        /// <summary>
        /// The TemplateBinding that owns this TemplateParameterSubstitution.
        /// </summary>
        TemplateBinding TemplateBinding { get; set; }
    
    }
}
