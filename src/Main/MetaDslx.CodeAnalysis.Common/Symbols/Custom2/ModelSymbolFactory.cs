using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Model
{
    public class ModelSymbolFactory : SymbolFactory<IModelObject>
    {
        public ModelSymbolFactory(ModuleSymbol moduleSymbol) 
            : base(moduleSymbol)
        {
        }

        public override string? GetName(IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MName;
        }

        public override string? GetMetadataName(IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MName;
        }

        public override ImmutableArray<Symbol> GetContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var mobj = container.ModelObject;
            if (mobj is null || mobj.MChildren.Count == 0) return ImmutableArray<Symbol>.Empty;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in mobj.MChildren)
            {
                var symbol = GetSymbol<Symbol>(container, child, diagnostics, cancellationToken);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        protected override TSymbol? CreateSymbol<TSymbol>(Symbol container, IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken) where TSymbol : default
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
