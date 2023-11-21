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
    internal class AnnotationSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Type = new CompletionPart(nameof(StartComputingProperty_Type));
            public static readonly CompletionPart FinishComputingProperty_Type = new CompletionPart(nameof(FinishComputingProperty_Type));
            public static readonly CompletionPart StartComputingProperty_Arguments = new CompletionPart(nameof(StartComputingProperty_Arguments));
            public static readonly CompletionPart FinishComputingProperty_Arguments = new CompletionPart(nameof(FinishComputingProperty_Arguments));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_Type, FinishComputingProperty_Type,
                    StartComputingProperty_Arguments, FinishComputingProperty_Arguments,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaType _type;
        private ImmutableArray<AnnotationArgumentSymbol> _arguments;

        public AnnotationSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [ModelProperty]
        public MetaType Type
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Type, null, default);
                return _type;
            }
        }

        [ModelProperty]
        public ImmutableArray<AnnotationArgumentSymbol> Arguments
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Arguments, null, default);
                return _arguments;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Type || incompletePart == CompletionParts.FinishComputingProperty_Type)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Type))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _type = CompleteProperty_Type(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Type);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Arguments || incompletePart == CompletionParts.FinishComputingProperty_Arguments)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Arguments))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _arguments = CompleteProperty_Arguments(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Arguments);
                }
                return true;
            }
            else if (base.ForceCompletePart(ref incompletePart, locationOpt, cancellationToken))
            {
                return true;
            }
            return false;
        }

        protected virtual MetaType CompleteProperty_Type(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaType>(this, nameof(Type), diagnostics, cancellationToken);
        }

        protected virtual ImmutableArray<AnnotationArgumentSymbol> CompleteProperty_Arguments(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<AnnotationArgumentSymbol>(this, nameof(Arguments), diagnostics, cancellationToken);
        }
    }
}
