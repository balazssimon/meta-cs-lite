using MetaDslx.CodeAnalysis.CodeGeneration;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeGeneration;
using System;

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

control < >;

template Q(int a, int b = 5)
[if (a > 3)]
Hello, [name(a[5])]!
[else if (b < 3)]
aaa
[else]
bbb
[end if]
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
            var compiler = new CodeTemplateCompiler("hello.mgen", templateCode);
            var compiledCode = compiler.Compile();
            Console.WriteLine(compiledCode);
        }
    }
}
