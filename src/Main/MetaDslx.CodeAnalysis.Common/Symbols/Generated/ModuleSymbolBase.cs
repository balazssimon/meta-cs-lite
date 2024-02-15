namespace MetaDslx.CodeAnalysis.Symbols.__Impl
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

    public partial class ModuleSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, ModuleSymbol
    {
        private NamespaceSymbol _globalNamespace;

        public ModuleSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public ModuleSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public ModuleSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public ModuleSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public ModuleSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public ModuleSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public ModuleSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public ModuleSymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, NamespaceSymbol globalNamespace) 
            : base(container, compilation, modelObject, name, metadataName, attributes)
        {
            _globalNamespace = globalNamespace;
        }

        public override __ISymbolFactory SymbolFactory => CallImpl<__ISymbolFactory, ModuleSymbol, ModuleSymbolImpl>(impl => impl.SymbolFactory);

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, ModuleSymbol, ModuleSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, ModuleSymbol, ModuleSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, ModuleSymbol, ModuleSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, ModuleSymbol, ModuleSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, ModuleSymbol, ModuleSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, ModuleSymbol, ModuleSymbolImpl>(impl => impl.ContainingNamespace);


        public NamespaceSymbol GlobalNamespace
        {
            get
            {
                this.ForceComplete(ModuleSymbol.CompletionParts.Finish_GlobalNamespace, null, default);
                return _globalNamespace;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, ModuleSymbol, ModuleSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, ModuleSymbol, ModuleSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, ModuleSymbol, ModuleSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, ModuleSymbol, ModuleSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }

        public virtual NamespaceSymbol GetRootNamespace(global::MetaDslx.CodeAnalysis.SyntaxTree syntaxTree)
        {
            return CallImpl<NamespaceSymbol, ModuleSymbol, ModuleSymbolImpl>(impl => impl.GetRootNamespace(syntaxTree));
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == ModuleSymbol.CompletionParts.Start_GlobalNamespace || incompletePart == ModuleSymbol.CompletionParts.Finish_GlobalNamespace)
            {
                if (NotePartComplete(ModuleSymbol.CompletionParts.Start_GlobalNamespace))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_GlobalNamespace(diagnostics, cancellationToken);
                    _globalNamespace = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ModuleSymbol.CompletionParts.Finish_GlobalNamespace);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected override void CompletePart_Initialize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ModuleSymbol, ModuleSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, ModuleSymbol, ModuleSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, ModuleSymbol, ModuleSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, ModuleSymbol, ModuleSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, ModuleSymbol, ModuleSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ModuleSymbol, ModuleSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ModuleSymbol, ModuleSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ModuleSymbol, ModuleSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<NamespaceSymbol, ModuleSymbol, ModuleSymbolImpl>(impl => impl.Complete_GlobalNamespace(diagnostics, cancellationToken));
        }
    }

    public abstract class ModuleSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, ModuleSymbol
    {
        public NamespaceSymbol GlobalNamespace => ((ModuleSymbol)__Wrapped).GlobalNamespace;

        public abstract NamespaceSymbol GetRootNamespace(global::MetaDslx.CodeAnalysis.SyntaxTree syntaxTree);


        public abstract NamespaceSymbol Complete_GlobalNamespace(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
