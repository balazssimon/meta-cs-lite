#nullable enable

namespace MetaDslx.Languages.Mof.Model.__Impl
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

    internal class __AggregationKind_Info : __ModelEnumInfo
    {
        public static readonly __AggregationKind_Info Instance = new __AggregationKind_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __AggregationKind_Info()
        {
            _literals = __ImmutableArray.Create<string>("None", "Shared", "Composite");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("None", __MetaSymbol.FromValue(AggregationKind.None));
            literalsByName.Add("Shared", __MetaSymbol.FromValue(AggregationKind.Shared));
            literalsByName.Add("Composite", __MetaSymbol.FromValue(AggregationKind.Composite));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Mof.MInstance;
        public override __MetaType MetaType => typeof(AggregationKind);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }
}
