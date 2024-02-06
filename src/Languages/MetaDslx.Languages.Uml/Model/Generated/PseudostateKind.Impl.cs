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

    internal class __PseudostateKind_Info : __ModelEnumInfo
    {
        public static readonly __PseudostateKind_Info Instance = new __PseudostateKind_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __PseudostateKind_Info()
        {
            _literals = __ImmutableArray.Create<string>("Initial", "DeepHistory", "ShallowHistory", "Join", "Fork", "Junction", "Choice", "EntryPoint", "ExitPoint", "Terminate");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("Initial", __MetaSymbol.FromValue(PseudostateKind.Initial));
            literalsByName.Add("DeepHistory", __MetaSymbol.FromValue(PseudostateKind.DeepHistory));
            literalsByName.Add("ShallowHistory", __MetaSymbol.FromValue(PseudostateKind.ShallowHistory));
            literalsByName.Add("Join", __MetaSymbol.FromValue(PseudostateKind.Join));
            literalsByName.Add("Fork", __MetaSymbol.FromValue(PseudostateKind.Fork));
            literalsByName.Add("Junction", __MetaSymbol.FromValue(PseudostateKind.Junction));
            literalsByName.Add("Choice", __MetaSymbol.FromValue(PseudostateKind.Choice));
            literalsByName.Add("EntryPoint", __MetaSymbol.FromValue(PseudostateKind.EntryPoint));
            literalsByName.Add("ExitPoint", __MetaSymbol.FromValue(PseudostateKind.ExitPoint));
            literalsByName.Add("Terminate", __MetaSymbol.FromValue(PseudostateKind.Terminate));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Uml.MInstance;
        public override __MetaType MetaType => typeof(PseudostateKind);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }
}
