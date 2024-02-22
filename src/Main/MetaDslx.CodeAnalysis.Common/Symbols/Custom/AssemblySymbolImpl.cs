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

namespace MetaDslx.CodeAnalysis.Symbols.Impl
{
    public class AssemblySymbolImpl : AssemblySymbol
    {
        private readonly Compilation _compilation;
        private readonly string _assemblySimpleName;
        private readonly ModelGroup _modelGroup;
        private NamespaceSymbol _globalNamespace;

        public AssemblySymbolImpl(Compilation compilation, ISymbolFactory symbolFactory, string assemblySimpleName, string moduleName, ImmutableArray<ModuleSymbol> referencedModules)
            : base(container: null)
        {
            _compilation = compilation;
            SymbolFactory = symbolFactory;
            _assemblySimpleName = assemblySimpleName;

            var compilationFactory = compilation.MainLanguage.CompilationFactory;
            _modelGroup = compilationFactory.CreateModelGroup(compilation);

            SourceModule = new ModuleSymbolImpl(this, symbolFactory, moduleName, compilation.DeclarationTable);
            SymbolFactory.AddSymbol(SourceModule);

            ArrayBuilder<ModuleSymbol> moduleBuilder = new ArrayBuilder<ModuleSymbol>(1 + referencedModules.Length);
            moduleBuilder.Add(SourceModule);
            _modelGroup.AttachModel(SourceModule.Model);
            foreach (var reference in referencedModules)
            {
                moduleBuilder.Add(reference);
                if (reference.Model is not null)
                {
                    _modelGroup.AddReference(reference.Model);
                }
            }
            Modules = moduleBuilder.ToImmutable();
        }

        public AssemblySymbolImpl(ISymbolFactory symbolFactory, IAssemblySymbol csharpAssemblySymbol)
            : base(container: null, csharpSymbol: csharpAssemblySymbol)
        {
            SymbolFactory = symbolFactory;
        }

        public ModelGroup ModelGroup => _modelGroup;

        public override AssemblySymbol? ContainingAssembly => null;
        public override ModuleSymbol? ContainingModule => null;
        public override Compilation? DeclaringCompilation => _compilation;

        public override ImmutableArray<Location> Locations => Modules.SelectMany(m => m.Locations).AsImmutable();

        /// <summary>
        /// A list of modules the assembly consists of. 
        /// The first (index=0) module is a SourceModuleSymbol, which is a primary module, the rest are net-modules.
        /// </summary>
        internal void DangerousSetModules(ImmutableArray<ModuleSymbol> modules)
        {
            Modules = modules;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return Modules.Cast<ModuleSymbol, Symbol>();
        }

        protected override string? Compute_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _assemblySimpleName;
        }

        protected override NamespaceSymbol Compute_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var moduleGlobalNamespaces = Modules.Select(m => m.GlobalNamespace).Where(ns => ns is not null).ToImmutableArray();
            var mergedGlobalNamespace = MergedNamespaceSymbol.Create(new NamespaceExtent(this), null, moduleGlobalNamespaces);
            return mergedGlobalNamespace;
        }

        protected override bool Compute_IsCorLibrary(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var systemObject = ((IAssemblySymbol)CSharpSymbol).GetTypeByMetadataName("System.Object");
            if (systemObject is null) return false;
            return systemObject.DeclaredAccessibility == Microsoft.CodeAnalysis.Accessibility.Public &&
                systemObject.TypeKind == TypeKind.Class;
        }

    }
}
