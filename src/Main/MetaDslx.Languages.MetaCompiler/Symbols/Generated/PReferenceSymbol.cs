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

public abstract partial class PReferenceSymbol: Impl.DeclarationSymbolImpl
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
            public static readonly CompletionPart Start_Rule = new CompletionPart(nameof(Start_Rule));
            public static readonly CompletionPart Finish_Rule = new CompletionPart(nameof(Finish_Rule));
            public static readonly CompletionPart Start_ReferencedTypes = new CompletionPart(nameof(Start_ReferencedTypes));
            public static readonly CompletionPart Finish_ReferencedTypes = new CompletionPart(nameof(Finish_ReferencedTypes));
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
                    Start_Rule, Finish_Rule,
                    Start_ReferencedTypes, Finish_ReferencedTypes,
                    Start_Attributes, Finish_Attributes
                );
        }

        private global::MetaDslx.CodeAnalysis.MetaSymbol _rule;
        private global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaType> _referencedTypes;

        public PReferenceSymbol(__Symbol? container, __Compilation? compilation = null, __MergedDeclaration? declaration = null, __Model? model = null, __IModelObject? modelObject = null, __ISymbol csharpSymbol = null, __ErrorSymbolInfo? errorInfo = null, bool fixedSymbol = false, string? name = default, string? metadataName = default, global::System.Collections.Immutable.ImmutableArray<AttributeSymbol> attributes = default, global::MetaDslx.CodeAnalysis.MetaSymbol rule = default, global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaType> referencedTypes = default, global::MetaDslx.CodeAnalysis.Accessibility declaredAccessibility = default, bool isStatic = default, bool isExtern = default, global::System.Collections.Immutable.ImmutableArray<TypeSymbol> typeArguments = default, global::System.Collections.Immutable.ImmutableArray<ImportSymbol> imports = default) 
            : base(container, compilation, declaration, model, modelObject, csharpSymbol, errorInfo, fixedSymbol, name, metadataName, attributes, declaredAccessibility: declaredAccessibility, isStatic: isStatic, isExtern: isExtern, typeArguments: typeArguments, imports: imports)
        {
            if (fixedSymbol)
            {
                _rule = rule;
                _referencedTypes = referencedTypes;
            }
        }

        [__ModelProperty]
        public global::MetaDslx.CodeAnalysis.MetaSymbol Rule
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_Rule, null, default);
                return _rule;
            }
        }
        [__ModelProperty]
        public global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaType> ReferencedTypes
        {
            get
            {
                this.ForceComplete(CompletionParts.Finish_ReferencedTypes, null, default);
                return _referencedTypes;
            }
        }


        protected override bool ForceCompletePart(ref __CompletionPart incompletePart, __SourceLocation? locationOpt, __CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.Start_Rule || incompletePart == CompletionParts.Finish_Rule)
            {
                if (NotePartComplete(CompletionParts.Start_Rule))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_Rule(diagnostics, cancellationToken);
                    _rule = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_Rule);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.Start_ReferencedTypes || incompletePart == CompletionParts.Finish_ReferencedTypes)
            {
                if (NotePartComplete(CompletionParts.Start_ReferencedTypes))
                {
                    var diagnostics = __DiagnosticBag.GetInstance();
                    var result = Complete_ReferencedTypes(diagnostics, cancellationToken);
                    _referencedTypes = result;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.Finish_ReferencedTypes);
                }
                return true;
            }
            else 
            {
                return base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken);
            }
        }


        protected virtual global::MetaDslx.CodeAnalysis.MetaSymbol Complete_Rule(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValue<global::MetaDslx.CodeAnalysis.MetaSymbol>(this, nameof(Rule), diagnostics, cancellationToken);
        }

        protected virtual global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.MetaType> Complete_ReferencedTypes(__DiagnosticBag diagnostics, __CancellationToken cancellationToken)
        {
            return ContainingModule!.SymbolFactory.GetSymbolPropertyValues<global::MetaDslx.CodeAnalysis.MetaType>(this, nameof(ReferencedTypes), diagnostics, cancellationToken);
        }
    }
}
