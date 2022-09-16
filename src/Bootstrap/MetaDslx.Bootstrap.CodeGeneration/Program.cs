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

            var templateCode =
@"
namespace HelloNs.X.Y;

generator AAA;

control [ ]

using System.C;
using System.D

template Q(int a, int b = 5)
  aaa!
  [var a = 5; a*2]
  [var b = a]
  [B b = a]
  [b = a]
  [while (x == y)]cc
    [if (a > n)]
      xx
      vv
    [end if]
    bb
    [if (a > n)]yy[end if]
  [end while]
  bbb
end template";
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
            var compiler = new CodeTemplateParser("hello.mgen", templateCode);
            var compiledCode = compiler.Compile();
            Console.WriteLine(compiledCode);
            foreach (var diag in compiler.Diagnostics)
            {
                Console.WriteLine(diag);
            }
        }
    }
}
