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
    public class DefineBinder : Binder, IDefineBinder, IValueBinder
    {
        private enum CandidateSymbolKind
        {
            None,
            Nesting,
            Defined
        }

        private readonly Type? _type;
        private readonly bool _isScope;
        private ImmutableArray<Symbol> _nestingSymbols;
        private ImmutableArray<Symbol> _definedSymbols;

        public DefineBinder(Type? type = null, bool isScope = true)
        {
            _type = type;
            _isScope = isScope;
        }

        public Type? Type => _type;

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

        protected override void CollectNameBinders(ArrayBuilder<INameBinder> nameBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectQualifierBinders(ArrayBuilder<IQualifierBinder> qualifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectIdentifierBinders(ArrayBuilder<IIdentifierBinder> identifierBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectPropertyBinders(string? propertyName, ArrayBuilder<IPropertyBinder> propertyBinders, CancellationToken cancellationToken)
        {
        }

        protected override void CollectValueBinders(IPropertyBinder propertyBinder, ArrayBuilder<IValueBinder> valueBinders, CancellationToken cancellationToken)
        {
            valueBinders.Add(this);
        }

        protected override ImmutableArray<object?> BindValues(CancellationToken cancellationToken = default)
        {
            ComputeDefinedSymbols(cancellationToken);
            return _definedSymbols.Cast<Symbol, object?>();
        }

        /*protected override void AddLookupCandidateSymbolsInSingleBinder(LookupContext context, LookupCandidates result)
        {
            if (_isScope && context.Qualifier is null)
            {
                foreach (var definedSymbol in DefinedSymbols)
                {
                    var declaredSymbol = definedSymbol as DeclaredSymbol;
                    if (declaredSymbol is not null)
                    {
                        context.Qualifier = declaredSymbol;
                        base.AddLookupCandidateSymbolsInSingleBinder(context, result);
                        context.Qualifier = null;
                    }
                }
            }
            else
            {
                base.AddLookupCandidateSymbolsInSingleBinder(context, result);
            }
        }*/

        protected override void MarkSymbolAsUsed(DeclaredSymbol symbol)
        {
            foreach (var definedSymbol in DefinedSymbols)
            {
                //if (definedSymbol is DeclaredSymbol declaredSymbol && declaredSymbol.Members.Contains(symbol)) return;
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
