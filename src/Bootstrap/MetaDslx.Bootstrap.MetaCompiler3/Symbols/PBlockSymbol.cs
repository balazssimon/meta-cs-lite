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
using MetaDslx.CodeAnalysis.Symbols.CSharp;
using System.Collections.Immutable;
using MetaDslx.CodeAnalysis.PooledObjects;
using MetaDslx.Bootstrap.MetaCompiler2.Model;
using MetaDslx.Bootstrap.MetaCompiler2.Compiler.Syntax;

namespace MetaDslx.Bootstrap.MetaCompiler2.Symbols
{
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;

    internal class PBlockSymbol : SourceDeclarationSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Alternatives = new CompletionPart(nameof(StartComputingProperty_Alternatives));
            public static readonly CompletionPart FinishComputingProperty_Alternatives = new CompletionPart(nameof(FinishComputingProperty_Alternatives));
            public static readonly CompletionPart StartComputingProperty_ExpectedType = new CompletionPart(nameof(StartComputingProperty_ExpectedType));
            public static readonly CompletionPart FinishComputingProperty_ExpectedType = new CompletionPart(nameof(FinishComputingProperty_ExpectedType));
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
                    StartComputingProperty_Alternatives, FinishComputingProperty_Alternatives,
                    StartComputingProperty_ExpectedType, FinishComputingProperty_ExpectedType,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private MetaType _expectedType;
        private ImmutableArray<PAlternativeSymbol> _alternatives;

        public PBlockSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public PElementSymbol? ContainingElementSymbol => this.ContainingSymbol as PElementSymbol;

        public MetaType ExpectedType
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedType, null, default);
                return _expectedType;
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
            if (incompletePart == CompletionParts.StartComputingProperty_Alternatives || incompletePart == CompletionParts.FinishComputingProperty_Alternatives)
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
            else if (incompletePart == CompletionParts.StartComputingProperty_ExpectedType || incompletePart == CompletionParts.FinishComputingProperty_ExpectedType)
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
            return this.ContainingElementSymbol?.ExpectedType ?? default;
        }

        protected virtual ImmutableArray<PAlternativeSymbol> CompleteProperty_Alternatives(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PAlternativeSymbol>(this, nameof(Alternatives), diagnostics, cancellationToken);
        }

        protected override void CompletePart_Validate(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            base.CompletePart_Validate(diagnostics, cancellationToken);
            var expectedType = this.ExpectedType;
            if (!expectedType.IsNull && expectedType.SpecialType != SpecialType.MetaDslx_CodeAnalysis_MetaSymbol)
            {
                foreach (var alt in Alternatives)
                {
                    if (alt.ReturnValue is null)
                    {
                        diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_AltMustHaveReturnValue, alt.Location, expectedType));
                    }
                }
            }
        }
    }
}
