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

        private ImmutableDictionary<ParserRuleSymbol, ImmutableArray<BlockRuleReference>> _allBlocks;

        public GrammarSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public ImmutableDictionary<ParserRuleSymbol, ImmutableArray<BlockRuleReference>> AllBlocks
        {
            get
            {
                ComputeAllBlocks();
                return _allBlocks;
            }
        }

        private void ComputeAllBlocks()
        {
            if (_allBlocks is not null) return;
            var allBlocks = ImmutableDictionary.CreateBuilder<ParserRuleSymbol, ArrayBuilder<BlockRuleReference>>();
            var parserRules = this.Members.OfType<ParserRuleSymbol>().ToImmutableArray();
            var blockRules = new HashSet<ParserRuleSymbol>(parserRules.Where(r => r.IsBlock));
            foreach (var pr in parserRules)
            {
                foreach (var alt in pr.Alternatives)
                {
                    foreach (var elem in alt.Elements)
                    {
                        if (elem.Value.OriginalSymbol is PReferenceSymbol rs && rs.Rule.OriginalSymbol is ParserRuleSymbol prs && blockRules.Contains(prs))
                        {
                            if (!allBlocks.TryGetValue(prs, out var ralts))
                            {
                                ralts = new ArrayBuilder<BlockRuleReference>();
                                allBlocks.Add(prs, ralts);
                            }
                            ralts.Add(new BlockRuleReference(prs, alt));
                        }
                    }
                }
            }
            var finished = false;
            while (!finished)
            {
                finished = true;
                foreach (var blk in allBlocks.Keys)
                {
                    var rAlts = allBlocks[blk];
                    for (int i = 0; i < rAlts.Count; ++i)
                    {
                        var rAlt = rAlts[i];
                        if (rAlt.ReferencingRule.IsBlock)
                        {
                            var brAlts = allBlocks[rAlt.ReferencingRule];
                            foreach (var brAlt in brAlts)
                            {
                                //if (!rAlts.Any(ra => ra.ReferencingRule == ))
                            }
                        }
                    }
                }
            }
        }

    }
}
