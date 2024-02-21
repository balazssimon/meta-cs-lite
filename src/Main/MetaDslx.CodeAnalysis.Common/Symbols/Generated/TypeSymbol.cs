namespace MetaDslx.CodeAnalysis.Symbols
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

public abstract partial class TypeSymbol: Impl.DeclarationSymbolImpl
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
            public static readonly CompletionPart Start_IsReferenceType = new CompletionPart(nameof(Start_IsReferenceType));
            public static readonly CompletionPart Finish_IsReferenceType = new CompletionPart(nameof(Finish_IsReferenceType));
            public static readonly CompletionPart Start_IsValueType = new CompletionPart(nameof(Start_IsValueType));
            public static readonly CompletionPart Finish_IsValueType = new CompletionPart(nameof(Finish_IsValueType));
            public static readonly CompletionPart Start_TypeParameters = new CompletionPart(nameof(Start_TypeParameters));
            public static readonly CompletionPart Finish_TypeParameters = new CompletionPart(nameof(Finish_TypeParameters));
            public static readonly CompletionPart Start_BaseTypes = new CompletionPart(nameof(Start_BaseTypes));
            public static readonly CompletionPart Finish_BaseTypes = new CompletionPart(nameof(Finish_BaseTypes));
            public static readonly CompletionPart Start_AllBaseTypes = new CompletionPart(nameof(Start_AllBaseTypes));
            public static readonly CompletionPart Finish_AllBaseTypes = new CompletionPart(nameof(Finish_AllBaseTypes));
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
                    Start_IsReferenceType, Finish_IsReferenceType,
                    Start_IsValueType, Finish_IsValueType,
                    Start_TypeParameters, Finish_TypeParameters,
                    Start_BaseTypes, Finish_BaseTypes,
                    Start_AllBaseTypes, Finish_AllBaseTypes,
                    Start_Attributes, Finish_Attributes
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

        [__ModelProperty]
        public bool IsReferenceType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsReferenceType, null, default);
                return _isReferenceType;
            }
        }
        [__ModelProperty]
        public bool IsValueType
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_IsValueType, null, default);
                return _isValueType;
            }
        }
        [__ModelProperty]
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
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_BaseTypes, null, default);
                if (s_BaseTypes.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }
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
                    var result = Complete_IsReferenceType(diagnostics, cancellationToken);
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
                    var result = Complete_IsValueType(diagnostics, cancellationToken);
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
                    var result = Complete_TypeParameters(diagnostics, cancellationToken);
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
                    var result = Complete_BaseTypes(diagnostics, cancellationToken);
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
                    var result = Complete_AllBaseTypes(diagnostics, cancellationToken);
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


        protected virtual bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsReferenceType), diagnostics, cancellationToken);
        }

        protected virtual bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsValueType), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<TypeParameterSymbol>(this, nameof(TypeParameters), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<TypeSymbol>(this, nameof(BaseTypes), diagnostics, cancellationToken);
        }

        protected abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
