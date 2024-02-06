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
    /// A Gate is a MessageEnd which serves as a connection point for relating a Message which has a MessageEnd (sendEvent / receiveEvent) outside an InteractionFragment with another Message which has a MessageEnd (receiveEvent / sendEvent)  inside that InteractionFragment.
    /// </summary>
    public interface Gate : global::MetaDslx.Languages.Uml.Model.MessageEnd
    {
        /// <summary>
        /// The CombinedFragment to which the Gate is attached to.
        /// </summary>
        CombinedFragment CombinedFragment { get; set; }
        /// <summary>
        /// The Interaction that owns the Gate.
        /// </summary>
        Interaction Interaction { get; set; }
        /// <summary>
        /// The InteractionUse of which the Gate is an actual gate.
        /// </summary>
        InteractionUse InteractionUse { get; set; }
    
        /// <summary>
        /// This query returns true if this Gate is attached to the boundary of a CombinedFragment, and its other end (if present)  is outside of the same CombinedFragment.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsOutsideCF();
        /// <summary>
        /// This query returns true if this Gate is attached to the boundary of a CombinedFragment, and its other end (if present) is inside of an InteractionOperator of the same CombinedFragment.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsInsideCF();
        /// <summary>
        /// This query returns true value if this Gate is an actualGate of an InteractionUse.
        /// </summary>
        /// <returns>
        /// </returns>
        bool IsActual();
        /// <summary>
        /// This query returns true if this Gate is a formalGate of an Interaction.
        /// </summary>
        /// <returns>
        /// </returns>
        /// <para>
        /// &lt;p&gt;interaction-&amp;gt;notEmpty()&lt;/p&gt;
        /// </para>
        bool IsFormal();
        /// <summary>
        /// This query returns the name of the gate, either the explicit name (.name) or the constructed name (&apos;out_&quot; or &apos;in_&apos; concatenated in front of .message.name) if the explicit name is not present.
        /// </summary>
        /// <returns>
        /// </returns>
        string GetName();
        /// <summary>
        /// This query returns true if the name of this Gate matches the name of the in parameter Gate, and the messages for the two Gates correspond. The Message for one Gate (say A) corresponds to the Message for another Gate (say B) if (A and B have the same name value) and (if A is a sendEvent then B is a receiveEvent) and (if A is a receiveEvent then B is a sendEvent) and (A and B have the same messageSort value) and (A and B have the same signature value).
        /// </summary>
        /// <param name="gateToMatch">
        /// </param>
        /// <returns>
        /// </returns>
        bool Matches(Gate gateToMatch);
        /// <summary>
        /// The query isDistinguishableFrom() specifies that two Gates may coexist in the same Namespace, without an explicit name property. The association end formalGate subsets ownedElement, and since the Gate name attribute
        /// is optional, it is allowed to have two formal gates without an explicit name, but having derived names which are distinct.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsDistinguishableFrom(NamedElement n, Namespace ns);
        /// <summary>
        /// If the Gate is an inside Combined Fragment Gate, this operation returns the InteractionOperand that the opposite end of this Gate is included within.
        /// </summary>
        /// <returns>
        /// </returns>
        InteractionOperand GetOperand();
    }
}
