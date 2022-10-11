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
            CompileCodeTemplate();
            //GenerateCSharp();
        }
        static void CompileCodeTemplate()
        {
            var templateCode = @"
namespace HelloNs
generator G

using A
using B;
using C

template SayHello(string name)
  [--i;]
end template

template SayHello(string name)
    [single_line]
  [if (a)][name][else]X[end if]!
DDD
  [if (b)]
    A
  [else]
    B
  [end if]

DDD
  
    [multi_line]
  [if (b)]
    A
  [else]B[end if]
DDD[@skip-line-end]
EEE
  [if (b)]A[else]
    B
  [end if]
DDD
  [if (b)]A
  [else]B
  [end if]
DDD
  [while(i > 0) separator "",""]X[i -= 1][end while]
DDD
  [while(true)]
    X
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
  [if (a)][name][else]X[end if]!
DDD
  [if (b)]
    A
  [else]
    B
  [end if]
DDD
  [if (b)]
    A
  [else]B[end if]
DDD
  [if (b)]A[else]
    B
  [end if]
DDD
  [if (b)]A
  [else]B
  [end if]
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

    }
}
