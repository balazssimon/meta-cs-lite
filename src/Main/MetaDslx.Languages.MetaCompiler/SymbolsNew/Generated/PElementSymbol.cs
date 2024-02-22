namespace MetaDslx.Languages.MetaCompiler.Symbols
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
    using MetaDslx.CodeAnalysis.Symbols;

    public abstract partial class PElementSymbol: MetaDslx.CodeAnalysis.Symbols.Impl.DeclarationSymbolImpl
    {
        public new class CompletionParts : MetaDslx.CodeAnalysis.Symbols.Impl.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_IsNamedElement = new __CompletionPart(nameof(Start_IsNamedElement));
            public static readonly __CompletionPart Finish_IsNamedElement = new __CompletionPart(nameof(Finish_IsNamedElement));
            public static readonly __CompletionPart Start_ContainingPAlternativeSymbol = new __CompletionPart(nameof(Start_ContainingPAlternativeSymbol));
            public static readonly __CompletionPart Finish_ContainingPAlternativeSymbol = new __CompletionPart(nameof(Finish_ContainingPAlternativeSymbol));
            public static readonly __CompletionPart Start_Value = new __CompletionPart(nameof(Start_Value));
            public static readonly __CompletionPart Finish_Value = new __CompletionPart(nameof(Finish_Value));
            public static readonly __CompletionPart Start_Assignment = new __CompletionPart(nameof(Start_Assignment));
            public static readonly __CompletionPart Finish_Assignment = new __CompletionPart(nameof(Finish_Assignment));
            public static readonly __CompletionPart Start_ExpectedType = new __CompletionPart(nameof(Start_ExpectedType));
            public static readonly __CompletionPart Finish_ExpectedType = new __CompletionPart(nameof(Finish_ExpectedType));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    MetaDslx.CodeAnalysis.Symbols.Impl.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_IsNamedElement, Finish_IsNamedElement
                    , Start_ContainingPAlternativeSymbol, Finish_ContainingPAlternativeSymbol
                    , Start_Value, Finish_Value
                    , Start_Assignment, Finish_Assignment
                    , Start_ExpectedType, Finish_ExpectedType
                );
        }

        private bool _isNamedElement;
        private PAlternativeSymbol? _containingPAlternativeSymbol;
        private global::MetaDslx.CodeAnalysis.MetaSymbol _value;
        private global::MetaDslx.Languages.MetaCompiler.Model.Assignment _assignment;
        private global::MetaDslx.CodeAnalysis.MetaType _expectedType;
        private global::MetaDslx.Languages.MetaCompiler.Model.ExpectedTypeKind _expectedKind;

        public PElementSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.MetaSymbol value = default, global::MetaDslx.Languages.MetaCompiler.Model.Assignment assignment = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes)
        {
            if (fixedSymbol)
            {
                _value = value;
                _assignment = assignment;
            }
        }

[__Phase]
[__Derived]
        public bool IsNamedElement
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsNamedElement, null, default);
                return _isNamedElement;
            }
        }
[__Phase]
[__Derived]
        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ContainingPAlternativeSymbol, null, default);
                return _containingPAlternativeSymbol;
            }
        }
        [__ModelProperty]
[__Phase]
        public global::MetaDslx.CodeAnalysis.MetaSymbol Value
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Value, null, default);
                return _value;
            }
        }
        [__ModelProperty]
[__Phase]
        public global::MetaDslx.Languages.MetaCompiler.Model.Assignment Assignment
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Assignment, null, default);
                return _assignment;
            }
        }
[__Phase]
[__Derived]
        public global::MetaDslx.CodeAnalysis.MetaType ExpectedType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ExpectedType, null, default);
                return _expectedType;
            }
        }
[__Phase(nameof(ExpectedType))]
[__Derived]
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
                    var result = Compute_IsNamedElement(diagnostics, cancellationToken);
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
                    var result = Compute_ContainingPAlternativeSymbol(diagnostics, cancellationToken);
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
                    var result = Compute_Value(diagnostics, cancellationToken);
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
                    var result = Compute_Assignment(diagnostics, cancellationToken);
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
                    var result = Compute_ExpectedType(diagnostics, cancellationToken);
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


        protected abstract bool Compute_IsNamedElement(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract PAlternativeSymbol? Compute_ContainingPAlternativeSymbol(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected virtual global::MetaDslx.CodeAnalysis.MetaSymbol Compute_Value(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }

        protected virtual global::MetaDslx.Languages.MetaCompiler.Model.Assignment Compute_Assignment(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.Languages.MetaCompiler.Model.Assignment>(this, nameof(Assignment), diagnostics, cancellationToken);
        }

        protected abstract (global::MetaDslx.CodeAnalysis.MetaType ExpectedType, global::MetaDslx.Languages.MetaCompiler.Model.ExpectedTypeKind ExpectedKind) Compute_ExpectedType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
