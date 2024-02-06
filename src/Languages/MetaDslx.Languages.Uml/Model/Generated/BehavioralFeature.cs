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
    /// A BehavioralFeature is a feature of a Classifier that specifies an aspect of the behavior of its instances.  A BehavioralFeature is implemented (realized) by a Behavior. A BehavioralFeature specifies that a Classifier will respond to a designated request by invoking its implementing method.
    /// </summary>
    public interface BehavioralFeature : global::MetaDslx.Languages.Uml.Model.Feature, global::MetaDslx.Languages.Uml.Model.Namespace
    {
        /// <summary>
        /// Specifies the semantics of concurrent calls to the same passive instance (i.e., an instance originating from a Class with isActive being false). Active instances control access to their own BehavioralFeatures.
        /// </summary>
        global::MetaDslx.Languages.Uml.Model.CallConcurrencyKind Concurrency { get; set; }
        /// <summary>
        /// If true, then the BehavioralFeature does not have an implementation, and one must be supplied by a more specific Classifier. If false, the BehavioralFeature must have an implementation in the Classifier or one must be inherited.
        /// </summary>
        bool IsAbstract { get; set; }
        /// <summary>
        /// A Behavior that implements the BehavioralFeature. There may be at most one Behavior for a particular pairing of a Classifier (as owner of the Behavior) and a BehavioralFeature (as specification of the Behavior).
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Behavior> Method { get; }
        /// <summary>
        /// The ordered set of formal Parameters of this BehavioralFeature.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Parameter> OwnedParameter { get; }
        /// <summary>
        /// The ParameterSets owned by this BehavioralFeature.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ParameterSet> OwnedParameterSet { get; }
        /// <summary>
        /// The Types representing exceptions that may be raised during an invocation of this BehavioralFeature.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Type> RaisedException { get; }
    
        /// <summary>
        /// The query isDistinguishableFrom() determines whether two BehavioralFeatures may coexist in the same Namespace. It specifies that they must have different signatures.
        /// </summary>
        /// <param name="n">
        /// </param>
        /// <param name="ns">
        /// </param>
        /// <returns>
        /// </returns>
        bool IsDistinguishableFrom(NamedElement n, Namespace ns);
        /// <summary>
        /// The ownedParameters with direction in and inout.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Parameter> InputParameters();
        /// <summary>
        /// The ownedParameters with direction out, inout, or return.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Parameter> OutputParameters();
    }
}
