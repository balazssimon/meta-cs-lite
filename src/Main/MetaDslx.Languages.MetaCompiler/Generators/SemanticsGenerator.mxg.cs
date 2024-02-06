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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,5)-(20,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,9)-(22,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,13)-(25,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,13)-(26,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,13)-(29,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (31,13)-(31,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,9)-(32,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,5)-(33,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,5)-(45,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,9)-(49,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,13)-(52,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (53,13)-(53,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
                    __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,13)-(63,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (64,13)-(64,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (65,9)-(65,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (66,5)-(66,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
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
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (71,5)-(71,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            
            __cb.Push("    ");
            #line (75,10)-(75,14) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (76,5)-(76,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (79,9)-(79,76) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitAlt(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (80,6)-(80,72) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitElements(alt, ref annotIndex);
            #line hidden
            
            #line (81,6)-(81,96) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(alt.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (82,6)-(82,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (85,9)-(85,81) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElements(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first76 = true;
            #line (86,6)-(86,70) 13 "SemanticsGenerator.mxg"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                __cb.Push("");
                #line (87,10)-(87,70) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElement(alt, elem, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first76) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (91,9)-(91,136) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinders(IEnumerable<Binder> binders, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first77 = true;
            #line (92,6)-(92,82) 13 "SemanticsGenerator.mxg"
            foreach (var binder in binders.Where(b => b.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first77)
                {
                    __first77 = false;
                }
                #line (93,10)-(93,89) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinder(binder, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first77) __cb.AppendLine();
            __cb.Push("");
            #line (95,6)-(95,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (98,9)-(98,107) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinder(Binder binder, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (99,6)-(99,50) 13 "SemanticsGenerator.mxg"
            var binderVarName = "__annot"+(annotIndex++);
            #line hidden
            
            __cb.Push("");
            #line (100,5)-(100,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (100,8)-(100,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,10)-(100,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (100,24)-(100,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,25)-(100,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (100,26)-(100,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,27)-(100,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (100,30)-(100,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,32)-(100,47) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.TypeName);
            #line hidden
            #line (100,48)-(100,49) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (100,50)-(100,77) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.ConstructorArguments);
            #line hidden
            #line (100,78)-(100,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (101,5)-(101,16) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.Begin(");
            #line hidden
            #line (101,17)-(101,30) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (101,31)-(101,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (101,32)-(101,33) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,34)-(101,42) 24 "SemanticsGenerator.mxg"
            __cb.Write(nodeName);
            #line hidden
            #line (101,43)-(101,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (102,5)-(102,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("try");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (103,5)-(103,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (104,10)-(104,14) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (105,5)-(105,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (106,5)-(106,12) 25 "SemanticsGenerator.mxg"
            __cb.Write("finally");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (107,5)-(107,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (108,9)-(108,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.End(");
            #line hidden
            #line (108,19)-(108,32) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (108,33)-(108,35) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (109,5)-(109,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (112,9)-(112,94) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElement(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (113,6)-(113,111) 13 "SemanticsGenerator.mxg"
            var isList = MetaDslx.Languages.MetaCompiler.Model.MultiplicityExtensions.IsList(elem.Value.Multiplicity);
            #line hidden
            
            #line (114,6)-(114,119) 13 "SemanticsGenerator.mxg"
            var isOptional = MetaDslx.Languages.MetaCompiler.Model.MultiplicityExtensions.IsOptional(elem.Value.Multiplicity);
            #line hidden
            
            var __first78 = true;
            #line (115,6)-(115,17) 13 "SemanticsGenerator.mxg"
            if (isList)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (116,10)-(116,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (117,10)-(117,86) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitListElements(alt, elem, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (118,10)-(118,96) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (119,6)-(119,46) 13 "SemanticsGenerator.mxg"
            else if (elem.Value is SeparatedList sl)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (120,10)-(120,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (121,10)-(121,99) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitSeparatedListElements(alt, elem, sl, ref annotIndex);
                #line hidden
                
                #line (122,10)-(122,101) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(sl.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (123,10)-(123,96) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (124,6)-(124,26) 13 "SemanticsGenerator.mxg"
            else if (isOptional)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (125,10)-(125,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (126,9)-(126,11) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (126,11)-(126,12) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (126,12)-(126,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (126,14)-(126,22) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                var __first79 = true;
                #line (126,24)-(126,41) 17 "SemanticsGenerator.mxg"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first79)
                    {
                        __first79 = false;
                    }
                    #line (126,42)-(126,46) 33 "SemanticsGenerator.mxg"
                    __cb.Write(".Get");
                    #line hidden
                    #line (126,47)-(126,51) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (126,52)-(126,58) 33 "SemanticsGenerator.mxg"
                    __cb.Write("Kind()");
                    #line hidden
                    #line (126,58)-(126,59) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (126,59)-(126,61) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (126,61)-(126,62) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (126,63)-(126,67) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (126,68)-(126,83) 33 "SemanticsGenerator.mxg"
                    __cb.Write("SyntaxKind.None");
                    #line hidden
                }
                #line (126,84)-(126,88) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first79)
                    {
                        __first79 = false;
                    }
                    #line (126,89)-(126,90) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (126,90)-(126,92) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (126,92)-(126,93) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (126,93)-(126,97) 33 "SemanticsGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                }
                #line (126,105)-(126,106) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (127,9)-(127,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (128,14)-(128,102) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (129,9)-(129,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (130,6)-(130,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (131,10)-(131,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (132,10)-(132,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first78) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (136,9)-(136,99) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitListElements(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (137,5)-(137,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (137,8)-(137,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,10)-(137,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (137,29)-(137,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (137,33)-(137,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,34)-(137,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (137,35)-(137,36) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,36)-(137,41) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (137,42)-(137,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (137,60)-(137,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (138,6)-(138,48) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (139,5)-(139,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (139,8)-(139,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,9)-(139,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (139,13)-(139,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,15)-(139,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (139,25)-(139,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,26)-(139,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (139,27)-(139,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,28)-(139,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (139,30)-(139,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,32)-(139,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (139,42)-(139,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,43)-(139,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (139,44)-(139,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,46)-(139,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (139,65)-(139,76) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (139,76)-(139,77) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,77)-(139,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (139,80)-(139,89) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (139,90)-(139,91) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (140,5)-(140,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (141,10)-(141,68) 13 "SemanticsGenerator.mxg"
            var elemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            __cb.Push("    ");
            #line (142,10)-(142,99) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, false, ref annotIndex));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (143,5)-(143,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (146,9)-(146,128) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListElements(Alternative alt, Element elem, SeparatedList list, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (147,5)-(147,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (147,8)-(147,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,10)-(147,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (147,29)-(147,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (147,33)-(147,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,34)-(147,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (147,35)-(147,36) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,36)-(147,41) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (147,42)-(147,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (147,60)-(147,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (148,6)-(148,48) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (149,5)-(149,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (149,8)-(149,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,9)-(149,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (149,13)-(149,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,15)-(149,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (149,25)-(149,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,26)-(149,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (149,27)-(149,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,28)-(149,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (149,30)-(149,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,32)-(149,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (149,42)-(149,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,43)-(149,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (149,44)-(149,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,46)-(149,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (149,65)-(149,76) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (149,76)-(149,77) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,77)-(149,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (149,80)-(149,89) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (149,90)-(149,91) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (150,5)-(150,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (151,9)-(151,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (151,13)-(151,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,14)-(151,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("__itemHandled");
            #line hidden
            #line (151,27)-(151,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,28)-(151,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (151,29)-(151,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,30)-(151,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (152,9)-(152,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (152,13)-(152,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,14)-(152,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("__sepHandled");
            #line hidden
            #line (152,26)-(152,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,27)-(152,28) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (152,28)-(152,29) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,29)-(152,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (153,10)-(153,68) 13 "SemanticsGenerator.mxg"
            var itemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            #line (154,10)-(154,80) 13 "SemanticsGenerator.mxg"
            var sepName = "node."+elem.PropertyName+".GetSeparator("+indexName+")";
            #line hidden
            
            #line (155,10)-(155,93) 13 "SemanticsGenerator.mxg"
            var firstCount = System.Math.Max(list.FirstItems.Count, list.FirstSeparators.Count);
            #line hidden
            
            #line (156,10)-(156,90) 13 "SemanticsGenerator.mxg"
            var lastCount = System.Math.Min(list.LastItems.Count, list.LastSeparators.Count);
            #line hidden
            
            #line (157,10)-(157,25) 13 "SemanticsGenerator.mxg"
            var ifElse = "";
            #line hidden
            
            var __first80 = true;
            #line (158,10)-(158,50) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < firstCount - 1; ++i)
            #line hidden
            
            {
                if (__first80)
                {
                    __first80 = false;
                }
                __cb.Push("    ");
                #line (159,14)-(159,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (159,21)-(159,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (159,23)-(159,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,24)-(159,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (159,26)-(159,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (159,36)-(159,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,37)-(159,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (159,39)-(159,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,41)-(159,42) 28 "SemanticsGenerator.mxg"
                __cb.Write(i);
                #line hidden
                #line (159,43)-(159,44) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (160,13)-(160,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (161,18)-(161,162) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.FirstItems[i], sepName, list.FirstSeparators[i], list.SeparatorFirst, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (162,17)-(162,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("__itemHandled");
                #line hidden
                #line (162,30)-(162,31) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,31)-(162,32) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (162,32)-(162,33) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,33)-(162,38) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (163,17)-(163,29) 29 "SemanticsGenerator.mxg"
                __cb.Write("__sepHandled");
                #line hidden
                #line (163,29)-(163,30) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (163,30)-(163,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (163,31)-(163,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (163,32)-(163,37) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (164,13)-(164,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (165,14)-(165,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first80) __cb.AppendLine();
            var __first81 = true;
            #line (167,10)-(167,29) 13 "SemanticsGenerator.mxg"
            if (firstCount > 0)
            #line hidden
            
            {
                if (__first81)
                {
                    __first81 = false;
                }
                __cb.Push("    ");
                #line (168,14)-(168,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (168,21)-(168,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (168,23)-(168,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (168,24)-(168,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (168,26)-(168,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (168,36)-(168,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (168,37)-(168,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (168,39)-(168,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (168,41)-(168,53) 28 "SemanticsGenerator.mxg"
                __cb.Write(firstCount-1);
                #line hidden
                #line (168,54)-(168,55) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (169,13)-(169,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first82 = true;
                #line (170,18)-(170,42) 17 "SemanticsGenerator.mxg"
                if (list.SeparatorFirst)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (171,22)-(171,169) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.FirstSeparators[firstCount-1], list.FirstSeparators[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (172,21)-(172,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (172,33)-(172,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (172,34)-(172,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (172,35)-(172,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (172,36)-(172,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (173,18)-(173,22) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("        ");
                    #line (174,22)-(174,160) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.FirstItems[firstCount-1], list.FirstItems[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (175,21)-(175,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (175,34)-(175,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,35)-(175,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (175,36)-(175,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,37)-(175,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first82) __cb.AppendLine();
                __cb.Push("    ");
                #line (177,13)-(177,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (178,14)-(178,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first81) __cb.AppendLine();
            var __first83 = true;
            #line (180,10)-(180,45) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < lastCount; ++i)
            #line hidden
            
            {
                if (__first83)
                {
                    __first83 = false;
                }
                __cb.Push("    ");
                #line (181,14)-(181,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (181,21)-(181,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (181,23)-(181,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (181,24)-(181,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (181,26)-(181,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (181,36)-(181,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (181,37)-(181,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (181,39)-(181,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (181,41)-(181,59) 28 "SemanticsGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (181,60)-(181,70) 29 "SemanticsGenerator.mxg"
                __cb.Write("List.Count");
                #line hidden
                #line (181,70)-(181,71) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (181,71)-(181,72) 29 "SemanticsGenerator.mxg"
                __cb.Write("-");
                #line hidden
                #line (181,72)-(181,73) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (181,74)-(181,87) 28 "SemanticsGenerator.mxg"
                __cb.Write(lastCount - i);
                #line hidden
                #line (181,88)-(181,89) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (182,13)-(182,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (183,18)-(183,43) 17 "SemanticsGenerator.mxg"
                var j = lastCount - 1 - i;
                #line hidden
                
                var __first84 = true;
                #line (184,18)-(184,80) 17 "SemanticsGenerator.mxg"
                if (j < list.LastItems.Count && j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (185,22)-(185,172) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.LastItems[j], sepName, list.LastSeparators[j], list.RepeatedSeparatorFirst, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (186,21)-(186,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (186,34)-(186,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,35)-(186,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (186,36)-(186,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,37)-(186,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (187,21)-(187,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (187,33)-(187,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,34)-(187,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (187,35)-(187,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,36)-(187,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (188,18)-(188,52) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastItems.Count)
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (189,22)-(189,136) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.LastItems[j], list.LastItems[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (190,21)-(190,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (190,34)-(190,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (190,35)-(190,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (190,36)-(190,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (190,37)-(190,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (191,18)-(191,57) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (192,22)-(192,145) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.LastSeparators[j], list.LastSeparators[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (193,21)-(193,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (193,33)-(193,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (193,34)-(193,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (193,35)-(193,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (193,36)-(193,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (194,18)-(194,22) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first84)
                    {
                        __first84 = false;
                    }
                    __cb.Push("        ");
                    #line (195,21)-(195,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("INTERNAL");
                    #line hidden
                    #line (195,29)-(195,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (195,30)-(195,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("ERROR");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first84) __cb.AppendLine();
                __cb.Push("    ");
                #line (197,13)-(197,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (198,14)-(198,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first83) __cb.AppendLine();
            __cb.Push("    ");
            #line (200,9)-(200,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (200,11)-(200,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,12)-(200,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__itemHandled");
            #line hidden
            #line (200,27)-(200,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,28)-(200,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (200,30)-(200,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,32)-(200,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (200,42)-(200,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,43)-(200,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (200,44)-(200,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,45)-(200,50) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (200,51)-(200,68) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (200,69)-(200,76) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Count)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (201,9)-(201,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (202,14)-(202,146) 13 "SemanticsGenerator.mxg"
            var repItemBody = GenerateBinderFactoryVisitElementValue(itemName, list.RepeatedItem, list.RepeatedItem.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (203,14)-(203,121) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repItemBody, false, ref annotIndex));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (204,9)-(204,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (205,9)-(205,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (205,11)-(205,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,12)-(205,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__sepHandled");
            #line hidden
            #line (205,26)-(205,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,27)-(205,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (205,29)-(205,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,31)-(205,40) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (205,41)-(205,42) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,42)-(205,43) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (205,43)-(205,44) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,44)-(205,49) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (205,50)-(205,67) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (205,68)-(205,84) 25 "SemanticsGenerator.mxg"
            __cb.Write(".SeparatorCount)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (206,9)-(206,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (207,14)-(207,154) 13 "SemanticsGenerator.mxg"
            var repSepBody = GenerateBinderFactoryVisitElementValue(sepName, list.RepeatedSeparator, list.RepeatedSeparator.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (208,14)-(208,120) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repSepBody, false, ref annotIndex));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (209,9)-(209,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (210,5)-(210,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (213,9)-(213,162) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListItem(string itemName, Element itemElem, string sepName, Element sepElem, bool separatorFirst, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first85 = true;
            #line (214,6)-(214,25) 13 "SemanticsGenerator.mxg"
            if (separatorFirst)
            #line hidden
            
            {
                if (__first85)
                {
                    __first85 = false;
                }
                __cb.Push("");
                #line (215,10)-(215,103) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (216,10)-(216,106) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (217,6)-(217,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first85)
                {
                    __first85 = false;
                }
                __cb.Push("");
                #line (218,10)-(218,106) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (219,10)-(219,103) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first85) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (223,9)-(223,145) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementValue(string elemName, Element elem, ElementValue elemValue, bool withElemBinders, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first86 = true;
            #line (224,6)-(224,38) 13 "SemanticsGenerator.mxg"
            if (elemValue is TokenAlts alts)
            #line hidden
            
            {
                if (__first86)
                {
                    __first86 = false;
                }
                __cb.Push("");
                #line (225,9)-(225,11) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (225,11)-(225,12) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,12)-(225,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (225,14)-(225,22) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (225,23)-(225,27) 29 "SemanticsGenerator.mxg"
                __cb.Write(".Get");
                #line hidden
                #line (225,28)-(225,32) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (225,33)-(225,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("Kind()");
                #line hidden
                #line (225,39)-(225,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,40)-(225,42) 29 "SemanticsGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (225,42)-(225,43) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,44)-(225,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (225,49)-(225,65) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.None)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (226,9)-(226,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (227,14)-(227,98) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitTokenAlts(elemName, elem, alts, ref annotIndex);
                #line hidden
                
                #line (228,14)-(228,107) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first87 = true;
                #line (229,14)-(229,34) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first87)
                    {
                        __first87 = false;
                    }
                    #line (230,18)-(230,111) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first87) __cb.AppendLine();
                __cb.Push("    ");
                #line (232,14)-(232,18) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (233,9)-(233,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (234,9)-(234,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (235,9)-(235,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (236,14)-(236,114) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, "// default", true, ref annotIndex);
                #line hidden
                
                var __first88 = true;
                #line (237,14)-(237,34) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first88)
                    {
                        __first88 = false;
                    }
                    #line (238,18)-(238,110) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, true, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first88) __cb.AppendLine();
                __cb.Push("    ");
                #line (240,14)-(240,18) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (241,9)-(241,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (242,6)-(242,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first86)
                {
                    __first86 = false;
                }
                #line (243,10)-(243,95) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitElementBody(elemName, elemValue, ref annotIndex);
                #line hidden
                
                #line (244,10)-(244,108) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(elemValue.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first89 = true;
                #line (245,10)-(245,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first89)
                    {
                        __first89 = false;
                    }
                    #line (246,14)-(246,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first89) __cb.AppendLine();
                __cb.Push("");
                #line (248,10)-(248,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first86) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (252,9)-(252,112) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitTokenAlts(string elemName, Element elem, TokenAlts alts, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (253,5)-(253,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (253,11)-(253,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,12)-(253,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (253,14)-(253,22) 24 "SemanticsGenerator.mxg"
            __cb.Write(elemName);
            #line hidden
            #line (253,23)-(253,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Get");
            #line hidden
            #line (253,28)-(253,32) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (253,33)-(253,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("Kind())");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (254,5)-(254,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first90 = true;
            #line (255,10)-(255,42) 13 "SemanticsGenerator.mxg"
            foreach (var alt in alts.Tokens)
            #line hidden
            
            {
                if (__first90)
                {
                    __first90 = false;
                }
                __cb.Push("    ");
                #line (256,13)-(256,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (256,17)-(256,18) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,19)-(256,23) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (256,24)-(256,35) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (256,36)-(256,56) 28 "SemanticsGenerator.mxg"
                __cb.Write(alt.Token.CSharpName);
                #line hidden
                #line (256,57)-(256,58) 29 "SemanticsGenerator.mxg"
                __cb.Write(":");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (257,18)-(257,100) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, alt, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (258,17)-(258,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("break;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first90) __cb.AppendLine();
            __cb.Push("    ");
            #line (260,9)-(260,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (261,13)-(261,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("break;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (262,5)-(262,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (265,9)-(265,108) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementBody(string elemName, ElementValue elemValue, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first91 = true;
            #line (266,6)-(266,58) 13 "SemanticsGenerator.mxg"
            if (elemValue is RuleRef rr && rr.Token is not null)
            #line hidden
            
            {
                if (__first91)
                {
                    __first91 = false;
                }
                #line (267,10)-(267,55) 17 "SemanticsGenerator.mxg"
                var body = "//this.VisitToken("+elemName+");";
                #line hidden
                
                __cb.Push("");
                #line (268,10)-(268,100) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(rr.Token.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (269,6)-(269,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first91)
                {
                    __first91 = false;
                }
                __cb.Push("");
                #line (270,9)-(270,20) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Visit(");
                #line hidden
                #line (270,21)-(270,29) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (270,30)-(270,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first91) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}