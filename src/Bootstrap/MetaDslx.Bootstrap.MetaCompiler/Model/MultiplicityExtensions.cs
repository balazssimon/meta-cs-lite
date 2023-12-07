using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetaDslx.Bootstrap.MetaCompiler.Model
{
    public static class MultiplicityExtensions
    {
        public static bool IsSingle(this Multiplicity multiplicity)
        {
            return multiplicity == Multiplicity.ExactlyOne || multiplicity == Multiplicity.ZeroOrOne || multiplicity == Multiplicity.NonGreedyZeroOrOne;
        }

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
