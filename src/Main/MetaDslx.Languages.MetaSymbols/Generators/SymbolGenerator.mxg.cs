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
            #line (75,11)-(75,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (75,36)-(75,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,37)-(75,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (75,38)-(75,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,39)-(75,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            #line (76,11)-(76,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (76,24)-(76,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,25)-(76,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,26)-(76,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,27)-(76,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
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
            #line (77,11)-(77,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (77,38)-(77,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,39)-(77,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (77,40)-(77,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,41)-(77,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (79,5)-(79,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (79,11)-(79,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,12)-(79,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (79,19)-(79,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,20)-(79,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (79,25)-(79,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,27)-(79,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (79,55)-(79,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,56)-(79,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (79,57)-(79,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first8 = true;
            #line (79,59)-(79,82) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (79,83)-(79,131) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst");
                #line hidden
            }
            #line (79,132)-(79,136) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (79,138)-(79,169) 28 "SymbolGenerator.mxg"
                __cb.Write(GetInstName(symbol, baseSymbol));
                #line hidden
            }
            #line (79,178)-(79,179) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (79,179)-(79,180) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,181)-(79,208) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (80,5)-(80,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (81,10)-(81,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                var __first10 = true;
                #line (82,14)-(82,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (83,17)-(83,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (83,24)-(83,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (83,25)-(83,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (83,31)-(83,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (83,33)-(83,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (83,60)-(83,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (83,62)-(83,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (83,81)-(83,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (83,82)-(83,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (83,83)-(83,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (83,84)-(83,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (83,87)-(83,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (83,89)-(83,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (83,116)-(83,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (84,14)-(84,18) 17 "SymbolGenerator.mxg"
                else
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
                    #line (85,26)-(85,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (85,53)-(85,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (85,55)-(85,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (85,74)-(85,75) 33 "SymbolGenerator.mxg"
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
            #line (89,9)-(89,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (89,15)-(89,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,17)-(89,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (89,45)-(89,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (89,54)-(89,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,55)-(89,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (89,65)-(89,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,66)-(89,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (89,85)-(89,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,86)-(89,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (89,98)-(89,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,99)-(89,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (89,113)-(89,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,114)-(89,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (89,126)-(89,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (90,13)-(90,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (90,14)-(90,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,15)-(90,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (90,30)-(90,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,31)-(90,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (90,43)-(90,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,44)-(90,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (91,9)-(91,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (92,9)-(92,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (94,9)-(94,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (94,15)-(94,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,17)-(94,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (94,45)-(94,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (94,54)-(94,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,55)-(94,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (94,65)-(94,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,66)-(94,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (94,80)-(94,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,81)-(94,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (94,93)-(94,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (95,13)-(95,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (95,14)-(95,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,15)-(95,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (95,30)-(95,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,31)-(95,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (96,9)-(96,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (97,9)-(97,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (99,9)-(99,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (99,15)-(99,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,17)-(99,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (99,45)-(99,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (99,54)-(99,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,55)-(99,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (99,65)-(99,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,66)-(99,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (99,75)-(99,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,76)-(99,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (99,89)-(99,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (100,13)-(100,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (100,14)-(100,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,15)-(100,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (100,30)-(100,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,31)-(100,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (101,9)-(101,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (102,9)-(102,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (104,9)-(104,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (104,15)-(104,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,17)-(104,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (104,45)-(104,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (104,54)-(104,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,55)-(104,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (104,65)-(104,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,66)-(104,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (104,83)-(104,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,84)-(104,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (104,94)-(104,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (105,13)-(105,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (105,14)-(105,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,15)-(105,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (105,30)-(105,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,31)-(105,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (106,9)-(106,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (107,9)-(107,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (109,9)-(109,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (109,15)-(109,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,17)-(109,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (109,45)-(109,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (109,54)-(109,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,55)-(109,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (109,65)-(109,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,66)-(109,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (109,85)-(109,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,86)-(109,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (109,98)-(109,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,99)-(109,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (109,113)-(109,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,114)-(109,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (109,126)-(109,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,127)-(109,134) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (109,134)-(109,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,135)-(109,140) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (109,140)-(109,141) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,141)-(109,148) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (109,148)-(109,149) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,149)-(109,162) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (109,162)-(109,163) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,163)-(109,190) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (109,190)-(109,191) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,191)-(109,201) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first11 = true;
            #line (109,202)-(109,245) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                #line (109,246)-(109,247) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (109,247)-(109,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (109,249)-(109,279) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (109,280)-(109,281) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (109,282)-(109,300) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (109,314)-(109,315) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (109,315)-(109,316) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (110,13)-(110,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (110,14)-(110,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,15)-(110,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (110,30)-(110,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,31)-(110,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (110,43)-(110,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,44)-(110,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (110,56)-(110,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,57)-(110,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (110,62)-(110,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,63)-(110,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (110,76)-(110,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,77)-(110,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first12 = true;
            #line (110,88)-(110,135) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                #line (110,136)-(110,137) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (110,137)-(110,138) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (110,139)-(110,157) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (110,171)-(110,172) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (111,9)-(111,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first13 = true;
            #line (112,14)-(112,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("            ");
                #line (113,18)-(113,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            __cb.Push("        ");
            #line (115,9)-(115,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (117,9)-(117,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (117,15)-(117,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,17)-(117,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (117,45)-(117,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (117,54)-(117,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,55)-(117,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (117,65)-(117,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,66)-(117,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (117,80)-(117,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,81)-(117,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (117,93)-(117,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,94)-(117,101) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (117,101)-(117,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,102)-(117,107) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (117,107)-(117,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,108)-(117,115) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (117,115)-(117,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,116)-(117,129) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (117,129)-(117,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,130)-(117,157) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (117,157)-(117,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (117,158)-(117,168) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first14 = true;
            #line (117,169)-(117,212) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                #line (117,213)-(117,214) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (117,214)-(117,215) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (117,216)-(117,246) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (117,247)-(117,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (117,249)-(117,267) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (117,281)-(117,282) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (117,282)-(117,283) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (118,13)-(118,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (118,14)-(118,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (118,15)-(118,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (118,30)-(118,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (118,31)-(118,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (118,43)-(118,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (118,44)-(118,49) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (118,49)-(118,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (118,50)-(118,63) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (118,63)-(118,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (118,64)-(118,74) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first15 = true;
            #line (118,75)-(118,122) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                #line (118,123)-(118,124) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (118,124)-(118,125) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (118,126)-(118,144) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (118,158)-(118,159) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (119,9)-(119,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first16 = true;
            #line (120,14)-(120,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                __cb.Push("            ");
                #line (121,18)-(121,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("        ");
            #line (123,9)-(123,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (125,9)-(125,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (125,15)-(125,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,17)-(125,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (125,45)-(125,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (125,54)-(125,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,55)-(125,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (125,65)-(125,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,66)-(125,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (125,75)-(125,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,76)-(125,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (125,89)-(125,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,90)-(125,97) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (125,97)-(125,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,98)-(125,103) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (125,103)-(125,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,104)-(125,111) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (125,111)-(125,112) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,112)-(125,125) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (125,125)-(125,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,126)-(125,153) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (125,153)-(125,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,154)-(125,164) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first17 = true;
            #line (125,165)-(125,208) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                #line (125,209)-(125,210) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (125,210)-(125,211) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (125,212)-(125,242) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (125,243)-(125,244) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (125,245)-(125,263) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (125,277)-(125,278) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (125,278)-(125,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (126,13)-(126,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (126,14)-(126,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,15)-(126,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (126,30)-(126,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,31)-(126,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (126,44)-(126,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,45)-(126,50) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (126,50)-(126,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,51)-(126,64) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (126,64)-(126,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,65)-(126,75) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first18 = true;
            #line (126,76)-(126,123) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (126,124)-(126,125) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (126,125)-(126,126) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (126,127)-(126,145) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (126,159)-(126,160) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (127,9)-(127,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first19 = true;
            #line (128,14)-(128,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first19)
                {
                    __first19 = false;
                }
                __cb.Push("            ");
                #line (129,18)-(129,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first19) __cb.AppendLine();
            __cb.Push("        ");
            #line (131,9)-(131,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (133,9)-(133,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (133,15)-(133,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,17)-(133,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (133,45)-(133,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (133,54)-(133,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,55)-(133,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (133,65)-(133,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,66)-(133,79) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (133,79)-(133,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,80)-(133,92) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (133,92)-(133,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,93)-(133,108) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (133,108)-(133,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,109)-(133,121) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (133,121)-(133,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,122)-(133,129) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (133,129)-(133,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,130)-(133,135) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (133,135)-(133,136) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,136)-(133,143) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (133,143)-(133,144) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,144)-(133,157) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (133,157)-(133,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,158)-(133,185) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (133,185)-(133,186) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,186)-(133,196) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first20 = true;
            #line (133,197)-(133,240) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                #line (133,241)-(133,242) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (133,242)-(133,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (133,244)-(133,274) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (133,275)-(133,276) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (133,277)-(133,295) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (133,309)-(133,310) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (133,310)-(133,311) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (134,13)-(134,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (134,14)-(134,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,15)-(134,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (134,30)-(134,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,31)-(134,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (134,43)-(134,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,44)-(134,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (134,56)-(134,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,57)-(134,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (134,62)-(134,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,63)-(134,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (134,76)-(134,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,77)-(134,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first21 = true;
            #line (134,88)-(134,135) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (134,136)-(134,137) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (134,137)-(134,138) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (134,139)-(134,157) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (134,171)-(134,172) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (135,9)-(135,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first22 = true;
            #line (136,14)-(136,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("            ");
                #line (137,18)-(137,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            __cb.Push("        ");
            #line (139,9)-(139,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (141,9)-(141,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (141,15)-(141,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,16)-(141,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (141,24)-(141,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,25)-(141,41) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (141,41)-(141,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,42)-(141,55) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolFactory");
            #line hidden
            #line (141,55)-(141,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,56)-(141,58) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (141,58)-(141,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,60)-(141,113) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__ISymbolFactory", "SymbolFactory"));
            #line hidden
            #line (141,114)-(141,115) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
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
            #line (143,25)-(143,42) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol?");
            #line hidden
            #line (143,42)-(143,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,43)-(143,61) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingAssembly");
            #line hidden
            #line (143,61)-(143,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,62)-(143,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (143,64)-(143,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,66)-(143,124) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__AssemblySymbol", "ContainingAssembly"));
            #line hidden
            #line (143,125)-(143,126) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (145,9)-(145,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (145,15)-(145,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,16)-(145,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (145,24)-(145,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,25)-(145,39) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (145,39)-(145,40) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,40)-(145,60) 25 "SymbolGenerator.mxg"
            __cb.Write("DeclaringCompilation");
            #line hidden
            #line (145,60)-(145,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,61)-(145,63) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (145,63)-(145,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,65)-(145,122) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__Compilation", "DeclaringCompilation"));
            #line hidden
            #line (145,123)-(145,124) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (147,9)-(147,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (147,15)-(147,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,16)-(147,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (147,24)-(147,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,25)-(147,40) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol?");
            #line hidden
            #line (147,40)-(147,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,41)-(147,57) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingModule");
            #line hidden
            #line (147,57)-(147,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,58)-(147,60) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (147,60)-(147,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,62)-(147,116) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__ModuleSymbol", "ContainingModule"));
            #line hidden
            #line (147,117)-(147,118) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (149,9)-(149,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (149,15)-(149,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,16)-(149,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (149,24)-(149,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,25)-(149,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol?");
            #line hidden
            #line (149,45)-(149,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,46)-(149,67) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingDeclaration");
            #line hidden
            #line (149,67)-(149,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,68)-(149,70) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (149,70)-(149,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,72)-(149,136) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__DeclarationSymbol", "ContainingDeclaration"));
            #line hidden
            #line (149,137)-(149,138) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (151,9)-(151,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (151,15)-(151,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,16)-(151,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (151,24)-(151,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,25)-(151,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol?");
            #line hidden
            #line (151,38)-(151,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,39)-(151,53) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingType");
            #line hidden
            #line (151,53)-(151,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,54)-(151,56) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (151,56)-(151,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,58)-(151,108) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__TypeSymbol", "ContainingType"));
            #line hidden
            #line (151,109)-(151,110) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (153,9)-(153,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (153,15)-(153,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,16)-(153,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (153,24)-(153,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,25)-(153,43) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol?");
            #line hidden
            #line (153,43)-(153,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,44)-(153,63) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingNamespace");
            #line hidden
            #line (153,63)-(153,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,64)-(153,66) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (153,66)-(153,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,68)-(153,128) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__NamespaceSymbol", "ContainingNamespace"));
            #line hidden
            #line (153,129)-(153,130) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (155,9)-(155,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (155,15)-(155,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,16)-(155,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (155,24)-(155,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,25)-(155,41) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (155,41)-(155,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,42)-(155,61) 25 "SymbolGenerator.mxg"
            __cb.Write("GetLexicalSortKey()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (156,9)-(156,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (157,13)-(157,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (157,19)-(157,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,21)-(157,80) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__LexicalSortKey", "GetLexicalSortKey()"));
            #line hidden
            #line (157,81)-(157,82) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (158,9)-(158,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (160,9)-(160,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (160,15)-(160,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,16)-(160,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (160,24)-(160,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,25)-(160,29) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (160,29)-(160,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,30)-(160,52) 25 "SymbolGenerator.mxg"
            __cb.Write("HasUnsupportedMetadata");
            #line hidden
            #line (160,52)-(160,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,53)-(160,55) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (160,55)-(160,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,57)-(160,107) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "bool", "HasUnsupportedMetadata"));
            #line hidden
            #line (160,108)-(160,109) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (162,9)-(162,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (162,15)-(162,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,16)-(162,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (162,24)-(162,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,25)-(162,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (162,31)-(162,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,32)-(162,59) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentId()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (163,9)-(163,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (164,13)-(164,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (164,19)-(164,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,21)-(164,78) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string", "GetDocumentationCommentId()"));
            #line hidden
            #line (164,79)-(164,80) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (165,9)-(165,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (167,9)-(167,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (167,15)-(167,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,16)-(167,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (167,24)-(167,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,25)-(167,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (167,31)-(167,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,32)-(167,72) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentXml(__CultureInfo");
            #line hidden
            #line (167,72)-(167,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,73)-(167,89) 25 "SymbolGenerator.mxg"
            __cb.Write("preferredCulture");
            #line hidden
            #line (167,89)-(167,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,90)-(167,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (167,91)-(167,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,92)-(167,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (167,97)-(167,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,98)-(167,102) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (167,102)-(167,103) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,103)-(167,117) 25 "SymbolGenerator.mxg"
            __cb.Write("expandIncludes");
            #line hidden
            #line (167,117)-(167,118) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,118)-(167,119) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (167,119)-(167,120) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,120)-(167,126) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (167,126)-(167,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,127)-(167,146) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (167,146)-(167,147) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,147)-(167,164) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken");
            #line hidden
            #line (167,164)-(167,165) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,165)-(167,166) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (167,166)-(167,167) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,167)-(167,175) 25 "SymbolGenerator.mxg"
            __cb.Write("default)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (168,9)-(168,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (169,13)-(169,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (169,19)-(169,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (169,21)-(169,130) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string", "GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken)"));
            #line hidden
            #line (169,131)-(169,132) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (170,9)-(170,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first23 = true;
            #line (172,10)-(172,49) 13 "SymbolGenerator.mxg"
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
                #line (174,13)-(174,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (174,19)-(174,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,21)-(174,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (174,52)-(174,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (174,54)-(174,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (175,13)-(175,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (176,17)-(176,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (177,17)-(177,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (178,21)-(178,40) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(");
                #line hidden
                #line (178,41)-(178,68) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (178,69)-(178,93) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (178,94)-(178,123) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Phase?.Name ?? prop.Name);
                #line hidden
                #line (178,124)-(178,125) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (178,125)-(178,126) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,126)-(178,131) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (178,131)-(178,132) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (178,132)-(178,141) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first24 = true;
                #line (179,22)-(179,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("                ");
                    #line (180,25)-(180,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (180,27)-(180,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,28)-(180,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (180,30)-(180,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (180,49)-(180,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (180,67)-(180,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,68)-(180,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (180,71)-(180,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,72)-(180,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (180,75)-(180,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,76)-(180,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (180,84)-(180,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,85)-(180,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (180,91)-(180,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (180,92)-(180,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (180,94)-(180,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (180,125)-(180,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (181,25)-(181,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (181,29)-(181,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (181,30)-(181,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (181,36)-(181,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (181,38)-(181,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (181,68)-(181,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (182,22)-(182,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("                ");
                    #line (183,25)-(183,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (183,31)-(183,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (183,33)-(183,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (183,52)-(183,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first24) __cb.AppendLine();
                __cb.Push("            ");
                #line (185,17)-(185,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (186,13)-(186,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (189,9)-(189,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (189,18)-(189,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,19)-(189,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (189,27)-(189,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,28)-(189,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (189,32)-(189,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,33)-(189,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (189,54)-(189,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,55)-(189,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (189,71)-(189,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,72)-(189,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (189,87)-(189,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,88)-(189,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (189,105)-(189,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,106)-(189,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (189,118)-(189,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,119)-(189,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (189,138)-(189,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,139)-(189,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (190,9)-(190,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (191,14)-(191,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            #line (192,14)-(192,44) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            #line (193,14)-(193,52) 13 "SymbolGenerator.mxg"
            var basePhases = GetPhases(baseSymbol);
            #line hidden
            
            var __first25 = true;
            #line (194,14)-(194,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                var __first26 = true;
                #line (195,18)-(195,50) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    #line (196,22)-(196,41) 21 "SymbolGenerator.mxg"
                    hasNewPhase = true;
                    #line hidden
                    
                    #line (197,22)-(197,67) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    __cb.Push("            ");
                    #line (198,21)-(198,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (198,23)-(198,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,24)-(198,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("(incompletePart");
                    #line hidden
                    #line (198,39)-(198,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,40)-(198,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (198,42)-(198,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,44)-(198,71) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (198,72)-(198,95) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (198,96)-(198,101) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (198,102)-(198,103) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,103)-(198,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("||");
                    #line hidden
                    #line (198,105)-(198,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,106)-(198,120) 33 "SymbolGenerator.mxg"
                    __cb.Write("incompletePart");
                    #line hidden
                    #line (198,120)-(198,121) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,121)-(198,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (198,123)-(198,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,125)-(198,152) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (198,153)-(198,177) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (198,178)-(198,183) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (198,184)-(198,185) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (199,21)-(199,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (200,25)-(200,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (200,27)-(200,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (200,28)-(200,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("(NotePartComplete(");
                    #line hidden
                    #line (200,47)-(200,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (200,75)-(200,98) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (200,99)-(200,104) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (200,105)-(200,107) 33 "SymbolGenerator.mxg"
                    __cb.Write("))");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (201,25)-(201,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (202,29)-(202,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (202,32)-(202,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (202,33)-(202,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (202,44)-(202,45) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (202,45)-(202,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (202,46)-(202,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (202,47)-(202,77) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first27 = true;
                    #line (203,30)-(203,52) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("                    ");
                        #line (204,33)-(204,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (204,36)-(204,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (204,37)-(204,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (204,43)-(204,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (204,44)-(204,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (204,45)-(204,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (204,46)-(204,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (204,56)-(204,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (204,62)-(204,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (204,75)-(204,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (204,76)-(204,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first28 = true;
                        #line (205,34)-(205,61) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props)
                        #line hidden
                        
                        {
                            if (__first28)
                            {
                                __first28 = false;
                            }
                            __cb.Push("                    ");
                            #line (206,38)-(206,87) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first28) __cb.AppendLine();
                    }
                    #line (208,30)-(208,57) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("                    ");
                        #line (209,33)-(209,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (209,36)-(209,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,37)-(209,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (209,43)-(209,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,44)-(209,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (209,45)-(209,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,46)-(209,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (209,56)-(209,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (209,62)-(209,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (209,75)-(209,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,76)-(209,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                    ");
                        #line (210,34)-(210,76) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, props[0], "result"));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (211,30)-(211,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("                    ");
                        #line (212,33)-(212,42) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (212,43)-(212,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (212,49)-(212,62) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (212,62)-(212,63) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,63)-(212,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first27) __cb.AppendLine();
                    __cb.Push("                    ");
                    #line (214,29)-(214,63) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (215,29)-(215,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (216,29)-(216,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (216,47)-(216,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (216,75)-(216,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (216,100)-(216,105) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (216,106)-(216,108) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (217,25)-(217,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (218,25)-(218,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (218,31)-(218,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (218,32)-(218,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (219,21)-(219,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (220,21)-(220,25) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (220,25)-(220,26) 33 "SymbolGenerator.mxg"
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
            #line (223,14)-(223,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first29)
                {
                    __first29 = false;
                }
                __cb.Push("            ");
                #line (224,17)-(224,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (225,21)-(225,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (225,27)-(225,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,28)-(225,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (225,54)-(225,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,55)-(225,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (225,70)-(225,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,71)-(225,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (225,83)-(225,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (225,84)-(225,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (226,17)-(226,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (227,14)-(227,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first29)
                {
                    __first29 = false;
                }
                __cb.Push("            ");
                #line (228,17)-(228,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (228,23)-(228,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,24)-(228,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (228,50)-(228,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,51)-(228,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (228,66)-(228,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,67)-(228,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (228,79)-(228,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,80)-(228,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first29) __cb.AppendLine();
            __cb.Push("        ");
            #line (230,9)-(230,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (233,9)-(233,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (233,18)-(233,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,19)-(233,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (233,27)-(233,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,28)-(233,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (233,32)-(233,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,33)-(233,72) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Initialize(__DiagnosticBag");
            #line hidden
            #line (233,72)-(233,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,73)-(233,85) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (233,85)-(233,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,86)-(233,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (233,105)-(233,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (233,106)-(233,124) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (234,9)-(234,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (235,14)-(235,89) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Initialize(diagnostics, cancellationToken)"));
            #line hidden
            #line (235,90)-(235,91) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (236,9)-(236,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (238,9)-(238,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (238,18)-(238,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (238,19)-(238,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (238,27)-(238,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (238,28)-(238,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (238,35)-(238,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (238,36)-(238,65) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Name(__DiagnosticBag");
            #line hidden
            #line (238,65)-(238,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (238,66)-(238,78) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (238,78)-(238,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (238,79)-(238,98) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (238,98)-(238,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (238,99)-(238,117) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (239,9)-(239,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (240,13)-(240,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (240,19)-(240,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (240,21)-(240,97) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_Name(diagnostics, cancellationToken)"));
            #line hidden
            #line (240,98)-(240,99) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (241,9)-(241,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (243,9)-(243,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (243,18)-(243,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,19)-(243,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (243,27)-(243,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,28)-(243,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (243,35)-(243,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,36)-(243,73) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_MetadataName(__DiagnosticBag");
            #line hidden
            #line (243,73)-(243,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,74)-(243,86) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (243,86)-(243,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,87)-(243,106) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (243,106)-(243,107) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,107)-(243,125) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (244,9)-(244,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (245,13)-(245,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (245,19)-(245,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (245,21)-(245,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_MetadataName(diagnostics, cancellationToken)"));
            #line hidden
            #line (245,106)-(245,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (246,9)-(246,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (248,9)-(248,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (248,18)-(248,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,19)-(248,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (248,27)-(248,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,28)-(248,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__Symbol>");
            #line hidden
            #line (248,89)-(248,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,90)-(248,141) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_CreateContainedSymbols(__DiagnosticBag");
            #line hidden
            #line (248,141)-(248,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,142)-(248,154) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (248,154)-(248,155) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,155)-(248,174) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (248,174)-(248,175) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (248,175)-(248,193) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (249,9)-(249,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (250,13)-(250,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (250,19)-(250,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,21)-(250,173) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__Symbol>", "CompletePart_CreateContainedSymbols(diagnostics, cancellationToken)"));
            #line hidden
            #line (250,174)-(250,175) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (251,9)-(251,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (253,9)-(253,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (253,18)-(253,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,19)-(253,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (253,27)-(253,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,28)-(253,98) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>");
            #line hidden
            #line (253,98)-(253,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,99)-(253,134) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Attributes(__DiagnosticBag");
            #line hidden
            #line (253,134)-(253,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,135)-(253,147) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (253,147)-(253,148) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,148)-(253,167) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (253,167)-(253,168) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,168)-(253,186) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (254,9)-(254,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (255,13)-(255,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (255,19)-(255,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (255,21)-(255,166) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>", "Complete_Attributes(diagnostics, cancellationToken)"));
            #line hidden
            #line (255,167)-(255,168) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (256,9)-(256,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (258,9)-(258,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (258,18)-(258,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,19)-(258,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (258,27)-(258,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,28)-(258,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (258,32)-(258,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,33)-(258,88) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_ComputeNonSymbolProperties(__DiagnosticBag");
            #line hidden
            #line (258,88)-(258,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,89)-(258,101) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (258,101)-(258,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,102)-(258,121) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (258,121)-(258,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,122)-(258,140) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (259,9)-(259,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (260,14)-(260,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken)"));
            #line hidden
            #line (260,106)-(260,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (261,9)-(261,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (263,9)-(263,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (263,18)-(263,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,19)-(263,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (263,27)-(263,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,28)-(263,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (263,32)-(263,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,33)-(263,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Finalize(__DiagnosticBag");
            #line hidden
            #line (263,70)-(263,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,71)-(263,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (263,83)-(263,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,84)-(263,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (263,103)-(263,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,104)-(263,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (264,9)-(264,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (265,14)-(265,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Finalize(diagnostics, cancellationToken)"));
            #line hidden
            #line (265,88)-(265,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (266,9)-(266,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (268,9)-(268,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (268,18)-(268,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,19)-(268,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (268,27)-(268,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,28)-(268,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (268,32)-(268,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,33)-(268,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Validate(__DiagnosticBag");
            #line hidden
            #line (268,70)-(268,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,71)-(268,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (268,83)-(268,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,84)-(268,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (268,103)-(268,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,104)-(268,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (269,9)-(269,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (270,14)-(270,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Validate(diagnostics, cancellationToken)"));
            #line hidden
            #line (270,88)-(270,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (271,9)-(271,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first30 = true;
            #line (273,10)-(273,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (275,14)-(275,80) 17 "SymbolGenerator.mxg"
                var virtOvrd = basePhases.Contains(phase) ? "override" : "virtual";
                #line hidden
                
                #line (276,14)-(276,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first31 = true;
                #line (277,14)-(277,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    #line (278,18)-(278,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (279,17)-(279,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (279,26)-(279,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,28)-(279,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (279,37)-(279,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,39)-(279,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (279,50)-(279,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,51)-(279,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (279,61)-(279,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (279,67)-(279,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (279,83)-(279,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,84)-(279,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (279,96)-(279,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,97)-(279,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (279,116)-(279,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (279,117)-(279,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (280,17)-(280,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (281,21)-(281,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (281,27)-(281,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (281,29)-(281,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (281,112)-(281,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (282,17)-(282,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (283,14)-(283,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    #line (284,18)-(284,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (285,18)-(285,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (286,17)-(286,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (286,26)-(286,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (286,28)-(286,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (286,37)-(286,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (286,39)-(286,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (286,50)-(286,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (286,51)-(286,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (286,61)-(286,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (286,67)-(286,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (286,83)-(286,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (286,84)-(286,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (286,96)-(286,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (286,97)-(286,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (286,116)-(286,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (286,117)-(286,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (287,17)-(287,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (288,21)-(288,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (288,27)-(288,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (288,29)-(288,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (288,112)-(288,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (289,17)-(289,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (290,14)-(290,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("        ");
                    #line (291,17)-(291,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (291,26)-(291,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (291,28)-(291,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (291,37)-(291,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (291,38)-(291,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (291,42)-(291,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (291,43)-(291,52) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (291,53)-(291,58) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (291,59)-(291,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (291,75)-(291,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (291,76)-(291,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (291,88)-(291,89) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (291,89)-(291,108) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (291,108)-(291,109) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (291,109)-(291,127) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (292,17)-(292,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (293,22)-(293,92) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (293,93)-(293,94) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (294,17)-(294,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
            }
            if (!__first30) __cb.AppendLine();
            __cb.Push("    ");
            #line (297,5)-(297,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (299,5)-(299,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (299,11)-(299,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,12)-(299,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (299,20)-(299,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,21)-(299,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (299,26)-(299,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,28)-(299,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (299,56)-(299,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,57)-(299,58) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (299,58)-(299,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first32 = true;
            #line (299,60)-(299,83) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                #line (299,84)-(299,132) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl");
                #line hidden
            }
            #line (299,133)-(299,137) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                #line (299,139)-(299,170) 28 "SymbolGenerator.mxg"
                __cb.Write(GetImplName(symbol, baseSymbol));
                #line hidden
            }
            #line (299,179)-(299,180) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (299,180)-(299,181) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,182)-(299,209) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (300,5)-(300,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first33 = true;
            #line (301,10)-(301,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("        ");
                #line (302,13)-(302,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (302,19)-(302,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (302,21)-(302,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (302,52)-(302,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (302,54)-(302,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (302,64)-(302,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (302,65)-(302,67) 29 "SymbolGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (302,67)-(302,68) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (302,68)-(302,70) 29 "SymbolGenerator.mxg"
                __cb.Write("((");
                #line hidden
                #line (302,71)-(302,98) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (302,99)-(302,111) 29 "SymbolGenerator.mxg"
                __cb.Write(")__Wrapped).");
                #line hidden
                #line (302,112)-(302,121) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (302,122)-(302,123) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first34 = true;
            #line (305,10)-(305,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                var __first35 = true;
                #line (306,14)-(306,46) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.WriteLine();
                    __cb.Pop();
                    #line (308,18)-(308,63) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    var __first36 = true;
                    #line (309,18)-(309,40) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        #line (310,22)-(310,123) 25 "SymbolGenerator.mxg"
                        var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                        #line hidden
                        
                        var __first37 = true;
                        #line (311,22)-(311,62) 25 "SymbolGenerator.mxg"
                        if (props.Where(p => p.IsDerived).Any())
                        #line hidden
                        
                        {
                            if (__first37)
                            {
                                __first37 = false;
                            }
                            __cb.Push("        ");
                            #line (312,25)-(312,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (312,31)-(312,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (312,32)-(312,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (312,40)-(312,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (312,42)-(312,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (312,53)-(312,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (312,54)-(312,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (312,64)-(312,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (312,70)-(312,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (312,86)-(312,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (312,87)-(312,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (312,99)-(312,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (312,100)-(312,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (312,119)-(312,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (312,120)-(312,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (313,22)-(313,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first37)
                            {
                                __first37 = false;
                            }
                            __cb.Push("        ");
                            #line (314,25)-(314,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (314,31)-(314,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (314,32)-(314,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (314,39)-(314,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (314,41)-(314,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (314,52)-(314,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (314,53)-(314,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (314,63)-(314,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (314,69)-(314,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (314,85)-(314,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (314,86)-(314,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (314,98)-(314,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (314,99)-(314,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (314,118)-(314,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (314,119)-(314,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (315,25)-(315,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (316,29)-(316,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (316,31)-(316,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (316,32)-(316,36) 41 "SymbolGenerator.mxg"
                            __cb.Write("TODO");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (317,29)-(317,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (317,35)-(317,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (317,36)-(317,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            var __first38 = true;
                            foreach (var __item39 in 
                            #line (317,38)-(317,94) 29 "SymbolGenerator.mxg"
                            from prop in props select GetDefaultValue(symbol, prop) 
                            #line hidden
                            )
                            {
                                if (__first38)
                                {
                                    __first38 = false;
                                }
                                else
                                {
                                    __cb.Push("            ");
                                    __cb.DontIgnoreLastLineEnd = true;
                                    #line (317,104)-(317,108) 48 "SymbolGenerator.mxg"
                                    __cb.Write(", ");
                                    #line hidden
                                    __cb.DontIgnoreLastLineEnd = false;
                                    __cb.Pop();
                                }
                                __cb.Write(__item39);
                            }
                            #line (317,109)-(317,111) 41 "SymbolGenerator.mxg"
                            __cb.Write(");");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (318,25)-(318,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first37) __cb.AppendLine();
                    }
                    #line (320,18)-(320,45) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        #line (321,22)-(321,41) 25 "SymbolGenerator.mxg"
                        var prop = props[0];
                        #line hidden
                        
                        #line (322,22)-(322,69) 25 "SymbolGenerator.mxg"
                        var returnType = GetTypeName(symbol, prop.Type);
                        #line hidden
                        
                        var __first40 = true;
                        #line (323,22)-(323,41) 25 "SymbolGenerator.mxg"
                        if (prop.IsDerived)
                        #line hidden
                        
                        {
                            if (__first40)
                            {
                                __first40 = false;
                            }
                            __cb.Push("        ");
                            #line (324,25)-(324,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (324,31)-(324,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (324,32)-(324,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (324,40)-(324,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (324,42)-(324,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (324,53)-(324,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (324,54)-(324,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (324,64)-(324,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (324,70)-(324,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (324,86)-(324,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (324,87)-(324,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (324,99)-(324,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (324,100)-(324,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (324,119)-(324,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (324,120)-(324,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (325,22)-(325,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first40)
                            {
                                __first40 = false;
                            }
                            __cb.Push("        ");
                            #line (326,25)-(326,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (326,31)-(326,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (326,32)-(326,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (326,39)-(326,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (326,41)-(326,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (326,52)-(326,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (326,53)-(326,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (326,63)-(326,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (326,69)-(326,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (326,85)-(326,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (326,86)-(326,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (326,98)-(326,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (326,99)-(326,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (326,118)-(326,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (326,119)-(326,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (327,25)-(327,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (328,29)-(328,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (328,31)-(328,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (328,32)-(328,36) 41 "SymbolGenerator.mxg"
                            __cb.Write("TODO");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (329,29)-(329,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (329,35)-(329,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (329,37)-(329,66) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (329,67)-(329,68) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (330,25)-(330,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first40) __cb.AppendLine();
                    }
                    #line (332,18)-(332,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        __cb.Push("        ");
                        #line (333,21)-(333,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (333,27)-(333,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (333,28)-(333,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (333,36)-(333,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (333,37)-(333,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("void");
                        #line hidden
                        #line (333,41)-(333,42) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (333,42)-(333,51) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (333,52)-(333,57) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (333,58)-(333,74) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (333,74)-(333,75) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (333,75)-(333,87) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (333,87)-(333,88) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (333,88)-(333,107) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (333,107)-(333,108) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (333,108)-(333,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first36) __cb.AppendLine();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("    ");
            #line (337,5)-(337,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (338,1)-(338,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (341,9)-(341,42) 22 "SymbolGenerator.mxg"
        public string GenerateMultiBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (342,1)-(342,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (342,10)-(342,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,12)-(342,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (342,33)-(342,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (343,1)-(343,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (344,5)-(344,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (344,10)-(344,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (344,11)-(344,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (344,20)-(344,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (344,21)-(344,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (344,22)-(344,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (344,23)-(344,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (345,5)-(345,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (345,10)-(345,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,11)-(345,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (345,25)-(345,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,26)-(345,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (345,27)-(345,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,28)-(345,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (346,5)-(346,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (346,10)-(346,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (346,11)-(346,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (346,30)-(346,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (346,31)-(346,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (346,32)-(346,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (346,33)-(346,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (347,5)-(347,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (347,10)-(347,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,11)-(347,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (347,19)-(347,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,20)-(347,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (347,21)-(347,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,22)-(347,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (348,5)-(348,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (348,10)-(348,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,11)-(348,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (348,28)-(348,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,29)-(348,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (348,30)-(348,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (348,31)-(348,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (349,5)-(349,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (349,10)-(349,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,11)-(349,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (349,26)-(349,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,27)-(349,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (349,28)-(349,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (349,29)-(349,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (350,5)-(350,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (350,10)-(350,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,11)-(350,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (350,28)-(350,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,29)-(350,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (350,30)-(350,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,31)-(350,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (351,5)-(351,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (351,10)-(351,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,11)-(351,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (351,27)-(351,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,28)-(351,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (351,29)-(351,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (351,30)-(351,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (352,5)-(352,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (352,10)-(352,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,11)-(352,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (352,26)-(352,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,27)-(352,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (352,28)-(352,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (352,29)-(352,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (353,5)-(353,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (353,10)-(353,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,11)-(353,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (353,27)-(353,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,28)-(353,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (353,29)-(353,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (353,30)-(353,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (354,5)-(354,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (354,10)-(354,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (354,11)-(354,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (354,30)-(354,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (354,31)-(354,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (354,32)-(354,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (354,33)-(354,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (355,5)-(355,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (355,10)-(355,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,11)-(355,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (355,36)-(355,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,37)-(355,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (355,38)-(355,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (355,39)-(355,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (356,5)-(356,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (356,10)-(356,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,11)-(356,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (356,38)-(356,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,39)-(356,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (356,40)-(356,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,41)-(356,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (358,5)-(358,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (358,11)-(358,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,12)-(358,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (358,19)-(358,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,20)-(358,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (358,25)-(358,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,27)-(358,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (358,55)-(358,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,56)-(358,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (358,57)-(358,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,58)-(358,107) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst,");
            #line hidden
            #line (358,107)-(358,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,109)-(358,136) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (359,5)-(359,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first41 = true;
            #line (360,10)-(360,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                var __first42 = true;
                #line (361,14)-(361,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("        ");
                    #line (362,17)-(362,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (362,24)-(362,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,25)-(362,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (362,31)-(362,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,33)-(362,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (362,60)-(362,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,62)-(362,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (362,81)-(362,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,82)-(362,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (362,83)-(362,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,84)-(362,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (362,87)-(362,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,89)-(362,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (362,116)-(362,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (363,14)-(363,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("        ");
                    #line (364,17)-(364,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (364,24)-(364,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (364,26)-(364,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (364,53)-(364,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (364,55)-(364,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (364,74)-(364,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first42) __cb.AppendLine();
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("        ");
            #line (367,9)-(367,11) 25 "SymbolGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (367,11)-(367,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (367,12)-(367,16) 25 "SymbolGenerator.mxg"
            __cb.Write("TODO");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (368,5)-(368,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (369,1)-(369,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (372,9)-(372,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (373,1)-(373,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (373,6)-(373,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,7)-(373,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (374,1)-(374,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (374,6)-(374,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,7)-(374,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (375,1)-(375,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (375,6)-(375,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,7)-(375,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (376,1)-(376,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (376,6)-(376,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,7)-(376,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (377,1)-(377,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (377,6)-(377,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,7)-(377,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (378,1)-(378,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (378,6)-(378,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,7)-(378,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (380,1)-(380,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (380,10)-(380,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,12)-(380,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (380,33)-(380,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (381,1)-(381,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (382,5)-(382,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (382,11)-(382,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,12)-(382,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (382,17)-(382,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,19)-(382,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (382,47)-(382,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,48)-(382,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (382,49)-(382,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,51)-(382,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (383,5)-(383,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (384,5)-(384,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (385,1)-(385,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (388,9)-(388,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first43 = true;
            #line (389,6)-(389,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                var __first44 = true;
                #line (390,10)-(390,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    __cb.Push("");
                    #line (391,13)-(391,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (391,15)-(391,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (391,16)-(391,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (391,19)-(391,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (391,28)-(391,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (392,13)-(392,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (393,18)-(393,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (393,37)-(393,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (393,47)-(393,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (393,49)-(393,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (393,58)-(393,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (394,13)-(394,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (395,10)-(395,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    __cb.Push("");
                    #line (396,13)-(396,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (396,15)-(396,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (396,16)-(396,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (396,18)-(396,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (396,27)-(396,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (396,28)-(396,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (396,30)-(396,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (396,32)-(396,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (396,62)-(396,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (397,13)-(397,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (398,18)-(398,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (398,37)-(398,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (398,47)-(398,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (398,49)-(398,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (398,58)-(398,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (399,13)-(399,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first44) __cb.AppendLine();
            }
            #line (401,6)-(401,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                __cb.Push("");
                #line (402,10)-(402,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (402,29)-(402,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (402,30)-(402,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (402,31)-(402,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (402,33)-(402,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (402,42)-(402,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (406,9)-(406,46) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (407,5)-(407,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (407,15)-(407,42) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (407,43)-(407,44) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (407,44)-(407,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (407,46)-(407,73) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (407,74)-(407,80) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (407,80)-(407,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (407,81)-(407,83) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (407,83)-(407,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (407,84)-(407,89) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (407,90)-(407,94) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (407,95)-(407,96) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (410,9)-(410,59) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string type, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (411,5)-(411,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (411,15)-(411,19) 24 "SymbolGenerator.mxg"
            __cb.Write(type);
            #line hidden
            #line (411,20)-(411,21) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (411,21)-(411,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,23)-(411,50) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (411,51)-(411,52) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (411,52)-(411,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,54)-(411,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (411,82)-(411,88) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (411,88)-(411,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,89)-(411,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (411,91)-(411,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,92)-(411,97) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (411,98)-(411,102) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (411,103)-(411,104) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}