using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class ExpressionSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_ExpectedTypes = new CompletionPart(nameof(StartComputingProperty_ExpectedTypes));
            public static readonly CompletionPart FinishComputingProperty_ExpectedTypes = new CompletionPart(nameof(FinishComputingProperty_ExpectedTypes));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_ExpectedTypes, FinishComputingProperty_ExpectedTypes,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private ImmutableArray<MetaType> _expectedTypes;
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

        public ImmutableArray<MetaType> ExpectedTypes
        { 
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedTypes, null, default);
                return _expectedTypes;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_ExpectedTypes || incompletePart == CompletionParts.FinishComputingProperty_ExpectedTypes)
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

        protected virtual ImmutableArray<MetaType> CompleteProperty_ExpectedTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var alt = this.ContainingPAlternativeSymbol;
            if (alt is not null)
            {
                return alt.ExpectedTypes;
            }
            var arg = this.ContainingAnnotationArgumentSymbol;
            if (arg is not null)
            {
                return arg.ExpectedTypes;
            }
            return default;
        }
    }
}
