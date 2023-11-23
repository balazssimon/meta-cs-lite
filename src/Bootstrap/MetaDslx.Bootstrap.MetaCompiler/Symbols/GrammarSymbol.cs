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
using MetaDslx.CodeAnalysis.PooledObjects;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Diagnostics.CodeAnalysis;
using MetaDslx.Bootstrap.MetaCompiler.Model;

namespace MetaDslx.Bootstrap.MetaCompiler.Symbols
{
    internal class GrammarSymbol : SourceDeclaredSymbol
    {
        public new static class CompletionParts
        {
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
                    StartComputingProperty_Members, FinishComputingProperty_Members,
                    StartComputingProperty_TypeArguments, FinishComputingProperty_TypeArguments,
                    StartComputingProperty_Imports, FinishComputingProperty_Imports,
                    StartComputingProperty_Attributes, FinishComputingProperty_Attributes);
        }

        private static readonly ParserRuleSymbolsByName CompareParserRuleSymbolsByName = new ParserRuleSymbolsByName();

        private ImmutableDictionary<PBlockSymbol, ImmutableArray<PAlternativeSymbol>> _blockFromAlterativeReferences;

        public GrammarSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public ImmutableDictionary<PBlockSymbol, ImmutableArray<PAlternativeSymbol>> BlockFromAlterativeReferences
        {
            get
            {
                ComputeAllBlocks();
                return _blockFromAlterativeReferences;
            }
        }

        private void ComputeAllBlocks()
        {
            if (_blockFromAlterativeReferences is not null) return;
            var blockRefs = new Dictionary<PAlternativeSymbol, HashSet<PBlockSymbol>>();
            var parserRules = this.Members.OfType<ParserRuleSymbol>().ToImmutableArray();
            foreach (var rule in this.Members)
            {
                if (rule is ParserRuleSymbol pr)
                {
                    CollectAltBlocks(blockRefs, pr.Alternatives);
                }
                else if (rule is PBlockSymbol pb)
                {
                    CollectAltBlocks(blockRefs, pb.Alternatives);
                }
            }
            Interlocked.CompareExchange(ref _blockFromAlterativeReferences, blockFromAlternativeReferences.ToImmutable(), null);
        }

        private void CollectAltBlocks(Dictionary<PAlternativeSymbol, HashSet<PBlockSymbol>> blockRefs, IEnumerable<PAlternativeSymbol> alts)
        {
            foreach (var alt in alts)
            {
                foreach (var elem in alt.Elements)
                {
                    if (elem.IsNamedElement)
                    {
                        if (elem.Value.OriginalSymbol is PBlockSymbol pblock)
                        {
                            CollectAltBlocks(blockRefs, pblock.Alternatives);
                        }
                    }
                    else 
                    {
                        if (elem.Value.OriginalSymbol is PReferenceSymbol pref)
                        {
                            if (pref.Rule.OriginalSymbol is PBlockSymbol prefBlock)
                            {
                                AddAltBlockRef(blockRefs, alt, prefBlock);
                                CollectAltBlocks(blockRefs, prefBlock.Alternatives);
                            }
                        }
                        if (elem.Value.OriginalSymbol is PBlockSymbol pblock)
                        {
                            AddAltBlockRef(blockRefs, alt, pblock);
                            CollectAltBlocks(blockRefs, pblock.Alternatives);
                        }
                    }
                }
            }
        }

        private void AddAltBlockRef(Dictionary<PAlternativeSymbol, HashSet<PBlockSymbol>> blockRefs, PAlternativeSymbol alt, PBlockSymbol block)
        {
            if (!blockRefs.TryGetValue(alt, out var blocks))
            {
                blocks = new HashSet<PBlockSymbol>();
                blockRefs.Add(alt, blocks);
            }
            blocks.Add(block);
        }

        private class ParserRuleSymbolsByName : IComparer<ParserRuleSymbol>
        {
            public int Compare(ParserRuleSymbol? x, ParserRuleSymbol? y)
            {
                return string.Compare(x?.Name, y?.Name);
            }
        }
    }
}
