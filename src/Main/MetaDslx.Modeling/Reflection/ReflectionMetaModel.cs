﻿using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Xml.Linq;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling.Meta;
using Microsoft.CodeAnalysis;

namespace MetaDslx.Modeling.Reflection
{
    public sealed class ReflectionMetaModel : MetaModel
    {
        private readonly object _lockObject = new object();

        private readonly string _name;
        private readonly string _fullName;
        private readonly ModelVersion _version;
        private readonly string _uri;
        private readonly string _prefix;
        private readonly ImmutableArray<Type> _types;
        private ImmutableArray<ModelObjectInfo> _modelObjectInfos;
        private ImmutableDictionary<Type, ModelObjectInfo> _modelObjectInfosByType;
        private ImmutableDictionary<string, ModelObjectInfo> _modelObjectInfosByName;

        private ReflectionMetaModel(string name, string fullName, ModelVersion version, string uri, string prefix, ImmutableArray<Type> types)
        {
            _name = name;
            _fullName = fullName;
            _version = version;
            _uri = uri;
            _prefix = prefix;
            _types = types;
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
            return CreateFromTypes(assembly.GetExportedTypes().Where(t => t.Namespace == namespaceName), name, fullName, version, uri, prefix);
        }

        public static MetaModel CreateFromTypes(IEnumerable<Type> types, string? name = null, string? fullName = null, ModelVersion version = default, string? uri = null, string? prefix = null)
        {
            if (fullName is null) fullName = name;
            if (uri is null) uri = name ?? "http://tempuri.org";
            if (prefix is null) prefix = !string.IsNullOrWhiteSpace(name) ? string.Concat(name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c))) : "tmp";
            return new ReflectionMetaModel(name, fullName, version, uri, prefix, types.ToImmutableArray());
        }

        public override string Name => _name;

        public override string FullName => _fullName;

        public override ModelVersion Version => _version;

        public override string Uri => _uri;

        public override string Prefix => _prefix;

        public override Model Model => throw new NotImplementedException();

        public override ImmutableArray<Type> ModelObjectTypes => _types;

        public override ImmutableArray<ModelObjectInfo> ModelObjectInfos
        {
            get
            {
                ComputeMetaGraph();
                return _modelObjectInfos;
            }
        }

        private ImmutableDictionary<Type, ModelObjectInfo> ModelObjectInfosByType
        {
            get
            {
                ComputeMetaGraph();
                return _modelObjectInfosByType;
            }
        }

        private ImmutableDictionary<string, ModelObjectInfo> ModelObjectInfosByName
        {
            get
            {
                ComputeMetaGraph();
                return _modelObjectInfosByName;
            }
        }

        public override bool Contains(Type modelObjectType)
        {
            return ModelObjectInfosByType.ContainsKey(modelObjectType);
        }

        public override bool Contains(string modelObjectTypeName)
        {
            return ModelObjectInfosByName.ContainsKey(modelObjectTypeName);
        }

        public override bool TryGetInfo(Type modelObjectType, out ModelObjectInfo info)
        {
            return ModelObjectInfosByType.TryGetValue(modelObjectType, out info);
        }

        public override bool TryGetInfo(string modelObjectTypeName, out ModelObjectInfo info)
        {
            return ModelObjectInfosByName.TryGetValue(modelObjectTypeName, out info);
        }

        private void ComputeMetaGraph()
        {
            if (!_modelObjectInfos.IsDefault) return;
            var modelObjectInfos = ArrayBuilder<ModelObjectInfo>.GetInstance();
            var modelObjectInfosByName = ImmutableDictionary.CreateBuilder<string, ModelObjectInfo>();
            var modelObjectInfosByType = ImmutableDictionary.CreateBuilder<Type, ModelObjectInfo>();
            var rmap = new ReflectionToModelMap();
            var graph = new ReflectionMetaGraph(_types);
            var metaClasses = graph.Compute();
            foreach (var cls in metaClasses)
            {
                var info = new ReflectionModelObjectInfo(this, cls.UnderlyingType, cls.SymbolType, rmap.Map(cls.NameProperty), rmap.Map(cls.TypeProperty),
                    rmap.Map(cls.DeclaredProperties), rmap.Map(cls.AllDeclaredProperties), rmap.Map(cls.PublicProperties), 
                    rmap.Map(cls.PublicPropertiesByName), rmap.Map(cls.ModelPropertyInfos));
                modelObjectInfos.Add(info);
                modelObjectInfosByName.Add(cls.Name, info);
                modelObjectInfosByType.Add(cls.UnderlyingType, info);
            }
            if (_modelObjectInfos.IsDefault)
            {
                lock (_lockObject)
                {
                    if (_modelObjectInfos.IsDefault)
                    {
                        _modelObjectInfosByName = modelObjectInfosByName.ToImmutable();
                        _modelObjectInfosByType = modelObjectInfosByType.ToImmutable();
                        ImmutableInterlocked.InterlockedInitialize(ref _modelObjectInfos, modelObjectInfos.ToImmutable());
                    }    
                }
            }
            modelObjectInfos.Free();
        }

        private class ReflectionToModelMap
        {
            private Dictionary<ReflectionMetaProperty, ModelProperty> _propertyMap = new Dictionary<ReflectionMetaProperty, ModelProperty>();
            private Dictionary<ReflectionMetaPropertyInfo, ModelPropertyInfo> _propertyInfoMap = new Dictionary<ReflectionMetaPropertyInfo, ModelPropertyInfo>();
            private Dictionary<ReflectionMetaPropertySlot, ModelPropertySlot> _propertySlotMap = new Dictionary<ReflectionMetaPropertySlot, ModelPropertySlot>();

            public ModelProperty? Map(MetaProperty<Type, PropertyInfo>? mprop)
            {
                if (mprop is null) return null;
                var rprop = (ReflectionMetaProperty)mprop;
                if (_propertyMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelProperty(rprop.DeclaringType.UnderlyingType, rprop.Name, rprop.Type, rprop.DefaultValue, rprop.Flags, rprop.SymbolProperty);
                _propertyMap.Add(rprop, prop);
                return prop;
            }

            public ImmutableArray<ModelProperty> Map(ImmutableArray<MetaProperty<Type, PropertyInfo>> mprops)
            {
                return mprops.Select(mp => Map(mp)).ToImmutableArray();
            }

            public ImmutableDictionary<string, ModelProperty> Map(ImmutableDictionary<string, MetaProperty<Type, PropertyInfo>> mprops)
            {
                var props = ImmutableDictionary.CreateBuilder<string, ModelProperty>();
                foreach (var name in mprops.Keys)
                {
                    props.Add(name, Map(mprops[name]));
                }
                return props.ToImmutable();
            }

            public ImmutableDictionary<ModelProperty, ModelPropertyInfo> Map(ImmutableDictionary<MetaProperty<Type, PropertyInfo>, MetaPropertyInfo<Type, PropertyInfo>> mprops)
            {
                var props = ImmutableDictionary.CreateBuilder<ModelProperty, ModelPropertyInfo>();
                foreach (var mprop in mprops.Keys)
                {
                    props.Add(Map(mprop), Map(mprops[mprop]));
                }
                return props.ToImmutable();
            }

            public ModelPropertyInfo Map(MetaPropertyInfo<Type, PropertyInfo> mprop)
            {
                var rprop = (ReflectionMetaPropertyInfo)mprop;
                if (_propertyInfoMap.TryGetValue(rprop, out var prop)) return prop;
                prop = new ModelPropertyInfo(Map(rprop.Slot), Map(rprop.OppositeProperties), Map(rprop.SubsettedProperties), Map(rprop.SubsettingProperties),
                    Map(rprop.RedefinedProperties), Map(rprop.RedefiningProperties));
                _propertyInfoMap.Add(rprop, prop);
                return prop;
            }

            public ModelPropertySlot Map(MetaPropertySlot<Type, PropertyInfo> mprop)
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