using System;
using System.Collections.Generic;
using System.Collections.Immutable;
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

    public class DeclarationSymbolImpl : DeclarationSymbol
    {
        public DeclarationSymbolImpl(Symbol? container, Compilation? compilation = null, MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, ErrorSymbolInfo? errorInfo = null) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo)
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
