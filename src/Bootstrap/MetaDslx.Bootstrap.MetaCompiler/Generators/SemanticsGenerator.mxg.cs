#line (1,10)-(1,53) 10 "SemanticsGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "SemanticsGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler.Model;
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
            #line (12,5)-(12,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,10)-(12,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,11)-(12,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,5)-(13,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,10)-(13,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,11)-(13,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,5)-(14,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,10)-(14,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,11)-(14,46) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,5)-(15,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,10)-(15,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,11)-(15,41) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,5)-(17,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (17,14)-(17,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,15)-(17,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,5)-(19,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (19,14)-(19,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,16)-(19,25) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,5)-(20,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,9)-(21,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (21,15)-(21,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,16)-(21,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (21,21)-(21,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,23)-(21,27) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (21,28)-(21,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            #line (21,44)-(21,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,45)-(21,46) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (21,46)-(21,47) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,47)-(21,63) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,9)-(22,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (23,13)-(23,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (23,19)-(23,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,21)-(23,25) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (23,26)-(23,54) 25 "SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory(Compilation");
            #line hidden
            #line (23,54)-(23,55) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,55)-(23,67) 25 "SemanticsGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (23,67)-(23,68) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,68)-(23,76) 25 "SemanticsGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (23,76)-(23,77) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,77)-(23,86) 25 "SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            #line (23,86)-(23,87) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (24,17)-(24,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (24,18)-(24,19) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,19)-(24,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("base(compilation,");
            #line hidden
            #line (24,36)-(24,37) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,37)-(24,46) 25 "SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,13)-(25,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,13)-(26,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,13)-(28,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (28,19)-(28,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,20)-(28,28) 25 "SemanticsGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (28,28)-(28,29) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,29)-(28,49) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (28,49)-(28,50) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,50)-(28,90) 25 "SemanticsGenerator.mxg"
            __cb.Write("CreateBinderFactoryVisitor(BinderFactory");
            #line hidden
            #line (28,90)-(28,91) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,91)-(28,105) 25 "SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,13)-(29,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (30,17)-(30,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (30,23)-(30,24) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,24)-(30,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (30,27)-(30,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,28)-(30,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (30,37)-(30,46) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (30,47)-(30,56) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Binding.");
            #line hidden
            #line (30,57)-(30,61) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (30,62)-(30,98) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(binderFactory);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (31,13)-(31,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,9)-(32,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,5)-(33,6) 25 "SemanticsGenerator.mxg"
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
            #line (38,5)-(38,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (38,10)-(38,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,11)-(38,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,5)-(39,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,10)-(39,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,11)-(39,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (40,5)-(40,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (40,10)-(40,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,11)-(40,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (42,5)-(42,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (42,14)-(42,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,15)-(42,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,5)-(44,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (44,14)-(44,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,16)-(44,25) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (44,26)-(44,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Binding");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,5)-(45,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (46,9)-(46,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (46,14)-(46,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,15)-(46,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (46,24)-(46,33) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (46,34)-(46,42) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,9)-(48,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (48,15)-(48,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,16)-(48,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (48,21)-(48,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,23)-(48,27) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (48,28)-(48,48) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (48,48)-(48,49) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,49)-(48,50) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (48,50)-(48,51) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,51)-(48,102) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor,");
            #line hidden
            #line (48,102)-(48,103) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,103)-(48,104) 25 "SemanticsGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (48,105)-(48,109) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (48,110)-(48,123) 25 "SemanticsGenerator.mxg"
            __cb.Write("SyntaxVisitor");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,9)-(49,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,13)-(50,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (50,21)-(50,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,23)-(50,27) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (50,28)-(50,92) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory");
            #line hidden
            #line (50,92)-(50,93) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,93)-(50,107) 25 "SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (51,17)-(51,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (51,18)-(51,19) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,19)-(51,38) 25 "SemanticsGenerator.mxg"
            __cb.Write("base(binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,13)-(52,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (53,13)-(53,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first74 = true;
            #line (55,14)-(55,50) 13 "SemanticsGenerator.mxg"
            foreach (var rule in RulesAndBlocks)
            #line hidden
            
            {
                if (__first74)
                {
                    __first74 = false;
                }
                var __first75 = true;
                #line (56,18)-(56,56) 17 "SemanticsGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first75)
                    {
                        __first75 = false;
                    }
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (58,22)-(58,63) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitRule(rule, alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first75) __cb.AppendLine();
            }
            if (!__first74) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (62,13)-(62,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (62,19)-(62,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,20)-(62,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (62,27)-(62,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,28)-(62,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (62,32)-(62,33) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,33)-(62,58) 25 "SemanticsGenerator.mxg"
            __cb.Write("VisitSkippedTokensTrivia(");
            #line hidden
            #line (62,59)-(62,63) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (62,64)-(62,89) 25 "SemanticsGenerator.mxg"
            __cb.Write("SkippedTokensTriviaSyntax");
            #line hidden
            #line (62,89)-(62,90) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,90)-(62,95) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,13)-(63,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (64,13)-(64,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (65,9)-(65,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (66,5)-(66,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (69,9)-(69,68) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitRule(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (70,5)-(70,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (70,11)-(70,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,12)-(70,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (70,19)-(70,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,20)-(70,24) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (70,24)-(70,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,25)-(70,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("Visit");
            #line hidden
            #line (70,31)-(70,45) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (70,46)-(70,47) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (70,48)-(70,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.RedName);
            #line hidden
            #line (70,60)-(70,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,61)-(70,66) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (71,5)-(71,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (72,10)-(72,28) 13 "SemanticsGenerator.mxg"
            var annotIndex = 0;
            #line hidden
            
            #line (73,10)-(73,71) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitAlt(alt, ref annotIndex);
            #line hidden
            
            #line (74,10)-(74,101) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(rule.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (75,5)-(75,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (78,9)-(78,76) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitAlt(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (79,6)-(79,72) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitElements(alt, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (80,6)-(80,89) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(alt.Binders, "node", body, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (83,9)-(83,81) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElements(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first76 = true;
            #line (84,6)-(84,70) 13 "SemanticsGenerator.mxg"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                __cb.Push("");
                #line (85,10)-(85,70) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElement(alt, elem, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first76) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (89,9)-(89,136) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinders(IEnumerable<Binder> binders, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first77 = true;
            #line (90,6)-(90,82) 13 "SemanticsGenerator.mxg"
            foreach (var binder in binders.Where(b => b.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first77)
                {
                    __first77 = false;
                }
                #line (91,10)-(91,89) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinder(binder, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first77) __cb.AppendLine();
            __cb.Push("");
            #line (93,6)-(93,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (96,9)-(96,107) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinder(Binder binder, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (97,6)-(97,50) 13 "SemanticsGenerator.mxg"
            var binderVarName = "__annot"+(annotIndex++);
            #line hidden
            
            __cb.Push("");
            #line (98,5)-(98,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (98,8)-(98,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,10)-(98,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (98,24)-(98,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,25)-(98,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (98,26)-(98,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,27)-(98,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (98,30)-(98,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,32)-(98,47) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.TypeName);
            #line hidden
            #line (98,48)-(98,49) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (98,50)-(98,77) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.ConstructorArguments);
            #line hidden
            #line (98,78)-(98,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (99,5)-(99,16) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.Begin(");
            #line hidden
            #line (99,17)-(99,30) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (99,31)-(99,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (99,32)-(99,33) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,34)-(99,42) 24 "SemanticsGenerator.mxg"
            __cb.Write(nodeName);
            #line hidden
            #line (99,43)-(99,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (100,5)-(100,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("try");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (101,5)-(101,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (102,10)-(102,14) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (103,5)-(103,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (104,5)-(104,12) 25 "SemanticsGenerator.mxg"
            __cb.Write("finally");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (105,5)-(105,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (106,9)-(106,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.End(");
            #line hidden
            #line (106,19)-(106,32) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (106,33)-(106,35) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (107,5)-(107,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (110,9)-(110,94) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElement(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (111,6)-(111,111) 13 "SemanticsGenerator.mxg"
            var isList = MetaDslx.Bootstrap.MetaCompiler.Model.MultiplicityExtensions.IsList(elem.Value.Multiplicity);
            #line hidden
            
            #line (112,6)-(112,119) 13 "SemanticsGenerator.mxg"
            var isOptional = MetaDslx.Bootstrap.MetaCompiler.Model.MultiplicityExtensions.IsOptional(elem.Value.Multiplicity);
            #line hidden
            
            var __first78 = true;
            #line (113,6)-(113,17) 13 "SemanticsGenerator.mxg"
            if (isList)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (114,10)-(114,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (115,10)-(115,86) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitListElements(alt, elem, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (116,10)-(116,96) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (117,6)-(117,46) 13 "SemanticsGenerator.mxg"
            else if (elem.Value is SeparatedList sl)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (118,10)-(118,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (119,10)-(119,99) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitSeparatedListElements(alt, elem, sl, ref annotIndex);
                #line hidden
                
                #line (120,10)-(120,101) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(sl.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (121,10)-(121,96) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (122,6)-(122,26) 13 "SemanticsGenerator.mxg"
            else if (isOptional)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (123,10)-(123,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (124,9)-(124,11) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (124,11)-(124,12) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (124,12)-(124,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (124,14)-(124,22) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                var __first79 = true;
                #line (124,24)-(124,41) 17 "SemanticsGenerator.mxg"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first79)
                    {
                        __first79 = false;
                    }
                    #line (124,42)-(124,46) 33 "SemanticsGenerator.mxg"
                    __cb.Write(".Get");
                    #line hidden
                    #line (124,47)-(124,51) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (124,52)-(124,58) 33 "SemanticsGenerator.mxg"
                    __cb.Write("Kind()");
                    #line hidden
                    #line (124,58)-(124,59) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,59)-(124,61) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (124,61)-(124,62) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,63)-(124,67) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (124,68)-(124,83) 33 "SemanticsGenerator.mxg"
                    __cb.Write("SyntaxKind.None");
                    #line hidden
                }
                #line (124,84)-(124,88) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first79)
                    {
                        __first79 = false;
                    }
                    #line (124,89)-(124,90) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,90)-(124,92) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (124,92)-(124,93) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (124,93)-(124,97) 33 "SemanticsGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                }
                #line (124,105)-(124,106) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (125,9)-(125,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (126,14)-(126,102) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (127,9)-(127,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (128,6)-(128,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (129,10)-(129,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (130,10)-(130,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first78) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (134,9)-(134,99) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitListElements(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (135,5)-(135,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (135,8)-(135,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,10)-(135,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (135,29)-(135,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (135,33)-(135,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,34)-(135,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (135,35)-(135,36) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,36)-(135,41) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (135,42)-(135,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (135,60)-(135,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (136,6)-(136,48) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (137,5)-(137,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (137,8)-(137,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,9)-(137,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (137,13)-(137,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,15)-(137,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (137,25)-(137,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,26)-(137,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (137,27)-(137,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,28)-(137,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (137,30)-(137,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,32)-(137,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (137,42)-(137,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,43)-(137,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (137,44)-(137,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,46)-(137,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (137,65)-(137,76) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (137,76)-(137,77) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,77)-(137,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (137,80)-(137,89) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (137,90)-(137,91) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (138,5)-(138,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (139,10)-(139,68) 13 "SemanticsGenerator.mxg"
            var elemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            __cb.Push("    ");
            #line (140,10)-(140,99) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (141,5)-(141,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (144,9)-(144,128) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListElements(Alternative alt, Element elem, SeparatedList list, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (145,5)-(145,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (145,8)-(145,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,10)-(145,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (145,29)-(145,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (145,33)-(145,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,34)-(145,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (145,35)-(145,36) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,36)-(145,41) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (145,42)-(145,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (145,60)-(145,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (146,6)-(146,48) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (147,5)-(147,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (147,8)-(147,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,9)-(147,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (147,13)-(147,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,15)-(147,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (147,25)-(147,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,26)-(147,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (147,27)-(147,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,28)-(147,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (147,30)-(147,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,32)-(147,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (147,42)-(147,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,43)-(147,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (147,44)-(147,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,46)-(147,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (147,65)-(147,76) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (147,76)-(147,77) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,77)-(147,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (147,80)-(147,89) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (147,90)-(147,91) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (148,5)-(148,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (149,9)-(149,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (149,13)-(149,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,14)-(149,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("__itemHandled");
            #line hidden
            #line (149,27)-(149,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,28)-(149,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (149,29)-(149,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,30)-(149,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (150,9)-(150,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (150,13)-(150,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,14)-(150,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("__sepHandled");
            #line hidden
            #line (150,26)-(150,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,27)-(150,28) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (150,28)-(150,29) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,29)-(150,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (151,10)-(151,68) 13 "SemanticsGenerator.mxg"
            var itemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            #line (152,10)-(152,80) 13 "SemanticsGenerator.mxg"
            var sepName = "node."+elem.PropertyName+".GetSeparator("+indexName+")";
            #line hidden
            
            #line (153,10)-(153,93) 13 "SemanticsGenerator.mxg"
            var firstCount = System.Math.Max(list.FirstItems.Count, list.FirstSeparators.Count);
            #line hidden
            
            #line (154,10)-(154,90) 13 "SemanticsGenerator.mxg"
            var lastCount = System.Math.Min(list.LastItems.Count, list.LastSeparators.Count);
            #line hidden
            
            #line (155,10)-(155,25) 13 "SemanticsGenerator.mxg"
            var ifElse = "";
            #line hidden
            
            var __first80 = true;
            #line (156,10)-(156,50) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < firstCount - 1; ++i)
            #line hidden
            
            {
                if (__first80)
                {
                    __first80 = false;
                }
                __cb.Push("    ");
                #line (157,14)-(157,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (157,21)-(157,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (157,23)-(157,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (157,24)-(157,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (157,26)-(157,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (157,36)-(157,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (157,37)-(157,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (157,39)-(157,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (157,41)-(157,42) 28 "SemanticsGenerator.mxg"
                __cb.Write(i);
                #line hidden
                #line (157,43)-(157,44) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (158,13)-(158,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (159,18)-(159,162) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.FirstItems[i], sepName, list.FirstSeparators[i], list.SeparatorFirst, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (160,17)-(160,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("__itemHandled");
                #line hidden
                #line (160,30)-(160,31) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (160,31)-(160,32) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (160,32)-(160,33) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (160,33)-(160,38) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (161,17)-(161,29) 29 "SemanticsGenerator.mxg"
                __cb.Write("__sepHandled");
                #line hidden
                #line (161,29)-(161,30) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (161,30)-(161,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (161,31)-(161,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (161,32)-(161,37) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (162,13)-(162,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (163,14)-(163,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first80) __cb.AppendLine();
            var __first81 = true;
            #line (165,10)-(165,29) 13 "SemanticsGenerator.mxg"
            if (firstCount > 0)
            #line hidden
            
            {
                if (__first81)
                {
                    __first81 = false;
                }
                __cb.Push("    ");
                #line (166,14)-(166,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (166,21)-(166,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (166,23)-(166,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (166,24)-(166,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (166,26)-(166,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (166,36)-(166,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (166,37)-(166,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (166,39)-(166,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (166,41)-(166,53) 28 "SemanticsGenerator.mxg"
                __cb.Write(firstCount-1);
                #line hidden
                #line (166,54)-(166,55) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (167,13)-(167,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first82 = true;
                #line (168,18)-(168,42) 17 "SemanticsGenerator.mxg"
                if (list.SeparatorFirst)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (169,22)-(169,169) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.FirstSeparators[firstCount-1], list.FirstSeparators[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (170,21)-(170,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (170,33)-(170,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (170,34)-(170,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (170,35)-(170,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (170,36)-(170,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (171,18)-(171,22) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (172,22)-(172,160) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.FirstItems[firstCount-1], list.FirstItems[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (173,21)-(173,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (173,34)-(173,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (173,35)-(173,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (173,36)-(173,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (173,37)-(173,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first82) __cb.AppendLine();
                __cb.Push("    ");
                #line (175,13)-(175,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (176,14)-(176,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first81) __cb.AppendLine();
            var __first83 = true;
            #line (178,10)-(178,45) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < lastCount; ++i)
            #line hidden
            
            {
                if (__first83)
                {
                    __first83 = false;
                }
                __cb.Push("    ");
                #line (179,14)-(179,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (179,21)-(179,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (179,23)-(179,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,24)-(179,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (179,26)-(179,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (179,36)-(179,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,37)-(179,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (179,39)-(179,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,41)-(179,59) 28 "SemanticsGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (179,60)-(179,70) 29 "SemanticsGenerator.mxg"
                __cb.Write("List.Count");
                #line hidden
                #line (179,70)-(179,71) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,71)-(179,72) 29 "SemanticsGenerator.mxg"
                __cb.Write("-");
                #line hidden
                #line (179,72)-(179,73) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,74)-(179,87) 28 "SemanticsGenerator.mxg"
                __cb.Write(lastCount - i);
                #line hidden
                #line (179,88)-(179,89) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (180,13)-(180,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (181,18)-(181,43) 17 "SemanticsGenerator.mxg"
                var j = lastCount - 1 - i;
                #line hidden
                
                var __first84 = true;
                #line (182,18)-(182,80) 17 "SemanticsGenerator.mxg"
                if (j < list.LastItems.Count && j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (183,22)-(183,172) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.LastItems[j], sepName, list.LastSeparators[j], list.RepeatedSeparatorFirst, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (184,21)-(184,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (184,34)-(184,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (184,35)-(184,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (184,36)-(184,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (184,37)-(184,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (185,21)-(185,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (185,33)-(185,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (185,34)-(185,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (185,35)-(185,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (185,36)-(185,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (186,18)-(186,52) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastItems.Count)
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (187,22)-(187,136) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.LastItems[j], list.LastItems[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (188,21)-(188,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (188,34)-(188,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,35)-(188,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (188,36)-(188,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,37)-(188,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (189,18)-(189,57) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (190,22)-(190,145) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.LastSeparators[j], list.LastSeparators[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (191,21)-(191,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (191,33)-(191,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,34)-(191,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (191,35)-(191,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,36)-(191,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (192,18)-(192,22) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (193,21)-(193,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("INTERNAL");
                    #line hidden
                    #line (193,29)-(193,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (193,30)-(193,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("ERROR");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first84) __cb.AppendLine();
                __cb.Push("    ");
                #line (195,13)-(195,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (196,14)-(196,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first83) __cb.AppendLine();
            __cb.Push("    ");
            #line (198,9)-(198,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (198,11)-(198,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,12)-(198,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__itemHandled");
            #line hidden
            #line (198,27)-(198,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,28)-(198,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (198,30)-(198,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,32)-(198,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (198,42)-(198,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,43)-(198,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (198,44)-(198,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,45)-(198,50) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (198,51)-(198,68) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (198,69)-(198,76) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Count)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (199,9)-(199,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (200,14)-(200,146) 13 "SemanticsGenerator.mxg"
            var repItemBody = GenerateBinderFactoryVisitElementValue(itemName, list.RepeatedItem, list.RepeatedItem.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (201,14)-(201,121) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repItemBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (202,9)-(202,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (203,9)-(203,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (203,11)-(203,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,12)-(203,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__sepHandled");
            #line hidden
            #line (203,26)-(203,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,27)-(203,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (203,29)-(203,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,31)-(203,40) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (203,41)-(203,42) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,42)-(203,43) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (203,43)-(203,44) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,44)-(203,49) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (203,50)-(203,67) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (203,68)-(203,84) 25 "SemanticsGenerator.mxg"
            __cb.Write(".SeparatorCount)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (204,9)-(204,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (205,14)-(205,154) 13 "SemanticsGenerator.mxg"
            var repSepBody = GenerateBinderFactoryVisitElementValue(sepName, list.RepeatedSeparator, list.RepeatedSeparator.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (206,14)-(206,120) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repSepBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (207,9)-(207,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (208,5)-(208,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (211,9)-(211,162) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListItem(string itemName, Element itemElem, string sepName, Element sepElem, bool separatorFirst, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first85 = true;
            #line (212,6)-(212,25) 13 "SemanticsGenerator.mxg"
            if (separatorFirst)
            #line hidden
            
            {
                if (__first85)
                {
                    __first85 = false;
                }
                __cb.Push("");
                #line (213,10)-(213,103) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (214,10)-(214,106) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (215,6)-(215,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first85)
                {
                    __first85 = false;
                }
                __cb.Push("");
                #line (216,10)-(216,106) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (217,10)-(217,103) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first85) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (221,9)-(221,145) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementValue(string elemName, Element elem, ElementValue elemValue, bool withElemBinders, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first86 = true;
            #line (222,6)-(222,38) 13 "SemanticsGenerator.mxg"
            if (elemValue is TokenAlts alts)
            #line hidden
            
            {
                if (__first86)
                {
                    __first86 = false;
                }
                __cb.Push("");
                #line (223,9)-(223,11) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (223,11)-(223,12) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,12)-(223,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (223,14)-(223,22) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (223,23)-(223,27) 29 "SemanticsGenerator.mxg"
                __cb.Write(".Get");
                #line hidden
                #line (223,28)-(223,32) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (223,33)-(223,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("Kind()");
                #line hidden
                #line (223,39)-(223,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,40)-(223,42) 29 "SemanticsGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (223,42)-(223,43) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,44)-(223,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (223,49)-(223,65) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.None)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (224,9)-(224,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (225,14)-(225,98) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitTokenAlts(elemName, elem, alts, ref annotIndex);
                #line hidden
                
                #line (226,14)-(226,107) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first87 = true;
                #line (227,14)-(227,34) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first87)
                    {
                        __first87 = false;
                    }
                    #line (228,18)-(228,111) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first87) __cb.AppendLine();
                __cb.Push("    ");
                #line (230,14)-(230,18) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (231,9)-(231,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (232,9)-(232,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (233,9)-(233,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (234,14)-(234,114) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, "// default", true, ref annotIndex);
                #line hidden
                
                var __first88 = true;
                #line (235,14)-(235,34) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first88)
                    {
                        __first88 = false;
                    }
                    #line (236,18)-(236,110) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, true, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first88) __cb.AppendLine();
                __cb.Push("    ");
                #line (238,14)-(238,18) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (239,9)-(239,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (240,6)-(240,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first86)
                {
                    __first86 = false;
                }
                #line (241,10)-(241,95) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitElementBody(elemName, elemValue, ref annotIndex);
                #line hidden
                
                #line (242,10)-(242,108) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(elemValue.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first89 = true;
                #line (243,10)-(243,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first89)
                    {
                        __first89 = false;
                    }
                    #line (244,14)-(244,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first89) __cb.AppendLine();
                __cb.Push("");
                #line (246,10)-(246,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first86) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (250,9)-(250,112) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitTokenAlts(string elemName, Element elem, TokenAlts alts, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (251,5)-(251,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (251,11)-(251,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,12)-(251,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (251,14)-(251,22) 24 "SemanticsGenerator.mxg"
            __cb.Write(elemName);
            #line hidden
            #line (251,23)-(251,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Get");
            #line hidden
            #line (251,28)-(251,32) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (251,33)-(251,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("Kind())");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (252,5)-(252,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first90 = true;
            #line (253,10)-(253,42) 13 "SemanticsGenerator.mxg"
            foreach (var alt in alts.Tokens)
            #line hidden
            
            {
                if (__first90)
                {
                    __first90 = false;
                }
                __cb.Push("    ");
                #line (254,13)-(254,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (254,17)-(254,18) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (254,19)-(254,23) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (254,24)-(254,35) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (254,36)-(254,56) 28 "SemanticsGenerator.mxg"
                __cb.Write(alt.Token.CSharpName);
                #line hidden
                #line (254,57)-(254,58) 29 "SemanticsGenerator.mxg"
                __cb.Write(":");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (255,18)-(255,100) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, alt, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (256,17)-(256,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("break;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first90) __cb.AppendLine();
            __cb.Push("    ");
            #line (258,9)-(258,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (259,13)-(259,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("break;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (260,5)-(260,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (263,9)-(263,108) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementBody(string elemName, ElementValue elemValue, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first91 = true;
            #line (264,6)-(264,58) 13 "SemanticsGenerator.mxg"
            if (elemValue is RuleRef rr && rr.Token is not null)
            #line hidden
            
            {
                if (__first91)
                {
                    __first91 = false;
                }
                #line (265,10)-(265,55) 17 "SemanticsGenerator.mxg"
                var body = "//this.VisitToken("+elemName+");";
                #line hidden
                
                __cb.Push("");
                #line (266,10)-(266,100) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(rr.Token.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (267,6)-(267,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first91)
                {
                    __first91 = false;
                }
                __cb.Push("");
                #line (268,9)-(268,20) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Visit(");
                #line hidden
                #line (268,21)-(268,29) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (268,30)-(268,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first91) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}