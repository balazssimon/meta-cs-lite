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

public abstract partial class NamespaceSymbol: Impl.DeclarationSymbolImpl
    {
        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_DeclaredAccessibility = new CompletionPart(nameof(Start_DeclaredAccessibility));
            public static readonly CompletionPart Finish_DeclaredAccessibility = new CompletionPart(nameof(Finish_DeclaredAccessibility));
            public static readonly CompletionPart Start_IsStatic = new CompletionPart(nameof(Start_IsStatic));
            public static readonly CompletionPart Finish_IsStatic = new CompletionPart(nameof(Finish_IsStatic));
            public static readonly CompletionPart Start_IsExtern = new CompletionPart(nameof(Start_IsExtern));
            public static readonly CompletionPart Finish_IsExtern = new CompletionPart(nameof(Finish_IsExtern));
            public static readonly CompletionPart Start_TypeArguments = new CompletionPart(nameof(Start_TypeArguments));
            public static readonly CompletionPart Finish_TypeArguments = new CompletionPart(nameof(Finish_TypeArguments));
            public static readonly CompletionPart Start_Imports = new CompletionPart(nameof(Start_Imports));
            public static readonly CompletionPart Finish_Imports = new CompletionPart(nameof(Finish_Imports));
            public static readonly CompletionPart Start_MemberNames = new CompletionPart(nameof(Start_MemberNames));
            public static readonly CompletionPart Finish_MemberNames = new CompletionPart(nameof(Finish_MemberNames));
            public static readonly CompletionPart Start_Members = new CompletionPart(nameof(Start_Members));
            public static readonly CompletionPart Finish_Members = new CompletionPart(nameof(Finish_Members));
            public static readonly CompletionPart Start_TypeMembers = new CompletionPart(nameof(Start_TypeMembers));
            public static readonly CompletionPart Finish_TypeMembers = new CompletionPart(nameof(Finish_TypeMembers));
            public static readonly CompletionPart Start_Extent = new CompletionPart(nameof(Start_Extent));
            public static readonly CompletionPart Finish_Extent = new CompletionPart(nameof(Finish_Extent));
            public static readonly CompletionPart Start_IsGlobalNamespace = new CompletionPart(nameof(Start_IsGlobalNamespace));
            public static readonly CompletionPart Finish_IsGlobalNamespace = new CompletionPart(nameof(Finish_IsGlobalNamespace));
            public static readonly CompletionPart Start_NamespaceKind = new CompletionPart(nameof(Start_NamespaceKind));
            public static readonly CompletionPart Finish_NamespaceKind = new CompletionPart(nameof(Finish_NamespaceKind));
            public static readonly CompletionPart Start_ContainingCompilation = new CompletionPart(nameof(Start_ContainingCompilation));
            public static readonly CompletionPart Finish_ContainingCompilation = new CompletionPart(nameof(Finish_ContainingCompilation));
            public static readonly CompletionPart Start_ConstituentNamespaces = new CompletionPart(nameof(Start_ConstituentNamespaces));
            public static readonly CompletionPart Finish_ConstituentNamespaces = new CompletionPart(nameof(Finish_ConstituentNamespaces));
            public static readonly CompletionPart Start_NamespaceMembers = new CompletionPart(nameof(Start_NamespaceMembers));
            public static readonly CompletionPart Finish_NamespaceMembers = new CompletionPart(nameof(Finish_NamespaceMembers));
            public static readonly CompletionPart Start_Attributes = new CompletionPart(nameof(Start_Attributes));
            public static readonly CompletionPart Finish_Attributes = new CompletionPart(nameof(Finish_Attributes));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_DeclaredAccessibility, Finish_DeclaredAccessibility,
                    Start_IsStatic, Finish_IsStatic,
                    Start_IsExtern, Finish_IsExtern,
                    Start_TypeArguments, Finish_TypeArguments,
                    Start_Imports, Finish_Imports,
                    Start_MemberNames, Finish_MemberNames,
                    Start_Members, Finish_Members,
                    Start_TypeMembers, Finish_TypeMembers,
                    Start_Extent, Finish_Extent,
                    Start_IsGlobalNamespace, Finish_IsGlobalNamespace,
                    Start_NamespaceKind, Finish_NamespaceKind,
                    Start_ContainingCompilation, Finish_ContainingCompilation,
                    Start_ConstituentNamespaces, Finish_ConstituentNamespaces,
                    Start_NamespaceMembers, Finish_NamespaceMembers,
                    Start_Attributes, Finish_Attributes
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
        public global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Extent
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Extent, null, default);
                return _extent;
            }
        }
        public bool IsGlobalNamespace
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsGlobalNamespace, null, default);
                return _isGlobalNamespace;
            }
        }
        public global::MetaDslx.CodeAnalysis.NamespaceKind NamespaceKind
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_NamespaceKind, null, default);
                return _namespaceKind;
            }
        }
        public global::MetaDslx.CodeAnalysis.Compilation? ContainingCompilation
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingCompilation, null, default);
                return _containingCompilation;
            }
        }
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> ConstituentNamespaces
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ConstituentNamespaces, null, default);
                return _constituentNamespaces;
            }
        }
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
                    var result = Complete_Extent(diagnostics, cancellationToken);
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
                    var result = Complete_IsGlobalNamespace(diagnostics, cancellationToken);
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
                    var result = Complete_NamespaceKind(diagnostics, cancellationToken);
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
                    var result = Complete_ContainingCompilation(diagnostics, cancellationToken);
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
                    var result = Complete_ConstituentNamespaces(diagnostics, cancellationToken);
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
                    var result = Complete_NamespaceMembers(diagnostics, cancellationToken);
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


        protected virtual global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent Complete_Extent(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.Symbols.NamespaceExtent>(this, nameof(Extent), diagnostics, cancellationToken);
        }

        protected abstract bool Complete_IsGlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.NamespaceKind Complete_NamespaceKind(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.Compilation? Complete_ContainingCompilation(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_ConstituentNamespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_NamespaceMembers(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
