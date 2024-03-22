#pragma warning disable CS8669

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

    internal class __BuiltInTypeKind_Info : __ModelEnumInfo
    {
        public static readonly __BuiltInTypeKind_Info Instance = new __BuiltInTypeKind_Info();
    
        private readonly global::System.Collections.Immutable.ImmutableArray<string> _literals;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> _literalsByName;
    
        private __BuiltInTypeKind_Info()
        {
            _literals = __ImmutableArray.Create<string>("Error", "Any", "Void", "Object", "Binary", "Bool", "String", "Int", "Long", "Float", "Double", "Date", "Time", "DateTime", "Duration");
            var literalsByName = __ImmutableDictionary.CreateBuilder<string, __MetaSymbol>();
            literalsByName.Add("Error", __MetaSymbol.FromValue(BuiltInTypeKind.Error));
            literalsByName.Add("Any", __MetaSymbol.FromValue(BuiltInTypeKind.Any));
            literalsByName.Add("Void", __MetaSymbol.FromValue(BuiltInTypeKind.Void));
            literalsByName.Add("Object", __MetaSymbol.FromValue(BuiltInTypeKind.Object));
            literalsByName.Add("Binary", __MetaSymbol.FromValue(BuiltInTypeKind.Binary));
            literalsByName.Add("Bool", __MetaSymbol.FromValue(BuiltInTypeKind.Bool));
            literalsByName.Add("String", __MetaSymbol.FromValue(BuiltInTypeKind.String));
            literalsByName.Add("Int", __MetaSymbol.FromValue(BuiltInTypeKind.Int));
            literalsByName.Add("Long", __MetaSymbol.FromValue(BuiltInTypeKind.Long));
            literalsByName.Add("Float", __MetaSymbol.FromValue(BuiltInTypeKind.Float));
            literalsByName.Add("Double", __MetaSymbol.FromValue(BuiltInTypeKind.Double));
            literalsByName.Add("Date", __MetaSymbol.FromValue(BuiltInTypeKind.Date));
            literalsByName.Add("Time", __MetaSymbol.FromValue(BuiltInTypeKind.Time));
            literalsByName.Add("DateTime", __MetaSymbol.FromValue(BuiltInTypeKind.DateTime));
            literalsByName.Add("Duration", __MetaSymbol.FromValue(BuiltInTypeKind.Duration));
            _literalsByName = literalsByName.ToImmutable();
        }
    
        public override __MetaModel MetaModel => Soal.MInstance;
        public override __MetaType MetaType => typeof(BuiltInTypeKind);
        public override global::System.Collections.Immutable.ImmutableArray<string> Literals => _literals;
        protected override global::System.Collections.Immutable.ImmutableDictionary<string, __MetaSymbol> LiteralsByName => _literalsByName;
    }
}
