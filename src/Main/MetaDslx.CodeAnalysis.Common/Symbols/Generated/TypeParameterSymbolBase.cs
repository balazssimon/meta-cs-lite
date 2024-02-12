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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<TypeParameterSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    internal abstract class TypeParameterSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolBase, TypeParameterSymbol
    {
        protected TypeParameterSymbolBase() 
            : base()
        {
        }

        protected TypeParameterSymbolBase(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected TypeParameterSymbolBase(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        protected TypeParameterSymbolBase(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        protected TypeParameterSymbolBase(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        protected TypeParameterSymbolBase(Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
        }

        protected TypeParameterSymbolBase(Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, modelObject, name, metadataName, attributes)
        {
        }

        protected TypeParameterSymbolBase(Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
        }

        protected TypeParameterSymbolBase(Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes)
            : base(container, errorInfo, name, metadataName, attributes)
        {
        }

        protected sealed override __CompletionGraph CompletionGraph => TypeParameterSymbol.CompletionParts.CompletionGraph;

        public abstract bool IsReferenceType { get; }
        public abstract bool IsValueType { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes { get; }
        public abstract global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility { get; }
        public abstract bool IsStatic { get; }
        public abstract bool IsExtern { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports { get; }
        public abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members { get; }


        protected abstract bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>) Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);

        protected abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }

    internal sealed class TypeParameterSymbolDefaultImpl : TypeParameterSymbolBase
    {
        private bool _isReferenceType;
        private bool _isValueType;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeParameters = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_BaseTypes = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private global::System.Collections.Immutable.ImmutableArray<TypeSymbol> _allBaseTypes;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_DeclaredAccessibility = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private bool _isStatic;
        private bool _isExtern;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeArguments = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_Imports = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _members;

        public TypeParameterSymbolDefaultImpl(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public TypeParameterSymbolDefaultImpl(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public TypeParameterSymbolDefaultImpl(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public TypeParameterSymbolDefaultImpl(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public TypeParameterSymbolDefaultImpl(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
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
            _allBaseTypes = allBaseTypes;
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }

        public TypeParameterSymbolDefaultImpl(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, modelObject, name, metadataName, attributes)
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
            _allBaseTypes = allBaseTypes;
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }

        public TypeParameterSymbolDefaultImpl(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, csharpSymbol, name, metadataName, attributes)
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
            _allBaseTypes = allBaseTypes;
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }

        public TypeParameterSymbolDefaultImpl(__Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, bool isReferenceType, bool isValueType, global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> typeParameters, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> baseTypes, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> allBaseTypes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, errorInfo, name, metadataName, attributes)
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
            _allBaseTypes = allBaseTypes;
            if (declaredAccessibility != default)
            {
                s_DeclaredAccessibility.Add(this, declaredAccessibility);
            }
            _isStatic = isStatic;
            _isExtern = isExtern;
            if (!typeArguments.IsDefaultOrEmpty)
            {
                s_TypeArguments.Add(this, typeArguments);
            }
            if (!imports.IsDefaultOrEmpty)
            {
                s_Imports.Add(this, imports);
            }
            _members = members;
        }


        public override bool IsReferenceType
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_IsReferenceType, null, default);
                return _isReferenceType;
            }
        }

        public override bool IsValueType
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_IsValueType, null, default);
                return _isValueType;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_TypeParameters, null, default);
                if (s_TypeParameters.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>.Empty;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_BaseTypes, null, default);
                if (s_BaseTypes.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_AllBaseTypes, null, default);
                return _allBaseTypes;
            }
        }

        public override global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_DeclaredAccessibility, null, default);
                if (s_DeclaredAccessibility.TryGetValue(this, out var result)) return (global::MetaDslx.CodeAnalysis.Accessibility)result;
                else return default;
            }
        }

        public override bool IsStatic
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_IsStatic, null, default);
                return _isStatic;
            }
        }

        public override bool IsExtern
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_IsExtern, null, default);
                return _isExtern;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_TypeArguments, null, default);
                if (s_TypeArguments.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_Imports, null, default);
                if (s_Imports.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<ImportSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
            }
        }

        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members
        {
            get
            {
                this.ForceComplete(TypeParameterSymbol.CompletionParts.Finish_Members, null, default);
                return _members;
            }
        }

        protected sealed override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == TypeParameterSymbol.CompletionParts.Start_IsReferenceType || incompletePart == TypeParameterSymbol.CompletionParts.Finish_IsReferenceType)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_IsReferenceType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsReferenceType(diagnostics, cancellationToken);
                    _isReferenceType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_IsReferenceType);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_IsValueType || incompletePart == TypeParameterSymbol.CompletionParts.Finish_IsValueType)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_IsValueType))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsValueType(diagnostics, cancellationToken);
                    _isValueType = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_IsValueType);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_TypeParameters || incompletePart == TypeParameterSymbol.CompletionParts.Finish_TypeParameters)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_TypeParameters))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_TypeParameters(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeParameters.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_TypeParameters);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_BaseTypes || incompletePart == TypeParameterSymbol.CompletionParts.Finish_BaseTypes)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_BaseTypes))
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
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_BaseTypes);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_AllBaseTypes || incompletePart == TypeParameterSymbol.CompletionParts.Finish_AllBaseTypes)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_AllBaseTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_AllBaseTypes(diagnostics, cancellationToken);
                    _allBaseTypes = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_AllBaseTypes);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_DeclaredAccessibility || incompletePart == TypeParameterSymbol.CompletionParts.Finish_DeclaredAccessibility)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_DeclaredAccessibility))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_DeclaredAccessibility(diagnostics, cancellationToken);
                    if (result != default)
                    {
                        s_DeclaredAccessibility.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_DeclaredAccessibility);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_IsStatic || incompletePart == TypeParameterSymbol.CompletionParts.Finish_IsStatic)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_IsStatic))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsStatic(diagnostics, cancellationToken);
                    _isStatic = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_IsStatic);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_IsExtern || incompletePart == TypeParameterSymbol.CompletionParts.Finish_IsExtern)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_IsExtern))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsExtern(diagnostics, cancellationToken);
                    _isExtern = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_IsExtern);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_TypeArguments || incompletePart == TypeParameterSymbol.CompletionParts.Finish_TypeArguments)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_TypeArguments))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_TypeArguments(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeArguments.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_TypeArguments);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_Imports || incompletePart == TypeParameterSymbol.CompletionParts.Finish_Imports)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_Imports))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Imports(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_Imports.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_Imports);
                }
                return true;
            }
            else if (incompletePart == TypeParameterSymbol.CompletionParts.Start_Members || incompletePart == TypeParameterSymbol.CompletionParts.Finish_Members)
            {
                if (NotePartComplete(TypeParameterSymbol.CompletionParts.Start_Members))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Members(diagnostics, cancellationToken);
                    _members = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(TypeParameterSymbol.CompletionParts.Finish_Members);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected override bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsReferenceType(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsValueType(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_TypeParameters(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>, global::System.Collections.Immutable.ImmutableArray<TypeSymbol>) Complete_BaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_BaseTypes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_AllBaseTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_AllBaseTypes(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsStatic(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsExtern(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_TypeArguments(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_Imports(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = TypeParameterSymbolImpl.GetInstance(this);
            var result = impl.Complete_Members(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    internal sealed partial class TypeParameterSymbolImpl
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new TypeParameterSymbolImpl(s_poolInstance), 32);

        private readonly __ObjectPool _pool;

        private TypeParameterSymbolImpl(__ObjectPool pool) 
            : base()
        {
            _pool = pool;
        }

        public static TypeParameterSymbolImpl GetInstance(TypeParameterSymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__WrappedInstance is null);
            __InitInstance(result, wrapped);
            return result;
        }

        public void Free()
        {
            this.__ClearInstance();
            _pool?.Free(this);
        }

        public override bool IsReferenceType => ((TypeParameterSymbol)__WrappedInstance).IsReferenceType;
        public override bool IsValueType => ((TypeParameterSymbol)__WrappedInstance).IsValueType;
        public override global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> TypeParameters => ((TypeParameterSymbol)__WrappedInstance).TypeParameters;
        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> BaseTypes => ((TypeParameterSymbol)__WrappedInstance).BaseTypes;
        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> AllBaseTypes => ((TypeParameterSymbol)__WrappedInstance).AllBaseTypes;
        public override global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility => ((TypeParameterSymbol)__WrappedInstance).DeclaredAccessibility;
        public override bool IsStatic => ((TypeParameterSymbol)__WrappedInstance).IsStatic;
        public override bool IsExtern => ((TypeParameterSymbol)__WrappedInstance).IsExtern;
        public override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments => ((TypeParameterSymbol)__WrappedInstance).TypeArguments;
        public override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports => ((TypeParameterSymbol)__WrappedInstance).Imports;
        public override global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members => ((TypeParameterSymbol)__WrappedInstance).Members;


        protected override bool Complete_IsReferenceType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        protected override bool Complete_IsValueType(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol> Complete_TypeParameters(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<TypeParameterSymbol>.Empty;
        }



        protected override global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        protected override bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        protected override bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
        }

        protected override global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
        }

    }
}
