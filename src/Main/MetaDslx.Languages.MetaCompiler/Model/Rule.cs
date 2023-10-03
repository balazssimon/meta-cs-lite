using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    using CSharpCompilation = Microsoft.CodeAnalysis.CSharp.CSharpCompilation;
    using INamespaceSymbol = Microsoft.CodeAnalysis.INamespaceSymbol;
    using INamespaceOrTypeSymbol = Microsoft.CodeAnalysis.INamespaceOrTypeSymbol;
    using INamedTypeSymbol = Microsoft.CodeAnalysis.INamedTypeSymbol;
    using ITypeSymbol = Microsoft.CodeAnalysis.ITypeSymbol;
    using IArrayTypeSymbol = Microsoft.CodeAnalysis.IArrayTypeSymbol;
    using IMethodSymbol = Microsoft.CodeAnalysis.IMethodSymbol;
    using IParameterSymbol = Microsoft.CodeAnalysis.IParameterSymbol;
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;
    using SymbolDisplayFormat = Microsoft.CodeAnalysis.SymbolDisplayFormat;

    public abstract class Rule : NamedElement
    {
        private readonly Grammar _grammar;
        private CSharpTypeInfo _csharpReturnType;

        public Rule(Grammar grammar)
        {
            _grammar = grammar;
        }

        public Grammar Grammar => _grammar;
        public Language Language => _grammar.Language;

        public abstract string GreenName { get; }
        public abstract string RedName { get; }

        public ImmutableArray<string> ReturnTypeName { get; set; }
        public CSharpTypeInfo CSharpReturnType
        {
            get
            {
                if (_csharpReturnType is null)
                {
                    var typeSymbol = ReturnTypeName.Length > 0 ? Language.ResolveSymbols(Location, true, "type", ReturnTypeName).OfType<ITypeSymbol>().FirstOrDefault() : null;
                    _csharpReturnType = new CSharpTypeInfo(Language, typeSymbol);
                }
                return _csharpReturnType;
            }
        }
    }

}
