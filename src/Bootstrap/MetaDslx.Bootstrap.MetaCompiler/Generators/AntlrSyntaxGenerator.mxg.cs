#line (1,10)-(1,53) 10 "AntlrSyntaxGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "AntlrSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "AntlrSyntaxGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "AntlrSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "AntlrSyntaxGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "AntlrSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "AntlrSyntaxGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "AntlrSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "AntlrSyntaxGenerator.mxg"
    System.Linq;
    #line hidden
    #line (7,1)-(7,6) 5 "AntlrSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (7,7)-(7,23) 13 "AntlrSyntaxGenerator.mxg"
    Roslyn.Utilities;
    #line hidden
    
    #line (9,10)-(9,29) 25 "AntlrSyntaxGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (12,9)-(12,36) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateAntlrSyntaxLexer()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,1)-(15,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,6)-(15,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,7)-(15,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,1)-(16,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (16,6)-(16,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,7)-(16,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,1)-(17,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (17,6)-(17,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,7)-(17,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,1)-(19,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (19,10)-(19,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,11)-(19,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (21,1)-(21,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (21,10)-(21,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,12)-(21,21) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (21,22)-(21,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (22,1)-(22,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,5)-(23,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (23,11)-(23,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,12)-(23,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (23,19)-(23,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,20)-(23,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (23,25)-(23,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,27)-(23,31) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (23,32)-(23,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer");
            #line hidden
            #line (23,43)-(23,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,44)-(23,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (23,45)-(23,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,46)-(23,62) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrSyntaxLexer");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,5)-(24,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,9)-(25,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (25,15)-(25,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,17)-(25,21) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (25,22)-(25,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer(SourceText");
            #line hidden
            #line (25,44)-(25,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,45)-(25,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (25,50)-(25,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,52)-(25,56) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (25,57)-(25,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParseOptions");
            #line hidden
            #line (25,69)-(25,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,70)-(25,78) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("options)");
            #line hidden
            #line (25,78)-(25,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (26,13)-(26,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (26,14)-(26,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,15)-(26,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("base(text,");
            #line hidden
            #line (26,25)-(26,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,26)-(26,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("options)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,9)-(27,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,9)-(28,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (30,9)-(30,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (30,18)-(30,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,19)-(30,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (30,22)-(30,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,24)-(30,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (30,29)-(30,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer");
            #line hidden
            #line (30,34)-(30,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,35)-(30,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (30,45)-(30,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,46)-(30,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (30,48)-(30,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,49)-(30,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (30,51)-(30,55) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (30,56)-(30,78) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer)base.AntlrLexer;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,5)-(32,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,1)-(33,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (36,9)-(36,37) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateAntlrSyntaxParser()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (37,1)-(37,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (37,6)-(37,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,7)-(37,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (38,1)-(38,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (38,6)-(38,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,7)-(38,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Diagnostics;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,1)-(39,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,6)-(39,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,7)-(39,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (40,1)-(40,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (40,6)-(40,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,7)-(40,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (41,1)-(41,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (41,6)-(41,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,7)-(41,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (42,1)-(42,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (42,6)-(42,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,7)-(42,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Threading.Tasks;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (43,1)-(43,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (43,6)-(43,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,7)-(43,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,1)-(44,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (44,6)-(44,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,7)-(44,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime.Tree;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,1)-(45,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (45,6)-(45,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,7)-(45,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (46,1)-(46,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (46,6)-(46,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,7)-(46,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (47,1)-(47,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (47,6)-(47,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,7)-(47,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (48,1)-(48,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (48,6)-(48,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,7)-(48,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (49,1)-(49,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (49,6)-(49,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,7)-(49,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (50,1)-(50,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (50,6)-(50,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,8)-(50,17) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (50,18)-(50,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (52,1)-(52,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (52,10)-(52,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,11)-(52,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (54,1)-(54,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (54,10)-(54,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,12)-(54,21) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (54,22)-(54,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (55,1)-(55,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (56,5)-(56,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (56,11)-(56,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,12)-(56,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (56,19)-(56,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,20)-(56,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (56,25)-(56,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,27)-(56,31) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (56,32)-(56,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (56,44)-(56,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,45)-(56,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (56,46)-(56,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,47)-(56,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrSyntaxParser");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (57,5)-(57,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (58,9)-(58,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (58,16)-(58,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,17)-(58,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (58,25)-(58,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,26)-(58,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor");
            #line hidden
            #line (58,46)-(58,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,47)-(58,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_visitor;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (60,9)-(60,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (60,15)-(60,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,17)-(60,21) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (60,22)-(60,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (61,14)-(61,18) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (61,19)-(61,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer");
            #line hidden
            #line (61,30)-(61,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,31)-(61,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("lexer,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (62,4)-(62,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IncrementalParseData?");
            #line hidden
            #line (62,25)-(62,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,26)-(62,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("oldParseData,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (63,13)-(63,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IEnumerable<TextChangeRange>");
            #line hidden
            #line (63,41)-(63,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,42)-(63,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("changes,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (64,13)-(64,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("CancellationToken");
            #line hidden
            #line (64,30)-(64,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,31)-(64,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("cancellationToken");
            #line hidden
            #line (64,48)-(64,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,49)-(64,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (64,50)-(64,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,51)-(64,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("default)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (65,13)-(65,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (65,14)-(65,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,15)-(65,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("base(lexer,");
            #line hidden
            #line (65,26)-(65,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,27)-(65,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("oldParseData,");
            #line hidden
            #line (65,40)-(65,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,41)-(65,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("changes,");
            #line hidden
            #line (65,49)-(65,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,50)-(65,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,9)-(66,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (67,13)-(67,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_visitor");
            #line hidden
            #line (67,21)-(67,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,22)-(67,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,23)-(67,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,24)-(67,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (67,27)-(67,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,28)-(67,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (68,9)-(68,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,9)-(70,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (70,18)-(70,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,19)-(70,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (70,22)-(70,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,24)-(70,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (70,29)-(70,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser");
            #line hidden
            #line (70,35)-(70,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,36)-(70,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrParser");
            #line hidden
            #line (70,47)-(70,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,48)-(70,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (70,50)-(70,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,51)-(70,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (70,53)-(70,57) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (70,58)-(70,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser)base.AntlrParser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (72,3)-(72,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (72,12)-(72,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,13)-(72,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (72,21)-(72,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,22)-(72,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxNode");
            #line hidden
            #line (72,32)-(72,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,33)-(72,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParseRoot()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (73,3)-(73,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (74,13)-(74,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParserState?");
            #line hidden
            #line (74,25)-(74,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,26)-(74,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("state");
            #line hidden
            #line (74,31)-(74,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,32)-(74,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,33)-(74,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,34)-(74,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (75,4)-(75,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (75,14)-(75,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,15)-(75,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green");
            #line hidden
            #line (75,20)-(75,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,21)-(75,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (75,22)-(75,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,23)-(75,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("this.Parse");
            #line hidden
            #line (75,34)-(75,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.CSharpName);
            #line hidden
            #line (75,55)-(75,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(ref");
            #line hidden
            #line (75,59)-(75,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,60)-(75,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("state);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (76,4)-(76,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (76,7)-(76,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,8)-(76,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("red");
            #line hidden
            #line (76,11)-(76,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,12)-(76,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,13)-(76,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,14)-(76,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (76,16)-(76,20) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (76,21)-(76,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxNode)green!.CreateRed();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (77,4)-(77,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (77,10)-(77,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,11)-(77,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("red;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t");
            #line (78,3)-(78,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,9)-(80,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (80,16)-(80,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,17)-(80,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (80,27)-(80,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,28)-(80,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parse");
            #line hidden
            #line (80,34)-(80,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.CSharpName);
            #line hidden
            #line (80,55)-(80,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(ref");
            #line hidden
            #line (80,59)-(80,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,60)-(80,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParserState?");
            #line hidden
            #line (80,72)-(80,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,73)-(80,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("state)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,9)-(81,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (82,13)-(82,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (82,19)-(82,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,20)-(82,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_visitor.Visit");
            #line hidden
            #line (82,35)-(82,70) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.AntlrName?.ToPascalCase());
            #line hidden
            #line (82,71)-(82,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(AntlrParser.");
            #line hidden
            #line (82,85)-(82,104) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.AntlrName);
            #line hidden
            #line (82,105)-(82,109) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,9)-(83,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (85,16)-(85,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,17)-(85,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (85,22)-(85,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,23)-(85,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor");
            #line hidden
            #line (85,43)-(85,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,44)-(85,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (85,45)-(85,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,47)-(85,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (85,52)-(85,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParserBaseVisitor<GreenNode?>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (86,9)-(86,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (87,4)-(87,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (87,6)-(87,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,7)-(87,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("list");
            #line hidden
            #line (87,11)-(87,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,12)-(87,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("pools");
            #line hidden
            #line (87,17)-(87,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,18)-(87,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("-");
            #line hidden
            #line (87,19)-(87,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,20)-(87,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("allocators");
            #line hidden
            #line (87,30)-(87,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,31)-(87,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (87,34)-(87,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,35)-(87,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("lists");
            #line hidden
            #line (87,40)-(87,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,41)-(87,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("that");
            #line hidden
            #line (87,45)-(87,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,46)-(87,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("are");
            #line hidden
            #line (87,49)-(87,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,50)-(87,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("used");
            #line hidden
            #line (87,54)-(87,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,55)-(87,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (87,57)-(87,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,58)-(87,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("build");
            #line hidden
            #line (87,63)-(87,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,64)-(87,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("sequences");
            #line hidden
            #line (87,73)-(87,74) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,74)-(87,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (87,76)-(87,77) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,77)-(87,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("nodes.");
            #line hidden
            #line (87,83)-(87,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,84)-(87,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (87,87)-(87,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,88)-(87,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("lists");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (88,4)-(88,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (88,6)-(88,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,7)-(88,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("can");
            #line hidden
            #line (88,10)-(88,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,11)-(88,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("be");
            #line hidden
            #line (88,13)-(88,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,14)-(88,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("reused");
            #line hidden
            #line (88,20)-(88,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,21)-(88,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(hence");
            #line hidden
            #line (88,27)-(88,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,28)-(88,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("pooled)");
            #line hidden
            #line (88,35)-(88,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,36)-(88,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("since");
            #line hidden
            #line (88,41)-(88,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,42)-(88,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (88,45)-(88,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,46)-(88,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("syntax");
            #line hidden
            #line (88,52)-(88,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,53)-(88,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("factory");
            #line hidden
            #line (88,60)-(88,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,61)-(88,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("methods");
            #line hidden
            #line (88,68)-(88,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,69)-(88,74) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("don't");
            #line hidden
            #line (88,74)-(88,75) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,75)-(88,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("keep");
            #line hidden
            #line (88,79)-(88,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,80)-(88,90) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("references");
            #line hidden
            #line (88,90)-(88,91) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,91)-(88,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (89,4)-(89,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (89,6)-(89,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,7)-(89,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("them");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (90,4)-(90,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (90,11)-(90,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,12)-(90,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (90,20)-(90,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,21)-(90,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxListPool");
            #line hidden
            #line (90,35)-(90,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,36)-(90,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool");
            #line hidden
            #line (90,41)-(90,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,42)-(90,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (90,43)-(90,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,44)-(90,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (90,47)-(90,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,48)-(90,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxListPool();");
            #line hidden
            #line (90,65)-(90,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,66)-(90,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (90,68)-(90,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,69)-(90,74) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Don't");
            #line hidden
            #line (90,74)-(90,75) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,75)-(90,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("need");
            #line hidden
            #line (90,79)-(90,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,80)-(90,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (90,82)-(90,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,83)-(90,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("reset");
            #line hidden
            #line (90,88)-(90,89) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,89)-(90,94) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("this.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (92,13)-(92,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (92,20)-(92,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,21)-(92,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (92,29)-(92,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,31)-(92,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (92,36)-(92,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (92,48)-(92,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,49)-(92,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (93,13)-(93,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (93,20)-(93,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,21)-(93,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (93,29)-(93,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,30)-(93,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrTokenStream");
            #line hidden
            #line (93,46)-(93,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,47)-(93,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (94,4)-(94,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (94,11)-(94,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,12)-(94,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (94,20)-(94,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,22)-(94,26) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (94,27)-(94,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (94,48)-(94,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,49)-(94,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (96,13)-(96,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (96,19)-(96,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,20)-(96,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor(");
            #line hidden
            #line (96,42)-(96,46) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (96,47)-(96,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (96,59)-(96,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,60)-(96,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("parser)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (97,13)-(97,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (98,17)-(98,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser");
            #line hidden
            #line (98,24)-(98,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,25)-(98,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (98,26)-(98,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,27)-(98,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (99,17)-(99,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream");
            #line hidden
            #line (99,29)-(99,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,30)-(99,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (99,31)-(99,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,32)-(99,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(AntlrTokenStream)_parser.AntlrParser.InputStream;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (100,5)-(100,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory");
            #line hidden
            #line (100,13)-(100,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,14)-(100,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (100,15)-(100,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,16)-(100,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (100,18)-(100,22) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (100,23)-(100,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (101,13)-(101,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (103,13)-(103,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (103,20)-(103,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,21)-(103,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (103,31)-(103,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,32)-(103,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(IToken?");
            #line hidden
            #line (103,53)-(103,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,54)-(103,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("token,");
            #line hidden
            #line (103,60)-(103,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,62)-(103,66) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (103,67)-(103,77) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (103,77)-(103,78) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,78)-(103,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (104,13)-(104,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (105,5)-(105,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (105,7)-(105,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,8)-(105,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(token");
            #line hidden
            #line (105,14)-(105,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,15)-(105,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (105,17)-(105,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,18)-(105,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (106,5)-(106,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (107,6)-(107,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (107,8)-(107,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,9)-(107,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(kind");
            #line hidden
            #line (107,14)-(107,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,15)-(107,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (107,17)-(107,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,19)-(107,23) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (107,24)-(107,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None)");
            #line hidden
            #line (107,40)-(107,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,41)-(107,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (107,47)-(107,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,48)-(107,107) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream.ConsumeGreenToken(_factory.MissingToken(kind),");
            #line hidden
            #line (107,107)-(107,108) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,108)-(107,117) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (108,6)-(108,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (108,10)-(108,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,11)-(108,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (108,17)-(108,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,18)-(108,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (109,5)-(109,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (110,17)-(110,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (110,20)-(110,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,21)-(110,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green");
            #line hidden
            #line (110,26)-(110,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,27)-(110,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (110,28)-(110,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,29)-(110,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream.ConsumeGreenToken(token,");
            #line hidden
            #line (110,66)-(110,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,67)-(110,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (111,5)-(111,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Debug.Assert(kind");
            #line hidden
            #line (111,22)-(111,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,23)-(111,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (111,25)-(111,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,27)-(111,31) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (111,32)-(111,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None");
            #line hidden
            #line (111,47)-(111,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,48)-(111,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("||");
            #line hidden
            #line (111,50)-(111,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,51)-(111,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green.RawKind");
            #line hidden
            #line (111,64)-(111,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,65)-(111,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (111,67)-(111,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,68)-(111,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (112,5)-(112,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (112,11)-(112,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,12)-(112,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (113,13)-(113,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (115,13)-(115,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (115,19)-(115,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,20)-(115,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (115,30)-(115,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,31)-(115,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(IToken?");
            #line hidden
            #line (115,52)-(115,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,53)-(115,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("token)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (116,13)-(116,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (117,5)-(117,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (117,11)-(117,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,12)-(117,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(token,");
            #line hidden
            #line (117,32)-(117,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,34)-(117,38) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (117,39)-(117,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (118,13)-(118,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (120,13)-(120,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (120,20)-(120,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,21)-(120,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (120,31)-(120,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,32)-(120,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(ITerminalNode?");
            #line hidden
            #line (120,60)-(120,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,61)-(120,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("node,");
            #line hidden
            #line (120,66)-(120,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,68)-(120,72) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (120,73)-(120,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (120,83)-(120,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,84)-(120,89) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (121,13)-(121,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (122,17)-(122,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (122,19)-(122,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,20)-(122,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(node?.Symbol");
            #line hidden
            #line (122,33)-(122,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,34)-(122,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (122,36)-(122,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,37)-(122,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (123,5)-(123,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (124,6)-(124,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (124,8)-(124,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,9)-(124,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(kind");
            #line hidden
            #line (124,14)-(124,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,15)-(124,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (124,17)-(124,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,19)-(124,23) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (124,24)-(124,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None)");
            #line hidden
            #line (124,40)-(124,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,41)-(124,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (124,47)-(124,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,48)-(124,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory.MissingToken(kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t\t");
            #line (125,6)-(125,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (125,10)-(125,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,11)-(125,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (125,17)-(125,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,18)-(125,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (126,5)-(126,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (127,17)-(127,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (127,20)-(127,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,21)-(127,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green");
            #line hidden
            #line (127,26)-(127,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,27)-(127,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (127,28)-(127,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,29)-(127,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream.ConsumeGreenToken(node.Symbol,");
            #line hidden
            #line (127,72)-(127,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,73)-(127,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (128,5)-(128,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Debug.Assert(kind");
            #line hidden
            #line (128,22)-(128,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,23)-(128,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (128,25)-(128,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,27)-(128,31) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (128,32)-(128,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None");
            #line hidden
            #line (128,47)-(128,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,48)-(128,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("||");
            #line hidden
            #line (128,50)-(128,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,51)-(128,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green.RawKind");
            #line hidden
            #line (128,64)-(128,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,65)-(128,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (128,67)-(128,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,68)-(128,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t\t");
            #line (129,5)-(129,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (129,11)-(129,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,12)-(129,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t\t\t");
            #line (130,4)-(130,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (132,13)-(132,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (132,19)-(132,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,20)-(132,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (132,28)-(132,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,29)-(132,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (132,39)-(132,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,40)-(132,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(ITerminalNode?");
            #line hidden
            #line (132,68)-(132,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,69)-(132,74) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (133,13)-(133,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (134,17)-(134,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (134,23)-(134,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,24)-(134,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(node,");
            #line hidden
            #line (134,43)-(134,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,45)-(134,49) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (134,50)-(134,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (135,13)-(135,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first24 = true;
            #line (137,14)-(137,41) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                var __first25 = true;
                #line (138,18)-(138,56) 17 "AntlrSyntaxGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first25)
                    {
                        __first25 = false;
                    }
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (140,13)-(140,19) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (140,19)-(140,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,20)-(140,28) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("override");
                    #line hidden
                    #line (140,28)-(140,29) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,29)-(140,39) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("GreenNode?");
                    #line hidden
                    #line (140,39)-(140,40) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,40)-(140,45) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("Visit");
                    #line hidden
                    #line (140,46)-(140,74) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(alt.AntlrName.ToPascalCase());
                    #line hidden
                    #line (140,75)-(140,76) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (140,77)-(140,81) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (140,82)-(140,89) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("Parser.");
                    #line hidden
                    #line (140,90)-(140,118) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(alt.AntlrName.ToPascalCase());
                    #line hidden
                    #line (140,119)-(140,127) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("Context?");
                    #line hidden
                    #line (140,127)-(140,128) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,128)-(140,136) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("context)");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (141,13)-(141,14) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("   \t");
                    #line (142,17)-(142,19) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (142,19)-(142,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,20)-(142,28) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(context");
                    #line hidden
                    #line (142,28)-(142,29) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,29)-(142,31) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (142,31)-(142,32) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,32)-(142,37) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("null)");
                    #line hidden
                    #line (142,37)-(142,38) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,38)-(142,44) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (142,44)-(142,45) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,46)-(142,59) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(alt.GreenName);
                    #line hidden
                    #line (142,60)-(142,71) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(".__Missing;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    var __first26 = true;
                    #line (143,18)-(143,52) 21 "AntlrSyntaxGenerator.mxg"
                    foreach (var elem in alt.Elements)
                    #line hidden
                    
                    {
                        if (__first26)
                        {
                            __first26 = false;
                        }
                        var __first27 = true;
                        #line (144,22)-(144,57) 25 "AntlrSyntaxGenerator.mxg"
                        if (elem.Value is SeparatedList sl)
                        #line hidden
                        
                        {
                            if (__first27)
                            {
                                __first27 = false;
                            }
                            __cb.Push("    ");
                            #line (145,18)-(145,54) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(GenerateVisitSeparatedList(elem, sl));
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        #line (146,22)-(146,58) 25 "AntlrSyntaxGenerator.mxg"
                        else if (elem.Multiplicity.IsList())
                        #line hidden
                        
                        {
                            if (__first27)
                            {
                                __first27 = false;
                            }
                            __cb.Push("    ");
                            #line (147,18)-(147,41) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(GenerateVisitList(elem));
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        #line (148,22)-(148,65) 25 "AntlrSyntaxGenerator.mxg"
                        else if (elem.Value is TokenAlts tokenAlts)
                        #line hidden
                        
                        {
                            if (__first27)
                            {
                                __first27 = false;
                            }
                            __cb.Push("    ");
                            #line (149,18)-(149,57) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(GenerateVisitTokenAlts(elem, tokenAlts));
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        #line (150,22)-(150,49) 25 "AntlrSyntaxGenerator.mxg"
                        else if (elem.Value is Eof)
                        #line hidden
                        
                        {
                            if (__first27)
                            {
                                __first27 = false;
                            }
                            __cb.Push("    ");
                            #line (151,17)-(151,20) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("var");
                            #line hidden
                            #line (151,20)-(151,21) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (151,22)-(151,40) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(elem.ParameterName);
                            #line hidden
                            #line (151,41)-(151,42) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (151,42)-(151,43) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (151,43)-(151,44) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (151,44)-(151,93) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                            #line hidden
                            #line (151,94)-(151,108) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(elem.AntlrName);
                            #line hidden
                            #line (151,109)-(151,110) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (151,110)-(151,111) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (151,112)-(151,116) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(Lang);
                            #line hidden
                            #line (151,117)-(151,133) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("SyntaxKind.Eof);");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        #line (152,22)-(152,56) 25 "AntlrSyntaxGenerator.mxg"
                        else if (elem.Value is RuleRef rr)
                        #line hidden
                        
                        {
                            if (__first27)
                            {
                                __first27 = false;
                            }
                            var __first28 = true;
                            #line (153,26)-(153,51) 29 "AntlrSyntaxGenerator.mxg"
                            if (rr.Token is not null)
                            #line hidden
                            
                            {
                                if (__first28)
                                {
                                    __first28 = false;
                                }
                                __cb.Push("    ");
                                #line (154,17)-(154,20) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("var");
                                #line hidden
                                #line (154,20)-(154,21) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (154,22)-(154,40) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (154,41)-(154,42) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (154,42)-(154,43) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("=");
                                #line hidden
                                #line (154,43)-(154,44) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (154,44)-(154,93) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                                #line hidden
                                #line (154,94)-(154,108) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                var __first29 = true;
                                #line (154,110)-(154,146) 33 "AntlrSyntaxGenerator.mxg"
                                if (!elem.Multiplicity.IsOptional())
                                #line hidden
                                
                                {
                                    if (__first29)
                                    {
                                        __first29 = false;
                                    }
                                    #line (154,147)-(154,148) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(",");
                                    #line hidden
                                    #line (154,148)-(154,149) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (154,150)-(154,154) 48 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(Lang);
                                    #line hidden
                                    #line (154,155)-(154,166) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write("SyntaxKind.");
                                    #line hidden
                                    #line (154,167)-(154,186) 48 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(rr.Token.CSharpName);
                                    #line hidden
                                }
                                #line (154,195)-(154,197) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            #line (155,26)-(155,54) 29 "AntlrSyntaxGenerator.mxg"
                            else if(rr.Rule is not null)
                            #line hidden
                            
                            {
                                if (__first28)
                                {
                                    __first28 = false;
                                }
                                __cb.Push("    ");
                                #line (156,18)-(156,30) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(rr.GreenType);
                                #line hidden
                                #line (156,31)-(156,32) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("?");
                                #line hidden
                                #line (156,32)-(156,33) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (156,34)-(156,52) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (156,53)-(156,54) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (156,54)-(156,55) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("=");
                                #line hidden
                                #line (156,55)-(156,56) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (156,56)-(156,61) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("null;");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                __cb.Push("    ");
                                #line (157,17)-(157,19) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (157,19)-(157,20) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (157,20)-(157,29) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("(context.");
                                #line hidden
                                #line (157,30)-(157,44) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                #line (157,45)-(157,46) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (157,46)-(157,48) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("is");
                                #line hidden
                                #line (157,48)-(157,49) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (157,49)-(157,52) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("not");
                                #line hidden
                                #line (157,52)-(157,53) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (157,53)-(157,58) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("null)");
                                #line hidden
                                #line (157,58)-(157,59) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (157,60)-(157,78) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(elem.ParameterName);
                                #line hidden
                                #line (157,79)-(157,80) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (157,80)-(157,81) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("=");
                                #line hidden
                                #line (157,81)-(157,82) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (157,82)-(157,83) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("(");
                                #line hidden
                                #line (157,84)-(157,96) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(rr.GreenType);
                                #line hidden
                                #line (157,97)-(157,118) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write("?)this.Visit(context.");
                                #line hidden
                                #line (157,119)-(157,133) 44 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(elem.AntlrName);
                                #line hidden
                                #line (157,134)-(157,135) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(")");
                                #line hidden
                                var __first30 = true;
                                #line (157,136)-(157,172) 33 "AntlrSyntaxGenerator.mxg"
                                if (!elem.Multiplicity.IsOptional())
                                #line hidden
                                
                                {
                                    if (__first30)
                                    {
                                        __first30 = false;
                                    }
                                    #line (157,173)-(157,174) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (157,174)-(157,176) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write("??");
                                    #line hidden
                                    #line (157,176)-(157,177) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (157,178)-(157,190) 48 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(rr.GreenType);
                                    #line hidden
                                    #line (157,191)-(157,201) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(".__Missing");
                                    #line hidden
                                }
                                #line (157,209)-(157,210) 45 "AntlrSyntaxGenerator.mxg"
                                __cb.Write(";");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                                var __first31 = true;
                                #line (158,30)-(158,66) 33 "AntlrSyntaxGenerator.mxg"
                                if (!elem.Multiplicity.IsOptional())
                                #line hidden
                                
                                {
                                    if (__first31)
                                    {
                                        __first31 = false;
                                    }
                                    __cb.Push("    ");
                                    #line (159,17)-(159,21) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write("else");
                                    #line hidden
                                    #line (159,21)-(159,22) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (159,23)-(159,41) 48 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(elem.ParameterName);
                                    #line hidden
                                    #line (159,42)-(159,43) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (159,43)-(159,44) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write("=");
                                    #line hidden
                                    #line (159,44)-(159,45) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(" ");
                                    #line hidden
                                    #line (159,46)-(159,58) 48 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(rr.GreenType);
                                    #line hidden
                                    #line (159,59)-(159,70) 49 "AntlrSyntaxGenerator.mxg"
                                    __cb.Write(".__Missing;");
                                    #line hidden
                                    __cb.WriteLine();
                                    __cb.Pop();
                                }
                                if (!__first31) __cb.AppendLine();
                            }
                            #line (161,26)-(161,30) 29 "AntlrSyntaxGenerator.mxg"
                            else
                            #line hidden
                            
                            {
                                if (__first28)
                                {
                                    __first28 = false;
                                }
                            }
                            if (!__first28) __cb.AppendLine();
                        }
                        if (!__first27) __cb.AppendLine();
                    }
                    if (!__first26) __cb.AppendLine();
                    __cb.Push("\t");
                    #line (165,14)-(165,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (165,20)-(165,21) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,21)-(165,30) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("_factory.");
                    #line hidden
                    #line (165,31)-(165,45) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(alt.CSharpName);
                    #line hidden
                    #line (165,46)-(165,47) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (165,48)-(165,72) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(alt.GreenUpdateArguments);
                    #line hidden
                    #line (165,73)-(165,75) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (166,13)-(166,14) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first25) __cb.AppendLine();
            }
            if (!__first24) __cb.AppendLine();
            __cb.Push("");
            #line (169,9)-(169,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (170,5)-(170,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (171,1)-(171,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (174,9)-(174,67) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitTokenAlts(Element elem, TokenAlts tokenAlts)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (175,1)-(175,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxToken?");
            #line hidden
            #line (175,21)-(175,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,23)-(175,41) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (175,42)-(175,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,43)-(175,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (175,44)-(175,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,45)-(175,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first32 = true;
            #line (176,2)-(176,41) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var token in tokenAlts.Tokens)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("");
                #line (177,1)-(177,3) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (177,3)-(177,4) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,4)-(177,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(context.");
                #line hidden
                #line (177,14)-(177,35) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (177,36)-(177,38) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("()");
                #line hidden
                #line (177,38)-(177,39) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,39)-(177,41) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (177,41)-(177,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,42)-(177,45) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (177,45)-(177,46) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,46)-(177,51) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (177,51)-(177,52) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,53)-(177,71) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (177,72)-(177,73) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,73)-(177,74) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (177,74)-(177,75) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,75)-(177,124) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                #line hidden
                #line (177,125)-(177,146) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (177,147)-(177,151) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("());");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            var __first33 = true;
            #line (179,2)-(179,38) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("");
                #line (180,1)-(180,3) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (180,3)-(180,4) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,4)-(180,5) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (180,6)-(180,24) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (180,25)-(180,26) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,26)-(180,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (180,28)-(180,29) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,29)-(180,34) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (180,34)-(180,35) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,36)-(180,54) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (180,55)-(180,56) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,56)-(180,57) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (180,57)-(180,58) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,58)-(180,72) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("_factory.None;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (184,9)-(184,41) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitList(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (185,1)-(185,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (185,4)-(185,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (185,6)-(185,20) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (185,21)-(185,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (185,28)-(185,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (185,29)-(185,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (185,30)-(185,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (185,31)-(185,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (185,41)-(185,55) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (185,56)-(185,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (186,1)-(186,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (186,4)-(186,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,6)-(186,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (186,25)-(186,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder");
            #line hidden
            #line (186,32)-(186,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,33)-(186,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (186,34)-(186,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,35)-(186,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Allocate<");
            #line hidden
            #line (186,51)-(186,71) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (186,72)-(186,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (187,1)-(187,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (187,4)-(187,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,5)-(187,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (187,9)-(187,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,10)-(187,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (187,11)-(187,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,12)-(187,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (187,13)-(187,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,14)-(187,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (187,16)-(187,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,17)-(187,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (187,18)-(187,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,19)-(187,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (187,20)-(187,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,22)-(187,36) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (187,37)-(187,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (187,51)-(187,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,52)-(187,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (188,1)-(188,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first34 = true;
            #line (189,14)-(189,30) 13 "AntlrSyntaxGenerator.mxg"
            if(elem.IsToken)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("    ");
                #line (190,6)-(190,24) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (190,25)-(190,78) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (190,79)-(190,93) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (190,94)-(190,101) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (190,102)-(190,107) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (190,108)-(190,111) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (191,14)-(191,18) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("    ");
                #line (192,5)-(192,7) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (192,7)-(192,8) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,8)-(192,9) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (192,10)-(192,24) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (192,25)-(192,32) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (192,33)-(192,38) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (192,39)-(192,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,40)-(192,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (192,42)-(192,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,43)-(192,46) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (192,46)-(192,47) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,47)-(192,52) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (192,52)-(192,53) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,54)-(192,72) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (192,73)-(192,86) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((");
                #line hidden
                #line (192,87)-(192,107) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (192,108)-(192,121) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("?)this.Visit(");
                #line hidden
                #line (192,122)-(192,136) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (192,137)-(192,144) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (192,145)-(192,150) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (192,151)-(192,152) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (192,152)-(192,153) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,153)-(192,155) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("??");
                #line hidden
                #line (192,155)-(192,156) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,157)-(192,177) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (192,178)-(192,190) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (193,5)-(193,9) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (193,9)-(193,10) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,11)-(193,29) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (193,30)-(193,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add(");
                #line hidden
                #line (193,43)-(193,63) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (193,64)-(193,76) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("");
            #line (195,1)-(195,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (196,1)-(196,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (196,4)-(196,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,6)-(196,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (196,25)-(196,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,26)-(196,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (196,27)-(196,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,29)-(196,47) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (196,48)-(196,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder.ToList();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (197,1)-(197,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (197,13)-(197,31) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (197,32)-(197,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (200,9)-(200,68) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedList(Element elem, SeparatedList sl)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (201,2)-(201,44) 13 "AntlrSyntaxGenerator.mxg"
            var builder = elem.ParameterName+"Builder";
            #line hidden
            
            __cb.Push("");
            #line (202,1)-(202,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (202,4)-(202,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,6)-(202,13) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (202,14)-(202,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,15)-(202,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (202,16)-(202,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,17)-(202,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.AllocateSeparated<");
            #line hidden
            #line (202,42)-(202,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.GreenType);
            #line hidden
            #line (202,55)-(202,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">(reversed:");
            #line hidden
            #line (202,66)-(202,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,68)-(202,104) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.SeparatorFirst ? "true" : "false");
            #line hidden
            #line (202,105)-(202,107) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first35 = true;
            #line (203,6)-(203,83) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.FirstItems.Count && i < sl.FirstSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                var __first36 = true;
                #line (204,10)-(204,32) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.SeparatorFirst)
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    __cb.Push("");
                    #line (205,2)-(205,69) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (206,2)-(206,59) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (207,10)-(207,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    __cb.Push("");
                    #line (208,2)-(208,59) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (209,2)-(209,69) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first36) __cb.AppendLine();
            }
            if (!__first35) __cb.AppendLine();
            var __first37 = true;
            #line (212,6)-(212,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstItems.Count > sl.FirstSeparators.Count)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("");
                #line (213,2)-(213,79) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[sl.FirstItems.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            var __first38 = true;
            #line (215,6)-(215,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstSeparators.Count > sl.FirstItems.Count)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("");
                #line (216,2)-(216,94) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[sl.FirstSeparators.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (218,1)-(218,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (218,4)-(218,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,6)-(218,31) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (218,32)-(218,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (218,39)-(218,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,40)-(218,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (218,41)-(218,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (218,42)-(218,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (218,52)-(218,77) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (218,78)-(218,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (219,1)-(219,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (219,4)-(219,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,6)-(219,36) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (219,37)-(219,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (219,44)-(219,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,45)-(219,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (219,46)-(219,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,47)-(219,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (219,57)-(219,87) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (219,88)-(219,89) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (220,1)-(220,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (220,4)-(220,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,5)-(220,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (220,9)-(220,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,10)-(220,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (220,11)-(220,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,12)-(220,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (220,13)-(220,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,14)-(220,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (220,16)-(220,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,17)-(220,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (220,18)-(220,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,19)-(220,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (220,20)-(220,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,22)-(220,47) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (220,48)-(220,62) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (220,62)-(220,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,63)-(220,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (221,1)-(221,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first39 = true;
            #line (222,6)-(222,36) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.RepeatedSeparatorFirst)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("    ");
                #line (223,5)-(223,7) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (223,7)-(223,8) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,8)-(223,10) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (223,10)-(223,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,11)-(223,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (223,12)-(223,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,14)-(223,44) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (223,45)-(223,59) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (224,5)-(224,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (225,10)-(225,81) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (226,5)-(226,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (227,5)-(227,9) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (228,5)-(228,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (229,10)-(229,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (229,18)-(229,87) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (229,87)-(229,88) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (229,89)-(229,93) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (229,94)-(229,105) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (229,106)-(229,137) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (229,138)-(229,141) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (230,5)-(230,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (231,6)-(231,67) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (232,6)-(232,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("    ");
                #line (233,6)-(233,67) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (234,5)-(234,7) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (234,7)-(234,8) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (234,8)-(234,10) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (234,10)-(234,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (234,11)-(234,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (234,12)-(234,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (234,14)-(234,44) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (234,45)-(234,59) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (235,5)-(235,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (236,10)-(236,81) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (237,5)-(237,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (238,5)-(238,9) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (239,5)-(239,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (240,10)-(240,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (240,18)-(240,87) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (240,87)-(240,88) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (240,89)-(240,93) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (240,94)-(240,105) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (240,106)-(240,137) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (240,138)-(240,141) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (241,5)-(241,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            __cb.Push("");
            #line (243,1)-(243,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first40 = true;
            #line (244,6)-(244,81) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.LastItems.Count && i < sl.LastSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                var __first41 = true;
                #line (245,10)-(245,40) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.RepeatedSeparatorFirst)
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    __cb.Push("");
                    #line (246,2)-(246,68) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (247,2)-(247,64) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (248,10)-(248,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    __cb.Push("");
                    #line (249,2)-(249,64) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (250,2)-(250,68) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first41) __cb.AppendLine();
            }
            if (!__first40) __cb.AppendLine();
            var __first42 = true;
            #line (253,6)-(253,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastItems.Count > sl.LastSeparators.Count)
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                __cb.Push("");
                #line (254,2)-(254,77) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[sl.LastItems.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first42) __cb.AppendLine();
            var __first43 = true;
            #line (256,6)-(256,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastSeparators.Count > sl.LastItems.Count)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                __cb.Push("");
                #line (257,2)-(257,92) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[sl.LastSeparators.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            __cb.Push("");
            #line (259,1)-(259,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (259,4)-(259,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,6)-(259,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (259,25)-(259,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,26)-(259,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (259,27)-(259,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,29)-(259,36) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (259,37)-(259,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".ToList();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (260,1)-(260,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (260,13)-(260,20) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (260,21)-(260,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (263,9)-(263,70) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (264,1)-(264,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (264,4)-(264,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,6)-(264,20) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (264,21)-(264,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (264,28)-(264,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,29)-(264,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (264,30)-(264,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,31)-(264,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (264,40)-(264,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (264,55)-(264,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (265,1)-(265,3) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (265,3)-(265,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,4)-(265,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (265,6)-(265,20) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (265,21)-(265,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (265,28)-(265,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,29)-(265,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (265,31)-(265,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,32)-(265,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (265,35)-(265,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,36)-(265,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (265,41)-(265,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,43)-(265,50) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (265,51)-(265,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (265,58)-(265,78) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (265,79)-(265,92) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(");
            #line hidden
            #line (265,93)-(265,107) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (265,108)-(265,116) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context)");
            #line hidden
            #line (265,116)-(265,117) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,117)-(265,119) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (265,119)-(265,120) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,121)-(265,141) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (265,142)-(265,154) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first44 = true;
            #line (266,6)-(266,42) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                __cb.Push("");
                #line (267,1)-(267,5) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (267,5)-(267,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,7)-(267,14) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (267,15)-(267,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (267,21)-(267,41) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (267,42)-(267,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (271,9)-(271,75) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (272,1)-(272,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (272,4)-(272,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,5)-(272,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separatorContext");
            #line hidden
            #line (272,22)-(272,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,23)-(272,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (272,24)-(272,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,25)-(272,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (272,34)-(272,48) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (272,49)-(272,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first45 = true;
            #line (273,6)-(273,41) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.Push("");
                #line (274,1)-(274,3) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (274,3)-(274,4) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (274,4)-(274,5) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (274,6)-(274,20) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (274,21)-(274,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (274,28)-(274,29) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (274,29)-(274,31) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (274,31)-(274,32) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (274,32)-(274,35) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (274,35)-(274,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (274,36)-(274,41) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (274,41)-(274,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (274,43)-(274,50) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (274,51)-(274,106) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (274,107)-(274,121) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (274,122)-(274,132) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (275,6)-(275,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.Push("");
                #line (276,2)-(276,9) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (276,10)-(276,65) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (276,66)-(276,80) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (276,81)-(276,89) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context,");
                #line hidden
                #line (276,89)-(276,90) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (276,91)-(276,95) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (276,96)-(276,107) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (276,108)-(276,123) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (276,124)-(276,127) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first45) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (280,9)-(280,84) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (281,1)-(281,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (281,4)-(281,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,5)-(281,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_item");
            #line hidden
            #line (281,10)-(281,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,11)-(281,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (281,12)-(281,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,14)-(281,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (281,29)-(281,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (281,37)-(281,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (281,42)-(281,47) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (281,49)-(281,52) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (281,53)-(281,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (282,1)-(282,3) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (282,3)-(282,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (282,4)-(282,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(_item");
            #line hidden
            #line (282,10)-(282,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (282,11)-(282,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (282,13)-(282,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (282,14)-(282,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (282,17)-(282,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (282,18)-(282,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (282,23)-(282,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (282,25)-(282,32) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (282,33)-(282,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (282,40)-(282,60) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (282,61)-(282,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(_item)");
            #line hidden
            #line (282,80)-(282,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (282,81)-(282,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (282,83)-(282,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (282,85)-(282,105) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (282,106)-(282,118) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first46 = true;
            #line (283,6)-(283,42) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("");
                #line (284,1)-(284,5) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (284,5)-(284,6) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (284,7)-(284,14) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (284,15)-(284,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (284,21)-(284,41) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (284,42)-(284,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (288,9)-(288,89) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (289,1)-(289,4) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (289,4)-(289,5) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,5)-(289,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separator");
            #line hidden
            #line (289,15)-(289,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,16)-(289,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (289,17)-(289,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,19)-(289,33) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (289,34)-(289,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (289,42)-(289,45) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (289,47)-(289,52) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (289,54)-(289,57) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (289,58)-(289,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first47 = true;
            #line (290,6)-(290,41) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("");
                #line (291,1)-(291,3) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (291,3)-(291,4) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,4)-(291,5) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (291,6)-(291,20) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (291,21)-(291,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (291,28)-(291,29) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,29)-(291,31) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (291,31)-(291,32) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,32)-(291,35) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (291,35)-(291,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,36)-(291,41) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (291,41)-(291,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,43)-(291,50) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (291,51)-(291,119) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (292,6)-(292,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("");
                #line (293,2)-(293,9) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (293,10)-(293,76) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator,");
                #line hidden
                #line (293,76)-(293,77) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (293,78)-(293,82) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (293,83)-(293,94) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (293,95)-(293,110) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (293,111)-(293,114) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (297,9)-(297,46) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateAntlrInternalSyntaxFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (298,1)-(298,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (298,6)-(298,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (298,7)-(298,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (299,1)-(299,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (299,6)-(299,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,7)-(299,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (300,1)-(300,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (300,6)-(300,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (300,7)-(300,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (301,1)-(301,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (301,6)-(301,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,7)-(301,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (302,1)-(302,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (302,6)-(302,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,7)-(302,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (304,1)-(304,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (304,10)-(304,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,11)-(304,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (306,1)-(306,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (306,10)-(306,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,12)-(306,21) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (306,22)-(306,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (307,1)-(307,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (308,5)-(308,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (308,11)-(308,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,12)-(308,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (308,19)-(308,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,20)-(308,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (308,25)-(308,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,27)-(308,31) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (308,32)-(308,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (308,53)-(308,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,54)-(308,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (308,55)-(308,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,56)-(308,75) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (309,5)-(309,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (310,6)-(310,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (310,16)-(310,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,17)-(310,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream");
            #line hidden
            #line (310,65)-(310,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,66)-(310,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("input)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (311,6)-(311,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (312,10)-(312,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (312,16)-(312,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,17)-(312,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (312,20)-(312,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,22)-(312,26) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (312,27)-(312,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (313,6)-(313,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (315,6)-(315,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrParser");
            #line hidden
            #line (315,17)-(315,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (315,18)-(315,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream");
            #line hidden
            #line (315,68)-(315,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (315,69)-(315,75) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("input)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (316,6)-(316,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t        ");
            #line (317,10)-(317,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (317,16)-(317,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,17)-(317,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (317,20)-(317,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,22)-(317,26) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (317,27)-(317,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("\t    ");
            #line (318,6)-(318,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (319,5)-(319,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (320,1)-(320,2) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}