using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public sealed class IncrementalTokenData : IEquatable<IncrementalTokenData>
    {
        public readonly LexerState? StartState;
        public readonly LexerState? EndState;
        public readonly int LookaheadBefore;
        public readonly int LookaheadAfter;

        public IncrementalTokenData(LexerState? startState, LexerState? endState, int lookaheadBefore, int lookaheadAfter)
        {
            StartState = startState;
            EndState = endState;
            LookaheadBefore = lookaheadBefore;
            LookaheadAfter = lookaheadAfter;
        }

        public bool Equals(LexerState? startState, LexerState? endState, int lookaheadBefore, int lookaheadAfter)
        {
            return startState == this.StartState &&
                endState == this.EndState &&
                lookaheadBefore == this.LookaheadBefore &&
                lookaheadAfter == this.LookaheadAfter;
        }

        public bool Equals(IncrementalTokenData other)
        {
            return Equals(other.StartState, other.EndState, other.LookaheadBefore, other.LookaheadAfter);
        }

        public override bool Equals(object obj)
        {
            if (obj is IncrementalTokenData other) return this.Equals(other);
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
