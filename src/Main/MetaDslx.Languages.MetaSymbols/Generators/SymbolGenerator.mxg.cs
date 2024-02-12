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
            #line (11,6)-(11,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (12,5)-(12,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (12,11)-(12,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,12)-(12,21) 25 "SymbolGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (12,21)-(12,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,23)-(12,50) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (12,51)-(12,52) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (12,52)-(12,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first1 = true;
            #line (12,54)-(12,79) 13 "SymbolGenerator.mxg"
            if (baseTypes.Count == 0)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                #line (12,80)-(12,124) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol");
                #line hidden
            }
            #line (12,125)-(12,129) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                var __first2 = true;
                foreach (var __item3 in 
                #line (12,131)-(12,183) 17 "SymbolGenerator.mxg"
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
                        #line (12,193)-(12,197) 36 "SymbolGenerator.mxg"
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
            #line (13,5)-(13,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first4 = true;
            #line (14,10)-(14,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                __cb.Push("        ");
                #line (15,14)-(15,44) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (15,45)-(15,46) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (15,47)-(15,56) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (15,57)-(15,58) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (15,58)-(15,59) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (15,59)-(15,60) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (15,60)-(15,64) 29 "SymbolGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (15,64)-(15,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (15,65)-(15,66) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (18,9)-(18,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (18,15)-(18,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,16)-(18,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (18,22)-(18,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,23)-(18,28) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (18,28)-(18,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,29)-(18,44) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (19,9)-(19,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first5 = true;
            #line (20,14)-(20,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
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
                #line (21,55)-(21,61) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (21,62)-(21,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (21,68)-(21,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,69)-(21,70) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (21,70)-(21,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,71)-(21,74) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (21,74)-(21,75) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,75)-(21,103) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Start_");
                #line hidden
                #line (21,104)-(21,109) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (21,110)-(21,113) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (22,17)-(22,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (22,23)-(22,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,24)-(22,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (22,30)-(22,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,31)-(22,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (22,39)-(22,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,40)-(22,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (22,54)-(22,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,55)-(22,62) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (22,63)-(22,68) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (22,69)-(22,70) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,70)-(22,71) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (22,71)-(22,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,72)-(22,75) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (22,75)-(22,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (22,76)-(22,105) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Finish_");
                #line hidden
                #line (22,106)-(22,111) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (22,112)-(22,115) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("            ");
            #line (24,13)-(24,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (24,19)-(24,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,20)-(24,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (24,26)-(24,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,27)-(24,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (24,35)-(24,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,36)-(24,51) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (24,51)-(24,52) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,52)-(24,67) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (24,67)-(24,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,68)-(24,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,69)-(24,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (25,17)-(25,49) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first6 = true;
            #line (26,22)-(26,63) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol)) 
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                else
                {
                    __cb.Push("                    ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (26,73)-(26,78) 32 "SymbolGenerator.mxg"
                    __cb.Write(",\n");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("                    ");
                #line (27,25)-(27,31) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (27,32)-(27,37) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (27,38)-(27,39) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (27,39)-(27,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (27,40)-(27,47) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (27,48)-(27,53) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.Push("                ");
            #line (29,17)-(29,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (30,9)-(30,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (31,5)-(31,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (32,1)-(32,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (35,9)-(35,37) 22 "SymbolGenerator.mxg"
        public string GenerateBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (36,1)-(36,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (36,10)-(36,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,12)-(36,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (37,1)-(37,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
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
            #line (38,11)-(38,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (38,20)-(38,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,21)-(38,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (38,22)-(38,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (38,23)-(38,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (39,11)-(39,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (39,25)-(39,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,26)-(39,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (39,27)-(39,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,28)-(39,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (40,11)-(40,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (40,30)-(40,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,31)-(40,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (40,32)-(40,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,33)-(40,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (41,11)-(41,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (41,19)-(41,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,20)-(41,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (41,21)-(41,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (41,22)-(41,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            #line (42,11)-(42,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (42,28)-(42,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,29)-(42,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (42,30)-(42,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (42,31)-(42,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (43,11)-(43,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (43,26)-(43,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,27)-(43,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (43,28)-(43,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (43,29)-(43,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            #line (44,11)-(44,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (44,28)-(44,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,29)-(44,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (44,30)-(44,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,31)-(44,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (45,11)-(45,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (45,27)-(45,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,28)-(45,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (45,29)-(45,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (45,30)-(45,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (46,11)-(46,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (46,26)-(46,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,27)-(46,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (46,28)-(46,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,29)-(46,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (47,11)-(47,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (47,27)-(47,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,28)-(47,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (47,29)-(47,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (47,30)-(47,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            #line (48,11)-(48,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (48,30)-(48,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,31)-(48,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (48,32)-(48,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (48,33)-(48,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,5)-(50,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (50,13)-(50,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,14)-(50,22) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (50,22)-(50,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,23)-(50,28) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (50,28)-(50,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,30)-(50,57) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (50,58)-(50,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,59)-(50,60) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (50,60)-(50,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,61)-(50,110) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolBase,");
            #line hidden
            #line (50,110)-(50,111) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (50,112)-(50,139) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (51,5)-(51,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first7 = true;
            #line (52,10)-(52,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                var __first8 = true;
                #line (53,14)-(53,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("        ");
                    #line (54,17)-(54,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (54,24)-(54,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (54,25)-(54,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (54,31)-(54,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (54,33)-(54,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (54,60)-(54,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (54,62)-(54,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (54,81)-(54,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (54,82)-(54,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (54,83)-(54,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (54,84)-(54,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (54,87)-(54,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (54,89)-(54,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (54,116)-(54,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (55,14)-(55,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("        ");
                    #line (56,17)-(56,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (56,24)-(56,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (56,26)-(56,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (56,53)-(56,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (56,55)-(56,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (56,74)-(56,75) 33 "SymbolGenerator.mxg"
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
            #line (60,69)-(60,88) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (60,88)-(60,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,89)-(60,101) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (60,101)-(60,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,102)-(60,116) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (60,116)-(60,117) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,117)-(60,129) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (60,129)-(60,130) 25 "SymbolGenerator.mxg"
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
            __cb.Write("declaration,");
            #line hidden
            #line (61,43)-(61,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,44)-(61,56) 25 "SymbolGenerator.mxg"
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
            #line (65,69)-(65,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (65,83)-(65,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,84)-(65,96) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (65,96)-(65,97) 25 "SymbolGenerator.mxg"
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
            #line (66,31)-(66,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
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
            #line (70,69)-(70,78) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (70,78)-(70,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,79)-(70,92) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (70,92)-(70,93) 25 "SymbolGenerator.mxg"
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
            #line (71,31)-(71,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
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
            #line (75,20)-(75,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (75,48)-(75,57) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (75,57)-(75,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,58)-(75,68) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (75,68)-(75,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,69)-(75,86) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (75,86)-(75,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,87)-(75,97) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (75,97)-(75,98) 25 "SymbolGenerator.mxg"
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
            #line (76,31)-(76,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
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
            #line (80,9)-(80,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (80,18)-(80,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,19)-(80,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (80,27)-(80,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,28)-(80,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (80,45)-(80,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,46)-(80,61) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (80,61)-(80,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,62)-(80,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (80,64)-(80,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,66)-(80,93) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (80,94)-(80,127) 25 "SymbolGenerator.mxg"
            __cb.Write(".CompletionParts.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (82,10)-(82,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("        ");
                #line (83,14)-(83,17) 28 "SymbolGenerator.mxg"
                __cb.Write("[");
                #line hidden
                #line (83,18)-(83,33) 29 "SymbolGenerator.mxg"
                __cb.Write("__ModelProperty");
                #line hidden
                #line (83,34)-(83,37) 28 "SymbolGenerator.mxg"
                __cb.Write("]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (84,13)-(84,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (84,19)-(84,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (84,21)-(84,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (84,52)-(84,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (84,54)-(84,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (85,13)-(85,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (86,17)-(86,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (87,17)-(87,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (88,21)-(88,40) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(");
                #line hidden
                #line (88,41)-(88,68) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (88,69)-(88,93) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (88,94)-(88,103) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (88,104)-(88,105) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (88,105)-(88,106) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (88,106)-(88,111) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (88,111)-(88,112) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (88,112)-(88,121) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first10 = true;
                #line (89,22)-(89,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("                ");
                    #line (90,25)-(90,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (90,27)-(90,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,28)-(90,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (90,30)-(90,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (90,49)-(90,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (90,67)-(90,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,68)-(90,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (90,71)-(90,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,72)-(90,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (90,75)-(90,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,76)-(90,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (90,84)-(90,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,85)-(90,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (90,91)-(90,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,92)-(90,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (90,94)-(90,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (90,125)-(90,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (91,25)-(91,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (91,29)-(91,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,30)-(91,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (91,36)-(91,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,38)-(91,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (91,68)-(91,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (92,22)-(92,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("                ");
                    #line (93,25)-(93,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (93,31)-(93,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (93,33)-(93,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (93,52)-(93,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                __cb.Push("            ");
                #line (95,17)-(95,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (96,13)-(96,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (99,9)-(99,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (99,18)-(99,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,19)-(99,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (99,27)-(99,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,28)-(99,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (99,32)-(99,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,33)-(99,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (99,54)-(99,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,55)-(99,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (99,71)-(99,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,72)-(99,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (99,87)-(99,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,88)-(99,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (99,105)-(99,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,106)-(99,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (99,118)-(99,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,119)-(99,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (99,138)-(99,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,139)-(99,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (100,9)-(100,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (101,14)-(101,44) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            var __first11 = true;
            #line (102,14)-(102,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                #line (103,18)-(103,63) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                __cb.Push("            ");
                #line (104,17)-(104,19) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (104,19)-(104,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (104,20)-(104,35) 29 "SymbolGenerator.mxg"
                __cb.Write("(incompletePart");
                #line hidden
                #line (104,35)-(104,36) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (104,36)-(104,38) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (104,38)-(104,39) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (104,40)-(104,67) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (104,68)-(104,91) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (104,92)-(104,97) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (104,98)-(104,99) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (104,99)-(104,101) 29 "SymbolGenerator.mxg"
                __cb.Write("||");
                #line hidden
                #line (104,101)-(104,102) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (104,102)-(104,116) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart");
                #line hidden
                #line (104,116)-(104,117) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (104,117)-(104,119) 29 "SymbolGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (104,119)-(104,120) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (104,121)-(104,148) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (104,149)-(104,173) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (104,174)-(104,179) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (104,180)-(104,181) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (105,17)-(105,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (106,21)-(106,23) 29 "SymbolGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (106,23)-(106,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (106,24)-(106,42) 29 "SymbolGenerator.mxg"
                __cb.Write("(NotePartComplete(");
                #line hidden
                #line (106,43)-(106,70) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (106,71)-(106,94) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Start_");
                #line hidden
                #line (106,95)-(106,100) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (106,101)-(106,103) 29 "SymbolGenerator.mxg"
                __cb.Write("))");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (107,21)-(107,22) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (108,25)-(108,28) 29 "SymbolGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (108,28)-(108,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (108,29)-(108,40) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics");
                #line hidden
                #line (108,40)-(108,41) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (108,41)-(108,42) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (108,42)-(108,43) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (108,43)-(108,73) 29 "SymbolGenerator.mxg"
                __cb.Write("__DiagnosticBag.GetInstance();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first12 = true;
                #line (109,26)-(109,48) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("                    ");
                    #line (110,29)-(110,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (110,32)-(110,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (110,33)-(110,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (110,39)-(110,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (110,40)-(110,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (110,41)-(110,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (110,42)-(110,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (110,52)-(110,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (110,58)-(110,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (110,71)-(110,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (110,72)-(110,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first13 = true;
                    #line (111,30)-(111,57) 21 "SymbolGenerator.mxg"
                    foreach (var prop in props)
                    #line hidden
                    
                    {
                        if (__first13)
                        {
                            __first13 = false;
                        }
                        var __first14 = true;
                        #line (112,34)-(112,50) 25 "SymbolGenerator.mxg"
                        if (prop.IsWeak)
                        #line hidden
                        
                        {
                            if (__first14)
                            {
                                __first14 = false;
                            }
                            var __first15 = true;
                            #line (113,38)-(113,67) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first15)
                                {
                                    __first15 = false;
                                }
                                __cb.Push("                    ");
                                #line (114,41)-(114,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (114,43)-(114,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (114,44)-(114,53) 45 "SymbolGenerator.mxg"
                                __cb.Write("(!result.");
                                #line hidden
                                #line (114,54)-(114,63) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (114,64)-(114,82) 45 "SymbolGenerator.mxg"
                                __cb.Write(".IsDefaultOrEmpty)");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (115,41)-(115,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (116,46)-(116,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (116,65)-(116,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (116,75)-(116,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (116,76)-(116,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (116,84)-(116,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (116,94)-(116,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (117,41)-(117,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            #line (118,38)-(118,42) 29 "SymbolGenerator.mxg"
                            else
                            #line hidden
                            
                            {
                                if (__first15)
                                {
                                    __first15 = false;
                                }
                                __cb.Push("                    ");
                                #line (119,41)-(119,43) 45 "SymbolGenerator.mxg"
                                __cb.Write("if");
                                #line hidden
                                #line (119,43)-(119,44) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (119,44)-(119,52) 45 "SymbolGenerator.mxg"
                                __cb.Write("(result.");
                                #line hidden
                                #line (119,53)-(119,62) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (119,63)-(119,64) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (119,64)-(119,66) 45 "SymbolGenerator.mxg"
                                __cb.Write("!=");
                                #line hidden
                                #line (119,66)-(119,67) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (119,68)-(119,97) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetDefaultValue(symbol, prop));
                                #line hidden
                                #line (119,98)-(119,99) 45 "SymbolGenerator.mxg"
                                __cb.Write(")");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (120,41)-(120,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("{");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                        ");
                                #line (121,46)-(121,64) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetFieldName(prop));
                                #line hidden
                                #line (121,65)-(121,75) 45 "SymbolGenerator.mxg"
                                __cb.Write(".Add(this,");
                                #line hidden
                                #line (121,75)-(121,76) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (121,76)-(121,83) 45 "SymbolGenerator.mxg"
                                __cb.Write("result.");
                                #line hidden
                                #line (121,84)-(121,93) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (121,94)-(121,96) 45 "SymbolGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                                __cb.Push("                    ");
                                #line (122,41)-(122,42) 45 "SymbolGenerator.mxg"
                                __cb.Write("}");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first15) __cb.AppendLine();
                        }
                        #line (124,34)-(124,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first14)
                            {
                                __first14 = false;
                            }
                            __cb.Push("                    ");
                            #line (125,38)-(125,56) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (125,57)-(125,58) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (125,58)-(125,59) 41 "SymbolGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (125,59)-(125,60) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (125,60)-(125,67) 41 "SymbolGenerator.mxg"
                            __cb.Write("result.");
                            #line hidden
                            #line (125,68)-(125,77) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (125,78)-(125,79) 41 "SymbolGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first14) __cb.AppendLine();
                    }
                    if (!__first13) __cb.AppendLine();
                }
                #line (128,26)-(128,53) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("                    ");
                    #line (129,29)-(129,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (129,32)-(129,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (129,33)-(129,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("result");
                    #line hidden
                    #line (129,39)-(129,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (129,40)-(129,41) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (129,41)-(129,42) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (129,42)-(129,51) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (129,52)-(129,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (129,58)-(129,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (129,71)-(129,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (129,72)-(129,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    #line (130,30)-(130,49) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first16 = true;
                    #line (131,30)-(131,46) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first16)
                        {
                            __first16 = false;
                        }
                        var __first17 = true;
                        #line (132,34)-(132,63) 25 "SymbolGenerator.mxg"
                        if (prop.Type.Dimensions > 0)
                        #line hidden
                        
                        {
                            if (__first17)
                            {
                                __first17 = false;
                            }
                            __cb.Push("                    ");
                            #line (133,37)-(133,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (133,39)-(133,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (133,40)-(133,66) 41 "SymbolGenerator.mxg"
                            __cb.Write("(!result.IsDefaultOrEmpty)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (134,37)-(134,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (135,42)-(135,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (135,61)-(135,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (135,71)-(135,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (135,72)-(135,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (136,37)-(136,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (137,34)-(137,38) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first17)
                            {
                                __first17 = false;
                            }
                            __cb.Push("                    ");
                            #line (138,37)-(138,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("if");
                            #line hidden
                            #line (138,39)-(138,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (138,40)-(138,47) 41 "SymbolGenerator.mxg"
                            __cb.Write("(result");
                            #line hidden
                            #line (138,47)-(138,48) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (138,48)-(138,50) 41 "SymbolGenerator.mxg"
                            __cb.Write("!=");
                            #line hidden
                            #line (138,50)-(138,51) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (138,52)-(138,81) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetDefaultValue(symbol, prop));
                            #line hidden
                            #line (138,82)-(138,83) 41 "SymbolGenerator.mxg"
                            __cb.Write(")");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (139,37)-(139,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                        ");
                            #line (140,42)-(140,60) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetFieldName(prop));
                            #line hidden
                            #line (140,61)-(140,71) 41 "SymbolGenerator.mxg"
                            __cb.Write(".Add(this,");
                            #line hidden
                            #line (140,71)-(140,72) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (140,72)-(140,80) 41 "SymbolGenerator.mxg"
                            __cb.Write("result);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("                    ");
                            #line (141,37)-(141,38) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first17) __cb.AppendLine();
                    }
                    #line (143,30)-(143,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first16)
                        {
                            __first16 = false;
                        }
                        __cb.Push("                    ");
                        #line (144,34)-(144,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (144,53)-(144,54) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (144,54)-(144,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (144,55)-(144,56) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (144,56)-(144,63) 37 "SymbolGenerator.mxg"
                        __cb.Write("result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first16) __cb.AppendLine();
                }
                #line (146,26)-(146,30) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("                    ");
                    #line (147,29)-(147,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (147,39)-(147,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (147,45)-(147,58) 33 "SymbolGenerator.mxg"
                    __cb.Write("(diagnostics,");
                    #line hidden
                    #line (147,58)-(147,59) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (147,59)-(147,78) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
                __cb.Push("                    ");
                #line (149,25)-(149,59) 29 "SymbolGenerator.mxg"
                __cb.Write("AddSymbolDiagnostics(diagnostics);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (150,25)-(150,44) 29 "SymbolGenerator.mxg"
                __cb.Write("diagnostics.Free();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                    ");
                #line (151,25)-(151,42) 29 "SymbolGenerator.mxg"
                __cb.Write("NotePartComplete(");
                #line hidden
                #line (151,43)-(151,70) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (151,71)-(151,95) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (151,96)-(151,101) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (151,102)-(151,104) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (152,21)-(152,22) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (153,21)-(153,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (153,27)-(153,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,28)-(153,33) 29 "SymbolGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (154,17)-(154,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (155,17)-(155,21) 29 "SymbolGenerator.mxg"
                __cb.Write("else");
                #line hidden
                #line (155,21)-(155,22) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first11) __cb.AppendLine();
            var __first18 = true;
            #line (157,14)-(157,36) 13 "SymbolGenerator.mxg"
            if (phases.Length > 0)
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                __cb.Push("            ");
                #line (158,17)-(158,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (159,21)-(159,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (159,27)-(159,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,28)-(159,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (159,54)-(159,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,55)-(159,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (159,70)-(159,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,71)-(159,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (159,83)-(159,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (159,84)-(159,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (160,17)-(160,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (161,14)-(161,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                __cb.Push("            ");
                #line (162,17)-(162,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (162,23)-(162,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,24)-(162,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (162,50)-(162,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,51)-(162,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (162,66)-(162,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,67)-(162,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (162,79)-(162,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,80)-(162,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first18) __cb.AppendLine();
            __cb.Push("        ");
            #line (164,9)-(164,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first19 = true;
            #line (166,10)-(166,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first19)
                {
                    __first19 = false;
                }
                #line (167,14)-(167,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first20 = true;
                #line (168,14)-(168,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    var __first21 = true;
                    #line (169,18)-(169,58) 21 "SymbolGenerator.mxg"
                    if (props.Where(p => p.IsDerived).Any())
                    #line hidden
                    
                    {
                        if (__first21)
                        {
                            __first21 = false;
                        }
                        __cb.Push("        ");
                        #line (170,21)-(170,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (170,30)-(170,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,31)-(170,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (170,39)-(170,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,40)-(170,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first22 = true;
                        foreach (var __item23 in 
                        #line (170,42)-(170,99) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first22)
                            {
                                __first22 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (170,109)-(170,113) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item23);
                        }
                        #line (170,114)-(170,115) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (170,115)-(170,116) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,116)-(170,125) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (170,126)-(170,131) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (170,132)-(170,148) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (170,148)-(170,149) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,149)-(170,161) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (170,161)-(170,162) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,162)-(170,181) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (170,181)-(170,182) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,182)-(170,201) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (171,18)-(171,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first21)
                        {
                            __first21 = false;
                        }
                        __cb.Push("        ");
                        #line (172,21)-(172,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (172,30)-(172,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,31)-(172,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (172,38)-(172,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,39)-(172,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first24 = true;
                        foreach (var __item25 in 
                        #line (172,41)-(172,98) 25 "SymbolGenerator.mxg"
                        from prop in props select GetTypeName(symbol, prop.Type) 
                        #line hidden
                        )
                        {
                            if (__first24)
                            {
                                __first24 = false;
                            }
                            else
                            {
                                __cb.Push("        ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (172,108)-(172,112) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item25);
                        }
                        #line (172,113)-(172,114) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (172,114)-(172,115) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,115)-(172,124) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (172,125)-(172,130) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (172,131)-(172,147) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (172,147)-(172,148) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,148)-(172,160) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (172,160)-(172,161) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,161)-(172,180) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (172,180)-(172,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (172,181)-(172,199) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (173,21)-(173,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (174,25)-(174,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (174,31)-(174,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,32)-(174,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        var __first26 = true;
                        foreach (var __item27 in 
                        #line (174,34)-(174,90) 25 "SymbolGenerator.mxg"
                        from prop in props select GetDefaultValue(symbol, prop) 
                        #line hidden
                        )
                        {
                            if (__first26)
                            {
                                __first26 = false;
                            }
                            else
                            {
                                __cb.Push("            ");
                                __cb.DontIgnoreLastLineEnd = true;
                                #line (174,100)-(174,104) 44 "SymbolGenerator.mxg"
                                __cb.Write(", ");
                                #line hidden
                                __cb.DontIgnoreLastLineEnd = false;
                                __cb.Pop();
                            }
                            __cb.Write(__item27);
                        }
                        #line (174,105)-(174,107) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (175,21)-(175,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first21) __cb.AppendLine();
                }
                #line (177,14)-(177,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    #line (178,18)-(178,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    var __first28 = true;
                    #line (179,18)-(179,37) 21 "SymbolGenerator.mxg"
                    if (prop.IsDerived)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("        ");
                        #line (180,21)-(180,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (180,30)-(180,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (180,31)-(180,39) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (180,39)-(180,40) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (180,41)-(180,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (180,72)-(180,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (180,73)-(180,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (180,83)-(180,88) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (180,89)-(180,105) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (180,105)-(180,106) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (180,106)-(180,118) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (180,118)-(180,119) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (180,119)-(180,138) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (180,138)-(180,139) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (180,139)-(180,158) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (181,18)-(181,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("        ");
                        #line (182,21)-(182,30) 37 "SymbolGenerator.mxg"
                        __cb.Write("protected");
                        #line hidden
                        #line (182,30)-(182,31) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (182,31)-(182,38) 37 "SymbolGenerator.mxg"
                        __cb.Write("virtual");
                        #line hidden
                        #line (182,38)-(182,39) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (182,40)-(182,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (182,71)-(182,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (182,72)-(182,81) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (182,82)-(182,87) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (182,88)-(182,104) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (182,104)-(182,105) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (182,105)-(182,117) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (182,117)-(182,118) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (182,118)-(182,137) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (182,137)-(182,138) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (182,138)-(182,156) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken)");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (183,21)-(183,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("{");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (184,25)-(184,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (184,31)-(184,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (184,33)-(184,62) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (184,63)-(184,64) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("        ");
                        #line (185,21)-(185,22) 37 "SymbolGenerator.mxg"
                        __cb.Write("}");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first28) __cb.AppendLine();
                }
                #line (187,14)-(187,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    __cb.Push("        ");
                    #line (188,17)-(188,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (188,26)-(188,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,27)-(188,35) 33 "SymbolGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (188,35)-(188,36) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,36)-(188,40) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (188,40)-(188,41) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,41)-(188,50) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (188,51)-(188,56) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (188,57)-(188,73) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (188,73)-(188,74) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,74)-(188,86) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (188,86)-(188,87) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,87)-(188,106) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (188,106)-(188,107) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,107)-(188,126) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first20) __cb.AppendLine();
            }
            if (!__first19) __cb.AppendLine();
            __cb.Push("    ");
            #line (191,5)-(191,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (192,1)-(192,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (195,9)-(195,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (196,1)-(196,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (196,6)-(196,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,7)-(196,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (197,1)-(197,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (197,6)-(197,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,7)-(197,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (198,1)-(198,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (198,6)-(198,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,7)-(198,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (199,1)-(199,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (199,6)-(199,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,7)-(199,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (200,1)-(200,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (200,6)-(200,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (200,7)-(200,44) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols.Errors;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (202,1)-(202,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (202,10)-(202,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,12)-(202,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (203,1)-(203,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (204,5)-(204,13) 25 "SymbolGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (204,13)-(204,14) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,14)-(204,21) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (204,21)-(204,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,22)-(204,27) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (204,27)-(204,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,29)-(204,56) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (204,57)-(204,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,58)-(204,59) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (204,59)-(204,60) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,61)-(204,88) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (205,5)-(205,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
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
            #line (206,67)-(206,84) 25 "SymbolGenerator.mxg"
            __cb.Write("MergedDeclaration");
            #line hidden
            #line (206,84)-(206,85) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,85)-(206,97) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (206,97)-(206,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,98)-(206,110) 25 "SymbolGenerator.mxg"
            __cb.Write("IModelObject");
            #line hidden
            #line (206,110)-(206,111) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,111)-(206,123) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (206,123)-(206,124) 25 "SymbolGenerator.mxg"
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
            #line (207,31)-(207,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (207,43)-(207,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,44)-(207,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
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
            __cb.Push("        ");
            #line (211,9)-(211,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (211,18)-(211,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,20)-(211,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (211,48)-(211,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (211,55)-(211,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,56)-(211,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (211,66)-(211,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,67)-(211,79) 25 "SymbolGenerator.mxg"
            __cb.Write("IModelObject");
            #line hidden
            #line (211,79)-(211,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,80)-(211,92) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (211,92)-(211,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (212,13)-(212,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (212,14)-(212,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,15)-(212,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (212,30)-(212,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,31)-(212,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (213,9)-(213,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (214,9)-(214,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (216,9)-(216,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (216,18)-(216,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,20)-(216,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (216,48)-(216,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (216,55)-(216,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,56)-(216,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (216,66)-(216,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,67)-(216,97) 25 "SymbolGenerator.mxg"
            __cb.Write("Microsoft.CodeAnalysis.ISymbol");
            #line hidden
            #line (216,97)-(216,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,98)-(216,111) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (216,111)-(216,112) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (217,13)-(217,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (217,14)-(217,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,15)-(217,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (217,30)-(217,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,31)-(217,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (218,9)-(218,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (219,9)-(219,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (221,9)-(221,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (221,18)-(221,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,20)-(221,47) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (221,48)-(221,55) 25 "SymbolGenerator.mxg"
            __cb.Write("(Symbol");
            #line hidden
            #line (221,55)-(221,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,56)-(221,66) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (221,66)-(221,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,67)-(221,82) 25 "SymbolGenerator.mxg"
            __cb.Write("ErrorSymbolInfo");
            #line hidden
            #line (221,82)-(221,83) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,83)-(221,93) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (221,93)-(221,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (222,13)-(222,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (222,14)-(222,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,15)-(222,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (222,30)-(222,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,31)-(222,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (223,9)-(223,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (224,9)-(224,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (226,5)-(226,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (227,1)-(227,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}