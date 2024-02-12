using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal partial class ImportSymbolImpl : ImportSymbolBase
    {
        protected ImportSymbolImpl(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected ImportSymbolImpl(Symbol container, IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected ImportSymbolImpl(Symbol container, Microsoft.CodeAnalysis.ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected ImportSymbolImpl(Symbol container, ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

    }
}
