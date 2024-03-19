#nullable enable

namespace MetaDslx.Examples.Soal.Model
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

    internal interface ISoal
    {
    }
    
    public sealed class Soal : __MetaModel, ISoal
    {
        // If there is an error at the following line, create a new class called 'CustomSoalImplementation'
        // inheriting from the class 'CustomSoalImplementationBase' and provide the custom implementation
        // for the derived properties and operations defined in the metamodel
        internal static readonly CustomSoalImplementationBase __CustomImpl = new CustomSoalImplementation();
    
        private static readonly Soal _instance;
        public static Soal MInstance => _instance;
    
        private static readonly __ModelProperty _Interface_Name;
        private static readonly __ModelProperty _Interface_Age;
    
        static Soal()
        {
            _Interface_Age = new __ModelProperty(typeof(Interface), "Age", typeof(int), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _Interface_Name = new __ModelProperty(typeof(Interface), "Name", typeof(string), default, __ModelPropertyFlags.None | __ModelPropertyFlags.ValueType | __ModelPropertyFlags.BuiltInType | __ModelPropertyFlags.Single, null);
            _instance = new Soal();
        }
    
        private readonly __Model _model;
    
        private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _enumTypes;
        private readonly global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> _enumInfos;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> _enumInfosByType;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> _enumInfosByName;
    
        private readonly global::System.Collections.Immutable.ImmutableArray<__MetaType> _classTypes;
        private readonly global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> _classInfos;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> _classInfosByType;
        private readonly global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> _classInfosByName;
    
    
        private Soal()
        {
            _enumTypes = __ImmutableArray.Create<__MetaType>();
            _enumInfos = __ImmutableArray.Create<__ModelEnumInfo>();
            var enumInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelEnumInfo>();
            _enumInfosByType = enumInfosByType.ToImmutable();
            var enumInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelEnumInfo>();
            _enumInfosByName = enumInfosByName.ToImmutable();
    
            _classTypes = __ImmutableArray.Create<__MetaType>(typeof(Interface));
            _classInfos = __ImmutableArray.Create<__ModelClassInfo>(InterfaceInfo);
            var classInfosByType = __ImmutableDictionary.CreateBuilder<__MetaType, __ModelClassInfo>();
            classInfosByType.Add(typeof(Interface), InterfaceInfo);
            _classInfosByType = classInfosByType.ToImmutable();
            var classInfosByName = __ImmutableDictionary.CreateBuilder<string, __ModelClassInfo>();
            classInfosByName.Add("Interface", InterfaceInfo);
            _classInfosByName = classInfosByName.ToImmutable();
            _model = new __Model();
            var cf = new SoalModelFactory(_model, this);
            var f = new __MetaModelFactory(_model);
            var obj1 = f.MetaModel();
            var obj2 = f.MetaClass();
            var obj3 = f.MetaProperty();
            var obj4 = f.MetaProperty();
            var obj5 = f.MetaTypeReference();
            var obj6 = f.MetaTypeReference();
            __CustomImpl.Soal(this);
            obj1.Name = "Soal";
            obj2.MChildren.Add(obj3);
            obj2.MChildren.Add(obj4);
            obj2.Properties.Add(obj3);
            obj2.Properties.Add(obj4);
            obj2.Name = "Interface";
            obj3.MChildren.Add(obj5);
            obj3.Type = obj5;
            obj3.Name = "Name";
            obj4.MChildren.Add(obj6);
            obj4.Type = obj6;
            obj4.Name = "Age";
            obj5.Type = typeof(string);
            obj6.Type = typeof(int);
            _model.IsSealed = true;
        }
    
        public override string MName => nameof(Soal);
        public override string MNamespace => "MetaDslx.Examples.Soal.Model";
        public override __ModelVersion MVersion => default;
        public override string MUri => "MetaDslx.Examples.Soal.Model.Soal";
        public override string MPrefix => "s";
        public override __Model MModel => _model;
    
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelEnumInfo> MEnumInfosByType => _enumInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelEnumInfo> MEnumInfosByName => _enumInfosByName;
        public override global::System.Collections.Immutable.ImmutableDictionary<__MetaType, __ModelClassInfo> MClassInfosByType => _classInfosByType;
        public override global::System.Collections.Immutable.ImmutableDictionary<string, __ModelClassInfo> MClassInfosByName => _classInfosByName;
    
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MEnumTypes => _enumTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo> MEnumInfos => _enumInfos;
        public override global::System.Collections.Immutable.ImmutableArray<__MetaType> MClassTypes => _classTypes;
        public override global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo> MClassInfos => _classInfos;
    
    
    
        public static __ModelClassInfo InterfaceInfo => __Impl.Interface_Impl.__Info.Instance;
        public static __ModelProperty Interface_Name => _Interface_Name;
        public static __ModelProperty Interface_Age => _Interface_Age;
    }
}
