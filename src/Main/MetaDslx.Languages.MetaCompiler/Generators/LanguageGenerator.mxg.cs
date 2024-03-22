#pragma warning disable CS8669
#line (1,10)-(1,53) 10 "LanguageGenerator.mxg"
namespace MetaDslx.Languages.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "LanguageGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "LanguageGenerator.mxg"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "LanguageGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "LanguageGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "LanguageGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "LanguageGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "LanguageGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "LanguageGenerator.mxg"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "LanguageGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (10,9)-(10,28) 22 "LanguageGenerator.mxg"
        public string GenerateLanguage()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,5)-(11,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (11,10)-(11,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,11)-(11,19) 25 "LanguageGenerator.mxg"
            __cb.Write("Autofac;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (12,5)-(12,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,10)-(12,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,11)-(12,33) 25 "LanguageGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,5)-(13,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,10)-(13,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,11)-(13,40) 25 "LanguageGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,5)-(14,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,10)-(14,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,11)-(14,55) 25 "LanguageGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,5)-(16,12) 25 "LanguageGenerator.mxg"
            __cb.Write("#pragma");
            #line hidden
            #line (16,12)-(16,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,13)-(16,20) 25 "LanguageGenerator.mxg"
            __cb.Write("warning");
            #line hidden
            #line (16,20)-(16,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,21)-(16,28) 25 "LanguageGenerator.mxg"
            __cb.Write("disable");
            #line hidden
            #line (16,28)-(16,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,29)-(16,35) 25 "LanguageGenerator.mxg"
            __cb.Write("CS8669");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (18,5)-(18,14) 25 "LanguageGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (18,14)-(18,15) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,16)-(18,25) 24 "LanguageGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,5)-(19,6) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (20,9)-(20,14) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (20,14)-(20,15) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,15)-(20,23) 25 "LanguageGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (20,24)-(20,33) 24 "LanguageGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (20,34)-(20,42) 25 "LanguageGenerator.mxg"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,9)-(21,14) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (21,14)-(21,15) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,15)-(21,23) 25 "LanguageGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (21,24)-(21,33) 24 "LanguageGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (21,34)-(21,57) 25 "LanguageGenerator.mxg"
            __cb.Write(".Syntax.InternalSyntax;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,9)-(23,15) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (23,15)-(23,16) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,16)-(23,22) 25 "LanguageGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (23,22)-(23,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,23)-(23,30) 25 "LanguageGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (23,30)-(23,31) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,31)-(23,36) 25 "LanguageGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (23,36)-(23,37) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,38)-(23,42) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (23,43)-(23,51) 25 "LanguageGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (23,51)-(23,52) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,52)-(23,53) 25 "LanguageGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (23,53)-(23,54) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,54)-(23,62) 25 "LanguageGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,9)-(24,10) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,13)-(25,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (25,19)-(25,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,20)-(25,26) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (25,26)-(25,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,28)-(25,32) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (25,33)-(25,41) 25 "LanguageGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (25,41)-(25,42) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,42)-(25,50) 25 "LanguageGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (25,50)-(25,51) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,51)-(25,52) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,52)-(25,53) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,53)-(25,56) 25 "LanguageGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (25,56)-(25,57) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,58)-(25,62) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (25,63)-(25,74) 25 "LanguageGenerator.mxg"
            __cb.Write("Language();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,13)-(27,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (27,19)-(27,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,20)-(27,28) 25 "LanguageGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (27,28)-(27,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,29)-(27,35) 25 "LanguageGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (27,35)-(27,36) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,36)-(27,40) 25 "LanguageGenerator.mxg"
            __cb.Write("Name");
            #line hidden
            #line (27,40)-(27,41) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,41)-(27,43) 25 "LanguageGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (27,43)-(27,44) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,44)-(27,45) 25 "LanguageGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (27,46)-(27,50) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (27,51)-(27,53) 25 "LanguageGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,13)-(29,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (29,19)-(29,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,20)-(29,23) 25 "LanguageGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (29,23)-(29,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,25)-(29,29) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (29,30)-(29,51) 25 "LanguageGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (29,51)-(29,52) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,52)-(29,73) 25 "LanguageGenerator.mxg"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (29,73)-(29,74) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,74)-(29,76) 25 "LanguageGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (29,76)-(29,77) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,77)-(29,78) 25 "LanguageGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (29,79)-(29,83) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (29,84)-(29,133) 25 "LanguageGenerator.mxg"
            __cb.Write("InternalSyntaxFactory)base.InternalSyntaxFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (31,13)-(31,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (31,19)-(31,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,20)-(31,23) 25 "LanguageGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (31,23)-(31,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,25)-(31,29) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (31,30)-(31,41) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFacts");
            #line hidden
            #line (31,41)-(31,42) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,42)-(31,53) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFacts");
            #line hidden
            #line (31,53)-(31,54) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,54)-(31,56) 25 "LanguageGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (31,56)-(31,57) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,57)-(31,58) 25 "LanguageGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (31,59)-(31,63) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (31,64)-(31,93) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFacts)base.SyntaxFacts;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (33,13)-(33,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (33,19)-(33,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,20)-(33,23) 25 "LanguageGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (33,23)-(33,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,25)-(33,29) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (33,30)-(33,43) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFactory");
            #line hidden
            #line (33,43)-(33,44) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,44)-(33,57) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFactory");
            #line hidden
            #line (33,57)-(33,58) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,58)-(33,60) 25 "LanguageGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (33,60)-(33,61) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,61)-(33,62) 25 "LanguageGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (33,63)-(33,67) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (33,68)-(33,101) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFactory)base.SyntaxFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (35,13)-(35,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (35,19)-(35,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,20)-(35,23) 25 "LanguageGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (35,23)-(35,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,25)-(35,29) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (35,30)-(35,48) 25 "LanguageGenerator.mxg"
            __cb.Write("CompilationFactory");
            #line hidden
            #line (35,48)-(35,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,49)-(35,67) 25 "LanguageGenerator.mxg"
            __cb.Write("CompilationFactory");
            #line hidden
            #line (35,67)-(35,68) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,68)-(35,70) 25 "LanguageGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (35,70)-(35,71) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,71)-(35,72) 25 "LanguageGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (35,73)-(35,77) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (35,78)-(35,121) 25 "LanguageGenerator.mxg"
            __cb.Write("CompilationFactory)base.CompilationFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (37,13)-(37,22) 25 "LanguageGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (37,22)-(37,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,23)-(37,31) 25 "LanguageGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (37,31)-(37,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,32)-(37,36) 25 "LanguageGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (37,36)-(37,37) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,37)-(37,59) 25 "LanguageGenerator.mxg"
            __cb.Write("RegisterServicesCore()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (38,13)-(38,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (39,17)-(39,36) 25 "LanguageGenerator.mxg"
            __cb.Write("RegisterServices();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (40,17)-(40,41) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegister<SyntaxFacts,");
            #line hidden
            #line (40,41)-(40,42) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,43)-(40,47) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (40,48)-(40,63) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFacts>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (41,17)-(41,51) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegister<InternalSyntaxFactory,");
            #line hidden
            #line (41,51)-(41,52) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,53)-(41,57) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (41,58)-(41,83) 25 "LanguageGenerator.mxg"
            __cb.Write("InternalSyntaxFactory>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (42,17)-(42,43) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegister<SyntaxFactory,");
            #line hidden
            #line (42,43)-(42,44) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,45)-(42,49) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (42,50)-(42,67) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFactory>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (43,17)-(43,48) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegister<CompilationFactory,");
            #line hidden
            #line (43,48)-(43,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,50)-(43,54) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (43,55)-(43,77) 25 "LanguageGenerator.mxg"
            __cb.Write("CompilationFactory>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (44,13)-(44,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (46,13)-(46,20) 25 "LanguageGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (46,20)-(46,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,21)-(46,25) 25 "LanguageGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (46,25)-(46,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,26)-(46,45) 25 "LanguageGenerator.mxg"
            __cb.Write("RegisterServices();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (47,9)-(47,10) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (48,5)-(48,6) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (51,9)-(51,35) 22 "LanguageGenerator.mxg"
        public string GenerateLanguageVersion()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (52,5)-(52,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (52,10)-(52,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,11)-(52,33) 25 "LanguageGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (53,5)-(53,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (53,10)-(53,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,11)-(53,28) 25 "LanguageGenerator.mxg"
            __cb.Write("Roslyn.Utilities;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (55,5)-(55,12) 25 "LanguageGenerator.mxg"
            __cb.Write("#pragma");
            #line hidden
            #line (55,12)-(55,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,13)-(55,20) 25 "LanguageGenerator.mxg"
            __cb.Write("warning");
            #line hidden
            #line (55,20)-(55,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,21)-(55,28) 25 "LanguageGenerator.mxg"
            __cb.Write("disable");
            #line hidden
            #line (55,28)-(55,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,29)-(55,35) 25 "LanguageGenerator.mxg"
            __cb.Write("CS8669");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (57,5)-(57,14) 25 "LanguageGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (57,14)-(57,15) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,16)-(57,25) 24 "LanguageGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (58,5)-(58,6) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (59,9)-(59,12) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (59,12)-(59,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,13)-(59,22) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (60,9)-(60,12) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (60,12)-(60,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,13)-(60,22) 25 "LanguageGenerator.mxg"
            __cb.Write("Specifies");
            #line hidden
            #line (60,22)-(60,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,23)-(60,26) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (60,26)-(60,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,27)-(60,35) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (60,35)-(60,36) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,36)-(60,44) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (61,9)-(61,12) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (61,12)-(61,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,13)-(61,23) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (62,9)-(62,15) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (62,15)-(62,16) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,16)-(62,20) 25 "LanguageGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (62,20)-(62,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,22)-(62,26) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (62,27)-(62,42) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (63,9)-(63,10) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (64,13)-(64,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (64,16)-(64,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,17)-(64,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (65,13)-(65,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (65,16)-(65,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,17)-(65,25) 25 "LanguageGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (65,25)-(65,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,26)-(65,33) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (65,33)-(65,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,34)-(65,35) 25 "LanguageGenerator.mxg"
            __cb.Write("1");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,13)-(66,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (66,16)-(66,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,17)-(66,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (67,13)-(67,21) 25 "LanguageGenerator.mxg"
            __cb.Write("Version1");
            #line hidden
            #line (67,21)-(67,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,22)-(67,23) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,23)-(67,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,24)-(67,26) 25 "LanguageGenerator.mxg"
            __cb.Write("1,");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (69,13)-(69,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (69,16)-(69,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,17)-(69,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,13)-(70,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (70,16)-(70,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,17)-(70,20) 25 "LanguageGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (70,20)-(70,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,21)-(70,27) 25 "LanguageGenerator.mxg"
            __cb.Write("latest");
            #line hidden
            #line (70,27)-(70,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,28)-(70,33) 25 "LanguageGenerator.mxg"
            __cb.Write("major");
            #line hidden
            #line (70,33)-(70,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,34)-(70,43) 25 "LanguageGenerator.mxg"
            __cb.Write("supported");
            #line hidden
            #line (70,43)-(70,44) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,44)-(70,52) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (71,13)-(71,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (71,16)-(71,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,17)-(71,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,13)-(72,24) 25 "LanguageGenerator.mxg"
            __cb.Write("LatestMajor");
            #line hidden
            #line (72,24)-(72,25) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,25)-(72,26) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (72,26)-(72,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,27)-(72,39) 25 "LanguageGenerator.mxg"
            __cb.Write("int.MaxValue");
            #line hidden
            #line (72,39)-(72,40) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,40)-(72,41) 25 "LanguageGenerator.mxg"
            __cb.Write("-");
            #line hidden
            #line (72,41)-(72,42) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,42)-(72,44) 25 "LanguageGenerator.mxg"
            __cb.Write("2,");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (74,13)-(74,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (74,16)-(74,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,17)-(74,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (75,13)-(75,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (75,16)-(75,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,17)-(75,24) 25 "LanguageGenerator.mxg"
            __cb.Write("Preview");
            #line hidden
            #line (75,24)-(75,25) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,25)-(75,27) 25 "LanguageGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (75,27)-(75,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,28)-(75,31) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (75,31)-(75,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,32)-(75,36) 25 "LanguageGenerator.mxg"
            __cb.Write("next");
            #line hidden
            #line (75,36)-(75,37) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,37)-(75,45) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (75,45)-(75,46) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,46)-(75,54) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (76,13)-(76,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (76,16)-(76,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,17)-(76,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (77,13)-(77,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Preview");
            #line hidden
            #line (77,20)-(77,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,21)-(77,22) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (77,22)-(77,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,23)-(77,35) 25 "LanguageGenerator.mxg"
            __cb.Write("int.MaxValue");
            #line hidden
            #line (77,35)-(77,36) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,36)-(77,37) 25 "LanguageGenerator.mxg"
            __cb.Write("-");
            #line hidden
            #line (77,37)-(77,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,38)-(77,40) 25 "LanguageGenerator.mxg"
            __cb.Write("1,");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (79,13)-(79,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (79,16)-(79,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,17)-(79,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,13)-(80,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (80,16)-(80,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,17)-(80,20) 25 "LanguageGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (80,20)-(80,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,21)-(80,27) 25 "LanguageGenerator.mxg"
            __cb.Write("latest");
            #line hidden
            #line (80,27)-(80,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,28)-(80,37) 25 "LanguageGenerator.mxg"
            __cb.Write("supported");
            #line hidden
            #line (80,37)-(80,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,38)-(80,45) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (80,45)-(80,46) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,46)-(80,48) 25 "LanguageGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (80,48)-(80,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,49)-(80,52) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (80,52)-(80,53) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,53)-(80,62) 25 "LanguageGenerator.mxg"
            __cb.Write("language.");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,13)-(81,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (81,16)-(81,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,17)-(81,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,13)-(82,19) 25 "LanguageGenerator.mxg"
            __cb.Write("Latest");
            #line hidden
            #line (82,19)-(82,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,20)-(82,21) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (82,21)-(82,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,22)-(82,35) 25 "LanguageGenerator.mxg"
            __cb.Write("int.MaxValue,");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (84,13)-(84,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (84,16)-(84,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,17)-(84,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,13)-(85,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (85,16)-(85,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,17)-(85,20) 25 "LanguageGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (85,20)-(85,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,21)-(85,28) 25 "LanguageGenerator.mxg"
            __cb.Write("default");
            #line hidden
            #line (85,28)-(85,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,29)-(85,37) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (85,37)-(85,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,38)-(85,46) 25 "LanguageGenerator.mxg"
            __cb.Write("version,");
            #line hidden
            #line (85,46)-(85,47) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,47)-(85,52) 25 "LanguageGenerator.mxg"
            __cb.Write("which");
            #line hidden
            #line (85,52)-(85,53) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,53)-(85,55) 25 "LanguageGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (85,55)-(85,56) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,56)-(85,59) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (85,59)-(85,60) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,60)-(85,66) 25 "LanguageGenerator.mxg"
            __cb.Write("latest");
            #line hidden
            #line (85,66)-(85,67) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,67)-(85,76) 25 "LanguageGenerator.mxg"
            __cb.Write("supported");
            #line hidden
            #line (85,76)-(85,77) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,77)-(85,85) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (86,13)-(86,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (86,16)-(86,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,17)-(86,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (87,13)-(87,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Default");
            #line hidden
            #line (87,20)-(87,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,21)-(87,22) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (87,22)-(87,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,23)-(87,25) 25 "LanguageGenerator.mxg"
            __cb.Write("0,");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (88,9)-(88,10) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (90,9)-(90,15) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (90,15)-(90,16) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,16)-(90,22) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (90,22)-(90,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,23)-(90,28) 25 "LanguageGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (90,28)-(90,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,30)-(90,34) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (90,35)-(90,55) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersionFacts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (91,9)-(91,10) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (92,13)-(92,21) 25 "LanguageGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (92,21)-(92,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,22)-(92,28) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (92,28)-(92,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,29)-(92,33) 25 "LanguageGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (92,33)-(92,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,34)-(92,46) 25 "LanguageGenerator.mxg"
            __cb.Write("IsValid(this");
            #line hidden
            #line (92,46)-(92,47) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,48)-(92,52) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (92,53)-(92,68) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (92,68)-(92,69) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,69)-(92,75) 25 "LanguageGenerator.mxg"
            __cb.Write("value)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (93,13)-(93,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (94,17)-(94,23) 25 "LanguageGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (94,23)-(94,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,24)-(94,31) 25 "LanguageGenerator.mxg"
            __cb.Write("(value)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (95,17)-(95,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (96,21)-(96,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (96,25)-(96,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,27)-(96,31) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (96,32)-(96,57) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (97,21)-(97,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (97,25)-(97,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,27)-(97,31) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (97,32)-(97,56) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Preview:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (98,25)-(98,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (98,31)-(98,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,32)-(98,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (99,17)-(99,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (101,17)-(101,23) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (101,23)-(101,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,24)-(101,30) 25 "LanguageGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (102,13)-(102,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (104,13)-(104,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (104,16)-(104,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,17)-(104,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (105,13)-(105,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (105,16)-(105,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,17)-(105,25) 25 "LanguageGenerator.mxg"
            __cb.Write("Displays");
            #line hidden
            #line (105,25)-(105,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,26)-(105,29) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (105,29)-(105,30) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,30)-(105,37) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (105,37)-(105,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,38)-(105,44) 25 "LanguageGenerator.mxg"
            __cb.Write("number");
            #line hidden
            #line (105,44)-(105,45) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,45)-(105,47) 25 "LanguageGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (105,47)-(105,48) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,48)-(105,51) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (105,51)-(105,52) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,52)-(105,58) 25 "LanguageGenerator.mxg"
            __cb.Write("format");
            #line hidden
            #line (105,58)-(105,59) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,59)-(105,67) 25 "LanguageGenerator.mxg"
            __cb.Write("expected");
            #line hidden
            #line (105,67)-(105,68) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,68)-(105,70) 25 "LanguageGenerator.mxg"
            __cb.Write("on");
            #line hidden
            #line (105,70)-(105,71) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,71)-(105,74) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (105,74)-(105,75) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,75)-(105,87) 25 "LanguageGenerator.mxg"
            __cb.Write("command-line");
            #line hidden
            #line (105,87)-(105,88) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,88)-(105,97) 25 "LanguageGenerator.mxg"
            __cb.Write("(/langver");
            #line hidden
            #line (105,97)-(105,98) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,98)-(105,104) 25 "LanguageGenerator.mxg"
            __cb.Write("flag).");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (106,13)-(106,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (106,16)-(106,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,17)-(106,20) 25 "LanguageGenerator.mxg"
            __cb.Write("For");
            #line hidden
            #line (106,20)-(106,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,21)-(106,30) 25 "LanguageGenerator.mxg"
            __cb.Write("instance,");
            #line hidden
            #line (106,30)-(106,31) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,31)-(106,35) 25 "LanguageGenerator.mxg"
            __cb.Write("\"6\",");
            #line hidden
            #line (106,35)-(106,36) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,36)-(106,40) 25 "LanguageGenerator.mxg"
            __cb.Write("\"7\",");
            #line hidden
            #line (106,40)-(106,41) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,41)-(106,47) 25 "LanguageGenerator.mxg"
            __cb.Write("\"7.1\",");
            #line hidden
            #line (106,47)-(106,48) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,48)-(106,57) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latest\".");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (107,13)-(107,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (107,16)-(107,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,17)-(107,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (108,13)-(108,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (108,19)-(108,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,20)-(108,26) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (108,26)-(108,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,27)-(108,33) 25 "LanguageGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (108,33)-(108,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,34)-(108,54) 25 "LanguageGenerator.mxg"
            __cb.Write("ToDisplayString(this");
            #line hidden
            #line (108,54)-(108,55) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,56)-(108,60) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (108,61)-(108,76) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (108,76)-(108,77) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,77)-(108,85) 25 "LanguageGenerator.mxg"
            __cb.Write("version)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (109,13)-(109,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (110,17)-(110,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (110,19)-(110,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,20)-(110,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (110,28)-(110,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,29)-(110,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (110,31)-(110,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,33)-(110,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (110,38)-(110,63) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1)");
            #line hidden
            #line (110,63)-(110,64) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,64)-(110,70) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (110,70)-(110,71) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,71)-(110,75) 25 "LanguageGenerator.mxg"
            __cb.Write("\"1\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (111,17)-(111,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (111,19)-(111,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,20)-(111,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (111,28)-(111,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,29)-(111,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (111,31)-(111,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,33)-(111,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (111,38)-(111,62) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default)");
            #line hidden
            #line (111,62)-(111,63) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,63)-(111,69) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (111,69)-(111,70) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,70)-(111,80) 25 "LanguageGenerator.mxg"
            __cb.Write("\"default\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (112,17)-(112,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (112,19)-(112,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,20)-(112,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (112,28)-(112,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,29)-(112,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (112,31)-(112,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,33)-(112,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (112,38)-(112,61) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Latest)");
            #line hidden
            #line (112,61)-(112,62) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,62)-(112,68) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (112,68)-(112,69) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,69)-(112,78) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latest\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (113,17)-(113,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (113,19)-(113,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,20)-(113,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (113,28)-(113,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,29)-(113,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (113,31)-(113,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,33)-(113,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (113,38)-(113,66) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.LatestMajor)");
            #line hidden
            #line (113,66)-(113,67) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,67)-(113,73) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (113,73)-(113,74) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,74)-(113,88) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latestmajor\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (114,17)-(114,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (114,19)-(114,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,20)-(114,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (114,28)-(114,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,29)-(114,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (114,31)-(114,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,33)-(114,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (114,38)-(114,62) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Preview)");
            #line hidden
            #line (114,62)-(114,63) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,63)-(114,69) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (114,69)-(114,70) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,70)-(114,80) 25 "LanguageGenerator.mxg"
            __cb.Write("\"preview\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (115,17)-(115,22) 25 "LanguageGenerator.mxg"
            __cb.Write("throw");
            #line hidden
            #line (115,22)-(115,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,23)-(115,67) 25 "LanguageGenerator.mxg"
            __cb.Write("ExceptionUtilities.UnexpectedValue(version);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (116,13)-(116,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (118,13)-(118,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (118,16)-(118,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (118,17)-(118,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (119,13)-(119,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (119,16)-(119,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,17)-(119,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Try");
            #line hidden
            #line (119,20)-(119,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,21)-(119,26) 25 "LanguageGenerator.mxg"
            __cb.Write("parse");
            #line hidden
            #line (119,26)-(119,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,27)-(119,28) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (119,28)-(119,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,29)-(119,33) 25 "LanguageGenerator.mxg"
            __cb.Write("<see");
            #line hidden
            #line (119,33)-(119,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,34)-(119,40) 25 "LanguageGenerator.mxg"
            __cb.Write("cref=\"");
            #line hidden
            #line (119,41)-(119,45) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (119,46)-(119,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion\"/>");
            #line hidden
            #line (119,64)-(119,65) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,65)-(119,69) 25 "LanguageGenerator.mxg"
            __cb.Write("from");
            #line hidden
            #line (119,69)-(119,70) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,70)-(119,71) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (119,71)-(119,72) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,72)-(119,78) 25 "LanguageGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (119,78)-(119,79) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,79)-(119,85) 25 "LanguageGenerator.mxg"
            __cb.Write("input,");
            #line hidden
            #line (119,85)-(119,86) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,86)-(119,95) 25 "LanguageGenerator.mxg"
            __cb.Write("returning");
            #line hidden
            #line (119,95)-(119,96) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,96)-(119,103) 25 "LanguageGenerator.mxg"
            __cb.Write("default");
            #line hidden
            #line (119,103)-(119,104) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,104)-(119,106) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (119,106)-(119,107) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,107)-(119,112) 25 "LanguageGenerator.mxg"
            __cb.Write("input");
            #line hidden
            #line (119,112)-(119,113) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,113)-(119,116) 25 "LanguageGenerator.mxg"
            __cb.Write("was");
            #line hidden
            #line (119,116)-(119,117) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,117)-(119,122) 25 "LanguageGenerator.mxg"
            __cb.Write("null.");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (120,13)-(120,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (120,16)-(120,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,17)-(120,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (121,13)-(121,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (121,19)-(121,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,20)-(121,26) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (121,26)-(121,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,27)-(121,31) 25 "LanguageGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (121,31)-(121,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,32)-(121,47) 25 "LanguageGenerator.mxg"
            __cb.Write("TryParse(string");
            #line hidden
            #line (121,47)-(121,48) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,48)-(121,56) 25 "LanguageGenerator.mxg"
            __cb.Write("version,");
            #line hidden
            #line (121,56)-(121,57) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,57)-(121,60) 25 "LanguageGenerator.mxg"
            __cb.Write("out");
            #line hidden
            #line (121,60)-(121,61) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,62)-(121,66) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (121,67)-(121,82) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (121,82)-(121,83) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,83)-(121,90) 25 "LanguageGenerator.mxg"
            __cb.Write("result)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (122,13)-(122,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (123,17)-(123,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (123,19)-(123,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,20)-(123,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (123,28)-(123,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,29)-(123,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (123,31)-(123,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,32)-(123,37) 25 "LanguageGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (124,17)-(124,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (125,21)-(125,27) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (125,27)-(125,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,28)-(125,29) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (125,29)-(125,30) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,31)-(125,35) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (125,36)-(125,60) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (126,21)-(126,27) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (126,27)-(126,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,28)-(126,33) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (127,17)-(127,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (128,17)-(128,23) 25 "LanguageGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (128,23)-(128,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,24)-(128,68) 25 "LanguageGenerator.mxg"
            __cb.Write("(CaseInsensitiveComparison.ToLower(version))");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (129,17)-(129,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (130,21)-(130,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (130,25)-(130,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,26)-(130,36) 25 "LanguageGenerator.mxg"
            __cb.Write("\"default\":");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (131,25)-(131,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (131,31)-(131,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,32)-(131,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (131,33)-(131,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,35)-(131,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (131,40)-(131,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (132,25)-(132,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (132,31)-(132,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,32)-(132,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (133,21)-(133,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (133,25)-(133,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,26)-(133,35) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latest\":");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (134,25)-(134,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (134,31)-(134,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,32)-(134,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (134,33)-(134,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,35)-(134,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (134,40)-(134,63) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Latest;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (135,25)-(135,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (135,31)-(135,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,32)-(135,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (136,21)-(136,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (136,25)-(136,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,26)-(136,40) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latestmajor\":");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (137,25)-(137,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (137,31)-(137,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,32)-(137,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (137,33)-(137,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,35)-(137,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (137,40)-(137,68) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.LatestMajor;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (138,25)-(138,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (138,31)-(138,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,32)-(138,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (139,21)-(139,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (139,25)-(139,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,26)-(139,36) 25 "LanguageGenerator.mxg"
            __cb.Write("\"preview\":");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (140,25)-(140,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (140,31)-(140,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,32)-(140,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (140,33)-(140,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,35)-(140,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (140,40)-(140,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Preview;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (141,25)-(141,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (141,31)-(141,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,32)-(141,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (142,21)-(142,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (142,25)-(142,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,26)-(142,30) 25 "LanguageGenerator.mxg"
            __cb.Write("\"1\":");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (143,21)-(143,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (143,25)-(143,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,26)-(143,32) 25 "LanguageGenerator.mxg"
            __cb.Write("\"1.0\":");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (144,25)-(144,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (144,31)-(144,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (144,32)-(144,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (144,33)-(144,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (144,35)-(144,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (144,40)-(144,65) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (145,25)-(145,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (145,31)-(145,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,32)-(145,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (146,21)-(146,29) 25 "LanguageGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (147,25)-(147,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (147,31)-(147,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,32)-(147,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (147,33)-(147,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,35)-(147,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (147,40)-(147,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (148,25)-(148,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (148,31)-(148,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,32)-(148,38) 25 "LanguageGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (149,17)-(149,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (150,13)-(150,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (152,13)-(152,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (152,16)-(152,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,17)-(152,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (153,13)-(153,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (153,16)-(153,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,17)-(153,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Map");
            #line hidden
            #line (153,20)-(153,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,21)-(153,22) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (153,22)-(153,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,23)-(153,31) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (153,31)-(153,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,32)-(153,39) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (153,39)-(153,40) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,40)-(153,45) 25 "LanguageGenerator.mxg"
            __cb.Write("(such");
            #line hidden
            #line (153,45)-(153,46) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,46)-(153,48) 25 "LanguageGenerator.mxg"
            __cb.Write("as");
            #line hidden
            #line (153,48)-(153,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,49)-(153,57) 25 "LanguageGenerator.mxg"
            __cb.Write("Default,");
            #line hidden
            #line (153,57)-(153,58) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,58)-(153,65) 25 "LanguageGenerator.mxg"
            __cb.Write("Latest,");
            #line hidden
            #line (153,65)-(153,66) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,66)-(153,68) 25 "LanguageGenerator.mxg"
            __cb.Write("or");
            #line hidden
            #line (153,68)-(153,69) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,69)-(153,78) 25 "LanguageGenerator.mxg"
            __cb.Write("VersionN)");
            #line hidden
            #line (153,78)-(153,79) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,79)-(153,81) 25 "LanguageGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (153,81)-(153,82) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,82)-(153,83) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (153,83)-(153,84) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,84)-(153,92) 25 "LanguageGenerator.mxg"
            __cb.Write("specific");
            #line hidden
            #line (153,92)-(153,93) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,93)-(153,100) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (153,100)-(153,101) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,101)-(153,112) 25 "LanguageGenerator.mxg"
            __cb.Write("(VersionM).");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,13)-(154,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (154,16)-(154,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,17)-(154,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (155,13)-(155,21) 25 "LanguageGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (155,21)-(155,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,22)-(155,28) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (155,28)-(155,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,30)-(155,34) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (155,35)-(155,50) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (155,50)-(155,51) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,51)-(155,86) 25 "LanguageGenerator.mxg"
            __cb.Write("MapSpecifiedToEffectiveVersion(this");
            #line hidden
            #line (155,86)-(155,87) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,88)-(155,92) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (155,93)-(155,108) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (155,108)-(155,109) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,109)-(155,117) 25 "LanguageGenerator.mxg"
            __cb.Write("version)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (156,13)-(156,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (157,17)-(157,23) 25 "LanguageGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (157,23)-(157,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,24)-(157,33) 25 "LanguageGenerator.mxg"
            __cb.Write("(version)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (158,17)-(158,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (159,21)-(159,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (159,25)-(159,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,27)-(159,31) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (159,32)-(159,55) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Latest:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (160,21)-(160,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (160,25)-(160,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,27)-(160,31) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (160,32)-(160,56) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (161,21)-(161,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (161,25)-(161,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,27)-(161,31) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (161,32)-(161,60) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.LatestMajor:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (162,25)-(162,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (162,31)-(162,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,33)-(162,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (162,38)-(162,63) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (163,21)-(163,29) 25 "LanguageGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (164,25)-(164,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (164,31)-(164,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,32)-(164,40) 25 "LanguageGenerator.mxg"
            __cb.Write("version;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (165,17)-(165,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (166,13)-(166,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (168,13)-(168,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (168,19)-(168,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,20)-(168,26) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (168,26)-(168,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,28)-(168,32) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (168,33)-(168,48) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (168,48)-(168,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,49)-(168,63) 25 "LanguageGenerator.mxg"
            __cb.Write("CurrentVersion");
            #line hidden
            #line (168,63)-(168,64) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,64)-(168,66) 25 "LanguageGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (168,66)-(168,67) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,68)-(168,72) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (168,73)-(168,98) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (169,9)-(169,10) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (171,5)-(171,6) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}