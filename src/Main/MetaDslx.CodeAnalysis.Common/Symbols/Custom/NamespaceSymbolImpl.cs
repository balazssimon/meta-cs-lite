using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.Impl
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class NamespaceSymbolImpl : NamespaceSymbol
    {
        public NamespaceSymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent extent = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
        }

        public override ModuleSymbol? ContainingModule => this.NamespaceKind == NamespaceKind.Module ? this.Extent.Module : null;

        protected override NamespaceExtent Compute_Extent(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return base.Compute_Extent(diagnostics, cancellationToken);
        }

        protected override ImmutableArray<NamespaceSymbol> Compute_ConstituentNamespaces(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray.Create<NamespaceSymbol>(this);
        }

        protected override Compilation? Compute_ContainingCompilation(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.NamespaceKind == NamespaceKind.Compilation ? this.Extent.Compilation : null;
        }

        protected override bool Compute_IsGlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ContainingNamespace is null;
        }

        protected override NamespaceKind Compute_NamespaceKind(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.Extent.Kind;
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
