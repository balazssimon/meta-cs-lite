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
                var __first5 = true;
                #line (18,14)-(18,31) 17 "SymbolGenerator.mxg"
                if (!prop.IsInit)
                #line hidden
                
                {
                    if (__first5)
                    {
                        __first5 = false;
                    }
                    __cb.Push("        ");
                    #line (19,18)-(19,21) 32 "SymbolGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (19,22)-(19,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (19,38)-(19,41) 32 "SymbolGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first5) __cb.AppendLine();
                __cb.Push("        ");
                #line (21,14)-(21,44) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (21,45)-(21,46) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,47)-(21,56) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (21,57)-(21,58) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,58)-(21,59) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (21,59)-(21,60) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,60)-(21,64) 29 "SymbolGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (21,64)-(21,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (21,65)-(21,66) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first6 = true;
            #line (24,10)-(24,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => !o.IsPhase))
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("        ");
                #line (25,14)-(25,48) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, op.ReturnType));
                #line hidden
                #line (25,49)-(25,50) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (25,51)-(25,58) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (25,59)-(25,60) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first7 = true;
                foreach (var __item8 in 
                #line (25,61)-(25,131) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                #line hidden
                )
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    else
                    {
                        __cb.Push("        ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (25,141)-(25,145) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item8);
                }
                #line (25,146)-(25,148) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (28,9)-(28,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (28,15)-(28,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,16)-(28,22) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (28,22)-(28,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,23)-(28,26) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (28,26)-(28,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,27)-(28,32) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (28,32)-(28,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,33)-(28,48) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionParts");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (29,9)-(29,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (30,14)-(30,57) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetAllPhases(symbol))
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("            ");
                #line (31,17)-(31,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (31,23)-(31,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (31,24)-(31,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (31,30)-(31,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (31,31)-(31,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (31,39)-(31,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (31,40)-(31,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (31,54)-(31,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (31,55)-(31,61) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (31,62)-(31,67) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (31,68)-(31,69) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (31,69)-(31,70) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (31,70)-(31,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (31,71)-(31,74) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (31,74)-(31,75) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (31,75)-(31,103) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Start_");
                #line hidden
                #line (31,104)-(31,109) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (31,110)-(31,113) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (32,17)-(32,23) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (32,23)-(32,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (32,24)-(32,30) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (32,30)-(32,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (32,31)-(32,39) 29 "SymbolGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (32,39)-(32,40) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (32,40)-(32,54) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart");
                #line hidden
                #line (32,54)-(32,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (32,55)-(32,62) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (32,63)-(32,68) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (32,69)-(32,70) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (32,70)-(32,71) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (32,71)-(32,72) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (32,72)-(32,75) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (32,75)-(32,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (32,76)-(32,105) 29 "SymbolGenerator.mxg"
                __cb.Write("CompletionPart(nameof(Finish_");
                #line hidden
                #line (32,106)-(32,111) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (32,112)-(32,115) 29 "SymbolGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("            ");
            #line (34,13)-(34,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (34,19)-(34,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,20)-(34,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (34,26)-(34,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,27)-(34,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (34,35)-(34,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,36)-(34,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (34,50)-(34,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,51)-(34,66) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attribute");
            #line hidden
            #line (34,66)-(34,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,67)-(34,68) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,68)-(34,69) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,69)-(34,72) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (34,72)-(34,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,73)-(34,113) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Start_Attribute));");
            #line hidden
            __cb.AppendLine();
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
            #line (35,36)-(35,50) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart");
            #line hidden
            #line (35,50)-(35,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,51)-(35,67) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attribute");
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
            #line (35,70)-(35,73) 25 "SymbolGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (35,73)-(35,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,74)-(35,115) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionPart(nameof(Finish_Attribute));");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (37,13)-(37,19) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (37,19)-(37,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,20)-(37,26) 25 "SymbolGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (37,26)-(37,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,27)-(37,35) 25 "SymbolGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (37,35)-(37,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,36)-(37,51) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (37,51)-(37,52) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,52)-(37,67) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph");
            #line hidden
            #line (37,67)-(37,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (37,68)-(37,69) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (37,69)-(37,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                ");
            #line (38,17)-(38,49) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletionGraph.CreateFromParts(");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("                    ");
            #line (39,21)-(39,37) 25 "SymbolGenerator.mxg"
            __cb.Write("Start_Attribute,");
            #line hidden
            #line (39,37)-(39,38) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (39,38)-(39,54) 25 "SymbolGenerator.mxg"
            __cb.Write("Finish_Attribute");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first10 = true;
            #line (40,22)-(40,65) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetAllPhases(symbol))
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                __cb.Push("                    ");
                #line (41,25)-(41,26) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (41,26)-(41,27) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (41,27)-(41,33) 29 "SymbolGenerator.mxg"
                __cb.Write("Start_");
                #line hidden
                #line (41,34)-(41,39) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                #line (41,40)-(41,41) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (41,41)-(41,42) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (41,42)-(41,49) 29 "SymbolGenerator.mxg"
                __cb.Write("Finish_");
                #line hidden
                #line (41,50)-(41,55) 28 "SymbolGenerator.mxg"
                __cb.Write(phase);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first10) __cb.AppendLine();
            __cb.Push("                ");
            #line (43,17)-(43,19) 25 "SymbolGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (44,9)-(44,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (45,5)-(45,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (46,1)-(46,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (49,9)-(49,37) 22 "SymbolGenerator.mxg"
        public string GenerateBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first11 = true;
            #line (50,6)-(50,38) 13 "SymbolGenerator.mxg"
            if (symbol.BaseTypes.Count == 0)
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                __cb.Push("");
                #line (51,10)-(51,42) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateSingleBase(symbol, null));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (52,6)-(52,43) 13 "SymbolGenerator.mxg"
            else if (symbol.BaseTypes.Count == 1)
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                __cb.Push("");
                #line (53,10)-(53,57) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateSingleBase(symbol, symbol.BaseTypes[0]));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (54,6)-(54,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                __cb.Push("");
                #line (55,10)-(55,35) 28 "SymbolGenerator.mxg"
                __cb.Write(GenerateMultiBase(symbol));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first11) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (59,9)-(59,63) 22 "SymbolGenerator.mxg"
        public string GenerateSingleBase(Symbol symbol, Symbol? baseSymbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (60,1)-(60,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (60,10)-(60,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,12)-(60,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (60,33)-(60,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (61,1)-(61,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
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
            #line (62,11)-(62,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (62,20)-(62,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,21)-(62,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (62,22)-(62,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,23)-(62,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
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
            #line (63,11)-(63,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (63,19)-(63,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,20)-(63,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (63,21)-(63,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,22)-(63,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
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
            #line (64,11)-(64,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__AttributeSymbol");
            #line hidden
            #line (64,28)-(64,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,29)-(64,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (64,30)-(64,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,31)-(64,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol;");
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
            #line (65,11)-(65,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol");
            #line hidden
            #line (65,27)-(65,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,28)-(65,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (65,29)-(65,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,30)-(65,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.AssemblySymbol;");
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
            #line (66,11)-(66,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol");
            #line hidden
            #line (66,25)-(66,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,26)-(66,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (66,27)-(66,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,28)-(66,79) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModuleSymbol;");
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
            #line (67,11)-(67,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol");
            #line hidden
            #line (67,30)-(67,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,31)-(67,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,32)-(67,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,33)-(67,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.DeclarationSymbol;");
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
            __cb.Write("__NamespaceSymbol");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.NamespaceSymbol;");
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
            #line (69,11)-(69,23) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol");
            #line hidden
            #line (69,23)-(69,24) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,24)-(69,25) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (69,25)-(69,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,26)-(69,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.TypeSymbol;");
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
            #line (70,11)-(70,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbolFactory");
            #line hidden
            #line (70,27)-(70,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,28)-(70,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,29)-(70,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,30)-(70,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ISymbolFactory;");
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
            #line (71,11)-(71,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (71,27)-(71,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,28)-(71,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (71,29)-(71,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,30)-(71,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.LexicalSortKey;");
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
            #line (72,11)-(72,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (72,25)-(72,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,26)-(72,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (72,27)-(72,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,28)-(72,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
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
            #line (73,11)-(73,18) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (73,18)-(73,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,19)-(73,20) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,20)-(73,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,21)-(73,53) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
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
            #line (74,11)-(74,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (74,28)-(74,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,29)-(74,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,30)-(74,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,31)-(74,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (75,11)-(75,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (75,26)-(75,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,27)-(75,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (75,28)-(75,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,29)-(75,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            #line (76,11)-(76,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (76,28)-(76,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,29)-(76,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,30)-(76,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,31)-(76,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (77,11)-(77,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (77,27)-(77,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,28)-(77,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (77,29)-(77,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,30)-(77,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (78,11)-(78,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (78,30)-(78,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,31)-(78,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (78,32)-(78,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,33)-(78,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (79,11)-(79,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (79,26)-(79,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,27)-(79,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (79,28)-(79,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,29)-(79,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (80,11)-(80,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (80,24)-(80,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,25)-(80,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (80,26)-(80,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,27)-(80,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            #line (81,11)-(81,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (81,27)-(81,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,28)-(81,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (81,29)-(81,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,30)-(81,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            #line (82,11)-(82,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (82,30)-(82,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,31)-(82,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (82,32)-(82,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,33)-(82,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (83,5)-(83,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (83,10)-(83,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,11)-(83,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (83,36)-(83,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,37)-(83,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (83,38)-(83,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,39)-(83,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (84,5)-(84,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (84,10)-(84,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,11)-(84,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (84,24)-(84,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,25)-(84,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (84,26)-(84,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,27)-(84,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (85,5)-(85,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (85,10)-(85,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,11)-(85,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (85,38)-(85,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,39)-(85,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (85,40)-(85,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,41)-(85,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (87,5)-(87,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (87,11)-(87,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,12)-(87,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (87,19)-(87,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,20)-(87,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (87,25)-(87,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,27)-(87,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (87,55)-(87,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,56)-(87,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (87,57)-(87,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first12 = true;
            #line (87,59)-(87,82) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                #line (87,83)-(87,131) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst");
                #line hidden
            }
            #line (87,132)-(87,136) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                #line (87,138)-(87,169) 28 "SymbolGenerator.mxg"
                __cb.Write(GetInstName(symbol, baseSymbol));
                #line hidden
            }
            #line (87,178)-(87,179) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (87,179)-(87,180) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (87,181)-(87,208) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (88,5)-(88,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first13 = true;
            #line (89,10)-(89,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                var __first14 = true;
                #line (90,14)-(90,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("        ");
                    #line (91,17)-(91,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (91,24)-(91,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,25)-(91,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (91,31)-(91,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,33)-(91,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (91,60)-(91,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,62)-(91,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (91,81)-(91,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,82)-(91,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (91,83)-(91,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,84)-(91,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (91,87)-(91,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (91,89)-(91,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (91,116)-(91,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (92,14)-(92,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("        ");
                    #line (93,17)-(93,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (93,24)-(93,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (93,26)-(93,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (93,53)-(93,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (93,55)-(93,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (93,74)-(93,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first14) __cb.AppendLine();
            }
            if (!__first13) __cb.AppendLine();
            var __first15 = true;
            #line (96,10)-(96,77) 13 "SymbolGenerator.mxg"
            foreach (var op in GetOperations(symbol).Where(o => o.CacheResult))
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                __cb.Push("        ");
                #line (97,13)-(97,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (97,20)-(97,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (97,21)-(97,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (97,27)-(97,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (97,29)-(97,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (97,54)-(97,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (97,56)-(97,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (97,73)-(97,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (97,74)-(97,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (97,75)-(97,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (97,76)-(97,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (97,79)-(97,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (97,81)-(97,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (97,106)-(97,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first15) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (100,9)-(100,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (100,15)-(100,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,17)-(100,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (100,45)-(100,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (100,54)-(100,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,55)-(100,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (100,65)-(100,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,66)-(100,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (100,85)-(100,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,86)-(100,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (100,98)-(100,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,99)-(100,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (100,113)-(100,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,114)-(100,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (100,126)-(100,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (101,13)-(101,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (101,14)-(101,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,15)-(101,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (101,30)-(101,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,31)-(101,43) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (101,43)-(101,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,44)-(101,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (102,9)-(102,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (103,9)-(103,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (105,9)-(105,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (105,15)-(105,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,17)-(105,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (105,45)-(105,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (105,54)-(105,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,55)-(105,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (105,65)-(105,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,66)-(105,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (105,80)-(105,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,81)-(105,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (105,93)-(105,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (106,13)-(106,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (106,14)-(106,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,15)-(106,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (106,30)-(106,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,31)-(106,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (107,9)-(107,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (108,9)-(108,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (110,9)-(110,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (110,15)-(110,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,17)-(110,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (110,45)-(110,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (110,54)-(110,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,55)-(110,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (110,65)-(110,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,66)-(110,73) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (110,73)-(110,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,74)-(110,80) 25 "SymbolGenerator.mxg"
            __cb.Write("model)");
            #line hidden
            #line (110,80)-(110,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (111,13)-(111,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (111,14)-(111,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,15)-(111,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (111,30)-(111,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,31)-(111,37) 25 "SymbolGenerator.mxg"
            __cb.Write("model)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (112,9)-(112,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (113,9)-(113,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (115,9)-(115,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (115,15)-(115,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,17)-(115,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (115,45)-(115,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (115,54)-(115,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,55)-(115,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (115,65)-(115,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,66)-(115,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (115,75)-(115,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,76)-(115,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (115,89)-(115,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (116,13)-(116,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (116,14)-(116,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (116,15)-(116,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (116,30)-(116,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (116,31)-(116,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (117,9)-(117,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (118,9)-(118,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (120,9)-(120,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (120,15)-(120,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,17)-(120,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (120,45)-(120,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (120,54)-(120,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,55)-(120,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (120,65)-(120,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,66)-(120,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (120,83)-(120,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,84)-(120,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (120,94)-(120,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (121,13)-(121,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (121,14)-(121,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,15)-(121,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (121,30)-(121,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,31)-(121,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (122,9)-(122,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
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
            #line (125,66)-(125,79) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (125,79)-(125,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,80)-(125,92) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation)");
            #line hidden
            #line (125,92)-(125,93) 25 "SymbolGenerator.mxg"
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
            #line (126,31)-(126,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (127,9)-(127,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
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
            #line (130,66)-(130,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (130,80)-(130,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,81)-(130,92) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation");
            #line hidden
            #line (130,92)-(130,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,93)-(130,94) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,94)-(130,95) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,95)-(130,100) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (130,100)-(130,101) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,101)-(130,121) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration?");
            #line hidden
            #line (130,121)-(130,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,122)-(130,133) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration");
            #line hidden
            #line (130,133)-(130,134) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,134)-(130,135) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,135)-(130,136) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,136)-(130,141) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (130,141)-(130,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,142)-(130,150) 25 "SymbolGenerator.mxg"
            __cb.Write("__Model?");
            #line hidden
            #line (130,150)-(130,151) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,151)-(130,156) 25 "SymbolGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (130,156)-(130,157) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,157)-(130,158) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,158)-(130,159) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,159)-(130,164) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (130,164)-(130,165) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,165)-(130,180) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (130,180)-(130,181) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,181)-(130,192) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (130,192)-(130,193) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,193)-(130,194) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,194)-(130,195) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,195)-(130,200) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (130,200)-(130,201) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,201)-(130,210) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (130,210)-(130,211) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,211)-(130,223) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol");
            #line hidden
            #line (130,223)-(130,224) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,224)-(130,225) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,225)-(130,226) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,226)-(130,231) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (130,231)-(130,232) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,232)-(130,239) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (130,239)-(130,240) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,240)-(130,244) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (130,244)-(130,245) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,245)-(130,246) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,246)-(130,247) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,247)-(130,255) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (130,255)-(130,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,256)-(130,263) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (130,263)-(130,264) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,264)-(130,276) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (130,276)-(130,277) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,277)-(130,278) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,278)-(130,279) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,279)-(130,287) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (130,287)-(130,288) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,288)-(130,315) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (130,315)-(130,316) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,316)-(130,326) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (130,326)-(130,327) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,327)-(130,328) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,328)-(130,329) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,329)-(130,336) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first16 = true;
            #line (130,337)-(130,405) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                #line (130,406)-(130,407) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (130,407)-(130,408) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,409)-(130,439) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (130,440)-(130,441) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,442)-(130,460) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (130,461)-(130,462) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,462)-(130,463) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (130,463)-(130,464) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,465)-(130,499) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (130,513)-(130,514) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (130,514)-(130,515) 25 "SymbolGenerator.mxg"
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
            #line (131,31)-(131,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (131,43)-(131,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,44)-(131,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (131,56)-(131,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,57)-(131,63) 25 "SymbolGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (131,63)-(131,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,64)-(131,76) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (131,76)-(131,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,77)-(131,90) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (131,90)-(131,91) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,91)-(131,96) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (131,96)-(131,97) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,97)-(131,110) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (131,110)-(131,111) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,111)-(131,121) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first17 = true;
            #line (131,122)-(131,194) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                #line (131,195)-(131,196) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (131,196)-(131,197) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (131,198)-(131,216) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (131,217)-(131,218) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (131,218)-(131,219) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (131,220)-(131,238) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (131,252)-(131,253) 25 "SymbolGenerator.mxg"
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
            var __first18 = true;
            #line (133,14)-(133,78) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                __cb.Push("            ");
                #line (134,18)-(134,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first19 = true;
                #line (135,18)-(135,35) 17 "SymbolGenerator.mxg"
                if (!prop.IsInit)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("            ");
                    #line (136,21)-(136,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (136,39)-(136,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (136,67)-(136,91) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (136,92)-(136,121) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (136,122)-(136,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first19) __cb.AppendLine();
            }
            if (!__first18) __cb.AppendLine();
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
            #line (141,25)-(141,42) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol?");
            #line hidden
            #line (141,42)-(141,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,43)-(141,61) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingAssembly");
            #line hidden
            #line (141,61)-(141,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,62)-(141,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (141,64)-(141,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,66)-(141,124) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__AssemblySymbol", "ContainingAssembly"));
            #line hidden
            #line (141,125)-(141,126) 25 "SymbolGenerator.mxg"
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
            #line (143,25)-(143,39) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (143,39)-(143,40) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,40)-(143,60) 25 "SymbolGenerator.mxg"
            __cb.Write("DeclaringCompilation");
            #line hidden
            #line (143,60)-(143,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,61)-(143,63) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (143,63)-(143,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (143,65)-(143,122) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__Compilation", "DeclaringCompilation"));
            #line hidden
            #line (143,123)-(143,124) 25 "SymbolGenerator.mxg"
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
            #line (145,25)-(145,40) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol?");
            #line hidden
            #line (145,40)-(145,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,41)-(145,57) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingModule");
            #line hidden
            #line (145,57)-(145,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,58)-(145,60) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (145,60)-(145,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,62)-(145,116) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__ModuleSymbol", "ContainingModule"));
            #line hidden
            #line (145,117)-(145,118) 25 "SymbolGenerator.mxg"
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
            #line (147,25)-(147,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol?");
            #line hidden
            #line (147,45)-(147,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,46)-(147,67) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingDeclaration");
            #line hidden
            #line (147,67)-(147,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,68)-(147,70) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (147,70)-(147,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,72)-(147,136) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__DeclarationSymbol", "ContainingDeclaration"));
            #line hidden
            #line (147,137)-(147,138) 25 "SymbolGenerator.mxg"
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
            #line (149,25)-(149,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol?");
            #line hidden
            #line (149,38)-(149,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,39)-(149,53) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingType");
            #line hidden
            #line (149,53)-(149,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,54)-(149,56) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (149,56)-(149,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,58)-(149,108) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__TypeSymbol", "ContainingType"));
            #line hidden
            #line (149,109)-(149,110) 25 "SymbolGenerator.mxg"
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
            #line (151,25)-(151,43) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol?");
            #line hidden
            #line (151,43)-(151,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,44)-(151,63) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingNamespace");
            #line hidden
            #line (151,63)-(151,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,64)-(151,66) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (151,66)-(151,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (151,68)-(151,128) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__NamespaceSymbol", "ContainingNamespace"));
            #line hidden
            #line (151,129)-(151,130) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first20 = true;
            #line (153,10)-(153,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                var __first21 = true;
                #line (154,14)-(154,30) 17 "SymbolGenerator.mxg"
                if (prop.IsInit)
                #line hidden
                
                {
                    if (__first21)
                    {
                        __first21 = false;
                    }
                    __cb.Push("        ");
                    #line (155,17)-(155,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (155,23)-(155,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (155,24)-(155,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("virtual");
                    #line hidden
                    #line (155,31)-(155,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (155,33)-(155,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (155,64)-(155,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (155,66)-(155,75) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (156,17)-(156,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (157,21)-(157,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (157,24)-(157,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (157,25)-(157,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (157,27)-(157,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (157,29)-(157,47) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (157,48)-(157,49) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (158,21)-(158,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (158,30)-(158,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,31)-(158,34) 33 "SymbolGenerator.mxg"
                    __cb.Write("set");
                    #line hidden
                    #line (158,34)-(158,35) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,35)-(158,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (158,37)-(158,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,39)-(158,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (158,58)-(158,59) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,59)-(158,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (158,60)-(158,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (158,61)-(158,67) 33 "SymbolGenerator.mxg"
                    __cb.Write("value;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (159,17)-(159,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (160,14)-(160,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first21)
                    {
                        __first21 = false;
                    }
                    __cb.Push("        ");
                    #line (161,17)-(161,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (161,23)-(161,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,25)-(161,55) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (161,56)-(161,57) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,58)-(161,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (162,17)-(162,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (163,21)-(163,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (164,21)-(164,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (165,25)-(165,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(");
                    #line hidden
                    #line (165,45)-(165,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (165,73)-(165,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (165,98)-(165,127) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (165,128)-(165,129) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (165,129)-(165,130) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,130)-(165,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (165,135)-(165,136) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,136)-(165,145) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first22 = true;
                    #line (166,26)-(166,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first22)
                        {
                            __first22 = false;
                        }
                        __cb.Push("                ");
                        #line (167,29)-(167,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (167,31)-(167,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,32)-(167,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (167,34)-(167,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (167,53)-(167,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (167,71)-(167,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,72)-(167,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (167,75)-(167,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,76)-(167,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (167,79)-(167,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,80)-(167,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (167,88)-(167,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,89)-(167,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (167,95)-(167,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,96)-(167,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (167,98)-(167,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (167,129)-(167,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (168,29)-(168,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (168,33)-(168,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,34)-(168,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (168,40)-(168,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,42)-(168,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (168,72)-(168,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (169,26)-(169,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first22)
                        {
                            __first22 = false;
                        }
                        __cb.Push("                ");
                        #line (170,29)-(170,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (170,35)-(170,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (170,37)-(170,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (170,56)-(170,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first22) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (172,21)-(172,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (173,17)-(173,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first21) __cb.AppendLine();
            }
            if (!__first20) __cb.AppendLine();
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
            var __first23 = true;
            #line (193,10)-(193,51) 13 "SymbolGenerator.mxg"
            foreach (var op in GetOperations(symbol))
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (194,14)-(194,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (195,14)-(195,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (196,14)-(196,84) 17 "SymbolGenerator.mxg"
                var virtOvrd = symbol.Operations.Contains(op) ? "virtual" : "override";
                #line hidden
                
                #line (197,14)-(197,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (199,13)-(199,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (199,19)-(199,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,21)-(199,29) 28 "SymbolGenerator.mxg"
                __cb.Write(virtOvrd);
                #line hidden
                #line (199,30)-(199,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,32)-(199,42) 28 "SymbolGenerator.mxg"
                __cb.Write(returnType);
                #line hidden
                #line (199,43)-(199,44) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,45)-(199,52) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (199,53)-(199,54) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first24 = true;
                foreach (var __item25 in 
                #line (199,55)-(199,125) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
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
                        #line (199,135)-(199,139) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item25);
                }
                #line (199,140)-(199,141) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (200,13)-(200,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first26 = true;
                #line (201,18)-(201,80) 17 "SymbolGenerator.mxg"
                if (op.ReturnType.Type.SpecialType == SpecialType.System_Void)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("            ");
                    #line (202,22)-(202,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, call));
                    #line hidden
                    #line (202,45)-(202,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (203,18)-(203,42) 17 "SymbolGenerator.mxg"
                else if (op.CacheResult)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    var __first27 = true;
                    #line (204,22)-(204,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        __cb.Push("            ");
                        #line (205,25)-(205,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (205,27)-(205,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (205,28)-(205,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (205,32)-(205,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (205,50)-(205,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (205,52)-(205,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (205,53)-(205,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (205,59)-(205,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (205,61)-(205,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (205,100)-(205,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first27) __cb.AppendLine();
                    #line (207,22)-(207,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first28 = true;
                    #line (208,22)-(208,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (209,25)-(209,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (209,31)-(209,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,32)-(209,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (209,34)-(209,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (209,45)-(209,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (209,47)-(209,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (209,57)-(209,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (209,72)-(209,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,73)-(209,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (209,79)-(209,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,80)-(209,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (209,82)-(209,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (209,84)-(209,118) 36 "SymbolGenerator.mxg"
                        __cb.Write(CallImpl(symbol, returnType, call));
                        #line hidden
                        #line (209,119)-(209,121) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (210,22)-(210,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("            ");
                        #line (211,25)-(211,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (211,28)-(211,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,29)-(211,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (211,47)-(211,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,48)-(211,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (211,49)-(211,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,51)-(211,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (211,61)-(211,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (211,76)-(211,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,77)-(211,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (211,83)-(211,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,84)-(211,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (211,86)-(211,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,87)-(211,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (211,90)-(211,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,91)-(211,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (211,151)-(211,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (211,179)-(211,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (211,180)-(211,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (211,182)-(211,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (211,193)-(211,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (212,25)-(212,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (212,31)-(212,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,32)-(212,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (212,61)-(212,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (212,71)-(212,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (212,72)-(212,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,73)-(212,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
                        #line hidden
                        #line (212,79)-(212,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,80)-(212,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (212,82)-(212,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (212,84)-(212,118) 36 "SymbolGenerator.mxg"
                        __cb.Write(CallImpl(symbol, returnType, call));
                        #line hidden
                        #line (212,119)-(212,121) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first28) __cb.AppendLine();
                }
                #line (214,18)-(214,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("            ");
                    #line (215,21)-(215,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (215,27)-(215,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (215,29)-(215,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, call));
                    #line hidden
                    #line (215,64)-(215,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
                __cb.Push("        ");
                #line (217,13)-(217,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (220,9)-(220,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (220,18)-(220,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,19)-(220,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (220,27)-(220,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,28)-(220,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (220,32)-(220,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,33)-(220,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (220,54)-(220,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,55)-(220,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (220,71)-(220,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,72)-(220,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (220,87)-(220,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,88)-(220,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (220,105)-(220,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,106)-(220,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (220,118)-(220,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,119)-(220,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (220,138)-(220,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,139)-(220,157) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (221,9)-(221,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (222,14)-(222,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            #line (223,14)-(223,47) 13 "SymbolGenerator.mxg"
            var phases = GetAllPhases(symbol);
            #line hidden
            
            #line (224,14)-(224,55) 13 "SymbolGenerator.mxg"
            var basePhases = GetAllPhases(baseSymbol);
            #line hidden
            
            var __first29 = true;
            #line (225,14)-(225,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first29)
                {
                    __first29 = false;
                }
                var __first30 = true;
                #line (226,18)-(226,50) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first30)
                    {
                        __first30 = false;
                    }
                    #line (227,22)-(227,41) 21 "SymbolGenerator.mxg"
                    hasNewPhase = true;
                    #line hidden
                    
                    #line (228,22)-(228,67) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    __cb.Push("            ");
                    #line (229,21)-(229,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (229,23)-(229,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (229,24)-(229,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("(incompletePart");
                    #line hidden
                    #line (229,39)-(229,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (229,40)-(229,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (229,42)-(229,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (229,44)-(229,71) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (229,72)-(229,95) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (229,96)-(229,101) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (229,102)-(229,103) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (229,103)-(229,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("||");
                    #line hidden
                    #line (229,105)-(229,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (229,106)-(229,120) 33 "SymbolGenerator.mxg"
                    __cb.Write("incompletePart");
                    #line hidden
                    #line (229,120)-(229,121) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (229,121)-(229,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (229,123)-(229,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (229,125)-(229,152) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (229,153)-(229,177) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (229,178)-(229,183) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (229,184)-(229,185) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (230,21)-(230,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (231,25)-(231,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (231,27)-(231,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (231,28)-(231,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("(NotePartComplete(");
                    #line hidden
                    #line (231,47)-(231,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (231,75)-(231,98) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (231,99)-(231,104) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (231,105)-(231,107) 33 "SymbolGenerator.mxg"
                    __cb.Write("))");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (232,25)-(232,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (233,29)-(233,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (233,32)-(233,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,33)-(233,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (233,44)-(233,45) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,45)-(233,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (233,46)-(233,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,47)-(233,77) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first31 = true;
                    #line (234,30)-(234,52) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        __cb.Push("                    ");
                        #line (235,33)-(235,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (235,36)-(235,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (235,37)-(235,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (235,43)-(235,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (235,44)-(235,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (235,45)-(235,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (235,46)-(235,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (235,56)-(235,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (235,62)-(235,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (235,75)-(235,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (235,76)-(235,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first32 = true;
                        #line (236,34)-(236,61) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props)
                        #line hidden
                        
                        {
                            if (__first32)
                            {
                                __first32 = false;
                            }
                            __cb.Push("                    ");
                            #line (237,38)-(237,87) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first32) __cb.AppendLine();
                    }
                    #line (239,30)-(239,57) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        __cb.Push("                    ");
                        #line (240,33)-(240,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (240,36)-(240,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (240,37)-(240,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (240,43)-(240,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (240,44)-(240,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (240,45)-(240,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (240,46)-(240,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (240,56)-(240,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (240,62)-(240,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (240,75)-(240,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (240,76)-(240,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                    ");
                        #line (241,34)-(241,76) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, props[0], "result"));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (242,30)-(242,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        __cb.Push("                    ");
                        #line (243,33)-(243,42) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (243,43)-(243,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (243,49)-(243,62) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (243,62)-(243,63) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (243,63)-(243,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first31) __cb.AppendLine();
                    __cb.Push("                    ");
                    #line (245,29)-(245,63) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (246,29)-(246,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (247,29)-(247,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (247,47)-(247,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (247,75)-(247,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (247,100)-(247,105) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (247,106)-(247,108) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (248,25)-(248,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (249,25)-(249,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (249,31)-(249,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (249,32)-(249,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (250,21)-(250,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (251,21)-(251,25) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (251,25)-(251,26) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.SkipLineEnd = true;
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first30) __cb.AppendLine();
            }
            if (!__first29) __cb.AppendLine();
            var __first33 = true;
            #line (254,14)-(254,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (255,17)-(255,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (256,21)-(256,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (256,27)-(256,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,28)-(256,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (256,54)-(256,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,55)-(256,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (256,70)-(256,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,71)-(256,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (256,83)-(256,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,84)-(256,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (257,17)-(257,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (258,14)-(258,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("            ");
                #line (259,17)-(259,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (259,23)-(259,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (259,24)-(259,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (259,50)-(259,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (259,51)-(259,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (259,66)-(259,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (259,67)-(259,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (259,79)-(259,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (259,80)-(259,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            __cb.Push("        ");
            #line (261,9)-(261,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (264,9)-(264,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (264,18)-(264,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,19)-(264,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (264,27)-(264,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,28)-(264,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (264,32)-(264,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,33)-(264,72) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Initialize(__DiagnosticBag");
            #line hidden
            #line (264,72)-(264,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,73)-(264,85) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (264,85)-(264,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,86)-(264,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (264,105)-(264,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,106)-(264,124) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (265,9)-(265,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (266,14)-(266,89) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Initialize(diagnostics, cancellationToken)"));
            #line hidden
            #line (266,90)-(266,91) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (267,9)-(267,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (269,9)-(269,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (269,18)-(269,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,19)-(269,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (269,27)-(269,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,28)-(269,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (269,35)-(269,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,36)-(269,65) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Name(__DiagnosticBag");
            #line hidden
            #line (269,65)-(269,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,66)-(269,78) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (269,78)-(269,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,79)-(269,98) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (269,98)-(269,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,99)-(269,117) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (270,9)-(270,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (271,13)-(271,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (271,19)-(271,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,21)-(271,97) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_Name(diagnostics, cancellationToken)"));
            #line hidden
            #line (271,98)-(271,99) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (272,9)-(272,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (274,9)-(274,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (274,18)-(274,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,19)-(274,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (274,27)-(274,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,28)-(274,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (274,35)-(274,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,36)-(274,73) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_MetadataName(__DiagnosticBag");
            #line hidden
            #line (274,73)-(274,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,74)-(274,86) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (274,86)-(274,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,87)-(274,106) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (274,106)-(274,107) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,107)-(274,125) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (275,9)-(275,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (276,13)-(276,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (276,19)-(276,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,21)-(276,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_MetadataName(diagnostics, cancellationToken)"));
            #line hidden
            #line (276,106)-(276,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (277,9)-(277,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (279,9)-(279,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (279,18)-(279,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,19)-(279,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (279,27)-(279,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,28)-(279,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__Symbol>");
            #line hidden
            #line (279,89)-(279,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,90)-(279,141) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_CreateContainedSymbols(__DiagnosticBag");
            #line hidden
            #line (279,141)-(279,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,142)-(279,154) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (279,154)-(279,155) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,155)-(279,174) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (279,174)-(279,175) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (279,175)-(279,193) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (280,9)-(280,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (281,13)-(281,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (281,19)-(281,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (281,21)-(281,173) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__Symbol>", "CompletePart_CreateContainedSymbols(diagnostics, cancellationToken)"));
            #line hidden
            #line (281,174)-(281,175) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (282,9)-(282,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (284,9)-(284,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (284,18)-(284,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,19)-(284,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (284,27)-(284,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,28)-(284,98) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>");
            #line hidden
            #line (284,98)-(284,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,99)-(284,134) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Attributes(__DiagnosticBag");
            #line hidden
            #line (284,134)-(284,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,135)-(284,147) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (284,147)-(284,148) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,148)-(284,167) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (284,167)-(284,168) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (284,168)-(284,186) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (285,9)-(285,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (286,13)-(286,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (286,19)-(286,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (286,21)-(286,166) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>", "Complete_Attributes(diagnostics, cancellationToken)"));
            #line hidden
            #line (286,167)-(286,168) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (287,9)-(287,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (289,9)-(289,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (289,18)-(289,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,19)-(289,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (289,27)-(289,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,28)-(289,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (289,32)-(289,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,33)-(289,88) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_ComputeNonSymbolProperties(__DiagnosticBag");
            #line hidden
            #line (289,88)-(289,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,89)-(289,101) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (289,101)-(289,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,102)-(289,121) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (289,121)-(289,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,122)-(289,140) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (290,9)-(290,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (291,14)-(291,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken)"));
            #line hidden
            #line (291,106)-(291,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (292,9)-(292,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (294,9)-(294,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (294,18)-(294,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,19)-(294,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (294,27)-(294,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,28)-(294,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (294,32)-(294,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,33)-(294,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Finalize(__DiagnosticBag");
            #line hidden
            #line (294,70)-(294,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,71)-(294,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (294,83)-(294,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,84)-(294,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (294,103)-(294,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,104)-(294,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (295,9)-(295,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (296,14)-(296,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Finalize(diagnostics, cancellationToken)"));
            #line hidden
            #line (296,88)-(296,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (297,9)-(297,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (299,9)-(299,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (299,18)-(299,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,19)-(299,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (299,27)-(299,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,28)-(299,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (299,32)-(299,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,33)-(299,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Validate(__DiagnosticBag");
            #line hidden
            #line (299,70)-(299,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,71)-(299,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (299,83)-(299,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,84)-(299,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (299,103)-(299,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,104)-(299,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (300,9)-(300,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (301,14)-(301,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Validate(diagnostics, cancellationToken)"));
            #line hidden
            #line (301,88)-(301,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (302,9)-(302,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first34 = true;
            #line (304,10)-(304,53) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetAllPhases(symbol))
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (306,14)-(306,80) 17 "SymbolGenerator.mxg"
                var virtOvrd = basePhases.Contains(phase) ? "override" : "virtual";
                #line hidden
                
                #line (307,14)-(307,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first35 = true;
                #line (308,14)-(308,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (309,18)-(309,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (310,17)-(310,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (310,26)-(310,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (310,28)-(310,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (310,37)-(310,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (310,39)-(310,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (310,50)-(310,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (310,51)-(310,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (310,61)-(310,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (310,67)-(310,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (310,83)-(310,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (310,84)-(310,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (310,96)-(310,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (310,97)-(310,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (310,116)-(310,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (310,117)-(310,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (311,17)-(311,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (312,21)-(312,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (312,27)-(312,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (312,29)-(312,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (312,112)-(312,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (313,17)-(313,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (314,14)-(314,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (315,18)-(315,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (316,18)-(316,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (317,17)-(317,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (317,26)-(317,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (317,28)-(317,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (317,37)-(317,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (317,39)-(317,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (317,50)-(317,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (317,51)-(317,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (317,61)-(317,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (317,67)-(317,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (317,83)-(317,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (317,84)-(317,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (317,96)-(317,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (317,97)-(317,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (317,116)-(317,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (317,117)-(317,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (318,17)-(318,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (319,21)-(319,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (319,27)-(319,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (319,29)-(319,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (319,112)-(319,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (320,17)-(320,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (321,14)-(321,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.Push("        ");
                    #line (322,17)-(322,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (322,26)-(322,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,28)-(322,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (322,37)-(322,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,38)-(322,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (322,42)-(322,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,43)-(322,52) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (322,53)-(322,58) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (322,59)-(322,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (322,75)-(322,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,76)-(322,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (322,88)-(322,89) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,89)-(322,108) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (322,108)-(322,109) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (322,109)-(322,127) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (323,17)-(323,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (324,22)-(324,92) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (324,93)-(324,94) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (325,17)-(325,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("    ");
            #line (328,5)-(328,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (330,5)-(330,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (330,11)-(330,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,12)-(330,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (330,20)-(330,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,21)-(330,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (330,26)-(330,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,28)-(330,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (330,56)-(330,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,57)-(330,58) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (330,58)-(330,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first36 = true;
            #line (330,60)-(330,83) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                #line (330,84)-(330,132) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl");
                #line hidden
            }
            #line (330,133)-(330,137) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                #line (330,139)-(330,170) 28 "SymbolGenerator.mxg"
                __cb.Write(GetImplName(symbol, baseSymbol));
                #line hidden
            }
            #line (330,179)-(330,180) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (330,180)-(330,181) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,182)-(330,209) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (331,5)-(331,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first37 = true;
            #line (332,10)-(332,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("        ");
                #line (333,13)-(333,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (333,19)-(333,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (333,21)-(333,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (333,52)-(333,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (333,54)-(333,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (333,64)-(333,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (333,65)-(333,67) 29 "SymbolGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (333,67)-(333,68) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (333,68)-(333,70) 29 "SymbolGenerator.mxg"
                __cb.Write("((");
                #line hidden
                #line (333,71)-(333,98) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (333,99)-(333,111) 29 "SymbolGenerator.mxg"
                __cb.Write(")__Wrapped).");
                #line hidden
                #line (333,112)-(333,121) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (333,122)-(333,123) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (336,10)-(336,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => !o.IsPhase))
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("        ");
                #line (337,13)-(337,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (337,19)-(337,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (337,20)-(337,28) 29 "SymbolGenerator.mxg"
                __cb.Write("abstract");
                #line hidden
                #line (337,28)-(337,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (337,30)-(337,64) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, op.ReturnType));
                #line hidden
                #line (337,65)-(337,66) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (337,67)-(337,74) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (337,75)-(337,76) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first39 = true;
                foreach (var __item40 in 
                #line (337,77)-(337,147) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                #line hidden
                )
                {
                    if (__first39)
                    {
                        __first39 = false;
                    }
                    else
                    {
                        __cb.Push("        ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (337,157)-(337,161) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item40);
                }
                #line (337,162)-(337,164) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first41 = true;
            #line (340,10)-(340,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                var __first42 = true;
                #line (341,14)-(341,46) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.WriteLine();
                    __cb.Pop();
                    #line (343,18)-(343,63) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    var __first43 = true;
                    #line (344,18)-(344,40) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first43)
                        {
                            __first43 = false;
                        }
                        #line (345,22)-(345,123) 25 "SymbolGenerator.mxg"
                        var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                        #line hidden
                        
                        var __first44 = true;
                        #line (346,22)-(346,62) 25 "SymbolGenerator.mxg"
                        if (props.Where(p => p.IsDerived).Any())
                        #line hidden
                        
                        {
                            if (__first44)
                            {
                                __first44 = false;
                            }
                            __cb.Push("        ");
                            #line (347,25)-(347,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (347,31)-(347,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (347,32)-(347,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (347,40)-(347,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (347,42)-(347,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (347,53)-(347,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (347,54)-(347,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (347,64)-(347,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (347,70)-(347,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (347,86)-(347,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (347,87)-(347,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (347,99)-(347,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (347,100)-(347,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (347,119)-(347,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (347,120)-(347,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (348,22)-(348,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first44)
                            {
                                __first44 = false;
                            }
                            __cb.Push("        ");
                            #line (349,25)-(349,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (349,31)-(349,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (349,32)-(349,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (349,39)-(349,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (349,41)-(349,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (349,52)-(349,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (349,53)-(349,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (349,63)-(349,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (349,69)-(349,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (349,85)-(349,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (349,86)-(349,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (349,98)-(349,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (349,99)-(349,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (349,118)-(349,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (349,119)-(349,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (350,25)-(350,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.SingleLineMode = true;
                            __cb.Push("            ");
                            #line (352,29)-(352,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (352,35)-(352,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (352,36)-(352,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            var __first45 = true;
                            #line (353,34)-(353,62) 29 "SymbolGenerator.mxg"
                            foreach (var prop in props) 
                            #line hidden
                            
                            {
                                if (__first45)
                                {
                                    __first45 = false;
                                }
                                else
                                {
                                    __cb.Push("                ");
                                    __cb.DontIgnoreLastLineEnd = true;
                                    #line (353,72)-(353,76) 48 "SymbolGenerator.mxg"
                                    __cb.Write(", ");
                                    #line hidden
                                    __cb.DontIgnoreLastLineEnd = false;
                                    __cb.Pop();
                                }
                                __cb.Push("                ");
                                #line (354,37)-(354,91) 45 "SymbolGenerator.mxg"
                                __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                                #line hidden
                                var __first46 = true;
                                #line (354,92)-(354,121) 33 "SymbolGenerator.mxg"
                                if (prop.Type.Dimensions > 0)
                                #line hidden
                                
                                {
                                    if (__first46)
                                    {
                                        __first46 = false;
                                    }
                                    #line (354,122)-(354,123) 49 "SymbolGenerator.mxg"
                                    __cb.Write("s");
                                    #line hidden
                                }
                                #line (354,131)-(354,132) 45 "SymbolGenerator.mxg"
                                __cb.Write("<");
                                #line hidden
                                #line (354,133)-(354,168) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetTypeName(symbol, prop.Type.Type));
                                #line hidden
                                #line (354,169)-(354,176) 45 "SymbolGenerator.mxg"
                                __cb.Write(">(this,");
                                #line hidden
                                #line (354,176)-(354,177) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (354,177)-(354,184) 45 "SymbolGenerator.mxg"
                                __cb.Write("nameof(");
                                #line hidden
                                #line (354,185)-(354,194) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (354,195)-(354,197) 45 "SymbolGenerator.mxg"
                                __cb.Write("),");
                                #line hidden
                                #line (354,197)-(354,198) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (354,198)-(354,210) 45 "SymbolGenerator.mxg"
                                __cb.Write("diagnostics,");
                                #line hidden
                                #line (354,210)-(354,211) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (354,211)-(354,230) 45 "SymbolGenerator.mxg"
                                __cb.Write("cancellationToken);");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first45) __cb.AppendLine();
                            __cb.Push("            ");
                            #line (356,29)-(356,31) 41 "SymbolGenerator.mxg"
                            __cb.Write(");");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.SingleLineMode = false;
                            __cb.AppendLine();
                            __cb.Push("        ");
                            #line (358,25)-(358,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first44) __cb.AppendLine();
                    }
                    #line (360,18)-(360,45) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first43)
                        {
                            __first43 = false;
                        }
                        #line (361,22)-(361,41) 25 "SymbolGenerator.mxg"
                        var prop = props[0];
                        #line hidden
                        
                        #line (362,22)-(362,69) 25 "SymbolGenerator.mxg"
                        var returnType = GetTypeName(symbol, prop.Type);
                        #line hidden
                        
                        var __first47 = true;
                        #line (363,22)-(363,41) 25 "SymbolGenerator.mxg"
                        if (prop.IsDerived)
                        #line hidden
                        
                        {
                            if (__first47)
                            {
                                __first47 = false;
                            }
                            __cb.Push("        ");
                            #line (364,25)-(364,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (364,31)-(364,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (364,32)-(364,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (364,40)-(364,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (364,42)-(364,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (364,53)-(364,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (364,54)-(364,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (364,64)-(364,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (364,70)-(364,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (364,86)-(364,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (364,87)-(364,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (364,99)-(364,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (364,100)-(364,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (364,119)-(364,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (364,120)-(364,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (365,22)-(365,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first47)
                            {
                                __first47 = false;
                            }
                            __cb.Push("        ");
                            #line (366,25)-(366,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (366,31)-(366,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (366,32)-(366,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (366,39)-(366,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (366,41)-(366,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (366,52)-(366,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (366,53)-(366,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (366,63)-(366,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (366,69)-(366,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (366,85)-(366,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (366,86)-(366,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (366,98)-(366,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (366,99)-(366,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (366,118)-(366,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (366,119)-(366,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (367,25)-(367,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (368,29)-(368,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (368,35)-(368,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (368,36)-(368,90) 41 "SymbolGenerator.mxg"
                            __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first48 = true;
                            #line (368,91)-(368,120) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first48)
                                {
                                    __first48 = false;
                                }
                                #line (368,121)-(368,122) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (368,130)-(368,131) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (368,132)-(368,167) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (368,168)-(368,175) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (368,175)-(368,176) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (368,176)-(368,183) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (368,184)-(368,193) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (368,194)-(368,196) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (368,196)-(368,197) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (368,197)-(368,209) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (368,209)-(368,210) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (368,210)-(368,229) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (369,25)-(369,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first47) __cb.AppendLine();
                    }
                    #line (371,18)-(371,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first43)
                        {
                            __first43 = false;
                        }
                        __cb.Push("        ");
                        #line (372,21)-(372,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (372,27)-(372,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (372,28)-(372,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (372,36)-(372,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (372,37)-(372,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("void");
                        #line hidden
                        #line (372,41)-(372,42) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (372,42)-(372,51) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (372,52)-(372,57) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (372,58)-(372,74) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (372,74)-(372,75) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (372,75)-(372,87) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (372,87)-(372,88) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (372,88)-(372,107) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (372,107)-(372,108) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (372,108)-(372,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first43) __cb.AppendLine();
                }
                if (!__first42) __cb.AppendLine();
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("    ");
            #line (376,5)-(376,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (377,1)-(377,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (380,9)-(380,42) 22 "SymbolGenerator.mxg"
        public string GenerateMultiBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (381,1)-(381,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (381,10)-(381,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,12)-(381,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (381,33)-(381,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (382,1)-(382,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (383,5)-(383,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (383,10)-(383,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,11)-(383,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (383,20)-(383,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,21)-(383,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (383,22)-(383,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,23)-(383,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (384,5)-(384,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (384,10)-(384,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,11)-(384,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (384,25)-(384,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,26)-(384,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (384,27)-(384,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,28)-(384,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (385,5)-(385,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (385,10)-(385,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,11)-(385,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (385,30)-(385,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,31)-(385,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (385,32)-(385,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,33)-(385,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (386,5)-(386,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (386,10)-(386,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,11)-(386,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (386,19)-(386,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,20)-(386,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (386,21)-(386,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,22)-(386,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (387,5)-(387,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (387,10)-(387,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,11)-(387,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (387,28)-(387,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,29)-(387,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (387,30)-(387,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,31)-(387,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (388,5)-(388,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (388,10)-(388,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,11)-(388,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (388,26)-(388,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,27)-(388,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (388,28)-(388,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,29)-(388,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (389,5)-(389,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (389,10)-(389,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,11)-(389,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (389,28)-(389,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,29)-(389,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (389,30)-(389,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,31)-(389,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (390,5)-(390,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (390,10)-(390,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (390,11)-(390,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (390,27)-(390,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (390,28)-(390,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (390,29)-(390,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (390,30)-(390,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (391,5)-(391,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (391,10)-(391,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,11)-(391,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (391,26)-(391,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,27)-(391,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (391,28)-(391,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,29)-(391,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (392,5)-(392,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (392,10)-(392,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,11)-(392,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (392,27)-(392,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,28)-(392,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (392,29)-(392,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,30)-(392,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (393,5)-(393,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (393,10)-(393,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,11)-(393,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (393,30)-(393,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,31)-(393,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (393,32)-(393,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,33)-(393,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (394,5)-(394,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (394,10)-(394,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,11)-(394,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (394,36)-(394,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,37)-(394,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (394,38)-(394,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,39)-(394,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (395,5)-(395,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (395,10)-(395,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,11)-(395,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (395,38)-(395,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,39)-(395,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (395,40)-(395,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,41)-(395,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (397,5)-(397,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (397,11)-(397,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,12)-(397,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (397,19)-(397,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,20)-(397,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (397,25)-(397,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,27)-(397,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (397,55)-(397,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,56)-(397,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (397,57)-(397,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,58)-(397,107) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst,");
            #line hidden
            #line (397,107)-(397,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,109)-(397,136) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (398,5)-(398,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first49 = true;
            #line (399,10)-(399,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                var __first50 = true;
                #line (400,14)-(400,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("        ");
                    #line (401,17)-(401,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (401,24)-(401,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (401,25)-(401,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (401,31)-(401,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (401,33)-(401,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (401,60)-(401,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (401,62)-(401,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (401,81)-(401,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (401,82)-(401,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (401,83)-(401,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (401,84)-(401,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (401,87)-(401,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (401,89)-(401,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (401,116)-(401,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (402,14)-(402,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("        ");
                    #line (403,17)-(403,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (403,24)-(403,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (403,26)-(403,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (403,53)-(403,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (403,55)-(403,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (403,74)-(403,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first50) __cb.AppendLine();
            }
            if (!__first49) __cb.AppendLine();
            __cb.Push("        ");
            #line (406,9)-(406,11) 25 "SymbolGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (406,11)-(406,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (406,12)-(406,16) 25 "SymbolGenerator.mxg"
            __cb.Write("TODO");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (407,5)-(407,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (408,1)-(408,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (411,9)-(411,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (412,1)-(412,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (412,6)-(412,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (412,7)-(412,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (413,1)-(413,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (413,6)-(413,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (413,7)-(413,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (414,1)-(414,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (414,6)-(414,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,7)-(414,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (415,1)-(415,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (415,6)-(415,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (415,7)-(415,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
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
            #line (416,7)-(416,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
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
            #line (422,33)-(422,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
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
            #line (424,5)-(424,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (424,11)-(424,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,12)-(424,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (424,17)-(424,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,19)-(424,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (424,47)-(424,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,48)-(424,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (424,49)-(424,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,51)-(424,78) 24 "SymbolGenerator.mxg"
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
        
        #line (430,9)-(430,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first51 = true;
            #line (431,6)-(431,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                var __first52 = true;
                #line (432,10)-(432,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first52)
                    {
                        __first52 = false;
                    }
                    __cb.Push("");
                    #line (433,13)-(433,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (433,15)-(433,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (433,16)-(433,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (433,19)-(433,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (433,28)-(433,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (434,13)-(434,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (435,18)-(435,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (435,37)-(435,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (435,47)-(435,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (435,49)-(435,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (435,58)-(435,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (436,13)-(436,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (437,10)-(437,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first52)
                    {
                        __first52 = false;
                    }
                    __cb.Push("");
                    #line (438,13)-(438,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (438,15)-(438,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (438,16)-(438,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (438,18)-(438,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (438,27)-(438,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (438,28)-(438,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (438,30)-(438,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (438,32)-(438,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (438,62)-(438,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (439,13)-(439,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (440,18)-(440,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (440,37)-(440,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (440,47)-(440,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (440,49)-(440,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (440,58)-(440,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (441,13)-(441,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first52) __cb.AppendLine();
            }
            #line (443,6)-(443,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("");
                #line (444,10)-(444,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (444,29)-(444,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (444,30)-(444,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (444,31)-(444,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (444,33)-(444,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (444,42)-(444,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (448,9)-(448,46) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (449,5)-(449,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (449,15)-(449,42) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (449,43)-(449,44) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (449,44)-(449,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,46)-(449,73) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (449,74)-(449,80) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (449,80)-(449,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,81)-(449,83) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (449,83)-(449,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,84)-(449,89) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (449,90)-(449,94) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (449,95)-(449,96) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (452,9)-(452,59) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string type, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (453,5)-(453,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (453,15)-(453,19) 24 "SymbolGenerator.mxg"
            __cb.Write(type);
            #line hidden
            #line (453,20)-(453,21) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (453,21)-(453,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,23)-(453,50) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (453,51)-(453,52) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (453,52)-(453,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,54)-(453,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (453,82)-(453,88) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (453,88)-(453,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,89)-(453,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (453,91)-(453,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,92)-(453,97) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (453,98)-(453,102) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (453,103)-(453,104) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}