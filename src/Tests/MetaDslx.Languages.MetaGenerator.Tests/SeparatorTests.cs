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
    Bye.
end template
""");
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

        [Fact]
        public void TestForEachBSA1()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<\r\n" separator "===\r\n" after ">>>\r\n"]
        Hello, [name]!
    [end foreach]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<
Hello, Alice!
>>>
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<
Hello, Alice!
===
Hello, Bob!
>>>
Bye.
", result);
        }

        [Fact]
        public void TestForEachBSA2()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<" separator "===" after ">>>"]
        Hello, [name]!
    [end foreach]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<
Hello, Alice!
>>>
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<
Hello, Alice!
===Hello, Bob!
>>>
Bye.
", result);
        }

        [Fact]
        public void TestForEachBSA3()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<" separator "===" after ">>>"]Hello, [name]![end foreach]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<Hello, Alice!>>>
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<Hello, Alice!===Hello, Bob!>>>
Bye.
", result);
        }

        [Fact]
        public void TestForEachBSA4()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<" separator "===" after ">>>"]
        Hello, [name]![\]
    [end foreach]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<
Hello, Alice!>>>
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<
Hello, Alice!===Hello, Bob!>>>
Bye.
", result);
        }

        [Fact]
        public void TestForEachBSA5()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<" separator "===" after ">>>"]Hello, [name]!
    [end foreach]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<Hello, Alice!
>>>
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<Hello, Alice!
===Hello, Bob!
>>>
Bye.
", result);
        }

        [Fact]
        public void TestForEachBSA6()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<" separator "===" after ">>>"]Hello, [name]![\]
    [end foreach]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<Hello, Alice!>>>
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<Hello, Alice!===Hello, Bob!>>>
Bye.
", result);
        }

        [Fact]
        public void TestForEachBSA7()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names) before "<<<" separator "===" after ">>>"]
      Hello, [name]![end foreach]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"<<<
Hello, Alice!>>>
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"<<<
Hello, Alice!===Hello, Bob!>>>
Bye.
", result);
        }

        [Fact]
        public void TestSelect1()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    Hello [names separator ", "]!
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Hello !
Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"Hello Alice!
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"Hello Alice, Bob!
Bye.
", result);
        }

        [Fact]
        public void TestSelect2()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    Hello [names before "(" separator ", " after ")"]!
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Hello !
Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"Hello (Alice)!
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"Hello (Alice, Bob)!
Bye.
", result);
        }

        [Fact]
        public void TestSelect3()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    Hello
    [names before "(" separator ", " after ")"]
    Bye.
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Hello
Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"Hello
(Alice)
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"Hello
(Alice, Bob)
Bye.
", result);
        }

        [Fact]
        public void TestSelect4()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [from name in names select SayHello(name) separator ""]
    Bye.
end template

template SayHello(string name)
    Hello, [name]!
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"Hello, Alice!
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"Hello, Alice!Hello, Bob!
Bye.
", result);
        }

        [Fact]
        public void TestSelect5()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [from name in names select SayHello(name) before "(" separator ", " after ")"]
    Bye.
end template

template SayHello(string name)
    Hello, [name]!
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"Bye.
", result);
            result = g.SayHello(new[] { "Alice" });
            Assert.Equal(@"(Hello, Alice!)
Bye.
", result);
            result = g.SayHello(new[] { "Alice", "Bob" });
            Assert.Equal(@"(Hello, Alice!, Hello, Bob!)
Bye.
", result);
        }
    }
}
