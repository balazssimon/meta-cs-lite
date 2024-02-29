namespace MetaDslx.CodeAnalysis.Symbols
{
    using __Type = global::System.Type;
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __SymbolAttribute = global::MetaDslx.CodeAnalysis.Symbols.SymbolAttribute;
    using __PhaseAttribute = global::MetaDslx.CodeAnalysis.Symbols.PhaseAttribute;
    using __DerivedAttribute = global::MetaDslx.CodeAnalysis.Symbols.DerivedAttribute;
    using __WeakAttribute = global::MetaDslx.CodeAnalysis.Symbols.WeakAttribute;
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
    using __ModelPropertyAttribute = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;
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

    [__SymbolAttribute]
    public abstract partial class ImportMetaModelSymbol: Impl.ImportSymbolImpl
    {
        public new class CompletionParts : Impl.ImportSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_MetaModelSymbols = new __CompletionPart(nameof(Start_MetaModelSymbols));
            public static readonly __CompletionPart Finish_MetaModelSymbols = new __CompletionPart(nameof(Finish_MetaModelSymbols));
            public static readonly __CompletionPart Start_MetaModels = new __CompletionPart(nameof(Start_MetaModels));
            public static readonly __CompletionPart Finish_MetaModels = new __CompletionPart(nameof(Finish_MetaModels));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    Impl.ImportSymbolImpl.CompletionParts.CompletionGraph
                    , Start_MetaModelSymbols, Finish_MetaModelSymbols
                    , Start_MetaModels, Finish_MetaModels
                );
        }

        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> _metaModelSymbols;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> _metaModels;

        public ImportMetaModelSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(ImportMetaModelSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> MetaModelSymbols
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_MetaModelSymbols, null, default);
                return _metaModelSymbols;
            }
            protected set
            {
                _metaModelSymbols = value;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> MetaModels
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_MetaModels, null, default);
                return _metaModels;
            }
            protected set
            {
                _metaModels = value;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_MetaModelSymbols || incompletePart == CompletionParts.Finish_MetaModelSymbols)
            {
                if (NotePartComplete(CompletionParts.Start_MetaModelSymbols))
                {
                    if (_metaModelSymbols == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_MetaModelSymbols(diagnostics, cancellationToken);
                        _metaModelSymbols = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_MetaModelSymbols);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_MetaModels || incompletePart == CompletionParts.Finish_MetaModels)
            {
                if (NotePartComplete(CompletionParts.Start_MetaModels))
                {
                    if (_metaModels == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_MetaModels(diagnostics, cancellationToken);
                        _metaModels = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_MetaModels);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> Compute_MetaModelSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.CodeAnalysis.MetaSymbol>(this, nameof(MetaModelSymbols), diagnostics, cancellationToken);
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> Compute_MetaModels(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
