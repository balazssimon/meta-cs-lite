
using MetaDslx.CodeAnalysis.Text;
using MetaDslx.Languages.MetaCompiler.Antlr.Analyzers;
using MetaDslx.Languages.MetaCompiler.Syntax;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.CodeAnalysis;
using System.Reflection.Emit;
using System.Collections.Immutable;
using MetaDslx.CodeGeneration;
using System.Reflection;
using MetaDslx.Languages.MetaCompiler.Analyzers;
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
var compilerGenerator = new MetaCompilerGenerator();
var antlrGenerator = new AntlrCompilerGenerator();
GeneratorDriver driver = CSharpGeneratorDriver.Create(compilerGenerator, antlrGenerator);
var testMText = new AdditionalTextFile("Test.mlang", @"namespace X;

language Test;


main : line* eof;

line      : statement NEWLINE;

statement : varDeclaration
          | assignment    
          | print 
          | list
          ;

print : 'print' '(' expression ')' ;

varDeclaration : 'var' assignment ;

assignment : ID '=' expression ;

list : listItemSep | listSepItem | listWithFirst | listWithFirstSep | listWithLast | listWithLastSep;

listItemSep : 'ItemSep' dummy (expression ',')* dummy;
listSepItem : 'SepItem' dummy (',' expression)* dummy;
listWithFirst : 'WithFirst' dummy expression (',' expression)* dummy;
listWithFirstSep : 'WithFirstSep' dummy expression (',' expression)* ',' dummy;
listWithLast : 'WithLast' dummy (expression ',')* expression dummy;
listWithLastSep : 'WithLastSep' dummy (expression ',')* expression ',' dummy;

dummy : 'dummy' '[' expression ']';

expression : binaryMulOperation# left=expression op=('/'|'*') right=expression
           | binaryAddOperation# left=expression op=('+'|'-') right=expression 
           | typeConversion#     value=expression 'as' targetType=type                           
           | parenExpression#    '(' expression ')'
           | varReference#       ID                                                            
           | minusExpression#    '-' expression                                              
           | intLiteral#         INTLIT                                                        
           | decimalLiteral#     DECLIT 
           ;
           
type : 'Int' | 'Decimal' ;

INTLIT : '0'| '1'..'9' ('0'..'9')* ;
DECLIT : ('0'|'1'..'9' ('0'..'9')*) '.' ('0'..'9')+ ;

[Default]
[Identifier]
ID : ('_'|'a'..'z'|'A'..'Z')+('_'|'a'..'z'|'A'..'Z'|'0'..'9')*;

[Default]
[Separator]
COMMA : ',' ;

[Default]
[Whitespace]
hidden WS : ('\t'|' ') +;

[Default]
[EndOfLine]
NEWLINE : ('\r\n' | 'r' | '\n');

");
driver = driver.AddAdditionalTexts(ImmutableArray.Create<AdditionalText>(testMText));
driver = driver.RunGeneratorsAndUpdateCompilation(inputCompilation, out var outputCompilation, out var diagnostics);
GeneratorDriverRunResult runResult = driver.GetRunResult();
Console.WriteLine(runResult.GeneratedTrees.Length);
foreach (var diag in runResult.Diagnostics)
{
    Console.WriteLine(diag);
}
var outputDir = @"..\..\..\..\..\Examples\MetaDslx.Examples.Sandy";
foreach (var tree in runResult.GeneratedTrees)
{
    File.WriteAllText(Path.Combine(outputDir, Path.GetFileName(tree.FilePath)), tree.GetText().ToString());
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