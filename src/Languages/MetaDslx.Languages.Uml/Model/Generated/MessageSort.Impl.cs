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

    internal class __MessageSort_Info : __ModelEnumInfo
    {
        public static readonly __MessageSort_Info Instance = new __MessageSort_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __MessageSort_Info()
        {
            _literals = __ImmutableArray.Create<string>("SynchCall", "AsynchCall", "AsynchSignal", "CreateMessage", "DeleteMessage", "Reply");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("SynchCall", __MetaSymbol.FromValue(MessageSort.SynchCall));
            literalsByName.Add("AsynchCall", __MetaSymbol.FromValue(MessageSort.AsynchCall));
            literalsByName.Add("AsynchSignal", __MetaSymbol.FromValue(MessageSort.AsynchSignal));
            literalsByName.Add("CreateMessage", __MetaSymbol.FromValue(MessageSort.CreateMessage));
            literalsByName.Add("DeleteMessage", __MetaSymbol.FromValue(MessageSort.DeleteMessage));
            literalsByName.Add("Reply", __MetaSymbol.FromValue(MessageSort.Reply));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Uml.MInstance;
        public override __MetaType MetaType => typeof(MessageSort);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }
}