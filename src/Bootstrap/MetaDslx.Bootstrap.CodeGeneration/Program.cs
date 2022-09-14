using MetaDslx.CodeAnalysis.CodeGeneration;
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
namespace HelloNs.X.Y

generator AAA

control < >

template Q()

end template
";
            var compiler = new CodeTemplateCompiler("hello.mgen", templateCode);
            Console.WriteLine(compiler.Compile());
        }
    }
}
