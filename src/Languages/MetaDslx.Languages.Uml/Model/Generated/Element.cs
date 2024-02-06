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
    /// An Element is a constituent of a model. As such, it has the capability of owning other Elements.
    /// </summary>
    public interface Element : __IModelObject
    {
        /// <summary>
        /// The Comments owned by this Element.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Comment> OwnedComment { get; }
        /// <summary>
        /// The Elements owned by this Element.
        /// </summary>
        global::MetaDslx.Modeling.ICollectionSlot<Element> OwnedElement { get; }
        /// <summary>
        /// The Element that owns this Element.
        /// </summary>
        Element Owner { get; set; }
    
        /// <summary>
        /// The query allOwnedElements() gives all of the direct and indirect ownedElements of an Element.
        /// </summary>
        /// <returns>
        /// </returns>
        global::System.Collections.Generic.IList<Element> AllOwnedElements();
        /// <summary>
        /// The query mustBeOwned() indicates whether Elements of this type must have an owner. Subclasses of Element that do not require an owner must override this operation.
        /// </summary>
        /// <returns>
        /// </returns>
        bool MustBeOwned();
    }
}
