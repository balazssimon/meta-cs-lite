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
    public abstract partial class ImportSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts
        {
            public static readonly __CompletionPart Start_Files = new __CompletionPart(nameof(Start_Files));
            public static readonly __CompletionPart Finish_Files = new __CompletionPart(nameof(Finish_Files));
            public static readonly __CompletionPart Start_Aliases = new __CompletionPart(nameof(Start_Aliases));
            public static readonly __CompletionPart Finish_Aliases = new __CompletionPart(nameof(Finish_Aliases));
            public static readonly __CompletionPart Start_Namespaces = new __CompletionPart(nameof(Start_Namespaces));
            public static readonly __CompletionPart Finish_Namespaces = new __CompletionPart(nameof(Finish_Namespaces));
            public static readonly __CompletionPart Start_Symbols = new __CompletionPart(nameof(Start_Symbols));
            public static readonly __CompletionPart Finish_Symbols = new __CompletionPart(nameof(Finish_Symbols));
            public static readonly __CompletionPart Start_ImportedSymbols = new __CompletionPart(nameof(Start_ImportedSymbols));
            public static readonly __CompletionPart Finish_ImportedSymbols = new __CompletionPart(nameof(Finish_ImportedSymbols));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.CompletionGraph
                    , Start_Files, Finish_Files
                    , Start_Aliases, Finish_Aliases
                    , Start_Namespaces, Finish_Namespaces
                    , Start_Symbols, Finish_Symbols
                    , Start_ImportedSymbols, Finish_ImportedSymbols
                );
        }

        private global::System.Collections.Immutable.ImmutableArray<string> _files;
        private global::System.Collections.Immutable.ImmutableArray<AliasSymbol> _aliases;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaces;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _symbols;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _importedSymbols;

        public ImportSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(ImportSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<string> Files
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Files, null, default);
                return _files;
            }
            protected set
            {
                _files = value;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Aliases, null, default);
                return _aliases;
            }
            protected set
            {
                _aliases = value;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Namespaces, null, default);
                return _namespaces;
            }
            protected set
            {
                _namespaces = value;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Symbols, null, default);
                return _symbols;
            }
            protected set
            {
                _symbols = value;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> ImportedSymbols
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ImportedSymbols, null, default);
                return _importedSymbols;
            }
            protected set
            {
                _importedSymbols = value;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_Files || incompletePart == CompletionParts.Finish_Files)
            {
                if (NotePartComplete(CompletionParts.Start_Files))
                {
                    if (_files == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_Files(diagnostics, cancellationToken);
                        _files = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_Files);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Aliases || incompletePart == CompletionParts.Finish_Aliases)
            {
                if (NotePartComplete(CompletionParts.Start_Aliases))
                {
                    if (_aliases == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_Aliases(diagnostics, cancellationToken);
                        _aliases = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_Aliases);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Namespaces || incompletePart == CompletionParts.Finish_Namespaces)
            {
                if (NotePartComplete(CompletionParts.Start_Namespaces))
                {
                    if (_namespaces == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_Namespaces(diagnostics, cancellationToken);
                        _namespaces = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_Namespaces);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Symbols || incompletePart == CompletionParts.Finish_Symbols)
            {
                if (NotePartComplete(CompletionParts.Start_Symbols))
                {
                    if (_symbols == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_Symbols(diagnostics, cancellationToken);
                        _symbols = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_Symbols);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ImportedSymbols || incompletePart == CompletionParts.Finish_ImportedSymbols)
            {
                if (NotePartComplete(CompletionParts.Start_ImportedSymbols))
                {
                    if (_importedSymbols == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_ImportedSymbols(diagnostics, cancellationToken);
                        _importedSymbols = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_ImportedSymbols);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::System.Collections.Immutable.ImmutableArray<string> Compute_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<string>(this, nameof(Files), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Compute_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<AliasSymbol>(this, nameof(Aliases), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Compute_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<NamespaceSymbol>(this, nameof(Namespaces), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Compute_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<DeclarationSymbol>(this, nameof(Symbols), diagnostics, cancellationToken);
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Compute_ImportedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
