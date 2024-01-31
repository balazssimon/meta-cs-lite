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
    public class DefineBinder : ValueBinder, IDefineBinder
    {
        private enum CandidateSymbolKind
        {
            None,
            Nesting,
            Defined
        }

        private ImmutableArray<Symbol> _nestingSymbols;
        private ImmutableArray<Symbol> _definedSymbols;

        public DefineBinder(Type type = default)
            : base(type)
        {
        }

        public new Type Type => base.Type.OriginalType;

        protected override ImmutableArray<SingleDeclaration> BuildDeclarationTree(SingleDeclarationBuilder builder)
        {
            var declaration = new SingleDeclarationBuilder(this.Syntax, this.Type);
            var children = this.BuildChildDeclarationTree(declaration);
            declaration.AddChildren(children);
            return declaration.ToImmutableAndFree();
        }

        public ImmutableArray<Symbol> NestingSymbols
        {
            get
            {
                ComputeDefinedSymbols();
                return _nestingSymbols;
            }
        }

        public override ImmutableArray<Symbol> DefinedSymbols
        {
            get
            {
                ComputeDefinedSymbols();
                return _definedSymbols;
            }
        }

        private void ComputeDefinedSymbols(CancellationToken cancellationToken = default)
        {
            if (!_definedSymbols.IsDefault) return;
            var parent = ParentBinder;
            var parentSymbols = parent?.DefinedSymbols ?? ImmutableArray<Symbol>.Empty;
            while (parent is not null && parentSymbols.IsDefaultOrEmpty)
            {
                parent = parent.ParentBinder;
                parentSymbols = parent?.DefinedSymbols ?? ImmutableArray<Symbol>.Empty;
            }
            if (parentSymbols.IsDefaultOrEmpty)
            {
                AddDiagnostic(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, "Could not resolve defined symbol."));
                ImmutableInterlocked.InterlockedInitialize(ref _nestingSymbols, ImmutableArray<Symbol>.Empty);
                ImmutableInterlocked.InterlockedInitialize(ref _definedSymbols, ImmutableArray<Symbol>.Empty);
                return;
            }
            var definedSymbols = ArrayBuilder<Symbol>.GetInstance();
            var nestingSymbols = ArrayBuilder<Symbol>.GetInstance();
            nestingSymbols.AddRange(parentSymbols);
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
            ImmutableInterlocked.InterlockedInitialize(ref _nestingSymbols, nestingSymbols.ToImmutableAndFree());
            ImmutableInterlocked.InterlockedInitialize(ref _definedSymbols, definedSymbols.ToImmutableAndFree());
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

        public ImmutableArray<IPropertyBinder> GetPropertyBinders(string? propertyName, CancellationToken cancellationToken = default)
        {
            var propertyBinders = ArrayBuilder<IPropertyBinder>.GetInstance();
            var queue = ArrayBuilder<Binder>.GetInstance();
            queue.Add(this);
            int i = 0;
            while (i < queue.Count)
            {
                var binder = queue[i];
                if (binder is IPropertyBinder propertyBinder)
                {
                    if (propertyName is null || propertyBinder.Name == propertyName)
                    {
                        propertyBinders.Add(propertyBinder);
                    }
                }
                foreach (var child in binder.GetChildBinders(false, cancellationToken))
                {
                    if (child is not IDefineBinder) queue.Add(child);
                }
                ++i;
            }
            queue.Free();
            return propertyBinders.ToImmutableAndFree();
        }

        protected override ImmutableArray<object?> ComputeValues(MetaType expectedType, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            ComputeDefinedSymbols(cancellationToken);
            return _definedSymbols.Cast<Symbol, object?>();
        }

        protected override void MarkSymbolAsUsed(DeclarationSymbol symbol)
        {
            foreach (var definedSymbol in DefinedSymbols)
            {
                //if (definedSymbol is DeclarationSymbol declarationSymbol && declarationSymbol.Members.Contains(symbol)) return;
                foreach (var import in definedSymbol.ContainedSymbols.OfType<ImportSymbol>())
                {
                    if (import.MarkImportedSymbolAsUsed(symbol)) return;
                }
            }
            base.MarkSymbolAsUsed(symbol);
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
