#line (1,10)-(1,53) 10 "AntlrGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "AntlrGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "AntlrGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler.Model;
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
            #line (12,1)-(12,6) 25 "AntlrGenerator.mxg"
            __cb.Write("lexer");
            #line hidden
            #line (12,6)-(12,7) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,7)-(12,14) 25 "AntlrGenerator.mxg"
            __cb.Write("grammar");
            #line hidden
            #line (12,14)-(12,15) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,16)-(12,20) 24 "AntlrGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (12,21)-(12,27) 25 "AntlrGenerator.mxg"
            __cb.Write("Lexer;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first1 = true;
            #line (14,2)-(14,36) 13 "AntlrGenerator.mxg"
            foreach (var token in FixedTokens)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("");
                #line (15,2)-(15,22) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateToken(token));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            var __first2 = true;
            #line (17,2)-(17,39) 13 "AntlrGenerator.mxg"
            foreach (var token in NonFixedTokens)
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("");
                #line (18,2)-(18,22) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateToken(token));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            var __first3 = true;
            #line (20,2)-(20,37) 13 "AntlrGenerator.mxg"
            foreach (var fragment in Fragments)
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.Push("");
                #line (21,2)-(21,28) 28 "AntlrGenerator.mxg"
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
            #line (26,1)-(26,9) 25 "AntlrGenerator.mxg"
            __cb.Write("fragment");
            #line hidden
            #line (26,9)-(26,10) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,11)-(26,29) 24 "AntlrGenerator.mxg"
            __cb.Write(fragment.AntlrName);
            #line hidden
            #line (26,30)-(26,31) 25 "AntlrGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (26,31)-(26,32) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,33)-(26,77) 24 "AntlrGenerator.mxg"
            __cb.Write(GenerateLexerRuleAlts(fragment.Alternatives));
            #line hidden
            #line (26,78)-(26,79) 25 "AntlrGenerator.mxg"
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
            #line (30,2)-(30,17) 24 "AntlrGenerator.mxg"
            __cb.Write(token.AntlrName);
            #line hidden
            #line (30,18)-(30,19) 25 "AntlrGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (30,19)-(30,20) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,21)-(30,62) 24 "AntlrGenerator.mxg"
            __cb.Write(GenerateLexerRuleAlts(token.Alternatives));
            #line hidden
            #line (30,64)-(30,107) 24 "AntlrGenerator.mxg"
            __cb.Write(token.IsTrivia ? " -> channel(HIDDEN)" : "");
            #line hidden
            #line (30,108)-(30,109) 25 "AntlrGenerator.mxg"
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
            #line (35,2)-(35,36) 13 "AntlrGenerator.mxg"
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
                    #line (35,46)-(35,51) 32 "AntlrGenerator.mxg"
                    __cb.Write(" | ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (36,2)-(36,32) 28 "AntlrGenerator.mxg"
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
            #line (42,2)-(42,37) 13 "AntlrGenerator.mxg"
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
                    #line (42,47)-(42,50) 32 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (43,2)-(43,27) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (43,29)-(43,65) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateLexerRuleElement(elem.Value));
                #line hidden
                #line (43,67)-(43,106) 28 "AntlrGenerator.mxg"
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
            #line (49,2)-(49,37) 13 "AntlrGenerator.mxg"
            if (elem is LReference ruleRefElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (50,2)-(50,28) 28 "AntlrGenerator.mxg"
                __cb.Write(ruleRefElem.Rule.AntlrName);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (51,2)-(51,36) 13 "AntlrGenerator.mxg"
            else if (elem is LFixed fixedElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (52,2)-(52,35) 28 "AntlrGenerator.mxg"
                __cb.Write(fixedElem.Text.EncodeString('\''));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (53,2)-(53,42) 13 "AntlrGenerator.mxg"
            else if (elem is LWildCard wildCardElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (54,1)-(54,2) 29 "AntlrGenerator.mxg"
                __cb.Write(".");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (55,2)-(55,36) 13 "AntlrGenerator.mxg"
            else if (elem is LBlock blockElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (56,1)-(56,2) 29 "AntlrGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (56,3)-(56,48) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateLexerRuleAlts(blockElem.Alternatives));
                #line hidden
                #line (56,49)-(56,50) 29 "AntlrGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (57,2)-(57,36) 13 "AntlrGenerator.mxg"
            else if (elem is LRange rangeElem)
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (58,2)-(58,40) 28 "AntlrGenerator.mxg"
                __cb.Write(rangeElem.StartChar.EncodeString('\''));
                #line hidden
                #line (58,41)-(58,43) 29 "AntlrGenerator.mxg"
                __cb.Write("..");
                #line hidden
                #line (58,44)-(58,80) 28 "AntlrGenerator.mxg"
                __cb.Write(rangeElem.EndChar.EncodeString('\''));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (59,2)-(59,6) 13 "AntlrGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                __cb.Push("");
                #line (60,1)-(60,4) 29 "AntlrGenerator.mxg"
                __cb.Write("!!!");
                #line hidden
                #line (60,4)-(60,5) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,5)-(60,11) 29 "AntlrGenerator.mxg"
                __cb.Write("ERROR:");
                #line hidden
                #line (60,11)-(60,12) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,12)-(60,19) 29 "AntlrGenerator.mxg"
                __cb.Write("unknown");
                #line hidden
                #line (60,19)-(60,20) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,20)-(60,25) 29 "AntlrGenerator.mxg"
                __cb.Write("lexer");
                #line hidden
                #line (60,25)-(60,26) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,26)-(60,30) 29 "AntlrGenerator.mxg"
                __cb.Write("rule");
                #line hidden
                #line (60,30)-(60,31) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,31)-(60,38) 29 "AntlrGenerator.mxg"
                __cb.Write("element");
                #line hidden
                #line (60,38)-(60,39) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,39)-(60,44) 29 "AntlrGenerator.mxg"
                __cb.Write("value");
                #line hidden
                #line (60,44)-(60,45) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,45)-(60,49) 29 "AntlrGenerator.mxg"
                __cb.Write("type");
                #line hidden
                #line (60,49)-(60,50) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (60,51)-(60,65) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.GetType());
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
            #line (66,2)-(66,45) 13 "AntlrGenerator.mxg"
            if (multiplicity == Multiplicity.ZeroOrOne)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (66,46)-(66,47) 29 "AntlrGenerator.mxg"
                __cb.Write("?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (67,2)-(67,51) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.ZeroOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (67,52)-(67,53) 29 "AntlrGenerator.mxg"
                __cb.Write("*");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (68,2)-(68,50) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.OneOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (68,51)-(68,52) 29 "AntlrGenerator.mxg"
                __cb.Write("+");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (69,2)-(69,59) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.NonGreedyZeroOrOne)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (69,60)-(69,62) 29 "AntlrGenerator.mxg"
                __cb.Write("??");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (70,2)-(70,60) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.NonGreedyZeroOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (70,61)-(70,63) 29 "AntlrGenerator.mxg"
                __cb.Write("*?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (71,2)-(71,59) 13 "AntlrGenerator.mxg"
            else if (multiplicity == Multiplicity.NonGreedyOneOrMore)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                #line (71,60)-(71,62) 29 "AntlrGenerator.mxg"
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
            #line (77,2)-(77,28) 13 "AntlrGenerator.mxg"
            if (multiplicity.IsList())
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (77,29)-(77,31) 29 "AntlrGenerator.mxg"
                __cb.Write("+=");
                #line hidden
            }
            #line (77,32)-(77,36) 13 "AntlrGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                #line (77,37)-(77,38) 29 "AntlrGenerator.mxg"
                __cb.Write("=");
                #line hidden
            }
            if (!__first8) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (81,9)-(81,26) 22 "AntlrGenerator.mxg"
        public string GenerateParser()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (82,1)-(82,7) 25 "AntlrGenerator.mxg"
            __cb.Write("parser");
            #line hidden
            #line (82,7)-(82,8) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,8)-(82,15) 25 "AntlrGenerator.mxg"
            __cb.Write("grammar");
            #line hidden
            #line (82,15)-(82,16) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (82,17)-(82,21) 24 "AntlrGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (82,22)-(82,29) 25 "AntlrGenerator.mxg"
            __cb.Write("Parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (84,1)-(84,8) 25 "AntlrGenerator.mxg"
            __cb.Write("options");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (85,1)-(85,2) 25 "AntlrGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (86,5)-(86,15) 25 "AntlrGenerator.mxg"
            __cb.Write("tokenVocab");
            #line hidden
            #line (86,15)-(86,16) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,16)-(86,17) 25 "AntlrGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (86,17)-(86,18) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (86,19)-(86,23) 24 "AntlrGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (86,24)-(86,30) 25 "AntlrGenerator.mxg"
            __cb.Write("Lexer;");
            #line hidden
            #line (86,30)-(86,31) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (87,1)-(87,2) 25 "AntlrGenerator.mxg"
            __cb.Write("}");
            #line hidden
            #line (87,2)-(87,3) 25 "AntlrGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (89,2)-(89,29) 13 "AntlrGenerator.mxg"
            foreach (var rule in Rules)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("");
                #line (90,2)-(90,26) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateParserRule(rule));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            var __first10 = true;
            #line (92,2)-(92,31) 13 "AntlrGenerator.mxg"
            foreach (var block in Blocks)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                __cb.Push("");
                #line (93,2)-(93,27) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateParserRule(block));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first10) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (97,9)-(97,39) 22 "AntlrGenerator.mxg"
        public string GenerateParserRule(Rule rule)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (98,2)-(98,16) 24 "AntlrGenerator.mxg"
            __cb.Write(rule.AntlrName);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (99,6)-(99,47) 24 "AntlrGenerator.mxg"
            __cb.Write(GenerateParserRuleAlts(rule.Alternatives));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (100,5)-(100,6) 25 "AntlrGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (103,9)-(103,41) 22 "AntlrGenerator.mxg"
        public string GenerateParserRule(Block block)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (104,2)-(104,17) 24 "AntlrGenerator.mxg"
            __cb.Write(block.AntlrName);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (105,6)-(105,48) 24 "AntlrGenerator.mxg"
            __cb.Write(GenerateParserRuleAlts(block.Alternatives));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (106,5)-(106,6) 25 "AntlrGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (109,9)-(109,65) 22 "AntlrGenerator.mxg"
        public string GenerateParserRuleAlts(IList<Alternative> alternatives)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (110,2)-(110,15) 13 "AntlrGenerator.mxg"
            var sep = ":";
            #line hidden
            
            var __first11 = true;
            #line (111,2)-(111,35) 13 "AntlrGenerator.mxg"
            foreach (var alt in alternatives)
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                #line (112,2)-(112,5) 28 "AntlrGenerator.mxg"
                __cb.Write(sep);
                #line hidden
                #line (112,6)-(112,7) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (112,8)-(112,39) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateParserRuleElements(alt));
                #line hidden
                var __first12 = true;
                #line (112,41)-(112,68) 17 "AntlrGenerator.mxg"
                if (alternatives.Count > 1)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    #line (112,69)-(112,70) 33 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (112,70)-(112,71) 33 "AntlrGenerator.mxg"
                    __cb.Write("#");
                    #line hidden
                    #line (112,72)-(112,85) 32 "AntlrGenerator.mxg"
                    __cb.Write(alt.AntlrName);
                    #line hidden
                }
                if (!__first12) __cb.AppendLine();
                #line (113,2)-(113,11) 17 "AntlrGenerator.mxg"
                sep = "|";
                #line hidden
                
            }
            if (!__first11) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (117,9)-(117,53) 22 "AntlrGenerator.mxg"
        public string GenerateParserRuleElements(Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first13 = true;
            #line (119,2)-(119,37) 13 "AntlrGenerator.mxg"
            foreach (var elem in alt.Elements) 
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (119,47)-(119,50) 32 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (120,2)-(120,33) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateParserRuleElement(elem));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (124,9)-(124,49) 22 "AntlrGenerator.mxg"
        public string GenerateParserRuleElement(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            #line (126,2)-(126,24) 13 "AntlrGenerator.mxg"
            var value = elem.Value;
            #line hidden
            
            var __first14 = true;
            #line (127,2)-(127,35) 13 "AntlrGenerator.mxg"
            if (value is RuleRef ruleRefElem)
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                __cb.Push("");
                #line (128,3)-(128,17) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (128,19)-(128,62) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateAssignment(elem.Value.Multiplicity));
                #line hidden
                #line (128,64)-(128,97) 28 "AntlrGenerator.mxg"
                __cb.Write(ruleRefElem.GrammarRule.AntlrName);
                #line hidden
                #line (128,99)-(128,144) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateMultiplicity(elem.Value.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (129,2)-(129,32) 13 "AntlrGenerator.mxg"
            else if (value is Eof eofElem)
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                __cb.Push("");
                #line (130,3)-(130,17) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (130,19)-(130,62) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateAssignment(elem.Value.Multiplicity));
                #line hidden
                #line (130,63)-(130,66) 29 "AntlrGenerator.mxg"
                __cb.Write("EOF");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (131,2)-(131,44) 13 "AntlrGenerator.mxg"
            else if (value is TokenAlts tokenAltsElem)
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                __cb.Push("");
                #line (132,3)-(132,17) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (132,18)-(132,20) 29 "AntlrGenerator.mxg"
                __cb.Write("=(");
                #line hidden
                var __first15 = true;
                #line (132,21)-(132,65) 17 "AntlrGenerator.mxg"
                foreach (var token in tokenAltsElem.Tokens) 
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (132,75)-(132,80) 36 "AntlrGenerator.mxg"
                        __cb.Write(" | ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (132,82)-(132,103) 32 "AntlrGenerator.mxg"
                    __cb.Write(token.Token.AntlrName);
                    #line hidden
                }
                #line (132,117)-(132,118) 29 "AntlrGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (132,119)-(132,164) 28 "AntlrGenerator.mxg"
                __cb.Write(GenerateMultiplicity(elem.Value.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (133,2)-(133,43) 13 "AntlrGenerator.mxg"
            else if (value is SeparatedList listElem)
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                var __first16 = true;
                #line (134,6)-(134,95) 17 "AntlrGenerator.mxg"
                for (int i = 0; i < listElem.FirstItems.Count && i < listElem.FirstSeparators.Count; ++i)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    var __first17 = true;
                    #line (135,10)-(135,38) 21 "AntlrGenerator.mxg"
                    if (listElem.SeparatorFirst)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("");
                        #line (136,3)-(136,57) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (137,3)-(137,52) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (138,10)-(138,14) 21 "AntlrGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("");
                        #line (139,3)-(139,52) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (140,3)-(140,57) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.FirstSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                }
                if (!__first16) __cb.AppendLine();
                var __first18 = true;
                #line (143,6)-(143,69) 17 "AntlrGenerator.mxg"
                if (listElem.FirstItems.Count > listElem.FirstSeparators.Count)
                #line hidden
                
                {
                    if (__first18)
                    {
                        __first18 = false;
                    }
                    __cb.Push("");
                    #line (144,3)-(144,78) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.FirstItems[listElem.FirstItems.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first18) __cb.AppendLine();
                var __first19 = true;
                #line (146,6)-(146,69) 17 "AntlrGenerator.mxg"
                if (listElem.FirstSeparators.Count > listElem.FirstItems.Count)
                #line hidden
                
                {
                    if (__first19)
                    {
                        __first19 = false;
                    }
                    __cb.Push("");
                    #line (147,3)-(147,88) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.FirstSeparators[listElem.FirstSeparators.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first19) __cb.AppendLine();
                var __first20 = true;
                #line (149,6)-(149,42) 17 "AntlrGenerator.mxg"
                if (listElem.RepeatedSeparatorFirst)
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    __cb.Push("");
                    #line (150,2)-(150,3) 33 "AntlrGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (150,4)-(150,40) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedSeparator.AntlrName);
                    #line hidden
                    #line (150,41)-(150,43) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (150,44)-(150,103) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedSeparator.Value).Token.AntlrName);
                    #line hidden
                    #line (150,104)-(150,105) 33 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (150,106)-(150,137) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedItem.AntlrName);
                    #line hidden
                    #line (150,138)-(150,140) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (150,141)-(150,194) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedItem.Value).Rule.AntlrName);
                    #line hidden
                    #line (150,195)-(150,196) 33 "AntlrGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (150,197)-(150,260) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateMultiplicity(listElem.RepeatedBlock.Value.Multiplicity));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (151,6)-(151,10) 17 "AntlrGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first20)
                    {
                        __first20 = false;
                    }
                    __cb.Push("");
                    #line (152,2)-(152,3) 33 "AntlrGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (152,4)-(152,35) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedItem.AntlrName);
                    #line hidden
                    #line (152,36)-(152,38) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (152,39)-(152,92) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedItem.Value).Rule.AntlrName);
                    #line hidden
                    #line (152,93)-(152,94) 33 "AntlrGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (152,95)-(152,131) 32 "AntlrGenerator.mxg"
                    __cb.Write(listElem.RepeatedSeparator.AntlrName);
                    #line hidden
                    #line (152,132)-(152,134) 33 "AntlrGenerator.mxg"
                    __cb.Write("+=");
                    #line hidden
                    #line (152,135)-(152,194) 32 "AntlrGenerator.mxg"
                    __cb.Write(((RuleRef)listElem.RepeatedSeparator.Value).Token.AntlrName);
                    #line hidden
                    #line (152,195)-(152,196) 33 "AntlrGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (152,197)-(152,260) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateMultiplicity(listElem.RepeatedBlock.Value.Multiplicity));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first20) __cb.AppendLine();
                var __first21 = true;
                #line (154,6)-(154,93) 17 "AntlrGenerator.mxg"
                for (int i = 0; i < listElem.LastItems.Count && i < listElem.LastSeparators.Count; ++i)
                #line hidden
                
                {
                    if (__first21)
                    {
                        __first21 = false;
                    }
                    var __first22 = true;
                    #line (155,10)-(155,46) 21 "AntlrGenerator.mxg"
                    if (listElem.RepeatedSeparatorFirst)
                    #line hidden
                    
                    {
                        if (__first22)
                        {
                            __first22 = false;
                        }
                        __cb.Push("");
                        #line (156,3)-(156,56) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (157,3)-(157,51) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    #line (158,10)-(158,14) 21 "AntlrGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first22)
                        {
                            __first22 = false;
                        }
                        __cb.Push("");
                        #line (159,3)-(159,51) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastItems[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                        __cb.Push("");
                        #line (160,3)-(160,56) 36 "AntlrGenerator.mxg"
                        __cb.Write(GenerateParserRuleElement(listElem.LastSeparators[i]));
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first22) __cb.AppendLine();
                }
                if (!__first21) __cb.AppendLine();
                var __first23 = true;
                #line (163,6)-(163,67) 17 "AntlrGenerator.mxg"
                if (listElem.LastItems.Count > listElem.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first23)
                    {
                        __first23 = false;
                    }
                    __cb.Push("");
                    #line (164,3)-(164,76) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.LastItems[listElem.LastItems.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first23) __cb.AppendLine();
                var __first24 = true;
                #line (166,6)-(166,67) 17 "AntlrGenerator.mxg"
                if (listElem.LastSeparators.Count > listElem.LastItems.Count)
                #line hidden
                
                {
                    if (__first24)
                    {
                        __first24 = false;
                    }
                    __cb.Push("");
                    #line (167,3)-(167,86) 32 "AntlrGenerator.mxg"
                    __cb.Write(GenerateParserRuleElement(listElem.LastSeparators[listElem.LastSeparators.Count-1]));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first24) __cb.AppendLine();
            }
            #line (169,2)-(169,6) 13 "AntlrGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                __cb.Push("");
                #line (170,1)-(170,4) 29 "AntlrGenerator.mxg"
                __cb.Write("!!!");
                #line hidden
                #line (170,4)-(170,5) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,5)-(170,11) 29 "AntlrGenerator.mxg"
                __cb.Write("ERROR:");
                #line hidden
                #line (170,11)-(170,12) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,12)-(170,19) 29 "AntlrGenerator.mxg"
                __cb.Write("unknown");
                #line hidden
                #line (170,19)-(170,20) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,20)-(170,25) 29 "AntlrGenerator.mxg"
                __cb.Write("lexer");
                #line hidden
                #line (170,25)-(170,26) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,26)-(170,30) 29 "AntlrGenerator.mxg"
                __cb.Write("rule");
                #line hidden
                #line (170,30)-(170,31) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,31)-(170,38) 29 "AntlrGenerator.mxg"
                __cb.Write("element");
                #line hidden
                #line (170,38)-(170,39) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,39)-(170,43) 29 "AntlrGenerator.mxg"
                __cb.Write("type");
                #line hidden
                #line (170,43)-(170,44) 29 "AntlrGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (170,45)-(170,59) 28 "AntlrGenerator.mxg"
                __cb.Write(elem.GetType());
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first14) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}