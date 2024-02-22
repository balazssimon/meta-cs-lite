namespace MetaDslx.CodeAnalysis.Symbols
{
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

    public abstract partial class NamespaceSymbol: Impl.DeclarationSymbolImpl
    {
        public new class CompletionParts : Impl.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_Extent = new __CompletionPart(nameof(Start_Extent));
            public static readonly __CompletionPart Finish_Extent = new __CompletionPart(nameof(Finish_Extent));
            public static readonly __CompletionPart Start_IsGlobalNamespace = new __CompletionPart(nameof(Start_IsGlobalNamespace));
            public static readonly __CompletionPart Finish_IsGlobalNamespace = new __CompletionPart(nameof(Finish_IsGlobalNamespace));
            public static readonly __CompletionPart Start_NamespaceKind = new __CompletionPart(nameof(Start_NamespaceKind));
            public static readonly __CompletionPart Finish_NamespaceKind = new __CompletionPart(nameof(Finish_NamespaceKind));
            public static readonly __CompletionPart Start_ContainingCompilation = new __CompletionPart(nameof(Start_ContainingCompilation));
            public static readonly __CompletionPart Finish_ContainingCompilation = new __CompletionPart(nameof(Finish_ContainingCompilation));
            public static readonly __CompletionPart Start_ConstituentNamespaces = new __CompletionPart(nameof(Start_ConstituentNamespaces));
            public static readonly __CompletionPart Finish_ConstituentNamespaces = new __CompletionPart(nameof(Finish_ConstituentNamespaces));
            public static readonly __CompletionPart Start_NamespaceMembers = new __CompletionPart(nameof(Start_NamespaceMembers));
            public static readonly __CompletionPart Finish_NamespaceMembers = new __CompletionPart(nameof(Finish_NamespaceMembers));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    Impl.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_Extent, Finish_Extent
                    , Start_IsGlobalNamespace, Finish_IsGlobalNamespace
                    , Start_NamespaceKind, Finish_NamespaceKind
                    , Start_ContainingCompilation, Finish_ContainingCompilation
                    , Start_ConstituentNamespaces, Finish_ConstituentNamespaces
                    , Start_NamespaceMembers, Finish_NamespaceMembers
                );
        }

        private global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent _extent;
        private bool _isGlobalNamespace;
        private global::MetaDslx.CodeAnalysis.NamespaceKind _namespaceKind;
        private global::MetaDslx.CodeAnalysis.Compilation? _containingCompilation;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _constituentNamespaces;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaceMembers;

        public NamespaceSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent extent = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            if (fixedSymbol)
            {
                _extent = extent;
            }
        }

        [__ModelProperty]
[__Phase]
        public global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Extent
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Extent, null, default);
                return _extent;
            }
        }
[__Phase]
[__Derived]
        public bool IsGlobalNamespace
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsGlobalNamespace, null, default);
                return _isGlobalNamespace;
            }
        }
[__Phase]
[__Derived]
        public global::MetaDslx.CodeAnalysis.NamespaceKind NamespaceKind
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_NamespaceKind, null, default);
                return _namespaceKind;
            }
        }
[__Phase]
[__Derived]
        public global::MetaDslx.CodeAnalysis.Compilation? ContainingCompilation
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingCompilation, null, default);
                return _containingCompilation;
            }
        }
[__Phase]
[__Derived]
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> ConstituentNamespaces
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ConstituentNamespaces, null, default);
                return _constituentNamespaces;
            }
        }
[__Phase]
[__Derived]
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
            if (incompletePart == CompletionParts.Start_Extent || incompletePart == CompletionParts.Finish_Extent)
            {
                if (NotePartComplete(CompletionParts.Start_Extent))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_Extent(diagnostics, cancellationToken);
                    _extent = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Extent);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_IsGlobalNamespace || incompletePart == CompletionParts.Finish_IsGlobalNamespace)
            {
                if (NotePartComplete(CompletionParts.Start_IsGlobalNamespace))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_IsGlobalNamespace(diagnostics, cancellationToken);
                    _isGlobalNamespace = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsGlobalNamespace);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_NamespaceKind || incompletePart == CompletionParts.Finish_NamespaceKind)
            {
                if (NotePartComplete(CompletionParts.Start_NamespaceKind))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_NamespaceKind(diagnostics, cancellationToken);
                    _namespaceKind = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_NamespaceKind);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ContainingCompilation || incompletePart == CompletionParts.Finish_ContainingCompilation)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingCompilation))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_ContainingCompilation(diagnostics, cancellationToken);
                    _containingCompilation = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingCompilation);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ConstituentNamespaces || incompletePart == CompletionParts.Finish_ConstituentNamespaces)
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


        protected virtual global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Compute_Extent(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent>(this, nameof(Extent), diagnostics, cancellationToken);
        }

        protected abstract bool Compute_IsGlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.NamespaceKind Compute_NamespaceKind(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.Compilation? Compute_ContainingCompilation(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Compute_ConstituentNamespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Compute_NamespaceMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
