namespace MetaDslx.CodeAnalysis.Symbols
{
    using __ISymbol = global::Microsoft.CodeAnalysis.ISymbol;
    using __IModelObject = global::MetaDslx.Modeling.IModelObject;
    using __MergedDeclaration = global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;
    using __Symbol = global::MetaDslx.CodeAnalysis.Symbols.Symbol;
    using __ErrorSymbolInfo = global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;
    using __ModelProperty = global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;
    using __CompletionGraph = global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;
    using __CompletionPart = global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;
    using __DiagnosticBag = global::MetaDslx.CodeAnalysis.DiagnosticBag;
    using __SourceLocation = global::MetaDslx.CodeAnalysis.SourceLocation;
    using __CancellationToken = global::System.Threading.CancellationToken;

    internal abstract class ImportSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolBase, ImportSymbol
    {
        private global::System.Collections.Immutable.ImmutableArray<string> _files;
        private global::System.Collections.Immutable.ImmutableArray<AliasSymbol> _aliases;
        private global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> _namespaces;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _symbols;

        protected ImportSymbolBase(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected ImportSymbolBase(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected ImportSymbolBase(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected ImportSymbolBase(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        protected override __CompletionGraph CompletionGraph => ImportSymbol.CompletionParts.CompletionGraph;

        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<string> Files
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Files, null, default);
                return _files;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Aliases
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Aliases, null, default);
                return _aliases;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Namespaces
        {
            get
            {
                this.ForceComplete(ImportSymbol.CompletionParts.Finish_Namespaces, null, default);
                return _namespaces;
            }
        }
        [__ModelProperty]
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
            else if (incompletePart == ImportSymbol.CompletionParts.Start_Aliases || incompletePart == ImportSymbol.CompletionParts.Finish_Aliases)
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
            else if (incompletePart == ImportSymbol.CompletionParts.Start_Namespaces || incompletePart == ImportSymbol.CompletionParts.Finish_Namespaces)
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
            else if (incompletePart == ImportSymbol.CompletionParts.Start_Symbols || incompletePart == ImportSymbol.CompletionParts.Finish_Symbols)
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

        protected virtual global::System.Collections.Immutable.ImmutableArray<string> Complete_Files(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<string>.Empty;
        }
        protected virtual global::System.Collections.Immutable.ImmutableArray<AliasSymbol> Complete_Aliases(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<AliasSymbol>.Empty;
        }
        protected virtual global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol> Complete_Namespaces(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<NamespaceSymbol>.Empty;
        }
        protected virtual global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Symbols(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>.Empty;
        }
    }
}
