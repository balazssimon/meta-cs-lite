using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax.InternalSyntax
{
    public struct IncrementalTokenData : IEquatable<IncrementalTokenData>
    {
        public readonly LexerState? StartState;
        public readonly LexerState? EndState;
        public readonly int LookAhead;
        public readonly int LookBack;

        public IncrementalTokenData(LexerState? startState, LexerState? endState, int lookAhead, int lookBack)
        {
            StartState = startState;
            EndState = endState;
            LookAhead = lookAhead;
            LookBack = lookBack;
        }

        public bool Equals(LexerState? startState, LexerState? endState, int lookAhead, int lookBack)
        {
            return startState == this.StartState &&
                endState == this.EndState &&
                lookAhead == this.LookAhead &&
                lookBack == this.LookBack;
        }

        public bool Equals(IncrementalTokenData other)
        {
            return Equals(other.StartState, other.EndState, other.LookAhead, other.LookBack);
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
                Hash.Combine(this.LookAhead, this.LookBack)));
        }
    }
}
