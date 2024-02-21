using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using System.Xml.Linq;
using System.Diagnostics;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class NamespaceSymbolImpl : NamespaceSymbolBase
    {
        public override ModuleSymbol? ContainingModule => this.NamespaceKind == NamespaceKind.Module ? this.Extent.Module : null;

        public override NamespaceExtent Complete_Extent(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return base.Complete_Extent(diagnostics, cancellationToken);
        }

        public override ImmutableArray<NamespaceSymbol> Complete_ConstituentNamespaces(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray.Create<NamespaceSymbol>(this.AsInstance<NamespaceSymbol>());
        }

        public override Compilation? Complete_ContainingCompilation(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.NamespaceKind == NamespaceKind.Compilation ? this.Extent.Compilation : null;
        }

        public override bool Complete_IsGlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ContainingNamespace is null;
        }

        public override NamespaceKind Complete_NamespaceKind(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.Extent.Kind;
        }

        public override ImmutableArray<NamespaceSymbol> Complete_NamespaceMembers(DiagnosticBag diagnostics, CancellationToken cancellationToken)
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
