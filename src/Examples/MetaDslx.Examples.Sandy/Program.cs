// See https://aka.ms/new-console-template for more information
using X;

Console.WriteLine("Hello, World!");

var tree = TestSyntaxTree.ParseText("var a = 3+4;");
Console.WriteLine(tree.ToString());

