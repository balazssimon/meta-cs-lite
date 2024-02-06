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
    /// MessageEnd is an abstract specialization of NamedElement that represents what can occur at the end of a Message.
    /// </summary>
    public interface MessageEnd : global::MetaDslx.Languages.Uml.Model.NamedElement
    {
        /// <summary>
        /// References a Message.
        /// </summary>
        Message Message { get; set; }
    
        /// <summary>
        /// This query returns a set including the MessageEnd (if exists) at the opposite end of the Message for this MessageEnd.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<MessageEnd> OppositeEnd();
        /// <summary>
        /// This query returns value true if this MessageEnd is a sendEvent.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsSend();
        /// <summary>
        /// This query returns value true if this MessageEnd is a receiveEvent.
        /// </summary>
        /// <returns>
        /// </returns>
        /// <para>
        /// &lt;p&gt;message-&amp;gt;notEmpty()&lt;/p&gt;
        /// </para>
        bool IsReceive();
        /// <summary>
        /// This query returns a set including the enclosing InteractionFragment this MessageEnd is enclosed within.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<InteractionFragment> EnclosingFragment();
    }
}
