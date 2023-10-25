using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Model;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;
using System.Xml.Linq;

namespace MetaDslx.CodeAnalysis.Symbols.Source
{
    public class SourceModuleSymbol : ModuleSymbol, ISourceSymbol, IModelSymbol
    {
        private readonly SourceAssemblySymbol _assemblySymbol;
        private SourceSymbolFactory _symbolFactory;
        private readonly IModelGroup _modelGroup;
        private readonly IModel _model;
        private readonly IMultiModelFactory _modelFactory;
        private readonly DeclarationTable _declarations;

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
        
        public IMultiModelFactory ModelFactory => _modelFactory;
        public IModelGroup ModelGroup => _modelGroup;
        public IModel Model => _model;
        public IModelObject ModelObject => null;
        public Type ModelObjectType => null;

        protected override NamespaceSymbol CompleteProperty_GlobalNamespace(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.CreateSymbol<NamespaceSymbol>(this, Declaration);
        }
    }
}
