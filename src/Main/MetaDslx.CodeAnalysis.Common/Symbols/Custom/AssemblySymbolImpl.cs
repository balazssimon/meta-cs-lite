using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Threading;
using MetaDslx.Modeling;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public partial class AssemblySymbol
    {
        public abstract ISymbolFactory SymbolFactory { get; }
        public abstract ModuleSymbol? SourceModule { get; }
        public abstract ImmutableArray<ModuleSymbol> Modules { get; }
    }
}

namespace MetaDslx.CodeAnalysis.Symbols.Impl
{
    public class AssemblySymbolImpl : AssemblySymbol
    {
        private readonly Compilation _compilation;
        private readonly ISymbolFactory _symbolFactory;
        private readonly string _assemblySimpleName;
        private readonly ModuleSymbol _sourceModule;
        private readonly ModelGroup _modelGroup;
        private ImmutableArray<ModuleSymbol> _modules;
        private NamespaceSymbol _globalNamespace;

        public AssemblySymbolImpl(Compilation compilation, ISymbolFactory symbolFactory, string assemblySimpleName, string moduleName, ImmutableArray<ModuleSymbol> referencedModules)
            : base(container: null)
        {
            _compilation = compilation;
            _symbolFactory = symbolFactory;
            _assemblySimpleName = assemblySimpleName;

            var compilationFactory = compilation.MainLanguage.CompilationFactory;
            _modelGroup = compilationFactory.CreateModelGroup(compilation);

            _sourceModule = new ModuleSymbolImpl(this, symbolFactory, moduleName, compilation.DeclarationTable);
            _symbolFactory.AddSymbol(_sourceModule);

            ArrayBuilder<ModuleSymbol> moduleBuilder = new ArrayBuilder<ModuleSymbol>(1 + referencedModules.Length);
            moduleBuilder.Add(_sourceModule);
            _modelGroup.AttachModel(_sourceModule.Model);
            foreach (var reference in referencedModules)
            {
                moduleBuilder.Add(reference);
                if (reference.Model is not null)
                {
                    _modelGroup.AddReference(reference.Model);
                }
            }
            _modules = moduleBuilder.ToImmutable();
        }

        public AssemblySymbolImpl(ISymbolFactory symbolFactory, IAssemblySymbol csharpAssemblySymbol)
            : base(container: null, csharpSymbol: csharpAssemblySymbol)
        {
            _symbolFactory = symbolFactory;
        }

        public ModelGroup ModelGroup => _modelGroup;
        public override ISymbolFactory SymbolFactory => _symbolFactory;
        public override ModuleSymbol? SourceModule => _sourceModule;
        public override ImmutableArray<ModuleSymbol> Modules => _modules;

        public override AssemblySymbol? ContainingAssembly => null;
        public override ModuleSymbol? ContainingModule => null;
        public override Compilation? DeclaringCompilation => _compilation;

        public override ImmutableArray<Location> Locations => _modules.SelectMany(m => m.Locations).AsImmutable();

        /// <summary>
        /// A list of modules the assembly consists of. 
        /// The first (index=0) module is a SourceModuleSymbol, which is a primary module, the rest are net-modules.
        /// </summary>
        internal void DangerousSetModules(ImmutableArray<ModuleSymbol> modules)
        {
            _modules = modules;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _modules.Cast<ModuleSymbol, Symbol>();
        }

        protected override string? Complete_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _assemblySimpleName;
        }

        protected override NamespaceSymbol Complete_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var moduleGlobalNamespaces = _modules.Select(m => m.GlobalNamespace).Where(ns => ns is not null).ToImmutableArray();
            var mergedGlobalNamespace = MergedNamespaceSymbol.Create(new NamespaceExtent(this), null, moduleGlobalNamespaces);
            return mergedGlobalNamespace;
        }

        protected override bool Complete_IsCorLibrary(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var systemObject = ((IAssemblySymbol)CSharpSymbol).GetTypeByMetadataName("System.Object");
            if (systemObject is null) return false;
            return systemObject.DeclaredAccessibility == Microsoft.CodeAnalysis.Accessibility.Public &&
                systemObject.TypeKind == TypeKind.Class;
        }

    }
}
