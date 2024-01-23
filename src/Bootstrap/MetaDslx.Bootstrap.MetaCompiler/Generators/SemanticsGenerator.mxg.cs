#line (1,10)-(1,53) 10 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (11,9)-(11,36) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateSemanticsFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (12,1)-(12,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,6)-(12,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (15,1)-(15,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,6)-(15,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,7)-(15,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (17,1)-(17,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (17,10)-(17,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,1)-(19,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (19,10)-(19,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,12)-(19,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (20,1)-(20,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (21,11)-(21,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,12)-(21,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (21,17)-(21,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,19)-(21,23) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (21,24)-(21,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            #line (21,40)-(21,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,41)-(21,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (21,42)-(21,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,43)-(21,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (23,9)-(23,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (23,15)-(23,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,17)-(23,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (23,22)-(23,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("SemanticsFactory(Compilation");
            #line hidden
            #line (23,50)-(23,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,51)-(23,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (23,63)-(23,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,64)-(23,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("Language");
            #line hidden
            #line (23,72)-(23,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,73)-(23,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            #line (23,82)-(23,83) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (24,13)-(24,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (24,14)-(24,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,15)-(24,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("base(compilation,");
            #line hidden
            #line (24,32)-(24,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,33)-(24,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("language)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,9)-(25,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,9)-(26,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,9)-(28,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (28,15)-(28,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,16)-(28,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (28,24)-(28,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,25)-(28,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (28,45)-(28,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,46)-(28,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("CreateBinderFactoryVisitor(BinderFactory");
            #line hidden
            #line (28,86)-(28,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,87)-(28,101) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,9)-(29,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (30,13)-(30,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (30,19)-(30,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,20)-(30,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (30,23)-(30,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,24)-(30,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (30,33)-(30,42) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (30,43)-(30,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(".Binding.");
            #line hidden
            #line (30,53)-(30,57) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (30,58)-(30,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(binderFactory);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (31,9)-(31,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,5)-(32,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (33,1)-(33,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (37,9)-(37,40) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitor()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (38,1)-(38,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (38,6)-(38,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,7)-(38,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,1)-(39,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,6)-(39,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,7)-(39,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (40,1)-(40,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (40,6)-(40,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,7)-(40,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (42,1)-(42,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (42,10)-(42,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,11)-(42,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,1)-(44,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (44,10)-(44,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,12)-(44,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (44,22)-(44,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(".Binding");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,1)-(45,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (46,5)-(46,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (46,10)-(46,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,11)-(46,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (46,20)-(46,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (46,30)-(46,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,5)-(48,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (48,11)-(48,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,12)-(48,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (48,17)-(48,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,19)-(48,23) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (48,24)-(48,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (48,44)-(48,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,45)-(48,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (48,46)-(48,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,47)-(48,98) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor,");
            #line hidden
            #line (48,98)-(48,99) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,99)-(48,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (48,101)-(48,105) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (48,106)-(48,119) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("SyntaxVisitor");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,5)-(49,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (50,9)-(50,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (50,17)-(50,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,19)-(50,23) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (50,24)-(50,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory");
            #line hidden
            #line (50,88)-(50,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,89)-(50,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (51,13)-(51,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (51,14)-(51,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,15)-(51,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("base(binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (53,9)-(53,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first154 = true;
            #line (55,4)-(55,31) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first154)
                {
                    __first154 = false;
                }
                var __first155 = true;
                #line (56,5)-(56,43) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first155)
                    {
                        __first155 = false;
                    }
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (58,10)-(58,47) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisit(rule, alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first155) __cb.AppendLine();
            }
            if (!__first154) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (62,3)-(62,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (62,9)-(62,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,10)-(62,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (62,17)-(62,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,18)-(62,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (62,22)-(62,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,23)-(62,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("VisitSkippedTokensTrivia(");
            #line hidden
            #line (62,49)-(62,53) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (62,54)-(62,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("SkippedTokensTriviaSyntax");
            #line hidden
            #line (62,79)-(62,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,80)-(62,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (63,3)-(63,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (64,3)-(64,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (65,5)-(65,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (66,1)-(66,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (69,9)-(69,64) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisit(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (70,1)-(70,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (70,7)-(70,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,8)-(70,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (70,15)-(70,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,16)-(70,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (70,20)-(70,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,21)-(70,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("Visit");
            #line hidden
            #line (70,27)-(70,41) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (70,42)-(70,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (70,44)-(70,55) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(alt.RedName);
            #line hidden
            #line (70,56)-(70,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,57)-(70,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (71,1)-(71,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first156 = true;
            #line (72,6)-(72,35) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            if (rule == Grammar.MainRule)
            #line hidden
            
            {
                if (__first156)
                {
                    __first156 = false;
                }
                __cb.Push("    ");
                #line (73,5)-(73,7) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (73,7)-(73,8) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (73,8)-(73,21) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("(this.IsRoot)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (74,5)-(74,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first157 = true;
                #line (75,10)-(75,47) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                if (Grammar.RootTypeName is not null)
                #line hidden
                
                {
                    if (__first157)
                    {
                        __first157 = false;
                    }
                    __cb.Push("        ");
                    #line (76,9)-(76,12) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (76,12)-(76,13) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (76,13)-(76,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__rootAnnot");
                    #line hidden
                    #line (76,24)-(76,25) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (76,25)-(76,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (76,26)-(76,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (76,27)-(76,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (76,30)-(76,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (76,31)-(76,96) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree,");
                    #line hidden
                    #line (76,96)-(76,97) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (76,97)-(76,102) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("type:");
                    #line hidden
                    #line (76,102)-(76,103) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (76,103)-(76,110) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("typeof(");
                    #line hidden
                    #line (76,111)-(76,131) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(Grammar.RootTypeName);
                    #line hidden
                    #line (76,132)-(76,135) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("));");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (77,10)-(77,14) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first157)
                    {
                        __first157 = false;
                    }
                    __cb.Push("        ");
                    #line (78,9)-(78,12) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (78,12)-(78,13) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,13)-(78,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__rootAnnot");
                    #line hidden
                    #line (78,24)-(78,25) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,25)-(78,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (78,26)-(78,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,27)-(78,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (78,30)-(78,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,31)-(78,96) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree,");
                    #line hidden
                    #line (78,96)-(78,97) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,97)-(78,102) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("type:");
                    #line hidden
                    #line (78,102)-(78,103) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,103)-(78,109) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("null);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first157) __cb.AppendLine();
                __cb.Push("        ");
                #line (80,9)-(80,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("this.Begin(__rootAnnot,");
                #line hidden
                #line (80,32)-(80,33) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (80,33)-(80,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("node);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (81,9)-(81,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("try");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (82,9)-(82,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (83,14)-(83,55) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (84,9)-(84,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (85,9)-(85,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("finally");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (86,9)-(86,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (87,13)-(87,35) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("this.End(__rootAnnot);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (88,9)-(88,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (89,5)-(89,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (90,5)-(90,9) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (91,5)-(91,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    \t");
                #line (92,7)-(92,48) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (93,5)-(93,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (94,6)-(94,10) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first156)
                {
                    __first156 = false;
                }
                __cb.Push("\t");
                #line (95,3)-(95,44) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBody(rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first156) __cb.AppendLine();
            __cb.Push("");
            #line (97,1)-(97,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (100,9)-(100,68) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBody(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (101,2)-(101,20) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var annotIndex = 0;
            #line hidden
            
            #line (102,2)-(102,68) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitElements(alt, ref annotIndex);
            #line hidden
            
            #line (103,2)-(103,92) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(alt.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            #line (104,2)-(104,93) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(rule.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (105,2)-(105,6) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (108,9)-(108,81) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElements(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first158 = true;
            #line (109,2)-(109,66) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first158)
                {
                    __first158 = false;
                }
                __cb.Push("");
                #line (110,2)-(110,62) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElement(alt, elem, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (111,14)-(111,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("    ");
            #line hidden
            return __cb.ToStringAndFree();
        }
        
        #line (114,9)-(114,136) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinders(IEnumerable<Binder> binders, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first159 = true;
            #line (115,2)-(115,78) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            foreach (var binder in binders.Where(b => b.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first159)
                {
                    __first159 = false;
                }
                #line (116,2)-(116,81) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinder(binder, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first159) __cb.AppendLine();
            __cb.Push("");
            #line (118,2)-(118,6) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (121,9)-(121,107) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinder(Binder binder, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (122,2)-(122,46) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var binderVarName = "__annot"+(annotIndex++);
            #line hidden
            
            __cb.Push("");
            #line (123,1)-(123,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (123,4)-(123,5) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,6)-(123,19) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (123,20)-(123,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,21)-(123,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (123,22)-(123,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,23)-(123,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (123,26)-(123,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,28)-(123,43) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(binder.TypeName);
            #line hidden
            #line (123,44)-(123,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (123,46)-(123,73) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(binder.ConstructorArguments);
            #line hidden
            #line (123,74)-(123,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (124,1)-(124,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("this.Begin(");
            #line hidden
            #line (124,13)-(124,26) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (124,27)-(124,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (124,28)-(124,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,30)-(124,38) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(nodeName);
            #line hidden
            #line (124,39)-(124,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (125,1)-(125,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("try");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (126,1)-(126,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (127,6)-(127,10) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (128,1)-(128,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (129,1)-(129,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("finally");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (130,1)-(130,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (131,5)-(131,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("this.End(");
            #line hidden
            #line (131,15)-(131,28) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (131,29)-(131,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (132,1)-(132,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (135,9)-(135,94) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElement(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (136,6)-(136,105) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var isList = MetaDslx.Bootstrap.MetaCompiler.Model.MultiplicityExtensions.IsList(elem.Multiplicity);
            #line hidden
            
            #line (137,6)-(137,113) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var isOptional = MetaDslx.Bootstrap.MetaCompiler.Model.MultiplicityExtensions.IsOptional(elem.Multiplicity);
            #line hidden
            
            var __first160 = true;
            #line (138,6)-(138,17) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            if (isList)
            #line hidden
            
            {
                if (__first160)
                {
                    __first160 = false;
                }
                #line (139,10)-(139,58) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (140,2)-(140,78) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitListElements(alt, elem, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (141,2)-(141,88) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (142,6)-(142,46) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            else if (elem.Value is SeparatedList sl)
            #line hidden
            
            {
                if (__first160)
                {
                    __first160 = false;
                }
                #line (143,10)-(143,58) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (144,2)-(144,91) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitSeparatedListElements(alt, elem, sl, ref annotIndex);
                #line hidden
                
                #line (145,2)-(145,93) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(sl.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (146,2)-(146,88) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (147,6)-(147,26) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            else if (isOptional)
            #line hidden
            
            {
                if (__first160)
                {
                    __first160 = false;
                }
                #line (148,10)-(148,50) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (149,1)-(149,3) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (149,3)-(149,4) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (149,4)-(149,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (149,6)-(149,14) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                var __first161 = true;
                #line (149,16)-(149,33) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first161)
                    {
                        __first161 = false;
                    }
                    #line (149,34)-(149,38) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(".Get");
                    #line hidden
                    #line (149,39)-(149,43) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (149,44)-(149,50) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("Kind()");
                    #line hidden
                    #line (149,50)-(149,51) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,51)-(149,53) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (149,53)-(149,54) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,55)-(149,59) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (149,60)-(149,75) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("SyntaxKind.None");
                    #line hidden
                }
                #line (149,76)-(149,80) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first161)
                    {
                        __first161 = false;
                    }
                    #line (149,81)-(149,82) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,82)-(149,84) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (149,84)-(149,85) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,85)-(149,89) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                }
                #line (149,97)-(149,98) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (150,1)-(150,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (151,6)-(151,94) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (152,1)-(152,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (153,6)-(153,10) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first160)
                {
                    __first160 = false;
                }
                #line (154,10)-(154,50) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (155,2)-(155,90) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first160) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (159,9)-(159,99) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitListElements(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (160,1)-(160,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (160,4)-(160,5) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,6)-(160,24) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (160,25)-(160,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (160,29)-(160,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,30)-(160,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (160,31)-(160,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,32)-(160,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (160,38)-(160,55) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (160,56)-(160,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (161,2)-(161,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (162,1)-(162,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (162,4)-(162,5) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,5)-(162,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (162,9)-(162,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,11)-(162,20) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (162,21)-(162,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,22)-(162,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (162,23)-(162,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,24)-(162,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (162,26)-(162,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,28)-(162,37) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (162,38)-(162,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,39)-(162,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (162,40)-(162,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,42)-(162,60) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (162,61)-(162,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (162,72)-(162,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,73)-(162,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (162,76)-(162,85) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (162,86)-(162,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (163,1)-(163,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (164,6)-(164,64) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var elemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            __cb.Push("    ");
            #line (165,6)-(165,95) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (166,1)-(166,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (169,9)-(169,128) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListElements(Alternative alt, Element elem, SeparatedList list, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (170,1)-(170,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (170,4)-(170,5) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,6)-(170,24) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (170,25)-(170,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (170,29)-(170,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,30)-(170,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (170,31)-(170,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,32)-(170,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (170,38)-(170,55) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (170,56)-(170,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (171,2)-(171,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (172,1)-(172,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (172,4)-(172,5) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,5)-(172,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (172,9)-(172,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,11)-(172,20) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (172,21)-(172,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,22)-(172,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (172,23)-(172,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,24)-(172,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (172,26)-(172,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,28)-(172,37) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (172,38)-(172,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,39)-(172,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (172,40)-(172,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,42)-(172,60) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (172,61)-(172,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (172,72)-(172,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,73)-(172,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (172,76)-(172,85) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (172,86)-(172,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (173,1)-(173,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (174,5)-(174,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (174,9)-(174,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,10)-(174,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("__itemHandled");
            #line hidden
            #line (174,23)-(174,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,24)-(174,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (174,25)-(174,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,26)-(174,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (175,5)-(175,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (175,9)-(175,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,10)-(175,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("__sepHandled");
            #line hidden
            #line (175,22)-(175,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,23)-(175,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (175,24)-(175,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (175,25)-(175,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (176,6)-(176,64) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var itemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            #line (177,6)-(177,76) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var sepName = "node."+elem.PropertyName+".GetSeparator("+indexName+")";
            #line hidden
            
            #line (178,6)-(178,82) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var firstCount = Math.Max(list.FirstItems.Count, list.FirstSeparators.Count);
            #line hidden
            
            #line (179,6)-(179,79) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var lastCount = Math.Min(list.LastItems.Count, list.LastSeparators.Count);
            #line hidden
            
            #line (180,6)-(180,21) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var ifElse = "";
            #line hidden
            
            var __first162 = true;
            #line (181,6)-(181,46) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            for (int i = 0; i < firstCount - 1; ++i)
            #line hidden
            
            {
                if (__first162)
                {
                    __first162 = false;
                }
                __cb.Push("    ");
                #line (182,6)-(182,12) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (182,13)-(182,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (182,15)-(182,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (182,16)-(182,17) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (182,18)-(182,27) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (182,28)-(182,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (182,29)-(182,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (182,31)-(182,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (182,33)-(182,34) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(i);
                #line hidden
                #line (182,35)-(182,36) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (183,5)-(183,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (184,10)-(184,154) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.FirstItems[i], sepName, list.FirstSeparators[i], list.SeparatorFirst, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (185,9)-(185,22) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("__itemHandled");
                #line hidden
                #line (185,22)-(185,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (185,23)-(185,24) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (185,24)-(185,25) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (185,25)-(185,30) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (186,9)-(186,21) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("__sepHandled");
                #line hidden
                #line (186,21)-(186,22) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,22)-(186,23) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (186,23)-(186,24) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (186,24)-(186,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (187,5)-(187,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (188,10)-(188,25) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first162) __cb.AppendLine();
            var __first163 = true;
            #line (190,6)-(190,25) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            if (firstCount > 0)
            #line hidden
            
            {
                if (__first163)
                {
                    __first163 = false;
                }
                __cb.Push("    ");
                #line (191,6)-(191,12) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (191,13)-(191,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (191,15)-(191,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,16)-(191,17) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (191,18)-(191,27) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (191,28)-(191,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,29)-(191,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (191,31)-(191,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (191,33)-(191,45) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(firstCount-1);
                #line hidden
                #line (191,46)-(191,47) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (192,5)-(192,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first164 = true;
                #line (193,10)-(193,34) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                if (list.SeparatorFirst)
                #line hidden
                
                {
                    if (__first164)
                    {
                        __first164 = false;
                    }
                    __cb.Push("        ");
                    #line (194,10)-(194,157) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.FirstSeparators[firstCount-1], list.FirstSeparators[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (195,9)-(195,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (195,21)-(195,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (195,22)-(195,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (195,23)-(195,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (195,24)-(195,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (196,10)-(196,14) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first164)
                    {
                        __first164 = false;
                    }
                    __cb.Push("        ");
                    #line (197,10)-(197,148) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.FirstItems[firstCount-1], list.FirstItems[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (198,9)-(198,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (198,22)-(198,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,23)-(198,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (198,24)-(198,25) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,25)-(198,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first164) __cb.AppendLine();
                __cb.Push("    ");
                #line (200,5)-(200,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (201,10)-(201,25) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first163) __cb.AppendLine();
            var __first165 = true;
            #line (203,6)-(203,41) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            for (int i = 0; i < lastCount; ++i)
            #line hidden
            
            {
                if (__first165)
                {
                    __first165 = false;
                }
                __cb.Push("    ");
                #line (204,6)-(204,12) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (204,13)-(204,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (204,15)-(204,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,16)-(204,17) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (204,18)-(204,27) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (204,28)-(204,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,29)-(204,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (204,31)-(204,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,33)-(204,51) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (204,52)-(204,62) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("List.Count");
                #line hidden
                #line (204,62)-(204,63) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,63)-(204,64) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("-");
                #line hidden
                #line (204,64)-(204,65) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,66)-(204,79) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(lastCount - i);
                #line hidden
                #line (204,80)-(204,81) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (205,5)-(205,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (206,10)-(206,35) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var j = lastCount - 1 - i;
                #line hidden
                
                var __first166 = true;
                #line (207,10)-(207,72) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                if (j < list.LastItems.Count && j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first166)
                    {
                        __first166 = false;
                    }
                    __cb.Push("        ");
                    #line (208,10)-(208,160) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.LastItems[j], sepName, list.LastSeparators[j], list.RepeatedSeparatorFirst, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (209,9)-(209,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (209,22)-(209,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (209,23)-(209,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (209,24)-(209,25) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (209,25)-(209,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (210,9)-(210,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (210,21)-(210,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (210,22)-(210,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (210,23)-(210,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (210,24)-(210,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (211,10)-(211,44) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                else if (j < list.LastItems.Count)
                #line hidden
                
                {
                    if (__first166)
                    {
                        __first166 = false;
                    }
                    __cb.Push("        ");
                    #line (212,10)-(212,124) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.LastItems[j], list.LastItems[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (213,9)-(213,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (213,22)-(213,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (213,23)-(213,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (213,24)-(213,25) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (213,25)-(213,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (214,10)-(214,49) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                else if (j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first166)
                    {
                        __first166 = false;
                    }
                    __cb.Push("        ");
                    #line (215,10)-(215,133) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.LastSeparators[j], list.LastSeparators[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (216,9)-(216,21) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (216,21)-(216,22) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,22)-(216,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (216,23)-(216,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,24)-(216,29) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (217,10)-(217,14) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first166)
                    {
                        __first166 = false;
                    }
                    __cb.Push("        ");
                    #line (218,9)-(218,17) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("INTERNAL");
                    #line hidden
                    #line (218,17)-(218,18) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (218,18)-(218,23) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    __cb.Write("ERROR");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first166) __cb.AppendLine();
                __cb.Push("    ");
                #line (220,5)-(220,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (221,10)-(221,25) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                ifElse = "else";
                #line hidden
                
            }
            if (!__first165) __cb.AppendLine();
            __cb.Push("    ");
            #line (223,5)-(223,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (223,7)-(223,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,8)-(223,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("(!__itemHandled");
            #line hidden
            #line (223,23)-(223,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,24)-(223,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (223,26)-(223,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,28)-(223,37) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (223,38)-(223,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,39)-(223,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (223,40)-(223,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,41)-(223,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (223,47)-(223,64) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (223,65)-(223,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(".Count)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (224,5)-(224,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (225,10)-(225,142) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var repItemBody = GenerateBinderFactoryVisitElementValue(itemName, list.RepeatedItem, list.RepeatedItem.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (226,10)-(226,117) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repItemBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (227,5)-(227,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (228,5)-(228,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (228,7)-(228,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,8)-(228,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("(!__sepHandled");
            #line hidden
            #line (228,22)-(228,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,23)-(228,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (228,25)-(228,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,27)-(228,36) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (228,37)-(228,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,38)-(228,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (228,39)-(228,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,40)-(228,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (228,46)-(228,63) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (228,64)-(228,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(".SeparatorCount)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (229,5)-(229,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            #line (230,10)-(230,150) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            var repSepBody = GenerateBinderFactoryVisitElementValue(sepName, list.RepeatedSeparator, list.RepeatedSeparator.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (231,10)-(231,116) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repSepBody, false, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (232,5)-(232,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (233,1)-(233,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (236,9)-(236,162) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListItem(string itemName, Element itemElem, string sepName, Element sepElem, bool separatorFirst, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first167 = true;
            #line (237,2)-(237,21) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            if (separatorFirst)
            #line hidden
            
            {
                if (__first167)
                {
                    __first167 = false;
                }
                __cb.Push("");
                #line (238,2)-(238,95) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (239,2)-(239,98) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (240,2)-(240,6) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first167)
                {
                    __first167 = false;
                }
                __cb.Push("");
                #line (241,2)-(241,98) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (242,2)-(242,95) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first167) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (246,9)-(246,145) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementValue(string elemName, Element elem, ElementValue elemValue, bool withElemBinders, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first168 = true;
            #line (247,6)-(247,38) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            if (elemValue is TokenAlts alts)
            #line hidden
            
            {
                if (__first168)
                {
                    __first168 = false;
                }
                __cb.Push("");
                #line (248,1)-(248,3) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (248,3)-(248,4) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (248,4)-(248,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (248,6)-(248,14) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (248,15)-(248,19) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(".Get");
                #line hidden
                #line (248,20)-(248,24) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (248,25)-(248,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("Kind()");
                #line hidden
                #line (248,31)-(248,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (248,32)-(248,34) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (248,34)-(248,35) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (248,36)-(248,40) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (248,41)-(248,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.None)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (249,1)-(249,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (250,10)-(250,94) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitTokenAlts(elemName, elem, alts, ref annotIndex);
                #line hidden
                
                #line (251,10)-(251,103) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first169 = true;
                #line (252,10)-(252,30) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first169)
                    {
                        __first169 = false;
                    }
                    #line (253,14)-(253,107) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first169) __cb.AppendLine();
                __cb.Push("    ");
                #line (255,6)-(255,10) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (256,1)-(256,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (257,1)-(257,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (258,1)-(258,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (259,10)-(259,110) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, "// default", true, ref annotIndex);
                #line hidden
                
                var __first170 = true;
                #line (260,10)-(260,30) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first170)
                    {
                        __first170 = false;
                    }
                    #line (261,14)-(261,106) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, true, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first170) __cb.AppendLine();
                __cb.Push("    ");
                #line (263,6)-(263,10) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (264,1)-(264,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (265,6)-(265,10) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first168)
                {
                    __first168 = false;
                }
                #line (266,10)-(266,95) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitElementBody(elemName, elemValue, ref annotIndex);
                #line hidden
                
                #line (267,10)-(267,108) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(elemValue.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first171 = true;
                #line (268,10)-(268,30) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first171)
                    {
                        __first171 = false;
                    }
                    #line (269,14)-(269,107) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first171) __cb.AppendLine();
                __cb.Push("");
                #line (271,2)-(271,6) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first168) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (275,9)-(275,112) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitTokenAlts(string elemName, Element elem, TokenAlts alts, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (276,1)-(276,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (276,7)-(276,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,8)-(276,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (276,10)-(276,18) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(elemName);
            #line hidden
            #line (276,19)-(276,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(".Get");
            #line hidden
            #line (276,24)-(276,28) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (276,29)-(276,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("Kind())");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (277,1)-(277,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first172 = true;
            #line (278,10)-(278,42) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            foreach (var alt in alts.Tokens)
            #line hidden
            
            {
                if (__first172)
                {
                    __first172 = false;
                }
                __cb.Push("    ");
                #line (279,5)-(279,9) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (279,9)-(279,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (279,11)-(279,15) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (279,16)-(279,27) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (279,28)-(279,48) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(alt.Token.CSharpName);
                #line hidden
                #line (279,49)-(279,50) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(":");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (280,10)-(280,92) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, alt, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (281,9)-(281,15) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("break;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first172) __cb.AppendLine();
            __cb.Push("    ");
            #line (283,5)-(283,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (284,9)-(284,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("break;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (285,1)-(285,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (288,9)-(288,108) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementBody(string elemName, ElementValue elemValue, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first173 = true;
            #line (289,6)-(289,58) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            if (elemValue is RuleRef rr && rr.Token is not null)
            #line hidden
            
            {
                if (__first173)
                {
                    __first173 = false;
                }
                #line (290,10)-(290,55) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                var body = "//this.VisitToken("+elemName+");";
                #line hidden
                
                __cb.Push("");
                #line (291,2)-(291,92) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(rr.Token.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (292,6)-(292,10) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first173)
                {
                    __first173 = false;
                }
                __cb.Push("");
                #line (293,1)-(293,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write("this.Visit(");
                #line hidden
                #line (293,13)-(293,21) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (293,22)-(293,24) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\SemanticsGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first173) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}