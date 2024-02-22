using MetaDslx.CodeAnalysis.PooledObjects;
using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MetaDslx.CodeAnalysis.Symbols
{
    public sealed partial class CompletionGraph
    {
        private ImmutableArray<CompletionPart> _parts;
        private ImmutableHashSet<CompletionPart> _allParts;
        private ImmutableHashSet<CompletionPart> _allPartsBeforeContainedSymbolsFinalized;
        private ImmutableHashSet<CompletionPart> _allPartsBeforeContainedSymbolsCompleted;

        private CompletionGraph(IEnumerable<CompletionPart> parts)
        {
            _parts = parts.ToImmutableArrayOrEmpty();
            _allParts = ImmutableHashSet.CreateRange(parts);
            _allPartsBeforeContainedSymbolsFinalized = ImmutableHashSet.CreateRange(_allParts.Where(p => p != ContainedSymbolsFinalized && p != StartFinalizing && p != FinishFinalizing && p != ContainedSymbolsCompleted && p != StartValidating && p != FinishValidating));
            _allPartsBeforeContainedSymbolsCompleted = ImmutableHashSet.CreateRange(_allParts.Where(p => p != ContainedSymbolsCompleted && p != StartValidating && p != FinishValidating));
        }

        public static CompletionGraph CreateFromParts(CompletionGraph baseGraph, params CompletionPart[] parts)
        {
            var allParts = ArrayBuilder<CompletionPart>.GetInstance();
            allParts.Add(StartInitializing);
            allParts.Add(FinishInitializing);
            allParts.Add(StartCreatingContainedSymbols);
            allParts.Add(FinishCreatingContainedSymbols);
            foreach (var part in baseGraph.Parts)
            {
                if (!WellKnownParts.Contains(part))
                {
                    allParts.Add(part);
                }
            }
            allParts.AddRange(parts);
            allParts.Add(StartComputingNonSymbolProperties);
            allParts.Add(FinishComputingNonSymbolProperties);
            allParts.Add(ContainedSymbolsFinalized);
            allParts.Add(StartFinalizing);
            allParts.Add(FinishFinalizing);
            allParts.Add(ContainedSymbolsCompleted);
            allParts.Add(StartValidating);
            allParts.Add(FinishValidating);
            return new CompletionGraph(allParts);
        }

        public static CompletionGraph CreateFromParts(params CompletionPart[] parts)
        {
            var allParts = ArrayBuilder<CompletionPart>.GetInstance();
            allParts.Add(StartInitializing);
            allParts.Add(FinishInitializing);
            allParts.Add(StartCreatingContainedSymbols);
            allParts.Add(FinishCreatingContainedSymbols);
            allParts.AddRange(parts);
            allParts.Add(StartComputingNonSymbolProperties);
            allParts.Add(FinishComputingNonSymbolProperties);
            allParts.Add(ContainedSymbolsFinalized);
            allParts.Add(StartFinalizing);
            allParts.Add(FinishFinalizing);
            allParts.Add(ContainedSymbolsCompleted);
            allParts.Add(StartValidating);
            allParts.Add(FinishValidating);
            return new CompletionGraph(allParts);
        }

        public static CompletionGraph CreateFromPartsCustom(params CompletionPart[] allParts)
        {
            return new CompletionGraph(allParts);
        }

        public ImmutableArray<CompletionPart> Parts => _parts;
        public ImmutableHashSet<CompletionPart> AllParts => _allParts;
        public ImmutableHashSet<CompletionPart> AllPartsBeforeContainedSymbolsFinalized => _allPartsBeforeContainedSymbolsFinalized;
        public ImmutableHashSet<CompletionPart> AllPartsBeforeContainedSymbolsCompleted => _allPartsBeforeContainedSymbolsCompleted;

        public bool Contains(CompletionPart part)
        {
            return _allParts.Contains(part);
        }

        public int IndexOf(CompletionPart part)
        {
            int index = _parts.IndexOf(part);
            Debug.Assert(index >= 0);
            return index;
        }

        public bool HasComplete(CompletionPart part, int completeParts)
        {
            if (part == CompletionGraph.All)
            {
                return completeParts >= _parts.Length;
            }
            int index = _parts.IndexOf(part);
            Debug.Assert(index >= 0);
            if (index < 0) return false;
            return index <= completeParts;
        }

        public IEnumerable<CompletionPart> IncompleteParts(int completeParts)
        {
            return _parts.Skip(completeParts);
        }

        public CompletionPart NextIncompletePart(int completeParts)
        {
            if (completeParts + 1 < _parts.Length) return _parts[completeParts + 1];
            else return null;
        }
    }

}
