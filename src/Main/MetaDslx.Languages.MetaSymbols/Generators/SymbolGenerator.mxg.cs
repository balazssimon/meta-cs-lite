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
    #line (4,7)-(4,28) 13 "SymbolGenerator.mxg"
    MetaDslx.CodeAnalysis;
    #line hidden
    #line (5,1)-(5,6) 5 "SymbolGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,43) 13 "SymbolGenerator.mxg"
    MetaDslx.Languages.MetaSymbols.Model;
    #line hidden
    
    #line (7,10)-(7,26) 25 "SymbolGenerator.mxg"
    public partial class SymbolGenerator
    #line hidden
    {
        #line (9,9)-(9,42) 22 "SymbolGenerator.mxg"
        public string GenerateInterface(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (10,1)-(10,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (10,10)-(10,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (10,12)-(10,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (11,1)-(11,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (12,5)-(12,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,10)-(12,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,11)-(12,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (12,26)-(12,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,27)-(12,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (12,28)-(12,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,29)-(12,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            #line (14,6)-(14,38) 13 "SymbolGenerator.mxg"
            var baseTypes = symbol.BaseTypes;
            #line hidden
            
            #line (15,5)-(15,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (15,11)-(15,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,12)-(15,21) 25 "SymbolGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (15,21)-(15,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,23)-(15,50) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (15,51)-(15,52) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (15,52)-(15,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first1 = true;
            #line (15,54)-(15,79) 13 "SymbolGenerator.mxg"
            if (baseTypes.Count == 0)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                #line (15,80)-(15,124) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol");
                #line hidden
            }
            #line (15,125)-(15,129) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                var __first2 = true;
                foreach (var __item3 in 
                #line (15,131)-(15,183) 17 "SymbolGenerator.mxg"
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
                        #line (15,193)-(15,197) 36 "SymbolGenerator.mxg"
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
            #line (16,5)-(16,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first4 = true;
            #line (17,10)-(17,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                __cb.Push("        ");
                #line (18,14)-(18,17) 28 "SymbolGenerator.mxg"
                __cb.Write("[");
                #line hidden
                #line (18,18)-(18,33) 29 "SymbolGenerator.mxg"
                __cb.Write("__ModelProperty");
                #line hidden
                #line (18,34)-(18,37) 28 "SymbolGenerator.mxg"
                __cb.Write("]");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (19,14)-(19,44) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (19,45)-(19,46) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (19,47)-(19,56) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (19,57)-(19,58) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (19,58)-(19,59) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (19,59)-(19,60) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (19,60)-(19,64) 29 "SymbolGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (19,64)-(19,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (19,65)-(19,66) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first5 = true;
            #line (22,10)-(22,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => !o.IsPhase))
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("        ");
                #line (23,14)-(23,48) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, op.ReturnType));
                #line hidden
                #line (23,49)-(23,50) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (23,51)-(23,58) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (23,59)-(23,60) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first6 = true;
                foreach (var __item7 in 
                #line (23,61)-(23,131) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                #line hidden
                )
                {
                    if (__first6)
                    {
                        __first6 = false;
                    }
                    else
                    {
                        __cb.Push("        ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (23,141)-(23,145) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item7);
                }
                #line (23,146)-(23,148) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,9)-(26,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (26,15)-(26,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,16)-(26,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (26,22)-(26,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,23)-(26,26) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (26,26)-(26,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,27)-(26,32) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (26,32)-(26,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,33)-(26,48) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,9)-(27,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first8 = true;
            #line (28,14)-(28,54) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                __cb.Push("            ");
                #line (29,17)-(29,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (29,23)-(29,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (29,24)-(29,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (29,30)-(29,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (29,31)-(29,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (29,39)-(29,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (29,40)-(29,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (29,54)-(29,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (29,55)-(29,61) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (29,62)-(29,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (29,68)-(29,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (29,69)-(29,70) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (29,70)-(29,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (29,71)-(29,74) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (29,74)-(29,75) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (29,75)-(29,103) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Start_");
                #line hidden
                #line (29,104)-(29,109) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (29,110)-(29,113) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (30,17)-(30,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (30,23)-(30,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,24)-(30,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (30,30)-(30,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,31)-(30,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (30,39)-(30,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,40)-(30,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (30,54)-(30,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,55)-(30,62) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (30,63)-(30,68) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (30,69)-(30,70) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,70)-(30,71) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (30,71)-(30,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,72)-(30,75) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (30,75)-(30,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (30,76)-(30,105) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Finish_");
                #line hidden
                #line (30,106)-(30,111) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (30,112)-(30,115) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first8) __cb.AppendLine();
            __cb.Push("            ");
            #line (32,13)-(32,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (32,19)-(32,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,20)-(32,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (32,26)-(32,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,27)-(32,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (32,35)-(32,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,36)-(32,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (32,50)-(32,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,51)-(32,66) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attribute");
            #line hidden
            #line (32,66)-(32,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,67)-(32,68) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (32,68)-(32,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,69)-(32,72) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (32,72)-(32,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,73)-(32,113) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Start_Attribute));");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (33,13)-(33,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (33,19)-(33,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,20)-(33,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (33,26)-(33,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,27)-(33,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (33,35)-(33,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,36)-(33,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (33,50)-(33,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,51)-(33,67) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attribute");
            #line hidden
            #line (33,67)-(33,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,68)-(33,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,69)-(33,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,70)-(33,73) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (33,73)-(33,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,74)-(33,115) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Finish_Attribute));");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (35,13)-(35,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (35,19)-(35,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,20)-(35,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (35,26)-(35,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,27)-(35,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (35,35)-(35,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,36)-(35,51) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (35,51)-(35,52) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,52)-(35,67) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (35,67)-(35,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,68)-(35,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (35,69)-(35,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (36,17)-(36,49) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (37,22)-(37,62) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("                    ");
                #line (38,25)-(38,31) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (38,32)-(38,37) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (38,38)-(38,39) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (38,39)-(38,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (38,40)-(38,47) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (38,48)-(38,53) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (38,54)-(38,55) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("                    ");
            #line (40,21)-(40,37) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attribute,");
            #line hidden
            #line (40,37)-(40,38) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (40,38)-(40,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attribute");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (41,17)-(41,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (42,9)-(42,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (43,5)-(43,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (44,1)-(44,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (47,9)-(47,37) 22 "SymbolGenerator.mxg"
        public string GenerateBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first10 = true;
            #line (48,6)-(48,38) 13 "SymbolGenerator.mxg"
            if (symbol.BaseTypes.Count == 0)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                __cb.Push("");
                #line (49,10)-(49,42) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateSingleBase(symbol, null));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (50,6)-(50,43) 13 "SymbolGenerator.mxg"
            else if (symbol.BaseTypes.Count == 1)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                __cb.Push("");
                #line (51,10)-(51,57) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateSingleBase(symbol, symbol.BaseTypes[0]));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (52,6)-(52,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                __cb.Push("");
                #line (53,10)-(53,35) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateMultiBase(symbol));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first10) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (57,9)-(57,63) 22 "SymbolGenerator.mxg"
        public string GenerateSingleBase(Symbol symbol, Symbol? baseSymbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (58,1)-(58,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (58,10)-(58,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,12)-(58,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (58,33)-(58,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (59,1)-(59,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
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
            #line (60,11)-(60,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (60,20)-(60,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,21)-(60,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (60,22)-(60,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,23)-(60,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (61,11)-(61,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (61,19)-(61,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,20)-(61,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (61,21)-(61,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,22)-(61,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            #line (62,11)-(62,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (62,28)-(62,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,29)-(62,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (62,30)-(62,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,31)-(62,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
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
            __cb.Write("__AssemblySymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
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
            #line (64,11)-(64,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (64,25)-(64,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,26)-(64,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (64,27)-(64,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,28)-(64,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
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
            #line (65,11)-(65,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (65,30)-(65,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,31)-(65,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (65,32)-(65,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,33)-(65,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
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
            __cb.Write("__NamespaceSymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
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
            #line (67,11)-(67,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (67,23)-(67,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,24)-(67,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,25)-(67,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,26)-(67,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
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
            #line (68,11)-(68,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (68,27)-(68,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,28)-(68,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (68,29)-(68,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,30)-(68,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
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
            __cb.Write("__LexicalSortKey");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
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
            #line (70,11)-(70,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (70,25)-(70,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,26)-(70,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,27)-(70,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,28)-(70,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (71,11)-(71,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (71,28)-(71,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,29)-(71,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (71,30)-(71,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,31)-(71,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (72,11)-(72,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (72,26)-(72,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,27)-(72,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (72,28)-(72,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,29)-(72,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            #line (73,11)-(73,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (73,28)-(73,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,29)-(73,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,30)-(73,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,31)-(73,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (74,11)-(74,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (74,27)-(74,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,28)-(74,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,29)-(74,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,30)-(74,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (75,11)-(75,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (75,30)-(75,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,31)-(75,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (75,32)-(75,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,33)-(75,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (76,11)-(76,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (76,26)-(76,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,27)-(76,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,28)-(76,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,29)-(76,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (77,11)-(77,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (77,24)-(77,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,25)-(77,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (77,26)-(77,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,27)-(77,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            #line (78,11)-(78,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (78,27)-(78,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,28)-(78,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (78,29)-(78,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,30)-(78,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            #line (79,11)-(79,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (79,30)-(79,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,31)-(79,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (79,32)-(79,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,33)-(79,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (80,5)-(80,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (80,10)-(80,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,11)-(80,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (80,36)-(80,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,37)-(80,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (80,38)-(80,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,39)-(80,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (81,5)-(81,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (81,10)-(81,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,11)-(81,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (81,24)-(81,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,25)-(81,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (81,26)-(81,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,27)-(81,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (82,5)-(82,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (82,10)-(82,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,11)-(82,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (82,38)-(82,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,39)-(82,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (82,40)-(82,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,41)-(82,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (84,5)-(84,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (84,11)-(84,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,12)-(84,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (84,19)-(84,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,20)-(84,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (84,25)-(84,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,27)-(84,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (84,55)-(84,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,56)-(84,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (84,57)-(84,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first11 = true;
            #line (84,59)-(84,82) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                #line (84,83)-(84,131) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst");
                #line hidden
            }
            #line (84,132)-(84,136) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                #line (84,138)-(84,169) 28 "SymbolGenerator.mxg"
                __cb.Write(GetInstName(symbol, baseSymbol));
                #line hidden
            }
            #line (84,178)-(84,179) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (84,179)-(84,180) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,181)-(84,208) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (85,5)-(85,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first12 = true;
            #line (86,10)-(86,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                var __first13 = true;
                #line (87,14)-(87,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("        ");
                    #line (88,17)-(88,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (88,24)-(88,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,25)-(88,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (88,31)-(88,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,33)-(88,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (88,60)-(88,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,62)-(88,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (88,81)-(88,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,82)-(88,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (88,83)-(88,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,84)-(88,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (88,87)-(88,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,89)-(88,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (88,116)-(88,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (89,14)-(89,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("        ");
                    #line (90,17)-(90,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (90,24)-(90,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,26)-(90,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (90,53)-(90,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,55)-(90,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (90,74)-(90,75) 33 "SymbolGenerator.mxg"
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
            #line (94,66)-(94,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (94,85)-(94,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,86)-(94,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (94,98)-(94,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,99)-(94,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (94,113)-(94,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,114)-(94,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (94,126)-(94,127) 25 "SymbolGenerator.mxg"
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
            __cb.Write("declaration,");
            #line hidden
            #line (95,43)-(95,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,44)-(95,56) 25 "SymbolGenerator.mxg"
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
            #line (99,66)-(99,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (99,80)-(99,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,81)-(99,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (99,93)-(99,94) 25 "SymbolGenerator.mxg"
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
            #line (100,31)-(100,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
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
            #line (104,66)-(104,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (104,75)-(104,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,76)-(104,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (104,89)-(104,90) 25 "SymbolGenerator.mxg"
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
            #line (105,31)-(105,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
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
            #line (109,66)-(109,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (109,83)-(109,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,84)-(109,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (109,94)-(109,95) 25 "SymbolGenerator.mxg"
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
            #line (110,31)-(110,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (111,9)-(111,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (112,9)-(112,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (114,9)-(114,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (114,15)-(114,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,17)-(114,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (114,45)-(114,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (114,54)-(114,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,55)-(114,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (114,65)-(114,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,66)-(114,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (114,85)-(114,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,86)-(114,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (114,98)-(114,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,99)-(114,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (114,113)-(114,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,114)-(114,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (114,126)-(114,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,127)-(114,134) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (114,134)-(114,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,135)-(114,140) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (114,140)-(114,141) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,141)-(114,148) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (114,148)-(114,149) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,149)-(114,162) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (114,162)-(114,163) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,163)-(114,190) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (114,190)-(114,191) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,191)-(114,201) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first14 = true;
            #line (114,202)-(114,245) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                #line (114,246)-(114,247) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (114,247)-(114,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (114,249)-(114,279) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (114,280)-(114,281) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (114,282)-(114,300) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (114,314)-(114,315) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (114,315)-(114,316) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (115,13)-(115,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (115,14)-(115,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,15)-(115,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (115,30)-(115,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,31)-(115,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (115,43)-(115,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,44)-(115,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (115,56)-(115,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,57)-(115,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (115,62)-(115,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,63)-(115,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (115,76)-(115,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,77)-(115,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first15 = true;
            #line (115,88)-(115,135) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                #line (115,136)-(115,137) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (115,137)-(115,138) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (115,139)-(115,157) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (115,171)-(115,172) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (116,9)-(116,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first16 = true;
            #line (117,14)-(117,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                __cb.Push("            ");
                #line (118,18)-(118,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("        ");
            #line (120,9)-(120,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (122,9)-(122,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (122,15)-(122,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,17)-(122,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (122,45)-(122,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (122,54)-(122,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,55)-(122,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (122,65)-(122,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,66)-(122,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (122,80)-(122,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,81)-(122,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (122,93)-(122,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,94)-(122,101) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (122,101)-(122,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,102)-(122,107) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (122,107)-(122,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,108)-(122,115) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (122,115)-(122,116) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,116)-(122,129) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (122,129)-(122,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,130)-(122,157) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (122,157)-(122,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (122,158)-(122,168) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first17 = true;
            #line (122,169)-(122,212) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                #line (122,213)-(122,214) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (122,214)-(122,215) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (122,216)-(122,246) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (122,247)-(122,248) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (122,249)-(122,267) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (122,281)-(122,282) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (122,282)-(122,283) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (123,13)-(123,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (123,14)-(123,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,15)-(123,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (123,30)-(123,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,31)-(123,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (123,43)-(123,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,44)-(123,49) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (123,49)-(123,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,50)-(123,63) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (123,63)-(123,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,64)-(123,74) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first18 = true;
            #line (123,75)-(123,122) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                #line (123,123)-(123,124) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (123,124)-(123,125) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (123,126)-(123,144) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (123,158)-(123,159) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (124,9)-(124,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first19 = true;
            #line (125,14)-(125,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first19)
                {
                    __first19 = false;
                }
                __cb.Push("            ");
                #line (126,18)-(126,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first19) __cb.AppendLine();
            __cb.Push("        ");
            #line (128,9)-(128,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (130,9)-(130,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (130,15)-(130,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,17)-(130,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (130,45)-(130,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (130,54)-(130,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,55)-(130,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (130,65)-(130,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,66)-(130,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (130,75)-(130,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,76)-(130,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (130,89)-(130,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,90)-(130,97) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (130,97)-(130,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,98)-(130,103) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (130,103)-(130,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,104)-(130,111) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (130,111)-(130,112) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,112)-(130,125) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (130,125)-(130,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,126)-(130,153) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (130,153)-(130,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,154)-(130,164) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first20 = true;
            #line (130,165)-(130,208) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                #line (130,209)-(130,210) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (130,210)-(130,211) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,212)-(130,242) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (130,243)-(130,244) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,245)-(130,263) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (130,277)-(130,278) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (130,278)-(130,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (131,13)-(131,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (131,14)-(131,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,15)-(131,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (131,30)-(131,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,31)-(131,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (131,44)-(131,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,45)-(131,50) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (131,50)-(131,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,51)-(131,64) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (131,64)-(131,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,65)-(131,75) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first21 = true;
            #line (131,76)-(131,123) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (131,124)-(131,125) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (131,125)-(131,126) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (131,127)-(131,145) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (131,159)-(131,160) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (132,9)-(132,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first22 = true;
            #line (133,14)-(133,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("            ");
                #line (134,18)-(134,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            __cb.Push("        ");
            #line (136,9)-(136,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (138,9)-(138,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (138,15)-(138,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,17)-(138,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (138,45)-(138,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (138,54)-(138,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,55)-(138,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (138,65)-(138,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,66)-(138,79) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (138,79)-(138,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,80)-(138,92) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (138,92)-(138,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,93)-(138,108) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (138,108)-(138,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,109)-(138,121) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (138,121)-(138,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,122)-(138,129) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (138,129)-(138,130) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,130)-(138,135) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (138,135)-(138,136) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,136)-(138,143) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (138,143)-(138,144) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,144)-(138,157) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (138,157)-(138,158) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,158)-(138,185) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (138,185)-(138,186) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,186)-(138,196) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first23 = true;
            #line (138,197)-(138,240) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (138,241)-(138,242) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (138,242)-(138,243) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (138,244)-(138,274) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (138,275)-(138,276) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (138,277)-(138,295) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (138,309)-(138,310) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (138,310)-(138,311) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (139,13)-(139,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (139,14)-(139,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,15)-(139,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (139,30)-(139,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,31)-(139,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (139,43)-(139,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,44)-(139,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (139,56)-(139,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,57)-(139,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (139,62)-(139,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,63)-(139,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (139,76)-(139,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,77)-(139,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first24 = true;
            #line (139,88)-(139,135) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol))
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                #line (139,136)-(139,137) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (139,137)-(139,138) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (139,139)-(139,157) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (139,171)-(139,172) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (140,9)-(140,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first25 = true;
            #line (141,14)-(141,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                __cb.Push("            ");
                #line (142,18)-(142,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first25) __cb.AppendLine();
            __cb.Push("        ");
            #line (144,9)-(144,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (146,9)-(146,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (146,15)-(146,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (146,16)-(146,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (146,24)-(146,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (146,25)-(146,41) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (146,41)-(146,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (146,42)-(146,55) 25 "SymbolGenerator.mxg"
            __cb.Write("SymbolFactory");
            #line hidden
            #line (146,55)-(146,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (146,56)-(146,58) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (146,58)-(146,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (146,60)-(146,113) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__ISymbolFactory", "SymbolFactory"));
            #line hidden
            #line (146,114)-(146,115) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (148,9)-(148,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (148,15)-(148,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,16)-(148,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (148,24)-(148,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,25)-(148,42) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol?");
            #line hidden
            #line (148,42)-(148,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,43)-(148,61) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingAssembly");
            #line hidden
            #line (148,61)-(148,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,62)-(148,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (148,64)-(148,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,66)-(148,124) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__AssemblySymbol", "ContainingAssembly"));
            #line hidden
            #line (148,125)-(148,126) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (150,9)-(150,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (150,15)-(150,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,16)-(150,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (150,24)-(150,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,25)-(150,39) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (150,39)-(150,40) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,40)-(150,60) 25 "SymbolGenerator.mxg"
            __cb.Write("DeclaringCompilation");
            #line hidden
            #line (150,60)-(150,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,61)-(150,63) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (150,63)-(150,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (150,65)-(150,122) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__Compilation", "DeclaringCompilation"));
            #line hidden
            #line (150,123)-(150,124) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
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
            #line (152,16)-(152,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (152,24)-(152,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,25)-(152,40) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol?");
            #line hidden
            #line (152,40)-(152,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,41)-(152,57) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingModule");
            #line hidden
            #line (152,57)-(152,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,58)-(152,60) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (152,60)-(152,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,62)-(152,116) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__ModuleSymbol", "ContainingModule"));
            #line hidden
            #line (152,117)-(152,118) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
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
            #line (154,25)-(154,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol?");
            #line hidden
            #line (154,45)-(154,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,46)-(154,67) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingDeclaration");
            #line hidden
            #line (154,67)-(154,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,68)-(154,70) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (154,70)-(154,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,72)-(154,136) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__DeclarationSymbol", "ContainingDeclaration"));
            #line hidden
            #line (154,137)-(154,138) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
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
            #line (156,16)-(156,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (156,24)-(156,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,25)-(156,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol?");
            #line hidden
            #line (156,38)-(156,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,39)-(156,53) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingType");
            #line hidden
            #line (156,53)-(156,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,54)-(156,56) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (156,56)-(156,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (156,58)-(156,108) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__TypeSymbol", "ContainingType"));
            #line hidden
            #line (156,109)-(156,110) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (158,9)-(158,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (158,15)-(158,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,16)-(158,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (158,24)-(158,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,25)-(158,43) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol?");
            #line hidden
            #line (158,43)-(158,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,44)-(158,63) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingNamespace");
            #line hidden
            #line (158,63)-(158,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,64)-(158,66) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (158,66)-(158,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,68)-(158,128) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__NamespaceSymbol", "ContainingNamespace"));
            #line hidden
            #line (158,129)-(158,130) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first26 = true;
            #line (160,10)-(160,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (162,13)-(162,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (162,19)-(162,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,21)-(162,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (162,52)-(162,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,54)-(162,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (163,13)-(163,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (164,17)-(164,20) 29 "SymbolGenerator.mxg"
                __cb.Write("get");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (165,17)-(165,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (166,21)-(166,40) 29 "SymbolGenerator.mxg"
                __cb.Write("this.ForceComplete(");
                #line hidden
                #line (166,41)-(166,68) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (166,69)-(166,93) 29 "SymbolGenerator.mxg"
                __cb.Write(".CompletionParts.Finish_");
                #line hidden
                #line (166,94)-(166,123) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Phase?.Name ?? prop.Name);
                #line hidden
                #line (166,124)-(166,125) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (166,125)-(166,126) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (166,126)-(166,131) 29 "SymbolGenerator.mxg"
                __cb.Write("null,");
                #line hidden
                #line (166,131)-(166,132) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (166,132)-(166,141) 29 "SymbolGenerator.mxg"
                __cb.Write("default);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first27 = true;
                #line (167,22)-(167,38) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    __cb.Push("                ");
                    #line (168,25)-(168,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (168,27)-(168,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,28)-(168,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (168,30)-(168,48) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (168,49)-(168,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(".TryGetValue(this,");
                    #line hidden
                    #line (168,67)-(168,68) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,68)-(168,71) 33 "SymbolGenerator.mxg"
                    __cb.Write("out");
                    #line hidden
                    #line (168,71)-(168,72) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,72)-(168,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (168,75)-(168,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,76)-(168,84) 33 "SymbolGenerator.mxg"
                    __cb.Write("result))");
                    #line hidden
                    #line (168,84)-(168,85) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,85)-(168,91) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (168,91)-(168,92) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (168,92)-(168,93) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (168,94)-(168,124) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (168,125)-(168,133) 33 "SymbolGenerator.mxg"
                    __cb.Write(")result;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (169,25)-(169,29) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (169,29)-(169,30) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (169,30)-(169,36) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (169,36)-(169,37) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (169,38)-(169,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (169,68)-(169,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (170,22)-(170,26) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    __cb.Push("                ");
                    #line (171,25)-(171,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (171,31)-(171,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,33)-(171,51) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (171,52)-(171,53) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first27) __cb.AppendLine();
                __cb.Push("            ");
                #line (173,17)-(173,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (174,13)-(174,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first26) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (177,9)-(177,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (177,15)-(177,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (177,16)-(177,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (177,24)-(177,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (177,25)-(177,41) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (177,41)-(177,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (177,42)-(177,61) 25 "SymbolGenerator.mxg"
            __cb.Write("GetLexicalSortKey()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (178,9)-(178,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (179,13)-(179,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (179,19)-(179,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,21)-(179,80) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__LexicalSortKey", "GetLexicalSortKey()"));
            #line hidden
            #line (179,81)-(179,82) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (180,9)-(180,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (182,9)-(182,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (182,15)-(182,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,16)-(182,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (182,24)-(182,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,25)-(182,29) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (182,29)-(182,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,30)-(182,52) 25 "SymbolGenerator.mxg"
            __cb.Write("HasUnsupportedMetadata");
            #line hidden
            #line (182,52)-(182,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,53)-(182,55) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (182,55)-(182,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,57)-(182,107) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "bool", "HasUnsupportedMetadata"));
            #line hidden
            #line (182,108)-(182,109) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (184,9)-(184,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (184,15)-(184,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,16)-(184,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (184,24)-(184,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,25)-(184,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (184,31)-(184,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,32)-(184,59) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentId()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (185,9)-(185,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (186,13)-(186,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (186,19)-(186,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (186,21)-(186,78) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string", "GetDocumentationCommentId()"));
            #line hidden
            #line (186,79)-(186,80) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (187,9)-(187,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (189,9)-(189,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (189,15)-(189,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,16)-(189,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (189,24)-(189,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,25)-(189,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (189,31)-(189,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,32)-(189,72) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentXml(__CultureInfo");
            #line hidden
            #line (189,72)-(189,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,73)-(189,89) 25 "SymbolGenerator.mxg"
            __cb.Write("preferredCulture");
            #line hidden
            #line (189,89)-(189,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,90)-(189,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (189,91)-(189,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,92)-(189,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (189,97)-(189,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,98)-(189,102) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (189,102)-(189,103) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,103)-(189,117) 25 "SymbolGenerator.mxg"
            __cb.Write("expandIncludes");
            #line hidden
            #line (189,117)-(189,118) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,118)-(189,119) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (189,119)-(189,120) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,120)-(189,126) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (189,126)-(189,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,127)-(189,146) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (189,146)-(189,147) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,147)-(189,164) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken");
            #line hidden
            #line (189,164)-(189,165) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,165)-(189,166) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (189,166)-(189,167) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (189,167)-(189,175) 25 "SymbolGenerator.mxg"
            __cb.Write("default)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (190,9)-(190,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (191,13)-(191,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (191,19)-(191,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,21)-(191,130) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string", "GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken)"));
            #line hidden
            #line (191,131)-(191,132) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (192,9)-(192,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first28 = true;
            #line (194,10)-(194,51) 13 "SymbolGenerator.mxg"
            foreach (var op in GetOperations(symbol))
            #line hidden
            
            {
                if (__first28)
                {
                    __first28 = false;
                }
                #line (195,14)-(195,93) 17 "SymbolGenerator.mxg"
                var call = op.Name+"("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (196,14)-(196,84) 17 "SymbolGenerator.mxg"
                var virtOvrd = symbol.Operations.Contains(op) ? "virtual" : "override";
                #line hidden
                
                __cb.Push("        ");
                #line (197,13)-(197,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (197,19)-(197,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (197,21)-(197,29) 28 "SymbolGenerator.mxg"
                __cb.Write(virtOvrd);
                #line hidden
                #line (197,30)-(197,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (197,32)-(197,66) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, op.ReturnType));
                #line hidden
                #line (197,67)-(197,68) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (197,69)-(197,76) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (197,77)-(197,78) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first29 = true;
                foreach (var __item30 in 
                #line (197,79)-(197,149) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                #line hidden
                )
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    else
                    {
                        __cb.Push("        ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (197,159)-(197,163) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item30);
                }
                #line (197,164)-(197,165) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (198,13)-(198,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first31 = true;
                #line (199,18)-(199,80) 17 "SymbolGenerator.mxg"
                if (op.ReturnType.Type.SpecialType == SpecialType.System_Void)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("            ");
                    #line (200,22)-(200,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, call));
                    #line hidden
                    #line (200,45)-(200,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (201,18)-(201,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("            ");
                    #line (202,21)-(202,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (202,27)-(202,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (202,29)-(202,87) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, GetTypeName(symbol, op.ReturnType), call));
                    #line hidden
                    #line (202,88)-(202,89) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
                __cb.Push("        ");
                #line (204,13)-(204,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first28) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (207,9)-(207,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (207,18)-(207,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,19)-(207,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (207,27)-(207,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,28)-(207,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (207,32)-(207,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,33)-(207,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (207,54)-(207,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,55)-(207,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (207,71)-(207,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,72)-(207,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (207,87)-(207,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,88)-(207,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (207,105)-(207,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,106)-(207,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (207,118)-(207,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,119)-(207,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (207,138)-(207,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,139)-(207,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (208,9)-(208,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (209,14)-(209,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            #line (210,14)-(210,44) 13 "SymbolGenerator.mxg"
            var phases = GetPhases(symbol);
            #line hidden
            
            #line (211,14)-(211,52) 13 "SymbolGenerator.mxg"
            var basePhases = GetPhases(baseSymbol);
            #line hidden
            
            var __first32 = true;
            #line (212,14)-(212,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                var __first33 = true;
                #line (213,18)-(213,50) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first33)
                    {
                        __first33 = false;
                    }
                    #line (214,22)-(214,41) 21 "SymbolGenerator.mxg"
                    hasNewPhase = true;
                    #line hidden
                    
                    #line (215,22)-(215,67) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    __cb.Push("            ");
                    #line (216,21)-(216,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (216,23)-(216,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,24)-(216,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("(incompletePart");
                    #line hidden
                    #line (216,39)-(216,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,40)-(216,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (216,42)-(216,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,44)-(216,71) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (216,72)-(216,95) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (216,96)-(216,101) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (216,102)-(216,103) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,103)-(216,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("||");
                    #line hidden
                    #line (216,105)-(216,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,106)-(216,120) 33 "SymbolGenerator.mxg"
                    __cb.Write("incompletePart");
                    #line hidden
                    #line (216,120)-(216,121) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,121)-(216,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (216,123)-(216,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (216,125)-(216,152) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (216,153)-(216,177) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (216,178)-(216,183) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (216,184)-(216,185) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (217,21)-(217,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (218,25)-(218,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (218,27)-(218,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (218,28)-(218,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("(NotePartComplete(");
                    #line hidden
                    #line (218,47)-(218,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (218,75)-(218,98) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (218,99)-(218,104) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (218,105)-(218,107) 33 "SymbolGenerator.mxg"
                    __cb.Write("))");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (219,25)-(219,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (220,29)-(220,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (220,32)-(220,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (220,33)-(220,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (220,44)-(220,45) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (220,45)-(220,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (220,46)-(220,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (220,47)-(220,77) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first34 = true;
                    #line (221,30)-(221,52) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        __cb.Push("                    ");
                        #line (222,33)-(222,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (222,36)-(222,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (222,37)-(222,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (222,43)-(222,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (222,44)-(222,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (222,45)-(222,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (222,46)-(222,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (222,56)-(222,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (222,62)-(222,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (222,75)-(222,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (222,76)-(222,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first35 = true;
                        #line (223,34)-(223,61) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props)
                        #line hidden
                        
                        {
                            if (__first35)
                            {
                                __first35 = false;
                            }
                            __cb.Push("                    ");
                            #line (224,38)-(224,87) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first35) __cb.AppendLine();
                    }
                    #line (226,30)-(226,57) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        __cb.Push("                    ");
                        #line (227,33)-(227,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (227,36)-(227,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,37)-(227,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (227,43)-(227,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,44)-(227,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (227,45)-(227,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,46)-(227,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (227,56)-(227,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (227,62)-(227,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (227,75)-(227,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (227,76)-(227,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                    ");
                        #line (228,34)-(228,76) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, props[0], "result"));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (229,30)-(229,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first34)
                        {
                            __first34 = false;
                        }
                        __cb.Push("                    ");
                        #line (230,33)-(230,42) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (230,43)-(230,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (230,49)-(230,62) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (230,62)-(230,63) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (230,63)-(230,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first34) __cb.AppendLine();
                    __cb.Push("                    ");
                    #line (232,29)-(232,63) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (233,29)-(233,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (234,29)-(234,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (234,47)-(234,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (234,75)-(234,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (234,100)-(234,105) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (234,106)-(234,108) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (235,25)-(235,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (236,25)-(236,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (236,31)-(236,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (236,32)-(236,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (237,21)-(237,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (238,21)-(238,25) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (238,25)-(238,26) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.SkipLineEnd = true;
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first33) __cb.AppendLine();
            }
            if (!__first32) __cb.AppendLine();
            var __first36 = true;
            #line (241,14)-(241,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("            ");
                #line (242,17)-(242,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (243,21)-(243,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (243,27)-(243,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,28)-(243,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (243,54)-(243,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,55)-(243,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (243,70)-(243,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,71)-(243,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (243,83)-(243,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (243,84)-(243,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (244,17)-(244,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (245,14)-(245,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("            ");
                #line (246,17)-(246,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (246,23)-(246,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (246,24)-(246,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (246,50)-(246,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (246,51)-(246,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (246,66)-(246,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (246,67)-(246,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (246,79)-(246,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (246,80)-(246,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            __cb.Push("        ");
            #line (248,9)-(248,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (251,9)-(251,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (251,18)-(251,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,19)-(251,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (251,27)-(251,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,28)-(251,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (251,32)-(251,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,33)-(251,72) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Initialize(__DiagnosticBag");
            #line hidden
            #line (251,72)-(251,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,73)-(251,85) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (251,85)-(251,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,86)-(251,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (251,105)-(251,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,106)-(251,124) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (252,9)-(252,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (253,14)-(253,89) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Initialize(diagnostics, cancellationToken)"));
            #line hidden
            #line (253,90)-(253,91) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (254,9)-(254,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (256,9)-(256,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (256,18)-(256,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,19)-(256,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (256,27)-(256,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,28)-(256,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (256,35)-(256,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,36)-(256,65) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Name(__DiagnosticBag");
            #line hidden
            #line (256,65)-(256,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,66)-(256,78) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (256,78)-(256,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,79)-(256,98) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (256,98)-(256,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (256,99)-(256,117) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (257,9)-(257,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (258,13)-(258,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (258,19)-(258,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,21)-(258,97) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_Name(diagnostics, cancellationToken)"));
            #line hidden
            #line (258,98)-(258,99) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (259,9)-(259,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (261,9)-(261,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (261,18)-(261,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,19)-(261,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (261,27)-(261,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,28)-(261,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (261,35)-(261,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,36)-(261,73) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_MetadataName(__DiagnosticBag");
            #line hidden
            #line (261,73)-(261,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,74)-(261,86) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (261,86)-(261,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,87)-(261,106) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (261,106)-(261,107) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,107)-(261,125) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (262,9)-(262,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (263,13)-(263,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (263,19)-(263,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,21)-(263,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_MetadataName(diagnostics, cancellationToken)"));
            #line hidden
            #line (263,106)-(263,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (264,9)-(264,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (266,9)-(266,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (266,18)-(266,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,19)-(266,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (266,27)-(266,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,28)-(266,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__Symbol>");
            #line hidden
            #line (266,89)-(266,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,90)-(266,141) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_CreateContainedSymbols(__DiagnosticBag");
            #line hidden
            #line (266,141)-(266,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,142)-(266,154) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (266,154)-(266,155) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,155)-(266,174) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (266,174)-(266,175) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,175)-(266,193) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (267,9)-(267,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (268,13)-(268,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (268,19)-(268,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,21)-(268,173) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__Symbol>", "CompletePart_CreateContainedSymbols(diagnostics, cancellationToken)"));
            #line hidden
            #line (268,174)-(268,175) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (269,9)-(269,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (271,9)-(271,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (271,18)-(271,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,19)-(271,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (271,27)-(271,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,28)-(271,98) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>");
            #line hidden
            #line (271,98)-(271,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,99)-(271,134) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Attributes(__DiagnosticBag");
            #line hidden
            #line (271,134)-(271,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,135)-(271,147) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (271,147)-(271,148) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,148)-(271,167) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (271,167)-(271,168) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,168)-(271,186) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (272,9)-(272,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (273,13)-(273,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (273,19)-(273,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,21)-(273,166) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>", "Complete_Attributes(diagnostics, cancellationToken)"));
            #line hidden
            #line (273,167)-(273,168) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (274,9)-(274,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (276,9)-(276,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (276,18)-(276,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,19)-(276,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (276,27)-(276,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,28)-(276,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (276,32)-(276,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,33)-(276,88) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_ComputeNonSymbolProperties(__DiagnosticBag");
            #line hidden
            #line (276,88)-(276,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,89)-(276,101) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (276,101)-(276,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,102)-(276,121) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (276,121)-(276,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,122)-(276,140) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (277,9)-(277,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (278,14)-(278,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken)"));
            #line hidden
            #line (278,106)-(278,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (279,9)-(279,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (281,9)-(281,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (281,18)-(281,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,19)-(281,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (281,27)-(281,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,28)-(281,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (281,32)-(281,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,33)-(281,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Finalize(__DiagnosticBag");
            #line hidden
            #line (281,70)-(281,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,71)-(281,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (281,83)-(281,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,84)-(281,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (281,103)-(281,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,104)-(281,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (282,9)-(282,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (283,14)-(283,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Finalize(diagnostics, cancellationToken)"));
            #line hidden
            #line (283,88)-(283,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (284,9)-(284,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (286,9)-(286,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (286,18)-(286,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,19)-(286,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (286,27)-(286,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,28)-(286,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (286,32)-(286,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,33)-(286,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Validate(__DiagnosticBag");
            #line hidden
            #line (286,70)-(286,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,71)-(286,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (286,83)-(286,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,84)-(286,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (286,103)-(286,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,104)-(286,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (287,9)-(287,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (288,14)-(288,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Validate(diagnostics, cancellationToken)"));
            #line hidden
            #line (288,88)-(288,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (289,9)-(289,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (291,10)-(291,50) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetPhases(symbol))
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (293,14)-(293,80) 17 "SymbolGenerator.mxg"
                var virtOvrd = basePhases.Contains(phase) ? "override" : "virtual";
                #line hidden
                
                #line (294,14)-(294,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first38 = true;
                #line (295,14)-(295,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (296,18)-(296,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (297,17)-(297,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (297,26)-(297,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (297,28)-(297,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (297,37)-(297,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (297,39)-(297,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (297,50)-(297,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (297,51)-(297,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (297,61)-(297,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (297,67)-(297,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (297,83)-(297,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (297,84)-(297,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (297,96)-(297,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (297,97)-(297,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (297,116)-(297,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (297,117)-(297,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (298,17)-(298,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (299,21)-(299,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (299,27)-(299,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (299,29)-(299,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (299,112)-(299,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (300,17)-(300,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (301,14)-(301,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    #line (302,18)-(302,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (303,18)-(303,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (304,17)-(304,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (304,26)-(304,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (304,28)-(304,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (304,37)-(304,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (304,39)-(304,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (304,50)-(304,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (304,51)-(304,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (304,61)-(304,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (304,67)-(304,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (304,83)-(304,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (304,84)-(304,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (304,96)-(304,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (304,97)-(304,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (304,116)-(304,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (304,117)-(304,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (305,17)-(305,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (306,21)-(306,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (306,27)-(306,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (306,29)-(306,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (306,112)-(306,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (307,17)-(307,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (308,14)-(308,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first38)
                    {
                        __first38 = false;
                    }
                    __cb.Push("        ");
                    #line (309,17)-(309,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (309,26)-(309,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (309,28)-(309,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (309,37)-(309,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (309,38)-(309,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (309,42)-(309,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (309,43)-(309,52) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (309,53)-(309,58) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (309,59)-(309,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (309,75)-(309,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (309,76)-(309,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (309,88)-(309,89) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (309,89)-(309,108) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (309,108)-(309,109) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (309,109)-(309,127) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (310,17)-(310,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (311,22)-(311,92) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (311,93)-(311,94) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (312,17)-(312,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first38) __cb.AppendLine();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("    ");
            #line (315,5)-(315,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (317,5)-(317,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (317,11)-(317,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,12)-(317,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (317,20)-(317,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,21)-(317,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (317,26)-(317,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,28)-(317,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (317,56)-(317,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,57)-(317,58) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (317,58)-(317,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first39 = true;
            #line (317,60)-(317,83) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                #line (317,84)-(317,132) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl");
                #line hidden
            }
            #line (317,133)-(317,137) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                #line (317,139)-(317,170) 28 "SymbolGenerator.mxg"
                __cb.Write(GetImplName(symbol, baseSymbol));
                #line hidden
            }
            #line (317,179)-(317,180) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (317,180)-(317,181) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,182)-(317,209) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (318,5)-(318,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first40 = true;
            #line (319,10)-(319,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("        ");
                #line (320,13)-(320,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (320,19)-(320,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (320,21)-(320,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (320,52)-(320,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (320,54)-(320,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (320,64)-(320,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (320,65)-(320,67) 29 "SymbolGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (320,67)-(320,68) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (320,68)-(320,70) 29 "SymbolGenerator.mxg"
                __cb.Write("((");
                #line hidden
                #line (320,71)-(320,98) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (320,99)-(320,111) 29 "SymbolGenerator.mxg"
                __cb.Write(")__Wrapped).");
                #line hidden
                #line (320,112)-(320,121) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (320,122)-(320,123) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first40) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first41 = true;
            #line (323,10)-(323,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => !o.IsPhase))
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("        ");
                #line (324,13)-(324,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (324,19)-(324,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (324,20)-(324,28) 29 "SymbolGenerator.mxg"
                __cb.Write("abstract");
                #line hidden
                #line (324,28)-(324,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (324,30)-(324,64) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, op.ReturnType));
                #line hidden
                #line (324,65)-(324,66) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (324,67)-(324,74) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (324,75)-(324,76) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first42 = true;
                foreach (var __item43 in 
                #line (324,77)-(324,147) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
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
                        #line (324,157)-(324,161) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item43);
                }
                #line (324,162)-(324,164) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first44 = true;
            #line (327,10)-(327,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                var __first45 = true;
                #line (328,14)-(328,46) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    __cb.WriteLine();
                    __cb.Pop();
                    #line (330,18)-(330,63) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    var __first46 = true;
                    #line (331,18)-(331,40) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first46)
                        {
                            __first46 = false;
                        }
                        #line (332,22)-(332,123) 25 "SymbolGenerator.mxg"
                        var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                        #line hidden
                        
                        var __first47 = true;
                        #line (333,22)-(333,62) 25 "SymbolGenerator.mxg"
                        if (props.Where(p => p.IsDerived).Any())
                        #line hidden
                        
                        {
                            if (__first47)
                            {
                                __first47 = false;
                            }
                            __cb.Push("        ");
                            #line (334,25)-(334,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (334,31)-(334,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (334,32)-(334,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (334,40)-(334,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (334,42)-(334,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (334,53)-(334,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (334,54)-(334,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (334,64)-(334,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (334,70)-(334,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (334,86)-(334,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (334,87)-(334,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (334,99)-(334,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (334,100)-(334,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (334,119)-(334,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (334,120)-(334,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (335,22)-(335,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first47)
                            {
                                __first47 = false;
                            }
                            __cb.Push("        ");
                            #line (336,25)-(336,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (336,31)-(336,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (336,32)-(336,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (336,39)-(336,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (336,41)-(336,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (336,52)-(336,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (336,53)-(336,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (336,63)-(336,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (336,69)-(336,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (336,85)-(336,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (336,86)-(336,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (336,98)-(336,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (336,99)-(336,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (336,118)-(336,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (336,119)-(336,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (337,25)-(337,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.SingleLineMode = true;
                            __cb.Push("            ");
                            #line (339,29)-(339,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (339,35)-(339,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (339,36)-(339,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            var __first48 = true;
                            #line (340,34)-(340,62) 29 "SymbolGenerator.mxg"
                            foreach (var prop in props) 
                            #line hidden
                            
                            {
                                if (__first48)
                                {
                                    __first48 = false;
                                }
                                else
                                {
                                    __cb.Push("                ");
                                    __cb.DontIgnoreLastLineEnd = true;
                                    #line (340,72)-(340,76) 48 "SymbolGenerator.mxg"
                                    __cb.Write(", ");
                                    #line hidden
                                    __cb.DontIgnoreLastLineEnd = false;
                                    __cb.Pop();
                                }
                                __cb.Push("                ");
                                #line (341,37)-(341,73) 45 "SymbolGenerator.mxg"
                                __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                                #line hidden
                                var __first49 = true;
                                #line (341,74)-(341,103) 33 "SymbolGenerator.mxg"
                                if (prop.Type.Dimensions > 0)
                                #line hidden
                                
                                {
                                    if (__first49)
                                    {
                                        __first49 = false;
                                    }
                                    #line (341,104)-(341,105) 49 "SymbolGenerator.mxg"
                                    __cb.Write("s");
                                    #line hidden
                                }
                                #line (341,113)-(341,114) 45 "SymbolGenerator.mxg"
                                __cb.Write("<");
                                #line hidden
                                #line (341,115)-(341,150) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetTypeName(symbol, prop.Type.Type));
                                #line hidden
                                #line (341,151)-(341,158) 45 "SymbolGenerator.mxg"
                                __cb.Write(">(this,");
                                #line hidden
                                #line (341,158)-(341,159) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (341,159)-(341,166) 45 "SymbolGenerator.mxg"
                                __cb.Write("nameof(");
                                #line hidden
                                #line (341,167)-(341,176) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (341,177)-(341,179) 45 "SymbolGenerator.mxg"
                                __cb.Write("),");
                                #line hidden
                                #line (341,179)-(341,180) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (341,180)-(341,192) 45 "SymbolGenerator.mxg"
                                __cb.Write("diagnostics,");
                                #line hidden
                                #line (341,192)-(341,193) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (341,193)-(341,212) 45 "SymbolGenerator.mxg"
                                __cb.Write("cancellationToken);");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first48) __cb.AppendLine();
                            __cb.Push("            ");
                            #line (343,29)-(343,31) 41 "SymbolGenerator.mxg"
                            __cb.Write(");");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.SingleLineMode = false;
                            __cb.AppendLine();
                            __cb.Push("        ");
                            #line (345,25)-(345,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first47) __cb.AppendLine();
                    }
                    #line (347,18)-(347,45) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first46)
                        {
                            __first46 = false;
                        }
                        #line (348,22)-(348,41) 25 "SymbolGenerator.mxg"
                        var prop = props[0];
                        #line hidden
                        
                        #line (349,22)-(349,69) 25 "SymbolGenerator.mxg"
                        var returnType = GetTypeName(symbol, prop.Type);
                        #line hidden
                        
                        var __first50 = true;
                        #line (350,22)-(350,41) 25 "SymbolGenerator.mxg"
                        if (prop.IsDerived)
                        #line hidden
                        
                        {
                            if (__first50)
                            {
                                __first50 = false;
                            }
                            __cb.Push("        ");
                            #line (351,25)-(351,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (351,31)-(351,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (351,32)-(351,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (351,40)-(351,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (351,42)-(351,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (351,53)-(351,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (351,54)-(351,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (351,64)-(351,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (351,70)-(351,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (351,86)-(351,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (351,87)-(351,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (351,99)-(351,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (351,100)-(351,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (351,119)-(351,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (351,120)-(351,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (352,22)-(352,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first50)
                            {
                                __first50 = false;
                            }
                            __cb.Push("        ");
                            #line (353,25)-(353,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (353,31)-(353,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (353,32)-(353,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (353,39)-(353,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (353,41)-(353,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (353,52)-(353,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (353,53)-(353,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (353,63)-(353,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (353,69)-(353,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (353,85)-(353,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (353,86)-(353,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (353,98)-(353,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (353,99)-(353,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (353,118)-(353,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (353,119)-(353,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (354,25)-(354,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (355,29)-(355,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (355,35)-(355,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (355,36)-(355,72) 41 "SymbolGenerator.mxg"
                            __cb.Write("SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first51 = true;
                            #line (355,73)-(355,102) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first51)
                                {
                                    __first51 = false;
                                }
                                #line (355,103)-(355,104) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (355,112)-(355,113) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (355,114)-(355,151) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (355,152)-(355,159) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (355,159)-(355,160) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (355,160)-(355,167) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (355,168)-(355,177) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (355,178)-(355,180) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (355,180)-(355,181) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (355,181)-(355,193) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (355,193)-(355,194) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (355,194)-(355,213) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (356,25)-(356,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first50) __cb.AppendLine();
                    }
                    #line (358,18)-(358,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first46)
                        {
                            __first46 = false;
                        }
                        __cb.Push("        ");
                        #line (359,21)-(359,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (359,27)-(359,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (359,28)-(359,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (359,36)-(359,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (359,37)-(359,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("void");
                        #line hidden
                        #line (359,41)-(359,42) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (359,42)-(359,51) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (359,52)-(359,57) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (359,58)-(359,74) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (359,74)-(359,75) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (359,75)-(359,87) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (359,87)-(359,88) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (359,88)-(359,107) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (359,107)-(359,108) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (359,108)-(359,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first46) __cb.AppendLine();
                }
                if (!__first45) __cb.AppendLine();
            }
            if (!__first44) __cb.AppendLine();
            __cb.Push("    ");
            #line (363,5)-(363,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (364,1)-(364,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (367,9)-(367,42) 22 "SymbolGenerator.mxg"
        public string GenerateMultiBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (368,1)-(368,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (368,10)-(368,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (368,12)-(368,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (368,33)-(368,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (369,1)-(369,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (370,5)-(370,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (370,10)-(370,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,11)-(370,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (370,20)-(370,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,21)-(370,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (370,22)-(370,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,23)-(370,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (371,5)-(371,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (371,10)-(371,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,11)-(371,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (371,25)-(371,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,26)-(371,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (371,27)-(371,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (371,28)-(371,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (372,5)-(372,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (372,10)-(372,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,11)-(372,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (372,30)-(372,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,31)-(372,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (372,32)-(372,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (372,33)-(372,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (373,5)-(373,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (373,10)-(373,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,11)-(373,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (373,19)-(373,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,20)-(373,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (373,21)-(373,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,22)-(373,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (374,5)-(374,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (374,10)-(374,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,11)-(374,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (374,28)-(374,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,29)-(374,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (374,30)-(374,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,31)-(374,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (375,5)-(375,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (375,10)-(375,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,11)-(375,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (375,26)-(375,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,27)-(375,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (375,28)-(375,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,29)-(375,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (376,5)-(376,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (376,10)-(376,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,11)-(376,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (376,28)-(376,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,29)-(376,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (376,30)-(376,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,31)-(376,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (377,5)-(377,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (377,10)-(377,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,11)-(377,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (377,27)-(377,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,28)-(377,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (377,29)-(377,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,30)-(377,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (378,5)-(378,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (378,10)-(378,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,11)-(378,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (378,26)-(378,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,27)-(378,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (378,28)-(378,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (378,29)-(378,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (379,5)-(379,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (379,10)-(379,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,11)-(379,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (379,27)-(379,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,28)-(379,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (379,29)-(379,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,30)-(379,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (380,5)-(380,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (380,10)-(380,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,11)-(380,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (380,30)-(380,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,31)-(380,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (380,32)-(380,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (380,33)-(380,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (381,5)-(381,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (381,10)-(381,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,11)-(381,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (381,36)-(381,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,37)-(381,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (381,38)-(381,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,39)-(381,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (382,5)-(382,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (382,10)-(382,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,11)-(382,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (382,38)-(382,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,39)-(382,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (382,40)-(382,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,41)-(382,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (384,5)-(384,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (384,11)-(384,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,12)-(384,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (384,19)-(384,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,20)-(384,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (384,25)-(384,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,27)-(384,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (384,55)-(384,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,56)-(384,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (384,57)-(384,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,58)-(384,107) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst,");
            #line hidden
            #line (384,107)-(384,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,109)-(384,136) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (385,5)-(385,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first52 = true;
            #line (386,10)-(386,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                var __first53 = true;
                #line (387,14)-(387,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("        ");
                    #line (388,17)-(388,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (388,24)-(388,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (388,25)-(388,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (388,31)-(388,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (388,33)-(388,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (388,60)-(388,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (388,62)-(388,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (388,81)-(388,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (388,82)-(388,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (388,83)-(388,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (388,84)-(388,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (388,87)-(388,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (388,89)-(388,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (388,116)-(388,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (389,14)-(389,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("        ");
                    #line (390,17)-(390,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (390,24)-(390,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,26)-(390,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (390,53)-(390,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (390,55)-(390,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (390,74)-(390,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first53) __cb.AppendLine();
            }
            if (!__first52) __cb.AppendLine();
            __cb.Push("        ");
            #line (393,9)-(393,11) 25 "SymbolGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (393,11)-(393,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,12)-(393,16) 25 "SymbolGenerator.mxg"
            __cb.Write("TODO");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (394,5)-(394,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (395,1)-(395,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (398,9)-(398,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (399,1)-(399,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (399,6)-(399,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (399,7)-(399,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (400,1)-(400,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (400,6)-(400,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,7)-(400,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (401,1)-(401,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (401,6)-(401,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (401,7)-(401,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (402,1)-(402,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (402,6)-(402,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,7)-(402,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (403,1)-(403,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (403,6)-(403,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,7)-(403,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (404,1)-(404,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (404,6)-(404,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (404,7)-(404,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (405,1)-(405,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (405,6)-(405,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,7)-(405,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (406,1)-(406,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (406,6)-(406,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (406,7)-(406,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (407,1)-(407,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (407,6)-(407,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (407,7)-(407,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (409,1)-(409,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (409,10)-(409,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,12)-(409,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (409,33)-(409,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (410,1)-(410,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (411,5)-(411,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (411,11)-(411,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,12)-(411,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (411,17)-(411,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,19)-(411,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (411,47)-(411,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,48)-(411,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (411,49)-(411,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,51)-(411,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (412,5)-(412,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (413,5)-(413,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (414,1)-(414,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (417,9)-(417,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first54 = true;
            #line (418,6)-(418,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first54)
                {
                    __first54 = false;
                }
                var __first55 = true;
                #line (419,10)-(419,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first55)
                    {
                        __first55 = false;
                    }
                    __cb.Push("");
                    #line (420,13)-(420,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (420,15)-(420,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (420,16)-(420,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (420,19)-(420,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (420,28)-(420,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (421,13)-(421,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (422,18)-(422,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (422,37)-(422,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (422,47)-(422,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (422,49)-(422,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (422,58)-(422,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (423,13)-(423,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (424,10)-(424,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first55)
                    {
                        __first55 = false;
                    }
                    __cb.Push("");
                    #line (425,13)-(425,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (425,15)-(425,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (425,16)-(425,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (425,18)-(425,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (425,27)-(425,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (425,28)-(425,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (425,30)-(425,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (425,32)-(425,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (425,62)-(425,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (426,13)-(426,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (427,18)-(427,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (427,37)-(427,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (427,47)-(427,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (427,49)-(427,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (427,58)-(427,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (428,13)-(428,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first55) __cb.AppendLine();
            }
            #line (430,6)-(430,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first54)
                {
                    __first54 = false;
                }
                __cb.Push("");
                #line (431,10)-(431,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (431,29)-(431,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (431,30)-(431,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (431,31)-(431,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (431,33)-(431,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (431,42)-(431,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first54) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (435,9)-(435,46) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (436,5)-(436,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (436,15)-(436,42) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (436,43)-(436,44) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (436,44)-(436,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,46)-(436,73) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (436,74)-(436,80) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (436,80)-(436,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,81)-(436,83) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (436,83)-(436,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,84)-(436,89) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (436,90)-(436,94) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (436,95)-(436,96) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (439,9)-(439,59) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string type, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (440,5)-(440,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (440,15)-(440,19) 24 "SymbolGenerator.mxg"
            __cb.Write(type);
            #line hidden
            #line (440,20)-(440,21) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (440,21)-(440,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,23)-(440,50) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (440,51)-(440,52) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (440,52)-(440,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,54)-(440,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (440,82)-(440,88) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (440,88)-(440,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,89)-(440,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (440,91)-(440,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,92)-(440,97) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (440,98)-(440,102) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (440,103)-(440,104) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}