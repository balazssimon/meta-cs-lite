using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal partial class TypeSymbolImpl : TypeSymbolBase
    {
        protected TypeSymbolImpl(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected TypeSymbolImpl(Symbol container, IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected TypeSymbolImpl(Symbol container, Microsoft.CodeAnalysis.ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected TypeSymbolImpl(Symbol container, ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

    }
}
