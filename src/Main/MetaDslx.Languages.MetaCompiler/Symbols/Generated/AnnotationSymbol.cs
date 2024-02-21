namespace MetaDslx.Languages.MetaCompiler.Symbols
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

public abstract partial class AnnotationSymbol: Impl.AttributeSymbolImpl
    {
        public static new class CompletionParts
        {
            public static readonly CompletionPart Start_AttributeClass = new CompletionPart(nameof(Start_AttributeClass));
            public static readonly CompletionPart Finish_AttributeClass = new CompletionPart(nameof(Finish_AttributeClass));
            public static readonly CompletionPart Start_Arguments = new CompletionPart(nameof(Start_Arguments));
            public static readonly CompletionPart Finish_Arguments = new CompletionPart(nameof(Finish_Arguments));
            public static readonly CompletionPart Start_Constructors = new CompletionPart(nameof(Start_Constructors));
            public static readonly CompletionPart Finish_Constructors = new CompletionPart(nameof(Finish_Constructors));
            public static readonly CompletionPart Start_Parameters = new CompletionPart(nameof(Start_Parameters));
            public static readonly CompletionPart Finish_Parameters = new CompletionPart(nameof(Finish_Parameters));
            public static readonly CompletionPart Start_SelectedConstructor = new CompletionPart(nameof(Start_SelectedConstructor));
            public static readonly CompletionPart Finish_SelectedConstructor = new CompletionPart(nameof(Finish_SelectedConstructor));
            public static readonly CompletionPart Start_Attributes = new CompletionPart(nameof(Start_Attributes));
            public static readonly CompletionPart Finish_Attributes = new CompletionPart(nameof(Finish_Attributes));

            public static readonly CompletionGraph CompletionGraph = 
                CompletionGraph.CreateFromParts(
                    Start_AttributeClass, Finish_AttributeClass,
                    Start_Arguments, Finish_Arguments,
                    Start_Constructors, Finish_Constructors,
                    Start_Parameters, Finish_Parameters,
                    Start_SelectedConstructor, Finish_SelectedConstructor,
                    Start_Attributes, Finish_Attributes
                );
        }

        private global::System.Collections.Immutable.ImmutableArray<AnnotationArgumentSymbol> _arguments;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _constructors;
        private global::System.Collections.Immutable.ImmutableArray<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>> _parameters;
        private DeclarationSymbol _selectedConstructor;
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _selectedParameters;

        public AnnotationSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::System.Collections.Immutable.ImmutableArray<AnnotationArgumentSymbol> arguments = default, TypeSymbol attributeClass = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, attributeClass: attributeClass)
        {
            if (fixedSymbol)
            {
                _arguments = arguments;
            }
        }

        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<AnnotationArgumentSymbol> Arguments
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Arguments, null, default);
                return _arguments;
            }
        }
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Constructors
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Constructors, null, default);
                return _constructors;
            }
        }
        public global::System.Collections.Immutable.ImmutableArray<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>> Parameters
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Parameters, null, default);
                return _parameters;
            }
        }
        public DeclarationSymbol SelectedConstructor
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_SelectedConstructor, null, default);
                return _selectedConstructor;
            }
        }
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> SelectedParameters
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_SelectedConstructor, null, default);
                return _selectedParameters;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_Arguments || incompletePart == CompletionParts.Finish_Arguments)
            {
                if (NotePartComplete(CompletionParts.Start_Arguments))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Arguments(diagnostics, cancellationToken);
                    _arguments = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Arguments);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Constructors || incompletePart == CompletionParts.Finish_Constructors)
            {
                if (NotePartComplete(CompletionParts.Start_Constructors))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Constructors(diagnostics, cancellationToken);
                    _constructors = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Constructors);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Parameters || incompletePart == CompletionParts.Finish_Parameters)
            {
                if (NotePartComplete(CompletionParts.Start_Parameters))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Parameters(diagnostics, cancellationToken);
                    _parameters = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Parameters);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_SelectedConstructor || incompletePart == CompletionParts.Finish_SelectedConstructor)
            {
                if (NotePartComplete(CompletionParts.Start_SelectedConstructor))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_SelectedConstructor(diagnostics, cancellationToken);
                    _selectedConstructor = result.SelectedConstructor;
                    _selectedParameters = result.SelectedParameters;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_SelectedConstructor);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::System.Collections.Immutable.ImmutableArray<AnnotationArgumentSymbol> Complete_Arguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<AnnotationArgumentSymbol>(this, nameof(Arguments), diagnostics, cancellationToken);
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Constructors(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol>> Complete_Parameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract (DeclarationSymbol SelectedConstructor, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> SelectedParameters) Complete_SelectedConstructor(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
