using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public sealed class IncrementalNodeData : IEquatable<IncrementalNodeData>
    {
        public readonly State? StartState;
        public readonly State? EndState;
        public readonly int LookaheadBefore;
        public readonly int LookaheadAfter;
#if DEBUG
        public readonly int Version;
#endif

#if DEBUG
        public IncrementalNodeData(State? startState, State? endState, int lookaheadBefore, int lookaheadAfter, int version)
#else
        public IncrementalNodeData(State? startState, State? endState, int lookaheadBefore, int lookaheadAfter)
#endif
        {
            StartState = startState;
            EndState = endState;
            LookaheadBefore = lookaheadBefore;
            LookaheadAfter = lookaheadAfter;
#if DEBUG
            Version = version;
#endif
        }

        public bool Equals(State? startState, State? endState, int lookaheadBefore, int lookaheadAfter)
        {
            return startState == this.StartState &&
                endState == this.EndState &&
                lookaheadBefore == this.LookaheadBefore &&
                lookaheadAfter == this.LookaheadAfter;
        }

        public bool Equals(IncrementalNodeData other)
        {
            return Equals(other.StartState, other.EndState, other.LookaheadBefore, other.LookaheadAfter);
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
                Hash.Combine(this.LookaheadBefore, this.LookaheadAfter)));
        }
    }
}
