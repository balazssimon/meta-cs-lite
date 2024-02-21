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
        public ModelSymbolFactory() 
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

        public override ImmutableArray<Symbol> CreateContainedSymbols(Symbol container, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var mobj = container.ModelObject;
            if (mobj is null || mobj.MChildren.Count == 0) return ImmutableArray<Symbol>.Empty;
            var symbols = ArrayBuilder<Symbol>.GetInstance();
            foreach (var child in mobj.MChildren)
            {
                var symbol = CreateSymbol<Symbol>(container, child, diagnostics, cancellationToken);
                if (symbol is not null) symbols.Add(symbol);
            }
            return symbols.ToImmutableAndFree();
        }

        public override ImmutableArray<TValue> GetSymbolPropertyValues<TValue>(Symbol symbol, string symbolProperty, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }

        public override void ComputeNonSymbolProperties(Symbol symbol, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            // nop
        }

        protected override IModelObject? GetParentCore(IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return underlyingObject.MParent;
        }

        protected override Symbol? CreateSymbolCore(Symbol container, IModelObject underlyingObject, DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
