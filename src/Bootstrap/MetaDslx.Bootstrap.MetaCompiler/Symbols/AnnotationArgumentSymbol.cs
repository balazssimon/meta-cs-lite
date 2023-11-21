using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class AnnotationArgumentSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Parameter = new CompletionPart(nameof(StartComputingProperty_Parameter));
            public static readonly CompletionPart FinishComputingProperty_Parameter = new CompletionPart(nameof(FinishComputingProperty_Parameter));
            public static readonly CompletionPart StartComputingProperty_Value = new CompletionPart(nameof(StartComputingProperty_Value));
            public static readonly CompletionPart FinishComputingProperty_Value = new CompletionPart(nameof(FinishComputingProperty_Value));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_Parameter, FinishComputingProperty_Parameter,
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaSymbol _parameter;
        private ExpressionSymbol _value;

        public AnnotationArgumentSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public AnnotationSymbol? AnnotationSymbol => (AnnotationSymbol)this.ContainingSymbol;

        [ModelProperty]
        public MetaSymbol Parameter
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Parameter, null, default);
                return _parameter;
            }
        }

        [ModelProperty]
        public ExpressionSymbol Value
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Value, null, default);
                return _value;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Parameter || incompletePart == CompletionParts.FinishComputingProperty_Parameter)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Parameter))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _parameter = CompleteProperty_Parameter(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Parameter);
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

        protected virtual MetaSymbol CompleteProperty_Parameter(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaSymbol>(this, nameof(Parameter), diagnostics, cancellationToken);
        }

        protected virtual ExpressionSymbol CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<ExpressionSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }
    }
}
