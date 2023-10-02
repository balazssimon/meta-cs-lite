using System;
using System.Collections.Generic;
using System.Text;

namespace MetaDslx.Languages.MetaCompiler.Model
{
    public enum Multiplicity
    {
        ExactlyOne,
        ZeroOrOne,
        ZeroOrMore,
        OneOrMore,
        NonGreedyZeroOrOne,
        NonGreedyZeroOrMore,
        NonGreedyOneOrMore
    }

    public static class MultiplicityExtensions
    {
        public static bool IsList(this Multiplicity multiplicity)
        {
            return multiplicity == Multiplicity.ZeroOrMore || multiplicity == Multiplicity.OneOrMore || multiplicity == Multiplicity.NonGreedyZeroOrMore || multiplicity == Multiplicity.NonGreedyOneOrMore;
        }

        public static bool IsOptional(this Multiplicity multiplicity)
        {
            return multiplicity == Multiplicity.ZeroOrOne || multiplicity == Multiplicity.NonGreedyZeroOrOne;
        }
    }

}
