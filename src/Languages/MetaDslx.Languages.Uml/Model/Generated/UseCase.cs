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
    /// A UseCase specifies a set of actions performed by its subjects, which yields an observable result that is of value for one or more Actors or other stakeholders of each subject.
    /// </summary>
    public interface UseCase : global::MetaDslx.Languages.Uml.Model.BehavioredClassifier
    {
        /// <summary>
        /// The Extend relationships owned by this UseCase.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Extend> Extend { get; }
        /// <summary>
        /// The ExtensionPoints owned by this UseCase.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<ExtensionPoint> ExtensionPoint { get; }
        /// <summary>
        /// The Include relationships owned by this UseCase.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Include> Include { get; }
        /// <summary>
        /// The subjects to which this UseCase applies. Each subject or its parts realize all the UseCases that apply to it.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Classifier> Subject { get; }
    
        /// <summary>
        /// The query allIncludedUseCases() returns the transitive closure of all UseCases (directly or indirectly) included by this UseCase.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<UseCase> AllIncludedUseCases();
    }
}
