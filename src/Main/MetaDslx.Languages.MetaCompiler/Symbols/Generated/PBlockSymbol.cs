#pragma warning disable CS8669
#pragma warning disable CS0108

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
    public abstract partial class PBlockSymbol: global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_ExpectedType = new __CompletionPart(nameof(Start_ExpectedType));
            public static readonly __CompletionPart Finish_ExpectedType = new __CompletionPart(nameof(Finish_ExpectedType));
            public static readonly __CompletionPart Start_Alternatives = new __CompletionPart(nameof(Start_Alternatives));
            public static readonly __CompletionPart Finish_Alternatives = new __CompletionPart(nameof(Finish_Alternatives));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_ExpectedType, Finish_ExpectedType
                    , Start_Alternatives, Finish_Alternatives
                );
        }

        private global::MetaDslx.CodeAnalysis.MetaType _expectedType;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Languages.MetaCompiler.Symbols.PAlternativeSymbol> _alternatives;

        public PBlockSymbol(__Symbol? container, __Compilation? compilation, __MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, __ErrorSymbolInfo? errorInfo) 
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(PBlockSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

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
        [__ModelPropertyAttribute]
        [__PhaseAttribute]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Languages.MetaCompiler.Symbols.PAlternativeSymbol> Alternatives
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Alternatives, null, default);
                return _alternatives;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_ExpectedType || incompletePart == CompletionParts.Finish_ExpectedType)
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
            else if (incompletePart == CompletionParts.Start_Alternatives || incompletePart == CompletionParts.Finish_Alternatives)
            {
                if (NotePartComplete(CompletionParts.Start_Alternatives))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Alternatives(diagnostics, cancellationToken);
                    _alternatives = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Alternatives);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected abstract global::MetaDslx.CodeAnalysis.MetaType Compute_ExpectedType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Languages.MetaCompiler.Symbols.PAlternativeSymbol> Compute_Alternatives(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.Languages.MetaCompiler.Symbols.PAlternativeSymbol>(this, nameof(Alternatives), diagnostics, cancellationToken);
        }
    }
}
