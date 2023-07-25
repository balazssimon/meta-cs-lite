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
        private ImmutableHashSet<CompletionPart> _allPartsWithLocation;

        private CompletionGraph(IEnumerable<CompletionPart> parts)
        {
            _parts = parts.ToImmutableArrayOrEmpty();
            _allParts = ImmutableHashSet.CreateRange(parts);
            _allPartsWithLocation = ImmutableHashSet.CreateRange(_allParts.Where(p => p != ContainedSymbolsCompleted && p != StartValidatingSymbol && p != FinishValidatingSymbol));
        }

        public static CompletionGraph CreateFromParts(params CompletionPart[] parts)
        {
            return new CompletionGraph(parts);
        }

        public ImmutableArray<CompletionPart> Parts => _parts;
        public ImmutableHashSet<CompletionPart> AllParts => _allParts;
        public ImmutableHashSet<CompletionPart> AllPartsWithLocation => _allPartsWithLocation;

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
