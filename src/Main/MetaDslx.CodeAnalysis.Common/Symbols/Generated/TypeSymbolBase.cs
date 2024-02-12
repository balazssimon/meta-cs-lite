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

    internal abstract class TypeSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolBase, TypeSymbol
    {
        private bool _isReferenceType;
        private bool _isValueType;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>> s_TypeParameters = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>> s_BaseTypes = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>();
        private global::System.Collections.Immutable.ImmutableArray<TypeSymbol> _allBaseTypes;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_DeclaredAccessibility = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private bool _isStatic;
        private bool _isExtern;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>> s_TypeArguments = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<ImportSymbol>> s_Imports = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, global::System.Collections.Immutable.ImmutableArray<ImportSymbol>>();
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _members;

        protected TypeSymbolBase(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected TypeSymbolBase(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected TypeSymbolBase(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected TypeSymbolBase(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        protected override __CompletionGraph CompletionGraph => TypeSymbol.CompletionParts.CompletionGraph;

        [__ModelProperty]
        public bool IsReferenceType
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_IsReferenceType, null, default);
                return _isReferenceType;
            }
        }
        [__ModelProperty]
        public bool IsValueType
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_IsValueType, null, default);
                return _isValueType;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_TypeParameters, null, default);
                if (s_TypeParameters.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>.Empty;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_BaseTypes, null, default);
                if (s_BaseTypes.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_AllBaseTypes, null, default);
                return _allBaseTypes;
            }
        }
        [__ModelProperty]
        public global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_DeclaredAccessibility, null, default);
                if (s_DeclaredAccessibility.TryGetValue(this, out var result)) return (global::MetaDslx.CodeAnalysis.Accessibility)result;
                else return default;
            }
        }
        [__ModelProperty]
        public bool IsStatic
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_IsStatic, null, default);
                return _isStatic;
            }
        }
        [__ModelProperty]
        public bool IsExtern
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_IsExtern, null, default);
                return _isExtern;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_TypeArguments, null, default);
                if (s_TypeArguments.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_Imports, null, default);
                if (s_Imports.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<ImportSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members
        {
            get
            {
                this.ForceComplete(TypeSymbol.CompletionParts.Finish_Members, null, default);
                return _members;
            }
        }

        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == TypeSymbol.CompletionParts.Start_IsReferenceType || incompletePart == TypeSymbol.CompletionParts.Finish_IsReferenceType)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_IsReferenceType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsReferenceType(diagnostics, cancellationToken);
                    _isReferenceType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_IsReferenceType);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_IsValueType || incompletePart == TypeSymbol.CompletionParts.Finish_IsValueType)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_IsValueType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsValueType(diagnostics, cancellationToken);
                    _isValueType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_IsValueType);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_TypeParameters || incompletePart == TypeSymbol.CompletionParts.Finish_TypeParameters)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_TypeParameters))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_TypeParameters(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeParameters.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_TypeParameters);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_BaseTypes || incompletePart == TypeSymbol.CompletionParts.Finish_BaseTypes)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_BaseTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_BaseTypes(diagnostics, cancellationToken);
                    if (!result.BaseTypes.IsDefaultOrEmpty)
                    {
                        s_BaseTypes.Add(this, result.BaseTypes);
                    }
                    _allBaseTypes = result.AllBaseTypes;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_BaseTypes);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_AllBaseTypes || incompletePart == TypeSymbol.CompletionParts.Finish_AllBaseTypes)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_AllBaseTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_AllBaseTypes(diagnostics, cancellationToken);
                    _allBaseTypes = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_AllBaseTypes);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_DeclaredAccessibility || incompletePart == TypeSymbol.CompletionParts.Finish_DeclaredAccessibility)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_DeclaredAccessibility))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_DeclaredAccessibility(diagnostics, cancellationToken);
                    if (result != default)
                    {
                        s_DeclaredAccessibility.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_DeclaredAccessibility);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_IsStatic || incompletePart == TypeSymbol.CompletionParts.Finish_IsStatic)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_IsStatic))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsStatic(diagnostics, cancellationToken);
                    _isStatic = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_IsStatic);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_IsExtern || incompletePart == TypeSymbol.CompletionParts.Finish_IsExtern)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_IsExtern))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsExtern(diagnostics, cancellationToken);
                    _isExtern = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_IsExtern);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_TypeArguments || incompletePart == TypeSymbol.CompletionParts.Finish_TypeArguments)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_TypeArguments))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_TypeArguments(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeArguments.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_TypeArguments);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_Imports || incompletePart == TypeSymbol.CompletionParts.Finish_Imports)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_Imports))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Imports(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_Imports.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_Imports);
                }
                return true;
            }
            else if (incompletePart == TypeSymbol.CompletionParts.Start_Members || incompletePart == TypeSymbol.CompletionParts.Finish_Members)
            {
                if (NotePartComplete(TypeSymbol.CompletionParts.Start_Members))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Members(diagnostics, cancellationToken);
                    _members = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeSymbol.CompletionParts.Finish_Members);
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
            return default;
        }
        protected virtual bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>.Empty;
        }
        protected abstract (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>) Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
        protected abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
        protected virtual global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
        protected virtual bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
        protected virtual bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }
        protected virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
        }
        protected virtual global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
        }
        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }
}
