using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal partial class AttributeSymbolImpl : AttributeSymbolBase
    {
        protected AttributeSymbolImpl(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected AttributeSymbolImpl(Symbol container, IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected AttributeSymbolImpl(Symbol container, Microsoft.CodeAnalysis.ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected AttributeSymbolImpl(Symbol container, ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

    }
}
