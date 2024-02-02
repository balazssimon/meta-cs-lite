#line (1,10)-(1,53) 10 "AntlrGenerator.mxg"
namespace MetaDslx.Languages.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "AntlrGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "AntlrGenerator.mxg"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "AntlrGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "AntlrGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "AntlrGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "AntlrGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "AntlrGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "AntlrGenerator.mxg"
    System.Linq;
    #line hidden
    #line (7,1)-(7,6) 5 "AntlrGenerator.mxg"
    using
    #line hidden
    global::
    #line (7,7)-(7,23) 13 "AntlrGenerator.mxg"
    Roslyn.Utilities;
    #line hidden
    
    #line (9,10)-(9,29) 25 "AntlrGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (11,9)-(11,25) 22 "AntlrGenerator.mxg"
        public string GenerateLexer()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (12,5)-(12,10) 25 "AntlrGenerator.mxg"
            __cb.Write("lexer");
            #line hidden
            #line (12,10)-(12,11) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,11)-(12,18) 25 "AntlrGenerator.mxg"
            __cb.Write("grammar");
            #line hidden
            #line (12,18)-(12,19) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,20)-(12,24) 24 "AntlrGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (12,25)-(12,31) 25 "AntlrGenerator.mxg"
            __cb.Write("Lexer;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first1 = true;
            #line (14,6)-(14,40) 13 "AntlrGenerator.mxg"
            foreach (var token in FixedTokens)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("");
                #line (15,10)-(15,30) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateToken(token));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            var __first2 = true;
            #line (17,6)-(17,43) 13 "AntlrGenerator.mxg"
            foreach (var token in NonFixedTokens)
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("");
                #line (18,10)-(18,30) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateToken(token));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            var __first3 = true;
            #line (20,6)-(20,41) 13 "AntlrGenerator.mxg"
            foreach (var fragment in Fragments)
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.Push("");
                #line (21,10)-(21,36) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateFragment(fragment));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (25,9)-(25,45) 22 "AntlrGenerator.mxg"
        public string GenerateFragment(Fragment fragment)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (26,5)-(26,13) 25 "AntlrGenerator.mxg"
            __cb.Write("fragment");
            #line hidden
            #line (26,13)-(26,14) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,15)-(26,33) 24 "AntlrGenerator.mxg"
            __cb.Write(fragment.AntlrName);
            #line hidden
            #line (26,34)-(26,35) 25 "AntlrGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (26,35)-(26,36) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,37)-(26,81) 24 "AntlrGenerator.mxg"
            __cb.Write(GenerateLexerRuleAlts(fragment.Alternatives));
            #line hidden
            #line (26,82)-(26,83) 25 "AntlrGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (29,9)-(29,36) 22 "AntlrGenerator.mxg"
        public string GenerateToken(Token token)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (30,6)-(30,21) 24 "AntlrGenerator.mxg"
            __cb.Write(token.AntlrName);
            #line hidden
            #line (30,22)-(30,23) 25 "AntlrGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (30,23)-(30,24) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,25)-(30,66) 24 "AntlrGenerator.mxg"
            __cb.Write(GenerateLexerRuleAlts(token.Alternatives));
            #line hidden
            #line (30,68)-(30,111) 24 "AntlrGenerator.mxg"
            __cb.Write(token.IsTrivia ? " -> channel(HIDDEN)" : "");
            #line hidden
            #line (30,112)-(30,113) 25 "AntlrGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (33,9)-(33,65) 22 "AntlrGenerator.mxg"
        public string GenerateLexerRuleAlts(IList<LAlternative> alternatives)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first4 = true;
            #line (35,6)-(35,40) 13 "AntlrGenerator.mxg"
            foreach (var alt in alternatives) 
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (35,50)-(35,55) 32 "AntlrGenerator.mxg"
                    __cb.Write(" | ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (36,10)-(36,40) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateLexerRuleElements(alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (40,9)-(40,53) 22 "AntlrGenerator.mxg"
        public string GenerateLexerRuleElements(LAlternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first5 = true;
            #line (42,6)-(42,41) 13 "AntlrGenerator.mxg"
            foreach (var elem in alt.Elements) 
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (42,51)-(42,54) 32 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (43,10)-(43,35) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (43,37)-(43,73) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateLexerRuleElement(elem.Value));
                #line hidden
                #line (43,75)-(43,114) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateMultiplicity(elem.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (47,9)-(47,54) 22 "AntlrGenerator.mxg"
        public string GenerateLexerRuleElement(LElementValue elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first6 = true;
            #line (49,6)-(49,41) 13 "AntlrGenerator.mxg"
            if (elem is LReference ruleRefElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (50,10)-(50,36) 28 "AntlrGenerator.mxg"
                __cb.Write(ruleRefElem.Rule.AntlrName);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (51,6)-(51,40) 13 "AntlrGenerator.mxg"
            else if (elem is LFixed fixedElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (52,10)-(52,43) 28 "AntlrGenerator.mxg"
                __cb.Write(fixedElem.Text.EncodeString('\''));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (53,6)-(53,46) 13 "AntlrGenerator.mxg"
            else if (elem is LWildCard wildCardElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (54,9)-(54,10) 29 "AntlrGenerator.mxg"
                __cb.Write(".");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (55,6)-(55,40) 13 "AntlrGenerator.mxg"
            else if (elem is LBlock blockElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (56,9)-(56,10) 29 "AntlrGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (56,11)-(56,56) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateLexerRuleAlts(blockElem.Alternatives));
                #line hidden
                #line (56,57)-(56,58) 29 "AntlrGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (57,6)-(57,40) 13 "AntlrGenerator.mxg"
            else if (elem is LRange rangeElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (58,10)-(58,48) 28 "AntlrGenerator.mxg"
                __cb.Write(rangeElem.StartChar.EncodeString('\''));
                #line hidden
                #line (58,49)-(58,51) 29 "AntlrGenerator.mxg"
                __cb.Write("..");
                #line hidden
                #line (58,52)-(58,88) 28 "AntlrGenerator.mxg"
                __cb.Write(rangeElem.EndChar.EncodeString('\''));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (59,6)-(59,10) 13 "AntlrGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (60,9)-(60,12) 29 "AntlrGenerator.mxg"
                __cb.Write("!!!");
                #line hidden
                #line (60,12)-(60,13) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,13)-(60,19) 29 "AntlrGenerator.mxg"
                __cb.Write("ERROR:");
                #line hidden
                #line (60,19)-(60,20) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,20)-(60,27) 29 "AntlrGenerator.mxg"
                __cb.Write("unknown");
                #line hidden
                #line (60,27)-(60,28) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,28)-(60,33) 29 "AntlrGenerator.mxg"
                __cb.Write("lexer");
                #line hidden
                #line (60,33)-(60,34) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,34)-(60,38) 29 "AntlrGenerator.mxg"
                __cb.Write("rule");
                #line hidden
                #line (60,38)-(60,39) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,39)-(60,46) 29 "AntlrGenerator.mxg"
                __cb.Write("element");
                #line hidden
                #line (60,46)-(60,47) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,47)-(60,52) 29 "AntlrGenerator.mxg"
                __cb.Write("value");
                #line hidden
                #line (60,52)-(60,53) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,53)-(60,57) 29 "AntlrGenerator.mxg"
                __cb.Write("type");
                #line hidden
                #line (60,57)-(60,58) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,59)-(60,78) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.MInfo.MetaType);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first6) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (64,9)-(64,57) 22 "AntlrGenerator.mxg"
        public string GenerateMultiplicity(Multiplicity multiplicity)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            __cb.Push("");
            var __first7 = true;
            #line (66,6)-(66,49) 13 "AntlrGenerator.mxg"
            if (multiplicity == Multiplicity.ZeroOrOne)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (66,50)-(66,51) 29 "AntlrGenerator.mxg"
                __cb.Write("?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (67,6)-(67,55) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.ZeroOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (67,56)-(67,57) 29 "AntlrGenerator.mxg"
                __cb.Write("*");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (68,6)-(68,54) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.OneOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (68,55)-(68,56) 29 "AntlrGenerator.mxg"
                __cb.Write("+");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (69,6)-(69,63) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.NonGreedyZeroOrOne)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (69,64)-(69,66) 29 "AntlrGenerator.mxg"
                __cb.Write("??");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (70,6)-(70,64) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.NonGreedyZeroOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (70,65)-(70,67) 29 "AntlrGenerator.mxg"
                __cb.Write("*?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (71,6)-(71,63) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.NonGreedyOneOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (71,64)-(71,66) 29 "AntlrGenerator.mxg"
                __cb.Write("+?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first7) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (75,9)-(75,55) 22 "AntlrGenerator.mxg"
        public string GenerateAssignment(Multiplicity multiplicity)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first8 = true;
            #line (77,6)-(77,32) 13 "AntlrGenerator.mxg"
            if (multiplicity.IsList())
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (77,33)-(77,35) 29 "AntlrGenerator.mxg"
                __cb.Write("+=");
                #line hidden
            }
            #line (77,36)-(77,40) 13 "AntlrGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (77,41)-(77,42) 29 "AntlrGenerator.mxg"
                __cb.Write("=");
                #line hidden
            }
            if (!__first8) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (80,9)-(80,26) 22 "AntlrGenerator.mxg"
        public string GenerateParser()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (81,5)-(81,11) 25 "AntlrGenerator.mxg"
            __cb.Write("parser");
            #line hidden
            #line (81,11)-(81,12) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,12)-(81,19) 25 "AntlrGenerator.mxg"
            __cb.Write("grammar");
            #line hidden
            #line (81,19)-(81,20) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (81,21)-(81,25) 24 "AntlrGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (81,26)-(81,33) 25 "AntlrGenerator.mxg"
            __cb.Write("Parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (83,5)-(83,12) 25 "AntlrGenerator.mxg"
            __cb.Write("options");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (84,5)-(84,6) 25 "AntlrGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (85,9)-(85,19) 25 "AntlrGenerator.mxg"
            __cb.Write("tokenVocab");
            #line hidden
            #line (85,19)-(85,20) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,20)-(85,21) 25 "AntlrGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (85,21)-(85,22) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (85,23)-(85,27) 24 "AntlrGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (85,28)-(85,34) 25 "AntlrGenerator.mxg"
            __cb.Write("Lexer;");
            #line hidden
            #line (85,34)-(85,35) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (86,5)-(86,6) 25 "AntlrGenerator.mxg"
            __cb.Write("}");
            #line hidden
            #line (86,6)-(86,7) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (88,6)-(88,42) 13 "AntlrGenerator.mxg"
            foreach (var rule in RulesAndBlocks)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("");
                #line (89,10)-(89,34) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateParserRule(rule));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (93,9)-(93,39) 22 "AntlrGenerator.mxg"
        public string GenerateParserRule(Rule rule)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (94,6)-(94,20) 24 "AntlrGenerator.mxg"
            __cb.Write(rule.AntlrName);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (95,10)-(95,51) 24 "AntlrGenerator.mxg"
            __cb.Write(GenerateParserRuleAlts(rule.Alternatives));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (96,9)-(96,10) 25 "AntlrGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (99,9)-(99,65) 22 "AntlrGenerator.mxg"
        public string GenerateParserRuleAlts(IList<Alternative> alternatives)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (100,6)-(100,19) 13 "AntlrGenerator.mxg"
            var sep = ":";
            #line hidden
            
            var __first10 = true;
            #line (101,6)-(101,39) 13 "AntlrGenerator.mxg"
            foreach (var alt in alternatives)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                #line (102,10)-(102,13) 28 "AntlrGenerator.mxg"
                __cb.Write(sep);
                #line hidden
                #line (102,14)-(102,15) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (102,16)-(102,47) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateParserRuleElements(alt));
                #line hidden
                var __first11 = true;
                #line (102,49)-(102,76) 17 "AntlrGenerator.mxg"
                if (alternatives.Count > 1)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    #line (102,77)-(102,78) 33 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (102,78)-(102,79) 33 "AntlrGenerator.mxg"
                    __cb.Write("#");
                    #line hidden
                    #line (102,80)-(102,93) 32 "AntlrGenerator.mxg"
                    __cb.Write(alt.AntlrName);
                    #line hidden
                }
                if (!__first11) __cb.AppendLine();
                #line (103,10)-(103,19) 17 "AntlrGenerator.mxg"
                sep = "|";
                #line hidden
                
            }
            if (!__first10) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (107,9)-(107,53) 22 "AntlrGenerator.mxg"
        public string GenerateParserRuleElements(Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first12 = true;
            #line (109,6)-(109,41) 13 "AntlrGenerator.mxg"
            foreach (var elem in alt.Elements) 
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (109,51)-(109,54) 32 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (110,10)-(110,41) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateParserRuleElement(elem));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first12) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (114,9)-(114,49) 22 "AntlrGenerator.mxg"
        public string GenerateParserRuleElement(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            #line (115,8)-(115,9) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (116,6)-(116,28) 13 "AntlrGenerator.mxg"
            var value = elem.Value;
            #line hidden
            
            var __first13 = true;
            #line (117,6)-(117,39) 13 "AntlrGenerator.mxg"
            if (value is RuleRef ruleRefElem)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("");
                #line (118,10)-(118,24) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (118,26)-(118,69) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateAssignment(elem.Value.Multiplicity));
                #line hidden
                #line (118,71)-(118,104) 28 "AntlrGenerator.mxg"
                __cb.Write(ruleRefElem.GrammarRule.AntlrName);
                #line hidden
                #line (118,106)-(118,151) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateMultiplicity(elem.Value.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (119,6)-(119,40) 13 "AntlrGenerator.mxg"
            else if (value is Block blockElem)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("");
                #line (120,10)-(120,24) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (120,26)-(120,69) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateAssignment(elem.Value.Multiplicity));
                #line hidden
                #line (120,71)-(120,90) 28 "AntlrGenerator.mxg"
                __cb.Write(blockElem.AntlrName);
                #line hidden
                #line (120,92)-(120,137) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateMultiplicity(elem.Value.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (121,6)-(121,36) 13 "AntlrGenerator.mxg"
            else if (value is Eof eofElem)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("");
                #line (122,10)-(122,24) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (122,26)-(122,69) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateAssignment(elem.Value.Multiplicity));
                #line hidden
                #line (122,70)-(122,73) 29 "AntlrGenerator.mxg"
                __cb.Write("EOF");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (123,6)-(123,48) 13 "AntlrGenerator.mxg"
            else if (value is TokenAlts tokenAltsElem)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("");
                #line (124,10)-(124,24) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (124,25)-(124,27) 29 "AntlrGenerator.mxg"
                __cb.Write("=(");
                #line hidden
                var __first14 = true;
                foreach (var __item15 in 
                #line (124,28)-(124,92) 17 "AntlrGenerator.mxg"
                from token in tokenAltsElem.Tokens select token.Token.AntlrName 
                #line hidden
                )
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (124,102)-(124,107) 36 "AntlrGenerator.mxg"
                        __cb.Write(" | ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    __cb.Write(__item15);
                }
                #line (124,108)-(124,109) 29 "AntlrGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (124,110)-(124,155) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateMultiplicity(elem.Value.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (125,6)-(125,47) 13 "AntlrGenerator.mxg"
            else if (value is SeparatedList listElem)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                var __first16 = true;
                #line (126,10)-(126,99) 17 "AntlrGenerator.mxg"
                for (int i = 0; i < listElem.FirstItems.Count && i < listElem.FirstSeparators.Count; ++i)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    var __first17 = true;
                    #line (127,14)-(127,42) 21 "AntlrGenerator.mxg"
                    if (listElem.SeparatorFirst)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("");
                        #line (128,18)-(128,72) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (129,18)-(129,67) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (130,14)-(130,18) 21 "AntlrGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("");
                        #line (131,18)-(131,67) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (132,18)-(132,72) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                }
                if (!__first16) __cb.AppendLine();
                var __first18 = true;
                #line (135,10)-(135,73) 17 "AntlrGenerator.mxg"
                if (listElem.FirstItems.Count > listElem.FirstSeparators.Count)
                #line hidden
                
                {
                    if (__first18)
                    {
                        __first18 = false;
                    }
                    __cb.Push("");
                    #line (136,14)-(136,89) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.FirstItems[listElem.FirstItems.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first18) __cb.AppendLine();
                var __first19 = true;
                #line (138,10)-(138,73) 17 "AntlrGenerator.mxg"
                if (listElem.FirstSeparators.Count > listElem.FirstItems.Count)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("");
                    #line (139,14)-(139,99) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.FirstSeparators[listElem.FirstSeparators.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first19) __cb.AppendLine();
                var __first20 = true;
                #line (141,10)-(141,46) 17 "AntlrGenerator.mxg"
                if (listElem.RepeatedSeparatorFirst)
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    __cb.Push("");
                    #line (142,13)-(142,14) 33 "AntlrGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (142,15)-(142,51) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedSeparator.AntlrName);
                    #line hidden
                    #line (142,52)-(142,54) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (142,55)-(142,114) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedSeparator.Value).Token.AntlrName);
                    #line hidden
                    #line (142,115)-(142,116) 33 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (142,117)-(142,148) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedItem.AntlrName);
                    #line hidden
                    #line (142,149)-(142,151) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (142,152)-(142,205) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedItem.Value).Rule.AntlrName);
                    #line hidden
                    #line (142,206)-(142,207) 33 "AntlrGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (142,208)-(142,271) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateMultiplicity(listElem.RepeatedBlock.Value.Multiplicity));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (143,10)-(143,14) 17 "AntlrGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    __cb.Push("");
                    #line (144,13)-(144,14) 33 "AntlrGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (144,15)-(144,46) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedItem.AntlrName);
                    #line hidden
                    #line (144,47)-(144,49) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (144,50)-(144,103) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedItem.Value).Rule.AntlrName);
                    #line hidden
                    #line (144,104)-(144,105) 33 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (144,106)-(144,142) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedSeparator.AntlrName);
                    #line hidden
                    #line (144,143)-(144,145) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (144,146)-(144,205) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedSeparator.Value).Token.AntlrName);
                    #line hidden
                    #line (144,206)-(144,207) 33 "AntlrGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (144,208)-(144,271) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateMultiplicity(listElem.RepeatedBlock.Value.Multiplicity));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first20) __cb.AppendLine();
                var __first21 = true;
                #line (146,10)-(146,97) 17 "AntlrGenerator.mxg"
                for (int i = 0; i < listElem.LastItems.Count && i < listElem.LastSeparators.Count; ++i)
                #line hidden
                
                {
                    if (__first21)
                    {
                        __first21 = false;
                    }
                    var __first22 = true;
                    #line (147,14)-(147,50) 21 "AntlrGenerator.mxg"
                    if (listElem.RepeatedSeparatorFirst)
                    #line hidden
                    
                    {
                        if (__first22)
                        {
                            __first22 = false;
                        }
                        __cb.Push("");
                        #line (148,18)-(148,71) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (149,18)-(149,66) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (150,14)-(150,18) 21 "AntlrGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first22)
                        {
                            __first22 = false;
                        }
                        __cb.Push("");
                        #line (151,18)-(151,66) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (152,18)-(152,71) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first22) __cb.AppendLine();
                }
                if (!__first21) __cb.AppendLine();
                var __first23 = true;
                #line (155,10)-(155,71) 17 "AntlrGenerator.mxg"
                if (listElem.LastItems.Count > listElem.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first23)
                    {
                        __first23 = false;
                    }
                    __cb.Push("");
                    #line (156,14)-(156,87) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.LastItems[listElem.LastItems.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first23) __cb.AppendLine();
                var __first24 = true;
                #line (158,10)-(158,71) 17 "AntlrGenerator.mxg"
                if (listElem.LastSeparators.Count > listElem.LastItems.Count)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("");
                    #line (159,14)-(159,97) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.LastSeparators[listElem.LastSeparators.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first24) __cb.AppendLine();
            }
            #line (161,6)-(161,10) 13 "AntlrGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("");
                #line (162,9)-(162,12) 29 "AntlrGenerator.mxg"
                __cb.Write("!!!");
                #line hidden
                #line (162,12)-(162,13) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,13)-(162,19) 29 "AntlrGenerator.mxg"
                __cb.Write("ERROR:");
                #line hidden
                #line (162,19)-(162,20) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,20)-(162,27) 29 "AntlrGenerator.mxg"
                __cb.Write("unknown");
                #line hidden
                #line (162,27)-(162,28) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,28)-(162,34) 29 "AntlrGenerator.mxg"
                __cb.Write("parser");
                #line hidden
                #line (162,34)-(162,35) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,35)-(162,39) 29 "AntlrGenerator.mxg"
                __cb.Write("rule");
                #line hidden
                #line (162,39)-(162,40) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,40)-(162,47) 29 "AntlrGenerator.mxg"
                __cb.Write("element");
                #line hidden
                #line (162,47)-(162,48) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,48)-(162,52) 29 "AntlrGenerator.mxg"
                __cb.Write("type");
                #line hidden
                #line (162,52)-(162,53) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,54)-(162,73) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.MInfo.MetaType);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}