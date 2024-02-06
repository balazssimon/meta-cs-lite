#line (1,10)-(1,50) 10 "MetaModelGenerator.mxg"
namespace MetaDslx.Languages.MetaModel.Generators
#line hidden

{
    #line (3,1)-(3,6) 5 "MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (3,7)-(3,13) 13 "MetaModelGenerator.mxg"
    System;
    #line hidden
    #line (4,1)-(4,6) 5 "MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (4,7)-(4,18) 13 "MetaModelGenerator.mxg"
    System.Linq;
    #line hidden
    #line (5,1)-(5,6) 5 "MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (5,7)-(5,23) 13 "MetaModelGenerator.mxg"
    Roslyn.Utilities;
    #line hidden
    #line (6,1)-(6,6) 5 "MetaModelGenerator.mxg"
    using
    #line hidden
    global::
    #line (6,7)-(6,41) 13 "MetaModelGenerator.mxg"
    MetaDslx.Languages.MetaModel.Model;
    #line hidden
    
    #line (8,10)-(8,29) 25 "MetaModelGenerator.mxg"
    public partial class MetaModelGenerator
    #line hidden
    {
        #line (10,9)-(10,20) 22 "MetaModelGenerator.mxg"
        public string Generate()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (11,1)-(11,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (11,10)-(11,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (11,11)-(11,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (13,1)-(13,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (13,10)-(13,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (13,12)-(13,21) 24 "MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (15,5)-(15,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (15,10)-(15,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,11)-(15,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaMetaModel");
            #line hidden
            #line (15,26)-(15,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,27)-(15,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (15,28)-(15,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (15,29)-(15,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Languages.MetaModel.Model.Meta;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (16,5)-(16,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (16,10)-(16,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,11)-(16,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelFactory");
            #line hidden
            #line (16,29)-(16,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,30)-(16,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (16,31)-(16,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (16,32)-(16,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (17,5)-(17,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (17,10)-(17,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,11)-(17,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (17,18)-(17,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,19)-(17,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (17,20)-(17,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (17,21)-(17,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (18,5)-(18,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (18,10)-(18,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,11)-(18,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (18,22)-(18,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,23)-(18,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (18,24)-(18,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (18,25)-(18,61) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModel;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (19,5)-(19,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (19,10)-(19,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,11)-(19,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (19,25)-(19,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,26)-(19,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (19,27)-(19,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (19,28)-(19,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (20,5)-(20,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (20,10)-(20,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,11)-(20,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            #line (20,25)-(20,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,26)-(20,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (20,27)-(20,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (20,28)-(20,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (21,5)-(21,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (21,10)-(21,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,11)-(21,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            #line (21,30)-(21,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,31)-(21,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (21,32)-(21,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (21,33)-(21,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MultiModelFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (22,5)-(22,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (22,10)-(22,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,11)-(22,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelVersion");
            #line hidden
            #line (22,25)-(22,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,26)-(22,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (22,27)-(22,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (22,28)-(22,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelVersion;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (23,5)-(23,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (23,10)-(23,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,11)-(23,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            #line (23,26)-(23,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,27)-(23,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (23,28)-(23,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (23,29)-(23,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelEnumInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (24,5)-(24,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (24,10)-(24,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,11)-(24,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (24,27)-(24,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,28)-(24,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (24,29)-(24,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (24,30)-(24,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelClassInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (25,5)-(25,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (25,10)-(25,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,11)-(25,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (25,26)-(25,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,27)-(25,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (25,28)-(25,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (25,29)-(25,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelProperty;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (26,5)-(26,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (26,10)-(26,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,11)-(26,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyFlags");
            #line hidden
            #line (26,31)-(26,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,32)-(26,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (26,33)-(26,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (26,34)-(26,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyFlags;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (27,5)-(27,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (27,10)-(27,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,11)-(27,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperation");
            #line hidden
            #line (27,27)-(27,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,28)-(27,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (27,29)-(27,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (27,30)-(27,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (28,5)-(28,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (28,10)-(28,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,11)-(28,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo");
            #line hidden
            #line (28,31)-(28,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,32)-(28,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (28,33)-(28,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (28,34)-(28,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperationInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (29,5)-(29,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (29,10)-(29,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,11)-(29,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray");
            #line hidden
            #line (29,27)-(29,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,28)-(29,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (29,29)-(29,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (29,30)-(29,82) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (30,5)-(30,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (30,10)-(30,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,11)-(30,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary");
            #line hidden
            #line (30,32)-(30,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,33)-(30,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (30,34)-(30,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (30,35)-(30,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (31,5)-(31,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (31,10)-(31,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,11)-(31,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (31,21)-(31,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,22)-(31,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (31,23)-(31,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (31,24)-(31,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (32,5)-(32,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (32,10)-(32,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,11)-(32,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol");
            #line hidden
            #line (32,23)-(32,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,24)-(32,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (32,25)-(32,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (32,26)-(32,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (33,5)-(33,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (33,10)-(33,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,11)-(33,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (33,17)-(33,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,18)-(33,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (33,19)-(33,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (33,20)-(33,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (34,5)-(34,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (34,10)-(34,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,11)-(34,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Enum");
            #line hidden
            #line (34,17)-(34,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,18)-(34,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (34,19)-(34,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (34,20)-(34,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Enum;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (36,6)-(36,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateMetaModel());
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (38,6)-(38,23) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateFactory());
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first1 = true;
            #line (40,6)-(40,32) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first1)
                {
                    __first1 = false;
                }
                __cb.Push("    ");
                #line (41,10)-(41,27) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateEnum(enm));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first1) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first2 = true;
            #line (45,6)-(45,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first2)
                {
                    __first2 = false;
                }
                __cb.Push("    ");
                #line (46,10)-(46,32) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateInterface(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,6)-(50,31) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateCustomInterface());
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (52,6)-(52,36) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateCustomImplementation());
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (53,1)-(53,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (55,1)-(55,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (55,10)-(55,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (55,12)-(55,21) 24 "MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (55,22)-(55,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (56,1)-(56,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (57,5)-(57,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (57,10)-(57,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,11)-(57,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (57,18)-(57,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,19)-(57,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (57,20)-(57,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (57,21)-(57,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (58,5)-(58,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (58,10)-(58,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,11)-(58,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (58,22)-(58,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,23)-(58,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (58,24)-(58,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (58,25)-(58,61) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModel;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (59,5)-(59,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (59,10)-(59,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,11)-(59,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (59,25)-(59,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,26)-(59,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (59,27)-(59,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (59,28)-(59,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (60,5)-(60,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (60,10)-(60,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,11)-(60,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject");
            #line hidden
            #line (60,28)-(60,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,29)-(60,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (60,30)-(60,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (60,31)-(60,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (61,5)-(61,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (61,10)-(61,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,11)-(61,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            #line (61,26)-(61,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,27)-(61,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (61,28)-(61,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (61,29)-(61,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelEnumInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (62,5)-(62,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (62,10)-(62,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,11)-(62,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (62,27)-(62,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,28)-(62,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (62,29)-(62,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (62,30)-(62,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelClassInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (63,5)-(63,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (63,10)-(63,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,11)-(63,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (63,26)-(63,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,27)-(63,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (63,28)-(63,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (63,29)-(63,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelProperty;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (64,5)-(64,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (64,10)-(64,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,11)-(64,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyFlags");
            #line hidden
            #line (64,31)-(64,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,32)-(64,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (64,33)-(64,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (64,34)-(64,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyFlags;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (65,5)-(65,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (65,10)-(65,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,11)-(65,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo");
            #line hidden
            #line (65,30)-(65,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,31)-(65,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (65,32)-(65,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (65,33)-(65,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (66,5)-(66,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (66,10)-(66,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,11)-(66,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertySlot");
            #line hidden
            #line (66,30)-(66,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,31)-(66,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (66,32)-(66,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (66,33)-(66,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertySlot;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (67,5)-(67,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (67,10)-(67,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,11)-(67,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperation");
            #line hidden
            #line (67,27)-(67,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,28)-(67,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (67,29)-(67,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (67,30)-(67,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (68,5)-(68,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (68,10)-(68,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,11)-(68,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo");
            #line hidden
            #line (68,31)-(68,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,32)-(68,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (68,33)-(68,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (68,34)-(68,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperationInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (69,5)-(69,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (69,10)-(69,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,11)-(69,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray");
            #line hidden
            #line (69,27)-(69,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,28)-(69,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (69,29)-(69,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (69,30)-(69,82) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (70,5)-(70,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (70,10)-(70,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,11)-(70,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary");
            #line hidden
            #line (70,32)-(70,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,33)-(70,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (70,34)-(70,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (70,35)-(70,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (71,5)-(71,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (71,10)-(71,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,11)-(71,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (71,21)-(71,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,22)-(71,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (71,23)-(71,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (71,24)-(71,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (72,5)-(72,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (72,10)-(72,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,11)-(72,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol");
            #line hidden
            #line (72,23)-(72,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,24)-(72,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (72,25)-(72,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (72,26)-(72,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (73,5)-(73,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (73,10)-(73,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,11)-(73,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (73,17)-(73,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,18)-(73,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (73,19)-(73,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (73,20)-(73,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (74,5)-(74,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (74,10)-(74,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,11)-(74,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Enum");
            #line hidden
            #line (74,17)-(74,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,18)-(74,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (74,19)-(74,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (74,20)-(74,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Enum;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first3 = true;
            #line (76,6)-(76,32) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first3)
                {
                    __first3 = false;
                }
                __cb.Push("    ");
                #line (77,10)-(77,31) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateEnumInfo(enm));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first3) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first4 = true;
            #line (81,6)-(81,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first4)
                {
                    __first4 = false;
                }
                __cb.Push("    ");
                #line (82,10)-(82,28) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateClass(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.Push("");
            #line (85,1)-(85,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (88,9)-(88,43) 22 "MetaModelGenerator.mxg"
        public string GenerateSeparateIntf(string body)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (89,1)-(89,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (89,10)-(89,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,11)-(89,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (91,1)-(91,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (91,10)-(91,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (91,12)-(91,21) 24 "MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (92,1)-(92,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (93,5)-(93,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (93,10)-(93,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,11)-(93,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaMetaModel");
            #line hidden
            #line (93,26)-(93,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,27)-(93,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (93,28)-(93,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (93,29)-(93,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Languages.MetaModel.Model.Meta;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (94,5)-(94,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (94,10)-(94,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,11)-(94,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelFactory");
            #line hidden
            #line (94,29)-(94,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,30)-(94,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (94,31)-(94,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (94,32)-(94,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Languages.MetaModel.Model.MetaModelFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (95,5)-(95,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (95,10)-(95,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,11)-(95,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (95,18)-(95,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,19)-(95,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (95,20)-(95,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (95,21)-(95,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (96,5)-(96,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (96,10)-(96,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,11)-(96,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (96,22)-(96,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,23)-(96,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (96,24)-(96,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,25)-(96,61) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModel;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (97,5)-(97,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (97,10)-(97,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,11)-(97,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (97,25)-(97,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,26)-(97,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (97,27)-(97,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (97,28)-(97,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (98,5)-(98,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (98,10)-(98,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,11)-(98,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            #line (98,25)-(98,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,26)-(98,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (98,27)-(98,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,28)-(98,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (99,5)-(99,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (99,10)-(99,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,11)-(99,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            #line (99,30)-(99,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,31)-(99,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (99,32)-(99,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,33)-(99,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MultiModelFactory;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (100,5)-(100,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (100,10)-(100,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,11)-(100,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelVersion");
            #line hidden
            #line (100,25)-(100,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,26)-(100,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (100,27)-(100,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,28)-(100,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelVersion;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (101,5)-(101,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (101,10)-(101,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,11)-(101,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            #line (101,26)-(101,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,27)-(101,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (101,28)-(101,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,29)-(101,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelEnumInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (102,5)-(102,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (102,10)-(102,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,11)-(102,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (102,27)-(102,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,28)-(102,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (102,29)-(102,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (102,30)-(102,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelClassInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (103,5)-(103,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (103,10)-(103,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,11)-(103,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (103,26)-(103,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,27)-(103,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (103,28)-(103,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,29)-(103,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelProperty;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (104,5)-(104,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (104,10)-(104,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,11)-(104,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyFlags");
            #line hidden
            #line (104,31)-(104,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,32)-(104,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (104,33)-(104,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,34)-(104,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyFlags;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (105,5)-(105,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (105,10)-(105,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,11)-(105,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperation");
            #line hidden
            #line (105,27)-(105,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,28)-(105,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (105,29)-(105,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (105,30)-(105,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (106,5)-(106,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (106,10)-(106,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,11)-(106,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo");
            #line hidden
            #line (106,31)-(106,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,32)-(106,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (106,33)-(106,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (106,34)-(106,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperationInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (107,5)-(107,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (107,10)-(107,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,11)-(107,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray");
            #line hidden
            #line (107,27)-(107,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,28)-(107,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (107,29)-(107,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (107,30)-(107,82) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (108,5)-(108,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (108,10)-(108,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,11)-(108,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary");
            #line hidden
            #line (108,32)-(108,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,33)-(108,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (108,34)-(108,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (108,35)-(108,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (109,5)-(109,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (109,10)-(109,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,11)-(109,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (109,21)-(109,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,22)-(109,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (109,23)-(109,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (109,24)-(109,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (110,5)-(110,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (110,10)-(110,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,11)-(110,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol");
            #line hidden
            #line (110,23)-(110,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,24)-(110,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (110,25)-(110,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (110,26)-(110,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (111,5)-(111,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (111,10)-(111,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,11)-(111,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (111,17)-(111,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,18)-(111,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (111,19)-(111,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (111,20)-(111,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (112,5)-(112,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (112,10)-(112,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,11)-(112,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Enum");
            #line hidden
            #line (112,17)-(112,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,18)-(112,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (112,19)-(112,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (112,20)-(112,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Enum;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (114,6)-(114,10) 24 "MetaModelGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (115,1)-(115,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (118,9)-(118,43) 22 "MetaModelGenerator.mxg"
        public string GenerateSeparateImpl(string body)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (119,1)-(119,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("#nullable");
            #line hidden
            #line (119,10)-(119,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (119,11)-(119,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("enable");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (121,1)-(121,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("namespace");
            #line hidden
            #line (121,10)-(121,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (121,12)-(121,21) 24 "MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (121,22)-(121,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(".__Impl");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (122,1)-(122,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (123,5)-(123,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (123,10)-(123,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,11)-(123,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (123,18)-(123,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,19)-(123,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (123,20)-(123,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (123,21)-(123,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.Model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (124,5)-(124,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (124,10)-(124,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,11)-(124,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (124,22)-(124,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,23)-(124,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (124,24)-(124,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (124,25)-(124,61) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModel;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (125,5)-(125,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (125,10)-(125,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,11)-(125,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject");
            #line hidden
            #line (125,25)-(125,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,26)-(125,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (125,27)-(125,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (125,28)-(125,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.IModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (126,5)-(126,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (126,10)-(126,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,11)-(126,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject");
            #line hidden
            #line (126,28)-(126,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,29)-(126,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (126,30)-(126,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,31)-(126,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.MetaModelObject;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (127,5)-(127,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (127,10)-(127,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,11)-(127,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            #line (127,26)-(127,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,27)-(127,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (127,28)-(127,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (127,29)-(127,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelEnumInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (128,5)-(128,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (128,10)-(128,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,11)-(128,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (128,27)-(128,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,28)-(128,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (128,29)-(128,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (128,30)-(128,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelClassInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (129,5)-(129,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (129,10)-(129,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,11)-(129,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty");
            #line hidden
            #line (129,26)-(129,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,27)-(129,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (129,28)-(129,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,29)-(129,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelProperty;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (130,5)-(130,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (130,10)-(130,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,11)-(130,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyFlags");
            #line hidden
            #line (130,31)-(130,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,32)-(130,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (130,33)-(130,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (130,34)-(130,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyFlags;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (131,5)-(131,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (131,10)-(131,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,11)-(131,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo");
            #line hidden
            #line (131,30)-(131,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,31)-(131,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (131,32)-(131,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,33)-(131,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertyInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (132,5)-(132,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (132,10)-(132,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,11)-(132,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertySlot");
            #line hidden
            #line (132,30)-(132,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,31)-(132,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (132,32)-(132,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,33)-(132,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelPropertySlot;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (133,5)-(133,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (133,10)-(133,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,11)-(133,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperation");
            #line hidden
            #line (133,27)-(133,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,28)-(133,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (133,29)-(133,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,30)-(133,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperation;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (134,5)-(134,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (134,10)-(134,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,11)-(134,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo");
            #line hidden
            #line (134,31)-(134,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,32)-(134,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (134,33)-(134,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,34)-(134,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.Modeling.ModelOperationInfo;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (135,5)-(135,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (135,10)-(135,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,11)-(135,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray");
            #line hidden
            #line (135,27)-(135,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,28)-(135,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (135,29)-(135,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (135,30)-(135,82) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (136,5)-(136,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (136,10)-(136,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,11)-(136,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary");
            #line hidden
            #line (136,32)-(136,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,33)-(136,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (136,34)-(136,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,35)-(136,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (137,5)-(137,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (137,10)-(137,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,11)-(137,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (137,21)-(137,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,22)-(137,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (137,23)-(137,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,24)-(137,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (138,5)-(138,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (138,10)-(138,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,11)-(138,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol");
            #line hidden
            #line (138,23)-(138,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,24)-(138,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (138,25)-(138,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,26)-(138,67) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::MetaDslx.CodeAnalysis.MetaSymbol;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (139,5)-(139,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (139,10)-(139,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,11)-(139,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Type");
            #line hidden
            #line (139,17)-(139,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,18)-(139,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (139,19)-(139,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,20)-(139,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Type;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (140,5)-(140,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("using");
            #line hidden
            #line (140,10)-(140,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,11)-(140,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Enum");
            #line hidden
            #line (140,17)-(140,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,18)-(140,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (140,19)-(140,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (140,20)-(140,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Enum;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (142,6)-(142,10) 24 "MetaModelGenerator.mxg"
            __cb.Write(body);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (143,1)-(143,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (147,9)-(147,29) 22 "MetaModelGenerator.mxg"
        public string GenerateMetaModel()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (148,1)-(148,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (148,9)-(148,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,10)-(148,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (148,19)-(148,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,20)-(148,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (148,22)-(148,36) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (149,1)-(149,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first5 = true;
            #line (150,6)-(150,77) 13 "MetaModelGenerator.mxg"
            foreach (var c in MetaModel.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("    ");
                #line (151,10)-(151,26) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (151,27)-(151,28) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,29)-(151,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (151,36)-(151,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,37)-(151,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (151,38)-(151,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,39)-(151,43) 29 "MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (151,43)-(151,44) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,44)-(151,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("");
            #line (153,1)-(153,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (155,1)-(155,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (155,7)-(155,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,8)-(155,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (155,14)-(155,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,15)-(155,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (155,20)-(155,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,22)-(155,36) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (155,37)-(155,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,38)-(155,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (155,39)-(155,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,40)-(155,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel,");
            #line hidden
            #line (155,52)-(155,53) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (155,53)-(155,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (155,55)-(155,69) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (156,1)-(156,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (157,5)-(157,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (157,7)-(157,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,8)-(157,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("If");
            #line hidden
            #line (157,10)-(157,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,11)-(157,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("there");
            #line hidden
            #line (157,16)-(157,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,17)-(157,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (157,19)-(157,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,20)-(157,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("an");
            #line hidden
            #line (157,22)-(157,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,23)-(157,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("error");
            #line hidden
            #line (157,28)-(157,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,29)-(157,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("at");
            #line hidden
            #line (157,31)-(157,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,32)-(157,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (157,35)-(157,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,36)-(157,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("following");
            #line hidden
            #line (157,45)-(157,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,46)-(157,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("line,");
            #line hidden
            #line (157,51)-(157,52) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,52)-(157,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("create");
            #line hidden
            #line (157,58)-(157,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,59)-(157,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (157,60)-(157,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,61)-(157,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (157,64)-(157,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,65)-(157,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (157,70)-(157,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,71)-(157,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("called");
            #line hidden
            #line (157,77)-(157,78) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (157,78)-(157,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("'Custom");
            #line hidden
            #line (157,86)-(157,100) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (157,101)-(157,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation'");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (158,5)-(158,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (158,7)-(158,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,8)-(158,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("inheriting");
            #line hidden
            #line (158,18)-(158,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,19)-(158,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("from");
            #line hidden
            #line (158,23)-(158,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,24)-(158,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (158,27)-(158,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,28)-(158,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (158,33)-(158,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,34)-(158,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("'Custom");
            #line hidden
            #line (158,42)-(158,56) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (158,57)-(158,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase'");
            #line hidden
            #line (158,76)-(158,77) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,77)-(158,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (158,80)-(158,81) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,81)-(158,88) 25 "MetaModelGenerator.mxg"
            __cb.Write("provide");
            #line hidden
            #line (158,88)-(158,89) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,89)-(158,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (158,92)-(158,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,93)-(158,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("custom");
            #line hidden
            #line (158,99)-(158,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,100)-(158,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (159,5)-(159,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (159,7)-(159,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,8)-(159,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (159,11)-(159,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,12)-(159,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (159,15)-(159,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,16)-(159,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("derived");
            #line hidden
            #line (159,23)-(159,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,24)-(159,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("properties");
            #line hidden
            #line (159,34)-(159,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,35)-(159,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (159,38)-(159,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,39)-(159,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("operations");
            #line hidden
            #line (159,49)-(159,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,50)-(159,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("defined");
            #line hidden
            #line (159,57)-(159,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,58)-(159,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (159,60)-(159,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,61)-(159,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (159,64)-(159,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (159,65)-(159,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("metamodel");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (160,5)-(160,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (160,13)-(160,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,14)-(160,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (160,20)-(160,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,21)-(160,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (160,29)-(160,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,30)-(160,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (160,37)-(160,51) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (160,52)-(160,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (160,70)-(160,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,71)-(160,83) 25 "MetaModelGenerator.mxg"
            __cb.Write("__CustomImpl");
            #line hidden
            #line (160,83)-(160,84) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,84)-(160,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (160,85)-(160,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,86)-(160,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (160,89)-(160,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,90)-(160,96) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (160,97)-(160,111) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (160,112)-(160,129) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (162,5)-(162,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (162,12)-(162,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,13)-(162,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (162,19)-(162,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,20)-(162,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (162,28)-(162,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,30)-(162,44) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (162,45)-(162,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,46)-(162,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("_instance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (163,5)-(163,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (163,11)-(163,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,12)-(163,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (163,18)-(163,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,20)-(163,34) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (163,35)-(163,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,36)-(163,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("MInstance");
            #line hidden
            #line (163,45)-(163,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,46)-(163,48) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (163,48)-(163,49) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (163,49)-(163,59) 25 "MetaModelGenerator.mxg"
            __cb.Write("_instance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first6 = true;
            #line (165,6)-(165,76) 13 "MetaModelGenerator.mxg"
            foreach (var cls in MetaModel.Parent.Declarations.OfType<MetaClass>())
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                var __first7 = true;
                #line (166,10)-(166,46) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    __cb.Push("    ");
                    #line (167,13)-(167,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (167,20)-(167,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,21)-(167,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (167,27)-(167,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,28)-(167,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (167,36)-(167,37) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,37)-(167,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (167,52)-(167,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (167,53)-(167,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (167,55)-(167,63) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (167,64)-(167,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (167,66)-(167,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (167,76)-(167,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first7) __cb.AppendLine();
                var __first8 = true;
                #line (169,10)-(169,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("    ");
                    #line (170,13)-(170,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (170,20)-(170,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (170,21)-(170,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (170,27)-(170,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (170,28)-(170,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (170,36)-(170,37) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (170,37)-(170,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (170,53)-(170,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (170,54)-(170,55) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (170,56)-(170,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (170,65)-(170,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (170,67)-(170,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (170,75)-(170,76) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (174,5)-(174,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (174,11)-(174,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (174,13)-(174,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (174,28)-(174,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (175,5)-(175,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first9 = true;
            #line (176,10)-(176,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                #line (177,14)-(177,131) 17 "MetaModelGenerator.mxg"
                var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
                #line hidden
                
                var __first10 = true;
                #line (178,14)-(178,62) 17 "MetaModelGenerator.mxg"
                foreach (var prop in metaCls.DeclaredProperties)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (179,17)-(179,18) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (179,19)-(179,27) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (179,28)-(179,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (179,30)-(179,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (179,40)-(179,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,41)-(179,42) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (179,42)-(179,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,43)-(179,46) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (179,46)-(179,47) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,47)-(179,70) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty(typeof(");
                    #line hidden
                    #line (179,71)-(179,79) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (179,80)-(179,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (179,82)-(179,83) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,83)-(179,84) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (179,85)-(179,94) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (179,95)-(179,97) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (179,97)-(179,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,98)-(179,105) 33 "MetaModelGenerator.mxg"
                    __cb.Write("typeof(");
                    #line hidden
                    #line (179,106)-(179,125) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (179,126)-(179,128) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (179,128)-(179,129) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,130)-(179,174) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToDefaultValue(prop.Type, prop.DefaultValue));
                    #line hidden
                    #line (179,175)-(179,176) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (179,176)-(179,177) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (179,178)-(179,198) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Flags));
                    #line hidden
                    #line (179,199)-(179,200) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (179,200)-(179,201) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    var __first11 = true;
                    #line (179,202)-(179,233) 21 "MetaModelGenerator.mxg"
                    if(prop.SymbolProperty is null)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (179,234)-(179,238) 37 "MetaModelGenerator.mxg"
                        __cb.Write("null");
                        #line hidden
                    }
                    #line (179,239)-(179,243) 21 "MetaModelGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (179,244)-(179,245) 37 "MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                        #line (179,246)-(179,265) 36 "MetaModelGenerator.mxg"
                        __cb.Write(prop.SymbolProperty);
                        #line hidden
                        #line (179,266)-(179,267) 37 "MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                    }
                    #line (179,275)-(179,277) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first12 = true;
                #line (181,14)-(181,60) 17 "MetaModelGenerator.mxg"
                foreach (var op in metaCls.DeclaredOperations)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("        ");
                    #line (182,17)-(182,18) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (182,19)-(182,27) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (182,28)-(182,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (182,30)-(182,37) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (182,38)-(182,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,39)-(182,40) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (182,40)-(182,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,41)-(182,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (182,44)-(182,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,45)-(182,69) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation(typeof(");
                    #line hidden
                    #line (182,70)-(182,78) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (182,79)-(182,81) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (182,81)-(182,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,82)-(182,83) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (182,84)-(182,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (182,92)-(182,94) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (182,94)-(182,95) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (182,95)-(182,96) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (182,97)-(182,104) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (182,105)-(182,106) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (182,107)-(182,146) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.UnderlyingOperation.Parameters.Count);
                    #line hidden
                    #line (182,147)-(182,151) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")\");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("        ");
            #line (185,9)-(185,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_instance");
            #line hidden
            #line (185,18)-(185,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (185,19)-(185,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (185,20)-(185,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (185,21)-(185,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (185,24)-(185,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (185,26)-(185,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (185,41)-(185,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (186,5)-(186,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (188,5)-(188,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (188,12)-(188,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (188,13)-(188,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (188,21)-(188,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (188,22)-(188,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (188,29)-(188,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (188,30)-(188,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (190,5)-(190,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (190,12)-(190,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (190,13)-(190,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (190,21)-(190,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (190,22)-(190,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (190,85)-(190,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (190,86)-(190,97) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (191,5)-(191,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (191,12)-(191,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,13)-(191,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (191,21)-(191,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,22)-(191,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (191,90)-(191,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (191,91)-(191,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (192,5)-(192,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (192,12)-(192,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,13)-(192,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (192,21)-(192,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,22)-(192,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (192,90)-(192,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,91)-(192,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (192,107)-(192,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (192,108)-(192,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (193,5)-(193,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (193,12)-(193,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,13)-(193,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (193,21)-(193,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,22)-(193,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (193,86)-(193,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,87)-(193,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (193,103)-(193,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (193,104)-(193,121) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (195,5)-(195,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (195,12)-(195,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,13)-(195,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (195,21)-(195,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,22)-(195,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (195,85)-(195,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (195,86)-(195,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (196,5)-(196,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (196,12)-(196,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,13)-(196,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (196,21)-(196,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,22)-(196,91) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (196,91)-(196,92) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (196,92)-(196,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (197,5)-(197,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (197,12)-(197,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,13)-(197,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (197,21)-(197,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,22)-(197,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (197,90)-(197,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,91)-(197,108) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (197,108)-(197,109) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (197,109)-(197,127) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (198,5)-(198,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (198,12)-(198,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,13)-(198,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (198,21)-(198,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,22)-(198,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (198,86)-(198,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,87)-(198,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (198,104)-(198,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (198,105)-(198,123) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first13 = true;
            #line (200,6)-(200,77) 13 "MetaModelGenerator.mxg"
            foreach (var c in MetaModel.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("    ");
                #line (201,9)-(201,16) 29 "MetaModelGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (201,16)-(201,17) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,17)-(201,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (201,25)-(201,26) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,27)-(201,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (201,44)-(201,45) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (201,45)-(201,46) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (201,47)-(201,67) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (201,68)-(201,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (204,5)-(204,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (204,12)-(204,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,14)-(204,28) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (204,29)-(204,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (205,5)-(205,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (206,9)-(206,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes");
            #line hidden
            #line (206,19)-(206,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,20)-(206,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (206,21)-(206,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,22)-(206,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first14 = true;
            #line (206,59)-(206,86) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums) 
            #line hidden
            
            {
                if (__first14)
                {
                    __first14 = false;
                }
                else
                {
                    __cb.Push("        ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (206,96)-(206,100) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (206,101)-(206,108) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (206,109)-(206,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (206,118)-(206,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (206,132)-(206,134) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (207,9)-(207,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos");
            #line hidden
            #line (207,19)-(207,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,20)-(207,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (207,21)-(207,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,22)-(207,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelEnumInfo>(");
            #line hidden
            var __first15 = true;
            #line (207,64)-(207,91) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums) 
            #line hidden
            
            {
                if (__first15)
                {
                    __first15 = false;
                }
                else
                {
                    __cb.Push("        ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (207,101)-(207,105) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (207,107)-(207,115) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (207,116)-(207,120) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (207,133)-(207,135) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (208,9)-(208,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (208,12)-(208,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,13)-(208,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType");
            #line hidden
            #line (208,28)-(208,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,29)-(208,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (208,30)-(208,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,31)-(208,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (208,78)-(208,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (208,79)-(208,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first16 = true;
            #line (209,10)-(209,36) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                __cb.Push("        ");
                #line (210,13)-(210,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("enumInfosByType.Add(typeof(");
                #line hidden
                #line (210,41)-(210,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (210,50)-(210,52) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (210,52)-(210,53) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (210,54)-(210,62) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (210,63)-(210,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("        ");
            #line (212,9)-(212,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType");
            #line hidden
            #line (212,25)-(212,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,26)-(212,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (212,27)-(212,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,28)-(212,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (213,9)-(213,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (213,12)-(213,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,13)-(213,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName");
            #line hidden
            #line (213,28)-(213,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,29)-(213,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (213,30)-(213,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,31)-(213,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (213,74)-(213,75) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (213,75)-(213,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first17 = true;
            #line (214,10)-(214,36) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                __cb.Push("        ");
                #line (215,13)-(215,34) 29 "MetaModelGenerator.mxg"
                __cb.Write("enumInfosByName.Add(\"");
                #line hidden
                #line (215,35)-(215,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (215,44)-(215,46) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (215,46)-(215,47) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (215,48)-(215,56) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (215,57)-(215,63) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first17) __cb.AppendLine();
            __cb.Push("        ");
            #line (217,9)-(217,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName");
            #line hidden
            #line (217,25)-(217,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,26)-(217,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (217,27)-(217,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,28)-(217,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (219,9)-(219,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes");
            #line hidden
            #line (219,20)-(219,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,21)-(219,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (219,22)-(219,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (219,23)-(219,59) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first18 = true;
            #line (219,60)-(219,89) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes) 
            #line hidden
            
            {
                if (__first18)
                {
                    __first18 = false;
                }
                else
                {
                    __cb.Push("        ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (219,99)-(219,103) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (219,104)-(219,111) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (219,112)-(219,120) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (219,121)-(219,122) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (219,135)-(219,137) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (220,9)-(220,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos");
            #line hidden
            #line (220,20)-(220,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,21)-(220,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (220,22)-(220,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (220,23)-(220,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first19 = true;
            #line (220,66)-(220,95) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes) 
            #line hidden
            
            {
                if (__first19)
                {
                    __first19 = false;
                }
                else
                {
                    __cb.Push("        ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (220,105)-(220,109) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (220,111)-(220,119) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (220,120)-(220,124) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (220,137)-(220,139) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (221,9)-(221,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (221,12)-(221,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,13)-(221,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByType");
            #line hidden
            #line (221,29)-(221,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,30)-(221,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (221,31)-(221,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,32)-(221,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (221,79)-(221,80) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (221,80)-(221,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first20 = true;
            #line (222,10)-(222,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                __cb.Push("        ");
                #line (223,13)-(223,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("classInfosByType.Add(typeof(");
                #line hidden
                #line (223,42)-(223,50) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (223,51)-(223,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (223,53)-(223,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (223,55)-(223,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (223,64)-(223,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first20) __cb.AppendLine();
            __cb.Push("        ");
            #line (225,9)-(225,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType");
            #line hidden
            #line (225,26)-(225,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,27)-(225,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (225,28)-(225,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (225,29)-(225,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByType.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (226,9)-(226,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (226,12)-(226,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,13)-(226,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByName");
            #line hidden
            #line (226,29)-(226,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,30)-(226,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (226,31)-(226,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,32)-(226,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (226,75)-(226,76) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (226,76)-(226,96) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first21 = true;
            #line (227,10)-(227,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                __cb.Push("        ");
                #line (228,13)-(228,35) 29 "MetaModelGenerator.mxg"
                __cb.Write("classInfosByName.Add(\"");
                #line hidden
                #line (228,36)-(228,44) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (228,45)-(228,47) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (228,47)-(228,48) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,49)-(228,57) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (228,58)-(228,64) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first21) __cb.AppendLine();
            __cb.Push("        ");
            #line (230,9)-(230,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName");
            #line hidden
            #line (230,26)-(230,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,27)-(230,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (230,28)-(230,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (230,29)-(230,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (231,9)-(231,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model");
            #line hidden
            #line (231,15)-(231,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,16)-(231,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (231,17)-(231,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,18)-(231,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (231,21)-(231,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (231,22)-(231,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (232,9)-(232,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (232,12)-(232,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,13)-(232,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("cf");
            #line hidden
            #line (232,15)-(232,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,16)-(232,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (232,17)-(232,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,18)-(232,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (232,21)-(232,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,23)-(232,37) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (232,38)-(232,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(_model,");
            #line hidden
            #line (232,58)-(232,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (232,59)-(232,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first22 = true;
            #line (233,10)-(233,81) 13 "MetaModelGenerator.mxg"
            foreach (var c in MetaModel.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("        ");
                #line (234,13)-(234,14) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (234,15)-(234,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (234,36)-(234,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (234,37)-(234,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (234,38)-(234,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (234,39)-(234,42) 29 "MetaModelGenerator.mxg"
                __cb.Write("cf.");
                #line hidden
                #line (234,43)-(234,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Type.Name);
                #line hidden
                #line (234,55)-(234,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            __cb.Push("        ");
            #line (236,9)-(236,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (236,12)-(236,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (236,13)-(236,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("f");
            #line hidden
            #line (236,14)-(236,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (236,15)-(236,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (236,16)-(236,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first23 = true;
            #line (236,18)-(236,38) 13 "MetaModelGenerator.mxg"
            if (IsMetaMetaModel)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (236,39)-(236,42) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (236,42)-(236,43) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (236,43)-(236,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaModelFactory(_model,");
                #line hidden
                #line (236,69)-(236,70) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (236,70)-(236,75) 29 "MetaModelGenerator.mxg"
                __cb.Write("this)");
                #line hidden
            }
            #line (236,76)-(236,80) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (236,81)-(236,84) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (236,84)-(236,85) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (236,85)-(236,111) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaModelFactory(_model)");
                #line hidden
            }
            #line (236,119)-(236,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first24 = true;
            #line (237,10)-(237,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                __cb.Push("        ");
                #line (238,13)-(238,16) 29 "MetaModelGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (238,16)-(238,17) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (238,18)-(238,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetName(obj));
                #line hidden
                #line (238,31)-(238,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (238,32)-(238,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (238,33)-(238,34) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (238,34)-(238,36) 29 "MetaModelGenerator.mxg"
                __cb.Write("f.");
                #line hidden
                #line (238,37)-(238,60) 28 "MetaModelGenerator.mxg"
                __cb.Write(obj.MInfo.MetaType.Name);
                #line hidden
                #line (238,61)-(238,64) 29 "MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first24) __cb.AppendLine();
            __cb.Push("        ");
            #line (240,9)-(240,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("__CustomImpl.");
            #line hidden
            #line (240,23)-(240,37) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (240,38)-(240,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first25 = true;
            #line (241,10)-(241,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                var __first26 = true;
                #line (242,14)-(242,50) 17 "MetaModelGenerator.mxg"
                foreach (var child in obj.MChildren)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    __cb.Push("        ");
                    #line (243,18)-(243,30) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetName(obj));
                    #line hidden
                    #line (243,31)-(243,46) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".MChildren.Add(");
                    #line hidden
                    #line (243,47)-(243,61) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetName(child));
                    #line hidden
                    #line (243,62)-(243,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first26) __cb.AppendLine();
                var __first27 = true;
                #line (245,14)-(245,62) 17 "MetaModelGenerator.mxg"
                foreach (var prop in obj.MInfo.PublicProperties)
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    #line (246,18)-(246,47) 21 "MetaModelGenerator.mxg"
                    var slot = obj.MGetSlot(prop);
                    #line hidden
                    
                    var __first28 = true;
                    #line (247,18)-(247,54) 21 "MetaModelGenerator.mxg"
                    if (slot != null && !slot.IsDefault)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        var __first29 = true;
                        #line (248,22)-(248,44) 25 "MetaModelGenerator.mxg"
                        if (prop.IsCollection)
                        #line hidden
                        
                        {
                            if (__first29)
                            {
                                __first29 = false;
                            }
                            var __first30 = true;
                            #line (249,26)-(249,60) 29 "MetaModelGenerator.mxg"
                            foreach (var value in slot.Values)
                            #line hidden
                            
                            {
                                if (__first30)
                                {
                                    __first30 = false;
                                }
                                __cb.Push("        ");
                                #line (250,30)-(250,42) 44 "MetaModelGenerator.mxg"
                                __cb.Write(GetName(obj));
                                #line hidden
                                #line (250,43)-(250,44) 45 "MetaModelGenerator.mxg"
                                __cb.Write(".");
                                #line hidden
                                #line (250,45)-(250,54) 44 "MetaModelGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (250,55)-(250,60) 45 "MetaModelGenerator.mxg"
                                __cb.Write(".Add(");
                                #line hidden
                                #line (250,61)-(250,92) 44 "MetaModelGenerator.mxg"
                                __cb.Write(ToCSharpValue(prop.Type, value));
                                #line hidden
                                #line (250,93)-(250,95) 45 "MetaModelGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.AppendLine();
                                __cb.Pop();
                            }
                            if (!__first30) __cb.AppendLine();
                        }
                        #line (252,22)-(252,48) 25 "MetaModelGenerator.mxg"
                        else if (!prop.IsReadOnly)
                        #line hidden
                        
                        {
                            if (__first29)
                            {
                                __first29 = false;
                            }
                            __cb.Push("        ");
                            #line (253,26)-(253,38) 40 "MetaModelGenerator.mxg"
                            __cb.Write(GetName(obj));
                            #line hidden
                            #line (253,39)-(253,40) 41 "MetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (253,41)-(253,50) 40 "MetaModelGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (253,51)-(253,52) 41 "MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (253,52)-(253,53) 41 "MetaModelGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (253,53)-(253,54) 41 "MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (253,55)-(253,103) 40 "MetaModelGenerator.mxg"
                            __cb.Write(ToCSharpValue(prop.Type, slot.AsSingle()?.Value));
                            #line hidden
                            #line (253,104)-(253,105) 41 "MetaModelGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.AppendLine();
                            __cb.Pop();
                        }
                        if (!__first29) __cb.AppendLine();
                    }
                    if (!__first28) __cb.AppendLine();
                }
                if (!__first27) __cb.AppendLine();
            }
            if (!__first25) __cb.AppendLine();
            __cb.Push("        ");
            #line (258,9)-(258,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model.IsSealed");
            #line hidden
            #line (258,24)-(258,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,25)-(258,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (258,26)-(258,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (258,27)-(258,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (259,5)-(259,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (261,5)-(261,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (261,11)-(261,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,12)-(261,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (261,20)-(261,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,21)-(261,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (261,27)-(261,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,28)-(261,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("MName");
            #line hidden
            #line (261,33)-(261,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,34)-(261,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (261,36)-(261,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,37)-(261,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("nameof(");
            #line hidden
            #line (261,45)-(261,59) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (261,60)-(261,62) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (262,5)-(262,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (262,11)-(262,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,12)-(262,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (262,20)-(262,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,21)-(262,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (262,27)-(262,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,28)-(262,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("MNamespace");
            #line hidden
            #line (262,38)-(262,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,39)-(262,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (262,41)-(262,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,42)-(262,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (262,44)-(262,53) 24 "MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (262,54)-(262,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (263,5)-(263,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (263,11)-(263,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,12)-(263,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (263,20)-(263,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,21)-(263,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelVersion");
            #line hidden
            #line (263,35)-(263,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,36)-(263,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MVersion");
            #line hidden
            #line (263,44)-(263,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,45)-(263,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (263,47)-(263,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (263,48)-(263,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("default;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (264,5)-(264,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (264,11)-(264,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,12)-(264,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (264,20)-(264,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,21)-(264,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (264,27)-(264,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,28)-(264,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("MUri");
            #line hidden
            #line (264,32)-(264,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,33)-(264,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (264,35)-(264,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,36)-(264,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (264,38)-(264,73) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Uri ?? MetaModel.FullName);
            #line hidden
            #line (264,74)-(264,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (265,5)-(265,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (265,11)-(265,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,12)-(265,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (265,20)-(265,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,21)-(265,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (265,27)-(265,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,28)-(265,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("MPrefix");
            #line hidden
            #line (265,35)-(265,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,36)-(265,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (265,38)-(265,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (265,39)-(265,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (265,41)-(265,127) 24 "MetaModelGenerator.mxg"
            __cb.Write(string.Concat(MetaModel.Name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c))));
            #line hidden
            #line (265,128)-(265,130) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (266,5)-(266,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (266,11)-(266,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,12)-(266,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (266,20)-(266,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,21)-(266,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (266,28)-(266,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,29)-(266,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("MModel");
            #line hidden
            #line (266,35)-(266,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,36)-(266,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (266,38)-(266,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,39)-(266,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (268,5)-(268,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (268,11)-(268,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,12)-(268,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (268,20)-(268,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,21)-(268,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (268,89)-(268,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,90)-(268,106) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (268,106)-(268,107) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,107)-(268,123) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByType");
            #line hidden
            #line (268,123)-(268,124) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,124)-(268,126) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (268,126)-(268,127) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (268,127)-(268,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (269,5)-(269,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (269,11)-(269,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,12)-(269,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (269,20)-(269,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,21)-(269,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (269,85)-(269,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,86)-(269,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (269,102)-(269,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,103)-(269,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByName");
            #line hidden
            #line (269,119)-(269,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,120)-(269,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (269,122)-(269,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (269,123)-(269,140) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (270,5)-(270,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (270,11)-(270,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,12)-(270,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (270,20)-(270,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,21)-(270,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (270,89)-(270,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,90)-(270,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (270,107)-(270,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,108)-(270,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByType");
            #line hidden
            #line (270,125)-(270,126) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,126)-(270,128) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (270,128)-(270,129) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (270,129)-(270,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (271,5)-(271,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (271,11)-(271,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,12)-(271,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (271,20)-(271,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,21)-(271,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (271,85)-(271,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,86)-(271,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (271,103)-(271,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,104)-(271,121) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByName");
            #line hidden
            #line (271,121)-(271,122) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,122)-(271,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (271,124)-(271,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (271,125)-(271,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (273,5)-(273,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (273,11)-(273,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,12)-(273,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (273,20)-(273,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,21)-(273,84) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (273,84)-(273,85) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,85)-(273,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumTypes");
            #line hidden
            #line (273,95)-(273,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,96)-(273,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (273,98)-(273,99) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (273,99)-(273,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (274,5)-(274,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (274,11)-(274,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,12)-(274,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (274,20)-(274,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,21)-(274,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (274,89)-(274,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,90)-(274,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfos");
            #line hidden
            #line (274,100)-(274,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,101)-(274,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (274,103)-(274,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (274,104)-(274,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (275,5)-(275,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (275,11)-(275,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,12)-(275,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (275,20)-(275,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,21)-(275,84) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (275,84)-(275,85) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,85)-(275,96) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassTypes");
            #line hidden
            #line (275,96)-(275,97) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,97)-(275,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (275,99)-(275,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (275,100)-(275,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (276,5)-(276,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (276,11)-(276,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,12)-(276,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (276,20)-(276,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,21)-(276,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (276,90)-(276,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,91)-(276,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfos");
            #line hidden
            #line (276,102)-(276,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,103)-(276,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (276,105)-(276,106) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (276,106)-(276,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first31 = true;
            #line (278,6)-(278,77) 13 "MetaModelGenerator.mxg"
            foreach (var c in MetaModel.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first31)
                {
                    __first31 = false;
                }
                __cb.Push("    ");
                #line (279,10)-(279,26) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (279,27)-(279,28) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (279,28)-(279,29) 29 "MetaModelGenerator.mxg"
                __cb.Write("I");
                #line hidden
                #line (279,30)-(279,44) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (279,45)-(279,46) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (279,47)-(279,53) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (279,54)-(279,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (279,55)-(279,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (279,57)-(279,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (279,58)-(279,59) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (279,60)-(279,80) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (279,81)-(279,82) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first31) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first32 = true;
            #line (282,6)-(282,77) 13 "MetaModelGenerator.mxg"
            foreach (var c in MetaModel.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("    ");
                #line (283,10)-(283,36) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(c));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (284,9)-(284,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (284,15)-(284,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (284,16)-(284,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (284,22)-(284,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (284,24)-(284,40) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (284,41)-(284,42) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (284,43)-(284,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (284,50)-(284,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (284,51)-(284,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (284,53)-(284,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (284,54)-(284,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("((I");
                #line hidden
                #line (284,58)-(284,72) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (284,73)-(284,85) 29 "MetaModelGenerator.mxg"
                __cb.Write(")MInstance).");
                #line hidden
                #line (284,86)-(284,92) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (284,93)-(284,94) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first33 = true;
            #line (287,6)-(287,32) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("    ");
                #line (288,9)-(288,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (288,15)-(288,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,16)-(288,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (288,22)-(288,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,23)-(288,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelEnumInfo");
                #line hidden
                #line (288,38)-(288,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,40)-(288,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (288,49)-(288,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (288,53)-(288,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,54)-(288,56) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (288,56)-(288,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (288,57)-(288,66) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.__");
                #line hidden
                #line (288,67)-(288,75) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (288,76)-(288,91) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Info.Instance;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first33) __cb.AppendLine();
            var __first34 = true;
            #line (290,6)-(290,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
                }
                __cb.Push("    ");
                #line (291,9)-(291,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (291,15)-(291,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,16)-(291,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (291,22)-(291,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,23)-(291,39) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelClassInfo");
                #line hidden
                #line (291,39)-(291,40) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,41)-(291,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (291,50)-(291,54) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (291,54)-(291,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,55)-(291,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (291,57)-(291,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (291,58)-(291,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.");
                #line hidden
                #line (291,66)-(291,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (291,75)-(291,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Impl.__Info.Instance;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first35 = true;
                #line (292,6)-(292,42) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.Push("    ");
                    #line (293,9)-(293,15) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (293,15)-(293,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,16)-(293,22) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (293,22)-(293,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,23)-(293,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (293,38)-(293,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,40)-(293,48) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (293,49)-(293,50) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (293,51)-(293,60) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (293,61)-(293,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,62)-(293,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (293,64)-(293,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (293,65)-(293,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (293,67)-(293,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (293,76)-(293,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (293,78)-(293,87) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (293,88)-(293,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
                var __first36 = true;
                #line (295,6)-(295,40) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
                    }
                    __cb.Push("    ");
                    #line (296,9)-(296,15) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (296,15)-(296,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (296,16)-(296,22) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (296,22)-(296,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (296,23)-(296,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (296,39)-(296,40) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (296,41)-(296,49) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (296,50)-(296,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (296,52)-(296,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (296,60)-(296,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (296,61)-(296,63) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (296,63)-(296,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (296,64)-(296,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (296,66)-(296,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (296,75)-(296,76) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (296,77)-(296,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (296,85)-(296,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first36) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
            __cb.Push("");
            #line (299,1)-(299,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (302,9)-(302,27) 22 "MetaModelGenerator.mxg"
        public string GenerateFactory()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (303,1)-(303,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (303,7)-(303,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,8)-(303,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (303,13)-(303,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,15)-(303,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (303,30)-(303,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory");
            #line hidden
            #line (303,42)-(303,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,43)-(303,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (303,44)-(303,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (303,45)-(303,59) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (304,1)-(304,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (305,5)-(305,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (305,11)-(305,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,13)-(305,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (305,28)-(305,48) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (305,48)-(305,49) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,49)-(305,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("model)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (306,9)-(306,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (306,10)-(306,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,11)-(306,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (306,22)-(306,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,24)-(306,38) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (306,39)-(306,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (307,5)-(307,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (308,5)-(308,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (310,5)-(310,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (310,13)-(310,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,15)-(310,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (310,30)-(310,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (310,50)-(310,51) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,51)-(310,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (310,57)-(310,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,59)-(310,73) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (310,74)-(310,75) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,75)-(310,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (311,9)-(311,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (311,10)-(311,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,11)-(311,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (311,22)-(311,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,23)-(311,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (312,5)-(312,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (313,5)-(313,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (315,6)-(315,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (316,10)-(316,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (317,9)-(317,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (317,15)-(317,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,17)-(317,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (317,31)-(317,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,33)-(317,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (317,42)-(317,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(string?");
                #line hidden
                #line (317,50)-(317,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,51)-(317,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (317,53)-(317,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,54)-(317,55) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (317,55)-(317,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,56)-(317,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (318,9)-(318,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (319,13)-(319,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (319,19)-(319,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (319,20)-(319,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (319,22)-(319,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (319,36)-(319,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (319,38)-(319,52) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (319,53)-(319,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (319,55)-(319,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (319,64)-(319,87) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(base.Model,");
                #line hidden
                #line (319,87)-(319,88) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (319,88)-(319,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (320,9)-(320,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (323,1)-(323,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (325,1)-(325,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (325,7)-(325,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,8)-(325,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (325,13)-(325,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,15)-(325,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (325,30)-(325,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory");
            #line hidden
            #line (325,47)-(325,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,48)-(325,49) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (325,49)-(325,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (325,50)-(325,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (326,1)-(326,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (327,5)-(327,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (327,11)-(327,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (327,13)-(327,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (327,28)-(327,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (328,9)-(328,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (328,10)-(328,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,11)-(328,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(new");
            #line hidden
            #line (328,19)-(328,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,20)-(328,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (328,32)-(328,36) 24 "MetaModelGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (328,37)-(328,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,38)-(328,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (328,39)-(328,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,41)-(328,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (328,56)-(328,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance");
            #line hidden
            #line (328,66)-(328,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,67)-(328,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("})");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (329,5)-(329,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (330,5)-(330,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (332,6)-(332,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (333,10)-(333,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (334,9)-(334,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (334,15)-(334,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (334,17)-(334,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (334,31)-(334,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (334,33)-(334,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (334,42)-(334,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(__Model");
                #line hidden
                #line (334,50)-(334,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (334,51)-(334,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("model,");
                #line hidden
                #line (334,57)-(334,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (334,58)-(334,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("string?");
                #line hidden
                #line (334,65)-(334,66) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (334,66)-(334,68) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (334,68)-(334,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (334,69)-(334,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (334,70)-(334,71) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (334,71)-(334,76) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (335,9)-(335,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (336,13)-(336,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (336,19)-(336,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,20)-(336,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (336,22)-(336,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (336,36)-(336,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (336,38)-(336,52) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (336,53)-(336,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (336,55)-(336,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (336,64)-(336,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(model,");
                #line hidden
                #line (336,82)-(336,83) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (336,83)-(336,88) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (337,9)-(337,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (340,1)-(340,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (344,9)-(344,36) 22 "MetaModelGenerator.mxg"
        public string GenerateEnum(MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (345,2)-(345,30) 24 "MetaModelGenerator.mxg"
            __cb.Write(GetDocumentationComment(enm));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (346,1)-(346,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (346,7)-(346,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (346,8)-(346,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (346,12)-(346,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (346,14)-(346,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (347,1)-(347,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first39 = true;
            #line (348,6)-(348,39) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("    ");
                #line (349,10)-(349,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(lit));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (350,10)-(350,18) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (350,19)-(350,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            __cb.Push("");
            #line (352,1)-(352,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (355,9)-(355,40) 22 "MetaModelGenerator.mxg"
        public string GenerateEnumInfo(MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (356,1)-(356,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (356,9)-(356,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,10)-(356,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (356,15)-(356,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,16)-(356,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (356,19)-(356,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (356,28)-(356,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (356,33)-(356,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,34)-(356,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (356,35)-(356,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (356,36)-(356,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (357,1)-(357,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (358,5)-(358,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (358,11)-(358,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,12)-(358,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (358,18)-(358,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,19)-(358,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (358,27)-(358,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,28)-(358,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (358,31)-(358,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (358,40)-(358,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (358,45)-(358,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,46)-(358,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (358,54)-(358,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,55)-(358,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (358,56)-(358,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,57)-(358,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (358,60)-(358,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (358,61)-(358,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (358,64)-(358,72) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (358,73)-(358,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (360,5)-(360,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (360,12)-(360,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,13)-(360,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (360,21)-(360,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,22)-(360,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (360,81)-(360,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (360,82)-(360,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (361,5)-(361,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (361,12)-(361,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,13)-(361,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (361,21)-(361,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,22)-(361,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (361,86)-(361,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,87)-(361,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (361,100)-(361,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (361,101)-(361,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (363,5)-(363,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (363,12)-(363,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (363,13)-(363,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (363,16)-(363,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (363,25)-(363,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (364,5)-(364,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (365,9)-(365,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals");
            #line hidden
            #line (365,18)-(365,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (365,19)-(365,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (365,20)-(365,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (365,21)-(365,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<string>(");
            #line hidden
            var __first40 = true;
            #line (365,54)-(365,88) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals) 
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                else
                {
                    __cb.Push("        ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (365,98)-(365,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (365,104)-(365,142) 28 "MetaModelGenerator.mxg"
                __cb.Write(StringUtilities.EncodeString(lit.Name));
                #line hidden
            }
            #line (365,156)-(365,158) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (366,9)-(366,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (366,12)-(366,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,13)-(366,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName");
            #line hidden
            #line (366,27)-(366,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,28)-(366,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (366,29)-(366,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,30)-(366,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (366,73)-(366,74) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (366,74)-(366,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first41 = true;
            #line (367,10)-(367,43) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("        ");
                #line (368,13)-(368,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("literalsByName.Add(\"");
                #line hidden
                #line (368,34)-(368,42) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (368,43)-(368,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (368,45)-(368,46) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (368,46)-(368,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaSymbol.FromValue(");
                #line hidden
                #line (368,70)-(368,78) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (368,79)-(368,80) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (368,81)-(368,89) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (368,90)-(368,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("        ");
            #line (370,9)-(370,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName");
            #line hidden
            #line (370,24)-(370,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,25)-(370,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (370,26)-(370,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (370,27)-(370,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (371,5)-(371,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (373,5)-(373,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (373,11)-(373,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,12)-(373,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (373,20)-(373,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,21)-(373,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (373,32)-(373,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,33)-(373,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (373,42)-(373,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,43)-(373,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (373,45)-(373,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (373,47)-(373,61) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (373,62)-(373,73) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (374,5)-(374,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (374,11)-(374,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,12)-(374,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (374,20)-(374,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,21)-(374,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (374,31)-(374,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,32)-(374,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (374,40)-(374,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,41)-(374,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (374,43)-(374,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (374,44)-(374,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (374,52)-(374,60) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (374,61)-(374,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (375,5)-(375,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (375,11)-(375,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,12)-(375,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (375,20)-(375,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,21)-(375,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (375,80)-(375,81) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,81)-(375,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("Literals");
            #line hidden
            #line (375,89)-(375,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,90)-(375,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (375,92)-(375,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (375,93)-(375,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (376,5)-(376,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (376,14)-(376,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,15)-(376,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (376,23)-(376,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,24)-(376,88) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (376,88)-(376,89) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,89)-(376,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (376,102)-(376,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,103)-(376,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("LiteralsByName");
            #line hidden
            #line (376,117)-(376,118) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,118)-(376,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (376,120)-(376,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (376,121)-(376,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (377,1)-(377,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (380,9)-(380,42) 22 "MetaModelGenerator.mxg"
        public string GenerateInterface(MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (381,2)-(381,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (382,2)-(382,30) 24 "MetaModelGenerator.mxg"
            __cb.Write(GetDocumentationComment(cls));
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            #line (383,1)-(383,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (383,7)-(383,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,8)-(383,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (383,17)-(383,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,19)-(383,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first42 = true;
            #line (383,29)-(383,53) 13 "MetaModelGenerator.mxg"
            if (cls.BaseTypes.Any())
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (383,54)-(383,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (383,55)-(383,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (383,56)-(383,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first43 = true;
                #line (383,58)-(383,92) 17 "MetaModelGenerator.mxg"
                foreach (var bt in cls.BaseTypes) 
                #line hidden
                
                {
                    if (__first43)
                    {
                        __first43 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (383,102)-(383,106) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (383,107)-(383,115) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::");
                    #line hidden
                    #line (383,116)-(383,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(bt.FullName);
                    #line hidden
                }
            }
            #line (383,142)-(383,146) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (383,147)-(383,148) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (383,148)-(383,149) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (383,149)-(383,150) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (383,150)-(383,164) 29 "MetaModelGenerator.mxg"
                __cb.Write("__IModelObject");
                #line hidden
            }
            if (!__first42) __cb.AppendLine();
            __cb.Push("");
            #line (384,1)-(384,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first44 = true;
            #line (385,6)-(385,54) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (386,10)-(386,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                __cb.Push("    ");
                #line (387,10)-(387,58) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(prop.UnderlyingProperty));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                var __first45 = true;
                #line (388,10)-(388,47) 17 "MetaModelGenerator.mxg"
                if (info.HiddenProperties.Length > 0)
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    #line (388,48)-(388,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (388,51)-(388,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (388,61)-(388,182) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                #line hidden
                #line (388,183)-(388,184) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (388,185)-(388,194) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (388,195)-(388,196) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (388,196)-(388,197) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (388,197)-(388,198) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (388,198)-(388,202) 29 "MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (388,202)-(388,203) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first46 = true;
                #line (388,204)-(388,224) 17 "MetaModelGenerator.mxg"
                if (HasSetter(prop))
                #line hidden
                
                {
                    if (__first46)
                    {
                        __first46 = false;
                    }
                    #line (388,225)-(388,229) 33 "MetaModelGenerator.mxg"
                    __cb.Write("set;");
                    #line hidden
                    #line (388,229)-(388,230) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (388,238)-(388,239) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first47 = true;
            #line (391,6)-(391,40) 13 "MetaModelGenerator.mxg"
            foreach (var op in cls.Operations)
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("    ");
                #line (392,10)-(392,37) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(op));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (393,10)-(393,39) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.ReturnType));
                #line hidden
                #line (393,40)-(393,41) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (393,42)-(393,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (393,50)-(393,51) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first48 = true;
                #line (393,52)-(393,89) 17 "MetaModelGenerator.mxg"
                foreach (var param in op.Parameters) 
                #line hidden
                
                {
                    if (__first48)
                    {
                        __first48 = false;
                    }
                    else
                    {
                        __cb.Push("    ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (393,99)-(393,103) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (393,105)-(393,131) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (393,132)-(393,133) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (393,134)-(393,144) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (393,158)-(393,160) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            __cb.Push("");
            #line (395,1)-(395,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (398,9)-(398,38) 22 "MetaModelGenerator.mxg"
        public string GenerateClass(MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (399,2)-(399,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (400,1)-(400,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (400,9)-(400,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,10)-(400,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (400,15)-(400,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,17)-(400,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (400,26)-(400,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl");
            #line hidden
            #line (400,31)-(400,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,32)-(400,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (400,33)-(400,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,34)-(400,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject,");
            #line hidden
            #line (400,52)-(400,53) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,54)-(400,62) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (401,1)-(401,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (402,5)-(402,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (402,12)-(402,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,14)-(402,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (402,23)-(402,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(string?");
            #line hidden
            #line (402,36)-(402,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,37)-(402,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("id)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (403,9)-(403,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (403,10)-(403,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,11)-(403,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(id)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (404,5)-(404,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first49 = true;
            #line (405,10)-(405,45) 13 "MetaModelGenerator.mxg"
            foreach (var slot in metaCls.Slots)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                #line (406,14)-(406,103) 17 "MetaModelGenerator.mxg"
                var defaultValue = ToDefaultValue(slot.SlotProperty.Type, slot.SlotProperty.DefaultValue);
                #line hidden
                
                var __first50 = true;
                #line (407,14)-(407,83) 17 "MetaModelGenerator.mxg"
                if (!string.IsNullOrEmpty(defaultValue) && defaultValue != "default")
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("        ");
                    #line (408,17)-(408,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write("((__IModelObject)this).MGetSlot(");
                    #line hidden
                    #line (408,50)-(408,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty));
                    #line hidden
                    #line (408,78)-(408,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")?.Add((");
                    #line hidden
                    #line (408,87)-(408,119) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty.Type));
                    #line hidden
                    #line (408,120)-(408,121) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (408,122)-(408,134) 32 "MetaModelGenerator.mxg"
                    __cb.Write(defaultValue);
                    #line hidden
                    #line (408,135)-(408,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first50) __cb.AppendLine();
            }
            if (!__first49) __cb.AppendLine();
            var __first51 = true;
            #line (411,10)-(411,66) 13 "MetaModelGenerator.mxg"
            foreach (var baseType in metaCls.AllBaseTypes.Reverse())
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("        ");
                #line (412,14)-(412,28) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (412,29)-(412,43) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (412,44)-(412,57) 28 "MetaModelGenerator.mxg"
                __cb.Write(baseType.Name);
                #line hidden
                #line (412,58)-(412,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            __cb.Push("        ");
            #line (414,10)-(414,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (414,25)-(414,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(".__CustomImpl.");
            #line hidden
            #line (414,40)-(414,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (414,49)-(414,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (415,5)-(415,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (417,5)-(417,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (417,11)-(417,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,12)-(417,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (417,20)-(417,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,21)-(417,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (417,37)-(417,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,38)-(417,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("MInfo");
            #line hidden
            #line (417,43)-(417,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,44)-(417,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (417,46)-(417,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (417,47)-(417,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info.Instance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first52 = true;
            #line (419,6)-(419,57) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                #line (420,10)-(420,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                var __first53 = true;
                #line (421,10)-(421,54) 17 "MetaModelGenerator.mxg"
                if (metaCls.PublicProperties.Contains(prop))
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (422,13)-(422,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (422,19)-(422,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (422,21)-(422,142) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (422,143)-(422,144) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (422,145)-(422,154) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (423,10)-(423,14) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (424,14)-(424,17) 32 "MetaModelGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (424,18)-(424,119) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)");
                    #line hidden
                    #line (424,120)-(424,123) 32 "MetaModelGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (425,14)-(425,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (425,136)-(425,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (425,138)-(425,181) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.DeclaringType.UnderlyingType));
                    #line hidden
                    #line (425,182)-(425,183) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (425,184)-(425,193) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                if (!__first53) __cb.AppendLine();
                __cb.Push("    ");
                #line (427,9)-(427,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                var __first54 = true;
                #line (428,14)-(428,52) 17 "MetaModelGenerator.mxg"
                if (prop.UnderlyingProperty.IsDerived)
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    #line (429,18)-(429,81) 21 "MetaModelGenerator.mxg"
                    var actualProp = info.HidingProperties.FirstOrDefault() ?? prop;
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (430,17)-(430,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (430,20)-(430,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (430,21)-(430,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (430,23)-(430,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (430,25)-(430,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(MetaModel.Name);
                    #line hidden
                    #line (430,40)-(430,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".__CustomImpl.");
                    #line hidden
                    #line (430,55)-(430,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.DeclaringType.Name);
                    #line hidden
                    #line (430,85)-(430,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (430,87)-(430,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.Name);
                    #line hidden
                    #line (430,103)-(430,110) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (431,14)-(431,41) 17 "MetaModelGenerator.mxg"
                else if (prop.IsCollection)
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    __cb.Push("        ");
                    #line (432,17)-(432,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (432,20)-(432,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (432,21)-(432,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (432,23)-(432,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (432,24)-(432,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGetCollection<");
                    #line hidden
                    #line (432,40)-(432,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (432,60)-(432,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (432,63)-(432,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (432,78)-(432,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                }
                #line (433,14)-(433,18) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    __cb.Push("        ");
                    #line (434,17)-(434,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (434,20)-(434,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,21)-(434,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (434,23)-(434,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (434,24)-(434,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGet<");
                    #line hidden
                    #line (434,30)-(434,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (434,69)-(434,71) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (434,72)-(434,86) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (434,87)-(434,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    var __first55 = true;
                    #line (435,18)-(435,38) 21 "MetaModelGenerator.mxg"
                    if (HasSetter(prop))
                    #line hidden
                    
                    {
                        if (__first55)
                        {
                            __first55 = false;
                        }
                        __cb.Push("        ");
                        #line (436,21)-(436,24) 37 "MetaModelGenerator.mxg"
                        __cb.Write("set");
                        #line hidden
                        #line (436,24)-(436,25) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (436,25)-(436,27) 37 "MetaModelGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (436,27)-(436,28) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (436,28)-(436,33) 37 "MetaModelGenerator.mxg"
                        __cb.Write("MSet<");
                        #line hidden
                        #line (436,34)-(436,72) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                        #line hidden
                        #line (436,73)-(436,75) 37 "MetaModelGenerator.mxg"
                        __cb.Write(">(");
                        #line hidden
                        #line (436,76)-(436,90) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop));
                        #line hidden
                        #line (436,91)-(436,92) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (436,92)-(436,93) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (436,93)-(436,100) 37 "MetaModelGenerator.mxg"
                        __cb.Write("value);");
                        #line hidden
                        __cb.AppendLine();
                        __cb.Pop();
                    }
                    if (!__first55) __cb.AppendLine();
                }
                if (!__first54) __cb.AppendLine();
                __cb.Push("    ");
                #line (439,9)-(439,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first52) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first56 = true;
            #line (443,6)-(443,55) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first56)
                {
                    __first56 = false;
                }
                #line (444,10)-(444,52) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                #line (445,10)-(445,73) 17 "MetaModelGenerator.mxg"
                var actualOp = info.OverridingOperations.FirstOrDefault() ?? op;
                #line hidden
                
                __cb.Push("    ");
                #line (446,10)-(446,59) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.UnderlyingOperation.ReturnType));
                #line hidden
                #line (446,60)-(446,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (446,62)-(446,103) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.DeclaringType.UnderlyingType));
                #line hidden
                #line (446,104)-(446,105) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (446,106)-(446,113) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (446,114)-(446,115) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first57 = true;
                #line (446,116)-(446,173) 17 "MetaModelGenerator.mxg"
                foreach (var param in op.UnderlyingOperation.Parameters) 
                #line hidden
                
                {
                    if (__first57)
                    {
                        __first57 = false;
                    }
                    else
                    {
                        __cb.Push("    ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (446,183)-(446,187) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (446,189)-(446,215) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (446,216)-(446,217) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (446,218)-(446,228) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (446,242)-(446,243) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (446,243)-(446,244) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (446,244)-(446,246) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (446,246)-(446,247) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (446,248)-(446,262) 28 "MetaModelGenerator.mxg"
                __cb.Write(MetaModel.Name);
                #line hidden
                #line (446,263)-(446,277) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (446,278)-(446,305) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.DeclaringType.Name);
                #line hidden
                #line (446,306)-(446,307) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (446,308)-(446,321) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.Name);
                #line hidden
                #line (446,322)-(446,327) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this");
                #line hidden
                var __first58 = true;
                #line (446,328)-(446,390) 17 "MetaModelGenerator.mxg"
                foreach (var param in actualOp.UnderlyingOperation.Parameters)
                #line hidden
                
                {
                    if (__first58)
                    {
                        __first58 = false;
                    }
                    #line (446,391)-(446,392) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (446,392)-(446,393) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (446,394)-(446,404) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (446,418)-(446,420) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first56) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (449,5)-(449,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (449,13)-(449,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,14)-(449,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (449,19)-(449,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,20)-(449,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (449,26)-(449,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,27)-(449,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (449,28)-(449,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (449,29)-(449,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (450,5)-(450,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (451,9)-(451,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (451,15)-(451,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,16)-(451,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (451,22)-(451,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,23)-(451,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (451,31)-(451,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,32)-(451,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (451,38)-(451,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,39)-(451,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (451,47)-(451,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,48)-(451,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (451,49)-(451,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,50)-(451,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (451,53)-(451,54) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,54)-(451,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (453,9)-(453,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (453,16)-(453,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,17)-(453,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (453,25)-(453,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,26)-(453,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (453,95)-(453,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (453,96)-(453,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (454,9)-(454,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (454,16)-(454,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (454,17)-(454,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (454,25)-(454,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (454,26)-(454,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (454,95)-(454,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (454,96)-(454,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (455,9)-(455,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (455,16)-(455,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,17)-(455,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (455,25)-(455,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,26)-(455,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (455,94)-(455,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,95)-(455,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (456,9)-(456,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (456,16)-(456,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (456,17)-(456,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (456,25)-(456,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (456,26)-(456,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (456,94)-(456,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (456,95)-(456,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (457,9)-(457,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (457,16)-(457,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,17)-(457,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (457,25)-(457,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,26)-(457,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (457,94)-(457,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,95)-(457,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (458,9)-(458,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (458,16)-(458,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (458,17)-(458,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (458,25)-(458,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (458,26)-(458,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (458,90)-(458,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (458,91)-(458,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (458,107)-(458,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (458,108)-(458,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (459,9)-(459,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (459,16)-(459,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,17)-(459,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (459,25)-(459,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,26)-(459,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (459,99)-(459,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,100)-(459,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (459,120)-(459,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,121)-(459,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (460,9)-(460,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (460,16)-(460,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,17)-(460,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (460,25)-(460,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,26)-(460,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (460,95)-(460,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (460,96)-(460,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (461,9)-(461,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (461,16)-(461,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,17)-(461,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (461,25)-(461,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,26)-(461,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (461,95)-(461,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,96)-(461,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (462,9)-(462,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (462,16)-(462,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,17)-(462,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (462,25)-(462,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,26)-(462,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (462,95)-(462,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,96)-(462,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (463,9)-(463,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (463,16)-(463,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,17)-(463,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (463,25)-(463,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,26)-(463,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (463,100)-(463,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,101)-(463,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (463,122)-(463,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,123)-(463,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (465,9)-(465,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (465,16)-(465,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (465,17)-(465,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info()");
            #line hidden
            #line (465,25)-(465,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (466,9)-(466,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (467,13)-(467,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes");
            #line hidden
            #line (467,23)-(467,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,24)-(467,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (467,25)-(467,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,26)-(467,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first59 = true;
            #line (467,69)-(467,107) 13 "MetaModelGenerator.mxg"
            foreach (var bt in metaCls.BaseTypes) 
            #line hidden
            
            {
                if (__first59)
                {
                    __first59 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (467,117)-(467,121) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (467,123)-(467,135) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (467,149)-(467,151) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (468,13)-(468,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes");
            #line hidden
            #line (468,26)-(468,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (468,27)-(468,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (468,28)-(468,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (468,29)-(468,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first60 = true;
            #line (468,72)-(468,113) 13 "MetaModelGenerator.mxg"
            foreach (var bt in metaCls.AllBaseTypes) 
            #line hidden
            
            {
                if (__first60)
                {
                    __first60 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (468,123)-(468,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (468,129)-(468,141) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (468,155)-(468,157) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (469,13)-(469,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties");
            #line hidden
            #line (469,32)-(469,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,33)-(469,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (469,34)-(469,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,35)-(469,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first61 = true;
            #line (469,77)-(469,126) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties) 
            #line hidden
            
            {
                if (__first61)
                {
                    __first61 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (469,136)-(469,140) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (469,142)-(469,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (469,170)-(469,172) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (470,13)-(470,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties");
            #line hidden
            #line (470,35)-(470,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (470,36)-(470,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (470,37)-(470,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (470,38)-(470,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first62 = true;
            #line (470,80)-(470,132) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties) 
            #line hidden
            
            {
                if (__first62)
                {
                    __first62 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (470,142)-(470,146) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (470,148)-(470,162) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (470,176)-(470,178) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (471,13)-(471,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties");
            #line hidden
            #line (471,30)-(471,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (471,31)-(471,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (471,32)-(471,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (471,33)-(471,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first63 = true;
            #line (471,75)-(471,122) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties) 
            #line hidden
            
            {
                if (__first63)
                {
                    __first63 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (471,132)-(471,136) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (471,138)-(471,152) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (471,166)-(471,168) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (472,13)-(472,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (472,16)-(472,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,17)-(472,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName");
            #line hidden
            #line (472,39)-(472,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,40)-(472,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (472,41)-(472,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,42)-(472,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (472,85)-(472,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (472,86)-(472,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first64 = true;
            #line (473,14)-(473,60) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties)
            #line hidden
            
            {
                if (__first64)
                {
                    __first64 = false;
                }
                __cb.Push("            ");
                #line (474,17)-(474,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("publicPropertiesByName.Add(\"");
                #line hidden
                #line (474,46)-(474,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (474,56)-(474,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (474,58)-(474,59) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (474,60)-(474,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (474,75)-(474,77) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first64) __cb.AppendLine();
            __cb.Push("            ");
            #line (476,13)-(476,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName");
            #line hidden
            #line (476,36)-(476,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (476,37)-(476,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (476,38)-(476,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (476,39)-(476,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (477,13)-(477,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (477,16)-(477,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,17)-(477,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos");
            #line hidden
            #line (477,35)-(477,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,36)-(477,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (477,37)-(477,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,38)-(477,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelProperty,");
            #line hidden
            #line (477,90)-(477,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (477,91)-(477,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first65 = true;
            #line (478,14)-(478,65) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first65)
                {
                    __first65 = false;
                }
                #line (479,18)-(479,61) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                #line (480,18)-(480,38) 17 "MetaModelGenerator.mxg"
                var slot = info.Slot;
                #line hidden
                
                __cb.Push("            ");
                #line (481,17)-(481,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelPropertyInfos.Add(");
                #line hidden
                #line (481,41)-(481,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (481,56)-(481,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,57)-(481,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,58)-(481,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (481,61)-(481,62) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,62)-(481,85) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertyInfo(new");
                #line hidden
                #line (481,85)-(481,86) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,86)-(481,106) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertySlot(");
                #line hidden
                #line (481,107)-(481,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperty));
                #line hidden
                #line (481,135)-(481,136) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,136)-(481,137) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,138)-(481,167) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperties));
                #line hidden
                #line (481,168)-(481,169) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,169)-(481,170) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,171)-(481,215) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToDefaultValue(prop.Type, prop.DefaultValue));
                #line hidden
                #line (481,216)-(481,217) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,217)-(481,218) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,219)-(481,239) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.Flags));
                #line hidden
                #line (481,240)-(481,242) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (481,242)-(481,243) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,244)-(481,277) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OppositeProperties));
                #line hidden
                #line (481,278)-(481,279) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,279)-(481,280) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,281)-(481,315) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettedProperties));
                #line hidden
                #line (481,316)-(481,317) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,317)-(481,318) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,319)-(481,354) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettingProperties));
                #line hidden
                #line (481,355)-(481,356) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,356)-(481,357) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,358)-(481,392) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefinedProperties));
                #line hidden
                #line (481,393)-(481,394) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,394)-(481,395) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,396)-(481,431) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefiningProperties));
                #line hidden
                #line (481,432)-(481,433) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,433)-(481,434) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,435)-(481,466) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HiddenProperties));
                #line hidden
                #line (481,467)-(481,468) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (481,468)-(481,469) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (481,470)-(481,501) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HidingProperties));
                #line hidden
                #line (481,502)-(481,505) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first65) __cb.AppendLine();
            __cb.Push("            ");
            #line (483,13)-(483,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos");
            #line hidden
            #line (483,32)-(483,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (483,33)-(483,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (483,34)-(483,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (483,35)-(483,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (485,13)-(485,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations");
            #line hidden
            #line (485,32)-(485,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (485,33)-(485,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (485,34)-(485,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (485,35)-(485,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first66 = true;
            #line (485,78)-(485,125) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.DeclaredOperations) 
            #line hidden
            
            {
                if (__first66)
                {
                    __first66 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (485,135)-(485,139) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (485,141)-(485,153) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (485,167)-(485,169) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (486,13)-(486,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations");
            #line hidden
            #line (486,35)-(486,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,36)-(486,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (486,37)-(486,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (486,38)-(486,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first67 = true;
            #line (486,81)-(486,131) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations) 
            #line hidden
            
            {
                if (__first67)
                {
                    __first67 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (486,141)-(486,145) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (486,147)-(486,159) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (486,173)-(486,175) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (487,13)-(487,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations");
            #line hidden
            #line (487,30)-(487,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (487,31)-(487,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (487,32)-(487,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (487,33)-(487,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first68 = true;
            #line (487,76)-(487,121) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.PublicOperations) 
            #line hidden
            
            {
                if (__first68)
                {
                    __first68 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (487,131)-(487,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (487,137)-(487,149) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (487,163)-(487,165) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (488,13)-(488,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (488,16)-(488,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,17)-(488,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos");
            #line hidden
            #line (488,36)-(488,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,37)-(488,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (488,38)-(488,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,39)-(488,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelOperation,");
            #line hidden
            #line (488,92)-(488,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (488,93)-(488,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            var __first69 = true;
            #line (489,14)-(489,63) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (490,14)-(490,56) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                __cb.Push("                ");
                #line (491,17)-(491,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelOperationInfos.Add(");
                #line hidden
                #line (491,42)-(491,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
                #line (491,55)-(491,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (491,56)-(491,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (491,57)-(491,60) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (491,60)-(491,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (491,61)-(491,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelOperationInfo(");
                #line hidden
                #line (491,83)-(491,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridenOperations));
                #line hidden
                #line (491,118)-(491,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (491,119)-(491,120) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (491,121)-(491,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridingOperations));
                #line hidden
                #line (491,157)-(491,160) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
            }
            if (!__first69) __cb.AppendLine();
            __cb.Push("            ");
            #line (493,13)-(493,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos");
            #line hidden
            #line (493,33)-(493,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,34)-(493,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (493,35)-(493,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (493,36)-(493,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos.ToImmutable();");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (494,9)-(494,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (496,9)-(496,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (496,15)-(496,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,16)-(496,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (496,24)-(496,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,25)-(496,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (496,36)-(496,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,37)-(496,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (496,46)-(496,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,47)-(496,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (496,49)-(496,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (496,51)-(496,65) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (496,66)-(496,77) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (497,9)-(497,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (497,15)-(497,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,16)-(497,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (497,24)-(497,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,25)-(497,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (497,35)-(497,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,36)-(497,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (497,44)-(497,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,45)-(497,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (497,47)-(497,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,48)-(497,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (497,56)-(497,64) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (497,65)-(497,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (499,9)-(499,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (499,15)-(499,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,16)-(499,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (499,24)-(499,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,25)-(499,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (499,35)-(499,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,36)-(499,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (499,46)-(499,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,47)-(499,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (499,49)-(499,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first70 = true;
            #line (499,51)-(499,82) 13 "MetaModelGenerator.mxg"
            if (metaCls.SymbolType is null)
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (499,83)-(499,90) 29 "MetaModelGenerator.mxg"
                __cb.Write("default");
                #line hidden
            }
            #line (499,91)-(499,95) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (499,96)-(499,103) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (499,104)-(499,132) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.SymbolType));
                #line hidden
                #line (499,133)-(499,134) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (499,142)-(499,143) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (500,9)-(500,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (500,15)-(500,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,16)-(500,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (500,24)-(500,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,25)-(500,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (500,41)-(500,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,42)-(500,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("NameProperty");
            #line hidden
            #line (500,54)-(500,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,55)-(500,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (500,57)-(500,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first71 = true;
            #line (500,59)-(500,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.NameProperty is null)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (500,93)-(500,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (500,98)-(500,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (500,104)-(500,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.NameProperty));
                #line hidden
            }
            #line (500,143)-(500,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (501,9)-(501,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (501,15)-(501,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,16)-(501,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (501,24)-(501,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,25)-(501,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (501,41)-(501,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,42)-(501,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("TypeProperty");
            #line hidden
            #line (501,54)-(501,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,55)-(501,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (501,57)-(501,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first72 = true;
            #line (501,59)-(501,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.TypeProperty is null)
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (501,93)-(501,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (501,98)-(501,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (501,104)-(501,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.TypeProperty));
                #line hidden
            }
            #line (501,143)-(501,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (502,9)-(502,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (502,15)-(502,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,16)-(502,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (502,24)-(502,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,25)-(502,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (502,94)-(502,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,95)-(502,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("BaseTypes");
            #line hidden
            #line (502,104)-(502,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,105)-(502,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (502,107)-(502,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,108)-(502,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (503,9)-(503,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (503,15)-(503,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,16)-(503,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (503,24)-(503,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,25)-(503,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (503,94)-(503,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,95)-(503,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllBaseTypes");
            #line hidden
            #line (503,107)-(503,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,108)-(503,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (503,110)-(503,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (503,111)-(503,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (504,9)-(504,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (504,15)-(504,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,16)-(504,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (504,24)-(504,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,25)-(504,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (504,93)-(504,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,94)-(504,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredProperties");
            #line hidden
            #line (504,112)-(504,113) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,113)-(504,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (504,115)-(504,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,116)-(504,136) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (505,9)-(505,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (505,15)-(505,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,16)-(505,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (505,24)-(505,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,25)-(505,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (505,93)-(505,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,94)-(505,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredProperties");
            #line hidden
            #line (505,115)-(505,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,116)-(505,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (505,118)-(505,119) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,119)-(505,142) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (506,9)-(506,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (506,15)-(506,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,16)-(506,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (506,24)-(506,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,25)-(506,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (506,93)-(506,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,94)-(506,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicProperties");
            #line hidden
            #line (506,110)-(506,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,111)-(506,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (506,113)-(506,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,114)-(506,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (507,9)-(507,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (507,15)-(507,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,16)-(507,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (507,24)-(507,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,25)-(507,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (507,94)-(507,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,95)-(507,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredOperations");
            #line hidden
            #line (507,113)-(507,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,114)-(507,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (507,116)-(507,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,117)-(507,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (508,9)-(508,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (508,15)-(508,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,16)-(508,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (508,24)-(508,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,25)-(508,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (508,94)-(508,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,95)-(508,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredOperations");
            #line hidden
            #line (508,116)-(508,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,117)-(508,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (508,119)-(508,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (508,120)-(508,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (509,9)-(509,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (509,15)-(509,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,16)-(509,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (509,24)-(509,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,25)-(509,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (509,94)-(509,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,95)-(509,111) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicOperations");
            #line hidden
            #line (509,111)-(509,112) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,112)-(509,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (509,114)-(509,115) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (509,115)-(509,133) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (511,9)-(511,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (511,18)-(511,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,19)-(511,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (511,27)-(511,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,28)-(511,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (511,92)-(511,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,93)-(511,109) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (511,109)-(511,110) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,110)-(511,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicPropertiesByName");
            #line hidden
            #line (511,132)-(511,133) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,133)-(511,135) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (511,135)-(511,136) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (511,136)-(511,160) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (512,9)-(512,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (512,18)-(512,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,19)-(512,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (512,27)-(512,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,28)-(512,101) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (512,101)-(512,102) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,102)-(512,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (512,122)-(512,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,123)-(512,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelPropertyInfos");
            #line hidden
            #line (512,141)-(512,142) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,142)-(512,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (512,144)-(512,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (512,145)-(512,165) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (513,9)-(513,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (513,18)-(513,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,19)-(513,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (513,27)-(513,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,28)-(513,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (513,102)-(513,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,103)-(513,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (513,124)-(513,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,125)-(513,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelOperationInfos");
            #line hidden
            #line (513,144)-(513,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,145)-(513,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (513,147)-(513,148) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (513,148)-(513,169) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (515,9)-(515,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (515,15)-(515,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,16)-(515,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (515,24)-(515,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,25)-(515,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (515,40)-(515,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,41)-(515,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("Create(__Model?");
            #line hidden
            #line (515,56)-(515,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,57)-(515,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (515,62)-(515,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,63)-(515,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (515,64)-(515,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,65)-(515,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (515,70)-(515,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,71)-(515,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (515,78)-(515,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,79)-(515,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("id");
            #line hidden
            #line (515,81)-(515,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,82)-(515,83) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (515,83)-(515,84) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (515,84)-(515,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (516,9)-(516,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (517,13)-(517,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (517,16)-(517,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,17)-(517,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (517,23)-(517,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,24)-(517,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (517,25)-(517,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,26)-(517,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (517,29)-(517,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (517,31)-(517,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (517,40)-(517,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(id);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (518,13)-(518,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (518,15)-(518,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,16)-(518,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("(model");
            #line hidden
            #line (518,22)-(518,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,23)-(518,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (518,25)-(518,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,26)-(518,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (518,29)-(518,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,30)-(518,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (518,35)-(518,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (518,36)-(518,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("model.AttachObject(result);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (519,13)-(519,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (519,19)-(519,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (519,20)-(519,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (520,9)-(520,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (522,9)-(522,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (522,15)-(522,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,16)-(522,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (522,24)-(522,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,25)-(522,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (522,31)-(522,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (522,32)-(522,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ToString()");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (523,9)-(523,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (524,13)-(524,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (524,19)-(524,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (524,20)-(524,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (524,22)-(524,36) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (524,37)-(524,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(".");
            #line hidden
            #line (524,39)-(524,47) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (524,48)-(524,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Info\";");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (525,9)-(525,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (526,5)-(526,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (527,1)-(527,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (530,9)-(530,35) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomInterface()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (531,1)-(531,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (531,9)-(531,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (531,10)-(531,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (531,19)-(531,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (531,20)-(531,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (531,28)-(531,42) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (531,43)-(531,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (532,1)-(532,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (533,5)-(533,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (533,8)-(533,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (533,9)-(533,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (534,5)-(534,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (534,8)-(534,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,9)-(534,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (534,20)-(534,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,21)-(534,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (534,24)-(534,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,25)-(534,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (534,28)-(534,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,29)-(534,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (534,33)-(534,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,34)-(534,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (534,39)-(534,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (534,41)-(534,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (535,5)-(535,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (535,8)-(535,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (535,9)-(535,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (536,5)-(536,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (536,9)-(536,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,11)-(536,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (536,26)-(536,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (536,29)-(536,43) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (536,44)-(536,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (536,45)-(536,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this);");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (538,6)-(538,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("    ");
                #line (539,9)-(539,13) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (539,13)-(539,14) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (539,15)-(539,23) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (539,24)-(539,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (539,26)-(539,34) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (539,35)-(539,36) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (539,36)-(539,43) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this);");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first73) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first74 = true;
            #line (543,6)-(543,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first74)
                {
                    __first74 = false;
                }
                var __first75 = true;
                #line (544,10)-(544,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first75)
                    {
                        __first75 = false;
                    }
                    __cb.Push("    ");
                    #line (545,14)-(545,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (545,40)-(545,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (545,42)-(545,50) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (545,51)-(545,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (545,53)-(545,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (545,63)-(545,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (545,65)-(545,73) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (545,74)-(545,75) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (545,75)-(545,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first75) __cb.AppendLine();
            }
            if (!__first74) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first76 = true;
            #line (550,6)-(550,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                var __first77 = true;
                #line (551,10)-(551,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    __cb.Push("    ");
                    #line (552,14)-(552,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (552,44)-(552,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (552,46)-(552,54) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (552,55)-(552,56) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (552,57)-(552,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (552,65)-(552,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (552,67)-(552,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (552,76)-(552,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (552,77)-(552,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first78 = true;
                    #line (552,83)-(552,119) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first78)
                        {
                            __first78 = false;
                        }
                        #line (552,120)-(552,121) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (552,121)-(552,122) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (552,123)-(552,149) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (552,150)-(552,151) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (552,152)-(552,162) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (552,176)-(552,178) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first77) __cb.AppendLine();
            }
            if (!__first76) __cb.AppendLine();
            __cb.Push("");
            #line (556,1)-(556,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (559,9)-(559,40) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomImplementation()
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (560,1)-(560,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (560,9)-(560,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (560,10)-(560,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (560,18)-(560,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (560,19)-(560,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (560,24)-(560,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (560,25)-(560,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (560,32)-(560,46) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (560,47)-(560,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (560,65)-(560,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (560,66)-(560,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (560,67)-(560,68) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (560,68)-(560,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (560,76)-(560,90) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (560,91)-(560,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("");
            #line (561,1)-(561,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (562,5)-(562,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (562,8)-(562,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (562,9)-(562,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (563,5)-(563,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (563,8)-(563,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,9)-(563,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (563,20)-(563,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,21)-(563,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (563,24)-(563,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,25)-(563,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (563,28)-(563,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,29)-(563,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (563,33)-(563,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,34)-(563,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (563,39)-(563,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (563,41)-(563,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (564,5)-(564,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (564,8)-(564,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (564,9)-(564,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (565,5)-(565,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (565,11)-(565,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,12)-(565,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (565,19)-(565,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,20)-(565,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (565,24)-(565,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,26)-(565,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (565,41)-(565,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (565,44)-(565,58) 24 "MetaModelGenerator.mxg"
            __cb.Write(MetaModel.Name);
            #line hidden
            #line (565,59)-(565,60) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (565,60)-(565,66) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this)");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (566,5)-(566,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (567,5)-(567,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first79 = true;
            #line (569,6)-(569,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                __cb.Push("    ");
                #line (570,10)-(570,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetDocumentationComment(cls));
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (571,9)-(571,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (571,15)-(571,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (571,16)-(571,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("virtual");
                #line hidden
                #line (571,23)-(571,24) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (571,24)-(571,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (571,28)-(571,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (571,30)-(571,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (571,39)-(571,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (571,41)-(571,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (571,50)-(571,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (571,51)-(571,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this)");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (572,9)-(572,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (573,9)-(573,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.AppendLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first79) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first80 = true;
            #line (577,6)-(577,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first80)
                {
                    __first80 = false;
                }
                var __first81 = true;
                #line (578,10)-(578,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first81)
                    {
                        __first81 = false;
                    }
                    __cb.Push("    ");
                    #line (579,14)-(579,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetDocumentationComment(prop));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (580,13)-(580,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (580,19)-(580,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (580,20)-(580,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (580,28)-(580,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (580,30)-(580,55) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (580,56)-(580,57) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (580,58)-(580,66) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (580,67)-(580,68) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (580,69)-(580,78) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (580,79)-(580,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (580,81)-(580,89) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (580,90)-(580,91) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (580,91)-(580,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first81) __cb.AppendLine();
            }
            if (!__first80) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first82 = true;
            #line (585,6)-(585,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first82)
                {
                    __first82 = false;
                }
                var __first83 = true;
                #line (586,10)-(586,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("    ");
                    #line (587,14)-(587,41) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetDocumentationComment(op));
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (588,13)-(588,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (588,19)-(588,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (588,20)-(588,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (588,28)-(588,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (588,30)-(588,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (588,60)-(588,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (588,62)-(588,70) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (588,71)-(588,72) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (588,73)-(588,80) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (588,81)-(588,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (588,83)-(588,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (588,92)-(588,93) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (588,93)-(588,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first84 = true;
                    #line (588,99)-(588,135) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first84)
                        {
                            __first84 = false;
                        }
                        #line (588,136)-(588,137) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (588,137)-(588,138) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (588,139)-(588,165) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (588,166)-(588,167) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (588,168)-(588,178) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (588,192)-(588,194) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.AppendLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first83) __cb.AppendLine();
            }
            if (!__first82) __cb.AppendLine();
            __cb.Push("");
            #line (592,1)-(592,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.AppendLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}