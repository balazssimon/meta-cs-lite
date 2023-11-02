using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using MetaDslx.Modeling.Meta;

namespace MetaDslx.Modeling.Reflection
{
    public sealed class ReflectionMetaModel : MetaModel
    {
        private readonly string _name;
        private readonly string _fullName;
        private readonly ModelVersion _version;
        private readonly string _uri;
        private readonly string _prefix;
        private readonly ImmutableArray<Type> _types;
        private ImmutableArray<ModelObjectInfo> _modelObjectInfos;
        private Dictionary<Type, ModelObjectInfo> _modelObjectInfosByType;
        private Dictionary<string, ModelObjectInfo> _modelObjectInfosByName;

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

        public override ImmutableArray<Type> ModelObjectTypes => _types;

        public override ImmutableArray<ModelObjectInfo> ModelObjectInfos
        {
            get
            {
                ComputeMetaGraph();
                return _modelObjectInfos;
            }
        }

        private Dictionary<Type, ModelObjectInfo> ModelObjectInfosByType
        {
            get
            {
                ComputeMetaGraph();
                return _modelObjectInfosByType;
            }
        }

        private Dictionary<string, ModelObjectInfo> ModelObjectInfosByName
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
            var graph = new ReflectionMetaGraph(_types);
            var metaClasses = graph.Compute();

        }
    }
}
