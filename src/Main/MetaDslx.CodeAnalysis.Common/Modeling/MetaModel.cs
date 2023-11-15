using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class MetaModel
    {
        public abstract string MName { get; }
        public abstract string MNamespace { get; }
        public string MFullName => $"{MNamespace}.{MName}";
        public abstract ModelVersion MVersion { get; }
        public abstract string MUri { get; }
        public abstract string MPrefix { get; }
        public abstract Model MModel { get; }

        public MultiModelFactory CreateFactory() => new MultiModelFactory(new MetaModel[] { this });
        public ModelFactory CreateFactory(Model model) => new ModelFactory(model, this);
        
        public abstract ImmutableDictionary<MetaType, ModelEnumInfo> MEnumInfosByType { get; }
        public abstract ImmutableDictionary<string, ModelEnumInfo> MEnumInfosByName { get; }
        public abstract ImmutableDictionary<MetaType, ModelClassInfo> MClassInfosByType { get; }
        public abstract ImmutableDictionary<string, ModelClassInfo> MClassInfosByName { get; }
        
        public abstract ImmutableArray<MetaType> MEnumTypes { get; }
        public abstract ImmutableArray<ModelEnumInfo> MEnumInfos { get; }
        public abstract ImmutableArray<MetaType> MClassTypes { get; }
        public abstract ImmutableArray<ModelClassInfo> MClassInfos { get; }

        public bool MContains(MetaType type) => MClassInfosByType.ContainsKey(type) || MEnumInfosByType.ContainsKey(type);
        public bool MContains(string typeName) => MClassInfosByType.ContainsKey(typeName) || MEnumInfosByType.ContainsKey(typeName);
    }
}
