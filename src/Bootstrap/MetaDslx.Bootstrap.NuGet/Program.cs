// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.NuGet;

Console.WriteLine("Hello, World2!");

var hello = new HelloWorld();
var hw1 = hello.SayHello("me");
Console.WriteLine(hw1);
Console.WriteLine(hello.SayHello2("me"));
Console.WriteLine(hello.SayHello3("me"));
Console.WriteLine(hello.SayHello4("me", true, true, 3));
Console.WriteLine(hello.SayHello5("me"));

