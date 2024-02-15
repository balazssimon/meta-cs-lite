using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceSymbolFactory : SymbolFactory<MergedDeclaration>
    {
        public SourceSymbolFactory(ModuleSymbol moduleSymbol)
            : base(moduleSymbol)
        {
        }

        public override string? GetName(MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.Name;
        }

        public override string? GetMetadataName(MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MetadataName;
        }

        public override ImmutableArray<Symbol> GetContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var declaration = container.MergedDeclaration;
            if (declaration is null || declaration.Children.Length == 0) return ImmutableArray<Symbol>.Empty;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in declaration.Children)
            {
                var symbol = GetSymbol<Symbol>(container, child, diagnostics, cancellationToken);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        protected override TSymbol? CreateSymbol<TSymbol>(Symbol container, MergedDeclaration underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken) where TSymbol : default
        {
            throw new NotImplementedException();
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
