using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis.Symbols.Source;
using System.Collections.Immutable;
using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaModel.Compiler.Syntax;
using MetaDslx.Bootstrap.MetaCompiler.Model;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;

    internal class PElementSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_SymbolProperty = new CompletionPart(nameof(StartComputingProperty_SymbolProperty));
            public static readonly CompletionPart FinishComputingProperty_SymbolProperty = new CompletionPart(nameof(FinishComputingProperty_SymbolProperty));
            public static readonly CompletionPart StartComputingProperty_ExpectedTypes = new CompletionPart(nameof(StartComputingProperty_ExpectedTypes));
            public static readonly CompletionPart FinishComputingProperty_ExpectedTypes = new CompletionPart(nameof(FinishComputingProperty_ExpectedTypes));
            public static readonly CompletionPart StartComputingProperty_Value = new CompletionPart(nameof(StartComputingProperty_Value));
            public static readonly CompletionPart FinishComputingProperty_Value = new CompletionPart(nameof(FinishComputingProperty_Value));
            public static readonly CompletionPart StartComputingProperty_Members = DeclaredSymbol.CompletionParts.StartComputingProperty_Members;
            public static readonly CompletionPart FinishComputingProperty_Members = DeclaredSymbol.CompletionParts.FinishComputingProperty_Members;
            public static readonly CompletionPart StartComputingProperty_TypeArguments = DeclaredSymbol.CompletionParts.StartComputingProperty_TypeArguments;
            public static readonly CompletionPart FinishComputingProperty_TypeArguments = DeclaredSymbol.CompletionParts.FinishComputingProperty_TypeArguments;
            public static readonly CompletionPart StartComputingProperty_Imports = DeclaredSymbol.CompletionParts.StartComputingProperty_Imports;
            public static readonly CompletionPart FinishComputingProperty_Imports = DeclaredSymbol.CompletionParts.FinishComputingProperty_Imports;
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_SymbolProperty, FinishComputingProperty_SymbolProperty,
                    StartComputingProperty_ExpectedTypes, FinishComputingProperty_ExpectedTypes,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private enum ExpectedTypeKind
        {
            None,
            Bool,
            Collection
        }

        private ImmutableArray<MetaSymbol> _symbolProperty;
        private ImmutableArray<TypeSymbol> _expectedTypes;
        private ExpectedTypeKind _expectedTypeKind;
        private MetaSymbol _value;
        private PAlternativeSymbol? _containingAlternative;

        public PElementSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public PElementSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as PElementSyntax;

        public bool IsNamedElement => Syntax?.PElementBlock1 is not null;

        public GrammarSymbol? ContainingGrammarSymbol => ContainingPAlternativeSymbol?.ContainingGrammarSymbol;

        public ParserRuleSymbol? ContainingParserRuleSymbol => ContainingPAlternativeSymbol?.ContainingParserRuleSymbol;

        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                if (_containingAlternative is null)
                {
                    Interlocked.CompareExchange(ref _containingAlternative, this.GetOutermostContainingSymbol<PAlternativeSymbol>(), null);
                }
                return _containingAlternative;
            }
        }

        [ModelProperty]
        public MetaSymbol Value
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Value, null, default);
                return _value;
            }
        }

        [ModelProperty]
        public ImmutableArray<MetaSymbol> SymbolProperty
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_SymbolProperty, null, default);
                return _symbolProperty;
            }
        }

        public ImmutableArray<TypeSymbol> ExpectedTypes
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedTypes, null, default);
                return _expectedTypes;
            }
        }

        private ExpectedTypeKind ExpectedKind
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedTypes, null, default);
                return _expectedTypeKind;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Value || incompletePart == CompletionParts.FinishComputingProperty_Value)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Value))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _value = CompleteProperty_Value(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Value);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_SymbolProperty || incompletePart == CompletionParts.FinishComputingProperty_SymbolProperty)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_SymbolProperty))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _symbolProperty = CompleteProperty_SymbolProperty(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_SymbolProperty);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ExpectedTypes || incompletePart == CompletionParts.FinishComputingProperty_ExpectedTypes)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ExpectedTypes))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var expectedTypes = CompleteProperty_ExpectedTypes(diagnostics, cancellationToken);
                    _expectedTypes = expectedTypes.ExpectedTypes;
                    _expectedTypeKind = expectedTypes.ExpectedTypeKind;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ExpectedTypes);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var nameSyntax = this.Syntax?.PElementBlock1?.SymbolProperty;
            return Declaration.Language.SyntaxFacts.ExtractName(nameSyntax);
        }

        protected virtual ImmutableArray<MetaSymbol> CompleteProperty_SymbolProperty(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<MetaSymbol>(this, nameof(SymbolProperty), diagnostics, cancellationToken);
        }

        private (ImmutableArray<TypeSymbol> ExpectedTypes, ExpectedTypeKind ExpectedTypeKind) CompleteProperty_ExpectedTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var kind = ExpectedTypeKind.None;
            var result = ArrayBuilder<TypeSymbol>.GetInstance();
            foreach (var prop in SymbolProperty)
            {
                var csProp = prop.OriginalSymbol as ICSharpSymbol;
                var msProp = csProp?.CSharpSymbol as IPropertySymbol;
                var msType = msProp?.Type;
                var csType = msType is null ? null : csProp?.SymbolFactory.GetSymbol<TypeSymbol>(msType, diagnostics, cancellationToken);
                var mtType = MetaType.FromTypeSymbol(csType);
                if (mtType.IsNullable) mtType.TryExtractNullableType(out mtType, diagnostics, cancellationToken);
                if (mtType.IsCollection)
                {
                    kind = ExpectedTypeKind.Collection;
                    mtType.TryExtractCollectionType(out mtType, diagnostics, cancellationToken);
                }
                if (mtType.SpecialType == SpecialType.System_Boolean)
                {
                    if (kind == ExpectedTypeKind.None) kind = ExpectedTypeKind.Bool;
                }
                if (!mtType.IsNull)
                {
                    result.Add(mtType.OriginalTypeSymbol);
                }
                else
                {
                    diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, this.Location, $"Could not determine the type of the property '{prop.Name}'"));
                }
            }
            return (result.ToImmutableAndFree(), kind);
        }

        protected virtual MetaSymbol CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            var mobj = this.ModelObject as PElement;
            if (mobj is not null)
            {
                if (ExpectedKind == ExpectedTypeKind.Collection && mobj.Assignment != Assignment.PlusAssign)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_CollectionPropertyWrongAssignment, this.Location, this.Name));
                }
                else if (ExpectedKind != ExpectedTypeKind.Collection && mobj.Assignment == Assignment.PlusAssign)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonCollectionPropertyWrongAssignment, this.Location, this.Name));
                }
                else if (mobj.Assignment == Assignment.QuestionAssign && ExpectedKind != ExpectedTypeKind.Bool)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonBooleanPropertyWrongAssignment, this.Location, this.Name, "?="));
                }
                else if (mobj.Assignment == Assignment.NegatedAssign && ExpectedKind != ExpectedTypeKind.Bool)
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_NonBooleanPropertyWrongAssignment, this.Location, this.Name, "!="));
                }
            }
        }
    }
}
