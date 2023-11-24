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

        private ImmutableDictionary<PBlockSymbol, ImmutableHashSet<PElementSymbol>> _blockReferences;

        public GrammarSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public ImmutableDictionary<PBlockSymbol, ImmutableHashSet<PElementSymbol>> BlockReferences
        {
            get
            {
                ComputeAllBlocks();
                return _blockReferences;
            }
        }

        private void ComputeAllBlocks()
        {
            if (_blockReferences is not null) return;
            var blocks = new HashSet<PBlockSymbol>();
            var blockRefs = new Dictionary<PElementSymbol, HashSet<PBlockSymbol>>();
            foreach (var rule in this.Members)
            {
                if (rule is ParserRuleSymbol pr)
                {
                    CollectAltBlocks(blocks, blockRefs, pr.Alternatives);
                }
                else if (rule is PBlockSymbol pb)
                {
                    blocks.Add(pb);
                    CollectAltBlocks(blocks, blockRefs, pb.Alternatives);
                }
            }
            var blockReferences = ImmutableDictionary.CreateBuilder<PBlockSymbol, ImmutableHashSet<PElementSymbol>>();
            var references = ImmutableHashSet.CreateBuilder<PElementSymbol>();
            foreach (var block in blocks)
            {
                references.Clear();
                foreach (var alt in blockRefs.Keys)
                {
                    var altRefs = blockRefs[alt];
                    if (altRefs.Contains(block))
                    {
                        references.Add(alt);
                    }
                }
                blockReferences.Add(block, references.ToImmutable());
            }
            Interlocked.CompareExchange(ref _blockReferences, blockReferences.ToImmutable(), null);
        }

        private void CollectAltBlocks(HashSet<PBlockSymbol> blocks, Dictionary<PElementSymbol, HashSet<PBlockSymbol>> blockRefs, IEnumerable<PAlternativeSymbol> alts)
        {
            foreach (var alt in alts)
            {
                foreach (var elem in alt.Elements)
                {
                    if (elem.Value.OriginalSymbol is PBlockSymbol pblock)
                    {
                        blocks.Add(pblock);
                        AddElemBlockRef(blockRefs, elem, pblock);
                        CollectAltBlocks(blocks, blockRefs, pblock.Alternatives);
                    }
                    if (elem.Value.OriginalSymbol is PReferenceSymbol pref && pref.Rule.OriginalSymbol is PBlockSymbol prefBlock)
                    {
                        AddElemBlockRef(blockRefs, elem, prefBlock);
                    }
                }
            }
        }

        private void AddElemBlockRef(Dictionary<PElementSymbol, HashSet<PBlockSymbol>> blockRefs, PElementSymbol elem, PBlockSymbol block)
        {
            if (!blockRefs.TryGetValue(elem, out var blocks))
            {
                blocks = new HashSet<PBlockSymbol>();
                blockRefs.Add(elem, blocks);
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
