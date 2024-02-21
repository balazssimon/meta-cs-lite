using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Binding
{
    public enum AmbiguousSymbolLocation
    {
        None,
        FromSourceModule,
        FromAddedModule,
        FromReferencedAssembly,
        FromCorLibrary,
    }
}
