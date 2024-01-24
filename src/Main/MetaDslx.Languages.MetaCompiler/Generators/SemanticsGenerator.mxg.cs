#line (1,10)-(1,53) 10 "SemanticsGenerator.mxg"
namespace MetaDslx.Languages.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "SemanticsGenerator.mxg"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,13) 13 "SemanticsGenerator.mxg"
    System;
    #line hidden
    #line (5,1)-(5,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,33) 13 "SemanticsGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (6,1)-(6,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,35) 13 "SemanticsGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (7,1)-(7,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (7,7)-(7,18) 13 "SemanticsGenerator.mxg"
    System.Linq;
    #line hidden
    
    #line (9,10)-(9,29) 25 "SemanticsGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (12,9)-(12,36) 22 "SemanticsGenerator.mxg"
        public string GenerateSemanticsFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,1)-(15,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,6)-(15,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,7)-(15,42) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,1)-(16,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (16,6)-(16,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,7)-(16,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (18,1)-(18,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (18,10)-(18,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,11)-(18,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,1)-(20,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (20,10)-(20,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,12)-(20,21) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (21,1)-(21,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (22,11)-(22,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,12)-(22,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (22,17)-(22,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,19)-(22,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (22,24)-(22,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            #line (22,40)-(22,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,41)-(22,42) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (22,42)-(22,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,43)-(22,59) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,5)-(23,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (24,9)-(24,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (24,15)-(24,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,17)-(24,21) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (24,22)-(24,50) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory(Compilation");
            #line hidden
            #line (24,50)-(24,51) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,51)-(24,63) 25 "SemanticsGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (24,63)-(24,64) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,64)-(24,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (24,72)-(24,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,73)-(24,82) 25 "SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            #line (24,82)-(24,83) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (25,13)-(25,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (25,14)-(25,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,15)-(25,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("base(compilation,");
            #line hidden
            #line (25,32)-(25,33) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,33)-(25,42) 25 "SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,9)-(26,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,9)-(27,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,9)-(29,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (29,15)-(29,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,16)-(29,24) 25 "SemanticsGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (29,24)-(29,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,25)-(29,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (29,45)-(29,46) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,46)-(29,86) 25 "SemanticsGenerator.mxg"
            __cb.Write("CreateBinderFactoryVisitor(BinderFactory");
            #line hidden
            #line (29,86)-(29,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,87)-(29,101) 25 "SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (30,9)-(30,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (31,13)-(31,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (31,19)-(31,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,20)-(31,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (31,23)-(31,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,24)-(31,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (31,33)-(31,42) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (31,43)-(31,52) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Binding.");
            #line hidden
            #line (31,53)-(31,57) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (31,58)-(31,94) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(binderFactory);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (32,9)-(32,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (33,5)-(33,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (34,1)-(34,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (38,9)-(38,40) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitor()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (39,1)-(39,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,6)-(39,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,7)-(39,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (40,1)-(40,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (40,6)-(40,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,7)-(40,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (41,1)-(41,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (41,6)-(41,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,7)-(41,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (43,1)-(43,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (43,10)-(43,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,11)-(43,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,1)-(45,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (45,10)-(45,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,12)-(45,21) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (45,22)-(45,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Binding");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (46,1)-(46,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (47,5)-(47,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (47,10)-(47,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,11)-(47,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (47,20)-(47,29) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (47,30)-(47,38) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,5)-(49,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (49,11)-(49,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,12)-(49,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (49,17)-(49,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,19)-(49,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (49,24)-(49,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (49,44)-(49,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,45)-(49,46) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (49,46)-(49,47) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,47)-(49,98) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor,");
            #line hidden
            #line (49,98)-(49,99) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,99)-(49,100) 25 "SemanticsGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (49,101)-(49,105) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (49,106)-(49,119) 25 "SemanticsGenerator.mxg"
            __cb.Write("SyntaxVisitor");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,5)-(50,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (51,9)-(51,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (51,17)-(51,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,19)-(51,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (51,24)-(51,88) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory");
            #line hidden
            #line (51,88)-(51,89) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,89)-(51,103) 25 "SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (52,13)-(52,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (52,14)-(52,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,15)-(52,34) 25 "SemanticsGenerator.mxg"
            __cb.Write("base(binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (53,9)-(53,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (54,9)-(54,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first71 = true;
            #line (56,4)-(56,31) 13 "SemanticsGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                var __first72 = true;
                #line (57,5)-(57,43) 17 "SemanticsGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first72)
                    {
                        __first72 = false;
                    }
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (59,10)-(59,47) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisit(rule, alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first72) __cb.AppendLine();
            }
            if (!__first71) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (63,3)-(63,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (63,9)-(63,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,10)-(63,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (63,17)-(63,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,18)-(63,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (63,22)-(63,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,23)-(63,48) 25 "SemanticsGenerator.mxg"
            __cb.Write("VisitSkippedTokensTrivia(");
            #line hidden
            #line (63,49)-(63,53) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (63,54)-(63,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("SkippedTokensTriviaSyntax");
            #line hidden
            #line (63,79)-(63,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,80)-(63,85) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (64,3)-(64,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (65,3)-(65,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (66,5)-(66,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (67,1)-(67,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (70,9)-(70,64) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisit(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (71,1)-(71,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (71,7)-(71,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,8)-(71,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (71,15)-(71,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,16)-(71,20) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (71,20)-(71,21) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,21)-(71,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("Visit");
            #line hidden
            #line (71,27)-(71,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (71,42)-(71,43) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (71,44)-(71,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.RedName);
            #line hidden
            #line (71,56)-(71,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,57)-(71,62) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (72,1)-(72,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (73,6)-(73,35) 13 "SemanticsGenerator.mxg"
            if (rule == Grammar.MainRule)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("    ");
                #line (74,5)-(74,7) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (74,7)-(74,8) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (74,8)-(74,21) 29 "SemanticsGenerator.mxg"
                __cb.Write("(this.IsRoot)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (75,5)-(75,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first74 = true;
                #line (76,10)-(76,47) 17 "SemanticsGenerator.mxg"
                if (Grammar.RootTypeName is not null)
                #line hidden
                
                {
                    if (__first74)
                    {
                        __first74 = false;
                    }
                    __cb.Push("        ");
                    #line (77,9)-(77,12) 33 "SemanticsGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (77,12)-(77,13) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,13)-(77,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__rootAnnot");
                    #line hidden
                    #line (77,24)-(77,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,25)-(77,26) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (77,26)-(77,27) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,27)-(77,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (77,30)-(77,31) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,31)-(77,96) 33 "SemanticsGenerator.mxg"
                    __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree,");
                    #line hidden
                    #line (77,96)-(77,97) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,97)-(77,102) 33 "SemanticsGenerator.mxg"
                    __cb.Write("type:");
                    #line hidden
                    #line (77,102)-(77,103) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (77,103)-(77,110) 33 "SemanticsGenerator.mxg"
                    __cb.Write("typeof(");
                    #line hidden
                    #line (77,111)-(77,131) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Grammar.RootTypeName);
                    #line hidden
                    #line (77,132)-(77,135) 33 "SemanticsGenerator.mxg"
                    __cb.Write("));");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (78,10)-(78,14) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first74)
                    {
                        __first74 = false;
                    }
                    __cb.Push("        ");
                    #line (79,9)-(79,12) 33 "SemanticsGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (79,12)-(79,13) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,13)-(79,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__rootAnnot");
                    #line hidden
                    #line (79,24)-(79,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,25)-(79,26) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (79,26)-(79,27) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,27)-(79,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (79,30)-(79,31) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,31)-(79,96) 33 "SemanticsGenerator.mxg"
                    __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree,");
                    #line hidden
                    #line (79,96)-(79,97) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,97)-(79,102) 33 "SemanticsGenerator.mxg"
                    __cb.Write("type:");
                    #line hidden
                    #line (79,102)-(79,103) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (79,103)-(79,109) 33 "SemanticsGenerator.mxg"
                    __cb.Write("null);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first74) __cb.AppendLine();
                __cb.Push("        ");
                #line (81,9)-(81,32) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Begin(__rootAnnot,");
                #line hidden
                #line (81,32)-(81,33) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (81,33)-(81,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("node);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (82,9)-(82,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("try");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (83,9)-(83,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (84,14)-(84,55) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (85,9)-(85,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (86,9)-(86,16) 29 "SemanticsGenerator.mxg"
                __cb.Write("finally");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (87,9)-(87,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (88,13)-(88,35) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.End(__rootAnnot);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (89,9)-(89,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (90,5)-(90,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (91,5)-(91,9) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (92,5)-(92,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    \t");
                #line (93,7)-(93,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (94,5)-(94,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (95,6)-(95,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("\t");
                #line (96,3)-(96,44) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first73) __cb.AppendLine();
            __cb.Push("");
            #line (98,1)-(98,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (101,9)-(101,68) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBody(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (102,2)-(102,20) 13 "SemanticsGenerator.mxg"
            var annotIndex = 0;
            #line hidden
            
            #line (103,2)-(103,68) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitElements(alt, ref annotIndex);
            #line hidden
            
            #line (104,2)-(104,92) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(alt.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            #line (105,2)-(105,93) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(rule.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (106,2)-(106,6) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (109,9)-(109,81) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElements(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first75 = true;
            #line (110,2)-(110,66) 13 "SemanticsGenerator.mxg"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first75)
                {
                    __first75 = false;
                }
                __cb.Push("");
                #line (111,2)-(111,62) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElement(alt, elem, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (112,14)-(112,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("    ");
            #line hidden
            return __cb.ToStringAndFree();
        }
        
        #line (115,9)-(115,136) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinders(IEnumerable<Binder> binders, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first76 = true;
            #line (116,2)-(116,78) 13 "SemanticsGenerator.mxg"
            foreach (var binder in binders.Where(b => b.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (117,2)-(117,81) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinder(binder, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first76) __cb.AppendLine();
            __cb.Push("");
            #line (119,2)-(119,6) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (122,9)-(122,107) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinder(Binder binder, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (123,2)-(123,46) 13 "SemanticsGenerator.mxg"
            var binderVarName = "__annot"+(annotIndex++);
            #line hidden
            
            __cb.Push("");
            #line (124,1)-(124,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (124,4)-(124,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,6)-(124,19) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (124,20)-(124,21) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,21)-(124,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (124,22)-(124,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,23)-(124,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (124,26)-(124,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,28)-(124,43) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.TypeName);
            #line hidden
            #line (124,44)-(124,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (124,46)-(124,73) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.ConstructorArguments);
            #line hidden
            #line (124,74)-(124,76) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (125,1)-(125,12) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.Begin(");
            #line hidden
            #line (125,13)-(125,26) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (125,27)-(125,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (125,28)-(125,29) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,30)-(125,38) 24 "SemanticsGenerator.mxg"
            __cb.Write(nodeName);
            #line hidden
            #line (125,39)-(125,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (126,1)-(126,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("try");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (127,1)-(127,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (128,6)-(128,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (129,1)-(129,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (130,1)-(130,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("finally");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (131,1)-(131,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (132,5)-(132,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.End(");
            #line hidden
            #line (132,15)-(132,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (132,29)-(132,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (133,1)-(133,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (136,9)-(136,94) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElement(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (137,6)-(137,105) 13 "SemanticsGenerator.mxg"
            var isList = MetaDslx.Languages.MetaCompiler.Model.MultiplicityExtensions.IsList(elem.Multiplicity);
            #line hidden
            
            #line (138,6)-(138,113) 13 "SemanticsGenerator.mxg"
            var isOptional = MetaDslx.Languages.MetaCompiler.Model.MultiplicityExtensions.IsOptional(elem.Multiplicity);
            #line hidden
            
            var __first77 = true;
            #line (139,6)-(139,17) 13 "SemanticsGenerator.mxg"
            if (isList)
            #line hidden
            
            {
                if (__first77)
                {
                    __first77 = false;
                }
                #line (140,10)-(140,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (141,2)-(141,78) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitListElements(alt, elem, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (142,2)-(142,88) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (143,6)-(143,46) 13 "SemanticsGenerator.mxg"
            else if (elem.Value is SeparatedList sl)
            #line hidden
            
            {
                if (__first77)
                {
                    __first77 = false;
                }
                #line (144,10)-(144,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (145,2)-(145,91) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitSeparatedListElements(alt, elem, sl, ref annotIndex);
                #line hidden
                
                #line (146,2)-(146,93) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(sl.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (147,2)-(147,88) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (148,6)-(148,26) 13 "SemanticsGenerator.mxg"
            else if (isOptional)
            #line hidden
            
            {
                if (__first77)
                {
                    __first77 = false;
                }
                #line (149,10)-(149,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (150,1)-(150,3) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (150,3)-(150,4) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (150,4)-(150,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (150,6)-(150,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                var __first78 = true;
                #line (150,16)-(150,33) 17 "SemanticsGenerator.mxg"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first78)
                    {
                        __first78 = false;
                    }
                    #line (150,34)-(150,38) 33 "SemanticsGenerator.mxg"
                    __cb.Write(".Get");
                    #line hidden
                    #line (150,39)-(150,43) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (150,44)-(150,50) 33 "SemanticsGenerator.mxg"
                    __cb.Write("Kind()");
                    #line hidden
                    #line (150,50)-(150,51) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (150,51)-(150,53) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (150,53)-(150,54) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (150,55)-(150,59) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (150,60)-(150,75) 33 "SemanticsGenerator.mxg"
                    __cb.Write("SyntaxKind.None");
                    #line hidden
                }
                #line (150,76)-(150,80) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first78)
                    {
                        __first78 = false;
                    }
                    #line (150,81)-(150,82) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (150,82)-(150,84) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (150,84)-(150,85) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (150,85)-(150,89) 33 "SemanticsGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                }
                #line (150,97)-(150,98) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (151,1)-(151,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (152,6)-(152,94) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (153,1)-(153,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (154,6)-(154,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first77)
                {
                    __first77 = false;
                }
                #line (155,10)-(155,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (156,2)-(156,90) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first77) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (160,9)-(160,99) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitListElements(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (161,1)-(161,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (161,4)-(161,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,6)-(161,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (161,25)-(161,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (161,29)-(161,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,30)-(161,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (161,31)-(161,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,32)-(161,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (161,38)-(161,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (161,56)-(161,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (162,2)-(162,44) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (163,1)-(163,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (163,4)-(163,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,5)-(163,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (163,9)-(163,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,11)-(163,20) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (163,21)-(163,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,22)-(163,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (163,23)-(163,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,24)-(163,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (163,26)-(163,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,28)-(163,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (163,38)-(163,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,39)-(163,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (163,40)-(163,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,42)-(163,60) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (163,61)-(163,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (163,72)-(163,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,73)-(163,75) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (163,76)-(163,85) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (163,86)-(163,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (164,1)-(164,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (165,6)-(165,64) 13 "SemanticsGenerator.mxg"
            var elemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            __cb.Push("    ");
            #line (166,6)-(166,95) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (167,1)-(167,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (170,9)-(170,128) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListElements(Alternative alt, Element elem, SeparatedList list, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (171,1)-(171,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (171,4)-(171,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,6)-(171,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (171,25)-(171,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (171,29)-(171,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,30)-(171,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (171,31)-(171,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,32)-(171,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (171,38)-(171,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (171,56)-(171,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (172,2)-(172,44) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (173,1)-(173,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (173,4)-(173,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,5)-(173,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (173,9)-(173,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,11)-(173,20) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (173,21)-(173,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,22)-(173,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (173,23)-(173,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,24)-(173,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (173,26)-(173,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,28)-(173,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (173,38)-(173,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,39)-(173,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (173,40)-(173,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,42)-(173,60) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (173,61)-(173,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (173,72)-(173,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,73)-(173,75) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (173,76)-(173,85) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (173,86)-(173,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (174,1)-(174,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (175,5)-(175,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (175,9)-(175,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,10)-(175,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("__itemHandled");
            #line hidden
            #line (175,23)-(175,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,24)-(175,25) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (175,25)-(175,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,26)-(175,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (176,5)-(176,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (176,9)-(176,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,10)-(176,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("__sepHandled");
            #line hidden
            #line (176,22)-(176,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,23)-(176,24) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (176,24)-(176,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,25)-(176,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (177,6)-(177,64) 13 "SemanticsGenerator.mxg"
            var itemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            #line (178,6)-(178,76) 13 "SemanticsGenerator.mxg"
            var sepName = "node."+elem.PropertyName+".GetSeparator("+indexName+")";
            #line hidden
            
            #line (179,6)-(179,82) 13 "SemanticsGenerator.mxg"
            var firstCount = Math.Max(list.FirstItems.Count, list.FirstSeparators.Count);
            #line hidden
            
            #line (180,6)-(180,79) 13 "SemanticsGenerator.mxg"
            var lastCount = Math.Min(list.LastItems.Count, list.LastSeparators.Count);
            #line hidden
            
            #line (181,6)-(181,21) 13 "SemanticsGenerator.mxg"
            var ifElse = "";
            #line hidden
            
            var __first79 = true;
            #line (182,6)-(182,46) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < firstCount - 1; ++i)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                __cb.Push("    ");
                #line (183,6)-(183,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (183,13)-(183,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (183,15)-(183,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (183,16)-(183,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (183,18)-(183,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (183,28)-(183,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (183,29)-(183,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (183,31)-(183,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (183,33)-(183,34) 28 "SemanticsGenerator.mxg"
                __cb.Write(i);
                #line hidden
                #line (183,35)-(183,36) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (184,5)-(184,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (185,10)-(185,154) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.FirstItems[i], sepName, list.FirstSeparators[i], list.SeparatorFirst, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (186,9)-(186,22) 29 "SemanticsGenerator.mxg"
                __cb.Write("__itemHandled");
                #line hidden
                #line (186,22)-(186,23) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,23)-(186,24) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (186,24)-(186,25) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,25)-(186,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (187,9)-(187,21) 29 "SemanticsGenerator.mxg"
                __cb.Write("__sepHandled");
                #line hidden
                #line (187,21)-(187,22) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (187,22)-(187,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (187,23)-(187,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (187,24)-(187,29) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (188,5)-(188,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (189,10)-(189,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first79) __cb.AppendLine();
            var __first80 = true;
            #line (191,6)-(191,25) 13 "SemanticsGenerator.mxg"
            if (firstCount > 0)
            #line hidden
            
            {
                if (__first80)
                {
                    __first80 = false;
                }
                __cb.Push("    ");
                #line (192,6)-(192,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (192,13)-(192,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (192,15)-(192,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,16)-(192,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (192,18)-(192,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (192,28)-(192,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,29)-(192,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (192,31)-(192,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (192,33)-(192,45) 28 "SemanticsGenerator.mxg"
                __cb.Write(firstCount-1);
                #line hidden
                #line (192,46)-(192,47) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (193,5)-(193,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first81 = true;
                #line (194,10)-(194,34) 17 "SemanticsGenerator.mxg"
                if (list.SeparatorFirst)
                #line hidden
                
                {
                    if (__first81)
                    {
                        __first81 = false;
                    }
                    __cb.Push("        ");
                    #line (195,10)-(195,157) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.FirstSeparators[firstCount-1], list.FirstSeparators[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (196,9)-(196,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (196,21)-(196,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (196,22)-(196,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (196,23)-(196,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (196,24)-(196,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (197,10)-(197,14) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first81)
                    {
                        __first81 = false;
                    }
                    __cb.Push("        ");
                    #line (198,10)-(198,148) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.FirstItems[firstCount-1], list.FirstItems[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (199,9)-(199,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (199,22)-(199,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (199,23)-(199,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (199,24)-(199,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (199,25)-(199,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first81) __cb.AppendLine();
                __cb.Push("    ");
                #line (201,5)-(201,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (202,10)-(202,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first80) __cb.AppendLine();
            var __first82 = true;
            #line (204,6)-(204,41) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < lastCount; ++i)
            #line hidden
            
            {
                if (__first82)
                {
                    __first82 = false;
                }
                __cb.Push("    ");
                #line (205,6)-(205,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (205,13)-(205,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (205,15)-(205,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,16)-(205,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (205,18)-(205,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (205,28)-(205,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,29)-(205,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (205,31)-(205,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,33)-(205,51) 28 "SemanticsGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (205,52)-(205,62) 29 "SemanticsGenerator.mxg"
                __cb.Write("List.Count");
                #line hidden
                #line (205,62)-(205,63) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,63)-(205,64) 29 "SemanticsGenerator.mxg"
                __cb.Write("-");
                #line hidden
                #line (205,64)-(205,65) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (205,66)-(205,79) 28 "SemanticsGenerator.mxg"
                __cb.Write(lastCount - i);
                #line hidden
                #line (205,80)-(205,81) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (206,5)-(206,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (207,10)-(207,35) 17 "SemanticsGenerator.mxg"
                var j = lastCount - 1 - i;
                #line hidden
                
                var __first83 = true;
                #line (208,10)-(208,72) 17 "SemanticsGenerator.mxg"
                if (j < list.LastItems.Count && j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("        ");
                    #line (209,10)-(209,160) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.LastItems[j], sepName, list.LastSeparators[j], list.RepeatedSeparatorFirst, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (210,9)-(210,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (210,22)-(210,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (210,23)-(210,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (210,24)-(210,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (210,25)-(210,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (211,9)-(211,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (211,21)-(211,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (211,22)-(211,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (211,23)-(211,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (211,24)-(211,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (212,10)-(212,44) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastItems.Count)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("        ");
                    #line (213,10)-(213,124) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.LastItems[j], list.LastItems[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (214,9)-(214,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (214,22)-(214,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (214,23)-(214,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (214,24)-(214,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (214,25)-(214,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (215,10)-(215,49) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("        ");
                    #line (216,10)-(216,133) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.LastSeparators[j], list.LastSeparators[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (217,9)-(217,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (217,21)-(217,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (217,22)-(217,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (217,23)-(217,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (217,24)-(217,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (218,10)-(218,14) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("        ");
                    #line (219,9)-(219,17) 33 "SemanticsGenerator.mxg"
                    __cb.Write("INTERNAL");
                    #line hidden
                    #line (219,17)-(219,18) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (219,18)-(219,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("ERROR");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first83) __cb.AppendLine();
                __cb.Push("    ");
                #line (221,5)-(221,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (222,10)-(222,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first82) __cb.AppendLine();
            __cb.Push("    ");
            #line (224,5)-(224,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (224,7)-(224,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,8)-(224,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__itemHandled");
            #line hidden
            #line (224,23)-(224,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,24)-(224,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (224,26)-(224,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,28)-(224,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (224,38)-(224,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,39)-(224,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (224,40)-(224,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,41)-(224,46) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (224,47)-(224,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (224,65)-(224,72) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Count)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (225,5)-(225,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (226,10)-(226,142) 13 "SemanticsGenerator.mxg"
            var repItemBody = GenerateBinderFactoryVisitElementValue(itemName, list.RepeatedItem, list.RepeatedItem.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (227,10)-(227,117) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repItemBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (228,5)-(228,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (229,5)-(229,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (229,7)-(229,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,8)-(229,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__sepHandled");
            #line hidden
            #line (229,22)-(229,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,23)-(229,25) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (229,25)-(229,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,27)-(229,36) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (229,37)-(229,38) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,38)-(229,39) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (229,39)-(229,40) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (229,40)-(229,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (229,46)-(229,63) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (229,64)-(229,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(".SeparatorCount)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (230,5)-(230,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (231,10)-(231,150) 13 "SemanticsGenerator.mxg"
            var repSepBody = GenerateBinderFactoryVisitElementValue(sepName, list.RepeatedSeparator, list.RepeatedSeparator.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (232,10)-(232,116) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repSepBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (233,5)-(233,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (234,1)-(234,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (237,9)-(237,162) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListItem(string itemName, Element itemElem, string sepName, Element sepElem, bool separatorFirst, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first84 = true;
            #line (238,2)-(238,21) 13 "SemanticsGenerator.mxg"
            if (separatorFirst)
            #line hidden
            
            {
                if (__first84)
                {
                    __first84 = false;
                }
                __cb.Push("");
                #line (239,2)-(239,95) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (240,2)-(240,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (241,2)-(241,6) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first84)
                {
                    __first84 = false;
                }
                __cb.Push("");
                #line (242,2)-(242,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (243,2)-(243,95) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first84) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (247,9)-(247,145) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementValue(string elemName, Element elem, ElementValue elemValue, bool withElemBinders, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first85 = true;
            #line (248,6)-(248,38) 13 "SemanticsGenerator.mxg"
            if (elemValue is TokenAlts alts)
            #line hidden
            
            {
                if (__first85)
                {
                    __first85 = false;
                }
                __cb.Push("");
                #line (249,1)-(249,3) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (249,3)-(249,4) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (249,4)-(249,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (249,6)-(249,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (249,15)-(249,19) 29 "SemanticsGenerator.mxg"
                __cb.Write(".Get");
                #line hidden
                #line (249,20)-(249,24) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (249,25)-(249,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("Kind()");
                #line hidden
                #line (249,31)-(249,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (249,32)-(249,34) 29 "SemanticsGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (249,34)-(249,35) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (249,36)-(249,40) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (249,41)-(249,57) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.None)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (250,1)-(250,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (251,10)-(251,94) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitTokenAlts(elemName, elem, alts, ref annotIndex);
                #line hidden
                
                #line (252,10)-(252,103) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first86 = true;
                #line (253,10)-(253,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first86)
                    {
                        __first86 = false;
                    }
                    #line (254,14)-(254,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first86) __cb.AppendLine();
                __cb.Push("    ");
                #line (256,6)-(256,10) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (257,1)-(257,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (258,1)-(258,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (259,1)-(259,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (260,10)-(260,110) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, "// default", true, ref annotIndex);
                #line hidden
                
                var __first87 = true;
                #line (261,10)-(261,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first87)
                    {
                        __first87 = false;
                    }
                    #line (262,14)-(262,106) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, true, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first87) __cb.AppendLine();
                __cb.Push("    ");
                #line (264,6)-(264,10) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (265,1)-(265,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (266,6)-(266,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first85)
                {
                    __first85 = false;
                }
                #line (267,10)-(267,95) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitElementBody(elemName, elemValue, ref annotIndex);
                #line hidden
                
                #line (268,10)-(268,108) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(elemValue.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first88 = true;
                #line (269,10)-(269,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first88)
                    {
                        __first88 = false;
                    }
                    #line (270,14)-(270,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first88) __cb.AppendLine();
                __cb.Push("");
                #line (272,2)-(272,6) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first85) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (276,9)-(276,112) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitTokenAlts(string elemName, Element elem, TokenAlts alts, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (277,1)-(277,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (277,7)-(277,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (277,8)-(277,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (277,10)-(277,18) 24 "SemanticsGenerator.mxg"
            __cb.Write(elemName);
            #line hidden
            #line (277,19)-(277,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Get");
            #line hidden
            #line (277,24)-(277,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (277,29)-(277,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("Kind())");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (278,1)-(278,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first89 = true;
            #line (279,10)-(279,42) 13 "SemanticsGenerator.mxg"
            foreach (var alt in alts.Tokens)
            #line hidden
            
            {
                if (__first89)
                {
                    __first89 = false;
                }
                __cb.Push("    ");
                #line (280,5)-(280,9) 29 "SemanticsGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (280,9)-(280,10) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (280,11)-(280,15) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (280,16)-(280,27) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (280,28)-(280,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(alt.Token.CSharpName);
                #line hidden
                #line (280,49)-(280,50) 29 "SemanticsGenerator.mxg"
                __cb.Write(":");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (281,10)-(281,92) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, alt, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (282,9)-(282,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("break;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first89) __cb.AppendLine();
            __cb.Push("    ");
            #line (284,5)-(284,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (285,9)-(285,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("break;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (286,1)-(286,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (289,9)-(289,108) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementBody(string elemName, ElementValue elemValue, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first90 = true;
            #line (290,6)-(290,58) 13 "SemanticsGenerator.mxg"
            if (elemValue is RuleRef rr && rr.Token is not null)
            #line hidden
            
            {
                if (__first90)
                {
                    __first90 = false;
                }
                #line (291,10)-(291,55) 17 "SemanticsGenerator.mxg"
                var body = "//this.VisitToken("+elemName+");";
                #line hidden
                
                __cb.Push("");
                #line (292,2)-(292,92) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(rr.Token.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (293,6)-(293,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first90)
                {
                    __first90 = false;
                }
                __cb.Push("");
                #line (294,1)-(294,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Visit(");
                #line hidden
                #line (294,13)-(294,21) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (294,22)-(294,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first90) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}