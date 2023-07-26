using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelNamespaceSymbol : NamespaceSymbol, IModelSymbol
    {
        private IModelObject _modelObject;

        public ModelNamespaceSymbol(Symbol container, IModelObject modelObject)
            : base(container)
        {
            _modelObject = modelObject;
        }

        public override NamespaceExtent Extent => new NamespaceExtent(ContainingModule);

        public IModelObject ModelObject => _modelObject;
        public IModel Model => _modelObject.Model;

        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => ImmutableArray<SyntaxNodeOrToken>.Empty;

    }
}
