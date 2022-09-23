using MetaDslx.CodeAnalysis.CodeGeneration;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeGeneration;
using System;
using System.Diagnostics.Metrics;

namespace MetaDslx.Bootstrap.CodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            var cb = CodeBuilder.GetInstance();
            cb.WriteLine("aaa");
            cb.Push("  [", "]");
            cb.WriteLine("bbb");
            cb.Write("ccc\r\nddd");
            cb.Push("  [", "]");
            cb.WriteLine("bbb");
            cb.Write("ccc\r\nddd");
            cb.WriteLine("");
            //cb.Write("\r\n\r\neee\r\n\r\n");
            //cb.Write("\r\n\r\neee\r\n");
            cb.Write("\r\n\r\neee");
            cb.Pop();
            //cb.Write("\r\n\r\neee\r\n\r\n");
            //cb.Write("\r\n\r\neee\r\n");
            cb.Write("\r\n\r\neee");
            cb.Pop();
            cb.WriteLine("fff");
            Console.WriteLine(cb.ToStringAndFree());

            var templateCode2 =
@"
namespace HelloNs.X.Y;

generator AAA;

using System.C;
using System.D

control [ ]

template Q()
  aaa!
  [var a = 5; a*2]
  [var b = a]
  [B b = a]
  [b = a]
  [while (x == y) separator x+1]cc
    [if (a > n)]
      xx
      vv
      [try]
          aaa
      [catch(Exception ex)]
          bbb
      [catch(Exception2 ex2)]
          ccc
      [catch]
          ddd
      [finally]
          eee
      [end try]
    [end ifx]
    bb
    [if (a > n)]yy[end while]
  [end while]
  [switch(c)]
    [case X:]
      aaa
      [switch(c)]
        [case X:]
          aaa
        [case Y:]
          bbb
        [default:]
          ccc
      [end switch]
    [case Y:]
      bbb
      [switch(c)]
        [case X:]
          aaa
        [case Y:]
          bbb
        [default:]
          ccc
      [end switch]
    [default:]
      ccc
      [switch(c)]
        [case X:]
          aaa
        [case Y:]
          bbb
        [default:]
          ccc
      [end switch]
      eee
  [end switch]
  bbb
end template

template Q(string name)
hello
end template

";
            /*var lexer = new CodeTemplateLexer("hello.mgen", SourceText.From(templateCode), true);
            var state = CodeTemplateLexerState.None;
            while (true)
            {
                var token = lexer.Lex(ref state);
                Console.WriteLine($"{token} -> {state}");
                if (token.Kind == CodeTemplateTokenKind.EndOfFile) break;
            }
            foreach (var diag in lexer.GetDiagnostics())
            {
                Console.WriteLine(diag);
            }*/
            var templateCode = @"
namespace HelloNs
generator G
template A()
  [if (a)]
    xxx
  [else]
    yyy
  [end while]
end template
";
            var compiler = new CodeTemplateParser("hello.mgen", SourceText.From(templateCode));
            var compiledCode = compiler.Compile();
            Console.WriteLine(compiledCode);
            foreach (var diag in compiler.Diagnostics)
            {
                Console.WriteLine(diag);
            }
        }
    }
}
