using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Languages.MetaCompiler.Compiler.Syntax;
using MetaDslx.Languages.MetaCompiler.Model;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    internal class PAlternativeSymbol : SourceDeclarationSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_ReturnType = new CompletionPart(nameof(StartComputingProperty_ReturnType));
            public static readonly CompletionPart FinishComputingProperty_ReturnType = new CompletionPart(nameof(FinishComputingProperty_ReturnType));
            public static readonly CompletionPart StartComputingProperty_NeverNull = new CompletionPart(nameof(StartComputingProperty_NeverNull));
            public static readonly CompletionPart FinishComputingProperty_NeverNull = new CompletionPart(nameof(FinishComputingProperty_NeverNull));
            public static readonly CompletionPart StartComputingProperty_Elements = new CompletionPart(nameof(StartComputingProperty_Elements));
            public static readonly CompletionPart FinishComputingProperty_Elements = new CompletionPart(nameof(FinishComputingProperty_Elements));
            public static readonly CompletionPart StartComputingProperty_ReturnValue = new CompletionPart(nameof(StartComputingProperty_ReturnValue));
            public static readonly CompletionPart FinishComputingProperty_ReturnValue = new CompletionPart(nameof(FinishComputingProperty_ReturnValue));
            public static readonly CompletionPart StartComputingProperty_ExpectedTypes = new CompletionPart(nameof(StartComputingProperty_ExpectedTypes));
            public static readonly CompletionPart FinishComputingProperty_ExpectedTypes = new CompletionPart(nameof(FinishComputingProperty_ExpectedTypes));
            public static readonly CompletionPart StartComputingProperty_Members = DeclarationSymbol.CompletionParts.StartComputingProperty_Members;
            public static readonly CompletionPart FinishComputingProperty_Members = DeclarationSymbol.CompletionParts.FinishComputingProperty_Members;
            public static readonly CompletionPart StartComputingProperty_TypeArguments = DeclarationSymbol.CompletionParts.StartComputingProperty_TypeArguments;
            public static readonly CompletionPart FinishComputingProperty_TypeArguments = DeclarationSymbol.CompletionParts.FinishComputingProperty_TypeArguments;
            public static readonly CompletionPart StartComputingProperty_Imports = DeclarationSymbol.CompletionParts.StartComputingProperty_Imports;
            public static readonly CompletionPart FinishComputingProperty_Imports = DeclarationSymbol.CompletionParts.FinishComputingProperty_Imports;
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_ReturnType, FinishComputingProperty_ReturnType,
                    StartComputingProperty_NeverNull, FinishComputingProperty_NeverNull,
                    StartComputingProperty_Elements, FinishComputingProperty_Elements,
                    StartComputingProperty_ReturnValue, FinishComputingProperty_ReturnValue,
                    StartComputingProperty_ExpectedTypes, FinishComputingProperty_ExpectedTypes,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private bool _isResolvingExpectedTypes;
        private ImmutableArray<MetaType> _expectedTypes;
        private MetaType _returnType;
        private bool _neverNull;
        private ExpressionSymbol _returnValue;
        private ImmutableArray<PElementSymbol> _elements;
        private ImmutableArray<PElementSymbol> _allSimpleElements;

        public PAlternativeSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public AlternativeSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as AlternativeSyntax;

        public GrammarSymbol? ContainingGrammarSymbol => this.GetOutermostContainingSymbol<GrammarSymbol>();

        public ParserRuleSymbol? ContainingParserRuleSymbol => this.ContainingSymbol as ParserRuleSymbol;

        public PBlockSymbol? ContainingPBlockSymbol => this.ContainingSymbol as PBlockSymbol;

        [ModelProperty]
        public MetaType ReturnType
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ReturnType, null, default);
                return _returnType;
            }
        }

        [ModelProperty]
        public bool NeverNull
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_NeverNull, null, default);
                return _neverNull;
            }
        }

        [ModelProperty]
        public ImmutableArray<PElementSymbol> Elements
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Elements, null, default);
                return _elements;
            }
        }

        [ModelProperty]
        public ExpressionSymbol ReturnValue
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ReturnValue, null, default);
                return _returnValue;
            }
        }

        public bool IsResolvingExpectedTypes => _isResolvingExpectedTypes || (this.ContainingPBlockSymbol?.IsResolvingExpectedTypes ?? false);

        public ImmutableArray<MetaType> ExpectedTypes
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedTypes, null, default);
                return _expectedTypes;
            }
        }

        public ImmutableArray<PElementSymbol> AllSimpleElements
        {
            get
            {
                if (_allSimpleElements.IsDefault)
                {
                    var builder = ArrayBuilder<PElementSymbol>.GetInstance();
                    foreach (var elem in Elements)
                    {
                        if (elem.Value.OriginalSymbol is PBlockSymbol pbs)
                        {
                            foreach (var balt in pbs.Alternatives)
                            {
                                builder.AddRange(balt.AllSimpleElements);
                            }
                        }
                        else
                        {
                            builder.Add(elem);
                        }
                    }
                    builder.AddRange(Elements);
                    ImmutableInterlocked.InterlockedInitialize(ref _allSimpleElements, builder.ToImmutableAndFree());
                }
                return _allSimpleElements;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_ReturnType || incompletePart == CompletionParts.FinishComputingProperty_ReturnType)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ReturnType))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _returnType = CompleteProperty_ReturnType(diagnostics, cancellationToken);
                    if (ModelObject is Alternative palt) palt.ReturnType = _returnType;
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ReturnType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_NeverNull || incompletePart == CompletionParts.FinishComputingProperty_NeverNull)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_NeverNull))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _neverNull = CompleteProperty_NeverNull(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_NeverNull);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Elements || incompletePart == CompletionParts.FinishComputingProperty_Elements)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Elements))
                {
                    _isResolvingExpectedTypes = true;
                    var diagnostics = DiagnosticBag.GetInstance();
                    _elements = CompleteProperty_Elements(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Elements);
                    _isResolvingExpectedTypes = false;
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ReturnValue || incompletePart == CompletionParts.FinishComputingProperty_ReturnValue)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ReturnValue))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _returnValue = CompleteProperty_ReturnValue(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ReturnValue);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ExpectedTypes || incompletePart == CompletionParts.FinishComputingProperty_ExpectedTypes)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ExpectedTypes))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _expectedTypes = CompleteProperty_ExpectedTypes(diagnostics, cancellationToken);
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
            var nameSyntax = this.Syntax?.Block1?.Name;
            return Declaration.Language.SyntaxFacts.ExtractName(nameSyntax);
        }

        protected virtual MetaType CompleteProperty_ReturnType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var returnType = SymbolFactory.GetSymbolPropertyValue<MetaType>(this, nameof(ReturnType), diagnostics, cancellationToken);
            if (returnType.IsNull)
            {
                var block = this.ContainingPBlockSymbol;
                if (block is not null)
                {
                    returnType = block.ReturnType;
                }
            }
            if (returnType.IsNull)
            {
                var rule = this.ContainingParserRuleSymbol;
                if (rule is not null)
                {
                    returnType = rule.ReturnType;
                }
            }
            return returnType;
        }

        protected virtual bool CompleteProperty_NeverNull(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(NeverNull), diagnostics, cancellationToken);
        }

        protected virtual ImmutableArray<PElementSymbol> CompleteProperty_Elements(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PElementSymbol>(this, nameof(Elements), diagnostics, cancellationToken);
        }

        protected virtual ExpressionSymbol CompleteProperty_ReturnValue(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<ExpressionSymbol>(this, nameof(ReturnValue), diagnostics, cancellationToken);
        }

        protected virtual ImmutableArray<MetaType> CompleteProperty_ExpectedTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            if (!this.ReturnType.IsNull)
            {
                return ImmutableArray.Create(this.ReturnType);
            }
            var block = this.ContainingPBlockSymbol;
            if (block is not null && !block.IsResolvingExpectedTypes)
            {
                return block.ExpectedTypes;
            }
            var rule = this.ContainingParserRuleSymbol;
            if (rule is not null)
            {
                return rule.ExpectedTypes;
            }
            return ImmutableArray<MetaType>.Empty;
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            var rule = this.ContainingParserRuleSymbol;
            if (rule is not null)
            {
                if (!rule.ReturnType.IsAssignableFrom(this.ReturnType))
                {
                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_IncompatibleAltReturnType, this.Location, this.ReturnType, this.Name, rule.ReturnType, rule.Name));
                }
            }
        }
    }
}
