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
    public abstract partial class PAlternativeSymbol: global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_ContainingParserRuleSymbol = new __CompletionPart(nameof(Start_ContainingParserRuleSymbol));
            public static readonly __CompletionPart Finish_ContainingParserRuleSymbol = new __CompletionPart(nameof(Finish_ContainingParserRuleSymbol));
            public static readonly __CompletionPart Start_ContainingPBlockSymbol = new __CompletionPart(nameof(Start_ContainingPBlockSymbol));
            public static readonly __CompletionPart Finish_ContainingPBlockSymbol = new __CompletionPart(nameof(Finish_ContainingPBlockSymbol));
            public static readonly __CompletionPart Start_Elements = new __CompletionPart(nameof(Start_Elements));
            public static readonly __CompletionPart Finish_Elements = new __CompletionPart(nameof(Finish_Elements));
            public static readonly __CompletionPart Start_ReturnValue = new __CompletionPart(nameof(Start_ReturnValue));
            public static readonly __CompletionPart Finish_ReturnValue = new __CompletionPart(nameof(Finish_ReturnValue));
            public static readonly __CompletionPart Start_ReturnType = new __CompletionPart(nameof(Start_ReturnType));
            public static readonly __CompletionPart Finish_ReturnType = new __CompletionPart(nameof(Finish_ReturnType));
            public static readonly __CompletionPart Start_ExpectedType = new __CompletionPart(nameof(Start_ExpectedType));
            public static readonly __CompletionPart Finish_ExpectedType = new __CompletionPart(nameof(Finish_ExpectedType));
            public static readonly __CompletionPart Start_AllSimpleElements = new __CompletionPart(nameof(Start_AllSimpleElements));
            public static readonly __CompletionPart Finish_AllSimpleElements = new __CompletionPart(nameof(Finish_AllSimpleElements));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_ContainingParserRuleSymbol, Finish_ContainingParserRuleSymbol
                    , Start_ContainingPBlockSymbol, Finish_ContainingPBlockSymbol
                    , Start_Elements, Finish_Elements
                    , Start_ReturnValue, Finish_ReturnValue
                    , Start_ReturnType, Finish_ReturnType
                    , Start_ExpectedType, Finish_ExpectedType
                    , Start_AllSimpleElements, Finish_AllSimpleElements
                );
        }

        private ParserRuleSymbol? _containingParserRuleSymbol;
        private PBlockSymbol? _containingPBlockSymbol;
        private global::System.Collections.Immutable.ImmutableArray<PElementSymbol> _elements;
        private ExpressionSymbol? _returnValue;
        private global::MetaDslx.CodeAnalysis.MetaType _returnType;
        private global::MetaDslx.CodeAnalysis.MetaType _expectedType;
        private global::System.Collections.Immutable.ImmutableArray<PElementSymbol> _allSimpleElements;

        public PAlternativeSymbol(__Symbol? container, __Compilation? compilation, __MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, __ErrorSymbolInfo? errorInfo) 
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(PAlternativeSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__PhaseAttribute]
        [__DerivedAttribute]
        public ParserRuleSymbol? ContainingParserRuleSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingParserRuleSymbol, null, default);
                return _containingParserRuleSymbol;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public PBlockSymbol? ContainingPBlockSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingPBlockSymbol, null, default);
                return _containingPBlockSymbol;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<PElementSymbol> Elements
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Elements, null, default);
                return _elements;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public ExpressionSymbol? ReturnValue
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ReturnValue, null, default);
                return _returnValue;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::MetaDslx.CodeAnalysis.MetaType ReturnType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ReturnType, null, default);
                return _returnType;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::MetaDslx.CodeAnalysis.MetaType ExpectedType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ExpectedType, null, default);
                return _expectedType;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<PElementSymbol> AllSimpleElements
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_AllSimpleElements, null, default);
                return _allSimpleElements;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_ContainingParserRuleSymbol || incompletePart == CompletionParts.Finish_ContainingParserRuleSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingParserRuleSymbol))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ContainingParserRuleSymbol(diagnostics, cancellationToken);
                    _containingParserRuleSymbol = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingParserRuleSymbol);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ContainingPBlockSymbol || incompletePart == CompletionParts.Finish_ContainingPBlockSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingPBlockSymbol))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ContainingPBlockSymbol(diagnostics, cancellationToken);
                    _containingPBlockSymbol = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingPBlockSymbol);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Elements || incompletePart == CompletionParts.Finish_Elements)
            {
                if (NotePartComplete(CompletionParts.Start_Elements))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Elements(diagnostics, cancellationToken);
                    _elements = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Elements);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ReturnValue || incompletePart == CompletionParts.Finish_ReturnValue)
            {
                if (NotePartComplete(CompletionParts.Start_ReturnValue))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ReturnValue(diagnostics, cancellationToken);
                    _returnValue = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ReturnValue);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ReturnType || incompletePart == CompletionParts.Finish_ReturnType)
            {
                if (NotePartComplete(CompletionParts.Start_ReturnType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ReturnType(diagnostics, cancellationToken);
                    _returnType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ReturnType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ExpectedType || incompletePart == CompletionParts.Finish_ExpectedType)
            {
                if (NotePartComplete(CompletionParts.Start_ExpectedType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ExpectedType(diagnostics, cancellationToken);
                    _expectedType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ExpectedType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_AllSimpleElements || incompletePart == CompletionParts.Finish_AllSimpleElements)
            {
                if (NotePartComplete(CompletionParts.Start_AllSimpleElements))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_AllSimpleElements(diagnostics, cancellationToken);
                    _allSimpleElements = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_AllSimpleElements);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected abstract ParserRuleSymbol? Compute_ContainingParserRuleSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract PBlockSymbol? Compute_ContainingPBlockSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected virtual global::System.Collections.Immutable.ImmutableArray<PElementSymbol> Compute_Elements(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PElementSymbol>(this, nameof(Elements), diagnostics, cancellationToken);
        }

        protected virtual ExpressionSymbol? Compute_ReturnValue(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<ExpressionSymbol>(this, nameof(ReturnValue), diagnostics, cancellationToken);
        }

        protected abstract global::MetaDslx.CodeAnalysis.MetaType Compute_ReturnType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.MetaType Compute_ExpectedType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<PElementSymbol> Compute_AllSimpleElements(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
