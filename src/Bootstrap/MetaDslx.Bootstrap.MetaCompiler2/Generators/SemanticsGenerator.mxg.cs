#line (1,10)-(1,54) 10 "SemanticsGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler2.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,45) 13 "SemanticsGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler2.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "SemanticsGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "SemanticsGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "SemanticsGenerator.mxg"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "SemanticsGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (11,9)-(11,36) 22 "SemanticsGenerator.mxg"
        public string GenerateSemanticsFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (12,1)-(12,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,6)-(12,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
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
            #line (14,7)-(14,42) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
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
            #line (15,7)-(15,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,1)-(17,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (17,10)-(17,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,1)-(19,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (19,10)-(19,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,12)-(19,21) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,1)-(20,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (21,11)-(21,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,12)-(21,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (21,17)-(21,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,19)-(21,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (21,24)-(21,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            #line (21,40)-(21,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,41)-(21,42) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (21,42)-(21,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,43)-(21,59) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (23,9)-(23,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (23,15)-(23,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,17)-(23,21) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (23,22)-(23,50) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory(Compilation");
            #line hidden
            #line (23,50)-(23,51) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,51)-(23,63) 25 "SemanticsGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (23,63)-(23,64) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,64)-(23,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (23,72)-(23,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,73)-(23,82) 25 "SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            #line (23,82)-(23,83) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (24,13)-(24,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (24,14)-(24,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,15)-(24,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("base(compilation,");
            #line hidden
            #line (24,32)-(24,33) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,33)-(24,42) 25 "SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,9)-(25,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,9)-(26,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,9)-(28,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (28,15)-(28,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,16)-(28,24) 25 "SemanticsGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (28,24)-(28,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,25)-(28,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (28,45)-(28,46) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,46)-(28,86) 25 "SemanticsGenerator.mxg"
            __cb.Write("CreateBinderFactoryVisitor(BinderFactory");
            #line hidden
            #line (28,86)-(28,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,87)-(28,101) 25 "SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,9)-(29,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (30,13)-(30,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (30,19)-(30,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,20)-(30,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (30,23)-(30,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,24)-(30,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (30,33)-(30,42) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (30,43)-(30,52) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Binding.");
            #line hidden
            #line (30,53)-(30,57) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (30,58)-(30,94) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(binderFactory);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (31,9)-(31,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,5)-(32,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,1)-(33,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (37,9)-(37,40) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitor()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (38,1)-(38,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (38,6)-(38,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,7)-(38,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,1)-(39,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,6)-(39,7) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,7)-(39,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
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
            #line (40,7)-(40,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (42,1)-(42,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (42,10)-(42,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,11)-(42,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,1)-(44,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (44,10)-(44,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,12)-(44,21) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (44,22)-(44,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Binding");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,1)-(45,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (46,5)-(46,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (46,10)-(46,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,11)-(46,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (46,20)-(46,29) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (46,30)-(46,38) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,5)-(48,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (48,11)-(48,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,12)-(48,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (48,17)-(48,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,19)-(48,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (48,24)-(48,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (48,44)-(48,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,45)-(48,46) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (48,46)-(48,47) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,47)-(48,98) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor,");
            #line hidden
            #line (48,98)-(48,99) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,99)-(48,100) 25 "SemanticsGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (48,101)-(48,105) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (48,106)-(48,119) 25 "SemanticsGenerator.mxg"
            __cb.Write("SyntaxVisitor");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,5)-(49,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,9)-(50,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (50,17)-(50,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,19)-(50,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (50,24)-(50,88) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory");
            #line hidden
            #line (50,88)-(50,89) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,89)-(50,103) 25 "SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (51,13)-(51,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (51,14)-(51,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,15)-(51,34) 25 "SemanticsGenerator.mxg"
            __cb.Write("base(binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (53,9)-(53,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first71 = true;
            #line (55,4)-(55,31) 13 "SemanticsGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                var __first72 = true;
                #line (56,5)-(56,43) 17 "SemanticsGenerator.mxg"
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
                    #line (58,10)-(58,47) 32 "SemanticsGenerator.mxg"
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
            #line (62,3)-(62,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (62,9)-(62,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,10)-(62,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (62,17)-(62,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,18)-(62,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (62,22)-(62,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,23)-(62,48) 25 "SemanticsGenerator.mxg"
            __cb.Write("VisitSkippedTokensTrivia(");
            #line hidden
            #line (62,49)-(62,53) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (62,54)-(62,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("SkippedTokensTriviaSyntax");
            #line hidden
            #line (62,79)-(62,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,80)-(62,85) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (63,3)-(63,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (64,3)-(64,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (65,5)-(65,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (66,1)-(66,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (69,9)-(69,64) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisit(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (70,1)-(70,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (70,7)-(70,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,8)-(70,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (70,15)-(70,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,16)-(70,20) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (70,20)-(70,21) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,21)-(70,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("Visit");
            #line hidden
            #line (70,27)-(70,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (70,42)-(70,43) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (70,44)-(70,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.RedName);
            #line hidden
            #line (70,56)-(70,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,57)-(70,62) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (71,1)-(71,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (72,6)-(72,35) 13 "SemanticsGenerator.mxg"
            if (rule == Grammar.MainRule)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("    ");
                #line (73,5)-(73,7) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (73,7)-(73,8) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,8)-(73,21) 29 "SemanticsGenerator.mxg"
                __cb.Write("(this.IsRoot)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (74,5)-(74,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (75,9)-(75,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (75,12)-(75,13) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,13)-(75,24) 29 "SemanticsGenerator.mxg"
                __cb.Write("__rootAnnot");
                #line hidden
                #line (75,24)-(75,25) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,25)-(75,26) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (75,26)-(75,27) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,27)-(75,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (75,30)-(75,31) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (75,31)-(75,97) 29 "SemanticsGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (76,9)-(76,32) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Begin(__rootAnnot,");
                #line hidden
                #line (76,32)-(76,33) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (76,33)-(76,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("node);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (77,9)-(77,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("try");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (78,9)-(78,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (79,14)-(79,55) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (80,9)-(80,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (81,9)-(81,16) 29 "SemanticsGenerator.mxg"
                __cb.Write("finally");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (82,9)-(82,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (83,13)-(83,35) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.End(__rootAnnot);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (84,9)-(84,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (85,5)-(85,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (86,5)-(86,9) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (87,5)-(87,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    \t");
                #line (88,7)-(88,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (89,5)-(89,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (90,6)-(90,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("\t");
                #line (91,3)-(91,44) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first73) __cb.AppendLine();
            __cb.Push("");
            #line (93,1)-(93,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (96,9)-(96,68) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBody(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (97,2)-(97,20) 13 "SemanticsGenerator.mxg"
            var annotIndex = 0;
            #line hidden
            
            #line (98,2)-(98,68) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitElements(alt, ref annotIndex);
            #line hidden
            
            #line (99,2)-(99,92) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(alt.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            #line (100,2)-(100,93) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(rule.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (101,2)-(101,6) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (104,9)-(104,81) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElements(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first74 = true;
            #line (105,2)-(105,66) 13 "SemanticsGenerator.mxg"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first74)
                {
                    __first74 = false;
                }
                __cb.Push("");
                #line (106,2)-(106,62) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElement(alt, elem, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (107,14)-(107,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("    ");
            #line hidden
            return __cb.ToStringAndFree();
        }
        
        #line (110,9)-(110,136) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinders(IEnumerable<Binder> binders, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first75 = true;
            #line (111,2)-(111,78) 13 "SemanticsGenerator.mxg"
            foreach (var binder in binders.Where(b => b.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first75)
                {
                    __first75 = false;
                }
                #line (112,2)-(112,81) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinder(binder, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first75) __cb.AppendLine();
            __cb.Push("");
            #line (114,2)-(114,6) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (117,9)-(117,107) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinder(Binder binder, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (118,2)-(118,46) 13 "SemanticsGenerator.mxg"
            var binderVarName = "__annot"+(annotIndex++);
            #line hidden
            
            __cb.Push("");
            #line (119,1)-(119,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (119,4)-(119,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,6)-(119,19) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (119,20)-(119,21) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,21)-(119,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (119,22)-(119,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,23)-(119,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (119,26)-(119,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,28)-(119,43) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.TypeName);
            #line hidden
            #line (119,44)-(119,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (119,46)-(119,73) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.ConstructorArguments);
            #line hidden
            #line (119,74)-(119,76) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (120,1)-(120,12) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.Begin(");
            #line hidden
            #line (120,13)-(120,26) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (120,27)-(120,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (120,28)-(120,29) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,30)-(120,38) 24 "SemanticsGenerator.mxg"
            __cb.Write(nodeName);
            #line hidden
            #line (120,39)-(120,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (121,1)-(121,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("try");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (122,1)-(122,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (123,6)-(123,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (124,1)-(124,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (125,1)-(125,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("finally");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (126,1)-(126,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (127,5)-(127,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.End(");
            #line hidden
            #line (127,15)-(127,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (127,29)-(127,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (128,1)-(128,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (131,9)-(131,94) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElement(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (132,6)-(132,106) 13 "SemanticsGenerator.mxg"
            var isList = MetaDslx.Bootstrap.MetaCompiler2.Model.MultiplicityExtensions.IsList(elem.Multiplicity);
            #line hidden
            
            #line (133,6)-(133,114) 13 "SemanticsGenerator.mxg"
            var isOptional = MetaDslx.Bootstrap.MetaCompiler2.Model.MultiplicityExtensions.IsOptional(elem.Multiplicity);
            #line hidden
            
            var __first76 = true;
            #line (134,6)-(134,17) 13 "SemanticsGenerator.mxg"
            if (isList)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (135,10)-(135,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (136,2)-(136,78) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitListElements(alt, elem, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (137,2)-(137,88) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (138,6)-(138,46) 13 "SemanticsGenerator.mxg"
            else if (elem.Value is SeparatedList sl)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (139,10)-(139,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (140,2)-(140,91) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitSeparatedListElements(alt, elem, sl, ref annotIndex);
                #line hidden
                
                #line (141,2)-(141,93) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(sl.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (142,2)-(142,88) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (143,6)-(143,26) 13 "SemanticsGenerator.mxg"
            else if (isOptional)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (144,10)-(144,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (145,1)-(145,3) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (145,3)-(145,4) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (145,4)-(145,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (145,6)-(145,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                var __first77 = true;
                #line (145,16)-(145,33) 17 "SemanticsGenerator.mxg"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    #line (145,34)-(145,38) 33 "SemanticsGenerator.mxg"
                    __cb.Write(".Get");
                    #line hidden
                    #line (145,39)-(145,43) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (145,44)-(145,50) 33 "SemanticsGenerator.mxg"
                    __cb.Write("Kind()");
                    #line hidden
                    #line (145,50)-(145,51) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (145,51)-(145,53) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (145,53)-(145,54) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (145,55)-(145,59) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (145,60)-(145,75) 33 "SemanticsGenerator.mxg"
                    __cb.Write("SyntaxKind.None");
                    #line hidden
                }
                #line (145,76)-(145,80) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    #line (145,81)-(145,82) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (145,82)-(145,84) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (145,84)-(145,85) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (145,85)-(145,89) 33 "SemanticsGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                }
                #line (145,97)-(145,98) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (146,1)-(146,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (147,6)-(147,94) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (148,1)-(148,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (149,6)-(149,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                #line (150,10)-(150,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (151,2)-(151,90) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first76) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (155,9)-(155,99) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitListElements(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (156,1)-(156,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (156,4)-(156,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,6)-(156,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (156,25)-(156,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (156,29)-(156,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,30)-(156,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (156,31)-(156,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,32)-(156,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (156,38)-(156,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (156,56)-(156,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (157,2)-(157,44) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (158,1)-(158,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (158,4)-(158,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,5)-(158,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (158,9)-(158,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,11)-(158,20) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (158,21)-(158,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,22)-(158,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (158,23)-(158,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,24)-(158,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (158,26)-(158,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,28)-(158,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (158,38)-(158,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,39)-(158,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (158,40)-(158,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,42)-(158,60) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (158,61)-(158,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (158,72)-(158,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,73)-(158,75) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (158,76)-(158,85) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (158,86)-(158,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (159,1)-(159,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (160,6)-(160,64) 13 "SemanticsGenerator.mxg"
            var elemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            __cb.Push("    ");
            #line (161,6)-(161,95) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (162,1)-(162,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (165,9)-(165,128) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListElements(Alternative alt, Element elem, SeparatedList list, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (166,1)-(166,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (166,4)-(166,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,6)-(166,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (166,25)-(166,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (166,29)-(166,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,30)-(166,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (166,31)-(166,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,32)-(166,37) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (166,38)-(166,55) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (166,56)-(166,57) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (167,2)-(167,44) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (168,1)-(168,4) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (168,4)-(168,5) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,5)-(168,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (168,9)-(168,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,11)-(168,20) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (168,21)-(168,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,22)-(168,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (168,23)-(168,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,24)-(168,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (168,26)-(168,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,28)-(168,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (168,38)-(168,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,39)-(168,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (168,40)-(168,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,42)-(168,60) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (168,61)-(168,72) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (168,72)-(168,73) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (168,73)-(168,75) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (168,76)-(168,85) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (168,86)-(168,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (169,1)-(169,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (170,5)-(170,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (170,9)-(170,10) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,10)-(170,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("__itemHandled");
            #line hidden
            #line (170,23)-(170,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,24)-(170,25) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (170,25)-(170,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,26)-(170,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
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
            #line (171,10)-(171,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("__sepHandled");
            #line hidden
            #line (171,22)-(171,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,23)-(171,24) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (171,24)-(171,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,25)-(171,31) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (172,6)-(172,64) 13 "SemanticsGenerator.mxg"
            var itemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            #line (173,6)-(173,76) 13 "SemanticsGenerator.mxg"
            var sepName = "node."+elem.PropertyName+".GetSeparator("+indexName+")";
            #line hidden
            
            #line (174,6)-(174,89) 13 "SemanticsGenerator.mxg"
            var firstCount = System.Math.Max(list.FirstItems.Count, list.FirstSeparators.Count);
            #line hidden
            
            #line (175,6)-(175,86) 13 "SemanticsGenerator.mxg"
            var lastCount = System.Math.Min(list.LastItems.Count, list.LastSeparators.Count);
            #line hidden
            
            #line (176,6)-(176,21) 13 "SemanticsGenerator.mxg"
            var ifElse = "";
            #line hidden
            
            var __first78 = true;
            #line (177,6)-(177,46) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < firstCount - 1; ++i)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                __cb.Push("    ");
                #line (178,6)-(178,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (178,13)-(178,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (178,15)-(178,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,16)-(178,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (178,18)-(178,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (178,28)-(178,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,29)-(178,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (178,31)-(178,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,33)-(178,34) 28 "SemanticsGenerator.mxg"
                __cb.Write(i);
                #line hidden
                #line (178,35)-(178,36) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (179,5)-(179,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (180,10)-(180,154) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.FirstItems[i], sepName, list.FirstSeparators[i], list.SeparatorFirst, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (181,9)-(181,22) 29 "SemanticsGenerator.mxg"
                __cb.Write("__itemHandled");
                #line hidden
                #line (181,22)-(181,23) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (181,23)-(181,24) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (181,24)-(181,25) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (181,25)-(181,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (182,9)-(182,21) 29 "SemanticsGenerator.mxg"
                __cb.Write("__sepHandled");
                #line hidden
                #line (182,21)-(182,22) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (182,22)-(182,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (182,23)-(182,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (182,24)-(182,29) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (183,5)-(183,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (184,10)-(184,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first78) __cb.AppendLine();
            var __first79 = true;
            #line (186,6)-(186,25) 13 "SemanticsGenerator.mxg"
            if (firstCount > 0)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                __cb.Push("    ");
                #line (187,6)-(187,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (187,13)-(187,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (187,15)-(187,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (187,16)-(187,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (187,18)-(187,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (187,28)-(187,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (187,29)-(187,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (187,31)-(187,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (187,33)-(187,45) 28 "SemanticsGenerator.mxg"
                __cb.Write(firstCount-1);
                #line hidden
                #line (187,46)-(187,47) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (188,5)-(188,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first80 = true;
                #line (189,10)-(189,34) 17 "SemanticsGenerator.mxg"
                if (list.SeparatorFirst)
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    __cb.Push("        ");
                    #line (190,10)-(190,157) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.FirstSeparators[firstCount-1], list.FirstSeparators[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (191,9)-(191,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (191,21)-(191,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,22)-(191,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (191,23)-(191,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,24)-(191,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (192,10)-(192,14) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    __cb.Push("        ");
                    #line (193,10)-(193,148) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.FirstItems[firstCount-1], list.FirstItems[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (194,9)-(194,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (194,22)-(194,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,23)-(194,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (194,24)-(194,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,25)-(194,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first80) __cb.AppendLine();
                __cb.Push("    ");
                #line (196,5)-(196,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (197,10)-(197,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first79) __cb.AppendLine();
            var __first81 = true;
            #line (199,6)-(199,41) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < lastCount; ++i)
            #line hidden
            
            {
                if (__first81)
                {
                    __first81 = false;
                }
                __cb.Push("    ");
                #line (200,6)-(200,12) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (200,13)-(200,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (200,15)-(200,16) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,16)-(200,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (200,18)-(200,27) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (200,28)-(200,29) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,29)-(200,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (200,31)-(200,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,33)-(200,51) 28 "SemanticsGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (200,52)-(200,62) 29 "SemanticsGenerator.mxg"
                __cb.Write("List.Count");
                #line hidden
                #line (200,62)-(200,63) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,63)-(200,64) 29 "SemanticsGenerator.mxg"
                __cb.Write("-");
                #line hidden
                #line (200,64)-(200,65) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,66)-(200,79) 28 "SemanticsGenerator.mxg"
                __cb.Write(lastCount - i);
                #line hidden
                #line (200,80)-(200,81) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (201,5)-(201,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (202,10)-(202,35) 17 "SemanticsGenerator.mxg"
                var j = lastCount - 1 - i;
                #line hidden
                
                var __first82 = true;
                #line (203,10)-(203,72) 17 "SemanticsGenerator.mxg"
                if (j < list.LastItems.Count && j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (204,10)-(204,160) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.LastItems[j], sepName, list.LastSeparators[j], list.RepeatedSeparatorFirst, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (205,9)-(205,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (205,22)-(205,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (205,23)-(205,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (205,24)-(205,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (205,25)-(205,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (206,9)-(206,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (206,21)-(206,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,22)-(206,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (206,23)-(206,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,24)-(206,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (207,10)-(207,44) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastItems.Count)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (208,10)-(208,124) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.LastItems[j], list.LastItems[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (209,9)-(209,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (209,22)-(209,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (209,23)-(209,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (209,24)-(209,25) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (209,25)-(209,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (210,10)-(210,49) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (211,10)-(211,133) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.LastSeparators[j], list.LastSeparators[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (212,9)-(212,21) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (212,21)-(212,22) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (212,22)-(212,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (212,23)-(212,24) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (212,24)-(212,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (213,10)-(213,14) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (214,9)-(214,17) 33 "SemanticsGenerator.mxg"
                    __cb.Write("INTERNAL");
                    #line hidden
                    #line (214,17)-(214,18) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (214,18)-(214,23) 33 "SemanticsGenerator.mxg"
                    __cb.Write("ERROR");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first82) __cb.AppendLine();
                __cb.Push("    ");
                #line (216,5)-(216,6) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (217,10)-(217,25) 17 "SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first81) __cb.AppendLine();
            __cb.Push("    ");
            #line (219,5)-(219,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (219,7)-(219,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,8)-(219,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__itemHandled");
            #line hidden
            #line (219,23)-(219,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,24)-(219,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (219,26)-(219,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,28)-(219,37) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (219,38)-(219,39) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,39)-(219,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (219,40)-(219,41) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,41)-(219,46) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (219,47)-(219,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (219,65)-(219,72) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Count)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (220,5)-(220,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (221,10)-(221,142) 13 "SemanticsGenerator.mxg"
            var repItemBody = GenerateBinderFactoryVisitElementValue(itemName, list.RepeatedItem, list.RepeatedItem.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (222,10)-(222,117) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repItemBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (223,5)-(223,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (224,5)-(224,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (224,7)-(224,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,8)-(224,22) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__sepHandled");
            #line hidden
            #line (224,22)-(224,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,23)-(224,25) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (224,25)-(224,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,27)-(224,36) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (224,37)-(224,38) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,38)-(224,39) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (224,39)-(224,40) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,40)-(224,45) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (224,46)-(224,63) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (224,64)-(224,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(".SeparatorCount)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (225,5)-(225,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (226,10)-(226,150) 13 "SemanticsGenerator.mxg"
            var repSepBody = GenerateBinderFactoryVisitElementValue(sepName, list.RepeatedSeparator, list.RepeatedSeparator.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (227,10)-(227,116) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repSepBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (228,5)-(228,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (229,1)-(229,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (232,9)-(232,162) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListItem(string itemName, Element itemElem, string sepName, Element sepElem, bool separatorFirst, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first83 = true;
            #line (233,2)-(233,21) 13 "SemanticsGenerator.mxg"
            if (separatorFirst)
            #line hidden
            
            {
                if (__first83)
                {
                    __first83 = false;
                }
                __cb.Push("");
                #line (234,2)-(234,95) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (235,2)-(235,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (236,2)-(236,6) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first83)
                {
                    __first83 = false;
                }
                __cb.Push("");
                #line (237,2)-(237,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (238,2)-(238,95) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first83) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (242,9)-(242,145) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementValue(string elemName, Element elem, ElementValue elemValue, bool withElemBinders, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first84 = true;
            #line (243,6)-(243,38) 13 "SemanticsGenerator.mxg"
            if (elemValue is TokenAlts alts)
            #line hidden
            
            {
                if (__first84)
                {
                    __first84 = false;
                }
                __cb.Push("");
                #line (244,1)-(244,3) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (244,3)-(244,4) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (244,4)-(244,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (244,6)-(244,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (244,15)-(244,19) 29 "SemanticsGenerator.mxg"
                __cb.Write(".Get");
                #line hidden
                #line (244,20)-(244,24) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (244,25)-(244,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("Kind()");
                #line hidden
                #line (244,31)-(244,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (244,32)-(244,34) 29 "SemanticsGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (244,34)-(244,35) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (244,36)-(244,40) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (244,41)-(244,57) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.None)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (245,1)-(245,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (246,10)-(246,94) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitTokenAlts(elemName, elem, alts, ref annotIndex);
                #line hidden
                
                #line (247,10)-(247,103) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first85 = true;
                #line (248,10)-(248,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first85)
                    {
                        __first85 = false;
                    }
                    #line (249,14)-(249,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first85) __cb.AppendLine();
                __cb.Push("    ");
                #line (251,6)-(251,10) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (252,1)-(252,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (253,1)-(253,5) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (254,1)-(254,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (255,10)-(255,110) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, "// default", true, ref annotIndex);
                #line hidden
                
                var __first86 = true;
                #line (256,10)-(256,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first86)
                    {
                        __first86 = false;
                    }
                    #line (257,14)-(257,106) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, true, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first86) __cb.AppendLine();
                __cb.Push("    ");
                #line (259,6)-(259,10) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (260,1)-(260,2) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (261,6)-(261,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first84)
                {
                    __first84 = false;
                }
                #line (262,10)-(262,95) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitElementBody(elemName, elemValue, ref annotIndex);
                #line hidden
                
                #line (263,10)-(263,108) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(elemValue.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first87 = true;
                #line (264,10)-(264,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first87)
                    {
                        __first87 = false;
                    }
                    #line (265,14)-(265,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first87) __cb.AppendLine();
                __cb.Push("");
                #line (267,2)-(267,6) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first84) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (271,9)-(271,112) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitTokenAlts(string elemName, Element elem, TokenAlts alts, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (272,1)-(272,7) 25 "SemanticsGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (272,7)-(272,8) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,8)-(272,9) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (272,10)-(272,18) 24 "SemanticsGenerator.mxg"
            __cb.Write(elemName);
            #line hidden
            #line (272,19)-(272,23) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Get");
            #line hidden
            #line (272,24)-(272,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (272,29)-(272,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("Kind())");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (273,1)-(273,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first88 = true;
            #line (274,10)-(274,42) 13 "SemanticsGenerator.mxg"
            foreach (var alt in alts.Tokens)
            #line hidden
            
            {
                if (__first88)
                {
                    __first88 = false;
                }
                __cb.Push("    ");
                #line (275,5)-(275,9) 29 "SemanticsGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (275,9)-(275,10) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (275,11)-(275,15) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (275,16)-(275,27) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (275,28)-(275,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(alt.Token.CSharpName);
                #line hidden
                #line (275,49)-(275,50) 29 "SemanticsGenerator.mxg"
                __cb.Write(":");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (276,10)-(276,92) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, alt, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (277,9)-(277,15) 29 "SemanticsGenerator.mxg"
                __cb.Write("break;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first88) __cb.AppendLine();
            __cb.Push("    ");
            #line (279,5)-(279,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (280,9)-(280,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("break;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (281,1)-(281,2) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (284,9)-(284,108) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementBody(string elemName, ElementValue elemValue, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first89 = true;
            #line (285,6)-(285,58) 13 "SemanticsGenerator.mxg"
            if (elemValue is RuleRef rr && rr.Token is not null)
            #line hidden
            
            {
                if (__first89)
                {
                    __first89 = false;
                }
                #line (286,10)-(286,55) 17 "SemanticsGenerator.mxg"
                var body = "//this.VisitToken("+elemName+");";
                #line hidden
                
                __cb.Push("");
                #line (287,2)-(287,92) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(rr.Token.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (288,6)-(288,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first89)
                {
                    __first89 = false;
                }
                __cb.Push("");
                #line (289,1)-(289,12) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Visit(");
                #line hidden
                #line (289,13)-(289,21) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (289,22)-(289,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first89) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}