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
using System.Collections.Immutable;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class PReferenceSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Rule = new CompletionPart(nameof(StartComputingProperty_Rule));
            public static readonly CompletionPart FinishComputingProperty_Rule = new CompletionPart(nameof(FinishComputingProperty_Rule));
            public static readonly CompletionPart StartComputingProperty_ReferencedTypes = new CompletionPart(nameof(StartComputingProperty_ReferencedTypes));
            public static readonly CompletionPart FinishComputingProperty_ReferencedTypes = new CompletionPart(nameof(FinishComputingProperty_ReferencedTypes));
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
                    StartComputingProperty_Rule, FinishComputingProperty_Rule,
                    StartComputingProperty_ReferencedTypes, FinishComputingProperty_ReferencedTypes,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaSymbol _rule;
        private ImmutableArray<MetaType> _referencedTypes;

        public PReferenceSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [ModelProperty]
        public MetaSymbol Rule
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Rule, null, default);
                return _rule;
            }
        }

        [ModelProperty]
        public ImmutableArray<MetaType> ReferencedTypes
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ReferencedTypes, null, default);
                return _referencedTypes;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_Rule || incompletePart == CompletionParts.FinishComputingProperty_Rule)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Rule))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _rule = CompleteProperty_Rule(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Rule);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ReferencedTypes || incompletePart == CompletionParts.FinishComputingProperty_ReferencedTypes)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ReferencedTypes))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _referencedTypes = CompleteProperty_ReferencedTypes(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ReferencedTypes);
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

        protected virtual MetaSymbol CompleteProperty_Rule(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaSymbol>(this, nameof(Rule), diagnostics, cancellationToken);
        }

        protected virtual ImmutableArray<MetaType> CompleteProperty_ReferencedTypes(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<MetaType>(this, nameof(ReferencedTypes), diagnostics, cancellationToken);
        }
    }
}
