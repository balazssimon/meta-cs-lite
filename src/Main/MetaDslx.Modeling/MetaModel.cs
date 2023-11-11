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

        public abstract ImmutableArray<MetaType> MModelObjectTypes { get; }
        public abstract ImmutableArray<ModelObjectInfo> MModelObjectInfos { get; }

        public abstract bool Contains(Type modelObjectType);
        public abstract bool Contains(string modelObjectTypeName);

        public abstract bool TryGetInfo(Type modelObjectType, out ModelObjectInfo? info);
        public abstract bool TryGetInfo(string modelObjectTypeName, out ModelObjectInfo? info);
    }
}
