using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Xml.Linq;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;

namespace MetaDslx.CodeAnalysis.Symbols.Implementation
{
    using __Model = MetaDslx.Modeling.Model;
    using __IModelObject = MetaDslx.Modeling.IModelObject;
    using __ISymbol = Microsoft.CodeAnalysis.ISymbol;

    public class ModuleSymbolImpl : ModuleSymbol
    {
        private readonly string _moduleName;
        private readonly ISymbolFactory _symbolFactory;
        private MetaDslx.Modeling.Model _model;
        private NamespaceSymbol _globalNamespace;
        private ImmutableArray<NamespaceSymbol> _fileNamespaces;

        public ModuleSymbolImpl(AssemblySymbol? assemblySymbol, ISymbolFactory symbolFactory, string moduleName, DeclarationTable? declarations)
            : base(container: assemblySymbol, compilation: null, declaration: declarations?.GetMergedRoot(assemblySymbol.DeclaringCompilation), modelObject: null, csharpSymbol: null, errorInfo: null)
        {
            _symbolFactory = symbolFactory;
            _moduleName = moduleName;
        }

        public ModuleSymbolImpl(AssemblySymbol? assemblySymbol, ISymbolFactory symbolFactory, MetaDslx.Modeling.Model model)
            : base(container: assemblySymbol, compilation: null, declaration: null, modelObject: null, csharpSymbol: null, errorInfo: null)
        {
            _symbolFactory = symbolFactory;
            _model = model;
        }

        public ModuleSymbolImpl(AssemblySymbol? assemblySymbol, ISymbolFactory symbolFactory, IModuleSymbol csharpModuleSymbol)
            : base(container: assemblySymbol, compilation: null, declaration: null, modelObject: null, csharpSymbol: csharpModuleSymbol, errorInfo: null)
        {
            _symbolFactory = symbolFactory;
        }

        public override ISymbolFactory SymbolFactory => _symbolFactory;

        public override __Model Model
        {
            get
            {
                if (_model is null)
                {
                    var model = new MetaDslx.Modeling.Model(name: this.Name);
                    Interlocked.CompareExchange(ref _model, model, null);
                }
                return _model;
            }
        }

        public override AssemblySymbol? ContainingAssembly => this.ContainingSymbol as AssemblySymbol;
        public override ModuleSymbol? ContainingModule => null;
        public override Compilation? DeclaringCompilation => ContainingAssembly?.DeclaringCompilation;

        public override NamespaceSymbol GlobalNamespace
        {
            get
            {
                ForceComplete(CompletionGraph.FinishCreatingContainedSymbols, null, default);
                return _globalNamespace;
            }
        }

        protected override string? Compute_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _moduleName;
        }

        protected override string? Compute_MetadataName(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return _moduleName;
        }

        protected override ImmutableArray<Symbol> CompletePart_CreateContainedSymbols(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (IsCSharpSymbol)
            {
                _globalNamespace = new RootNamespaceSymbol(this, ((IModuleSymbol)CSharpSymbol).GlobalNamespace, Model);
                _symbolFactory.AddSymbol(_globalNamespace);
            }
            else
            {
                _globalNamespace = new RootNamespaceSymbol(this, MergedDeclaration, Model);
                if (DeclaringCompilation is not null && !DeclaringCompilation.Options.MergeGlobalNamespace)
                {
                    var fileNamespaces = ArrayBuilder<NamespaceSymbol>.GetInstance();
                    foreach (var syntaxTree in DeclaringCompilation.SyntaxTrees)
                    {
                        var decl = MergedDeclaration.Declarations.FirstOrDefault(d => d.SyntaxReference.SyntaxTree == syntaxTree);
                        Debug.Assert(decl is not null);
                        if (decl is not null)
                        {
                            var fileNamespace = SymbolFactory.CreateSymbol<NamespaceSymbol>(_globalNamespace, MergedDeclaration, diagnostics, cancellationToken);
                            fileNamespaces.Add(fileNamespace);
                        }
                        else
                        {
                            fileNamespaces.Add(_globalNamespace);
                        }
                    }
                    _fileNamespaces = fileNamespaces.ToImmutableAndFree();
                }
            }
            return ImmutableArray.Create<Symbol>(_globalNamespace);
        }

        public override NamespaceSymbol? GetRootNamespace(SyntaxTree syntaxTree)
        {
            var globalNamespace = GlobalNamespace;
            if (DeclaringCompilation is null) return globalNamespace;
            if (!DeclaringCompilation.ContainsSyntaxTree(syntaxTree)) throw new ArgumentException(nameof(syntaxTree), "Syntax tree must be from the current compilation.");
            if (!DeclaringCompilation.Options.MergeGlobalNamespace)
            {
                var index = DeclaringCompilation.GetSyntaxTreeOrdinal(syntaxTree);
                return _fileNamespaces[index];
            }
            return globalNamespace;
        }

        protected override ImmutableArray<AttributeSymbol> Compute_Attributes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return ImmutableArray<AttributeSymbol>.Empty;
        }

        protected override void CompletePart_ComputeNonSymbolProperties(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            // nop
        }
    }
}
