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

    public partial class ImportSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, ImportSymbol
    {
        private global::System.Collections.Immutable.ImmutableArray<string> _files;
        private global::System.Collections.Immutable.ImmutableArray<AliasSymbol> _aliases;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaces;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _symbols;

        public ImportSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public ImportSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public ImportSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public ImportSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public ImportSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, modelObject, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public ImportSymbolInst(__Symbol container, __Compilation compilation, __IModelObject? modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::System.Collections.Immutable.ImmutableArray<string> files, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols) 
            : base(container, compilation, modelObject, name, metadataName, attributes)
        {
            _files = files;
            _aliases = aliases;
            _namespaces = namespaces;
            _symbols = symbols;
        }

        public override __ISymbolFactory SymbolFactory => CallImpl<__ISymbolFactory, ImportSymbol, ImportSymbolImpl>(impl => impl.SymbolFactory);

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, ImportSymbol, ImportSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, ImportSymbol, ImportSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, ImportSymbol, ImportSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, ImportSymbol, ImportSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, ImportSymbol, ImportSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, ImportSymbol, ImportSymbolImpl>(impl => impl.ContainingNamespace);

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, ImportSymbol, ImportSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, ImportSymbol, ImportSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, ImportSymbol, ImportSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, ImportSymbol, ImportSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }


        public global::System.Collections.Immutable.ImmutableArray<string> Files
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Files, null, default);
                return _files;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Aliases, null, default);
                return _aliases;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Namespaces, null, default);
                return _namespaces;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Symbols, null, default);
                return _symbols;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == ImportSymbol.CompletionParts.Start_Files || incompletePart == ImportSymbol.CompletionParts.Finish_Files)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Files))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Files(diagnostics, cancellationToken);
                    _files = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Files);
                }
                return true;
            }
            else 
            if (incompletePart == ImportSymbol.CompletionParts.Start_Aliases || incompletePart == ImportSymbol.CompletionParts.Finish_Aliases)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Aliases))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Aliases(diagnostics, cancellationToken);
                    _aliases = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Aliases);
                }
                return true;
            }
            else 
            if (incompletePart == ImportSymbol.CompletionParts.Start_Namespaces || incompletePart == ImportSymbol.CompletionParts.Finish_Namespaces)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Namespaces))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Namespaces(diagnostics, cancellationToken);
                    _namespaces = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Namespaces);
                }
                return true;
            }
            else 
            if (incompletePart == ImportSymbol.CompletionParts.Start_Symbols || incompletePart == ImportSymbol.CompletionParts.Finish_Symbols)
            {
                if (NotePartComplete(ImportSymbol.CompletionParts.Start_Symbols))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Symbols(diagnostics, cancellationToken);
                    _symbols = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportSymbol.CompletionParts.Finish_Symbols);
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
            CallImpl<ImportSymbol, ImportSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, ImportSymbol, ImportSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, ImportSymbol, ImportSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, ImportSymbol, ImportSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, ImportSymbol, ImportSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ImportSymbol, ImportSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ImportSymbol, ImportSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ImportSymbol, ImportSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<string>, ImportSymbol, ImportSymbolImpl>(impl => impl.Complete_Files(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<AliasSymbol>, ImportSymbol, ImportSymbolImpl>(impl => impl.Complete_Aliases(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>, ImportSymbol, ImportSymbolImpl>(impl => impl.Complete_Namespaces(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, ImportSymbol, ImportSymbolImpl>(impl => impl.Complete_Symbols(diagnostics, cancellationToken));
        }
    }

    public abstract class ImportSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, ImportSymbol
    {
        public global::System.Collections.Immutable.ImmutableArray<string> Files => ((ImportSymbol)__Wrapped).Files;
        public global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases => ((ImportSymbol)__Wrapped).Aliases;
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces => ((ImportSymbol)__Wrapped).Namespaces;
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Symbols => ((ImportSymbol)__Wrapped).Symbols;


        public virtual global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<string>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<AliasSymbol>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            // TODO
            return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
        }
    }
}
