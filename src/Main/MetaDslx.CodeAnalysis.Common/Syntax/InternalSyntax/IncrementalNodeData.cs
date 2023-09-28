using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public sealed class IncrementalNodeData : IEquatable<IncrementalNodeData>
    {
        public readonly ParserState? StartState;
        public readonly ParserState? EndState;
        public readonly int LookAhead;
        public readonly int LookBack;
#if DEBUG
        public readonly int Version;
#endif

#if DEBUG
        public IncrementalNodeData(ParserState? startState, ParserState? endState, int lookAhead, int lookBack, int version)
#else
        public IncrementalNodeData(ParserState? startState, ParserState? endState, int lookAhead, int lookBack)
#endif
        {
            StartState = startState;
            EndState = endState;
            LookAhead = lookAhead;
            LookBack = lookBack;
#if DEBUG
            Version = version;
#endif
        }

        public bool Equals(ParserState? startState, ParserState? endState, int lookAhead, int lookBack)
        {
            return startState == this.StartState &&
                endState == this.EndState &&
                lookAhead == this.LookAhead &&
                lookBack == this.LookBack;
        }

        public bool Equals(IncrementalNodeData other)
        {
            return Equals(other.StartState, other.EndState, other.LookAhead, other.LookBack);
        }

        public override bool Equals(object obj)
        {
            if (obj is IncrementalNodeData other) return this.Equals(other);
            else return false;
        }

        public override int GetHashCode()
        {
            return Hash.Combine(this.StartState?.GetHashCode() ?? 0, 
                Hash.Combine(this.EndState?.GetHashCode() ?? 0,
                Hash.Combine(this.LookAhead, this.LookBack)));
        }
    }
}
