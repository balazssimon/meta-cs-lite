using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Analyzers.Modeling
{
    internal class MetaClass
    {
        private INamedTypeSymbol _classInterface;

        public MetaClass(INamedTypeSymbol classInterface)
        {
            _classInterface = classInterface;
        }

        public INamedTypeSymbol ClassInterface => _classInterface;

        public string Name => _classInterface.Name;
        public string ImplName => _classInterface.Name + "Impl";
    }
}
