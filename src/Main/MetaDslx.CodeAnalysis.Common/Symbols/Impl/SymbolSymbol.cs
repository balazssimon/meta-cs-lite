using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal partial class SymbolSymbolImpl : SymbolSymbolBase
    {
        protected SymbolSymbolImpl(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected SymbolSymbolImpl(Symbol container, IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected SymbolSymbolImpl(Symbol container, Microsoft.CodeAnalysis.ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected SymbolSymbolImpl(Symbol container, ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

    }
}
