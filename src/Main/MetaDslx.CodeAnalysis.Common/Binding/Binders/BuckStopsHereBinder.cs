﻿using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    /// <summary>
    /// A binder that knows no symbols and will not delegate further.
    /// </summary>
    public sealed class BuckStopsHereBinder : Binder
    {
        public BuckStopsHereBinder(Compilation compilation)
        {
            this.Compilation = compilation;
        }

        public override Language Language => Language.NoLanguage;
        public override SyntaxTree SyntaxTree => null;
        public RootBinder? RootBinder => null;

        public override Binder GetBinder(SyntaxNodeOrToken syntax)
        {
            var rootBinder = Compilation.GetRootBinder(syntax.SyntaxTree);
            if (rootBinder is not null)
            {
                return base.GetBinder(syntax) ?? this;
            }
            return this;
        }

        public override Binder GetEnclosingBinder(TextSpan span)
        {
            return this;
        }

        public override ImmutableArray<Symbol> DefinedSymbols => ImmutableArray<Symbol>.Empty;

        public override ImmutableArray<DeclarationSymbol> ContainingScopeSymbols => ImmutableArray<DeclarationSymbol>.Empty;

        public override ImmutableArray<Symbol> ContainingDefinedSymbols => ImmutableArray<Symbol>.Empty;

        protected override IPropertyBinder? GetEnclosingPropertyBinder()
        {
            return null;
        }
    }
}
