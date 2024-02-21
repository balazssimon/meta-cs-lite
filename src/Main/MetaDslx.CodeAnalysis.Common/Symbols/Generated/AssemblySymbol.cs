namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
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

public abstract partial class AssemblySymbol: global::MetaDslx.CodeAnalysis.Symbols.Symbol
    {
        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_IsCorLibrary = new CompletionPart(nameof(Start_IsCorLibrary));
            public static readonly CompletionPart Finish_IsCorLibrary = new CompletionPart(nameof(Finish_IsCorLibrary));
            public static readonly CompletionPart Start_GlobalNamespace = new CompletionPart(nameof(Start_GlobalNamespace));
            public static readonly CompletionPart Finish_GlobalNamespace = new CompletionPart(nameof(Finish_GlobalNamespace));
            public static readonly CompletionPart Start_Attributes = new CompletionPart(nameof(Start_Attributes));
            public static readonly CompletionPart Finish_Attributes = new CompletionPart(nameof(Finish_Attributes));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_IsCorLibrary, Finish_IsCorLibrary,
                    Start_GlobalNamespace, Finish_GlobalNamespace,
                    Start_Attributes, Finish_Attributes
                );
        }

        private bool _isCorLibrary;
        private NamespaceSymbol _globalNamespace;

        public AssemblySymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, bool isCorLibrary = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
        {
            if (fixedSymbol)
            {
                _isCorLibrary = isCorLibrary;
            }
        }

        [__ModelProperty]
        public bool IsCorLibrary
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsCorLibrary, null, default);
                return _isCorLibrary;
            }
        }
        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_GlobalNamespace, null, default);
                return _globalNamespace;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_IsCorLibrary || incompletePart == CompletionParts.Finish_IsCorLibrary)
            {
                if (NotePartComplete(CompletionParts.Start_IsCorLibrary))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsCorLibrary(diagnostics, cancellationToken);
                    _isCorLibrary = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsCorLibrary);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_GlobalNamespace || incompletePart == CompletionParts.Finish_GlobalNamespace)
            {
                if (NotePartComplete(CompletionParts.Start_GlobalNamespace))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_GlobalNamespace(diagnostics, cancellationToken);
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


        protected virtual bool Complete_IsCorLibrary(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsCorLibrary), diagnostics, cancellationToken);
        }

        protected abstract NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
