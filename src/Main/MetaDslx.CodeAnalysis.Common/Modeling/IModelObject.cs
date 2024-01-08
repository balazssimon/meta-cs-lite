using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Symbols;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.Modeling
{
    public interface IModelObject
    {
        ModelClassInfo MInfo { get; }
        string? MId { get; set; }
        Model? MModel { get; set; }

        string? MName { get; set; }
        IModelObject? MParent { get; set; }
        IList<IModelObject> MChildren { get; }
        IEnumerable<Box> MReferences { get; }

        IModelObject MClone();

        IEnumerable<ModelProperty> MProperties { get; }
        IEnumerable<ModelProperty> MAttachedProperties { get; }
        ISlot? MGetSlot(string propertyName);
        ISlot? MGetSlot(ModelProperty? property);
        ISlot MAttachSlot(ModelProperty property);

        void MReplaceObject(IModelObject oldObject, IModelObject? newObject, CancellationToken cancellationToken = default);

        Location? MLocation { get; set; }
        SourceLocation? MSourceLocation { get; set; }
        Symbol? MSymbol { get; set; }
        SyntaxNodeOrToken MSyntax { get; set; }
        Microsoft.CodeAnalysis.ISymbol? MCSharpSymbol { get; }
        object? MTag { get; set; }
    }
}
