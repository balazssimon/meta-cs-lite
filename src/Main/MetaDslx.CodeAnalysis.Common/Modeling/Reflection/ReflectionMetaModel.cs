using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Modeling.Reflection;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling.Meta;
using Microsoft.CodeAnalysis;

namespace MetaDslx.Modeling.Reflection
{
    public sealed class ReflectionMetaModel : MetaModel
    {
        private readonly object _lockObject = new object();

        private readonly string _name;
        private readonly string _namespace;
        private readonly ModelVersion _version;
        private readonly string _uri;
        private readonly string _prefix;
        private readonly ImmutableArray<Type> _types;
        private readonly ImmutableArray<MetaType> _modelEnumTypes;
        private ImmutableArray<ModelEnumInfo> _modelEnumInfos;
        private ImmutableDictionary<MetaType, ModelEnumInfo> _modelEnumInfosByType;
        private ImmutableDictionary<string, ModelEnumInfo> _modelEnumInfosByName;
        private readonly ImmutableArray<MetaType> _modelClassTypes;
        private ImmutableArray<ModelClassInfo> _modelClassInfos;
        private ImmutableDictionary<MetaType, ModelClassInfo> _modelClassInfosByType;
        private ImmutableDictionary<string, ModelClassInfo> _modelClassInfosByName;

        private ReflectionMetaModel(string name, string namespaceName, ModelVersion version, string uri, string prefix, ImmutableArray<Type> types)
        {
            _name = name;
            _namespace = namespaceName;
            _version = version;
            _uri = uri;
            _prefix = prefix;
            _types = types;
            _modelClassTypes = types.Where(t => t.IsClass).Select(t => MetaType.FromType(t)).ToImmutableArray();
            _modelEnumTypes = types.Where(t => t.IsEnum).Select(t => MetaType.FromType(t)).ToImmutableArray();
            var typeNames = new HashSet<string>();
            foreach (var type in _types)
            {
                if (!typeNames.Add(type.Name))
                {
                    throw new ArgumentException(nameof(types), "Type names must be unique in the meta model.");
                }
            }
        }

        public static MetaModel CreateFromNamespace(Assembly assembly, string namespaceName, string? name = null, string? fullName = null, ModelVersion version = default, string? uri = null, string? prefix = null)
        {
            if (assembly == null) throw new ArgumentNullException(nameof(assembly));
            if (namespaceName == null) throw new ArgumentNullException(nameof(namespaceName));
            var index = namespaceName.LastIndexOf('.');
            if (name is null) name = index >= 0 ? namespaceName.Substring(index + 1) : namespaceName;
            if (fullName is null) fullName = namespaceName;
            if (uri is null) uri = namespaceName;
            if (prefix is null) prefix = string.Concat(name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c)));
            return CreateFromTypes(assembly.GetExportedTypes().Where(t => t.Namespace == namespaceName), name, namespaceName, version, uri, prefix);
        }

        public static MetaModel CreateFromTypes(IEnumerable<Type> types, string? name = null, string? namespaceName = null, ModelVersion version = default, string? uri = null, string? prefix = null)
        {
            if (uri is null) uri = name ?? "http://tempuri.org";
            if (prefix is null) prefix = !string.IsNullOrWhiteSpace(name) ? string.Concat(name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c))) : "tmp";
            return new ReflectionMetaModel(name, namespaceName, version, uri, prefix, types.ToImmutableArray());
        }

        public override string MName => _name;

        public override string MNamespace => _namespace;

        public override ModelVersion MVersion => _version;

        public override string MUri => _uri;

        public override string MPrefix => _prefix;

        public override Model MModel => throw new NotImplementedException();

        public override ImmutableArray<MetaType> MEnumTypes => _modelEnumTypes;

        public override ImmutableArray<ModelEnumInfo> MEnumInfos
        {
            get
            {
                ComputeEnums();
                return _modelEnumInfos;
            }
        }

        public override ImmutableDictionary<MetaType, ModelEnumInfo> MEnumInfosByType
        {
            get
            {
                ComputeEnums();
                return _modelEnumInfosByType;
            }
        }

        public override ImmutableDictionary<string, ModelEnumInfo> MEnumInfosByName
        {
            get
            {
                ComputeEnums();
                return _modelEnumInfosByName;
            }
        }

        public override ImmutableArray<MetaType> MClassTypes => _modelClassTypes;

        public override ImmutableArray<ModelClassInfo> MClassInfos
        {
            get
            {
                ComputeMetaGraph();
                return _modelClassInfos;
            }
        }

        public override ImmutableDictionary<MetaType, ModelClassInfo> MClassInfosByType
        {
            get
            {
                ComputeMetaGraph();
                return _modelClassInfosByType;
            }
        }

        public override ImmutableDictionary<string, ModelClassInfo> MClassInfosByName
        {
            get
            {
                ComputeMetaGraph();
                return _modelClassInfosByName;
            }
        }

        private void ComputeEnums()
        {
            if (!_modelEnumInfos.IsDefault) return;
            var modelEnumInfos = ArrayBuilder<ModelEnumInfo>.GetInstance();
            var modelEnumInfosByName = ImmutableDictionary.CreateBuilder<string, ModelEnumInfo>();
            var modelEnumInfosByType = ImmutableDictionary.CreateBuilder<MetaType, ModelEnumInfo>();
            foreach (var type in _modelEnumTypes)
            {
                var literals = ArrayBuilder<string>.GetInstance();
                var literalsByName = ImmutableDictionary.CreateBuilder<string, MetaSymbol>();
                foreach (Enum lit in Enum.GetValues(type.OriginalType))
                {
                    var name = lit.ToString();
                    literals.Add(name);
                    literalsByName.Add(name, MetaSymbol.FromValue(lit));
                }
                var info = new ReflectionMetaEnumInfo(this, type.OriginalType, literals.ToImmutableAndFree(), literalsByName.ToImmutable());
                modelEnumInfos.Add(info);
                modelEnumInfosByName.Add(type.Name, info);
                modelEnumInfosByType.Add(type.OriginalType, info);
            }
            if (_modelEnumInfos.IsDefault)
            {
                lock (_lockObject)
                {
                    if (_modelEnumInfos.IsDefault)
                    {
                        _modelEnumInfosByName = modelEnumInfosByName.ToImmutable();
                        _modelEnumInfosByType = modelEnumInfosByType.ToImmutable();
                        ImmutableInterlocked.InterlockedInitialize(ref _modelEnumInfos, modelEnumInfos.ToImmutable());
                    }
                }
            }
            modelEnumInfos.Free();
        }

        private void ComputeMetaGraph()
        {
            if (!_modelClassInfos.IsDefault) return;
            var modelClassInfos = ArrayBuilder<ModelClassInfo>.GetInstance();
            var modelClassInfosByName = ImmutableDictionary.CreateBuilder<string, ModelClassInfo>();
            var modelClassInfosByType = ImmutableDictionary.CreateBuilder<MetaType, ModelClassInfo>();
            var rmap = new ReflectionToModelMap();
            var graph = new ReflectionMetaGraph(_types);
            var metaClasses = graph.Compute();
            foreach (var cls in metaClasses)
            {
                var info = new ReflectionMetaClassInfo(this, cls.UnderlyingType, cls.SymbolType, rmap.Map(cls.NameProperty), rmap.Map(cls.TypeProperty),
                    rmap.Map(cls.DeclaredProperties), rmap.Map(cls.AllDeclaredProperties), rmap.Map(cls.PublicProperties), 
                    rmap.Map(cls.PublicPropertiesByName), rmap.Map(cls.ModelPropertyInfos));
                modelClassInfos.Add(info);
                modelClassInfosByName.Add(cls.Name, info);
                modelClassInfosByType.Add(cls.UnderlyingType, info);
            }
            if (_modelClassInfos.IsDefault)
            {
                lock (_lockObject)
                {
                    if (_modelClassInfos.IsDefault)
                    {
                        _modelClassInfosByName = modelClassInfosByName.ToImmutable();
                        _modelClassInfosByType = modelClassInfosByType.ToImmutable();
                        ImmutableInterlocked.InterlockedInitialize(ref _modelClassInfos, modelClassInfos.ToImmutable());
                    }    
                }
            }
            modelClassInfos.Free();
        }

        private class ReflectionToModelMap
        {
            private Dictionary<ReflectionMetaProperty, ModelProperty> _propertyMap = new Dictionary<ReflectionMetaProperty, ModelProperty>();
            private Dictionary<ReflectionMetaPropertyInfo, ModelPropertyInfo> _propertyInfoMap = new Dictionary<ReflectionMetaPropertyInfo, ModelPropertyInfo>();
            private Dictionary<ReflectionMetaPropertySlot, ModelPropertySlot> _propertySlotMap = new Dictionary<ReflectionMetaPropertySlot, ModelPropertySlot>();

            public ModelProperty? Map(MetaProperty<Type, PropertyInfo, MethodInfo>? mprop)
            {
                if (mprop is null) return null;
                var rprop = (ReflectionMetaProperty)mprop;
                if (_propertyMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelProperty(rprop.DeclaringType.UnderlyingType, rprop.Name, rprop.Type, rprop.DefaultValue, rprop.Flags, rprop.SymbolProperty);
                _propertyMap.Add(rprop, prop);
                return prop;
            }

            public ImmutableArray<ModelProperty> Map(ImmutableArray<MetaProperty<Type, PropertyInfo, MethodInfo>> mprops)
            {
                return mprops.Select(mp => Map(mp)).ToImmutableArray();
            }

            public ImmutableDictionary<string, ModelProperty> Map(ImmutableDictionary<string, MetaProperty<Type, PropertyInfo, MethodInfo>> mprops)
            {
                var props = ImmutableDictionary.CreateBuilder<string, ModelProperty>();
                foreach (var name in mprops.Keys)
                {
                    props.Add(name, Map(mprops[name]));
                }
                return props.ToImmutable();
            }

            public ImmutableDictionary<ModelProperty, ModelPropertyInfo> Map(ImmutableDictionary<MetaProperty<Type, PropertyInfo, MethodInfo>, MetaPropertyInfo<Type, PropertyInfo, MethodInfo>> mprops)
            {
                var props = ImmutableDictionary.CreateBuilder<ModelProperty, ModelPropertyInfo>();
                foreach (var mprop in mprops.Keys)
                {
                    props.Add(Map(mprop), Map(mprops[mprop]));
                }
                return props.ToImmutable();
            }

            public ModelPropertyInfo Map(MetaPropertyInfo<Type, PropertyInfo, MethodInfo> mprop)
            {
                var rprop = (ReflectionMetaPropertyInfo)mprop;
                if (_propertyInfoMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelPropertyInfo(Map(rprop.Slot), Map(rprop.OppositeProperties), Map(rprop.SubsettedProperties), Map(rprop.SubsettingProperties),
                    Map(rprop.RedefinedProperties), Map(rprop.RedefiningProperties));
                _propertyInfoMap.Add(rprop, prop);
                return prop;
            }

            public ModelPropertySlot Map(MetaPropertySlot<Type, PropertyInfo, MethodInfo> mprop)
            {
                var rprop = (ReflectionMetaPropertySlot)mprop;
                if (_propertySlotMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelPropertySlot(Map(rprop.SlotProperty), Map(rprop.SlotProperties), rprop.DefaultValue, rprop.Flags);
                _propertySlotMap.Add(rprop, prop);
                return prop;
            }
        }
    }
}
