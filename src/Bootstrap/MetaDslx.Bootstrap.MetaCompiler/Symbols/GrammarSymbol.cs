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
using Roslyn.Utilities;
using static System.Reflection.Metadata.BlobBuilder;

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

        private ImmutableArray<PElementSymbol> _allElements;
        private ImmutableDictionary<PBlockSymbol, ImmutableHashSet<PElementSymbol>> _blockReferences;
        private ImmutableDictionary<PElementSymbol, ElementTrace> _elementTraces;

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

        public ImmutableArray<PElementSymbol> AllElements
        {
            get
            {
                ComputeAllBlocks();
                return _allElements;
            }
        }

        public ImmutableDictionary<PElementSymbol, ElementTrace> ElementTraces
        {
            get
            {
                ComputeElementTraces();
                return _elementTraces;
            }
        }

        private void ComputeAllBlocks()
        {
            if (_blockReferences is not null) return;
            var elements = new HashSet<PElementSymbol>();
            var blocks = new HashSet<PBlockSymbol>();
            var blockRefs = new Dictionary<PElementSymbol, HashSet<PBlockSymbol>>();
            foreach (var rule in this.Members)
            {
                if (rule is ParserRuleSymbol pr)
                {
                    CollectAltBlocks(elements, blocks, blockRefs, pr.Alternatives);
                }
                else if (rule is PBlockSymbol pb)
                {
                    blocks.Add(pb);
                    CollectAltBlocks(elements, blocks, blockRefs, pb.Alternatives);
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
            var allElements = ArrayBuilder<PElementSymbol>.GetInstance();
            var stack = ArrayBuilder<PElementSymbol>.GetInstance();
            var visited = PooledHashSet<PElementSymbol>.GetInstance();
            while (elements.Count > 0)
            {
                var first = elements.First();
                stack.Add(first);
                visited.Add(first);
                elements.Remove(first);
                while (stack.Count > 0)
                {
                    var current = stack[stack.Count - 1];
                    var currentAlt = current.ContainingPAlternativeSymbol;
                    var currentBlock = currentAlt?.ContainingPBlockSymbol;
                    if (currentBlock is not null)
                    {
                        var added = false;
                        var currentBlockRefs = _blockReferences[currentBlock];
                        foreach (var refElem in currentBlockRefs)
                        {
                            if (!visited.Contains(refElem))
                            {
                                added = true;
                                stack.Add(refElem);
                                visited.Add(refElem);
                                elements.Remove(refElem);
                                break;
                            }
                        }
                        if (!added)
                        {
                            stack.RemoveAt(stack.Count - 1);
                            allElements.Add(current);
                        }
                    }
                    else
                    {
                        stack.RemoveAt(stack.Count - 1);
                        allElements.Add(current);
                    }
                }
            }
            stack.Free();
            visited.Free();
            ImmutableInterlocked.InterlockedInitialize(ref _allElements, allElements.ToImmutableAndFree());
        }

        private void CollectAltBlocks(HashSet<PElementSymbol> elements, HashSet<PBlockSymbol> blocks, Dictionary<PElementSymbol, HashSet<PBlockSymbol>> blockRefs, IEnumerable<PAlternativeSymbol> alts)
        {
            foreach (var alt in alts)
            {
                foreach (var elem in alt.Elements)
                {
                    elements.Add(elem);
                    if (elem.Value.OriginalSymbol is PBlockSymbol pblock)
                    {
                        blocks.Add(pblock);
                        AddElemBlockRef(blockRefs, elem, pblock);
                        CollectAltBlocks(elements, blocks, blockRefs, pblock.Alternatives);
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

        private void ComputeElementTraces()
        {
            if (_elementTraces is not null) return;
            var elementTraces = ImmutableDictionary.CreateBuilder<PElementSymbol, ElementTrace>();
            var visited = PooledHashSet<PElementSymbol>.GetInstance();
            foreach (var elem in AllElements)
            {
                elementTraces.Add(elem, CollectElementTraces(elementTraces, visited, elem));
            }
            visited.Free();
            Interlocked.CompareExchange(ref _elementTraces, elementTraces.ToImmutable(), null);
        }

        private ElementTrace CollectElementTraces(ImmutableDictionary<PElementSymbol, ElementTrace>.Builder elementTraces, HashSet<PElementSymbol> visited, PElementSymbol element)
        {
            var result = ArrayBuilder<ElementTrace>.GetInstance();
            var alt = element.ContainingPAlternativeSymbol;
            var block = alt?.ContainingPBlockSymbol;
            if (block is not null)
            {
                var blockRefs = BlockReferences[block];
                foreach (var blockRef in blockRefs)
                {
                    if (elementTraces.ContainsKey(blockRef))
                    {
                        result.Add(elementTraces[blockRef]);
                    }
                    else if (visited.Contains(blockRef))
                    {
                        //result.Add(new ElementTrace(blockRef, ImmutableArray<ElementTrace>.Empty));
                    }
                    else
                    {
                        visited.Add(blockRef);
                        result.Add(CollectElementTraces(elementTraces, visited, blockRef));
                    }
                }
            }
            /*var rule = alt?.ContainingParserRuleSymbol;
            if (rule is not null)
            {

            }*/
            return new ElementTrace(element, result.ToImmutableAndFree());
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
