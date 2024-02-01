#line (1,10)-(1,54) 10 "AntlrSyntaxGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler3.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "AntlrSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,45) 13 "AntlrSyntaxGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler3.Model;
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
            var __first25 = true;
            #line (136,18)-(136,54) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var rule in RulesAndBlocks)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                var __first26 = true;
                #line (137,22)-(137,60) 17 "AntlrSyntaxGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("            ");
                    #line (138,26)-(138,47) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitAlt(alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
            }
            if (!__first25) __cb.AppendLine();
            __cb.Push("        ");
            #line (141,13)-(141,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (142,9)-(142,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (143,5)-(143,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (146,9)-(146,43) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitAlt(Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (148,5)-(148,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (148,11)-(148,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,12)-(148,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (148,20)-(148,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,21)-(148,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("GreenNode?");
            #line hidden
            #line (148,31)-(148,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,32)-(148,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Visit");
            #line hidden
            #line (148,38)-(148,66) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.AntlrName.ToPascalCase());
            #line hidden
            #line (148,67)-(148,68) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (148,69)-(148,73) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (148,74)-(148,81) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser.");
            #line hidden
            #line (148,82)-(148,110) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.AntlrName.ToPascalCase());
            #line hidden
            #line (148,111)-(148,119) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context?");
            #line hidden
            #line (148,119)-(148,120) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,120)-(148,128) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (149,5)-(149,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (150,9)-(150,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (150,11)-(150,12) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,12)-(150,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(context");
            #line hidden
            #line (150,20)-(150,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,21)-(150,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (150,23)-(150,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,24)-(150,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (150,29)-(150,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,30)-(150,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (150,36)-(150,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,38)-(150,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.GreenName);
            #line hidden
            #line (150,52)-(150,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first27 = true;
            #line (151,10)-(151,44) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                var __first28 = true;
                #line (152,14)-(152,49) 17 "AntlrSyntaxGenerator.mxg"
                if (elem.Value is SeparatedList sl)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("    ");
                    #line (153,18)-(153,54) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedList(elem, sl));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (154,14)-(154,56) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value.Multiplicity.IsList())
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("    ");
                    #line (155,18)-(155,41) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitList(elem));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (156,14)-(156,57) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is TokenAlts tokenAlts)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("    ");
                    #line (157,18)-(157,57) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitTokenAlts(elem, tokenAlts));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (158,14)-(158,41) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is Eof)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("    ");
                    #line (159,17)-(159,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (159,20)-(159,21) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,22)-(159,40) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (159,41)-(159,42) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,42)-(159,43) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (159,43)-(159,44) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,44)-(159,93) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                    #line hidden
                    #line (159,94)-(159,108) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (159,109)-(159,110) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (159,110)-(159,111) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,112)-(159,116) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (159,117)-(159,133) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("SyntaxKind.Eof);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (160,14)-(160,47) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is Block blk)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("    ");
                    #line (161,18)-(161,31) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(blk.GreenType);
                    #line hidden
                    #line (161,32)-(161,33) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("?");
                    #line hidden
                    #line (161,33)-(161,34) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,35)-(161,53) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (161,54)-(161,55) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,55)-(161,56) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (161,56)-(161,57) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,57)-(161,62) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("null;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (162,17)-(162,19) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (162,19)-(162,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,20)-(162,29) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(context.");
                    #line hidden
                    #line (162,30)-(162,44) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (162,45)-(162,46) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,46)-(162,48) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("is");
                    #line hidden
                    #line (162,48)-(162,49) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,49)-(162,52) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("not");
                    #line hidden
                    #line (162,52)-(162,53) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,53)-(162,58) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("null)");
                    #line hidden
                    #line (162,58)-(162,59) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,60)-(162,78) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (162,79)-(162,80) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,80)-(162,81) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (162,81)-(162,82) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (162,82)-(162,83) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (162,84)-(162,97) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(blk.GreenType);
                    #line hidden
                    #line (162,98)-(162,119) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("?)this.Visit(context.");
                    #line hidden
                    #line (162,120)-(162,134) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (162,135)-(162,136) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    var __first29 = true;
                    #line (162,137)-(162,179) 21 "AntlrSyntaxGenerator.mxg"
                    if (!elem.Value.Multiplicity.IsOptional())
                    #line hidden
                    
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        #line (162,180)-(162,181) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (162,181)-(162,183) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("??");
                        #line hidden
                        #line (162,183)-(162,184) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (162,185)-(162,198) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(blk.GreenType);
                        #line hidden
                        #line (162,199)-(162,209) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(".__Missing");
                        #line hidden
                    }
                    #line (162,217)-(162,218) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    var __first30 = true;
                    #line (163,18)-(163,60) 21 "AntlrSyntaxGenerator.mxg"
                    if (!elem.Value.Multiplicity.IsOptional())
                    #line hidden
                    
                    {
                        if (__first30)
                        {
                            __first30 = false;
                        }
                        __cb.Push("    ");
                        #line (164,21)-(164,25) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (164,25)-(164,26) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (164,27)-(164,45) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (164,46)-(164,47) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (164,47)-(164,48) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (164,48)-(164,49) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (164,50)-(164,63) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(blk.GreenType);
                        #line hidden
                        #line (164,64)-(164,75) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(".__Missing;");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first30) __cb.AppendLine();
                }
                #line (166,14)-(166,48) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is RuleRef rr)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    var __first31 = true;
                    #line (167,18)-(167,43) 21 "AntlrSyntaxGenerator.mxg"
                    if (rr.Token is not null)
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        __cb.Push("    ");
                        #line (168,21)-(168,24) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (168,24)-(168,25) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,26)-(168,44) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (168,45)-(168,46) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,46)-(168,47) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (168,47)-(168,48) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,48)-(168,97) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                        #line hidden
                        #line (168,98)-(168,112) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        var __first32 = true;
                        #line (168,114)-(168,156) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first32)
                            {
                                __first32 = false;
                            }
                            #line (168,157)-(168,158) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (168,158)-(168,159) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (168,160)-(168,164) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(Lang);
                            #line hidden
                            #line (168,165)-(168,176) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("SyntaxKind.");
                            #line hidden
                            #line (168,177)-(168,196) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.Token.CSharpName);
                            #line hidden
                        }
                        #line (168,205)-(168,207) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (169,18)-(169,46) 21 "AntlrSyntaxGenerator.mxg"
                    else if(rr.Rule is not null)
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        __cb.Push("    ");
                        #line (170,22)-(170,34) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(rr.GreenType);
                        #line hidden
                        #line (170,35)-(170,36) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("?");
                        #line hidden
                        #line (170,36)-(170,37) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,38)-(170,56) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (170,57)-(170,58) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,58)-(170,59) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (170,59)-(170,60) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,60)-(170,65) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("null;");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (171,21)-(171,23) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (171,23)-(171,24) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,24)-(171,33) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(context.");
                        #line hidden
                        #line (171,34)-(171,48) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        #line (171,49)-(171,50) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,50)-(171,52) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("is");
                        #line hidden
                        #line (171,52)-(171,53) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,53)-(171,56) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("not");
                        #line hidden
                        #line (171,56)-(171,57) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,57)-(171,62) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("null)");
                        #line hidden
                        #line (171,62)-(171,63) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,64)-(171,82) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (171,83)-(171,84) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,84)-(171,85) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (171,85)-(171,86) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,86)-(171,87) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (171,88)-(171,100) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(rr.GreenType);
                        #line hidden
                        #line (171,101)-(171,122) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("?)this.Visit(context.");
                        #line hidden
                        #line (171,123)-(171,137) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        #line (171,138)-(171,139) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        var __first33 = true;
                        #line (171,140)-(171,182) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first33)
                            {
                                __first33 = false;
                            }
                            #line (171,183)-(171,184) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (171,184)-(171,186) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("??");
                            #line hidden
                            #line (171,186)-(171,187) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (171,188)-(171,200) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.GreenType);
                            #line hidden
                            #line (171,201)-(171,211) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(".__Missing");
                            #line hidden
                        }
                        #line (171,219)-(171,220) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        var __first34 = true;
                        #line (172,22)-(172,64) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first34)
                            {
                                __first34 = false;
                            }
                            __cb.Push("    ");
                            #line (173,25)-(173,29) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (173,29)-(173,30) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (173,31)-(173,49) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(elem.ParameterName);
                            #line hidden
                            #line (173,50)-(173,51) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (173,51)-(173,52) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (173,52)-(173,53) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (173,54)-(173,66) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.GreenType);
                            #line hidden
                            #line (173,67)-(173,78) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(".__Missing;");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        if (!__first34) __cb.AppendLine();
                    }
                    #line (175,18)-(175,22) 21 "AntlrSyntaxGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                    }
                    if (!__first31) __cb.AppendLine();
                }
                if (!__first28) __cb.AppendLine();
            }
            if (!__first27) __cb.AppendLine();
            __cb.Push("    ");
            #line (179,9)-(179,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (179,15)-(179,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,16)-(179,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory.");
            #line hidden
            #line (179,26)-(179,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (179,41)-(179,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (179,43)-(179,67) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.GreenUpdateArguments);
            #line hidden
            #line (179,68)-(179,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (180,5)-(180,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (183,9)-(183,67) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitTokenAlts(Element elem, TokenAlts tokenAlts)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (184,5)-(184,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxToken?");
            #line hidden
            #line (184,25)-(184,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,27)-(184,45) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (184,46)-(184,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,47)-(184,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (184,48)-(184,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,49)-(184,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first35 = true;
            #line (185,6)-(185,45) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var token in tokenAlts.Tokens)
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                __cb.Push("");
                #line (186,9)-(186,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (186,11)-(186,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,12)-(186,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(context.");
                #line hidden
                #line (186,22)-(186,43) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (186,44)-(186,46) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("()");
                #line hidden
                #line (186,46)-(186,47) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,47)-(186,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (186,49)-(186,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,50)-(186,53) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (186,53)-(186,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,54)-(186,59) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (186,59)-(186,60) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,61)-(186,79) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (186,80)-(186,81) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,81)-(186,82) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (186,82)-(186,83) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,83)-(186,132) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                #line hidden
                #line (186,133)-(186,154) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (186,155)-(186,159) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("());");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first35) __cb.AppendLine();
            var __first36 = true;
            #line (188,6)-(188,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("");
                #line (189,9)-(189,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (189,11)-(189,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (189,12)-(189,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (189,14)-(189,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (189,33)-(189,34) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (189,34)-(189,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (189,36)-(189,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (189,37)-(189,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (189,42)-(189,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (189,44)-(189,62) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (189,63)-(189,64) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (189,64)-(189,65) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (189,65)-(189,66) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (189,66)-(189,80) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("_factory.None;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (193,9)-(193,41) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitList(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (194,5)-(194,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (194,8)-(194,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,10)-(194,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (194,25)-(194,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (194,32)-(194,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,33)-(194,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (194,34)-(194,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,35)-(194,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (194,45)-(194,59) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (194,60)-(194,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (195,5)-(195,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (195,8)-(195,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,10)-(195,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (195,29)-(195,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder");
            #line hidden
            #line (195,36)-(195,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,37)-(195,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (195,38)-(195,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,39)-(195,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Allocate<");
            #line hidden
            #line (195,55)-(195,75) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (195,76)-(195,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (196,5)-(196,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (196,8)-(196,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,9)-(196,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (196,13)-(196,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,14)-(196,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (196,15)-(196,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,16)-(196,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (196,17)-(196,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,18)-(196,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (196,20)-(196,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,21)-(196,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (196,22)-(196,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,23)-(196,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (196,24)-(196,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,26)-(196,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (196,41)-(196,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (196,55)-(196,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,56)-(196,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (197,5)-(197,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (198,10)-(198,26) 13 "AntlrSyntaxGenerator.mxg"
            if(elem.IsToken)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (199,14)-(199,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (199,33)-(199,86) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (199,87)-(199,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (199,102)-(199,109) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (199,110)-(199,115) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (199,116)-(199,119) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (200,10)-(200,14) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (201,13)-(201,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (201,15)-(201,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,16)-(201,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (201,18)-(201,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (201,33)-(201,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (201,41)-(201,46) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (201,47)-(201,48) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,48)-(201,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (201,50)-(201,51) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,51)-(201,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (201,54)-(201,55) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,55)-(201,60) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (201,60)-(201,61) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,62)-(201,80) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (201,81)-(201,94) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((");
                #line hidden
                #line (201,95)-(201,115) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (201,116)-(201,129) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("?)this.Visit(");
                #line hidden
                #line (201,130)-(201,144) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (201,145)-(201,152) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (201,153)-(201,158) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (201,159)-(201,160) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (201,160)-(201,161) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,161)-(201,163) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("??");
                #line hidden
                #line (201,163)-(201,164) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,165)-(201,185) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (201,186)-(201,198) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (202,13)-(202,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (202,17)-(202,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,19)-(202,37) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (202,38)-(202,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add(");
                #line hidden
                #line (202,51)-(202,71) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (202,72)-(202,84) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (204,5)-(204,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (205,5)-(205,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (205,8)-(205,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,10)-(205,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (205,29)-(205,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,30)-(205,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (205,31)-(205,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,33)-(205,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (205,52)-(205,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder.ToList();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (206,5)-(206,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (206,17)-(206,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (206,36)-(206,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (209,9)-(209,68) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedList(Element elem, SeparatedList sl)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (210,6)-(210,48) 13 "AntlrSyntaxGenerator.mxg"
            var builder = elem.ParameterName+"Builder";
            #line hidden
            
            __cb.Push("");
            #line (211,5)-(211,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (211,8)-(211,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,10)-(211,17) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (211,18)-(211,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,19)-(211,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (211,20)-(211,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,21)-(211,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.AllocateSeparated<");
            #line hidden
            #line (211,46)-(211,58) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.GreenType);
            #line hidden
            #line (211,59)-(211,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">(reversed:");
            #line hidden
            #line (211,70)-(211,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,72)-(211,108) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.SeparatorFirst ? "true" : "false");
            #line hidden
            #line (211,109)-(211,111) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (212,6)-(212,83) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.FirstItems.Count && i < sl.FirstSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                var __first39 = true;
                #line (213,10)-(213,32) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.SeparatorFirst)
                #line hidden
                
                {
                    if (__first39)
                    {
                        __first39 = false;
                    }
                    __cb.Push("");
                    #line (214,14)-(214,81) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (215,14)-(215,71) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (216,10)-(216,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first39)
                    {
                        __first39 = false;
                    }
                    __cb.Push("");
                    #line (217,14)-(217,71) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (218,14)-(218,81) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first39) __cb.AppendLine();
            }
            if (!__first38) __cb.AppendLine();
            var __first40 = true;
            #line (221,6)-(221,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstItems.Count > sl.FirstSeparators.Count)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("");
                #line (222,10)-(222,87) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[sl.FirstItems.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first40) __cb.AppendLine();
            var __first41 = true;
            #line (224,6)-(224,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstSeparators.Count > sl.FirstItems.Count)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("");
                #line (225,10)-(225,102) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[sl.FirstSeparators.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("");
            #line (227,5)-(227,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (227,8)-(227,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,10)-(227,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (227,36)-(227,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (227,43)-(227,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,44)-(227,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (227,45)-(227,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,46)-(227,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (227,56)-(227,81) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (227,82)-(227,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (228,5)-(228,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (228,8)-(228,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,10)-(228,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (228,41)-(228,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (228,48)-(228,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,49)-(228,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (228,50)-(228,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,51)-(228,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (228,61)-(228,91) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (228,92)-(228,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (229,5)-(229,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (229,8)-(229,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,9)-(229,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (229,13)-(229,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,14)-(229,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (229,15)-(229,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,16)-(229,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (229,17)-(229,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,18)-(229,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (229,20)-(229,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,21)-(229,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (229,22)-(229,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,23)-(229,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (229,24)-(229,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,26)-(229,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (229,52)-(229,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (229,66)-(229,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,67)-(229,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (230,5)-(230,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first42 = true;
            #line (231,10)-(231,40) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.RepeatedSeparatorFirst)
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                __cb.Push("    ");
                #line (232,13)-(232,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (232,15)-(232,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (232,16)-(232,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (232,18)-(232,19) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (232,19)-(232,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (232,20)-(232,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (232,22)-(232,52) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (232,53)-(232,67) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (233,13)-(233,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (234,18)-(234,89) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (235,13)-(235,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (236,13)-(236,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (237,13)-(237,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (238,18)-(238,25) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (238,26)-(238,95) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (238,95)-(238,96) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (238,97)-(238,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (238,102)-(238,113) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (238,114)-(238,145) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (238,146)-(238,149) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (239,13)-(239,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (240,14)-(240,75) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (241,10)-(241,14) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                __cb.Push("    ");
                #line (242,14)-(242,75) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (243,13)-(243,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (243,15)-(243,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,16)-(243,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (243,18)-(243,19) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,19)-(243,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (243,20)-(243,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,22)-(243,52) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (243,53)-(243,67) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (244,13)-(244,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (245,18)-(245,89) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (246,13)-(246,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (247,13)-(247,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (248,13)-(248,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (249,18)-(249,25) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (249,26)-(249,95) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (249,95)-(249,96) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (249,97)-(249,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (249,102)-(249,113) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (249,114)-(249,145) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (249,146)-(249,149) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (250,13)-(250,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first42) __cb.AppendLine();
            __cb.Push("");
            #line (252,5)-(252,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first43 = true;
            #line (253,6)-(253,81) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.LastItems.Count && i < sl.LastSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                var __first44 = true;
                #line (254,10)-(254,40) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.RepeatedSeparatorFirst)
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    __cb.Push("");
                    #line (255,14)-(255,80) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (256,14)-(256,76) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (257,10)-(257,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    __cb.Push("");
                    #line (258,14)-(258,76) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (259,14)-(259,80) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first44) __cb.AppendLine();
            }
            if (!__first43) __cb.AppendLine();
            var __first45 = true;
            #line (262,6)-(262,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastItems.Count > sl.LastSeparators.Count)
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.Push("");
                #line (263,10)-(263,85) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[sl.LastItems.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first45) __cb.AppendLine();
            var __first46 = true;
            #line (265,6)-(265,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastSeparators.Count > sl.LastItems.Count)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("");
                #line (266,10)-(266,100) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[sl.LastSeparators.Count-1], builder));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            __cb.Push("");
            #line (268,5)-(268,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (268,8)-(268,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,10)-(268,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (268,29)-(268,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,30)-(268,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (268,31)-(268,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,33)-(268,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (268,41)-(268,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".ToList();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (269,5)-(269,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (269,17)-(269,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (269,25)-(269,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (272,9)-(272,70) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (273,5)-(273,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (273,8)-(273,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,10)-(273,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (273,25)-(273,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (273,32)-(273,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,33)-(273,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (273,34)-(273,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,35)-(273,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (273,44)-(273,58) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (273,59)-(273,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (274,5)-(274,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (274,7)-(274,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,8)-(274,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (274,10)-(274,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (274,25)-(274,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (274,32)-(274,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,33)-(274,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (274,35)-(274,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,36)-(274,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (274,39)-(274,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,40)-(274,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (274,45)-(274,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,47)-(274,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (274,55)-(274,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (274,62)-(274,82) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (274,83)-(274,96) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(");
            #line hidden
            #line (274,97)-(274,111) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (274,112)-(274,120) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context)");
            #line hidden
            #line (274,120)-(274,121) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,121)-(274,123) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (274,123)-(274,124) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,125)-(274,145) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (274,146)-(274,158) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first47 = true;
            #line (275,6)-(275,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("");
                #line (276,9)-(276,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (276,13)-(276,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (276,15)-(276,22) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (276,23)-(276,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (276,29)-(276,49) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (276,50)-(276,62) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (280,9)-(280,75) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (281,5)-(281,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (281,8)-(281,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,9)-(281,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separatorContext");
            #line hidden
            #line (281,26)-(281,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,27)-(281,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (281,28)-(281,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,29)-(281,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (281,38)-(281,52) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (281,53)-(281,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first48 = true;
            #line (282,6)-(282,47) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first48)
                {
                    __first48 = false;
                }
                __cb.Push("");
                #line (283,9)-(283,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (283,11)-(283,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,12)-(283,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (283,14)-(283,28) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (283,29)-(283,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (283,36)-(283,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,37)-(283,39) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (283,39)-(283,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,40)-(283,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (283,43)-(283,44) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,44)-(283,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (283,49)-(283,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (283,51)-(283,58) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (283,59)-(283,114) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (283,115)-(283,129) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (283,130)-(283,140) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (284,6)-(284,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first48)
                {
                    __first48 = false;
                }
                __cb.Push("");
                #line (285,10)-(285,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (285,18)-(285,73) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (285,74)-(285,88) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (285,89)-(285,97) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context,");
                #line hidden
                #line (285,97)-(285,98) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (285,99)-(285,103) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (285,104)-(285,115) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (285,116)-(285,131) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (285,132)-(285,135) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first48) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (289,9)-(289,84) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (290,5)-(290,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (290,8)-(290,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (290,9)-(290,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_item");
            #line hidden
            #line (290,14)-(290,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (290,15)-(290,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (290,16)-(290,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (290,18)-(290,32) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (290,33)-(290,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (290,41)-(290,44) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (290,46)-(290,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (290,53)-(290,56) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (290,57)-(290,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (291,5)-(291,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (291,7)-(291,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,8)-(291,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(_item");
            #line hidden
            #line (291,14)-(291,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,15)-(291,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (291,17)-(291,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,18)-(291,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (291,21)-(291,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,22)-(291,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (291,27)-(291,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,29)-(291,36) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (291,37)-(291,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (291,44)-(291,64) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (291,65)-(291,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(_item)");
            #line hidden
            #line (291,84)-(291,85) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,85)-(291,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (291,87)-(291,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,89)-(291,109) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (291,110)-(291,122) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first49 = true;
            #line (292,6)-(292,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("");
                #line (293,9)-(293,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (293,13)-(293,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (293,15)-(293,22) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (293,23)-(293,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (293,29)-(293,49) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (293,50)-(293,62) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first49) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (297,9)-(297,89) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (298,5)-(298,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (298,8)-(298,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (298,9)-(298,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separator");
            #line hidden
            #line (298,19)-(298,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (298,20)-(298,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (298,21)-(298,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (298,23)-(298,37) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (298,38)-(298,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (298,46)-(298,49) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (298,51)-(298,56) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (298,58)-(298,61) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (298,62)-(298,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first50 = true;
            #line (299,6)-(299,47) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.Push("");
                #line (300,9)-(300,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (300,11)-(300,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (300,12)-(300,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (300,14)-(300,28) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (300,29)-(300,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (300,36)-(300,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (300,37)-(300,39) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (300,39)-(300,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (300,40)-(300,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (300,43)-(300,44) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (300,44)-(300,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (300,49)-(300,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (300,51)-(300,58) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (300,59)-(300,127) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (301,6)-(301,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.Push("");
                #line (302,10)-(302,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (302,18)-(302,84) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator,");
                #line hidden
                #line (302,84)-(302,85) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (302,86)-(302,90) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (302,91)-(302,102) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (302,103)-(302,118) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (302,119)-(302,122) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first50) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (306,9)-(306,46) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateAntlrInternalSyntaxFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (307,5)-(307,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (307,10)-(307,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,11)-(307,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (308,5)-(308,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (308,10)-(308,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (308,11)-(308,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (309,5)-(309,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (309,10)-(309,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,11)-(309,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (310,5)-(310,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (310,10)-(310,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,11)-(310,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (311,5)-(311,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (311,10)-(311,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,11)-(311,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (313,5)-(313,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (313,14)-(313,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,15)-(313,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (315,5)-(315,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (315,14)-(315,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (315,16)-(315,25) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (315,26)-(315,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (316,5)-(316,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (317,9)-(317,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (317,15)-(317,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,16)-(317,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (317,23)-(317,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,24)-(317,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (317,29)-(317,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,31)-(317,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (317,36)-(317,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (317,57)-(317,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,58)-(317,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (317,59)-(317,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,60)-(317,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (318,9)-(318,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (319,13)-(319,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (319,23)-(319,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (319,24)-(319,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream");
            #line hidden
            #line (319,72)-(319,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (319,73)-(319,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("input)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (320,13)-(320,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (321,17)-(321,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (321,23)-(321,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,24)-(321,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (321,27)-(321,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,29)-(321,33) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (321,34)-(321,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (322,13)-(322,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (324,13)-(324,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrParser");
            #line hidden
            #line (324,24)-(324,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (324,25)-(324,75) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream");
            #line hidden
            #line (324,75)-(324,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (324,76)-(324,82) 25 "AntlrSyntaxGenerator.mxg"
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
            #line (326,34)-(326,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser(input);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (327,13)-(327,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (328,9)-(328,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (329,5)-(329,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}