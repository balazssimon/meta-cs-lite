using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class DefineBinder : Binder, IValueBinder
    {
        private readonly Type? _type;

        public DefineBinder(Type? type = null)
        {
            _type = type;
        }

        public Type? Type => _type;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            var declaration = new SingleDeclarationBuilder(this.Syntax, this.Type);
            var children = this.BuildChildDeclarationTree(declaration);
            declaration.AddChildren(children);
            return declaration.ToImmutableAndFree();
        }

        public override ImmutableArray<Symbol> GetDefinedSymbols()
        {
            var containingSymbols = this.GetContainingSymbols();
            var definedSymbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var containingSymbol in containingSymbols)
            {
                foreach (var childSymbol in containingSymbol.ContainedSymbols)
                {
                    // TODO:MetaDslx 
                }
            }
            return definedSymbols.ToImmutableAndFree();
        }
    }
}
