using MetaDslx.Bootstrap.Antlr4.Sandy;
using MetaDslx.Bootstrap.Antlr4.Sandy.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Antlr4;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;

namespace MetaDslx.Bootstrap.Antlr4
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexer = SandyLanguage.Instance.InternalSyntaxFactory.CreateLexer(SourceText.From("var a @ = 3\r\nvar b = 5\r\nvar c = a + b\r\n\r\n@"), null);
            var parser = SandyLanguage.Instance.InternalSyntaxFactory.CreateParser(lexer, null, null, null, default);
            var main = parser.Parse();
            Console.WriteLine(main);
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
