using MetaDslx.Bootstrap.Antlr4.Sandy;
using MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;

namespace MetaDslx.Bootstrap.Antlr
{
    class Program
    {
        static void Main(string[] args)
        {

            //string source = "var a @ = 3\r\nvar b = 5\r\nvar c = + b\r\n\r\n@";
            //string source = "var a = 3\r\nvar b = 5\r\nvar c = a + b";
            //string source = "var a = 3\r\nvar b = 5\r\nvar c = ((a + b\r\n";
            //string source = "var a = 3\r\nvar b = 5\r\nvar c = (a + b)\r\n";
            string source = "var a = 3\r\nvar b = 5\r\nvar c = (a + b\r\n";
            var tree = SandySyntaxTree.ParseText(source);
            Console.WriteLine(tree);

            foreach (var diag in tree.GetDiagnostics())
            {
                Console.WriteLine(diag);
            }

            /*var parser = new SandyParser(new Antlr4LexerBasedTokenStream(lexer));
            parser.ErrorHandler = new DefaultErrorStrategy();
            var main = parser.main();
            Console.WriteLine(main);*/
            /*InternalSyntaxToken? token = null;
            do
            {
                token = lexer.Lex();
                if (token != null)
                {
                    Console.WriteLine($"{token.KindText}: '{token.ToFullString()}'");
                }
            }
            while (token != null);
            Console.WriteLine();
            foreach (var error in lexer.Errors)
            {
                Console.WriteLine($"({error.Offset}:{error.Width}): {error}");
            }*/
        }
    }
}
