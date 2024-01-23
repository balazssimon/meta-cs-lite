#line (1,10)-(1,53) 10 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
namespace MetaDslx.Bootstrap.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    MetaDslx.Bootstrap.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (10,9)-(10,28) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
        public string GenerateLanguage()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (11,6)-(11,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (11,7)-(11,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Autofac;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (12,1)-(12,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (12,6)-(12,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (13,6)-(13,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (13,7)-(13,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (14,6)-(14,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (14,7)-(14,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis.Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,1)-(16,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (16,10)-(16,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (16,11)-(16,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (18,1)-(18,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (18,10)-(18,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (18,12)-(18,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,1)-(19,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (20,5)-(20,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (20,10)-(20,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (20,11)-(20,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("global::");
            #line hidden
            #line (20,20)-(20,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Namespace);
            #line hidden
            #line (20,30)-(20,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (21,10)-(21,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (21,11)-(21,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("global::");
            #line hidden
            #line (21,20)-(21,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Namespace);
            #line hidden
            #line (21,30)-(21,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(".Syntax.InternalSyntax;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,5)-(23,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (23,11)-(23,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,12)-(23,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("sealed");
            #line hidden
            #line (23,18)-(23,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,19)-(23,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("partial");
            #line hidden
            #line (23,26)-(23,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,27)-(23,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (23,32)-(23,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,34)-(23,38) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (23,39)-(23,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Language");
            #line hidden
            #line (23,47)-(23,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,48)-(23,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (23,49)-(23,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (23,50)-(23,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Language");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,5)-(24,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (25,9)-(25,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (25,15)-(25,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,16)-(25,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (25,22)-(25,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,24)-(25,28) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (25,29)-(25,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Language");
            #line hidden
            #line (25,37)-(25,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,38)-(25,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Instance");
            #line hidden
            #line (25,46)-(25,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,47)-(25,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (25,48)-(25,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,49)-(25,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (25,52)-(25,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (25,54)-(25,58) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (25,59)-(25,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Language();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,9)-(27,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (27,15)-(27,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,16)-(27,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("override");
            #line hidden
            #line (27,24)-(27,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,25)-(27,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("string");
            #line hidden
            #line (27,31)-(27,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,32)-(27,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Name");
            #line hidden
            #line (27,36)-(27,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,37)-(27,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (27,39)-(27,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (27,40)-(27,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"");
            #line hidden
            #line (27,42)-(27,46) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (27,47)-(27,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,9)-(29,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (29,15)-(29,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,16)-(29,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (29,19)-(29,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,21)-(29,25) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (29,26)-(29,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (29,47)-(29,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,48)-(29,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("InternalSyntaxFactory");
            #line hidden
            #line (29,69)-(29,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,70)-(29,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (29,72)-(29,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (29,73)-(29,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (29,75)-(29,79) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (29,80)-(29,129) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("InternalSyntaxFactory)base.InternalSyntaxFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (31,9)-(31,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (31,15)-(31,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (31,16)-(31,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (31,19)-(31,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (31,21)-(31,25) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (31,26)-(31,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFacts");
            #line hidden
            #line (31,37)-(31,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (31,38)-(31,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFacts");
            #line hidden
            #line (31,49)-(31,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (31,50)-(31,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (31,52)-(31,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (31,53)-(31,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (31,55)-(31,59) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (31,60)-(31,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFacts)base.SyntaxFacts;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (33,9)-(33,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (33,15)-(33,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (33,16)-(33,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (33,19)-(33,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (33,21)-(33,25) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (33,26)-(33,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFactory");
            #line hidden
            #line (33,39)-(33,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (33,40)-(33,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFactory");
            #line hidden
            #line (33,53)-(33,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (33,54)-(33,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (33,56)-(33,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (33,57)-(33,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (33,59)-(33,63) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (33,64)-(33,97) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFactory)base.SyntaxFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (35,9)-(35,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (35,15)-(35,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (35,16)-(35,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("new");
            #line hidden
            #line (35,19)-(35,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (35,21)-(35,25) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (35,26)-(35,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("CompilationFactory");
            #line hidden
            #line (35,44)-(35,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (35,45)-(35,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("CompilationFactory");
            #line hidden
            #line (35,63)-(35,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (35,64)-(35,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (35,66)-(35,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (35,67)-(35,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(");
            #line hidden
            #line (35,69)-(35,73) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (35,74)-(35,117) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("CompilationFactory)base.CompilationFactory;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (37,9)-(37,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("protected");
            #line hidden
            #line (37,18)-(37,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (37,19)-(37,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("override");
            #line hidden
            #line (37,27)-(37,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (37,28)-(37,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("void");
            #line hidden
            #line (37,32)-(37,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (37,33)-(37,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("RegisterServicesCore()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (38,9)-(38,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (39,13)-(39,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("RegisterServices();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (40,13)-(40,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("TryRegisterGlobal<SyntaxFacts,");
            #line hidden
            #line (40,43)-(40,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (40,45)-(40,49) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (40,50)-(40,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFacts>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (41,13)-(41,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("TryRegisterGlobal<InternalSyntaxFactory,");
            #line hidden
            #line (41,53)-(41,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (41,55)-(41,59) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (41,60)-(41,85) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("InternalSyntaxFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (42,13)-(42,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("TryRegisterGlobal<SyntaxFactory,");
            #line hidden
            #line (42,45)-(42,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (42,47)-(42,51) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (42,52)-(42,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SyntaxFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (43,13)-(43,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("TryRegisterGlobal<CompilationFactory,");
            #line hidden
            #line (43,50)-(43,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (43,52)-(43,56) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (43,57)-(43,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("CompilationFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (44,13)-(44,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("TryRegisterCompilationScoped<SemanticsFactory,");
            #line hidden
            #line (44,59)-(44,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (44,61)-(44,65) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (44,66)-(44,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("SemanticsFactory>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (45,9)-(45,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (47,9)-(47,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("partial");
            #line hidden
            #line (47,16)-(47,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (47,17)-(47,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("void");
            #line hidden
            #line (47,21)-(47,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (47,22)-(47,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("RegisterServices();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,5)-(48,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (49,1)-(49,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (52,9)-(52,35) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
        public string GenerateLanguageVersion()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (53,1)-(53,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (53,6)-(53,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (53,7)-(53,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (54,1)-(54,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("using");
            #line hidden
            #line (54,6)-(54,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (54,7)-(54,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Roslyn.Utilities;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (56,1)-(56,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("#nullable");
            #line hidden
            #line (56,10)-(56,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (56,11)-(56,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("enable");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (58,1)-(58,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("namespace");
            #line hidden
            #line (58,10)-(58,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (58,12)-(58,21) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Namespace);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (59,1)-(59,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (60,5)-(60,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (60,8)-(60,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (60,9)-(60,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (61,5)-(61,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (61,8)-(61,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (61,9)-(61,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Specifies");
            #line hidden
            #line (61,18)-(61,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (61,19)-(61,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (61,22)-(61,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (61,23)-(61,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("language");
            #line hidden
            #line (61,31)-(61,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (61,32)-(61,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (62,5)-(62,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (62,8)-(62,9) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (62,9)-(62,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (63,5)-(63,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (63,11)-(63,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,12)-(63,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("enum");
            #line hidden
            #line (63,16)-(63,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (63,18)-(63,22) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (63,23)-(63,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (64,5)-(64,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (65,9)-(65,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (65,12)-(65,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (65,13)-(65,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (66,9)-(66,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (66,12)-(66,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,13)-(66,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Language");
            #line hidden
            #line (66,21)-(66,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,22)-(66,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version");
            #line hidden
            #line (66,29)-(66,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (66,30)-(66,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("1");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (67,9)-(67,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (67,12)-(67,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (67,13)-(67,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (68,9)-(68,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Version1");
            #line hidden
            #line (68,17)-(68,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (68,18)-(68,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (68,19)-(68,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (68,20)-(68,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("1,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,9)-(70,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (70,12)-(70,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (70,13)-(70,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (71,9)-(71,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (71,12)-(71,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,13)-(71,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("The");
            #line hidden
            #line (71,16)-(71,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,17)-(71,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("latest");
            #line hidden
            #line (71,23)-(71,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,24)-(71,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("major");
            #line hidden
            #line (71,29)-(71,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,30)-(71,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("supported");
            #line hidden
            #line (71,39)-(71,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (71,40)-(71,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,9)-(72,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (72,12)-(72,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (72,13)-(72,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,9)-(73,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LatestMajor");
            #line hidden
            #line (73,20)-(73,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,21)-(73,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (73,22)-(73,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,23)-(73,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("int.MaxValue");
            #line hidden
            #line (73,35)-(73,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,36)-(73,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("-");
            #line hidden
            #line (73,37)-(73,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,38)-(73,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("2,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (75,9)-(75,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (75,12)-(75,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (75,13)-(75,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (76,9)-(76,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (76,12)-(76,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (76,13)-(76,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Preview");
            #line hidden
            #line (76,20)-(76,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (76,21)-(76,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("of");
            #line hidden
            #line (76,23)-(76,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (76,24)-(76,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (76,27)-(76,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (76,28)-(76,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("next");
            #line hidden
            #line (76,32)-(76,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (76,33)-(76,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("language");
            #line hidden
            #line (76,41)-(76,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (76,42)-(76,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (77,9)-(77,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (77,12)-(77,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (77,13)-(77,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,9)-(78,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Preview");
            #line hidden
            #line (78,16)-(78,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (78,17)-(78,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (78,18)-(78,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (78,19)-(78,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("int.MaxValue");
            #line hidden
            #line (78,31)-(78,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (78,32)-(78,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("-");
            #line hidden
            #line (78,33)-(78,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (78,34)-(78,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("1,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,9)-(80,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (80,12)-(80,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (80,13)-(80,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (81,9)-(81,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (81,12)-(81,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,13)-(81,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("The");
            #line hidden
            #line (81,16)-(81,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,17)-(81,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("latest");
            #line hidden
            #line (81,23)-(81,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,24)-(81,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("supported");
            #line hidden
            #line (81,33)-(81,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,34)-(81,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version");
            #line hidden
            #line (81,41)-(81,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,42)-(81,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("of");
            #line hidden
            #line (81,44)-(81,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,45)-(81,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (81,48)-(81,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (81,49)-(81,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("language.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,9)-(82,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (82,12)-(82,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (82,13)-(82,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,9)-(83,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Latest");
            #line hidden
            #line (83,15)-(83,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (83,16)-(83,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (83,17)-(83,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (83,18)-(83,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("int.MaxValue,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (85,12)-(85,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (85,13)-(85,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (86,9)-(86,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (86,12)-(86,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,13)-(86,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("The");
            #line hidden
            #line (86,16)-(86,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,17)-(86,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("default");
            #line hidden
            #line (86,24)-(86,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,25)-(86,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("language");
            #line hidden
            #line (86,33)-(86,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,34)-(86,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version,");
            #line hidden
            #line (86,42)-(86,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,43)-(86,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("which");
            #line hidden
            #line (86,48)-(86,49) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,49)-(86,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("is");
            #line hidden
            #line (86,51)-(86,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,52)-(86,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (86,55)-(86,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,56)-(86,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("latest");
            #line hidden
            #line (86,62)-(86,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,63)-(86,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("supported");
            #line hidden
            #line (86,72)-(86,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (86,73)-(86,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (87,9)-(87,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (87,12)-(87,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (87,13)-(87,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (88,9)-(88,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Default");
            #line hidden
            #line (88,16)-(88,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (88,17)-(88,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (88,18)-(88,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (88,19)-(88,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("0,");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (89,5)-(89,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (91,5)-(91,11) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (91,11)-(91,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (91,12)-(91,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (91,18)-(91,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (91,19)-(91,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("class");
            #line hidden
            #line (91,24)-(91,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (91,26)-(91,30) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (91,31)-(91,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersionFacts");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (92,5)-(92,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (93,9)-(93,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("internal");
            #line hidden
            #line (93,17)-(93,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,18)-(93,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (93,24)-(93,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,25)-(93,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("bool");
            #line hidden
            #line (93,29)-(93,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,30)-(93,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("IsValid(this");
            #line hidden
            #line (93,42)-(93,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,44)-(93,48) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (93,49)-(93,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (93,64)-(93,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (93,65)-(93,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (94,9)-(94,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (95,13)-(95,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("switch");
            #line hidden
            #line (95,19)-(95,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (95,20)-(95,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(value)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (96,13)-(96,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (97,17)-(97,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (97,21)-(97,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (97,23)-(97,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (97,28)-(97,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Version1:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (98,17)-(98,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (98,21)-(98,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (98,23)-(98,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (98,28)-(98,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Preview:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (99,21)-(99,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (99,27)-(99,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (99,28)-(99,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (100,13)-(100,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (102,13)-(102,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (102,19)-(102,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (102,20)-(102,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (103,9)-(103,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (105,9)-(105,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (105,12)-(105,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (105,13)-(105,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (106,9)-(106,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (106,12)-(106,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,13)-(106,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Displays");
            #line hidden
            #line (106,21)-(106,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,22)-(106,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (106,25)-(106,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,26)-(106,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version");
            #line hidden
            #line (106,33)-(106,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,34)-(106,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("number");
            #line hidden
            #line (106,40)-(106,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,41)-(106,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("in");
            #line hidden
            #line (106,43)-(106,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,44)-(106,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (106,47)-(106,48) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,48)-(106,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("format");
            #line hidden
            #line (106,54)-(106,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,55)-(106,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("expected");
            #line hidden
            #line (106,63)-(106,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,64)-(106,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("on");
            #line hidden
            #line (106,66)-(106,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,67)-(106,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("the");
            #line hidden
            #line (106,70)-(106,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,71)-(106,83) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("command-line");
            #line hidden
            #line (106,83)-(106,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,84)-(106,93) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(/langver");
            #line hidden
            #line (106,93)-(106,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (106,94)-(106,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("flag).");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (107,9)-(107,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (107,12)-(107,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,13)-(107,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("For");
            #line hidden
            #line (107,16)-(107,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,17)-(107,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("instance,");
            #line hidden
            #line (107,26)-(107,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,27)-(107,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"6\",");
            #line hidden
            #line (107,31)-(107,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,32)-(107,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"7\",");
            #line hidden
            #line (107,36)-(107,37) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,37)-(107,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"7.1\",");
            #line hidden
            #line (107,43)-(107,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (107,44)-(107,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"latest\".");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (108,9)-(108,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (108,12)-(108,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (108,13)-(108,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (109,9)-(109,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (109,15)-(109,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,16)-(109,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (109,22)-(109,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,23)-(109,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("string");
            #line hidden
            #line (109,29)-(109,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,30)-(109,50) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("ToDisplayString(this");
            #line hidden
            #line (109,50)-(109,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,52)-(109,56) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (109,57)-(109,72) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (109,72)-(109,73) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (109,73)-(109,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (110,9)-(110,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (111,13)-(111,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (111,15)-(111,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (111,16)-(111,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(version");
            #line hidden
            #line (111,24)-(111,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (111,25)-(111,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (111,27)-(111,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (111,29)-(111,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (111,34)-(111,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Version1)");
            #line hidden
            #line (111,59)-(111,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (111,60)-(111,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (111,66)-(111,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (111,67)-(111,71) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"1\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (112,13)-(112,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (112,15)-(112,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (112,16)-(112,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(version");
            #line hidden
            #line (112,24)-(112,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (112,25)-(112,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (112,27)-(112,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (112,29)-(112,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (112,34)-(112,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Default)");
            #line hidden
            #line (112,58)-(112,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (112,59)-(112,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (112,65)-(112,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (112,66)-(112,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"default\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (113,13)-(113,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (113,15)-(113,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (113,16)-(113,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(version");
            #line hidden
            #line (113,24)-(113,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (113,25)-(113,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (113,27)-(113,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (113,29)-(113,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (113,34)-(113,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Latest)");
            #line hidden
            #line (113,57)-(113,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (113,58)-(113,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (113,64)-(113,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (113,65)-(113,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"latest\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (114,13)-(114,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (114,15)-(114,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,16)-(114,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(version");
            #line hidden
            #line (114,24)-(114,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,25)-(114,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (114,27)-(114,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,29)-(114,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (114,34)-(114,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.LatestMajor)");
            #line hidden
            #line (114,62)-(114,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,63)-(114,69) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (114,69)-(114,70) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (114,70)-(114,84) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"latestmajor\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (115,13)-(115,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (115,15)-(115,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (115,16)-(115,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(version");
            #line hidden
            #line (115,24)-(115,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (115,25)-(115,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (115,27)-(115,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (115,29)-(115,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (115,34)-(115,58) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Preview)");
            #line hidden
            #line (115,58)-(115,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (115,59)-(115,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (115,65)-(115,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (115,66)-(115,76) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"preview\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (116,13)-(116,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("throw");
            #line hidden
            #line (116,18)-(116,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (116,19)-(116,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("ExceptionUtilities.UnexpectedValue(version);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (117,9)-(117,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (119,9)-(119,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (119,12)-(119,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (119,13)-(119,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (120,9)-(120,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (120,12)-(120,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,13)-(120,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Try");
            #line hidden
            #line (120,16)-(120,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,17)-(120,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("parse");
            #line hidden
            #line (120,22)-(120,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,23)-(120,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("a");
            #line hidden
            #line (120,24)-(120,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,25)-(120,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<see");
            #line hidden
            #line (120,29)-(120,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,30)-(120,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("cref=\"");
            #line hidden
            #line (120,37)-(120,41) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (120,42)-(120,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion\"/>");
            #line hidden
            #line (120,60)-(120,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,61)-(120,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("from");
            #line hidden
            #line (120,65)-(120,66) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,66)-(120,67) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("a");
            #line hidden
            #line (120,67)-(120,68) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,68)-(120,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("string");
            #line hidden
            #line (120,74)-(120,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,75)-(120,81) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("input,");
            #line hidden
            #line (120,81)-(120,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,82)-(120,91) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("returning");
            #line hidden
            #line (120,91)-(120,92) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,92)-(120,99) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("default");
            #line hidden
            #line (120,99)-(120,100) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,100)-(120,102) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (120,102)-(120,103) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,103)-(120,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("input");
            #line hidden
            #line (120,108)-(120,109) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,109)-(120,112) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("was");
            #line hidden
            #line (120,112)-(120,113) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (120,113)-(120,118) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("null.");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (121,9)-(121,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (121,12)-(121,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (121,13)-(121,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (122,9)-(122,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (122,15)-(122,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (122,16)-(122,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (122,22)-(122,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (122,23)-(122,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("bool");
            #line hidden
            #line (122,27)-(122,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (122,28)-(122,43) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("TryParse(string");
            #line hidden
            #line (122,43)-(122,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (122,44)-(122,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version,");
            #line hidden
            #line (122,52)-(122,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (122,53)-(122,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("out");
            #line hidden
            #line (122,56)-(122,57) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (122,58)-(122,62) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (122,63)-(122,78) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (122,78)-(122,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (122,79)-(122,86) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (123,9)-(123,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (124,13)-(124,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("if");
            #line hidden
            #line (124,15)-(124,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (124,16)-(124,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(version");
            #line hidden
            #line (124,24)-(124,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (124,25)-(124,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("==");
            #line hidden
            #line (124,27)-(124,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (124,28)-(124,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (125,13)-(125,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (126,17)-(126,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result");
            #line hidden
            #line (126,23)-(126,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,24)-(126,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (126,25)-(126,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (126,27)-(126,31) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (126,32)-(126,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (127,17)-(127,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (127,23)-(127,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (127,24)-(127,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (128,13)-(128,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (129,13)-(129,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("switch");
            #line hidden
            #line (129,19)-(129,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (129,20)-(129,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(CaseInsensitiveComparison.ToLower(version))");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (130,13)-(130,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (131,17)-(131,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (131,21)-(131,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (131,22)-(131,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"default\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (132,21)-(132,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result");
            #line hidden
            #line (132,27)-(132,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (132,28)-(132,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (132,29)-(132,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (132,31)-(132,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (132,36)-(132,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (133,21)-(133,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (133,27)-(133,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (133,28)-(133,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (134,17)-(134,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (134,21)-(134,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (134,22)-(134,31) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"latest\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (135,21)-(135,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result");
            #line hidden
            #line (135,27)-(135,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (135,28)-(135,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (135,29)-(135,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (135,31)-(135,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (135,36)-(135,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Latest;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (136,21)-(136,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (136,27)-(136,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (136,28)-(136,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (137,17)-(137,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (137,21)-(137,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (137,22)-(137,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"latestmajor\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (138,21)-(138,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result");
            #line hidden
            #line (138,27)-(138,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (138,28)-(138,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (138,29)-(138,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (138,31)-(138,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (138,36)-(138,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.LatestMajor;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (139,21)-(139,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (139,27)-(139,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (139,28)-(139,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (140,17)-(140,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (140,21)-(140,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (140,22)-(140,32) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"preview\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (141,21)-(141,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result");
            #line hidden
            #line (141,27)-(141,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (141,28)-(141,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (141,29)-(141,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (141,31)-(141,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (141,36)-(141,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Preview;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (142,21)-(142,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (142,27)-(142,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (142,28)-(142,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (143,17)-(143,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (143,21)-(143,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (143,22)-(143,26) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"1\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (144,17)-(144,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (144,21)-(144,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (144,22)-(144,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("\"1.0\":");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (145,21)-(145,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result");
            #line hidden
            #line (145,27)-(145,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (145,28)-(145,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (145,29)-(145,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (145,31)-(145,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (145,36)-(145,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (146,21)-(146,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (146,27)-(146,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (146,28)-(146,33) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (147,17)-(147,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (148,21)-(148,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("result");
            #line hidden
            #line (148,27)-(148,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (148,28)-(148,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (148,29)-(148,30) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (148,31)-(148,35) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (148,36)-(148,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (149,21)-(149,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (149,27)-(149,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (149,28)-(149,34) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("false;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (150,13)-(150,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (151,9)-(151,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (153,9)-(153,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (153,12)-(153,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (153,13)-(153,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,9)-(154,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (154,12)-(154,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,13)-(154,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Map");
            #line hidden
            #line (154,16)-(154,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,17)-(154,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("a");
            #line hidden
            #line (154,18)-(154,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,19)-(154,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("language");
            #line hidden
            #line (154,27)-(154,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,28)-(154,35) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version");
            #line hidden
            #line (154,35)-(154,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,36)-(154,41) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(such");
            #line hidden
            #line (154,41)-(154,42) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,42)-(154,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("as");
            #line hidden
            #line (154,44)-(154,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,45)-(154,53) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Default,");
            #line hidden
            #line (154,53)-(154,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,54)-(154,61) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("Latest,");
            #line hidden
            #line (154,61)-(154,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,62)-(154,64) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("or");
            #line hidden
            #line (154,64)-(154,65) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,65)-(154,74) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("VersionN)");
            #line hidden
            #line (154,74)-(154,75) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,75)-(154,77) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("to");
            #line hidden
            #line (154,77)-(154,78) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,78)-(154,79) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("a");
            #line hidden
            #line (154,79)-(154,80) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,80)-(154,88) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("specific");
            #line hidden
            #line (154,88)-(154,89) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,89)-(154,96) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version");
            #line hidden
            #line (154,96)-(154,97) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (154,97)-(154,108) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(VersionM).");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (155,9)-(155,12) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("///");
            #line hidden
            #line (155,12)-(155,13) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (155,13)-(155,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (156,9)-(156,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("internal");
            #line hidden
            #line (156,17)-(156,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (156,18)-(156,24) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (156,24)-(156,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (156,26)-(156,30) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (156,31)-(156,46) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (156,46)-(156,47) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (156,47)-(156,82) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("MapSpecifiedToEffectiveVersion(this");
            #line hidden
            #line (156,82)-(156,83) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (156,84)-(156,88) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (156,89)-(156,104) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (156,104)-(156,105) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (156,105)-(156,113) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (157,9)-(157,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (158,13)-(158,19) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("switch");
            #line hidden
            #line (158,19)-(158,20) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (158,20)-(158,29) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("(version)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (159,13)-(159,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (160,17)-(160,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (160,21)-(160,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (160,23)-(160,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (160,28)-(160,51) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Latest:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (161,17)-(161,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (161,21)-(161,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (161,23)-(161,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (161,28)-(161,52) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (162,17)-(162,21) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("case");
            #line hidden
            #line (162,21)-(162,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (162,23)-(162,27) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (162,28)-(162,56) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.LatestMajor:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (163,21)-(163,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (163,27)-(163,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (163,29)-(163,33) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (163,34)-(163,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (164,17)-(164,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("default:");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (165,21)-(165,27) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("return");
            #line hidden
            #line (165,27)-(165,28) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (165,28)-(165,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("version;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (166,13)-(166,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (167,9)-(167,10) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (169,9)-(169,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("public");
            #line hidden
            #line (169,15)-(169,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (169,16)-(169,22) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("static");
            #line hidden
            #line (169,22)-(169,23) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (169,24)-(169,28) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (169,29)-(169,44) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion");
            #line hidden
            #line (169,44)-(169,45) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (169,45)-(169,59) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("CurrentVersion");
            #line hidden
            #line (169,59)-(169,60) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (169,60)-(169,62) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("=>");
            #line hidden
            #line (169,62)-(169,63) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (169,64)-(169,68) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write(Lang);
            #line hidden
            #line (169,69)-(169,94) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("LanguageVersion.Version1;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (170,5)-(170,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (172,1)-(172,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Bootstrap\MetaDslx.Bootstrap.MetaCompiler\Generators\LanguageGenerator.mgen"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}