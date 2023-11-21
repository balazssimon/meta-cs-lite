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

        private ImmutableDictionary<ParserRuleSymbol, ImmutableArray<BlockRuleReference>> _ruleToBlockReferences;
        private ImmutableDictionary<ParserRuleSymbol, ImmutableArray<PAlternativeSymbol>> _blockFromAlterativeReferences;

        public GrammarSymbol(Symbol container, MergedDeclaration declaration, IModelObject modelObject)
            : base(container, declaration, modelObject)
        {
        }

        protected override CompletionGraph CompletionGraph => CompletionParts.CompletionGraph;

        public ImmutableDictionary<ParserRuleSymbol, ImmutableArray<BlockRuleReference>> RuleToBlockReferences
        {
            get
            {
                ComputeAllBlocks();
                return _ruleToBlockReferences;
            }
        }

        public ImmutableDictionary<ParserRuleSymbol, ImmutableArray<PAlternativeSymbol>> BlockFromAlterativeReferences
        {
            get
            {
                ComputeAllBlocks();
                return _blockFromAlterativeReferences;
            }
        }

        private void ComputeAllBlocks()
        {
            if (_ruleToBlockReferences is not null) return;
            var blockRefs = new SortedDictionary<ParserRuleSymbol, SortedSet<ParserRuleSymbol>>(CompareParserRuleSymbolsByName);
            var parserRules = this.Members.OfType<ParserRuleSymbol>().ToImmutableArray();
            var blockRules = new HashSet<ParserRuleSymbol>(parserRules.Where(r => r.IsBlock));
            foreach (var br in blockRules)
            {
                var brRefs = new SortedSet<ParserRuleSymbol>(CompareParserRuleSymbolsByName);
                blockRefs.Add(br, brRefs);
                foreach (var alt in br.Alternatives)
                {
                    foreach (var elem in alt.Elements)
                    {
                        if (elem.Value.OriginalSymbol is PReferenceSymbol rs && rs.Rule.OriginalSymbol is ParserRuleSymbol prs && blockRules.Contains(prs))
                        {
                            brRefs.Add(prs);
                        }
                    }
                }
            }
            var ruleToBlockReferences = ImmutableDictionary.CreateBuilder<ParserRuleSymbol, ImmutableArray<BlockRuleReference>>();
            var blockTargetRefsBuilder = ArrayBuilder<BlockRuleReference>.GetInstance();
            foreach (var blk in blockRefs.Keys)
            {
                var brRefs = blockRefs[blk];
                blockTargetRefsBuilder.Clear();
                blockTargetRefsBuilder.AddRange(brRefs.Select(br => new BlockRuleReference(br, br)));
                var i = 0;
                while (i < blockTargetRefsBuilder.Count)
                {
                    var brRef = blockTargetRefsBuilder[i];
                    var brRefRefs = blockRefs[brRef.ReferencedBlock];
                    foreach (var brRefRef in brRefRefs)
                    {
                        if (!blockTargetRefsBuilder.Any(br => br.ReferencedBlock == brRefRef))
                        {
                            blockTargetRefsBuilder.Add(new BlockRuleReference(brRef.ReferencedBlock, brRefRef));
                        }
                    }
                    ++i;
                }
                ruleToBlockReferences.Add(blk, blockTargetRefsBuilder.ToImmutable());
            }
            foreach (var pr in parserRules.Where(r => !r.IsBlock))
            {
                blockTargetRefsBuilder.Clear();
                foreach (var alt in pr.Alternatives)
                {
                    foreach (var elem in alt.AllSimpleElements)
                    {
                        if (elem.Value.OriginalSymbol is PReferenceSymbol rs && rs.Rule.OriginalSymbol is ParserRuleSymbol prs && blockRules.Contains(prs))
                        {
                            if (!blockTargetRefsBuilder.Any(br => br.ReferencedBlock == prs))
                            {
                                blockTargetRefsBuilder.Add(new BlockRuleReference(pr, prs));
                            }
                        }
                    }
                }
                var i = 0;
                while (i < blockTargetRefsBuilder.Count)
                {
                    var brRef = blockTargetRefsBuilder[i];
                    var brRefRefs = blockRefs[brRef.ReferencedBlock];
                    foreach (var brRefRef in brRefRefs)
                    {
                        if (!blockTargetRefsBuilder.Any(br => br.ReferencedBlock == brRefRef))
                        {
                            blockTargetRefsBuilder.Add(new BlockRuleReference(brRef.ReferencedBlock, brRefRef));
                        }
                    }
                    ++i;
                }
                ruleToBlockReferences.Add(pr, blockTargetRefsBuilder.ToImmutable());
            }
            blockTargetRefsBuilder.Free();
            var blockFromAlternativeReferences = ImmutableDictionary.CreateBuilder<ParserRuleSymbol, ImmutableArray<PAlternativeSymbol>>();
            var blockSourceRefsBuilder = ArrayBuilder<PAlternativeSymbol>.GetInstance();
            foreach (var blk in blockRefs.Keys)
            {
                blockSourceRefsBuilder.Clear();
                foreach (var pr in parserRules.Where(r => !r.IsBlock))
                {
                    foreach (var alt in pr.Alternatives)
                    {
                        foreach (var elem in alt.AllSimpleElements)
                        {
                            if (elem.Value.OriginalSymbol is PReferenceSymbol rs && rs.Rule.OriginalSymbol == blk)
                            {
                                if (!blockSourceRefsBuilder.Any(br => br == alt))
                                {
                                    blockSourceRefsBuilder.Add(alt);
                                }
                            }
                        }
                    }
                }
                blockFromAlternativeReferences.Add(blk, blockSourceRefsBuilder.ToImmutable());
            }
            blockSourceRefsBuilder.Free();
            Interlocked.CompareExchange(ref _ruleToBlockReferences, ruleToBlockReferences.ToImmutable(), null);
            Interlocked.CompareExchange(ref _blockFromAlterativeReferences, blockFromAlternativeReferences.ToImmutable(), null);
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
