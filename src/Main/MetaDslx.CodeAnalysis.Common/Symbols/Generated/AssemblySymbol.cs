namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __Phase = global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;
    using __Derived = global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;
    using __Weak = global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;
    using __Symbol = global::MetaDslx.CodeAnalysis.Symbols.Symbol;
    using __AttributeSymbol = global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;
    using __AssemblySymbol = global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;
    using __ModuleSymbol = global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;
    using __DeclarationSymbol = global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;
    using __NamespaceSymbol = global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;
    using __TypeSymbol = global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;
    using __ISymbolFactory = global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;
    using __LexicalSortKey = global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __Model = global::MetaDslx.Modeling.Model;
    using __ErrorSymbolInfo = global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;
    using __CompletionGraph = global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;
    using __CompletionPart = global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;
    using __MergedDeclaration = global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;
    using __DiagnosticBag = global::MetaDslx.CodeAnalysis.DiagnosticBag;
    using __Compilation = global::MetaDslx.CodeAnalysis.Compilation;
    using __SourceLocation = global::MetaDslx.CodeAnalysis.SourceLocation;
    using __CancellationToken = global::System.Threading.CancellationToken;
    using __NotImplementedException = global::System.NotImplementedException;
    using __CultureInfo = global::System.Globalization.CultureInfo;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    public abstract partial class AssemblySymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts
        {
            public static readonly __CompletionPart Start_SymbolFactory = new __CompletionPart(nameof(Start_SymbolFactory));
            public static readonly __CompletionPart Finish_SymbolFactory = new __CompletionPart(nameof(Finish_SymbolFactory));
            public static readonly __CompletionPart Start_SourceModule = new __CompletionPart(nameof(Start_SourceModule));
            public static readonly __CompletionPart Finish_SourceModule = new __CompletionPart(nameof(Finish_SourceModule));
            public static readonly __CompletionPart Start_Modules = new __CompletionPart(nameof(Start_Modules));
            public static readonly __CompletionPart Finish_Modules = new __CompletionPart(nameof(Finish_Modules));
            public static readonly __CompletionPart Start_IsCorLibrary = new __CompletionPart(nameof(Start_IsCorLibrary));
            public static readonly __CompletionPart Finish_IsCorLibrary = new __CompletionPart(nameof(Finish_IsCorLibrary));
            public static readonly __CompletionPart Start_GlobalNamespace = new __CompletionPart(nameof(Start_GlobalNamespace));
            public static readonly __CompletionPart Finish_GlobalNamespace = new __CompletionPart(nameof(Finish_GlobalNamespace));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.CompletionGraph
                    , Start_SymbolFactory, Finish_SymbolFactory
                    , Start_SourceModule, Finish_SourceModule
                    , Start_Modules, Finish_Modules
                    , Start_IsCorLibrary, Finish_IsCorLibrary
                    , Start_GlobalNamespace, Finish_GlobalNamespace
                );
        }

        private global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory _symbolFactory;
        private ModuleSymbol? _sourceModule;
        private global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> _modules;
        private bool _isCorLibrary;
        private NamespaceSymbol _globalNamespace;

        public AssemblySymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory symbolFactory = default, ModuleSymbol? sourceModule = default, global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> modules = default, bool isCorLibrary = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
        {
            if (fixedSymbol)
            {
                _symbolFactory = symbolFactory;
                _sourceModule = sourceModule;
                _modules = modules;
                _isCorLibrary = isCorLibrary;
            }
        }

        [__ModelProperty]
        public global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory SymbolFactory
        {
            get => _symbolFactory;
            protected set => _symbolFactory = value;
        }
        [__ModelProperty]
        public ModuleSymbol? SourceModule
        {
            get => _sourceModule;
            protected set => _sourceModule = value;
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules
        {
            get => _modules;
            protected set => _modules = value;
        }
        [__ModelProperty]
[__Phase]
        public bool IsCorLibrary
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsCorLibrary, null, default);
                return _isCorLibrary;
            }
        }
[__Phase]
[__Derived]
        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_GlobalNamespace, null, default);
                return _globalNamespace;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_SymbolFactory || incompletePart == CompletionParts.Finish_SymbolFactory)
            {
                if (NotePartComplete(CompletionParts.Start_SymbolFactory))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_SymbolFactory(diagnostics, cancellationToken);
                    _symbolFactory = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_SymbolFactory);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_SourceModule || incompletePart == CompletionParts.Finish_SourceModule)
            {
                if (NotePartComplete(CompletionParts.Start_SourceModule))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_SourceModule(diagnostics, cancellationToken);
                    _sourceModule = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_SourceModule);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Modules || incompletePart == CompletionParts.Finish_Modules)
            {
                if (NotePartComplete(CompletionParts.Start_Modules))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Modules(diagnostics, cancellationToken);
                    _modules = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Modules);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_IsCorLibrary || incompletePart == CompletionParts.Finish_IsCorLibrary)
            {
                if (NotePartComplete(CompletionParts.Start_IsCorLibrary))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_IsCorLibrary(diagnostics, cancellationToken);
                    _isCorLibrary = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsCorLibrary);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_GlobalNamespace || incompletePart == CompletionParts.Finish_GlobalNamespace)
            {
                if (NotePartComplete(CompletionParts.Start_GlobalNamespace))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_GlobalNamespace(diagnostics, cancellationToken);
                    _globalNamespace = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_GlobalNamespace);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory Compute_SymbolFactory(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory>(this, nameof(SymbolFactory), diagnostics, cancellationToken);
        }

        protected virtual ModuleSymbol? Compute_SourceModule(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<ModuleSymbol>(this, nameof(SourceModule), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Compute_Modules(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<ModuleSymbol>(this, nameof(Modules), diagnostics, cancellationToken);
        }

        protected virtual bool Compute_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsCorLibrary), diagnostics, cancellationToken);
        }

        protected abstract NamespaceSymbol Compute_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
