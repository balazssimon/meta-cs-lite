#line (1,10)-(1,43) 10 "UmlModelToMetaModelGenerator.mxg"
namespace MetaDslx.Languages.Uml.Generator
#line hidden

{
    #line (3,1)-(3,6) 5 "UmlModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,24) 13 "UmlModelToMetaModelGenerator.mxg"
    MetaDslx.Modeling;
    #line hidden
    #line (4,1)-(4,6) 5 "UmlModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,35) 13 "UmlModelToMetaModelGenerator.mxg"
    MetaDslx.Languages.Uml.Model;
    #line hidden
    #line (5,1)-(5,6) 5 "UmlModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "UmlModelToMetaModelGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "UmlModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,23) 13 "UmlModelToMetaModelGenerator.mxg"
    Roslyn.Utilities;
    #line hidden
    
    #line (8,10)-(8,39) 25 "UmlModelToMetaModelGenerator.mxg"
    public partial class UmlModelToMetaModelGenerator
    #line hidden
    {
        #line (10,9)-(10,74) 22 "UmlModelToMetaModelGenerator.mxg"
        public string Generate(string namespaceName, string metaModelName, string uri)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,10) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (11,10)-(11,11) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,12)-(11,25) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(namespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,10) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("metamodel");
            #line hidden
            #line (13,10)-(13,11) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,12)-(13,25) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(metaModelName);
            #line hidden
            #line (13,26)-(13,27) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,27)-(13,28) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (13,28)-(13,29) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,29)-(13,30) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (13,31)-(13,34) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(uri);
            #line hidden
            #line (13,35)-(13,36) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first1 = true;
            #line (14,2)-(14,36) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var pt in PrimitiveTypes)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (16,6)-(16,31) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GeneratePrimitiveType(pt));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            var __first2 = true;
            #line (18,2)-(18,28) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (20,6)-(20,23) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateEnum(enm));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            var __first3 = true;
            #line (22,2)-(22,30) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("");
                #line (24,6)-(24,24) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateClass(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (28,9)-(28,49) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GeneratePrimitiveType(PrimitiveType pt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (29,6)-(29,25) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(pt));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (30,5)-(30,10) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("const");
            #line hidden
            #line (30,10)-(30,11) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,11)-(30,24) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("PrimitiveType");
            #line hidden
            #line (30,24)-(30,25) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,26)-(30,33) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(pt.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (33,9)-(33,39) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateEnum(Enumeration enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (34,6)-(34,26) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(enm));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (35,5)-(35,9) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (35,9)-(35,10) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,11)-(35,19) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (36,5)-(36,6) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first4 = true;
            #line (37,10)-(37,48) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var lit in enm.OwnedLiteral) 
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                else
                {
                    __cb.Push("    ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (37,58)-(37,64) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(",\n" );
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("    ");
                #line (38,14)-(38,34) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateComment(lit));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (39,14)-(39,37) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(lit.Name.ToPascalCase());
                #line hidden
                __cb.SkipLineEnd = true;
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first4)
            {
                __cb.Push("    ");
                __cb.DontIgnoreLastLineEnd = true;
                #line (37,70)-(37,74) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("\n");
                #line hidden
                __cb.DontIgnoreLastLineEnd = false;
                __cb.AppendLine();
                __cb.Pop();
            }
            __cb.Push("");
            #line (41,5)-(41,6) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (44,9)-(44,34) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateClass(Class cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (45,6)-(45,26) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(cls));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (46,6)-(46,39) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(cls.IsAbstract ? "abstract " : "");
            #line hidden
            #line (46,40)-(46,45) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (46,45)-(46,46) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,47)-(46,55) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first5 = true;
            foreach (var __item6 in 
            #line (46,57)-(46,108) 13 "UmlModelToMetaModelGenerator.mxg"
            from g in cls.Generalization select g.General.Name 
            #line hidden
            )
            {
                if (__first5)
                {
                    __first5 = false;
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (46,115)-(46,121) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" : " );
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (46,131)-(46,135) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Write(__item6);
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("");
            #line (47,5)-(47,6) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first7 = true;
            #line (48,10)-(48,50) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var prop in cls.OwnedAttribute)
            #line hidden
            
            {
                if (__first7)
                {
                    __first7 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (50,14)-(50,43) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateProperty(prop, false));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first7) __cb.AppendLine();
            var __first8 = true;
            #line (52,10)-(52,61) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var prop in GetAssociationProperties(cls))
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (54,14)-(54,42) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateProperty(prop, true));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first8) __cb.AppendLine();
            var __first9 = true;
            #line (56,10)-(56,48) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var op in cls.OwnedOperation)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (58,14)-(58,35) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateOperation(op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("");
            #line (60,5)-(60,6) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (63,9)-(63,55) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateProperty(Property prop, bool comment)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (64,6)-(64,27) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (65,6)-(65,26) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(comment ? "// " : "");
            #line hidden
            #line (65,28)-(65,53) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateContainment(prop));
            #line hidden
            #line (65,55)-(65,78) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateModifiers(prop));
            #line hidden
            #line (65,80)-(65,109) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateType(prop, prop.Type));
            #line hidden
            #line (65,110)-(65,111) 25 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,112)-(65,136) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(prop.Name.ToPascalCase());
            #line hidden
            #line (65,138)-(65,164) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateDefaultValue(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (66,10)-(66,30) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(comment ? "// " : "");
            #line hidden
            #line (66,32)-(66,55) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateRedefines(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (67,10)-(67,30) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(comment ? "// " : "");
            #line hidden
            #line (67,32)-(67,53) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateSubsets(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (68,10)-(68,30) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(comment ? "// " : "");
            #line hidden
            #line (68,32)-(68,54) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateOpposite(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (71,9)-(71,44) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateContainment(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (72,6)-(72,113) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(prop.Aggregation == AggregationKind.Composite && !prop.IsDerived && !prop.IsDerivedUnion ? "contains " : "");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (75,9)-(75,42) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateModifiers(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first10 = true;
            #line (76,6)-(76,43) 13 "UmlModelToMetaModelGenerator.mxg"
            if (prop.Upper > 1 || prop.Upper < 0)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                __cb.Push("");
                #line (77,10)-(77,77) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(prop.IsDerivedUnion ? "union " : (prop.IsDerived ? "derived " : ""));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (78,6)-(78,36) 13 "UmlModelToMetaModelGenerator.mxg"
            else if (!prop.IsDerivedUnion)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                __cb.Push("");
                #line (79,10)-(79,42) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(prop.IsDerived ? "derived " : "");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first10) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (83,9)-(83,83) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateType(MultiplicityElement me, MetaDslx.Languages.Uml.Model.Type t)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (84,6)-(84,30) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write(GeneratePrimitiveType(t));
            #line hidden
            #line (84,32)-(84,74) 24 "UmlModelToMetaModelGenerator.mxg"
            __cb.Write((me.Upper > 1 || me.Upper < 0) ? "[]" : "");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (87,9)-(87,42) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateRedefines(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first11 = true;
            #line (88,6)-(88,51) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var rprop in prop.RedefinedProperty)
            #line hidden
            
            {
                if (__first11)
                {
                    __first11 = false;
                }
                var __first12 = true;
                #line (89,10)-(89,49) 17 "UmlModelToMetaModelGenerator.mxg"
                if (rprop?.Owner is NamedElement owner)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("");
                    #line (90,13)-(90,22) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("redefines");
                    #line hidden
                    #line (90,22)-(90,23) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (90,24)-(90,34) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(owner.Name);
                    #line hidden
                    #line (90,35)-(90,36) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (90,37)-(90,62) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(rprop.Name.ToPascalCase());
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (91,10)-(91,14) 17 "UmlModelToMetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("");
                    #line (92,13)-(92,15) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("//");
                    #line hidden
                    #line (92,15)-(92,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,16)-(92,25) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("redefined");
                    #line hidden
                    #line (92,25)-(92,26) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,26)-(92,34) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (92,34)-(92,35) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,35)-(92,36) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (92,37)-(92,46) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(rprop.MId);
                    #line hidden
                    #line (92,47)-(92,48) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (92,48)-(92,49) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,49)-(92,51) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("is");
                    #line hidden
                    #line (92,51)-(92,52) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (92,52)-(92,56) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
            }
            if (!__first11) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (97,9)-(97,40) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateSubsets(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first13 = true;
            #line (98,6)-(98,51) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var sprop in prop.SubsettedProperty)
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                var __first14 = true;
                #line (99,10)-(99,49) 17 "UmlModelToMetaModelGenerator.mxg"
                if (sprop?.Owner is NamedElement owner)
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("");
                    #line (100,13)-(100,20) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("subsets");
                    #line hidden
                    #line (100,20)-(100,21) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (100,22)-(100,32) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(owner.Name);
                    #line hidden
                    #line (100,33)-(100,34) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (100,35)-(100,60) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(sprop.Name.ToPascalCase());
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (101,10)-(101,14) 17 "UmlModelToMetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first14)
                    {
                        __first14 = false;
                    }
                    __cb.Push("");
                    #line (102,13)-(102,15) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("//");
                    #line hidden
                    #line (102,15)-(102,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (102,16)-(102,25) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("subsetted");
                    #line hidden
                    #line (102,25)-(102,26) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (102,26)-(102,34) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (102,34)-(102,35) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (102,35)-(102,36) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (102,37)-(102,46) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(sprop.MId);
                    #line hidden
                    #line (102,47)-(102,48) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (102,48)-(102,49) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (102,49)-(102,51) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("is");
                    #line hidden
                    #line (102,51)-(102,52) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (102,52)-(102,56) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first14) __cb.AppendLine();
            }
            if (!__first13) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (107,9)-(107,41) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateOpposite(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first15 = true;
            #line (108,6)-(108,45) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var assoc in prop.Association)
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                var __first16 = true;
                #line (109,10)-(109,41) 17 "UmlModelToMetaModelGenerator.mxg"
                if (assoc.MemberEnd.Count == 2)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    __cb.Push("");
                    #line (110,14)-(110,36) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(GenerateComment(assoc));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    #line (111,14)-(111,44) 21 "UmlModelToMetaModelGenerator.mxg"
                    var first = assoc.MemberEnd[0];
                    #line hidden
                    
                    #line (112,14)-(112,45) 21 "UmlModelToMetaModelGenerator.mxg"
                    var second = assoc.MemberEnd[1];
                    #line hidden
                    
                    var __first17 = true;
                    #line (113,14)-(113,32) 21 "UmlModelToMetaModelGenerator.mxg"
                    if (first == prop)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        #line (114,18)-(114,41) 25 "UmlModelToMetaModelGenerator.mxg"
                        var owner = first?.Type;
                        #line hidden
                        
                        var __first18 = true;
                        #line (115,18)-(115,40) 25 "UmlModelToMetaModelGenerator.mxg"
                        if (owner is not null)
                        #line hidden
                        
                        {
                            if (__first18)
                            {
                                __first18 = false;
                            }
                            __cb.Push("");
                            var __first19 = true;
                            #line (116,22)-(116,51) 29 "UmlModelToMetaModelGenerator.mxg"
                            if (assoc.OwnedEnd.Count > 0)
                            #line hidden
                            
                            {
                                if (__first19)
                                {
                                    __first19 = false;
                                }
                                #line (116,52)-(116,54) 45 "UmlModelToMetaModelGenerator.mxg"
                                __cb.Write("//");
                                #line hidden
                                #line (116,54)-(116,55) 45 "UmlModelToMetaModelGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                            }
                            #line (116,63)-(116,71) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (116,71)-(116,72) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (116,73)-(116,83) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(owner.Name);
                            #line hidden
                            #line (116,84)-(116,85) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (116,86)-(116,112) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(second.Name.ToPascalCase());
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (117,18)-(117,22) 25 "UmlModelToMetaModelGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first18)
                            {
                                __first18 = false;
                            }
                            __cb.Push("");
                            #line (118,21)-(118,23) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (118,23)-(118,24) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,24)-(118,32) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (118,32)-(118,33) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,33)-(118,35) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("is");
                            #line hidden
                            #line (118,35)-(118,36) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,36)-(118,40) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("null");
                            #line hidden
                            #line (118,40)-(118,41) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,41)-(118,43) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("in");
                            #line hidden
                            #line (118,43)-(118,44) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (118,44)-(118,45) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("'");
                            #line hidden
                            #line (118,46)-(118,55) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(assoc.MId);
                            #line hidden
                            #line (118,56)-(118,57) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("'");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first18) __cb.AppendLine();
                    }
                    #line (120,14)-(120,38) 21 "UmlModelToMetaModelGenerator.mxg"
                    else if (second == prop)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        #line (121,18)-(121,42) 25 "UmlModelToMetaModelGenerator.mxg"
                        var owner = second?.Type;
                        #line hidden
                        
                        var __first20 = true;
                        #line (122,18)-(122,40) 25 "UmlModelToMetaModelGenerator.mxg"
                        if (owner is not null)
                        #line hidden
                        
                        {
                            if (__first20)
                            {
                                __first20 = false;
                            }
                            __cb.Push("");
                            var __first21 = true;
                            #line (123,22)-(123,51) 29 "UmlModelToMetaModelGenerator.mxg"
                            if (assoc.OwnedEnd.Count > 0)
                            #line hidden
                            
                            {
                                if (__first21)
                                {
                                    __first21 = false;
                                }
                                #line (123,52)-(123,54) 45 "UmlModelToMetaModelGenerator.mxg"
                                __cb.Write("//");
                                #line hidden
                                #line (123,54)-(123,55) 45 "UmlModelToMetaModelGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                            }
                            #line (123,63)-(123,71) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (123,71)-(123,72) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (123,73)-(123,83) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(owner.Name);
                            #line hidden
                            #line (123,84)-(123,85) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (123,86)-(123,111) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(first.Name.ToPascalCase());
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (124,18)-(124,22) 25 "UmlModelToMetaModelGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first20)
                            {
                                __first20 = false;
                            }
                            __cb.Push("");
                            #line (125,21)-(125,23) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (125,23)-(125,24) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (125,24)-(125,32) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (125,32)-(125,33) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (125,33)-(125,35) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("is");
                            #line hidden
                            #line (125,35)-(125,36) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (125,36)-(125,40) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("null");
                            #line hidden
                            #line (125,40)-(125,41) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (125,41)-(125,43) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("in");
                            #line hidden
                            #line (125,43)-(125,44) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (125,44)-(125,45) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("'");
                            #line hidden
                            #line (125,46)-(125,55) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(assoc.MId);
                            #line hidden
                            #line (125,56)-(125,57) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("'");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first20) __cb.AppendLine();
                    }
                    if (!__first17) __cb.AppendLine();
                }
                if (!__first16) __cb.AppendLine();
            }
            if (!__first15) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (132,9)-(132,41) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateOperation(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first22 = true;
            #line (133,6)-(133,40) 13 "UmlModelToMetaModelGenerator.mxg"
            if (!IsPropertyImplementation(op))
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("");
                #line (134,10)-(134,29) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateComment(op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (135,10)-(135,32) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateReturnType(op));
                #line hidden
                #line (135,33)-(135,34) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (135,35)-(135,57) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(op.Name.ToPascalCase());
                #line hidden
                #line (135,58)-(135,59) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (135,60)-(135,78) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateParams(op));
                #line hidden
                #line (135,79)-(135,80) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (139,9)-(139,42) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateReturnType(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (140,6)-(140,115) 13 "UmlModelToMetaModelGenerator.mxg"
            var returnParam = op.OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Return).FirstOrDefault();
            #line hidden
            
            var __first23 = true;
            #line (141,6)-(141,34) 13 "UmlModelToMetaModelGenerator.mxg"
            if (returnParam is not null)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                __cb.Push("");
                #line (142,10)-(142,53) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateType(returnParam, returnParam.Type));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (143,6)-(143,10) 13 "UmlModelToMetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                __cb.Push("");
                #line (144,9)-(144,13) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (148,9)-(148,38) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateParams(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first24 = true;
            #line (150,6)-(150,104) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var param in op.OwnedParameter.Where(p => p.Direction != ParameterDirectionKind.Return)) 
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (150,114)-(150,118) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (151,10)-(151,41) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateType(param, param.Type));
                #line hidden
                #line (151,42)-(151,43) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,44)-(151,54) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(param.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first24) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (155,9)-(155,39) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateComment(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (156,6)-(156,42) 13 "UmlModelToMetaModelGenerator.mxg"
            var lines = CommentLines(elem, true);
            #line hidden
            
            var __first25 = true;
            #line (157,6)-(157,27) 13 "UmlModelToMetaModelGenerator.mxg"
            if (lines.Length > 0)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                __cb.Push("");
                #line (158,9)-(158,12) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (158,12)-(158,13) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (158,13)-(158,22) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first26 = true;
                #line (159,10)-(159,37) 17 "UmlModelToMetaModelGenerator.mxg"
                foreach (var line in lines)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("");
                    #line (160,13)-(160,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (160,16)-(160,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,18)-(160,22) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(line);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
                __cb.Push("");
                #line (162,9)-(162,12) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (162,12)-(162,13) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (162,13)-(162,23) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first25) __cb.AppendLine();
            var __first27 = true;
            #line (164,6)-(164,31) 13 "UmlModelToMetaModelGenerator.mxg"
            if (elem is Operation op)
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                var __first28 = true;
                #line (165,10)-(165,107) 17 "UmlModelToMetaModelGenerator.mxg"
                foreach (var param in op.OwnedParameter.Where(p => p.Direction != ParameterDirectionKind.Return))
                #line hidden
                
                {
                    if (__first28)
                    {
                        __first28 = false;
                    }
                    __cb.Push("");
                    #line (166,13)-(166,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (166,16)-(166,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,17)-(166,23) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("<param");
                    #line hidden
                    #line (166,23)-(166,24) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (166,24)-(166,30) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("name=\"");
                    #line hidden
                    #line (166,31)-(166,41) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                    #line (166,42)-(166,44) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("\">");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first29 = true;
                    #line (167,14)-(167,61) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var line in CommentLines(param, true))
                    #line hidden
                    
                    {
                        if (__first29)
                        {
                            __first29 = false;
                        }
                        __cb.Push("");
                        #line (168,17)-(168,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (168,20)-(168,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (168,22)-(168,26) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first29) __cb.AppendLine();
                    __cb.Push("");
                    #line (170,13)-(170,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (170,16)-(170,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (170,17)-(170,25) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("</param>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first28) __cb.AppendLine();
                var __first30 = true;
                #line (172,10)-(172,107) 17 "UmlModelToMetaModelGenerator.mxg"
                foreach (var param in op.OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Return))
                #line hidden
                
                {
                    if (__first30)
                    {
                        __first30 = false;
                    }
                    __cb.Push("");
                    #line (173,13)-(173,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (173,16)-(173,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (173,17)-(173,26) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("<returns>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first31 = true;
                    #line (174,14)-(174,61) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var line in CommentLines(param, true))
                    #line hidden
                    
                    {
                        if (__first31)
                        {
                            __first31 = false;
                        }
                        __cb.Push("");
                        #line (175,17)-(175,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (175,20)-(175,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (175,22)-(175,26) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first31) __cb.AppendLine();
                    __cb.Push("");
                    #line (177,13)-(177,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (177,16)-(177,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (177,17)-(177,27) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("</returns>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first30) __cb.AppendLine();
                __cb.Push("");
                #line (179,10)-(179,48) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateSpecification((Operation)elem));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (180,6)-(180,37) 13 "UmlModelToMetaModelGenerator.mxg"
            else if (elem is Property prop)
            #line hidden
            
            {
                if (__first27)
                {
                    __first27 = false;
                }
                var __first32 = true;
                #line (181,10)-(181,53) 17 "UmlModelToMetaModelGenerator.mxg"
                if (prop.IsDerived && !prop.IsDerivedUnion)
                #line hidden
                
                {
                    if (__first32)
                    {
                        __first32 = false;
                    }
                    var __first33 = true;
                    #line (182,14)-(182,93) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var impl in prop.Class.OwnedOperation.Where(o => o.Name == prop.Name))
                    #line hidden
                    
                    {
                        if (__first33)
                        {
                            __first33 = false;
                        }
                        __cb.Push("");
                        #line (183,14)-(183,41) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(GenerateSpecification(impl));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first33) __cb.AppendLine();
                }
                if (!__first32) __cb.AppendLine();
            }
            if (!__first27) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (189,9)-(189,45) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateSpecification(Namespace ns)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first34 = true;
            #line (190,6)-(190,40) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var rule in ns.OwnedRule)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                var __first35 = true;
                #line (191,10)-(191,58) 17 "UmlModelToMetaModelGenerator.mxg"
                if (rule.Specification is OpaqueExpression expr)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    #line (192,14)-(192,50) 21 "UmlModelToMetaModelGenerator.mxg"
                    var lines = CommentLines(rule, true);
                    #line hidden
                    
                    var __first36 = true;
                    #line (193,14)-(193,35) 21 "UmlModelToMetaModelGenerator.mxg"
                    if (lines.Length > 0)
                    #line hidden
                    
                    {
                        if (__first36)
                        {
                            __first36 = false;
                        }
                        __cb.Push("");
                        #line (194,17)-(194,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (194,20)-(194,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (194,21)-(194,27) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("<para>");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first37 = true;
                        #line (195,18)-(195,45) 25 "UmlModelToMetaModelGenerator.mxg"
                        foreach (var line in lines)
                        #line hidden
                        
                        {
                            if (__first37)
                            {
                                __first37 = false;
                            }
                            __cb.Push("");
                            #line (196,21)-(196,24) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("///");
                            #line hidden
                            #line (196,24)-(196,25) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (196,26)-(196,30) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(line);
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first37) __cb.AppendLine();
                        __cb.Push("");
                        #line (198,17)-(198,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (198,20)-(198,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (198,21)-(198,28) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("</para>");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first36) __cb.AppendLine();
                    __cb.Push("");
                    #line (200,13)-(200,15) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("//");
                    #line hidden
                    #line (200,15)-(200,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (200,17)-(200,26) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(rule.Name);
                    #line hidden
                    #line (200,27)-(200,28) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(":");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    #line (201,14)-(201,52) 21 "UmlModelToMetaModelGenerator.mxg"
                    lines = CommentLines(expr.Body, false);
                    #line hidden
                    
                    var __first38 = true;
                    #line (202,14)-(202,41) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var line in lines)
                    #line hidden
                    
                    {
                        if (__first38)
                        {
                            __first38 = false;
                        }
                        __cb.Push("");
                        #line (203,17)-(203,19) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("//");
                        #line hidden
                        #line (203,19)-(203,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (203,21)-(203,25) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first38) __cb.AppendLine();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}