#pragma warning disable CS8669
#pragma warning disable CS0108

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
    public abstract partial class NamespaceSymbol: global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl
    {
        public new class CompletionParts : global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_ConstituentNamespaces = new __CompletionPart(nameof(Start_ConstituentNamespaces));
            public static readonly __CompletionPart Finish_ConstituentNamespaces = new __CompletionPart(nameof(Finish_ConstituentNamespaces));
            public static readonly __CompletionPart Start_NamespaceMembers = new __CompletionPart(nameof(Start_NamespaceMembers));
            public static readonly __CompletionPart Finish_NamespaceMembers = new __CompletionPart(nameof(Finish_NamespaceMembers));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    global::MetaDslx.CodeAnalysis.Symbols.Implementation.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_ConstituentNamespaces, Finish_ConstituentNamespaces
                    , Start_NamespaceMembers, Finish_NamespaceMembers
                );
        }

        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _constituentNamespaces;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaceMembers;

        public NamespaceSymbol(__Symbol? container, __Compilation? compilation, __MergedDeclaration? declaration, __IModelObject? modelObject, __ISymbol? csharpSymbol, __ErrorSymbolInfo? errorInfo) 
            : base(container, compilation, declaration, modelObject, csharpSymbol, errorInfo)
        {
        }

        public override __Type SymbolType => typeof(NamespaceSymbol);
        protected override __CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public abstract global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Extent
        {
            get;
        }
        public abstract bool IsGlobalNamespace
        {
            get;
        }
        public abstract global::MetaDslx.CodeAnalysis.NamespaceKind NamespaceKind
        {
            get;
        }
        public abstract global::MetaDslx.CodeAnalysis.Compilation? ContainingCompilation
        {
            get;
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> ConstituentNamespaces
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ConstituentNamespaces, null, default);
                return _constituentNamespaces;
            }
        }
        [__PhaseAttribute]
        [__DerivedAttribute]
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> NamespaceMembers
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_NamespaceMembers, null, default);
                return _namespaceMembers;
            }
        }


        public abstract NamespaceSymbol? LookupNestedNamespace(global::System.Collections.Immutable.ImmutableArray<string> names);

        public abstract NamespaceSymbol? LookupNestedNamespace(string name);

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_ConstituentNamespaces || incompletePart == CompletionParts.Finish_ConstituentNamespaces)
            {
                if (NotePartComplete(CompletionParts.Start_ConstituentNamespaces))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ConstituentNamespaces(diagnostics, cancellationToken);
                    _constituentNamespaces = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ConstituentNamespaces);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_NamespaceMembers || incompletePart == CompletionParts.Finish_NamespaceMembers)
            {
                if (NotePartComplete(CompletionParts.Start_NamespaceMembers))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_NamespaceMembers(diagnostics, cancellationToken);
                    _namespaceMembers = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_NamespaceMembers);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Compute_ConstituentNamespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Compute_NamespaceMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
