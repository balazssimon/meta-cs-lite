namespace MetaDslx.CodeAnalysis.Symbols
{
    using __Type = global::System.Type;
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

    [SymbolAttribute]
    public abstract partial class TypeSymbol: Impl.DeclarationSymbolImpl
    {
        public new class CompletionParts : Impl.DeclarationSymbolImpl.CompletionParts
        {
            public static readonly __CompletionPart Start_IsReferenceType = new __CompletionPart(nameof(Start_IsReferenceType));
            public static readonly __CompletionPart Finish_IsReferenceType = new __CompletionPart(nameof(Finish_IsReferenceType));
            public static readonly __CompletionPart Start_IsValueType = new __CompletionPart(nameof(Start_IsValueType));
            public static readonly __CompletionPart Finish_IsValueType = new __CompletionPart(nameof(Finish_IsValueType));
            public static readonly __CompletionPart Start_TypeParameters = new __CompletionPart(nameof(Start_TypeParameters));
            public static readonly __CompletionPart Finish_TypeParameters = new __CompletionPart(nameof(Finish_TypeParameters));
            public static readonly __CompletionPart Start_BaseTypes = new __CompletionPart(nameof(Start_BaseTypes));
            public static readonly __CompletionPart Finish_BaseTypes = new __CompletionPart(nameof(Finish_BaseTypes));
            public static readonly __CompletionPart Start_AllBaseTypes = new __CompletionPart(nameof(Start_AllBaseTypes));
            public static readonly __CompletionPart Finish_AllBaseTypes = new __CompletionPart(nameof(Finish_AllBaseTypes));

            public static readonly __CompletionGraph CompletionGraph = 
                __CompletionGraph.CreateFromParts(
                    Impl.DeclarationSymbolImpl.CompletionParts.CompletionGraph
                    , Start_IsReferenceType, Finish_IsReferenceType
                    , Start_IsValueType, Finish_IsValueType
                    , Start_TypeParameters, Finish_TypeParameters
                    , Start_BaseTypes, Finish_BaseTypes
                    , Start_AllBaseTypes, Finish_AllBaseTypes
                );
        }

        private bool _isReferenceType;
        private bool _isValueType;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeParameters = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_BaseTypes = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private global::System.Collections.Immutable.ImmutableArray<TypeSymbol> _allBaseTypes;

        public TypeSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, bool isReferenceType = default, bool isValueType = default, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            if (fixedSymbol)
            {
                _isReferenceType = isReferenceType;
                _isValueType = isValueType;
                if (!typeParameters.IsDefaultOrEmpty)
                {
                    s_TypeParameters.Add(this, typeParameters);
                }
                if (!baseTypes.IsDefaultOrEmpty)
                {
                    s_BaseTypes.Add(this, baseTypes);
                }
            }
        }

        public override __Type SymbolType => typeof(TypeSymbol);
        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [__ModelProperty]
        [__Phase]
        public bool IsReferenceType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsReferenceType, null, default);
                return _isReferenceType;
            }
        }
        [__ModelProperty]
        [__Phase]
        public bool IsValueType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsValueType, null, default);
                return _isValueType;
            }
        }
        [__ModelProperty]
        [__Phase]
        [__Weak]
        public global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_TypeParameters, null, default);
                if (s_TypeParameters.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>.Empty;
            }
        }
        [__ModelProperty]
        [__Phase]
        [__Weak]
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_BaseTypes, null, default);
                if (s_BaseTypes.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }
        [__Phase]
        [__Derived]
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_AllBaseTypes, null, default);
                return _allBaseTypes;
            }
        }


        public abstract bool IsDerivedFrom(TypeSymbol type, global::MetaDslx.CodeAnalysis.Symbols.TypeEqualityComparer comparison);

        public abstract bool IsEqualToOrDerivedFrom(TypeSymbol type, global::MetaDslx.CodeAnalysis.Symbols.TypeEqualityComparer comparison);

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_IsReferenceType || incompletePart == CompletionParts.Finish_IsReferenceType)
            {
                if (NotePartComplete(CompletionParts.Start_IsReferenceType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_IsReferenceType(diagnostics, cancellationToken);
                    _isReferenceType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsReferenceType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_IsValueType || incompletePart == CompletionParts.Finish_IsValueType)
            {
                if (NotePartComplete(CompletionParts.Start_IsValueType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_IsValueType(diagnostics, cancellationToken);
                    _isValueType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_IsValueType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_TypeParameters || incompletePart == CompletionParts.Finish_TypeParameters)
            {
                if (NotePartComplete(CompletionParts.Start_TypeParameters))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_TypeParameters(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeParameters.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_TypeParameters);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_BaseTypes || incompletePart == CompletionParts.Finish_BaseTypes)
            {
                if (NotePartComplete(CompletionParts.Start_BaseTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_BaseTypes(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_BaseTypes.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_BaseTypes);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_AllBaseTypes || incompletePart == CompletionParts.Finish_AllBaseTypes)
            {
                if (NotePartComplete(CompletionParts.Start_AllBaseTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Compute_AllBaseTypes(diagnostics, cancellationToken);
                    _allBaseTypes = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_AllBaseTypes);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual bool Compute_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsReferenceType), diagnostics, cancellationToken);
        }

        protected virtual bool Compute_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsValueType), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Compute_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<TypeParameterSymbol>(this, nameof(TypeParameters), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Compute_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(this, nameof(BaseTypes), diagnostics, cancellationToken);
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Compute_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
