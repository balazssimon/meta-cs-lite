#line (1,10)-(1,59) 10 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
namespace MetaDslx.Languages.MetaCompiler.Antlr.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    using
    #line hidden
    global::
    #line (5,7)-(5,18) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    System.Linq;
    #line hidden
    #line (6,1)-(6,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    using
    #line hidden
    global::
    #line (6,7)-(6,23) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    Roslyn.Utilities;
    #line hidden
    
    #line (8,10)-(8,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
    public partial class AntlrGenerator
    #line hidden
    {
        #line (11,9)-(11,48) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
        public string GenerateSyntaxLexer(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (12,1)-(12,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (12,6)-(12,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,1)-(15,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (15,6)-(15,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (15,7)-(15,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,1)-(16,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (16,6)-(16,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (16,7)-(16,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (18,1)-(18,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (18,10)-(18,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (18,11)-(18,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,1)-(20,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (20,10)-(20,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (20,12)-(20,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            #line (20,40)-(20,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(".Syntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (21,1)-(21,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (22,11)-(22,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,12)-(22,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("partial");
            #line hidden
            #line (22,19)-(22,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,20)-(22,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (22,25)-(22,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,27)-(22,40) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (22,41)-(22,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxLexer");
            #line hidden
            #line (22,52)-(22,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,53)-(22,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (22,54)-(22,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,55)-(22,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrSyntaxLexer");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,5)-(23,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (24,9)-(24,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (24,15)-(24,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (24,17)-(24,30) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (24,31)-(24,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxLexer(SourceText");
            #line hidden
            #line (24,53)-(24,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (24,54)-(24,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("text,");
            #line hidden
            #line (24,59)-(24,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (24,61)-(24,74) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (24,75)-(24,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("ParseOptions");
            #line hidden
            #line (24,87)-(24,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (24,88)-(24,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("options)");
            #line hidden
            #line (24,96)-(24,97) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (25,13)-(25,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (25,14)-(25,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,15)-(25,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("base(text,");
            #line hidden
            #line (25,25)-(25,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,26)-(25,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("options)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,9)-(26,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,9)-(27,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,9)-(29,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("protected");
            #line hidden
            #line (29,18)-(29,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,19)-(29,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (29,22)-(29,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,24)-(29,37) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (29,38)-(29,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Lexer");
            #line hidden
            #line (29,43)-(29,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,44)-(29,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (29,54)-(29,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,55)-(29,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (29,57)-(29,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,58)-(29,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (29,60)-(29,73) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (29,74)-(29,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Lexer)base.AntlrLexer;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (31,5)-(31,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (32,1)-(32,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (35,9)-(35,49) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
        public string GenerateSyntaxParser(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (36,1)-(36,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (36,6)-(36,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (36,7)-(36,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (37,1)-(37,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (37,6)-(37,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (37,7)-(37,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("System.Diagnostics;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (38,1)-(38,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (38,6)-(38,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (38,7)-(38,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,1)-(39,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (39,6)-(39,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (39,7)-(39,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("System.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (40,1)-(40,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (40,6)-(40,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (40,7)-(40,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (41,1)-(41,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (41,6)-(41,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (41,7)-(41,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("System.Threading.Tasks;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (42,1)-(42,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (42,6)-(42,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (42,7)-(42,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (43,1)-(43,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (43,6)-(43,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (43,7)-(43,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Antlr4.Runtime.Tree;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,1)-(44,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (44,6)-(44,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (44,7)-(44,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,1)-(45,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (45,6)-(45,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (45,7)-(45,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (46,1)-(46,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (46,6)-(46,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (46,7)-(46,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (47,1)-(47,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (47,6)-(47,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (47,7)-(47,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (48,1)-(48,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (48,6)-(48,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (48,7)-(48,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (49,1)-(49,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (49,6)-(49,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,8)-(49,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            #line (49,36)-(49,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(".Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (51,1)-(51,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (51,10)-(51,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (51,11)-(51,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (53,1)-(53,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (53,10)-(53,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (53,12)-(53,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            #line (53,40)-(53,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(".Syntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (54,1)-(54,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (55,5)-(55,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (55,11)-(55,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,12)-(55,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("partial");
            #line hidden
            #line (55,19)-(55,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,20)-(55,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (55,25)-(55,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,27)-(55,40) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (55,41)-(55,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (55,53)-(55,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,54)-(55,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (55,55)-(55,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,56)-(55,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrSyntaxParser");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (56,5)-(56,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (57,9)-(57,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (57,16)-(57,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (57,17)-(57,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("readonly");
            #line hidden
            #line (57,25)-(57,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (57,26)-(57,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrToRoslynVisitor");
            #line hidden
            #line (57,46)-(57,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (57,47)-(57,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_visitor;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (59,9)-(59,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (59,15)-(59,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (59,17)-(59,30) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (59,31)-(59,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxParser(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (60,14)-(60,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (60,28)-(60,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxLexer");
            #line hidden
            #line (60,39)-(60,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (60,40)-(60,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("lexer,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (61,4)-(61,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("IncrementalParseData?");
            #line hidden
            #line (61,25)-(61,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (61,26)-(61,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("oldParseData,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (62,13)-(62,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("IEnumerable<TextChangeRange>");
            #line hidden
            #line (62,41)-(62,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (62,42)-(62,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("changes,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (63,13)-(63,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("CancellationToken");
            #line hidden
            #line (63,30)-(63,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,31)-(63,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("cancellationToken");
            #line hidden
            #line (63,48)-(63,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,49)-(63,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (63,50)-(63,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,51)-(63,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("default)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (64,13)-(64,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (64,14)-(64,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,15)-(64,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("base(lexer,");
            #line hidden
            #line (64,26)-(64,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,27)-(64,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("oldParseData,");
            #line hidden
            #line (64,40)-(64,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,41)-(64,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("changes,");
            #line hidden
            #line (64,49)-(64,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,50)-(64,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (65,9)-(65,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (66,13)-(66,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_visitor");
            #line hidden
            #line (66,21)-(66,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,22)-(66,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (66,23)-(66,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,24)-(66,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (66,27)-(66,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,28)-(66,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrToRoslynVisitor(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (67,9)-(67,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (69,9)-(69,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("protected");
            #line hidden
            #line (69,18)-(69,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,19)-(69,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (69,22)-(69,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,24)-(69,37) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (69,38)-(69,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Parser");
            #line hidden
            #line (69,44)-(69,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,45)-(69,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrParser");
            #line hidden
            #line (69,56)-(69,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,57)-(69,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (69,59)-(69,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,60)-(69,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (69,62)-(69,75) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (69,76)-(69,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Parser)base.AntlrParser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (71,3)-(71,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("protected");
            #line hidden
            #line (71,12)-(71,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,13)-(71,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("override");
            #line hidden
            #line (71,21)-(71,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,22)-(71,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxNode");
            #line hidden
            #line (71,32)-(71,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,33)-(71,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("ParseRoot()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (72,3)-(72,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (73,13)-(73,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("ParserState?");
            #line hidden
            #line (73,25)-(73,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,26)-(73,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("state");
            #line hidden
            #line (73,31)-(73,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,32)-(73,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (73,33)-(73,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,34)-(73,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (74,4)-(74,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("GreenNode?");
            #line hidden
            #line (74,14)-(74,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (74,15)-(74,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("green");
            #line hidden
            #line (74,20)-(74,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (74,21)-(74,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (74,22)-(74,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (74,23)-(74,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("this.Parse");
            #line hidden
            #line (74,34)-(74,71) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Grammar.MainRule?.CSharpName);
            #line hidden
            #line (74,72)-(74,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(ref");
            #line hidden
            #line (74,76)-(74,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (74,77)-(74,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("state);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (75,4)-(75,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("var");
            #line hidden
            #line (75,7)-(75,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (75,8)-(75,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("red");
            #line hidden
            #line (75,11)-(75,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (75,12)-(75,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (75,13)-(75,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (75,14)-(75,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (75,16)-(75,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (75,30)-(75,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxNode)green!.CreateRed();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (76,4)-(76,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (76,10)-(76,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (76,11)-(76,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("red;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (77,3)-(77,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (79,9)-(79,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (79,16)-(79,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (79,17)-(79,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("GreenNode?");
            #line hidden
            #line (79,27)-(79,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (79,28)-(79,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Parse");
            #line hidden
            #line (79,34)-(79,71) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Grammar.MainRule?.CSharpName);
            #line hidden
            #line (79,72)-(79,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(ref");
            #line hidden
            #line (79,76)-(79,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (79,77)-(79,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("ParserState?");
            #line hidden
            #line (79,89)-(79,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (79,90)-(79,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("state)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,9)-(80,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (81,13)-(81,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (81,19)-(81,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,20)-(81,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_visitor.Visit");
            #line hidden
            #line (81,35)-(81,87) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Grammar.MainRule?.AntlrName?.ToPascalCase());
            #line hidden
            #line (81,88)-(81,101) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(AntlrParser.");
            #line hidden
            #line (81,102)-(81,138) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Grammar.MainRule?.AntlrName);
            #line hidden
            #line (81,139)-(81,143) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,9)-(82,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (84,9)-(84,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (84,16)-(84,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (84,17)-(84,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (84,22)-(84,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (84,23)-(84,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrToRoslynVisitor");
            #line hidden
            #line (84,43)-(84,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (84,44)-(84,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (84,45)-(84,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (84,47)-(84,60) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (84,61)-(84,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("ParserBaseVisitor<GreenNode?>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (86,4)-(86,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("//");
            #line hidden
            #line (86,6)-(86,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,7)-(86,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("list");
            #line hidden
            #line (86,11)-(86,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,12)-(86,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("pools");
            #line hidden
            #line (86,17)-(86,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,18)-(86,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("-");
            #line hidden
            #line (86,19)-(86,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,20)-(86,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("allocators");
            #line hidden
            #line (86,30)-(86,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,31)-(86,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("for");
            #line hidden
            #line (86,34)-(86,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,35)-(86,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("lists");
            #line hidden
            #line (86,40)-(86,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,41)-(86,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("that");
            #line hidden
            #line (86,45)-(86,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,46)-(86,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("are");
            #line hidden
            #line (86,49)-(86,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,50)-(86,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("used");
            #line hidden
            #line (86,54)-(86,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,55)-(86,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("to");
            #line hidden
            #line (86,57)-(86,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,58)-(86,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("build");
            #line hidden
            #line (86,63)-(86,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,64)-(86,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("sequences");
            #line hidden
            #line (86,73)-(86,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,74)-(86,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("of");
            #line hidden
            #line (86,76)-(86,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,77)-(86,83) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("nodes.");
            #line hidden
            #line (86,83)-(86,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,84)-(86,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("The");
            #line hidden
            #line (86,87)-(86,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,88)-(86,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("lists");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (87,4)-(87,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("//");
            #line hidden
            #line (87,6)-(87,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,7)-(87,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("can");
            #line hidden
            #line (87,10)-(87,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,11)-(87,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("be");
            #line hidden
            #line (87,13)-(87,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,14)-(87,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("reused");
            #line hidden
            #line (87,20)-(87,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,21)-(87,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(hence");
            #line hidden
            #line (87,27)-(87,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,28)-(87,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("pooled)");
            #line hidden
            #line (87,35)-(87,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,36)-(87,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("since");
            #line hidden
            #line (87,41)-(87,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,42)-(87,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (87,45)-(87,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,46)-(87,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("syntax");
            #line hidden
            #line (87,52)-(87,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,53)-(87,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("factory");
            #line hidden
            #line (87,60)-(87,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,61)-(87,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("methods");
            #line hidden
            #line (87,68)-(87,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,69)-(87,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("don't");
            #line hidden
            #line (87,74)-(87,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,75)-(87,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("keep");
            #line hidden
            #line (87,79)-(87,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,80)-(87,90) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("references");
            #line hidden
            #line (87,90)-(87,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,91)-(87,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("to");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (88,4)-(88,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("//");
            #line hidden
            #line (88,6)-(88,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (88,7)-(88,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("them");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (89,4)-(89,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (89,11)-(89,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,12)-(89,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("readonly");
            #line hidden
            #line (89,20)-(89,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,21)-(89,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxListPool");
            #line hidden
            #line (89,35)-(89,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,36)-(89,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_pool");
            #line hidden
            #line (89,41)-(89,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,42)-(89,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (89,43)-(89,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,44)-(89,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (89,47)-(89,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,48)-(89,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxListPool();");
            #line hidden
            #line (89,65)-(89,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,66)-(89,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("//");
            #line hidden
            #line (89,68)-(89,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,69)-(89,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Don't");
            #line hidden
            #line (89,74)-(89,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,75)-(89,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("need");
            #line hidden
            #line (89,79)-(89,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,80)-(89,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("to");
            #line hidden
            #line (89,82)-(89,83) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,83)-(89,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("reset");
            #line hidden
            #line (89,88)-(89,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (89,89)-(89,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("this.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (91,13)-(91,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (91,20)-(91,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (91,21)-(91,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("readonly");
            #line hidden
            #line (91,29)-(91,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (91,31)-(91,44) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (91,45)-(91,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (91,57)-(91,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (91,58)-(91,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (92,13)-(92,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (92,20)-(92,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (92,21)-(92,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("readonly");
            #line hidden
            #line (92,29)-(92,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (92,30)-(92,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrTokenStream");
            #line hidden
            #line (92,46)-(92,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (92,47)-(92,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_tokenStream;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (93,4)-(93,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (93,11)-(93,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,12)-(93,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("readonly");
            #line hidden
            #line (93,20)-(93,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,22)-(93,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (93,36)-(93,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (93,57)-(93,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,58)-(93,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_factory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (95,13)-(95,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (95,19)-(95,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (95,20)-(95,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrToRoslynVisitor(");
            #line hidden
            #line (95,42)-(95,55) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (95,56)-(95,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (95,68)-(95,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (95,69)-(95,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("parser)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (96,13)-(96,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (97,17)-(97,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_parser");
            #line hidden
            #line (97,24)-(97,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (97,25)-(97,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (97,26)-(97,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (97,27)-(97,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (98,17)-(98,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_tokenStream");
            #line hidden
            #line (98,29)-(98,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (98,30)-(98,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (98,31)-(98,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (98,32)-(98,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(AntlrTokenStream)_parser.AntlrParser.InputStream;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (99,5)-(99,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_factory");
            #line hidden
            #line (99,13)-(99,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (99,14)-(99,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (99,15)-(99,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (99,16)-(99,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (99,18)-(99,31) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (99,32)-(99,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("InternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (100,13)-(100,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (102,13)-(102,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (102,20)-(102,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (102,21)-(102,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("GreenNode?");
            #line hidden
            #line (102,31)-(102,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (102,32)-(102,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("VisitTerminal(IToken?");
            #line hidden
            #line (102,53)-(102,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (102,54)-(102,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("token,");
            #line hidden
            #line (102,60)-(102,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (102,62)-(102,75) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (102,76)-(102,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (102,86)-(102,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (102,87)-(102,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (103,13)-(103,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (104,5)-(104,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (104,7)-(104,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (104,8)-(104,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(token");
            #line hidden
            #line (104,14)-(104,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (104,15)-(104,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (104,17)-(104,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (104,18)-(104,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (105,5)-(105,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (106,6)-(106,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (106,8)-(106,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,9)-(106,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(kind");
            #line hidden
            #line (106,14)-(106,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,15)-(106,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("!=");
            #line hidden
            #line (106,17)-(106,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,19)-(106,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (106,33)-(106,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind.None)");
            #line hidden
            #line (106,49)-(106,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,50)-(106,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (106,56)-(106,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,57)-(106,116) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_tokenStream.ConsumeGreenToken(_factory.MissingToken(kind),");
            #line hidden
            #line (106,116)-(106,117) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,117)-(106,126) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (107,6)-(107,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("else");
            #line hidden
            #line (107,10)-(107,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,11)-(107,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (107,17)-(107,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,18)-(107,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (108,5)-(108,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (109,17)-(109,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("var");
            #line hidden
            #line (109,20)-(109,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,21)-(109,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("green");
            #line hidden
            #line (109,26)-(109,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,27)-(109,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (109,28)-(109,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,29)-(109,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_tokenStream.ConsumeGreenToken(token,");
            #line hidden
            #line (109,66)-(109,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,67)-(109,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (110,5)-(110,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Debug.Assert(kind");
            #line hidden
            #line (110,22)-(110,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (110,23)-(110,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (110,25)-(110,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (110,27)-(110,40) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (110,41)-(110,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind.None");
            #line hidden
            #line (110,56)-(110,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (110,57)-(110,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("||");
            #line hidden
            #line (110,59)-(110,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (110,60)-(110,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("green.RawKind");
            #line hidden
            #line (110,73)-(110,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (110,74)-(110,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (110,76)-(110,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (110,77)-(110,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(int)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (111,5)-(111,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (111,11)-(111,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (111,12)-(111,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("green;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (112,13)-(112,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (114,13)-(114,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (114,19)-(114,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,20)-(114,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("GreenNode?");
            #line hidden
            #line (114,30)-(114,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,31)-(114,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("VisitTerminal(IToken?");
            #line hidden
            #line (114,52)-(114,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,53)-(114,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("token)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (115,13)-(115,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (116,5)-(116,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (116,11)-(116,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (116,12)-(116,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("VisitTerminal(token,");
            #line hidden
            #line (116,32)-(116,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (116,34)-(116,47) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (116,48)-(116,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind.None);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (117,13)-(117,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (119,13)-(119,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("private");
            #line hidden
            #line (119,20)-(119,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (119,21)-(119,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("GreenNode?");
            #line hidden
            #line (119,31)-(119,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (119,32)-(119,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("VisitTerminal(ITerminalNode?");
            #line hidden
            #line (119,60)-(119,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (119,61)-(119,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("node,");
            #line hidden
            #line (119,66)-(119,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (119,68)-(119,81) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (119,82)-(119,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (119,92)-(119,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (119,93)-(119,98) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (120,13)-(120,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (121,17)-(121,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (121,19)-(121,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (121,20)-(121,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(node?.Symbol");
            #line hidden
            #line (121,33)-(121,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (121,34)-(121,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (121,36)-(121,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (121,37)-(121,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (122,5)-(122,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (123,6)-(123,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (123,8)-(123,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (123,9)-(123,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(kind");
            #line hidden
            #line (123,14)-(123,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (123,15)-(123,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("!=");
            #line hidden
            #line (123,17)-(123,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (123,19)-(123,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (123,33)-(123,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind.None)");
            #line hidden
            #line (123,49)-(123,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (123,50)-(123,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (123,56)-(123,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (123,57)-(123,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_factory.MissingToken(kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (124,6)-(124,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("else");
            #line hidden
            #line (124,10)-(124,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (124,11)-(124,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (124,17)-(124,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (124,18)-(124,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (125,5)-(125,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (126,17)-(126,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("var");
            #line hidden
            #line (126,20)-(126,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,21)-(126,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("green");
            #line hidden
            #line (126,26)-(126,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,27)-(126,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (126,28)-(126,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,29)-(126,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_tokenStream.ConsumeGreenToken(node.Symbol,");
            #line hidden
            #line (126,72)-(126,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,73)-(126,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (127,5)-(127,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Debug.Assert(kind");
            #line hidden
            #line (127,22)-(127,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,23)-(127,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (127,25)-(127,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,27)-(127,40) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (127,41)-(127,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind.None");
            #line hidden
            #line (127,56)-(127,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,57)-(127,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("||");
            #line hidden
            #line (127,59)-(127,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,60)-(127,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("green.RawKind");
            #line hidden
            #line (127,73)-(127,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,74)-(127,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (127,76)-(127,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,77)-(127,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("(int)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (128,5)-(128,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (128,11)-(128,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (128,12)-(128,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("green;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (129,4)-(129,5) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (131,13)-(131,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (131,19)-(131,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (131,20)-(131,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("override");
            #line hidden
            #line (131,28)-(131,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (131,29)-(131,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("GreenNode?");
            #line hidden
            #line (131,39)-(131,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (131,40)-(131,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("VisitTerminal(ITerminalNode?");
            #line hidden
            #line (131,68)-(131,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (131,69)-(131,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (132,13)-(132,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (133,17)-(133,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (133,23)-(133,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (133,24)-(133,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("VisitTerminal(node,");
            #line hidden
            #line (133,43)-(133,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (133,45)-(133,58) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (133,59)-(133,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("SyntaxKind.None);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (134,13)-(134,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first213 = true;
            #line (136,14)-(136,64) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            foreach (var rule in language.Grammar.ParserRules)
            #line hidden
            
            {
                if (__first213)
                {
                    __first213 = false;
                }
                var __first214 = true;
                #line (137,18)-(137,56) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first214)
                    {
                        __first214 = false;
                    }
                    __cb.Push("            ");
                    #line (138,13)-(138,19) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("public");
                    #line hidden
                    #line (138,19)-(138,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (138,20)-(138,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("override");
                    #line hidden
                    #line (138,28)-(138,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (138,29)-(138,39) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("GreenNode?");
                    #line hidden
                    #line (138,39)-(138,40) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (138,40)-(138,45) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("Visit");
                    #line hidden
                    #line (138,46)-(138,74) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(alt.AntlrName.ToPascalCase());
                    #line hidden
                    #line (138,75)-(138,76) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("(");
                    #line hidden
                    #line (138,77)-(138,90) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(language.Name);
                    #line hidden
                    #line (138,91)-(138,98) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("Parser.");
                    #line hidden
                    #line (138,99)-(138,127) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(alt.AntlrName.ToPascalCase());
                    #line hidden
                    #line (138,128)-(138,136) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("Context?");
                    #line hidden
                    #line (138,136)-(138,137) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (138,137)-(138,145) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("context)");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (139,13)-(139,14) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("{");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("               \t");
                    #line (140,17)-(140,19) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("if");
                    #line hidden
                    #line (140,19)-(140,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,20)-(140,28) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("(context");
                    #line hidden
                    #line (140,28)-(140,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,29)-(140,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("==");
                    #line hidden
                    #line (140,31)-(140,32) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,32)-(140,37) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("null)");
                    #line hidden
                    #line (140,37)-(140,38) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,38)-(140,44) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("return");
                    #line hidden
                    #line (140,44)-(140,45) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,46)-(140,59) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(alt.GreenName);
                    #line hidden
                    #line (140,60)-(140,71) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(".__Missing;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    var __first215 = true;
                    #line (141,18)-(141,52) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    foreach (var elem in alt.Elements)
                    #line hidden
                    
                    {
                        if (__first215)
                        {
                            __first215 = false;
                        }
                        var __first216 = true;
                        #line (142,22)-(142,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                        if (elem.IsList)
                        #line hidden
                        
                        {
                            if (__first216)
                            {
                                __first216 = false;
                            }
                            var __first217 = true;
                            #line (143,26)-(143,89) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            if (elem.IsSeparated && elem is ParserRuleListElement listElem)
                            #line hidden
                            
                            {
                                if (__first217)
                                {
                                    __first217 = false;
                                }
                                __cb.Push("                ");
                                #line (144,17)-(144,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (144,20)-(144,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (144,22)-(144,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (144,41)-(144,48) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Builder");
                                #line hidden
                                #line (144,48)-(144,49) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (144,49)-(144,50) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (144,50)-(144,51) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (144,51)-(144,75) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("_pool.AllocateSeparated<");
                                #line hidden
                                #line (144,76)-(144,94) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.GreenItemType);
                                #line hidden
                                #line (144,95)-(144,106) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(">(reversed:");
                                #line hidden
                                #line (144,106)-(144,107) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (144,108)-(144,146) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(listElem.IsReversed ? "true" : "false");
                                #line hidden
                                #line (144,147)-(144,149) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(");");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                var __first218 = true;
                                #line (145,30)-(145,134) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (listElem.ListKind == ListKind.WithFirstItem || listElem.ListKind == ListKind.WithFirstItemSeparator)
                                #line hidden
                                
                                {
                                    if (__first218)
                                    {
                                        __first218 = false;
                                    }
                                    __cb.Push("                ");
                                    #line (146,17)-(146,20) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("var");
                                    #line hidden
                                    #line (146,20)-(146,21) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (146,22)-(146,54) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.FirstItem.ParameterName);
                                    #line hidden
                                    #line (146,55)-(146,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (146,62)-(146,63) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (146,63)-(146,64) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("=");
                                    #line hidden
                                    #line (146,64)-(146,65) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (146,65)-(146,73) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("context.");
                                    #line hidden
                                    #line (146,74)-(146,102) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.FirstItem.AntlrName);
                                    #line hidden
                                    #line (146,103)-(146,104) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(";");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    __cb.Push("                ");
                                    #line (147,17)-(147,19) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("if");
                                    #line hidden
                                    #line (147,19)-(147,20) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (147,20)-(147,21) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("(");
                                    #line hidden
                                    #line (147,22)-(147,54) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.FirstItem.ParameterName);
                                    #line hidden
                                    #line (147,55)-(147,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (147,62)-(147,63) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (147,63)-(147,65) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("is");
                                    #line hidden
                                    #line (147,65)-(147,66) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (147,66)-(147,69) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("not");
                                    #line hidden
                                    #line (147,69)-(147,70) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (147,70)-(147,75) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("null)");
                                    #line hidden
                                    #line (147,75)-(147,76) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (147,77)-(147,95) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (147,96)-(147,109) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add((");
                                    #line hidden
                                    #line (147,110)-(147,142) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.FirstItem.GreenItemType);
                                    #line hidden
                                    #line (147,143)-(147,156) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("?)this.Visit(");
                                    #line hidden
                                    #line (147,157)-(147,189) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.FirstItem.ParameterName);
                                    #line hidden
                                    #line (147,190)-(147,198) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context)");
                                    #line hidden
                                    #line (147,198)-(147,199) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (147,199)-(147,201) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("??");
                                    #line hidden
                                    #line (147,201)-(147,202) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (147,203)-(147,235) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.FirstItem.GreenItemType);
                                    #line hidden
                                    #line (147,236)-(147,248) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    var __first219 = true;
                                    #line (148,34)-(148,69) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    if (!listElem.FirstItem.IsOptional)
                                    #line hidden
                                    
                                    {
                                        if (__first219)
                                        {
                                            __first219 = false;
                                        }
                                        __cb.Push("                ");
                                        #line (149,17)-(149,21) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("else");
                                        #line hidden
                                        #line (149,21)-(149,22) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(" ");
                                        #line hidden
                                        #line (149,23)-(149,41) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(elem.ParameterName);
                                        #line hidden
                                        #line (149,42)-(149,54) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("Builder.Add(");
                                        #line hidden
                                        #line (149,55)-(149,87) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(listElem.FirstItem.GreenItemType);
                                        #line hidden
                                        #line (149,88)-(149,100) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(".__Missing);");
                                        #line hidden
                                        __cb.WriteLine();
                                        __cb.Pop();
                                    }
                                    if (!__first219) __cb.AppendLine();
                                }
                                if (!__first218) __cb.AppendLine();
                                __cb.Push("                ");
                                #line (152,17)-(152,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (152,20)-(152,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (152,22)-(152,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (152,41)-(152,48) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Context");
                                #line hidden
                                #line (152,48)-(152,49) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (152,49)-(152,50) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (152,50)-(152,51) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (152,51)-(152,60) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("context._");
                                #line hidden
                                #line (152,61)-(152,92) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(listElem.RepeatedRule.AntlrName);
                                #line hidden
                                #line (152,93)-(152,94) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(";");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (153,17)-(153,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("for");
                                #line hidden
                                #line (153,20)-(153,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,21)-(153,25) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("(int");
                                #line hidden
                                #line (153,25)-(153,26) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,26)-(153,27) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("i");
                                #line hidden
                                #line (153,27)-(153,28) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,28)-(153,29) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (153,29)-(153,30) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,30)-(153,32) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("0;");
                                #line hidden
                                #line (153,32)-(153,33) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,33)-(153,34) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("i");
                                #line hidden
                                #line (153,34)-(153,35) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,35)-(153,36) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("<");
                                #line hidden
                                #line (153,36)-(153,37) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,38)-(153,56) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (153,57)-(153,71) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Context.Count;");
                                #line hidden
                                #line (153,71)-(153,72) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (153,72)-(153,76) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("++i)");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (154,17)-(154,18) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("{");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (155,21)-(155,24) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (155,24)-(155,25) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (155,25)-(155,36) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("itemContext");
                                #line hidden
                                #line (155,36)-(155,37) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (155,37)-(155,38) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (155,38)-(155,39) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (155,40)-(155,58) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (155,59)-(155,66) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Context");
                                #line hidden
                                #line (155,67)-(155,72) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("[i]");
                                #line hidden
                                #line (155,73)-(155,74) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(";");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (156,21)-(156,23) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("if");
                                #line hidden
                                #line (156,23)-(156,24) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (156,24)-(156,36) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("(itemContext");
                                #line hidden
                                #line (156,36)-(156,37) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (156,37)-(156,39) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("is");
                                #line hidden
                                #line (156,39)-(156,40) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (156,40)-(156,43) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("not");
                                #line hidden
                                #line (156,43)-(156,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (156,44)-(156,49) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("null)");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (157,21)-(157,22) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("{");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (158,25)-(158,28) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (158,28)-(158,29) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (158,29)-(158,33) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("item");
                                #line hidden
                                #line (158,33)-(158,34) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (158,34)-(158,35) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (158,35)-(158,36) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (158,36)-(158,48) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("itemContext.");
                                #line hidden
                                #line (158,49)-(158,80) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(listElem.RepeatedItem.AntlrName);
                                #line hidden
                                #line (158,81)-(158,82) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(";");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (159,25)-(159,28) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (159,28)-(159,29) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (159,29)-(159,38) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("separator");
                                #line hidden
                                #line (159,38)-(159,39) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (159,39)-(159,40) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (159,40)-(159,41) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (159,41)-(159,53) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("itemContext.");
                                #line hidden
                                #line (159,54)-(159,90) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(listElem.RepeatedSeparator.AntlrName);
                                #line hidden
                                #line (159,91)-(159,92) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(";");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                var __first220 = true;
                                #line (160,30)-(160,181) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (listElem.ListKind == ListKind.SeparatorItem || listElem.ListKind == ListKind.WithFirstItem || listElem.ListKind == ListKind.WithFirstItemSeparator)
                                #line hidden
                                
                                {
                                    if (__first220)
                                    {
                                        __first220 = false;
                                    }
                                    __cb.Push("                        ");
                                    #line (161,26)-(161,44) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (161,45)-(161,95) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.AddSeparator(this.VisitTerminal(separator,");
                                    #line hidden
                                    #line (161,95)-(161,96) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (161,97)-(161,110) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(language.Name);
                                    #line hidden
                                    #line (161,111)-(161,122) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("SyntaxKind.");
                                    #line hidden
                                    #line (161,123)-(161,160) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.RepeatedSeparator.CSharpName);
                                    #line hidden
                                    #line (161,161)-(161,164) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("));");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    __cb.Push("                        ");
                                    #line (162,25)-(162,27) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("if");
                                    #line hidden
                                    #line (162,27)-(162,28) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (162,28)-(162,33) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("(item");
                                    #line hidden
                                    #line (162,33)-(162,34) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (162,34)-(162,36) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("is");
                                    #line hidden
                                    #line (162,36)-(162,37) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (162,37)-(162,40) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("not");
                                    #line hidden
                                    #line (162,40)-(162,41) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (162,41)-(162,46) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("null)");
                                    #line hidden
                                    #line (162,46)-(162,47) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (162,48)-(162,66) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (162,67)-(162,80) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add((");
                                    #line hidden
                                    #line (162,81)-(162,99) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (162,100)-(162,118) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("?)this.Visit(item)");
                                    #line hidden
                                    #line (162,118)-(162,119) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (162,119)-(162,121) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("??");
                                    #line hidden
                                    #line (162,121)-(162,122) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (162,123)-(162,141) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (162,142)-(162,154) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    __cb.Push("                        ");
                                    #line (163,25)-(163,29) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("else");
                                    #line hidden
                                    #line (163,29)-(163,30) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (163,31)-(163,49) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (163,50)-(163,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add(");
                                    #line hidden
                                    #line (163,63)-(163,81) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (163,82)-(163,94) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                }
                                #line (164,30)-(164,34) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                else
                                #line hidden
                                
                                {
                                    if (__first220)
                                    {
                                        __first220 = false;
                                    }
                                    __cb.Push("                        ");
                                    #line (165,25)-(165,27) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("if");
                                    #line hidden
                                    #line (165,27)-(165,28) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (165,28)-(165,33) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("(item");
                                    #line hidden
                                    #line (165,33)-(165,34) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (165,34)-(165,36) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("is");
                                    #line hidden
                                    #line (165,36)-(165,37) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (165,37)-(165,40) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("not");
                                    #line hidden
                                    #line (165,40)-(165,41) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (165,41)-(165,46) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("null)");
                                    #line hidden
                                    #line (165,46)-(165,47) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (165,48)-(165,66) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (165,67)-(165,80) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add((");
                                    #line hidden
                                    #line (165,81)-(165,99) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (165,100)-(165,118) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("?)this.Visit(item)");
                                    #line hidden
                                    #line (165,118)-(165,119) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (165,119)-(165,121) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("??");
                                    #line hidden
                                    #line (165,121)-(165,122) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (165,123)-(165,141) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (165,142)-(165,154) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    __cb.Push("                        ");
                                    #line (166,25)-(166,29) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("else");
                                    #line hidden
                                    #line (166,29)-(166,30) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (166,31)-(166,49) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (166,50)-(166,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add(");
                                    #line hidden
                                    #line (166,63)-(166,81) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (166,82)-(166,94) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    __cb.Push("                        ");
                                    #line (167,26)-(167,44) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (167,45)-(167,95) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.AddSeparator(this.VisitTerminal(separator,");
                                    #line hidden
                                    #line (167,95)-(167,96) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (167,97)-(167,110) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(language.Name);
                                    #line hidden
                                    #line (167,111)-(167,122) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("SyntaxKind.");
                                    #line hidden
                                    #line (167,123)-(167,160) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.RepeatedSeparator.CSharpName);
                                    #line hidden
                                    #line (167,161)-(167,164) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("));");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                }
                                if (!__first220) __cb.AppendLine();
                                __cb.Push("                    ");
                                #line (169,21)-(169,22) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("}");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (170,17)-(170,18) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("}");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                var __first221 = true;
                                #line (171,30)-(171,132) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (listElem.ListKind == ListKind.WithLastItem || listElem.ListKind == ListKind.WithLastItemSeparator)
                                #line hidden
                                
                                {
                                    if (__first221)
                                    {
                                        __first221 = false;
                                    }
                                    __cb.Push("                ");
                                    #line (172,17)-(172,20) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("var");
                                    #line hidden
                                    #line (172,20)-(172,21) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (172,22)-(172,53) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastItem.ParameterName);
                                    #line hidden
                                    #line (172,54)-(172,61) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (172,61)-(172,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (172,62)-(172,63) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("=");
                                    #line hidden
                                    #line (172,63)-(172,64) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (172,64)-(172,72) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("context.");
                                    #line hidden
                                    #line (172,73)-(172,100) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastItem.AntlrName);
                                    #line hidden
                                    #line (172,101)-(172,102) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(";");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    __cb.Push("                ");
                                    #line (173,17)-(173,19) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("if");
                                    #line hidden
                                    #line (173,19)-(173,20) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (173,20)-(173,21) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("(");
                                    #line hidden
                                    #line (173,22)-(173,53) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastItem.ParameterName);
                                    #line hidden
                                    #line (173,54)-(173,61) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (173,61)-(173,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (173,62)-(173,64) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("is");
                                    #line hidden
                                    #line (173,64)-(173,65) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (173,65)-(173,68) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("not");
                                    #line hidden
                                    #line (173,68)-(173,69) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (173,69)-(173,74) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("null)");
                                    #line hidden
                                    #line (173,74)-(173,75) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (173,76)-(173,94) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (173,95)-(173,108) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add((");
                                    #line hidden
                                    #line (173,109)-(173,140) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastItem.GreenItemType);
                                    #line hidden
                                    #line (173,141)-(173,154) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("?)this.Visit(");
                                    #line hidden
                                    #line (173,155)-(173,186) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastItem.ParameterName);
                                    #line hidden
                                    #line (173,187)-(173,195) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context)");
                                    #line hidden
                                    #line (173,195)-(173,196) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (173,196)-(173,198) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("??");
                                    #line hidden
                                    #line (173,198)-(173,199) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (173,200)-(173,231) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastItem.GreenItemType);
                                    #line hidden
                                    #line (173,232)-(173,244) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    var __first222 = true;
                                    #line (174,34)-(174,68) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    if (!listElem.LastItem.IsOptional)
                                    #line hidden
                                    
                                    {
                                        if (__first222)
                                        {
                                            __first222 = false;
                                        }
                                        __cb.Push("                ");
                                        #line (175,17)-(175,21) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("else");
                                        #line hidden
                                        #line (175,21)-(175,23) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("  ");
                                        #line hidden
                                        #line (175,24)-(175,42) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(elem.ParameterName);
                                        #line hidden
                                        #line (175,43)-(175,55) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("Builder.Add(");
                                        #line hidden
                                        #line (175,56)-(175,87) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(listElem.LastItem.GreenItemType);
                                        #line hidden
                                        #line (175,88)-(175,100) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(".__Missing);");
                                        #line hidden
                                        __cb.WriteLine();
                                        __cb.Pop();
                                    }
                                    if (!__first222) __cb.AppendLine();
                                }
                                if (!__first221) __cb.AppendLine();
                                var __first223 = true;
                                #line (178,30)-(178,142) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (listElem.ListKind == ListKind.WithFirstItemSeparator || listElem.ListKind == ListKind.WithLastItemSeparator)
                                #line hidden
                                
                                {
                                    if (__first223)
                                    {
                                        __first223 = false;
                                    }
                                    __cb.Push("                ");
                                    #line (179,17)-(179,20) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("var");
                                    #line hidden
                                    #line (179,20)-(179,21) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (179,22)-(179,58) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastSeparator.ParameterName);
                                    #line hidden
                                    #line (179,59)-(179,66) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (179,66)-(179,67) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (179,67)-(179,68) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("=");
                                    #line hidden
                                    #line (179,68)-(179,69) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (179,69)-(179,77) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("context.");
                                    #line hidden
                                    #line (179,78)-(179,110) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(listElem.LastSeparator.AntlrName);
                                    #line hidden
                                    #line (179,111)-(179,112) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(";");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    var __first224 = true;
                                    #line (180,34)-(180,72) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    if (listElem.LastSeparator.IsOptional)
                                    #line hidden
                                    
                                    {
                                        if (__first224)
                                        {
                                            __first224 = false;
                                        }
                                        __cb.Push("                ");
                                        #line (181,17)-(181,19) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("if");
                                        #line hidden
                                        #line (181,19)-(181,20) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(" ");
                                        #line hidden
                                        #line (181,20)-(181,21) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("(");
                                        #line hidden
                                        #line (181,22)-(181,58) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(listElem.LastSeparator.ParameterName);
                                        #line hidden
                                        #line (181,59)-(181,66) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("Context");
                                        #line hidden
                                        #line (181,66)-(181,67) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(" ");
                                        #line hidden
                                        #line (181,67)-(181,69) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("is");
                                        #line hidden
                                        #line (181,69)-(181,70) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(" ");
                                        #line hidden
                                        #line (181,70)-(181,73) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("not");
                                        #line hidden
                                        #line (181,73)-(181,74) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(" ");
                                        #line hidden
                                        #line (181,74)-(181,79) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("null)");
                                        #line hidden
                                        #line (181,79)-(181,80) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(" ");
                                        #line hidden
                                        #line (181,81)-(181,99) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(elem.ParameterName);
                                        #line hidden
                                        #line (181,100)-(181,140) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("Builder.AddSeparator(this.VisitTerminal(");
                                        #line hidden
                                        #line (181,141)-(181,177) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(listElem.LastSeparator.ParameterName);
                                        #line hidden
                                        #line (181,178)-(181,188) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("Context));");
                                        #line hidden
                                        __cb.WriteLine();
                                        __cb.Pop();
                                    }
                                    #line (182,34)-(182,38) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    else
                                    #line hidden
                                    
                                    {
                                        if (__first224)
                                        {
                                            __first224 = false;
                                        }
                                        __cb.Push("                ");
                                        #line (183,18)-(183,36) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(elem.ParameterName);
                                        #line hidden
                                        #line (183,37)-(183,77) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("Builder.AddSeparator(this.VisitTerminal(");
                                        #line hidden
                                        #line (183,78)-(183,114) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(listElem.LastSeparator.ParameterName);
                                        #line hidden
                                        #line (183,115)-(183,123) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("Context,");
                                        #line hidden
                                        #line (183,123)-(183,124) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(" ");
                                        #line hidden
                                        #line (183,125)-(183,138) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(language.Name);
                                        #line hidden
                                        #line (183,139)-(183,150) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("SyntaxKind.");
                                        #line hidden
                                        #line (183,151)-(183,184) 52 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write(listElem.LastSeparator.CSharpName);
                                        #line hidden
                                        #line (183,185)-(183,188) 53 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                        __cb.Write("));");
                                        #line hidden
                                        __cb.WriteLine();
                                        __cb.Pop();
                                    }
                                    if (!__first224) __cb.AppendLine();
                                }
                                if (!__first223) __cb.AppendLine();
                                __cb.Push("                ");
                                #line (186,17)-(186,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (186,20)-(186,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (186,22)-(186,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (186,41)-(186,42) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (186,42)-(186,43) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (186,43)-(186,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (186,45)-(186,63) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (186,64)-(186,81) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Builder.ToList();");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (187,17)-(187,28) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("_pool.Free(");
                                #line hidden
                                #line (187,29)-(187,47) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (187,48)-(187,57) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Builder);");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            #line (188,26)-(188,30) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            else
                            #line hidden
                            
                            {
                                if (__first217)
                                {
                                    __first217 = false;
                                }
                                __cb.Push("                ");
                                #line (189,17)-(189,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (189,20)-(189,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (189,22)-(189,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (189,41)-(189,48) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Context");
                                #line hidden
                                #line (189,48)-(189,49) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (189,49)-(189,50) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (189,50)-(189,51) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (189,51)-(189,60) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("context._");
                                #line hidden
                                #line (189,61)-(189,75) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                #line (189,76)-(189,77) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(";");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (190,17)-(190,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (190,20)-(190,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (190,22)-(190,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (190,41)-(190,48) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Builder");
                                #line hidden
                                #line (190,48)-(190,49) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (190,49)-(190,50) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (190,50)-(190,51) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (190,51)-(190,66) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("_pool.Allocate<");
                                #line hidden
                                #line (190,67)-(190,85) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.GreenItemType);
                                #line hidden
                                #line (190,86)-(190,90) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(">();");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (191,17)-(191,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("for");
                                #line hidden
                                #line (191,20)-(191,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,21)-(191,25) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("(int");
                                #line hidden
                                #line (191,25)-(191,26) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,26)-(191,27) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("i");
                                #line hidden
                                #line (191,27)-(191,28) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,28)-(191,29) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (191,29)-(191,30) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,30)-(191,32) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("0;");
                                #line hidden
                                #line (191,32)-(191,33) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,33)-(191,34) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("i");
                                #line hidden
                                #line (191,34)-(191,35) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,35)-(191,36) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("<");
                                #line hidden
                                #line (191,36)-(191,37) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,38)-(191,56) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (191,57)-(191,71) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Context.Count;");
                                #line hidden
                                #line (191,71)-(191,72) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (191,72)-(191,76) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("++i)");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (192,17)-(192,18) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("{");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                var __first225 = true;
                                #line (193,30)-(193,46) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if(elem.IsToken)
                                #line hidden
                                
                                {
                                    if (__first225)
                                    {
                                        __first225 = false;
                                    }
                                    __cb.Push("                    ");
                                    #line (194,22)-(194,40) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (194,41)-(194,72) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add(this.VisitTerminal(");
                                    #line hidden
                                    #line (194,73)-(194,91) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (194,92)-(194,99) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (194,100)-(194,105) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("[i]");
                                    #line hidden
                                    #line (194,106)-(194,109) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("));");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                }
                                #line (195,30)-(195,34) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                else
                                #line hidden
                                
                                {
                                    if (__first225)
                                    {
                                        __first225 = false;
                                    }
                                    __cb.Push("                    ");
                                    #line (196,21)-(196,23) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("if");
                                    #line hidden
                                    #line (196,23)-(196,24) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (196,24)-(196,25) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("(");
                                    #line hidden
                                    #line (196,26)-(196,44) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (196,45)-(196,52) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (196,53)-(196,58) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("[i]");
                                    #line hidden
                                    #line (196,59)-(196,60) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (196,60)-(196,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("is");
                                    #line hidden
                                    #line (196,62)-(196,63) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (196,63)-(196,66) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("not");
                                    #line hidden
                                    #line (196,66)-(196,67) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (196,67)-(196,72) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("null)");
                                    #line hidden
                                    #line (196,72)-(196,73) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (196,74)-(196,92) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (196,93)-(196,106) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add((");
                                    #line hidden
                                    #line (196,107)-(196,125) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (196,126)-(196,139) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("?)this.Visit(");
                                    #line hidden
                                    #line (196,140)-(196,158) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (196,159)-(196,166) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Context");
                                    #line hidden
                                    #line (196,167)-(196,172) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("[i]");
                                    #line hidden
                                    #line (196,173)-(196,174) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(")");
                                    #line hidden
                                    #line (196,174)-(196,175) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (196,175)-(196,177) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("??");
                                    #line hidden
                                    #line (196,177)-(196,178) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (196,179)-(196,197) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (196,198)-(196,210) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                    __cb.Push("                    ");
                                    #line (197,21)-(197,25) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("else");
                                    #line hidden
                                    #line (197,25)-(197,26) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (197,27)-(197,45) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (197,46)-(197,58) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("Builder.Add(");
                                    #line hidden
                                    #line (197,59)-(197,77) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (197,78)-(197,90) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing);");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                }
                                if (!__first225) __cb.AppendLine();
                                __cb.Push("                ");
                                #line (199,17)-(199,18) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("}");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (200,17)-(200,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (200,20)-(200,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (200,22)-(200,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (200,41)-(200,42) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (200,42)-(200,43) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (200,43)-(200,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (200,45)-(200,63) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (200,64)-(200,81) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Builder.ToList();");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (201,17)-(201,28) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("_pool.Free(");
                                #line hidden
                                #line (201,29)-(201,47) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (201,48)-(201,57) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("Builder);");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            if (!__first217) __cb.AppendLine();
                        }
                        #line (203,22)-(203,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                        else
                        #line hidden
                        
                        {
                            if (__first216)
                            {
                                __first216 = false;
                            }
                            var __first226 = true;
                            #line (204,26)-(204,88) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            if(elem is ParserRuleFixedStringAlternativesElement fixedAlts)
                            #line hidden
                            
                            {
                                if (__first226)
                                {
                                    __first226 = false;
                                }
                                __cb.Push("                ");
                                #line (205,17)-(205,37) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("InternalSyntaxToken?");
                                #line hidden
                                #line (205,37)-(205,38) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (205,39)-(205,57) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (205,58)-(205,59) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (205,59)-(205,60) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (205,60)-(205,61) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (205,61)-(205,66) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("null;");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                var __first227 = true;
                                #line (206,30)-(206,78) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                foreach (var fixedAlt in fixedAlts.Alternatives)
                                #line hidden
                                
                                {
                                    if (__first227)
                                    {
                                        __first227 = false;
                                    }
                                    __cb.Push("                ");
                                    #line (207,17)-(207,19) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("if");
                                    #line hidden
                                    #line (207,19)-(207,20) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (207,20)-(207,29) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("(context.");
                                    #line hidden
                                    #line (207,30)-(207,48) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(fixedAlt.AntlrName);
                                    #line hidden
                                    #line (207,49)-(207,50) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (207,50)-(207,52) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("is");
                                    #line hidden
                                    #line (207,52)-(207,53) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (207,53)-(207,56) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("not");
                                    #line hidden
                                    #line (207,56)-(207,57) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (207,57)-(207,62) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("null)");
                                    #line hidden
                                    #line (207,62)-(207,63) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (207,64)-(207,82) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (207,83)-(207,84) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (207,84)-(207,85) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("=");
                                    #line hidden
                                    #line (207,85)-(207,86) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (207,86)-(207,134) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("(InternalSyntaxToken)this.VisitTerminal(context.");
                                    #line hidden
                                    #line (207,135)-(207,153) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(fixedAlt.AntlrName);
                                    #line hidden
                                    #line (207,154)-(207,156) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(");");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                }
                                if (!__first227) __cb.AppendLine();
                            }
                            #line (209,26)-(209,81) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            else if(elem is ParserRuleFixedStringElement fixedElem)
                            #line hidden
                            
                            {
                                if (__first226)
                                {
                                    __first226 = false;
                                }
                                __cb.Push("                ");
                                #line (210,17)-(210,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (210,20)-(210,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (210,22)-(210,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (210,41)-(210,42) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (210,42)-(210,43) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (210,43)-(210,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (210,44)-(210,71) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("this.VisitTerminal(context.");
                                #line hidden
                                #line (210,72)-(210,86) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                var __first228 = true;
                                #line (210,88)-(210,109) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (!elem.IsOptional)
                                #line hidden
                                
                                {
                                    if (__first228)
                                    {
                                        __first228 = false;
                                    }
                                    #line (210,110)-(210,111) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(",");
                                    #line hidden
                                    #line (210,111)-(210,112) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (210,113)-(210,126) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(language.Name);
                                    #line hidden
                                    #line (210,127)-(210,138) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("SyntaxKind.");
                                    #line hidden
                                    #line (210,139)-(210,169) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(fixedElem.LexerRule.CSharpName);
                                    #line hidden
                                }
                                #line (210,178)-(210,180) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(");");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            #line (211,26)-(211,97) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            else if(elem.IsToken && elem is ParserRuleReferenceElement ruleRefElem)
                            #line hidden
                            
                            {
                                if (__first226)
                                {
                                    __first226 = false;
                                }
                                __cb.Push("                ");
                                #line (212,17)-(212,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (212,20)-(212,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (212,22)-(212,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (212,41)-(212,42) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (212,42)-(212,43) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (212,43)-(212,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (212,44)-(212,71) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("this.VisitTerminal(context.");
                                #line hidden
                                #line (212,72)-(212,86) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                var __first229 = true;
                                #line (212,88)-(212,109) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (!elem.IsOptional)
                                #line hidden
                                
                                {
                                    if (__first229)
                                    {
                                        __first229 = false;
                                    }
                                    #line (212,110)-(212,111) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(",");
                                    #line hidden
                                    #line (212,111)-(212,112) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (212,113)-(212,126) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(language.Name);
                                    #line hidden
                                    #line (212,127)-(212,138) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("SyntaxKind.");
                                    #line hidden
                                    #line (212,139)-(212,166) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(ruleRefElem.Rule.CSharpName);
                                    #line hidden
                                }
                                #line (212,175)-(212,177) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(");");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            #line (213,26)-(213,87) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            else if(elem.IsToken && elem is ParserRuleEofElement eofElem)
                            #line hidden
                            
                            {
                                if (__first226)
                                {
                                    __first226 = false;
                                }
                                __cb.Push("                ");
                                #line (214,17)-(214,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (214,20)-(214,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (214,22)-(214,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (214,41)-(214,42) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (214,42)-(214,43) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (214,43)-(214,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (214,44)-(214,71) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("this.VisitTerminal(context.");
                                #line hidden
                                #line (214,72)-(214,86) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                #line (214,87)-(214,88) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(",");
                                #line hidden
                                #line (214,88)-(214,89) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (214,90)-(214,103) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(language.Name);
                                #line hidden
                                #line (214,104)-(214,120) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("SyntaxKind.Eof);");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            #line (215,26)-(215,47) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            else if(elem.IsToken)
                            #line hidden
                            
                            {
                                if (__first226)
                                {
                                    __first226 = false;
                                }
                                __cb.Push("                ");
                                #line (216,17)-(216,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("var");
                                #line hidden
                                #line (216,20)-(216,21) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (216,22)-(216,40) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (216,41)-(216,42) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (216,42)-(216,43) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (216,43)-(216,44) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (216,44)-(216,71) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("this.VisitTerminal(context.");
                                #line hidden
                                #line (216,72)-(216,86) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                #line (216,87)-(216,89) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(");");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            #line (217,26)-(217,30) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                            else
                            #line hidden
                            
                            {
                                if (__first226)
                                {
                                    __first226 = false;
                                }
                                __cb.Push("                ");
                                #line (218,18)-(218,36) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.GreenItemType);
                                #line hidden
                                #line (218,37)-(218,38) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("?");
                                #line hidden
                                #line (218,38)-(218,39) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (218,40)-(218,58) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (218,59)-(218,60) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (218,60)-(218,61) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (218,61)-(218,62) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (218,62)-(218,67) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("null;");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("                ");
                                #line (219,17)-(219,19) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("if");
                                #line hidden
                                #line (219,19)-(219,20) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (219,20)-(219,29) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("(context.");
                                #line hidden
                                #line (219,30)-(219,44) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                #line (219,45)-(219,46) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (219,46)-(219,48) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("is");
                                #line hidden
                                #line (219,48)-(219,49) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (219,49)-(219,52) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("not");
                                #line hidden
                                #line (219,52)-(219,53) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (219,53)-(219,58) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("null)");
                                #line hidden
                                #line (219,58)-(219,59) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (219,60)-(219,78) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (219,79)-(219,80) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (219,80)-(219,81) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("=");
                                #line hidden
                                #line (219,81)-(219,82) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(" ");
                                #line hidden
                                #line (219,82)-(219,83) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("(");
                                #line hidden
                                #line (219,84)-(219,102) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.GreenItemType);
                                #line hidden
                                #line (219,103)-(219,124) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write("?)this.Visit(context.");
                                #line hidden
                                #line (219,125)-(219,139) 44 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                #line (219,140)-(219,141) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(")");
                                #line hidden
                                var __first230 = true;
                                #line (219,142)-(219,163) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (!elem.IsOptional)
                                #line hidden
                                
                                {
                                    if (__first230)
                                    {
                                        __first230 = false;
                                    }
                                    #line (219,164)-(219,165) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (219,165)-(219,167) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("??");
                                    #line hidden
                                    #line (219,167)-(219,168) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (219,169)-(219,187) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (219,188)-(219,198) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing");
                                    #line hidden
                                }
                                #line (219,206)-(219,207) 45 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                __cb.Write(";");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                var __first231 = true;
                                #line (220,30)-(220,51) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                if (!elem.IsOptional)
                                #line hidden
                                
                                {
                                    if (__first231)
                                    {
                                        __first231 = false;
                                    }
                                    __cb.Push("                ");
                                    #line (221,17)-(221,21) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("else");
                                    #line hidden
                                    #line (221,21)-(221,22) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (221,23)-(221,41) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (221,42)-(221,43) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (221,43)-(221,44) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write("=");
                                    #line hidden
                                    #line (221,44)-(221,45) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (221,46)-(221,64) 48 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(elem.GreenItemType);
                                    #line hidden
                                    #line (221,65)-(221,76) 49 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                                    __cb.Write(".__Missing;");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                }
                                if (!__first231) __cb.AppendLine();
                            }
                            if (!__first226) __cb.AppendLine();
                        }
                        if (!__first216) __cb.AppendLine();
                    }
                    if (!__first215) __cb.AppendLine();
                    __cb.Push("            \t");
                    #line (226,14)-(226,20) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("return");
                    #line hidden
                    #line (226,20)-(226,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (226,21)-(226,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("_factory.");
                    #line hidden
                    #line (226,31)-(226,45) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(alt.CSharpName);
                    #line hidden
                    #line (226,46)-(226,47) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("(");
                    #line hidden
                    #line (226,48)-(226,72) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(alt.GreenUpdateArguments);
                    #line hidden
                    #line (226,73)-(226,75) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (227,13)-(227,14) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
                    __cb.Write("}");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first214) __cb.AppendLine();
            }
            if (!__first213) __cb.AppendLine();
            __cb.Push("        ");
            #line (230,9)-(230,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (231,5)-(231,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (232,1)-(232,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (235,9)-(235,58) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
        public string GenerateInternalSyntaxFactory(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (236,1)-(236,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (236,6)-(236,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (236,7)-(236,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (237,1)-(237,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (237,6)-(237,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (237,7)-(237,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (238,1)-(238,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (238,6)-(238,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (238,7)-(238,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (239,1)-(239,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (239,6)-(239,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (239,7)-(239,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (240,1)-(240,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (240,6)-(240,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (240,7)-(240,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (242,1)-(242,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (242,10)-(242,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (242,11)-(242,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (244,1)-(244,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (244,10)-(244,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (244,12)-(244,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            #line (244,40)-(244,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (245,1)-(245,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (246,5)-(246,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (246,11)-(246,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (246,12)-(246,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("partial");
            #line hidden
            #line (246,19)-(246,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (246,20)-(246,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (246,25)-(246,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (246,27)-(246,40) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (246,41)-(246,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (246,62)-(246,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (246,63)-(246,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (246,64)-(246,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (246,65)-(246,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("IAntlrSyntaxFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (247,5)-(247,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (248,6)-(248,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (248,16)-(248,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (248,17)-(248,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream");
            #line hidden
            #line (248,65)-(248,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (248,66)-(248,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("input)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (249,6)-(249,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (250,10)-(250,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (250,16)-(250,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (250,17)-(250,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (250,20)-(250,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (250,22)-(250,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (250,36)-(250,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Lexer(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (251,6)-(251,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (253,6)-(253,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("AntlrParser");
            #line hidden
            #line (253,17)-(253,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (253,18)-(253,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream");
            #line hidden
            #line (253,68)-(253,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (253,69)-(253,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("input)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (254,6)-(254,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (255,10)-(255,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (255,16)-(255,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (255,17)-(255,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (255,20)-(255,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (255,22)-(255,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (255,36)-(255,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("Parser(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (256,6)-(256,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (257,5)-(257,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (258,1)-(258,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\SyntaxGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}