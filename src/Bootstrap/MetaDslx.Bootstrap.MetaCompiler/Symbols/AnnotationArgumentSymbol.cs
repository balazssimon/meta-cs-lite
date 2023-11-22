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
using MetaDslx.Bootstrap.MetaCompiler.Model;
using MetaDslx.Bootstrap.MetaCompiler.Compiler.Syntax;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class AnnotationArgumentSymbol : SourceSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_NamedParameter = new CompletionPart(nameof(StartComputingProperty_NamedParameter));
            public static readonly CompletionPart FinishComputingProperty_NamedParameter = new CompletionPart(nameof(FinishComputingProperty_NamedParameter));
            public static readonly CompletionPart StartComputingProperty_Parameters = new CompletionPart(nameof(StartComputingProperty_Parameters));
            public static readonly CompletionPart FinishComputingProperty_Parameters = new CompletionPart(nameof(FinishComputingProperty_Parameters));
            public static readonly CompletionPart StartComputingProperty_Value = new CompletionPart(nameof(StartComputingProperty_Value));
            public static readonly CompletionPart FinishComputingProperty_Value = new CompletionPart(nameof(FinishComputingProperty_Value));
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_NamedParameter, FinishComputingProperty_NamedParameter,
                    StartComputingProperty_Parameters, FinishComputingProperty_Parameters,
                    StartComputingProperty_Value, FinishComputingProperty_Value,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private ImmutableArray<MetaSymbol> _namedParameter;
        private ImmutableArray<DeclaredSymbol> _parameters;
        private ExpressionSymbol _value;

        public AnnotationArgumentSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public AnnotationSymbol? AnnotationSymbol => (AnnotationSymbol)this.ContainingSymbol;

        public AnnotationArgumentSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as AnnotationArgumentSyntax;

        public bool IsNamedArgument => Syntax?.AnnotationArgumentBlock1 is not null;

        [ModelProperty]
        public ImmutableArray<MetaSymbol> NamedParameter
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_NamedParameter, null, default);
                return _namedParameter;
            }
        }

        [ModelProperty]
        public ImmutableArray<DeclaredSymbol> Parameters
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Parameters, null, default);
                return _parameters;
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
            if (incompletePart == CompletionParts.StartComputingProperty_NamedParameter || incompletePart == CompletionParts.FinishComputingProperty_NamedParameter)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_NamedParameter))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _namedParameter = CompleteProperty_NamedParameter(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_NamedParameter);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Parameters || incompletePart == CompletionParts.FinishComputingProperty_Parameters)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Parameters))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _parameters = CompleteProperty_Parameters(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Parameters);
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

        protected virtual ImmutableArray<MetaSymbol> CompleteProperty_NamedParameter(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<MetaSymbol>(this, nameof(NamedParameter), diagnostics, cancellationToken);
        }

        protected virtual ImmutableArray<DeclaredSymbol> CompleteProperty_Parameters(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var index = AnnotationSymbol?.Arguments.IndexOf(this) ?? -1;
            if (index < 0) return ImmutableArray<DeclaredSymbol>.Empty;
            return AnnotationSymbol.ArgumentParameters[index];
        }

        protected virtual ExpressionSymbol CompleteProperty_Value(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<ExpressionSymbol>(this, nameof(Value), diagnostics, cancellationToken);
        }
    }
}
