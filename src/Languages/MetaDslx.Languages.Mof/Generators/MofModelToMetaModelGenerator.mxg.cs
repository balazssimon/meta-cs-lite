#line (1,10)-(1,43) 10 "MofModelToMetaModelGenerator.mxg"
namespace MetaDslx.Languages.Mof.Generator
#line hidden

{
    #line (3,1)-(3,6) 5 "MofModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,24) 13 "MofModelToMetaModelGenerator.mxg"
    MetaDslx.Modeling;
    #line hidden
    #line (4,1)-(4,6) 5 "MofModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,35) 13 "MofModelToMetaModelGenerator.mxg"
    MetaDslx.Languages.Mof.Model;
    #line hidden
    #line (5,1)-(5,6) 5 "MofModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,35) 13 "MofModelToMetaModelGenerator.mxg"
    System.Collections.Immutable;
    #line hidden
    #line (6,1)-(6,6) 5 "MofModelToMetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,23) 13 "MofModelToMetaModelGenerator.mxg"
    Roslyn.Utilities;
    #line hidden
    
    #line (8,10)-(8,39) 25 "MofModelToMetaModelGenerator.mxg"
    public partial class MofModelToMetaModelGenerator
    #line hidden
    {
        #line (10,9)-(10,74) 22 "MofModelToMetaModelGenerator.mxg"
        public string Generate(string namespaceName, string metaModelName, string uri)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,10) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (11,10)-(11,11) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,12)-(11,25) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(namespaceName);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,10) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("metamodel");
            #line hidden
            #line (13,10)-(13,11) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,12)-(13,25) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(metaModelName);
            #line hidden
            #line (13,26)-(13,27) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,27)-(13,28) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (13,28)-(13,29) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,29)-(13,30) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (13,31)-(13,34) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(uri);
            #line hidden
            #line (13,35)-(13,36) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first1 = true;
            #line (14,2)-(14,36) 13 "MofModelToMetaModelGenerator.mxg"
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
                #line (16,6)-(16,31) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GeneratePrimitiveType(pt));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            var __first2 = true;
            #line (18,2)-(18,28) 13 "MofModelToMetaModelGenerator.mxg"
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
                #line (20,6)-(20,23) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateEnum(enm));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            var __first3 = true;
            #line (22,2)-(22,30) 13 "MofModelToMetaModelGenerator.mxg"
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
                #line (24,6)-(24,24) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateClass(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (28,9)-(28,49) 22 "MofModelToMetaModelGenerator.mxg"
        public string GeneratePrimitiveType(PrimitiveType pt)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (29,6)-(29,25) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(pt));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (30,5)-(30,10) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("const");
            #line hidden
            #line (30,10)-(30,11) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,11)-(30,24) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("PrimitiveType");
            #line hidden
            #line (30,24)-(30,25) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,26)-(30,33) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(pt.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (33,9)-(33,39) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateEnum(Enumeration enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (34,6)-(34,26) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(enm));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (35,5)-(35,9) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (35,9)-(35,10) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (35,11)-(35,19) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (36,5)-(36,6) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first4 = true;
            #line (37,10)-(37,48) 13 "MofModelToMetaModelGenerator.mxg"
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
                    #line (37,58)-(37,64) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(",\n" );
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("    ");
                #line (38,14)-(38,34) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateComment(lit));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (39,14)-(39,37) 28 "MofModelToMetaModelGenerator.mxg"
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
                #line (37,70)-(37,74) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write("\n");
                #line hidden
                __cb.DontIgnoreLastLineEnd = false;
                __cb.AppendLine();
                __cb.Pop();
            }
            __cb.Push("");
            #line (41,5)-(41,6) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (44,9)-(44,34) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateClass(Class cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (45,6)-(45,26) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(cls));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (46,6)-(46,39) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(cls.IsAbstract ? "abstract " : "");
            #line hidden
            #line (46,40)-(46,45) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (46,45)-(46,46) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (46,47)-(46,55) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first5 = true;
            foreach (var __item6 in 
            #line (46,57)-(46,108) 13 "MofModelToMetaModelGenerator.mxg"
            from g in cls.Generalization select g.General.Name 
            #line hidden
            )
            {
                if (__first5)
                {
                    __first5 = false;
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (46,115)-(46,121) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" : " );
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                else
                {
                    __cb.Push("");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (46,131)-(46,135) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Write(__item6);
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("");
            #line (47,5)-(47,6) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first7 = true;
            #line (48,10)-(48,50) 13 "MofModelToMetaModelGenerator.mxg"
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
                #line (50,14)-(50,36) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateProperty(prop));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first7) __cb.AppendLine();
            var __first8 = true;
            #line (52,10)-(52,48) 13 "MofModelToMetaModelGenerator.mxg"
            foreach (var op in cls.OwnedOperation)
            #line hidden
            
            {
                if (__first8)
                {
                    __first8 = false;
                }
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (54,14)-(54,35) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateOperation(op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first8) __cb.AppendLine();
            __cb.Push("");
            #line (56,5)-(56,6) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (59,9)-(59,41) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateProperty(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (60,6)-(60,27) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateComment(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (61,6)-(61,31) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateContainment(prop));
            #line hidden
            #line (61,33)-(61,56) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateModifiers(prop));
            #line hidden
            #line (61,58)-(61,87) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateType(prop, prop.Type));
            #line hidden
            #line (61,88)-(61,89) 25 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,90)-(61,114) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(prop.Name.ToPascalCase());
            #line hidden
            #line (61,116)-(61,142) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateDefaultValue(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (62,10)-(62,33) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateRedefines(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (63,10)-(63,31) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateSubsets(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (64,10)-(64,32) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GenerateOpposite(prop));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (67,9)-(67,44) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateContainment(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (68,6)-(68,70) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(prop.Aggregation == AggregationKind.Composite ? "contains " : "");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (71,9)-(71,42) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateModifiers(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first9 = true;
            #line (72,6)-(72,43) 13 "MofModelToMetaModelGenerator.mxg"
            if (prop.Upper > 1 || prop.Upper < 0)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("");
                #line (73,10)-(73,77) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(prop.IsDerivedUnion ? "union " : (prop.IsDerived ? "derived " : ""));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (74,6)-(74,36) 13 "MofModelToMetaModelGenerator.mxg"
            else if (!prop.IsDerivedUnion)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                __cb.Push("");
                #line (75,10)-(75,42) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(prop.IsDerived ? "derived " : "");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first9) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (79,9)-(79,83) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateType(MultiplicityElement me, MetaDslx.Languages.Mof.Model.Type t)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (80,6)-(80,30) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write(GeneratePrimitiveType(t));
            #line hidden
            #line (80,32)-(80,74) 24 "MofModelToMetaModelGenerator.mxg"
            __cb.Write((me.Upper > 1 || me.Upper < 0) ? "[]" : "");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (83,9)-(83,42) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateRedefines(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first10 = true;
            #line (84,6)-(84,51) 13 "MofModelToMetaModelGenerator.mxg"
            foreach (var rprop in prop.RedefinedProperty)
            #line hidden
            
            {
                if (__first10)
                {
                    __first10 = false;
                }
                var __first11 = true;
                #line (85,10)-(85,39) 17 "MofModelToMetaModelGenerator.mxg"
                if (rprop?.Class is not null)
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    __cb.Push("");
                    #line (86,13)-(86,22) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("redefines");
                    #line hidden
                    #line (86,22)-(86,23) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (86,24)-(86,40) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(rprop.Class.Name);
                    #line hidden
                    #line (86,41)-(86,42) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (86,43)-(86,68) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(rprop.Name.ToPascalCase());
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (87,10)-(87,14) 17 "MofModelToMetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first11)
                    {
                        __first11 = false;
                    }
                    __cb.Push("");
                    #line (88,13)-(88,15) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("//");
                    #line hidden
                    #line (88,15)-(88,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,16)-(88,25) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("redefined");
                    #line hidden
                    #line (88,25)-(88,26) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,26)-(88,34) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (88,34)-(88,35) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,35)-(88,36) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (88,37)-(88,46) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(rprop.MId);
                    #line hidden
                    #line (88,47)-(88,48) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (88,48)-(88,49) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,49)-(88,51) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("is");
                    #line hidden
                    #line (88,51)-(88,52) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (88,52)-(88,56) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first11) __cb.AppendLine();
            }
            if (!__first10) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (93,9)-(93,40) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateSubsets(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first12 = true;
            #line (94,6)-(94,51) 13 "MofModelToMetaModelGenerator.mxg"
            foreach (var sprop in prop.SubsettedProperty)
            #line hidden
            
            {
                if (__first12)
                {
                    __first12 = false;
                }
                var __first13 = true;
                #line (95,10)-(95,39) 17 "MofModelToMetaModelGenerator.mxg"
                if (sprop?.Class is not null)
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("");
                    #line (96,13)-(96,22) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("redefines");
                    #line hidden
                    #line (96,22)-(96,23) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (96,24)-(96,40) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(sprop.Class.Name);
                    #line hidden
                    #line (96,41)-(96,42) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (96,43)-(96,68) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(sprop.Name.ToPascalCase());
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (97,10)-(97,14) 17 "MofModelToMetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first13)
                    {
                        __first13 = false;
                    }
                    __cb.Push("");
                    #line (98,13)-(98,15) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("//");
                    #line hidden
                    #line (98,15)-(98,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (98,16)-(98,25) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("subsetted");
                    #line hidden
                    #line (98,25)-(98,26) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (98,26)-(98,34) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (98,34)-(98,35) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (98,35)-(98,36) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (98,37)-(98,46) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(sprop.MId);
                    #line hidden
                    #line (98,47)-(98,48) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("'");
                    #line hidden
                    #line (98,48)-(98,49) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (98,49)-(98,51) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("is");
                    #line hidden
                    #line (98,51)-(98,52) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (98,52)-(98,56) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("null");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first13) __cb.AppendLine();
            }
            if (!__first12) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (103,9)-(103,41) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateOpposite(Property prop)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first14 = true;
            #line (104,6)-(104,45) 13 "MofModelToMetaModelGenerator.mxg"
            foreach (var assoc in prop.Association)
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                var __first15 = true;
                #line (105,10)-(105,70) 17 "MofModelToMetaModelGenerator.mxg"
                if (assoc.MemberEnd.Count == 2 && assoc.OwnedEnd.Count == 0)
                #line hidden
                
                {
                    if (__first15)
                    {
                        __first15 = false;
                    }
                    __cb.Push("");
                    #line (106,14)-(106,36) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(GenerateComment(assoc));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    #line (107,14)-(107,44) 21 "MofModelToMetaModelGenerator.mxg"
                    var first = assoc.MemberEnd[0];
                    #line hidden
                    
                    #line (108,14)-(108,45) 21 "MofModelToMetaModelGenerator.mxg"
                    var second = assoc.MemberEnd[1];
                    #line hidden
                    
                    var __first16 = true;
                    #line (109,14)-(109,32) 21 "MofModelToMetaModelGenerator.mxg"
                    if (first == prop)
                    #line hidden
                    
                    {
                        if (__first16)
                        {
                            __first16 = false;
                        }
                        var __first17 = true;
                        #line (110,18)-(110,47) 25 "MofModelToMetaModelGenerator.mxg"
                        if (first?.Class is not null)
                        #line hidden
                        
                        {
                            if (__first17)
                            {
                                __first17 = false;
                            }
                            __cb.Push("");
                            var __first18 = true;
                            #line (111,22)-(111,51) 29 "MofModelToMetaModelGenerator.mxg"
                            if (assoc.OwnedEnd.Count > 0)
                            #line hidden
                            
                            {
                                if (__first18)
                                {
                                    __first18 = false;
                                }
                                #line (111,52)-(111,54) 45 "MofModelToMetaModelGenerator.mxg"
                                __cb.Write("//");
                                #line hidden
                                #line (111,54)-(111,55) 45 "MofModelToMetaModelGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                            }
                            #line (111,63)-(111,71) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (111,71)-(111,72) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (111,73)-(111,89) 40 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(first.Class.Name);
                            #line hidden
                            #line (111,90)-(111,91) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (111,92)-(111,118) 40 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(second.Name.ToPascalCase());
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (112,18)-(112,22) 25 "MofModelToMetaModelGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first17)
                            {
                                __first17 = false;
                            }
                            __cb.Push("");
                            #line (113,21)-(113,23) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (113,23)-(113,24) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,24)-(113,32) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (113,32)-(113,33) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,33)-(113,35) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("is");
                            #line hidden
                            #line (113,35)-(113,36) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,36)-(113,40) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("null");
                            #line hidden
                            #line (113,40)-(113,41) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,41)-(113,43) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("in");
                            #line hidden
                            #line (113,43)-(113,44) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (113,44)-(113,45) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("'");
                            #line hidden
                            #line (113,46)-(113,55) 40 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(assoc.MId);
                            #line hidden
                            #line (113,56)-(113,57) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("'");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first17) __cb.AppendLine();
                    }
                    #line (115,14)-(115,38) 21 "MofModelToMetaModelGenerator.mxg"
                    else if (second == prop)
                    #line hidden
                    
                    {
                        if (__first16)
                        {
                            __first16 = false;
                        }
                        var __first19 = true;
                        #line (116,18)-(116,48) 25 "MofModelToMetaModelGenerator.mxg"
                        if (second?.Class is not null)
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("");
                            var __first20 = true;
                            #line (117,22)-(117,51) 29 "MofModelToMetaModelGenerator.mxg"
                            if (assoc.OwnedEnd.Count > 0)
                            #line hidden
                            
                            {
                                if (__first20)
                                {
                                    __first20 = false;
                                }
                                #line (117,52)-(117,54) 45 "MofModelToMetaModelGenerator.mxg"
                                __cb.Write("//");
                                #line hidden
                                #line (117,54)-(117,55) 45 "MofModelToMetaModelGenerator.mxg"
                                __cb.Write(" ");
                                #line hidden
                            }
                            #line (117,63)-(117,71) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (117,71)-(117,72) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (117,73)-(117,90) 40 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(second.Class.Name);
                            #line hidden
                            #line (117,91)-(117,92) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (117,93)-(117,118) 40 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(first.Name.ToPascalCase());
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        #line (118,18)-(118,22) 25 "MofModelToMetaModelGenerator.mxg"
                        else
                        #line hidden
                        
                        {
                            if (__first19)
                            {
                                __first19 = false;
                            }
                            __cb.Push("");
                            #line (119,21)-(119,23) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("//");
                            #line hidden
                            #line (119,23)-(119,24) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,24)-(119,32) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("opposite");
                            #line hidden
                            #line (119,32)-(119,33) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,33)-(119,35) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("is");
                            #line hidden
                            #line (119,35)-(119,36) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,36)-(119,40) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("null");
                            #line hidden
                            #line (119,40)-(119,41) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,41)-(119,43) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("in");
                            #line hidden
                            #line (119,43)-(119,44) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (119,44)-(119,45) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("'");
                            #line hidden
                            #line (119,46)-(119,55) 40 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(assoc.MId);
                            #line hidden
                            #line (119,56)-(119,57) 41 "MofModelToMetaModelGenerator.mxg"
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
            }
            if (!__first14) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (126,9)-(126,41) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateOperation(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first21 = true;
            #line (127,6)-(127,40) 13 "MofModelToMetaModelGenerator.mxg"
            if (!IsPropertyImplementation(op))
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                __cb.Push("");
                #line (128,10)-(128,29) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateComment(op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("");
                #line (129,10)-(129,32) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateReturnType(op));
                #line hidden
                #line (129,33)-(129,34) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (129,35)-(129,57) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(op.Name.ToPascalCase());
                #line hidden
                #line (129,58)-(129,59) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (129,60)-(129,78) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateParams(op));
                #line hidden
                #line (129,79)-(129,80) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first21) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (133,9)-(133,42) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateReturnType(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (134,6)-(134,115) 13 "MofModelToMetaModelGenerator.mxg"
            var returnParam = op.OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Return).FirstOrDefault();
            #line hidden
            
            var __first22 = true;
            #line (135,6)-(135,34) 13 "MofModelToMetaModelGenerator.mxg"
            if (returnParam is not null)
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("");
                #line (136,10)-(136,53) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateType(returnParam, returnParam.Type));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (137,6)-(137,10) 13 "MofModelToMetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("");
                #line (138,9)-(138,13) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (142,9)-(142,38) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateParams(Operation op)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.SingleLineMode = true;
            var __first23 = true;
            #line (144,6)-(144,47) 13 "MofModelToMetaModelGenerator.mxg"
            foreach (var param in op.OwnedParameter) 
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
                    #line (144,57)-(144,61) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                __cb.Push("");
                #line (145,10)-(145,41) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateType(param, param.Type));
                #line hidden
                #line (145,42)-(145,43) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (145,44)-(145,54) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(param.Name);
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
        #line (149,9)-(149,39) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateComment(Element elem)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (150,6)-(150,42) 13 "MofModelToMetaModelGenerator.mxg"
            var lines = CommentLines(elem, true);
            #line hidden
            
            var __first24 = true;
            #line (151,6)-(151,27) 13 "MofModelToMetaModelGenerator.mxg"
            if (lines.Length > 0)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                __cb.Push("");
                #line (152,9)-(152,12) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (152,12)-(152,13) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (152,13)-(152,22) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first25 = true;
                #line (153,10)-(153,37) 17 "MofModelToMetaModelGenerator.mxg"
                foreach (var line in lines)
                #line hidden
                
                {
                    if (__first25)
                    {
                        __first25 = false;
                    }
                    __cb.Push("");
                    #line (154,13)-(154,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (154,16)-(154,17) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (154,18)-(154,22) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(line);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first25) __cb.AppendLine();
                __cb.Push("");
                #line (156,9)-(156,12) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (156,12)-(156,13) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (156,13)-(156,23) 29 "MofModelToMetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first24) __cb.AppendLine();
            var __first26 = true;
            #line (158,6)-(158,31) 13 "MofModelToMetaModelGenerator.mxg"
            if (elem is Operation op)
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                var __first27 = true;
                #line (159,10)-(159,107) 17 "MofModelToMetaModelGenerator.mxg"
                foreach (var param in op.OwnedParameter.Where(p => p.Direction != ParameterDirectionKind.Return))
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    __cb.Push("");
                    #line (160,13)-(160,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (160,16)-(160,17) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,17)-(160,23) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("<param");
                    #line hidden
                    #line (160,23)-(160,24) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (160,24)-(160,30) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("name=\"");
                    #line hidden
                    #line (160,31)-(160,41) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                    #line (160,42)-(160,44) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("\">");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first28 = true;
                    #line (161,14)-(161,61) 21 "MofModelToMetaModelGenerator.mxg"
                    foreach (var line in CommentLines(param, true))
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        __cb.Push("");
                        #line (162,17)-(162,20) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (162,20)-(162,21) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (162,22)-(162,26) 36 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first28) __cb.AppendLine();
                    __cb.Push("");
                    #line (164,13)-(164,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (164,16)-(164,17) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (164,17)-(164,25) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("</param>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first27) __cb.AppendLine();
                var __first29 = true;
                #line (166,10)-(166,107) 17 "MofModelToMetaModelGenerator.mxg"
                foreach (var param in op.OwnedParameter.Where(p => p.Direction == ParameterDirectionKind.Return))
                #line hidden
                
                {
                    if (__first29)
                    {
                        __first29 = false;
                    }
                    __cb.Push("");
                    #line (167,13)-(167,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (167,16)-(167,17) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,17)-(167,26) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("<returns>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first30 = true;
                    #line (168,14)-(168,61) 21 "MofModelToMetaModelGenerator.mxg"
                    foreach (var line in CommentLines(param, true))
                    #line hidden
                    
                    {
                        if (__first30)
                        {
                            __first30 = false;
                        }
                        __cb.Push("");
                        #line (169,17)-(169,20) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (169,20)-(169,21) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (169,22)-(169,26) 36 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first30) __cb.AppendLine();
                    __cb.Push("");
                    #line (171,13)-(171,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (171,16)-(171,17) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (171,17)-(171,27) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("</returns>");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first29) __cb.AppendLine();
                __cb.Push("");
                #line (173,10)-(173,48) 28 "MofModelToMetaModelGenerator.mxg"
                __cb.Write(GenerateSpecification((Operation)elem));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            #line (174,6)-(174,37) 13 "MofModelToMetaModelGenerator.mxg"
            else if (elem is Property prop)
            #line hidden
            
            {
                if (__first26)
                {
                    __first26 = false;
                }
                var __first31 = true;
                #line (175,10)-(175,53) 17 "MofModelToMetaModelGenerator.mxg"
                if (prop.IsDerived && !prop.IsDerivedUnion)
                #line hidden
                
                {
                    if (__first31)
                    {
                        __first31 = false;
                    }
                    var __first32 = true;
                    #line (176,14)-(176,93) 21 "MofModelToMetaModelGenerator.mxg"
                    foreach (var impl in prop.Class.OwnedOperation.Where(o => o.Name == prop.Name))
                    #line hidden
                    
                    {
                        if (__first32)
                        {
                            __first32 = false;
                        }
                        __cb.Push("");
                        #line (177,14)-(177,41) 36 "MofModelToMetaModelGenerator.mxg"
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
        
        #line (183,9)-(183,45) 22 "MofModelToMetaModelGenerator.mxg"
        public string GenerateSpecification(Namespace ns)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            var __first33 = true;
            #line (184,6)-(184,40) 13 "MofModelToMetaModelGenerator.mxg"
            foreach (var rule in ns.OwnedRule)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                var __first34 = true;
                #line (185,10)-(185,58) 17 "MofModelToMetaModelGenerator.mxg"
                if (rule.Specification is OpaqueExpression expr)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    #line (186,14)-(186,50) 21 "MofModelToMetaModelGenerator.mxg"
                    var lines = CommentLines(rule, true);
                    #line hidden
                    
                    var __first35 = true;
                    #line (187,14)-(187,35) 21 "MofModelToMetaModelGenerator.mxg"
                    if (lines.Length > 0)
                    #line hidden
                    
                    {
                        if (__first35)
                        {
                            __first35 = false;
                        }
                        __cb.Push("");
                        #line (188,17)-(188,20) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (188,20)-(188,21) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (188,21)-(188,27) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write("<para>");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                        var __first36 = true;
                        #line (189,18)-(189,45) 25 "MofModelToMetaModelGenerator.mxg"
                        foreach (var line in lines)
                        #line hidden
                        
                        {
                            if (__first36)
                            {
                                __first36 = false;
                            }
                            __cb.Push("");
                            #line (190,21)-(190,24) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write("///");
                            #line hidden
                            #line (190,24)-(190,25) 41 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (190,26)-(190,30) 40 "MofModelToMetaModelGenerator.mxg"
                            __cb.Write(line);
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first36) __cb.AppendLine();
                        __cb.Push("");
                        #line (192,17)-(192,20) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write("///");
                        #line hidden
                        #line (192,20)-(192,21) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (192,21)-(192,28) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write("</para>");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first35) __cb.AppendLine();
                    __cb.Push("");
                    #line (194,13)-(194,15) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write("//");
                    #line hidden
                    #line (194,15)-(194,16) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (194,17)-(194,26) 32 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(rule.Name);
                    #line hidden
                    #line (194,27)-(194,28) 33 "MofModelToMetaModelGenerator.mxg"
                    __cb.Write(":");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    #line (195,14)-(195,47) 21 "MofModelToMetaModelGenerator.mxg"
                    lines = CommentLines(expr, false);
                    #line hidden
                    
                    var __first37 = true;
                    #line (196,14)-(196,41) 21 "MofModelToMetaModelGenerator.mxg"
                    foreach (var line in lines)
                    #line hidden
                    
                    {
                        if (__first37)
                        {
                            __first37 = false;
                        }
                        __cb.Push("");
                        #line (197,17)-(197,19) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write("//");
                        #line hidden
                        #line (197,19)-(197,20) 37 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (197,21)-(197,25) 36 "MofModelToMetaModelGenerator.mxg"
                        __cb.Write(line);
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first37) __cb.AppendLine();
                }
                if (!__first34) __cb.AppendLine();
            }
            if (!__first33) __cb.AppendLine();
            return __cb.ToStringAndFree();
        }
        
    }}