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
    internal class PAlternativeSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_ReturnType = new CompletionPart(nameof(StartComputingProperty_ReturnType));
            public static readonly CompletionPart FinishComputingProperty_ReturnType = new CompletionPart(nameof(FinishComputingProperty_ReturnType));
            public static readonly CompletionPart StartComputingProperty_Elements = new CompletionPart(nameof(StartComputingProperty_Elements));
            public static readonly CompletionPart FinishComputingProperty_Elements = new CompletionPart(nameof(FinishComputingProperty_Elements));
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
                    StartComputingProperty_ReturnType, FinishComputingProperty_ReturnType,
                    StartComputingProperty_Elements, FinishComputingProperty_Elements,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaType _returnType;
        private ImmutableArray<PElementSymbol> _elements;

        public PAlternativeSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

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
        public ImmutableArray<PElementSymbol> Elements
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_Elements, null, default);
                return _elements;
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
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ReturnType);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_Elements || incompletePart == CompletionParts.FinishComputingProperty_Elements)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_Elements))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _elements = CompleteProperty_Elements(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_Elements);
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
            var syntax = Declaration.SyntaxReferences.FirstOrDefault();
            return Declaration.Language.SyntaxFacts.ExtractName(syntax);
        }

        protected virtual MetaType CompleteProperty_ReturnType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var returnType = SymbolFactory.GetSymbolPropertyValue<MetaType>(this, nameof(ReturnType), diagnostics, cancellationToken);
            if (returnType.IsNull)
            {
                returnType = (this.ContainingSymbol as ParserRuleSymbol)?.ReturnType ?? default;
            }
            return returnType;
        }

        protected virtual ImmutableArray<PElementSymbol> CompleteProperty_Elements(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PElementSymbol>(this, nameof(Elements), diagnostics, cancellationToken);
        }
    }
}
