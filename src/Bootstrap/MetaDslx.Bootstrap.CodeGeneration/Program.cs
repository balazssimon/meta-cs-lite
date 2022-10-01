using MetaDslx.CodeAnalysis.Analyzers;
using MetaDslx.CodeAnalysis.CodeGeneration;
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.CodeGeneration;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System;
using System.Diagnostics.Metrics;
using System.Reflection;
using System.Collections.Immutable;

namespace MetaDslx.Bootstrap.CodeGeneration
{
    class Program
    {
        static void Main(string[] args)
        {
            //CompileCodeTemplate();
            GenerateCSharp();
        }

        static void GenerateCSharp()
        {
            Compilation inputCompilation = CreateCompilation(@"
namespace MyCode
{
    public class Program
    {
        public static void Main(string[] args)
        {
        }
    }
}
");
            var generator = new MetaGeneratorGenerator();
            GeneratorDriver driver = CSharpGeneratorDriver.Create(generator);
            var helloMgen = new AdditionalTextFile("HelloWorld.mgen", @"
namespace MetaDslx.Bootstrap.NuGet

generator HelloWorld

template SayHello(string name)
Hello, [name]!
end template
");
            driver = driver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(helloMgen));
            driver = driver.RunGeneratorsAndUpdateCompilation(inputCompilation, out var outputCompilation, out var diagnostics);
            GeneratorDriverRunResult runResult = driver.GetRunResult();
            Console.WriteLine(runResult.GeneratedTrees.Length);
        }

        private static Compilation CreateCompilation(string source)
            => CSharpCompilation.Create("compilation",
                new[] { CSharpSyntaxTree.ParseText(source) },
                new[] 
                { 
                    MetadataReference.CreateFromFile(typeof(Binder).GetTypeInfo().Assembly.Location),
                    MetadataReference.CreateFromFile(typeof(CodeBuilder).GetTypeInfo().Assembly.Location)
                },
                new CSharpCompilationOptions(OutputKind.ConsoleApplication));

        static void CompileCodeTemplate()
        {
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
            var compiler = new MetaGeneratorParser("hello.mgen", SourceText.From(templateCode));
            var compiledCode = compiler.Compile();
            Console.WriteLine(compiledCode);
            foreach (var diag in compiler.Diagnostics)
            {
                Console.WriteLine(diag);
            }
        }
    }
}
