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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,5)-(16,14) 25 "LanguageGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (16,14)-(16,15) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,15)-(16,21) 25 "LanguageGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
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
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,5)-(19,6) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,9)-(24,10) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (38,13)-(38,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (39,17)-(39,36) 25 "LanguageGenerator.mxg"
            __cb.Write("RegisterServices();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (40,17)-(40,47) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegisterGlobal<SyntaxFacts,");
            #line hidden
            #line (40,47)-(40,48) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,49)-(40,53) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (40,54)-(40,69) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFacts>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (41,17)-(41,57) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegisterGlobal<InternalSyntaxFactory,");
            #line hidden
            #line (41,57)-(41,58) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,59)-(41,63) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (41,64)-(41,89) 25 "LanguageGenerator.mxg"
            __cb.Write("InternalSyntaxFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (42,17)-(42,49) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegisterGlobal<SyntaxFactory,");
            #line hidden
            #line (42,49)-(42,50) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,51)-(42,55) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (42,56)-(42,73) 25 "LanguageGenerator.mxg"
            __cb.Write("SyntaxFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (43,17)-(43,54) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegisterGlobal<CompilationFactory,");
            #line hidden
            #line (43,54)-(43,55) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,56)-(43,60) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (43,61)-(43,83) 25 "LanguageGenerator.mxg"
            __cb.Write("CompilationFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (44,17)-(44,63) 25 "LanguageGenerator.mxg"
            __cb.Write("TryRegisterCompilationScoped<SemanticsFactory,");
            #line hidden
            #line (44,63)-(44,64) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,65)-(44,69) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (44,70)-(44,90) 25 "LanguageGenerator.mxg"
            __cb.Write("SemanticsFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (45,13)-(45,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (47,13)-(47,20) 25 "LanguageGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (47,20)-(47,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,21)-(47,25) 25 "LanguageGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (47,25)-(47,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,26)-(47,45) 25 "LanguageGenerator.mxg"
            __cb.Write("RegisterServices();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,9)-(48,10) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (49,5)-(49,6) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (52,9)-(52,35) 22 "LanguageGenerator.mxg"
        public string GenerateLanguageVersion()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (53,5)-(53,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (53,10)-(53,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,11)-(53,33) 25 "LanguageGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (54,5)-(54,10) 25 "LanguageGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (54,10)-(54,11) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,11)-(54,28) 25 "LanguageGenerator.mxg"
            __cb.Write("Roslyn.Utilities;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (56,5)-(56,14) 25 "LanguageGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (56,14)-(56,15) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,15)-(56,21) 25 "LanguageGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (58,5)-(58,14) 25 "LanguageGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (58,14)-(58,15) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,16)-(58,25) 24 "LanguageGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (59,5)-(59,6) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (60,9)-(60,12) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (60,12)-(60,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,13)-(60,22) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (61,9)-(61,12) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (61,12)-(61,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,13)-(61,22) 25 "LanguageGenerator.mxg"
            __cb.Write("Specifies");
            #line hidden
            #line (61,22)-(61,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,23)-(61,26) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (61,26)-(61,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,27)-(61,35) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (61,35)-(61,36) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,36)-(61,44) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (62,9)-(62,12) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (62,12)-(62,13) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,13)-(62,23) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (63,9)-(63,15) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (63,15)-(63,16) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,16)-(63,20) 25 "LanguageGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (63,20)-(63,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,22)-(63,26) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (63,27)-(63,42) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (64,9)-(64,10) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (65,13)-(65,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (65,16)-(65,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,17)-(65,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,13)-(66,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (66,16)-(66,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,17)-(66,25) 25 "LanguageGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (66,25)-(66,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,26)-(66,33) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (66,33)-(66,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,34)-(66,35) 25 "LanguageGenerator.mxg"
            __cb.Write("1");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (67,13)-(67,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (67,16)-(67,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,17)-(67,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (68,13)-(68,21) 25 "LanguageGenerator.mxg"
            __cb.Write("Version1");
            #line hidden
            #line (68,21)-(68,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,22)-(68,23) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (68,23)-(68,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,24)-(68,26) 25 "LanguageGenerator.mxg"
            __cb.Write("1,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,13)-(70,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (70,16)-(70,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,17)-(70,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (71,13)-(71,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (71,16)-(71,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,17)-(71,20) 25 "LanguageGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (71,20)-(71,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,21)-(71,27) 25 "LanguageGenerator.mxg"
            __cb.Write("latest");
            #line hidden
            #line (71,27)-(71,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,28)-(71,33) 25 "LanguageGenerator.mxg"
            __cb.Write("major");
            #line hidden
            #line (71,33)-(71,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,34)-(71,43) 25 "LanguageGenerator.mxg"
            __cb.Write("supported");
            #line hidden
            #line (71,43)-(71,44) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,44)-(71,52) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,13)-(72,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (72,16)-(72,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,17)-(72,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,13)-(73,24) 25 "LanguageGenerator.mxg"
            __cb.Write("LatestMajor");
            #line hidden
            #line (73,24)-(73,25) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,25)-(73,26) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,26)-(73,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,27)-(73,39) 25 "LanguageGenerator.mxg"
            __cb.Write("int.MaxValue");
            #line hidden
            #line (73,39)-(73,40) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,40)-(73,41) 25 "LanguageGenerator.mxg"
            __cb.Write("-");
            #line hidden
            #line (73,41)-(73,42) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,42)-(73,44) 25 "LanguageGenerator.mxg"
            __cb.Write("2,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (75,13)-(75,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (75,16)-(75,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,17)-(75,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (76,13)-(76,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (76,16)-(76,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,17)-(76,24) 25 "LanguageGenerator.mxg"
            __cb.Write("Preview");
            #line hidden
            #line (76,24)-(76,25) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,25)-(76,27) 25 "LanguageGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (76,27)-(76,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,28)-(76,31) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (76,31)-(76,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,32)-(76,36) 25 "LanguageGenerator.mxg"
            __cb.Write("next");
            #line hidden
            #line (76,36)-(76,37) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,37)-(76,45) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (76,45)-(76,46) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,46)-(76,54) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (77,13)-(77,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (77,16)-(77,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,17)-(77,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,13)-(78,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Preview");
            #line hidden
            #line (78,20)-(78,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,21)-(78,22) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (78,22)-(78,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,23)-(78,35) 25 "LanguageGenerator.mxg"
            __cb.Write("int.MaxValue");
            #line hidden
            #line (78,35)-(78,36) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,36)-(78,37) 25 "LanguageGenerator.mxg"
            __cb.Write("-");
            #line hidden
            #line (78,37)-(78,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,38)-(78,40) 25 "LanguageGenerator.mxg"
            __cb.Write("1,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,13)-(80,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (80,16)-(80,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,17)-(80,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,13)-(81,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (81,16)-(81,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,17)-(81,20) 25 "LanguageGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (81,20)-(81,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,21)-(81,27) 25 "LanguageGenerator.mxg"
            __cb.Write("latest");
            #line hidden
            #line (81,27)-(81,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,28)-(81,37) 25 "LanguageGenerator.mxg"
            __cb.Write("supported");
            #line hidden
            #line (81,37)-(81,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,38)-(81,45) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (81,45)-(81,46) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,46)-(81,48) 25 "LanguageGenerator.mxg"
            __cb.Write("of");
            #line hidden
            #line (81,48)-(81,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,49)-(81,52) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (81,52)-(81,53) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,53)-(81,62) 25 "LanguageGenerator.mxg"
            __cb.Write("language.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,13)-(82,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (82,16)-(82,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,17)-(82,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,13)-(83,19) 25 "LanguageGenerator.mxg"
            __cb.Write("Latest");
            #line hidden
            #line (83,19)-(83,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,20)-(83,21) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (83,21)-(83,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,22)-(83,35) 25 "LanguageGenerator.mxg"
            __cb.Write("int.MaxValue,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,13)-(85,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (85,16)-(85,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,17)-(85,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (86,13)-(86,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (86,16)-(86,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,17)-(86,20) 25 "LanguageGenerator.mxg"
            __cb.Write("The");
            #line hidden
            #line (86,20)-(86,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,21)-(86,28) 25 "LanguageGenerator.mxg"
            __cb.Write("default");
            #line hidden
            #line (86,28)-(86,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,29)-(86,37) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (86,37)-(86,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,38)-(86,46) 25 "LanguageGenerator.mxg"
            __cb.Write("version,");
            #line hidden
            #line (86,46)-(86,47) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,47)-(86,52) 25 "LanguageGenerator.mxg"
            __cb.Write("which");
            #line hidden
            #line (86,52)-(86,53) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,53)-(86,55) 25 "LanguageGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (86,55)-(86,56) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,56)-(86,59) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (86,59)-(86,60) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,60)-(86,66) 25 "LanguageGenerator.mxg"
            __cb.Write("latest");
            #line hidden
            #line (86,66)-(86,67) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,67)-(86,76) 25 "LanguageGenerator.mxg"
            __cb.Write("supported");
            #line hidden
            #line (86,76)-(86,77) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,77)-(86,85) 25 "LanguageGenerator.mxg"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (87,13)-(87,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (87,16)-(87,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,17)-(87,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (88,13)-(88,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Default");
            #line hidden
            #line (88,20)-(88,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,21)-(88,22) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (88,22)-(88,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,23)-(88,25) 25 "LanguageGenerator.mxg"
            __cb.Write("0,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (89,9)-(89,10) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (91,9)-(91,15) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (91,15)-(91,16) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,16)-(91,22) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (91,22)-(91,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,23)-(91,28) 25 "LanguageGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (91,28)-(91,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,30)-(91,34) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (91,35)-(91,55) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersionFacts");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (92,9)-(92,10) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (93,13)-(93,21) 25 "LanguageGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (93,21)-(93,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,22)-(93,28) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (93,28)-(93,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,29)-(93,33) 25 "LanguageGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (93,33)-(93,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,34)-(93,46) 25 "LanguageGenerator.mxg"
            __cb.Write("IsValid(this");
            #line hidden
            #line (93,46)-(93,47) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,48)-(93,52) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (93,53)-(93,68) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (93,68)-(93,69) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,69)-(93,75) 25 "LanguageGenerator.mxg"
            __cb.Write("value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (94,13)-(94,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (95,17)-(95,23) 25 "LanguageGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (95,23)-(95,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,24)-(95,31) 25 "LanguageGenerator.mxg"
            __cb.Write("(value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (96,17)-(96,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
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
            #line (97,32)-(97,57) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (98,21)-(98,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (98,25)-(98,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,27)-(98,31) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (98,32)-(98,56) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Preview:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (99,25)-(99,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (99,31)-(99,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,32)-(99,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (100,17)-(100,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (102,17)-(102,23) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (102,23)-(102,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,24)-(102,30) 25 "LanguageGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (103,13)-(103,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (105,13)-(105,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (105,16)-(105,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,17)-(105,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (106,13)-(106,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (106,16)-(106,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,17)-(106,25) 25 "LanguageGenerator.mxg"
            __cb.Write("Displays");
            #line hidden
            #line (106,25)-(106,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,26)-(106,29) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (106,29)-(106,30) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,30)-(106,37) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (106,37)-(106,38) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,38)-(106,44) 25 "LanguageGenerator.mxg"
            __cb.Write("number");
            #line hidden
            #line (106,44)-(106,45) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,45)-(106,47) 25 "LanguageGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (106,47)-(106,48) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,48)-(106,51) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (106,51)-(106,52) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,52)-(106,58) 25 "LanguageGenerator.mxg"
            __cb.Write("format");
            #line hidden
            #line (106,58)-(106,59) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,59)-(106,67) 25 "LanguageGenerator.mxg"
            __cb.Write("expected");
            #line hidden
            #line (106,67)-(106,68) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,68)-(106,70) 25 "LanguageGenerator.mxg"
            __cb.Write("on");
            #line hidden
            #line (106,70)-(106,71) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,71)-(106,74) 25 "LanguageGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (106,74)-(106,75) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,75)-(106,87) 25 "LanguageGenerator.mxg"
            __cb.Write("command-line");
            #line hidden
            #line (106,87)-(106,88) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,88)-(106,97) 25 "LanguageGenerator.mxg"
            __cb.Write("(/langver");
            #line hidden
            #line (106,97)-(106,98) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,98)-(106,104) 25 "LanguageGenerator.mxg"
            __cb.Write("flag).");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (107,13)-(107,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (107,16)-(107,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,17)-(107,20) 25 "LanguageGenerator.mxg"
            __cb.Write("For");
            #line hidden
            #line (107,20)-(107,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,21)-(107,30) 25 "LanguageGenerator.mxg"
            __cb.Write("instance,");
            #line hidden
            #line (107,30)-(107,31) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,31)-(107,35) 25 "LanguageGenerator.mxg"
            __cb.Write("\"6\",");
            #line hidden
            #line (107,35)-(107,36) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,36)-(107,40) 25 "LanguageGenerator.mxg"
            __cb.Write("\"7\",");
            #line hidden
            #line (107,40)-(107,41) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,41)-(107,47) 25 "LanguageGenerator.mxg"
            __cb.Write("\"7.1\",");
            #line hidden
            #line (107,47)-(107,48) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,48)-(107,57) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latest\".");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (108,13)-(108,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (108,16)-(108,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,17)-(108,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (109,13)-(109,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (109,19)-(109,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,20)-(109,26) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (109,26)-(109,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,27)-(109,33) 25 "LanguageGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (109,33)-(109,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,34)-(109,54) 25 "LanguageGenerator.mxg"
            __cb.Write("ToDisplayString(this");
            #line hidden
            #line (109,54)-(109,55) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,56)-(109,60) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (109,61)-(109,76) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (109,76)-(109,77) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,77)-(109,85) 25 "LanguageGenerator.mxg"
            __cb.Write("version)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (110,13)-(110,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
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
            #line (111,38)-(111,63) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1)");
            #line hidden
            #line (111,63)-(111,64) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,64)-(111,70) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (111,70)-(111,71) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,71)-(111,75) 25 "LanguageGenerator.mxg"
            __cb.Write("\"1\";");
            #line hidden
            __cb.WriteLine();
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
            #line (112,38)-(112,62) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default)");
            #line hidden
            #line (112,62)-(112,63) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,63)-(112,69) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (112,69)-(112,70) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,70)-(112,80) 25 "LanguageGenerator.mxg"
            __cb.Write("\"default\";");
            #line hidden
            __cb.WriteLine();
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
            #line (113,38)-(113,61) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Latest)");
            #line hidden
            #line (113,61)-(113,62) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,62)-(113,68) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (113,68)-(113,69) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,69)-(113,78) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latest\";");
            #line hidden
            __cb.WriteLine();
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
            #line (114,38)-(114,66) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.LatestMajor)");
            #line hidden
            #line (114,66)-(114,67) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,67)-(114,73) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (114,73)-(114,74) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,74)-(114,88) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latestmajor\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (115,17)-(115,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (115,19)-(115,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,20)-(115,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (115,28)-(115,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,29)-(115,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (115,31)-(115,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,33)-(115,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (115,38)-(115,62) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Preview)");
            #line hidden
            #line (115,62)-(115,63) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,63)-(115,69) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (115,69)-(115,70) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,70)-(115,80) 25 "LanguageGenerator.mxg"
            __cb.Write("\"preview\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (116,17)-(116,22) 25 "LanguageGenerator.mxg"
            __cb.Write("throw");
            #line hidden
            #line (116,22)-(116,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (116,23)-(116,67) 25 "LanguageGenerator.mxg"
            __cb.Write("ExceptionUtilities.UnexpectedValue(version);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (117,13)-(117,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (119,13)-(119,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (119,16)-(119,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,17)-(119,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (120,13)-(120,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (120,16)-(120,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,17)-(120,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Try");
            #line hidden
            #line (120,20)-(120,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,21)-(120,26) 25 "LanguageGenerator.mxg"
            __cb.Write("parse");
            #line hidden
            #line (120,26)-(120,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,27)-(120,28) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (120,28)-(120,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,29)-(120,33) 25 "LanguageGenerator.mxg"
            __cb.Write("<see");
            #line hidden
            #line (120,33)-(120,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,34)-(120,40) 25 "LanguageGenerator.mxg"
            __cb.Write("cref=\"");
            #line hidden
            #line (120,41)-(120,45) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (120,46)-(120,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion\"/>");
            #line hidden
            #line (120,64)-(120,65) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,65)-(120,69) 25 "LanguageGenerator.mxg"
            __cb.Write("from");
            #line hidden
            #line (120,69)-(120,70) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,70)-(120,71) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (120,71)-(120,72) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,72)-(120,78) 25 "LanguageGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (120,78)-(120,79) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,79)-(120,85) 25 "LanguageGenerator.mxg"
            __cb.Write("input,");
            #line hidden
            #line (120,85)-(120,86) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,86)-(120,95) 25 "LanguageGenerator.mxg"
            __cb.Write("returning");
            #line hidden
            #line (120,95)-(120,96) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,96)-(120,103) 25 "LanguageGenerator.mxg"
            __cb.Write("default");
            #line hidden
            #line (120,103)-(120,104) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,104)-(120,106) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (120,106)-(120,107) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,107)-(120,112) 25 "LanguageGenerator.mxg"
            __cb.Write("input");
            #line hidden
            #line (120,112)-(120,113) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,113)-(120,116) 25 "LanguageGenerator.mxg"
            __cb.Write("was");
            #line hidden
            #line (120,116)-(120,117) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,117)-(120,122) 25 "LanguageGenerator.mxg"
            __cb.Write("null.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (121,13)-(121,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (121,16)-(121,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,17)-(121,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (122,13)-(122,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (122,19)-(122,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,20)-(122,26) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (122,26)-(122,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,27)-(122,31) 25 "LanguageGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (122,31)-(122,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,32)-(122,47) 25 "LanguageGenerator.mxg"
            __cb.Write("TryParse(string");
            #line hidden
            #line (122,47)-(122,48) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,48)-(122,56) 25 "LanguageGenerator.mxg"
            __cb.Write("version,");
            #line hidden
            #line (122,56)-(122,57) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,57)-(122,60) 25 "LanguageGenerator.mxg"
            __cb.Write("out");
            #line hidden
            #line (122,60)-(122,61) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,62)-(122,66) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (122,67)-(122,82) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (122,82)-(122,83) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,83)-(122,90) 25 "LanguageGenerator.mxg"
            __cb.Write("result)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (123,13)-(123,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (124,17)-(124,19) 25 "LanguageGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (124,19)-(124,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,20)-(124,28) 25 "LanguageGenerator.mxg"
            __cb.Write("(version");
            #line hidden
            #line (124,28)-(124,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,29)-(124,31) 25 "LanguageGenerator.mxg"
            __cb.Write("==");
            #line hidden
            #line (124,31)-(124,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,32)-(124,37) 25 "LanguageGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (125,17)-(125,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (126,21)-(126,27) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (126,27)-(126,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,28)-(126,29) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (126,29)-(126,30) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,31)-(126,35) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (126,36)-(126,60) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (127,21)-(127,27) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (127,27)-(127,28) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,28)-(127,33) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (128,17)-(128,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (129,17)-(129,23) 25 "LanguageGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (129,23)-(129,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,24)-(129,68) 25 "LanguageGenerator.mxg"
            __cb.Write("(CaseInsensitiveComparison.ToLower(version))");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (130,17)-(130,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (131,21)-(131,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (131,25)-(131,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,26)-(131,36) 25 "LanguageGenerator.mxg"
            __cb.Write("\"default\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (132,25)-(132,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (132,31)-(132,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,32)-(132,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (132,33)-(132,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,35)-(132,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (132,40)-(132,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (133,25)-(133,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (133,31)-(133,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,32)-(133,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (134,21)-(134,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (134,25)-(134,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,26)-(134,35) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latest\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (135,25)-(135,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (135,31)-(135,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,32)-(135,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (135,33)-(135,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,35)-(135,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (135,40)-(135,63) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Latest;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (136,25)-(136,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (136,31)-(136,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,32)-(136,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (137,21)-(137,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (137,25)-(137,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,26)-(137,40) 25 "LanguageGenerator.mxg"
            __cb.Write("\"latestmajor\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (138,25)-(138,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (138,31)-(138,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,32)-(138,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (138,33)-(138,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,35)-(138,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (138,40)-(138,68) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.LatestMajor;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (139,25)-(139,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (139,31)-(139,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,32)-(139,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (140,21)-(140,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (140,25)-(140,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,26)-(140,36) 25 "LanguageGenerator.mxg"
            __cb.Write("\"preview\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (141,25)-(141,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (141,31)-(141,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,32)-(141,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (141,33)-(141,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,35)-(141,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (141,40)-(141,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Preview;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (142,25)-(142,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (142,31)-(142,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,32)-(142,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (143,21)-(143,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (143,25)-(143,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,26)-(143,30) 25 "LanguageGenerator.mxg"
            __cb.Write("\"1\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (144,21)-(144,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (144,25)-(144,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (144,26)-(144,32) 25 "LanguageGenerator.mxg"
            __cb.Write("\"1.0\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (145,25)-(145,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (145,31)-(145,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,32)-(145,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (145,33)-(145,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,35)-(145,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (145,40)-(145,65) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (146,25)-(146,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (146,31)-(146,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (146,32)-(146,37) 25 "LanguageGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (147,21)-(147,29) 25 "LanguageGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (148,25)-(148,31) 25 "LanguageGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (148,31)-(148,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,32)-(148,33) 25 "LanguageGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (148,33)-(148,34) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,35)-(148,39) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (148,40)-(148,64) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (149,25)-(149,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (149,31)-(149,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,32)-(149,38) 25 "LanguageGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (150,17)-(150,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (151,13)-(151,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (153,13)-(153,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (153,16)-(153,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,17)-(153,26) 25 "LanguageGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,13)-(154,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (154,16)-(154,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,17)-(154,20) 25 "LanguageGenerator.mxg"
            __cb.Write("Map");
            #line hidden
            #line (154,20)-(154,21) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,21)-(154,22) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (154,22)-(154,23) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,23)-(154,31) 25 "LanguageGenerator.mxg"
            __cb.Write("language");
            #line hidden
            #line (154,31)-(154,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,32)-(154,39) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (154,39)-(154,40) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,40)-(154,45) 25 "LanguageGenerator.mxg"
            __cb.Write("(such");
            #line hidden
            #line (154,45)-(154,46) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,46)-(154,48) 25 "LanguageGenerator.mxg"
            __cb.Write("as");
            #line hidden
            #line (154,48)-(154,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,49)-(154,57) 25 "LanguageGenerator.mxg"
            __cb.Write("Default,");
            #line hidden
            #line (154,57)-(154,58) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,58)-(154,65) 25 "LanguageGenerator.mxg"
            __cb.Write("Latest,");
            #line hidden
            #line (154,65)-(154,66) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,66)-(154,68) 25 "LanguageGenerator.mxg"
            __cb.Write("or");
            #line hidden
            #line (154,68)-(154,69) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,69)-(154,78) 25 "LanguageGenerator.mxg"
            __cb.Write("VersionN)");
            #line hidden
            #line (154,78)-(154,79) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,79)-(154,81) 25 "LanguageGenerator.mxg"
            __cb.Write("to");
            #line hidden
            #line (154,81)-(154,82) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,82)-(154,83) 25 "LanguageGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (154,83)-(154,84) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,84)-(154,92) 25 "LanguageGenerator.mxg"
            __cb.Write("specific");
            #line hidden
            #line (154,92)-(154,93) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,93)-(154,100) 25 "LanguageGenerator.mxg"
            __cb.Write("version");
            #line hidden
            #line (154,100)-(154,101) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,101)-(154,112) 25 "LanguageGenerator.mxg"
            __cb.Write("(VersionM).");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (155,13)-(155,16) 25 "LanguageGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (155,16)-(155,17) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,17)-(155,27) 25 "LanguageGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (156,13)-(156,21) 25 "LanguageGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (156,21)-(156,22) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,22)-(156,28) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (156,28)-(156,29) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,30)-(156,34) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (156,35)-(156,50) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (156,50)-(156,51) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,51)-(156,86) 25 "LanguageGenerator.mxg"
            __cb.Write("MapSpecifiedToEffectiveVersion(this");
            #line hidden
            #line (156,86)-(156,87) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,88)-(156,92) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (156,93)-(156,108) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (156,108)-(156,109) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,109)-(156,117) 25 "LanguageGenerator.mxg"
            __cb.Write("version)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (157,13)-(157,14) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (158,17)-(158,23) 25 "LanguageGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (158,23)-(158,24) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,24)-(158,33) 25 "LanguageGenerator.mxg"
            __cb.Write("(version)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (159,17)-(159,18) 25 "LanguageGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
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
            #line (160,32)-(160,55) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Latest:");
            #line hidden
            __cb.WriteLine();
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
            #line (161,32)-(161,56) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (162,21)-(162,25) 25 "LanguageGenerator.mxg"
            __cb.Write("case");
            #line hidden
            #line (162,25)-(162,26) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,27)-(162,31) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (162,32)-(162,60) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.LatestMajor:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (163,25)-(163,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (163,31)-(163,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,33)-(163,37) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (163,38)-(163,63) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (164,21)-(164,29) 25 "LanguageGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (165,25)-(165,31) 25 "LanguageGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (165,31)-(165,32) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,32)-(165,40) 25 "LanguageGenerator.mxg"
            __cb.Write("version;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (166,17)-(166,18) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (167,13)-(167,14) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (169,13)-(169,19) 25 "LanguageGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (169,19)-(169,20) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,20)-(169,26) 25 "LanguageGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (169,26)-(169,27) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,28)-(169,32) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (169,33)-(169,48) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (169,48)-(169,49) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,49)-(169,63) 25 "LanguageGenerator.mxg"
            __cb.Write("CurrentVersion");
            #line hidden
            #line (169,63)-(169,64) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,64)-(169,66) 25 "LanguageGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (169,66)-(169,67) 25 "LanguageGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,68)-(169,72) 24 "LanguageGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (169,73)-(169,98) 25 "LanguageGenerator.mxg"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (170,9)-(170,10) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (172,5)-(172,6) 25 "LanguageGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}