namespace MetaDslx.Languages.MetaCompiler.Symbols
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
    public abstract partial class AnnotationSymbol: global::MetaDslx.CodeAnalysis.Symbols.Implementation.AttributeSymbolImpl
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Implementation.AttributeSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_Arguments = new __CompletionPart(nameof(Start_Arguments));
            public static readonly __CompletionPart Finish_Arguments = new __CompletionPart(nameof(Finish_Arguments));
            public static readonly __CompletionPart Start_Constructors = new __CompletionPart(nameof(Start_Constructors));
            public static readonly __CompletionPart Finish_Constructors = new __CompletionPart(nameof(Finish_Constructors));
            public static readonly __CompletionPart Start_Parameters = new __CompletionPart(nameof(Start_Parameters));
            public static readonly __CompletionPart Finish_Parameters = new __CompletionPart(nameof(Finish_Parameters));
            public static readonly __CompletionPart Start_SelectedConstructor = new __CompletionPart(nameof(Start_SelectedConstructor));
            public static readonly __CompletionPart Finish_SelectedConstructor = new __CompletionPart(nameof(Finish_SelectedConstructor));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Implementation.AttributeSymbolImpl.CompletionParts.CompletionGraph
                    , Start_Arguments, Finish_Arguments
                    , Start_Constructors, Finish_Constructors
                    , Start_Parameters, Finish_Parameters
                    , Start_SelectedConstructor, Finish_SelectedConstructor
                );
        }

        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Languages.MetaCompiler.Symbols.AnnotationArgumentSymbol> _arguments;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol> _constructors;
        private global::System.Collections.Immutable.ImmutableArray<global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol>> _parameters;
        private global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol _selectedConstructor;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol> _selectedParameters;

        public AnnotationSymbol(__Symbol? container, __Compilation? compilation, __MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, __ErrorSymbolInfo? errorInfo) 
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(AnnotationSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Languages.MetaCompiler.Symbols.AnnotationArgumentSymbol> Arguments
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Arguments, null, default);
                return _arguments;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol> Constructors
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Constructors, null, default);
                return _constructors;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol>> Parameters
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Parameters, null, default);
                return _parameters;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol SelectedConstructor
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_SelectedConstructor, null, default);
                return _selectedConstructor;
            }
        }
        [__PhaseAttribute(nameof(SelectedConstructor))]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol> SelectedParameters
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_SelectedConstructor, null, default);
                return _selectedParameters;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_Arguments || incompletePart == CompletionParts.Finish_Arguments)
            {
                if (NotePartComplete(CompletionParts.Start_Arguments))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Arguments(diagnostics, cancellationToken);
                    _arguments = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Arguments);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Constructors || incompletePart == CompletionParts.Finish_Constructors)
            {
                if (NotePartComplete(CompletionParts.Start_Constructors))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Constructors(diagnostics, cancellationToken);
                    _constructors = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Constructors);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Parameters || incompletePart == CompletionParts.Finish_Parameters)
            {
                if (NotePartComplete(CompletionParts.Start_Parameters))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Parameters(diagnostics, cancellationToken);
                    _parameters = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Parameters);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_SelectedConstructor || incompletePart == CompletionParts.Finish_SelectedConstructor)
            {
                if (NotePartComplete(CompletionParts.Start_SelectedConstructor))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_SelectedConstructor(diagnostics, cancellationToken);
                    _selectedConstructor = result.SelectedConstructor;
                    _selectedParameters = result.SelectedParameters;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_SelectedConstructor);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Languages.MetaCompiler.Symbols.AnnotationArgumentSymbol> Compute_Arguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.Languages.MetaCompiler.Symbols.AnnotationArgumentSymbol>(this, nameof(Arguments), diagnostics, cancellationToken);
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol> Compute_Constructors(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol>> Compute_Parameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract (global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol SelectedConstructor, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol> SelectedParameters) Compute_SelectedConstructor(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
