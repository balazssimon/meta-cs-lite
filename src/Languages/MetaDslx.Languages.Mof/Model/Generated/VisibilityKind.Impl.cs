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

    internal class __VisibilityKind_Info : __ModelEnumInfo
    {
        public static readonly __VisibilityKind_Info Instance = new __VisibilityKind_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __VisibilityKind_Info()
        {
            _literals = __ImmutableArray.Create<string>("Public");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("Public", __MetaSymbol.FromValue(VisibilityKind.Public));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Mof.MInstance;
        public override __MetaType MetaType => typeof(VisibilityKind);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }
}
