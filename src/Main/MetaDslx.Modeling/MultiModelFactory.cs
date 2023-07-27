using MetaDslx.Modeling;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;
using System.Text;

namespace MetaDslx.CodeAnalysis.Modeling
{
    public class MultiModelFactory : IMultiModelFactory
    {
        private readonly ImmutableArray<IMetaModel> _metaModels;
        private readonly ConditionalWeakTable<Type, IMultiModelFactory> factoriesByType = new ConditionalWeakTable<Type, IMultiModelFactory>();
        private readonly ConditionalWeakTable<string, IMultiModelFactory> factoriesByName = new ConditionalWeakTable<string, IMultiModelFactory>();

        public MultiModelFactory(IEnumerable<IMetaModel> metaModels)
        {
            _metaModels = metaModels.ToImmutableArrayOrEmpty();
        }

        public ImmutableArray<IMetaModel> MetaModels => _metaModels;

        public IModelObject? Create(IModel model, Type? modelObjectType, string? id = null)
        {
            if (modelObjectType is null) return null;
            if (factoriesByType.TryGetValue(modelObjectType, out var factory))
            {
                return factory.Create(model, modelObjectType, id);
            }
            else
            {
                foreach (var metaModel in _metaModels)
                {
                    if (metaModel.Info.Contains(modelObjectType))
                    {
                        var newFactory = metaModel.CreateFactory();
                        factoriesByType.Add(modelObjectType, newFactory);
                        return newFactory.Create(model, modelObjectType, id);
                    }
                }
            }
            return null;
        }

        public IModelObject? Create(IModel model, string? modelObjectTypeName, string? id = null)
        {
            if (modelObjectTypeName is null) return null;
            if (factoriesByName.TryGetValue(modelObjectTypeName, out var factory))
            {
                return factory.Create(model, modelObjectTypeName, id);
            }
            else
            {
                foreach (var metaModel in _metaModels)
                {
                    if (metaModel.Info.Contains(modelObjectTypeName))
                    {
                        var newFactory = metaModel.CreateFactory();
                        factoriesByName.Add(modelObjectTypeName, newFactory);
                        return newFactory.Create(model, modelObjectTypeName, id);
                    }
                }
            }
            return null;
        }

    }
}
