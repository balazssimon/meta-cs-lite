using MetaDslx.CodeAnalysis.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class MetaModel
    {
        public abstract string Name { get; }
        public abstract string FullName { get; }
        public abstract ModelVersion Version { get; }
        public abstract string Uri { get; }
        public abstract string Prefix { get; }

        public MultiModelFactory CreateFactory() => new MultiModelFactory(this);
        public ModelFactory CreateFactory(Model model) => new ModelFactory(model, this);

        public abstract ImmutableArray<Type> ModelObjectTypes { get; }
        public abstract ImmutableArray<ModelObjectInfo> ModelObjectInfos { get; }

        public abstract bool Contains(Type modelObjectType);
        public abstract bool Contains(string modelObjectTypeName);

        public abstract bool TryGetInfo(Type modelObjectType, out ModelObjectInfo info);
        public abstract bool TryGetInfo(string modelObjectTypeName, out ModelObjectInfo info);
    }
}
