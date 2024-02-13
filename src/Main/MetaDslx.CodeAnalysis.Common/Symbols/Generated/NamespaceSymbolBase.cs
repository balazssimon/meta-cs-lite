namespace MetaDslx.CodeAnalysis.Symbols.__Impl
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
    using __ObjectPool = global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<NamespaceSymbolImpl>;
    using __NotImplementedException = global::System.NotImplementedException;
    using __ImmutableAttributeSymbols = global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;

    internal sealed class NamespaceSymbolInst : global::MetaDslx.CodeAnalysis.Symbols.SymbolInst, NamespaceSymbol
    {
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_DeclaredAccessibility = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private bool _isStatic;
        private bool _isExtern;
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_TypeArguments = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private static global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object> s_Imports = new global::System.Runtime.CompilerServices.ConditionalWeakTable<Symbol, object>();
        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> _members;

        public NamespaceSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __IModelObject modelObject) 
            : base(container, modelObject)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __ISymbol csharpSymbol) 
            : base(container, csharpSymbol)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo) 
            : base(container, errorInfo)
        {
        }

        public NamespaceSymbolInst(__Symbol container, __MergedDeclaration declaration, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, declaration, modelObject, name, metadataName, attributes)
        {
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

        public NamespaceSymbolInst(__Symbol container, __IModelObject modelObject, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, modelObject, name, metadataName, attributes)
        {
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

        public NamespaceSymbolInst(__Symbol container, __ISymbol csharpSymbol, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, csharpSymbol, name, metadataName, attributes)
        {
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

        public NamespaceSymbolInst(__Symbol container, __ErrorSymbolInfo errorInfo, string? name, string? metadataName, __ImmutableAttributeSymbols attributes, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility, bool isStatic, bool isExtern, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports, global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> members) 
            : base(container, errorInfo, name, metadataName, attributes)
        {
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


        public global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_DeclaredAccessibility, null, default);
                if (s_DeclaredAccessibility.TryGetValue(this, out var result)) return (global::MetaDslx.CodeAnalysis.Accessibility)result;
                else return default;
            }
        }

        public bool IsStatic
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_IsStatic, null, default);
                return _isStatic;
            }
        }

        public bool IsExtern
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_IsExtern, null, default);
                return _isExtern;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_TypeArguments, null, default);
                if (s_TypeArguments.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<TypeSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_Imports, null, default);
                if (s_Imports.TryGetValue(this, out var result)) return (global::System.Collections.Immutable.ImmutableArray<ImportSymbol>)result;
                else return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
            }
        }

        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members
        {
            get
            {
                this.ForceComplete(NamespaceSymbol.CompletionParts.Finish_Members, null, default);
                return _members;
            }
        }

        protected sealed override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == NamespaceSymbol.CompletionParts.Start_DeclaredAccessibility || incompletePart == NamespaceSymbol.CompletionParts.Finish_DeclaredAccessibility)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_DeclaredAccessibility))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_DeclaredAccessibility(diagnostics, cancellationToken);
                    if (result != default)
                    {
                        s_DeclaredAccessibility.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_DeclaredAccessibility);
                }
                return true;
            }
            else if (incompletePart == NamespaceSymbol.CompletionParts.Start_IsStatic || incompletePart == NamespaceSymbol.CompletionParts.Finish_IsStatic)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_IsStatic))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsStatic(diagnostics, cancellationToken);
                    _isStatic = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_IsStatic);
                }
                return true;
            }
            else if (incompletePart == NamespaceSymbol.CompletionParts.Start_IsExtern || incompletePart == NamespaceSymbol.CompletionParts.Finish_IsExtern)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_IsExtern))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_IsExtern(diagnostics, cancellationToken);
                    _isExtern = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_IsExtern);
                }
                return true;
            }
            else if (incompletePart == NamespaceSymbol.CompletionParts.Start_TypeArguments || incompletePart == NamespaceSymbol.CompletionParts.Finish_TypeArguments)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_TypeArguments))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_TypeArguments(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_TypeArguments.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_TypeArguments);
                }
                return true;
            }
            else if (incompletePart == NamespaceSymbol.CompletionParts.Start_Imports || incompletePart == NamespaceSymbol.CompletionParts.Finish_Imports)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_Imports))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Imports(diagnostics, cancellationToken);
                    if (!result.IsDefaultOrEmpty)
                    {
                        s_Imports.Add(this, result);
                    }
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_Imports);
                }
                return true;
            }
            else if (incompletePart == NamespaceSymbol.CompletionParts.Start_Members || incompletePart == NamespaceSymbol.CompletionParts.Finish_Members)
            {
                if (NotePartComplete(NamespaceSymbol.CompletionParts.Start_Members))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Members(diagnostics, cancellationToken);
                    _members = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(NamespaceSymbol.CompletionParts.Finish_Members);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        private global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = NamespaceSymbolImpl.GetInstance(this);
            var result = impl.Complete_DeclaredAccessibility(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = NamespaceSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsStatic(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = NamespaceSymbolImpl.GetInstance(this);
            var result = impl.Complete_IsExtern(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = NamespaceSymbolImpl.GetInstance(this);
            var result = impl.Complete_TypeArguments(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = NamespaceSymbolImpl.GetInstance(this);
            var result = impl.Complete_Imports(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }

        private global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            var impl = NamespaceSymbolImpl.GetInstance(this);
            var result = impl.Complete_Members(diagnostics, cancellationToken);
            impl.Free();
            return result;
        }
    }

    public abstract class NamespaceSymbolBase : global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl, NamespaceSymbol
    {
        public global::MetaDslx.CodeAnalysis.Accessibility DeclaredAccessibility => ((NamespaceSymbol)__WrappedInstance).]DeclaredAccessibility;
        public bool IsStatic => ((NamespaceSymbol)__WrappedInstance).]IsStatic;
        public bool IsExtern => ((NamespaceSymbol)__WrappedInstance).]IsExtern;
        public global::System.Collections.Immutable.ImmutableArray<TypeSymbol> TypeArguments => ((NamespaceSymbol)__WrappedInstance).]TypeArguments;
        public global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Imports => ((NamespaceSymbol)__WrappedInstance).]Imports;
        public global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Members => ((NamespaceSymbol)__WrappedInstance).]Members;


        public virtual global::MetaDslx.CodeAnalysis.Accessibility Complete_DeclaredAccessibility(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        public virtual bool Complete_IsStatic(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        public virtual bool Complete_IsExtern(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return default;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<TypeSymbol> Complete_TypeArguments(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<TypeSymbol>.Empty;
        }

        public virtual global::System.Collections.Immutable.ImmutableArray<ImportSymbol> Complete_Imports(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return global::System.Collections.Immutable.ImmutableArray<ImportSymbol>.Empty;
        }

        public abstract global::System.Collections.Immutable.ImmutableArray<DeclarationSymbol> Complete_Members(__DiagnosticBag diagnostics, __CancellationToken cancellationToken);
    }

    public sealed partial class NamespaceSymbolImpl : NamespaceSymbolBase
    {
        private static readonly __ObjectPool s_poolInstance = new __ObjectPool(() => new NamespaceSymbolImpl(s_poolInstance), 32);

        private readonly __ObjectPool _pool;

        private NamespaceSymbolImpl(__ObjectPool pool) 
            : base()
        {
            _pool = pool;
        }

        public static NamespaceSymbolImpl GetInstance(NamespaceSymbol wrapped)
        {
            var result = s_poolInstance.Allocate();
            global::System.Diagnostics.Debug.Assert(result.__WrappedInstance is null);
            result.__InitInstance(wrapped);
            return result;
        }

        public void Free()
        {
            this.__ClearInstance();
            _pool?.Free(this);
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
