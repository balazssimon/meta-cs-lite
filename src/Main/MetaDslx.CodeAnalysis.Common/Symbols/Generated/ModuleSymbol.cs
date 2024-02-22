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

    public abstract partial class ModuleSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts
        {
            public static readonly __CompletionPart Start_SymbolFactory = new __CompletionPart(nameof(Start_SymbolFactory));
            public static readonly __CompletionPart Finish_SymbolFactory = new __CompletionPart(nameof(Finish_SymbolFactory));
            public static readonly __CompletionPart Start_GlobalNamespace = new __CompletionPart(nameof(Start_GlobalNamespace));
            public static readonly __CompletionPart Finish_GlobalNamespace = new __CompletionPart(nameof(Finish_GlobalNamespace));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.CompletionGraph
                    , Start_SymbolFactory, Finish_SymbolFactory
                    , Start_GlobalNamespace, Finish_GlobalNamespace
                );
        }

        private global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory _symbolFactory;
        private NamespaceSymbol _globalNamespace;

        public ModuleSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory symbolFactory = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
        {
            if (fixedSymbol)
            {
                _symbolFactory = symbolFactory;
            }
        }

        [__ModelProperty]
        public global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory SymbolFactory
        {
            get => _symbolFactory;
            protected set => _symbolFactory = value;
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


        public abstract global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol? GetRootNamespace(global::MetaDslx.CodeAnalysis.SyntaxTree syntaxTree);

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

        protected abstract NamespaceSymbol Compute_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
