#line (1,10)-(1,53) 10 "CompilationGenerator.mxg"
namespace MetaDslx.Languages.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "CompilationGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "CompilationGenerator.mxg"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "CompilationGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "CompilationGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "CompilationGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "CompilationGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "CompilationGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "CompilationGenerator.mxg"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "CompilationGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (11,9)-(11,38) 22 "CompilationGenerator.mxg"
        public string GenerateCompilationFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (12,1)-(12,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,6)-(12,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,14) 25 "CompilationGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,29) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,42) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,1)-(15,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,6)-(15,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,7)-(15,37) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,1)-(17,10) 25 "CompilationGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (17,10)-(17,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,17) 25 "CompilationGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,1)-(19,10) 25 "CompilationGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (19,10)-(19,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,12)-(19,21) 24 "CompilationGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,1)-(20,2) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,11) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (21,11)-(21,12) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,12)-(21,17) 25 "CompilationGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (21,17)-(21,18) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,19)-(21,23) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (21,24)-(21,42) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationFactory");
            #line hidden
            #line (21,42)-(21,43) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,43)-(21,44) 25 "CompilationGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (21,44)-(21,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,45)-(21,63) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,6) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,5)-(24,6) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (25,1)-(25,2) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (29,9)-(29,31) 22 "CompilationGenerator.mxg"
        public string GenerateCompilation()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (30,1)-(30,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (30,6)-(30,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,7)-(30,14) 25 "CompilationGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (31,1)-(31,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (31,6)-(31,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,7)-(31,29) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (32,1)-(32,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (32,6)-(32,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,7)-(32,42) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,1)-(33,6) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (33,6)-(33,7) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,7)-(33,37) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (35,1)-(35,10) 25 "CompilationGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (35,10)-(35,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,11)-(35,17) 25 "CompilationGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (37,1)-(37,10) 25 "CompilationGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (37,10)-(37,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,12)-(37,21) 24 "CompilationGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (38,1)-(38,2) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (39,5)-(39,11) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (39,11)-(39,12) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,12)-(39,17) 25 "CompilationGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (39,17)-(39,18) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,19)-(39,23) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (39,24)-(39,35) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            #line (39,35)-(39,36) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,36)-(39,37) 25 "CompilationGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (39,37)-(39,38) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,38)-(39,49) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (40,5)-(40,6) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (41,9)-(41,18) 25 "CompilationGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (41,18)-(41,19) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,20)-(41,24) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (41,25)-(41,37) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (42,13)-(42,20) 25 "CompilationGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (42,20)-(42,21) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,21)-(42,34) 25 "CompilationGenerator.mxg"
            __cb.Write("assemblyName,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (43,13)-(43,31) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationOptions");
            #line hidden
            #line (43,31)-(43,32) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,32)-(43,40) 25 "CompilationGenerator.mxg"
            __cb.Write("options,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (44,13)-(44,46) 25 "CompilationGenerator.mxg"
            __cb.Write("ImmutableArray<MetadataReference>");
            #line hidden
            #line (44,46)-(44,47) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,47)-(44,58) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (45,13)-(45,35) 25 "CompilationGenerator.mxg"
            __cb.Write("ScriptCompilationInfo?");
            #line hidden
            #line (45,35)-(45,36) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,36)-(45,58) 25 "CompilationGenerator.mxg"
            __cb.Write("scriptCompilationInfo,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (46,13)-(46,30) 25 "CompilationGenerator.mxg"
            __cb.Write("ReferenceManager?");
            #line hidden
            #line (46,30)-(46,31) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,31)-(46,48) 25 "CompilationGenerator.mxg"
            __cb.Write("referenceManager,");
            #line hidden
            #line (46,48)-(46,49) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (47,13)-(47,17) 25 "CompilationGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (47,17)-(47,18) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,18)-(47,40) 25 "CompilationGenerator.mxg"
            __cb.Write("reuseReferenceManager,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (48,13)-(48,40) 25 "CompilationGenerator.mxg"
            __cb.Write("SyntaxAndDeclarationManager");
            #line hidden
            #line (48,40)-(48,41) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,41)-(48,63) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxAndDeclarations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (49,13)-(49,14) 25 "CompilationGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (49,14)-(49,15) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,15)-(49,33) 25 "CompilationGenerator.mxg"
            __cb.Write("base(assemblyName,");
            #line hidden
            #line (49,33)-(49,34) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,35)-(49,39) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (49,40)-(49,58) 25 "CompilationGenerator.mxg"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (49,58)-(49,59) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,59)-(49,67) 25 "CompilationGenerator.mxg"
            __cb.Write("options,");
            #line hidden
            #line (49,67)-(49,68) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,68)-(49,79) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            #line (49,79)-(49,80) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,80)-(49,102) 25 "CompilationGenerator.mxg"
            __cb.Write("scriptCompilationInfo,");
            #line hidden
            #line (49,102)-(49,103) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,103)-(49,120) 25 "CompilationGenerator.mxg"
            __cb.Write("referenceManager,");
            #line hidden
            #line (49,120)-(49,121) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,121)-(49,143) 25 "CompilationGenerator.mxg"
            __cb.Write("reuseReferenceManager,");
            #line hidden
            #line (49,143)-(49,144) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,144)-(49,166) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxAndDeclarations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,9)-(50,10) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,10) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (54,9)-(54,15) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (54,15)-(54,16) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,16)-(54,22) 25 "CompilationGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (54,22)-(54,23) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,23)-(54,26) 25 "CompilationGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (54,26)-(54,27) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,28)-(54,32) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (54,33)-(54,44) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            #line (54,44)-(54,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,45)-(54,52) 25 "CompilationGenerator.mxg"
            __cb.Write("Create(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (55,13)-(55,20) 25 "CompilationGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (55,20)-(55,21) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,21)-(55,33) 25 "CompilationGenerator.mxg"
            __cb.Write("assemblyName");
            #line hidden
            #line (55,33)-(55,34) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,34)-(55,35) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (55,35)-(55,36) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,36)-(55,41) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (55,41)-(55,42) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (56,13)-(56,37) 25 "CompilationGenerator.mxg"
            __cb.Write("IEnumerable<SyntaxTree>?");
            #line hidden
            #line (56,37)-(56,38) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,38)-(56,49) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTrees");
            #line hidden
            #line (56,49)-(56,50) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,50)-(56,51) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (56,51)-(56,52) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,52)-(56,57) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (56,57)-(56,58) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (57,13)-(57,44) 25 "CompilationGenerator.mxg"
            __cb.Write("IEnumerable<MetadataReference>?");
            #line hidden
            #line (57,44)-(57,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,45)-(57,55) 25 "CompilationGenerator.mxg"
            __cb.Write("references");
            #line hidden
            #line (57,55)-(57,56) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,56)-(57,57) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (57,57)-(57,58) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,58)-(57,63) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (57,63)-(57,64) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (58,13)-(58,32) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationOptions?");
            #line hidden
            #line (58,32)-(58,33) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,33)-(58,40) 25 "CompilationGenerator.mxg"
            __cb.Write("options");
            #line hidden
            #line (58,40)-(58,41) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,41)-(58,42) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (58,42)-(58,43) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,43)-(58,48) 25 "CompilationGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (59,9)-(59,10) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (60,13)-(60,19) 25 "CompilationGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (60,19)-(60,20) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,20)-(60,21) 25 "CompilationGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (60,22)-(60,26) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (60,27)-(60,71) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation)Compilation.Create(assemblyName,");
            #line hidden
            #line (60,71)-(60,72) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,73)-(60,77) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (60,78)-(60,96) 25 "CompilationGenerator.mxg"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (60,96)-(60,97) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,97)-(60,109) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTrees,");
            #line hidden
            #line (60,109)-(60,110) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,110)-(60,121) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            #line (60,121)-(60,122) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,122)-(60,131) 25 "CompilationGenerator.mxg"
            __cb.Write("options);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (61,9)-(61,10) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,9)-(63,15) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (63,15)-(63,16) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,16)-(63,22) 25 "CompilationGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (63,22)-(63,23) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,23)-(63,26) 25 "CompilationGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (63,26)-(63,27) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,28)-(63,32) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (63,33)-(63,44) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            #line (63,44)-(63,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,45)-(63,69) 25 "CompilationGenerator.mxg"
            __cb.Write("CreateScriptCompilation(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (64,13)-(64,19) 25 "CompilationGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (64,19)-(64,20) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,20)-(64,33) 25 "CompilationGenerator.mxg"
            __cb.Write("assemblyName,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (65,13)-(65,24) 25 "CompilationGenerator.mxg"
            __cb.Write("SyntaxTree?");
            #line hidden
            #line (65,24)-(65,25) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,25)-(65,35) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTree");
            #line hidden
            #line (65,35)-(65,36) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,36)-(65,37) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (65,37)-(65,38) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,38)-(65,43) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (66,13)-(66,44) 25 "CompilationGenerator.mxg"
            __cb.Write("IEnumerable<MetadataReference>?");
            #line hidden
            #line (66,44)-(66,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,45)-(66,55) 25 "CompilationGenerator.mxg"
            __cb.Write("references");
            #line hidden
            #line (66,55)-(66,56) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,56)-(66,57) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (66,57)-(66,58) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,58)-(66,63) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (67,13)-(67,32) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationOptions?");
            #line hidden
            #line (67,32)-(67,33) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,33)-(67,40) 25 "CompilationGenerator.mxg"
            __cb.Write("options");
            #line hidden
            #line (67,40)-(67,41) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,41)-(67,42) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,42)-(67,43) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,43)-(67,48) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (68,13)-(68,25) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (68,25)-(68,26) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,26)-(68,51) 25 "CompilationGenerator.mxg"
            __cb.Write("previousScriptCompilation");
            #line hidden
            #line (68,51)-(68,52) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,52)-(68,53) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (68,53)-(68,54) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,54)-(68,59) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (69,13)-(69,18) 25 "CompilationGenerator.mxg"
            __cb.Write("Type?");
            #line hidden
            #line (69,18)-(69,19) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,19)-(69,29) 25 "CompilationGenerator.mxg"
            __cb.Write("returnType");
            #line hidden
            #line (69,29)-(69,30) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,30)-(69,31) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (69,31)-(69,32) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,32)-(69,37) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (70,13)-(70,18) 25 "CompilationGenerator.mxg"
            __cb.Write("Type?");
            #line hidden
            #line (70,18)-(70,19) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,19)-(70,30) 25 "CompilationGenerator.mxg"
            __cb.Write("globalsType");
            #line hidden
            #line (70,30)-(70,31) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,31)-(70,32) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,32)-(70,33) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,33)-(70,38) 25 "CompilationGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (71,9)-(71,10) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (72,13)-(72,19) 25 "CompilationGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (72,19)-(72,20) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,20)-(72,21) 25 "CompilationGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (72,22)-(72,26) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (72,27)-(72,88) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation)Compilation.CreateScriptCompilation(assemblyName,");
            #line hidden
            #line (72,88)-(72,89) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,90)-(72,94) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (72,95)-(72,113) 25 "CompilationGenerator.mxg"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (72,113)-(72,114) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,114)-(72,125) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTree,");
            #line hidden
            #line (72,125)-(72,126) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,126)-(72,137) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            #line (72,137)-(72,138) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,138)-(72,146) 25 "CompilationGenerator.mxg"
            __cb.Write("options,");
            #line hidden
            #line (72,146)-(72,147) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,147)-(72,173) 25 "CompilationGenerator.mxg"
            __cb.Write("previousScriptCompilation,");
            #line hidden
            #line (72,173)-(72,174) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,174)-(72,185) 25 "CompilationGenerator.mxg"
            __cb.Write("returnType,");
            #line hidden
            #line (72,185)-(72,186) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,186)-(72,199) 25 "CompilationGenerator.mxg"
            __cb.Write("globalsType);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,9)-(73,10) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (74,5)-(74,6) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (75,1)-(75,2) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}