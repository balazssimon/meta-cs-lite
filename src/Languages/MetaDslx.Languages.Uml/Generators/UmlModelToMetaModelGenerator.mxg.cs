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
            #line (108,6)-(108,34) 13 "UmlModelToMetaModelGenerator.mxg"
            var assoc = prop.Association;
            #line hidden
            
            var __first15 = true;
            #line (109,6)-(109,37) 13 "UmlModelToMetaModelGenerator.mxg"
            if (assoc.MemberEnd.Count == 2)
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                __cb.Push("");
                #line (110,10)-(110,32) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateComment(assoc));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                #line (111,10)-(111,40) 17 "UmlModelToMetaModelGenerator.mxg"
                var first = assoc.MemberEnd[0];
                #line hidden
                
                #line (112,10)-(112,41) 17 "UmlModelToMetaModelGenerator.mxg"
                var second = assoc.MemberEnd[1];
                #line hidden
                
                var __first16 = true;
                #line (113,10)-(113,28) 17 "UmlModelToMetaModelGenerator.mxg"
                if (first == prop)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    #line (114,14)-(114,37) 21 "UmlModelToMetaModelGenerator.mxg"
                    var owner = first?.Type;
                    #line hidden
                    
                    var __first17 = true;
                    #line (115,14)-(115,36) 21 "UmlModelToMetaModelGenerator.mxg"
                    if (owner is not null)
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("");
                        var __first18 = true;
                        #line (116,18)-(116,47) 25 "UmlModelToMetaModelGenerator.mxg"
                        if (assoc.OwnedEnd.Count > 0)
                        #line hidden
                        
                        {
                            if (__first18)
                            {
                                __first18 = false;
                            }
                            #line (116,48)-(116,50) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (116,50)-(116,51) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                        }
                        #line (116,59)-(116,67) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("opposite");
                        #line hidden
                        #line (116,67)-(116,68) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (116,69)-(116,79) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(owner.Name);
                        #line hidden
                        #line (116,80)-(116,81) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(".");
                        #line hidden
                        #line (116,82)-(116,108) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(second.Name.ToPascalCase());
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (117,14)-(117,18) 21 "UmlModelToMetaModelGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first17)
                        {
                            __first17 = false;
                        }
                        __cb.Push("");
                        #line (118,17)-(118,19) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("//");
                        #line hidden
                        #line (118,19)-(118,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,20)-(118,28) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("opposite");
                        #line hidden
                        #line (118,28)-(118,29) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,29)-(118,31) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("is");
                        #line hidden
                        #line (118,31)-(118,32) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,32)-(118,36) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("null");
                        #line hidden
                        #line (118,36)-(118,37) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,37)-(118,39) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("in");
                        #line hidden
                        #line (118,39)-(118,40) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (118,40)-(118,41) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("'");
                        #line hidden
                        #line (118,42)-(118,51) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(assoc.MId);
                        #line hidden
                        #line (118,52)-(118,53) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("'");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first17) __cb.AppendLine();
                }
                #line (120,10)-(120,34) 17 "UmlModelToMetaModelGenerator.mxg"
                else if (second == prop)
                #line hidden
                
                {
                    if (__first16)
                    {
                        __first16 = false;
                    }
                    #line (121,14)-(121,38) 21 "UmlModelToMetaModelGenerator.mxg"
                    var owner = second?.Type;
                    #line hidden
                    
                    var __first19 = true;
                    #line (122,14)-(122,36) 21 "UmlModelToMetaModelGenerator.mxg"
                    if (owner is not null)
                    #line hidden
                    
                    {
                        if (__first19)
                        {
                            __first19 = false;
                        }
                        __cb.Push("");
                        var __first20 = true;
                        #line (123,18)-(123,47) 25 "UmlModelToMetaModelGenerator.mxg"
                        if (assoc.OwnedEnd.Count > 0)
                        #line hidden
                        
                        {
                            if (__first20)
                            {
                                __first20 = false;
                            }
                            #line (123,48)-(123,50) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (123,50)-(123,51) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                        }
                        #line (123,59)-(123,67) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("opposite");
                        #line hidden
                        #line (123,67)-(123,68) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (123,69)-(123,79) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(owner.Name);
                        #line hidden
                        #line (123,80)-(123,81) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(".");
                        #line hidden
                        #line (123,82)-(123,107) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(first.Name.ToPascalCase());
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    #line (124,14)-(124,18) 21 "UmlModelToMetaModelGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first19)
                        {
                            __first19 = false;
                        }
                        __cb.Push("");
                        #line (125,17)-(125,19) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("//");
                        #line hidden
                        #line (125,19)-(125,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,20)-(125,28) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("opposite");
                        #line hidden
                        #line (125,28)-(125,29) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,29)-(125,31) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("is");
                        #line hidden
                        #line (125,31)-(125,32) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,32)-(125,36) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("null");
                        #line hidden
                        #line (125,36)-(125,37) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,37)-(125,39) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("in");
                        #line hidden
                        #line (125,39)-(125,40) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (125,40)-(125,41) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("'");
                        #line hidden
                        #line (125,42)-(125,51) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(assoc.MId);
                        #line hidden
                        #line (125,52)-(125,53) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("'");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first19) __cb.AppendLine();
                }
                if (!__first16) __cb.AppendLine();
            }
            if (!__first15) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (131,9)-(131,41) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateOperation(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first21 = true;
            #line (132,6)-(132,40) 13 "UmlModelToMetaModelGenerator.mxg"
            if (!IsPropertyImplementation(op))
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                __cb.Push("");
                #line (133,10)-(133,29) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateComment(op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (134,10)-(134,32) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateReturnType(op));
                #line hidden
                #line (134,33)-(134,34) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (134,35)-(134,57) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(op.Name.ToPascalCase());
                #line hidden
                #line (134,58)-(134,59) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (134,60)-(134,78) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateParams(op));
                #line hidden
                #line (134,79)-(134,80) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first21) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (138,9)-(138,42) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateReturnType(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (139,6)-(139,115) 13 "UmlModelToMetaModelGenerator.mxg"
            var returnParam = op.OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Return).FirstOrDefault();
            #line hidden
            
            var __first22 = true;
            #line (140,6)-(140,34) 13 "UmlModelToMetaModelGenerator.mxg"
            if (returnParam is not null)
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("");
                #line (141,10)-(141,53) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateType(returnParam, returnParam.Type));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (142,6)-(142,10) 13 "UmlModelToMetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("");
                #line (143,9)-(143,13) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (147,9)-(147,38) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateParams(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first23 = true;
            #line (149,6)-(149,104) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var param in op.OwnedParameter.Where(p => p.Direction != ParameterDirectionKind.Return)) 
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (149,114)-(149,118) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (150,10)-(150,41) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateType(param, param.Type));
                #line hidden
                #line (150,42)-(150,43) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (150,44)-(150,54) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(param.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (154,9)-(154,39) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateComment(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (155,6)-(155,42) 13 "UmlModelToMetaModelGenerator.mxg"
            var lines = CommentLines(elem, true);
            #line hidden
            
            var __first24 = true;
            #line (156,6)-(156,27) 13 "UmlModelToMetaModelGenerator.mxg"
            if (lines.Length > 0)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                __cb.Push("");
                #line (157,9)-(157,12) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (157,12)-(157,13) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (157,13)-(157,22) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first25 = true;
                #line (158,10)-(158,37) 17 "UmlModelToMetaModelGenerator.mxg"
                foreach (var line in lines)
                #line hidden
                
                {
                    if (__first25)
                    {
                        __first25 = false;
                    }
                    __cb.Push("");
                    #line (159,13)-(159,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (159,16)-(159,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (159,18)-(159,22) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(line);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first25) __cb.AppendLine();
                __cb.Push("");
                #line (161,9)-(161,12) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (161,12)-(161,13) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (161,13)-(161,23) 29 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first24) __cb.AppendLine();
            var __first26 = true;
            #line (163,6)-(163,31) 13 "UmlModelToMetaModelGenerator.mxg"
            if (elem is Operation op)
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                var __first27 = true;
                #line (164,10)-(164,107) 17 "UmlModelToMetaModelGenerator.mxg"
                foreach (var param in op.OwnedParameter.Where(p => p.Direction != ParameterDirectionKind.Return))
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    __cb.Push("");
                    #line (165,13)-(165,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (165,16)-(165,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,17)-(165,23) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("<param");
                    #line hidden
                    #line (165,23)-(165,24) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (165,24)-(165,30) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("name=\"");
                    #line hidden
                    #line (165,31)-(165,41) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                    #line (165,42)-(165,44) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("\">");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first28 = true;
                    #line (166,14)-(166,61) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var line in CommentLines(param, true))
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("");
                        #line (167,17)-(167,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (167,20)-(167,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (167,22)-(167,26) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first28) __cb.AppendLine();
                    __cb.Push("");
                    #line (169,13)-(169,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (169,16)-(169,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (169,17)-(169,25) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("</param>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first27) __cb.AppendLine();
                var __first29 = true;
                #line (171,10)-(171,107) 17 "UmlModelToMetaModelGenerator.mxg"
                foreach (var param in op.OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Return))
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("");
                    #line (172,13)-(172,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (172,16)-(172,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (172,17)-(172,26) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("<returns>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first30 = true;
                    #line (173,14)-(173,61) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var line in CommentLines(param, true))
                    #line hidden
                    
                    {
                        if (__first30)
                        {
                            __first30 = false;
                        }
                        __cb.Push("");
                        #line (174,17)-(174,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (174,20)-(174,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (174,22)-(174,26) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first30) __cb.AppendLine();
                    __cb.Push("");
                    #line (176,13)-(176,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (176,16)-(176,17) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (176,17)-(176,27) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("</returns>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first29) __cb.AppendLine();
                __cb.Push("");
                #line (178,10)-(178,48) 28 "UmlModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateSpecification((Operation)elem));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (179,6)-(179,37) 13 "UmlModelToMetaModelGenerator.mxg"
            else if (elem is Property prop)
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                var __first31 = true;
                #line (180,10)-(180,53) 17 "UmlModelToMetaModelGenerator.mxg"
                if (prop.IsDerived && !prop.IsDerivedUnion)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    var __first32 = true;
                    #line (181,14)-(181,93) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var impl in prop.Class.OwnedOperation.Where(o => o.Name == prop.Name))
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("");
                        #line (182,14)-(182,41) 36 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(GenerateSpecification(impl));
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first32) __cb.AppendLine();
                }
                if (!__first31) __cb.AppendLine();
            }
            if (!__first26) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (188,9)-(188,45) 22 "UmlModelToMetaModelGenerator.mxg"
        public string GenerateSpecification(Namespace ns)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first33 = true;
            #line (189,6)-(189,40) 13 "UmlModelToMetaModelGenerator.mxg"
            foreach (var rule in ns.OwnedRule)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                var __first34 = true;
                #line (190,10)-(190,58) 17 "UmlModelToMetaModelGenerator.mxg"
                if (rule.Specification is OpaqueExpression expr)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    #line (191,14)-(191,50) 21 "UmlModelToMetaModelGenerator.mxg"
                    var lines = CommentLines(rule, true);
                    #line hidden
                    
                    var __first35 = true;
                    #line (192,14)-(192,35) 21 "UmlModelToMetaModelGenerator.mxg"
                    if (lines.Length > 0)
                    #line hidden
                    
                    {
                        if (__first35)
                        {
                            __first35 = false;
                        }
                        __cb.Push("");
                        #line (193,17)-(193,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (193,20)-(193,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (193,21)-(193,27) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("<para>");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first36 = true;
                        #line (194,18)-(194,45) 25 "UmlModelToMetaModelGenerator.mxg"
                        foreach (var line in lines)
                        #line hidden
                        
                        {
                            if (__first36)
                            {
                                __first36 = false;
                            }
                            __cb.Push("");
                            #line (195,21)-(195,24) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("///");
                            #line hidden
                            #line (195,24)-(195,25) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (195,26)-(195,30) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(line);
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first36) __cb.AppendLine();
                        __cb.Push("");
                        #line (197,17)-(197,20) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (197,20)-(197,21) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (197,21)-(197,28) 37 "UmlModelToMetaModelGenerator.mxg"
                        __cb.Write("</para>");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first35) __cb.AppendLine();
                    __cb.Push("");
                    #line (199,13)-(199,15) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write("//");
                    #line hidden
                    #line (199,15)-(199,16) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (199,17)-(199,26) 32 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(rule.Name);
                    #line hidden
                    #line (199,27)-(199,28) 33 "UmlModelToMetaModelGenerator.mxg"
                    __cb.Write(":");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first37 = true;
                    #line (200,14)-(200,45) 21 "UmlModelToMetaModelGenerator.mxg"
                    foreach (var body in expr.Body)
                    #line hidden
                    
                    {
                        if (__first37)
                        {
                            __first37 = false;
                        }
                        #line (201,18)-(201,51) 25 "UmlModelToMetaModelGenerator.mxg"
                        lines = CommentLines(body, false);
                        #line hidden
                        
                        var __first38 = true;
                        #line (202,18)-(202,45) 25 "UmlModelToMetaModelGenerator.mxg"
                        foreach (var line in lines)
                        #line hidden
                        
                        {
                            if (__first38)
                            {
                                __first38 = false;
                            }
                            __cb.Push("");
                            #line (203,21)-(203,23) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (203,23)-(203,24) 41 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (203,25)-(203,29) 40 "UmlModelToMetaModelGenerator.mxg"
                            __cb.Write(line);
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first38) __cb.AppendLine();
                    }
                    if (!__first37) __cb.AppendLine();
                }
                if (!__first34) __cb.AppendLine();
            }
            if (!__first33) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}