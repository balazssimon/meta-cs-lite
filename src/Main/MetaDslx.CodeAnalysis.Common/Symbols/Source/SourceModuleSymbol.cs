using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceModuleSymbol : ModuleSymbol, ISourceSymbol, IModelSymbol
    {
        private readonly SourceAssemblySymbol _assemblySymbol;
        private SourceSymbolFactory _symbolFactory;
        private readonly ModelGroup _modelGroup;
        private readonly MetaDslx.Modeling.Model _model;
        private readonly MultiModelFactory _modelFactory;
        private readonly DeclarationTable _declarations;
        private ImmutableArray<NamespaceSymbol> _fileNamespaces;

        public SourceModuleSymbol(SourceAssemblySymbol assemblySymbol, string moduleName, DeclarationTable declarations)
            : base(assemblySymbol)
        {
            _assemblySymbol = assemblySymbol;
            _declarations = declarations;
            var compilation = assemblySymbol.DeclaringCompilation;
            var compilationFactory = compilation.MainLanguage.CompilationFactory;
            _modelFactory = compilationFactory.CreateModelFactory(compilation);
            _model = compilationFactory.CreateModel(compilation);
            _model.Name = moduleName;
        }

        public SourceSymbolFactory SymbolFactory
        {
            get => _symbolFactory;
            internal set => _symbolFactory = value;
        }

        public SourceAssemblySymbol SourceAssemblySymbol => _assemblySymbol;
        public override Compilation? DeclaringCompilation => SourceAssemblySymbol.DeclaringCompilation;

        public DeclarationTable DeclarationTable => _declarations;
        public MergedDeclaration Declaration => _declarations.GetMergedRoot(DeclaringCompilation);
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => Declaration.SyntaxReferences;
        public override ImmutableArray<Location> Locations => Declaration.NameLocations.Cast<SourceLocation, Location>();
        ImmutableArray<SourceLocation> ISourceSymbol.Locations => Declaration.NameLocations;
        
        public MultiModelFactory ModelFactory => _modelFactory;
        public ModelGroup ModelGroup => _modelGroup;
        public MetaDslx.Modeling.Model Model => _model;
        public IModelObject ModelObject => null;
        public Type ModelObjectType => null;

        public ImmutableArray<NamespaceSymbol> FileNamespaces
        {
            get
            {
                ForceComplete(CompletionGraph.FinishCreatingContainedSymbols, null, default);
                return _fileNamespaces;
            }
        }

        public NamespaceSymbol GetRootNamespace(SyntaxTree syntaxTree)
        {
            if (!DeclaringCompilation.ContainsSyntaxTree(syntaxTree)) throw new ArgumentException(nameof(syntaxTree), "Syntax tree must be from the current compilation.");
            var globalNamespace = GlobalNamespace;
            if (!DeclaringCompilation.Options.MergeGlobalNamespace)
            {
                var index = DeclaringCompilation.GetSyntaxTreeOrdinal(syntaxTree);
                return _fileNamespaces[index];
            }
            return globalNamespace;
        }

        protected override NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var globalNamespace = SymbolFactory.CreateSymbol<NamespaceSymbol>(this, Declaration, diagnostics);
            if (!DeclaringCompilation.Options.MergeGlobalNamespace)
            {
                var fileNamespaces = ArrayBuilder<NamespaceSymbol>.GetInstance();
                foreach (var syntaxTree in DeclaringCompilation.SyntaxTrees)
                {
                    var decl = Declaration.Declarations.FirstOrDefault(d => d.SyntaxReference.SyntaxTree == syntaxTree);
                    Debug.Assert(decl is not null);
                    /*if (decl is not null)
                    {
                        var fileNamespace = SymbolFactory.CreateSymbol<NamespaceSymbol>((ISourceSymbol)globalNamespace, Declaration);
                        fileNamespaces.Add(fileNamespace);
                    }
                    else
                    {*/
                        fileNamespaces.Add(globalNamespace);
                    //}
                }
                _fileNamespaces = fileNamespaces.ToImmutableAndFree();
            }
            return globalNamespace;
        }
    }
}
