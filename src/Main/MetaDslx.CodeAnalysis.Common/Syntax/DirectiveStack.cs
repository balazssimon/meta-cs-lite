using Roslyn.Utilities;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace MetaDslx.CodeAnalysis.Syntax
{
    [DebuggerDisplay("{GetDebuggerDisplay(), nq}")]
    public struct DirectiveStack
    {
        public static readonly DirectiveStack Empty = new DirectiveStack(ConsList<Directive>.Empty);
        public static readonly DirectiveStack Null = new DirectiveStack(null);

        private readonly ConsList<Directive>? _directives;

        private DirectiveStack(ConsList<Directive>? directives)
        {
            _directives = directives;
        }

        public bool IsNull
        {
            get
            {
                return _directives == null;
            }
        }

        public bool IsEmpty
        {
            get
            {
                return _directives == ConsList<Directive>.Empty;
            }
        }

        public DefineState IsDefined(string id)
        {
            for (var current = _directives; current != null && current.Any(); current = current.Tail)
            {
                switch (current.Head.Kind)
                {
                    case DirectiveKind.Define:
                        if (current.Head.GetIdentifier() == id)
                        {
                            return DefineState.Defined;
                        }

                        break;
                    case DirectiveKind.Undef:
                        if (current.Head.GetIdentifier() == id)
                        {
                            return DefineState.Undefined;
                        }

                        break;

                    case DirectiveKind.Elif:
                    case DirectiveKind.Else:
                        // Skip directives from previous branches of the same #if.
                        do
                        {
                            current = current.Tail;

                            if (current == null || !current.Any())
                            {
                                return DefineState.Unspecified;
                            }
                        }
                        while (current.Head.Kind != DirectiveKind.If);

                        break;
                }
            }

            return DefineState.Unspecified;
        }

        // true if any previous section of the closest #if has its branch taken
        public bool PreviousBranchTaken()
        {
            for (var current = _directives; current != null && current.Any(); current = current.Tail)
            {
                if (current.Head.BranchTaken)
                {
                    return true;
                }
                else if (current.Head.Kind == DirectiveKind.If)
                {
                    return false;
                }
            }

            return false;
        }

        public bool HasUnfinishedIf()
        {
            var prev = GetPreviousIfElifElseOrRegion(_directives);
            return prev != null && prev.Any() && prev.Head.Kind != DirectiveKind.Region;
        }

        public bool HasPreviousIfOrElif()
        {
            var prev = GetPreviousIfElifElseOrRegion(_directives);
            return prev != null && prev.Any() && (prev.Head.Kind == DirectiveKind.If || prev.Head.Kind == DirectiveKind.Elif);
        }

        public bool HasUnfinishedRegion()
        {
            var prev = GetPreviousIfElifElseOrRegion(_directives);
            return prev != null && prev.Any() && prev.Head.Kind == DirectiveKind.Region;
        }

        public DirectiveStack Add(Directive directive)
        {
            switch (directive.Kind)
            {
                case DirectiveKind.EndIf:
                    var prevIf = GetPreviousIf(_directives);
                    if (prevIf == null || !prevIf.Any())
                    {
                        goto default; // no matching if directive !! leave directive alone
                    }

                    bool tmp;
                    return new DirectiveStack(CompleteIf(_directives, out tmp));
                case DirectiveKind.EndRegion:
                    var prevRegion = GetPreviousRegion(_directives);
                    if (prevRegion == null || !prevRegion.Any())
                    {
                        goto default; // no matching region directive !! leave directive alone
                    }

                    return new DirectiveStack(CompleteRegion(_directives)); // remove region directives from stack but leave everything else
                default:
                    return new DirectiveStack(new ConsList<Directive>(directive, _directives != null ? _directives : ConsList<Directive>.Empty));
            }
        }

        // removes unfinished if & related directives from stack and leaves active branch directives
        private static ConsList<Directive>? CompleteIf(ConsList<Directive>? stack, out bool include)
        {
            // if we get to the top, the default rule is to include anything that follows
            if (stack == null || !stack.Any())
            {
                include = true;
                return stack;
            }

            // if we reach the #if directive, then we stop unwinding and start
            // rebuilding the stack w/o the #if/#elif/#else/#endif directives
            // only including content from sections that are considered included
            if (stack.Head.Kind == DirectiveKind.If)
            {
                include = stack.Head.BranchTaken;
                return stack.Tail;
            }

            var newStack = CompleteIf(stack.Tail, out include);
            switch (stack.Head.Kind)
            {
                case DirectiveKind.Elif:
                case DirectiveKind.Else:
                    include = stack.Head.BranchTaken;
                    break;
                default:
                    if (include)
                    {
                        newStack = new ConsList<Directive>(stack.Head, newStack ?? ConsList<Directive>.Empty);
                    }

                    break;
            }

            return newStack;
        }

        // removes region directives from stack but leaves everything else
        private static ConsList<Directive>? CompleteRegion(ConsList<Directive>? stack)
        {
            // if we get to the top, the default rule is to include anything that follows
            if (stack == null || !stack.Any())
            {
                return stack;
            }

            if (stack.Head.Kind == DirectiveKind.Region)
            {
                return stack.Tail;
            }

            var newStack = CompleteRegion(stack.Tail);
            newStack = new ConsList<Directive>(stack.Head, newStack ?? ConsList<Directive>.Empty);
            return newStack;
        }

        private static ConsList<Directive>? GetPreviousIf(ConsList<Directive>? directives)
        {
            var current = directives;
            while (current != null && current.Any())
            {
                switch (current.Head.Kind)
                {
                    case DirectiveKind.If:
                        return current;
                }

                current = current.Tail;
            }

            return current;
        }

        private static ConsList<Directive>? GetPreviousIfElifElseOrRegion(ConsList<Directive>? directives)
        {
            var current = directives;
            while (current != null && current.Any())
            {
                switch (current.Head.Kind)
                {
                    case DirectiveKind.If:
                    case DirectiveKind.Elif:
                    case DirectiveKind.Else:
                    case DirectiveKind.Region:
                        return current;
                }

                current = current.Tail;
            }

            return current;
        }

        private static ConsList<Directive>? GetPreviousRegion(ConsList<Directive>? directives)
        {
            var current = directives;
            while (current != null && current.Any() && current.Head.Kind != DirectiveKind.Region)
            {
                current = current.Tail;
            }

            return current;
        }

        private string GetDebuggerDisplay()
        {
            var sb = new StringBuilder();
            for (var current = _directives; current != null && current.Any(); current = current.Tail)
            {
                if (sb.Length > 0)
                {
                    sb.Insert(0, " | ");
                }

                sb.Insert(0, current.Head.GetDebuggerDisplay());
            }

            return sb.ToString();
        }

        public bool IncrementallyEquivalent(DirectiveStack other)
        {
            var mine = SkipInsignificantDirectives(_directives);
            var theirs = SkipInsignificantDirectives(other._directives);
            bool mineHasAny = mine != null && mine.Any();
            bool theirsHasAny = theirs != null && theirs.Any();
            while (mineHasAny && theirsHasAny)
            {
                if (!mine!.Head.IncrementallyEquivalent(theirs!.Head))
                {
                    return false;
                }

                mine = SkipInsignificantDirectives(mine.Tail);
                theirs = SkipInsignificantDirectives(theirs.Tail);
                mineHasAny = mine != null && mine.Any();
                theirsHasAny = theirs != null && theirs.Any();
            }

            return mineHasAny == theirsHasAny;
        }

        private static ConsList<Directive>? SkipInsignificantDirectives(ConsList<Directive>? directives)
        {
            for (; directives != null && directives.Any(); directives = directives.Tail)
            {
                switch (directives.Head.Kind)
                {
                    case DirectiveKind.If:
                    case DirectiveKind.Elif:
                    case DirectiveKind.Else:
                    case DirectiveKind.EndIf:
                    case DirectiveKind.Define:
                    case DirectiveKind.Undef:
                    case DirectiveKind.Region:
                    case DirectiveKind.EndRegion:
                        return directives;
                }
            }

            return directives;
        }
    }
}
