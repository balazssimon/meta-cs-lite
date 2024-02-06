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
    /// LinkEndData is an Element that identifies on end of a link to be read or written by a LinkAction. As a link (that is not a link object) cannot be passed as a runtime value to or from an Action, it is instead identified by its end objects and qualifier values, if any. A LinkEndData instance provides these values for a single Association end.
    /// </summary>
    public interface LinkEndData : global::MetaDslx.Languages.Uml.Model.Element
    {
        /// <summary>
        /// The Association end for which this LinkEndData specifies values.
        /// </summary>
        Property End { get; set; }
        /// <summary>
        /// A set of QualifierValues used to provide values for the qualifiers of the end.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<QualifierValue> Qualifier { get; }
        /// <summary>
        /// The InputPin that provides the specified value for the given end. This InputPin is omitted if the LinkEndData specifies the &quot;open&quot; end for a ReadLinkAction.
        /// </summary>
        InputPin Value { get; set; }
    
        /// <summary>
        /// Returns all the InputPins referenced by this LinkEndData. By default this includes the value and qualifier InputPins, but subclasses may override the operation to add other InputPins.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<InputPin> AllPins();
    }
}
