#line (1,10)-(1,52) 10 "SymbolGenerator.mxg"
namespace MetaDslx.Languages.MetaSymbols.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,18) 13 "SymbolGenerator.mxg"
    System.Linq;
    #line hidden
    #line (4,1)-(4,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,43) 13 "SymbolGenerator.mxg"
    MetaDslx.Languages.MetaSymbols.Model;
    #line hidden
    
    #line (6,10)-(6,26) 25 "SymbolGenerator.mxg"
    public partial class SymbolGenerator
    #line hidden
    {
        #line (8,9)-(8,42) 22 "SymbolGenerator.mxg"
        public string GenerateInterface(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (9,1)-(9,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (9,10)-(9,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (9,12)-(9,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (10,1)-(10,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (11,5)-(11,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (11,11)-(11,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,12)-(11,21) 25 "SymbolGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (11,21)-(11,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,23)-(11,34) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Name);
            #line hidden
            var __first1 = true;
            foreach (var __item2 in 
            #line (11,36)-(11,95) 13 "SymbolGenerator.mxg"
            from bt in symbol.BaseTypes select GetIntfName(symbol, bt) 
            #line hidden
            )
            {
                if (__first1)
                {
                    __first1 = false;
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (11,102)-(11,107) 32 "SymbolGenerator.mxg"
                    __cb.Write(": " );
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (11,117)-(11,121) 32 "SymbolGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Write(__item2);
            }
            if (!__first1) __cb.AppendLine();
            __cb.Push("    ");
            #line (12,5)-(12,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first3 = true;
            #line (13,10)-(13,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.Push("        ");
                #line (14,14)-(14,44) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (14,45)-(14,46) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (14,47)-(14,56) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (14,57)-(14,58) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (14,58)-(14,59) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (14,59)-(14,60) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (14,60)-(14,64) 29 "SymbolGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (14,64)-(14,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (14,65)-(14,66) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (17,9)-(17,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (17,15)-(17,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,16)-(17,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (17,22)-(17,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,23)-(17,28) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (17,28)-(17,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,29)-(17,44) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (18,9)-(18,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first4 = true;
            #line (19,14)-(19,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                __cb.Push("            ");
                #line (20,17)-(20,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (20,23)-(20,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (20,24)-(20,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (20,30)-(20,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (20,31)-(20,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (20,39)-(20,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (20,40)-(20,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (20,54)-(20,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (20,55)-(20,61) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (20,62)-(20,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (20,68)-(20,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (20,69)-(20,70) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (20,70)-(20,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (20,71)-(20,74) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (20,74)-(20,75) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (20,75)-(20,103) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Start_");
                #line hidden
                #line (20,104)-(20,109) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (20,110)-(20,113) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (21,17)-(21,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (21,23)-(21,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,24)-(21,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (21,30)-(21,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,31)-(21,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (21,39)-(21,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,40)-(21,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (21,54)-(21,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,55)-(21,62) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (21,63)-(21,68) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (21,69)-(21,70) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,70)-(21,71) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (21,71)-(21,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,72)-(21,75) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (21,75)-(21,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,76)-(21,105) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Finish_");
                #line hidden
                #line (21,106)-(21,111) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (21,112)-(21,115) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.Push("            ");
            #line (23,13)-(23,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (23,19)-(23,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,20)-(23,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (23,26)-(23,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,27)-(23,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (23,35)-(23,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,36)-(23,51) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (23,51)-(23,52) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,52)-(23,67) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (23,67)-(23,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,68)-(23,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,69)-(23,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (24,17)-(24,49) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first5 = true;
            #line (25,22)-(25,63) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol)) 
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                else
                {
                    __cb.Push("                    ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (25,73)-(25,78) 32 "SymbolGenerator.mxg"
                    __cb.Write(",\n");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("                    ");
                #line (26,25)-(26,31) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (26,32)-(26,37) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (26,38)-(26,39) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (26,39)-(26,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (26,40)-(26,47) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (26,48)-(26,53) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("                ");
            #line (28,17)-(28,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,9)-(29,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (30,5)-(30,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (31,1)-(31,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (34,9)-(34,37) 22 "SymbolGenerator.mxg"
        public string GenerateBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (35,1)-(35,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (35,10)-(35,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,12)-(35,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (36,1)-(36,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (37,5)-(37,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (37,10)-(37,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,11)-(37,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (37,20)-(37,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,21)-(37,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (37,22)-(37,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,23)-(37,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (38,5)-(38,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (38,10)-(38,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,11)-(38,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (38,25)-(38,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,26)-(38,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (38,27)-(38,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,28)-(38,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (39,5)-(39,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (39,10)-(39,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,11)-(39,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (39,30)-(39,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,31)-(39,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (39,32)-(39,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,33)-(39,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (40,5)-(40,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (40,10)-(40,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,11)-(40,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (40,19)-(40,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,20)-(40,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (40,21)-(40,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,22)-(40,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (41,5)-(41,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (41,10)-(41,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,11)-(41,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (41,28)-(41,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,29)-(41,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (41,30)-(41,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,31)-(41,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (42,5)-(42,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (42,10)-(42,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,11)-(42,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (42,26)-(42,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,27)-(42,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (42,28)-(42,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,29)-(42,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (43,5)-(43,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (43,10)-(43,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,11)-(43,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (43,28)-(43,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,29)-(43,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (43,30)-(43,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,31)-(43,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (44,5)-(44,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (44,10)-(44,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,11)-(44,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (44,27)-(44,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,28)-(44,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (44,29)-(44,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,30)-(44,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (45,5)-(45,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (45,10)-(45,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,11)-(45,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (45,26)-(45,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,27)-(45,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (45,28)-(45,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,29)-(45,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (46,5)-(46,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (46,10)-(46,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,11)-(46,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (46,27)-(46,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,28)-(46,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (46,29)-(46,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,30)-(46,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (47,5)-(47,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (47,10)-(47,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,11)-(47,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (47,30)-(47,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,31)-(47,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (47,32)-(47,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,33)-(47,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,5)-(49,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (49,13)-(49,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,14)-(49,22) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (49,22)-(49,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,23)-(49,28) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (49,28)-(49,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,30)-(49,57) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (49,58)-(49,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,59)-(49,60) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (49,60)-(49,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,61)-(49,115) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.MultiSymbolBase,");
            #line hidden
            #line (49,115)-(49,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,117)-(49,128) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,5)-(50,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first6 = true;
            #line (51,10)-(51,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("        ");
                #line (52,13)-(52,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (52,20)-(52,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,22)-(52,48) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, prop));
                #line hidden
                #line (52,49)-(52,50) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (52,51)-(52,69) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (52,70)-(52,71) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (55,9)-(55,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (55,18)-(55,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,20)-(55,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (55,48)-(55,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (55,57)-(55,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,58)-(55,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (55,68)-(55,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,69)-(55,88) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (55,88)-(55,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,89)-(55,101) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (55,101)-(55,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,102)-(55,116) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (55,116)-(55,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,117)-(55,129) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (55,129)-(55,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (56,13)-(56,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (56,14)-(56,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,15)-(56,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (56,30)-(56,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,31)-(56,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (56,43)-(56,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,44)-(56,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (57,9)-(57,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (58,9)-(58,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (60,9)-(60,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (60,18)-(60,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,20)-(60,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (60,48)-(60,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (60,57)-(60,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,58)-(60,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (60,68)-(60,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,69)-(60,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (60,83)-(60,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,84)-(60,96) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (60,96)-(60,97) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (61,13)-(61,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (61,14)-(61,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,15)-(61,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (61,30)-(61,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,31)-(61,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (62,9)-(62,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (63,9)-(63,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (65,9)-(65,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (65,18)-(65,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,20)-(65,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (65,48)-(65,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (65,57)-(65,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,58)-(65,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (65,68)-(65,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,69)-(65,78) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (65,78)-(65,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,79)-(65,92) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (65,92)-(65,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (66,13)-(66,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (66,14)-(66,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,15)-(66,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (66,30)-(66,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,31)-(66,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (67,9)-(67,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (68,9)-(68,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,9)-(70,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (70,18)-(70,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,20)-(70,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (70,48)-(70,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (70,57)-(70,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,58)-(70,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (70,68)-(70,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,69)-(70,86) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (70,86)-(70,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,87)-(70,97) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (70,97)-(70,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (71,13)-(71,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (71,14)-(71,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,15)-(71,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (71,30)-(71,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,31)-(71,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,9)-(72,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (73,9)-(73,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (75,9)-(75,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (75,18)-(75,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,19)-(75,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (75,27)-(75,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,28)-(75,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (75,45)-(75,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,46)-(75,61) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (75,61)-(75,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,62)-(75,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (75,64)-(75,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,66)-(75,77) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.Name);
            #line hidden
            #line (75,78)-(75,111) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first7 = true;
            #line (77,10)-(77,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                __cb.Push("        ");
                #line (78,14)-(78,17) 28 "SymbolGenerator.mxg"
                __cb.Write("[");
                #line hidden
                #line (78,18)-(78,33) 29 "SymbolGenerator.mxg"
                __cb.Write("__ModelProperty");
                #line hidden
                #line (78,34)-(78,37) 28 "SymbolGenerator.mxg"
                __cb.Write("]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (79,13)-(79,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (79,19)-(79,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (79,21)-(79,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (79,52)-(79,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (79,54)-(79,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (80,13)-(80,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (81,17)-(81,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (82,17)-(82,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (83,21)-(83,63) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(CompletionGraph.Finish_");
                #line hidden
                #line (83,64)-(83,73) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (83,74)-(83,75) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (83,75)-(83,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (83,76)-(83,81) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (83,81)-(83,82) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (83,82)-(83,91) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first8 = true;
                #line (84,22)-(84,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("                ");
                    #line (85,25)-(85,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (85,27)-(85,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,28)-(85,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (85,30)-(85,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (85,49)-(85,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (85,67)-(85,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,68)-(85,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (85,71)-(85,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,72)-(85,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (85,75)-(85,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,76)-(85,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (85,84)-(85,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,85)-(85,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (85,91)-(85,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,92)-(85,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (85,94)-(85,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (85,125)-(85,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (86,25)-(86,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (86,29)-(86,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (86,30)-(86,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (86,36)-(86,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (86,38)-(86,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (86,68)-(86,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (87,22)-(87,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("                ");
                    #line (88,25)-(88,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (88,31)-(88,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,33)-(88,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (88,52)-(88,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
                __cb.Push("            ");
                #line (90,17)-(90,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (91,13)-(91,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first7) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (94,9)-(94,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (94,18)-(94,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,19)-(94,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (94,27)-(94,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,28)-(94,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (94,32)-(94,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,33)-(94,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (94,54)-(94,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,55)-(94,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (94,71)-(94,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,72)-(94,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (94,87)-(94,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,88)-(94,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (94,105)-(94,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,106)-(94,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (94,118)-(94,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,119)-(94,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (94,138)-(94,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,139)-(94,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (95,9)-(95,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (96,14)-(96,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                #line (97,18)-(97,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (98,17)-(98,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (98,19)-(98,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (98,20)-(98,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (98,35)-(98,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (98,36)-(98,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (98,38)-(98,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (98,40)-(98,51) 28 "SymbolGenerator.mxg"
                __cb.Write(symbol.Name);
                #line hidden
                #line (98,52)-(98,75) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (98,76)-(98,81) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (98,82)-(98,83) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (98,83)-(98,85) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (98,85)-(98,86) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (98,86)-(98,100) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (98,100)-(98,101) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (98,101)-(98,103) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (98,103)-(98,104) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (98,105)-(98,116) 28 "SymbolGenerator.mxg"
                __cb.Write(symbol.Name);
                #line hidden
                #line (98,117)-(98,141) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (98,142)-(98,147) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (98,148)-(98,149) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (99,17)-(99,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (100,21)-(100,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (100,23)-(100,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (100,24)-(100,42) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(");
                #line hidden
                #line (100,43)-(100,54) 28 "SymbolGenerator.mxg"
                __cb.Write(symbol.Name);
                #line hidden
                #line (100,55)-(100,78) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (100,79)-(100,84) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (100,85)-(100,87) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (101,21)-(101,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (102,25)-(102,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (102,28)-(102,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (102,29)-(102,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (102,40)-(102,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (102,41)-(102,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (102,42)-(102,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (102,43)-(102,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first10 = true;
                #line (103,26)-(103,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("                    ");
                    #line (104,29)-(104,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (104,32)-(104,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (104,33)-(104,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (104,39)-(104,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (104,40)-(104,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (104,41)-(104,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (104,42)-(104,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (104,52)-(104,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (104,58)-(104,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (104,71)-(104,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (104,72)-(104,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first11 = true;
                    #line (105,30)-(105,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        var __first12 = true;
                        #line (106,34)-(106,50) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first12)
                            {
                                __first12 = false;
                            }
                            var __first13 = true;
                            #line (107,38)-(107,67) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first13)
                                {
                                    __first13 = false;
                                }
                                __cb.Push("                    ");
                                #line (108,41)-(108,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (108,43)-(108,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (108,44)-(108,53) 45 "SymbolGenerator.mxg"
                                __cb.Write("(!result.");
                                #line hidden
                                #line (108,54)-(108,63) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (108,64)-(108,82) 45 "SymbolGenerator.mxg"
                                __cb.Write(".IsDefaultOrEmpty)");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (109,41)-(109,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (110,46)-(110,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (110,65)-(110,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (110,75)-(110,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (110,76)-(110,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (110,84)-(110,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (110,94)-(110,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (111,41)-(111,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            #line (112,38)-(112,42) 29 "SymbolGenerator.mxg"
                            else
                            #line hidden
                            
                            {
                                if (__first13)
                                {
                                    __first13 = false;
                                }
                                __cb.Push("                    ");
                                #line (113,41)-(113,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (113,43)-(113,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (113,44)-(113,52) 45 "SymbolGenerator.mxg"
                                __cb.Write("(result.");
                                #line hidden
                                #line (113,53)-(113,62) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (113,63)-(113,64) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (113,64)-(113,66) 45 "SymbolGenerator.mxg"
                                __cb.Write("!=");
                                #line hidden
                                #line (113,66)-(113,67) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (113,68)-(113,97) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetDefaultValue(symbol, prop));
                                #line hidden
                                #line (113,98)-(113,99) 45 "SymbolGenerator.mxg"
                                __cb.Write(")");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (114,41)-(114,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (115,46)-(115,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (115,65)-(115,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (115,75)-(115,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (115,76)-(115,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (115,84)-(115,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (115,94)-(115,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (116,41)-(116,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first13) __cb.AppendLine();
                        }
                        #line (118,34)-(118,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first12)
                            {
                                __first12 = false;
                            }
                            __cb.Push("                    ");
                            #line (119,38)-(119,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (119,57)-(119,58) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,58)-(119,59) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (119,59)-(119,60) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,60)-(119,67) 41 "SymbolGenerator.mxg"
                            __cb.Write("result.");
                            #line hidden
                            #line (119,68)-(119,77) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (119,78)-(119,79) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first12) __cb.AppendLine();
                    }
                    if (!__first11) __cb.AppendLine();
                }
                #line (122,26)-(122,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    #line (123,30)-(123,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first14 = true;
                    #line (124,30)-(124,46) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first14)
                        {
                            __first14 = false;
                        }
                        var __first15 = true;
                        #line (125,34)-(125,63) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first15)
                            {
                                __first15 = false;
                            }
                            __cb.Push("                    ");
                            #line (126,37)-(126,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (126,39)-(126,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (126,40)-(126,66) 41 "SymbolGenerator.mxg"
                            __cb.Write("(!result.IsDefaultOrEmpty)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (127,37)-(127,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (128,42)-(128,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (128,61)-(128,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (128,71)-(128,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (128,72)-(128,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (129,37)-(129,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (130,34)-(130,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first15)
                            {
                                __first15 = false;
                            }
                            __cb.Push("                    ");
                            #line (131,37)-(131,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (131,39)-(131,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (131,40)-(131,47) 41 "SymbolGenerator.mxg"
                            __cb.Write("(result");
                            #line hidden
                            #line (131,47)-(131,48) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (131,48)-(131,50) 41 "SymbolGenerator.mxg"
                            __cb.Write("!=");
                            #line hidden
                            #line (131,50)-(131,51) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (131,52)-(131,81) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (131,82)-(131,83) 41 "SymbolGenerator.mxg"
                            __cb.Write(")");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (132,37)-(132,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (133,42)-(133,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (133,61)-(133,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (133,71)-(133,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (133,72)-(133,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (134,37)-(134,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first15) __cb.AppendLine();
                    }
                    #line (136,30)-(136,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first14)
                        {
                            __first14 = false;
                        }
                        __cb.Push("                    ");
                        #line (137,34)-(137,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (137,53)-(137,54) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (137,54)-(137,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (137,55)-(137,56) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (137,56)-(137,63) 37 "SymbolGenerator.mxg"
                        __cb.Write("result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first14) __cb.AppendLine();
                }
                #line (139,26)-(139,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("                    ");
                    #line (140,29)-(140,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (140,39)-(140,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (140,45)-(140,58) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (140,58)-(140,59) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (140,59)-(140,78) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                __cb.Push("                    ");
                #line (142,25)-(142,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (143,25)-(143,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (144,25)-(144,42) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(");
                #line hidden
                #line (144,43)-(144,54) 28 "SymbolGenerator.mxg"
                __cb.Write(symbol.Name);
                #line hidden
                #line (144,55)-(144,79) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (144,80)-(144,85) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (144,86)-(144,88) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (145,21)-(145,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (146,21)-(146,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (146,27)-(146,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (146,28)-(146,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (147,17)-(147,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (148,17)-(148,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (148,21)-(148,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("            ");
            #line (150,13)-(150,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (150,19)-(150,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,20)-(150,46) 25 "SymbolGenerator.mxg"
            __cb.Write("base.ForceCompletePart(ref");
            #line hidden
            #line (150,46)-(150,47) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,47)-(150,62) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (150,62)-(150,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,63)-(150,75) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (150,75)-(150,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,76)-(150,95) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (151,9)-(151,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first16 = true;
            #line (153,10)-(153,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                #line (154,14)-(154,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first17 = true;
                #line (155,14)-(155,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    var __first18 = true;
                    #line (156,18)-(156,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        __cb.Push("        ");
                        #line (157,21)-(157,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (157,30)-(157,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,31)-(157,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (157,39)-(157,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,40)-(157,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first19 = true;
                        foreach (var __item20 in 
                        #line (157,42)-(157,99) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (157,109)-(157,113) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item20);
                        }
                        #line (157,114)-(157,115) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (157,115)-(157,116) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,116)-(157,125) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (157,126)-(157,131) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (157,132)-(157,148) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (157,148)-(157,149) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,149)-(157,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (157,161)-(157,162) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,162)-(157,181) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (157,181)-(157,182) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (157,182)-(157,201) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (158,18)-(158,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first18)
                        {
                            __first18 = false;
                        }
                        __cb.Push("        ");
                        #line (159,21)-(159,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (159,30)-(159,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,31)-(159,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (159,38)-(159,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,39)-(159,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first21 = true;
                        foreach (var __item22 in 
                        #line (159,41)-(159,98) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first21)
                            {
                                __first21 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (159,108)-(159,112) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item22);
                        }
                        #line (159,113)-(159,114) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (159,114)-(159,115) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,115)-(159,124) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (159,125)-(159,130) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (159,131)-(159,147) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (159,147)-(159,148) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,148)-(159,160) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (159,160)-(159,161) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,161)-(159,180) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (159,180)-(159,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (159,181)-(159,199) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (160,21)-(160,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (161,25)-(161,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (161,31)-(161,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (161,32)-(161,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first23 = true;
                        foreach (var __item24 in 
                        #line (161,34)-(161,90) 25 "SymbolGenerator.mxg"
                        from prop in props select GetDefaultValue(symbol, prop) 
                        #line hidden
                        )
                        {
                            if (__first23)
                            {
                                __first23 = false;
                            }
                            else
                            {
                                __cb.Push("            ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (161,100)-(161,104) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item24);
                        }
                        #line (161,105)-(161,107) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (162,21)-(162,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first18) __cb.AppendLine();
                }
                #line (164,14)-(164,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    #line (165,18)-(165,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first25 = true;
                    #line (166,18)-(166,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("        ");
                        #line (167,21)-(167,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (167,30)-(167,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,31)-(167,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (167,39)-(167,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,41)-(167,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (167,72)-(167,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,73)-(167,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (167,83)-(167,88) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (167,89)-(167,105) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (167,105)-(167,106) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,106)-(167,118) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (167,118)-(167,119) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,119)-(167,138) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (167,138)-(167,139) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,139)-(167,158) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (168,18)-(168,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("        ");
                        #line (169,21)-(169,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (169,30)-(169,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,31)-(169,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (169,38)-(169,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,40)-(169,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (169,71)-(169,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,72)-(169,81) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (169,82)-(169,87) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (169,88)-(169,104) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (169,104)-(169,105) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,105)-(169,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (169,117)-(169,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,118)-(169,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (169,137)-(169,138) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,138)-(169,156) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (170,21)-(170,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (171,25)-(171,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (171,31)-(171,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (171,33)-(171,62) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (171,63)-(171,64) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (172,21)-(172,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first25) __cb.AppendLine();
                }
                #line (174,14)-(174,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first17)
                    {
                        __first17 = false;
                    }
                    __cb.Push("        ");
                    #line (175,17)-(175,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (175,26)-(175,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,27)-(175,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (175,35)-(175,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,36)-(175,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (175,40)-(175,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,41)-(175,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (175,51)-(175,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (175,57)-(175,73) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (175,73)-(175,74) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,74)-(175,86) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (175,86)-(175,87) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,87)-(175,106) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (175,106)-(175,107) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (175,107)-(175,126) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first17) __cb.AppendLine();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("    ");
            #line (178,5)-(178,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (179,1)-(179,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (182,9)-(182,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (183,1)-(183,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (183,6)-(183,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (183,7)-(183,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (184,1)-(184,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (184,6)-(184,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,7)-(184,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (185,1)-(185,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (185,6)-(185,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (185,7)-(185,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (187,1)-(187,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (187,10)-(187,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,12)-(187,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (188,1)-(188,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (189,5)-(189,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (189,13)-(189,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,14)-(189,19) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (189,19)-(189,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,21)-(189,48) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (189,49)-(189,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,50)-(189,51) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (189,51)-(189,52) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,53)-(189,80) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (190,5)-(190,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (191,9)-(191,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (191,18)-(191,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,20)-(191,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (191,48)-(191,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (191,55)-(191,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,56)-(191,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (191,66)-(191,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,67)-(191,84) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration");
            #line hidden
            #line (191,84)-(191,85) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,85)-(191,97) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (191,97)-(191,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,98)-(191,110) 25 "SymbolGenerator.mxg"
            __cb.Write("IModelObject");
            #line hidden
            #line (191,110)-(191,111) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,111)-(191,123) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (191,123)-(191,124) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (192,13)-(192,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (192,14)-(192,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,15)-(192,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (192,30)-(192,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,31)-(192,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (192,43)-(192,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,44)-(192,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (193,9)-(193,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (194,9)-(194,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (196,9)-(196,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (196,18)-(196,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,20)-(196,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (196,48)-(196,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (196,55)-(196,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,56)-(196,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (196,66)-(196,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,67)-(196,79) 25 "SymbolGenerator.mxg"
            __cb.Write("IModelObject");
            #line hidden
            #line (196,79)-(196,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,80)-(196,92) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (196,92)-(196,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (197,13)-(197,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (197,14)-(197,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,15)-(197,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (197,30)-(197,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,31)-(197,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (198,9)-(198,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (199,9)-(199,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (201,9)-(201,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (201,18)-(201,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,20)-(201,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (201,48)-(201,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (201,55)-(201,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,56)-(201,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (201,66)-(201,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,67)-(201,97) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol");
            #line hidden
            #line (201,97)-(201,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,98)-(201,111) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (201,111)-(201,112) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (202,13)-(202,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (202,14)-(202,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,15)-(202,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (202,30)-(202,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,31)-(202,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (203,9)-(203,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (204,9)-(204,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (206,9)-(206,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (206,18)-(206,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,20)-(206,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (206,48)-(206,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (206,55)-(206,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,56)-(206,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (206,66)-(206,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,67)-(206,82) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo");
            #line hidden
            #line (206,82)-(206,83) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,83)-(206,93) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (206,93)-(206,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (207,13)-(207,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (207,14)-(207,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,15)-(207,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (207,30)-(207,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,31)-(207,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (208,9)-(208,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (209,9)-(209,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (211,5)-(211,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (212,1)-(212,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}