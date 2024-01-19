using Xunit;

namespace MetaDslx.Languages.MetaGenerator.Tests
{
    public class ControlCharsTests : MetaGeneratorTests
    {
        [Fact]
        public void TestDefault()
        {
            var g = Generator("""
template SayHello(string name)
Hello, [name]!
end template
""");
            var result = g.SayHello("Alice");
            Assert.Equal("Hello, Alice!\r\n", result);
        }

        [Fact]
        public void TestT4()
        {
            var g = Generator("""
control <# #>

template SayHello(string name)
Hello, <#name#>!
end template
""");
            var result = g.SayHello("Alice");
            Assert.Equal("Hello, Alice!\r\n", result);
        }

        [Fact]
        public void TestXtend()
        {
            var g = Generator("""
control chevrons

template SayHello(string name)
Hello, «name»!
end template
""");
            var result = g.SayHello("Alice");
            Assert.Equal("Hello, Alice!\r\n", result);
        }

        [Fact]
        public void TestVariation()
        {
            var g = Generator("""
control chevrons

template SayHelloXtend(string name)
Hello, «name»!
end template

control <# #>

template SayHelloT4(string name)
Hello, <#name#>!
end template

control default

template SayHelloMgen1(string name)
Hello, [name]!
end template

control < >

template SayHelloStringTemplate(string name)
Hello, <name>!
end template

control [ ]

template SayHelloMgen2(string name)
Hello, [name]!
end template
""");
            Assert.Equal("Hello, Xtend!\r\n", g.SayHelloXtend("Xtend"));
            Assert.Equal("Hello, T4!\r\n", g.SayHelloT4("T4"));
            Assert.Equal("Hello, Mgen1!\r\n", g.SayHelloMgen1("Mgen1"));
            Assert.Equal("Hello, StringTemplate!\r\n", g.SayHelloStringTemplate("StringTemplate"));
            Assert.Equal("Hello, Mgen2!\r\n", g.SayHelloMgen2("Mgen2"));
        }
    }
}