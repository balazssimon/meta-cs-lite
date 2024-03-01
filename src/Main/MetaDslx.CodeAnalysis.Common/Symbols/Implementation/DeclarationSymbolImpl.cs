using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;

namespace MetaDslx.CodeAnalysis.Symbols.Implementation
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class DeclarationSymbolImpl : DeclarationSymbol
    {
        public DeclarationSymbolImpl(Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        protected override ImmutableArray<ImportSymbol> Compute_Imports(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<ImportSymbol>().ToImmutableArray();
        }

        protected override ImmutableArray<string> Compute_MemberNames(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<DeclarationSymbol>().Where(m => !string.IsNullOrEmpty(m.Name)).Select(m => m.Name).Distinct().ToImmutableArray();
        }

        protected override ImmutableArray<DeclarationSymbol> Compute_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<DeclarationSymbol>().ToImmutableArray();
        }

        protected override ImmutableArray<TypeSymbol> Compute_TypeMembers(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<TypeSymbol>().ToImmutableArray();
        }

        protected override ImmutableArray<DeclarationSymbol> Compute_GetMembers(string name)
        {
            return this.Members.Where(m => m.Name == name).ToImmutableArray();
        }

        protected override ImmutableArray<DeclarationSymbol> Compute_GetMembers(string name, string metadataName)
        {
            return this.Members.Where(m => m.Name == name && m.MetadataName == metadataName).ToImmutableArray();
        }

        protected override ImmutableArray<TypeSymbol> Compute_GetTypeMembers(string name)
        {
            return this.TypeMembers.Where(m => m.Name == name).ToImmutableArray();
        }

        protected override ImmutableArray<TypeSymbol> Compute_GetTypeMembers(string name, string metadataName)
        {
            return this.TypeMembers.Where(m => m.Name == name && m.MetadataName == metadataName).ToImmutableArray();
        }
    }
}
