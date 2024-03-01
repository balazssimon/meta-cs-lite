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
    public abstract partial class PReferenceSymbol: global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_Rule = new __CompletionPart(nameof(Start_Rule));
            public static readonly __CompletionPart Finish_Rule = new __CompletionPart(nameof(Finish_Rule));
            public static readonly __CompletionPart Start_ReferencedTypes = new __CompletionPart(nameof(Start_ReferencedTypes));
            public static readonly __CompletionPart Finish_ReferencedTypes = new __CompletionPart(nameof(Finish_ReferencedTypes));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_Rule, Finish_Rule
                    , Start_ReferencedTypes, Finish_ReferencedTypes
                );
        }

        private global::MetaDslx.CodeAnalysis.MetaSymbol _rule;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaType> _referencedTypes;

        public PReferenceSymbol(__Symbol? container, __Compilation? compilation, __MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, __ErrorSymbolInfo? errorInfo) 
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(PReferenceSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::MetaDslx.CodeAnalysis.MetaSymbol Rule
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Rule, null, default);
                return _rule;
            }
        }
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaType> ReferencedTypes
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ReferencedTypes, null, default);
                return _referencedTypes;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_Rule || incompletePart == CompletionParts.Finish_Rule)
            {
                if (NotePartComplete(CompletionParts.Start_Rule))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Rule(diagnostics, cancellationToken);
                    _rule = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Rule);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ReferencedTypes || incompletePart == CompletionParts.Finish_ReferencedTypes)
            {
                if (NotePartComplete(CompletionParts.Start_ReferencedTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ReferencedTypes(diagnostics, cancellationToken);
                    _referencedTypes = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ReferencedTypes);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::MetaDslx.CodeAnalysis.MetaSymbol Compute_Rule(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.MetaSymbol>(this, nameof(Rule), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaType> Compute_ReferencedTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.CodeAnalysis.MetaType>(this, nameof(ReferencedTypes), diagnostics, cancellationToken);
        }
    }
}
