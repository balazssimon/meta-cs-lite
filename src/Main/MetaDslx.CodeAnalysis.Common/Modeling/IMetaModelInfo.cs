using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IMetaModelInfo
    {
        IMetaModel MetaModel { get; }
        ImmutableArray<Type> ModelObjectTypes { get; }
        ImmutableArray<IModelObjectInfo> ModelObjectInfos { get; }

        bool Contains(Type modelObjectType);
        bool Contains(string modelObjectTypeName);

        bool TryGetInfo(Type modelObjectType, out IModelObjectInfo info);
        bool TryGetInfo(string modelObjectTypeName, out IModelObjectInfo info);
    }
}
