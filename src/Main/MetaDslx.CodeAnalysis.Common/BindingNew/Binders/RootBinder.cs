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
        private ImmutableArray<Symbol> _definedSymbols;

        public RootBinder(SyntaxTree syntaxTree)
        {
            _syntaxTree = syntaxTree;
        }

        public override Language Language => _syntaxTree.Language;
        public override SyntaxTree SyntaxTree => _syntaxTree;

        public RootSingleDeclaration BuildDeclarationTree(string? scriptClassName, bool isSubmission)
        {
            var builder = new SingleDeclarationBuilder(this.Syntax, null);
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
                    ImmutableInterlocked.InterlockedInitialize(ref _definedSymbols, rootNamespace is null ? ImmutableArray<Symbol>.Empty : ImmutableArray.Create<Symbol>(rootNamespace));
                }
                return _definedSymbols;
            }
        }

        public override ImmutableArray<DeclarationSymbol> ContainingScopeSymbols => ImmutableArray<DeclarationSymbol>.Empty;

        public override ImmutableArray<Symbol> ContainingDefinedSymbols => ImmutableArray<Symbol>.Empty;

        protected override IPropertyBinder? GetEnclosingPropertyBinder()
        {
            return null;
        }

        protected override void AddLookupCandidateSymbolsInSingleBinder(LookupContext context, LookupCandidates result)
        {
            if (context.Qualifier is null)
            {
                if (Compilation.Options.MergeGlobalNamespace)
                {
                    foreach (var symbol in Compilation.GlobalNamespace.ContainedSymbols)
                    {
                        if (symbol is DeclarationSymbol declaredSymbol && context.IsViable(declaredSymbol))
                        {
                            result.Add(declaredSymbol);
                        }
                    }
                }
                else
                {
                    foreach (var rootNamespace in DefinedSymbols)
                    {
                        foreach (var symbol in rootNamespace.ContainedSymbols.Where(s => s.DeclaringSyntaxReferences.Any(d => d.SyntaxTree == this.SyntaxTree)))
                        {
                            if (symbol is DeclarationSymbol declaredSymbol && context.IsViable(declaredSymbol))
                            {
                                result.Add(declaredSymbol);
                            }
                        }
                    }
                }
            }
            else
            {
                base.AddLookupCandidateSymbolsInSingleBinder(context, result);
            }
        }

    }
}
