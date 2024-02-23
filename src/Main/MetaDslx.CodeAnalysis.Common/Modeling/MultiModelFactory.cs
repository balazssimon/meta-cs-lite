using MetaDslx.CodeAnalysis;
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
        private static readonly ConditionalWeakTable<Type, ModelClassInfo> infosByType = new ConditionalWeakTable<Type, ModelClassInfo>();
        private static readonly ConditionalWeakTable<string, ModelClassInfo> infosByName = new ConditionalWeakTable<string, ModelClassInfo>();

        private readonly ImmutableArray<MetaModel> _metaModels;

        public MultiModelFactory(IEnumerable<MetaModel> metaModels)
        {
            _metaModels = metaModels.ToImmutableArrayOrEmpty();
        }

        public ImmutableArray<MetaModel> MetaModels => _metaModels;

        public IModelObject? Create(Model model, Type? modelObjectType, string? id = null)
        {
            if (modelObjectType is null) return null;
            var info = infosByType.GetValue(modelObjectType, GetInfo);
            return info?.Create(model, id);
        }

        public IModelObject? Create(Model model, string? modelObjectTypeName, string? id = null)
        {
            if (modelObjectTypeName is null) return null;
            var info = infosByName.GetValue(modelObjectTypeName, GetInfo);
            return info?.Create(model, id);
        }

        public ModelClassInfo? GetInfo(Type modelObjectType)
        {
            foreach (var metaModel in _metaModels)
            {
                if (metaModel.MClassInfosByType.TryGetValue(modelObjectType, out var info))
                {
                    return info;
                }
            }
            return null;
        }

        public ModelClassInfo? GetInfo(string modelObjectTypeName)
        {
            foreach (var metaModel in _metaModels)
            {
                if (metaModel.MClassInfosByName.TryGetValue(modelObjectTypeName, out var info))
                {
                    return info;
                }
            }
            return null;
        }
    }
}
