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
            #line (21,23)-(21,28) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (21,28)-(21,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,29)-(21,44) 25 "SymbolGenerator.mxg"
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
            #line (60,14)-(60,22) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (60,22)-(60,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,23)-(60,28) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (60,28)-(60,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,30)-(60,57) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (60,58)-(60,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,59)-(60,60) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (60,60)-(60,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,61)-(60,110) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolBase,");
            #line hidden
            #line (60,110)-(60,111) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,112)-(60,139) 24 "SymbolGenerator.mxg"
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
            __cb.Push("        ");
            #line (62,9)-(62,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (62,18)-(62,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,20)-(62,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (62,48)-(62,50) 25 "SymbolGenerator.mxg"
            __cb.Write("()");
            #line hidden
            #line (62,50)-(62,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (63,13)-(63,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (63,14)-(63,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,15)-(63,21) 25 "SymbolGenerator.mxg"
            __cb.Write("base()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (64,9)-(64,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (65,9)-(65,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (67,9)-(67,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (67,18)-(67,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,20)-(67,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (67,48)-(67,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (67,57)-(67,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,58)-(67,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (67,68)-(67,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,69)-(67,88) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (67,88)-(67,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,89)-(67,101) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (67,101)-(67,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,102)-(67,116) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (67,116)-(67,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,117)-(67,129) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (67,129)-(67,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (68,13)-(68,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (68,14)-(68,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,15)-(68,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (68,30)-(68,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,31)-(68,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (68,43)-(68,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,44)-(68,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (69,9)-(69,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (70,9)-(70,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (72,9)-(72,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (72,18)-(72,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,20)-(72,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (72,48)-(72,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (72,57)-(72,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,58)-(72,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (72,68)-(72,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,69)-(72,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (72,83)-(72,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,84)-(72,96) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (72,96)-(72,97) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (73,13)-(73,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (73,14)-(73,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,15)-(73,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (73,30)-(73,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,31)-(73,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (74,9)-(74,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (75,9)-(75,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (77,9)-(77,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (77,18)-(77,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,20)-(77,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (77,48)-(77,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (77,57)-(77,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,58)-(77,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (77,68)-(77,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,69)-(77,78) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (77,78)-(77,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,79)-(77,92) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (77,92)-(77,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (78,13)-(78,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (78,14)-(78,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,15)-(78,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (78,30)-(78,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,31)-(78,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (79,9)-(79,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (80,9)-(80,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (82,9)-(82,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (82,18)-(82,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,20)-(82,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (82,48)-(82,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (82,57)-(82,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,58)-(82,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (82,68)-(82,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,69)-(82,86) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (82,86)-(82,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,87)-(82,97) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (82,97)-(82,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (83,13)-(83,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (83,14)-(83,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,15)-(83,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (83,30)-(83,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,31)-(83,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (84,9)-(84,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (85,9)-(85,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (87,9)-(87,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (87,18)-(87,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,20)-(87,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (87,48)-(87,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (87,55)-(87,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,56)-(87,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (87,66)-(87,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,67)-(87,86) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (87,86)-(87,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,87)-(87,99) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (87,99)-(87,100) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,100)-(87,114) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (87,114)-(87,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,115)-(87,127) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (87,127)-(87,128) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,128)-(87,135) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (87,135)-(87,136) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,136)-(87,141) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (87,141)-(87,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,142)-(87,149) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (87,149)-(87,150) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,150)-(87,163) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (87,163)-(87,164) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,164)-(87,191) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (87,191)-(87,192) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,192)-(87,203) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (88,13)-(88,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (88,14)-(88,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,15)-(88,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (88,30)-(88,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,31)-(88,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (88,43)-(88,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,44)-(88,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (88,56)-(88,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,57)-(88,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (88,62)-(88,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,63)-(88,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (88,76)-(88,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (88,77)-(88,88) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (89,9)-(89,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (90,9)-(90,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (92,9)-(92,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (92,18)-(92,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,20)-(92,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (92,48)-(92,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (92,55)-(92,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,56)-(92,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (92,66)-(92,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,67)-(92,81) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (92,81)-(92,82) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,82)-(92,94) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (92,94)-(92,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,95)-(92,102) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (92,102)-(92,103) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,103)-(92,108) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (92,108)-(92,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,109)-(92,116) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (92,116)-(92,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,117)-(92,130) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (92,130)-(92,131) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,131)-(92,158) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (92,158)-(92,159) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (92,159)-(92,170) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (93,13)-(93,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (93,14)-(93,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,15)-(93,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (93,30)-(93,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,31)-(93,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (93,43)-(93,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,44)-(93,49) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (93,49)-(93,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,50)-(93,63) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (93,63)-(93,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,64)-(93,75) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (94,9)-(94,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (95,9)-(95,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (97,9)-(97,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (97,18)-(97,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,20)-(97,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (97,48)-(97,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (97,55)-(97,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,56)-(97,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (97,66)-(97,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,67)-(97,76) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (97,76)-(97,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,77)-(97,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (97,90)-(97,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,91)-(97,98) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (97,98)-(97,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,99)-(97,104) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (97,104)-(97,105) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,105)-(97,112) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (97,112)-(97,113) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,113)-(97,126) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (97,126)-(97,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,127)-(97,154) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (97,154)-(97,155) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,155)-(97,166) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (98,13)-(98,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (98,14)-(98,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,15)-(98,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (98,30)-(98,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,31)-(98,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (98,44)-(98,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,45)-(98,50) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (98,50)-(98,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,51)-(98,64) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (98,64)-(98,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,65)-(98,76) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (99,9)-(99,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (100,9)-(100,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (102,9)-(102,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (102,18)-(102,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,20)-(102,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (102,48)-(102,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (102,55)-(102,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,56)-(102,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (102,66)-(102,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,67)-(102,84) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (102,84)-(102,85) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,85)-(102,95) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (102,95)-(102,96) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,96)-(102,103) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (102,103)-(102,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,104)-(102,109) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (102,109)-(102,110) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,110)-(102,117) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (102,117)-(102,118) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,118)-(102,131) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (102,131)-(102,132) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,132)-(102,159) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (102,159)-(102,160) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,160)-(102,171) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (103,13)-(103,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (103,14)-(103,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,15)-(103,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (103,30)-(103,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,31)-(103,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (103,41)-(103,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,42)-(103,47) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (103,47)-(103,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,48)-(103,61) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (103,61)-(103,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,62)-(103,73) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (104,9)-(104,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (105,9)-(105,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (107,9)-(107,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (107,18)-(107,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,19)-(107,25) 25 "SymbolGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (107,25)-(107,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,26)-(107,34) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (107,34)-(107,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,35)-(107,52) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (107,52)-(107,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,53)-(107,68) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (107,68)-(107,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,69)-(107,71) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (107,71)-(107,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,73)-(107,100) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (107,101)-(107,134) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first7 = true;
            #line (109,10)-(109,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                __cb.Push("        ");
                #line (110,13)-(110,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (110,19)-(110,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (110,20)-(110,28) 29 "SymbolGenerator.mxg"
                __cb.Write("abstract");
                #line hidden
                #line (110,28)-(110,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (110,30)-(110,60) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (110,61)-(110,62) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (110,63)-(110,72) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (110,73)-(110,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (110,74)-(110,75) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (110,75)-(110,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (110,76)-(110,80) 29 "SymbolGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (110,80)-(110,81) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (110,81)-(110,82) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first7) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first8 = true;
            #line (113,10)-(113,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (115,14)-(115,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first9 = true;
                #line (116,14)-(116,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first9)
                    {
                        __first9 = false;
                    }
                    __cb.Push("        ");
                    #line (117,17)-(117,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (117,26)-(117,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (117,27)-(117,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (117,35)-(117,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (117,36)-(117,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first10 = true;
                    foreach (var __item11 in 
                    #line (117,38)-(117,95) 21 "SymbolGenerator.mxg"
                    from prop in props select GetTypeName(symbol, prop.Type) 
                    #line hidden
                    )
                    {
                        if (__first10)
                        {
                            __first10 = false;
                        }
                        else
                        {
                            __cb.Push("        ");
                            __cb.DontIgnoreLastLineEnd = true;
                            #line (117,105)-(117,109) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item11);
                    }
                    #line (117,110)-(117,111) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (117,111)-(117,112) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (117,112)-(117,121) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (117,122)-(117,127) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (117,128)-(117,144) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (117,144)-(117,145) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (117,145)-(117,157) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (117,157)-(117,158) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (117,158)-(117,177) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (117,177)-(117,178) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (117,178)-(117,197) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (118,14)-(118,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first9)
                    {
                        __first9 = false;
                    }
                    #line (119,18)-(119,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (120,17)-(120,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (120,26)-(120,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,27)-(120,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (120,35)-(120,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,37)-(120,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (120,68)-(120,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,69)-(120,78) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (120,79)-(120,84) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (120,85)-(120,101) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (120,101)-(120,102) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,102)-(120,114) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (120,114)-(120,115) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,115)-(120,134) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (120,134)-(120,135) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,135)-(120,154) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (121,14)-(121,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first9)
                    {
                        __first9 = false;
                    }
                    __cb.Push("        ");
                    #line (122,17)-(122,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (122,26)-(122,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,27)-(122,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (122,35)-(122,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,36)-(122,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (122,40)-(122,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,41)-(122,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (122,51)-(122,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (122,57)-(122,73) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (122,73)-(122,74) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,74)-(122,86) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (122,86)-(122,87) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,87)-(122,106) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (122,106)-(122,107) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (122,107)-(122,126) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first9) __cb.AppendLine();
            }
            if (!__first8) __cb.AppendLine();
            __cb.Push("    ");
            #line (125,5)-(125,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (127,5)-(127,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (127,13)-(127,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,14)-(127,20) 25 "SymbolGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (127,20)-(127,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,21)-(127,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (127,26)-(127,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,28)-(127,62) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (127,63)-(127,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,64)-(127,65) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (127,65)-(127,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,67)-(127,94) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (128,5)-(128,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first12 = true;
            #line (129,10)-(129,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                var __first13 = true;
                #line (130,14)-(130,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("        ");
                    #line (131,17)-(131,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (131,24)-(131,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (131,25)-(131,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (131,31)-(131,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (131,33)-(131,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (131,60)-(131,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (131,62)-(131,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (131,81)-(131,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (131,82)-(131,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (131,83)-(131,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (131,84)-(131,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (131,87)-(131,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (131,89)-(131,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (131,116)-(131,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (132,14)-(132,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("        ");
                    #line (133,17)-(133,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (133,24)-(133,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (133,26)-(133,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (133,53)-(133,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (133,55)-(133,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (133,74)-(133,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first13) __cb.AppendLine();
            }
            if (!__first12) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (137,9)-(137,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (137,15)-(137,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,17)-(137,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (137,52)-(137,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (137,61)-(137,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,62)-(137,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (137,72)-(137,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,73)-(137,92) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (137,92)-(137,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,93)-(137,105) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (137,105)-(137,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,106)-(137,120) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (137,120)-(137,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,121)-(137,133) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (137,133)-(137,134) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (138,13)-(138,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (138,14)-(138,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,15)-(138,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (138,30)-(138,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,31)-(138,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (138,43)-(138,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,44)-(138,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (139,9)-(139,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (140,9)-(140,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (142,9)-(142,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (142,15)-(142,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,17)-(142,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (142,52)-(142,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (142,61)-(142,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,62)-(142,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (142,72)-(142,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,73)-(142,87) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (142,87)-(142,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,88)-(142,100) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (142,100)-(142,101) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (143,13)-(143,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (143,14)-(143,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,15)-(143,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (143,30)-(143,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,31)-(143,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (144,9)-(144,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (145,9)-(145,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
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
            #line (147,17)-(147,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (147,52)-(147,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (147,61)-(147,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,62)-(147,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (147,72)-(147,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,73)-(147,82) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (147,82)-(147,83) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,83)-(147,96) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (147,96)-(147,97) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (148,13)-(148,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (148,14)-(148,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,15)-(148,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (148,30)-(148,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,31)-(148,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (149,9)-(149,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (150,9)-(150,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (152,9)-(152,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (152,15)-(152,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,17)-(152,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (152,52)-(152,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (152,61)-(152,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,62)-(152,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (152,72)-(152,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,73)-(152,90) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (152,90)-(152,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,91)-(152,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (152,101)-(152,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (153,13)-(153,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (153,14)-(153,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,15)-(153,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (153,30)-(153,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,31)-(153,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,9)-(154,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (155,9)-(155,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (157,9)-(157,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (157,15)-(157,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,17)-(157,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (157,52)-(157,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (157,61)-(157,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,62)-(157,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (157,72)-(157,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,73)-(157,92) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (157,92)-(157,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,93)-(157,105) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (157,105)-(157,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,106)-(157,120) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (157,120)-(157,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,121)-(157,133) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (157,133)-(157,134) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,134)-(157,141) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (157,141)-(157,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,142)-(157,147) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (157,147)-(157,148) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,148)-(157,155) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (157,155)-(157,156) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,156)-(157,169) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (157,169)-(157,170) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,170)-(157,197) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (157,197)-(157,198) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,198)-(157,208) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first14 = true;
            #line (157,209)-(157,252) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                #line (157,253)-(157,254) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (157,254)-(157,255) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (157,256)-(157,286) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (157,287)-(157,288) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (157,289)-(157,307) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (157,321)-(157,322) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (157,322)-(157,323) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (158,13)-(158,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (158,14)-(158,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,15)-(158,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (158,30)-(158,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,31)-(158,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (158,43)-(158,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,44)-(158,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (158,56)-(158,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,57)-(158,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (158,62)-(158,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,63)-(158,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (158,76)-(158,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,77)-(158,88) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (159,9)-(159,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first15 = true;
            #line (160,14)-(160,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                var __first16 = true;
                #line (161,18)-(161,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    var __first17 = true;
                    #line (162,22)-(162,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("            ");
                        #line (163,25)-(163,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (163,27)-(163,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (163,28)-(163,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (163,31)-(163,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (163,50)-(163,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (164,25)-(164,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (165,30)-(165,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (165,49)-(165,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (165,59)-(165,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (165,61)-(165,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (165,80)-(165,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (166,25)-(166,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (167,22)-(167,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("            ");
                        #line (168,25)-(168,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (168,27)-(168,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,28)-(168,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (168,30)-(168,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (168,49)-(168,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,50)-(168,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (168,52)-(168,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,54)-(168,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (168,84)-(168,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (169,25)-(169,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (170,30)-(170,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (170,49)-(170,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (170,59)-(170,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,61)-(170,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (170,80)-(170,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (171,25)-(171,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                }
                #line (173,18)-(173,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    __cb.Push("            ");
                    #line (174,22)-(174,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (174,41)-(174,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (174,42)-(174,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (174,43)-(174,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (174,45)-(174,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (174,64)-(174,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first16) __cb.AppendLine();
            }
            if (!__first15) __cb.AppendLine();
            __cb.Push("        ");
            #line (177,9)-(177,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (179,9)-(179,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (179,15)-(179,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,17)-(179,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (179,52)-(179,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (179,61)-(179,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,62)-(179,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (179,72)-(179,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,73)-(179,87) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (179,87)-(179,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,88)-(179,100) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (179,100)-(179,101) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,101)-(179,108) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (179,108)-(179,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,109)-(179,114) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (179,114)-(179,115) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,115)-(179,122) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (179,122)-(179,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,123)-(179,136) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (179,136)-(179,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,137)-(179,164) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (179,164)-(179,165) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,165)-(179,175) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first18 = true;
            #line (179,176)-(179,219) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (179,220)-(179,221) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (179,221)-(179,222) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,223)-(179,253) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (179,254)-(179,255) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,256)-(179,274) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (179,288)-(179,289) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (179,289)-(179,290) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (180,13)-(180,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (180,14)-(180,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,15)-(180,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (180,30)-(180,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,31)-(180,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (180,43)-(180,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,44)-(180,49) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (180,49)-(180,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,50)-(180,63) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (180,63)-(180,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,64)-(180,75) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (181,9)-(181,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first19 = true;
            #line (182,14)-(182,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first19)
                {
                    __first19 = false;
                }
                var __first20 = true;
                #line (183,18)-(183,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    var __first21 = true;
                    #line (184,22)-(184,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first21)
                        {
                            __first21 = false;
                        }
                        __cb.Push("            ");
                        #line (185,25)-(185,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (185,27)-(185,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (185,28)-(185,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (185,31)-(185,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (185,50)-(185,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (186,25)-(186,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (187,30)-(187,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (187,49)-(187,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (187,59)-(187,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (187,61)-(187,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (187,80)-(187,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (188,25)-(188,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (189,22)-(189,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first21)
                        {
                            __first21 = false;
                        }
                        __cb.Push("            ");
                        #line (190,25)-(190,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (190,27)-(190,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (190,28)-(190,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (190,30)-(190,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (190,49)-(190,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (190,50)-(190,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (190,52)-(190,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (190,54)-(190,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (190,84)-(190,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (191,25)-(191,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (192,30)-(192,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (192,49)-(192,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (192,59)-(192,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (192,61)-(192,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (192,80)-(192,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (193,25)-(193,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first21) __cb.AppendLine();
                }
                #line (195,18)-(195,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    __cb.Push("            ");
                    #line (196,22)-(196,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (196,41)-(196,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (196,42)-(196,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (196,43)-(196,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (196,45)-(196,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (196,64)-(196,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first20) __cb.AppendLine();
            }
            if (!__first19) __cb.AppendLine();
            __cb.Push("        ");
            #line (199,9)-(199,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (201,9)-(201,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (201,15)-(201,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,17)-(201,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (201,52)-(201,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (201,61)-(201,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,62)-(201,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (201,72)-(201,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,73)-(201,82) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (201,82)-(201,83) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,83)-(201,96) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (201,96)-(201,97) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,97)-(201,104) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (201,104)-(201,105) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,105)-(201,110) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (201,110)-(201,111) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,111)-(201,118) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (201,118)-(201,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,119)-(201,132) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (201,132)-(201,133) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,133)-(201,160) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (201,160)-(201,161) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (201,161)-(201,171) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first22 = true;
            #line (201,172)-(201,215) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                #line (201,216)-(201,217) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (201,217)-(201,218) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,219)-(201,249) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (201,250)-(201,251) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,252)-(201,270) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (201,284)-(201,285) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (201,285)-(201,286) 25 "SymbolGenerator.mxg"
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
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (202,44)-(202,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,45)-(202,50) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (202,50)-(202,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,51)-(202,64) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (202,64)-(202,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,65)-(202,76) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (203,9)-(203,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first23 = true;
            #line (204,14)-(204,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                var __first24 = true;
                #line (205,18)-(205,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    var __first25 = true;
                    #line (206,22)-(206,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (207,25)-(207,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (207,27)-(207,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (207,28)-(207,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (207,31)-(207,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (207,50)-(207,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (208,25)-(208,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (209,30)-(209,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (209,49)-(209,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (209,59)-(209,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,61)-(209,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (209,80)-(209,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (210,25)-(210,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (211,22)-(211,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first25)
                        {
                            __first25 = false;
                        }
                        __cb.Push("            ");
                        #line (212,25)-(212,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (212,27)-(212,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,28)-(212,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (212,30)-(212,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (212,49)-(212,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,50)-(212,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (212,52)-(212,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,54)-(212,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (212,84)-(212,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (213,25)-(213,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (214,30)-(214,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (214,49)-(214,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (214,59)-(214,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (214,61)-(214,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (214,80)-(214,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (215,25)-(215,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first25) __cb.AppendLine();
                }
                #line (217,18)-(217,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("            ");
                    #line (218,22)-(218,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (218,41)-(218,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (218,42)-(218,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (218,43)-(218,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (218,45)-(218,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (218,64)-(218,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first24) __cb.AppendLine();
            }
            if (!__first23) __cb.AppendLine();
            __cb.Push("        ");
            #line (221,9)-(221,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (223,9)-(223,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (223,15)-(223,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,17)-(223,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetDefaultImplName(symbol, symbol));
            #line hidden
            #line (223,52)-(223,61) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (223,61)-(223,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,62)-(223,72) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (223,72)-(223,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,73)-(223,90) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (223,90)-(223,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,91)-(223,101) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (223,101)-(223,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,102)-(223,109) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (223,109)-(223,110) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,110)-(223,115) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (223,115)-(223,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,116)-(223,123) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (223,123)-(223,124) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,124)-(223,137) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (223,137)-(223,138) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,138)-(223,165) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (223,165)-(223,166) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (223,166)-(223,176) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first26 = true;
            #line (223,177)-(223,220) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                #line (223,221)-(223,222) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (223,222)-(223,223) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,224)-(223,254) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (223,255)-(223,256) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,257)-(223,275) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (223,289)-(223,290) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (223,290)-(223,291) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (224,13)-(224,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (224,14)-(224,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,15)-(224,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (224,30)-(224,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,31)-(224,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo,");
            #line hidden
            #line (224,41)-(224,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,42)-(224,47) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (224,47)-(224,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,48)-(224,61) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (224,61)-(224,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,62)-(224,73) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (225,9)-(225,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first27 = true;
            #line (226,14)-(226,57) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                var __first28 = true;
                #line (227,18)-(227,34) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    var __first29 = true;
                    #line (228,22)-(228,51) 21 "SymbolGenerator.mxg"
                    if (prop.Type.Dimensions > 0)
                    #line hidden
                    
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        __cb.Push("            ");
                        #line (229,25)-(229,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (229,27)-(229,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (229,28)-(229,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!");
                        #line hidden
                        #line (229,31)-(229,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (229,50)-(229,68) 37 "SymbolGenerator.mxg"
                        __cb.Write(".IsDefaultOrEmpty)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (230,25)-(230,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (231,30)-(231,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (231,49)-(231,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (231,59)-(231,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (231,61)-(231,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (231,80)-(231,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (232,25)-(232,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (233,22)-(233,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        __cb.Push("            ");
                        #line (234,25)-(234,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (234,27)-(234,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,28)-(234,29) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (234,30)-(234,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (234,49)-(234,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,50)-(234,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("!=");
                        #line hidden
                        #line (234,52)-(234,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (234,54)-(234,83) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (234,84)-(234,85) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (235,25)-(235,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (236,30)-(236,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (236,49)-(236,59) 37 "SymbolGenerator.mxg"
                        __cb.Write(".Add(this,");
                        #line hidden
                        #line (236,59)-(236,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (236,61)-(236,79) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetParamName(prop));
                        #line hidden
                        #line (236,80)-(236,82) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (237,25)-(237,26) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first29) __cb.AppendLine();
                }
                #line (239,18)-(239,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("            ");
                    #line (240,22)-(240,40) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (240,41)-(240,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (240,42)-(240,43) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (240,43)-(240,44) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (240,45)-(240,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetParamName(prop));
                    #line hidden
                    #line (240,64)-(240,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first28) __cb.AppendLine();
            }
            if (!__first27) __cb.AppendLine();
            __cb.Push("        ");
            #line (243,9)-(243,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first30 = true;
            #line (245,10)-(245,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (247,13)-(247,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (247,19)-(247,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,20)-(247,28) 29 "SymbolGenerator.mxg"
                __cb.Write("override");
                #line hidden
                #line (247,28)-(247,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,30)-(247,60) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (247,61)-(247,62) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (247,63)-(247,72) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (248,13)-(248,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (249,17)-(249,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (250,17)-(250,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (251,21)-(251,40) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(");
                #line hidden
                #line (251,41)-(251,68) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (251,69)-(251,93) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (251,94)-(251,103) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (251,104)-(251,105) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (251,105)-(251,106) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (251,106)-(251,111) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (251,111)-(251,112) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (251,112)-(251,121) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first31 = true;
                #line (252,22)-(252,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                ");
                    #line (253,25)-(253,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (253,27)-(253,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (253,28)-(253,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (253,30)-(253,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (253,49)-(253,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (253,67)-(253,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (253,68)-(253,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (253,71)-(253,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (253,72)-(253,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (253,75)-(253,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (253,76)-(253,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (253,84)-(253,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (253,85)-(253,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (253,91)-(253,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (253,92)-(253,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (253,94)-(253,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (253,125)-(253,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (254,25)-(254,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (254,29)-(254,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (254,30)-(254,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (254,36)-(254,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (254,38)-(254,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (254,68)-(254,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (255,22)-(255,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("                ");
                    #line (256,25)-(256,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (256,31)-(256,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (256,33)-(256,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (256,52)-(256,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
                __cb.Push("            ");
                #line (258,17)-(258,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (259,13)-(259,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (262,9)-(262,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (262,18)-(262,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,19)-(262,25) 25 "SymbolGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (262,25)-(262,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,26)-(262,34) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (262,34)-(262,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,35)-(262,39) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (262,39)-(262,40) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,40)-(262,61) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (262,61)-(262,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,62)-(262,78) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (262,78)-(262,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,79)-(262,94) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (262,94)-(262,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,95)-(262,112) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (262,112)-(262,113) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,113)-(262,125) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (262,125)-(262,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,126)-(262,145) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (262,145)-(262,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,146)-(262,164) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (263,9)-(263,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (264,14)-(264,44) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            var __first32 = true;
            #line (265,14)-(265,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                #line (266,18)-(266,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (267,17)-(267,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (267,19)-(267,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,20)-(267,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (267,35)-(267,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,36)-(267,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (267,38)-(267,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,40)-(267,67) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (267,68)-(267,91) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (267,92)-(267,97) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (267,98)-(267,99) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,99)-(267,101) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (267,101)-(267,102) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,102)-(267,116) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (267,116)-(267,117) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,117)-(267,119) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (267,119)-(267,120) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,121)-(267,148) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (267,149)-(267,173) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (267,174)-(267,179) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (267,180)-(267,181) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (268,17)-(268,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (269,21)-(269,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (269,23)-(269,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (269,24)-(269,42) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(");
                #line hidden
                #line (269,43)-(269,70) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (269,71)-(269,94) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (269,95)-(269,100) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (269,101)-(269,103) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (270,21)-(270,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (271,25)-(271,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (271,28)-(271,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (271,29)-(271,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (271,40)-(271,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (271,41)-(271,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (271,42)-(271,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (271,43)-(271,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first33 = true;
                #line (272,26)-(272,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first33)
                    {
                        __first33 = false;
                    }
                    __cb.Push("                    ");
                    #line (273,29)-(273,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (273,32)-(273,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (273,33)-(273,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (273,39)-(273,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (273,40)-(273,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (273,41)-(273,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (273,42)-(273,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (273,52)-(273,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (273,58)-(273,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (273,71)-(273,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (273,72)-(273,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first34 = true;
                    #line (274,30)-(274,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        var __first35 = true;
                        #line (275,34)-(275,50) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first35)
                            {
                                __first35 = false;
                            }
                            var __first36 = true;
                            #line (276,38)-(276,67) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first36)
                                {
                                    __first36 = false;
                                }
                                __cb.Push("                    ");
                                #line (277,41)-(277,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (277,43)-(277,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (277,44)-(277,53) 45 "SymbolGenerator.mxg"
                                __cb.Write("(!result.");
                                #line hidden
                                #line (277,54)-(277,63) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (277,64)-(277,82) 45 "SymbolGenerator.mxg"
                                __cb.Write(".IsDefaultOrEmpty)");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (278,41)-(278,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (279,46)-(279,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (279,65)-(279,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (279,75)-(279,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (279,76)-(279,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (279,84)-(279,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (279,94)-(279,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (280,41)-(280,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            #line (281,38)-(281,42) 29 "SymbolGenerator.mxg"
                            else
                            #line hidden
                            
                            {
                                if (__first36)
                                {
                                    __first36 = false;
                                }
                                __cb.Push("                    ");
                                #line (282,41)-(282,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (282,43)-(282,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (282,44)-(282,52) 45 "SymbolGenerator.mxg"
                                __cb.Write("(result.");
                                #line hidden
                                #line (282,53)-(282,62) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (282,63)-(282,64) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (282,64)-(282,66) 45 "SymbolGenerator.mxg"
                                __cb.Write("!=");
                                #line hidden
                                #line (282,66)-(282,67) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (282,68)-(282,97) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetDefaultValue(symbol, prop));
                                #line hidden
                                #line (282,98)-(282,99) 45 "SymbolGenerator.mxg"
                                __cb.Write(")");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (283,41)-(283,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (284,46)-(284,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (284,65)-(284,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (284,75)-(284,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (284,76)-(284,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (284,84)-(284,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (284,94)-(284,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (285,41)-(285,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first36) __cb.AppendLine();
                        }
                        #line (287,34)-(287,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first35)
                            {
                                __first35 = false;
                            }
                            __cb.Push("                    ");
                            #line (288,38)-(288,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (288,57)-(288,58) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (288,58)-(288,59) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (288,59)-(288,60) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (288,60)-(288,67) 41 "SymbolGenerator.mxg"
                            __cb.Write("result.");
                            #line hidden
                            #line (288,68)-(288,77) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (288,78)-(288,79) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first35) __cb.AppendLine();
                    }
                    if (!__first34) __cb.AppendLine();
                }
                #line (291,26)-(291,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first33)
                    {
                        __first33 = false;
                    }
                    __cb.Push("                    ");
                    #line (292,29)-(292,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (292,32)-(292,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,33)-(292,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (292,39)-(292,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,40)-(292,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (292,41)-(292,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,42)-(292,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (292,52)-(292,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (292,58)-(292,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (292,71)-(292,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (292,72)-(292,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    #line (293,30)-(293,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first37 = true;
                    #line (294,30)-(294,46) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first37)
                        {
                            __first37 = false;
                        }
                        var __first38 = true;
                        #line (295,34)-(295,63) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first38)
                            {
                                __first38 = false;
                            }
                            __cb.Push("                    ");
                            #line (296,37)-(296,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (296,39)-(296,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (296,40)-(296,66) 41 "SymbolGenerator.mxg"
                            __cb.Write("(!result.IsDefaultOrEmpty)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (297,37)-(297,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (298,42)-(298,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (298,61)-(298,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (298,71)-(298,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (298,72)-(298,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (299,37)-(299,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (300,34)-(300,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first38)
                            {
                                __first38 = false;
                            }
                            __cb.Push("                    ");
                            #line (301,37)-(301,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (301,39)-(301,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (301,40)-(301,47) 41 "SymbolGenerator.mxg"
                            __cb.Write("(result");
                            #line hidden
                            #line (301,47)-(301,48) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (301,48)-(301,50) 41 "SymbolGenerator.mxg"
                            __cb.Write("!=");
                            #line hidden
                            #line (301,50)-(301,51) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (301,52)-(301,81) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (301,82)-(301,83) 41 "SymbolGenerator.mxg"
                            __cb.Write(")");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (302,37)-(302,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (303,42)-(303,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (303,61)-(303,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (303,71)-(303,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (303,72)-(303,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (304,37)-(304,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first38) __cb.AppendLine();
                    }
                    #line (306,30)-(306,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first37)
                        {
                            __first37 = false;
                        }
                        __cb.Push("                    ");
                        #line (307,34)-(307,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (307,53)-(307,54) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (307,54)-(307,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (307,55)-(307,56) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (307,56)-(307,63) 37 "SymbolGenerator.mxg"
                        __cb.Write("result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first37) __cb.AppendLine();
                }
                #line (309,26)-(309,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first33)
                    {
                        __first33 = false;
                    }
                    __cb.Push("                    ");
                    #line (310,29)-(310,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (310,39)-(310,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (310,45)-(310,58) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (310,58)-(310,59) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (310,59)-(310,78) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first33) __cb.AppendLine();
                __cb.Push("                    ");
                #line (312,25)-(312,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (313,25)-(313,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (314,25)-(314,42) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(");
                #line hidden
                #line (314,43)-(314,70) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (314,71)-(314,95) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (314,96)-(314,101) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (314,102)-(314,104) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (315,21)-(315,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (316,21)-(316,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (316,27)-(316,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (316,28)-(316,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (317,17)-(317,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (318,17)-(318,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (318,21)-(318,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            var __first39 = true;
            #line (320,14)-(320,36) 13 "SymbolGenerator.mxg"
            if (phases.Length > 0)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("            ");
                #line (321,17)-(321,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (322,21)-(322,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (322,27)-(322,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (322,28)-(322,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (322,54)-(322,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (322,55)-(322,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (322,70)-(322,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (322,71)-(322,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (322,83)-(322,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (322,84)-(322,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (323,17)-(323,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (324,14)-(324,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("            ");
                #line (325,17)-(325,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (325,23)-(325,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (325,24)-(325,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (325,50)-(325,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (325,51)-(325,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (325,66)-(325,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (325,67)-(325,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (325,79)-(325,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (325,80)-(325,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            __cb.Push("        ");
            #line (327,9)-(327,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first40 = true;
            #line (329,10)-(329,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (331,14)-(331,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first41 = true;
                #line (332,14)-(332,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    __cb.Push("        ");
                    #line (333,17)-(333,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (333,26)-(333,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (333,27)-(333,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("override");
                    #line hidden
                    #line (333,35)-(333,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (333,36)-(333,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    var __first42 = true;
                    foreach (var __item43 in 
                    #line (333,38)-(333,95) 21 "SymbolGenerator.mxg"
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
                            #line (333,105)-(333,109) 40 "SymbolGenerator.mxg"
                            __cb.Write(", ");
                            #line hidden
                            __cb.DontIgnoreLastLineEnd = false;
                            __cb.Pop();
                        }
                        __cb.Write(__item43);
                    }
                    #line (333,110)-(333,111) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (333,111)-(333,112) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (333,112)-(333,121) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (333,122)-(333,127) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (333,128)-(333,144) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (333,144)-(333,145) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (333,145)-(333,157) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (333,157)-(333,158) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (333,158)-(333,177) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (333,177)-(333,178) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (333,178)-(333,196) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (334,17)-(334,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (335,21)-(335,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (335,24)-(335,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (335,25)-(335,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (335,29)-(335,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (335,30)-(335,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (335,31)-(335,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (335,33)-(335,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (335,61)-(335,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (336,21)-(336,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (336,24)-(336,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (336,25)-(336,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (336,31)-(336,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (336,32)-(336,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (336,33)-(336,34) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (336,34)-(336,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (336,49)-(336,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (336,55)-(336,68) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (336,68)-(336,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (336,69)-(336,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (337,21)-(337,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (338,21)-(338,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (338,27)-(338,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (338,28)-(338,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (339,17)-(339,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (340,14)-(340,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    #line (341,18)-(341,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (342,17)-(342,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (342,26)-(342,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (342,27)-(342,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("override");
                    #line hidden
                    #line (342,35)-(342,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (342,37)-(342,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (342,68)-(342,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (342,69)-(342,78) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (342,79)-(342,84) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (342,85)-(342,101) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (342,101)-(342,102) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (342,102)-(342,114) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (342,114)-(342,115) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (342,115)-(342,134) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (342,134)-(342,135) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (342,135)-(342,153) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (343,17)-(343,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (344,21)-(344,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (344,24)-(344,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (344,25)-(344,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (344,29)-(344,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (344,30)-(344,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (344,31)-(344,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (344,33)-(344,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (344,61)-(344,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (345,21)-(345,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (345,24)-(345,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (345,25)-(345,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (345,31)-(345,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (345,32)-(345,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (345,33)-(345,34) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (345,34)-(345,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (345,49)-(345,54) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (345,55)-(345,68) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (345,68)-(345,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (345,69)-(345,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (346,21)-(346,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (347,21)-(347,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (347,27)-(347,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (347,28)-(347,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (348,17)-(348,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (349,14)-(349,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first41)
                    {
                        __first41 = false;
                    }
                    __cb.Push("        ");
                    #line (350,17)-(350,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (350,26)-(350,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,27)-(350,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("override");
                    #line hidden
                    #line (350,35)-(350,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,36)-(350,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (350,40)-(350,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,41)-(350,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (350,51)-(350,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (350,57)-(350,73) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (350,73)-(350,74) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,74)-(350,86) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (350,86)-(350,87) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,87)-(350,106) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (350,106)-(350,107) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,107)-(350,125) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (351,17)-(351,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (352,21)-(352,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (352,24)-(352,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (352,25)-(352,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl");
                    #line hidden
                    #line (352,29)-(352,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (352,30)-(352,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (352,31)-(352,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (352,33)-(352,60) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetImplName(symbol, symbol));
                    #line hidden
                    #line (352,61)-(352,80) 33 "SymbolGenerator.mxg"
                    __cb.Write(".GetInstance(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (353,21)-(353,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Complete_");
                    #line hidden
                    #line (353,36)-(353,41) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (353,42)-(353,55) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (353,55)-(353,56) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (353,56)-(353,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (354,21)-(354,33) 33 "SymbolGenerator.mxg"
                    __cb.Write("impl.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (355,17)-(355,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first41) __cb.AppendLine();
            }
            if (!__first40) __cb.AppendLine();
            __cb.Push("    ");
            #line (358,5)-(358,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (360,5)-(360,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (360,13)-(360,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,14)-(360,20) 25 "SymbolGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (360,20)-(360,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,21)-(360,28) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (360,28)-(360,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,29)-(360,34) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (360,34)-(360,35) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,36)-(360,63) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (361,5)-(361,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (362,9)-(362,16) 25 "SymbolGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (362,16)-(362,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,17)-(362,23) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (362,23)-(362,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,24)-(362,32) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (362,32)-(362,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,33)-(362,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (362,45)-(362,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,46)-(362,60) 25 "SymbolGenerator.mxg"
            __cb.Write("s_poolInstance");
            #line hidden
            #line (362,60)-(362,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,61)-(362,62) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (362,62)-(362,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,63)-(362,66) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (362,66)-(362,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,67)-(362,82) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool(()");
            #line hidden
            #line (362,82)-(362,83) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,83)-(362,85) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (362,85)-(362,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,86)-(362,89) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (362,89)-(362,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,91)-(362,118) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (362,119)-(362,136) 25 "SymbolGenerator.mxg"
            __cb.Write("(s_poolInstance),");
            #line hidden
            #line (362,136)-(362,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (362,137)-(362,141) 25 "SymbolGenerator.mxg"
            __cb.Write("32);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (364,9)-(364,16) 25 "SymbolGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (364,16)-(364,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,17)-(364,25) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (364,25)-(364,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,26)-(364,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ObjectPool");
            #line hidden
            #line (364,38)-(364,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (364,39)-(364,45) 25 "SymbolGenerator.mxg"
            __cb.Write("_pool;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (366,9)-(366,16) 25 "SymbolGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (366,16)-(366,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,18)-(366,45) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (366,46)-(366,59) 25 "SymbolGenerator.mxg"
            __cb.Write("(__ObjectPool");
            #line hidden
            #line (366,59)-(366,60) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,60)-(366,65) 25 "SymbolGenerator.mxg"
            __cb.Write("pool)");
            #line hidden
            #line (366,65)-(366,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (367,13)-(367,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (367,14)-(367,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (367,15)-(367,21) 25 "SymbolGenerator.mxg"
            __cb.Write("base()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (368,9)-(368,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (369,13)-(369,18) 25 "SymbolGenerator.mxg"
            __cb.Write("_pool");
            #line hidden
            #line (369,18)-(369,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,19)-(369,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (369,20)-(369,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (369,21)-(369,26) 25 "SymbolGenerator.mxg"
            __cb.Write("pool;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (370,9)-(370,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (372,9)-(372,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (372,15)-(372,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,16)-(372,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (372,22)-(372,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,24)-(372,51) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (372,52)-(372,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,53)-(372,65) 25 "SymbolGenerator.mxg"
            __cb.Write("GetInstance(");
            #line hidden
            #line (372,66)-(372,93) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (372,94)-(372,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,95)-(372,103) 25 "SymbolGenerator.mxg"
            __cb.Write("wrapped)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (373,9)-(373,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (374,13)-(374,16) 25 "SymbolGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (374,16)-(374,17) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,17)-(374,23) 25 "SymbolGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (374,23)-(374,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,24)-(374,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (374,25)-(374,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,26)-(374,52) 25 "SymbolGenerator.mxg"
            __cb.Write("s_poolInstance.Allocate();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (375,13)-(375,77) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Diagnostics.Debug.Assert(result.__WrappedInstance");
            #line hidden
            #line (375,77)-(375,78) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,78)-(375,80) 25 "SymbolGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (375,80)-(375,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,81)-(375,87) 25 "SymbolGenerator.mxg"
            __cb.Write("null);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (376,13)-(376,35) 25 "SymbolGenerator.mxg"
            __cb.Write("__InitInstance(result,");
            #line hidden
            #line (376,35)-(376,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,36)-(376,45) 25 "SymbolGenerator.mxg"
            __cb.Write("wrapped);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (377,13)-(377,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (377,19)-(377,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,20)-(377,27) 25 "SymbolGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (378,9)-(378,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (380,9)-(380,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (380,15)-(380,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,16)-(380,20) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (380,20)-(380,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,21)-(380,27) 25 "SymbolGenerator.mxg"
            __cb.Write("Free()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (381,9)-(381,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (382,13)-(382,36) 25 "SymbolGenerator.mxg"
            __cb.Write("this.__ClearInstance();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (383,13)-(383,31) 25 "SymbolGenerator.mxg"
            __cb.Write("_pool?.Free(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (384,9)-(384,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first44 = true;
            #line (386,10)-(386,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                __cb.Push("        ");
                #line (387,13)-(387,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (387,19)-(387,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (387,20)-(387,28) 29 "SymbolGenerator.mxg"
                __cb.Write("override");
                #line hidden
                #line (387,28)-(387,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (387,30)-(387,60) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (387,61)-(387,62) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (387,63)-(387,72) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (387,73)-(387,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (387,74)-(387,76) 29 "SymbolGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (387,76)-(387,77) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (387,77)-(387,79) 29 "SymbolGenerator.mxg"
                __cb.Write("((");
                #line hidden
                #line (387,80)-(387,107) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (387,108)-(387,128) 29 "SymbolGenerator.mxg"
                __cb.Write(")__WrappedInstance).");
                #line hidden
                #line (387,129)-(387,138) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (387,139)-(387,140) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first45 = true;
            #line (390,10)-(390,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (392,14)-(392,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first46 = true;
                #line (393,14)-(393,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first46)
                    {
                        __first46 = false;
                    }
                    var __first47 = true;
                    #line (394,18)-(394,59) 21 "SymbolGenerator.mxg"
                    if (!props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first47)
                        {
                            __first47 = false;
                        }
                        __cb.Push("        ");
                        #line (395,21)-(395,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (395,30)-(395,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (395,31)-(395,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("override");
                        #line hidden
                        #line (395,39)-(395,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (395,40)-(395,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first48 = true;
                        foreach (var __item49 in 
                        #line (395,42)-(395,99) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first48)
                            {
                                __first48 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (395,109)-(395,113) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item49);
                        }
                        #line (395,114)-(395,115) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (395,115)-(395,116) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (395,116)-(395,125) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (395,126)-(395,131) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (395,132)-(395,148) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (395,148)-(395,149) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (395,149)-(395,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (395,161)-(395,162) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (395,162)-(395,181) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (395,181)-(395,182) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (395,182)-(395,200) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (396,21)-(396,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (397,25)-(397,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (397,31)-(397,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (397,32)-(397,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first50 = true;
                        foreach (var __item51 in 
                        #line (397,34)-(397,90) 25 "SymbolGenerator.mxg"
                        from prop in props select GetDefaultValue(symbol, prop) 
                        #line hidden
                        )
                        {
                            if (__first50)
                            {
                                __first50 = false;
                            }
                            else
                            {
                                __cb.Push("            ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (397,100)-(397,104) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item51);
                        }
                        #line (397,105)-(397,107) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (398,21)-(398,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first47) __cb.AppendLine();
                }
                #line (400,14)-(400,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first46)
                    {
                        __first46 = false;
                    }
                    #line (401,18)-(401,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first52 = true;
                    #line (402,18)-(402,38) 21 "SymbolGenerator.mxg"
                    if (!prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first52)
                        {
                            __first52 = false;
                        }
                        __cb.Push("        ");
                        #line (403,21)-(403,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (403,30)-(403,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (403,31)-(403,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("override");
                        #line hidden
                        #line (403,39)-(403,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (403,41)-(403,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (403,72)-(403,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (403,73)-(403,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (403,83)-(403,88) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (403,89)-(403,105) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (403,105)-(403,106) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (403,106)-(403,118) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (403,118)-(403,119) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (403,119)-(403,138) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (403,138)-(403,139) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (403,139)-(403,157) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (404,21)-(404,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (405,25)-(405,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (405,31)-(405,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (405,33)-(405,62) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (405,63)-(405,64) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (406,21)-(406,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first52) __cb.AppendLine();
                }
                if (!__first46) __cb.AppendLine();
            }
            if (!__first45) __cb.AppendLine();
            __cb.Push("    ");
            #line (410,5)-(410,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (411,1)-(411,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (414,9)-(414,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (415,1)-(415,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (415,6)-(415,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (415,7)-(415,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (416,1)-(416,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (416,6)-(416,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,7)-(416,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (417,1)-(417,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (417,6)-(417,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,7)-(417,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (418,1)-(418,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (418,6)-(418,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,7)-(418,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (419,1)-(419,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (419,6)-(419,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,7)-(419,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (420,1)-(420,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (420,6)-(420,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,7)-(420,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (422,1)-(422,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (422,10)-(422,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,12)-(422,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (423,1)-(423,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (424,5)-(424,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (424,13)-(424,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,14)-(424,21) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (424,21)-(424,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,22)-(424,27) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (424,27)-(424,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,29)-(424,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (424,57)-(424,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,58)-(424,59) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (424,59)-(424,60) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,61)-(424,88) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (425,5)-(425,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (426,5)-(426,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (427,1)-(427,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}