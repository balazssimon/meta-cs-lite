using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;

namespace MetaDslx.CodeAnalysis.Symbols.Implementation
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;

    public class TypeSymbolImpl : TypeSymbol
    {
        public TypeSymbolImpl(Symbol? container, Compilation? compilation, MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, ErrorSymbolInfo? errorInfo)
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        protected override ImmutableArray<TypeSymbol> Compute_BaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (IsCSharpSymbol)
            {
                var cst = (ITypeSymbol)CSharpSymbol;
                var baseTypes = ArrayBuilder<TypeSymbol>.GetInstance();
                if (cst.BaseType is not null)
                {
                    var baseType = SymbolFactory.GetSymbol<TypeSymbol>(cst.BaseType, diagnostics, cancellationToken);
                    if (baseType is not null) baseTypes.Add(baseType);
                }
                baseTypes.AddRange(SymbolFactory.GetSymbols<TypeSymbol>(((ITypeSymbol)CSharpSymbol).Interfaces, diagnostics, cancellationToken));
                return baseTypes.ToImmutableAndFree();
            }
            else
            {
                return base.Compute_BaseTypes(diagnostics, cancellationToken);
            }
        }

        protected override ImmutableArray<TypeSymbol> Compute_AllBaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var allBaseTypes = ArrayBuilder<TypeSymbol>.GetInstance();
            var stack = ArrayBuilder<TypeSymbol>.GetInstance();
            stack.Add(this);
            while (stack.Count > 0)
            {
                var type = stack[stack.Count - 1];
                var added = false;
                foreach (var baseType in type.BaseTypes)
                {
                    if (!stack.Contains(baseType) && !allBaseTypes.Contains(baseType))
                    {
                        added = true;
                        stack.Add(baseType);
                    }
                }
                if (!added)
                {
                    if (!allBaseTypes.Contains(type)) allBaseTypes.Add(type);
                    stack.RemoveAt(stack.Count - 1);
                }
            }
            stack.Free();
            allBaseTypes.Remove(this);
            return allBaseTypes.ToImmutableAndFree();
        }

        public override bool IsDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            Debug.Assert(type is not null);
            if (object.ReferenceEquals(this, type)) return false;
            return AllBaseTypes.Any(t => comparison.Equals(t, type));
        }

        public override bool IsEqualToOrDerivedFrom(TypeSymbol type, TypeEqualityComparer comparison)
        {
            return comparison.Equals(this, type) || this.IsDerivedFrom(type, comparison);
        }
    }
}
