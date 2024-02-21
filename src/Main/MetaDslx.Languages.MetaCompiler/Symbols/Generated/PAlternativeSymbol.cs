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

public abstract partial class PAlternativeSymbol: Impl.DeclarationSymbolImpl
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
            public static readonly CompletionPart Start_ContainingParserRuleSymbol = new CompletionPart(nameof(Start_ContainingParserRuleSymbol));
            public static readonly CompletionPart Finish_ContainingParserRuleSymbol = new CompletionPart(nameof(Finish_ContainingParserRuleSymbol));
            public static readonly CompletionPart Start_ContainingPBlockSymbol = new CompletionPart(nameof(Start_ContainingPBlockSymbol));
            public static readonly CompletionPart Finish_ContainingPBlockSymbol = new CompletionPart(nameof(Finish_ContainingPBlockSymbol));
            public static readonly CompletionPart Start_Elements = new CompletionPart(nameof(Start_Elements));
            public static readonly CompletionPart Finish_Elements = new CompletionPart(nameof(Finish_Elements));
            public static readonly CompletionPart Start_ReturnValue = new CompletionPart(nameof(Start_ReturnValue));
            public static readonly CompletionPart Finish_ReturnValue = new CompletionPart(nameof(Finish_ReturnValue));
            public static readonly CompletionPart Start_ReturnType = new CompletionPart(nameof(Start_ReturnType));
            public static readonly CompletionPart Finish_ReturnType = new CompletionPart(nameof(Finish_ReturnType));
            public static readonly CompletionPart Start_ExpectedType = new CompletionPart(nameof(Start_ExpectedType));
            public static readonly CompletionPart Finish_ExpectedType = new CompletionPart(nameof(Finish_ExpectedType));
            public static readonly CompletionPart Start_AllSimpleElements = new CompletionPart(nameof(Start_AllSimpleElements));
            public static readonly CompletionPart Finish_AllSimpleElements = new CompletionPart(nameof(Finish_AllSimpleElements));
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
                    Start_ContainingParserRuleSymbol, Finish_ContainingParserRuleSymbol,
                    Start_ContainingPBlockSymbol, Finish_ContainingPBlockSymbol,
                    Start_Elements, Finish_Elements,
                    Start_ReturnValue, Finish_ReturnValue,
                    Start_ReturnType, Finish_ReturnType,
                    Start_ExpectedType, Finish_ExpectedType,
                    Start_AllSimpleElements, Finish_AllSimpleElements,
                    Start_Attributes, Finish_Attributes
                );
        }

        private ParserRuleSymbol? _containingParserRuleSymbol;
        private PBlockSymbol? _containingPBlockSymbol;
        private global::System.Collections.Immutable.ImmutableArray<PElementSymbol> _elements;
        private ExpressionSymbol? _returnValue;
        private global::MetaDslx.CodeAnalysis.MetaType _returnType;
        private global::MetaDslx.CodeAnalysis.MetaType _expectedType;
        private PElementSymbol _allSimpleElements;

        public PAlternativeSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::System.Collections.Immutable.ImmutableArray<PElementSymbol> elements = default, ExpressionSymbol? returnValue = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            if (fixedSymbol)
            {
                _elements = elements;
                _returnValue = returnValue;
            }
        }

        public ParserRuleSymbol? ContainingParserRuleSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingParserRuleSymbol, null, default);
                return _containingParserRuleSymbol;
            }
        }
        public PBlockSymbol? ContainingPBlockSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingPBlockSymbol, null, default);
                return _containingPBlockSymbol;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<PElementSymbol> Elements
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Elements, null, default);
                return _elements;
            }
        }
        [__ModelProperty]
        public ExpressionSymbol? ReturnValue
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ReturnValue, null, default);
                return _returnValue;
            }
        }
        public global::MetaDslx.CodeAnalysis.MetaType ReturnType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ReturnType, null, default);
                return _returnType;
            }
        }
        public global::MetaDslx.CodeAnalysis.MetaType ExpectedType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ExpectedType, null, default);
                return _expectedType;
            }
        }
        public PElementSymbol AllSimpleElements
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_AllSimpleElements, null, default);
                return _allSimpleElements;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_ContainingParserRuleSymbol || incompletePart == CompletionParts.Finish_ContainingParserRuleSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingParserRuleSymbol))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ContainingParserRuleSymbol(diagnostics, cancellationToken);
                    _containingParserRuleSymbol = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingParserRuleSymbol);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ContainingPBlockSymbol || incompletePart == CompletionParts.Finish_ContainingPBlockSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingPBlockSymbol))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ContainingPBlockSymbol(diagnostics, cancellationToken);
                    _containingPBlockSymbol = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingPBlockSymbol);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Elements || incompletePart == CompletionParts.Finish_Elements)
            {
                if (NotePartComplete(CompletionParts.Start_Elements))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Elements(diagnostics, cancellationToken);
                    _elements = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Elements);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ReturnValue || incompletePart == CompletionParts.Finish_ReturnValue)
            {
                if (NotePartComplete(CompletionParts.Start_ReturnValue))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ReturnValue(diagnostics, cancellationToken);
                    _returnValue = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ReturnValue);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ReturnType || incompletePart == CompletionParts.Finish_ReturnType)
            {
                if (NotePartComplete(CompletionParts.Start_ReturnType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ReturnType(diagnostics, cancellationToken);
                    _returnType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ReturnType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ExpectedType || incompletePart == CompletionParts.Finish_ExpectedType)
            {
                if (NotePartComplete(CompletionParts.Start_ExpectedType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ExpectedType(diagnostics, cancellationToken);
                    _expectedType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ExpectedType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_AllSimpleElements || incompletePart == CompletionParts.Finish_AllSimpleElements)
            {
                if (NotePartComplete(CompletionParts.Start_AllSimpleElements))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_AllSimpleElements(diagnostics, cancellationToken);
                    _allSimpleElements = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_AllSimpleElements);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected abstract ParserRuleSymbol? Complete_ContainingParserRuleSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract PBlockSymbol? Complete_ContainingPBlockSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected virtual global::System.Collections.Immutable.ImmutableArray<PElementSymbol> Complete_Elements(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<PElementSymbol>(this, nameof(Elements), diagnostics, cancellationToken);
        }

        protected virtual ExpressionSymbol? Complete_ReturnValue(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<ExpressionSymbol>(this, nameof(ReturnValue), diagnostics, cancellationToken);
        }

        protected abstract global::MetaDslx.CodeAnalysis.MetaType Complete_ReturnType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.MetaType Complete_ExpectedType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract PElementSymbol Complete_AllSimpleElements(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
