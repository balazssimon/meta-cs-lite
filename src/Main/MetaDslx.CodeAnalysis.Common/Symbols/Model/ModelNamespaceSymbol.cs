﻿using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelNamespaceSymbol : NamespaceSymbol
    {
        private Symbol _containingSymbol;
        private IModelObject _modelObject;

        public ModelNamespaceSymbol(Symbol containingSymbol, IModelObject modelObject)
        {
            _containingSymbol = containingSymbol;
            _modelObject = modelObject;
        }

        public IModelObject ModelObject => _modelObject;
        public override Symbol? ContainingSymbol => _containingSymbol;
        public override ImmutableArray<Location> Locations => ImmutableArray<Location>.Empty;
        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => ImmutableArray<SyntaxNodeOrToken>.Empty;

    }
}
