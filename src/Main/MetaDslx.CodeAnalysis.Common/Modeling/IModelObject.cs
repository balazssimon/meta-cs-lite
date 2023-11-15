﻿using MetaDslx.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.Modeling
{
    public interface IModelObject : IModelObjectCore
    {
        string Id { get; set; }
        MetaModel MetaModel { get; }
        MetaType MetaType { get; }
        ModelClassInfo Info { get; }
        Model? Model { get; set; }
        string? Name { get; set; }
        IModelObject? Parent { get; set; }
        IList<IModelObject> Children { get; }
        object? UnderlyingObject { get; }
        void Init(ModelProperty property, object? value);
        bool IsDefault(ModelProperty property);
        object? Get(ModelProperty property);
        IEnumerable<object> GetValues(ModelProperty property);
        void Add(ModelProperty property, object? item);
        void Remove(ModelProperty property, object? item);

        ModelProperty? NameProperty { get; }
        ModelProperty? TypeProperty { get; }
        MetaType SymbolType { get; }
        ImmutableArray<ModelProperty> DeclaredProperties { get; }
        ImmutableArray<ModelProperty> AllDeclaredProperties { get; }
        ImmutableArray<ModelProperty> PublicProperties { get; }
        IEnumerable<ModelProperty> Properties { get; }
        IEnumerable<ModelProperty> AttachedProperties { get; }
        ModelProperty? GetProperty(string name);
        ImmutableArray<ModelProperty> GetOppositeProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetSubsettedProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetSubsettingProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetRedefinedProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetRedefiningProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetHiddenProperties(ModelProperty property);
        ImmutableArray<ModelProperty> GetHidingProperties(ModelProperty property);

        ImmutableArray<ModelOperation> DeclaredOperations { get; }
        ImmutableArray<ModelOperation> AllDeclaredOperations { get; }
        ImmutableArray<ModelOperation> PublicOperations { get; }
        ImmutableArray<ModelOperation> GetOverridenOperations(ModelOperation property);
        ImmutableArray<ModelOperation> GetOverridingOperations(ModelOperation property);
    }
}