using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using System.Collections.Immutable;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;

    internal class PBlockSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Alternatives = new CompletionPart(nameof(StartComputingProperty_Alternatives));
            public static readonly CompletionPart FinishComputingProperty_Alternatives = new CompletionPart(nameof(FinishComputingProperty_Alternatives));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_Alternatives, FinishComputingProperty_Alternatives,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private ImmutableArray<PAlternativeSymbol> _alternatives;

        public PBlockSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [ModelProperty]
        public ImmutableArray<PAlternativeSymbol> Alternatives
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Alternatives, null, default);
                return _alternatives;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Alternatives || incompletePart == CompletionParts.FinishComputingProperty_Alternatives)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Alternatives))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _alternatives = CompleteProperty_Alternatives(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Alternatives);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual ImmutableArray<PAlternativeSymbol> CompleteProperty_Alternatives(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PAlternativeSymbol>(this, nameof(Alternatives), diagnostics, cancellationToken);
        }
    }
}
