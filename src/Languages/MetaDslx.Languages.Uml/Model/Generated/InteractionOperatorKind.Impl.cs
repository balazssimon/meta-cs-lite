#nullable enable

namespace MetaDslx.Languages.Uml.Model.__Impl
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

    internal class __InteractionOperatorKind_Info : __ModelEnumInfo
    {
        public static readonly __InteractionOperatorKind_Info Instance = new __InteractionOperatorKind_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __InteractionOperatorKind_Info()
        {
            _literals = __ImmutableArray.Create<string>("Seq", "Alt", "Opt", "Break", "Par", "Strict", "Loop", "Critical", "Neg", "Assert", "Ignore", "Consider");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("Seq", __MetaSymbol.FromValue(InteractionOperatorKind.Seq));
            literalsByName.Add("Alt", __MetaSymbol.FromValue(InteractionOperatorKind.Alt));
            literalsByName.Add("Opt", __MetaSymbol.FromValue(InteractionOperatorKind.Opt));
            literalsByName.Add("Break", __MetaSymbol.FromValue(InteractionOperatorKind.Break));
            literalsByName.Add("Par", __MetaSymbol.FromValue(InteractionOperatorKind.Par));
            literalsByName.Add("Strict", __MetaSymbol.FromValue(InteractionOperatorKind.Strict));
            literalsByName.Add("Loop", __MetaSymbol.FromValue(InteractionOperatorKind.Loop));
            literalsByName.Add("Critical", __MetaSymbol.FromValue(InteractionOperatorKind.Critical));
            literalsByName.Add("Neg", __MetaSymbol.FromValue(InteractionOperatorKind.Neg));
            literalsByName.Add("Assert", __MetaSymbol.FromValue(InteractionOperatorKind.Assert));
            literalsByName.Add("Ignore", __MetaSymbol.FromValue(InteractionOperatorKind.Ignore));
            literalsByName.Add("Consider", __MetaSymbol.FromValue(InteractionOperatorKind.Consider));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Uml.MInstance;
        public override __MetaType MetaType => typeof(InteractionOperatorKind);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }
}
