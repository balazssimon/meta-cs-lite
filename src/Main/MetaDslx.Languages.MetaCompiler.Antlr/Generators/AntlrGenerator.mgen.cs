#line (1,10)-(1,59) 10 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
namespace MetaDslx.Languages.MetaCompiler.Antlr.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
    MetaDslx.Languages.MetaCompiler.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
    using
    #line hidden
    global::
    #line (5,7)-(5,18) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
    System.Linq;
    #line hidden
    
    #line (7,10)-(7,25) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
    public partial class AntlrGenerator
    #line hidden
    {
        #line (9,9)-(9,42) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateLexer(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (10,1)-(10,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("lexer");
            #line hidden
            #line (10,6)-(10,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (10,7)-(10,14) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("grammar");
            #line hidden
            #line (10,14)-(10,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (10,16)-(10,29) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (10,30)-(10,36) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("Lexer;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first197 = true;
            #line (12,2)-(12,56) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            foreach (var rule in language.Grammar.FixedLexerRules)
            #line hidden
            
            {
                if (__first197)
                {
                    __first197 = false;
                }
                __cb.Push("");
                #line (13,2)-(13,25) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateLexerRule(rule));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first197) __cb.AppendLine();
            var __first198 = true;
            #line (15,2)-(15,59) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            foreach (var rule in language.Grammar.NonFixedLexerRules)
            #line hidden
            
            {
                if (__first198)
                {
                    __first198 = false;
                }
                __cb.Push("");
                #line (16,2)-(16,25) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateLexerRule(rule));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first198) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (20,9)-(20,43) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateLexerRule(LexerRule rule)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (21,2)-(21,36) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(rule.IsFragment ? "fragment " : "");
            #line hidden
            #line (21,38)-(21,52) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(rule.AntlrName);
            #line hidden
            #line (21,53)-(21,54) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(":");
            #line hidden
            #line (21,54)-(21,55) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (21,56)-(21,96) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(GenerateLexerRuleAlts(rule.Alternatives));
            #line hidden
            #line (21,98)-(21,140) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(rule.IsHidden ? " -> channel(HIDDEN)" : "");
            #line hidden
            #line (21,141)-(21,142) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (24,9)-(24,72) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateLexerRuleAlts(List<LexerRuleAlternative> alternatives)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first199 = true;
            #line (26,2)-(26,36) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            foreach (var alt in alternatives) 
            #line hidden
            
            {
                if (__first199)
                {
                    __first199 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (26,46)-(26,51) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(" | ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (27,2)-(27,32) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateLexerRuleElements(alt));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first199) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (31,9)-(31,61) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateLexerRuleElements(LexerRuleAlternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first200 = true;
            #line (33,2)-(33,37) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            foreach (var elem in alt.Elements) 
            #line hidden
            
            {
                if (__first200)
                {
                    __first200 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (33,47)-(33,50) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (34,2)-(34,27) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (34,29)-(34,59) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateLexerRuleElement(elem));
                #line hidden
                #line (34,61)-(34,100) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateMultiplicity(elem.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first200) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (38,9)-(38,57) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateLexerRuleElement(LexerRuleElement elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first201 = true;
            #line (40,2)-(40,52) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            if (elem is LexerRuleReferenceElement ruleRefElem)
            #line hidden
            
            {
                if (__first201)
                {
                    __first201 = false;
                }
                __cb.Push("");
                #line (41,2)-(41,28) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(ruleRefElem.Rule.AntlrName);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (42,2)-(42,57) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is LexerRuleFixedStringElement fixedElem)
            #line hidden
            
            {
                if (__first201)
                {
                    __first201 = false;
                }
                __cb.Push("");
                #line (43,2)-(43,21) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(fixedElem.ValueText);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (44,2)-(44,57) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is LexerRuleWildcardElement wildcardElem)
            #line hidden
            
            {
                if (__first201)
                {
                    __first201 = false;
                }
                __cb.Push("");
                #line (45,1)-(45,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(".");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (46,2)-(46,51) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is LexerRuleBlockElement blockElem)
            #line hidden
            
            {
                if (__first201)
                {
                    __first201 = false;
                }
                __cb.Push("");
                #line (47,1)-(47,2) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("(");
                #line hidden
                #line (47,3)-(47,48) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateLexerRuleAlts(blockElem.Alternatives));
                #line hidden
                #line (47,49)-(47,50) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(")");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (48,2)-(48,51) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is LexerRuleRangeElement rangeElem)
            #line hidden
            
            {
                if (__first201)
                {
                    __first201 = false;
                }
                __cb.Push("");
                #line (49,2)-(49,21) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(rangeElem.StartText);
                #line hidden
                #line (49,22)-(49,24) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("..");
                #line hidden
                #line (49,25)-(49,42) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(rangeElem.EndText);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (50,2)-(50,6) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else
            #line hidden
            
            {
                if (__first201)
                {
                    __first201 = false;
                }
                __cb.Push("");
                #line (51,1)-(51,4) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("!!!");
                #line hidden
                #line (51,4)-(51,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,5)-(51,11) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("ERROR:");
                #line hidden
                #line (51,11)-(51,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,12)-(51,19) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("unknown");
                #line hidden
                #line (51,19)-(51,20) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,20)-(51,25) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("lexer");
                #line hidden
                #line (51,25)-(51,26) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,26)-(51,30) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("rule");
                #line hidden
                #line (51,30)-(51,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,31)-(51,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("element");
                #line hidden
                #line (51,38)-(51,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,39)-(51,43) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("type");
                #line hidden
                #line (51,43)-(51,44) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (51,45)-(51,59) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.GetType());
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first201) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (55,9)-(55,57) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateMultiplicity(Multiplicity multiplicity)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            __cb.Push("");
            var __first202 = true;
            #line (57,2)-(57,45) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            if (multiplicity == Multiplicity.ZeroOrOne)
            #line hidden
            
            {
                if (__first202)
                {
                    __first202 = false;
                }
                #line (57,46)-(57,47) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (58,2)-(58,51) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (multiplicity == Multiplicity.ZeroOrMore)
            #line hidden
            
            {
                if (__first202)
                {
                    __first202 = false;
                }
                #line (58,52)-(58,53) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("*");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (59,2)-(59,50) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (multiplicity == Multiplicity.OneOrMore)
            #line hidden
            
            {
                if (__first202)
                {
                    __first202 = false;
                }
                #line (59,51)-(59,52) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("+");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (60,2)-(60,59) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (multiplicity == Multiplicity.NonGreedyZeroOrOne)
            #line hidden
            
            {
                if (__first202)
                {
                    __first202 = false;
                }
                #line (60,60)-(60,62) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("??");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (61,2)-(61,60) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (multiplicity == Multiplicity.NonGreedyZeroOrMore)
            #line hidden
            
            {
                if (__first202)
                {
                    __first202 = false;
                }
                #line (61,61)-(61,63) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("*?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
            }
            #line (62,2)-(62,59) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (multiplicity == Multiplicity.NonGreedyOneOrMore)
            #line hidden
            
            {
                if (__first202)
                {
                    __first202 = false;
                }
                #line (62,60)-(62,62) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("+?");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first202) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (66,9)-(66,55) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateAssignment(Multiplicity multiplicity)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first203 = true;
            #line (68,2)-(68,28) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            if (multiplicity.IsList())
            #line hidden
            
            {
                if (__first203)
                {
                    __first203 = false;
                }
                #line (68,29)-(68,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("+=");
                #line hidden
            }
            #line (68,32)-(68,36) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else
            #line hidden
            
            {
                if (__first203)
                {
                    __first203 = false;
                }
                #line (68,37)-(68,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("=");
                #line hidden
            }
            if (!__first203) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (72,9)-(72,43) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateParser(Language language)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (73,1)-(73,7) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("parser");
            #line hidden
            #line (73,7)-(73,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,8)-(73,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("grammar");
            #line hidden
            #line (73,15)-(73,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (73,17)-(73,30) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (73,31)-(73,38) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("Parser;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (75,1)-(75,8) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("options");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (76,1)-(76,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (77,5)-(77,15) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("tokenVocab");
            #line hidden
            #line (77,15)-(77,16) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (77,16)-(77,17) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("=");
            #line hidden
            #line (77,17)-(77,18) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            #line (77,19)-(77,32) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(language.Name);
            #line hidden
            #line (77,33)-(77,39) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("Lexer;");
            #line hidden
            #line (77,39)-(77,40) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (78,1)-(78,2) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write("}");
            #line hidden
            #line (78,2)-(78,3) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            __cb.WriteLine();
            __cb.Pop();
            var __first204 = true;
            #line (80,2)-(80,52) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            foreach (var rule in language.Grammar.ParserRules)
            #line hidden
            
            {
                if (__first204)
                {
                    __first204 = false;
                }
                __cb.Push("");
                #line (81,2)-(81,26) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateParserRule(rule));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first204) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (85,9)-(85,45) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateParserRule(ParserRule rule)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (86,2)-(86,16) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(rule.AntlrName);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (87,6)-(87,47) 24 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(GenerateParserRuleAlts(rule.Alternatives));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (88,5)-(88,6) 25 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (91,9)-(91,74) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateParserRuleAlts(List<ParserRuleAlternative> alternatives)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (92,2)-(92,15) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            var sep = ":";
            #line hidden
            
            var __first205 = true;
            #line (93,2)-(93,35) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            foreach (var alt in alternatives)
            #line hidden
            
            {
                if (__first205)
                {
                    __first205 = false;
                }
                #line (94,2)-(94,5) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(sep);
                #line hidden
                #line (94,6)-(94,7) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (94,8)-(94,39) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateParserRuleElements(alt));
                #line hidden
                var __first206 = true;
                #line (94,41)-(94,68) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                if (alternatives.Count > 1)
                #line hidden
                
                {
                    if (__first206)
                    {
                        __first206 = false;
                    }
                    #line (94,69)-(94,70) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    #line (94,70)-(94,71) 33 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write("#");
                    #line hidden
                    #line (94,72)-(94,85) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(alt.AntlrName);
                    #line hidden
                }
                if (!__first206) __cb.AppendLine();
                #line (95,2)-(95,11) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                sep = "|";
                #line hidden
                
            }
            if (!__first205) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (99,9)-(99,63) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateParserRuleElements(ParserRuleAlternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first207 = true;
            #line (101,2)-(101,37) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            foreach (var elem in alt.Elements) 
            #line hidden
            
            {
                if (__first207)
                {
                    __first207 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (101,47)-(101,50) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(" ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (102,2)-(102,33) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateParserRuleElement(elem));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first207) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (106,9)-(106,59) 22 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
        public string GenerateParserRuleElement(ParserRuleElement elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first208 = true;
            #line (108,2)-(108,53) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            if (elem is ParserRuleReferenceElement ruleRefElem)
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                __cb.Push("");
                #line (109,3)-(109,17) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (109,19)-(109,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateAssignment(elem.Multiplicity));
                #line hidden
                #line (109,58)-(109,83) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (109,85)-(109,111) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(ruleRefElem.Rule.AntlrName);
                #line hidden
                #line (109,113)-(109,152) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateMultiplicity(elem.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (110,2)-(110,48) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is ParserRuleEofElement eofElem)
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                __cb.Push("");
                #line (111,3)-(111,17) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (111,19)-(111,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateAssignment(elem.Multiplicity));
                #line hidden
                #line (111,57)-(111,60) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("EOF");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (112,2)-(112,58) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is ParserRuleFixedStringElement fixedElem)
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                __cb.Push("");
                #line (113,3)-(113,17) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (113,19)-(113,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateAssignment(elem.Multiplicity));
                #line hidden
                #line (113,58)-(113,83) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (113,85)-(113,114) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(fixedElem.LexerRule.AntlrName);
                #line hidden
                #line (113,116)-(113,155) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateMultiplicity(elem.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (114,2)-(114,74) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is ParserRuleFixedStringAlternativesElement fixedAltsElem)
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                __cb.Push("");
                #line (115,3)-(115,28) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (115,29)-(115,30) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("(");
                #line hidden
                var __first209 = true;
                #line (115,31)-(115,84) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                foreach (var fixedAlt in fixedAltsElem.Alternatives) 
                #line hidden
                
                {
                    if (__first209)
                    {
                        __first209 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (115,94)-(115,99) 36 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                        __cb.Write(" | ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (115,101)-(115,136) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(GenerateParserRuleElement(fixedAlt));
                    #line hidden
                }
                #line (115,150)-(115,151) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(")");
                #line hidden
                #line (115,152)-(115,191) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateMultiplicity(elem.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (116,2)-(116,58) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is ParserRuleWildcardElement wildcardElem)
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                __cb.Push("");
                #line (117,3)-(117,17) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (117,19)-(117,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateAssignment(elem.Multiplicity));
                #line hidden
                #line (117,58)-(117,83) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (117,84)-(117,85) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(".");
                #line hidden
                #line (117,86)-(117,125) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateMultiplicity(elem.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (118,2)-(118,52) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is ParserRuleBlockElement blockElem)
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                __cb.Push("");
                #line (119,3)-(119,17) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.AntlrName);
                #line hidden
                #line (119,19)-(119,56) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateAssignment(elem.Multiplicity));
                #line hidden
                #line (119,58)-(119,83) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.IsNegated ? "~" : "");
                #line hidden
                #line (119,84)-(119,85) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("(");
                #line hidden
                #line (119,86)-(119,132) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateParserRuleAlts(blockElem.Alternatives));
                #line hidden
                #line (119,133)-(119,134) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(")");
                #line hidden
                #line (119,135)-(119,174) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateMultiplicity(elem.Multiplicity));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            #line (120,2)-(120,50) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else if (elem is ParserRuleListElement listElem)
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                var __first210 = true;
                #line (121,6)-(121,110) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                if (listElem.ListKind == ListKind.WithFirstItem || listElem.ListKind == ListKind.WithFirstItemSeparator)
                #line hidden
                
                {
                    if (__first210)
                    {
                        __first210 = false;
                    }
                    __cb.Push("");
                    #line (122,3)-(122,48) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(GenerateParserRuleElement(listElem.FirstItem));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first210) __cb.AppendLine();
                __cb.Push("");
                #line (124,3)-(124,51) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(GenerateParserRuleElement(listElem.RepeatedRule));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first211 = true;
                #line (125,6)-(125,108) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                if (listElem.ListKind == ListKind.WithLastItem || listElem.ListKind == ListKind.WithLastItemSeparator)
                #line hidden
                
                {
                    if (__first211)
                    {
                        __first211 = false;
                    }
                    __cb.Push("");
                    #line (126,3)-(126,47) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(GenerateParserRuleElement(listElem.LastItem));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first211) __cb.AppendLine();
                var __first212 = true;
                #line (128,6)-(128,118) 17 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                if (listElem.ListKind == ListKind.WithFirstItemSeparator || listElem.ListKind == ListKind.WithLastItemSeparator)
                #line hidden
                
                {
                    if (__first212)
                    {
                        __first212 = false;
                    }
                    __cb.Push("");
                    #line (129,3)-(129,52) 32 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                    __cb.Write(GenerateParserRuleElement(listElem.LastSeparator));
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first212) __cb.AppendLine();
            }
            #line (131,2)-(131,6) 13 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
            else
            #line hidden
            
            {
                if (__first208)
                {
                    __first208 = false;
                }
                __cb.Push("");
                #line (132,1)-(132,4) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("!!!");
                #line hidden
                #line (132,4)-(132,5) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (132,5)-(132,11) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("ERROR:");
                #line hidden
                #line (132,11)-(132,12) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (132,12)-(132,19) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("unknown");
                #line hidden
                #line (132,19)-(132,20) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (132,20)-(132,25) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("lexer");
                #line hidden
                #line (132,25)-(132,26) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (132,26)-(132,30) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("rule");
                #line hidden
                #line (132,30)-(132,31) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (132,31)-(132,38) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("element");
                #line hidden
                #line (132,38)-(132,39) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (132,39)-(132,43) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write("type");
                #line hidden
                #line (132,43)-(132,44) 29 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(" ");
                #line hidden
                #line (132,45)-(132,59) 28 "C:\Users\Balazs\source\repos\meta-cs-lite\src\Main\MetaDslx.Languages.MetaCompiler.Antlr\Generators\AntlrGenerator.mgen"
                __cb.Write(elem.GetType());
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first208) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}