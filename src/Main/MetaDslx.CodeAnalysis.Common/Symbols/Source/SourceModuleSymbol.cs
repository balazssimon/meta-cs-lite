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
        private readonly SourceSymbolFactory _symbolFactory;
        private readonly IModelGroup _modelGroup;
        private readonly IModel _model;
        private readonly IMultiModelFactory _modelFactory;
        private readonly DeclarationTable _declarations;

        public SourceModuleSymbol(SourceAssemblySymbol assemblySymbol, SourceSymbolFactory symbolFactory, string moduleName, DeclarationTable declarations)
            : base(assemblySymbol)
        {
            _assemblySymbol = assemblySymbol;
            _symbolFactory = symbolFactory;
            _declarations = declarations;
            var compilation = assemblySymbol.DeclaringCompilation;
            var compilationFactory = compilation.MainLanguage.CompilationFactory;
            _modelFactory = compilationFactory.CreateModelFactory(compilation);
            _model = compilationFactory.CreateModel(compilation);
            _model.Name = moduleName;
        }

        SourceModuleSymbol ISourceSymbol.ContainingModule => null;

        public SourceSymbolFactory SymbolFactory => _symbolFactory;

        public SourceAssemblySymbol SourceAssemblySymbol => _assemblySymbol;
        public override Compilation? DeclaringCompilation => SourceAssemblySymbol.DeclaringCompilation;

        public DeclarationTable DeclarationTable => _declarations;
        public MergedDeclaration Declaration => _declarations.GetMergedRoot(DeclaringCompilation);
        public ImmutableArray<SyntaxNodeOrToken> DeclaringSyntaxReferences => Declaration.SyntaxReferences;
        public override ImmutableArray<Location> Locations => Declaration.NameLocations;

        public IMultiModelFactory ModelFactory => _modelFactory;
        public IModelGroup ModelGroup => _modelGroup;
        public IModel Model => _model;
        public IModelObject ModelObject => null;

        protected override NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateSymbol<NamespaceSymbol>(this, Declaration);
        }
    }
}
