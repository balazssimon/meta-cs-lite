using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using MetaDslx.Modeling.Reflection;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.MetaModelImport
{
    internal class ImportedMetaModel : MetaModel
    {
        private readonly object _lockObject = new object();

        private readonly NamespaceSymbol _container;
        private readonly string _name;
        private readonly string _namespace;
        private readonly string _prefix;
        private readonly bool _isSymbolModel;
        private ImmutableArray<MetaType> _enumTypes;
        private ImmutableArray<MetaType> _classTypes;
        private ImmutableArray<ModelEnumInfo> _enumInfos;
        private ImmutableDictionary<MetaType, ModelEnumInfo> _enumInfosByType;
        private ImmutableDictionary<string, ModelEnumInfo> _enumInfosByName;
        private ImmutableArray<ModelClassInfo> _classInfos;
        private ImmutableDictionary<MetaType, ModelClassInfo> _classInfosByType;
        private ImmutableDictionary<string, ModelClassInfo> _classInfosByName;

        public ImportedMetaModel(NamespaceSymbol container, string name, bool isSymbolModel)
        {
            if (container is null) throw new ArgumentNullException(nameof(container));
            if (name is null) throw new ArgumentNullException(nameof(name));
            _container = container;
            _name = name;
            _namespace = SymbolDisplayFormat.QualifiedNameOnlyFormat.ToString(container);
            _prefix = string.Concat(name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c)));
            _isSymbolModel = isSymbolModel;
        }

        public override string MName => _name;

        public override string MNamespace => _namespace;

        public override ModelVersion MVersion => default;

        public override string MUri => _namespace;

        public override string MPrefix => _prefix;

        public bool IsSymbolModel => _isSymbolModel;

        public override MetaDslx.Modeling.Model MModel => throw new NotSupportedException();

        public override ImmutableDictionary<MetaType, ModelEnumInfo> MEnumInfosByType
        {
            get
            {
                ComputeEnumInfos();
                return _enumInfosByType;
            }
        }

        public override ImmutableDictionary<string, ModelEnumInfo> MEnumInfosByName
        {
            get
            {
                ComputeEnumInfos();
                return _enumInfosByName;
            }
        }

        public override ImmutableDictionary<MetaType, ModelClassInfo> MClassInfosByType => throw new NotImplementedException();

        public override ImmutableDictionary<string, ModelClassInfo> MClassInfosByName => throw new NotImplementedException();

        public override ImmutableArray<MetaType> MEnumTypes
        {
            get
            {
                ComputeTypes();
                return _enumTypes;
            }
        }

        public override ImmutableArray<ModelEnumInfo> MEnumInfos
        {
            get
            {
                ComputeEnumInfos();
                return _enumInfos;
            }
        }

        public override ImmutableArray<MetaType> MClassTypes
        {
            get
            {
                ComputeTypes();
                return _classTypes;
            }
        }

        public override ImmutableArray<ModelClassInfo> MClassInfos => throw new NotImplementedException();

        private void ComputeTypes()
        {
            if (!_enumTypes.IsDefault) return;
            var enumTypes = ArrayBuilder<MetaType>.GetInstance();
            var classTypes = ArrayBuilder<MetaType>.GetInstance();
            ImportedMetaUtils.CollectTypes(_container, collectSymbols: _isSymbolModel);
            ImmutableInterlocked.InterlockedInitialize(ref _classTypes, classTypes.ToImmutableAndFree());
            ImmutableInterlocked.InterlockedInitialize(ref _enumTypes, enumTypes.ToImmutableAndFree());
        }

        private void ComputeEnumInfos()
        {
            if (!_enumInfos.IsDefault) return;
            var enumInfos = ArrayBuilder<ModelEnumInfo>.GetInstance();
            var enumInfosByType = ImmutableDictionary.CreateBuilder<MetaType, ModelEnumInfo>();
            var enumInfosByName = ImmutableDictionary.CreateBuilder<string, ModelEnumInfo>();
            foreach (var type in MEnumTypes)
            {
                var info = new ImportedMetaEnumInfo(this, (CSharpTypeSymbol)type.OriginalTypeSymbol);
                if (!enumInfosByName.ContainsKey(type.Name))
                {
                    enumInfosByName.Add(type.Name, info);
                    enumInfos.Add(info);
                    enumInfosByType.Add(type, info);
                }
            }
            if (_enumInfos.IsDefault)
            {
                lock (_lockObject)
                {
                    if (_enumInfos.IsDefault)
                    {
                        _enumInfosByType = enumInfosByType.ToImmutable();
                        _enumInfosByName = enumInfosByName.ToImmutable();
                        ImmutableInterlocked.InterlockedInitialize(ref _enumInfos, enumInfos.ToImmutableAndFree());
                    }
                }
            }
        }
        /*
        private void ComputeMetaGraph()
        {
            if (!_classInfos.IsDefault) return;
            var classInfos = ArrayBuilder<ModelClassInfo>.GetInstance();
            var classInfosByName = ImmutableDictionary.CreateBuilder<string, ModelClassInfo>();
            var classInfosByType = ImmutableDictionary.CreateBuilder<MetaType, ModelClassInfo>();
            var rmap = new ModelMap();
            var graph = new ImportedMetaGraph(this, MClassTypes, null);
            var metaClasses = graph.Compute();
            foreach (var cls in metaClasses)
            {
                var info = new ImportedMetaClassInfo(this, cls.UnderlyingType, cls.SymbolType, rmap.Map(cls.NameProperty), rmap.Map(cls.TypeProperty),
                    rmap.Map(cls.DeclaredProperties), rmap.Map(cls.AllDeclaredProperties), rmap.Map(cls.PublicProperties),
                    rmap.Map(cls.PublicPropertiesByName), rmap.Map(cls.ModelPropertyInfos));
                classInfos.Add(info);
                classInfosByName.Add(cls.Name, info);
                classInfosByType.Add(cls.UnderlyingType, info);
            }
            if (_classInfos.IsDefault)
            {
                lock (_lockObject)
                {
                    if (_classInfos.IsDefault)
                    {
                        _classInfosByName = classInfosByName.ToImmutable();
                        _classInfosByType = classInfosByType.ToImmutable();
                        ImmutableInterlocked.InterlockedInitialize(ref _classInfos, classInfos.ToImmutable());
                    }
                }
            }
            classInfos.Free();
        }

        private class ModelMap
        {
            private Dictionary<ImportedMetaProperty, ModelProperty> _propertyMap = new Dictionary<ImportedMetaProperty, ModelProperty>();
            private Dictionary<ImportedMetaPropertyInfo, ModelPropertyInfo> _propertyInfoMap = new Dictionary<ImportedMetaPropertyInfo, ModelPropertyInfo>();
            private Dictionary<ImportedMetaPropertySlot, ModelPropertySlot> _propertySlotMap = new Dictionary<ImportedMetaPropertySlot, ModelPropertySlot>();

            public ModelProperty? Map(MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>? mprop)
            {
                if (mprop is null) return null;
                var rprop = (ImportedMetaProperty)mprop;
                if (_propertyMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelProperty(rprop.DeclaringType.UnderlyingType, rprop.Name, rprop.Type, rprop.DefaultValue, rprop.Flags, rprop.SymbolProperty);
                _propertyMap.Add(rprop, prop);
                return prop;
            }

            public ImmutableArray<ModelProperty> Map(ImmutableArray<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> mprops)
            {
                return mprops.Select(mp => Map(mp)).ToImmutableArray();
            }

            public ImmutableDictionary<string, ModelProperty> Map(ImmutableDictionary<string, MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> mprops)
            {
                var props = ImmutableDictionary.CreateBuilder<string, ModelProperty>();
                foreach (var name in mprops.Keys)
                {
                    props.Add(name, Map(mprops[name]));
                }
                return props.ToImmutable();
            }

            public ImmutableDictionary<ModelProperty, ModelPropertyInfo> Map(ImmutableDictionary<MetaProperty<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>, MetaPropertyInfo<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>> mprops)
            {
                var props = ImmutableDictionary.CreateBuilder<ModelProperty, ModelPropertyInfo>();
                foreach (var mprop in mprops.Keys)
                {
                    props.Add(Map(mprop), Map(mprops[mprop]));
                }
                return props.ToImmutable();
            }

            public ModelPropertyInfo Map(MetaPropertyInfo<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> mprop)
            {
                var rprop = (ImportedMetaPropertyInfo)mprop;
                if (_propertyInfoMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelPropertyInfo(Map(rprop.Slot), Map(rprop.OppositeProperties), Map(rprop.SubsettedProperties), Map(rprop.SubsettingProperties),
                    Map(rprop.RedefinedProperties), Map(rprop.RedefiningProperties));
                _propertyInfoMap.Add(rprop, prop);
                return prop;
            }

            public ModelPropertySlot Map(MetaPropertySlot<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol> mprop)
            {
                var rprop = (ImportedMetaPropertySlot)mprop;
                if (_propertySlotMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelPropertySlot(Map(rprop.SlotProperty), Map(rprop.SlotProperties), rprop.DefaultValue, rprop.Flags);
                _propertySlotMap.Add(rprop, prop);
                return prop;
            }
        }
        */
    }
}
