namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    using global::MetaDslx.CodeAnalysis.Symbols;
    using __Type = global::System.Type;
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

    public abstract partial class ExpressionSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts
        {
            public static readonly __CompletionPart Start_ContainingPAlternativeSymbol = new __CompletionPart(nameof(Start_ContainingPAlternativeSymbol));
            public static readonly __CompletionPart Finish_ContainingPAlternativeSymbol = new __CompletionPart(nameof(Finish_ContainingPAlternativeSymbol));
            public static readonly __CompletionPart Start_ContainingAnnotationArgumentSymbol = new __CompletionPart(nameof(Start_ContainingAnnotationArgumentSymbol));
            public static readonly __CompletionPart Finish_ContainingAnnotationArgumentSymbol = new __CompletionPart(nameof(Finish_ContainingAnnotationArgumentSymbol));
            public static readonly __CompletionPart Start_ExpectedType = new __CompletionPart(nameof(Start_ExpectedType));
            public static readonly __CompletionPart Finish_ExpectedType = new __CompletionPart(nameof(Finish_ExpectedType));
            public static readonly __CompletionPart Start_Value = new __CompletionPart(nameof(Start_Value));
            public static readonly __CompletionPart Finish_Value = new __CompletionPart(nameof(Finish_Value));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.CompletionGraph
                    , Start_ContainingPAlternativeSymbol, Finish_ContainingPAlternativeSymbol
                    , Start_ContainingAnnotationArgumentSymbol, Finish_ContainingAnnotationArgumentSymbol
                    , Start_ExpectedType, Finish_ExpectedType
                    , Start_Value, Finish_Value
                );
        }

        private PAlternativeSymbol? _containingPAlternativeSymbol;
        private AnnotationArgumentSymbol? _containingAnnotationArgumentSymbol;
        private global::MetaDslx.CodeAnalysis.MetaType _expectedType;
        private global::MetaDslx.CodeAnalysis.MetaSymbol _value;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> _values;

        public ExpressionSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
        {
            if (fixedSymbol)
            {
            }
        }

        public override __Type SymbolType => typeof(ExpressionSymbol);
        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__Phase]
        [__Derived]
        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingPAlternativeSymbol, null, default);
                return _containingPAlternativeSymbol;
            }
        }
        [__Phase]
        [__Derived]
        public AnnotationArgumentSymbol? ContainingAnnotationArgumentSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingAnnotationArgumentSymbol, null, default);
                return _containingAnnotationArgumentSymbol;
            }
        }
        [__Phase]
        [__Derived]
        public global::MetaDslx.CodeAnalysis.MetaType ExpectedType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ExpectedType, null, default);
                return _expectedType;
            }
        }
        [__Phase]
        [__Derived]
        public global::MetaDslx.CodeAnalysis.MetaSymbol Value
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Value, null, default);
                return _value;
            }
        }
        [__Phase(nameof(Value))]
        [__Derived]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> Values
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Value, null, default);
                return _values;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_ContainingPAlternativeSymbol || incompletePart == CompletionParts.Finish_ContainingPAlternativeSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingPAlternativeSymbol))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ContainingPAlternativeSymbol(diagnostics, cancellationToken);
                    _containingPAlternativeSymbol = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingPAlternativeSymbol);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ContainingAnnotationArgumentSymbol || incompletePart == CompletionParts.Finish_ContainingAnnotationArgumentSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingAnnotationArgumentSymbol))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ContainingAnnotationArgumentSymbol(diagnostics, cancellationToken);
                    _containingAnnotationArgumentSymbol = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingAnnotationArgumentSymbol);
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
            else if (incompletePart == CompletionParts.Start_Value || incompletePart == CompletionParts.Finish_Value)
            {
                if (NotePartComplete(CompletionParts.Start_Value))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Value(diagnostics, cancellationToken);
                    _value = result.Value;
                    _values = result.Values;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Value);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected abstract PAlternativeSymbol? Compute_ContainingPAlternativeSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract AnnotationArgumentSymbol? Compute_ContainingAnnotationArgumentSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.MetaType Compute_ExpectedType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract (global::MetaDslx.CodeAnalysis.MetaSymbol Value, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> Values) Compute_Value(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}