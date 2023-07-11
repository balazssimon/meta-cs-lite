using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    using Model = MetaDslx.Modeling.Model;

    public class SourceModuleSymbol : ModuleSymbol
    {
        private readonly SourceAssemblySymbol _assemblySymbol;
        private readonly DeclarationTable _declarations;
        private readonly Model _model;
        private SourceNamespaceSymbol? _globalNamespace;

        public SourceModuleSymbol(SourceAssemblySymbol assemblySymbol, DeclarationTable declarations, string moduleName)
        {
            _assemblySymbol = assemblySymbol;
            _model = new Model(moduleName);
            _declarations = declarations;
        }

        public SourceAssemblySymbol AssemblySymbol => _assemblySymbol;
        public Compilation Compilation => AssemblySymbol.Compilation;
        public DeclarationTable DeclarationTable => _declarations;
        public Model Model => _model;

        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                if (_globalNamespace is null)
                {
                    //Debug.Assert(!Compilation.RootDeclaration.HasDiagnostics);
                    var globalNS = new SourceNamespaceSymbol(this, this, Compilation.RootDeclaration, null);
                    Interlocked.CompareExchange(ref _globalNamespace, globalNS, null);
                }

                return _globalNamespace;
            }
        }
    }
}
