#line (1,10)-(1,53) 10 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
namespace MetaDslx.Languages.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (10,9)-(10,53) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateSemanticsFactory(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (11,6)-(11,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (11,7)-(11,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (12,1)-(12,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (12,6)-(12,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Binding;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,1)-(16,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (16,10)-(16,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (16,11)-(16,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (18,1)-(18,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (18,10)-(18,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (18,12)-(18,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,1)-(19,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (20,5)-(20,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (20,11)-(20,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (20,12)-(20,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (20,17)-(20,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (20,19)-(20,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (20,33)-(20,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("SemanticsFactory");
            #line hidden
            #line (20,49)-(20,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (20,50)-(20,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (20,51)-(20,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (20,52)-(20,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("SemanticsFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (22,9)-(22,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (22,15)-(22,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,17)-(22,30) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (22,31)-(22,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("SemanticsFactory(Compilation");
            #line hidden
            #line (22,59)-(22,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,60)-(22,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("compilation,");
            #line hidden
            #line (22,72)-(22,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,73)-(22,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("Language");
            #line hidden
            #line (22,81)-(22,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (22,82)-(22,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("language)");
            #line hidden
            #line (22,91)-(22,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (23,13)-(23,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (23,14)-(23,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,15)-(23,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("base(compilation,");
            #line hidden
            #line (23,32)-(23,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,33)-(23,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("language)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (24,9)-(24,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,9)-(25,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,9)-(27,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (27,15)-(27,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,16)-(27,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("override");
            #line hidden
            #line (27,24)-(27,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,25)-(27,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (27,45)-(27,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,46)-(27,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("CreateBinderFactoryVisitor(BinderFactory");
            #line hidden
            #line (27,86)-(27,87) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,87)-(27,101) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,9)-(28,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (29,13)-(29,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (29,19)-(29,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,20)-(29,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (29,23)-(29,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,25)-(29,52) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            #line (29,53)-(29,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(".Binding.");
            #line hidden
            #line (29,63)-(29,76) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (29,77)-(29,113) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("BinderFactoryVisitor(binderFactory);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (30,9)-(30,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (31,5)-(31,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (32,1)-(32,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (36,9)-(36,57) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitor(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (37,1)-(37,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (37,6)-(37,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (37,7)-(37,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("System;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (38,1)-(38,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (38,6)-(38,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (38,7)-(38,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,1)-(39,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (39,6)-(39,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (39,7)-(39,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first114 = true;
            #line (40,2)-(40,38) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            foreach (var use in language.Usings)
            #line hidden
            
            {
                if (__first114)
                {
                    __first114 = false;
                }
                __cb.Push("");
                #line (41,1)-(41,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("using");
                #line hidden
                #line (41,6)-(41,7) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                var __first115 = true;
                #line (41,8)-(41,34) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                if (use.Alias is not null)
                #line hidden
                
                {
                    if (__first115)
                    {
                        __first115 = false;
                    }
                    #line (41,36)-(41,45) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(use.Alias);
                    #line hidden
                    #line (41,46)-(41,47) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (41,47)-(41,48) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("=");
                    #line hidden
                    #line (41,48)-(41,49) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (41,58)-(41,80) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(use.QualifiedReference);
                #line hidden
                #line (41,81)-(41,82) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first114) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,1)-(44,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (44,10)-(44,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (44,11)-(44,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (46,1)-(46,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (46,10)-(46,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (46,12)-(46,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            #line (46,40)-(46,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(".Binding");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (47,1)-(47,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,5)-(48,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (48,10)-(48,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (48,12)-(48,39) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.QualifiedNamespace);
            #line hidden
            #line (48,40)-(48,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,5)-(50,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (50,11)-(50,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (50,12)-(50,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (50,17)-(50,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (50,19)-(50,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (50,33)-(50,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (50,53)-(50,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (50,54)-(50,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (50,55)-(50,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (50,56)-(50,107) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor,");
            #line hidden
            #line (50,107)-(50,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (50,108)-(50,109) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("I");
            #line hidden
            #line (50,110)-(50,123) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (50,124)-(50,137) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("SyntaxVisitor");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (51,5)-(51,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (52,9)-(52,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("internal");
            #line hidden
            #line (52,17)-(52,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (52,19)-(52,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (52,33)-(52,97) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("BinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory");
            #line hidden
            #line (52,97)-(52,98) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (52,98)-(52,112) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (53,13)-(53,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (53,14)-(53,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (53,15)-(53,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("base(binderFactory)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (54,9)-(54,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (55,9)-(55,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first116 = true;
            #line (57,4)-(57,54) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            foreach (var rule in language.Grammar.ParserRules)
            #line hidden
            
            {
                if (__first116)
                {
                    __first116 = false;
                }
                var __first117 = true;
                #line (58,5)-(58,43) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first117)
                    {
                        __first117 = false;
                    }
                    __cb.Push("");
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (60,10)-(60,57) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(GenerateBinderFactoryVisit(language, rule, alt));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first117) __cb.AppendLine();
            }
            if (!__first116) __cb.AppendLine();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (64,3)-(64,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (64,9)-(64,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,10)-(64,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("virtual");
            #line hidden
            #line (64,17)-(64,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,18)-(64,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("void");
            #line hidden
            #line (64,22)-(64,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,23)-(64,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("VisitSkippedTokensTrivia(");
            #line hidden
            #line (64,49)-(64,62) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (64,63)-(64,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("SkippedTokensTriviaSyntax");
            #line hidden
            #line (64,88)-(64,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (64,89)-(64,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (65,3)-(65,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (66,3)-(66,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (67,5)-(67,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (68,1)-(68,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (71,9)-(71,99) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisit(Language language, ParserRule rule, ParserRuleAlternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (72,1)-(72,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (72,7)-(72,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,8)-(72,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("virtual");
            #line hidden
            #line (72,15)-(72,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,16)-(72,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("void");
            #line hidden
            #line (72,20)-(72,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,21)-(72,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("Visit");
            #line hidden
            #line (72,27)-(72,41) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (72,42)-(72,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (72,44)-(72,55) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(alt.RedName);
            #line hidden
            #line (72,56)-(72,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,57)-(72,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("node)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (73,1)-(73,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first118 = true;
            #line (74,6)-(74,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            if (rule == language.Grammar.MainRule)
            #line hidden
            
            {
                if (__first118)
                {
                    __first118 = false;
                }
                __cb.Push("    ");
                #line (75,5)-(75,7) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("if");
                #line hidden
                #line (75,7)-(75,8) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (75,8)-(75,21) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("(this.IsRoot)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (76,5)-(76,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first119 = true;
                #line (77,10)-(77,52) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                if (language.Grammar.RootType is not null)
                #line hidden
                
                {
                    if (__first119)
                    {
                        __first119 = false;
                    }
                    __cb.Push("        ");
                    #line (78,9)-(78,12) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("var");
                    #line hidden
                    #line (78,12)-(78,13) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,13)-(78,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("__rootAnnot");
                    #line hidden
                    #line (78,24)-(78,25) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,25)-(78,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("=");
                    #line hidden
                    #line (78,26)-(78,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,27)-(78,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("new");
                    #line hidden
                    #line (78,30)-(78,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,31)-(78,96) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree,");
                    #line hidden
                    #line (78,96)-(78,97) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,97)-(78,102) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("type:");
                    #line hidden
                    #line (78,102)-(78,103) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (78,103)-(78,110) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("typeof(");
                    #line hidden
                    #line (78,111)-(78,217) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(language.Grammar.RootType.ToDisplayString(Microsoft.CodeAnalysis.SymbolDisplayFormat.FullyQualifiedFormat));
                    #line hidden
                    #line (78,218)-(78,221) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("));");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (79,10)-(79,14) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                else
                #line hidden
                
                {
                    if (__first119)
                    {
                        __first119 = false;
                    }
                    __cb.Push("        ");
                    #line (80,9)-(80,12) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("var");
                    #line hidden
                    #line (80,12)-(80,13) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (80,13)-(80,24) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("__rootAnnot");
                    #line hidden
                    #line (80,24)-(80,25) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (80,25)-(80,26) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("=");
                    #line hidden
                    #line (80,26)-(80,27) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (80,27)-(80,30) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("new");
                    #line hidden
                    #line (80,30)-(80,31) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (80,31)-(80,96) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("global::MetaDslx.CodeAnalysis.Binding.RootBinder(node.SyntaxTree,");
                    #line hidden
                    #line (80,96)-(80,97) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (80,97)-(80,102) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("type:");
                    #line hidden
                    #line (80,102)-(80,103) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (80,103)-(80,109) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write("null);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first119) __cb.AppendLine();
                __cb.Push("        ");
                #line (82,9)-(82,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("this.Begin(__rootAnnot,");
                #line hidden
                #line (82,32)-(82,33) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (82,33)-(82,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("node);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (83,9)-(83,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("try");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (84,9)-(84,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (85,14)-(85,65) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitBody(language, rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (86,9)-(86,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (87,9)-(87,16) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("finally");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (88,9)-(88,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (89,13)-(89,35) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("this.End(__rootAnnot);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (90,9)-(90,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (91,5)-(91,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (92,5)-(92,9) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("else");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (93,5)-(93,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    \t");
                #line (94,7)-(94,58) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitBody(language, rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (95,5)-(95,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (96,6)-(96,10) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            else
            #line hidden
            
            {
                if (__first118)
                {
                    __first118 = false;
                }
                __cb.Push("\t");
                #line (97,3)-(97,54) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitBody(language, rule, alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first118) __cb.AppendLine();
            __cb.Push("");
            #line (99,1)-(99,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (102,9)-(102,103) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitBody(Language language, ParserRule rule, ParserRuleAlternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (103,2)-(103,20) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            var annotIndex = 0;
            #line hidden
            
            #line (104,2)-(104,78) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            var body = GenerateBinderFactoryVisitElements(language, alt, ref annotIndex);
            #line hidden
            
            #line (105,2)-(105,100) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            body = GenerateBinderFactoryVisitAnnotations(alt.Annotations, "node", body, false, ref annotIndex);
            #line hidden
            
            #line (106,2)-(106,101) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            body = GenerateBinderFactoryVisitAnnotations(rule.Annotations, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (107,2)-(107,6) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (110,9)-(110,110) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitElements(Language language, ParserRuleAlternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first120 = true;
            #line (111,2)-(111,66) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first120)
                {
                    __first120 = false;
                }
                __cb.Push("");
                #line (112,2)-(112,72) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitElement(language, alt, elem, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (113,14)-(113,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("    ");
            #line hidden
            return __cb.ToStringAndFree();
        }
        
        #line (116,9)-(116,148) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitAnnotations(IEnumerable<Annotation> annotations, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first121 = true;
            #line (117,2)-(117,116) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            foreach (var annot in annotations.Where(a => a.Kind == AnnotationKind.Binder && a.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first121)
                {
                    __first121 = false;
                }
                #line (118,2)-(118,84) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                body = GenerateBinderFactoryVisitAnnotation(annot, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first121) __cb.AppendLine();
            __cb.Push("");
            #line (120,2)-(120,6) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (123,9)-(123,114) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitAnnotation(Annotation annot, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (124,2)-(124,45) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            var annotVarName = "__annot"+(annotIndex++);
            #line hidden
            
            #line (125,2)-(125,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            var annotName = annot.Name.LastOrDefault();
            #line hidden
            
            __cb.Push("");
            #line (126,1)-(126,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("var");
            #line hidden
            #line (126,4)-(126,5) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,6)-(126,18) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(annotVarName);
            #line hidden
            #line (126,19)-(126,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,20)-(126,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (126,21)-(126,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,22)-(126,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (126,25)-(126,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,27)-(126,46) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(annot.QualifiedName);
            #line hidden
            #line (126,47)-(126,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("Binder(");
            #line hidden
            #line (126,55)-(126,100) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(GenerateAnnotationConstructorArguments(annot));
            #line hidden
            #line (126,101)-(126,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (127,1)-(127,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("this.Begin(");
            #line hidden
            #line (127,13)-(127,25) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(annotVarName);
            #line hidden
            #line (127,26)-(127,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(",");
            #line hidden
            #line (127,27)-(127,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,29)-(127,37) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(nodeName);
            #line hidden
            #line (127,38)-(127,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (128,1)-(128,4) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("try");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (129,1)-(129,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (130,6)-(130,10) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(body);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (131,1)-(131,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (132,1)-(132,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("finally");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (133,1)-(133,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (134,5)-(134,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("this.End(");
            #line hidden
            #line (134,15)-(134,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(annotVarName);
            #line hidden
            #line (134,28)-(134,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (135,1)-(135,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (138,9)-(138,66) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateAnnotationConstructorArguments(Annotation annot)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first122 = true;
            #line (140,2)-(140,50) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            foreach (var arg in annot.ConstructorArguments) 
            #line hidden
            
            {
                if (__first122)
                {
                    __first122 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (140,60)-(140,64) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (141,2)-(141,10) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(arg.Name);
                #line hidden
                #line (141,11)-(141,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(":");
                #line hidden
                #line (141,12)-(141,13) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (141,14)-(141,29) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(arg.CSharpValue);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first122) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (145,9)-(145,133) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitElement(Language language, ParserRuleAlternative alt, ParserRuleElement elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first123 = true;
            #line (146,3)-(146,19) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            if (elem.IsList)
            #line hidden
            
            {
                if (__first123)
                {
                    __first123 = false;
                }
                __cb.Push("");
                #line (147,1)-(147,4) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("var");
                #line hidden
                #line (147,4)-(147,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (147,6)-(147,24) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (147,25)-(147,29) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("List");
                #line hidden
                #line (147,29)-(147,30) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (147,30)-(147,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("=");
                #line hidden
                #line (147,31)-(147,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (147,32)-(147,37) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("node.");
                #line hidden
                #line (147,38)-(147,55) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(elem.PropertyName);
                #line hidden
                #line (147,56)-(147,57) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (148,1)-(148,4) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("for");
                #line hidden
                #line (148,4)-(148,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,5)-(148,9) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("(var");
                #line hidden
                #line (148,9)-(148,10) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,11)-(148,29) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (148,30)-(148,35) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("Index");
                #line hidden
                #line (148,35)-(148,36) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,36)-(148,37) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("=");
                #line hidden
                #line (148,37)-(148,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,38)-(148,40) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("0;");
                #line hidden
                #line (148,40)-(148,41) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,42)-(148,60) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (148,61)-(148,66) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("Index");
                #line hidden
                #line (148,66)-(148,67) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,67)-(148,68) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("<");
                #line hidden
                #line (148,68)-(148,69) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,70)-(148,88) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (148,89)-(148,100) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("List.Count;");
                #line hidden
                #line (148,100)-(148,101) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (148,101)-(148,103) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("++");
                #line hidden
                #line (148,104)-(148,122) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (148,123)-(148,129) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("Index)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (149,1)-(149,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first124 = true;
                #line (150,6)-(150,69) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                if (elem.IsSeparated && elem is ParserRuleListElement listElem)
                #line hidden
                
                {
                    if (__first124)
                    {
                        __first124 = false;
                    }
                    var __first125 = true;
                    #line (151,6)-(151,110) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    if (listElem.ListKind == ListKind.WithFirstItem || listElem.ListKind == ListKind.WithFirstItemSeparator)
                    #line hidden
                    
                    {
                        if (__first125)
                        {
                            __first125 = false;
                        }
                        __cb.Push("    ");
                        #line (152,5)-(152,7) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("if");
                        #line hidden
                        #line (152,7)-(152,8) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,8)-(152,9) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("(");
                        #line hidden
                        #line (152,10)-(152,28) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (152,29)-(152,34) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("Index");
                        #line hidden
                        #line (152,34)-(152,35) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,35)-(152,37) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("==");
                        #line hidden
                        #line (152,37)-(152,38) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (152,38)-(152,40) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("0)");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (153,5)-(153,6) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("{");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        #line (154,10)-(154,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        var elemName = "node."+elem.PropertyName+"["+elem.ParameterName+"Index]";
                        #line hidden
                        
                        #line (155,10)-(155,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        var elemBody = "this.Visit("+elemName+");";
                        #line hidden
                        
                        __cb.Push("        ");
                        #line (156,10)-(156,125) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.FirstItem.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (157,5)-(157,6) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("}");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first125) __cb.AppendLine();
                    var __first126 = true;
                    #line (159,6)-(159,164) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    if (listElem.ListKind == ListKind.WithLastItem || listElem.ListKind == ListKind.WithLastItemSeparator || listElem.ListKind == ListKind.WithFirstItemSeparator)
                    #line hidden
                    
                    {
                        if (__first126)
                        {
                            __first126 = false;
                        }
                        __cb.Push("    ");
                        var __first127 = true;
                        #line (160,6)-(160,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        if (listElem.ListKind == ListKind.WithFirstItemSeparator)
                        #line hidden
                        
                        {
                            if (__first127)
                            {
                                __first127 = false;
                            }
                            #line (160,64)-(160,68) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("else");
                            #line hidden
                            #line (160,68)-(160,69) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(" ");
                            #line hidden
                        }
                        #line (160,77)-(160,79) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("if");
                        #line hidden
                        #line (160,79)-(160,80) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (160,80)-(160,81) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("(");
                        #line hidden
                        #line (160,82)-(160,100) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (160,101)-(160,106) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("Index");
                        #line hidden
                        #line (160,106)-(160,107) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (160,107)-(160,109) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("==");
                        #line hidden
                        #line (160,109)-(160,110) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (160,111)-(160,129) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(elem.ParameterName);
                        #line hidden
                        #line (160,130)-(160,140) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("List.Count");
                        #line hidden
                        #line (160,140)-(160,141) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (160,141)-(160,142) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("-");
                        #line hidden
                        #line (160,142)-(160,143) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (160,143)-(160,145) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("1)");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (161,5)-(161,6) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("{");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        var __first128 = true;
                        #line (162,10)-(162,112) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        if (listElem.ListKind == ListKind.WithLastItem || listElem.ListKind == ListKind.WithLastItemSeparator)
                        #line hidden
                        
                        {
                            if (__first128)
                            {
                                __first128 = false;
                            }
                            #line (163,14)-(163,86) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            var elemName = "node."+elem.PropertyName+"["+elem.ParameterName+"Index]";
                            #line hidden
                            
                            #line (164,14)-(164,56) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            var elemBody = "this.Visit("+elemName+");";
                            #line hidden
                            
                            __cb.Push("        ");
                            #line (165,10)-(165,124) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.LastItem.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        if (!__first128) __cb.AppendLine();
                        var __first129 = true;
                        #line (167,10)-(167,122) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        if (listElem.ListKind == ListKind.WithFirstItemSeparator || listElem.ListKind == ListKind.WithLastItemSeparator)
                        #line hidden
                        
                        {
                            if (__first129)
                            {
                                __first129 = false;
                            }
                            #line (168,14)-(168,99) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            var elemName = "node."+elem.PropertyName+".GetSeparator("+elem.ParameterName+"Index)";
                            #line hidden
                            
                            #line (169,14)-(169,64) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            var elemBody = "// this.VisitToken("+elemName+");";
                            #line hidden
                            
                            __cb.Push("        ");
                            #line (170,9)-(170,11) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("if");
                            #line hidden
                            #line (170,11)-(170,12) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(" ");
                            #line hidden
                            #line (170,12)-(170,13) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("(");
                            #line hidden
                            #line (170,14)-(170,32) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(elem.ParameterName);
                            #line hidden
                            #line (170,33)-(170,38) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("Index");
                            #line hidden
                            #line (170,38)-(170,39) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(" ");
                            #line hidden
                            #line (170,39)-(170,41) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("==");
                            #line hidden
                            #line (170,41)-(170,42) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(" ");
                            #line hidden
                            #line (170,43)-(170,61) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(elem.ParameterName);
                            #line hidden
                            #line (170,62)-(170,81) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("List.SeparatorCount");
                            #line hidden
                            #line (170,81)-(170,82) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(" ");
                            #line hidden
                            #line (170,82)-(170,83) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("-");
                            #line hidden
                            #line (170,83)-(170,84) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(" ");
                            #line hidden
                            #line (170,84)-(170,86) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("1)");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (171,9)-(171,10) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("{");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (172,14)-(172,133) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.LastSeparator.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (173,9)-(173,10) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("}");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (174,9)-(174,13) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("else");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (175,9)-(175,10) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("{");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (176,14)-(176,132) 40 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.LastSeparator.AllAnnotations, elemName, elemBody, true, ref annotIndex));
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (177,9)-(177,10) 41 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                            __cb.Write("}");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        if (!__first129) __cb.AppendLine();
                        __cb.Push("    ");
                        #line (179,5)-(179,6) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("}");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first126) __cb.AppendLine();
                    var __first130 = true;
                    #line (181,6)-(181,211) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    if (listElem.ListKind == ListKind.WithFirstItem || listElem.ListKind == ListKind.WithLastItem || listElem.ListKind == ListKind.WithLastItemSeparator || listElem.ListKind == ListKind.WithFirstItemSeparator)
                    #line hidden
                    
                    {
                        if (__first130)
                        {
                            __first130 = false;
                        }
                        __cb.Push("    ");
                        #line (182,5)-(182,9) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("else");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (183,5)-(183,6) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("{");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        #line (184,10)-(184,106) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        var elemBody = GenerateBinderFactoryVisitListElement(listElem, out var elemName, ref annotIndex);
                        #line hidden
                        
                        __cb.Push("        ");
                        #line (185,10)-(185,128) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.RepeatedRule.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (186,5)-(186,6) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("}");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (187,6)-(187,10) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    else
                    #line hidden
                    
                    {
                        if (__first130)
                        {
                            __first130 = false;
                        }
                        #line (188,10)-(188,106) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        var elemBody = GenerateBinderFactoryVisitListElement(listElem, out var elemName, ref annotIndex);
                        #line hidden
                        
                        __cb.Push("    ");
                        #line (189,6)-(189,124) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.RepeatedRule.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first130) __cb.AppendLine();
                }
                #line (191,10)-(191,32) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                else if (elem.IsToken)
                #line hidden
                
                {
                    if (__first124)
                    {
                        __first124 = false;
                    }
                    #line (192,14)-(192,86) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemName = "node."+elem.PropertyName+"["+elem.ParameterName+"Index]";
                    #line hidden
                    
                    #line (193,14)-(193,64) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemBody = "// this.VisitToken("+elemName+");";
                    #line hidden
                    
                    __cb.Push("    ");
                    #line (194,6)-(194,107) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(GenerateBinderFactoryVisitAnnotations(elem.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (195,10)-(195,14) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                else
                #line hidden
                
                {
                    if (__first124)
                    {
                        __first124 = false;
                    }
                    #line (196,14)-(196,86) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemName = "node."+elem.PropertyName+"["+elem.ParameterName+"Index]";
                    #line hidden
                    
                    #line (197,14)-(197,56) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemBody = "this.Visit("+elemName+");";
                    #line hidden
                    
                    __cb.Push("    ");
                    #line (198,6)-(198,107) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(GenerateBinderFactoryVisitAnnotations(elem.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first124) __cb.AppendLine();
                __cb.Push("");
                #line (200,1)-(200,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (201,3)-(201,7) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            else
            #line hidden
            
            {
                if (__first123)
                {
                    __first123 = false;
                }
                var __first131 = true;
                #line (202,4)-(202,21) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first131)
                    {
                        __first131 = false;
                    }
                    #line (203,14)-(203,54) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemName = "node."+elem.PropertyName;
                    #line hidden
                    
                    #line (204,14)-(204,64) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemBody = "// this.VisitToken("+elemName+");";
                    #line hidden
                    
                    var __first132 = true;
                    #line (205,14)-(205,81) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    if (elem is ParserRuleFixedStringAlternativesElement fixedAltsElem)
                    #line hidden
                    
                    {
                        if (__first132)
                        {
                            __first132 = false;
                        }
                        __cb.Push("");
                        #line (206,2)-(206,105) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(GenerateBinderFactoryVisitFixedAltsElement(language, fixedAltsElem, elemName, elemBody, ref annotIndex));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (207,14)-(207,18) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    else
                    #line hidden
                    
                    {
                        if (__first132)
                        {
                            __first132 = false;
                        }
                        __cb.Push("");
                        #line (208,1)-(208,3) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("if");
                        #line hidden
                        #line (208,3)-(208,4) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,4)-(208,10) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("(node.");
                        #line hidden
                        #line (208,11)-(208,28) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(elem.PropertyName);
                        #line hidden
                        #line (208,29)-(208,33) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(".Get");
                        #line hidden
                        #line (208,34)-(208,47) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(language.Name);
                        #line hidden
                        #line (208,48)-(208,54) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("Kind()");
                        #line hidden
                        #line (208,54)-(208,55) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,55)-(208,57) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("!=");
                        #line hidden
                        #line (208,57)-(208,58) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(" ");
                        #line hidden
                        #line (208,59)-(208,72) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(language.Name);
                        #line hidden
                        #line (208,73)-(208,89) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("SyntaxKind.None)");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (209,1)-(209,2) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("{");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (210,6)-(210,107) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(GenerateBinderFactoryVisitAnnotations(elem.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (211,1)-(211,2) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("}");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (212,1)-(212,5) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("else");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (213,1)-(213,2) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("{");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("    ");
                        #line (214,6)-(214,106) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write(GenerateBinderFactoryVisitAnnotations(elem.AllAnnotations, elemName, elemBody, true, ref annotIndex));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (215,1)-(215,2) 37 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                        __cb.Write("}");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first132) __cb.AppendLine();
                }
                #line (217,4)-(217,8) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                else
                #line hidden
                
                {
                    if (__first131)
                    {
                        __first131 = false;
                    }
                    #line (218,14)-(218,54) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemName = "node."+elem.PropertyName;
                    #line hidden
                    
                    #line (219,14)-(219,56) 21 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    var elemBody = "this.Visit("+elemName+");";
                    #line hidden
                    
                    __cb.Push("");
                    #line (220,2)-(220,103) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                    __cb.Write(GenerateBinderFactoryVisitAnnotations(elem.AllAnnotations, elemName, elemBody, false, ref annotIndex));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first131) __cb.AppendLine();
            }
            if (!__first123) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (225,9)-(225,181) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitFixedAltsElement(Language language, ParserRuleFixedStringAlternativesElement fixedAltsElem, string elemName, string elemBody, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (226,1)-(226,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("switch");
            #line hidden
            #line (226,7)-(226,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (226,8)-(226,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("(node.");
            #line hidden
            #line (226,15)-(226,41) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(fixedAltsElem.PropertyName);
            #line hidden
            #line (226,42)-(226,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(".Get");
            #line hidden
            #line (226,47)-(226,60) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (226,61)-(226,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("Kind())");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (227,1)-(227,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first133 = true;
            #line (228,18)-(228,70) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            foreach (var fixedAlt in fixedAltsElem.Alternatives)
            #line hidden
            
            {
                if (__first133)
                {
                    __first133 = false;
                }
                __cb.Push("");
                #line (229,1)-(229,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("case");
                #line hidden
                #line (229,5)-(229,6) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (229,7)-(229,20) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(language.Name);
                #line hidden
                #line (229,21)-(229,32) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (229,33)-(229,62) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(fixedAlt.LexerRule.CSharpName);
                #line hidden
                #line (229,63)-(229,64) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(":");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                #line (230,6)-(230,125) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                var altBody = GenerateBinderFactoryVisitAnnotations(fixedAlt.AllAnnotations, elemName, elemBody, false, ref annotIndex);
                #line hidden
                
                __cb.Push("    ");
                #line (231,6)-(231,115) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitAnnotations(fixedAltsElem.AllAnnotations, elemName, altBody, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (232,5)-(232,11) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write("break;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first133) __cb.AppendLine();
            __cb.Push("");
            #line (234,1)-(234,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (235,6)-(235,115) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write(GenerateBinderFactoryVisitAnnotations(fixedAltsElem.AllAnnotations, elemName, elemBody, true, ref annotIndex));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (236,5)-(236,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("break;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (237,1)-(237,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (240,9)-(240,120) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
        public string GenerateBinderFactoryVisitListElement(ParserRuleListElement listElem, out string itemName, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (241,6)-(241,98) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            var sepName = "node."+listElem.PropertyName+".GetSeparator("+listElem.ParameterName+"Index)";
            #line hidden
            
            #line (242,6)-(242,54) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            var sepBody = "// this.VisitToken("+sepName+");";
            #line hidden
            
            #line (243,6)-(243,82) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            itemName = "node."+listElem.PropertyName+"["+listElem.ParameterName+"Index]";
            #line hidden
            
            #line (244,6)-(244,48) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            var itemBody = "this.Visit("+itemName+");";
            #line hidden
            
            var __first134 = true;
            #line (245,6)-(245,30) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            if (listElem.IsReversed)
            #line hidden
            
            {
                if (__first134)
                {
                    __first134 = false;
                }
                __cb.Push("");
                #line (246,2)-(246,123) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.RepeatedSeparator.AllAnnotations, sepName, sepBody, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (247,2)-(247,120) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.RepeatedItem.AllAnnotations, itemName, itemBody, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (248,6)-(248,10) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
            else
            #line hidden
            
            {
                if (__first134)
                {
                    __first134 = false;
                }
                __cb.Push("");
                #line (249,2)-(249,120) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.RepeatedItem.AllAnnotations, itemName, itemBody, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (250,2)-(250,123) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler\Generators\SemanticsGenerator.mgen"
                __cb.Write(GenerateBinderFactoryVisitAnnotations(listElem.RepeatedSeparator.AllAnnotations, sepName, sepBody, false, ref annotIndex));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first134) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}