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
            __cb.Push("");
            #line (43,1)-(43,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (43,10)-(43,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,12)-(43,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (43,33)-(43,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,1)-(44,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
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
            #line (45,11)-(45,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (45,20)-(45,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,21)-(45,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (45,22)-(45,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,23)-(45,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (46,11)-(46,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (46,25)-(46,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,26)-(46,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (46,27)-(46,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,28)-(46,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            __cb.Write("__MergedDeclaration");
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
            #line (47,33)-(47,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (48,5)-(48,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (48,10)-(48,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,11)-(48,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (48,19)-(48,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,20)-(48,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (48,21)-(48,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,22)-(48,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (49,5)-(49,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (49,10)-(49,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,11)-(49,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (49,28)-(49,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,29)-(49,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (49,30)-(49,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (49,31)-(49,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,5)-(50,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (50,10)-(50,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,11)-(50,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (50,26)-(50,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,27)-(50,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (50,28)-(50,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,29)-(50,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (51,5)-(51,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (51,10)-(51,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,11)-(51,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (51,28)-(51,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,29)-(51,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (51,30)-(51,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (51,31)-(51,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (52,5)-(52,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (52,10)-(52,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,11)-(52,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (52,27)-(52,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,28)-(52,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (52,29)-(52,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (52,30)-(52,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (53,5)-(53,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (53,10)-(53,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,11)-(53,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (53,26)-(53,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,27)-(53,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (53,28)-(53,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (53,29)-(53,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (54,5)-(54,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (54,10)-(54,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,11)-(54,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (54,27)-(54,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,28)-(54,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (54,29)-(54,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (54,30)-(54,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            #line (55,11)-(55,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (55,30)-(55,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,31)-(55,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (55,32)-(55,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,33)-(55,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
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
            #line (56,11)-(56,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (56,23)-(56,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,24)-(56,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (56,25)-(56,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (56,26)-(56,81) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.PooledObjects.ObjectPool<");
            #line hidden
            #line (56,82)-(56,109) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (56,110)-(56,112) 25 "SymbolGenerator.mxg"
            __cb.Write(">;");
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
            #line (57,11)-(57,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (57,36)-(57,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,37)-(57,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (57,38)-(57,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,39)-(57,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            #line (58,11)-(58,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (58,38)-(58,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,39)-(58,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (58,40)-(58,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,41)-(58,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (60,5)-(60,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (60,13)-(60,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,14)-(60,20) 25 "SymbolGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (60,20)-(60,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,21)-(60,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (60,26)-(60,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,28)-(60,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (60,56)-(60,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,57)-(60,58) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (60,58)-(60,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,59)-(60,108) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst,");
            #line hidden
            #line (60,108)-(60,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,110)-(60,137) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (61,5)-(61,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first7 = true;
            #line (62,10)-(62,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                var __first8 = true;
                #line (63,14)-(63,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("        ");
                    #line (64,17)-(64,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (64,24)-(64,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,25)-(64,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (64,31)-(64,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,33)-(64,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (64,60)-(64,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,62)-(64,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (64,81)-(64,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,82)-(64,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (64,83)-(64,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,84)-(64,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (64,87)-(64,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (64,89)-(64,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (64,116)-(64,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (65,14)-(65,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("        ");
                    #line (66,17)-(66,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (66,24)-(66,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (66,26)-(66,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (66,53)-(66,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (66,55)-(66,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (66,74)-(66,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
            }
            if (!__first7) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,9)-(70,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (70,15)-(70,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,17)-(70,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (70,45)-(70,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (70,54)-(70,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,55)-(70,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (70,65)-(70,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,66)-(70,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (70,85)-(70,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,86)-(70,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (70,98)-(70,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,99)-(70,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (70,113)-(70,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,114)-(70,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (70,126)-(70,127) 25 "SymbolGenerator.mxg"
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
            #line (71,31)-(71,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (71,43)-(71,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,44)-(71,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
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
            #line (75,9)-(75,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (75,15)-(75,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,17)-(75,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (75,45)-(75,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (75,54)-(75,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,55)-(75,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (75,65)-(75,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,66)-(75,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (75,80)-(75,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,81)-(75,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (75,93)-(75,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (76,13)-(76,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (76,14)-(76,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,15)-(76,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (76,30)-(76,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,31)-(76,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (77,9)-(77,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (78,9)-(78,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,9)-(80,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (80,15)-(80,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,17)-(80,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (80,45)-(80,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (80,54)-(80,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,55)-(80,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (80,65)-(80,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,66)-(80,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (80,75)-(80,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,76)-(80,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (80,89)-(80,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (81,13)-(81,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (81,14)-(81,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,15)-(81,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (81,30)-(81,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,31)-(81,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,9)-(82,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (83,9)-(83,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (85,15)-(85,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,17)-(85,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (85,45)-(85,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (85,54)-(85,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,55)-(85,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (85,65)-(85,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,66)-(85,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (85,83)-(85,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,84)-(85,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (85,94)-(85,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (86,13)-(86,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (86,14)-(86,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,15)-(86,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (86,30)-(86,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,31)-(86,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (87,9)-(87,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (88,9)-(88,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (90,9)-(90,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (90,15)-(90,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,17)-(90,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (90,45)-(90,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (90,54)-(90,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,55)-(90,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (90,65)-(90,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,66)-(90,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (90,85)-(90,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,86)-(90,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (90,98)-(90,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,99)-(90,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (90,113)-(90,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,114)-(90,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (90,126)-(90,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,127)-(90,134) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (90,134)-(90,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,135)-(90,140) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (90,140)-(90,141) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,141)-(90,148) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (90,148)-(90,149) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,149)-(90,162) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (90,162)-(90,163) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,163)-(90,190) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (90,190)-(90,191) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (90,191)-(90,201) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first9 = true;
            #line (90,202)-(90,245) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                #line (90,246)-(90,247) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (90,247)-(90,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (90,249)-(90,279) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (90,280)-(90,281) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (90,282)-(90,300) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (90,314)-(90,315) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (90,315)-(90,316) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (91,13)-(91,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (91,14)-(91,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,15)-(91,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (91,30)-(91,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,31)-(91,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (91,43)-(91,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,44)-(91,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (91,56)-(91,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,57)-(91,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (91,62)-(91,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,63)-(91,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (91,76)-(91,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,77)-(91,88) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (92,9)-(92,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first10 = true;
            #line (93,14)-(93,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                var __first11 = true;
                #line (94,18)-(94,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    var __first12 = true;
                    #line (95,22)-(95,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first12)
                        {
                            __first12 = false;
                        }
                        __cb.Push("            ");
                        #line (96,25)-(96,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (96,27)-(96,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (96,28)-(96,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (96,31)-(96,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (96,50)-(96,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (97,25)-(97,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (98,30)-(98,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (98,49)-(98,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (98,59)-(98,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (98,61)-(98,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (98,80)-(98,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (99,25)-(99,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (100,22)-(100,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first12)
                        {
                            __first12 = false;
                        }
                        __cb.Push("            ");
                        #line (101,25)-(101,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (101,27)-(101,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (101,28)-(101,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (101,30)-(101,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (101,49)-(101,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (101,50)-(101,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (101,52)-(101,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (101,54)-(101,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (101,84)-(101,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (102,25)-(102,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (103,30)-(103,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (103,49)-(103,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (103,59)-(103,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (103,61)-(103,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (103,80)-(103,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (104,25)-(104,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first12) __cb.AppendLine();
                }
                #line (106,18)-(106,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    __cb.Push("            ");
                    #line (107,22)-(107,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (107,41)-(107,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (107,42)-(107,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (107,43)-(107,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (107,45)-(107,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (107,64)-(107,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first11) __cb.AppendLine();
            }
            if (!__first10) __cb.AppendLine();
            __cb.Push("        ");
            #line (110,9)-(110,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (112,9)-(112,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (112,15)-(112,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,17)-(112,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (112,45)-(112,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (112,54)-(112,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,55)-(112,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (112,65)-(112,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,66)-(112,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (112,80)-(112,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,81)-(112,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (112,93)-(112,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,94)-(112,101) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (112,101)-(112,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,102)-(112,107) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (112,107)-(112,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,108)-(112,115) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (112,115)-(112,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,116)-(112,129) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (112,129)-(112,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,130)-(112,157) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (112,157)-(112,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,158)-(112,168) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first13 = true;
            #line (112,169)-(112,212) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                #line (112,213)-(112,214) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (112,214)-(112,215) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (112,216)-(112,246) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (112,247)-(112,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (112,249)-(112,267) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (112,281)-(112,282) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (112,282)-(112,283) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (113,13)-(113,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (113,14)-(113,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,15)-(113,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (113,30)-(113,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,31)-(113,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (113,43)-(113,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,44)-(113,49) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (113,49)-(113,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,50)-(113,63) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (113,63)-(113,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,64)-(113,75) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (114,9)-(114,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first14 = true;
            #line (115,14)-(115,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                var __first15 = true;
                #line (116,18)-(116,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    var __first16 = true;
                    #line (117,22)-(117,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first16)
                        {
                            __first16 = false;
                        }
                        __cb.Push("            ");
                        #line (118,25)-(118,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (118,27)-(118,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,28)-(118,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (118,31)-(118,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (118,50)-(118,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (119,25)-(119,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (120,30)-(120,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (120,49)-(120,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (120,59)-(120,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (120,61)-(120,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (120,80)-(120,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (121,25)-(121,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (122,22)-(122,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first16)
                        {
                            __first16 = false;
                        }
                        __cb.Push("            ");
                        #line (123,25)-(123,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (123,27)-(123,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,28)-(123,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (123,30)-(123,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (123,49)-(123,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,50)-(123,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (123,52)-(123,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,54)-(123,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (123,84)-(123,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (124,25)-(124,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (125,30)-(125,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (125,49)-(125,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (125,59)-(125,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,61)-(125,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (125,80)-(125,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (126,25)-(126,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first16) __cb.AppendLine();
                }
                #line (128,18)-(128,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    __cb.Push("            ");
                    #line (129,22)-(129,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (129,41)-(129,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (129,42)-(129,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (129,43)-(129,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (129,45)-(129,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (129,64)-(129,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first15) __cb.AppendLine();
            }
            if (!__first14) __cb.AppendLine();
            __cb.Push("        ");
            #line (132,9)-(132,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (134,9)-(134,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (134,15)-(134,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,17)-(134,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (134,45)-(134,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (134,54)-(134,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,55)-(134,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (134,65)-(134,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,66)-(134,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (134,75)-(134,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,76)-(134,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (134,89)-(134,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,90)-(134,97) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (134,97)-(134,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,98)-(134,103) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (134,103)-(134,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,104)-(134,111) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (134,111)-(134,112) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,112)-(134,125) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (134,125)-(134,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,126)-(134,153) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (134,153)-(134,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,154)-(134,164) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first17 = true;
            #line (134,165)-(134,208) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                #line (134,209)-(134,210) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (134,210)-(134,211) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (134,212)-(134,242) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (134,243)-(134,244) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (134,245)-(134,263) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (134,277)-(134,278) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (134,278)-(134,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (135,13)-(135,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (135,14)-(135,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,15)-(135,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (135,30)-(135,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,31)-(135,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (135,44)-(135,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,45)-(135,50) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (135,50)-(135,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,51)-(135,64) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (135,64)-(135,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,65)-(135,76) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (136,9)-(136,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first18 = true;
            #line (137,14)-(137,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                var __first19 = true;
                #line (138,18)-(138,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    var __first20 = true;
                    #line (139,22)-(139,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("            ");
                        #line (140,25)-(140,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (140,27)-(140,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (140,28)-(140,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (140,31)-(140,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (140,50)-(140,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (141,25)-(141,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (142,30)-(142,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (142,49)-(142,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (142,59)-(142,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (142,61)-(142,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (142,80)-(142,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (143,25)-(143,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (144,22)-(144,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first20)
                        {
                            __first20 = false;
                        }
                        __cb.Push("            ");
                        #line (145,25)-(145,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (145,27)-(145,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (145,28)-(145,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (145,30)-(145,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (145,49)-(145,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (145,50)-(145,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (145,52)-(145,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (145,54)-(145,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (145,84)-(145,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (146,25)-(146,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (147,30)-(147,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (147,49)-(147,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (147,59)-(147,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (147,61)-(147,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (147,80)-(147,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (148,25)-(148,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first20) __cb.AppendLine();
                }
                #line (150,18)-(150,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("            ");
                    #line (151,22)-(151,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (151,41)-(151,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (151,42)-(151,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (151,43)-(151,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (151,45)-(151,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (151,64)-(151,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first19) __cb.AppendLine();
            }
            if (!__first18) __cb.AppendLine();
            __cb.Push("        ");
            #line (154,9)-(154,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (156,9)-(156,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (156,15)-(156,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,17)-(156,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (156,45)-(156,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (156,54)-(156,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,55)-(156,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (156,65)-(156,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,66)-(156,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (156,83)-(156,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,84)-(156,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (156,94)-(156,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,95)-(156,102) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (156,102)-(156,103) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,103)-(156,108) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (156,108)-(156,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,109)-(156,116) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (156,116)-(156,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,117)-(156,130) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (156,130)-(156,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,131)-(156,158) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (156,158)-(156,159) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,159)-(156,169) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first21 = true;
            #line (156,170)-(156,213) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (156,214)-(156,215) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (156,215)-(156,216) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (156,217)-(156,247) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (156,248)-(156,249) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (156,250)-(156,268) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (156,282)-(156,283) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (156,283)-(156,284) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (157,13)-(157,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (157,14)-(157,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,15)-(157,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (157,30)-(157,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,31)-(157,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (157,41)-(157,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,42)-(157,47) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (157,47)-(157,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,48)-(157,61) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (157,61)-(157,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,62)-(157,73) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (158,9)-(158,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first22 = true;
            #line (159,14)-(159,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                var __first23 = true;
                #line (160,18)-(160,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first23)
                    {
                        __first23 = false;
                    }
                    var __first24 = true;
                    #line (161,22)-(161,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first24)
                        {
                            __first24 = false;
                        }
                        __cb.Push("            ");
                        #line (162,25)-(162,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (162,27)-(162,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (162,28)-(162,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (162,31)-(162,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (162,50)-(162,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (163,25)-(163,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (164,30)-(164,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (164,49)-(164,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (164,59)-(164,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (164,61)-(164,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (164,80)-(164,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (165,25)-(165,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (166,22)-(166,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first24)
                        {
                            __first24 = false;
                        }
                        __cb.Push("            ");
                        #line (167,25)-(167,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (167,27)-(167,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,28)-(167,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (167,30)-(167,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (167,49)-(167,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,50)-(167,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (167,52)-(167,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,54)-(167,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (167,84)-(167,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (168,25)-(168,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (169,30)-(169,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (169,49)-(169,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (169,59)-(169,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,61)-(169,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (169,80)-(169,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (170,25)-(170,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first24) __cb.AppendLine();
                }
                #line (172,18)-(172,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first23)
                    {
                        __first23 = false;
                    }
                    __cb.Push("            ");
                    #line (173,22)-(173,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (173,41)-(173,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (173,42)-(173,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (173,43)-(173,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (173,45)-(173,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (173,64)-(173,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first23) __cb.AppendLine();
            }
            if (!__first22) __cb.AppendLine();
            __cb.Push("        ");
            #line (176,9)-(176,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first25 = true;
            #line (178,10)-(178,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (180,13)-(180,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (180,19)-(180,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,21)-(180,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (180,52)-(180,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (180,54)-(180,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (181,13)-(181,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (182,17)-(182,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (183,17)-(183,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (184,21)-(184,40) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(");
                #line hidden
                #line (184,41)-(184,68) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (184,69)-(184,93) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (184,94)-(184,103) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (184,104)-(184,105) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (184,105)-(184,106) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (184,106)-(184,111) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (184,111)-(184,112) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (184,112)-(184,121) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first26 = true;
                #line (185,22)-(185,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("                ");
                    #line (186,25)-(186,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (186,27)-(186,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,28)-(186,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (186,30)-(186,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (186,49)-(186,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (186,67)-(186,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,68)-(186,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (186,71)-(186,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,72)-(186,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (186,75)-(186,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,76)-(186,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (186,84)-(186,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,85)-(186,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (186,91)-(186,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (186,92)-(186,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (186,94)-(186,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (186,125)-(186,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (187,25)-(187,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (187,29)-(187,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,30)-(187,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (187,36)-(187,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (187,38)-(187,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (187,68)-(187,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (188,22)-(188,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("                ");
                    #line (189,25)-(189,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (189,31)-(189,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (189,33)-(189,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (189,52)-(189,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
                __cb.Push("            ");
                #line (191,17)-(191,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (192,13)-(192,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first25) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (195,9)-(195,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (195,18)-(195,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,19)-(195,25) 25 "SymbolGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (195,25)-(195,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,26)-(195,34) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (195,34)-(195,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,35)-(195,39) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (195,39)-(195,40) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,40)-(195,61) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (195,61)-(195,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,62)-(195,78) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (195,78)-(195,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,79)-(195,94) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (195,94)-(195,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,95)-(195,112) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (195,112)-(195,113) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,113)-(195,125) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (195,125)-(195,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,126)-(195,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (195,145)-(195,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,146)-(195,164) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (196,9)-(196,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (197,14)-(197,44) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            var __first27 = true;
            #line (198,14)-(198,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                #line (199,18)-(199,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (200,17)-(200,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (200,19)-(200,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,20)-(200,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (200,35)-(200,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,36)-(200,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (200,38)-(200,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,40)-(200,67) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (200,68)-(200,91) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (200,92)-(200,97) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (200,98)-(200,99) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,99)-(200,101) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (200,101)-(200,102) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,102)-(200,116) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (200,116)-(200,117) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,117)-(200,119) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (200,119)-(200,120) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (200,121)-(200,148) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (200,149)-(200,173) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (200,174)-(200,179) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (200,180)-(200,181) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (201,17)-(201,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (202,21)-(202,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (202,23)-(202,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (202,24)-(202,42) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(");
                #line hidden
                #line (202,43)-(202,70) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (202,71)-(202,94) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (202,95)-(202,100) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (202,101)-(202,103) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (203,21)-(203,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (204,25)-(204,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (204,28)-(204,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,29)-(204,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (204,40)-(204,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,41)-(204,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (204,42)-(204,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (204,43)-(204,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first28 = true;
                #line (205,26)-(205,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("                    ");
                    #line (206,29)-(206,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (206,32)-(206,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,33)-(206,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (206,39)-(206,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,40)-(206,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (206,41)-(206,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,42)-(206,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (206,52)-(206,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (206,58)-(206,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (206,71)-(206,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (206,72)-(206,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first29 = true;
                    #line (207,30)-(207,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        var __first30 = true;
                        #line (208,34)-(208,50) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first30)
                            {
                                __first30 = false;
                            }
                            var __first31 = true;
                            #line (209,38)-(209,67) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first31)
                                {
                                    __first31 = false;
                                }
                                __cb.Push("                    ");
                                #line (210,41)-(210,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (210,43)-(210,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (210,44)-(210,53) 45 "SymbolGenerator.mxg"
                                __cb.Write("(!result.");
                                #line hidden
                                #line (210,54)-(210,63) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (210,64)-(210,82) 45 "SymbolGenerator.mxg"
                                __cb.Write(".IsDefaultOrEmpty)");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (211,41)-(211,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (212,46)-(212,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (212,65)-(212,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (212,75)-(212,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (212,76)-(212,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (212,84)-(212,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (212,94)-(212,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (213,41)-(213,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            #line (214,38)-(214,42) 29 "SymbolGenerator.mxg"
                            else
                            #line hidden
                            
                            {
                                if (__first31)
                                {
                                    __first31 = false;
                                }
                                __cb.Push("                    ");
                                #line (215,41)-(215,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (215,43)-(215,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (215,44)-(215,52) 45 "SymbolGenerator.mxg"
                                __cb.Write("(result.");
                                #line hidden
                                #line (215,53)-(215,62) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (215,63)-(215,64) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (215,64)-(215,66) 45 "SymbolGenerator.mxg"
                                __cb.Write("!=");
                                #line hidden
                                #line (215,66)-(215,67) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (215,68)-(215,97) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetDefaultValue(symbol, prop));
                                #line hidden
                                #line (215,98)-(215,99) 45 "SymbolGenerator.mxg"
                                __cb.Write(")");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (216,41)-(216,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (217,46)-(217,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (217,65)-(217,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (217,75)-(217,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (217,76)-(217,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (217,84)-(217,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (217,94)-(217,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (218,41)-(218,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first31) __cb.AppendLine();
                        }
                        #line (220,34)-(220,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first30)
                            {
                                __first30 = false;
                            }
                            __cb.Push("                    ");
                            #line (221,38)-(221,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (221,57)-(221,58) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (221,58)-(221,59) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (221,59)-(221,60) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (221,60)-(221,67) 41 "SymbolGenerator.mxg"
                            __cb.Write("result.");
                            #line hidden
                            #line (221,68)-(221,77) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (221,78)-(221,79) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first30) __cb.AppendLine();
                    }
                    if (!__first29) __cb.AppendLine();
                }
                #line (224,26)-(224,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("                    ");
                    #line (225,29)-(225,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (225,32)-(225,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (225,33)-(225,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (225,39)-(225,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (225,40)-(225,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (225,41)-(225,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (225,42)-(225,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (225,52)-(225,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (225,58)-(225,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (225,71)-(225,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (225,72)-(225,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    #line (226,30)-(226,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first32 = true;
                    #line (227,30)-(227,46) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        var __first33 = true;
                        #line (228,34)-(228,63) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first33)
                            {
                                __first33 = false;
                            }
                            __cb.Push("                    ");
                            #line (229,37)-(229,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (229,39)-(229,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (229,40)-(229,66) 41 "SymbolGenerator.mxg"
                            __cb.Write("(!result.IsDefaultOrEmpty)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (230,37)-(230,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (231,42)-(231,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (231,61)-(231,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (231,71)-(231,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (231,72)-(231,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (232,37)-(232,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (233,34)-(233,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first33)
                            {
                                __first33 = false;
                            }
                            __cb.Push("                    ");
                            #line (234,37)-(234,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (234,39)-(234,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (234,40)-(234,47) 41 "SymbolGenerator.mxg"
                            __cb.Write("(result");
                            #line hidden
                            #line (234,47)-(234,48) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (234,48)-(234,50) 41 "SymbolGenerator.mxg"
                            __cb.Write("!=");
                            #line hidden
                            #line (234,50)-(234,51) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (234,52)-(234,81) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (234,82)-(234,83) 41 "SymbolGenerator.mxg"
                            __cb.Write(")");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (235,37)-(235,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (236,42)-(236,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (236,61)-(236,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (236,71)-(236,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (236,72)-(236,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (237,37)-(237,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first33) __cb.AppendLine();
                    }
                    #line (239,30)-(239,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("                    ");
                        #line (240,34)-(240,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (240,53)-(240,54) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (240,54)-(240,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (240,55)-(240,56) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (240,56)-(240,63) 37 "SymbolGenerator.mxg"
                        __cb.Write("result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first32) __cb.AppendLine();
                }
                #line (242,26)-(242,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("                    ");
                    #line (243,29)-(243,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (243,39)-(243,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (243,45)-(243,58) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (243,58)-(243,59) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (243,59)-(243,78) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first28) __cb.AppendLine();
                __cb.Push("                    ");
                #line (245,25)-(245,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (246,25)-(246,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (247,25)-(247,42) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(");
                #line hidden
                #line (247,43)-(247,70) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (247,71)-(247,95) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (247,96)-(247,101) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (247,102)-(247,104) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (248,21)-(248,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (249,21)-(249,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (249,27)-(249,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (249,28)-(249,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (250,17)-(250,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (251,17)-(251,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (251,21)-(251,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first27) __cb.AppendLine();
            var __first34 = true;
            #line (253,14)-(253,36) 13 "SymbolGenerator.mxg"
            if (phases.Length > 0)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("            ");
                #line (254,17)-(254,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (255,21)-(255,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (255,27)-(255,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (255,28)-(255,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (255,54)-(255,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (255,55)-(255,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (255,70)-(255,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (255,71)-(255,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (255,83)-(255,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (255,84)-(255,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (256,17)-(256,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (257,14)-(257,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("            ");
                #line (258,17)-(258,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (258,23)-(258,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,24)-(258,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (258,50)-(258,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,51)-(258,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (258,66)-(258,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,67)-(258,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (258,79)-(258,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,80)-(258,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("        ");
            #line (260,9)-(260,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first35 = true;
            #line (262,10)-(262,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first35)
                {
                    __first35 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (264,14)-(264,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first36 = true;
                #line (265,14)-(265,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    __cb.Push("        ");
                    #line (266,17)-(266,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (266,24)-(266,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,25)-(266,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first37 = true;
                    foreach (var __item38 in 
                    #line (266,27)-(266,84) 21 "SymbolGenerator.mxg"
                    from prop in props select GetTypeName(symbol, prop.Type) 
                    #line hidden
                    )
                    {
                        if (__first37)
                        {
                            __first37 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (266,94)-(266,98) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item38);
                    }
                    #line (266,99)-(266,100) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (266,100)-(266,101) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,101)-(266,110) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (266,111)-(266,116) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (266,117)-(266,133) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (266,133)-(266,134) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,134)-(266,146) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (266,146)-(266,147) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,147)-(266,166) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (266,166)-(266,167) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,167)-(266,185) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (267,17)-(267,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (268,21)-(268,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (268,24)-(268,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (268,25)-(268,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (268,29)-(268,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (268,30)-(268,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (268,31)-(268,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (268,33)-(268,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (268,61)-(268,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (269,21)-(269,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (269,24)-(269,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (269,25)-(269,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (269,31)-(269,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (269,32)-(269,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (269,33)-(269,34) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (269,34)-(269,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (269,49)-(269,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (269,55)-(269,68) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (269,68)-(269,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (269,69)-(269,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (270,21)-(270,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (271,21)-(271,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (271,27)-(271,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (271,28)-(271,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (272,17)-(272,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (273,14)-(273,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    #line (274,18)-(274,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (275,17)-(275,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (275,24)-(275,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,26)-(275,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (275,57)-(275,58) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,58)-(275,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (275,68)-(275,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (275,74)-(275,90) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (275,90)-(275,91) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,91)-(275,103) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (275,103)-(275,104) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,104)-(275,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (275,123)-(275,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (275,124)-(275,142) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (276,17)-(276,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (277,21)-(277,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (277,24)-(277,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,25)-(277,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (277,29)-(277,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,30)-(277,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (277,31)-(277,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (277,33)-(277,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (277,61)-(277,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (278,21)-(278,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (278,24)-(278,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (278,25)-(278,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (278,31)-(278,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (278,32)-(278,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (278,33)-(278,34) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (278,34)-(278,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (278,49)-(278,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (278,55)-(278,68) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (278,68)-(278,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (278,69)-(278,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (279,21)-(279,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (280,21)-(280,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (280,27)-(280,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (280,28)-(280,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (281,17)-(281,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (282,14)-(282,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    __cb.Push("        ");
                    #line (283,17)-(283,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (283,24)-(283,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (283,25)-(283,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (283,29)-(283,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (283,30)-(283,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (283,40)-(283,45) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (283,46)-(283,62) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (283,62)-(283,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (283,63)-(283,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (283,75)-(283,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (283,76)-(283,95) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (283,95)-(283,96) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (283,96)-(283,114) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (284,17)-(284,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (285,21)-(285,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (285,24)-(285,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (285,25)-(285,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (285,29)-(285,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (285,30)-(285,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (285,31)-(285,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (285,33)-(285,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (285,61)-(285,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (286,21)-(286,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (286,36)-(286,41) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (286,42)-(286,55) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (286,55)-(286,56) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (286,56)-(286,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (287,21)-(287,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (288,17)-(288,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first36) __cb.AppendLine();
            }
            if (!__first35) __cb.AppendLine();
            __cb.Push("    ");
            #line (291,5)-(291,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (293,5)-(293,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (293,11)-(293,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,12)-(293,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (293,20)-(293,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,21)-(293,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (293,26)-(293,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,28)-(293,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (293,56)-(293,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,57)-(293,58) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (293,58)-(293,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,59)-(293,108) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl,");
            #line hidden
            #line (293,108)-(293,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (293,110)-(293,137) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (294,5)-(294,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first39 = true;
            #line (295,10)-(295,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("        ");
                #line (296,13)-(296,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (296,19)-(296,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (296,21)-(296,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (296,52)-(296,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (296,54)-(296,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (296,64)-(296,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (296,65)-(296,67) 29 "SymbolGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (296,67)-(296,68) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (296,68)-(296,70) 29 "SymbolGenerator.mxg"
                __cb.Write("((");
                #line hidden
                #line (296,71)-(296,98) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (296,99)-(296,120) 29 "SymbolGenerator.mxg"
                __cb.Write(")__WrappedInstance).]");
                #line hidden
                #line (296,121)-(296,130) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (296,131)-(296,132) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first40 = true;
            #line (299,10)-(299,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (301,14)-(301,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first41 = true;
                #line (302,14)-(302,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    var __first42 = true;
                    #line (303,18)-(303,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("        ");
                        #line (304,21)-(304,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (304,27)-(304,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (304,28)-(304,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (304,36)-(304,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (304,37)-(304,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first43 = true;
                        foreach (var __item44 in 
                        #line (304,39)-(304,96) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first43)
                            {
                                __first43 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (304,106)-(304,110) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item44);
                        }
                        #line (304,111)-(304,112) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (304,112)-(304,113) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (304,113)-(304,122) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (304,123)-(304,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (304,129)-(304,145) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (304,145)-(304,146) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (304,146)-(304,158) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (304,158)-(304,159) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (304,159)-(304,178) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (304,178)-(304,179) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (304,179)-(304,198) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (305,18)-(305,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first42)
                        {
                            __first42 = false;
                        }
                        __cb.Push("        ");
                        #line (306,21)-(306,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (306,27)-(306,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (306,28)-(306,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (306,35)-(306,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (306,36)-(306,37) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first45 = true;
                        foreach (var __item46 in 
                        #line (306,38)-(306,95) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first45)
                            {
                                __first45 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (306,105)-(306,109) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item46);
                        }
                        #line (306,110)-(306,111) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (306,111)-(306,112) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (306,112)-(306,121) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (306,122)-(306,127) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (306,128)-(306,144) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (306,144)-(306,145) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (306,145)-(306,157) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (306,157)-(306,158) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (306,158)-(306,177) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (306,177)-(306,178) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (306,178)-(306,196) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (307,21)-(307,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (308,25)-(308,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (308,31)-(308,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (308,32)-(308,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first47 = true;
                        foreach (var __item48 in 
                        #line (308,34)-(308,90) 25 "SymbolGenerator.mxg"
                        from prop in props select GetDefaultValue(symbol, prop) 
                        #line hidden
                        )
                        {
                            if (__first47)
                            {
                                __first47 = false;
                            }
                            else
                            {
                                __cb.Push("            ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (308,100)-(308,104) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item48);
                        }
                        #line (308,105)-(308,107) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (309,21)-(309,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first42) __cb.AppendLine();
                }
                #line (311,14)-(311,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    #line (312,18)-(312,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first49 = true;
                    #line (313,18)-(313,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first49)
                        {
                            __first49 = false;
                        }
                        __cb.Push("        ");
                        #line (314,21)-(314,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (314,27)-(314,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (314,28)-(314,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (314,36)-(314,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (314,38)-(314,68) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (314,69)-(314,70) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (314,70)-(314,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (314,80)-(314,85) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (314,86)-(314,102) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (314,102)-(314,103) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (314,103)-(314,115) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (314,115)-(314,116) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (314,116)-(314,135) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (314,135)-(314,136) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (314,136)-(314,155) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (315,18)-(315,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first49)
                        {
                            __first49 = false;
                        }
                        __cb.Push("        ");
                        #line (316,21)-(316,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (316,27)-(316,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (316,28)-(316,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (316,35)-(316,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (316,37)-(316,67) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (316,68)-(316,69) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (316,69)-(316,78) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (316,79)-(316,84) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (316,85)-(316,101) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (316,101)-(316,102) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (316,102)-(316,114) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (316,114)-(316,115) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (316,115)-(316,134) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (316,134)-(316,135) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (316,135)-(316,153) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (317,21)-(317,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (318,25)-(318,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (318,31)-(318,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (318,33)-(318,62) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (318,63)-(318,64) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (319,21)-(319,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first49) __cb.AppendLine();
                }
                #line (321,14)-(321,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    __cb.Push("        ");
                    #line (322,17)-(322,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (322,23)-(322,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,24)-(322,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (322,32)-(322,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,33)-(322,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (322,37)-(322,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,38)-(322,47) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (322,48)-(322,53) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (322,54)-(322,70) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (322,70)-(322,71) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,71)-(322,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (322,83)-(322,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,84)-(322,103) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (322,103)-(322,104) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,104)-(322,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first41) __cb.AppendLine();
            }
            if (!__first40) __cb.AppendLine();
            __cb.Push("    ");
            #line (325,5)-(325,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (327,5)-(327,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (327,11)-(327,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,12)-(327,18) 25 "SymbolGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (327,18)-(327,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,19)-(327,26) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (327,26)-(327,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,27)-(327,32) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (327,32)-(327,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,34)-(327,61) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (327,62)-(327,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,63)-(327,64) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (327,64)-(327,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,66)-(327,93) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (328,5)-(328,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (329,9)-(329,16) 25 "SymbolGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (329,16)-(329,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,17)-(329,23) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (329,23)-(329,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,24)-(329,32) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (329,32)-(329,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,33)-(329,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (329,45)-(329,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,46)-(329,60) 25 "SymbolGenerator.mxg"
            __cb.Write("s_poolInstance");
            #line hidden
            #line (329,60)-(329,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,61)-(329,62) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (329,62)-(329,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,63)-(329,66) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (329,66)-(329,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,67)-(329,82) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool(()");
            #line hidden
            #line (329,82)-(329,83) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,83)-(329,85) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (329,85)-(329,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,86)-(329,89) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (329,89)-(329,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,91)-(329,118) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (329,119)-(329,136) 25 "SymbolGenerator.mxg"
            __cb.Write("(s_poolInstance),");
            #line hidden
            #line (329,136)-(329,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (329,137)-(329,141) 25 "SymbolGenerator.mxg"
            __cb.Write("32);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (331,9)-(331,16) 25 "SymbolGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (331,16)-(331,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,17)-(331,25) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (331,25)-(331,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,26)-(331,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (331,38)-(331,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,39)-(331,45) 25 "SymbolGenerator.mxg"
            __cb.Write("_pool;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (333,9)-(333,16) 25 "SymbolGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (333,16)-(333,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,18)-(333,45) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (333,46)-(333,59) 25 "SymbolGenerator.mxg"
            __cb.Write("(__ObjectPool");
            #line hidden
            #line (333,59)-(333,60) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,60)-(333,65) 25 "SymbolGenerator.mxg"
            __cb.Write("pool)");
            #line hidden
            #line (333,65)-(333,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (334,13)-(334,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (334,14)-(334,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (334,15)-(334,21) 25 "SymbolGenerator.mxg"
            __cb.Write("base()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (335,9)-(335,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (336,13)-(336,18) 25 "SymbolGenerator.mxg"
            __cb.Write("_pool");
            #line hidden
            #line (336,18)-(336,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,19)-(336,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (336,20)-(336,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,21)-(336,26) 25 "SymbolGenerator.mxg"
            __cb.Write("pool;");
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
            #line (339,9)-(339,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (339,15)-(339,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,16)-(339,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (339,22)-(339,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,24)-(339,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (339,52)-(339,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,53)-(339,65) 25 "SymbolGenerator.mxg"
            __cb.Write("GetInstance(");
            #line hidden
            #line (339,66)-(339,93) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (339,94)-(339,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (339,95)-(339,103) 25 "SymbolGenerator.mxg"
            __cb.Write("wrapped)");
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
            #line (341,17)-(341,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (341,23)-(341,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,24)-(341,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (341,25)-(341,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (341,26)-(341,52) 25 "SymbolGenerator.mxg"
            __cb.Write("s_poolInstance.Allocate();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (342,13)-(342,77) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Diagnostics.Debug.Assert(result.__WrappedInstance");
            #line hidden
            #line (342,77)-(342,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,78)-(342,80) 25 "SymbolGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (342,80)-(342,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (342,81)-(342,87) 25 "SymbolGenerator.mxg"
            __cb.Write("null);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (343,13)-(343,44) 25 "SymbolGenerator.mxg"
            __cb.Write("result.__InitInstance(wrapped);");
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
            #line (347,9)-(347,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (347,15)-(347,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,16)-(347,20) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (347,20)-(347,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (347,21)-(347,27) 25 "SymbolGenerator.mxg"
            __cb.Write("Free()");
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
            #line (349,13)-(349,36) 25 "SymbolGenerator.mxg"
            __cb.Write("this.__ClearInstance();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (350,13)-(350,31) 25 "SymbolGenerator.mxg"
            __cb.Write("_pool?.Free(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (351,9)-(351,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first50 = true;
            #line (353,10)-(353,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (355,14)-(355,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first51 = true;
                #line (356,14)-(356,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first51)
                    {
                        __first51 = false;
                    }
                    var __first52 = true;
                    #line (357,18)-(357,59) 21 "SymbolGenerator.mxg"
                    if (!props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first52)
                        {
                            __first52 = false;
                        }
                        __cb.Push("        ");
                        #line (358,21)-(358,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (358,30)-(358,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (358,31)-(358,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("override");
                        #line hidden
                        #line (358,39)-(358,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (358,40)-(358,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first53 = true;
                        foreach (var __item54 in 
                        #line (358,42)-(358,99) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first53)
                            {
                                __first53 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (358,109)-(358,113) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item54);
                        }
                        #line (358,114)-(358,115) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (358,115)-(358,116) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (358,116)-(358,125) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (358,126)-(358,131) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (358,132)-(358,148) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (358,148)-(358,149) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (358,149)-(358,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (358,161)-(358,162) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (358,162)-(358,181) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (358,181)-(358,182) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (358,182)-(358,200) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (359,21)-(359,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (360,25)-(360,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (360,31)-(360,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (360,32)-(360,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first55 = true;
                        foreach (var __item56 in 
                        #line (360,34)-(360,90) 25 "SymbolGenerator.mxg"
                        from prop in props select GetDefaultValue(symbol, prop) 
                        #line hidden
                        )
                        {
                            if (__first55)
                            {
                                __first55 = false;
                            }
                            else
                            {
                                __cb.Push("            ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (360,100)-(360,104) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item56);
                        }
                        #line (360,105)-(360,107) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (361,21)-(361,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first52) __cb.AppendLine();
                }
                #line (363,14)-(363,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first51)
                    {
                        __first51 = false;
                    }
                    #line (364,18)-(364,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first57 = true;
                    #line (365,18)-(365,38) 21 "SymbolGenerator.mxg"
                    if (!prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first57)
                        {
                            __first57 = false;
                        }
                        __cb.Push("        ");
                        #line (366,21)-(366,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (366,30)-(366,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (366,31)-(366,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("override");
                        #line hidden
                        #line (366,39)-(366,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (366,41)-(366,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (366,72)-(366,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (366,73)-(366,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (366,83)-(366,88) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (366,89)-(366,105) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (366,105)-(366,106) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (366,106)-(366,118) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (366,118)-(366,119) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (366,119)-(366,138) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (366,138)-(366,139) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (366,139)-(366,157) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (367,21)-(367,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (368,25)-(368,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (368,31)-(368,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (368,33)-(368,62) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (368,63)-(368,64) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (369,21)-(369,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first57) __cb.AppendLine();
                }
                #line (371,14)-(371,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first51)
                    {
                        __first51 = false;
                    }
                }
                if (!__first51) __cb.AppendLine();
            }
            if (!__first50) __cb.AppendLine();
            __cb.Push("    ");
            #line (374,5)-(374,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (375,1)-(375,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (378,9)-(378,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (379,1)-(379,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (379,6)-(379,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,7)-(379,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (380,1)-(380,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (380,6)-(380,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,7)-(380,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (381,1)-(381,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (381,6)-(381,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,7)-(381,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (382,1)-(382,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (382,6)-(382,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,7)-(382,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (383,1)-(383,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (383,6)-(383,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,7)-(383,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (384,1)-(384,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (384,6)-(384,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,7)-(384,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (386,1)-(386,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (386,10)-(386,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,12)-(386,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (386,33)-(386,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (387,1)-(387,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (388,5)-(388,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (388,11)-(388,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,12)-(388,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (388,19)-(388,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,20)-(388,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (388,25)-(388,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,27)-(388,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (389,5)-(389,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (390,5)-(390,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (391,1)-(391,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}