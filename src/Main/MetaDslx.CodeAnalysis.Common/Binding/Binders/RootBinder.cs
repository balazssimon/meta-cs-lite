using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.CodeAnalysis.Text;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Binding
{
    public sealed class RootBinder : Binder
    {
        private readonly SyntaxTree? _syntaxTree;
        private readonly Type? _type;
        private ImmutableArray<Symbol> _definedSymbols;

        public RootBinder(SyntaxTree syntaxTree, Type? type = null)
        {
            _syntaxTree = syntaxTree;
            _type = type;
        }

        public override SyntaxTree SyntaxTree => _syntaxTree;
        public Type? Type => _type;

        public RootSingleDeclaration BuildDeclarationTree(string? scriptClassName, bool isSubmission)
        {
            var builder = new SingleDeclarationBuilder(this.Syntax, this.Type);
            builder.AddChildren(this.BuildDeclarationTree(builder));
            return (RootSingleDeclaration)builder.ToImmutableAndFree(root: true, rootName: scriptClassName)[0];
        }

        internal override RootBinder? GetRootBinder()
        {
            return this;
        }

        public override Binder GetBinder(SyntaxNodeOrToken syntax)
        {
            var result = base.GetBinder(syntax);
            return result ?? this;
        }

        public override Binder GetEnclosingBinder(TextSpan span)
        {
            var result = base.GetEnclosingBinder(span);
            return result ?? this;
        }

        public override ImmutableArray<Symbol> DefinedSymbols
        {
            get
            {
                if (_definedSymbols.IsDefault)
                {
                    var rootNamespace = Compilation.GetRootNamespace(this.SyntaxTree);
                    ImmutableInterlocked.InterlockedInitialize(ref _definedSymbols, ImmutableArray.Create<Symbol>(rootNamespace));
                }
                return _definedSymbols;
            }
        }

        public override ImmutableArray<DeclaredSymbol> ContainingScopeSymbols => ImmutableArray<DeclaredSymbol>.Empty;

        public override ImmutableArray<Symbol> ContainingDefinedSymbols => ImmutableArray<Symbol>.Empty;

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
        }

        protected override IPropertyBinder? GetEnclosingPropertyBinder()
        {
            return null;
        }

        protected override void AddLookupCandidateSymbolsInSingleBinder(LookupContext context, LookupCandidates result)
        {
            if (Compilation.Options.MergeGlobalNamespace)
            {
                foreach (var symbol in Compilation.GlobalNamespace.ContainedSymbols)
                {
                    if (symbol is DeclaredSymbol declaredSymbol && context.IsViable(declaredSymbol))
                    {
                        result.Add(declaredSymbol);
                    }
                }
            }
            else
            {
                foreach (var rootNamespace in DefinedSymbols)
                {
                    foreach (var symbol in rootNamespace.ContainedSymbols.Where(s => s is ISourceSymbol ss && ss.DeclaringSyntaxReferences.Any(d => d.SyntaxTree == this.SyntaxTree)))
                    {
                        if (symbol is DeclaredSymbol declaredSymbol && context.IsViable(declaredSymbol))
                        {
                            result.Add(declaredSymbol);
                        }
                    }
                }
            }
        }
    }
}
