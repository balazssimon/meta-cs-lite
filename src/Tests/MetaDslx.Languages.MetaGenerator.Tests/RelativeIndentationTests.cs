using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace MetaDslx.Languages.MetaGenerator.Tests
{
    public class RelativeIndentationTests : MetaGeneratorTests
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

        [Fact]
        public void TestCall()
        {
            var g = Generator("""
template SayHello1(string name)
  Hello1.
  [SayHello2(name)]
    [SayHello2(name)]
  [SayHello2(name)]
  Bye1.
end template

template SayHello2(string name)
  Hello2.
  [SayHello3(name)]
    [SayHello3(name)]
  [SayHello3(name)]
  Bye2.
end template

template SayHello3(string name)
  Hello3, [name]!
end template
""");
            var result = g.SayHello1("Alice");
            Assert.Equal(@"Hello1.
Hello2.
Hello3, Alice!
  Hello3, Alice!
Hello3, Alice!
Bye2.
  Hello2.
  Hello3, Alice!
    Hello3, Alice!
  Hello3, Alice!
  Bye2.
Hello2.
Hello3, Alice!
  Hello3, Alice!
Hello3, Alice!
Bye2.
Bye1.
", result);
        }


        [Fact]
        public void TestIf()
        {
            var g = Generator("""
template SayHello1(string name, bool morning)
  [if (morning)]
  Good morning, [name]!
  [else]
  Good evening, [name]!
  [end if]
end template

template SayHello2(string name, bool morning)
  Hello, [name]!
  [if (morning)]
    [GoodMorning(name)]
      [GoodMorning(name)]
    [GoodMorning(name)]
  [else]
    [GoodEvening(name)]
      [GoodEvening(name)]
    [GoodEvening(name)]
  [end if]
  Bye, [name]!
end template

template GoodMorning(string name)
  Good morning, [name]!
end template

template GoodEvening(string name)
  Good evening, [name]!
end template
""");
            var result = g.SayHello1("Alice", true);
            Assert.Equal("Good morning, Alice!\r\n", result);
            result = g.SayHello1("Alice", false);
            Assert.Equal("Good evening, Alice!\r\n", result);
            result = g.SayHello2("Alice", true);
            Assert.Equal(@"Hello, Alice!
Good morning, Alice!
  Good morning, Alice!
Good morning, Alice!
Bye, Alice!
", result);
            result = g.SayHello2("Alice", false);
            Assert.Equal(@"Hello, Alice!
Good evening, Alice!
  Good evening, Alice!
Good evening, Alice!
Bye, Alice!
", result);
        }


        [Fact]
        public void TestForEach()
        {
            var g = Generator("""
template SayHello1(IEnumerable<string> names, bool morning)
  [foreach (var name in names)]
    [if (morning)]
    Good morning, [name]!
    [else]
    Good evening, [name]!
    [end if]
  [end foreach]
end template

template SayHello2(IEnumerable<string> names, bool morning)
  [foreach (var name in names)]
    Hello, [name]!
    [if (morning)]
      [GoodMorning(name)]
        [GoodMorning(name)]
      [GoodMorning(name)]
    [else]
      [GoodEvening(name)]
        [GoodEvening(name)]
      [GoodEvening(name)]
    [end if]
    Bye, [name]!
  [end foreach]
end template

template GoodMorning(string name)
  Good morning, [name]!
end template

template GoodEvening(string name)
  Good evening, [name]!
end template
""");
            var result = g.SayHello1(new[] { "Alice", "Bob" }, true);
            Assert.Equal(@"Good morning, Alice!
Good morning, Bob!
", result);
            result = g.SayHello1(new[] { "Alice", "Bob" }, false);
            Assert.Equal(@"Good evening, Alice!
Good evening, Bob!
", result);
            result = g.SayHello2(new[] { "Alice", "Bob" }, true);
            Assert.Equal(@"Hello, Alice!
Good morning, Alice!
  Good morning, Alice!
Good morning, Alice!
Bye, Alice!
Hello, Bob!
Good morning, Bob!
  Good morning, Bob!
Good morning, Bob!
Bye, Bob!
", result);
            result = g.SayHello2(new[] { "Alice", "Bob" }, false);
            Assert.Equal(@"Hello, Alice!
Good evening, Alice!
  Good evening, Alice!
Good evening, Alice!
Bye, Alice!
Hello, Bob!
Good evening, Bob!
  Good evening, Bob!
Good evening, Bob!
Bye, Bob!
", result);
        }


        [Fact]
        public void TestSwitchCase()
        {
            var g = Generator("""
template SayHello(string name, int time)
  [switch (time)]
    [case 1:]
      Good morning, [name]!
        Good morning2, [name]!
      Good morning3, [name]!
    [case 2: case 3:]
      Good afternoon, [name]!
      [if (name == "Alice")]
        Good afternoon2, [name]!
          Good afternoon3, [name]!
        Good afternoon4, [name]!
      [else]
        Good afternoon5, [name]!
          Good afternoon6, [name]!
        Good afternoon7, [name]!
      [end if]
      Good afternoon8, [name]!
    [case 4:][case 5:]
      Good evening, [name]!
    [default:]
      Hello, [name]!
      [if (name == "Alice")]
        Hello2, [name]!
          Hello3, [name]!
        Hello4, [name]!
      [else]
        Hello5, [name]!
          Hello6, [name]!
        Hello7, [name]!
      [end if]
      Hello8, [name]!
  [end switch]
end template
""");
            var result = g.SayHello("Alice", 0);
            Assert.Equal(@"Hello, Alice!
Hello2, Alice!
  Hello3, Alice!
Hello4, Alice!
Hello8, Alice!
", result);
            result = g.SayHello("Alice", 1);
            Assert.Equal(@"Good morning, Alice!
  Good morning2, Alice!
Good morning3, Alice!
", result);
            result = g.SayHello("Alice", 2);
            Assert.Equal(@"Good afternoon, Alice!
Good afternoon2, Alice!
  Good afternoon3, Alice!
Good afternoon4, Alice!
Good afternoon8, Alice!
", result);
            result = g.SayHello("Bob", 3);
            Assert.Equal(@"Good afternoon, Bob!
Good afternoon5, Bob!
  Good afternoon6, Bob!
Good afternoon7, Bob!
Good afternoon8, Bob!
", result);
            result = g.SayHello("Alice", 4);
            Assert.Equal("", result);
            result = g.SayHello("Alice", 5);
            Assert.Equal("Good evening, Alice!\r\n", result);
            result = g.SayHello("Bob", 6);
            Assert.Equal(@"Hello, Bob!
Hello5, Bob!
  Hello6, Bob!
Hello7, Bob!
Hello8, Bob!
", result);
        }
    }
}
