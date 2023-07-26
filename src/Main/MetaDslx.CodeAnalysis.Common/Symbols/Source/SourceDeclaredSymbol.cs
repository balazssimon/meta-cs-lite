using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceDeclaredSymbol : DeclaredSymbol, ISourceSymbol
    {
        private readonly MergedDeclaration _declaration;
        private readonly IModelObject _modelObject;

        public SourceDeclaredSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container)
        {
            _declaration = declaration;
            _modelObject = modelObject;
        }

        public IModel Model => _modelObject.Model;
        public IModelObject ModelObject => _modelObject;

        public MergedDeclaration Declaration => _declaration;
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => _declaration.SyntaxReferences;
        public override ImmutableArray<Location> Locations => _declaration.NameLocations;

    }
}
