namespace MetaDslx.Bootstrap.MetaCompiler3.Symbols
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
    public abstract partial class AnnotationArgumentSymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts
        {
            public static readonly __CompletionPart Start_AnnotationSymbol = new __CompletionPart(nameof(Start_AnnotationSymbol));
            public static readonly __CompletionPart Finish_AnnotationSymbol = new __CompletionPart(nameof(Finish_AnnotationSymbol));
            public static readonly __CompletionPart Start_IsNamedArgument = new __CompletionPart(nameof(Start_IsNamedArgument));
            public static readonly __CompletionPart Finish_IsNamedArgument = new __CompletionPart(nameof(Finish_IsNamedArgument));
            public static readonly __CompletionPart Start_NamedParameter = new __CompletionPart(nameof(Start_NamedParameter));
            public static readonly __CompletionPart Finish_NamedParameter = new __CompletionPart(nameof(Finish_NamedParameter));
            public static readonly __CompletionPart Start_Parameter = new __CompletionPart(nameof(Start_Parameter));
            public static readonly __CompletionPart Finish_Parameter = new __CompletionPart(nameof(Finish_Parameter));
            public static readonly __CompletionPart Start_Value = new __CompletionPart(nameof(Start_Value));
            public static readonly __CompletionPart Finish_Value = new __CompletionPart(nameof(Finish_Value));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Symbol.CompletionParts.CompletionGraph
                    , Start_AnnotationSymbol, Finish_AnnotationSymbol
                    , Start_IsNamedArgument, Finish_IsNamedArgument
                    , Start_NamedParameter, Finish_NamedParameter
                    , Start_Parameter, Finish_Parameter
                    , Start_Value, Finish_Value
                );
        }

        private AnnotationSymbol? _annotationSymbol;
        private bool _isNamedArgument;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> _namedParameter;
        private global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol _parameter;
        private global::MetaDslx.CodeAnalysis.MetaType _parameterType;
        private ExpressionSymbol _value;

        public AnnotationArgumentSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(AnnotationArgumentSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__PhaseAttribute]
        [__DerivedAttribute]
        public AnnotationSymbol? AnnotationSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_AnnotationSymbol, null, default);
                return _annotationSymbol;
            }
            protected set
            {
                _annotationSymbol = value;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public bool IsNamedArgument
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsNamedArgument, null, default);
                return _isNamedArgument;
            }
            protected set
            {
                _isNamedArgument = value;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> NamedParameter
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_NamedParameter, null, default);
                return _namedParameter;
            }
            protected set
            {
                _namedParameter = value;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol Parameter
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Parameter, null, default);
                return _parameter;
            }
            protected set
            {
                _parameter = value;
            }
        }
        [__PhaseAttribute(nameof(Parameter))]
        [__DerivedAttribute]
        public global::MetaDslx.CodeAnalysis.MetaType ParameterType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Parameter, null, default);
                return _parameterType;
            }
            protected set
            {
                _parameterType = value;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public ExpressionSymbol Value
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Value, null, default);
                return _value;
            }
            protected set
            {
                _value = value;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_AnnotationSymbol || incompletePart == CompletionParts.Finish_AnnotationSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_AnnotationSymbol))
                {
                    if (_annotationSymbol == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_AnnotationSymbol(diagnostics, cancellationToken);
                        _annotationSymbol = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_AnnotationSymbol);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_IsNamedArgument || incompletePart == CompletionParts.Finish_IsNamedArgument)
            {
                if (NotePartComplete(CompletionParts.Start_IsNamedArgument))
                {
                    if (_isNamedArgument == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_IsNamedArgument(diagnostics, cancellationToken);
                        _isNamedArgument = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_IsNamedArgument);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_NamedParameter || incompletePart == CompletionParts.Finish_NamedParameter)
            {
                if (NotePartComplete(CompletionParts.Start_NamedParameter))
                {
                    if (_namedParameter == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_NamedParameter(diagnostics, cancellationToken);
                        _namedParameter = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_NamedParameter);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Parameter || incompletePart == CompletionParts.Finish_Parameter)
            {
                if (NotePartComplete(CompletionParts.Start_Parameter))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Parameter(diagnostics, cancellationToken);
                    if (_parameter == default)
                    {
                        _parameter = result.Parameter;
                    }
                    if (_parameterType == default)
                    {
                        _parameterType = result.ParameterType;
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Parameter);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Value || incompletePart == CompletionParts.Finish_Value)
            {
                if (NotePartComplete(CompletionParts.Start_Value))
                {
                    if (_value == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_Value(diagnostics, cancellationToken);
                        _value = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_Value);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected abstract AnnotationSymbol? Compute_AnnotationSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract bool Compute_IsNamedArgument(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaSymbol> Compute_NamedParameter(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.CodeAnalysis.MetaSymbol>(this, nameof(NamedParameter), diagnostics, cancellationToken);
        }

        protected abstract (global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol Parameter, global::MetaDslx.CodeAnalysis.MetaType ParameterType) Compute_Parameter(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected virtual ExpressionSymbol Compute_Value(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<ExpressionSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }
    }
}
