#line (1,10)-(1,53) 10 "AntlrSyntaxGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler3.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "AntlrSyntaxGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "AntlrSyntaxGenerator.mxg"
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (22,5)-(22,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,9)-(24,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,13)-(27,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,13)-(28,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,9)-(32,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,5)-(33,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (55,5)-(55,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (57,9)-(57,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,13)-(66,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (68,13)-(68,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,13)-(73,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,13)-(78,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,13)-(81,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,13)-(83,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (86,13)-(86,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (97,17)-(97,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (101,17)-(101,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (104,17)-(104,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (106,21)-(106,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (109,21)-(109,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (113,17)-(113,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (116,17)-(116,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (118,17)-(118,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (121,17)-(121,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (123,21)-(123,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            #line (124,67)-(124,126) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_tokenStream.ConsumeGreenToken(_factory.MissingToken(kind),");
            #line hidden
            #line (124,126)-(124,127) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,127)-(124,136) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_parser);");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (126,21)-(126,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (130,17)-(130,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (133,17)-(133,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (135,17)-(135,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
            }
            if (!__first25) __cb.AppendLine();
            __cb.Push("        ");
            #line (141,13)-(141,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (142,9)-(142,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (143,5)-(143,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (149,5)-(149,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first27 = true;
            #line (150,10)-(150,76) 13 "AntlrSyntaxGenerator.mxg"
            if (alt.Elements.Count == 1 && alt.Elements[0].Value is TokenAlts)
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                __cb.Push("    ");
                #line (151,13)-(151,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (151,15)-(151,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,16)-(151,26) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(context?.");
                #line hidden
                #line (151,27)-(151,52) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(alt.Elements[0].AntlrName);
                #line hidden
                #line (151,53)-(151,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,54)-(151,56) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (151,56)-(151,57) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,57)-(151,62) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (151,62)-(151,63) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,63)-(151,69) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (151,69)-(151,70) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,71)-(151,84) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(alt.GreenName);
                #line hidden
                #line (151,85)-(151,96) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (152,10)-(152,14) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                __cb.Push("    ");
                #line (153,13)-(153,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (153,15)-(153,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,16)-(153,24) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(context");
                #line hidden
                #line (153,24)-(153,25) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,25)-(153,27) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (153,27)-(153,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,28)-(153,33) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (153,33)-(153,34) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,34)-(153,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (153,40)-(153,41) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,42)-(153,55) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(alt.GreenName);
                #line hidden
                #line (153,56)-(153,67) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first27) __cb.AppendLine();
            var __first28 = true;
            #line (155,10)-(155,44) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var elem in alt.Elements)
            #line hidden
            
            {
                if (__first28)
                {
                    __first28 = false;
                }
                var __first29 = true;
                #line (156,14)-(156,49) 17 "AntlrSyntaxGenerator.mxg"
                if (elem.Value is SeparatedList sl)
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("    ");
                    #line (157,18)-(157,54) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedList(elem, sl));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (158,14)-(158,56) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value.Multiplicity.IsList())
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("    ");
                    #line (159,18)-(159,41) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitList(elem));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (160,14)-(160,57) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is TokenAlts tokenAlts)
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("    ");
                    #line (161,18)-(161,57) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitTokenAlts(elem, tokenAlts));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (162,14)-(162,41) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is Eof)
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("    ");
                    #line (163,17)-(163,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (163,20)-(163,21) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,22)-(163,40) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (163,41)-(163,42) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,42)-(163,43) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (163,43)-(163,44) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,44)-(163,93) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                    #line hidden
                    #line (163,94)-(163,108) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (163,109)-(163,110) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (163,110)-(163,111) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (163,112)-(163,116) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (163,117)-(163,133) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("SyntaxKind.Eof);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (164,14)-(164,47) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is Block blk)
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("    ");
                    #line (165,18)-(165,31) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(blk.GreenType);
                    #line hidden
                    #line (165,32)-(165,33) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("?");
                    #line hidden
                    #line (165,33)-(165,34) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,35)-(165,53) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (165,54)-(165,55) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,55)-(165,56) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (165,56)-(165,57) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,57)-(165,62) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("null;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (166,17)-(166,19) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (166,19)-(166,20) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,20)-(166,29) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(context.");
                    #line hidden
                    #line (166,30)-(166,44) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (166,45)-(166,46) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,46)-(166,48) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("is");
                    #line hidden
                    #line (166,48)-(166,49) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,49)-(166,52) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("not");
                    #line hidden
                    #line (166,52)-(166,53) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,53)-(166,58) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("null)");
                    #line hidden
                    #line (166,58)-(166,59) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,60)-(166,78) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.ParameterName);
                    #line hidden
                    #line (166,79)-(166,80) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,80)-(166,81) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (166,81)-(166,82) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,82)-(166,83) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (166,84)-(166,97) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(blk.GreenType);
                    #line hidden
                    #line (166,98)-(166,119) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write("?)this.Visit(context.");
                    #line hidden
                    #line (166,120)-(166,134) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(elem.AntlrName);
                    #line hidden
                    #line (166,135)-(166,136) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    var __first30 = true;
                    #line (166,137)-(166,179) 21 "AntlrSyntaxGenerator.mxg"
                    if (!elem.Value.Multiplicity.IsOptional())
                    #line hidden
                    
                    {
                        if (__first30)
                        {
                            __first30 = false;
                        }
                        #line (166,180)-(166,181) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (166,181)-(166,183) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("??");
                        #line hidden
                        #line (166,183)-(166,184) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (166,185)-(166,198) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(blk.GreenType);
                        #line hidden
                        #line (166,199)-(166,209) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(".__Missing");
                        #line hidden
                    }
                    #line (166,217)-(166,218) 33 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first31 = true;
                    #line (167,18)-(167,60) 21 "AntlrSyntaxGenerator.mxg"
                    if (!elem.Value.Multiplicity.IsOptional())
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        __cb.Push("    ");
                        #line (168,21)-(168,25) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (168,25)-(168,26) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,27)-(168,45) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (168,46)-(168,47) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,47)-(168,48) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (168,48)-(168,49) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,50)-(168,63) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(blk.GreenType);
                        #line hidden
                        #line (168,64)-(168,75) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(".__Missing;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first31) __cb.AppendLine();
                }
                #line (170,14)-(170,48) 17 "AntlrSyntaxGenerator.mxg"
                else if (elem.Value is RuleRef rr)
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    var __first32 = true;
                    #line (171,18)-(171,43) 21 "AntlrSyntaxGenerator.mxg"
                    if (rr.Token is not null)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("    ");
                        #line (172,21)-(172,24) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (172,24)-(172,25) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,26)-(172,44) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (172,45)-(172,46) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,46)-(172,47) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (172,47)-(172,48) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,48)-(172,97) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                        #line hidden
                        #line (172,98)-(172,112) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        var __first33 = true;
                        #line (172,114)-(172,156) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first33)
                            {
                                __first33 = false;
                            }
                            #line (172,157)-(172,158) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(",");
                            #line hidden
                            #line (172,158)-(172,159) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (172,160)-(172,164) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(Lang);
                            #line hidden
                            #line (172,165)-(172,176) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("SyntaxKind.");
                            #line hidden
                            #line (172,177)-(172,196) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.Token.CSharpName);
                            #line hidden
                        }
                        #line (172,205)-(172,207) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (173,18)-(173,46) 21 "AntlrSyntaxGenerator.mxg"
                    else if(rr.Rule is not null)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("    ");
                        #line (174,22)-(174,34) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(rr.GreenType);
                        #line hidden
                        #line (174,35)-(174,36) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("?");
                        #line hidden
                        #line (174,36)-(174,37) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,38)-(174,56) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (174,57)-(174,58) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,58)-(174,59) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (174,59)-(174,60) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,60)-(174,65) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("null;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (175,21)-(175,23) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (175,23)-(175,24) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,24)-(175,33) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(context.");
                        #line hidden
                        #line (175,34)-(175,48) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        #line (175,49)-(175,50) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,50)-(175,52) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("is");
                        #line hidden
                        #line (175,52)-(175,53) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,53)-(175,56) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("not");
                        #line hidden
                        #line (175,56)-(175,57) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,57)-(175,62) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("null)");
                        #line hidden
                        #line (175,62)-(175,63) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,64)-(175,82) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (175,83)-(175,84) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,84)-(175,85) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (175,85)-(175,86) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,86)-(175,87) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (175,88)-(175,100) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(rr.GreenType);
                        #line hidden
                        #line (175,101)-(175,122) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write("?)this.Visit(context.");
                        #line hidden
                        #line (175,123)-(175,137) 36 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(elem.AntlrName);
                        #line hidden
                        #line (175,138)-(175,139) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        var __first34 = true;
                        #line (175,140)-(175,182) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first34)
                            {
                                __first34 = false;
                            }
                            #line (175,183)-(175,184) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (175,184)-(175,186) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("??");
                            #line hidden
                            #line (175,186)-(175,187) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (175,188)-(175,200) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.GreenType);
                            #line hidden
                            #line (175,201)-(175,211) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(".__Missing");
                            #line hidden
                        }
                        #line (175,219)-(175,220) 37 "AntlrSyntaxGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first35 = true;
                        #line (176,22)-(176,64) 25 "AntlrSyntaxGenerator.mxg"
                        if (!elem.Value.Multiplicity.IsOptional())
                        #line hidden
                        
                        {
                            if (__first35)
                            {
                                __first35 = false;
                            }
                            __cb.Push("    ");
                            #line (177,25)-(177,29) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("else");
                            #line hidden
                            #line (177,29)-(177,30) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (177,31)-(177,49) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(elem.ParameterName);
                            #line hidden
                            #line (177,50)-(177,51) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (177,51)-(177,52) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (177,52)-(177,53) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (177,54)-(177,66) 40 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(rr.GreenType);
                            #line hidden
                            #line (177,67)-(177,78) 41 "AntlrSyntaxGenerator.mxg"
                            __cb.Write(".__Missing;");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first35) __cb.AppendLine();
                    }
                    #line (179,18)-(179,22) 21 "AntlrSyntaxGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                    }
                    if (!__first32) __cb.AppendLine();
                }
                if (!__first29) __cb.AppendLine();
            }
            if (!__first28) __cb.AppendLine();
            __cb.Push("    ");
            #line (183,9)-(183,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (183,15)-(183,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (183,16)-(183,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_factory.");
            #line hidden
            #line (183,26)-(183,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (183,41)-(183,42) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (183,43)-(183,67) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(alt.GreenUpdateArguments);
            #line hidden
            #line (183,68)-(183,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (184,5)-(184,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (187,9)-(187,67) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitTokenAlts(Element elem, TokenAlts tokenAlts)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (188,5)-(188,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxToken?");
            #line hidden
            #line (188,25)-(188,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (188,27)-(188,45) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (188,46)-(188,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (188,47)-(188,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (188,48)-(188,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (188,49)-(188,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first36 = true;
            #line (189,6)-(189,45) 13 "AntlrSyntaxGenerator.mxg"
            foreach (var token in tokenAlts.Tokens)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("");
                #line (190,9)-(190,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (190,11)-(190,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (190,12)-(190,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(context.");
                #line hidden
                #line (190,22)-(190,43) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (190,44)-(190,46) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("()");
                #line hidden
                #line (190,46)-(190,47) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (190,47)-(190,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (190,49)-(190,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (190,50)-(190,53) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (190,53)-(190,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (190,54)-(190,59) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (190,59)-(190,60) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (190,61)-(190,79) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (190,80)-(190,81) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (190,81)-(190,82) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (190,82)-(190,83) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (190,83)-(190,132) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(InternalSyntaxToken?)this.VisitTerminal(context.");
                #line hidden
                #line (190,133)-(190,154) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(token.Token.AntlrName);
                #line hidden
                #line (190,155)-(190,159) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("());");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            var __first37 = true;
            #line (192,6)-(192,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("");
                #line (193,9)-(193,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (193,11)-(193,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,12)-(193,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (193,14)-(193,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (193,33)-(193,34) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,34)-(193,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (193,36)-(193,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,37)-(193,42) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (193,42)-(193,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,44)-(193,62) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (193,63)-(193,64) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,64)-(193,65) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (193,65)-(193,66) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,66)-(193,121) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (193,121)-(193,122) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (193,123)-(193,127) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (193,128)-(193,139) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (193,140)-(193,192) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(tokenAlts.Tokens.FirstOrDefault()?.Token?.CSharpName);
                #line hidden
                #line (193,193)-(193,195) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (197,9)-(197,41) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitList(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (198,5)-(198,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (198,8)-(198,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,10)-(198,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (198,25)-(198,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (198,32)-(198,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,33)-(198,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (198,34)-(198,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,35)-(198,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (198,45)-(198,59) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (198,60)-(198,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (199,5)-(199,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (199,8)-(199,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,10)-(199,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (199,29)-(199,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder");
            #line hidden
            #line (199,36)-(199,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,37)-(199,38) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (199,38)-(199,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,39)-(199,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Allocate<");
            #line hidden
            #line (199,55)-(199,75) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (199,76)-(199,80) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (200,5)-(200,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (200,8)-(200,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,9)-(200,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (200,13)-(200,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,14)-(200,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (200,15)-(200,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,16)-(200,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (200,17)-(200,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,18)-(200,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (200,20)-(200,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,21)-(200,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (200,22)-(200,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,23)-(200,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (200,24)-(200,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,26)-(200,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (200,41)-(200,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (200,55)-(200,56) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,56)-(200,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (201,5)-(201,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first38 = true;
            #line (202,10)-(202,26) 13 "AntlrSyntaxGenerator.mxg"
            if(elem.IsToken)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (203,14)-(203,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (203,33)-(203,86) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (203,87)-(203,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (203,102)-(203,109) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (203,110)-(203,115) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (203,116)-(203,119) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (204,10)-(204,14) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (205,13)-(205,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (205,15)-(205,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,16)-(205,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (205,18)-(205,32) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (205,33)-(205,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (205,41)-(205,46) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (205,47)-(205,48) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,48)-(205,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (205,50)-(205,51) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,51)-(205,54) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (205,54)-(205,55) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,55)-(205,60) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (205,60)-(205,61) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,62)-(205,80) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (205,81)-(205,94) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add((");
                #line hidden
                #line (205,95)-(205,115) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (205,116)-(205,129) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("?)this.Visit(");
                #line hidden
                #line (205,130)-(205,144) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (205,145)-(205,152) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (205,153)-(205,158) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write("[i]");
                #line hidden
                #line (205,159)-(205,160) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (205,160)-(205,161) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,161)-(205,163) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("??");
                #line hidden
                #line (205,163)-(205,164) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,165)-(205,185) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (205,186)-(205,198) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (206,13)-(206,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (206,17)-(206,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (206,19)-(206,37) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (206,38)-(206,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Builder.Add(");
                #line hidden
                #line (206,51)-(206,71) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (206,72)-(206,84) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (208,5)-(208,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (209,5)-(209,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (209,8)-(209,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,10)-(209,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (209,29)-(209,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,30)-(209,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (209,31)-(209,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,33)-(209,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (209,52)-(209,69) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder.ToList();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (210,5)-(210,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (210,17)-(210,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (210,36)-(210,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Builder);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (213,9)-(213,68) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedList(Element elem, SeparatedList sl)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (214,6)-(214,48) 13 "AntlrSyntaxGenerator.mxg"
            var builder = elem.ParameterName+"Builder";
            #line hidden
            
            __cb.Push("");
            #line (215,5)-(215,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (215,8)-(215,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,10)-(215,17) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (215,18)-(215,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,19)-(215,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (215,20)-(215,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,21)-(215,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.AllocateSeparated<");
            #line hidden
            #line (215,46)-(215,58) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.GreenType);
            #line hidden
            #line (215,59)-(215,70) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(">(reversed:");
            #line hidden
            #line (215,70)-(215,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,72)-(215,108) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.SeparatorFirst ? "true" : "false");
            #line hidden
            #line (215,109)-(215,111) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first39 = true;
            #line (216,6)-(216,83) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.FirstItems.Count && i < sl.FirstSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                var __first40 = true;
                #line (217,10)-(217,32) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.SeparatorFirst)
                #line hidden
                
                {
                    if (__first40)
                    {
                        __first40 = false;
                    }
                    __cb.Push("");
                    #line (218,14)-(218,81) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (219,14)-(219,71) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (220,10)-(220,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first40)
                    {
                        __first40 = false;
                    }
                    __cb.Push("");
                    #line (221,14)-(221,71) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[i], builder));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (222,14)-(222,81) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[i], builder));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first40) __cb.AppendLine();
            }
            if (!__first39) __cb.AppendLine();
            var __first41 = true;
            #line (225,6)-(225,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstItems.Count > sl.FirstSeparators.Count)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("");
                #line (226,10)-(226,87) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.FirstItems[sl.FirstItems.Count-1], builder));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            var __first42 = true;
            #line (228,6)-(228,57) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.FirstSeparators.Count > sl.FirstItems.Count)
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                __cb.Push("");
                #line (229,10)-(229,102) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.FirstSeparators[sl.FirstSeparators.Count-1], builder));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first42) __cb.AppendLine();
            __cb.Push("");
            #line (231,5)-(231,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (231,8)-(231,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,10)-(231,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (231,36)-(231,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (231,43)-(231,44) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,44)-(231,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (231,45)-(231,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,46)-(231,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (231,56)-(231,81) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (231,82)-(231,83) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (232,5)-(232,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (232,8)-(232,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,10)-(232,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (232,41)-(232,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (232,48)-(232,49) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,49)-(232,50) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (232,50)-(232,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,51)-(232,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context._");
            #line hidden
            #line (232,61)-(232,91) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedSeparator.AntlrName);
            #line hidden
            #line (232,92)-(232,93) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (233,5)-(233,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (233,8)-(233,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,9)-(233,13) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(int");
            #line hidden
            #line (233,13)-(233,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,14)-(233,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (233,15)-(233,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,16)-(233,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (233,17)-(233,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,18)-(233,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (233,20)-(233,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,21)-(233,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("i");
            #line hidden
            #line (233,22)-(233,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,23)-(233,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (233,24)-(233,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,26)-(233,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(sl.RepeatedItem.AntlrName);
            #line hidden
            #line (233,52)-(233,66) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context.Count;");
            #line hidden
            #line (233,66)-(233,67) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,67)-(233,71) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("++i)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (234,5)-(234,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first43 = true;
            #line (235,10)-(235,40) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.RepeatedSeparatorFirst)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                __cb.Push("    ");
                #line (236,13)-(236,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (236,15)-(236,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (236,16)-(236,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (236,18)-(236,19) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (236,19)-(236,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (236,20)-(236,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (236,22)-(236,52) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (236,53)-(236,67) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (237,13)-(237,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (238,18)-(238,89) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (239,13)-(239,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (240,13)-(240,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (241,13)-(241,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (242,18)-(242,25) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (242,26)-(242,95) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (242,95)-(242,96) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (242,97)-(242,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (242,102)-(242,113) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (242,114)-(242,145) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (242,146)-(242,149) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (243,13)-(243,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (244,14)-(244,75) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (245,10)-(245,14) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                __cb.Push("    ");
                #line (246,14)-(246,75) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.RepeatedItem, builder, "i"));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (247,13)-(247,15) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (247,15)-(247,16) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,16)-(247,18) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(i");
                #line hidden
                #line (247,18)-(247,19) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,19)-(247,20) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("<");
                #line hidden
                #line (247,20)-(247,21) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,22)-(247,52) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.AntlrName);
                #line hidden
                #line (247,53)-(247,67) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context.Count)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (248,13)-(248,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (249,18)-(249,89) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.RepeatedSeparator, builder, "i"));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (250,13)-(250,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (251,13)-(251,17) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (252,13)-(252,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (253,18)-(253,25) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (253,26)-(253,95) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal((IToken?)null,");
                #line hidden
                #line (253,95)-(253,96) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (253,97)-(253,101) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (253,102)-(253,113) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (253,114)-(253,145) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(sl.RepeatedSeparator.CSharpName);
                #line hidden
                #line (253,146)-(253,149) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (254,13)-(254,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            __cb.Push("");
            #line (256,5)-(256,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first44 = true;
            #line (257,6)-(257,81) 13 "AntlrSyntaxGenerator.mxg"
            for (int i = 0; i < sl.LastItems.Count && i < sl.LastSeparators.Count; ++i)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                var __first45 = true;
                #line (258,10)-(258,40) 17 "AntlrSyntaxGenerator.mxg"
                if (sl.RepeatedSeparatorFirst)
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    __cb.Push("");
                    #line (259,14)-(259,80) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (260,14)-(260,76) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (261,10)-(261,14) 17 "AntlrSyntaxGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    __cb.Push("");
                    #line (262,14)-(262,76) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[i], builder, null));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (263,14)-(263,80) 32 "AntlrSyntaxGenerator.mxg"
                    __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[i], builder));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first45) __cb.AppendLine();
            }
            if (!__first44) __cb.AppendLine();
            var __first46 = true;
            #line (266,6)-(266,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastItems.Count > sl.LastSeparators.Count)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("");
                #line (267,10)-(267,85) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListItem(sl.LastItems[sl.LastItems.Count-1], builder));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            var __first47 = true;
            #line (269,6)-(269,55) 13 "AntlrSyntaxGenerator.mxg"
            if (sl.LastSeparators.Count > sl.LastItems.Count)
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("");
                #line (270,10)-(270,100) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(GenerateVisitSeparatedListSeparator(sl.LastSeparators[sl.LastSeparators.Count-1], builder));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            __cb.Push("");
            #line (272,5)-(272,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (272,8)-(272,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,10)-(272,28) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (272,29)-(272,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,30)-(272,31) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (272,31)-(272,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,33)-(272,40) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (272,41)-(272,51) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".ToList();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (273,5)-(273,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_pool.Free(");
            #line hidden
            #line (273,17)-(273,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (273,25)-(273,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (276,9)-(276,70) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (277,5)-(277,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (277,8)-(277,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,10)-(277,24) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (277,25)-(277,32) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (277,32)-(277,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,33)-(277,34) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (277,34)-(277,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,35)-(277,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (277,44)-(277,58) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (277,59)-(277,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (278,5)-(278,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (278,7)-(278,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,8)-(278,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(");
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
            #line (278,33)-(278,35) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (278,35)-(278,36) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,36)-(278,39) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (278,39)-(278,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,40)-(278,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (278,45)-(278,46) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,47)-(278,54) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (278,55)-(278,61) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (278,62)-(278,82) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (278,83)-(278,96) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(");
            #line hidden
            #line (278,97)-(278,111) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (278,112)-(278,120) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context)");
            #line hidden
            #line (278,120)-(278,121) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,121)-(278,123) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (278,123)-(278,124) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,125)-(278,145) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (278,146)-(278,158) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first48 = true;
            #line (279,6)-(279,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first48)
                {
                    __first48 = false;
                }
                __cb.Push("");
                #line (280,9)-(280,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (280,13)-(280,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (280,15)-(280,22) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (280,23)-(280,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (280,29)-(280,49) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (280,50)-(280,62) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first48) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (284,9)-(284,75) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (285,5)-(285,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (285,8)-(285,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (285,9)-(285,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separatorContext");
            #line hidden
            #line (285,26)-(285,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (285,27)-(285,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (285,28)-(285,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (285,29)-(285,37) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("context.");
            #line hidden
            #line (285,38)-(285,52) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (285,53)-(285,54) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first49 = true;
            #line (286,6)-(286,47) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("");
                #line (287,9)-(287,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (287,11)-(287,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,12)-(287,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (287,14)-(287,28) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (287,29)-(287,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (287,36)-(287,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,37)-(287,39) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (287,39)-(287,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,40)-(287,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (287,43)-(287,44) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,44)-(287,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (287,49)-(287,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (287,51)-(287,58) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (287,59)-(287,114) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (287,115)-(287,129) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (287,130)-(287,140) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (288,6)-(288,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("");
                #line (289,10)-(289,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (289,18)-(289,73) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(");
                #line hidden
                #line (289,74)-(289,88) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (289,89)-(289,97) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context,");
                #line hidden
                #line (289,97)-(289,98) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,99)-(289,103) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (289,104)-(289,115) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (289,116)-(289,131) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (289,132)-(289,135) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first49) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (293,9)-(293,84) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListItem(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (294,5)-(294,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (294,8)-(294,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,9)-(294,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_item");
            #line hidden
            #line (294,14)-(294,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,15)-(294,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (294,16)-(294,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,18)-(294,32) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (294,33)-(294,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (294,41)-(294,44) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (294,46)-(294,51) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (294,53)-(294,56) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (294,57)-(294,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (295,5)-(295,7) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (295,7)-(295,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,8)-(295,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("(_item");
            #line hidden
            #line (295,14)-(295,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,15)-(295,17) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (295,17)-(295,18) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,18)-(295,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (295,21)-(295,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,22)-(295,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (295,27)-(295,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,29)-(295,36) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(builder);
            #line hidden
            #line (295,37)-(295,43) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Add((");
            #line hidden
            #line (295,44)-(295,64) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (295,65)-(295,84) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("?)this.Visit(_item)");
            #line hidden
            #line (295,84)-(295,85) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,85)-(295,87) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("??");
            #line hidden
            #line (295,87)-(295,88) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (295,89)-(295,109) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.Value.GreenType);
            #line hidden
            #line (295,110)-(295,122) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".__Missing);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first50 = true;
            #line (296,6)-(296,48) 13 "AntlrSyntaxGenerator.mxg"
            if (!elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.Push("");
                #line (297,9)-(297,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (297,13)-(297,14) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (297,15)-(297,22) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (297,23)-(297,28) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".Add(");
                #line hidden
                #line (297,29)-(297,49) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.Value.GreenType);
                #line hidden
                #line (297,50)-(297,62) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".__Missing);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first50) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (301,9)-(301,89) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateVisitSeparatedListSeparator(Element elem, string builder, string index)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (302,5)-(302,8) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (302,8)-(302,9) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,9)-(302,19) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("_separator");
            #line hidden
            #line (302,19)-(302,20) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,20)-(302,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (302,21)-(302,22) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,23)-(302,37) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(elem.AntlrName);
            #line hidden
            #line (302,38)-(302,45) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Context");
            #line hidden
            #line (302,46)-(302,49) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("[");
            #line hidden
            #line (302,51)-(302,56) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(index);
            #line hidden
            #line (302,58)-(302,61) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write("]");
            #line hidden
            #line (302,62)-(302,63) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first51 = true;
            #line (303,6)-(303,47) 13 "AntlrSyntaxGenerator.mxg"
            if (elem.Value.Multiplicity.IsOptional())
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("");
                #line (304,9)-(304,11) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (304,11)-(304,12) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (304,12)-(304,13) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (304,14)-(304,28) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (304,29)-(304,36) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("Context");
                #line hidden
                #line (304,36)-(304,37) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (304,37)-(304,39) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("is");
                #line hidden
                #line (304,39)-(304,40) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (304,40)-(304,43) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("not");
                #line hidden
                #line (304,43)-(304,44) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (304,44)-(304,49) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                #line (304,49)-(304,50) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (304,51)-(304,58) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (304,59)-(304,127) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (305,6)-(305,10) 13 "AntlrSyntaxGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("");
                #line (306,10)-(306,17) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(builder);
                #line hidden
                #line (306,18)-(306,84) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(".AddSeparator((InternalSyntaxToken?)this.VisitTerminal(_separator,");
                #line hidden
                #line (306,84)-(306,85) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (306,86)-(306,90) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (306,91)-(306,102) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (306,103)-(306,118) 28 "AntlrSyntaxGenerator.mxg"
                __cb.Write(elem.CSharpName);
                #line hidden
                #line (306,119)-(306,122) 29 "AntlrSyntaxGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (310,9)-(310,46) 22 "AntlrSyntaxGenerator.mxg"
        public string GenerateAntlrInternalSyntaxFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (311,5)-(311,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (311,10)-(311,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,11)-(311,33) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (312,5)-(312,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (312,10)-(312,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,11)-(312,40) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (313,5)-(313,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (313,10)-(313,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,11)-(313,55) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (314,5)-(314,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (314,10)-(314,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (314,11)-(314,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Parsers.Antlr;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (315,5)-(315,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (315,10)-(315,11) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (315,11)-(315,26) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Antlr4.Runtime;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (317,5)-(317,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (317,14)-(317,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,15)-(317,21) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (319,5)-(319,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (319,14)-(319,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (319,16)-(319,25) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (319,26)-(319,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (320,5)-(320,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (321,9)-(321,15) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (321,15)-(321,16) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,16)-(321,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (321,23)-(321,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,24)-(321,29) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (321,29)-(321,30) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,31)-(321,35) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (321,36)-(321,57) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (321,57)-(321,58) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,58)-(321,59) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (321,59)-(321,60) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (321,60)-(321,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (322,9)-(322,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (323,13)-(323,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrLexer");
            #line hidden
            #line (323,23)-(323,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,24)-(323,72) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrLexer(ICharStream");
            #line hidden
            #line (323,72)-(323,73) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,73)-(323,79) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("input)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (324,13)-(324,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (325,17)-(325,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (325,23)-(325,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,24)-(325,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (325,27)-(325,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,29)-(325,33) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (325,34)-(325,47) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Lexer(input);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (326,13)-(326,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (328,13)-(328,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("AntlrParser");
            #line hidden
            #line (328,24)-(328,25) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,25)-(328,75) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("IAntlrSyntaxFactory.CreateAntlrParser(ITokenStream");
            #line hidden
            #line (328,75)-(328,76) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,76)-(328,82) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("input)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (329,13)-(329,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (330,17)-(330,23) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (330,23)-(330,24) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,24)-(330,27) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (330,27)-(330,28) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,29)-(330,33) 24 "AntlrSyntaxGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (330,34)-(330,48) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("Parser(input);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (331,13)-(331,14) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (332,9)-(332,10) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (333,5)-(333,6) 25 "AntlrSyntaxGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}