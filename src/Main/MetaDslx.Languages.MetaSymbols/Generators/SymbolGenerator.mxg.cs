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
            __cb.Push("    ");
            #line (11,5)-(11,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (11,10)-(11,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,11)-(11,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (11,26)-(11,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,27)-(11,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (11,28)-(11,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,29)-(11,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (13,6)-(13,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (14,5)-(14,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (14,11)-(14,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,12)-(14,21) 25 "SymbolGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (14,21)-(14,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,23)-(14,50) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (14,51)-(14,52) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (14,52)-(14,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first1 = true;
            #line (14,54)-(14,79) 13 "SymbolGenerator.mxg"
            if (baseTypes.Count == 0)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                #line (14,80)-(14,124) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol");
                #line hidden
            }
            #line (14,125)-(14,129) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                var __first2 = true;
                foreach (var __item3 in 
                #line (14,131)-(14,183) 17 "SymbolGenerator.mxg"
                from bt in baseTypes select GetIntfName(symbol, bt) 
                #line hidden
                )
                {
                    if (__first2)
                    {
                        __first2 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (14,193)-(14,197) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item3);
                }
            }
            if (!__first1) __cb.AppendLine();
            __cb.Push("    ");
            #line (15,5)-(15,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first4 = true;
            #line (16,10)-(16,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                __cb.Push("        ");
                #line (17,14)-(17,17) 28 "SymbolGenerator.mxg"
                __cb.Write("[");
                #line hidden
                #line (17,18)-(17,33) 29 "SymbolGenerator.mxg"
                __cb.Write("__ModelProperty");
                #line hidden
                #line (17,34)-(17,37) 28 "SymbolGenerator.mxg"
                __cb.Write("]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (18,14)-(18,44) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (18,45)-(18,46) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (18,47)-(18,56) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (18,57)-(18,58) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (18,58)-(18,59) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (18,59)-(18,60) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (18,60)-(18,64) 29 "SymbolGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (18,64)-(18,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (18,65)-(18,66) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (21,9)-(21,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (21,15)-(21,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,16)-(21,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (21,22)-(21,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,23)-(21,26) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (21,26)-(21,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,27)-(21,32) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (21,32)-(21,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,33)-(21,48) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (22,9)-(22,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first5 = true;
            #line (23,14)-(23,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("            ");
                #line (24,17)-(24,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (24,23)-(24,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (24,24)-(24,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (24,30)-(24,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (24,31)-(24,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (24,39)-(24,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (24,40)-(24,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (24,54)-(24,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (24,55)-(24,61) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (24,62)-(24,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (24,68)-(24,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (24,69)-(24,70) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (24,70)-(24,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (24,71)-(24,74) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (24,74)-(24,75) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (24,75)-(24,103) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Start_");
                #line hidden
                #line (24,104)-(24,109) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (24,110)-(24,113) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (25,17)-(25,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (25,23)-(25,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,24)-(25,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (25,30)-(25,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,31)-(25,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (25,39)-(25,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,40)-(25,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (25,54)-(25,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,55)-(25,62) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (25,63)-(25,68) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (25,69)-(25,70) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,70)-(25,71) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (25,71)-(25,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,72)-(25,75) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (25,75)-(25,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,76)-(25,105) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Finish_");
                #line hidden
                #line (25,106)-(25,111) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (25,112)-(25,115) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("            ");
            #line (27,13)-(27,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (27,19)-(27,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,20)-(27,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (27,26)-(27,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,27)-(27,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (27,35)-(27,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,36)-(27,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (27,50)-(27,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,51)-(27,66) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attribute");
            #line hidden
            #line (27,66)-(27,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,67)-(27,68) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,68)-(27,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,69)-(27,72) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (27,72)-(27,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,73)-(27,113) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Start_Attribute));");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (28,13)-(28,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (28,19)-(28,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,20)-(28,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (28,26)-(28,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,27)-(28,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (28,35)-(28,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,36)-(28,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (28,50)-(28,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,51)-(28,67) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attribute");
            #line hidden
            #line (28,67)-(28,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,68)-(28,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,69)-(28,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,70)-(28,73) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (28,73)-(28,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,74)-(28,115) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Finish_Attribute));");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (30,13)-(30,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (30,19)-(30,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,20)-(30,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (30,26)-(30,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,27)-(30,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (30,35)-(30,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,36)-(30,51) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (30,51)-(30,52) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,52)-(30,67) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (30,67)-(30,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,68)-(30,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,69)-(30,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (31,17)-(31,49) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first6 = true;
            #line (32,22)-(32,62) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("                    ");
                #line (33,25)-(33,31) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (33,32)-(33,37) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (33,38)-(33,39) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (33,39)-(33,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (33,40)-(33,47) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (33,48)-(33,53) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (33,54)-(33,55) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.Push("                    ");
            #line (35,21)-(35,37) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attribute,");
            #line hidden
            #line (35,37)-(35,38) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,38)-(35,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attribute");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (36,17)-(36,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (37,9)-(37,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (38,5)-(38,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (39,1)-(39,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (42,9)-(42,37) 22 "SymbolGenerator.mxg"
        public string GenerateBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first7 = true;
            #line (43,6)-(43,38) 13 "SymbolGenerator.mxg"
            if (symbol.BaseTypes.Count == 0)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                __cb.Push("");
                #line (44,10)-(44,42) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateSingleBase(symbol, null));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (45,6)-(45,43) 13 "SymbolGenerator.mxg"
            else if (symbol.BaseTypes.Count == 1)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                __cb.Push("");
                #line (46,10)-(46,57) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateSingleBase(symbol, symbol.BaseTypes[0]));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (47,6)-(47,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                __cb.Push("");
                #line (48,10)-(48,35) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateMultiBase(symbol));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first7) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (52,9)-(52,63) 22 "SymbolGenerator.mxg"
        public string GenerateSingleBase(Symbol symbol, Symbol? baseSymbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (53,1)-(53,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (53,10)-(53,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,12)-(53,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (53,33)-(53,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (54,1)-(54,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (55,5)-(55,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (55,10)-(55,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,11)-(55,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (55,20)-(55,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,21)-(55,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (55,22)-(55,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,23)-(55,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (56,5)-(56,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (56,10)-(56,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,11)-(56,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (56,19)-(56,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,20)-(56,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (56,21)-(56,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,22)-(56,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (57,5)-(57,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (57,10)-(57,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,11)-(57,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (57,28)-(57,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,29)-(57,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (57,30)-(57,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,31)-(57,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (58,5)-(58,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (58,10)-(58,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,11)-(58,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol");
            #line hidden
            #line (58,27)-(58,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,28)-(58,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (58,29)-(58,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,30)-(58,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (59,5)-(59,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (59,10)-(59,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,11)-(59,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (59,25)-(59,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,26)-(59,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (59,27)-(59,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,28)-(59,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (60,5)-(60,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (60,10)-(60,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,11)-(60,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (60,30)-(60,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,31)-(60,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (60,32)-(60,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,33)-(60,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (61,5)-(61,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (61,10)-(61,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,11)-(61,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol");
            #line hidden
            #line (61,28)-(61,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,29)-(61,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (61,30)-(61,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,31)-(61,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (62,5)-(62,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (62,10)-(62,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,11)-(62,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (62,23)-(62,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,24)-(62,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (62,25)-(62,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,26)-(62,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (63,5)-(63,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (63,10)-(63,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,11)-(63,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (63,27)-(63,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,28)-(63,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (63,29)-(63,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,30)-(63,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (64,5)-(64,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (64,10)-(64,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,11)-(64,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (64,27)-(64,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,28)-(64,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (64,29)-(64,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,30)-(64,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (65,5)-(65,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (65,10)-(65,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,11)-(65,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (65,25)-(65,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,26)-(65,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (65,27)-(65,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,28)-(65,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (66,5)-(66,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (66,10)-(66,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,11)-(66,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (66,28)-(66,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,29)-(66,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (66,30)-(66,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,31)-(66,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (67,5)-(67,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (67,10)-(67,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,11)-(67,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (67,26)-(67,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,27)-(67,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,28)-(67,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,29)-(67,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (68,5)-(68,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (68,10)-(68,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,11)-(68,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (68,28)-(68,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,29)-(68,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (68,30)-(68,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,31)-(68,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (69,5)-(69,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (69,10)-(69,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,11)-(69,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (69,27)-(69,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,28)-(69,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (69,29)-(69,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,30)-(69,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (70,5)-(70,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (70,10)-(70,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,11)-(70,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (70,30)-(70,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,31)-(70,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,32)-(70,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,33)-(70,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (71,5)-(71,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (71,10)-(71,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,11)-(71,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (71,26)-(71,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,27)-(71,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (71,28)-(71,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,29)-(71,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (72,5)-(72,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (72,10)-(72,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,11)-(72,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (72,24)-(72,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,25)-(72,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (72,26)-(72,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,27)-(72,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (73,5)-(73,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (73,10)-(73,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,11)-(73,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (73,27)-(73,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,28)-(73,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,29)-(73,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,30)-(73,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (74,5)-(74,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (74,10)-(74,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,11)-(74,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (74,30)-(74,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,31)-(74,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,32)-(74,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,33)-(74,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (75,5)-(75,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (75,10)-(75,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,11)-(75,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__IObjectPool");
            #line hidden
            #line (75,24)-(75,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,25)-(75,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (75,26)-(75,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,27)-(75,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.PooledObjects.IObjectPool;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (76,5)-(76,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (76,10)-(76,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,11)-(76,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (76,23)-(76,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,24)-(76,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,25)-(76,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,26)-(76,81) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<");
            #line hidden
            #line (76,82)-(76,109) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (76,110)-(76,112) 25 "SymbolGenerator.mxg"
            __cb.Write(">;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (77,5)-(77,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (77,10)-(77,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,11)-(77,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (77,36)-(77,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,37)-(77,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (77,38)-(77,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,39)-(77,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (78,5)-(78,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (78,10)-(78,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,11)-(78,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (78,24)-(78,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,25)-(78,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (78,26)-(78,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,27)-(78,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (79,5)-(79,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (79,10)-(79,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,11)-(79,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (79,38)-(79,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,39)-(79,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (79,40)-(79,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,41)-(79,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (81,5)-(81,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (81,11)-(81,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,12)-(81,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (81,19)-(81,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,20)-(81,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (81,25)-(81,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,27)-(81,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (81,55)-(81,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,56)-(81,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (81,57)-(81,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first8 = true;
            #line (81,59)-(81,82) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (81,83)-(81,131) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst");
                #line hidden
            }
            #line (81,132)-(81,136) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (81,138)-(81,169) 28 "SymbolGenerator.mxg"
                __cb.Write(GetInstName(symbol, baseSymbol));
                #line hidden
            }
            #line (81,178)-(81,179) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (81,179)-(81,180) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,181)-(81,208) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (82,5)-(82,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (83,10)-(83,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                var __first10 = true;
                #line (84,14)-(84,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (85,17)-(85,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (85,24)-(85,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,25)-(85,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (85,31)-(85,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,33)-(85,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (85,60)-(85,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,62)-(85,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (85,81)-(85,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,82)-(85,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (85,83)-(85,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,84)-(85,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (85,87)-(85,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,89)-(85,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (85,116)-(85,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (86,14)-(86,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (87,17)-(87,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (87,24)-(87,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (87,26)-(87,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (87,53)-(87,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (87,55)-(87,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (87,74)-(87,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
            }
            if (!__first9) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (91,9)-(91,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (91,15)-(91,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,17)-(91,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (91,45)-(91,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (91,54)-(91,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,55)-(91,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (91,65)-(91,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,66)-(91,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (91,85)-(91,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,86)-(91,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (91,98)-(91,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,99)-(91,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (91,113)-(91,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,114)-(91,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (91,126)-(91,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (92,13)-(92,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (92,14)-(92,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,15)-(92,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (92,30)-(92,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,31)-(92,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (92,43)-(92,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,44)-(92,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (93,9)-(93,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (94,9)-(94,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (96,9)-(96,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (96,15)-(96,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,17)-(96,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (96,45)-(96,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (96,54)-(96,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,55)-(96,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (96,65)-(96,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,66)-(96,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (96,80)-(96,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,81)-(96,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (96,93)-(96,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (97,13)-(97,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (97,14)-(97,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,15)-(97,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (97,30)-(97,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,31)-(97,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (98,9)-(98,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (99,9)-(99,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (101,9)-(101,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (101,15)-(101,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,17)-(101,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (101,45)-(101,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (101,54)-(101,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,55)-(101,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (101,65)-(101,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,66)-(101,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (101,75)-(101,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,76)-(101,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (101,89)-(101,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (102,13)-(102,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (102,14)-(102,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,15)-(102,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (102,30)-(102,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,31)-(102,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (103,9)-(103,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (104,9)-(104,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (106,9)-(106,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (106,15)-(106,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,17)-(106,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (106,45)-(106,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (106,54)-(106,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,55)-(106,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (106,65)-(106,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,66)-(106,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (106,83)-(106,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,84)-(106,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (106,94)-(106,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (107,13)-(107,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (107,14)-(107,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,15)-(107,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (107,30)-(107,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,31)-(107,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (108,9)-(108,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (109,9)-(109,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (111,9)-(111,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (111,15)-(111,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,17)-(111,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (111,45)-(111,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (111,54)-(111,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,55)-(111,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (111,65)-(111,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,66)-(111,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (111,85)-(111,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,86)-(111,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (111,98)-(111,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,99)-(111,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (111,113)-(111,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,114)-(111,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (111,126)-(111,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,127)-(111,134) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (111,134)-(111,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,135)-(111,140) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (111,140)-(111,141) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,141)-(111,148) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (111,148)-(111,149) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,149)-(111,162) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (111,162)-(111,163) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,163)-(111,190) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (111,190)-(111,191) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,191)-(111,201) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first11 = true;
            #line (111,202)-(111,245) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                #line (111,246)-(111,247) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (111,247)-(111,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (111,249)-(111,279) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (111,280)-(111,281) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (111,282)-(111,300) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (111,314)-(111,315) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (111,315)-(111,316) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (112,13)-(112,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (112,14)-(112,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,15)-(112,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (112,30)-(112,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,31)-(112,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (112,43)-(112,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,44)-(112,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (112,56)-(112,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,57)-(112,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (112,62)-(112,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,63)-(112,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (112,76)-(112,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,77)-(112,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first12 = true;
            #line (112,88)-(112,135) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                #line (112,136)-(112,137) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (112,137)-(112,138) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (112,139)-(112,157) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (112,171)-(112,172) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (113,9)-(113,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first13 = true;
            #line (114,14)-(114,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("            ");
                #line (115,18)-(115,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            __cb.Push("        ");
            #line (117,9)-(117,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (119,9)-(119,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (119,15)-(119,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,17)-(119,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (119,45)-(119,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (119,54)-(119,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,55)-(119,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (119,65)-(119,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,66)-(119,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (119,80)-(119,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,81)-(119,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (119,93)-(119,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,94)-(119,101) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (119,101)-(119,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,102)-(119,107) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (119,107)-(119,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,108)-(119,115) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (119,115)-(119,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,116)-(119,129) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (119,129)-(119,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,130)-(119,157) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (119,157)-(119,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,158)-(119,168) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first14 = true;
            #line (119,169)-(119,212) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                #line (119,213)-(119,214) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (119,214)-(119,215) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (119,216)-(119,246) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (119,247)-(119,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (119,249)-(119,267) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (119,281)-(119,282) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (119,282)-(119,283) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (120,13)-(120,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (120,14)-(120,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,15)-(120,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (120,30)-(120,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,31)-(120,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (120,43)-(120,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,44)-(120,49) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (120,49)-(120,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,50)-(120,63) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (120,63)-(120,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,64)-(120,74) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first15 = true;
            #line (120,75)-(120,122) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                #line (120,123)-(120,124) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (120,124)-(120,125) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (120,126)-(120,144) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (120,158)-(120,159) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (121,9)-(121,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first16 = true;
            #line (122,14)-(122,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                __cb.Push("            ");
                #line (123,18)-(123,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("        ");
            #line (125,9)-(125,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (127,9)-(127,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (127,15)-(127,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,17)-(127,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (127,45)-(127,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (127,54)-(127,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,55)-(127,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (127,65)-(127,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,66)-(127,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (127,75)-(127,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,76)-(127,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (127,89)-(127,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,90)-(127,97) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (127,97)-(127,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,98)-(127,103) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (127,103)-(127,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,104)-(127,111) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (127,111)-(127,112) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,112)-(127,125) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (127,125)-(127,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,126)-(127,153) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (127,153)-(127,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,154)-(127,164) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first17 = true;
            #line (127,165)-(127,208) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                #line (127,209)-(127,210) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (127,210)-(127,211) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (127,212)-(127,242) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (127,243)-(127,244) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (127,245)-(127,263) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (127,277)-(127,278) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (127,278)-(127,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (128,13)-(128,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (128,14)-(128,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,15)-(128,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (128,30)-(128,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,31)-(128,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (128,44)-(128,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,45)-(128,50) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (128,50)-(128,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,51)-(128,64) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (128,64)-(128,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,65)-(128,75) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first18 = true;
            #line (128,76)-(128,123) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (128,124)-(128,125) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (128,125)-(128,126) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (128,127)-(128,145) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (128,159)-(128,160) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (129,9)-(129,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first19 = true;
            #line (130,14)-(130,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first19)
                {
                    __first19 = false;
                }
                __cb.Push("            ");
                #line (131,18)-(131,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first19) __cb.AppendLine();
            __cb.Push("        ");
            #line (133,9)-(133,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (135,9)-(135,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (135,15)-(135,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,17)-(135,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (135,45)-(135,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (135,54)-(135,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,55)-(135,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (135,65)-(135,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,66)-(135,79) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (135,79)-(135,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,80)-(135,92) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (135,92)-(135,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,93)-(135,108) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (135,108)-(135,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,109)-(135,121) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (135,121)-(135,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,122)-(135,129) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (135,129)-(135,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,130)-(135,135) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (135,135)-(135,136) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,136)-(135,143) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (135,143)-(135,144) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,144)-(135,157) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (135,157)-(135,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,158)-(135,185) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (135,185)-(135,186) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,186)-(135,196) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first20 = true;
            #line (135,197)-(135,240) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                #line (135,241)-(135,242) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (135,242)-(135,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,244)-(135,274) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (135,275)-(135,276) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,277)-(135,295) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (135,309)-(135,310) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (135,310)-(135,311) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (136,13)-(136,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (136,14)-(136,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,15)-(136,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (136,30)-(136,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,31)-(136,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (136,43)-(136,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,44)-(136,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (136,56)-(136,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,57)-(136,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (136,62)-(136,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,63)-(136,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (136,76)-(136,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,77)-(136,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first21 = true;
            #line (136,88)-(136,135) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (136,136)-(136,137) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (136,137)-(136,138) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (136,139)-(136,157) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (136,171)-(136,172) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (137,9)-(137,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first22 = true;
            #line (138,14)-(138,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("            ");
                #line (139,18)-(139,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            __cb.Push("        ");
            #line (141,9)-(141,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (143,9)-(143,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (143,15)-(143,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,16)-(143,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (143,24)-(143,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,25)-(143,41) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (143,41)-(143,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,42)-(143,55) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (144,9)-(144,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (145,13)-(145,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (146,13)-(146,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (147,17)-(147,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (147,20)-(147,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,21)-(147,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (147,25)-(147,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,26)-(147,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (147,27)-(147,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,29)-(147,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (147,57)-(147,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (148,17)-(148,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (148,20)-(148,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,21)-(148,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (148,27)-(148,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,28)-(148,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (148,29)-(148,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,30)-(148,49) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.SymbolFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (149,17)-(149,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (150,17)-(150,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (150,23)-(150,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,24)-(150,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (151,13)-(151,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (152,9)-(152,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,9)-(154,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (154,15)-(154,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,16)-(154,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (154,24)-(154,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,25)-(154,42) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol?");
            #line hidden
            #line (154,42)-(154,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,43)-(154,61) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingAssembly");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (155,9)-(155,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (156,13)-(156,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (157,13)-(157,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (158,17)-(158,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (158,20)-(158,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,21)-(158,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (158,25)-(158,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,26)-(158,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (158,27)-(158,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,29)-(158,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (158,57)-(158,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (159,17)-(159,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (159,20)-(159,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,21)-(159,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (159,27)-(159,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,28)-(159,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (159,29)-(159,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,30)-(159,54) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.ContainingAssembly;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (160,17)-(160,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (161,17)-(161,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (161,23)-(161,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,24)-(161,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (162,13)-(162,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (163,9)-(163,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (165,9)-(165,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (165,15)-(165,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,16)-(165,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (165,24)-(165,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,25)-(165,39) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (165,39)-(165,40) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (165,40)-(165,60) 25 "SymbolGenerator.mxg"
            __cb.Write("DeclaringCompilation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (166,9)-(166,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (167,13)-(167,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (168,13)-(168,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (169,17)-(169,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (169,20)-(169,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,21)-(169,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (169,25)-(169,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,26)-(169,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (169,27)-(169,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,29)-(169,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (169,57)-(169,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (170,17)-(170,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (170,20)-(170,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,21)-(170,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (170,27)-(170,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,28)-(170,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (170,29)-(170,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (170,30)-(170,56) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.DeclaringCompilation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (171,17)-(171,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (172,17)-(172,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (172,23)-(172,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,24)-(172,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (173,13)-(173,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (174,9)-(174,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (176,9)-(176,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (176,15)-(176,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,16)-(176,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (176,24)-(176,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,25)-(176,40) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol?");
            #line hidden
            #line (176,40)-(176,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,41)-(176,57) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingModule");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (177,9)-(177,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (178,13)-(178,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (179,13)-(179,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (180,17)-(180,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (180,20)-(180,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,21)-(180,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (180,25)-(180,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,26)-(180,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (180,27)-(180,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,29)-(180,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (180,57)-(180,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (181,17)-(181,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (181,20)-(181,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (181,21)-(181,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (181,27)-(181,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (181,28)-(181,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (181,29)-(181,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (181,30)-(181,52) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.ContainingModule;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (182,17)-(182,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (183,17)-(183,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (183,23)-(183,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (183,24)-(183,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (184,13)-(184,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (185,9)-(185,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (187,9)-(187,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (187,15)-(187,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,16)-(187,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (187,24)-(187,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,25)-(187,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol?");
            #line hidden
            #line (187,45)-(187,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (187,46)-(187,67) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingDeclaration");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (188,9)-(188,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (189,13)-(189,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (190,13)-(190,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (191,17)-(191,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (191,20)-(191,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,21)-(191,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (191,25)-(191,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,26)-(191,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (191,27)-(191,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,29)-(191,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (191,57)-(191,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (192,17)-(192,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (192,20)-(192,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,21)-(192,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (192,27)-(192,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,28)-(192,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (192,29)-(192,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,30)-(192,57) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.ContainingDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (193,17)-(193,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (194,17)-(194,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (194,23)-(194,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (194,24)-(194,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (195,13)-(195,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (196,9)-(196,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (198,9)-(198,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (198,15)-(198,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,16)-(198,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (198,24)-(198,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,25)-(198,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol?");
            #line hidden
            #line (198,38)-(198,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,39)-(198,53) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingType");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (199,9)-(199,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (200,13)-(200,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (201,13)-(201,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (202,17)-(202,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (202,20)-(202,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,21)-(202,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (202,25)-(202,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,26)-(202,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (202,27)-(202,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,29)-(202,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (202,57)-(202,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (203,17)-(203,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (203,20)-(203,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,21)-(203,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (203,27)-(203,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,28)-(203,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (203,29)-(203,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,30)-(203,50) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.ContainingType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (204,17)-(204,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (205,17)-(205,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (205,23)-(205,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,24)-(205,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (206,13)-(206,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (207,9)-(207,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (209,9)-(209,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (209,15)-(209,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,16)-(209,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (209,24)-(209,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,25)-(209,43) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol?");
            #line hidden
            #line (209,43)-(209,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,44)-(209,63) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingNamespace");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (210,9)-(210,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (211,13)-(211,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (212,13)-(212,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (213,17)-(213,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (213,20)-(213,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,21)-(213,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (213,25)-(213,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,26)-(213,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (213,27)-(213,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,29)-(213,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (213,57)-(213,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (214,17)-(214,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (214,20)-(214,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,21)-(214,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (214,27)-(214,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,28)-(214,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (214,29)-(214,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,30)-(214,55) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.ContainingNamespace;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (215,17)-(215,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (216,17)-(216,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (216,23)-(216,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,24)-(216,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (217,13)-(217,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (218,9)-(218,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (220,9)-(220,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (220,15)-(220,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,16)-(220,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (220,24)-(220,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,25)-(220,41) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (220,41)-(220,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,42)-(220,61) 25 "SymbolGenerator.mxg"
            __cb.Write("GetLexicalSortKey()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (221,9)-(221,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (222,13)-(222,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (222,16)-(222,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,17)-(222,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (222,21)-(222,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,22)-(222,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (222,23)-(222,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,25)-(222,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (222,53)-(222,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (223,13)-(223,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (223,16)-(223,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,17)-(223,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (223,23)-(223,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,24)-(223,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (223,25)-(223,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,26)-(223,51) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.GetLexicalSortKey();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (224,13)-(224,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (225,13)-(225,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (225,19)-(225,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,20)-(225,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (226,9)-(226,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (228,9)-(228,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (228,15)-(228,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,16)-(228,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (228,24)-(228,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,25)-(228,29) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (228,29)-(228,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (228,30)-(228,52) 25 "SymbolGenerator.mxg"
            __cb.Write("HasUnsupportedMetadata");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (229,9)-(229,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (230,13)-(230,16) 25 "SymbolGenerator.mxg"
            __cb.Write("get");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (231,13)-(231,14) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (232,17)-(232,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (232,20)-(232,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,21)-(232,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (232,25)-(232,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,26)-(232,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (232,27)-(232,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,29)-(232,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (232,57)-(232,76) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (233,17)-(233,20) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (233,20)-(233,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,21)-(233,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (233,27)-(233,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,28)-(233,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (233,29)-(233,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,30)-(233,58) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.HasUnsupportedMetadata;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (234,17)-(234,29) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (235,17)-(235,23) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (235,23)-(235,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (235,24)-(235,31) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (236,13)-(236,14) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (237,9)-(237,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (239,9)-(239,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (239,15)-(239,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,16)-(239,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (239,24)-(239,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,25)-(239,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (239,31)-(239,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (239,32)-(239,59) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentId()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (240,9)-(240,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (241,13)-(241,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (241,16)-(241,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (241,17)-(241,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (241,21)-(241,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (241,22)-(241,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (241,23)-(241,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (241,25)-(241,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (241,53)-(241,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (242,13)-(242,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (242,16)-(242,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,17)-(242,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (242,23)-(242,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,24)-(242,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (242,25)-(242,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (242,26)-(242,59) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.GetDocumentationCommentId();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (243,13)-(243,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (244,13)-(244,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (244,19)-(244,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (244,20)-(244,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (245,9)-(245,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (247,9)-(247,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (247,15)-(247,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,16)-(247,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (247,24)-(247,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,25)-(247,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (247,31)-(247,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,32)-(247,72) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentXml(__CultureInfo");
            #line hidden
            #line (247,72)-(247,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,73)-(247,89) 25 "SymbolGenerator.mxg"
            __cb.Write("preferredCulture");
            #line hidden
            #line (247,89)-(247,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,90)-(247,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (247,91)-(247,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,92)-(247,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (247,97)-(247,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,98)-(247,102) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (247,102)-(247,103) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,103)-(247,117) 25 "SymbolGenerator.mxg"
            __cb.Write("expandIncludes");
            #line hidden
            #line (247,117)-(247,118) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,118)-(247,119) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (247,119)-(247,120) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,120)-(247,126) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (247,126)-(247,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,127)-(247,146) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (247,146)-(247,147) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,147)-(247,164) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken");
            #line hidden
            #line (247,164)-(247,165) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,165)-(247,166) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (247,166)-(247,167) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (247,167)-(247,175) 25 "SymbolGenerator.mxg"
            __cb.Write("default)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (248,9)-(248,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (249,13)-(249,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (249,16)-(249,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,17)-(249,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (249,21)-(249,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,22)-(249,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (249,23)-(249,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (249,25)-(249,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (249,53)-(249,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (250,13)-(250,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (250,16)-(250,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,17)-(250,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (250,23)-(250,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,24)-(250,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (250,25)-(250,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,26)-(250,75) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.GetDocumentationCommentXml(preferredCulture,");
            #line hidden
            #line (250,75)-(250,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,76)-(250,91) 25 "SymbolGenerator.mxg"
            __cb.Write("expandIncludes,");
            #line hidden
            #line (250,91)-(250,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,92)-(250,111) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (251,13)-(251,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (252,13)-(252,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (252,19)-(252,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (252,20)-(252,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (253,9)-(253,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first23 = true;
            #line (255,10)-(255,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (257,13)-(257,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (257,19)-(257,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (257,21)-(257,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (257,52)-(257,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (257,54)-(257,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (258,13)-(258,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (259,17)-(259,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (260,17)-(260,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (261,21)-(261,40) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(");
                #line hidden
                #line (261,41)-(261,68) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (261,69)-(261,93) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (261,94)-(261,103) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (261,104)-(261,105) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (261,105)-(261,106) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (261,106)-(261,111) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (261,111)-(261,112) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (261,112)-(261,121) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first24 = true;
                #line (262,22)-(262,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("                ");
                    #line (263,25)-(263,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (263,27)-(263,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (263,28)-(263,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (263,30)-(263,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (263,49)-(263,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (263,67)-(263,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (263,68)-(263,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (263,71)-(263,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (263,72)-(263,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (263,75)-(263,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (263,76)-(263,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (263,84)-(263,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (263,85)-(263,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (263,91)-(263,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (263,92)-(263,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (263,94)-(263,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (263,125)-(263,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (264,25)-(264,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (264,29)-(264,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (264,30)-(264,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (264,36)-(264,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (264,38)-(264,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (264,68)-(264,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (265,22)-(265,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("                ");
                    #line (266,25)-(266,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (266,31)-(266,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,33)-(266,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (266,52)-(266,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first24) __cb.AppendLine();
                __cb.Push("            ");
                #line (268,17)-(268,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (269,13)-(269,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (272,9)-(272,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (272,18)-(272,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,19)-(272,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (272,27)-(272,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,28)-(272,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (272,32)-(272,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,33)-(272,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (272,54)-(272,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,55)-(272,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (272,71)-(272,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,72)-(272,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (272,87)-(272,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,88)-(272,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (272,105)-(272,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,106)-(272,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (272,118)-(272,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,119)-(272,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (272,138)-(272,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (272,139)-(272,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (273,9)-(273,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (274,14)-(274,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            #line (275,14)-(275,44) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            #line (276,14)-(276,52) 13 "SymbolGenerator.mxg"
            var basePhases = GetPhases(baseSymbol);
            #line hidden
            
            var __first25 = true;
            #line (277,14)-(277,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                var __first26 = true;
                #line (278,18)-(278,50) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    #line (279,22)-(279,41) 21 "SymbolGenerator.mxg"
                    hasNewPhase = true;
                    #line hidden
                    
                    #line (280,22)-(280,67) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    __cb.Push("            ");
                    #line (281,21)-(281,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (281,23)-(281,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,24)-(281,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("(incompletePart");
                    #line hidden
                    #line (281,39)-(281,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,40)-(281,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (281,42)-(281,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,44)-(281,71) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (281,72)-(281,95) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (281,96)-(281,101) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (281,102)-(281,103) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,103)-(281,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("||");
                    #line hidden
                    #line (281,105)-(281,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,106)-(281,120) 33 "SymbolGenerator.mxg"
                    __cb.Write("incompletePart");
                    #line hidden
                    #line (281,120)-(281,121) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,121)-(281,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (281,123)-(281,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,125)-(281,152) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (281,153)-(281,177) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (281,178)-(281,183) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (281,184)-(281,185) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (282,21)-(282,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (283,25)-(283,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (283,27)-(283,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (283,28)-(283,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("(NotePartComplete(");
                    #line hidden
                    #line (283,47)-(283,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (283,75)-(283,98) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (283,99)-(283,104) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (283,105)-(283,107) 33 "SymbolGenerator.mxg"
                    __cb.Write("))");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (284,25)-(284,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (285,29)-(285,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (285,32)-(285,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (285,33)-(285,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (285,44)-(285,45) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (285,45)-(285,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (285,46)-(285,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (285,47)-(285,77) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first27 = true;
                    #line (286,30)-(286,52) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("                    ");
                        #line (287,33)-(287,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (287,36)-(287,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (287,37)-(287,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (287,43)-(287,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (287,44)-(287,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (287,45)-(287,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (287,46)-(287,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (287,56)-(287,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (287,62)-(287,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (287,75)-(287,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (287,76)-(287,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first28 = true;
                        #line (288,34)-(288,61) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props)
                        #line hidden
                        
                        {
                            if (__first28)
                            {
                                __first28 = false;
                            }
                            __cb.Push("                    ");
                            #line (289,38)-(289,87) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first28) __cb.AppendLine();
                    }
                    #line (291,30)-(291,57) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("                    ");
                        #line (292,33)-(292,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (292,36)-(292,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (292,37)-(292,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (292,43)-(292,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (292,44)-(292,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (292,45)-(292,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (292,46)-(292,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (292,56)-(292,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (292,62)-(292,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (292,75)-(292,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (292,76)-(292,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                    ");
                        #line (293,34)-(293,76) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, props[0], "result"));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (294,30)-(294,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("                    ");
                        #line (295,33)-(295,42) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (295,43)-(295,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (295,49)-(295,62) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (295,62)-(295,63) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (295,63)-(295,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first27) __cb.AppendLine();
                    __cb.Push("                    ");
                    #line (297,29)-(297,63) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (298,29)-(298,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (299,29)-(299,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (299,47)-(299,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (299,75)-(299,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (299,100)-(299,105) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (299,106)-(299,108) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (300,25)-(300,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (301,25)-(301,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (301,31)-(301,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (301,32)-(301,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (302,21)-(302,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (303,21)-(303,25) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (303,25)-(303,26) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.SkipLineEnd = true;
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
            }
            if (!__first25) __cb.AppendLine();
            var __first29 = true;
            #line (306,14)-(306,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first29)
                {
                    __first29 = false;
                }
                __cb.Push("            ");
                #line (307,17)-(307,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (308,21)-(308,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (308,27)-(308,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (308,28)-(308,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (308,54)-(308,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (308,55)-(308,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (308,70)-(308,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (308,71)-(308,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (308,83)-(308,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (308,84)-(308,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (309,17)-(309,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (310,14)-(310,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first29)
                {
                    __first29 = false;
                }
                __cb.Push("            ");
                #line (311,17)-(311,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (311,23)-(311,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (311,24)-(311,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (311,50)-(311,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (311,51)-(311,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (311,66)-(311,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (311,67)-(311,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (311,79)-(311,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (311,80)-(311,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first29) __cb.AppendLine();
            __cb.Push("        ");
            #line (313,9)-(313,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (316,9)-(316,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (316,18)-(316,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (316,19)-(316,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (316,27)-(316,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (316,28)-(316,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (316,32)-(316,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (316,33)-(316,72) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Initialize(__DiagnosticBag");
            #line hidden
            #line (316,72)-(316,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (316,73)-(316,85) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (316,85)-(316,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (316,86)-(316,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (316,105)-(316,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (316,106)-(316,124) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (317,9)-(317,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (318,13)-(318,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (318,16)-(318,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (318,17)-(318,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (318,21)-(318,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (318,22)-(318,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (318,23)-(318,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (318,25)-(318,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (318,53)-(318,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (319,13)-(319,54) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.CompletePart_Initialize(diagnostics,");
            #line hidden
            #line (319,54)-(319,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (319,55)-(319,74) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (320,13)-(320,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (321,9)-(321,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (323,9)-(323,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (323,18)-(323,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,19)-(323,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (323,27)-(323,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,28)-(323,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (323,35)-(323,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,36)-(323,65) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Name(__DiagnosticBag");
            #line hidden
            #line (323,65)-(323,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,66)-(323,78) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (323,78)-(323,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,79)-(323,98) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (323,98)-(323,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (323,99)-(323,117) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (324,9)-(324,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (325,13)-(325,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (325,16)-(325,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,17)-(325,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (325,21)-(325,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,22)-(325,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (325,23)-(325,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,25)-(325,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (325,53)-(325,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (326,13)-(326,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (326,16)-(326,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,17)-(326,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (326,23)-(326,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,24)-(326,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (326,25)-(326,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,26)-(326,57) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Complete_Name(diagnostics,");
            #line hidden
            #line (326,57)-(326,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (326,58)-(326,77) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (327,13)-(327,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (328,13)-(328,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (328,19)-(328,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,20)-(328,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (329,9)-(329,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (331,9)-(331,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (331,18)-(331,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,19)-(331,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (331,27)-(331,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,28)-(331,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (331,35)-(331,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,36)-(331,73) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_MetadataName(__DiagnosticBag");
            #line hidden
            #line (331,73)-(331,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,74)-(331,86) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (331,86)-(331,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,87)-(331,106) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (331,106)-(331,107) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,107)-(331,125) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (332,9)-(332,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (333,13)-(333,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (333,16)-(333,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,17)-(333,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (333,21)-(333,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,22)-(333,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (333,23)-(333,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,25)-(333,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (333,53)-(333,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (334,13)-(334,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (334,16)-(334,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,17)-(334,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (334,23)-(334,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,24)-(334,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (334,25)-(334,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,26)-(334,65) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Complete_MetadataName(diagnostics,");
            #line hidden
            #line (334,65)-(334,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,66)-(334,85) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (335,13)-(335,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (336,13)-(336,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (336,19)-(336,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,20)-(336,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (337,9)-(337,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (339,9)-(339,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (339,18)-(339,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,19)-(339,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (339,27)-(339,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,28)-(339,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__Symbol>");
            #line hidden
            #line (339,89)-(339,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,90)-(339,141) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_CreateContainedSymbols(__DiagnosticBag");
            #line hidden
            #line (339,141)-(339,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,142)-(339,154) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (339,154)-(339,155) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,155)-(339,174) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (339,174)-(339,175) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,175)-(339,193) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (340,9)-(340,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (341,13)-(341,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (341,16)-(341,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,17)-(341,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (341,21)-(341,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,22)-(341,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (341,23)-(341,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,25)-(341,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (341,53)-(341,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (342,13)-(342,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (342,16)-(342,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,17)-(342,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (342,23)-(342,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,24)-(342,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (342,25)-(342,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,26)-(342,79) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.CompletePart_CreateContainedSymbols(diagnostics,");
            #line hidden
            #line (342,79)-(342,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,80)-(342,99) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (343,13)-(343,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (344,13)-(344,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (344,19)-(344,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (344,20)-(344,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (345,9)-(345,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (347,9)-(347,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (347,18)-(347,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,19)-(347,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (347,27)-(347,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,28)-(347,98) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>");
            #line hidden
            #line (347,98)-(347,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,99)-(347,134) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Attributes(__DiagnosticBag");
            #line hidden
            #line (347,134)-(347,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,135)-(347,147) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (347,147)-(347,148) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,148)-(347,167) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (347,167)-(347,168) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,168)-(347,186) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (348,9)-(348,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (349,13)-(349,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (349,16)-(349,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,17)-(349,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (349,21)-(349,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,22)-(349,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (349,23)-(349,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,25)-(349,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (349,53)-(349,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (350,13)-(350,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (350,16)-(350,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,17)-(350,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (350,23)-(350,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,24)-(350,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (350,25)-(350,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,26)-(350,63) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Complete_Attributes(diagnostics,");
            #line hidden
            #line (350,63)-(350,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,64)-(350,83) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (351,13)-(351,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (352,13)-(352,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (352,19)-(352,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,20)-(352,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (353,9)-(353,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (355,9)-(355,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (355,18)-(355,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,19)-(355,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (355,27)-(355,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,28)-(355,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (355,32)-(355,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,33)-(355,88) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_ComputeNonSymbolProperties(__DiagnosticBag");
            #line hidden
            #line (355,88)-(355,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,89)-(355,101) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (355,101)-(355,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,102)-(355,121) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (355,121)-(355,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,122)-(355,140) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (356,9)-(356,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (357,13)-(357,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (357,16)-(357,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,17)-(357,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (357,21)-(357,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,22)-(357,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (357,23)-(357,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (357,25)-(357,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (357,53)-(357,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (358,13)-(358,70) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.CompletePart_ComputeNonSymbolProperties(diagnostics,");
            #line hidden
            #line (358,70)-(358,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,71)-(358,90) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (359,13)-(359,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (360,9)-(360,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (362,9)-(362,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (362,18)-(362,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,19)-(362,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (362,27)-(362,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,28)-(362,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (362,32)-(362,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,33)-(362,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Finalize(__DiagnosticBag");
            #line hidden
            #line (362,70)-(362,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,71)-(362,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (362,83)-(362,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,84)-(362,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (362,103)-(362,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,104)-(362,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (363,9)-(363,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (364,13)-(364,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (364,16)-(364,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,17)-(364,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (364,21)-(364,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,22)-(364,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (364,23)-(364,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,25)-(364,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (364,53)-(364,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (365,13)-(365,52) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.CompletePart_Finalize(diagnostics,");
            #line hidden
            #line (365,52)-(365,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (365,53)-(365,72) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (366,13)-(366,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (367,9)-(367,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (369,9)-(369,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (369,18)-(369,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,19)-(369,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (369,27)-(369,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,28)-(369,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (369,32)-(369,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,33)-(369,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Validate(__DiagnosticBag");
            #line hidden
            #line (369,70)-(369,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,71)-(369,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (369,83)-(369,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,84)-(369,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (369,103)-(369,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,104)-(369,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (370,9)-(370,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (371,13)-(371,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (371,16)-(371,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,17)-(371,21) 25 "SymbolGenerator.mxg"
            __cb.Write("impl");
            #line hidden
            #line (371,21)-(371,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,22)-(371,23) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (371,23)-(371,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,25)-(371,52) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (371,53)-(371,72) 25 "SymbolGenerator.mxg"
            __cb.Write(".GetInstance(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (372,13)-(372,52) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.CompletePart_Validate(diagnostics,");
            #line hidden
            #line (372,52)-(372,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,53)-(372,72) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (373,13)-(373,25) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.Free();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (374,9)-(374,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first30 = true;
            #line (376,10)-(376,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (378,14)-(378,80) 17 "SymbolGenerator.mxg"
                var virtOvrd = basePhases.Contains(phase) ? "override" : "virtual";
                #line hidden
                
                #line (379,14)-(379,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first31 = true;
                #line (380,14)-(380,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("        ");
                    #line (381,17)-(381,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (381,26)-(381,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (381,28)-(381,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (381,37)-(381,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (381,38)-(381,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first32 = true;
                    foreach (var __item33 in 
                    #line (381,40)-(381,97) 21 "SymbolGenerator.mxg"
                    from prop in props select GetTypeName(symbol, prop.Type) 
                    #line hidden
                    )
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (381,107)-(381,111) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item33);
                    }
                    #line (381,112)-(381,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (381,113)-(381,114) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (381,114)-(381,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (381,124)-(381,129) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (381,130)-(381,146) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (381,146)-(381,147) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (381,147)-(381,159) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (381,159)-(381,160) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (381,160)-(381,179) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (381,179)-(381,180) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (381,180)-(381,198) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (382,17)-(382,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (383,21)-(383,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (383,24)-(383,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (383,25)-(383,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (383,29)-(383,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (383,30)-(383,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (383,31)-(383,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (383,33)-(383,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (383,61)-(383,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (384,21)-(384,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (384,24)-(384,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (384,25)-(384,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (384,31)-(384,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (384,32)-(384,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (384,33)-(384,34) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (384,34)-(384,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (384,49)-(384,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (384,55)-(384,68) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (384,68)-(384,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (384,69)-(384,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (385,21)-(385,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (386,21)-(386,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (386,27)-(386,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (386,28)-(386,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (387,17)-(387,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (388,14)-(388,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    #line (389,18)-(389,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (390,17)-(390,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (390,26)-(390,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,28)-(390,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (390,37)-(390,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,39)-(390,69) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (390,70)-(390,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,71)-(390,80) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (390,81)-(390,86) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (390,87)-(390,103) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (390,103)-(390,104) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,104)-(390,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (390,116)-(390,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,117)-(390,136) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (390,136)-(390,137) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,137)-(390,155) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (391,17)-(391,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (392,21)-(392,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (392,24)-(392,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (392,25)-(392,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (392,29)-(392,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (392,30)-(392,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (392,31)-(392,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (392,33)-(392,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (392,61)-(392,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (393,21)-(393,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (393,24)-(393,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (393,25)-(393,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (393,31)-(393,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (393,32)-(393,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (393,33)-(393,34) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (393,34)-(393,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (393,49)-(393,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (393,55)-(393,68) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (393,68)-(393,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (393,69)-(393,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (394,21)-(394,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (395,21)-(395,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (395,27)-(395,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (395,28)-(395,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (396,17)-(396,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (397,14)-(397,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("        ");
                    #line (398,17)-(398,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (398,26)-(398,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (398,28)-(398,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (398,37)-(398,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (398,38)-(398,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (398,42)-(398,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (398,43)-(398,52) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (398,53)-(398,58) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (398,59)-(398,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (398,75)-(398,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (398,76)-(398,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (398,88)-(398,89) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (398,89)-(398,108) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (398,108)-(398,109) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (398,109)-(398,127) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (399,17)-(399,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (400,21)-(400,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (400,24)-(400,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (400,25)-(400,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (400,29)-(400,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (400,30)-(400,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (400,31)-(400,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (400,33)-(400,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (400,61)-(400,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (401,21)-(401,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (401,36)-(401,41) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (401,42)-(401,55) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (401,55)-(401,56) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (401,56)-(401,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (402,21)-(402,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (403,17)-(403,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
            }
            if (!__first30) __cb.AppendLine();
            __cb.Push("    ");
            #line (406,5)-(406,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (408,5)-(408,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (408,11)-(408,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,12)-(408,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (408,20)-(408,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,21)-(408,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (408,26)-(408,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,28)-(408,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (408,56)-(408,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,57)-(408,58) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (408,58)-(408,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first34 = true;
            #line (408,60)-(408,83) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                #line (408,84)-(408,132) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl");
                #line hidden
            }
            #line (408,133)-(408,137) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                #line (408,139)-(408,170) 28 "SymbolGenerator.mxg"
                __cb.Write(GetImplName(symbol, baseSymbol));
                #line hidden
            }
            #line (408,179)-(408,180) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (408,180)-(408,181) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (408,182)-(408,209) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (409,5)-(409,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (410,9)-(410,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (410,18)-(410,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,20)-(410,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (410,48)-(410,62) 25 "SymbolGenerator.mxg"
            __cb.Write("(__IObjectPool");
            #line hidden
            #line (410,62)-(410,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,63)-(410,68) 25 "SymbolGenerator.mxg"
            __cb.Write("pool)");
            #line hidden
            #line (410,68)-(410,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (411,13)-(411,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (411,14)-(411,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,15)-(411,25) 25 "SymbolGenerator.mxg"
            __cb.Write("base(pool)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (412,9)-(412,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (413,9)-(413,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first35 = true;
            #line (415,10)-(415,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                __cb.Push("        ");
                #line (416,13)-(416,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (416,19)-(416,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (416,21)-(416,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (416,52)-(416,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (416,54)-(416,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (416,64)-(416,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (416,65)-(416,67) 29 "SymbolGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (416,67)-(416,68) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (416,68)-(416,70) 29 "SymbolGenerator.mxg"
                __cb.Write("((");
                #line hidden
                #line (416,71)-(416,98) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (416,99)-(416,111) 29 "SymbolGenerator.mxg"
                __cb.Write(")__Wrapped).");
                #line hidden
                #line (416,112)-(416,121) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (416,122)-(416,123) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first35) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first36 = true;
            #line (419,10)-(419,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                var __first37 = true;
                #line (420,14)-(420,46) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    __cb.WriteLine();
                    __cb.Pop();
                    #line (422,18)-(422,63) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    var __first38 = true;
                    #line (423,18)-(423,40) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        var __first39 = true;
                        #line (424,22)-(424,62) 25 "SymbolGenerator.mxg"
                        if (props.Where(p => p.IsDerived).Any())
                        #line hidden
                        
                        {
                            if (__first39)
                            {
                                __first39 = false;
                            }
                            __cb.Push("        ");
                            #line (425,25)-(425,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (425,31)-(425,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (425,32)-(425,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (425,40)-(425,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (425,41)-(425,42) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            var __first40 = true;
                            foreach (var __item41 in 
                            #line (425,43)-(425,100) 29 "SymbolGenerator.mxg"
                            from prop in props select GetTypeName(symbol, prop.Type) 
                            #line hidden
                            )
                            {
                                if (__first40)
                                {
                                    __first40 = false;
                                }
                                else
                                {
                                    __cb.Push("        ");
                                    __cb.DontIgnoreLastLineEnd = true;
                                    #line (425,110)-(425,114) 48 "SymbolGenerator.mxg"
                                    __cb.Write(", ");
                                    #line hidden
                                    __cb.DontIgnoreLastLineEnd = false;
                                    __cb.Pop();
                                }
                                __cb.Write(__item41);
                            }
                            #line (425,115)-(425,116) 41 "SymbolGenerator.mxg"
                            __cb.Write(")");
                            #line hidden
                            #line (425,116)-(425,117) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (425,117)-(425,126) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (425,127)-(425,132) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (425,133)-(425,149) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (425,149)-(425,150) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (425,150)-(425,162) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (425,162)-(425,163) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (425,163)-(425,182) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (425,182)-(425,183) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (425,183)-(425,202) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (426,22)-(426,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first39)
                            {
                                __first39 = false;
                            }
                            __cb.Push("        ");
                            #line (427,25)-(427,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (427,31)-(427,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (427,32)-(427,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (427,39)-(427,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (427,40)-(427,41) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            var __first42 = true;
                            foreach (var __item43 in 
                            #line (427,42)-(427,99) 29 "SymbolGenerator.mxg"
                            from prop in props select GetTypeName(symbol, prop.Type) 
                            #line hidden
                            )
                            {
                                if (__first42)
                                {
                                    __first42 = false;
                                }
                                else
                                {
                                    __cb.Push("        ");
                                    __cb.DontIgnoreLastLineEnd = true;
                                    #line (427,109)-(427,113) 48 "SymbolGenerator.mxg"
                                    __cb.Write(", ");
                                    #line hidden
                                    __cb.DontIgnoreLastLineEnd = false;
                                    __cb.Pop();
                                }
                                __cb.Write(__item43);
                            }
                            #line (427,114)-(427,115) 41 "SymbolGenerator.mxg"
                            __cb.Write(")");
                            #line hidden
                            #line (427,115)-(427,116) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (427,116)-(427,125) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (427,126)-(427,131) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (427,132)-(427,148) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (427,148)-(427,149) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (427,149)-(427,161) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (427,161)-(427,162) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (427,162)-(427,181) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (427,181)-(427,182) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (427,182)-(427,200) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (428,25)-(428,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (429,29)-(429,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (429,31)-(429,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (429,32)-(429,36) 41 "SymbolGenerator.mxg"
                            __cb.Write("TODO");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (430,29)-(430,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (430,35)-(430,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (430,36)-(430,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            var __first44 = true;
                            foreach (var __item45 in 
                            #line (430,38)-(430,94) 29 "SymbolGenerator.mxg"
                            from prop in props select GetDefaultValue(symbol, prop) 
                            #line hidden
                            )
                            {
                                if (__first44)
                                {
                                    __first44 = false;
                                }
                                else
                                {
                                    __cb.Push("            ");
                                    __cb.DontIgnoreLastLineEnd = true;
                                    #line (430,104)-(430,108) 48 "SymbolGenerator.mxg"
                                    __cb.Write(", ");
                                    #line hidden
                                    __cb.DontIgnoreLastLineEnd = false;
                                    __cb.Pop();
                                }
                                __cb.Write(__item45);
                            }
                            #line (430,109)-(430,111) 41 "SymbolGenerator.mxg"
                            __cb.Write(");");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (431,25)-(431,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first39) __cb.AppendLine();
                    }
                    #line (433,18)-(433,45) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        #line (434,22)-(434,41) 25 "SymbolGenerator.mxg"
                        var prop = props[0];
                        #line hidden
                        
                        var __first46 = true;
                        #line (435,22)-(435,41) 25 "SymbolGenerator.mxg"
                        if (prop.IsDerived)
                        #line hidden
                        
                        {
                            if (__first46)
                            {
                                __first46 = false;
                            }
                            __cb.Push("        ");
                            #line (436,25)-(436,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (436,31)-(436,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (436,32)-(436,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (436,40)-(436,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (436,42)-(436,72) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (436,73)-(436,74) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (436,74)-(436,83) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (436,84)-(436,89) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (436,90)-(436,106) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (436,106)-(436,107) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (436,107)-(436,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (436,119)-(436,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (436,120)-(436,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (436,139)-(436,140) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (436,140)-(436,159) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (437,22)-(437,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first46)
                            {
                                __first46 = false;
                            }
                            __cb.Push("        ");
                            #line (438,25)-(438,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (438,31)-(438,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (438,32)-(438,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (438,39)-(438,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (438,41)-(438,71) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type));
                            #line hidden
                            #line (438,72)-(438,73) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (438,73)-(438,82) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (438,83)-(438,88) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (438,89)-(438,105) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (438,105)-(438,106) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (438,106)-(438,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (438,118)-(438,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (438,119)-(438,138) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (438,138)-(438,139) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (438,139)-(438,157) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (439,25)-(439,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (440,29)-(440,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (440,31)-(440,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (440,32)-(440,36) 41 "SymbolGenerator.mxg"
                            __cb.Write("TODO");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (441,29)-(441,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (441,35)-(441,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (441,37)-(441,66) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (441,67)-(441,68) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (442,25)-(442,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first46) __cb.AppendLine();
                    }
                    #line (444,18)-(444,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        __cb.Push("        ");
                        #line (445,21)-(445,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (445,27)-(445,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (445,28)-(445,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (445,36)-(445,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (445,37)-(445,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("void");
                        #line hidden
                        #line (445,41)-(445,42) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (445,42)-(445,51) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (445,52)-(445,57) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (445,58)-(445,74) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (445,74)-(445,75) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (445,75)-(445,87) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (445,87)-(445,88) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (445,88)-(445,107) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (445,107)-(445,108) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (445,108)-(445,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first38) __cb.AppendLine();
                }
                if (!__first37) __cb.AppendLine();
            }
            if (!__first36) __cb.AppendLine();
            __cb.Push("    ");
            #line (449,5)-(449,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (451,5)-(451,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (451,11)-(451,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,12)-(451,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (451,19)-(451,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,20)-(451,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (451,25)-(451,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,27)-(451,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (451,55)-(451,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,56)-(451,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (451,57)-(451,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,59)-(451,86) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (452,5)-(452,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (453,9)-(453,16) 25 "SymbolGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (453,16)-(453,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,17)-(453,23) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (453,23)-(453,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,24)-(453,32) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (453,32)-(453,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,33)-(453,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (453,45)-(453,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,46)-(453,60) 25 "SymbolGenerator.mxg"
            __cb.Write("s_poolInstance");
            #line hidden
            #line (453,60)-(453,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,61)-(453,62) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (453,62)-(453,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,63)-(453,66) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (453,66)-(453,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,67)-(453,82) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool(()");
            #line hidden
            #line (453,82)-(453,83) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,83)-(453,85) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (453,85)-(453,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,86)-(453,89) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (453,89)-(453,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,91)-(453,118) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (453,119)-(453,136) 25 "SymbolGenerator.mxg"
            __cb.Write("(s_poolInstance),");
            #line hidden
            #line (453,136)-(453,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,137)-(453,141) 25 "SymbolGenerator.mxg"
            __cb.Write("32);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (455,9)-(455,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (455,18)-(455,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,20)-(455,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (455,48)-(455,62) 25 "SymbolGenerator.mxg"
            __cb.Write("(__IObjectPool");
            #line hidden
            #line (455,62)-(455,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,63)-(455,68) 25 "SymbolGenerator.mxg"
            __cb.Write("pool)");
            #line hidden
            #line (455,68)-(455,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (456,13)-(456,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (456,14)-(456,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (456,15)-(456,25) 25 "SymbolGenerator.mxg"
            __cb.Write("base(pool)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (457,9)-(457,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (458,9)-(458,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (460,9)-(460,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (460,15)-(460,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,16)-(460,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (460,22)-(460,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,23)-(460,26) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (460,26)-(460,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,28)-(460,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (460,56)-(460,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,57)-(460,69) 25 "SymbolGenerator.mxg"
            __cb.Write("GetInstance(");
            #line hidden
            #line (460,70)-(460,97) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (460,98)-(460,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,99)-(460,107) 25 "SymbolGenerator.mxg"
            __cb.Write("wrapped)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (461,9)-(461,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (462,13)-(462,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (462,16)-(462,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,17)-(462,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (462,23)-(462,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,24)-(462,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (462,25)-(462,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,26)-(462,52) 25 "SymbolGenerator.mxg"
            __cb.Write("s_poolInstance.Allocate();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (463,13)-(463,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Diagnostics.Debug.Assert(result.__Wrapped");
            #line hidden
            #line (463,69)-(463,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,70)-(463,72) 25 "SymbolGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (463,72)-(463,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,73)-(463,79) 25 "SymbolGenerator.mxg"
            __cb.Write("null);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (464,13)-(464,43) 25 "SymbolGenerator.mxg"
            __cb.Write("result.__InitWrapped(wrapped);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (465,13)-(465,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (465,19)-(465,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (465,20)-(465,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (466,9)-(466,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (467,5)-(467,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (468,1)-(468,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (471,9)-(471,42) 22 "SymbolGenerator.mxg"
        public string GenerateMultiBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (472,1)-(472,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (472,10)-(472,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,12)-(472,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (472,33)-(472,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (473,1)-(473,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (474,5)-(474,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (474,10)-(474,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (474,11)-(474,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (474,20)-(474,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (474,21)-(474,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (474,22)-(474,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (474,23)-(474,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (475,5)-(475,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (475,10)-(475,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (475,11)-(475,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (475,25)-(475,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (475,26)-(475,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (475,27)-(475,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (475,28)-(475,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (476,5)-(476,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (476,10)-(476,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (476,11)-(476,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (476,30)-(476,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (476,31)-(476,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (476,32)-(476,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (476,33)-(476,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (477,5)-(477,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (477,10)-(477,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,11)-(477,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (477,19)-(477,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,20)-(477,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (477,21)-(477,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,22)-(477,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (478,5)-(478,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (478,10)-(478,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,11)-(478,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (478,28)-(478,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,29)-(478,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (478,30)-(478,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (478,31)-(478,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (479,5)-(479,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (479,10)-(479,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,11)-(479,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (479,26)-(479,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,27)-(479,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (479,28)-(479,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (479,29)-(479,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (480,5)-(480,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (480,10)-(480,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,11)-(480,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (480,28)-(480,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,29)-(480,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (480,30)-(480,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (480,31)-(480,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (481,5)-(481,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (481,10)-(481,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (481,11)-(481,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (481,27)-(481,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (481,28)-(481,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (481,29)-(481,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (481,30)-(481,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (482,5)-(482,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (482,10)-(482,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (482,11)-(482,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (482,26)-(482,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (482,27)-(482,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (482,28)-(482,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (482,29)-(482,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (483,5)-(483,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (483,10)-(483,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (483,11)-(483,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (483,27)-(483,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (483,28)-(483,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (483,29)-(483,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (483,30)-(483,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (484,5)-(484,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (484,10)-(484,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (484,11)-(484,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (484,30)-(484,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (484,31)-(484,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (484,32)-(484,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (484,33)-(484,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (485,5)-(485,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (485,10)-(485,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (485,11)-(485,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (485,23)-(485,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (485,24)-(485,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (485,25)-(485,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (485,26)-(485,81) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<");
            #line hidden
            #line (485,82)-(485,109) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (485,110)-(485,112) 25 "SymbolGenerator.mxg"
            __cb.Write(">;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (486,5)-(486,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (486,10)-(486,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,11)-(486,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (486,36)-(486,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,37)-(486,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (486,38)-(486,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,39)-(486,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (487,5)-(487,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (487,10)-(487,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (487,11)-(487,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (487,38)-(487,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (487,39)-(487,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (487,40)-(487,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (487,41)-(487,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (489,5)-(489,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (489,11)-(489,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,12)-(489,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (489,19)-(489,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,20)-(489,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (489,25)-(489,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,27)-(489,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (489,55)-(489,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,56)-(489,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (489,57)-(489,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,58)-(489,107) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst,");
            #line hidden
            #line (489,107)-(489,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (489,109)-(489,136) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (490,5)-(490,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first47 = true;
            #line (491,10)-(491,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                var __first48 = true;
                #line (492,14)-(492,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first48)
                    {
                        __first48 = false;
                    }
                    __cb.Push("        ");
                    #line (493,17)-(493,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (493,24)-(493,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (493,25)-(493,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (493,31)-(493,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (493,33)-(493,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (493,60)-(493,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (493,62)-(493,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (493,81)-(493,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (493,82)-(493,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (493,83)-(493,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (493,84)-(493,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (493,87)-(493,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (493,89)-(493,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (493,116)-(493,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (494,14)-(494,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first48)
                    {
                        __first48 = false;
                    }
                    __cb.Push("        ");
                    #line (495,17)-(495,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (495,24)-(495,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (495,26)-(495,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (495,53)-(495,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (495,55)-(495,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (495,74)-(495,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first48) __cb.AppendLine();
            }
            if (!__first47) __cb.AppendLine();
            __cb.Push("        ");
            #line (498,9)-(498,11) 25 "SymbolGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (498,11)-(498,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (498,12)-(498,16) 25 "SymbolGenerator.mxg"
            __cb.Write("TODO");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (499,5)-(499,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (500,1)-(500,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (503,9)-(503,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (504,1)-(504,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (504,6)-(504,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,7)-(504,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (505,1)-(505,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (505,6)-(505,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,7)-(505,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (506,1)-(506,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (506,6)-(506,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,7)-(506,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (507,1)-(507,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (507,6)-(507,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,7)-(507,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (508,1)-(508,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (508,6)-(508,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,7)-(508,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (509,1)-(509,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (509,6)-(509,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,7)-(509,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (511,1)-(511,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (511,10)-(511,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,12)-(511,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (511,33)-(511,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (512,1)-(512,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (513,5)-(513,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (513,11)-(513,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,12)-(513,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (513,19)-(513,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,20)-(513,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (513,25)-(513,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,27)-(513,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (514,5)-(514,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (515,5)-(515,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (516,1)-(516,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (519,9)-(519,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first49 = true;
            #line (520,6)-(520,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                var __first50 = true;
                #line (521,10)-(521,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("");
                    #line (522,13)-(522,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (522,15)-(522,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (522,16)-(522,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (522,19)-(522,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (522,28)-(522,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (523,13)-(523,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (524,18)-(524,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (524,37)-(524,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (524,47)-(524,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (524,49)-(524,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (524,58)-(524,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (525,13)-(525,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (526,10)-(526,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("");
                    #line (527,13)-(527,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (527,15)-(527,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,16)-(527,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (527,18)-(527,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (527,27)-(527,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,28)-(527,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (527,30)-(527,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (527,32)-(527,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (527,62)-(527,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (528,13)-(528,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (529,18)-(529,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (529,37)-(529,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (529,47)-(529,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,49)-(529,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (529,58)-(529,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (530,13)-(530,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first50) __cb.AppendLine();
            }
            #line (532,6)-(532,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("");
                #line (533,10)-(533,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (533,29)-(533,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (533,30)-(533,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (533,31)-(533,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (533,33)-(533,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (533,42)-(533,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first49) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}