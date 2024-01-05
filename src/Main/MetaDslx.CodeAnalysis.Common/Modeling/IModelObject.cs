using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

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
        IEnumerable<Box> References { get; }

        ISlot? GetSlot(string propertyName);
        ISlot? GetSlot(ModelProperty? property);
        ISlot AttachSlot(ModelProperty property);
        IModelObject Clone();

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

        void ReplaceObject(IModelObject oldObject, IModelObject newObject, CancellationToken cancellationToken = default);

        Location? Location { get; set; }
        SourceLocation? SourceLocation { get; set; }
        Symbol? Symbol { get; set; }
        SyntaxNodeOrToken Syntax { get; set; }
        Microsoft.CodeAnalysis.ISymbol? CSharpSymbol { get; }
        object? Tag { get; set; }
    }
}
