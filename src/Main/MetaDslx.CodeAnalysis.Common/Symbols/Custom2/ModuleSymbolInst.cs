using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using Microsoft.CodeAnalysis;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public class ModuleSymbolInst : __Impl.ModuleSymbolInst
    {
        private readonly MetaDslx.Modeling.Model _model;
        private readonly MultiModelFactory _modelFactory;
        private readonly DeclarationTable _declarations;
        private ImmutableArray<NamespaceSymbol> _fileNamespaces;

        public ModuleSymbolInst(AssemblySymbol? assemblySymbol, ISymbolFactory symbolFactory, string moduleName, DeclarationTable? declarations)
            : base(assemblySymbol, declaration: declarations?.GetMergedRoot(assemblySymbol.DeclaringCompilation), modelObject: null)
        {
            SymbolFactory = symbolFactory;
            _declarations = declarations;
            var compilation = assemblySymbol.DeclaringCompilation;
            var compilationFactory = compilation.MainLanguage.CompilationFactory;
            _modelFactory = compilationFactory.CreateModelFactory(compilation);
            _model = compilationFactory.CreateSourceModel(compilation);
            _model.Name = moduleName;
        }

        public ModuleSymbolInst(AssemblySymbol? assemblySymbol, ISymbolFactory symbolFactory, MetaDslx.Modeling.Model model)
            : base(assemblySymbol, model: model)
        {
            SymbolFactory = symbolFactory;
        }

        public ModuleSymbolInst(AssemblySymbol? assemblySymbol, ISymbolFactory symbolFactory, IModuleSymbol csharpModuleSymbol)
            : base(assemblySymbol, csharpSymbol: csharpModuleSymbol)
        {
            SymbolFactory = symbolFactory;
        }

        public MultiModelFactory ModelFactory => _modelFactory;

        public override AssemblySymbol? ContainingAssembly => this.ContainingSymbol as AssemblySymbol;
        public override ModuleSymbol? ContainingModule => null;
        public override Compilation? DeclaringCompilation => ContainingAssembly?.DeclaringCompilation;

        protected override NamespaceSymbol Complete_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (IsCSharpSymbol)
            {
                return SymbolFactory.CreateSymbol<NamespaceSymbol>(ContainingAssembly, ((IModuleSymbol)CSharpSymbol).GlobalNamespace, diagnostics, cancellationToken);
            }
            else
            {
                var globalNamespace = new RootNamespaceSymbol(this, MergedDeclaration, _model);
                if (DeclaringCompilation is not null && !DeclaringCompilation.Options.MergeGlobalNamespace)
                {
                    var fileNamespaces = ArrayBuilder<NamespaceSymbol>.GetInstance();
                    foreach (var syntaxTree in DeclaringCompilation.SyntaxTrees)
                    {
                        var decl = MergedDeclaration.Declarations.FirstOrDefault(d => d.SyntaxReference.SyntaxTree == syntaxTree);
                        Debug.Assert(decl is not null);
                        if (decl is not null)
                        {
                            var fileNamespace = SymbolFactory.CreateSymbol<NamespaceSymbol>(globalNamespace, MergedDeclaration, diagnostics, cancellationToken);
                            fileNamespaces.Add(fileNamespace);
                        }
                        else
                        {
                            fileNamespaces.Add(globalNamespace);
                        }
                    }
                    _fileNamespaces = fileNamespaces.ToImmutableAndFree();
                }
                return globalNamespace;
            }
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
    }
}
