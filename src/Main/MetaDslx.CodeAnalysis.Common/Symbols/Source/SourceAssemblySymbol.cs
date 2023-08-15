using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceAssemblySymbol : AssemblySymbol
    {
        private readonly Compilation _compilation;
        private readonly string _assemblySimpleName;
        private readonly SourceModuleSymbol _sourceModule;
        private readonly IModelGroup _modelGroup;
        private NamespaceSymbol _globalNamespace;

        /// <summary>
        /// A list of modules the assembly consists of. 
        /// The first (index=0) module is a SourceModuleSymbol, which is a primary module, the rest are net-modules.
        /// </summary>
        private readonly ImmutableArray<ModuleSymbol> _modules;

        public SourceAssemblySymbol(Compilation compilation, string assemblySimpleName, string moduleName, ImmutableArray<ModuleSymbol> referencedModules)
        {
            _compilation = compilation;
            _assemblySimpleName = assemblySimpleName;

            var compilationFactory = compilation.MainLanguage.CompilationFactory;
            _modelGroup = compilationFactory.CreateModelGroup(compilation);

            _sourceModule = new SourceModuleSymbol(this, moduleName, compilation.DeclarationTable);
            var sourceSymbolFactory = compilationFactory.CreateSourceSymbolFactory(compilation, _sourceModule);
            _sourceModule.SymbolFactory = sourceSymbolFactory;

            ArrayBuilder<ModuleSymbol> moduleBuilder = new ArrayBuilder<ModuleSymbol>(1 + referencedModules.Length);
            moduleBuilder.Add(_sourceModule);
            _modelGroup.AddModel(_sourceModule.Model);
            foreach (var reference in referencedModules)
            {
                moduleBuilder.Add(reference);
                if (reference is IModelSymbol modelReference && modelReference.Model is not null)
                {
                    _modelGroup.AddReference(modelReference.Model);
                }
            }
            _modules = moduleBuilder.ToImmutable();
        }

        public SourceModuleSymbol SourceModuleSymbol => _sourceModule;
        public override ImmutableArray<ModuleSymbol> Modules => _modules;

        public override Compilation? DeclaringCompilation => _compilation;

        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => ImmutableArray<SyntaxNodeOrToken>.Empty;
        public override ImmutableArray<Location> Locations => Modules.SelectMany(m => m.Locations).AsImmutable();

        public IModelGroup ModelGroup => _modelGroup;
        public Type ModelObjectType => null;

        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                ForceComplete(CompletionGraph.FinishCreatingContainedSymbols, null, default);
                return _globalNamespace;
            }
        }

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _assemblySimpleName;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var moduleGlobalNamespaces = _modules.Select(m => m.GlobalNamespace).ToImmutableArray();
            var mergedGlobalNamespace = MergedNamespaceSymbol.Create(new NamespaceExtent(this), null, moduleGlobalNamespaces);
            Interlocked.CompareExchange(ref _globalNamespace, mergedGlobalNamespace, null);
            return _modules.Cast<ModuleSymbol, Symbol>();
        }
    }
}
