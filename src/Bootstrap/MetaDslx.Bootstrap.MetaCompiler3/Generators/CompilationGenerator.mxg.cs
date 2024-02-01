#line (1,10)-(1,54) 10 "CompilationGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler3.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "CompilationGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,45) 13 "CompilationGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler3.Model;
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
            #line (12,5)-(12,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,10)-(12,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,11)-(12,18) 25 "CompilationGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,5)-(13,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,10)-(13,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,11)-(13,33) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,5)-(14,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,10)-(14,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,11)-(14,46) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,5)-(15,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,10)-(15,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,11)-(15,41) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,5)-(17,14) 25 "CompilationGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (17,14)-(17,15) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,15)-(17,21) 25 "CompilationGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,5)-(19,14) 25 "CompilationGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (19,14)-(19,15) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,16)-(19,25) 24 "CompilationGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,5)-(20,6) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,9)-(21,15) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (21,15)-(21,16) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,16)-(21,21) 25 "CompilationGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (21,21)-(21,22) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,23)-(21,27) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (21,28)-(21,46) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationFactory");
            #line hidden
            #line (21,46)-(21,47) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,47)-(21,48) 25 "CompilationGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (21,48)-(21,49) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,49)-(21,67) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,9)-(22,10) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,9)-(24,10) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (25,5)-(25,6) 25 "CompilationGenerator.mxg"
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
            #line (30,5)-(30,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (30,10)-(30,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,11)-(30,18) 25 "CompilationGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (31,5)-(31,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (31,10)-(31,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,11)-(31,33) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (32,5)-(32,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (32,10)-(32,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,11)-(32,46) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,5)-(33,10) 25 "CompilationGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (33,10)-(33,11) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,11)-(33,41) 25 "CompilationGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (35,5)-(35,14) 25 "CompilationGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (35,14)-(35,15) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,15)-(35,21) 25 "CompilationGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (37,5)-(37,14) 25 "CompilationGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (37,14)-(37,15) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,16)-(37,25) 24 "CompilationGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (38,5)-(38,6) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (39,9)-(39,15) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (39,15)-(39,16) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,16)-(39,21) 25 "CompilationGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (39,21)-(39,22) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,23)-(39,27) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (39,28)-(39,39) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            #line (39,39)-(39,40) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,40)-(39,41) 25 "CompilationGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (39,41)-(39,42) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,42)-(39,53) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (40,9)-(40,10) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (41,13)-(41,22) 25 "CompilationGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (41,22)-(41,23) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,24)-(41,28) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (41,29)-(41,41) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (42,17)-(42,24) 25 "CompilationGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (42,24)-(42,25) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,25)-(42,38) 25 "CompilationGenerator.mxg"
            __cb.Write("assemblyName,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (43,17)-(43,35) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationOptions");
            #line hidden
            #line (43,35)-(43,36) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,36)-(43,44) 25 "CompilationGenerator.mxg"
            __cb.Write("options,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (44,17)-(44,50) 25 "CompilationGenerator.mxg"
            __cb.Write("ImmutableArray<MetadataReference>");
            #line hidden
            #line (44,50)-(44,51) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,51)-(44,62) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (45,17)-(45,39) 25 "CompilationGenerator.mxg"
            __cb.Write("ScriptCompilationInfo?");
            #line hidden
            #line (45,39)-(45,40) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,40)-(45,62) 25 "CompilationGenerator.mxg"
            __cb.Write("scriptCompilationInfo,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (46,17)-(46,34) 25 "CompilationGenerator.mxg"
            __cb.Write("ReferenceManager?");
            #line hidden
            #line (46,34)-(46,35) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,35)-(46,52) 25 "CompilationGenerator.mxg"
            __cb.Write("referenceManager,");
            #line hidden
            #line (46,52)-(46,53) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (47,17)-(47,21) 25 "CompilationGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (47,21)-(47,22) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,22)-(47,44) 25 "CompilationGenerator.mxg"
            __cb.Write("reuseReferenceManager,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (48,17)-(48,44) 25 "CompilationGenerator.mxg"
            __cb.Write("SyntaxAndDeclarationManager");
            #line hidden
            #line (48,44)-(48,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,45)-(48,67) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxAndDeclarations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (49,17)-(49,18) 25 "CompilationGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (49,18)-(49,19) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,19)-(49,37) 25 "CompilationGenerator.mxg"
            __cb.Write("base(assemblyName,");
            #line hidden
            #line (49,37)-(49,38) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,39)-(49,43) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (49,44)-(49,62) 25 "CompilationGenerator.mxg"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (49,62)-(49,63) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,63)-(49,71) 25 "CompilationGenerator.mxg"
            __cb.Write("options,");
            #line hidden
            #line (49,71)-(49,72) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,72)-(49,83) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            #line (49,83)-(49,84) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,84)-(49,106) 25 "CompilationGenerator.mxg"
            __cb.Write("scriptCompilationInfo,");
            #line hidden
            #line (49,106)-(49,107) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,107)-(49,124) 25 "CompilationGenerator.mxg"
            __cb.Write("referenceManager,");
            #line hidden
            #line (49,124)-(49,125) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,125)-(49,147) 25 "CompilationGenerator.mxg"
            __cb.Write("reuseReferenceManager,");
            #line hidden
            #line (49,147)-(49,148) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,148)-(49,170) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxAndDeclarations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,13)-(50,14) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,13)-(52,14) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (54,13)-(54,19) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (54,19)-(54,20) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,20)-(54,26) 25 "CompilationGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (54,26)-(54,27) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,27)-(54,30) 25 "CompilationGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (54,30)-(54,31) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,32)-(54,36) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (54,37)-(54,48) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            #line (54,48)-(54,49) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,49)-(54,56) 25 "CompilationGenerator.mxg"
            __cb.Write("Create(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (55,17)-(55,24) 25 "CompilationGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (55,24)-(55,25) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,25)-(55,37) 25 "CompilationGenerator.mxg"
            __cb.Write("assemblyName");
            #line hidden
            #line (55,37)-(55,38) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,38)-(55,39) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (55,39)-(55,40) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,40)-(55,45) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (55,45)-(55,46) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (56,17)-(56,41) 25 "CompilationGenerator.mxg"
            __cb.Write("IEnumerable<SyntaxTree>?");
            #line hidden
            #line (56,41)-(56,42) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,42)-(56,53) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTrees");
            #line hidden
            #line (56,53)-(56,54) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,54)-(56,55) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (56,55)-(56,56) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,56)-(56,61) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (56,61)-(56,62) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (57,17)-(57,48) 25 "CompilationGenerator.mxg"
            __cb.Write("IEnumerable<MetadataReference>?");
            #line hidden
            #line (57,48)-(57,49) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,49)-(57,59) 25 "CompilationGenerator.mxg"
            __cb.Write("references");
            #line hidden
            #line (57,59)-(57,60) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,60)-(57,61) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (57,61)-(57,62) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,62)-(57,67) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (57,67)-(57,68) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (58,17)-(58,36) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationOptions?");
            #line hidden
            #line (58,36)-(58,37) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,37)-(58,44) 25 "CompilationGenerator.mxg"
            __cb.Write("options");
            #line hidden
            #line (58,44)-(58,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,45)-(58,46) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (58,46)-(58,47) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,47)-(58,52) 25 "CompilationGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (59,13)-(59,14) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (60,17)-(60,23) 25 "CompilationGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (60,23)-(60,24) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,24)-(60,25) 25 "CompilationGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (60,26)-(60,30) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (60,31)-(60,75) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation)Compilation.Create(assemblyName,");
            #line hidden
            #line (60,75)-(60,76) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,77)-(60,81) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (60,82)-(60,100) 25 "CompilationGenerator.mxg"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (60,100)-(60,101) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,101)-(60,113) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTrees,");
            #line hidden
            #line (60,113)-(60,114) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,114)-(60,125) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            #line (60,125)-(60,126) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,126)-(60,135) 25 "CompilationGenerator.mxg"
            __cb.Write("options);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (61,13)-(61,14) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,13)-(63,19) 25 "CompilationGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (63,19)-(63,20) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,20)-(63,26) 25 "CompilationGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (63,26)-(63,27) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,27)-(63,30) 25 "CompilationGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (63,30)-(63,31) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,32)-(63,36) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (63,37)-(63,48) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation");
            #line hidden
            #line (63,48)-(63,49) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,49)-(63,73) 25 "CompilationGenerator.mxg"
            __cb.Write("CreateScriptCompilation(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (64,17)-(64,23) 25 "CompilationGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (64,23)-(64,24) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,24)-(64,37) 25 "CompilationGenerator.mxg"
            __cb.Write("assemblyName,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (65,17)-(65,28) 25 "CompilationGenerator.mxg"
            __cb.Write("SyntaxTree?");
            #line hidden
            #line (65,28)-(65,29) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,29)-(65,39) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTree");
            #line hidden
            #line (65,39)-(65,40) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,40)-(65,41) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (65,41)-(65,42) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,42)-(65,47) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (66,17)-(66,48) 25 "CompilationGenerator.mxg"
            __cb.Write("IEnumerable<MetadataReference>?");
            #line hidden
            #line (66,48)-(66,49) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,49)-(66,59) 25 "CompilationGenerator.mxg"
            __cb.Write("references");
            #line hidden
            #line (66,59)-(66,60) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,60)-(66,61) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (66,61)-(66,62) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,62)-(66,67) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (67,17)-(67,36) 25 "CompilationGenerator.mxg"
            __cb.Write("CompilationOptions?");
            #line hidden
            #line (67,36)-(67,37) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,37)-(67,44) 25 "CompilationGenerator.mxg"
            __cb.Write("options");
            #line hidden
            #line (67,44)-(67,45) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,45)-(67,46) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,46)-(67,47) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,47)-(67,52) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (68,17)-(68,29) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation?");
            #line hidden
            #line (68,29)-(68,30) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,30)-(68,55) 25 "CompilationGenerator.mxg"
            __cb.Write("previousScriptCompilation");
            #line hidden
            #line (68,55)-(68,56) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,56)-(68,57) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (68,57)-(68,58) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,58)-(68,63) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (69,17)-(69,22) 25 "CompilationGenerator.mxg"
            __cb.Write("Type?");
            #line hidden
            #line (69,22)-(69,23) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,23)-(69,33) 25 "CompilationGenerator.mxg"
            __cb.Write("returnType");
            #line hidden
            #line (69,33)-(69,34) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,34)-(69,35) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (69,35)-(69,36) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,36)-(69,41) 25 "CompilationGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (70,17)-(70,22) 25 "CompilationGenerator.mxg"
            __cb.Write("Type?");
            #line hidden
            #line (70,22)-(70,23) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,23)-(70,34) 25 "CompilationGenerator.mxg"
            __cb.Write("globalsType");
            #line hidden
            #line (70,34)-(70,35) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,35)-(70,36) 25 "CompilationGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,36)-(70,37) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,37)-(70,42) 25 "CompilationGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (71,13)-(71,14) 25 "CompilationGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (72,17)-(72,23) 25 "CompilationGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (72,23)-(72,24) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,24)-(72,25) 25 "CompilationGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (72,26)-(72,30) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (72,31)-(72,92) 25 "CompilationGenerator.mxg"
            __cb.Write("Compilation)Compilation.CreateScriptCompilation(assemblyName,");
            #line hidden
            #line (72,92)-(72,93) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,94)-(72,98) 24 "CompilationGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (72,99)-(72,117) 25 "CompilationGenerator.mxg"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (72,117)-(72,118) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,118)-(72,129) 25 "CompilationGenerator.mxg"
            __cb.Write("syntaxTree,");
            #line hidden
            #line (72,129)-(72,130) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,130)-(72,141) 25 "CompilationGenerator.mxg"
            __cb.Write("references,");
            #line hidden
            #line (72,141)-(72,142) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,142)-(72,150) 25 "CompilationGenerator.mxg"
            __cb.Write("options,");
            #line hidden
            #line (72,150)-(72,151) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,151)-(72,177) 25 "CompilationGenerator.mxg"
            __cb.Write("previousScriptCompilation,");
            #line hidden
            #line (72,177)-(72,178) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,178)-(72,189) 25 "CompilationGenerator.mxg"
            __cb.Write("returnType,");
            #line hidden
            #line (72,189)-(72,190) 25 "CompilationGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,190)-(72,203) 25 "CompilationGenerator.mxg"
            __cb.Write("globalsType);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,13)-(73,14) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (74,9)-(74,10) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (75,5)-(75,6) 25 "CompilationGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}