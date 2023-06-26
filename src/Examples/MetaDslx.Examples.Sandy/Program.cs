// See https://aka.ms/new-console-template for more information
using MetaDslx.CodeAnalysis;
using X;

Console.WriteLine("Hello, World!");

var tree = TestSyntaxTree.ParseText("var a = 3+4\r\nvar b = a + 3 \r\n   ");
Console.WriteLine(tree.ToString());

foreach (var diag in tree.GetDiagnostics())
{
    Console.WriteLine(diag);
}

