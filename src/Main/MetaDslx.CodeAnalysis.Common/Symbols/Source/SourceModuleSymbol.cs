using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceModuleSymbol : ModuleSymbol, ISourceSymbol
    {
        private readonly SourceAssemblySymbol _assemblySymbol;
        private readonly IModelGroup _modelGroup;
        private readonly IModel _model;
        private readonly IMultiModelFactory _modelFactory;
        private readonly DeclarationTable _declarations;
        private SourceNamespaceSymbol? _globalNamespace;

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

        public SourceAssemblySymbol SourceAssemblySymbol => _assemblySymbol;

        public override Compilation? DeclaringCompilation => SourceAssemblySymbol.DeclaringCompilation;

        public DeclarationTable DeclarationTable => _declarations;

        public MergedDeclaration Declaration => _declarations.GetMergedRoot(DeclaringCompilation);

        public override ImmutableArray<Location> Locations => Declaration.NameLocations;

        public override ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => Declaration.SyntaxReferences;

        public IModelGroup ModelGroup => _modelGroup;

        public IMultiModelFactory ModelFactory => _modelFactory;

        public IModel Model => _model;

        public IModelObject ModelObject => null;

        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                ForceComplete(CompletionGraph.FinishInitializing, null, default);
                return _globalNamespace;
            }
        }

        protected override void CompletePart_InitializeSymbol(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (_globalNamespace is null)
            {
                var rootObject = ModelFactory.Create(Model, Declaration.ModelObjectType);
                var globalNS = new SourceNamespaceSymbol(this, Declaration, rootObject);
                Interlocked.CompareExchange(ref _globalNamespace, globalNS, null);
            }
        }
    }
}
