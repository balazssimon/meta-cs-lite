using MetaDslx.Bootstrap.Antlr4.Sandy;
using MetaDslx.CodeAnalysis.Syntax.InternalSyntax;
using MetaDslx.CodeAnalysis.Text;
using System;

namespace MetaDslx.Bootstrap.Antlr4
{
    class Program
    {
        static void Main(string[] args)
        {
            var lexer = SandyLanguage.Instance.InternalSyntaxFactory.CreateLexer(SourceText.From("Int a = 3;\r\nInt b = 5;\r\n@\r\nInt c = (a+b"), null);
            InternalSyntaxToken? token = null;
            do
            {
                token = lexer.Lex();
                if (token != null)
                {
                    Console.WriteLine($"{token.KindText}: '{token.Text}'");
                }
            }
            while (token != null);
            Console.WriteLine();
            foreach (var error in lexer.Errors)
            {
                Console.WriteLine($"({error.Offset}:{error.Width}): {error}");
            }
        }
    }
}
