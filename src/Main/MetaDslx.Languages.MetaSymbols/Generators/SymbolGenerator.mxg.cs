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
            #line (73,11)-(73,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
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
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
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
            #line (74,11)-(74,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (74,26)-(74,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,27)-(74,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,28)-(74,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,29)-(74,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
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
            #line (75,11)-(75,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (75,28)-(75,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,29)-(75,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (75,30)-(75,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,31)-(75,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
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
            #line (76,11)-(76,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (76,27)-(76,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,28)-(76,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (76,29)-(76,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (76,30)-(76,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
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
            #line (77,11)-(77,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (77,30)-(77,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,31)-(77,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (77,32)-(77,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (77,33)-(77,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
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
            #line (78,11)-(78,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (78,26)-(78,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,27)-(78,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (78,28)-(78,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (78,29)-(78,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
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
            #line (79,11)-(79,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (79,24)-(79,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,25)-(79,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (79,26)-(79,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (79,27)-(79,69) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Compilation;");
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
            #line (80,11)-(80,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (80,27)-(80,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,28)-(80,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (80,29)-(80,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (80,30)-(80,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
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
            #line (81,11)-(81,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (81,30)-(81,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,31)-(81,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (81,32)-(81,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,33)-(81,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
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
            #line (82,11)-(82,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (82,36)-(82,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,37)-(82,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (82,38)-(82,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,39)-(82,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
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
            #line (83,11)-(83,24) 25 "SymbolGenerator.mxg"
            __cb.Write("__CultureInfo");
            #line hidden
            #line (83,24)-(83,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,25)-(83,26) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (83,26)-(83,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (83,27)-(83,68) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Globalization.CultureInfo;");
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
            #line (84,11)-(84,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (84,38)-(84,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,39)-(84,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (84,40)-(84,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (84,41)-(84,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (86,5)-(86,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (86,11)-(86,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,12)-(86,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (86,19)-(86,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,20)-(86,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (86,25)-(86,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,27)-(86,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (86,55)-(86,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,56)-(86,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (86,57)-(86,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first12 = true;
            #line (86,59)-(86,82) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                #line (86,83)-(86,131) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst");
                #line hidden
            }
            #line (86,132)-(86,136) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                #line (86,138)-(86,169) 28 "SymbolGenerator.mxg"
                __cb.Write(GetInstName(symbol, baseSymbol));
                #line hidden
            }
            #line (86,178)-(86,179) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (86,179)-(86,180) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,181)-(86,208) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (87,5)-(87,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first13 = true;
            #line (88,10)-(88,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                var __first14 = true;
                #line (89,14)-(89,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("        ");
                    #line (90,17)-(90,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (90,24)-(90,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,25)-(90,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (90,31)-(90,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,33)-(90,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (90,60)-(90,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,62)-(90,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (90,81)-(90,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,82)-(90,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (90,83)-(90,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,84)-(90,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (90,87)-(90,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,89)-(90,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (90,116)-(90,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (91,14)-(91,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("        ");
                    #line (92,17)-(92,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (92,24)-(92,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,26)-(92,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (92,53)-(92,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,55)-(92,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (92,74)-(92,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first14) __cb.AppendLine();
            }
            if (!__first13) __cb.AppendLine();
            var __first15 = true;
            #line (95,10)-(95,77) 13 "SymbolGenerator.mxg"
            foreach (var op in GetOperations(symbol).Where(o => o.CacheResult))
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                __cb.Push("        ");
                #line (96,13)-(96,20) 29 "SymbolGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (96,20)-(96,21) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (96,21)-(96,27) 29 "SymbolGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (96,27)-(96,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (96,29)-(96,53) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (96,54)-(96,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (96,56)-(96,72) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(op));
                #line hidden
                #line (96,73)-(96,74) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (96,74)-(96,75) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (96,75)-(96,76) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (96,76)-(96,79) 29 "SymbolGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (96,79)-(96,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (96,81)-(96,105) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldType(symbol, op));
                #line hidden
                #line (96,106)-(96,109) 29 "SymbolGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first15) __cb.AppendLine();
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
            #line (99,66)-(99,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (99,85)-(99,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,86)-(99,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (99,98)-(99,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,99)-(99,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (99,113)-(99,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,114)-(99,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (99,126)-(99,127) 25 "SymbolGenerator.mxg"
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
            __cb.Write("declaration,");
            #line hidden
            #line (100,43)-(100,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,44)-(100,56) 25 "SymbolGenerator.mxg"
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
            #line (104,66)-(104,80) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (104,80)-(104,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,81)-(104,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
            #line hidden
            #line (104,93)-(104,94) 25 "SymbolGenerator.mxg"
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
            #line (105,31)-(105,43) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject)");
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
            #line (109,66)-(109,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (109,75)-(109,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,76)-(109,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
            #line hidden
            #line (109,89)-(109,90) 25 "SymbolGenerator.mxg"
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
            #line (110,31)-(110,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol)");
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
            #line (114,66)-(114,83) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (114,83)-(114,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (114,84)-(114,94) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            #line (114,94)-(114,95) 25 "SymbolGenerator.mxg"
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
            #line (115,31)-(115,41) 25 "SymbolGenerator.mxg"
            __cb.Write("errorInfo)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (116,9)-(116,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
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
            #line (119,66)-(119,85) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (119,85)-(119,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,86)-(119,98) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (119,98)-(119,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,99)-(119,113) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (119,113)-(119,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,114)-(119,126) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (119,126)-(119,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,127)-(119,134) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (119,134)-(119,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,135)-(119,139) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (119,139)-(119,140) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,140)-(119,141) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (119,141)-(119,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,142)-(119,150) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (119,150)-(119,151) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,151)-(119,158) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (119,158)-(119,159) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,159)-(119,171) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (119,171)-(119,172) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,172)-(119,173) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (119,173)-(119,174) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,174)-(119,182) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (119,182)-(119,183) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,183)-(119,210) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (119,210)-(119,211) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,211)-(119,221) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (119,221)-(119,222) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,222)-(119,223) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (119,223)-(119,224) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,224)-(119,231) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first16 = true;
            #line (119,232)-(119,300) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                #line (119,301)-(119,302) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (119,302)-(119,303) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (119,304)-(119,334) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (119,335)-(119,336) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (119,337)-(119,355) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (119,356)-(119,357) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (119,357)-(119,358) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (119,358)-(119,359) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (119,360)-(119,394) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (119,408)-(119,409) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (119,409)-(119,410) 25 "SymbolGenerator.mxg"
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
            __cb.Write("declaration,");
            #line hidden
            #line (120,43)-(120,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,44)-(120,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (120,56)-(120,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,57)-(120,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (120,62)-(120,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,63)-(120,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (120,76)-(120,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (120,77)-(120,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first17 = true;
            #line (120,88)-(120,160) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                #line (120,161)-(120,162) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (120,162)-(120,163) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (120,164)-(120,182) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (120,183)-(120,184) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (120,184)-(120,185) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (120,186)-(120,204) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (120,218)-(120,219) 25 "SymbolGenerator.mxg"
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
            var __first18 = true;
            #line (122,14)-(122,78) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                __cb.Push("            ");
                #line (123,18)-(123,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first19 = true;
                #line (124,18)-(124,35) 17 "SymbolGenerator.mxg"
                if (!prop.IsInit)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("            ");
                    #line (125,21)-(125,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (125,39)-(125,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (125,67)-(125,91) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (125,92)-(125,121) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (125,122)-(125,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first19) __cb.AppendLine();
            }
            if (!__first18) __cb.AppendLine();
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
            __cb.Write("__IModelObject");
            #line hidden
            #line (130,80)-(130,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,81)-(130,93) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (130,93)-(130,94) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,94)-(130,101) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (130,101)-(130,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,102)-(130,106) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (130,106)-(130,107) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,107)-(130,108) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,108)-(130,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,109)-(130,117) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (130,117)-(130,118) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,118)-(130,125) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (130,125)-(130,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,126)-(130,138) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (130,138)-(130,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,139)-(130,140) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,140)-(130,141) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,141)-(130,149) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (130,149)-(130,150) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,150)-(130,177) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (130,177)-(130,178) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,178)-(130,188) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (130,188)-(130,189) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,189)-(130,190) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,190)-(130,191) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,191)-(130,198) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first20 = true;
            #line (130,199)-(130,267) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                #line (130,268)-(130,269) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (130,269)-(130,270) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,271)-(130,301) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (130,302)-(130,303) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,304)-(130,322) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (130,323)-(130,324) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,324)-(130,325) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (130,325)-(130,326) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (130,327)-(130,361) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (130,375)-(130,376) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (130,376)-(130,377) 25 "SymbolGenerator.mxg"
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
            __cb.Write("modelObject,");
            #line hidden
            #line (131,43)-(131,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,44)-(131,49) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (131,49)-(131,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,50)-(131,63) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (131,63)-(131,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,64)-(131,74) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first21 = true;
            #line (131,75)-(131,147) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                #line (131,148)-(131,149) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (131,149)-(131,150) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (131,151)-(131,169) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (131,170)-(131,171) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (131,171)-(131,172) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (131,173)-(131,191) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (131,205)-(131,206) 25 "SymbolGenerator.mxg"
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
            #line (133,14)-(133,78) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
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
                var __first23 = true;
                #line (135,18)-(135,35) 17 "SymbolGenerator.mxg"
                if (!prop.IsInit)
                #line hidden
                
                {
                    if (__first23)
                    {
                        __first23 = false;
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
                if (!__first23) __cb.AppendLine();
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
            #line (141,17)-(141,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (141,45)-(141,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (141,54)-(141,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,55)-(141,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (141,65)-(141,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,66)-(141,75) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (141,75)-(141,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,76)-(141,89) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (141,89)-(141,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,90)-(141,97) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (141,97)-(141,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,98)-(141,102) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (141,102)-(141,103) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,103)-(141,104) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (141,104)-(141,105) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,105)-(141,113) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (141,113)-(141,114) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,114)-(141,121) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (141,121)-(141,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,122)-(141,134) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (141,134)-(141,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,135)-(141,136) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (141,136)-(141,137) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,137)-(141,145) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (141,145)-(141,146) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,146)-(141,173) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (141,173)-(141,174) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,174)-(141,184) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (141,184)-(141,185) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,185)-(141,186) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (141,186)-(141,187) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (141,187)-(141,194) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first24 = true;
            #line (141,195)-(141,263) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                #line (141,264)-(141,265) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (141,265)-(141,266) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (141,267)-(141,297) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (141,298)-(141,299) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (141,300)-(141,318) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (141,319)-(141,320) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (141,320)-(141,321) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (141,321)-(141,322) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (141,323)-(141,357) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (141,371)-(141,372) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (141,372)-(141,373) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (142,13)-(142,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (142,14)-(142,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,15)-(142,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (142,30)-(142,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,31)-(142,44) 25 "SymbolGenerator.mxg"
            __cb.Write("csharpSymbol,");
            #line hidden
            #line (142,44)-(142,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,45)-(142,50) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (142,50)-(142,51) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,51)-(142,64) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (142,64)-(142,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (142,65)-(142,75) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first25 = true;
            #line (142,76)-(142,148) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                #line (142,149)-(142,150) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (142,150)-(142,151) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,152)-(142,170) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (142,171)-(142,172) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (142,172)-(142,173) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,174)-(142,192) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (142,206)-(142,207) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (143,9)-(143,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first26 = true;
            #line (144,14)-(144,78) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                __cb.Push("            ");
                #line (145,18)-(145,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first27 = true;
                #line (146,18)-(146,35) 17 "SymbolGenerator.mxg"
                if (!prop.IsInit)
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    __cb.Push("            ");
                    #line (147,21)-(147,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (147,39)-(147,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (147,67)-(147,91) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (147,92)-(147,121) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (147,122)-(147,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first27) __cb.AppendLine();
            }
            if (!__first26) __cb.AppendLine();
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
            #line (152,17)-(152,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (152,45)-(152,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (152,54)-(152,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,55)-(152,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (152,65)-(152,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,66)-(152,79) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (152,79)-(152,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,80)-(152,92) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (152,92)-(152,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,93)-(152,108) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (152,108)-(152,109) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,109)-(152,120) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (152,120)-(152,121) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,121)-(152,122) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (152,122)-(152,123) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,123)-(152,131) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (152,131)-(152,132) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,132)-(152,139) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (152,139)-(152,140) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,140)-(152,144) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (152,144)-(152,145) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,145)-(152,146) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (152,146)-(152,147) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,147)-(152,155) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (152,155)-(152,156) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,156)-(152,163) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (152,163)-(152,164) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,164)-(152,176) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (152,176)-(152,177) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,177)-(152,178) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (152,178)-(152,179) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,179)-(152,187) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (152,187)-(152,188) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,188)-(152,215) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (152,215)-(152,216) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,216)-(152,226) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (152,226)-(152,227) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,227)-(152,228) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (152,228)-(152,229) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (152,229)-(152,236) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first28 = true;
            #line (152,237)-(152,305) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first28)
                {
                    __first28 = false;
                }
                #line (152,306)-(152,307) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (152,307)-(152,308) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (152,309)-(152,339) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (152,340)-(152,341) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (152,342)-(152,360) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (152,361)-(152,362) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (152,362)-(152,363) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (152,363)-(152,364) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (152,365)-(152,399) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (152,413)-(152,414) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (152,414)-(152,415) 25 "SymbolGenerator.mxg"
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
            #line (153,31)-(153,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (153,43)-(153,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,44)-(153,56) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (153,56)-(153,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,57)-(153,62) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (153,62)-(153,63) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,63)-(153,76) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (153,76)-(153,77) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,77)-(153,87) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first29 = true;
            #line (153,88)-(153,160) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first29)
                {
                    __first29 = false;
                }
                #line (153,161)-(153,162) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (153,162)-(153,163) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,164)-(153,182) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (153,183)-(153,184) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (153,184)-(153,185) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (153,186)-(153,204) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (153,218)-(153,219) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,9)-(154,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first30 = true;
            #line (155,14)-(155,78) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("            ");
                #line (156,18)-(156,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first31 = true;
                #line (157,18)-(157,35) 17 "SymbolGenerator.mxg"
                if (!prop.IsInit)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    __cb.Push("            ");
                    #line (158,21)-(158,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (158,39)-(158,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (158,67)-(158,91) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (158,92)-(158,121) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (158,122)-(158,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first31) __cb.AppendLine();
            }
            if (!__first30) __cb.AppendLine();
            __cb.Push("        ");
            #line (161,9)-(161,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (163,9)-(163,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (163,15)-(163,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,17)-(163,44) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (163,45)-(163,54) 25 "SymbolGenerator.mxg"
            __cb.Write("(__Symbol");
            #line hidden
            #line (163,54)-(163,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,55)-(163,65) 25 "SymbolGenerator.mxg"
            __cb.Write("container,");
            #line hidden
            #line (163,65)-(163,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,66)-(163,79) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation");
            #line hidden
            #line (163,79)-(163,80) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,80)-(163,92) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (163,92)-(163,93) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,93)-(163,112) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (163,112)-(163,113) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,113)-(163,125) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (163,125)-(163,126) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,126)-(163,141) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (163,141)-(163,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,142)-(163,153) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject");
            #line hidden
            #line (163,153)-(163,154) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,154)-(163,155) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (163,155)-(163,156) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,156)-(163,164) 25 "SymbolGenerator.mxg"
            __cb.Write("default,");
            #line hidden
            #line (163,164)-(163,165) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,165)-(163,172) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (163,172)-(163,173) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,173)-(163,177) 25 "SymbolGenerator.mxg"
            __cb.Write("name");
            #line hidden
            #line (163,177)-(163,178) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,178)-(163,179) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (163,179)-(163,180) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,180)-(163,185) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (163,185)-(163,186) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,186)-(163,193) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (163,193)-(163,194) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,194)-(163,206) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName");
            #line hidden
            #line (163,206)-(163,207) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,207)-(163,208) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (163,208)-(163,209) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,209)-(163,214) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (163,214)-(163,215) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,215)-(163,242) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (163,242)-(163,243) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,243)-(163,253) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            #line (163,253)-(163,254) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,254)-(163,255) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (163,255)-(163,256) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,256)-(163,263) 25 "SymbolGenerator.mxg"
            __cb.Write("default");
            #line hidden
            var __first32 = true;
            #line (163,264)-(163,332) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                #line (163,333)-(163,334) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (163,334)-(163,335) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (163,336)-(163,366) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (163,367)-(163,368) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (163,369)-(163,387) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (163,388)-(163,389) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (163,389)-(163,390) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (163,390)-(163,391) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (163,392)-(163,426) 28 "SymbolGenerator.mxg"
                __cb.Write(GetConstDefaultValue(symbol, prop));
                #line hidden
            }
            #line (163,440)-(163,441) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            #line (163,441)-(163,442) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (164,13)-(164,14) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (164,14)-(164,15) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,15)-(164,30) 25 "SymbolGenerator.mxg"
            __cb.Write("base(container,");
            #line hidden
            #line (164,30)-(164,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,31)-(164,43) 25 "SymbolGenerator.mxg"
            __cb.Write("compilation,");
            #line hidden
            #line (164,43)-(164,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,44)-(164,56) 25 "SymbolGenerator.mxg"
            __cb.Write("declaration,");
            #line hidden
            #line (164,56)-(164,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,57)-(164,69) 25 "SymbolGenerator.mxg"
            __cb.Write("modelObject,");
            #line hidden
            #line (164,69)-(164,70) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,70)-(164,75) 25 "SymbolGenerator.mxg"
            __cb.Write("name,");
            #line hidden
            #line (164,75)-(164,76) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,76)-(164,89) 25 "SymbolGenerator.mxg"
            __cb.Write("metadataName,");
            #line hidden
            #line (164,89)-(164,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (164,90)-(164,100) 25 "SymbolGenerator.mxg"
            __cb.Write("attributes");
            #line hidden
            var __first33 = true;
            #line (164,101)-(164,173) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(baseSymbol).Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                #line (164,174)-(164,175) 29 "SymbolGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (164,175)-(164,176) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,177)-(164,195) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
                #line (164,196)-(164,197) 29 "SymbolGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (164,197)-(164,198) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,199)-(164,217) 28 "SymbolGenerator.mxg"
                __cb.Write(GetParamName(prop));
                #line hidden
            }
            #line (164,231)-(164,232) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (165,9)-(165,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first34 = true;
            #line (166,14)-(166,78) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties.Where(p => !p.IsDerived))
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("            ");
                #line (167,18)-(167,66) 28 "SymbolGenerator.mxg"
                __cb.Write(AssignProperty(symbol, prop, GetParamName(prop)));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first35 = true;
                #line (168,18)-(168,35) 17 "SymbolGenerator.mxg"
                if (!prop.IsInit)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.Push("            ");
                    #line (169,21)-(169,38) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (169,39)-(169,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (169,67)-(169,91) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (169,92)-(169,121) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (169,122)-(169,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("        ");
            #line (172,9)-(172,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (174,9)-(174,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (174,15)-(174,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,16)-(174,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (174,24)-(174,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,25)-(174,42) 25 "SymbolGenerator.mxg"
            __cb.Write("__AssemblySymbol?");
            #line hidden
            #line (174,42)-(174,43) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,43)-(174,61) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingAssembly");
            #line hidden
            #line (174,61)-(174,62) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,62)-(174,64) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (174,64)-(174,65) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,66)-(174,124) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__AssemblySymbol", "ContainingAssembly"));
            #line hidden
            #line (174,125)-(174,126) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
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
            #line (176,25)-(176,39) 25 "SymbolGenerator.mxg"
            __cb.Write("__Compilation?");
            #line hidden
            #line (176,39)-(176,40) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,40)-(176,60) 25 "SymbolGenerator.mxg"
            __cb.Write("DeclaringCompilation");
            #line hidden
            #line (176,60)-(176,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,61)-(176,63) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (176,63)-(176,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (176,65)-(176,122) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__Compilation", "DeclaringCompilation"));
            #line hidden
            #line (176,123)-(176,124) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (178,9)-(178,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (178,15)-(178,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (178,16)-(178,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (178,24)-(178,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (178,25)-(178,40) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModuleSymbol?");
            #line hidden
            #line (178,40)-(178,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (178,41)-(178,57) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingModule");
            #line hidden
            #line (178,57)-(178,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (178,58)-(178,60) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (178,60)-(178,61) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (178,62)-(178,116) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__ModuleSymbol", "ContainingModule"));
            #line hidden
            #line (178,117)-(178,118) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (180,9)-(180,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (180,15)-(180,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,16)-(180,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (180,24)-(180,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,25)-(180,45) 25 "SymbolGenerator.mxg"
            __cb.Write("__DeclarationSymbol?");
            #line hidden
            #line (180,45)-(180,46) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,46)-(180,67) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingDeclaration");
            #line hidden
            #line (180,67)-(180,68) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,68)-(180,70) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (180,70)-(180,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (180,72)-(180,136) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__DeclarationSymbol", "ContainingDeclaration"));
            #line hidden
            #line (180,137)-(180,138) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
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
            #line (182,25)-(182,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__TypeSymbol?");
            #line hidden
            #line (182,38)-(182,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,39)-(182,53) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingType");
            #line hidden
            #line (182,53)-(182,54) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,54)-(182,56) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (182,56)-(182,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (182,58)-(182,108) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__TypeSymbol", "ContainingType"));
            #line hidden
            #line (182,109)-(182,110) 25 "SymbolGenerator.mxg"
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
            #line (184,25)-(184,43) 25 "SymbolGenerator.mxg"
            __cb.Write("__NamespaceSymbol?");
            #line hidden
            #line (184,43)-(184,44) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,44)-(184,63) 25 "SymbolGenerator.mxg"
            __cb.Write("ContainingNamespace");
            #line hidden
            #line (184,63)-(184,64) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,64)-(184,66) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (184,66)-(184,67) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (184,68)-(184,128) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__NamespaceSymbol", "ContainingNamespace"));
            #line hidden
            #line (184,129)-(184,130) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first36 = true;
            #line (186,10)-(186,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                var __first37 = true;
                #line (187,14)-(187,30) 17 "SymbolGenerator.mxg"
                if (prop.IsInit)
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    __cb.Push("        ");
                    #line (188,17)-(188,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (188,23)-(188,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,24)-(188,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("virtual");
                    #line hidden
                    #line (188,31)-(188,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,33)-(188,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (188,64)-(188,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (188,66)-(188,75) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (189,17)-(189,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (190,21)-(190,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (190,24)-(190,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (190,25)-(190,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (190,27)-(190,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (190,29)-(190,55) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (190,56)-(190,57) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (191,21)-(191,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (191,30)-(191,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,31)-(191,34) 33 "SymbolGenerator.mxg"
                    __cb.Write("set");
                    #line hidden
                    #line (191,34)-(191,35) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,35)-(191,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (191,37)-(191,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,39)-(191,65) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (191,66)-(191,67) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,67)-(191,68) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (191,68)-(191,69) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (191,69)-(191,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("value;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (192,17)-(192,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (193,14)-(193,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first37)
                    {
                        __first37 = false;
                    }
                    __cb.Push("        ");
                    #line (194,17)-(194,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (194,23)-(194,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,25)-(194,55) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetTypeName(symbol, prop.Type));
                    #line hidden
                    #line (194,56)-(194,57) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,58)-(194,67) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (195,17)-(195,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (196,21)-(196,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (197,21)-(197,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (198,25)-(198,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("this.ForceComplete(");
                    #line hidden
                    #line (198,45)-(198,72) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (198,73)-(198,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (198,98)-(198,127) 32 "SymbolGenerator.mxg"
                    __cb.Write(prop.Phase?.Name ?? prop.Name);
                    #line hidden
                    #line (198,128)-(198,129) 33 "SymbolGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (198,129)-(198,130) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,130)-(198,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("null,");
                    #line hidden
                    #line (198,135)-(198,136) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (198,136)-(198,145) 33 "SymbolGenerator.mxg"
                    __cb.Write("default);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first38 = true;
                    #line (199,26)-(199,42) 21 "SymbolGenerator.mxg"
                    if (prop.IsWeak)
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        __cb.Push("                ");
                        #line (200,29)-(200,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (200,31)-(200,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (200,32)-(200,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (200,34)-(200,52) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (200,53)-(200,71) 37 "SymbolGenerator.mxg"
                        __cb.Write(".TryGetValue(this,");
                        #line hidden
                        #line (200,71)-(200,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (200,72)-(200,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("out");
                        #line hidden
                        #line (200,75)-(200,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (200,76)-(200,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (200,79)-(200,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (200,80)-(200,88) 37 "SymbolGenerator.mxg"
                        __cb.Write("result))");
                        #line hidden
                        #line (200,88)-(200,89) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (200,89)-(200,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (200,95)-(200,96) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (200,96)-(200,97) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (200,98)-(200,128) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetTypeName(symbol, prop.Type));
                        #line hidden
                        #line (200,129)-(200,137) 37 "SymbolGenerator.mxg"
                        __cb.Write(")result;");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                ");
                        #line (201,29)-(201,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("else");
                        #line hidden
                        #line (201,33)-(201,34) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (201,34)-(201,40) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (201,40)-(201,41) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (201,42)-(201,71) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, prop));
                        #line hidden
                        #line (201,72)-(201,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (202,26)-(202,30) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        __cb.Push("                ");
                        #line (203,29)-(203,35) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (203,35)-(203,36) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (203,37)-(203,55) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetFieldName(prop));
                        #line hidden
                        #line (203,56)-(203,57) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first38) __cb.AppendLine();
                    __cb.Push("            ");
                    #line (205,21)-(205,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (206,17)-(206,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first37) __cb.AppendLine();
            }
            if (!__first36) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (210,9)-(210,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (210,15)-(210,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,16)-(210,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (210,24)-(210,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,25)-(210,41) 25 "SymbolGenerator.mxg"
            __cb.Write("__LexicalSortKey");
            #line hidden
            #line (210,41)-(210,42) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,42)-(210,61) 25 "SymbolGenerator.mxg"
            __cb.Write("GetLexicalSortKey()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (211,9)-(211,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (212,13)-(212,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (212,19)-(212,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,21)-(212,80) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "__LexicalSortKey", "GetLexicalSortKey()"));
            #line hidden
            #line (212,81)-(212,82) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (213,9)-(213,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (215,9)-(215,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (215,15)-(215,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,16)-(215,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (215,24)-(215,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,25)-(215,29) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (215,29)-(215,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,30)-(215,52) 25 "SymbolGenerator.mxg"
            __cb.Write("HasUnsupportedMetadata");
            #line hidden
            #line (215,52)-(215,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,53)-(215,55) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (215,55)-(215,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,57)-(215,107) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "bool", "HasUnsupportedMetadata"));
            #line hidden
            #line (215,108)-(215,109) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (217,9)-(217,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (217,15)-(217,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,16)-(217,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (217,24)-(217,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,25)-(217,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (217,31)-(217,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,32)-(217,59) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentId()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (218,9)-(218,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (219,13)-(219,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (219,19)-(219,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,21)-(219,78) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string", "GetDocumentationCommentId()"));
            #line hidden
            #line (219,79)-(219,80) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (220,9)-(220,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (222,9)-(222,15) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (222,15)-(222,16) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,16)-(222,24) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (222,24)-(222,25) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,25)-(222,31) 25 "SymbolGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (222,31)-(222,32) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,32)-(222,72) 25 "SymbolGenerator.mxg"
            __cb.Write("GetDocumentationCommentXml(__CultureInfo");
            #line hidden
            #line (222,72)-(222,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,73)-(222,89) 25 "SymbolGenerator.mxg"
            __cb.Write("preferredCulture");
            #line hidden
            #line (222,89)-(222,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,90)-(222,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (222,91)-(222,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,92)-(222,97) 25 "SymbolGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (222,97)-(222,98) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,98)-(222,102) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (222,102)-(222,103) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,103)-(222,117) 25 "SymbolGenerator.mxg"
            __cb.Write("expandIncludes");
            #line hidden
            #line (222,117)-(222,118) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,118)-(222,119) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (222,119)-(222,120) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,120)-(222,126) 25 "SymbolGenerator.mxg"
            __cb.Write("false,");
            #line hidden
            #line (222,126)-(222,127) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,127)-(222,146) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (222,146)-(222,147) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,147)-(222,164) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken");
            #line hidden
            #line (222,164)-(222,165) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,165)-(222,166) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (222,166)-(222,167) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (222,167)-(222,175) 25 "SymbolGenerator.mxg"
            __cb.Write("default)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (223,9)-(223,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (224,13)-(224,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (224,19)-(224,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (224,21)-(224,130) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string", "GetDocumentationCommentXml(preferredCulture, expandIncludes, cancellationToken)"));
            #line hidden
            #line (224,131)-(224,132) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (225,9)-(225,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first39 = true;
            #line (226,10)-(226,51) 13 "SymbolGenerator.mxg"
            foreach (var op in GetOperations(symbol))
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                #line (227,14)-(227,90) 17 "SymbolGenerator.mxg"
                var arguments = "("+string.Join(", ", op.Parameters.Select(p => p.Name))+")";
                #line hidden
                
                #line (228,14)-(228,42) 17 "SymbolGenerator.mxg"
                var call = op.Name+arguments;
                #line hidden
                
                #line (229,14)-(229,84) 17 "SymbolGenerator.mxg"
                var virtOvrd = symbol.Operations.Contains(op) ? "virtual" : "override";
                #line hidden
                
                #line (230,14)-(230,65) 17 "SymbolGenerator.mxg"
                var returnType = GetTypeName(symbol, op.ReturnType);
                #line hidden
                
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (232,13)-(232,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (232,19)-(232,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (232,21)-(232,29) 28 "SymbolGenerator.mxg"
                __cb.Write(virtOvrd);
                #line hidden
                #line (232,30)-(232,31) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (232,32)-(232,42) 28 "SymbolGenerator.mxg"
                __cb.Write(returnType);
                #line hidden
                #line (232,43)-(232,44) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (232,45)-(232,52) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (232,53)-(232,54) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first40 = true;
                foreach (var __item41 in 
                #line (232,55)-(232,125) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
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
                        #line (232,135)-(232,139) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item41);
                }
                #line (232,140)-(232,141) 29 "SymbolGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (233,13)-(233,14) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first42 = true;
                #line (234,18)-(234,80) 17 "SymbolGenerator.mxg"
                if (op.ReturnType.Type.SpecialType == SpecialType.System_Void)
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("            ");
                    #line (235,22)-(235,44) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, call));
                    #line hidden
                    #line (235,45)-(235,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (236,18)-(236,42) 17 "SymbolGenerator.mxg"
                else if (op.CacheResult)
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    var __first43 = true;
                    #line (237,22)-(237,67) 21 "SymbolGenerator.mxg"
                    if (!string.IsNullOrEmpty(op.CacheCondition))
                    #line hidden
                    
                    {
                        if (__first43)
                        {
                            __first43 = false;
                        }
                        __cb.Push("            ");
                        #line (238,25)-(238,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("if");
                        #line hidden
                        #line (238,27)-(238,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (238,28)-(238,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("(!(");
                        #line hidden
                        #line (238,32)-(238,49) 36 "SymbolGenerator.mxg"
                        __cb.Write(op.CacheCondition);
                        #line hidden
                        #line (238,50)-(238,52) 37 "SymbolGenerator.mxg"
                        __cb.Write("))");
                        #line hidden
                        #line (238,52)-(238,53) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (238,53)-(238,59) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (238,59)-(238,60) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (238,61)-(238,99) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetDefaultValue(symbol, op.ReturnType));
                        #line hidden
                        #line (238,100)-(238,101) 37 "SymbolGenerator.mxg"
                        __cb.Write(";");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first43) __cb.AppendLine();
                    #line (240,22)-(240,54) 21 "SymbolGenerator.mxg"
                    var fieldName = GetFieldName(op);
                    #line hidden
                    
                    var __first44 = true;
                    #line (241,22)-(241,51) 21 "SymbolGenerator.mxg"
                    if (op.Parameters.Count == 0)
                    #line hidden
                    
                    {
                        if (__first44)
                        {
                            __first44 = false;
                        }
                        __cb.Push("            ");
                        #line (242,25)-(242,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (242,31)-(242,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (242,32)-(242,33) 37 "SymbolGenerator.mxg"
                        __cb.Write("(");
                        #line hidden
                        #line (242,34)-(242,44) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (242,45)-(242,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(")");
                        #line hidden
                        #line (242,47)-(242,56) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (242,57)-(242,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (242,72)-(242,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (242,73)-(242,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (242,79)-(242,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (242,80)-(242,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (242,82)-(242,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (242,84)-(242,118) 36 "SymbolGenerator.mxg"
                        __cb.Write(CallImpl(symbol, returnType, call));
                        #line hidden
                        #line (242,119)-(242,121) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (243,22)-(243,26) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first44)
                        {
                            __first44 = false;
                        }
                        __cb.Push("            ");
                        #line (244,25)-(244,28) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (244,28)-(244,29) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,29)-(244,47) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary");
                        #line hidden
                        #line (244,47)-(244,48) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,48)-(244,49) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (244,49)-(244,50) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,51)-(244,60) 36 "SymbolGenerator.mxg"
                        __cb.Write(fieldName);
                        #line hidden
                        #line (244,61)-(244,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(".GetValue(this,");
                        #line hidden
                        #line (244,76)-(244,77) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,77)-(244,83) 37 "SymbolGenerator.mxg"
                        __cb.Write("__this");
                        #line hidden
                        #line (244,83)-(244,84) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,84)-(244,86) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (244,86)-(244,87) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,87)-(244,90) 37 "SymbolGenerator.mxg"
                        __cb.Write("new");
                        #line hidden
                        #line (244,90)-(244,91) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,91)-(244,150) 37 "SymbolGenerator.mxg"
                        __cb.Write("global::System.Collections.Concurrent.ConcurrentDictionary<");
                        #line hidden
                        #line (244,151)-(244,178) 36 "SymbolGenerator.mxg"
                        __cb.Write(GetCacheKeyType(symbol, op));
                        #line hidden
                        #line (244,179)-(244,180) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (244,180)-(244,181) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (244,182)-(244,192) 36 "SymbolGenerator.mxg"
                        __cb.Write(returnType);
                        #line hidden
                        #line (244,193)-(244,198) 37 "SymbolGenerator.mxg"
                        __cb.Write(">());");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("            ");
                        #line (245,25)-(245,31) 37 "SymbolGenerator.mxg"
                        __cb.Write("return");
                        #line hidden
                        #line (245,31)-(245,32) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,32)-(245,60) 37 "SymbolGenerator.mxg"
                        __cb.Write("__cachedDictionary.GetOrAdd(");
                        #line hidden
                        #line (245,61)-(245,70) 36 "SymbolGenerator.mxg"
                        __cb.Write(arguments);
                        #line hidden
                        #line (245,71)-(245,72) 37 "SymbolGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (245,72)-(245,73) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,73)-(245,79) 37 "SymbolGenerator.mxg"
                        __cb.Write("__args");
                        #line hidden
                        #line (245,79)-(245,80) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,80)-(245,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (245,82)-(245,83) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (245,84)-(245,118) 36 "SymbolGenerator.mxg"
                        __cb.Write(CallImpl(symbol, returnType, call));
                        #line hidden
                        #line (245,119)-(245,121) 37 "SymbolGenerator.mxg"
                        __cb.Write(");");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first44) __cb.AppendLine();
                }
                #line (247,18)-(247,22) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    __cb.Push("            ");
                    #line (248,21)-(248,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (248,27)-(248,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (248,29)-(248,63) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, call));
                    #line hidden
                    #line (248,64)-(248,65) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first42) __cb.AppendLine();
                __cb.Push("        ");
                #line (250,13)-(250,14) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
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
            #line (253,28)-(253,32) 25 "SymbolGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (253,32)-(253,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,33)-(253,54) 25 "SymbolGenerator.mxg"
            __cb.Write("ForceCompletePart(ref");
            #line hidden
            #line (253,54)-(253,55) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,55)-(253,71) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (253,71)-(253,72) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,72)-(253,87) 25 "SymbolGenerator.mxg"
            __cb.Write("incompletePart,");
            #line hidden
            #line (253,87)-(253,88) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,88)-(253,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation?");
            #line hidden
            #line (253,105)-(253,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,106)-(253,118) 25 "SymbolGenerator.mxg"
            __cb.Write("locationOpt,");
            #line hidden
            #line (253,118)-(253,119) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,119)-(253,138) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (253,138)-(253,139) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (253,139)-(253,157) 25 "SymbolGenerator.mxg"
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
            #line (255,14)-(255,37) 13 "SymbolGenerator.mxg"
            var hasNewPhase = false;
            #line hidden
            
            #line (256,14)-(256,47) 13 "SymbolGenerator.mxg"
            var phases = GetAllPhases(symbol);
            #line hidden
            
            #line (257,14)-(257,55) 13 "SymbolGenerator.mxg"
            var basePhases = GetAllPhases(baseSymbol);
            #line hidden
            
            var __first45 = true;
            #line (258,14)-(258,43) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first45)
                {
                    __first45 = false;
                }
                var __first46 = true;
                #line (259,18)-(259,50) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first46)
                    {
                        __first46 = false;
                    }
                    #line (260,22)-(260,41) 21 "SymbolGenerator.mxg"
                    hasNewPhase = true;
                    #line hidden
                    
                    #line (261,22)-(261,67) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    __cb.Push("            ");
                    #line (262,21)-(262,23) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (262,23)-(262,24) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (262,24)-(262,39) 33 "SymbolGenerator.mxg"
                    __cb.Write("(incompletePart");
                    #line hidden
                    #line (262,39)-(262,40) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (262,40)-(262,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (262,42)-(262,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (262,44)-(262,71) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (262,72)-(262,95) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (262,96)-(262,101) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (262,102)-(262,103) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (262,103)-(262,105) 33 "SymbolGenerator.mxg"
                    __cb.Write("||");
                    #line hidden
                    #line (262,105)-(262,106) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (262,106)-(262,120) 33 "SymbolGenerator.mxg"
                    __cb.Write("incompletePart");
                    #line hidden
                    #line (262,120)-(262,121) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (262,121)-(262,123) 33 "SymbolGenerator.mxg"
                    __cb.Write("==");
                    #line hidden
                    #line (262,123)-(262,124) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (262,125)-(262,152) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (262,153)-(262,177) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (262,178)-(262,183) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (262,184)-(262,185) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (263,21)-(263,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (264,25)-(264,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (264,27)-(264,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (264,28)-(264,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("(NotePartComplete(");
                    #line hidden
                    #line (264,47)-(264,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (264,75)-(264,98) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Start_");
                    #line hidden
                    #line (264,99)-(264,104) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (264,105)-(264,107) 33 "SymbolGenerator.mxg"
                    __cb.Write("))");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (265,25)-(265,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (266,29)-(266,32) 33 "SymbolGenerator.mxg"
                    __cb.Write("var");
                    #line hidden
                    #line (266,32)-(266,33) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,33)-(266,44) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics");
                    #line hidden
                    #line (266,44)-(266,45) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,45)-(266,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (266,46)-(266,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (266,47)-(266,77) 33 "SymbolGenerator.mxg"
                    __cb.Write("__DiagnosticBag.GetInstance();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first47 = true;
                    #line (267,30)-(267,52) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first47)
                        {
                            __first47 = false;
                        }
                        __cb.Push("                    ");
                        #line (268,33)-(268,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (268,36)-(268,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (268,37)-(268,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (268,43)-(268,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (268,44)-(268,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (268,45)-(268,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (268,46)-(268,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (268,56)-(268,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (268,62)-(268,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (268,75)-(268,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (268,76)-(268,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first48 = true;
                        #line (269,34)-(269,61) 25 "SymbolGenerator.mxg"
                        foreach (var prop in props)
                        #line hidden
                        
                        {
                            if (__first48)
                            {
                                __first48 = false;
                            }
                            __cb.Push("                    ");
                            #line (270,38)-(270,87) 40 "SymbolGenerator.mxg"
                            __cb.Write(AssignProperty(symbol, prop, "result."+prop.Name));
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first48) __cb.AppendLine();
                    }
                    #line (272,30)-(272,57) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first47)
                        {
                            __first47 = false;
                        }
                        __cb.Push("                    ");
                        #line (273,33)-(273,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("var");
                        #line hidden
                        #line (273,36)-(273,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (273,37)-(273,43) 37 "SymbolGenerator.mxg"
                        __cb.Write("result");
                        #line hidden
                        #line (273,43)-(273,44) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (273,44)-(273,45) 37 "SymbolGenerator.mxg"
                        __cb.Write("=");
                        #line hidden
                        #line (273,45)-(273,46) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (273,46)-(273,55) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (273,56)-(273,61) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (273,62)-(273,75) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (273,75)-(273,76) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (273,76)-(273,95) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        __cb.Push("                    ");
                        #line (274,34)-(274,76) 36 "SymbolGenerator.mxg"
                        __cb.Write(AssignProperty(symbol, props[0], "result"));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (275,30)-(275,34) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first47)
                        {
                            __first47 = false;
                        }
                        __cb.Push("                    ");
                        #line (276,33)-(276,42) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (276,43)-(276,48) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (276,49)-(276,62) 37 "SymbolGenerator.mxg"
                        __cb.Write("(diagnostics,");
                        #line hidden
                        #line (276,62)-(276,63) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (276,63)-(276,82) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first47) __cb.AppendLine();
                    __cb.Push("                    ");
                    #line (278,29)-(278,63) 33 "SymbolGenerator.mxg"
                    __cb.Write("AddSymbolDiagnostics(diagnostics);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (279,29)-(279,48) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics.Free();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                    ");
                    #line (280,29)-(280,46) 33 "SymbolGenerator.mxg"
                    __cb.Write("NotePartComplete(");
                    #line hidden
                    #line (280,47)-(280,74) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetIntfName(symbol, symbol));
                    #line hidden
                    #line (280,75)-(280,99) 33 "SymbolGenerator.mxg"
                    __cb.Write(".CompletionParts.Finish_");
                    #line hidden
                    #line (280,100)-(280,105) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (280,106)-(280,108) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (281,25)-(281,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("                ");
                    #line (282,25)-(282,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (282,31)-(282,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (282,32)-(282,37) 33 "SymbolGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (283,21)-(283,22) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (284,21)-(284,25) 33 "SymbolGenerator.mxg"
                    __cb.Write("else");
                    #line hidden
                    #line (284,25)-(284,26) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.SkipLineEnd = true;
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first46) __cb.AppendLine();
            }
            if (!__first45) __cb.AppendLine();
            var __first49 = true;
            #line (287,14)-(287,30) 13 "SymbolGenerator.mxg"
            if (hasNewPhase)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("            ");
                #line (288,17)-(288,18) 29 "SymbolGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("                ");
                #line (289,21)-(289,27) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (289,27)-(289,28) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,28)-(289,54) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (289,54)-(289,55) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,55)-(289,70) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (289,70)-(289,71) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,71)-(289,83) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (289,83)-(289,84) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (289,84)-(289,103) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("            ");
                #line (290,17)-(290,18) 29 "SymbolGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (291,14)-(291,18) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                __cb.Push("            ");
                #line (292,17)-(292,23) 29 "SymbolGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (292,23)-(292,24) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,24)-(292,50) 29 "SymbolGenerator.mxg"
                __cb.Write("base.ForceCompletePart(ref");
                #line hidden
                #line (292,50)-(292,51) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,51)-(292,66) 29 "SymbolGenerator.mxg"
                __cb.Write("incompletePart,");
                #line hidden
                #line (292,66)-(292,67) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,67)-(292,79) 29 "SymbolGenerator.mxg"
                __cb.Write("locationOpt,");
                #line hidden
                #line (292,79)-(292,80) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (292,80)-(292,99) 29 "SymbolGenerator.mxg"
                __cb.Write("cancellationToken);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first49) __cb.AppendLine();
            __cb.Push("        ");
            #line (294,9)-(294,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (297,9)-(297,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (297,18)-(297,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,19)-(297,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (297,27)-(297,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,28)-(297,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (297,32)-(297,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,33)-(297,72) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Initialize(__DiagnosticBag");
            #line hidden
            #line (297,72)-(297,73) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,73)-(297,85) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (297,85)-(297,86) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,86)-(297,105) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (297,105)-(297,106) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,106)-(297,124) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (298,9)-(298,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (299,14)-(299,89) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Initialize(diagnostics, cancellationToken)"));
            #line hidden
            #line (299,90)-(299,91) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (300,9)-(300,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (302,9)-(302,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (302,18)-(302,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,19)-(302,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (302,27)-(302,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,28)-(302,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (302,35)-(302,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,36)-(302,65) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Name(__DiagnosticBag");
            #line hidden
            #line (302,65)-(302,66) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,66)-(302,78) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (302,78)-(302,79) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,79)-(302,98) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (302,98)-(302,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,99)-(302,117) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (303,9)-(303,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (304,13)-(304,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (304,19)-(304,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,21)-(304,97) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_Name(diagnostics, cancellationToken)"));
            #line hidden
            #line (304,98)-(304,99) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (305,9)-(305,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (307,9)-(307,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (307,18)-(307,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,19)-(307,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (307,27)-(307,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,28)-(307,35) 25 "SymbolGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (307,35)-(307,36) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,36)-(307,73) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_MetadataName(__DiagnosticBag");
            #line hidden
            #line (307,73)-(307,74) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,74)-(307,86) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (307,86)-(307,87) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,87)-(307,106) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (307,106)-(307,107) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,107)-(307,125) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (308,9)-(308,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (309,13)-(309,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (309,19)-(309,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,21)-(309,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "string?", "Complete_MetadataName(diagnostics, cancellationToken)"));
            #line hidden
            #line (309,106)-(309,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (310,9)-(310,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (312,9)-(312,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (312,18)-(312,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,19)-(312,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (312,27)-(312,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,28)-(312,89) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__Symbol>");
            #line hidden
            #line (312,89)-(312,90) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,90)-(312,141) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_CreateContainedSymbols(__DiagnosticBag");
            #line hidden
            #line (312,141)-(312,142) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,142)-(312,154) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (312,154)-(312,155) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,155)-(312,174) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (312,174)-(312,175) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,175)-(312,193) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (313,9)-(313,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (314,13)-(314,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (314,19)-(314,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (314,21)-(314,173) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__Symbol>", "CompletePart_CreateContainedSymbols(diagnostics, cancellationToken)"));
            #line hidden
            #line (314,174)-(314,175) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (315,9)-(315,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (317,9)-(317,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (317,18)-(317,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,19)-(317,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (317,27)-(317,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,28)-(317,98) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>");
            #line hidden
            #line (317,98)-(317,99) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,99)-(317,134) 25 "SymbolGenerator.mxg"
            __cb.Write("Complete_Attributes(__DiagnosticBag");
            #line hidden
            #line (317,134)-(317,135) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,135)-(317,147) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (317,147)-(317,148) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,148)-(317,167) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (317,167)-(317,168) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (317,168)-(317,186) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (318,9)-(318,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (319,13)-(319,19) 25 "SymbolGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (319,19)-(319,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (319,21)-(319,166) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "global::System.Collections.Immutable.ImmutableArray<__AttributeSymbol>", "Complete_Attributes(diagnostics, cancellationToken)"));
            #line hidden
            #line (319,167)-(319,168) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (320,9)-(320,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (322,9)-(322,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (322,18)-(322,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,19)-(322,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (322,27)-(322,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,28)-(322,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (322,32)-(322,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,33)-(322,88) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_ComputeNonSymbolProperties(__DiagnosticBag");
            #line hidden
            #line (322,88)-(322,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,89)-(322,101) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (322,101)-(322,102) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,102)-(322,121) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (322,121)-(322,122) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (322,122)-(322,140) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (323,9)-(323,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (324,14)-(324,105) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_ComputeNonSymbolProperties(diagnostics, cancellationToken)"));
            #line hidden
            #line (324,106)-(324,107) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (325,9)-(325,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (327,9)-(327,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (327,18)-(327,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,19)-(327,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (327,27)-(327,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,28)-(327,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (327,32)-(327,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,33)-(327,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Finalize(__DiagnosticBag");
            #line hidden
            #line (327,70)-(327,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,71)-(327,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (327,83)-(327,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,84)-(327,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (327,103)-(327,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,104)-(327,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (328,9)-(328,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (329,14)-(329,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Finalize(diagnostics, cancellationToken)"));
            #line hidden
            #line (329,88)-(329,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (330,9)-(330,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (332,9)-(332,18) 25 "SymbolGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (332,18)-(332,19) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,19)-(332,27) 25 "SymbolGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (332,27)-(332,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,28)-(332,32) 25 "SymbolGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (332,32)-(332,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,33)-(332,70) 25 "SymbolGenerator.mxg"
            __cb.Write("CompletePart_Validate(__DiagnosticBag");
            #line hidden
            #line (332,70)-(332,71) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,71)-(332,83) 25 "SymbolGenerator.mxg"
            __cb.Write("diagnostics,");
            #line hidden
            #line (332,83)-(332,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,84)-(332,103) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (332,103)-(332,104) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (332,104)-(332,122) 25 "SymbolGenerator.mxg"
            __cb.Write("cancellationToken)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (333,9)-(333,10) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (334,14)-(334,87) 24 "SymbolGenerator.mxg"
            __cb.Write(CallImpl(symbol, "CompletePart_Validate(diagnostics, cancellationToken)"));
            #line hidden
            #line (334,88)-(334,89) 25 "SymbolGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (335,9)-(335,10) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first50 = true;
            #line (337,10)-(337,53) 13 "SymbolGenerator.mxg"
            foreach (var phase in GetAllPhases(symbol))
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                #line (339,14)-(339,80) 17 "SymbolGenerator.mxg"
                var virtOvrd = basePhases.Contains(phase) ? "override" : "virtual";
                #line hidden
                
                #line (340,14)-(340,59) 17 "SymbolGenerator.mxg"
                var props = GetPhaseProperties(symbol, phase);
                #line hidden
                
                var __first51 = true;
                #line (341,14)-(341,36) 17 "SymbolGenerator.mxg"
                if (props.Length >= 2)
                #line hidden
                
                {
                    if (__first51)
                    {
                        __first51 = false;
                    }
                    #line (342,18)-(342,119) 21 "SymbolGenerator.mxg"
                    var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (343,17)-(343,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (343,26)-(343,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (343,28)-(343,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (343,37)-(343,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (343,39)-(343,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (343,50)-(343,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (343,51)-(343,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (343,61)-(343,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (343,67)-(343,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (343,83)-(343,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (343,84)-(343,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (343,96)-(343,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (343,97)-(343,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (343,116)-(343,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (343,117)-(343,135) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (344,17)-(344,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (345,21)-(345,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (345,27)-(345,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (345,29)-(345,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (345,112)-(345,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (346,17)-(346,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (347,14)-(347,41) 17 "SymbolGenerator.mxg"
                else if (props.Length == 1)
                #line hidden
                
                {
                    if (__first51)
                    {
                        __first51 = false;
                    }
                    #line (348,18)-(348,37) 21 "SymbolGenerator.mxg"
                    var prop = props[0];
                    #line hidden
                    
                    #line (349,18)-(349,65) 21 "SymbolGenerator.mxg"
                    var returnType = GetTypeName(symbol, prop.Type);
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (350,17)-(350,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (350,26)-(350,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,28)-(350,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (350,37)-(350,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,39)-(350,49) 32 "SymbolGenerator.mxg"
                    __cb.Write(returnType);
                    #line hidden
                    #line (350,50)-(350,51) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,51)-(350,60) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (350,61)-(350,66) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (350,67)-(350,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (350,83)-(350,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,84)-(350,96) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (350,96)-(350,97) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,97)-(350,116) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (350,116)-(350,117) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,117)-(350,135) 33 "SymbolGenerator.mxg"
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
                    #line (352,21)-(352,27) 33 "SymbolGenerator.mxg"
                    __cb.Write("return");
                    #line hidden
                    #line (352,27)-(352,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (352,29)-(352,111) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, returnType, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (352,112)-(352,113) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (353,17)-(353,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (354,14)-(354,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first51)
                    {
                        __first51 = false;
                    }
                    __cb.Push("        ");
                    #line (355,17)-(355,26) 33 "SymbolGenerator.mxg"
                    __cb.Write("protected");
                    #line hidden
                    #line (355,26)-(355,27) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,28)-(355,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(virtOvrd);
                    #line hidden
                    #line (355,37)-(355,38) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,38)-(355,42) 33 "SymbolGenerator.mxg"
                    __cb.Write("void");
                    #line hidden
                    #line (355,42)-(355,43) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,43)-(355,52) 33 "SymbolGenerator.mxg"
                    __cb.Write("Complete_");
                    #line hidden
                    #line (355,53)-(355,58) 32 "SymbolGenerator.mxg"
                    __cb.Write(phase);
                    #line hidden
                    #line (355,59)-(355,75) 33 "SymbolGenerator.mxg"
                    __cb.Write("(__DiagnosticBag");
                    #line hidden
                    #line (355,75)-(355,76) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,76)-(355,88) 33 "SymbolGenerator.mxg"
                    __cb.Write("diagnostics,");
                    #line hidden
                    #line (355,88)-(355,89) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,89)-(355,108) 33 "SymbolGenerator.mxg"
                    __cb.Write("__CancellationToken");
                    #line hidden
                    #line (355,108)-(355,109) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,109)-(355,127) 33 "SymbolGenerator.mxg"
                    __cb.Write("cancellationToken)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (356,17)-(356,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("            ");
                    #line (357,22)-(357,92) 32 "SymbolGenerator.mxg"
                    __cb.Write(CallImpl(symbol, "Complete_"+phase+"(diagnostics, cancellationToken)"));
                    #line hidden
                    #line (357,93)-(357,94) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (358,17)-(358,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first51) __cb.AppendLine();
            }
            if (!__first50) __cb.AppendLine();
            __cb.Push("    ");
            #line (361,5)-(361,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (363,5)-(363,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (363,11)-(363,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,12)-(363,20) 25 "SymbolGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (363,20)-(363,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,21)-(363,26) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (363,26)-(363,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,28)-(363,55) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            #line (363,56)-(363,57) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,57)-(363,58) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (363,58)-(363,59) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first52 = true;
            #line (363,60)-(363,83) 13 "SymbolGenerator.mxg"
            if (baseSymbol is null)
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                #line (363,84)-(363,132) 29 "SymbolGenerator.mxg"
                __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolImpl");
                #line hidden
            }
            #line (363,133)-(363,137) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                #line (363,139)-(363,170) 28 "SymbolGenerator.mxg"
                __cb.Write(GetImplName(symbol, baseSymbol));
                #line hidden
            }
            #line (363,179)-(363,180) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (363,180)-(363,181) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,182)-(363,209) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (364,5)-(364,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first53 = true;
            #line (365,10)-(365,49) 13 "SymbolGenerator.mxg"
            foreach (var prop in symbol.Properties)
            #line hidden
            
            {
                if (__first53)
                {
                    __first53 = false;
                }
                __cb.Push("        ");
                #line (366,13)-(366,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (366,19)-(366,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (366,21)-(366,51) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, prop.Type));
                #line hidden
                #line (366,52)-(366,53) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (366,54)-(366,63) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (366,64)-(366,65) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (366,65)-(366,67) 29 "SymbolGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (366,67)-(366,68) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (366,68)-(366,70) 29 "SymbolGenerator.mxg"
                __cb.Write("((");
                #line hidden
                #line (366,71)-(366,98) 28 "SymbolGenerator.mxg"
                __cb.Write(GetIntfName(symbol, symbol));
                #line hidden
                #line (366,99)-(366,111) 29 "SymbolGenerator.mxg"
                __cb.Write(")__Wrapped).");
                #line hidden
                #line (366,112)-(366,121) 28 "SymbolGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (366,122)-(366,123) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first53) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first54 = true;
            #line (369,10)-(369,70) 13 "SymbolGenerator.mxg"
            foreach (var op in symbol.Operations.Where(o => !o.IsPhase))
            #line hidden
            
            {
                if (__first54)
                {
                    __first54 = false;
                }
                __cb.Push("        ");
                #line (370,13)-(370,19) 29 "SymbolGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (370,19)-(370,20) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (370,20)-(370,28) 29 "SymbolGenerator.mxg"
                __cb.Write("abstract");
                #line hidden
                #line (370,28)-(370,29) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (370,30)-(370,64) 28 "SymbolGenerator.mxg"
                __cb.Write(GetTypeName(symbol, op.ReturnType));
                #line hidden
                #line (370,65)-(370,66) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (370,67)-(370,74) 28 "SymbolGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (370,75)-(370,76) 29 "SymbolGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first55 = true;
                foreach (var __item56 in 
                #line (370,77)-(370,147) 17 "SymbolGenerator.mxg"
                from p in op.Parameters select GetTypeName(symbol, p.Type)+" "+p.Name 
                #line hidden
                )
                {
                    if (__first55)
                    {
                        __first55 = false;
                    }
                    else
                    {
                        __cb.Push("        ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (370,157)-(370,161) 36 "SymbolGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item56);
                }
                #line (370,162)-(370,164) 29 "SymbolGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first54) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first57 = true;
            #line (373,10)-(373,39) 13 "SymbolGenerator.mxg"
            foreach (var phase in phases)
            #line hidden
            
            {
                if (__first57)
                {
                    __first57 = false;
                }
                var __first58 = true;
                #line (374,14)-(374,46) 17 "SymbolGenerator.mxg"
                if (!basePhases.Contains(phase))
                #line hidden
                
                {
                    if (__first58)
                    {
                        __first58 = false;
                    }
                    __cb.WriteLine();
                    __cb.Pop();
                    #line (376,18)-(376,63) 21 "SymbolGenerator.mxg"
                    var props = GetPhaseProperties(symbol, phase);
                    #line hidden
                    
                    var __first59 = true;
                    #line (377,18)-(377,40) 21 "SymbolGenerator.mxg"
                    if (props.Length >= 2)
                    #line hidden
                    
                    {
                        if (__first59)
                        {
                            __first59 = false;
                        }
                        #line (378,22)-(378,123) 25 "SymbolGenerator.mxg"
                        var returnType = "("+string.Join(", ", props.Select(p => GetTypeName(symbol, p.Type)+" "+p.Name))+")";
                        #line hidden
                        
                        var __first60 = true;
                        #line (379,22)-(379,62) 25 "SymbolGenerator.mxg"
                        if (props.Where(p => p.IsDerived).Any())
                        #line hidden
                        
                        {
                            if (__first60)
                            {
                                __first60 = false;
                            }
                            __cb.Push("        ");
                            #line (380,25)-(380,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (380,31)-(380,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (380,32)-(380,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (380,40)-(380,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (380,42)-(380,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (380,53)-(380,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (380,54)-(380,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (380,64)-(380,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (380,70)-(380,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (380,86)-(380,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (380,87)-(380,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (380,99)-(380,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (380,100)-(380,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (380,119)-(380,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (380,120)-(380,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (381,22)-(381,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first60)
                            {
                                __first60 = false;
                            }
                            __cb.Push("        ");
                            #line (382,25)-(382,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (382,31)-(382,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (382,32)-(382,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (382,39)-(382,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (382,41)-(382,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (382,52)-(382,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (382,53)-(382,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (382,63)-(382,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (382,69)-(382,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (382,85)-(382,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (382,86)-(382,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (382,98)-(382,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (382,99)-(382,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (382,118)-(382,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (382,119)-(382,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (383,25)-(383,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.SingleLineMode = true;
                            __cb.Push("            ");
                            #line (385,29)-(385,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (385,35)-(385,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (385,36)-(385,37) 41 "SymbolGenerator.mxg"
                            __cb.Write("(");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            var __first61 = true;
                            #line (386,34)-(386,62) 29 "SymbolGenerator.mxg"
                            foreach (var prop in props) 
                            #line hidden
                            
                            {
                                if (__first61)
                                {
                                    __first61 = false;
                                }
                                else
                                {
                                    __cb.Push("                ");
                                    __cb.DontIgnoreLastLineEnd = true;
                                    #line (386,72)-(386,76) 48 "SymbolGenerator.mxg"
                                    __cb.Write(", ");
                                    #line hidden
                                    __cb.DontIgnoreLastLineEnd = false;
                                    __cb.Pop();
                                }
                                __cb.Push("                ");
                                #line (387,37)-(387,91) 45 "SymbolGenerator.mxg"
                                __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                                #line hidden
                                var __first62 = true;
                                #line (387,92)-(387,121) 33 "SymbolGenerator.mxg"
                                if (prop.Type.Dimensions > 0)
                                #line hidden
                                
                                {
                                    if (__first62)
                                    {
                                        __first62 = false;
                                    }
                                    #line (387,122)-(387,123) 49 "SymbolGenerator.mxg"
                                    __cb.Write("s");
                                    #line hidden
                                }
                                #line (387,131)-(387,132) 45 "SymbolGenerator.mxg"
                                __cb.Write("<");
                                #line hidden
                                #line (387,133)-(387,168) 44 "SymbolGenerator.mxg"
                                __cb.Write(GetTypeName(symbol, prop.Type.Type));
                                #line hidden
                                #line (387,169)-(387,176) 45 "SymbolGenerator.mxg"
                                __cb.Write(">(this,");
                                #line hidden
                                #line (387,176)-(387,177) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (387,177)-(387,184) 45 "SymbolGenerator.mxg"
                                __cb.Write("nameof(");
                                #line hidden
                                #line (387,185)-(387,194) 44 "SymbolGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (387,195)-(387,197) 45 "SymbolGenerator.mxg"
                                __cb.Write("),");
                                #line hidden
                                #line (387,197)-(387,198) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (387,198)-(387,210) 45 "SymbolGenerator.mxg"
                                __cb.Write("diagnostics,");
                                #line hidden
                                #line (387,210)-(387,211) 45 "SymbolGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                                #line (387,211)-(387,230) 45 "SymbolGenerator.mxg"
                                __cb.Write("cancellationToken);");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first61) __cb.AppendLine();
                            __cb.Push("            ");
                            #line (389,29)-(389,31) 41 "SymbolGenerator.mxg"
                            __cb.Write(");");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.SingleLineMode = false;
                            __cb.AppendLine();
                            __cb.Push("        ");
                            #line (391,25)-(391,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first60) __cb.AppendLine();
                    }
                    #line (393,18)-(393,45) 21 "SymbolGenerator.mxg"
                    else if (props.Length == 1)
                    #line hidden
                    
                    {
                        if (__first59)
                        {
                            __first59 = false;
                        }
                        #line (394,22)-(394,41) 25 "SymbolGenerator.mxg"
                        var prop = props[0];
                        #line hidden
                        
                        #line (395,22)-(395,69) 25 "SymbolGenerator.mxg"
                        var returnType = GetTypeName(symbol, prop.Type);
                        #line hidden
                        
                        var __first63 = true;
                        #line (396,22)-(396,41) 25 "SymbolGenerator.mxg"
                        if (prop.IsDerived)
                        #line hidden
                        
                        {
                            if (__first63)
                            {
                                __first63 = false;
                            }
                            __cb.Push("        ");
                            #line (397,25)-(397,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (397,31)-(397,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (397,32)-(397,40) 41 "SymbolGenerator.mxg"
                            __cb.Write("abstract");
                            #line hidden
                            #line (397,40)-(397,41) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (397,42)-(397,52) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (397,53)-(397,54) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (397,54)-(397,63) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (397,64)-(397,69) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (397,70)-(397,86) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (397,86)-(397,87) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (397,87)-(397,99) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (397,99)-(397,100) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (397,100)-(397,119) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (397,119)-(397,120) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (397,120)-(397,139) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (398,22)-(398,26) 25 "SymbolGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first63)
                            {
                                __first63 = false;
                            }
                            __cb.Push("        ");
                            #line (399,25)-(399,31) 41 "SymbolGenerator.mxg"
                            __cb.Write("public");
                            #line hidden
                            #line (399,31)-(399,32) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (399,32)-(399,39) 41 "SymbolGenerator.mxg"
                            __cb.Write("virtual");
                            #line hidden
                            #line (399,39)-(399,40) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (399,41)-(399,51) 40 "SymbolGenerator.mxg"
                            __cb.Write(returnType);
                            #line hidden
                            #line (399,52)-(399,53) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (399,53)-(399,62) 41 "SymbolGenerator.mxg"
                            __cb.Write("Complete_");
                            #line hidden
                            #line (399,63)-(399,68) 40 "SymbolGenerator.mxg"
                            __cb.Write(phase);
                            #line hidden
                            #line (399,69)-(399,85) 41 "SymbolGenerator.mxg"
                            __cb.Write("(__DiagnosticBag");
                            #line hidden
                            #line (399,85)-(399,86) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (399,86)-(399,98) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (399,98)-(399,99) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (399,99)-(399,118) 41 "SymbolGenerator.mxg"
                            __cb.Write("__CancellationToken");
                            #line hidden
                            #line (399,118)-(399,119) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (399,119)-(399,137) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken)");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (400,25)-(400,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("{");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("            ");
                            #line (401,29)-(401,35) 41 "SymbolGenerator.mxg"
                            __cb.Write("return");
                            #line hidden
                            #line (401,35)-(401,36) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (401,36)-(401,90) 41 "SymbolGenerator.mxg"
                            __cb.Write("ContainingModule!.SymbolFactory.GetSymbolPropertyValue");
                            #line hidden
                            var __first64 = true;
                            #line (401,91)-(401,120) 29 "SymbolGenerator.mxg"
                            if (prop.Type.Dimensions > 0)
                            #line hidden
                            
                            {
                                if (__first64)
                                {
                                    __first64 = false;
                                }
                                #line (401,121)-(401,122) 45 "SymbolGenerator.mxg"
                                __cb.Write("s");
                                #line hidden
                            }
                            #line (401,130)-(401,131) 41 "SymbolGenerator.mxg"
                            __cb.Write("<");
                            #line hidden
                            #line (401,132)-(401,167) 40 "SymbolGenerator.mxg"
                            __cb.Write(GetTypeName(symbol, prop.Type.Type));
                            #line hidden
                            #line (401,168)-(401,175) 41 "SymbolGenerator.mxg"
                            __cb.Write(">(this,");
                            #line hidden
                            #line (401,175)-(401,176) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (401,176)-(401,183) 41 "SymbolGenerator.mxg"
                            __cb.Write("nameof(");
                            #line hidden
                            #line (401,184)-(401,193) 40 "SymbolGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (401,194)-(401,196) 41 "SymbolGenerator.mxg"
                            __cb.Write("),");
                            #line hidden
                            #line (401,196)-(401,197) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (401,197)-(401,209) 41 "SymbolGenerator.mxg"
                            __cb.Write("diagnostics,");
                            #line hidden
                            #line (401,209)-(401,210) 41 "SymbolGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (401,210)-(401,229) 41 "SymbolGenerator.mxg"
                            __cb.Write("cancellationToken);");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                            __cb.Push("        ");
                            #line (402,25)-(402,26) 41 "SymbolGenerator.mxg"
                            __cb.Write("}");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first63) __cb.AppendLine();
                    }
                    #line (404,18)-(404,22) 21 "SymbolGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first59)
                        {
                            __first59 = false;
                        }
                        __cb.Push("        ");
                        #line (405,21)-(405,27) 37 "SymbolGenerator.mxg"
                        __cb.Write("public");
                        #line hidden
                        #line (405,27)-(405,28) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (405,28)-(405,36) 37 "SymbolGenerator.mxg"
                        __cb.Write("abstract");
                        #line hidden
                        #line (405,36)-(405,37) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (405,37)-(405,41) 37 "SymbolGenerator.mxg"
                        __cb.Write("void");
                        #line hidden
                        #line (405,41)-(405,42) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (405,42)-(405,51) 37 "SymbolGenerator.mxg"
                        __cb.Write("Complete_");
                        #line hidden
                        #line (405,52)-(405,57) 36 "SymbolGenerator.mxg"
                        __cb.Write(phase);
                        #line hidden
                        #line (405,58)-(405,74) 37 "SymbolGenerator.mxg"
                        __cb.Write("(__DiagnosticBag");
                        #line hidden
                        #line (405,74)-(405,75) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (405,75)-(405,87) 37 "SymbolGenerator.mxg"
                        __cb.Write("diagnostics,");
                        #line hidden
                        #line (405,87)-(405,88) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (405,88)-(405,107) 37 "SymbolGenerator.mxg"
                        __cb.Write("__CancellationToken");
                        #line hidden
                        #line (405,107)-(405,108) 37 "SymbolGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (405,108)-(405,127) 37 "SymbolGenerator.mxg"
                        __cb.Write("cancellationToken);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first59) __cb.AppendLine();
                }
                if (!__first58) __cb.AppendLine();
            }
            if (!__first57) __cb.AppendLine();
            __cb.Push("    ");
            #line (409,5)-(409,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (410,1)-(410,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (413,9)-(413,42) 22 "SymbolGenerator.mxg"
        public string GenerateMultiBase(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (414,1)-(414,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (414,10)-(414,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,12)-(414,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (414,33)-(414,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (415,1)-(415,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (416,5)-(416,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (416,10)-(416,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,11)-(416,20) 25 "SymbolGenerator.mxg"
            __cb.Write("__ISymbol");
            #line hidden
            #line (416,20)-(416,21) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,21)-(416,22) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (416,22)-(416,23) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,23)-(416,62) 25 "SymbolGenerator.mxg"
            __cb.Write("global::Microsoft.CodeAnalysis.ISymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (417,5)-(417,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (417,10)-(417,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,11)-(417,25) 25 "SymbolGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (417,25)-(417,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,26)-(417,27) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (417,27)-(417,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,28)-(417,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (418,5)-(418,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (418,10)-(418,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,11)-(418,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__MergedDeclaration");
            #line hidden
            #line (418,30)-(418,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,31)-(418,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (418,32)-(418,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,33)-(418,94) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Declarations.MergedDeclaration;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (419,5)-(419,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (419,10)-(419,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,11)-(419,19) 25 "SymbolGenerator.mxg"
            __cb.Write("__Symbol");
            #line hidden
            #line (419,19)-(419,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,20)-(419,21) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (419,21)-(419,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,22)-(419,67) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.Symbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (420,5)-(420,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (420,10)-(420,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,11)-(420,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__ErrorSymbolInfo");
            #line hidden
            #line (420,28)-(420,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,29)-(420,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (420,30)-(420,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,31)-(420,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ErrorSymbolInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (421,5)-(421,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (421,10)-(421,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,11)-(421,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (421,26)-(421,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,27)-(421,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (421,28)-(421,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,29)-(421,90) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.ModelPropertyAttribute;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (422,5)-(422,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (422,10)-(422,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,11)-(422,28) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionGraph");
            #line hidden
            #line (422,28)-(422,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,29)-(422,30) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (422,30)-(422,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (422,31)-(422,85) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionGraph;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (423,5)-(423,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (423,10)-(423,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,11)-(423,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__CompletionPart");
            #line hidden
            #line (423,27)-(423,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,28)-(423,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (423,29)-(423,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (423,30)-(423,83) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.CompletionPart;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (424,5)-(424,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (424,10)-(424,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,11)-(424,26) 25 "SymbolGenerator.mxg"
            __cb.Write("__DiagnosticBag");
            #line hidden
            #line (424,26)-(424,27) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,27)-(424,28) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (424,28)-(424,29) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,29)-(424,73) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.DiagnosticBag;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (425,5)-(425,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (425,10)-(425,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,11)-(425,27) 25 "SymbolGenerator.mxg"
            __cb.Write("__SourceLocation");
            #line hidden
            #line (425,27)-(425,28) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,28)-(425,29) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (425,29)-(425,30) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,30)-(425,75) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.SourceLocation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (426,5)-(426,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (426,10)-(426,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,11)-(426,30) 25 "SymbolGenerator.mxg"
            __cb.Write("__CancellationToken");
            #line hidden
            #line (426,30)-(426,31) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,31)-(426,32) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (426,32)-(426,33) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,33)-(426,76) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Threading.CancellationToken;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (427,5)-(427,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (427,10)-(427,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,11)-(427,36) 25 "SymbolGenerator.mxg"
            __cb.Write("__NotImplementedException");
            #line hidden
            #line (427,36)-(427,37) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,37)-(427,38) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (427,38)-(427,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,39)-(427,78) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.NotImplementedException;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (428,5)-(428,10) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (428,10)-(428,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,11)-(428,38) 25 "SymbolGenerator.mxg"
            __cb.Write("__ImmutableAttributeSymbols");
            #line hidden
            #line (428,38)-(428,39) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,39)-(428,40) 25 "SymbolGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (428,40)-(428,41) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,41)-(428,148) 25 "SymbolGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<global::MetaDslx.CodeAnalysis.Symbols.AttributeSymbol>;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (430,5)-(430,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (430,11)-(430,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,12)-(430,19) 25 "SymbolGenerator.mxg"
            __cb.Write("partial");
            #line hidden
            #line (430,19)-(430,20) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,20)-(430,25) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (430,25)-(430,26) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,27)-(430,54) 24 "SymbolGenerator.mxg"
            __cb.Write(GetInstName(symbol, symbol));
            #line hidden
            #line (430,55)-(430,56) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,56)-(430,57) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (430,57)-(430,58) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,58)-(430,107) 25 "SymbolGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.Symbols.SymbolInst,");
            #line hidden
            #line (430,107)-(430,108) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,109)-(430,136) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (431,5)-(431,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first65 = true;
            #line (432,10)-(432,53) 13 "SymbolGenerator.mxg"
            foreach (var prop in GetProperties(symbol))
            #line hidden
            
            {
                if (__first65)
                {
                    __first65 = false;
                }
                var __first66 = true;
                #line (433,14)-(433,30) 17 "SymbolGenerator.mxg"
                if (prop.IsWeak)
                #line hidden
                
                {
                    if (__first66)
                    {
                        __first66 = false;
                    }
                    __cb.Push("        ");
                    #line (434,17)-(434,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (434,24)-(434,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,25)-(434,31) 33 "SymbolGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (434,31)-(434,32) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,33)-(434,59) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (434,60)-(434,61) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,62)-(434,80) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (434,81)-(434,82) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,82)-(434,83) 33 "SymbolGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (434,83)-(434,84) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,84)-(434,87) 33 "SymbolGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (434,87)-(434,88) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,89)-(434,115) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (434,116)-(434,119) 33 "SymbolGenerator.mxg"
                    __cb.Write("();");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (435,14)-(435,18) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first66)
                    {
                        __first66 = false;
                    }
                    __cb.Push("        ");
                    #line (436,17)-(436,24) 33 "SymbolGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (436,24)-(436,25) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (436,26)-(436,52) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldType(symbol, prop));
                    #line hidden
                    #line (436,53)-(436,54) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (436,55)-(436,73) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (436,74)-(436,75) 33 "SymbolGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first66) __cb.AppendLine();
            }
            if (!__first65) __cb.AppendLine();
            __cb.Push("        ");
            #line (439,9)-(439,11) 25 "SymbolGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (439,11)-(439,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,12)-(439,16) 25 "SymbolGenerator.mxg"
            __cb.Write("TODO");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (440,5)-(440,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (441,1)-(441,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (444,9)-(444,47) 22 "SymbolGenerator.mxg"
        public string GenerateImplementation(Symbol symbol)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (445,1)-(445,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (445,6)-(445,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,7)-(445,14) 25 "SymbolGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (446,1)-(446,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (446,6)-(446,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,7)-(446,34) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Generic;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (447,1)-(447,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (447,6)-(447,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,7)-(447,36) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (448,1)-(448,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (448,6)-(448,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,7)-(448,19) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Linq;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (449,1)-(449,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (449,6)-(449,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,7)-(449,24) 25 "SymbolGenerator.mxg"
            __cb.Write("System.Threading;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (450,1)-(450,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (450,6)-(450,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,7)-(450,25) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.Modeling;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (451,1)-(451,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (451,6)-(451,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,7)-(451,29) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (452,1)-(452,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (452,6)-(452,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,7)-(452,42) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Declarations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (453,1)-(453,6) 25 "SymbolGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (453,6)-(453,7) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,7)-(453,37) 25 "SymbolGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Symbols;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (455,1)-(455,10) 25 "SymbolGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (455,10)-(455,11) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,12)-(455,32) 24 "SymbolGenerator.mxg"
            __cb.Write(symbol.NamespaceName);
            #line hidden
            #line (455,33)-(455,40) 25 "SymbolGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (456,1)-(456,2) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (457,5)-(457,11) 25 "SymbolGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (457,11)-(457,12) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,12)-(457,17) 25 "SymbolGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (457,17)-(457,18) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,19)-(457,46) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (457,47)-(457,48) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,48)-(457,49) 25 "SymbolGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (457,49)-(457,50) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,51)-(457,78) 24 "SymbolGenerator.mxg"
            __cb.Write(GetBaseName(symbol, symbol));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (458,5)-(458,6) 25 "SymbolGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (459,5)-(459,6) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (460,1)-(460,2) 25 "SymbolGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (463,9)-(463,71) 22 "SymbolGenerator.mxg"
        public string AssignProperty(Symbol symbol, Property prop, string variable)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first67 = true;
            #line (464,6)-(464,22) 13 "SymbolGenerator.mxg"
            if (prop.IsWeak)
            #line hidden
            
            {
                if (__first67)
                {
                    __first67 = false;
                }
                var __first68 = true;
                #line (465,10)-(465,39) 17 "SymbolGenerator.mxg"
                if (prop.Type.Dimensions > 0)
                #line hidden
                
                {
                    if (__first68)
                    {
                        __first68 = false;
                    }
                    __cb.Push("");
                    #line (466,13)-(466,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (466,15)-(466,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (466,16)-(466,18) 33 "SymbolGenerator.mxg"
                    __cb.Write("(!");
                    #line hidden
                    #line (466,19)-(466,27) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (466,28)-(466,46) 33 "SymbolGenerator.mxg"
                    __cb.Write(".IsDefaultOrEmpty)");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (467,13)-(467,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (468,18)-(468,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (468,37)-(468,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (468,47)-(468,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (468,49)-(468,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (468,58)-(468,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (469,13)-(469,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (470,10)-(470,14) 17 "SymbolGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first68)
                    {
                        __first68 = false;
                    }
                    __cb.Push("");
                    #line (471,13)-(471,15) 33 "SymbolGenerator.mxg"
                    __cb.Write("if");
                    #line hidden
                    #line (471,15)-(471,16) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (471,16)-(471,17) 33 "SymbolGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (471,18)-(471,26) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (471,27)-(471,28) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (471,28)-(471,30) 33 "SymbolGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (471,30)-(471,31) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (471,32)-(471,61) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetDefaultValue(symbol, prop));
                    #line hidden
                    #line (471,62)-(471,63) 33 "SymbolGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (472,13)-(472,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("{");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (473,18)-(473,36) 32 "SymbolGenerator.mxg"
                    __cb.Write(GetFieldName(prop));
                    #line hidden
                    #line (473,37)-(473,47) 33 "SymbolGenerator.mxg"
                    __cb.Write(".Add(this,");
                    #line hidden
                    #line (473,47)-(473,48) 33 "SymbolGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (473,49)-(473,57) 32 "SymbolGenerator.mxg"
                    __cb.Write(variable);
                    #line hidden
                    #line (473,58)-(473,60) 33 "SymbolGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("");
                    #line (474,13)-(474,14) 33 "SymbolGenerator.mxg"
                    __cb.Write("}");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first68) __cb.AppendLine();
            }
            #line (476,6)-(476,10) 13 "SymbolGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first67)
                {
                    __first67 = false;
                }
                __cb.Push("");
                #line (477,10)-(477,28) 28 "SymbolGenerator.mxg"
                __cb.Write(GetFieldName(prop));
                #line hidden
                #line (477,29)-(477,30) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (477,30)-(477,31) 29 "SymbolGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (477,31)-(477,32) 29 "SymbolGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (477,33)-(477,41) 28 "SymbolGenerator.mxg"
                __cb.Write(variable);
                #line hidden
                #line (477,42)-(477,43) 29 "SymbolGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first67) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (481,9)-(481,46) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (482,5)-(482,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (482,15)-(482,42) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (482,43)-(482,44) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (482,44)-(482,45) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (482,46)-(482,73) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (482,74)-(482,80) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (482,80)-(482,81) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (482,81)-(482,83) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (482,83)-(482,84) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (482,84)-(482,89) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (482,90)-(482,94) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (482,95)-(482,96) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (485,9)-(485,59) 22 "SymbolGenerator.mxg"
        public string CallImpl(Symbol symbol, string type, string func)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (486,5)-(486,14) 25 "SymbolGenerator.mxg"
            __cb.Write("CallImpl<");
            #line hidden
            #line (486,15)-(486,19) 24 "SymbolGenerator.mxg"
            __cb.Write(type);
            #line hidden
            #line (486,20)-(486,21) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (486,21)-(486,22) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,23)-(486,50) 24 "SymbolGenerator.mxg"
            __cb.Write(GetIntfName(symbol, symbol));
            #line hidden
            #line (486,51)-(486,52) 25 "SymbolGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (486,52)-(486,53) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,54)-(486,81) 24 "SymbolGenerator.mxg"
            __cb.Write(GetImplName(symbol, symbol));
            #line hidden
            #line (486,82)-(486,88) 25 "SymbolGenerator.mxg"
            __cb.Write(">(impl");
            #line hidden
            #line (486,88)-(486,89) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,89)-(486,91) 25 "SymbolGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (486,91)-(486,92) 25 "SymbolGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,92)-(486,97) 25 "SymbolGenerator.mxg"
            __cb.Write("impl.");
            #line hidden
            #line (486,98)-(486,102) 24 "SymbolGenerator.mxg"
            __cb.Write(func);
            #line hidden
            #line (486,103)-(486,104) 25 "SymbolGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}