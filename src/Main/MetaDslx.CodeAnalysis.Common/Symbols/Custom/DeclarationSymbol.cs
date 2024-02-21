using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.__Impl
{
    public class DeclarationSymbolImpl : DeclarationSymbolBase
    {
        public override ImmutableArray<string> Complete_MemberNames(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<DeclarationSymbol>().Where(m => !string.IsNullOrEmpty(m.Name)).Select(m => m.Name).Distinct().ToImmutableArray();
        }

        public override ImmutableArray<DeclarationSymbol> Complete_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<DeclarationSymbol>().ToImmutableArray();
        }

        public override ImmutableArray<TypeSymbol> Complete_TypeMembers(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return this.ContainedSymbols.OfType<TypeSymbol>().ToImmutableArray();
        }

        public override ImmutableArray<DeclarationSymbol> GetMembers(string name)
        {
            return this.Members.Where(m => m.Name == name).ToImmutableArray();
        }

        public override ImmutableArray<DeclarationSymbol> GetMembers(string name, string metadataName)
        {
            return this.Members.Where(m => m.Name == name && m.MetadataName == metadataName).ToImmutableArray();
        }

        public override ImmutableArray<TypeSymbol> GetTypeMembers(string name)
        {
            return this.TypeMembers.Where(m => m.Name == name).ToImmutableArray();
        }

        public override ImmutableArray<TypeSymbol> GetTypeMembers(string name, string metadataName)
        {
            return this.TypeMembers.Where(m => m.Name == name && m.MetadataName == metadataName).ToImmutableArray();
        }
    }
}
