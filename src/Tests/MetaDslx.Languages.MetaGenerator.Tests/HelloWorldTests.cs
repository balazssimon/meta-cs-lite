using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetaDslx.Languages.MetaGenerator.Tests
{
    public class HelloWorldTests : MetaGeneratorTests
    {
        [Fact]
        public void TestHelloWorld()
        {
            var g = Generator("""
template SayHello(string name)
Hello, [name]!
end template
""");
            var result = g.SayHello("Alice");
            Assert.Equal("Hello, Alice!\r\n", result);
        }
    }
}
