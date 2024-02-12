using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Errors;

namespace MetaDslx.CodeAnalysis.Symbols
{
    internal partial class AssemblySymbolImpl : AssemblySymbolBase
    {
        protected AssemblySymbolImpl(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected AssemblySymbolImpl(Symbol container, IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected AssemblySymbolImpl(Symbol container, Microsoft.CodeAnalysis.ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected AssemblySymbolImpl(Symbol container, ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

    }
}
