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
    internal class ParserRuleSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_IsBlock = new CompletionPart(nameof(StartComputingProperty_IsBlock));
            public static readonly CompletionPart FinishComputingProperty_IsBlock = new CompletionPart(nameof(FinishComputingProperty_IsBlock));
            public static readonly CompletionPart StartComputingProperty_ReturnType = new CompletionPart(nameof(StartComputingProperty_ReturnType));
            public static readonly CompletionPart FinishComputingProperty_ReturnType = new CompletionPart(nameof(FinishComputingProperty_ReturnType));
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
                    StartComputingProperty_IsBlock, FinishComputingProperty_IsBlock,
                    StartComputingProperty_ReturnType, FinishComputingProperty_ReturnType,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaType _returnType;
        private bool _isBlock;

        public ParserRuleSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        [ModelProperty]
        public bool IsBlock
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_IsBlock, null, default);
                return _isBlock;
            }
        }

        [ModelProperty]
        public MetaType ReturnType
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ReturnType, null, default);
                return _returnType;
            }
        }

        protected override bool ForceCompletePart(ref CompletionPart incompletePart, SourceLocation? locationOpt, CancellationToken cancellationToken)
        {
            if (incompletePart == CompletionParts.StartComputingProperty_IsBlock || incompletePart == CompletionParts.FinishComputingProperty_IsBlock)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_IsBlock))
                {
                    var diagnostics = DiagnosticBag.GetInstance();
                    _isBlock = CompleteProperty_IsBlock(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_IsBlock);
                }
                return true;
            }
            else if (incompletePart == CompletionParts.StartComputingProperty_ReturnType || incompletePart == CompletionParts.FinishComputingProperty_ReturnType)
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

        protected virtual bool CompleteProperty_IsBlock(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<bool>(this, nameof(IsBlock), diagnostics, cancellationToken);
        }

        protected virtual MetaType CompleteProperty_ReturnType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValue<MetaType>(this, nameof(ReturnType), diagnostics, cancellationToken);
        }

    }
}
