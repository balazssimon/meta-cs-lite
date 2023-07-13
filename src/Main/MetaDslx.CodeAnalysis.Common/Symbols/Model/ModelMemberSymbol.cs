using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelMemberSymbol : MemberSymbol
    {
        private Symbol _containingSymbol;
        private IModelObject _modelObject;

        public ModelMemberSymbol(Symbol containingSymbol, IModelObject modelObject)
        {
            _containingSymbol = containingSymbol;
            _modelObject = modelObject;
        }

        public IModelObject ModelObject => _modelObject;
        public override Symbol? ContainingSymbol => _containingSymbol;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntax => ImmutableArray<SyntaxNodeOrToken>.Empty;

    }
}
