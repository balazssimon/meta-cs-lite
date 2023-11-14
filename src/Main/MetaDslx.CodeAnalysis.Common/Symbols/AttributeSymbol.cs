using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Text;
using System.Threading;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public abstract partial class AttributeSymbol : Symbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_AttributeClass = new CompletionPart(nameof(StartComputingProperty_AttributeClass));
            public static readonly CompletionPart FinishComputingProperty_AttributeClass = new CompletionPart(nameof(FinishComputingProperty_AttributeClass));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    CompletionGraph.StartInitializing, CompletionGraph.FinishInitializing,
                    CompletionGraph.StartCreatingContainedSymbols, CompletionGraph.FinishCreatingContainedSymbols,
                    StartComputingProperty_AttributeClass, FinishComputingProperty_AttributeClass,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes,
                    CompletionGraph.StartComputingNonSymbolProperties, CompletionGraph.FinishComputingNonSymbolProperties,
                    CompletionGraph.ContainedSymbolsFinalized,
                    CompletionGraph.StartFinalizing, CompletionGraph.FinishFinalizing,
                    CompletionGraph.ContainedSymbolsCompleted,
                    CompletionGraph.StartValidating, CompletionGraph.FinishValidating);
        }

        private TypeSymbol _attributeClass;

        protected AttributeSymbol(Symbol container) 
            : base(container)
        {
        }

        [ModelProperty]
        public TypeSymbol AttributeClass
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_AttributeClass, null, default);
                return _attributeClass;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_AttributeClass || incompletePart == CompletionParts.FinishComputingProperty_AttributeClass)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_AttributeClass))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    var attributeClass = CompleteProperty_AttributeClass(diagnostics, cancellationToken);
                    Interlocked.CompareExchange(ref _attributeClass, attributeClass, null);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_AttributeClass);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual TypeSymbol CompleteProperty_AttributeClass(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return null;
        }

    }
}
