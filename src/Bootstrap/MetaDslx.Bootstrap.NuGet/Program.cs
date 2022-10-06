// See https://aka.ms/new-console-template for more information
using MetaDslx.Bootstrap.NuGet;

Console.WriteLine("Hello, World2!");

var hello = new HelloWorld();
var hw1 = hello.SayHelloXY("me");
Console.WriteLine(hw1);
Console.WriteLine(hello.SayHello2("me"));
Console.WriteLine(hello.SayHello3("me"));
Console.WriteLine(hello.SayHello4("me", true, true, 3));
Console.WriteLine(hello.SayHello5("me"));


var book = new Entity() { Name = "Book", Properties = new List<Property>() { 
    new Property() { Name = "Author", Type= typeof(string) },
    new Property() { Name = "Year", Type= typeof(int) }
}
};
Console.WriteLine(hello.GenerateEntity(book));

