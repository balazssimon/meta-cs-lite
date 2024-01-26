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
                __cb.Push("        ");
                #line (76,9)-(76,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (76,12)-(76,13) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,13)-(76,24) 29 "SemanticsGenerator.mxg"
                __cb.Write("__rootAnnot");
                #line hidden
                #line (76,24)-(76,25) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,25)-(76,26) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (76,26)-(76,27) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,27)-(76,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (76,30)-(76,31) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,31)-(76,97) 29 "SemanticsGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (77,9)-(77,32) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Begin(__rootAnnot,");
                #line hidden
                #line (77,32)-(77,33) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (77,33)-(77,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("node);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (78,9)-(78,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("try");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (79,9)-(79,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (80,14)-(80,55) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (81,9)-(81,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (82,9)-(82,16) 29 "SemanticsGenerator.mxg"
                __cb.Write("finally");
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
                #line (84,13)-(84,35) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.End(__rootAnnot);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (85,9)-(85,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (86,5)-(86,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (87,5)-(87,9) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (88,5)-(88,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    \t");
                #line (89,7)-(89,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (90,5)-(90,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (91,6)-(91,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("\t");
                #line (92,3)-(92,44) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first73) __cb.AppendLine();
            __cb.Push("");
            #line (94,1)-(94,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (97,9)-(97,68) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBody(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (98,2)-(98,20) 13 "SemanticsGenerator.mxg"
            var annotIndex = 0;
            #line hidden
            
            #line (99,2)-(99,68) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitElements(alt, ref annotIndex);
            #line hidden
            
            #line (100,2)-(100,92) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(alt.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            #line (101,2)-(101,93) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(rule.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (102,2)-(102,6) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (105,9)-(105,81) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElements(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first74 = true;
            #line (106,2)-(106,66) 13 "SemanticsGenerator.mxg"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first74)
                {
                    __first74 = false;
                }
                __cb.Push("");
                #line (107,2)-(107,62) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElement(alt, elem, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (108,14)-(108,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("    ");
            #line hidden
            return __cb.ToStringAndFree();
        }
        
        #line (111,9)-(111,136) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinders(IEnumerable<Binder> binders, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first75 = true;
            #line (112,2)-(112,78) 13 "SemanticsGenerator.mxg"
            foreach (var binder in binders.Where(b => b.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first75)
                {
                    __first75 = false;
                }
                #line (113,2)-(113,81) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinder(binder, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first75) __cb.AppendLine();
            __cb.Push("");
            #line (115,2)-(115,6) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (118,9)-(118,107) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinder(Binder binder, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (119,2)-(119,46) 13 "SemanticsGenerator.mxg"
            var binderVarName = "__annot"+(annotIndex++);
            #line hidden
            
            __cb.Push("");
            #line (120,1)-(120,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (120,4)-(120,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,6)-(120,19) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (120,20)-(120,21) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,21)-(120,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (120,22)-(120,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,23)-(120,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (120,26)-(120,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,28)-(120,43) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.TypeName);
            #line hidden
            #line (120,44)-(120,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (120,46)-(120,73) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.ConstructorArguments);
            #line hidden
            #line (120,74)-(120,76) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (121,1)-(121,12) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.Begin(");
            #line hidden
            #line (121,13)-(121,26) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (121,27)-(121,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (121,28)-(121,29) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,30)-(121,38) 24 "SemanticsGenerator.mxg"
            __cb.Write(nodeName);
            #line hidden
            #line (121,39)-(121,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (122,1)-(122,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("try");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (123,1)-(123,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (124,6)-(124,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (125,1)-(125,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (126,1)-(126,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("finally");
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
            #line (128,5)-(128,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.End(");
            #line hidden
            #line (128,15)-(128,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (128,29)-(128,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (129,1)-(129,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (132,9)-(132,94) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElement(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (133,6)-(133,105) 13 "SemanticsGenerator.mxg"
            var isList = MetaDslx.Languages.MetaCompiler.Model.MultiplicityExtensions.IsList(elem.Multiplicity);
            #line hidden
            
            #line (134,6)-(134,113) 13 "SemanticsGenerator.mxg"
            var isOptional = MetaDslx.Languages.MetaCompiler.Model.MultiplicityExtensions.IsOptional(elem.Multiplicity);
            #line hidden
            
            var __first76 = true;
            #line (135,6)-(135,17) 13 "SemanticsGenerator.mxg"
            if (isList)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (136,10)-(136,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (137,2)-(137,78) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitListElements(alt, elem, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (138,2)-(138,88) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (139,6)-(139,46) 13 "SemanticsGenerator.mxg"
            else if (elem.Value is SeparatedList sl)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (140,10)-(140,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (141,2)-(141,91) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitSeparatedListElements(alt, elem, sl, ref annotIndex);
                #line hidden
                
                #line (142,2)-(142,93) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(sl.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (143,2)-(143,88) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (144,6)-(144,26) 13 "SemanticsGenerator.mxg"
            else if (isOptional)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (145,10)-(145,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (146,1)-(146,3) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (146,3)-(146,4) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (146,4)-(146,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (146,6)-(146,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                var __first77 = true;
                #line (146,16)-(146,33) 17 "SemanticsGenerator.mxg"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    #line (146,34)-(146,38) 33 "SemanticsGenerator.mxg"
                    __cb.Write(".Get");
                    #line hidden
                    #line (146,39)-(146,43) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (146,44)-(146,50) 33 "SemanticsGenerator.mxg"
                    __cb.Write("Kind()");
                    #line hidden
                    #line (146,50)-(146,51) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,51)-(146,53) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (146,53)-(146,54) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,55)-(146,59) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (146,60)-(146,75) 33 "SemanticsGenerator.mxg"
                    __cb.Write("SyntaxKind.None");
                    #line hidden
                }
                #line (146,76)-(146,80) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    #line (146,81)-(146,82) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,82)-(146,84) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (146,84)-(146,85) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,85)-(146,89) 33 "SemanticsGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                }
                #line (146,97)-(146,98) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (147,1)-(147,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (148,6)-(148,94) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (149,1)-(149,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (150,6)-(150,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (151,10)-(151,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (152,2)-(152,90) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first76) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (156,9)-(156,99) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitListElements(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (157,1)-(157,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (157,4)-(157,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,6)-(157,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (157,25)-(157,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (157,29)-(157,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,30)-(157,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (157,31)-(157,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,32)-(157,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (157,38)-(157,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (157,56)-(157,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (158,2)-(158,44) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (159,1)-(159,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (159,4)-(159,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,5)-(159,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (159,9)-(159,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,11)-(159,20) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (159,21)-(159,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,22)-(159,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (159,23)-(159,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,24)-(159,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (159,26)-(159,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,28)-(159,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (159,38)-(159,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,39)-(159,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (159,40)-(159,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,42)-(159,60) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (159,61)-(159,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (159,72)-(159,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,73)-(159,75) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (159,76)-(159,85) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (159,86)-(159,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (160,1)-(160,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (161,6)-(161,64) 13 "SemanticsGenerator.mxg"
            var elemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            __cb.Push("    ");
            #line (162,6)-(162,95) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (163,1)-(163,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (166,9)-(166,128) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListElements(Alternative alt, Element elem, SeparatedList list, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (167,1)-(167,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (167,4)-(167,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,6)-(167,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (167,25)-(167,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (167,29)-(167,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,30)-(167,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (167,31)-(167,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,32)-(167,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (167,38)-(167,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (167,56)-(167,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (168,2)-(168,44) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (169,1)-(169,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (169,4)-(169,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,5)-(169,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (169,9)-(169,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,11)-(169,20) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (169,21)-(169,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,22)-(169,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (169,23)-(169,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,24)-(169,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (169,26)-(169,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,28)-(169,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (169,38)-(169,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,39)-(169,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (169,40)-(169,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,42)-(169,60) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (169,61)-(169,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (169,72)-(169,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,73)-(169,75) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (169,76)-(169,85) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (169,86)-(169,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (170,1)-(170,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (171,5)-(171,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (171,9)-(171,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,10)-(171,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("__itemHandled");
            #line hidden
            #line (171,23)-(171,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,24)-(171,25) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (171,25)-(171,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,26)-(171,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (172,5)-(172,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (172,9)-(172,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,10)-(172,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("__sepHandled");
            #line hidden
            #line (172,22)-(172,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,23)-(172,24) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (172,24)-(172,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,25)-(172,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (173,6)-(173,64) 13 "SemanticsGenerator.mxg"
            var itemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            #line (174,6)-(174,76) 13 "SemanticsGenerator.mxg"
            var sepName = "node."+elem.PropertyName+".GetSeparator("+indexName+")";
            #line hidden
            
            #line (175,6)-(175,82) 13 "SemanticsGenerator.mxg"
            var firstCount = Math.Max(list.FirstItems.Count, list.FirstSeparators.Count);
            #line hidden
            
            #line (176,6)-(176,79) 13 "SemanticsGenerator.mxg"
            var lastCount = Math.Min(list.LastItems.Count, list.LastSeparators.Count);
            #line hidden
            
            #line (177,6)-(177,21) 13 "SemanticsGenerator.mxg"
            var ifElse = "";
            #line hidden
            
            var __first78 = true;
            #line (178,6)-(178,46) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < firstCount - 1; ++i)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                __cb.Push("    ");
                #line (179,6)-(179,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (179,13)-(179,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (179,15)-(179,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,16)-(179,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (179,18)-(179,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (179,28)-(179,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,29)-(179,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (179,31)-(179,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,33)-(179,34) 28 "SemanticsGenerator.mxg"
                __cb.Write(i);
                #line hidden
                #line (179,35)-(179,36) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (180,5)-(180,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (181,10)-(181,154) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.FirstItems[i], sepName, list.FirstSeparators[i], list.SeparatorFirst, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (182,9)-(182,22) 29 "SemanticsGenerator.mxg"
                __cb.Write("__itemHandled");
                #line hidden
                #line (182,22)-(182,23) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (182,23)-(182,24) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (182,24)-(182,25) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (182,25)-(182,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (183,9)-(183,21) 29 "SemanticsGenerator.mxg"
                __cb.Write("__sepHandled");
                #line hidden
                #line (183,21)-(183,22) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (183,22)-(183,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (183,23)-(183,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (183,24)-(183,29) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (184,5)-(184,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (185,10)-(185,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first78) __cb.AppendLine();
            var __first79 = true;
            #line (187,6)-(187,25) 13 "SemanticsGenerator.mxg"
            if (firstCount > 0)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                __cb.Push("    ");
                #line (188,6)-(188,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (188,13)-(188,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (188,15)-(188,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (188,16)-(188,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (188,18)-(188,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (188,28)-(188,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (188,29)-(188,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (188,31)-(188,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (188,33)-(188,45) 28 "SemanticsGenerator.mxg"
                __cb.Write(firstCount-1);
                #line hidden
                #line (188,46)-(188,47) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (189,5)-(189,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first80 = true;
                #line (190,10)-(190,34) 17 "SemanticsGenerator.mxg"
                if (list.SeparatorFirst)
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    __cb.Push("        ");
                    #line (191,10)-(191,157) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.FirstSeparators[firstCount-1], list.FirstSeparators[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (192,9)-(192,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (192,21)-(192,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (192,22)-(192,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (192,23)-(192,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (192,24)-(192,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (193,10)-(193,14) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    __cb.Push("        ");
                    #line (194,10)-(194,148) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.FirstItems[firstCount-1], list.FirstItems[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (195,9)-(195,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (195,22)-(195,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (195,23)-(195,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (195,24)-(195,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (195,25)-(195,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first80) __cb.AppendLine();
                __cb.Push("    ");
                #line (197,5)-(197,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (198,10)-(198,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first79) __cb.AppendLine();
            var __first81 = true;
            #line (200,6)-(200,41) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < lastCount; ++i)
            #line hidden
            
            {
                if (__first81)
                {
                    __first81 = false;
                }
                __cb.Push("    ");
                #line (201,6)-(201,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (201,13)-(201,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (201,15)-(201,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,16)-(201,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (201,18)-(201,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (201,28)-(201,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,29)-(201,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (201,31)-(201,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,33)-(201,51) 28 "SemanticsGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (201,52)-(201,62) 29 "SemanticsGenerator.mxg"
                __cb.Write("List.Count");
                #line hidden
                #line (201,62)-(201,63) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,63)-(201,64) 29 "SemanticsGenerator.mxg"
                __cb.Write("-");
                #line hidden
                #line (201,64)-(201,65) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,66)-(201,79) 28 "SemanticsGenerator.mxg"
                __cb.Write(lastCount - i);
                #line hidden
                #line (201,80)-(201,81) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (202,5)-(202,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (203,10)-(203,35) 17 "SemanticsGenerator.mxg"
                var j = lastCount - 1 - i;
                #line hidden
                
                var __first82 = true;
                #line (204,10)-(204,72) 17 "SemanticsGenerator.mxg"
                if (j < list.LastItems.Count && j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (205,10)-(205,160) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.LastItems[j], sepName, list.LastSeparators[j], list.RepeatedSeparatorFirst, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (206,9)-(206,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (206,22)-(206,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,23)-(206,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (206,24)-(206,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,25)-(206,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (207,9)-(207,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (207,21)-(207,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (207,22)-(207,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (207,23)-(207,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (207,24)-(207,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (208,10)-(208,44) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastItems.Count)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (209,10)-(209,124) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.LastItems[j], list.LastItems[j].Value, true, ref annotIndex));
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
                }
                #line (211,10)-(211,49) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (212,10)-(212,133) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.LastSeparators[j], list.LastSeparators[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (213,9)-(213,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (213,21)-(213,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (213,22)-(213,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (213,23)-(213,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (213,24)-(213,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (214,10)-(214,14) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (215,9)-(215,17) 33 "SemanticsGenerator.mxg"
                    __cb.Write("INTERNAL");
                    #line hidden
                    #line (215,17)-(215,18) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (215,18)-(215,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("ERROR");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first82) __cb.AppendLine();
                __cb.Push("    ");
                #line (217,5)-(217,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (218,10)-(218,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first81) __cb.AppendLine();
            __cb.Push("    ");
            #line (220,5)-(220,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (220,7)-(220,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,8)-(220,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__itemHandled");
            #line hidden
            #line (220,23)-(220,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,24)-(220,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (220,26)-(220,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,28)-(220,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (220,38)-(220,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,39)-(220,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (220,40)-(220,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,41)-(220,46) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (220,47)-(220,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (220,65)-(220,72) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Count)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (221,5)-(221,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (222,10)-(222,142) 13 "SemanticsGenerator.mxg"
            var repItemBody = GenerateBinderFactoryVisitElementValue(itemName, list.RepeatedItem, list.RepeatedItem.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (223,10)-(223,117) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repItemBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (224,5)-(224,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (225,5)-(225,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (225,7)-(225,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,8)-(225,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__sepHandled");
            #line hidden
            #line (225,22)-(225,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,23)-(225,25) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (225,25)-(225,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,27)-(225,36) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (225,37)-(225,38) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,38)-(225,39) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (225,39)-(225,40) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,40)-(225,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (225,46)-(225,63) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (225,64)-(225,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(".SeparatorCount)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (226,5)-(226,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (227,10)-(227,150) 13 "SemanticsGenerator.mxg"
            var repSepBody = GenerateBinderFactoryVisitElementValue(sepName, list.RepeatedSeparator, list.RepeatedSeparator.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (228,10)-(228,116) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repSepBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (229,5)-(229,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (230,1)-(230,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (233,9)-(233,162) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListItem(string itemName, Element itemElem, string sepName, Element sepElem, bool separatorFirst, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first83 = true;
            #line (234,2)-(234,21) 13 "SemanticsGenerator.mxg"
            if (separatorFirst)
            #line hidden
            
            {
                if (__first83)
                {
                    __first83 = false;
                }
                __cb.Push("");
                #line (235,2)-(235,95) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (236,2)-(236,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (237,2)-(237,6) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first83)
                {
                    __first83 = false;
                }
                __cb.Push("");
                #line (238,2)-(238,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (239,2)-(239,95) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first83) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (243,9)-(243,145) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementValue(string elemName, Element elem, ElementValue elemValue, bool withElemBinders, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first84 = true;
            #line (244,6)-(244,38) 13 "SemanticsGenerator.mxg"
            if (elemValue is TokenAlts alts)
            #line hidden
            
            {
                if (__first84)
                {
                    __first84 = false;
                }
                __cb.Push("");
                #line (245,1)-(245,3) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (245,3)-(245,4) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (245,4)-(245,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (245,6)-(245,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (245,15)-(245,19) 29 "SemanticsGenerator.mxg"
                __cb.Write(".Get");
                #line hidden
                #line (245,20)-(245,24) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (245,25)-(245,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("Kind()");
                #line hidden
                #line (245,31)-(245,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (245,32)-(245,34) 29 "SemanticsGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (245,34)-(245,35) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (245,36)-(245,40) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (245,41)-(245,57) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.None)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (246,1)-(246,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (247,10)-(247,94) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitTokenAlts(elemName, elem, alts, ref annotIndex);
                #line hidden
                
                #line (248,10)-(248,103) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first85 = true;
                #line (249,10)-(249,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first85)
                    {
                        __first85 = false;
                    }
                    #line (250,14)-(250,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first85) __cb.AppendLine();
                __cb.Push("    ");
                #line (252,6)-(252,10) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (253,1)-(253,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (254,1)-(254,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (255,1)-(255,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (256,10)-(256,110) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, "// default", true, ref annotIndex);
                #line hidden
                
                var __first86 = true;
                #line (257,10)-(257,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first86)
                    {
                        __first86 = false;
                    }
                    #line (258,14)-(258,106) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, true, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first86) __cb.AppendLine();
                __cb.Push("    ");
                #line (260,6)-(260,10) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (261,1)-(261,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (262,6)-(262,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first84)
                {
                    __first84 = false;
                }
                #line (263,10)-(263,95) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitElementBody(elemName, elemValue, ref annotIndex);
                #line hidden
                
                #line (264,10)-(264,108) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(elemValue.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first87 = true;
                #line (265,10)-(265,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first87)
                    {
                        __first87 = false;
                    }
                    #line (266,14)-(266,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first87) __cb.AppendLine();
                __cb.Push("");
                #line (268,2)-(268,6) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first84) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (272,9)-(272,112) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitTokenAlts(string elemName, Element elem, TokenAlts alts, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (273,1)-(273,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (273,7)-(273,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,8)-(273,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (273,10)-(273,18) 24 "SemanticsGenerator.mxg"
            __cb.Write(elemName);
            #line hidden
            #line (273,19)-(273,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Get");
            #line hidden
            #line (273,24)-(273,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (273,29)-(273,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("Kind())");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (274,1)-(274,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first88 = true;
            #line (275,10)-(275,42) 13 "SemanticsGenerator.mxg"
            foreach (var alt in alts.Tokens)
            #line hidden
            
            {
                if (__first88)
                {
                    __first88 = false;
                }
                __cb.Push("    ");
                #line (276,5)-(276,9) 29 "SemanticsGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (276,9)-(276,10) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (276,11)-(276,15) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (276,16)-(276,27) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (276,28)-(276,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(alt.Token.CSharpName);
                #line hidden
                #line (276,49)-(276,50) 29 "SemanticsGenerator.mxg"
                __cb.Write(":");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (277,10)-(277,92) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, alt, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (278,9)-(278,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("break;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first88) __cb.AppendLine();
            __cb.Push("    ");
            #line (280,5)-(280,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (281,9)-(281,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("break;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (282,1)-(282,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (285,9)-(285,108) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementBody(string elemName, ElementValue elemValue, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first89 = true;
            #line (286,6)-(286,58) 13 "SemanticsGenerator.mxg"
            if (elemValue is RuleRef rr && rr.Token is not null)
            #line hidden
            
            {
                if (__first89)
                {
                    __first89 = false;
                }
                #line (287,10)-(287,55) 17 "SemanticsGenerator.mxg"
                var body = "//this.VisitToken("+elemName+");";
                #line hidden
                
                __cb.Push("");
                #line (288,2)-(288,92) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(rr.Token.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (289,6)-(289,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first89)
                {
                    __first89 = false;
                }
                __cb.Push("");
                #line (290,1)-(290,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Visit(");
                #line hidden
                #line (290,13)-(290,21) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (290,22)-(290,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first89) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}