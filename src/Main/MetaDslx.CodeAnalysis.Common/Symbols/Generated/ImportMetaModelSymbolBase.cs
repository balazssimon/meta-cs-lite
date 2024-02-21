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

    public partial class ImportMetaModelSymbolInst : ImportSymbolInst, ImportMetaModelSymbol
    {
        private global::MetaDslx.CodeAnalysis.MetaSymbol _metaModelSymbols;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> _metaModels;

        public ImportMetaModelSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public ImportMetaModelSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public ImportMetaModelSymbolInst(__Symbol container, __Model model) 
            : base(container, model)
        {
        }

        public ImportMetaModelSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public ImportMetaModelSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public ImportMetaModelSymbolInst(__Symbol container, __Compilation compilation) 
            : base(container, compilation)
        {
        }

        public ImportMetaModelSymbolInst(__Symbol container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, string? name = default, string? metadataName = default, __ImmutableAttributeSymbols attributes = default, global::MetaDslx.CodeAnalysis.MetaSymbol metaModelSymbols = default, global::System.Collections.Immutable.ImmutableArray<string> files = default, global::System.Collections.Immutable.ImmutableArray<AliasSymbol> aliases = default, global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> namespaces = default, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> symbols = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, name, metadataName, attributes, files: files, aliases: aliases, namespaces: namespaces, symbols: symbols)
        {
            _metaModelSymbols = metaModelSymbols;
            NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModelSymbols);
        }

        public override __AssemblySymbol? ContainingAssembly => CallImpl<__AssemblySymbol, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.ContainingAssembly);

        public override __Compilation? DeclaringCompilation => CallImpl<__Compilation, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.DeclaringCompilation);

        public override __ModuleSymbol? ContainingModule => CallImpl<__ModuleSymbol, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.ContainingModule);

        public override __DeclarationSymbol? ContainingDeclaration => CallImpl<__DeclarationSymbol, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.ContainingDeclaration);

        public override __TypeSymbol? ContainingType => CallImpl<__TypeSymbol, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.ContainingType);

        public override __NamespaceSymbol? ContainingNamespace => CallImpl<__NamespaceSymbol, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.ContainingNamespace);

        public global::MetaDslx.CodeAnalysis.MetaSymbol MetaModelSymbols
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModelSymbols, null, default);
                return _metaModelSymbols;
            }
        }
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> MetaModels
        {
            get
            {
                this.ForceComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModels, null, default);
                return _metaModels;
            }
        }

        public override __LexicalSortKey GetLexicalSortKey()
        {
            return CallImpl<__LexicalSortKey, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.GetLexicalSortKey());
        }

        public override bool HasUnsupportedMetadata => CallImpl<bool, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.HasUnsupportedMetadata);

        public override string GetDocumentationCommentId()
        {
            return CallImpl<string, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.GetDocumentationCommentId());
        }

        public override string GetDocumentationCommentXml(__CultureInfo preferredCulture = null, bool expandIncludes = false, __CancellationToken cancellationToken = default)
        {
            return CallImpl<string, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken));
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_MetaModelSymbols || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_MetaModelSymbols)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_MetaModelSymbols))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_MetaModelSymbols(diagnostics, cancellationToken);
                    _metaModelSymbols = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModelSymbols);
                }
                return true;
            }
            else 
            if (incompletePart == ImportMetaModelSymbol.CompletionParts.Start_MetaModels || incompletePart == ImportMetaModelSymbol.CompletionParts.Finish_MetaModels)
            {
                if (NotePartComplete(ImportMetaModelSymbol.CompletionParts.Start_MetaModels))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_MetaModels(diagnostics, cancellationToken);
                    _metaModels = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(ImportMetaModelSymbol.CompletionParts.Finish_MetaModels);
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
            CallImpl<ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.CompletePart_Initialize(diagnostics, cancellationToken));
        }

        protected override string? Complete_Name(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_Name(diagnostics, cancellationToken));
        }

        protected override string? Complete_MetadataName(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<string?, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_MetadataName(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__Symbol> CompletePart_CreateContainedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__Symbol>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.CompletePart_CreateContainedSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol> Complete_Attributes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_Attributes(diagnostics, cancellationToken));
        }

        protected override void CompletePart_ComputeNonSymbolProperties(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Finalize(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.CompletePart_Finalize(diagnostics, cancellationToken));
        }

        protected override void CompletePart_Validate(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            CallImpl<ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.CompletePart_Validate(diagnostics, cancellationToken));
        }


        protected virtual global::MetaDslx.CodeAnalysis.MetaSymbol Complete_MetaModelSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::MetaDslx.CodeAnalysis.MetaSymbol, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_MetaModelSymbols(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<string>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_Files(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<AliasSymbol>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_Aliases(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_Namespaces(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_Symbols(diagnostics, cancellationToken));
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> Complete_MetaModels(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_MetaModels(diagnostics, cancellationToken));
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_ImportedSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return CallImpl<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>, ImportMetaModelSymbol, ImportMetaModelSymbolImpl>(impl => impl.Complete_ImportedSymbols(diagnostics, cancellationToken));
        }
    }

    public abstract class ImportMetaModelSymbolBase : ImportSymbolImpl, ImportMetaModelSymbol
    {
        public global::MetaDslx.CodeAnalysis.MetaSymbol MetaModelSymbols => ((ImportMetaModelSymbol)__Wrapped).MetaModelSymbols;
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> MetaModels => ((ImportMetaModelSymbol)__Wrapped).MetaModels;



        public virtual global::MetaDslx.CodeAnalysis.MetaSymbol Complete_MetaModelSymbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.MetaSymbol>(this, nameof(MetaModelSymbols), diagnostics, cancellationToken);
        }

        public abstract global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.Modeling.MetaModel> Complete_MetaModels(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
