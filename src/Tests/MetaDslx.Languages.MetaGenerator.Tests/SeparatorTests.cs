using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetaDslx.Languages.MetaGenerator.Tests
{
    public class SeparatorTests : MetaGeneratorTests
    {
        [Fact]
        public void TestForEach()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) separator "===\r\n"]
        Hello, [name]!
    [end foreach]
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"Hello, Alice!
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"Hello, Alice!
===
Hello, Bob!
", result);
        }

        [Fact]
        public void TestForEachBSA()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<\r\n" separator "===\r\n" after ">>>\r\n"]
        Hello, [name]!
    [end foreach]
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<
Hello, Alice!
>>>
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<
Hello, Alice!
===
Hello, Bob!
>>>
", result);
        }

        [Fact]
        public void TestForEachBSA2()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<" separator "===" after ">>>"]Hello, [name]![end foreach]
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<Hello, Alice!>>>
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<Hello, Alice!===Hello, Bob!>>>
", result);
        }
    }
}
