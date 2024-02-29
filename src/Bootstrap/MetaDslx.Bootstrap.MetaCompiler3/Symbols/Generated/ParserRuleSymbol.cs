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
    public abstract partial class ParserRuleSymbol: global::MetaDslx.CodeAnalysis.Symbols.Impl.DeclarationSymbolImpl
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Impl.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_ReturnType = new __CompletionPart(nameof(Start_ReturnType));
            public static readonly __CompletionPart Finish_ReturnType = new __CompletionPart(nameof(Finish_ReturnType));
            public static readonly __CompletionPart Start_Alternatives = new __CompletionPart(nameof(Start_Alternatives));
            public static readonly __CompletionPart Finish_Alternatives = new __CompletionPart(nameof(Finish_Alternatives));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Impl.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_ReturnType, Finish_ReturnType
                    , Start_Alternatives, Finish_Alternatives
                );
        }

        private global::MetaDslx.CodeAnalysis.MetaType _returnType;
        private global::System.Collections.Immutable.ImmutableArray<PAlternativeSymbol> _alternatives;

        public ParserRuleSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(ParserRuleSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::MetaDslx.CodeAnalysis.MetaType ReturnType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ReturnType, null, default);
                return _returnType;
            }
            protected set
            {
                _returnType = value;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<PAlternativeSymbol> Alternatives
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Alternatives, null, default);
                return _alternatives;
            }
            protected set
            {
                _alternatives = value;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_ReturnType || incompletePart == CompletionParts.Finish_ReturnType)
            {
                if (NotePartComplete(CompletionParts.Start_ReturnType))
                {
                    if (_returnType == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_ReturnType(diagnostics, cancellationToken);
                        _returnType = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_ReturnType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Alternatives || incompletePart == CompletionParts.Finish_Alternatives)
            {
                if (NotePartComplete(CompletionParts.Start_Alternatives))
                {
                    if (_alternatives == default)
                    {
                        var diagnostics = __DiagnosticBag.GetInstance();
                        var result = Compute_Alternatives(diagnostics, cancellationToken);
                        _alternatives = result;
                        AddSymbolDiagnostics(diagnostics);
                        diagnostics.Free();
                    }
                    NotePartComplete(CompletionParts.Finish_Alternatives);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::MetaDslx.CodeAnalysis.MetaType Compute_ReturnType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.MetaType>(this, nameof(ReturnType), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<PAlternativeSymbol> Compute_Alternatives(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PAlternativeSymbol>(this, nameof(Alternatives), diagnostics, cancellationToken);
        }
    }
}
