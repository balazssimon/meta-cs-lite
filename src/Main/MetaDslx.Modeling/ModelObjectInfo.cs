using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.Modeling
{
    public abstract class ModelObjectInfo
    {
        protected abstract ImmutableDictionary<string, ModelProperty> PublicPropertiesByName { get; }
        protected abstract ImmutableDictionary<ModelProperty, ModelPropertyInfo> ModelPropertyInfos { get; }

        public abstract MetaModel MetaModel { get; }
        public abstract Type MetaType { get; }
        public abstract Type? SymbolType { get; }
        public abstract ModelProperty? NameProperty { get; }
        public abstract ModelProperty? TypeProperty { get; }
        public abstract ImmutableArray<ModelProperty> DeclaredProperties { get; }
        public abstract ImmutableArray<ModelProperty> AllDeclaredProperties { get; }
        public abstract ImmutableArray<ModelProperty> PublicProperties { get; }

        public abstract IModelObject? Create(Model? model = null, string? id = null);

        public ModelProperty? GetProperty(string name)
        {
            if (PublicPropertiesByName.TryGetValue(name, out var prop)) return prop;
            else return null;
        }

        public ModelPropertySlot? GetSlot(ModelProperty property)
        {
            if (ModelPropertyInfos.TryGetValue(property, out var info)) return info.Slot;
            else return null;
        }

        public ModelPropertyInfo? GetPropertyInfo(ModelProperty property)
        {
            if (ModelPropertyInfos.TryGetValue(property, out var info)) return info;
            else return null;
        }

        public ImmutableArray<ModelProperty> GetOppositeProperties(ModelProperty property)
        {
            if (ModelPropertyInfos.TryGetValue(property, out var info)) return info.OppositeProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        public ImmutableArray<ModelProperty> GetSubsettedProperties(ModelProperty property)
        {
            if (ModelPropertyInfos.TryGetValue(property, out var info)) return info.SubsettedProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        public ImmutableArray<ModelProperty> GetSubsettingProperties(ModelProperty property)
        {
            if (ModelPropertyInfos.TryGetValue(property, out var info)) return info.SubsettingProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        public ImmutableArray<ModelProperty> GetRedefinedProperties(ModelProperty property)
        {
            if (ModelPropertyInfos.TryGetValue(property, out var info)) return info.RedefinedProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

        public ImmutableArray<ModelProperty> GetRedefiningProperties(ModelProperty property)
        {
            if (ModelPropertyInfos.TryGetValue(property, out var info)) return info.RedefiningProperties;
            else return ImmutableArray<ModelProperty>.Empty;
        }

    }
}
