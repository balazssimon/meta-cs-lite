using MetaDslx.Modeling;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.Modeling
{
    public class MultiModelFactory
    {
        private static readonly ConditionalWeakTable<Type, ModelObjectInfo> infosByType = new ConditionalWeakTable<Type, ModelObjectInfo>();
        private static readonly ConditionalWeakTable<string, ModelObjectInfo> infosByName = new ConditionalWeakTable<string, ModelObjectInfo>();

        private readonly ImmutableArray<MetaModel> _metaModels;

        public MultiModelFactory(IEnumerable<MetaModel> metaModels)
        {
            _metaModels = metaModels.ToImmutableArrayOrEmpty();
        }

        public ImmutableArray<MetaModel> MetaModels => _metaModels;

        public IModelObject? Create(Model model, Type? modelObjectType, string? id = null)
        {
            if (modelObjectType is null) return null;
            var info = infosByType.GetValue(modelObjectType, CreateInfo);
            if (info is not null)
            {
                var mobj = info.Create(id);
                if (mobj is not null) mobj.Model = model;
                return mobj;
            }
            return null;
        }

        public IModelObject? Create(Model model, string? modelObjectTypeName, string? id = null)
        {
            if (modelObjectTypeName is null) return null;
            var info = infosByName.GetValue(modelObjectTypeName, CreateInfo);
            if (info is not null)
            {
                var mobj = info.Create(id);
                if (mobj is not null) mobj.Model = model;
                return mobj;
            }
            return null;
        }

        private ModelObjectInfo? CreateInfo(Type modelObjectType)
        {
            foreach (var metaModel in _metaModels)
            {
                if (metaModel.TryGetInfo(modelObjectType, out var info))
                {
                    return info;
                }
            }
            return null;
        }

        private ModelObjectInfo? CreateInfo(string modelObjectTypeName)
        {
            foreach (var metaModel in _metaModels)
            {
                if (metaModel.TryGetInfo(modelObjectTypeName, out var info))
                {
                    return info;
                }
            }
            return null;
        }
    }
}
