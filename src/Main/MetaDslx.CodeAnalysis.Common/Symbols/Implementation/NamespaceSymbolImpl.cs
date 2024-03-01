using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.Implementation
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class NamespaceSymbolImpl : NamespaceSymbol
    {
        private readonly NamespaceExtent _extent;

        public NamespaceSymbolImpl(NamespaceExtent extent, Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
            _extent = extent;
        }

        public override NamespaceExtent Extent => _extent;
        public override ModuleSymbol? ContainingModule => this.NamespaceKind == NamespaceKind.Module ? this.Extent.Module : base.ContainingModule;
        public override Compilation? ContainingCompilation => this.NamespaceKind == NamespaceKind.Compilation ? this.Extent.Compilation : null;
        public override Compilation? DeclaringCompilation => Extent.DeclaringCompilation;
        public override bool IsGlobalNamespace => ContainingNamespace is null;
        public override NamespaceKind NamespaceKind => this.Extent.Kind;

        protected override ImmutableArray<NamespaceSymbol> Compute_ConstituentNamespaces(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray.Create<NamespaceSymbol>(this);
        }

        protected override ImmutableArray<NamespaceSymbol> Compute_NamespaceMembers(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return Members.OfType<NamespaceSymbol>().ToImmutableArray();
        }

        public override NamespaceSymbol? LookupNestedNamespace(ImmutableArray<string> names)
        {
            NamespaceSymbol scope = this;
            foreach (string name in names)
            {
                scope = scope.LookupNestedNamespace(name);
                if (scope is null) break;
            }
            return scope;
        }

        public override NamespaceSymbol? LookupNestedNamespace(string name)
        {
            NamespaceSymbol nextScope = null;
            foreach (var symbol in this.GetMembers(name))
            {
                var ns = symbol as NamespaceSymbol;
                if (ns is not null)
                {
                    if (nextScope is not null)
                    {
                        Debug.Assert(false, "Why did we run into an unmerged namespace?");
                        nextScope = null;
                        break;
                    }
                    nextScope = ns;
                }
            }
            return nextScope;
        }
    }
}
