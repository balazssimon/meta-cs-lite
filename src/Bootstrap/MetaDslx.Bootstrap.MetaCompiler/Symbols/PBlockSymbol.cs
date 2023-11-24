﻿using MetaDslx.CodeAnalysis.Declarations;
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
using MetaDslx.Bootstrap.MetaCompiler.Model;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    using IPropertySymbol = Microsoft.CodeAnalysis.IPropertySymbol;

    internal class PBlockSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
            public static readonly CompletionPart StartComputingProperty_Alternatives = new CompletionPart(nameof(StartComputingProperty_Alternatives));
            public static readonly CompletionPart FinishComputingProperty_Alternatives = new CompletionPart(nameof(FinishComputingProperty_Alternatives));
            public static readonly CompletionPart StartComputingProperty_ExpectedTypes = new CompletionPart(nameof(StartComputingProperty_ExpectedTypes));
            public static readonly CompletionPart FinishComputingProperty_ExpectedTypes = new CompletionPart(nameof(FinishComputingProperty_ExpectedTypes));
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
                    StartComputingProperty_Alternatives, FinishComputingProperty_Alternatives,
                    StartComputingProperty_ExpectedTypes, FinishComputingProperty_ExpectedTypes,
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private bool _isResolvingExpectedTypes;
        private ImmutableArray<MetaType> _expectedTypes;
        private ImmutableArray<PAlternativeSymbol> _alternatives;

        public PBlockSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public PElementSymbol? ContainingElementSymbol => this.ContainingSymbol as PElementSymbol;

        public bool IsResolvingExpectedTypes => _isResolvingExpectedTypes;

        public ImmutableArray<MetaType> ExpectedTypes
        {
            get
            {
                ForceComplete(CompletionParts.FinishComputingProperty_ExpectedTypes, null, default);
                return _expectedTypes;
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
            else if (incompletePart == CompletionParts.StartComputingProperty_ExpectedTypes || incompletePart == CompletionParts.FinishComputingProperty_ExpectedTypes)
            {
                if (NotePartComplete(CompletionParts.StartComputingProperty_ExpectedTypes))
                {
                    _isResolvingExpectedTypes = true;
                    var diagnostics = DiagnosticBag.GetInstance();
                    _expectedTypes = CompleteProperty_ExpectedTypes(diagnostics, cancellationToken);
                    AddSymbolDiagnostics(diagnostics);
                    diagnostics.Free();
                    NotePartComplete(CompletionParts.FinishComputingProperty_ExpectedTypes);
                    _isResolvingExpectedTypes = false;
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
            var elem = this.ContainingElementSymbol;
            if (elem is not null)
            {
                if (elem.IsNamedElement)
                {
                    return elem.ExpectedTypes;
                }
                else
                {
                    var alt = elem.ContainingPAlternativeSymbol;
                    if (alt is not null)
                    {
                        return alt.ExpectedTypes;
                    }
                }
            }
            else 
            {
                var grammar = this.ContainingSymbol as GrammarSymbol;
                if (grammar is not null)
                {
                    var expectedTypes = ArrayBuilder<MetaType>.GetInstance();
                    var blockRefs = grammar.BlockReferences[this];
                    foreach (var blockRef in blockRefs)
                    {
                        if (blockRef.IsNamedElement)
                        {
                            foreach (var type in blockRef.ExpectedTypes)
                            {
                                if (!expectedTypes.Contains(type)) expectedTypes.Add(type);
                            }
                        }
                        else
                        {
                            var altRef = blockRef.ContainingPAlternativeSymbol;
                            if (altRef is not null)
                            {
                                if (altRef.IsResolvingExpectedTypes)
                                {
                                    diagnostics.Add(Diagnostic.Create(CompilerErrorCode.ERR_CircularBlockReference, this.Location, this.Name));
                                }
                                else
                                {
                                    foreach (var type in altRef.ExpectedTypes)
                                    {
                                        if (!expectedTypes.Contains(type)) expectedTypes.Add(type);
                                    }
                                }
                            }
                        }
                    }
                    return expectedTypes.ToImmutableAndFree();
                }
                else
                {
                    diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"Named block '{this.Name}' must be contained directly by the grammar"));
                    return ImmutableArray<MetaType>.Empty;
                }
            }
            diagnostics.Add(Diagnostic.Create(ErrorCode.ERR_InternalError, this.Location, $"Could not determine the expected types for the block"));
            return ImmutableArray<MetaType>.Empty;
        }

        protected virtual ImmutableArray<PAlternativeSymbol> CompleteProperty_Alternatives(DiagnosticBag diagnostics, CancellationToken cancellationToken)
        {
            return SymbolFactory.GetSymbolPropertyValues<PAlternativeSymbol>(this, nameof(Alternatives), diagnostics, cancellationToken);
        }
    }
}
