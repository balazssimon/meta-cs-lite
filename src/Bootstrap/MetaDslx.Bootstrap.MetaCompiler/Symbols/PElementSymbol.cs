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

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class PElementSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_SymbolProperty = new CompletionPart(nameof(StartComputingProperty_SymbolProperty));
            public static readonly CompletionPart FinishComputingProperty_SymbolProperty = new CompletionPart(nameof(FinishComputingProperty_SymbolProperty));
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
                    StartComputingProperty_SymbolProperty, FinishComputingProperty_SymbolProperty,
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private ImmutableArray<MetaSymbol> _symbolProperty;
        private MetaSymbol _value;
        private PAlternativeSymbol _containingAlternative;

        public PElementSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public GrammarSymbol? ContainingGrammarSymbol => ContainingPAlternativeSymbol?.ContainingGrammarSymbol;

        public ParserRuleSymbol? ContainingParserRuleSymbol => ContainingPAlternativeSymbol?.ContainingParserRuleSymbol;

        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                if (_containingAlternative is null)
                {
                    var container = this.ContainingSymbol;
                    while (container is not null)
                    {
                        if (container is PAlternativeSymbol pas && pas.ContainingSymbol is ParserRuleSymbol)
                        {
                            Interlocked.CompareExchange(ref _containingAlternative, pas, null);
                            break;
                        }
                        container = container.ContainingSymbol;
                    }
                }
                return _containingAlternative;
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

        [ModelProperty]
        public MetaSymbol Value
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Value, null, default);
                return _value;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_SymbolProperty || incompletePart == CompletionParts.FinishComputingProperty_SymbolProperty)
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
            else if (incompletePart == CompletionParts.StartComputingProperty_Value || incompletePart == CompletionParts.FinishComputingProperty_Value)
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
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected override string? CompleteProperty_Name(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

        protected virtual ImmutableArray<MetaSymbol> CompleteProperty_SymbolProperty(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<MetaSymbol>(this, nameof(SymbolProperty), diagnostics, cancellationToken);
        }

        protected virtual MetaSymbol CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }

    }
}
