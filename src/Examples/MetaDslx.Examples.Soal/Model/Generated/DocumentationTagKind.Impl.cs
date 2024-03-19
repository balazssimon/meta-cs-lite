#nullable enable

namespace MetaDslx.Examples.Soal.Model.__Impl
{
    using __Model = global::MetaDslx.Modeling.Model;
    using __MetaModel = global::MetaDslx.Modeling.MetaModel;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MetaModelObject = global::MetaDslx.Modeling.MetaModelObject;
    using __ModelEnumInfo = global::MetaDslx.Modeling.ModelEnumInfo;
    using __ModelClassInfo = global::MetaDslx.Modeling.ModelClassInfo;
    using __ModelProperty = global::MetaDslx.Modeling.ModelProperty;
    using __ModelPropertyFlags = global::MetaDslx.Modeling.ModelPropertyFlags;
    using __ModelPropertyInfo = global::MetaDslx.Modeling.ModelPropertyInfo;
    using __ModelPropertySlot = global::MetaDslx.Modeling.ModelPropertySlot;
    using __ModelOperation = global::MetaDslx.Modeling.ModelOperation;
    using __ModelOperationInfo = global::MetaDslx.Modeling.ModelOperationInfo;
    using __ImmutableArray = global::System.Collections.Immutable.ImmutableArray;
    using __ImmutableDictionary = global::System.Collections.Immutable.ImmutableDictionary;
    using __MetaType = global::MetaDslx.CodeAnalysis.MetaType;
    using __MetaSymbol = global::MetaDslx.CodeAnalysis.MetaSymbol;
    using __Type = global::System.Type;
    using __Enum = global::System.Enum;

    internal class __DocumentationTagKind_Info : __ModelEnumInfo
    {
        public static readonly __DocumentationTagKind_Info Instance = new __DocumentationTagKind_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __DocumentationTagKind_Info()
        {
            _literals = __ImmutableArray.Create<string>("Unknown", "Version", "Alpha", "Beta", "Deprecated", "Test", "Internal", "Summary", "DefaultValue", "Param", "Returns", "Throws", "Label", "Example", "Remarks");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("Unknown", __MetaSymbol.FromValue(DocumentationTagKind.Unknown));
            literalsByName.Add("Version", __MetaSymbol.FromValue(DocumentationTagKind.Version));
            literalsByName.Add("Alpha", __MetaSymbol.FromValue(DocumentationTagKind.Alpha));
            literalsByName.Add("Beta", __MetaSymbol.FromValue(DocumentationTagKind.Beta));
            literalsByName.Add("Deprecated", __MetaSymbol.FromValue(DocumentationTagKind.Deprecated));
            literalsByName.Add("Test", __MetaSymbol.FromValue(DocumentationTagKind.Test));
            literalsByName.Add("Internal", __MetaSymbol.FromValue(DocumentationTagKind.Internal));
            literalsByName.Add("Summary", __MetaSymbol.FromValue(DocumentationTagKind.Summary));
            literalsByName.Add("DefaultValue", __MetaSymbol.FromValue(DocumentationTagKind.DefaultValue));
            literalsByName.Add("Param", __MetaSymbol.FromValue(DocumentationTagKind.Param));
            literalsByName.Add("Returns", __MetaSymbol.FromValue(DocumentationTagKind.Returns));
            literalsByName.Add("Throws", __MetaSymbol.FromValue(DocumentationTagKind.Throws));
            literalsByName.Add("Label", __MetaSymbol.FromValue(DocumentationTagKind.Label));
            literalsByName.Add("Example", __MetaSymbol.FromValue(DocumentationTagKind.Example));
            literalsByName.Add("Remarks", __MetaSymbol.FromValue(DocumentationTagKind.Remarks));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Soal.MInstance;
        public override __MetaType MetaType => typeof(DocumentationTagKind);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }
}
