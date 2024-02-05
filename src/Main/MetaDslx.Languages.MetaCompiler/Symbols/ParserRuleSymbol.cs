using MetaDslx.Languages.MetaCompiler.Compiler.Syntax;
using MetaDslx.Languages.MetaCompiler.Compiler.Syntax.InternalSyntax;
using MetaDslx.Languages.MetaCompiler.Model;
using MetaDslx.CodeAnalysis;
using MetaDslx.CodeAnalysis.Declarations;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.CodeAnalysis.Symbols;
using MetaDslx.CodeAnalysis.Symbols.Source;
using MetaDslx.Modeling;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MetaDslx.Languages.MetaCompiler.Symbols
{
    internal class ParserRuleSymbol : SourceDeclarationSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_ReturnType = new CompletionPart(nameof(StartComputingProperty_ReturnType));
            public static readonly CompletionPart FinishComputingProperty_ReturnType = new CompletionPart(nameof(FinishComputingProperty_ReturnType));
            public static readonly CompletionPart StartComputingProperty_Alternatives = new CompletionPart(nameof(StartComputingProperty_Alternatives));
            public static readonly CompletionPart FinishComputingProperty_Alternatives = new CompletionPart(nameof(FinishComputingProperty_Alternatives));
            public static readonly CompletionPart StartComputingProperty_Members = DeclarationSymbol.CompletionParts.StartComputingProperty_Members;
            public static readonly CompletionPart FinishComputingProperty_Members = DeclarationSymbol.CompletionParts.FinishComputingProperty_Members;
            public static readonly CompletionPart StartComputingProperty_TypeArguments = DeclarationSymbol.CompletionParts.StartComputingProperty_TypeArguments;
            public static readonly CompletionPart FinishComputingProperty_TypeArguments = DeclarationSymbol.CompletionParts.FinishComputingProperty_TypeArguments;
            public static readonly CompletionPart StartComputingProperty_Imports = DeclarationSymbol.CompletionParts.StartComputingProperty_Imports;
            public static readonly CompletionPart FinishComputingProperty_Imports = DeclarationSymbol.CompletionParts.FinishComputingProperty_Imports;
            public static readonly CompletionPart StartComputingProperty_Attributes = Symbol.CompletionParts.StartComputingProperty_Attributes;
            public static readonly CompletionPart FinishComputingProperty_Attributes = Symbol.CompletionParts.FinishComputingProperty_Attributes;
            public static readonly CompletionGraph CompletionGraph =
                CompletionGraph.CreateFromParts(
                    StartComputingProperty_ReturnType, FinishComputingProperty_ReturnType,
                    StartComputingProperty_Alternatives, FinishComputingProperty_Alternatives,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaType _returnType;
        private ImmutableArray<PAlternativeSymbol> _alternatives;

        public ParserRuleSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject) 
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public RuleSyntax? Syntax => this.DeclaringSyntaxReference.AsNode() as RuleSyntax;

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
            else if (incompletePart == CompletionParts.StartComputingProperty_Alternatives || incompletePart == CompletionParts.FinishComputingProperty_Alternatives)
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

        protected virtual MetaType CompleteProperty_ReturnType(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            var returnType = SymbolFactory.GetSymbolPropertyValue<MetaType>(this, nameof(ReturnType), diagnostics, cancellationToken);
            if (returnType.IsDefaultOrNull)
            {
                diagnostics.Add(Diagnostic.Create(CommonErrorCode.ERR_BindingError, Location, $"Could not determine the return type of the rule '{Name}'"));
            }
            return returnType;
        }

        protected virtual ImmutableArray<PAlternativeSymbol> CompleteProperty_Alternatives(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PAlternativeSymbol>(this, nameof(Alternatives), diagnostics, cancellationToken);
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            var returnType = this.ReturnType;
            if (!returnType.IsDefaultOrNull)
            {
                foreach (var alt in this.Alternatives)
                {
                    if (!returnType.IsAssignableFrom(alt.ReturnType) && returnType.SpecialType != SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
                    {
                        diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_IncompatibleAltReturnType, alt.Location, alt.ReturnType, alt.Name, this.ReturnType, this.Name));
                    }
                }
            }
        }
    }
}
