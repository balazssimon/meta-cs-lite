
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Antlr.Analyzers;
using MetaDslx.Languages.MetaCompiler.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Reflection.Emit;
using System.Collections.Immutable;
using MetaDslx.CodeGeneration;
using System.Reflection;
/*
var code = @"
namespace A.B.C;

using D.E;
using D;

language Sample;

[B(x = true, y = 'a'+3)]
g: [Q] aa# [T] a+= [R] A*? eof
 | bb# b=B
 ;

[def A]
f: a;

a: A;

al: f [P] a [Q] (',' [R] a)* G;

fragment A: 'a';
B: 'b';

[C]
G: 'a'..'z';
";

var parser = new MetaCompilerParser("sample.mcomp", SourceText.From(code));
var language = parser.Parse();
Console.WriteLine(language.Namespace);
*/
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
var antlrGenerator = new AntlrCompilerGenerator();
GeneratorDriver driver = CSharpGeneratorDriver.Create(antlrGenerator);
var testMText = new AdditionalTextFile("Test.mlang", @"namespace X;

language Test;

main: Int a='int' s?='string' r!=Az?;

foo: i+='int' (',' i+='int')*;
bar: f+=foo (';' f+=foo)+;

Az: ('a'..'z')+;

Int: 'int';");
driver = driver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(testMText));
driver = driver.RunGeneratorsAndUpdateCompilation(inputCompilation, out var outputCompilation, out var diagnostics);
GeneratorDriverRunResult runResult = driver.GetRunResult();
Console.WriteLine(runResult.GeneratedTrees.Length);
foreach (var diag in runResult.Diagnostics)
{
    Console.WriteLine(diag);
}

static Compilation CreateCompilation(string source)
    => CSharpCompilation.Create("compilation",
        new[] { CSharpSyntaxTree.ParseText(source) },
        new[]
        {
            MetadataReference.CreateFromFile(typeof(Binder).GetTypeInfo().Assembly.Location),
            MetadataReference.CreateFromFile(typeof(CodeBuilder).GetTypeInfo().Assembly.Location)
        },
        new CSharpCompilationOptions(OutputKind.ConsoleApplication));