using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetaDslx.Languages.MetaGenerator.Tests
{
    public class StatementTests : MetaGeneratorTests
    {
        [Fact]
        public void TestSingleLineSwitch()
        {
            var g = Generator("""
template GenerateMultiplicity(Multiplicity multiplicity)
    [-]
    [switch (multiplicity)]
        [case Multiplicity.ZeroOrOne:]?
        [case Multiplicity.ZeroOrMore:]*
        [case Multiplicity.OneOrMore:]+
        [case Multiplicity.NonGreedyZeroOrOne:]??
        [case Multiplicity.NonGreedyZeroOrMore:]*?
        [case Multiplicity.NonGreedyOneOrMore:]+?
    [end switch]
end template
""");
            // TODO:
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"Hello, Alice!
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"Hello, Alice!
===
Hello, Bob!
Bye.
", result);
        }
    }
}
