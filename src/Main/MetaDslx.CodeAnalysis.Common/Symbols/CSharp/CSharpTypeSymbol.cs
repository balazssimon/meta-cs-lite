using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.CSharp
{
    internal class CSharpTypeSymbol : TypeSymbol, ICSharpSymbol
    {
        private readonly ITypeSymbol _csharpSymbol;

        public CSharpTypeSymbol(Symbol container, ITypeSymbol csharpSymbol)
            : base(container)
        {
            _csharpSymbol = csharpSymbol;
        }

        public CSharpSymbolFactory SymbolFactory => ((CSharpModuleSymbol)ContainingModule).SymbolFactory;
        public ITypeSymbol CSharpSymbol => _csharpSymbol;
        public override ImmutableArray<Location> Locations => _csharpSymbol.Locations.SelectAsArray(l => l.ToMetaDslx());

        public override bool IsImplicitlyDeclared => _csharpSymbol.IsImplicitlyDeclared;
        public override bool IsStatic => _csharpSymbol.IsStatic;
        public override bool IsExtern => _csharpSymbol.IsExtern;
        public override bool IsError => _csharpSymbol.TypeKind == TypeKind.Error;
        public override bool IsReferenceType => _csharpSymbol.IsReferenceType;
        public override bool IsValueType => _csharpSymbol.IsValueType;

        ISymbol ICSharpSymbol.CSharpSymbol => this.CSharpSymbol;

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.Name;
        }

        protected override string? CompleteProperty_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _csharpSymbol.MetadataName;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<Symbol>(_csharpSymbol.GetMembers(), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<DeclaredSymbol> CompleteProperty_Members(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbols<DeclaredSymbol>(_csharpSymbol.GetMembers(), diagnostics, cancellationToken);
        }

        protected override ImmutableArray<TypeSymbol> CompleteProperty_BaseTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (_csharpSymbol.BaseType is null && _csharpSymbol.Interfaces.Length == 0)
            {
                return ImmutableArray<TypeSymbol>.Empty;
            }
            else if (_csharpSymbol.BaseType is null)
            {
                return SymbolFactory.GetSymbols<TypeSymbol>(_csharpSymbol.Interfaces, diagnostics, cancellationToken);
            }
            else if (_csharpSymbol.Interfaces.Length == 0)
            {
                var result = SymbolFactory.GetSymbol<TypeSymbol>(_csharpSymbol.BaseType, diagnostics, cancellationToken);
                if (result is null) return ImmutableArray<TypeSymbol>.Empty;
                else return ImmutableArray.Create(result);
            }
            else
            {
                var baseTypes = ArrayBuilder<INamedTypeSymbol>.GetInstance();
                baseTypes.Add(_csharpSymbol.BaseType);
                baseTypes.AddRange(_csharpSymbol.Interfaces);
                var result = SymbolFactory.GetSymbols<TypeSymbol>(baseTypes, diagnostics, cancellationToken);
                baseTypes.Free();
                return result;
            }
        }

        protected override ImmutableArray<AttributeSymbol> CompleteProperty_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateAttributes(_csharpSymbol, diagnostics, cancellationToken);
        }
    }
}
