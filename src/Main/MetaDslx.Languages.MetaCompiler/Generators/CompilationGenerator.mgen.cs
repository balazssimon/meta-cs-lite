#line (1,10)-(1,53) 10 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
namespace MetaDslx.Languages.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (11,9)-(11,55) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
        public string GenerateCompilationFactory(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (12,1)-(12,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (12,6)-(12,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,1)-(15,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (15,6)-(15,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (15,7)-(15,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,1)-(17,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (17,10)-(17,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,1)-(19,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (19,10)-(19,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (19,12)-(19,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,1)-(20,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (21,11)-(21,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (21,12)-(21,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (21,17)-(21,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (21,19)-(21,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (21,33)-(21,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("CompilationFactory");
            #line hidden
            #line (21,51)-(21,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (21,52)-(21,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (21,53)-(21,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (21,54)-(21,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("CompilationFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,5)-(24,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (25,1)-(25,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (29,9)-(29,48) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
        public string GenerateCompilation(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (30,1)-(30,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (30,6)-(30,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (30,7)-(30,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (31,1)-(31,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (31,6)-(31,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (31,7)-(31,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (32,1)-(32,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (32,6)-(32,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (32,7)-(32,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,1)-(33,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (33,6)-(33,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (33,7)-(33,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (35,1)-(35,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (35,10)-(35,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (35,11)-(35,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (37,1)-(37,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (37,10)-(37,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (37,12)-(37,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (38,1)-(38,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (39,5)-(39,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (39,11)-(39,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (39,12)-(39,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (39,17)-(39,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (39,19)-(39,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (39,33)-(39,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation");
            #line hidden
            #line (39,44)-(39,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (39,45)-(39,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (39,46)-(39,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (39,47)-(39,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (40,5)-(40,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (41,9)-(41,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("protected");
            #line hidden
            #line (41,18)-(41,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (41,20)-(41,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (41,34)-(41,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (42,13)-(42,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("string?");
            #line hidden
            #line (42,20)-(42,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (42,21)-(42,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("assemblyName,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (43,13)-(43,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("CompilationOptions");
            #line hidden
            #line (43,31)-(43,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (43,32)-(43,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("options,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (44,13)-(44,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("ImmutableArray<MetadataReference>");
            #line hidden
            #line (44,46)-(44,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (44,47)-(44,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("references,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (45,13)-(45,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("ScriptCompilationInfo?");
            #line hidden
            #line (45,35)-(45,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (45,36)-(45,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("scriptCompilationInfo,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (46,13)-(46,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("ReferenceManager?");
            #line hidden
            #line (46,30)-(46,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (46,31)-(46,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("referenceManager,");
            #line hidden
            #line (46,48)-(46,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (47,13)-(47,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("bool");
            #line hidden
            #line (47,17)-(47,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (47,18)-(47,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("reuseReferenceManager,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (48,13)-(48,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("SyntaxAndDeclarationManager");
            #line hidden
            #line (48,40)-(48,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (48,41)-(48,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("syntaxAndDeclarations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (49,13)-(49,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (49,14)-(49,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,15)-(49,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("base(assemblyName,");
            #line hidden
            #line (49,33)-(49,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,35)-(49,48) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (49,49)-(49,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (49,67)-(49,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,68)-(49,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("options,");
            #line hidden
            #line (49,76)-(49,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,77)-(49,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("references,");
            #line hidden
            #line (49,88)-(49,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,89)-(49,111) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("scriptCompilationInfo,");
            #line hidden
            #line (49,111)-(49,112) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,112)-(49,129) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("referenceManager,");
            #line hidden
            #line (49,129)-(49,130) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,130)-(49,152) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("reuseReferenceManager,");
            #line hidden
            #line (49,152)-(49,153) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (49,153)-(49,175) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("syntaxAndDeclarations)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,9)-(50,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (54,9)-(54,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (54,15)-(54,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (54,16)-(54,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (54,22)-(54,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (54,23)-(54,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (54,26)-(54,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (54,28)-(54,41) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (54,42)-(54,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation");
            #line hidden
            #line (54,53)-(54,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (54,54)-(54,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Create(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (55,13)-(55,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("string?");
            #line hidden
            #line (55,20)-(55,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,21)-(55,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("assemblyName");
            #line hidden
            #line (55,33)-(55,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,34)-(55,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (55,35)-(55,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (55,36)-(55,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            #line (55,41)-(55,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (56,13)-(56,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("IEnumerable<SyntaxTree>?");
            #line hidden
            #line (56,37)-(56,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (56,38)-(56,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("syntaxTrees");
            #line hidden
            #line (56,49)-(56,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (56,50)-(56,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (56,51)-(56,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (56,52)-(56,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            #line (56,57)-(56,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (57,13)-(57,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("IEnumerable<MetadataReference>?");
            #line hidden
            #line (57,44)-(57,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (57,45)-(57,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("references");
            #line hidden
            #line (57,55)-(57,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (57,56)-(57,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (57,57)-(57,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (57,58)-(57,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            #line (57,63)-(57,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (58,13)-(58,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("CompilationOptions?");
            #line hidden
            #line (58,32)-(58,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (58,33)-(58,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("options");
            #line hidden
            #line (58,40)-(58,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (58,41)-(58,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (58,42)-(58,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (58,43)-(58,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (59,9)-(59,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (60,13)-(60,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (60,19)-(60,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (60,20)-(60,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (60,22)-(60,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (60,36)-(60,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation)Compilation.Create(assemblyName,");
            #line hidden
            #line (60,80)-(60,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (60,82)-(60,95) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (60,96)-(60,114) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (60,114)-(60,115) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (60,115)-(60,127) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("syntaxTrees,");
            #line hidden
            #line (60,127)-(60,128) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (60,128)-(60,139) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("references,");
            #line hidden
            #line (60,139)-(60,140) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (60,140)-(60,149) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("options);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (61,9)-(61,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,9)-(63,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (63,15)-(63,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,16)-(63,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (63,22)-(63,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,23)-(63,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (63,26)-(63,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,28)-(63,41) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (63,42)-(63,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation");
            #line hidden
            #line (63,53)-(63,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,54)-(63,78) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("CreateScriptCompilation(");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (64,13)-(64,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("string");
            #line hidden
            #line (64,19)-(64,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,20)-(64,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("assemblyName,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (65,13)-(65,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("SyntaxTree?");
            #line hidden
            #line (65,24)-(65,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (65,25)-(65,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("syntaxTree");
            #line hidden
            #line (65,35)-(65,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (65,36)-(65,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (65,37)-(65,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (65,38)-(65,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (66,13)-(66,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("IEnumerable<MetadataReference>?");
            #line hidden
            #line (66,44)-(66,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,45)-(66,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("references");
            #line hidden
            #line (66,55)-(66,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,56)-(66,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (66,57)-(66,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,58)-(66,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (67,13)-(67,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("CompilationOptions?");
            #line hidden
            #line (67,32)-(67,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (67,33)-(67,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("options");
            #line hidden
            #line (67,40)-(67,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (67,41)-(67,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (67,42)-(67,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (67,43)-(67,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (68,13)-(68,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation?");
            #line hidden
            #line (68,25)-(68,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (68,26)-(68,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("previousScriptCompilation");
            #line hidden
            #line (68,51)-(68,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (68,52)-(68,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (68,53)-(68,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (68,54)-(68,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (69,13)-(69,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Type?");
            #line hidden
            #line (69,18)-(69,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,19)-(69,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("returnType");
            #line hidden
            #line (69,29)-(69,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,30)-(69,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (69,31)-(69,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (69,32)-(69,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (70,13)-(70,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Type?");
            #line hidden
            #line (70,18)-(70,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (70,19)-(70,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("globalsType");
            #line hidden
            #line (70,30)-(70,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (70,31)-(70,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (70,32)-(70,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (70,33)-(70,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (71,9)-(71,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (72,13)-(72,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (72,19)-(72,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,20)-(72,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (72,22)-(72,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (72,36)-(72,97) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Compilation)Compilation.CreateScriptCompilation(assemblyName,");
            #line hidden
            #line (72,97)-(72,98) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,99)-(72,112) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (72,113)-(72,131) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("Language.Instance,");
            #line hidden
            #line (72,131)-(72,132) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,132)-(72,143) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("syntaxTree,");
            #line hidden
            #line (72,143)-(72,144) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,144)-(72,155) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("references,");
            #line hidden
            #line (72,155)-(72,156) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,156)-(72,164) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("options,");
            #line hidden
            #line (72,164)-(72,165) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,165)-(72,191) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("previousScriptCompilation,");
            #line hidden
            #line (72,191)-(72,192) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,192)-(72,203) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("returnType,");
            #line hidden
            #line (72,203)-(72,204) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,204)-(72,217) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("globalsType);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,9)-(73,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (74,5)-(74,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (75,1)-(75,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\CompilationGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}