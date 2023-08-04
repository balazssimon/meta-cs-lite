using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public class DefineBinder : Binder, IValueBinder
    {
        private enum CandidateSymbolKind
        {
            None,
            Nesting,
            Defined
        }

        private readonly Type? _type;
        private ImmutableArray<Symbol> _definedSymbols;

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

        public override ImmutableArray<Symbol> DefinedSymbols
        {
            get
            {
                if (!_definedSymbols.IsDefault) return _definedSymbols;
                var parent = ParentBinder;
                var parentSymbols = parent?.DefinedSymbols ?? ImmutableArray<Symbol>.Empty;
                while (parent is not null && parentSymbols.IsDefaultOrEmpty)
                {
                    parent = parent.ParentBinder;
                    parentSymbols = parent?.DefinedSymbols ?? ImmutableArray<Symbol>.Empty;
                }
                if (parentSymbols.IsDefaultOrEmpty) return ImmutableArray<Symbol>.Empty;
                var definedSymbols = GetDefinedSymbols(parentSymbols);
                ImmutableInterlocked.InterlockedInitialize(ref _definedSymbols, definedSymbols);
                return _definedSymbols;
            }
        }

        private ImmutableArray<Symbol> GetDefinedSymbols(ImmutableArray<Symbol> containingSymbols)
        {
            var definedSymbols = ArrayBuilder<Symbol>.GetInstance();
            var nestingSymbols = ArrayBuilder<Symbol>.GetInstance();
            nestingSymbols.AddRange(containingSymbols);
            int i = 0;
            while (i < nestingSymbols.Count)
            {
                var containingSymbol = nestingSymbols[i];
                foreach (var childSymbol in containingSymbol.ContainedSymbols)
                {
                    var kind = GetCandidateSymbolKind(childSymbol);
                    if (kind == CandidateSymbolKind.Defined) definedSymbols.Add(childSymbol);
                    else if (kind == CandidateSymbolKind.Nesting) nestingSymbols.Add(childSymbol);
                }
                ++i;
            }
            nestingSymbols.Free();
            return definedSymbols.ToImmutableAndFree();
        }

        private CandidateSymbolKind GetCandidateSymbolKind(Symbol symbol)
        {
            foreach (var decl in symbol.GetSingleDeclarations())
            {
                if (decl.SyntaxReference == this.Syntax)
                {
                    return decl.IsNesting ? CandidateSymbolKind.Nesting : CandidateSymbolKind.Defined;
                }
            }
            return CandidateSymbolKind.None;
        }

        public override ImmutableArray<Symbol> ContainingDefinedSymbols => this.DefinedSymbols;

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectPropertyBinders(ArrayBuilder<IPropertyBinder> propertyBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectValueBinders(ImmutableArray<IPropertyBinder> propertyBinders, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            valueBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(BindingContext context)
        {
            return DefinedSymbols.Cast<Symbol, object?>();
        }

        public override string ToString()
        {
            var builder = PooledStringBuilder.GetInstance();
            var sb = builder.Builder;
            sb.Append(this.GetType().Name);
            sb.Append(": [");
            var delim = string.Empty;
            foreach (var symbol in DefinedSymbols)
            {
                sb.Append(delim);
                sb.Append(symbol);
                delim = ", ";
            }
            sb.Append("]");
            return builder.ToStringAndFree();
        }

    }
}
