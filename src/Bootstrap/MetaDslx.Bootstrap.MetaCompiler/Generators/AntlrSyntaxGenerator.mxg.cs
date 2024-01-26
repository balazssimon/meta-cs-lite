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
            #line (13,5)-(13,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,10)-(13,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,11)-(13,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,5)-(14,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,10)-(14,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,11)-(14,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,5)-(15,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,10)-(15,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,11)-(15,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,5)-(16,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (16,10)-(16,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,11)-(16,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,5)-(17,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (17,10)-(17,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,5)-(19,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (19,14)-(19,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,15)-(19,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (21,5)-(21,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (21,14)-(21,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,16)-(21,25) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (21,26)-(21,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (22,5)-(22,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,9)-(23,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (23,15)-(23,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,16)-(23,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (23,23)-(23,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,24)-(23,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (23,29)-(23,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,31)-(23,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (23,36)-(23,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer");
            #line hidden
            #line (23,47)-(23,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,48)-(23,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (23,49)-(23,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,50)-(23,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrSyntaxLexer");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,9)-(24,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,13)-(25,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (25,19)-(25,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,21)-(25,25) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (25,26)-(25,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer(SourceText");
            #line hidden
            #line (25,48)-(25,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,49)-(25,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("text,");
            #line hidden
            #line (25,54)-(25,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,56)-(25,60) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (25,61)-(25,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParseOptions");
            #line hidden
            #line (25,73)-(25,74) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,74)-(25,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("options)");
            #line hidden
            #line (25,82)-(25,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (26,17)-(26,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (26,18)-(26,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,19)-(26,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("base(text,");
            #line hidden
            #line (26,29)-(26,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,30)-(26,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("options)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,13)-(27,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,13)-(28,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (30,13)-(30,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (30,22)-(30,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,23)-(30,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (30,26)-(30,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,28)-(30,32) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (30,33)-(30,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer");
            #line hidden
            #line (30,38)-(30,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,39)-(30,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (30,49)-(30,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,50)-(30,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (30,52)-(30,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,53)-(30,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (30,55)-(30,59) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (30,60)-(30,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer)base.AntlrLexer;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,9)-(32,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,5)-(33,6) 25 "AntlrSyntaxGenerator.mxg"
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
            #line (37,5)-(37,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (37,10)-(37,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,11)-(37,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (38,5)-(38,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (38,10)-(38,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,11)-(38,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Diagnostics;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,5)-(39,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,10)-(39,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,11)-(39,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (40,5)-(40,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (40,10)-(40,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,11)-(40,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (41,5)-(41,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (41,10)-(41,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,11)-(41,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (42,5)-(42,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (42,10)-(42,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,11)-(42,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("System.Threading.Tasks;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (43,5)-(43,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (43,10)-(43,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,11)-(43,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,5)-(44,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (44,10)-(44,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,11)-(44,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime.Tree;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,5)-(45,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (45,10)-(45,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,11)-(45,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (46,5)-(46,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (46,10)-(46,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,11)-(46,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (47,5)-(47,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (47,10)-(47,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,11)-(47,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (48,5)-(48,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (48,10)-(48,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,11)-(48,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Text;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (49,5)-(49,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (49,10)-(49,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,11)-(49,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (50,5)-(50,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (50,10)-(50,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,12)-(50,21) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (50,22)-(50,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (52,5)-(52,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (52,14)-(52,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,15)-(52,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (54,5)-(54,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (54,14)-(54,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,16)-(54,25) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (54,26)-(54,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (55,5)-(55,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (56,9)-(56,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (56,15)-(56,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,16)-(56,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (56,23)-(56,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,24)-(56,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (56,29)-(56,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,31)-(56,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (56,36)-(56,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (56,48)-(56,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,49)-(56,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (56,50)-(56,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,51)-(56,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrSyntaxParser");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (57,9)-(57,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (58,13)-(58,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (58,20)-(58,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,21)-(58,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (58,29)-(58,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,30)-(58,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor");
            #line hidden
            #line (58,50)-(58,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,51)-(58,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_visitor;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (60,13)-(60,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (60,19)-(60,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,21)-(60,25) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (60,26)-(60,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (61,18)-(61,22) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (61,23)-(61,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxLexer");
            #line hidden
            #line (61,34)-(61,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,35)-(61,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("lexer,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (62,17)-(62,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IncrementalParseData?");
            #line hidden
            #line (62,38)-(62,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,39)-(62,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("oldParseData,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (63,17)-(63,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IEnumerable<TextChangeRange>");
            #line hidden
            #line (63,45)-(63,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,46)-(63,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("changes,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (64,17)-(64,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("CancellationToken");
            #line hidden
            #line (64,34)-(64,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,35)-(64,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("cancellationToken");
            #line hidden
            #line (64,52)-(64,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,53)-(64,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (64,54)-(64,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,55)-(64,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("default)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (65,17)-(65,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (65,18)-(65,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,19)-(65,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("base(lexer,");
            #line hidden
            #line (65,30)-(65,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,31)-(65,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("oldParseData,");
            #line hidden
            #line (65,44)-(65,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,45)-(65,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("changes,");
            #line hidden
            #line (65,53)-(65,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,54)-(65,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,13)-(66,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (67,17)-(67,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_visitor");
            #line hidden
            #line (67,25)-(67,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,26)-(67,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,27)-(67,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,28)-(67,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (67,31)-(67,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,32)-(67,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (68,13)-(68,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,13)-(70,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (70,22)-(70,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,23)-(70,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (70,26)-(70,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,28)-(70,32) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (70,33)-(70,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser");
            #line hidden
            #line (70,39)-(70,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,40)-(70,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrParser");
            #line hidden
            #line (70,51)-(70,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,52)-(70,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (70,54)-(70,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,55)-(70,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (70,57)-(70,61) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (70,62)-(70,86) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser)base.AntlrParser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,13)-(72,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (72,22)-(72,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,23)-(72,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (72,31)-(72,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,32)-(72,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxNode");
            #line hidden
            #line (72,42)-(72,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,43)-(72,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParseRoot()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,13)-(73,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (74,17)-(74,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParserState?");
            #line hidden
            #line (74,29)-(74,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,30)-(74,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("state");
            #line hidden
            #line (74,35)-(74,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,36)-(74,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,37)-(74,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,38)-(74,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (75,17)-(75,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (75,27)-(75,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,28)-(75,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green");
            #line hidden
            #line (75,33)-(75,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,34)-(75,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (75,35)-(75,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,36)-(75,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("this.Parse");
            #line hidden
            #line (75,47)-(75,67) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.CSharpName);
            #line hidden
            #line (75,68)-(75,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(ref");
            #line hidden
            #line (75,72)-(75,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,73)-(75,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("state);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (76,17)-(76,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (76,20)-(76,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,21)-(76,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("red");
            #line hidden
            #line (76,24)-(76,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,25)-(76,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,26)-(76,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,27)-(76,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (76,29)-(76,33) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (76,34)-(76,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxNode)green!.CreateRed();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (77,17)-(77,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (77,23)-(77,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,24)-(77,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("red;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,13)-(78,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,13)-(80,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (80,20)-(80,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,21)-(80,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (80,31)-(80,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,32)-(80,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parse");
            #line hidden
            #line (80,38)-(80,58) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.CSharpName);
            #line hidden
            #line (80,59)-(80,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(ref");
            #line hidden
            #line (80,63)-(80,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,64)-(80,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParserState?");
            #line hidden
            #line (80,76)-(80,77) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,77)-(80,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("state)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,13)-(81,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (82,17)-(82,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (82,23)-(82,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,24)-(82,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_visitor.Visit");
            #line hidden
            #line (82,39)-(82,74) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.AntlrName?.ToPascalCase());
            #line hidden
            #line (82,75)-(82,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(AntlrParser.");
            #line hidden
            #line (82,89)-(82,108) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(MainRule?.AntlrName);
            #line hidden
            #line (82,109)-(82,113) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("());");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,13)-(83,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,13)-(85,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (85,20)-(85,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,21)-(85,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (85,26)-(85,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,27)-(85,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor");
            #line hidden
            #line (85,47)-(85,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,48)-(85,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (85,49)-(85,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,51)-(85,55) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (85,56)-(85,85) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("ParserBaseVisitor<GreenNode?>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (86,13)-(86,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (87,17)-(87,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (87,19)-(87,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,20)-(87,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("list");
            #line hidden
            #line (87,24)-(87,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,25)-(87,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("pools");
            #line hidden
            #line (87,30)-(87,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,31)-(87,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("-");
            #line hidden
            #line (87,32)-(87,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,33)-(87,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("allocators");
            #line hidden
            #line (87,43)-(87,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,44)-(87,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (87,47)-(87,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,48)-(87,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("lists");
            #line hidden
            #line (87,53)-(87,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,54)-(87,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("that");
            #line hidden
            #line (87,58)-(87,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,59)-(87,62) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("are");
            #line hidden
            #line (87,62)-(87,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,63)-(87,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("used");
            #line hidden
            #line (87,67)-(87,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,68)-(87,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (87,70)-(87,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,71)-(87,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("build");
            #line hidden
            #line (87,76)-(87,77) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,77)-(87,86) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("sequences");
            #line hidden
            #line (87,86)-(87,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,87)-(87,89) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (87,89)-(87,90) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,90)-(87,96) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("nodes.");
            #line hidden
            #line (87,96)-(87,97) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,97)-(87,100) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (87,100)-(87,101) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,101)-(87,106) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("lists");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (88,17)-(88,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (88,19)-(88,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,20)-(88,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("can");
            #line hidden
            #line (88,23)-(88,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,24)-(88,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("be");
            #line hidden
            #line (88,26)-(88,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,27)-(88,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("reused");
            #line hidden
            #line (88,33)-(88,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,34)-(88,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(hence");
            #line hidden
            #line (88,40)-(88,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,41)-(88,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("pooled)");
            #line hidden
            #line (88,48)-(88,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,49)-(88,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("since");
            #line hidden
            #line (88,54)-(88,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,55)-(88,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (88,58)-(88,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,59)-(88,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("syntax");
            #line hidden
            #line (88,65)-(88,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,66)-(88,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("factory");
            #line hidden
            #line (88,73)-(88,74) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,74)-(88,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("methods");
            #line hidden
            #line (88,81)-(88,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,82)-(88,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("don't");
            #line hidden
            #line (88,87)-(88,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,88)-(88,92) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("keep");
            #line hidden
            #line (88,92)-(88,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,93)-(88,103) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("references");
            #line hidden
            #line (88,103)-(88,104) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,104)-(88,106) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (89,17)-(89,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (89,19)-(89,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,20)-(89,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("them");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (90,17)-(90,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (90,24)-(90,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,25)-(90,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (90,33)-(90,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,34)-(90,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxListPool");
            #line hidden
            #line (90,48)-(90,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,49)-(90,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool");
            #line hidden
            #line (90,54)-(90,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,55)-(90,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (90,56)-(90,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,57)-(90,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (90,60)-(90,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,61)-(90,78) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxListPool();");
            #line hidden
            #line (90,78)-(90,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,79)-(90,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (90,81)-(90,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,82)-(90,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Don't");
            #line hidden
            #line (90,87)-(90,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,88)-(90,92) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("need");
            #line hidden
            #line (90,92)-(90,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,93)-(90,95) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (90,95)-(90,96) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,96)-(90,101) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("reset");
            #line hidden
            #line (90,101)-(90,102) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,102)-(90,107) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("this.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (92,17)-(92,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (92,24)-(92,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,25)-(92,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (92,33)-(92,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,35)-(92,39) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (92,40)-(92,52) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (92,52)-(92,53) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,53)-(92,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (93,17)-(93,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (93,24)-(93,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,25)-(93,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (93,33)-(93,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,34)-(93,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrTokenStream");
            #line hidden
            #line (93,50)-(93,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,51)-(93,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (94,17)-(94,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (94,24)-(94,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,25)-(94,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (94,33)-(94,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,35)-(94,39) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (94,40)-(94,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (94,61)-(94,62) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,62)-(94,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (96,17)-(96,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (96,23)-(96,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,24)-(96,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrToRoslynVisitor(");
            #line hidden
            #line (96,46)-(96,50) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (96,51)-(96,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxParser");
            #line hidden
            #line (96,63)-(96,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,64)-(96,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("parser)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (97,17)-(97,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (98,21)-(98,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser");
            #line hidden
            #line (98,28)-(98,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,29)-(98,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (98,30)-(98,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,31)-(98,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (99,21)-(99,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream");
            #line hidden
            #line (99,33)-(99,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,34)-(99,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (99,35)-(99,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,36)-(99,86) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(AntlrTokenStream)_parser.AntlrParser.InputStream;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (100,21)-(100,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory");
            #line hidden
            #line (100,29)-(100,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,30)-(100,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (100,31)-(100,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,32)-(100,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (100,34)-(100,38) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (100,39)-(100,100) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory)_parser.Language.InternalSyntaxFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (101,17)-(101,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (103,17)-(103,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (103,24)-(103,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,25)-(103,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (103,35)-(103,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,36)-(103,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(IToken?");
            #line hidden
            #line (103,57)-(103,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,58)-(103,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("token,");
            #line hidden
            #line (103,64)-(103,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,66)-(103,70) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (103,71)-(103,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (103,81)-(103,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,82)-(103,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (104,17)-(104,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (105,21)-(105,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (105,23)-(105,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,24)-(105,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(token");
            #line hidden
            #line (105,30)-(105,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,31)-(105,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (105,33)-(105,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,34)-(105,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (106,21)-(106,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (107,25)-(107,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (107,27)-(107,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,28)-(107,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(kind");
            #line hidden
            #line (107,33)-(107,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,34)-(107,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (107,36)-(107,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,38)-(107,42) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (107,43)-(107,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None)");
            #line hidden
            #line (107,59)-(107,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,60)-(107,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (107,66)-(107,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,67)-(107,126) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream.ConsumeGreenToken(_factory.MissingToken(kind),");
            #line hidden
            #line (107,126)-(107,127) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,127)-(107,136) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (108,25)-(108,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (108,29)-(108,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,30)-(108,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (108,36)-(108,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,37)-(108,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (109,21)-(109,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (110,21)-(110,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (110,24)-(110,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,25)-(110,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green");
            #line hidden
            #line (110,30)-(110,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,31)-(110,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (110,32)-(110,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,33)-(110,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream.ConsumeGreenToken(token,");
            #line hidden
            #line (110,70)-(110,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,71)-(110,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (111,21)-(111,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Debug.Assert(kind");
            #line hidden
            #line (111,38)-(111,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,39)-(111,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (111,41)-(111,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,43)-(111,47) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (111,48)-(111,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None");
            #line hidden
            #line (111,63)-(111,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,64)-(111,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("||");
            #line hidden
            #line (111,66)-(111,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,67)-(111,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green.RawKind");
            #line hidden
            #line (111,80)-(111,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,81)-(111,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (111,83)-(111,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,84)-(111,95) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (112,21)-(112,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (112,27)-(112,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,28)-(112,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (113,17)-(113,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (115,17)-(115,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (115,23)-(115,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,24)-(115,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (115,34)-(115,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,35)-(115,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(IToken?");
            #line hidden
            #line (115,56)-(115,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,57)-(115,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("token)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (116,17)-(116,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (117,21)-(117,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (117,27)-(117,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,28)-(117,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(token,");
            #line hidden
            #line (117,48)-(117,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,50)-(117,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (117,55)-(117,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (118,17)-(118,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (120,17)-(120,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (120,24)-(120,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,25)-(120,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (120,35)-(120,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,36)-(120,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(ITerminalNode?");
            #line hidden
            #line (120,64)-(120,65) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,65)-(120,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("node,");
            #line hidden
            #line (120,70)-(120,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,72)-(120,76) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (120,77)-(120,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind");
            #line hidden
            #line (120,87)-(120,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,88)-(120,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("kind)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (121,17)-(121,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (122,21)-(122,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (122,23)-(122,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,24)-(122,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(node?.Symbol");
            #line hidden
            #line (122,37)-(122,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,38)-(122,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (122,40)-(122,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,41)-(122,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (123,21)-(123,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (124,25)-(124,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (124,27)-(124,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,28)-(124,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(kind");
            #line hidden
            #line (124,33)-(124,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,34)-(124,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("!=");
            #line hidden
            #line (124,36)-(124,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,38)-(124,42) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (124,43)-(124,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None)");
            #line hidden
            #line (124,59)-(124,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,60)-(124,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (124,66)-(124,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,67)-(124,95) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory.MissingToken(kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (125,25)-(125,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("else");
            #line hidden
            #line (125,29)-(125,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,30)-(125,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (125,36)-(125,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,37)-(125,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (126,21)-(126,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (127,21)-(127,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (127,24)-(127,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,25)-(127,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green");
            #line hidden
            #line (127,30)-(127,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,31)-(127,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (127,32)-(127,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,33)-(127,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream.ConsumeGreenToken(node.Symbol,");
            #line hidden
            #line (127,76)-(127,77) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,77)-(127,86) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (128,21)-(128,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Debug.Assert(kind");
            #line hidden
            #line (128,38)-(128,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,39)-(128,41) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (128,41)-(128,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,43)-(128,47) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (128,48)-(128,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None");
            #line hidden
            #line (128,63)-(128,64) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,64)-(128,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("||");
            #line hidden
            #line (128,66)-(128,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,67)-(128,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green.RawKind");
            #line hidden
            #line (128,80)-(128,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,81)-(128,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (128,83)-(128,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,84)-(128,95) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int)kind);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (129,21)-(129,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (129,27)-(129,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,28)-(129,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("green;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (130,17)-(130,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (132,17)-(132,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (132,23)-(132,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,24)-(132,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (132,32)-(132,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,33)-(132,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (132,43)-(132,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,44)-(132,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(ITerminalNode?");
            #line hidden
            #line (132,72)-(132,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,73)-(132,78) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (133,17)-(133,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (134,21)-(134,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (134,27)-(134,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,28)-(134,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("VisitTerminal(node,");
            #line hidden
            #line (134,47)-(134,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,49)-(134,53) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (134,54)-(134,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("SyntaxKind.None);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (135,17)-(135,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first26 = true;
            #line (136,18)-(136,45) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                var __first27 = true;
                #line (137,22)-(137,60) 17 "AntlrSyntaxGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    __cb.Push("            ");
                    #line (138,26)-(138,47) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitAlt(alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first27) __cb.AppendLine();
            }
            if (!__first26) __cb.AppendLine();
            var __first28 = true;
            #line (141,18)-(141,47) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var block in Blocks)
            #line hidden
            
            {
                if (__first28)
                {
                    __first28 = false;
                }
                var __first29 = true;
                #line (142,22)-(142,61) 17 "AntlrSyntaxGenerator.mxg"
                foreach (var alt in block.Alternatives)
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("            ");
                    #line (143,26)-(143,47) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitAlt(alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first29) __cb.AppendLine();
            }
            if (!__first28) __cb.AppendLine();
            __cb.Push("        ");
            #line (146,13)-(146,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (147,9)-(147,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (148,5)-(148,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (151,9)-(151,43) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitAlt(Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (153,5)-(153,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (153,11)-(153,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,12)-(153,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (153,20)-(153,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,21)-(153,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (153,31)-(153,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,32)-(153,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Visit");
            #line hidden
            #line (153,38)-(153,66) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.AntlrName.ToPascalCase());
            #line hidden
            #line (153,67)-(153,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (153,69)-(153,73) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (153,74)-(153,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser.");
            #line hidden
            #line (153,82)-(153,110) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.AntlrName.ToPascalCase());
            #line hidden
            #line (153,111)-(153,119) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context?");
            #line hidden
            #line (153,119)-(153,120) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,120)-(153,128) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (154,5)-(154,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (155,9)-(155,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (155,11)-(155,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,12)-(155,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(context");
            #line hidden
            #line (155,20)-(155,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,21)-(155,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (155,23)-(155,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,24)-(155,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (155,29)-(155,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,30)-(155,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (155,36)-(155,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,38)-(155,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (155,52)-(155,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first30 = true;
            #line (156,10)-(156,44) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                var __first31 = true;
                #line (157,14)-(157,49) 17 "AntlrSyntaxGenerator.mxg"
                if (elem.Value is SeparatedList sl)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("    ");
                    #line (158,18)-(158,54) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedList(elem, sl));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (159,14)-(159,56) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value.Multiplicity.IsList())
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("    ");
                    #line (160,18)-(160,41) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitList(elem));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (161,14)-(161,57) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is TokenAlts tokenAlts)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("    ");
                    #line (162,18)-(162,57) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitTokenAlts(elem, tokenAlts));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (163,14)-(163,41) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is Eof)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("    ");
                    #line (164,17)-(164,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (164,20)-(164,21) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (164,22)-(164,40) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (164,41)-(164,42) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (164,42)-(164,43) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (164,43)-(164,44) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (164,44)-(164,93) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                    #line hidden
                    #line (164,94)-(164,108) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (164,109)-(164,110) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (164,110)-(164,111) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (164,112)-(164,116) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (164,117)-(164,133) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("SyntaxKind.Eof);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (165,14)-(165,47) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is Block blk)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("    ");
                    #line (166,18)-(166,31) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(blk.GreenType);
                    #line hidden
                    #line (166,32)-(166,33) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("?");
                    #line hidden
                    #line (166,33)-(166,34) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,35)-(166,53) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (166,54)-(166,55) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,55)-(166,56) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (166,56)-(166,57) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,57)-(166,62) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("null;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (167,17)-(167,19) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (167,19)-(167,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,20)-(167,29) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(context.");
                    #line hidden
                    #line (167,30)-(167,44) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (167,45)-(167,46) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,46)-(167,48) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("is");
                    #line hidden
                    #line (167,48)-(167,49) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,49)-(167,52) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("not");
                    #line hidden
                    #line (167,52)-(167,53) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,53)-(167,58) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("null)");
                    #line hidden
                    #line (167,58)-(167,59) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,60)-(167,78) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (167,79)-(167,80) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,80)-(167,81) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (167,81)-(167,82) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,82)-(167,83) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (167,84)-(167,97) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(blk.GreenType);
                    #line hidden
                    #line (167,98)-(167,119) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("?)this.Visit(context.");
                    #line hidden
                    #line (167,120)-(167,134) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (167,135)-(167,136) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    var __first32 = true;
                    #line (167,137)-(167,179) 21 "AntlrSyntaxGenerator.mxg"
                    if (!elem.Value.Multiplicity.IsOptional())
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        #line (167,180)-(167,181) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,181)-(167,183) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("??");
                        #line hidden
                        #line (167,183)-(167,184) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,185)-(167,198) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(blk.GreenType);
                        #line hidden
                        #line (167,199)-(167,209) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(".__Missing");
                        #line hidden
                    }
                    #line (167,217)-(167,218) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    var __first33 = true;
                    #line (168,18)-(168,60) 21 "AntlrSyntaxGenerator.mxg"
                    if (!elem.Value.Multiplicity.IsOptional())
                    #line hidden
                    
                    {
                        if (__first33)
                        {
                            __first33 = false;
                        }
                        __cb.Push("    ");
                        #line (169,21)-(169,25) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (169,25)-(169,26) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,27)-(169,45) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (169,46)-(169,47) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,47)-(169,48) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (169,48)-(169,49) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,50)-(169,63) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(blk.GreenType);
                        #line hidden
                        #line (169,64)-(169,75) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(".__Missing;");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first33) __cb.AppendLine();
                }
                #line (171,14)-(171,48) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is RuleRef rr)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    var __first34 = true;
                    #line (172,18)-(172,43) 21 "AntlrSyntaxGenerator.mxg"
                    if (rr.Token is not null)
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        __cb.Push("    ");
                        #line (173,21)-(173,24) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (173,24)-(173,25) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (173,26)-(173,44) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (173,45)-(173,46) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (173,46)-(173,47) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (173,47)-(173,48) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (173,48)-(173,97) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                        #line hidden
                        #line (173,98)-(173,112) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        var __first35 = true;
                        #line (173,114)-(173,156) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first35)
                            {
                                __first35 = false;
                            }
                            #line (173,157)-(173,158) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (173,158)-(173,159) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (173,160)-(173,164) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(Lang);
                            #line hidden
                            #line (173,165)-(173,176) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("SyntaxKind.");
                            #line hidden
                            #line (173,177)-(173,196) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.Token.CSharpName);
                            #line hidden
                        }
                        #line (173,205)-(173,207) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (174,18)-(174,46) 21 "AntlrSyntaxGenerator.mxg"
                    else if(rr.Rule is not null)
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        __cb.Push("    ");
                        #line (175,22)-(175,34) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(rr.GreenType);
                        #line hidden
                        #line (175,35)-(175,36) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("?");
                        #line hidden
                        #line (175,36)-(175,37) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,38)-(175,56) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (175,57)-(175,58) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,58)-(175,59) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (175,59)-(175,60) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,60)-(175,65) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("null;");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (176,21)-(176,23) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (176,23)-(176,24) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,24)-(176,33) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(context.");
                        #line hidden
                        #line (176,34)-(176,48) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        #line (176,49)-(176,50) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,50)-(176,52) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("is");
                        #line hidden
                        #line (176,52)-(176,53) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,53)-(176,56) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("not");
                        #line hidden
                        #line (176,56)-(176,57) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,57)-(176,62) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("null)");
                        #line hidden
                        #line (176,62)-(176,63) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,64)-(176,82) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (176,83)-(176,84) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,84)-(176,85) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (176,85)-(176,86) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (176,86)-(176,87) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (176,88)-(176,100) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(rr.GreenType);
                        #line hidden
                        #line (176,101)-(176,122) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("?)this.Visit(context.");
                        #line hidden
                        #line (176,123)-(176,137) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        #line (176,138)-(176,139) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        var __first36 = true;
                        #line (176,140)-(176,182) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first36)
                            {
                                __first36 = false;
                            }
                            #line (176,183)-(176,184) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (176,184)-(176,186) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("??");
                            #line hidden
                            #line (176,186)-(176,187) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (176,188)-(176,200) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.GreenType);
                            #line hidden
                            #line (176,201)-(176,211) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(".__Missing");
                            #line hidden
                        }
                        #line (176,219)-(176,220) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        var __first37 = true;
                        #line (177,22)-(177,64) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first37)
                            {
                                __first37 = false;
                            }
                            __cb.Push("    ");
                            #line (178,25)-(178,29) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (178,29)-(178,30) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (178,31)-(178,49) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(elem.ParameterName);
                            #line hidden
                            #line (178,50)-(178,51) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (178,51)-(178,52) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (178,52)-(178,53) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (178,54)-(178,66) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.GreenType);
                            #line hidden
                            #line (178,67)-(178,78) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(".__Missing;");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        if (!__first37) __cb.AppendLine();
                    }
                    #line (180,18)-(180,22) 21 "AntlrSyntaxGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                    }
                    if (!__first34) __cb.AppendLine();
                }
                if (!__first31) __cb.AppendLine();
            }
            if (!__first30) __cb.AppendLine();
            __cb.Push("    ");
            #line (184,9)-(184,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (184,15)-(184,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,16)-(184,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory.");
            #line hidden
            #line (184,26)-(184,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (184,41)-(184,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (184,43)-(184,67) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.GreenUpdateArguments);
            #line hidden
            #line (184,68)-(184,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (185,5)-(185,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (188,9)-(188,67) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitTokenAlts(Element elem, TokenAlts tokenAlts)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (189,5)-(189,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxToken?");
            #line hidden
            #line (189,25)-(189,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,27)-(189,45) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (189,46)-(189,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,47)-(189,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (189,48)-(189,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,49)-(189,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (190,6)-(190,45) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var token in tokenAlts.Tokens)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("");
                #line (191,9)-(191,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (191,11)-(191,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,12)-(191,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(context.");
                #line hidden
                #line (191,22)-(191,43) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (191,44)-(191,46) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("()");
                #line hidden
                #line (191,46)-(191,47) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,47)-(191,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (191,49)-(191,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,50)-(191,53) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (191,53)-(191,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,54)-(191,59) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (191,59)-(191,60) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,61)-(191,79) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (191,80)-(191,81) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,81)-(191,82) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (191,82)-(191,83) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,83)-(191,132) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                #line hidden
                #line (191,133)-(191,154) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (191,155)-(191,159) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("());");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            var __first39 = true;
            #line (193,6)-(193,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("");
                #line (194,9)-(194,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (194,11)-(194,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (194,12)-(194,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (194,14)-(194,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (194,33)-(194,34) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (194,34)-(194,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (194,36)-(194,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (194,37)-(194,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (194,42)-(194,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (194,44)-(194,62) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (194,63)-(194,64) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (194,64)-(194,65) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (194,65)-(194,66) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (194,66)-(194,80) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("_factory.None;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (198,9)-(198,41) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitList(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (199,5)-(199,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (199,8)-(199,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,10)-(199,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (199,25)-(199,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (199,32)-(199,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,33)-(199,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (199,34)-(199,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,35)-(199,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (199,45)-(199,59) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (199,60)-(199,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (200,5)-(200,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (200,8)-(200,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,10)-(200,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (200,29)-(200,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder");
            #line hidden
            #line (200,36)-(200,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,37)-(200,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (200,38)-(200,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,39)-(200,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Allocate<");
            #line hidden
            #line (200,55)-(200,75) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (200,76)-(200,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (201,5)-(201,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (201,8)-(201,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,9)-(201,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (201,13)-(201,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,14)-(201,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (201,15)-(201,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,16)-(201,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (201,17)-(201,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,18)-(201,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (201,20)-(201,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,21)-(201,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (201,22)-(201,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,23)-(201,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (201,24)-(201,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,26)-(201,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (201,41)-(201,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (201,55)-(201,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,56)-(201,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (202,5)-(202,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first40 = true;
            #line (203,10)-(203,26) 13 "AntlrSyntaxGenerator.mxg"
            if(elem.IsToken)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("    ");
                #line (204,14)-(204,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (204,33)-(204,86) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (204,87)-(204,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (204,102)-(204,109) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (204,110)-(204,115) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (204,116)-(204,119) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (205,10)-(205,14) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("    ");
                #line (206,13)-(206,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (206,15)-(206,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,16)-(206,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (206,18)-(206,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (206,33)-(206,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (206,41)-(206,46) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (206,47)-(206,48) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,48)-(206,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (206,50)-(206,51) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,51)-(206,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (206,54)-(206,55) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,55)-(206,60) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (206,60)-(206,61) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,62)-(206,80) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (206,81)-(206,94) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((");
                #line hidden
                #line (206,95)-(206,115) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (206,116)-(206,129) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("?)this.Visit(");
                #line hidden
                #line (206,130)-(206,144) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (206,145)-(206,152) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (206,153)-(206,158) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (206,159)-(206,160) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (206,160)-(206,161) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,161)-(206,163) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("??");
                #line hidden
                #line (206,163)-(206,164) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,165)-(206,185) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (206,186)-(206,198) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (207,13)-(207,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (207,17)-(207,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (207,19)-(207,37) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (207,38)-(207,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add(");
                #line hidden
                #line (207,51)-(207,71) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (207,72)-(207,84) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first40) __cb.AppendLine();
            __cb.Push("");
            #line (209,5)-(209,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (210,5)-(210,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (210,8)-(210,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,10)-(210,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (210,29)-(210,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,30)-(210,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (210,31)-(210,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,33)-(210,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (210,52)-(210,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder.ToList();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (211,5)-(211,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (211,17)-(211,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (211,36)-(211,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (214,9)-(214,68) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedList(Element elem, SeparatedList sl)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (215,6)-(215,48) 13 "AntlrSyntaxGenerator.mxg"
            var builder = elem.ParameterName+"Builder";
            #line hidden
            
            __cb.Push("");
            #line (216,5)-(216,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (216,8)-(216,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,10)-(216,17) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (216,18)-(216,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,19)-(216,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (216,20)-(216,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,21)-(216,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.AllocateSeparated<");
            #line hidden
            #line (216,46)-(216,58) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.GreenType);
            #line hidden
            #line (216,59)-(216,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">(reversed:");
            #line hidden
            #line (216,70)-(216,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,72)-(216,108) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.SeparatorFirst ? "true" : "false");
            #line hidden
            #line (216,109)-(216,111) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first41 = true;
            #line (217,6)-(217,83) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.FirstItems.Count && i < sl.FirstSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                var __first42 = true;
                #line (218,10)-(218,32) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.SeparatorFirst)
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (219,14)-(219,81) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (220,14)-(220,71) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (221,10)-(221,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("");
                    #line (222,14)-(222,71) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (223,14)-(223,81) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first42) __cb.AppendLine();
            }
            if (!__first41) __cb.AppendLine();
            var __first43 = true;
            #line (226,6)-(226,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstItems.Count > sl.FirstSeparators.Count)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                __cb.Push("");
                #line (227,10)-(227,87) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[sl.FirstItems.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            var __first44 = true;
            #line (229,6)-(229,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstSeparators.Count > sl.FirstItems.Count)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                __cb.Push("");
                #line (230,10)-(230,102) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[sl.FirstSeparators.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            __cb.Push("");
            #line (232,5)-(232,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (232,8)-(232,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,10)-(232,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (232,36)-(232,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (232,43)-(232,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,44)-(232,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (232,45)-(232,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,46)-(232,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (232,56)-(232,81) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (232,82)-(232,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (233,5)-(233,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (233,8)-(233,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,10)-(233,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (233,41)-(233,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (233,48)-(233,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,49)-(233,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (233,50)-(233,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,51)-(233,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (233,61)-(233,91) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (233,92)-(233,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (234,5)-(234,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (234,8)-(234,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,9)-(234,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (234,13)-(234,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,14)-(234,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (234,15)-(234,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,16)-(234,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (234,17)-(234,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,18)-(234,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (234,20)-(234,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,21)-(234,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (234,22)-(234,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,23)-(234,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (234,24)-(234,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,26)-(234,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (234,52)-(234,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (234,66)-(234,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (234,67)-(234,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (235,5)-(235,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first45 = true;
            #line (236,10)-(236,40) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.RepeatedSeparatorFirst)
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.Push("    ");
                #line (237,13)-(237,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (237,15)-(237,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (237,16)-(237,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (237,18)-(237,19) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (237,19)-(237,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (237,20)-(237,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (237,22)-(237,52) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (237,53)-(237,67) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (238,13)-(238,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (239,18)-(239,89) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (240,13)-(240,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (241,13)-(241,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (242,13)-(242,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (243,18)-(243,25) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (243,26)-(243,95) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (243,95)-(243,96) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,97)-(243,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (243,102)-(243,113) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (243,114)-(243,145) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (243,146)-(243,149) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (244,13)-(244,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (245,14)-(245,75) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (246,10)-(246,14) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.Push("    ");
                #line (247,14)-(247,75) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (248,13)-(248,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (248,15)-(248,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (248,16)-(248,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (248,18)-(248,19) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (248,19)-(248,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (248,20)-(248,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (248,22)-(248,52) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (248,53)-(248,67) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (249,13)-(249,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (250,18)-(250,89) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (251,13)-(251,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (252,13)-(252,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (253,13)-(253,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (254,18)-(254,25) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (254,26)-(254,95) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (254,95)-(254,96) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (254,97)-(254,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (254,102)-(254,113) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (254,114)-(254,145) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (254,146)-(254,149) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (255,13)-(255,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first45) __cb.AppendLine();
            __cb.Push("");
            #line (257,5)-(257,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first46 = true;
            #line (258,6)-(258,81) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.LastItems.Count && i < sl.LastSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                var __first47 = true;
                #line (259,10)-(259,40) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.RepeatedSeparatorFirst)
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
                    }
                    __cb.Push("");
                    #line (260,14)-(260,80) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (261,14)-(261,76) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (262,10)-(262,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
                    }
                    __cb.Push("");
                    #line (263,14)-(263,76) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (264,14)-(264,80) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first47) __cb.AppendLine();
            }
            if (!__first46) __cb.AppendLine();
            var __first48 = true;
            #line (267,6)-(267,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastItems.Count > sl.LastSeparators.Count)
            #line hidden
            
            {
                if (__first48)
                {
                    __first48 = false;
                }
                __cb.Push("");
                #line (268,10)-(268,85) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[sl.LastItems.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first48) __cb.AppendLine();
            var __first49 = true;
            #line (270,6)-(270,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastSeparators.Count > sl.LastItems.Count)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("");
                #line (271,10)-(271,100) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[sl.LastSeparators.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first49) __cb.AppendLine();
            __cb.Push("");
            #line (273,5)-(273,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (273,8)-(273,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,10)-(273,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (273,29)-(273,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,30)-(273,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (273,31)-(273,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,33)-(273,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (273,41)-(273,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".ToList();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (274,5)-(274,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (274,17)-(274,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (274,25)-(274,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (277,9)-(277,70) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (278,5)-(278,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (278,8)-(278,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,10)-(278,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (278,25)-(278,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (278,32)-(278,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,33)-(278,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (278,34)-(278,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,35)-(278,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (278,44)-(278,58) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (278,59)-(278,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (279,5)-(279,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (279,7)-(279,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,8)-(279,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (279,10)-(279,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (279,25)-(279,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (279,32)-(279,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,33)-(279,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (279,35)-(279,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,36)-(279,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (279,39)-(279,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,40)-(279,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (279,45)-(279,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,47)-(279,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (279,55)-(279,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (279,62)-(279,82) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (279,83)-(279,96) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(");
            #line hidden
            #line (279,97)-(279,111) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (279,112)-(279,120) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context)");
            #line hidden
            #line (279,120)-(279,121) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,121)-(279,123) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (279,123)-(279,124) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,125)-(279,145) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (279,146)-(279,158) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first50 = true;
            #line (280,6)-(280,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.Push("");
                #line (281,9)-(281,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (281,13)-(281,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (281,15)-(281,22) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (281,23)-(281,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (281,29)-(281,49) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (281,50)-(281,62) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first50) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (285,9)-(285,75) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (286,5)-(286,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (286,8)-(286,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,9)-(286,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separatorContext");
            #line hidden
            #line (286,26)-(286,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,27)-(286,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (286,28)-(286,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,29)-(286,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (286,38)-(286,52) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (286,53)-(286,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first51 = true;
            #line (287,6)-(287,47) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("");
                #line (288,9)-(288,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (288,11)-(288,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,12)-(288,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (288,14)-(288,28) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (288,29)-(288,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (288,36)-(288,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,37)-(288,39) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (288,39)-(288,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,40)-(288,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (288,43)-(288,44) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,44)-(288,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (288,49)-(288,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,51)-(288,58) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (288,59)-(288,114) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (288,115)-(288,129) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (288,130)-(288,140) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (289,6)-(289,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("");
                #line (290,10)-(290,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (290,18)-(290,73) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (290,74)-(290,88) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (290,89)-(290,97) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context,");
                #line hidden
                #line (290,97)-(290,98) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (290,99)-(290,103) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (290,104)-(290,115) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (290,116)-(290,131) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (290,132)-(290,135) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (294,9)-(294,84) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (295,5)-(295,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (295,8)-(295,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,9)-(295,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_item");
            #line hidden
            #line (295,14)-(295,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,15)-(295,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (295,16)-(295,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,18)-(295,32) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (295,33)-(295,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (295,41)-(295,44) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (295,46)-(295,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (295,53)-(295,56) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (295,57)-(295,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (296,5)-(296,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (296,7)-(296,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,8)-(296,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(_item");
            #line hidden
            #line (296,14)-(296,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,15)-(296,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (296,17)-(296,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,18)-(296,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (296,21)-(296,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,22)-(296,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (296,27)-(296,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,29)-(296,36) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (296,37)-(296,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (296,44)-(296,64) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (296,65)-(296,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(_item)");
            #line hidden
            #line (296,84)-(296,85) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,85)-(296,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (296,87)-(296,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,89)-(296,109) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (296,110)-(296,122) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first52 = true;
            #line (297,6)-(297,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                __cb.Push("");
                #line (298,9)-(298,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (298,13)-(298,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (298,15)-(298,22) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (298,23)-(298,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (298,29)-(298,49) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (298,50)-(298,62) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first52) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (302,9)-(302,89) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (303,5)-(303,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (303,8)-(303,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,9)-(303,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separator");
            #line hidden
            #line (303,19)-(303,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,20)-(303,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (303,21)-(303,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,23)-(303,37) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (303,38)-(303,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (303,46)-(303,49) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (303,51)-(303,56) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (303,58)-(303,61) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (303,62)-(303,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first53 = true;
            #line (304,6)-(304,47) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first53)
                {
                    __first53 = false;
                }
                __cb.Push("");
                #line (305,9)-(305,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (305,11)-(305,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (305,12)-(305,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (305,14)-(305,28) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (305,29)-(305,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (305,36)-(305,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (305,37)-(305,39) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (305,39)-(305,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (305,40)-(305,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (305,43)-(305,44) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (305,44)-(305,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (305,49)-(305,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (305,51)-(305,58) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (305,59)-(305,127) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (306,6)-(306,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first53)
                {
                    __first53 = false;
                }
                __cb.Push("");
                #line (307,10)-(307,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (307,18)-(307,84) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator,");
                #line hidden
                #line (307,84)-(307,85) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (307,86)-(307,90) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (307,91)-(307,102) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (307,103)-(307,118) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (307,119)-(307,122) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first53) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (311,9)-(311,46) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateAntlrInternalSyntaxFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (312,5)-(312,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (312,10)-(312,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,11)-(312,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (313,5)-(313,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (313,10)-(313,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,11)-(313,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (314,5)-(314,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (314,10)-(314,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (314,11)-(314,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (315,5)-(315,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (315,10)-(315,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (315,11)-(315,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (316,5)-(316,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (316,10)-(316,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (316,11)-(316,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (318,5)-(318,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (318,14)-(318,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (318,15)-(318,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (320,5)-(320,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (320,14)-(320,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (320,16)-(320,25) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (320,26)-(320,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (321,5)-(321,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (322,9)-(322,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (322,15)-(322,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,16)-(322,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (322,23)-(322,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,24)-(322,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (322,29)-(322,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,31)-(322,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (322,36)-(322,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (322,57)-(322,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,58)-(322,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (322,59)-(322,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,60)-(322,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (323,9)-(323,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (324,13)-(324,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (324,23)-(324,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (324,24)-(324,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream");
            #line hidden
            #line (324,72)-(324,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (324,73)-(324,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("input)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (325,13)-(325,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (326,17)-(326,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (326,23)-(326,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,24)-(326,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (326,27)-(326,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,29)-(326,33) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (326,34)-(326,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (327,13)-(327,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (329,13)-(329,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrParser");
            #line hidden
            #line (329,24)-(329,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,25)-(329,75) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream");
            #line hidden
            #line (329,75)-(329,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,76)-(329,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("input)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (330,13)-(330,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (331,17)-(331,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (331,23)-(331,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,24)-(331,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (331,27)-(331,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,29)-(331,33) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (331,34)-(331,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (332,13)-(332,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (333,9)-(333,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (334,5)-(334,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}