#line (1,10)-(1,53) 10 "SemanticsGenerator.mxg"
namespace MetaDslx.Bootstrap.MetaCompiler3.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,44) 13 "SemanticsGenerator.mxg"
    MetaDslx.Bootstrap.MetaCompiler3.Model;
    #line hidden
    #line (4,1)-(4,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,33) 13 "SemanticsGenerator.mxg"
    System.Collections.Generic;
    #line hidden
    #line (5,1)-(5,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "SemanticsGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "SemanticsGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,18) 13 "SemanticsGenerator.mxg"
    System.Linq;
    #line hidden
    
    #line (8,10)-(8,29) 25 "SemanticsGenerator.mxg"
    public partial class RoslynApiGenerator
    #line hidden
    {
        #line (11,9)-(11,40) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitor()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (12,5)-(12,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (12,10)-(12,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (12,11)-(12,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("System;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,5)-(13,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (13,10)-(13,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,11)-(13,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("System.Collections.Immutable;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,5)-(14,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (14,10)-(14,11) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (14,11)-(14,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (16,5)-(16,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (16,14)-(16,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,15)-(16,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (18,5)-(18,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (18,14)-(18,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,16)-(18,25) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (18,26)-(18,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Binding");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (19,5)-(19,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (20,9)-(20,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (20,14)-(20,15) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,15)-(20,23) 25 "SemanticsGenerator.mxg"
            __cb.Write("global::");
            #line hidden
            #line (20,24)-(20,33) 24 "SemanticsGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (20,34)-(20,42) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Syntax;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,9)-(22,15) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (22,15)-(22,16) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,16)-(22,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (22,21)-(22,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,23)-(22,27) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (22,28)-(22,48) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor");
            #line hidden
            #line (22,48)-(22,49) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,49)-(22,50) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (22,50)-(22,51) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,51)-(22,102) 25 "SemanticsGenerator.mxg"
            __cb.Write("MetaDslx.CodeAnalysis.Binding.BinderFactoryVisitor,");
            #line hidden
            #line (22,102)-(22,103) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,103)-(22,104) 25 "SemanticsGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (22,105)-(22,109) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (22,110)-(22,123) 25 "SemanticsGenerator.mxg"
            __cb.Write("SyntaxVisitor");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,9)-(23,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (24,13)-(24,21) 25 "SemanticsGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (24,21)-(24,22) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,23)-(24,27) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (24,28)-(24,92) 25 "SemanticsGenerator.mxg"
            __cb.Write("BinderFactoryVisitor(MetaDslx.CodeAnalysis.Binding.BinderFactory");
            #line hidden
            #line (24,92)-(24,93) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,93)-(24,107) 25 "SemanticsGenerator.mxg"
            __cb.Write("binderFactory)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (25,17)-(25,18) 25 "SemanticsGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (25,18)-(25,19) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,19)-(25,38) 25 "SemanticsGenerator.mxg"
            __cb.Write("base(binderFactory)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (26,13)-(26,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (27,13)-(27,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first75 = true;
            #line (29,14)-(29,50) 13 "SemanticsGenerator.mxg"
            foreach (var rule in RulesAndBlocks)
            #line hidden
            
            {
                if (__first75)
                {
                    __first75 = false;
                }
                var __first76 = true;
                #line (30,18)-(30,56) 17 "SemanticsGenerator.mxg"
                foreach (var alt in rule.Alternatives)
                #line hidden
                
                {
                    if (__first76)
                    {
                        __first76 = false;
                    }
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (32,22)-(32,63) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitRule(rule, alt));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first76) __cb.AppendLine();
            }
            if (!__first75) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (36,13)-(36,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (36,19)-(36,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,20)-(36,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (36,27)-(36,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,28)-(36,32) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (36,32)-(36,33) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,33)-(36,58) 25 "SemanticsGenerator.mxg"
            __cb.Write("VisitSkippedTokensTrivia(");
            #line hidden
            #line (36,59)-(36,63) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (36,64)-(36,89) 25 "SemanticsGenerator.mxg"
            __cb.Write("SkippedTokensTriviaSyntax");
            #line hidden
            #line (36,89)-(36,90) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (36,90)-(36,95) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (37,13)-(37,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (38,13)-(38,14) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (39,9)-(39,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (40,5)-(40,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (43,9)-(43,68) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitRule(Rule rule, Alternative alt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (44,5)-(44,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (44,11)-(44,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,12)-(44,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (44,19)-(44,20) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,20)-(44,24) 25 "SemanticsGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (44,24)-(44,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,25)-(44,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("Visit");
            #line hidden
            #line (44,31)-(44,45) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.CSharpName);
            #line hidden
            #line (44,46)-(44,47) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (44,48)-(44,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(alt.RedName);
            #line hidden
            #line (44,60)-(44,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (44,61)-(44,66) 25 "SemanticsGenerator.mxg"
            __cb.Write("node)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (45,5)-(45,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (46,10)-(46,28) 13 "SemanticsGenerator.mxg"
            var annotIndex = 0;
            #line hidden
            
            #line (47,10)-(47,71) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitAlt(alt, ref annotIndex);
            #line hidden
            
            #line (48,10)-(48,101) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(rule.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("    ");
            #line (49,10)-(49,14) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (50,5)-(50,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (53,9)-(53,76) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitAlt(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (54,6)-(54,72) 13 "SemanticsGenerator.mxg"
            var body = GenerateBinderFactoryVisitElements(alt, ref annotIndex);
            #line hidden
            
            #line (55,6)-(55,96) 13 "SemanticsGenerator.mxg"
            body = GenerateBinderFactoryVisitBinders(alt.Binders, "node", body, false, ref annotIndex);
            #line hidden
            
            __cb.Push("");
            #line (56,6)-(56,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (59,9)-(59,81) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElements(Alternative alt, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first77 = true;
            #line (60,6)-(60,70) 13 "SemanticsGenerator.mxg"
            foreach (var elem in alt.Elements.Where(e => e.ContainsBinders))
            #line hidden
            
            {
                if (__first77)
                {
                    __first77 = false;
                }
                __cb.Push("");
                #line (61,10)-(61,70) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElement(alt, elem, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first77) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (65,9)-(65,136) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinders(IEnumerable<Binder> binders, string nodeName, string body, bool negated, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first78 = true;
            #line (66,6)-(66,82) 13 "SemanticsGenerator.mxg"
            foreach (var binder in binders.Where(b => b.IsNegated == negated).Reverse())
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                #line (67,10)-(67,89) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinder(binder, nodeName, body, ref annotIndex);
                #line hidden
                
            }
            if (!__first78) __cb.AppendLine();
            __cb.Push("");
            #line (69,6)-(69,10) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (72,9)-(72,107) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitBinder(Binder binder, string nodeName, string body, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (73,6)-(73,50) 13 "SemanticsGenerator.mxg"
            var binderVarName = "__annot"+(annotIndex++);
            #line hidden
            
            __cb.Push("");
            #line (74,5)-(74,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (74,8)-(74,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,10)-(74,23) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (74,24)-(74,25) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,25)-(74,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,26)-(74,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,27)-(74,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (74,30)-(74,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,32)-(74,47) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.TypeName);
            #line hidden
            #line (74,48)-(74,49) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (74,50)-(74,77) 24 "SemanticsGenerator.mxg"
            __cb.Write(binder.ConstructorArguments);
            #line hidden
            #line (74,78)-(74,80) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (75,5)-(75,16) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.Begin(");
            #line hidden
            #line (75,17)-(75,30) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (75,31)-(75,32) 25 "SemanticsGenerator.mxg"
            __cb.Write(",");
            #line hidden
            #line (75,32)-(75,33) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (75,34)-(75,42) 24 "SemanticsGenerator.mxg"
            __cb.Write(nodeName);
            #line hidden
            #line (75,43)-(75,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (76,5)-(76,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("try");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (77,5)-(77,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (78,10)-(78,14) 24 "SemanticsGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (79,5)-(79,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (80,5)-(80,12) 25 "SemanticsGenerator.mxg"
            __cb.Write("finally");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (81,5)-(81,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (82,9)-(82,18) 25 "SemanticsGenerator.mxg"
            __cb.Write("this.End(");
            #line hidden
            #line (82,19)-(82,32) 24 "SemanticsGenerator.mxg"
            __cb.Write(binderVarName);
            #line hidden
            #line (82,33)-(82,35) 25 "SemanticsGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (83,5)-(83,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (86,9)-(86,94) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElement(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (87,6)-(87,111) 13 "SemanticsGenerator.mxg"
            var isList = MetaDslx.Bootstrap.MetaCompiler3.Model.MultiplicityExtensions.IsList(elem.Value.Multiplicity);
            #line hidden
            
            #line (88,6)-(88,119) 13 "SemanticsGenerator.mxg"
            var isOptional = MetaDslx.Bootstrap.MetaCompiler3.Model.MultiplicityExtensions.IsOptional(elem.Value.Multiplicity);
            #line hidden
            
            var __first79 = true;
            #line (89,6)-(89,17) 13 "SemanticsGenerator.mxg"
            if (isList)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                #line (90,10)-(90,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (91,10)-(91,86) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitListElements(alt, elem, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (92,10)-(92,96) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (93,6)-(93,46) 13 "SemanticsGenerator.mxg"
            else if (elem.Value is SeparatedList sl)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                #line (94,10)-(94,58) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName+".Node";
                #line hidden
                
                #line (95,10)-(95,99) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitSeparatedListElements(alt, elem, sl, ref annotIndex);
                #line hidden
                
                #line (96,10)-(96,101) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(sl.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                __cb.Push("");
                #line (97,10)-(97,96) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (98,6)-(98,26) 13 "SemanticsGenerator.mxg"
            else if (isOptional)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                #line (99,10)-(99,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (100,9)-(100,11) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (100,11)-(100,12) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (100,12)-(100,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (100,14)-(100,22) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                var __first80 = true;
                #line (100,24)-(100,41) 17 "SemanticsGenerator.mxg"
                if (elem.IsToken)
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    #line (100,42)-(100,46) 33 "SemanticsGenerator.mxg"
                    __cb.Write(".Get");
                    #line hidden
                    #line (100,47)-(100,51) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (100,52)-(100,58) 33 "SemanticsGenerator.mxg"
                    __cb.Write("Kind()");
                    #line hidden
                    #line (100,58)-(100,59) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (100,59)-(100,61) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (100,61)-(100,62) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (100,63)-(100,67) 32 "SemanticsGenerator.mxg"
                    __cb.Write(Lang);
                    #line hidden
                    #line (100,68)-(100,83) 33 "SemanticsGenerator.mxg"
                    __cb.Write("SyntaxKind.None");
                    #line hidden
                }
                #line (100,84)-(100,88) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    #line (100,89)-(100,90) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (100,90)-(100,92) 33 "SemanticsGenerator.mxg"
                    __cb.Write("!=");
                    #line hidden
                    #line (100,92)-(100,93) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (100,93)-(100,97) 33 "SemanticsGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                }
                #line (100,105)-(100,106) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (101,9)-(101,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (102,14)-(102,102) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (103,9)-(103,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (104,6)-(104,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                #line (105,10)-(105,50) 17 "SemanticsGenerator.mxg"
                var elemName = "node."+elem.PropertyName;
                #line hidden
                
                __cb.Push("");
                #line (106,10)-(106,98) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first79) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (110,9)-(110,99) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitListElements(Alternative alt, Element elem, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (111,5)-(111,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (111,8)-(111,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,10)-(111,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (111,29)-(111,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (111,33)-(111,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,34)-(111,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (111,35)-(111,36) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,36)-(111,41) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (111,42)-(111,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (111,60)-(111,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (112,6)-(112,48) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (113,5)-(113,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (113,8)-(113,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,9)-(113,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (113,13)-(113,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,15)-(113,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (113,25)-(113,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,26)-(113,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (113,27)-(113,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,28)-(113,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (113,30)-(113,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,32)-(113,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (113,42)-(113,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,43)-(113,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (113,44)-(113,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,46)-(113,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (113,65)-(113,76) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (113,76)-(113,77) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (113,77)-(113,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (113,80)-(113,89) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (113,90)-(113,91) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (114,5)-(114,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (115,10)-(115,68) 13 "SemanticsGenerator.mxg"
            var elemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            __cb.Push("    ");
            #line (116,10)-(116,99) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, elem.Value, false, ref annotIndex));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (117,5)-(117,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (120,9)-(120,128) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListElements(Alternative alt, Element elem, SeparatedList list, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (121,5)-(121,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (121,8)-(121,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,10)-(121,28) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (121,29)-(121,33) 25 "SemanticsGenerator.mxg"
            __cb.Write("List");
            #line hidden
            #line (121,33)-(121,34) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,34)-(121,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (121,35)-(121,36) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,36)-(121,41) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (121,42)-(121,59) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (121,60)-(121,61) 25 "SemanticsGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (122,6)-(122,48) 13 "SemanticsGenerator.mxg"
            var indexName = elem.ParameterName+"Index";
            #line hidden
            
            __cb.Push("");
            #line (123,5)-(123,8) 25 "SemanticsGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (123,8)-(123,9) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,9)-(123,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(var");
            #line hidden
            #line (123,13)-(123,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,15)-(123,24) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (123,25)-(123,26) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,26)-(123,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (123,27)-(123,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,28)-(123,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("0;");
            #line hidden
            #line (123,30)-(123,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,32)-(123,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (123,42)-(123,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,43)-(123,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (123,44)-(123,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,46)-(123,64) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.ParameterName);
            #line hidden
            #line (123,65)-(123,76) 25 "SemanticsGenerator.mxg"
            __cb.Write("List.Count;");
            #line hidden
            #line (123,76)-(123,77) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,77)-(123,79) 25 "SemanticsGenerator.mxg"
            __cb.Write("++");
            #line hidden
            #line (123,80)-(123,89) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (123,90)-(123,91) 25 "SemanticsGenerator.mxg"
            __cb.Write(")");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (124,5)-(124,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (125,9)-(125,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (125,13)-(125,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,14)-(125,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("__itemHandled");
            #line hidden
            #line (125,27)-(125,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,28)-(125,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (125,29)-(125,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,30)-(125,36) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (126,9)-(126,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("bool");
            #line hidden
            #line (126,13)-(126,14) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,14)-(126,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("__sepHandled");
            #line hidden
            #line (126,26)-(126,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,27)-(126,28) 25 "SemanticsGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (126,28)-(126,29) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,29)-(126,35) 25 "SemanticsGenerator.mxg"
            __cb.Write("false;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (127,10)-(127,68) 13 "SemanticsGenerator.mxg"
            var itemName = "node."+elem.PropertyName+"["+indexName+"]";
            #line hidden
            
            #line (128,10)-(128,80) 13 "SemanticsGenerator.mxg"
            var sepName = "node."+elem.PropertyName+".GetSeparator("+indexName+")";
            #line hidden
            
            #line (129,10)-(129,93) 13 "SemanticsGenerator.mxg"
            var firstCount = System.Math.Max(list.FirstItems.Count, list.FirstSeparators.Count);
            #line hidden
            
            #line (130,10)-(130,90) 13 "SemanticsGenerator.mxg"
            var lastCount = System.Math.Min(list.LastItems.Count, list.LastSeparators.Count);
            #line hidden
            
            #line (131,10)-(131,25) 13 "SemanticsGenerator.mxg"
            var ifElse = "";
            #line hidden
            
            var __first81 = true;
            #line (132,10)-(132,50) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < firstCount - 1; ++i)
            #line hidden
            
            {
                if (__first81)
                {
                    __first81 = false;
                }
                __cb.Push("    ");
                #line (133,14)-(133,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (133,21)-(133,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (133,23)-(133,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (133,24)-(133,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (133,26)-(133,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (133,36)-(133,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (133,37)-(133,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (133,39)-(133,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (133,41)-(133,42) 28 "SemanticsGenerator.mxg"
                __cb.Write(i);
                #line hidden
                #line (133,43)-(133,44) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (134,13)-(134,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (135,18)-(135,162) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.FirstItems[i], sepName, list.FirstSeparators[i], list.SeparatorFirst, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (136,17)-(136,30) 29 "SemanticsGenerator.mxg"
                __cb.Write("__itemHandled");
                #line hidden
                #line (136,30)-(136,31) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (136,31)-(136,32) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (136,32)-(136,33) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (136,33)-(136,38) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (137,17)-(137,29) 29 "SemanticsGenerator.mxg"
                __cb.Write("__sepHandled");
                #line hidden
                #line (137,29)-(137,30) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (137,30)-(137,31) 29 "SemanticsGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (137,31)-(137,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (137,32)-(137,37) 29 "SemanticsGenerator.mxg"
                __cb.Write("true;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (138,13)-(138,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (139,14)-(139,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first81) __cb.AppendLine();
            var __first82 = true;
            #line (141,10)-(141,29) 13 "SemanticsGenerator.mxg"
            if (firstCount > 0)
            #line hidden
            
            {
                if (__first82)
                {
                    __first82 = false;
                }
                __cb.Push("    ");
                #line (142,14)-(142,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (142,21)-(142,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (142,23)-(142,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,24)-(142,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (142,26)-(142,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (142,36)-(142,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,37)-(142,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (142,39)-(142,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,41)-(142,53) 28 "SemanticsGenerator.mxg"
                __cb.Write(firstCount-1);
                #line hidden
                #line (142,54)-(142,55) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (143,13)-(143,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first83 = true;
                #line (144,18)-(144,42) 17 "SemanticsGenerator.mxg"
                if (list.SeparatorFirst)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("        ");
                    #line (145,22)-(145,169) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.FirstSeparators[firstCount-1], list.FirstSeparators[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (146,21)-(146,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (146,33)-(146,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,34)-(146,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (146,35)-(146,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (146,36)-(146,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (147,18)-(147,22) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("        ");
                    #line (148,22)-(148,160) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.FirstItems[firstCount-1], list.FirstItems[firstCount-1].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (149,21)-(149,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (149,34)-(149,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,35)-(149,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (149,36)-(149,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (149,37)-(149,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first83) __cb.AppendLine();
                __cb.Push("    ");
                #line (151,13)-(151,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (152,14)-(152,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first82) __cb.AppendLine();
            var __first84 = true;
            #line (154,10)-(154,45) 13 "SemanticsGenerator.mxg"
            for (int i = 0; i < lastCount; ++i)
            #line hidden
            
            {
                if (__first84)
                {
                    __first84 = false;
                }
                __cb.Push("    ");
                #line (155,14)-(155,20) 28 "SemanticsGenerator.mxg"
                __cb.Write(ifElse);
                #line hidden
                #line (155,21)-(155,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (155,23)-(155,24) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (155,24)-(155,25) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (155,26)-(155,35) 28 "SemanticsGenerator.mxg"
                __cb.Write(indexName);
                #line hidden
                #line (155,36)-(155,37) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (155,37)-(155,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("==");
                #line hidden
                #line (155,39)-(155,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (155,41)-(155,59) 28 "SemanticsGenerator.mxg"
                __cb.Write(elem.ParameterName);
                #line hidden
                #line (155,60)-(155,70) 29 "SemanticsGenerator.mxg"
                __cb.Write("List.Count");
                #line hidden
                #line (155,70)-(155,71) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (155,71)-(155,72) 29 "SemanticsGenerator.mxg"
                __cb.Write("-");
                #line hidden
                #line (155,72)-(155,73) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (155,74)-(155,87) 28 "SemanticsGenerator.mxg"
                __cb.Write(lastCount - i);
                #line hidden
                #line (155,88)-(155,89) 29 "SemanticsGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (156,13)-(156,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (157,18)-(157,43) 17 "SemanticsGenerator.mxg"
                var j = lastCount - 1 - i;
                #line hidden
                
                var __first85 = true;
                #line (158,18)-(158,80) 17 "SemanticsGenerator.mxg"
                if (j < list.LastItems.Count && j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first85)
                    {
                        __first85 = false;
                    }
                    __cb.Push("        ");
                    #line (159,22)-(159,172) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitSeparatedListItem(itemName, list.LastItems[j], sepName, list.LastSeparators[j], list.RepeatedSeparatorFirst, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (160,21)-(160,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (160,34)-(160,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,35)-(160,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (160,36)-(160,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,37)-(160,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (161,21)-(161,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (161,33)-(161,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,34)-(161,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (161,35)-(161,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (161,36)-(161,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (162,18)-(162,52) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastItems.Count)
                #line hidden
                
                {
                    if (__first85)
                    {
                        __first85 = false;
                    }
                    __cb.Push("        ");
                    #line (163,22)-(163,136) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, list.LastItems[j], list.LastItems[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (164,21)-(164,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__itemHandled");
                    #line hidden
                    #line (164,34)-(164,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (164,35)-(164,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (164,36)-(164,37) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (164,37)-(164,42) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (165,18)-(165,57) 17 "SemanticsGenerator.mxg"
                else if (j < list.LastSeparators.Count)
                #line hidden
                
                {
                    if (__first85)
                    {
                        __first85 = false;
                    }
                    __cb.Push("        ");
                    #line (166,22)-(166,145) 32 "SemanticsGenerator.mxg"
                    __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, list.LastSeparators[j], list.LastSeparators[j].Value, true, ref annotIndex));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("        ");
                    #line (167,21)-(167,33) 33 "SemanticsGenerator.mxg"
                    __cb.Write("__sepHandled");
                    #line hidden
                    #line (167,33)-(167,34) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,34)-(167,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (167,35)-(167,36) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,36)-(167,41) 33 "SemanticsGenerator.mxg"
                    __cb.Write("true;");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (168,18)-(168,22) 17 "SemanticsGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first85)
                    {
                        __first85 = false;
                    }
                    __cb.Push("        ");
                    #line (169,21)-(169,29) 33 "SemanticsGenerator.mxg"
                    __cb.Write("INTERNAL");
                    #line hidden
                    #line (169,29)-(169,30) 33 "SemanticsGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (169,30)-(169,35) 33 "SemanticsGenerator.mxg"
                    __cb.Write("ERROR");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first85) __cb.AppendLine();
                __cb.Push("    ");
                #line (171,13)-(171,14) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (172,14)-(172,30) 17 "SemanticsGenerator.mxg"
                ifElse = "else ";
                #line hidden
                
            }
            if (!__first84) __cb.AppendLine();
            __cb.Push("    ");
            #line (174,9)-(174,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (174,11)-(174,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,12)-(174,27) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__itemHandled");
            #line hidden
            #line (174,27)-(174,28) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,28)-(174,30) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (174,30)-(174,31) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,32)-(174,41) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (174,42)-(174,43) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,43)-(174,44) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (174,44)-(174,45) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,45)-(174,50) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (174,51)-(174,68) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (174,69)-(174,76) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Count)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (175,9)-(175,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (176,14)-(176,146) 13 "SemanticsGenerator.mxg"
            var repItemBody = GenerateBinderFactoryVisitElementValue(itemName, list.RepeatedItem, list.RepeatedItem.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (177,14)-(177,121) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repItemBody, false, ref annotIndex));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (178,9)-(178,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (179,9)-(179,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (179,11)-(179,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,12)-(179,26) 25 "SemanticsGenerator.mxg"
            __cb.Write("(!__sepHandled");
            #line hidden
            #line (179,26)-(179,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,27)-(179,29) 25 "SemanticsGenerator.mxg"
            __cb.Write("&&");
            #line hidden
            #line (179,29)-(179,30) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,31)-(179,40) 24 "SemanticsGenerator.mxg"
            __cb.Write(indexName);
            #line hidden
            #line (179,41)-(179,42) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,42)-(179,43) 25 "SemanticsGenerator.mxg"
            __cb.Write("<");
            #line hidden
            #line (179,43)-(179,44) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (179,44)-(179,49) 25 "SemanticsGenerator.mxg"
            __cb.Write("node.");
            #line hidden
            #line (179,50)-(179,67) 24 "SemanticsGenerator.mxg"
            __cb.Write(elem.PropertyName);
            #line hidden
            #line (179,68)-(179,84) 25 "SemanticsGenerator.mxg"
            __cb.Write(".SeparatorCount)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (180,9)-(180,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (181,14)-(181,154) 13 "SemanticsGenerator.mxg"
            var repSepBody = GenerateBinderFactoryVisitElementValue(sepName, list.RepeatedSeparator, list.RepeatedSeparator.Value, true, ref annotIndex);
            #line hidden
            
            __cb.Push("        ");
            #line (182,14)-(182,120) 24 "SemanticsGenerator.mxg"
            __cb.Write(GenerateBinderFactoryVisitBinders(list.RepeatedBlock.Binders, itemName, repSepBody, false, ref annotIndex));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (183,9)-(183,10) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (184,5)-(184,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (187,9)-(187,162) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitSeparatedListItem(string itemName, Element itemElem, string sepName, Element sepElem, bool separatorFirst, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first86 = true;
            #line (188,6)-(188,25) 13 "SemanticsGenerator.mxg"
            if (separatorFirst)
            #line hidden
            
            {
                if (__first86)
                {
                    __first86 = false;
                }
                __cb.Push("");
                #line (189,10)-(189,103) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (190,10)-(190,106) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (191,6)-(191,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first86)
                {
                    __first86 = false;
                }
                __cb.Push("");
                #line (192,10)-(192,106) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(itemName, itemElem, itemElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (193,10)-(193,103) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(sepName, sepElem, sepElem.Value, true, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first86) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (197,9)-(197,145) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementValue(string elemName, Element elem, ElementValue elemValue, bool withElemBinders, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first87 = true;
            #line (198,6)-(198,38) 13 "SemanticsGenerator.mxg"
            if (elemValue is TokenAlts alts)
            #line hidden
            
            {
                if (__first87)
                {
                    __first87 = false;
                }
                __cb.Push("");
                #line (199,9)-(199,11) 29 "SemanticsGenerator.mxg"
                __cb.Write("if");
                #line hidden
                #line (199,11)-(199,12) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,12)-(199,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (199,14)-(199,22) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (199,23)-(199,27) 29 "SemanticsGenerator.mxg"
                __cb.Write(".Get");
                #line hidden
                #line (199,28)-(199,32) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (199,33)-(199,39) 29 "SemanticsGenerator.mxg"
                __cb.Write("Kind()");
                #line hidden
                #line (199,39)-(199,40) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,40)-(199,42) 29 "SemanticsGenerator.mxg"
                __cb.Write("!=");
                #line hidden
                #line (199,42)-(199,43) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (199,44)-(199,48) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (199,49)-(199,65) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.None)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (200,9)-(200,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (201,14)-(201,98) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitTokenAlts(elemName, elem, alts, ref annotIndex);
                #line hidden
                
                #line (202,14)-(202,107) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first88 = true;
                #line (203,14)-(203,34) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first88)
                    {
                        __first88 = false;
                    }
                    #line (204,18)-(204,111) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first88) __cb.AppendLine();
                __cb.Push("    ");
                #line (206,14)-(206,18) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (207,9)-(207,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (208,9)-(208,13) 29 "SemanticsGenerator.mxg"
                __cb.Write("else");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (209,9)-(209,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (210,14)-(210,114) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(alts.Binders, elemName, "// default", true, ref annotIndex);
                #line hidden
                
                var __first89 = true;
                #line (211,14)-(211,34) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first89)
                    {
                        __first89 = false;
                    }
                    #line (212,18)-(212,110) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, true, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first89) __cb.AppendLine();
                __cb.Push("    ");
                #line (214,14)-(214,18) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (215,9)-(215,10) 29 "SemanticsGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (216,6)-(216,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first87)
                {
                    __first87 = false;
                }
                #line (217,10)-(217,95) 17 "SemanticsGenerator.mxg"
                var body = GenerateBinderFactoryVisitElementBody(elemName, elemValue, ref annotIndex);
                #line hidden
                
                #line (218,10)-(218,108) 17 "SemanticsGenerator.mxg"
                body = GenerateBinderFactoryVisitBinders(elemValue.Binders, elemName, body, false, ref annotIndex);
                #line hidden
                
                var __first90 = true;
                #line (219,10)-(219,30) 17 "SemanticsGenerator.mxg"
                if (withElemBinders)
                #line hidden
                
                {
                    if (__first90)
                    {
                        __first90 = false;
                    }
                    #line (220,14)-(220,107) 21 "SemanticsGenerator.mxg"
                    body = GenerateBinderFactoryVisitBinders(elem.Binders, elemName, body, false, ref annotIndex);
                    #line hidden
                    
                }
                if (!__first90) __cb.AppendLine();
                __cb.Push("");
                #line (222,10)-(222,14) 28 "SemanticsGenerator.mxg"
                __cb.Write(body);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first87) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (226,9)-(226,112) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitTokenAlts(string elemName, Element elem, TokenAlts alts, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (227,5)-(227,11) 25 "SemanticsGenerator.mxg"
            __cb.Write("switch");
            #line hidden
            #line (227,11)-(227,12) 25 "SemanticsGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (227,12)-(227,13) 25 "SemanticsGenerator.mxg"
            __cb.Write("(");
            #line hidden
            #line (227,14)-(227,22) 24 "SemanticsGenerator.mxg"
            __cb.Write(elemName);
            #line hidden
            #line (227,23)-(227,27) 25 "SemanticsGenerator.mxg"
            __cb.Write(".Get");
            #line hidden
            #line (227,28)-(227,32) 24 "SemanticsGenerator.mxg"
            __cb.Write(Lang);
            #line hidden
            #line (227,33)-(227,40) 25 "SemanticsGenerator.mxg"
            __cb.Write("Kind())");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (228,5)-(228,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first91 = true;
            #line (229,10)-(229,42) 13 "SemanticsGenerator.mxg"
            foreach (var alt in alts.Tokens)
            #line hidden
            
            {
                if (__first91)
                {
                    __first91 = false;
                }
                __cb.Push("    ");
                #line (230,13)-(230,17) 29 "SemanticsGenerator.mxg"
                __cb.Write("case");
                #line hidden
                #line (230,17)-(230,18) 29 "SemanticsGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (230,19)-(230,23) 28 "SemanticsGenerator.mxg"
                __cb.Write(Lang);
                #line hidden
                #line (230,24)-(230,35) 29 "SemanticsGenerator.mxg"
                __cb.Write("SyntaxKind.");
                #line hidden
                #line (230,36)-(230,56) 28 "SemanticsGenerator.mxg"
                __cb.Write(alt.Token.CSharpName);
                #line hidden
                #line (230,57)-(230,58) 29 "SemanticsGenerator.mxg"
                __cb.Write(":");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (231,18)-(231,100) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitElementValue(elemName, elem, alt, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (232,17)-(232,23) 29 "SemanticsGenerator.mxg"
                __cb.Write("break;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first91) __cb.AppendLine();
            __cb.Push("    ");
            #line (234,9)-(234,17) 25 "SemanticsGenerator.mxg"
            __cb.Write("default:");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (235,13)-(235,19) 25 "SemanticsGenerator.mxg"
            __cb.Write("break;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (236,5)-(236,6) 25 "SemanticsGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (239,9)-(239,108) 22 "SemanticsGenerator.mxg"
        public string GenerateBinderFactoryVisitElementBody(string elemName, ElementValue elemValue, ref int annotIndex)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first92 = true;
            #line (240,6)-(240,58) 13 "SemanticsGenerator.mxg"
            if (elemValue is RuleRef rr && rr.Token is not null)
            #line hidden
            
            {
                if (__first92)
                {
                    __first92 = false;
                }
                #line (241,10)-(241,55) 17 "SemanticsGenerator.mxg"
                var body = "//this.VisitToken("+elemName+");";
                #line hidden
                
                __cb.Push("");
                #line (242,10)-(242,100) 28 "SemanticsGenerator.mxg"
                __cb.Write(GenerateBinderFactoryVisitBinders(rr.Token.Binders, elemName, body, false, ref annotIndex));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (243,6)-(243,10) 13 "SemanticsGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first92)
                {
                    __first92 = false;
                }
                __cb.Push("");
                #line (244,9)-(244,20) 29 "SemanticsGenerator.mxg"
                __cb.Write("this.Visit(");
                #line hidden
                #line (244,21)-(244,29) 28 "SemanticsGenerator.mxg"
                __cb.Write(elemName);
                #line hidden
                #line (244,30)-(244,32) 29 "SemanticsGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first92) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}