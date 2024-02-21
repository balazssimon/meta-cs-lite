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

public abstract partial class PElementSymbol: Impl.DeclarationSymbolImpl
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
            public static readonly CompletionPart Start_IsNamedElement = new CompletionPart(nameof(Start_IsNamedElement));
            public static readonly CompletionPart Finish_IsNamedElement = new CompletionPart(nameof(Finish_IsNamedElement));
            public static readonly CompletionPart Start_ContainingPAlternativeSymbol = new CompletionPart(nameof(Start_ContainingPAlternativeSymbol));
            public static readonly CompletionPart Finish_ContainingPAlternativeSymbol = new CompletionPart(nameof(Finish_ContainingPAlternativeSymbol));
            public static readonly CompletionPart Start_Value = new CompletionPart(nameof(Start_Value));
            public static readonly CompletionPart Finish_Value = new CompletionPart(nameof(Finish_Value));
            public static readonly CompletionPart Start_Assignment = new CompletionPart(nameof(Start_Assignment));
            public static readonly CompletionPart Finish_Assignment = new CompletionPart(nameof(Finish_Assignment));
            public static readonly CompletionPart Start_ExpectedType = new CompletionPart(nameof(Start_ExpectedType));
            public static readonly CompletionPart Finish_ExpectedType = new CompletionPart(nameof(Finish_ExpectedType));
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
                    Start_IsNamedElement, Finish_IsNamedElement,
                    Start_ContainingPAlternativeSymbol, Finish_ContainingPAlternativeSymbol,
                    Start_Value, Finish_Value,
                    Start_Assignment, Finish_Assignment,
                    Start_ExpectedType, Finish_ExpectedType,
                    Start_Attributes, Finish_Attributes
                );
        }

        private bool _isNamedElement;
        private PAlternativeSymbol? _containingPAlternativeSymbol;
        private global::MetaDslx.CodeAnalysis.MetaSymbol _value;
        private global::MetaDslx.Languages.MetaCompiler.Model.Assignment _assignment;
        private global::MetaDslx.CodeAnalysis.MetaType _expectedType;
        private global::MetaDslx.Languages.MetaCompiler.Model.ExpectedTypeKind _expectedKind;

        public PElementSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.MetaSymbol value = default, global::MetaDslx.Languages.MetaCompiler.Model.Assignment assignment = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            if (fixedSymbol)
            {
                _value = value;
                _assignment = assignment;
            }
        }

        public bool IsNamedElement
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsNamedElement, null, default);
                return _isNamedElement;
            }
        }
        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingPAlternativeSymbol, null, default);
                return _containingPAlternativeSymbol;
            }
        }
        [__ModelProperty]
        public global::MetaDslx.CodeAnalysis.MetaSymbol Value
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Value, null, default);
                return _value;
            }
        }
        [__ModelProperty]
        public global::MetaDslx.Languages.MetaCompiler.Model.Assignment Assignment
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Assignment, null, default);
                return _assignment;
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
        public global::MetaDslx.Languages.MetaCompiler.Model.ExpectedTypeKind ExpectedKind
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ExpectedType, null, default);
                return _expectedKind;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_IsNamedElement || incompletePart == CompletionParts.Finish_IsNamedElement)
            {
                if (NotePartComplete(CompletionParts.Start_IsNamedElement))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsNamedElement(diagnostics, cancellationToken);
                    _isNamedElement = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsNamedElement);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ContainingPAlternativeSymbol || incompletePart == CompletionParts.Finish_ContainingPAlternativeSymbol)
            {
                if (NotePartComplete(CompletionParts.Start_ContainingPAlternativeSymbol))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ContainingPAlternativeSymbol(diagnostics, cancellationToken);
                    _containingPAlternativeSymbol = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ContainingPAlternativeSymbol);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Value || incompletePart == CompletionParts.Finish_Value)
            {
                if (NotePartComplete(CompletionParts.Start_Value))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Value(diagnostics, cancellationToken);
                    _value = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Value);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_Assignment || incompletePart == CompletionParts.Finish_Assignment)
            {
                if (NotePartComplete(CompletionParts.Start_Assignment))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Assignment(diagnostics, cancellationToken);
                    _assignment = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Assignment);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ExpectedType || incompletePart == CompletionParts.Finish_ExpectedType)
            {
                if (NotePartComplete(CompletionParts.Start_ExpectedType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ExpectedType(diagnostics, cancellationToken);
                    _expectedType = result.ExpectedType;
                    _expectedKind = result.ExpectedKind;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ExpectedType);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected abstract bool Complete_IsNamedElement(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract PAlternativeSymbol? Complete_ContainingPAlternativeSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected virtual global::MetaDslx.CodeAnalysis.MetaSymbol Complete_Value(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }

        protected virtual global::MetaDslx.Languages.MetaCompiler.Model.Assignment Complete_Assignment(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.Languages.MetaCompiler.Model.Assignment>(this, nameof(Assignment), diagnostics, cancellationToken);
        }

        protected abstract (global::MetaDslx.CodeAnalysis.MetaType ExpectedType, global::MetaDslx.Languages.MetaCompiler.Model.ExpectedTypeKind ExpectedKind) Complete_ExpectedType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
