using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class ExpressionSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_ExpectedType = new CompletionPart(nameof(StartComputingProperty_ExpectedType));
            public static readonly CompletionPart FinishComputingProperty_ExpectedType = new CompletionPart(nameof(FinishComputingProperty_ExpectedType));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_ExpectedType, FinishComputingProperty_ExpectedType,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaType _expectedType;
        private PAlternativeSymbol? _containingAlternative;
        private AnnotationArgumentSymbol? _containingAnnotationArgument;

        public ExpressionSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public PAlternativeSymbol? ContainingPAlternativeSymbol
        {
            get
            {
                ComputeContainingSymbol();
                return _containingAlternative;
            }
        }

        public AnnotationArgumentSymbol? ContainingAnnotationArgumentSymbol
        {
            get
            {
                ComputeContainingSymbol();
                return _containingAnnotationArgument;
            }
        }

        private void ComputeContainingSymbol()
        {
            if (_containingAlternative is not null || _containingAnnotationArgument is not null) return;
            var container = this.ContainingSymbol;
            while (container is not null)
            {
                if (container is PAlternativeSymbol pas)
                {
                    Interlocked.CompareExchange(ref _containingAlternative, pas, null);
                    break;
                }
                if (container is AnnotationArgumentSymbol aas)
                {
                    Interlocked.CompareExchange(ref _containingAnnotationArgument, aas, null);
                    break;
                }
                container = container.ContainingSymbol;
            }
        }

        public MetaType ExpectedType
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedType, null, default);
                return _expectedType;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_ExpectedType || incompletePart == CompletionParts.FinishComputingProperty_ExpectedType)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ExpectedType))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _expectedType = CompleteProperty_ExpectedType(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ExpectedType);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual MetaType CompleteProperty_ExpectedType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var alt = this.ContainingSymbol as PAlternativeSymbol;
            if (alt is not null)
            {
                return alt.ReturnType;
            }
            return default;
        }
    }
}
