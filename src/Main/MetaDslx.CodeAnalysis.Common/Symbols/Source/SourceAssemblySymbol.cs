using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceAssemblySymbol : AssemblySymbol
    {
        private Compilation _compilation;
        private string _assemblySimpleName;
        private SourceModuleSymbol _sourceModule;

        /// <summary>
        /// A list of modules the assembly consists of. 
        /// The first (index=0) module is a SourceModuleSymbol, which is a primary module, the rest are net-modules.
        /// </summary>
        private readonly ImmutableArray<ModuleSymbol> _modules;

        public SourceAssemblySymbol(Compilation compilation, string assemblySimpleName, string moduleName, ImmutableArray<ModuleSymbol> referencedModules)
        {
            _compilation = compilation;
            _assemblySimpleName = assemblySimpleName;

            ArrayBuilder<ModuleSymbol> moduleBuilder = new ArrayBuilder<ModuleSymbol>(1 + referencedModules.Length);
            _sourceModule = new SourceModuleSymbol(this, compilation.DeclarationTable, moduleName);
            moduleBuilder.Add(_sourceModule);
            foreach (var reference in referencedModules)
            {
                moduleBuilder.Add(reference);
            }
            _modules = moduleBuilder.ToImmutable();
        }

        public Compilation Compilation => _compilation;

        public SourceModuleSymbol SourceModule => _sourceModule;

        public ImmutableArray<ModuleSymbol> Modules => _modules;
    }
}
