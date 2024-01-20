using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetaDslx.Languages.MetaGenerator.Tests
{
    public class LineEndTests : MetaGeneratorTests
    {
        [Fact]
        public void TestForEach1()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names)]
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
Hello, Bob!
Bye.
", result);
        }

        [Fact]
        public void TestForEach2()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names)]
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

Hello, Bob!

Bye.
", result);
        }

        [Fact]
        public void TestForEach3()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names)]
        [SayHello(name)]
    [end foreach]
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
            Assert.Equal(@"Hello, Alice!

Hello, Bob!

Bye.
", result);
        }

        [Fact]
        public void TestForEach4()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [foreach (var name in names)][SayHello(name)][end foreach]
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
            Assert.Equal(@"Hello, Alice!
Hello, Bob!
Bye.
", result);
        }

        [Fact]
        public void TestForEach5()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    enum Colors
    {
        [foreach (var name in names) separator ",\r\n"]
            [name][\]
        [end foreach]
    }
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"enum Colors
{
}
", result);
            result = g.SayHello(new[] { "Red" });
            Assert.Equal(@"enum Colors
{
    Red
}
", result);
            result = g.SayHello(new[] { "Red", "Green", "Blue" });
            Assert.Equal(@"enum Colors
{
    Red,
    Green,
    Blue
}
", result);
        }

        [Fact]
        public void TestForEach6()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [-]
    enum Colors
    {
        [foreach (var name in names) separator ",\r\n"]
        [name]
        [end foreach]
    }
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"enum Colors{}", result);
            result = g.SayHello(new[] { "Red" });
            Assert.Equal(@"enum Colors{Red}", result);
            result = g.SayHello(new[] { "Red", "Green", "Blue" });
            Assert.Equal(@"enum Colors{Red,Green,Blue}", result);
        }

        [Fact]
        public void TestForEach7()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [-]
    enum Colors 
    {
        [foreach (var name in names) separator ","] 
        [name]
        [end foreach] 
    }
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"enum Colors { }", result);
            result = g.SayHello(new[] { "Red" });
            Assert.Equal(@"enum Colors { Red }", result);
            result = g.SayHello(new[] { "Red", "Green", "Blue" });
            Assert.Equal(@"enum Colors { Red, Green, Blue }", result);
        }

        [Fact]
        public void TestForEach8()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [-]
    enum Colors 
    {
        [foreach (var name in names) separator ","] 
        [name][^]
        [end foreach] 
    }
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"enum Colors { }", result);
            result = g.SayHello(new[] { "Red" });
            Assert.Equal(@"enum Colors { Red }", result);
            result = g.SayHello(new[] { "Red", "Green", "Blue" });
            Assert.Equal(@"enum Colors { Red, Green, Blue }", result);
        }

        [Fact]
        public void TestForEach9()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [-]
    enum Colors 
    {
        [foreach (var name in names) separator ","] 
        [name][^]
        [end foreach] 
    }
    [=]
    enum Colors2
    {
        [foreach (var name in names) separator ","]
        [name]
        [end foreach]
    }
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"enum Colors { }
enum Colors2
{
}
", result);
            result = g.SayHello(new[] { "Red" });
            Assert.Equal(@"enum Colors { Red }
enum Colors2
{
    Red
}
", result);
            result = g.SayHello(new[] { "Red", "Green", "Blue" });
            Assert.Equal(@"enum Colors { Red, Green, Blue }
enum Colors2
{
    Red
    ,Green
    ,Blue
}
", result);
        }

        [Fact]
        public void TestForEach10()
        {
            var g = Generator("""
template SayHello(IEnumerable<string> names)
    [-]
    enum Colors 
    {
        [foreach (var name in names) separator ","] 
        [name][^]
        [end foreach] 
    }
    [=]
    enum Colors2
    {
        [foreach (var name in names) separator ",\r\n"]
        [name]
        [end foreach]
    }
end template
""");
            var result = g.SayHello(new string[0]);
            Assert.Equal(@"enum Colors { }
enum Colors2
{
}
", result);
            result = g.SayHello(new[] { "Red" });
            Assert.Equal(@"enum Colors { Red }
enum Colors2
{
    Red
}
", result);
            result = g.SayHello(new[] { "Red", "Green", "Blue" });
            Assert.Equal(@"enum Colors { Red, Green, Blue }
enum Colors2
{
    Red
    ,
    Green
    ,
    Blue
}
", result);
        }
    }
}
