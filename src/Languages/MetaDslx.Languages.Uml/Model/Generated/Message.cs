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
    /// A Message defines a particular communication between Lifelines of an Interaction.
    /// </summary>
    public interface Message : global::MetaDslx.Languages.Uml.Model.NamedElement
    {
        /// <summary>
        /// The arguments of the Message.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ValueSpecification> Argument { get; }
        /// <summary>
        /// The Connector on which this Message is sent.
        /// </summary>
        Connector Connector { get; set; }
        /// <summary>
        /// The enclosing Interaction owning the Message.
        /// </summary>
        Interaction Interaction { get; set; }
        /// <summary>
        /// The derived kind of the Message (complete, lost, found, or unknown).
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.MessageKind MessageKind { get; set; }
        /// <summary>
        /// The sort of communication reflected by the Message.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.MessageSort MessageSort { get; set; }
        /// <summary>
        /// References the Receiving of the Message.
        /// </summary>
        MessageEnd ReceiveEvent { get; set; }
        /// <summary>
        /// References the Sending of the Message.
        /// </summary>
        MessageEnd SendEvent { get; set; }
        /// <summary>
        /// The signature of the Message is the specification of its content. It refers either an Operation or a Signal.
        /// </summary>
        NamedElement Signature { get; set; }
    
        /// <summary>
        /// The query isDistinguishableFrom() specifies that any two Messages may coexist in the same Namespace, regardless of their names.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsDistinguishableFrom(NamedElement n, Namespace ns);
    }
}
