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

    internal abstract class AssemblySymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolBase, AssemblySymbol
    {
        private bool _isCorLibrary;
        private global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> _modules;

        protected AssemblySymbolBase(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected AssemblySymbolBase(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected AssemblySymbolBase(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected AssemblySymbolBase(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        protected override __CompletionGraph CompletionGraph => AssemblySymbol.CompletionParts.CompletionGraph;

        [__ModelProperty]
        public bool IsCorLibrary
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary, null, default);
                return _isCorLibrary;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Modules
        {
            get
            {
                this.ForceComplete(AssemblySymbol.CompletionParts.Finish_Modules, null, default);
                return _modules;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == AssemblySymbol.CompletionParts.Start_IsCorLibrary || incompletePart == AssemblySymbol.CompletionParts.Finish_IsCorLibrary)
            {
                if (NotePartComplete(AssemblySymbol.CompletionParts.Start_IsCorLibrary))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsCorLibrary(diagnostics, cancellationToken);
                    _isCorLibrary = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(AssemblySymbol.CompletionParts.Finish_IsCorLibrary);
                }
                return true;
            }
            else if (incompletePart == AssemblySymbol.CompletionParts.Start_Modules || incompletePart == AssemblySymbol.CompletionParts.Finish_Modules)
            {
                if (NotePartComplete(AssemblySymbol.CompletionParts.Start_Modules))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Modules(diagnostics, cancellationToken);
                    _modules = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(AssemblySymbol.CompletionParts.Finish_Modules);
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
            return default;
        }
        protected virtual global::System.Collections.Immutable.ImmutableArray<ModuleSymbol> Complete_Modules(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<ModuleSymbol>.Empty;
        }
    }
}
