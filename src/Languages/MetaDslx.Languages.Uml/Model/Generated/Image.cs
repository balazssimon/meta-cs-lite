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
    /// Physical definition of a graphical image.
    /// </summary>
    public interface Image : global::MetaDslx.Languages.Uml.Model.Element
    {
        /// <summary>
        /// This contains the serialization of the image according to the format. The value could represent a bitmap, image such as a GIF file, or drawing &apos;instructions&apos; using a standard such as Scalable Vector Graphic (SVG) (which is XML based).
        /// </summary>
        string Content { get; set; }
        /// <summary>
        /// This indicates the format of the content, which is how the string content should be interpreted. The following values are reserved: SVG, GIF, PNG, JPG, WMF, EMF, BMP. In addition the prefix &apos;MIME: &apos; is also reserved. This option can be used as an alternative to express the reserved values above, for example &quot;SVG&quot; could instead be expressed as &quot;MIME: image/svg+xml&quot;.
        /// </summary>
        string Format { get; set; }
        /// <summary>
        /// This contains a location that can be used by a tool to locate the image as an alternative to embedding it in the stereotype.
        /// </summary>
        string Location { get; set; }
    
    }
}
