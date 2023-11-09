using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using MetaDslx.Modeling.Meta;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Meta
{
    internal class SymbolMetaClass : MetaClass<MetaType, CSharpDeclaredSymbol, CSharpDeclaredSymbol>
    {
        private object? _symbolType;
        private ImmutableArray<MetaType> _baseTypes;
        private ImmutableArray<CSharpDeclaredSymbol> _declaredProperties;

        public SymbolMetaClass(MetaType underlyingType) 
            : base(underlyingType)
        {
            _baseTypes = CSharpClass.BaseTypes.Select(bt => MetaDslx.CodeAnalysis.MetaType.FromTypeSymbol(bt)).ToImmutableArray();
            var declaredProperties = ArrayBuilder<CSharpDeclaredSymbol>.GetInstance();
            foreach (var member in CSharpClass.Members)
            {
                if (member is CSharpDeclaredSymbol csmember && csmember.CSharpSymbol is IPropertySymbol prop)
                {
                    declaredProperties.Add(csmember);
                }
            }
            _declaredProperties = declaredProperties.ToImmutableAndFree();
        }

        public CSharpTypeSymbol CSharpClass => (CSharpTypeSymbol)UnderlyingType.OriginalTypeSymbol;
        public INamedTypeSymbol MsCSharpClass => (INamedTypeSymbol)CSharpClass.CSharpSymbol;

        public override string Name => UnderlyingType.Name;

        public override object? SymbolType
        {
            get => _symbolType;
            set => _symbolType = value;
        }

        public override ImmutableArray<MetaType> OriginalBaseTypes => _baseTypes;

        public override ImmutableArray<CSharpDeclaredSymbol> OriginalDeclaredProperties => _declaredProperties;

        public override ImmutableArray<CSharpDeclaredSymbol> OriginalDeclaredOperations => ImmutableArray<CSharpDeclaredSymbol>.Empty;
    }
}
