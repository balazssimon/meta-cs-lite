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
            __cb.WriteLine();
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
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (14,1)-(14,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (36,6)-(36,34) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateMetaModel(MetaModel));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (38,6)-(38,32) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateFactory(MetaModel));
            #line hidden
            __cb.WriteLine();
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
                #line (41,10)-(41,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateEnum(MetaModel, enm));
                #line hidden
                __cb.WriteLine();
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
                #line (46,10)-(46,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateInterface(MetaModel, cls));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first2) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (50,6)-(50,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateCustomInterface(MetaModel));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (52,6)-(52,45) 24 "MetaModelGenerator.mxg"
            __cb.Write(GenerateCustomImplementation(MetaModel));
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (53,1)-(53,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
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
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (56,1)-(56,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
            __cb.WriteLine();
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
                #line (77,10)-(77,42) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateEnumInfo(MetaModel, enm));
                #line hidden
                __cb.WriteLine();
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
                #line (82,10)-(82,39) 28 "MetaModelGenerator.mxg"
                __cb.Write(GenerateClass(MetaModel, cls));
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first4) __cb.AppendLine();
            __cb.Push("");
            #line (85,1)-(85,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (88,9)-(88,41) 22 "MetaModelGenerator.mxg"
        public string GenerateMetaModel(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (89,1)-(89,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (89,9)-(89,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,10)-(89,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (89,19)-(89,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (89,20)-(89,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (89,22)-(89,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (90,1)-(90,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first5 = true;
            #line (91,6)-(91,70) 13 "MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first5)
                {
                    __first5 = false;
                }
                __cb.Push("    ");
                #line (92,10)-(92,26) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (92,27)-(92,28) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,29)-(92,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (92,36)-(92,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,37)-(92,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (92,38)-(92,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,39)-(92,43) 29 "MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (92,43)-(92,44) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (92,44)-(92,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first5) __cb.AppendLine();
            __cb.Push("");
            #line (94,1)-(94,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (96,1)-(96,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (96,7)-(96,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,8)-(96,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("sealed");
            #line hidden
            #line (96,14)-(96,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,15)-(96,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (96,20)-(96,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,22)-(96,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (96,30)-(96,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,31)-(96,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (96,32)-(96,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,33)-(96,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel,");
            #line hidden
            #line (96,45)-(96,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (96,46)-(96,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("I");
            #line hidden
            #line (96,48)-(96,55) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (97,1)-(97,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (98,5)-(98,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (98,7)-(98,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,8)-(98,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("If");
            #line hidden
            #line (98,10)-(98,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,11)-(98,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("there");
            #line hidden
            #line (98,16)-(98,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,17)-(98,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (98,19)-(98,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,20)-(98,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("an");
            #line hidden
            #line (98,22)-(98,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,23)-(98,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("error");
            #line hidden
            #line (98,28)-(98,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,29)-(98,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("at");
            #line hidden
            #line (98,31)-(98,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,32)-(98,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (98,35)-(98,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,36)-(98,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("following");
            #line hidden
            #line (98,45)-(98,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,46)-(98,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("line,");
            #line hidden
            #line (98,51)-(98,52) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,52)-(98,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("create");
            #line hidden
            #line (98,58)-(98,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,59)-(98,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("a");
            #line hidden
            #line (98,60)-(98,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,61)-(98,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (98,64)-(98,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,65)-(98,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (98,70)-(98,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,71)-(98,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("called");
            #line hidden
            #line (98,77)-(98,78) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (98,78)-(98,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("'Custom");
            #line hidden
            #line (98,86)-(98,93) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (98,94)-(98,109) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation'");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (99,5)-(99,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (99,7)-(99,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,8)-(99,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("inheriting");
            #line hidden
            #line (99,18)-(99,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,19)-(99,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("from");
            #line hidden
            #line (99,23)-(99,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,24)-(99,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (99,27)-(99,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,28)-(99,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (99,33)-(99,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,34)-(99,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("'Custom");
            #line hidden
            #line (99,42)-(99,49) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (99,50)-(99,69) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase'");
            #line hidden
            #line (99,69)-(99,70) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,70)-(99,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (99,73)-(99,74) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,74)-(99,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("provide");
            #line hidden
            #line (99,81)-(99,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,82)-(99,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (99,85)-(99,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,86)-(99,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("custom");
            #line hidden
            #line (99,92)-(99,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (99,93)-(99,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (100,5)-(100,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("//");
            #line hidden
            #line (100,7)-(100,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,8)-(100,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (100,11)-(100,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,12)-(100,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (100,15)-(100,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,16)-(100,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("derived");
            #line hidden
            #line (100,23)-(100,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,24)-(100,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("properties");
            #line hidden
            #line (100,34)-(100,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,35)-(100,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("and");
            #line hidden
            #line (100,38)-(100,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,39)-(100,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("operations");
            #line hidden
            #line (100,49)-(100,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,50)-(100,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("defined");
            #line hidden
            #line (100,57)-(100,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,58)-(100,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("in");
            #line hidden
            #line (100,60)-(100,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,61)-(100,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (100,64)-(100,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (100,65)-(100,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("metamodel");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (101,5)-(101,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (101,13)-(101,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,14)-(101,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (101,20)-(101,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,21)-(101,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (101,29)-(101,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,30)-(101,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (101,37)-(101,44) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (101,45)-(101,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (101,63)-(101,64) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,64)-(101,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("__CustomImpl");
            #line hidden
            #line (101,76)-(101,77) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,77)-(101,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (101,78)-(101,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,79)-(101,82) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (101,82)-(101,83) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (101,83)-(101,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (101,90)-(101,97) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (101,98)-(101,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (103,5)-(103,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (103,12)-(103,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,13)-(103,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (103,19)-(103,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,20)-(103,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (103,28)-(103,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,30)-(103,37) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (103,38)-(103,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (103,39)-(103,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("_instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (104,5)-(104,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (104,11)-(104,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,12)-(104,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (104,18)-(104,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,20)-(104,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (104,28)-(104,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,29)-(104,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("MInstance");
            #line hidden
            #line (104,38)-(104,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,39)-(104,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (104,41)-(104,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (104,42)-(104,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("_instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first6 = true;
            #line (106,6)-(106,69) 13 "MetaModelGenerator.mxg"
            foreach (var cls in mm.Parent.Declarations.OfType<MetaClass>())
            #line hidden
            
            {
                if (__first6)
                {
                    __first6 = false;
                }
                var __first7 = true;
                #line (107,10)-(107,46) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first7)
                    {
                        __first7 = false;
                    }
                    __cb.Push("    ");
                    #line (108,13)-(108,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (108,20)-(108,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,21)-(108,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (108,27)-(108,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,28)-(108,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (108,36)-(108,37) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,37)-(108,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (108,52)-(108,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (108,53)-(108,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (108,55)-(108,63) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (108,64)-(108,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (108,66)-(108,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (108,76)-(108,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first7) __cb.AppendLine();
                var __first8 = true;
                #line (110,10)-(110,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first8)
                    {
                        __first8 = false;
                    }
                    __cb.Push("    ");
                    #line (111,13)-(111,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("private");
                    #line hidden
                    #line (111,20)-(111,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,21)-(111,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (111,27)-(111,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,28)-(111,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write("readonly");
                    #line hidden
                    #line (111,36)-(111,37) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,37)-(111,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (111,53)-(111,54) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (111,54)-(111,55) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (111,56)-(111,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (111,65)-(111,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (111,67)-(111,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (111,75)-(111,76) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first8) __cb.AppendLine();
            }
            if (!__first6) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (115,5)-(115,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (115,11)-(115,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (115,13)-(115,20) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (115,21)-(115,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (116,5)-(116,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first9 = true;
            #line (117,10)-(117,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first9)
                {
                    __first9 = false;
                }
                #line (118,14)-(118,131) 17 "MetaModelGenerator.mxg"
                var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
                #line hidden
                
                var __first10 = true;
                #line (119,14)-(119,62) 17 "MetaModelGenerator.mxg"
                foreach (var prop in metaCls.DeclaredProperties)
                #line hidden
                
                {
                    if (__first10)
                    {
                        __first10 = false;
                    }
                    __cb.Push("        ");
                    #line (120,17)-(120,18) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (120,19)-(120,27) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (120,28)-(120,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (120,30)-(120,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (120,40)-(120,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,41)-(120,42) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (120,42)-(120,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,43)-(120,46) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (120,46)-(120,47) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,47)-(120,70) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty(typeof(");
                    #line hidden
                    #line (120,71)-(120,79) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (120,80)-(120,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (120,82)-(120,83) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,83)-(120,84) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (120,85)-(120,94) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (120,95)-(120,97) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (120,97)-(120,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,98)-(120,105) 33 "MetaModelGenerator.mxg"
                    __cb.Write("typeof(");
                    #line hidden
                    #line (120,106)-(120,125) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (120,126)-(120,128) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (120,128)-(120,129) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,130)-(120,173) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpValue(prop.Type, prop.DefaultValue));
                    #line hidden
                    #line (120,174)-(120,175) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (120,175)-(120,176) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (120,177)-(120,197) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Flags));
                    #line hidden
                    #line (120,198)-(120,199) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (120,199)-(120,200) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    var __first11 = true;
                    #line (120,201)-(120,232) 21 "MetaModelGenerator.mxg"
                    if(prop.SymbolProperty is null)
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (120,233)-(120,237) 37 "MetaModelGenerator.mxg"
                        __cb.Write("null");
                        #line hidden
                    }
                    #line (120,238)-(120,242) 21 "MetaModelGenerator.mxg"
                    else
                    #line hidden
                    
                    {
                        if (__first11)
                        {
                            __first11 = false;
                        }
                        #line (120,243)-(120,244) 37 "MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                        #line (120,245)-(120,264) 36 "MetaModelGenerator.mxg"
                        __cb.Write(prop.SymbolProperty);
                        #line hidden
                        #line (120,265)-(120,266) 37 "MetaModelGenerator.mxg"
                        __cb.Write("\"");
                        #line hidden
                    }
                    #line (120,274)-(120,276) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first10) __cb.AppendLine();
                var __first12 = true;
                #line (122,14)-(122,60) 17 "MetaModelGenerator.mxg"
                foreach (var op in metaCls.DeclaredOperations)
                #line hidden
                
                {
                    if (__first12)
                    {
                        __first12 = false;
                    }
                    __cb.Push("        ");
                    #line (123,17)-(123,18) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (123,19)-(123,27) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (123,28)-(123,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (123,30)-(123,37) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (123,38)-(123,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,39)-(123,40) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=");
                    #line hidden
                    #line (123,40)-(123,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,41)-(123,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (123,44)-(123,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,45)-(123,69) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation(typeof(");
                    #line hidden
                    #line (123,70)-(123,78) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (123,79)-(123,81) 33 "MetaModelGenerator.mxg"
                    __cb.Write("),");
                    #line hidden
                    #line (123,81)-(123,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,82)-(123,83) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (123,84)-(123,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (123,92)-(123,94) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\",");
                    #line hidden
                    #line (123,94)-(123,95) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (123,95)-(123,96) 33 "MetaModelGenerator.mxg"
                    __cb.Write("\"");
                    #line hidden
                    #line (123,97)-(123,104) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (123,105)-(123,106) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (123,107)-(123,146) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.UnderlyingOperation.Parameters.Count);
                    #line hidden
                    #line (123,147)-(123,151) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")\");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first12) __cb.AppendLine();
            }
            if (!__first9) __cb.AppendLine();
            __cb.Push("        ");
            #line (126,9)-(126,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_instance");
            #line hidden
            #line (126,18)-(126,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,19)-(126,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (126,20)-(126,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,21)-(126,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (126,24)-(126,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (126,26)-(126,33) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (126,34)-(126,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (127,5)-(127,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (129,5)-(129,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (129,12)-(129,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,13)-(129,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (129,21)-(129,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,22)-(129,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (129,29)-(129,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (129,30)-(129,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (131,5)-(131,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (131,12)-(131,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,13)-(131,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (131,21)-(131,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,22)-(131,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (131,85)-(131,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (131,86)-(131,97) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (132,5)-(132,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (132,12)-(132,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,13)-(132,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (132,21)-(132,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,22)-(132,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (132,90)-(132,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (132,91)-(132,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (133,5)-(133,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (133,12)-(133,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,13)-(133,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (133,21)-(133,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,22)-(133,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (133,90)-(133,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,91)-(133,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (133,107)-(133,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (133,108)-(133,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (134,5)-(134,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (134,12)-(134,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,13)-(134,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (134,21)-(134,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,22)-(134,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (134,86)-(134,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,87)-(134,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (134,103)-(134,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (134,104)-(134,121) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (136,5)-(136,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (136,12)-(136,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,13)-(136,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (136,21)-(136,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,22)-(136,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (136,85)-(136,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (136,86)-(136,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (137,5)-(137,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (137,12)-(137,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,13)-(137,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (137,21)-(137,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,22)-(137,91) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (137,91)-(137,92) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (137,92)-(137,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (138,5)-(138,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (138,12)-(138,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,13)-(138,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (138,21)-(138,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,22)-(138,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (138,90)-(138,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,91)-(138,108) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (138,108)-(138,109) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (138,109)-(138,127) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (139,5)-(139,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (139,12)-(139,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,13)-(139,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (139,21)-(139,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,22)-(139,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (139,86)-(139,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,87)-(139,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (139,104)-(139,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (139,105)-(139,123) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first13 = true;
            #line (141,6)-(141,70) 13 "MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first13)
                {
                    __first13 = false;
                }
                __cb.Push("    ");
                #line (142,9)-(142,16) 29 "MetaModelGenerator.mxg"
                __cb.Write("private");
                #line hidden
                #line (142,16)-(142,17) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,17)-(142,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("readonly");
                #line hidden
                #line (142,25)-(142,26) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,27)-(142,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (142,44)-(142,45) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (142,45)-(142,46) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (142,47)-(142,67) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (142,68)-(142,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first13) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (145,5)-(145,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (145,12)-(145,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (145,14)-(145,21) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (145,22)-(145,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (146,5)-(146,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (147,9)-(147,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes");
            #line hidden
            #line (147,19)-(147,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,20)-(147,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (147,21)-(147,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (147,22)-(147,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first14 = true;
            #line (147,59)-(147,86) 13 "MetaModelGenerator.mxg"
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
                    #line (147,96)-(147,100) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (147,101)-(147,108) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (147,109)-(147,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (147,118)-(147,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (147,132)-(147,134) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (148,9)-(148,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos");
            #line hidden
            #line (148,19)-(148,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,20)-(148,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (148,21)-(148,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (148,22)-(148,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelEnumInfo>(");
            #line hidden
            var __first15 = true;
            #line (148,64)-(148,91) 13 "MetaModelGenerator.mxg"
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
                    #line (148,101)-(148,105) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (148,107)-(148,115) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (148,116)-(148,120) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (148,133)-(148,135) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (149,9)-(149,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (149,12)-(149,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,13)-(149,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType");
            #line hidden
            #line (149,28)-(149,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,29)-(149,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (149,30)-(149,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,31)-(149,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (149,78)-(149,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (149,79)-(149,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first16 = true;
            #line (150,10)-(150,36) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first16)
                {
                    __first16 = false;
                }
                __cb.Push("        ");
                #line (151,13)-(151,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("enumInfosByType.Add(typeof(");
                #line hidden
                #line (151,41)-(151,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (151,50)-(151,52) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (151,52)-(151,53) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (151,54)-(151,62) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (151,63)-(151,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first16) __cb.AppendLine();
            __cb.Push("        ");
            #line (153,9)-(153,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType");
            #line hidden
            #line (153,25)-(153,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,26)-(153,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (153,27)-(153,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (153,28)-(153,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByType.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (154,9)-(154,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (154,12)-(154,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,13)-(154,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName");
            #line hidden
            #line (154,28)-(154,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,29)-(154,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (154,30)-(154,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,31)-(154,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (154,74)-(154,75) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (154,75)-(154,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first17 = true;
            #line (155,10)-(155,36) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first17)
                {
                    __first17 = false;
                }
                __cb.Push("        ");
                #line (156,13)-(156,34) 29 "MetaModelGenerator.mxg"
                __cb.Write("enumInfosByName.Add(\"");
                #line hidden
                #line (156,35)-(156,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (156,44)-(156,46) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (156,46)-(156,47) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (156,48)-(156,56) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (156,57)-(156,63) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first17) __cb.AppendLine();
            __cb.Push("        ");
            #line (158,9)-(158,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName");
            #line hidden
            #line (158,25)-(158,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,26)-(158,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (158,27)-(158,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (158,28)-(158,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("enumInfosByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (160,9)-(160,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes");
            #line hidden
            #line (160,20)-(160,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,21)-(160,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (160,22)-(160,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (160,23)-(160,59) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__MetaType>(");
            #line hidden
            var __first18 = true;
            #line (160,60)-(160,89) 13 "MetaModelGenerator.mxg"
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
                    #line (160,99)-(160,103) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (160,104)-(160,111) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (160,112)-(160,120) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (160,121)-(160,122) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (160,135)-(160,137) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (161,9)-(161,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos");
            #line hidden
            #line (161,20)-(161,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,21)-(161,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (161,22)-(161,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (161,23)-(161,65) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first19 = true;
            #line (161,66)-(161,95) 13 "MetaModelGenerator.mxg"
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
                    #line (161,105)-(161,109) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (161,111)-(161,119) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (161,120)-(161,124) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
            }
            #line (161,137)-(161,139) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (162,9)-(162,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (162,12)-(162,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,13)-(162,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByType");
            #line hidden
            #line (162,29)-(162,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,30)-(162,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (162,31)-(162,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,32)-(162,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__MetaType,");
            #line hidden
            #line (162,79)-(162,80) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (162,80)-(162,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first20 = true;
            #line (163,10)-(163,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first20)
                {
                    __first20 = false;
                }
                __cb.Push("        ");
                #line (164,13)-(164,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("classInfosByType.Add(typeof(");
                #line hidden
                #line (164,42)-(164,50) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (164,51)-(164,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (164,53)-(164,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (164,55)-(164,63) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (164,64)-(164,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first20) __cb.AppendLine();
            __cb.Push("        ");
            #line (166,9)-(166,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType");
            #line hidden
            #line (166,26)-(166,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,27)-(166,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (166,28)-(166,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (166,29)-(166,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByType.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (167,9)-(167,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (167,12)-(167,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,13)-(167,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByName");
            #line hidden
            #line (167,29)-(167,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,30)-(167,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (167,31)-(167,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,32)-(167,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (167,75)-(167,76) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (167,76)-(167,96) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first21 = true;
            #line (168,10)-(168,38) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first21)
                {
                    __first21 = false;
                }
                __cb.Push("        ");
                #line (169,13)-(169,35) 29 "MetaModelGenerator.mxg"
                __cb.Write("classInfosByName.Add(\"");
                #line hidden
                #line (169,36)-(169,44) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (169,45)-(169,47) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (169,47)-(169,48) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (169,49)-(169,57) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (169,58)-(169,64) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first21) __cb.AppendLine();
            __cb.Push("        ");
            #line (171,9)-(171,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName");
            #line hidden
            #line (171,26)-(171,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,27)-(171,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (171,28)-(171,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (171,29)-(171,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("classInfosByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (172,9)-(172,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model");
            #line hidden
            #line (172,15)-(172,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,16)-(172,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (172,17)-(172,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,18)-(172,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (172,21)-(172,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (172,22)-(172,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (173,9)-(173,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (173,12)-(173,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,13)-(173,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("cf");
            #line hidden
            #line (173,15)-(173,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,16)-(173,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (173,17)-(173,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,18)-(173,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (173,21)-(173,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,23)-(173,30) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (173,31)-(173,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(_model);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first22 = true;
            #line (174,10)-(174,74) 13 "MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first22)
                {
                    __first22 = false;
                }
                __cb.Push("        ");
                #line (175,13)-(175,14) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (175,15)-(175,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (175,36)-(175,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,37)-(175,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (175,38)-(175,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (175,39)-(175,42) 29 "MetaModelGenerator.mxg"
                __cb.Write("cf.");
                #line hidden
                #line (175,43)-(175,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Type.Name);
                #line hidden
                #line (175,55)-(175,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first22) __cb.AppendLine();
            __cb.Push("        ");
            #line (177,9)-(177,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (177,12)-(177,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (177,13)-(177,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("f");
            #line hidden
            #line (177,14)-(177,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (177,15)-(177,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (177,16)-(177,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (177,17)-(177,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (177,20)-(177,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (177,21)-(177,48) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelFactory(_model);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first23 = true;
            #line (178,10)-(178,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                __cb.Push("        ");
                #line (179,13)-(179,16) 29 "MetaModelGenerator.mxg"
                __cb.Write("var");
                #line hidden
                #line (179,16)-(179,17) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,18)-(179,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(GetName(obj));
                #line hidden
                #line (179,31)-(179,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,32)-(179,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (179,33)-(179,34) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (179,34)-(179,36) 29 "MetaModelGenerator.mxg"
                __cb.Write("f.");
                #line hidden
                #line (179,37)-(179,60) 28 "MetaModelGenerator.mxg"
                __cb.Write(obj.MInfo.MetaType.Name);
                #line hidden
                #line (179,61)-(179,64) 29 "MetaModelGenerator.mxg"
                __cb.Write("();");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first23) __cb.AppendLine();
            __cb.Push("        ");
            #line (181,9)-(181,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("__CustomImpl.");
            #line hidden
            #line (181,23)-(181,30) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (181,31)-(181,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first24 = true;
            #line (182,10)-(182,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
                }
                var __first25 = true;
                #line (183,14)-(183,50) 17 "MetaModelGenerator.mxg"
                foreach (var child in obj.MChildren)
                #line hidden
                
                {
                    if (__first25)
                    {
                        __first25 = false;
                    }
                    __cb.Push("        ");
                    #line (184,18)-(184,30) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetName(obj));
                    #line hidden
                    #line (184,31)-(184,46) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".MChildren.Add(");
                    #line hidden
                    #line (184,47)-(184,61) 32 "MetaModelGenerator.mxg"
                    __cb.Write(GetName(child));
                    #line hidden
                    #line (184,62)-(184,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first25) __cb.AppendLine();
                var __first26 = true;
                #line (186,14)-(186,62) 17 "MetaModelGenerator.mxg"
                foreach (var prop in obj.MInfo.PublicProperties)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
                    }
                    #line (187,18)-(187,47) 21 "MetaModelGenerator.mxg"
                    var slot = obj.MGetSlot(prop);
                    #line hidden
                    
                    var __first27 = true;
                    #line (188,18)-(188,54) 21 "MetaModelGenerator.mxg"
                    if (slot != null && !slot.IsDefault)
                    #line hidden
                    
                    {
                        if (__first27)
                        {
                            __first27 = false;
                        }
                        var __first28 = true;
                        #line (189,22)-(189,44) 25 "MetaModelGenerator.mxg"
                        if (prop.IsCollection)
                        #line hidden
                        
                        {
                            if (__first28)
                            {
                                __first28 = false;
                            }
                            var __first29 = true;
                            #line (190,26)-(190,60) 29 "MetaModelGenerator.mxg"
                            foreach (var value in slot.Values)
                            #line hidden
                            
                            {
                                if (__first29)
                                {
                                    __first29 = false;
                                }
                                __cb.Push("        ");
                                #line (191,30)-(191,42) 44 "MetaModelGenerator.mxg"
                                __cb.Write(GetName(obj));
                                #line hidden
                                #line (191,43)-(191,44) 45 "MetaModelGenerator.mxg"
                                __cb.Write(".");
                                #line hidden
                                #line (191,45)-(191,54) 44 "MetaModelGenerator.mxg"
                                __cb.Write(prop.Name);
                                #line hidden
                                #line (191,55)-(191,60) 45 "MetaModelGenerator.mxg"
                                __cb.Write(".Add(");
                                #line hidden
                                #line (191,61)-(191,92) 44 "MetaModelGenerator.mxg"
                                __cb.Write(ToCSharpValue(prop.Type, value));
                                #line hidden
                                #line (191,93)-(191,95) 45 "MetaModelGenerator.mxg"
                                __cb.Write(");");
                                #line hidden
                                __cb.WriteLine();
                                __cb.Pop();
                            }
                            if (!__first29) __cb.AppendLine();
                        }
                        #line (193,22)-(193,48) 25 "MetaModelGenerator.mxg"
                        else if (!prop.IsReadOnly)
                        #line hidden
                        
                        {
                            if (__first28)
                            {
                                __first28 = false;
                            }
                            __cb.Push("        ");
                            #line (194,26)-(194,38) 40 "MetaModelGenerator.mxg"
                            __cb.Write(GetName(obj));
                            #line hidden
                            #line (194,39)-(194,40) 41 "MetaModelGenerator.mxg"
                            __cb.Write(".");
                            #line hidden
                            #line (194,41)-(194,50) 40 "MetaModelGenerator.mxg"
                            __cb.Write(prop.Name);
                            #line hidden
                            #line (194,51)-(194,52) 41 "MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (194,52)-(194,53) 41 "MetaModelGenerator.mxg"
                            __cb.Write("=");
                            #line hidden
                            #line (194,53)-(194,54) 41 "MetaModelGenerator.mxg"
                            __cb.Write(" ");
                            #line hidden
                            #line (194,55)-(194,103) 40 "MetaModelGenerator.mxg"
                            __cb.Write(ToCSharpValue(prop.Type, slot.AsSingle()?.Value));
                            #line hidden
                            #line (194,104)-(194,105) 41 "MetaModelGenerator.mxg"
                            __cb.Write(";");
                            #line hidden
                            __cb.WriteLine();
                            __cb.Pop();
                        }
                        if (!__first28) __cb.AppendLine();
                    }
                    if (!__first27) __cb.AppendLine();
                }
                if (!__first26) __cb.AppendLine();
            }
            if (!__first24) __cb.AppendLine();
            __cb.Push("        ");
            #line (199,9)-(199,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model.IsSealed");
            #line hidden
            #line (199,24)-(199,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,25)-(199,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (199,26)-(199,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (199,27)-(199,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("true;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (200,5)-(200,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (202,5)-(202,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (202,11)-(202,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,12)-(202,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (202,20)-(202,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,21)-(202,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (202,27)-(202,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,28)-(202,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("MName");
            #line hidden
            #line (202,33)-(202,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,34)-(202,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (202,36)-(202,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (202,37)-(202,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("nameof(");
            #line hidden
            #line (202,45)-(202,52) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (202,53)-(202,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (203,5)-(203,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (203,11)-(203,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,12)-(203,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (203,20)-(203,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,21)-(203,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (203,27)-(203,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,28)-(203,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("MNamespace");
            #line hidden
            #line (203,38)-(203,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,39)-(203,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (203,41)-(203,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (203,42)-(203,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (203,44)-(203,53) 24 "MetaModelGenerator.mxg"
            __cb.Write(Namespace);
            #line hidden
            #line (203,54)-(203,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (204,5)-(204,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (204,11)-(204,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,12)-(204,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (204,20)-(204,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,21)-(204,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelVersion");
            #line hidden
            #line (204,35)-(204,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,36)-(204,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MVersion");
            #line hidden
            #line (204,44)-(204,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,45)-(204,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (204,47)-(204,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (204,48)-(204,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("default;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (205,5)-(205,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (205,11)-(205,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,12)-(205,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (205,20)-(205,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,21)-(205,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (205,27)-(205,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,28)-(205,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("MUri");
            #line hidden
            #line (205,32)-(205,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,33)-(205,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (205,35)-(205,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (205,36)-(205,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (205,38)-(205,59) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Uri ?? mm.FullName);
            #line hidden
            #line (205,60)-(205,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (206,5)-(206,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (206,11)-(206,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,12)-(206,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (206,20)-(206,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,21)-(206,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (206,27)-(206,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,28)-(206,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("MPrefix");
            #line hidden
            #line (206,35)-(206,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,36)-(206,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (206,38)-(206,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (206,39)-(206,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (206,41)-(206,120) 24 "MetaModelGenerator.mxg"
            __cb.Write(string.Concat(mm.Name.Where(c => char.IsUpper(c)).Select(c => char.ToLower(c))));
            #line hidden
            #line (206,121)-(206,123) 25 "MetaModelGenerator.mxg"
            __cb.Write("\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (207,5)-(207,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (207,11)-(207,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,12)-(207,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (207,20)-(207,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,21)-(207,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Model");
            #line hidden
            #line (207,28)-(207,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,29)-(207,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("MModel");
            #line hidden
            #line (207,35)-(207,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,36)-(207,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (207,38)-(207,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (207,39)-(207,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("_model;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (209,5)-(209,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (209,11)-(209,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,12)-(209,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (209,20)-(209,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,21)-(209,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (209,89)-(209,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,90)-(209,106) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (209,106)-(209,107) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,107)-(209,123) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByType");
            #line hidden
            #line (209,123)-(209,124) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,124)-(209,126) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (209,126)-(209,127) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (209,127)-(209,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (210,5)-(210,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (210,11)-(210,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,12)-(210,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (210,20)-(210,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,21)-(210,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (210,85)-(210,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,86)-(210,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo>");
            #line hidden
            #line (210,102)-(210,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,103)-(210,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfosByName");
            #line hidden
            #line (210,119)-(210,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,120)-(210,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (210,122)-(210,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (210,123)-(210,140) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (211,5)-(211,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (211,11)-(211,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,12)-(211,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (211,20)-(211,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,21)-(211,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__MetaType,");
            #line hidden
            #line (211,89)-(211,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,90)-(211,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (211,107)-(211,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,108)-(211,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByType");
            #line hidden
            #line (211,125)-(211,126) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,126)-(211,128) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (211,128)-(211,129) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (211,129)-(211,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByType;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (212,5)-(212,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (212,11)-(212,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,12)-(212,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (212,20)-(212,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,21)-(212,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (212,85)-(212,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,86)-(212,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo>");
            #line hidden
            #line (212,103)-(212,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,104)-(212,121) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfosByName");
            #line hidden
            #line (212,121)-(212,122) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,122)-(212,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (212,124)-(212,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (212,125)-(212,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfosByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (214,5)-(214,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (214,11)-(214,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,12)-(214,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (214,20)-(214,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,21)-(214,84) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (214,84)-(214,85) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,85)-(214,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumTypes");
            #line hidden
            #line (214,95)-(214,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,96)-(214,98) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (214,98)-(214,99) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (214,99)-(214,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (215,5)-(215,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (215,11)-(215,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,12)-(215,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (215,20)-(215,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,21)-(215,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelEnumInfo>");
            #line hidden
            #line (215,89)-(215,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,90)-(215,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("MEnumInfos");
            #line hidden
            #line (215,100)-(215,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,101)-(215,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (215,103)-(215,104) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (215,104)-(215,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_enumInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (216,5)-(216,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (216,11)-(216,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,12)-(216,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (216,20)-(216,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,21)-(216,84) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__MetaType>");
            #line hidden
            #line (216,84)-(216,85) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,85)-(216,96) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassTypes");
            #line hidden
            #line (216,96)-(216,97) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,97)-(216,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (216,99)-(216,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (216,100)-(216,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (217,5)-(217,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (217,11)-(217,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,12)-(217,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (217,20)-(217,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,21)-(217,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (217,90)-(217,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,91)-(217,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("MClassInfos");
            #line hidden
            #line (217,102)-(217,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,103)-(217,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (217,105)-(217,106) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (217,106)-(217,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_classInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first30 = true;
            #line (219,6)-(219,70) 13 "MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first30)
                {
                    __first30 = false;
                }
                __cb.Push("    ");
                #line (220,10)-(220,26) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (220,27)-(220,28) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (220,28)-(220,29) 29 "MetaModelGenerator.mxg"
                __cb.Write("I");
                #line hidden
                #line (220,30)-(220,37) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (220,38)-(220,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (220,40)-(220,46) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (220,47)-(220,48) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (220,48)-(220,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (220,50)-(220,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (220,51)-(220,52) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (220,53)-(220,73) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name.ToCamelCase());
                #line hidden
                #line (220,74)-(220,75) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first30) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first31 = true;
            #line (223,6)-(223,70) 13 "MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first31)
                {
                    __first31 = false;
                }
                __cb.Push("    ");
                #line (224,9)-(224,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (224,15)-(224,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,16)-(224,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (224,22)-(224,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,24)-(224,40) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(c.Type));
                #line hidden
                #line (224,41)-(224,42) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,43)-(224,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (224,50)-(224,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,51)-(224,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (224,53)-(224,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (224,54)-(224,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("((I");
                #line hidden
                #line (224,58)-(224,65) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (224,66)-(224,78) 29 "MetaModelGenerator.mxg"
                __cb.Write(")MInstance).");
                #line hidden
                #line (224,79)-(224,85) 28 "MetaModelGenerator.mxg"
                __cb.Write(c.Name);
                #line hidden
                #line (224,86)-(224,87) 29 "MetaModelGenerator.mxg"
                __cb.Write(";");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first31) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first32 = true;
            #line (227,6)-(227,32) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
                }
                __cb.Push("    ");
                #line (228,9)-(228,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (228,15)-(228,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,16)-(228,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (228,22)-(228,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,23)-(228,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelEnumInfo");
                #line hidden
                #line (228,38)-(228,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,40)-(228,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (228,49)-(228,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (228,53)-(228,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,54)-(228,56) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (228,56)-(228,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (228,57)-(228,66) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.__");
                #line hidden
                #line (228,67)-(228,75) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (228,76)-(228,91) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Info.Instance;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first32) __cb.AppendLine();
            var __first33 = true;
            #line (230,6)-(230,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
                }
                __cb.Push("    ");
                #line (231,9)-(231,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (231,15)-(231,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (231,16)-(231,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("static");
                #line hidden
                #line (231,22)-(231,23) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (231,23)-(231,39) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelClassInfo");
                #line hidden
                #line (231,39)-(231,40) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (231,41)-(231,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (231,50)-(231,54) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info");
                #line hidden
                #line (231,54)-(231,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (231,55)-(231,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (231,57)-(231,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (231,58)-(231,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("__Impl.");
                #line hidden
                #line (231,66)-(231,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (231,75)-(231,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("_Impl.__Info.Instance;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first34 = true;
                #line (232,6)-(232,42) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first34)
                    {
                        __first34 = false;
                    }
                    __cb.Push("    ");
                    #line (233,9)-(233,15) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (233,15)-(233,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,16)-(233,22) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (233,22)-(233,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,23)-(233,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelProperty");
                    #line hidden
                    #line (233,38)-(233,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,40)-(233,48) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (233,49)-(233,50) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (233,51)-(233,60) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (233,61)-(233,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,62)-(233,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (233,64)-(233,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (233,65)-(233,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (233,67)-(233,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (233,76)-(233,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (233,78)-(233,87) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (233,88)-(233,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first34) __cb.AppendLine();
                var __first35 = true;
                #line (235,6)-(235,40) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
                    }
                    __cb.Push("    ");
                    #line (236,9)-(236,15) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (236,15)-(236,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (236,16)-(236,22) 33 "MetaModelGenerator.mxg"
                    __cb.Write("static");
                    #line hidden
                    #line (236,22)-(236,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (236,23)-(236,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("__ModelOperation");
                    #line hidden
                    #line (236,39)-(236,40) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (236,41)-(236,49) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (236,50)-(236,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (236,52)-(236,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (236,60)-(236,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (236,61)-(236,63) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (236,63)-(236,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (236,64)-(236,65) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (236,66)-(236,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (236,75)-(236,76) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (236,77)-(236,84) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (236,85)-(236,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(";");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first35) __cb.AppendLine();
            }
            if (!__first33) __cb.AppendLine();
            __cb.Push("");
            #line (239,1)-(239,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (242,9)-(242,39) 22 "MetaModelGenerator.mxg"
        public string GenerateFactory(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (243,1)-(243,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (243,7)-(243,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,8)-(243,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (243,13)-(243,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,15)-(243,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (243,23)-(243,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory");
            #line hidden
            #line (243,35)-(243,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,36)-(243,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (243,37)-(243,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (243,38)-(243,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (244,1)-(244,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (245,5)-(245,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (245,11)-(245,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (245,13)-(245,20) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (245,21)-(245,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (245,41)-(245,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (245,42)-(245,48) 25 "MetaModelGenerator.mxg"
            __cb.Write("model)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (246,9)-(246,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (246,10)-(246,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (246,11)-(246,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (246,22)-(246,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (246,24)-(246,31) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (246,32)-(246,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (247,5)-(247,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (248,5)-(248,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first36 = true;
            #line (250,6)-(250,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first36)
                {
                    __first36 = false;
                }
                __cb.Push("    ");
                #line (251,9)-(251,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (251,15)-(251,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (251,17)-(251,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (251,31)-(251,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (251,33)-(251,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (251,42)-(251,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(string?");
                #line hidden
                #line (251,50)-(251,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (251,51)-(251,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (251,53)-(251,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (251,54)-(251,55) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (251,55)-(251,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (251,56)-(251,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (252,9)-(252,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (253,13)-(253,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (253,19)-(253,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (253,20)-(253,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (253,22)-(253,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (253,36)-(253,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (253,38)-(253,45) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (253,46)-(253,47) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (253,48)-(253,56) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (253,57)-(253,75) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(Model,");
                #line hidden
                #line (253,75)-(253,76) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (253,76)-(253,81) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (254,9)-(254,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first36) __cb.AppendLine();
            __cb.Push("");
            #line (257,1)-(257,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (259,1)-(259,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (259,7)-(259,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,8)-(259,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (259,13)-(259,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,15)-(259,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (259,23)-(259,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory");
            #line hidden
            #line (259,40)-(259,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,41)-(259,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (259,42)-(259,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (259,43)-(259,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (260,1)-(260,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (261,5)-(261,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (261,11)-(261,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (261,13)-(261,20) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (261,21)-(261,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (262,9)-(262,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (262,10)-(262,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,11)-(262,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(new");
            #line hidden
            #line (262,19)-(262,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,20)-(262,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (262,32)-(262,36) 24 "MetaModelGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (262,37)-(262,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,38)-(262,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (262,39)-(262,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,41)-(262,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (262,49)-(262,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance");
            #line hidden
            #line (262,59)-(262,60) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (262,60)-(262,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("})");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (263,5)-(263,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (264,5)-(264,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (266,6)-(266,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (267,9)-(267,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (267,15)-(267,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,17)-(267,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (267,31)-(267,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,33)-(267,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (267,42)-(267,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(__Model");
                #line hidden
                #line (267,50)-(267,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,51)-(267,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("model,");
                #line hidden
                #line (267,57)-(267,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,58)-(267,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("string?");
                #line hidden
                #line (267,65)-(267,66) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,66)-(267,68) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (267,68)-(267,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,69)-(267,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (267,70)-(267,71) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (267,71)-(267,76) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (268,9)-(268,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (269,13)-(269,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (269,19)-(269,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (269,20)-(269,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (269,22)-(269,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (269,36)-(269,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (269,38)-(269,45) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (269,46)-(269,47) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (269,48)-(269,56) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (269,57)-(269,75) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(model,");
                #line hidden
                #line (269,75)-(269,76) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (269,76)-(269,81) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (270,9)-(270,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (273,1)-(273,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (277,9)-(277,50) 22 "MetaModelGenerator.mxg"
        public string GenerateEnum(MetaModel mm, MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (278,1)-(278,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (278,7)-(278,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,8)-(278,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (278,12)-(278,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (278,14)-(278,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (279,1)-(279,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (280,6)-(280,39) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (281,10)-(281,18) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (281,19)-(281,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (283,1)-(283,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (286,9)-(286,54) 22 "MetaModelGenerator.mxg"
        public string GenerateEnumInfo(MetaModel mm, MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (287,1)-(287,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (287,9)-(287,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (287,10)-(287,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (287,15)-(287,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (287,16)-(287,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (287,19)-(287,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (287,28)-(287,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (287,33)-(287,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (287,34)-(287,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (287,35)-(287,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (287,36)-(287,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (288,1)-(288,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (289,5)-(289,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (289,11)-(289,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,12)-(289,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (289,18)-(289,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,19)-(289,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (289,27)-(289,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,28)-(289,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (289,31)-(289,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (289,40)-(289,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (289,45)-(289,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,46)-(289,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (289,54)-(289,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,55)-(289,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (289,56)-(289,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,57)-(289,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (289,60)-(289,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (289,61)-(289,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (289,64)-(289,72) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (289,73)-(289,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (291,5)-(291,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (291,12)-(291,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,13)-(291,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (291,21)-(291,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,22)-(291,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (291,81)-(291,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (291,82)-(291,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (292,5)-(292,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (292,12)-(292,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,13)-(292,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (292,21)-(292,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,22)-(292,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (292,86)-(292,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,87)-(292,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (292,100)-(292,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,101)-(292,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (294,5)-(294,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (294,12)-(294,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,13)-(294,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (294,16)-(294,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (294,25)-(294,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (295,5)-(295,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (296,9)-(296,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals");
            #line hidden
            #line (296,18)-(296,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,19)-(296,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (296,20)-(296,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,21)-(296,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<string>(");
            #line hidden
            var __first39 = true;
            #line (296,54)-(296,88) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals) 
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                else
                {
                    __cb.Push("        ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (296,98)-(296,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (296,104)-(296,142) 28 "MetaModelGenerator.mxg"
                __cb.Write(StringUtilities.EncodeString(lit.Name));
                #line hidden
            }
            #line (296,156)-(296,158) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (297,9)-(297,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (297,12)-(297,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,13)-(297,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName");
            #line hidden
            #line (297,27)-(297,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,28)-(297,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (297,29)-(297,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,30)-(297,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (297,73)-(297,74) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,74)-(297,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first40 = true;
            #line (298,10)-(298,43) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first40)
                {
                    __first40 = false;
                }
                __cb.Push("        ");
                #line (299,13)-(299,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("literalsByName.Add(\"");
                #line hidden
                #line (299,34)-(299,42) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (299,43)-(299,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (299,45)-(299,46) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (299,46)-(299,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaSymbol.FromValue(");
                #line hidden
                #line (299,70)-(299,78) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (299,79)-(299,80) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (299,81)-(299,89) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (299,90)-(299,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first40) __cb.AppendLine();
            __cb.Push("        ");
            #line (301,9)-(301,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName");
            #line hidden
            #line (301,24)-(301,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,25)-(301,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (301,26)-(301,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,27)-(301,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (302,5)-(302,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (304,5)-(304,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (304,11)-(304,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,12)-(304,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (304,20)-(304,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,21)-(304,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (304,32)-(304,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,33)-(304,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (304,42)-(304,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,43)-(304,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (304,45)-(304,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (304,47)-(304,54) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (304,55)-(304,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (305,5)-(305,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (305,11)-(305,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,12)-(305,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (305,20)-(305,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,21)-(305,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (305,31)-(305,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,32)-(305,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (305,40)-(305,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,41)-(305,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (305,43)-(305,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (305,44)-(305,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (305,52)-(305,60) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (305,61)-(305,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (306,5)-(306,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (306,11)-(306,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,12)-(306,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (306,20)-(306,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,21)-(306,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (306,80)-(306,81) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,81)-(306,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("Literals");
            #line hidden
            #line (306,89)-(306,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,90)-(306,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (306,92)-(306,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,93)-(306,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (307,5)-(307,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (307,14)-(307,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,15)-(307,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (307,23)-(307,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,24)-(307,88) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (307,88)-(307,89) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,89)-(307,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (307,102)-(307,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,103)-(307,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("LiteralsByName");
            #line hidden
            #line (307,117)-(307,118) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,118)-(307,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (307,120)-(307,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (307,121)-(307,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (308,1)-(308,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (311,9)-(311,56) 22 "MetaModelGenerator.mxg"
        public string GenerateInterface(MetaModel mm, MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (312,2)-(312,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            #line (313,1)-(313,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (313,7)-(313,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,8)-(313,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (313,17)-(313,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (313,19)-(313,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first41 = true;
            #line (313,29)-(313,53) 13 "MetaModelGenerator.mxg"
            if (cls.BaseTypes.Any())
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                #line (313,54)-(313,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (313,55)-(313,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (313,56)-(313,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first42 = true;
                #line (313,58)-(313,92) 17 "MetaModelGenerator.mxg"
                foreach (var bt in cls.BaseTypes) 
                #line hidden
                
                {
                    if (__first42)
                    {
                        __first42 = false;
                    }
                    else
                    {
                        __cb.Push("");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (313,102)-(313,106) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (313,107)-(313,115) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::");
                    #line hidden
                    #line (313,116)-(313,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(bt.FullName);
                    #line hidden
                }
            }
            #line (313,142)-(313,146) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                #line (313,147)-(313,148) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (313,148)-(313,149) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (313,149)-(313,150) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (313,150)-(313,164) 29 "MetaModelGenerator.mxg"
                __cb.Write("__IModelObject");
                #line hidden
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("");
            #line (314,1)-(314,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first43 = true;
            #line (315,6)-(315,54) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties)
            #line hidden
            
            {
                if (__first43)
                {
                    __first43 = false;
                }
                #line (316,10)-(316,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                __cb.Push("    ");
                var __first44 = true;
                #line (317,10)-(317,47) 17 "MetaModelGenerator.mxg"
                if (info.HiddenProperties.Length > 0)
                #line hidden
                
                {
                    if (__first44)
                    {
                        __first44 = false;
                    }
                    #line (317,48)-(317,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (317,51)-(317,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (317,61)-(317,182) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                #line hidden
                #line (317,183)-(317,184) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,185)-(317,194) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (317,195)-(317,196) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,196)-(317,197) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (317,197)-(317,198) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (317,198)-(317,202) 29 "MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (317,202)-(317,203) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first45 = true;
                #line (317,204)-(317,224) 17 "MetaModelGenerator.mxg"
                if (HasSetter(prop))
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    #line (317,225)-(317,229) 33 "MetaModelGenerator.mxg"
                    __cb.Write("set;");
                    #line hidden
                    #line (317,229)-(317,230) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (317,238)-(317,239) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first43) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first46 = true;
            #line (320,6)-(320,40) 13 "MetaModelGenerator.mxg"
            foreach (var op in cls.Operations)
            #line hidden
            
            {
                if (__first46)
                {
                    __first46 = false;
                }
                __cb.Push("    ");
                #line (321,10)-(321,33) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.ReturnType));
                #line hidden
                #line (321,34)-(321,35) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (321,36)-(321,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (321,44)-(321,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first47 = true;
                #line (321,46)-(321,83) 17 "MetaModelGenerator.mxg"
                foreach (var param in op.Parameters) 
                #line hidden
                
                {
                    if (__first47)
                    {
                        __first47 = false;
                    }
                    else
                    {
                        __cb.Push("    ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (321,93)-(321,97) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (321,99)-(321,119) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(param.Type));
                    #line hidden
                    #line (321,120)-(321,121) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (321,122)-(321,132) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (321,146)-(321,148) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first46) __cb.AppendLine();
            __cb.Push("");
            #line (323,1)-(323,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (326,9)-(326,52) 22 "MetaModelGenerator.mxg"
        public string GenerateClass(MetaModel mm, MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (327,2)-(327,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (328,1)-(328,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (328,9)-(328,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,10)-(328,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (328,15)-(328,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,17)-(328,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (328,26)-(328,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl");
            #line hidden
            #line (328,31)-(328,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,32)-(328,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (328,33)-(328,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,34)-(328,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject,");
            #line hidden
            #line (328,52)-(328,53) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (328,54)-(328,62) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (329,1)-(329,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (330,5)-(330,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (330,12)-(330,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,14)-(330,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (330,23)-(330,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(string?");
            #line hidden
            #line (330,36)-(330,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (330,37)-(330,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("id)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (331,9)-(331,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (331,10)-(331,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (331,11)-(331,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(id)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (332,5)-(332,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first48 = true;
            #line (333,10)-(333,45) 13 "MetaModelGenerator.mxg"
            foreach (var slot in metaCls.Slots)
            #line hidden
            
            {
                if (__first48)
                {
                    __first48 = false;
                }
                #line (334,14)-(334,89) 17 "MetaModelGenerator.mxg"
                var defaultValue = ToCSharpValue(slot.SlotProperty.Type, slot.SlotProperty.DefaultValue);
                #line hidden
                
                var __first49 = true;
                #line (335,14)-(335,82) 17 "MetaModelGenerator.mxg"
                if (!string.IsNullOrEmpty(defaultValue) && defaultValue != "default")
                #line hidden
                
                {
                    if (__first49)
                    {
                        __first49 = false;
                    }
                    __cb.Push("        ");
                    #line (336,17)-(336,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write("((__IModelObject)this).MGetSlot(");
                    #line hidden
                    #line (336,50)-(336,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty));
                    #line hidden
                    #line (336,78)-(336,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")?.Add((");
                    #line hidden
                    #line (336,87)-(336,119) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty.Type));
                    #line hidden
                    #line (336,120)-(336,121) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (336,122)-(336,178) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpValue(slot.SlotProperty.Type, slot.DefaultValue));
                    #line hidden
                    #line (336,179)-(336,181) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first49) __cb.AppendLine();
            }
            if (!__first48) __cb.AppendLine();
            var __first50 = true;
            #line (339,10)-(339,66) 13 "MetaModelGenerator.mxg"
            foreach (var baseType in metaCls.AllBaseTypes.Reverse())
            #line hidden
            
            {
                if (__first50)
                {
                    __first50 = false;
                }
                __cb.Push("        ");
                #line (340,14)-(340,21) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (340,22)-(340,36) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (340,37)-(340,50) 28 "MetaModelGenerator.mxg"
                __cb.Write(baseType.Name);
                #line hidden
                #line (340,51)-(340,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first50) __cb.AppendLine();
            __cb.Push("        ");
            #line (342,10)-(342,17) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (342,18)-(342,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(".__CustomImpl.");
            #line hidden
            #line (342,33)-(342,41) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (342,42)-(342,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (343,5)-(343,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (345,5)-(345,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (345,11)-(345,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,12)-(345,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (345,20)-(345,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,21)-(345,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (345,37)-(345,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,38)-(345,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("MInfo");
            #line hidden
            #line (345,43)-(345,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,44)-(345,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (345,46)-(345,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (345,47)-(345,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info.Instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first51 = true;
            #line (347,6)-(347,57) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                #line (348,10)-(348,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                var __first52 = true;
                #line (349,10)-(349,54) 17 "MetaModelGenerator.mxg"
                if (metaCls.PublicProperties.Contains(prop))
                #line hidden
                
                {
                    if (__first52)
                    {
                        __first52 = false;
                    }
                    __cb.Push("    ");
                    #line (350,13)-(350,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (350,19)-(350,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,21)-(350,142) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (350,143)-(350,144) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (350,145)-(350,154) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (351,10)-(351,14) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first52)
                    {
                        __first52 = false;
                    }
                    __cb.Push("    ");
                    #line (352,14)-(352,17) 32 "MetaModelGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (352,18)-(352,119) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)");
                    #line hidden
                    #line (352,120)-(352,123) 32 "MetaModelGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (353,14)-(353,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (353,136)-(353,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (353,138)-(353,181) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.DeclaringType.UnderlyingType));
                    #line hidden
                    #line (353,182)-(353,183) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (353,184)-(353,193) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first52) __cb.AppendLine();
                __cb.Push("    ");
                #line (355,9)-(355,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first53 = true;
                #line (356,14)-(356,52) 17 "MetaModelGenerator.mxg"
                if (prop.UnderlyingProperty.IsDerived)
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    #line (357,18)-(357,81) 21 "MetaModelGenerator.mxg"
                    var actualProp = info.HidingProperties.FirstOrDefault() ?? prop;
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (358,17)-(358,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (358,20)-(358,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (358,21)-(358,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (358,23)-(358,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (358,25)-(358,32) 32 "MetaModelGenerator.mxg"
                    __cb.Write(mm.Name);
                    #line hidden
                    #line (358,33)-(358,47) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".__CustomImpl.");
                    #line hidden
                    #line (358,48)-(358,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.DeclaringType.Name);
                    #line hidden
                    #line (358,78)-(358,79) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (358,80)-(358,95) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.Name);
                    #line hidden
                    #line (358,96)-(358,103) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(this);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (359,14)-(359,41) 17 "MetaModelGenerator.mxg"
                else if (prop.IsCollection)
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("        ");
                    #line (360,17)-(360,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (360,20)-(360,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (360,21)-(360,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (360,23)-(360,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (360,24)-(360,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGetCollection<");
                    #line hidden
                    #line (360,40)-(360,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (360,60)-(360,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (360,63)-(360,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (360,78)-(360,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (361,14)-(361,18) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("        ");
                    #line (362,17)-(362,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (362,20)-(362,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,21)-(362,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (362,23)-(362,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (362,24)-(362,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGet<");
                    #line hidden
                    #line (362,30)-(362,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (362,69)-(362,71) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (362,72)-(362,86) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (362,87)-(362,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    var __first54 = true;
                    #line (363,18)-(363,38) 21 "MetaModelGenerator.mxg"
                    if (HasSetter(prop))
                    #line hidden
                    
                    {
                        if (__first54)
                        {
                            __first54 = false;
                        }
                        __cb.Push("        ");
                        #line (364,21)-(364,24) 37 "MetaModelGenerator.mxg"
                        __cb.Write("set");
                        #line hidden
                        #line (364,24)-(364,25) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (364,25)-(364,27) 37 "MetaModelGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (364,27)-(364,28) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (364,28)-(364,33) 37 "MetaModelGenerator.mxg"
                        __cb.Write("MSet<");
                        #line hidden
                        #line (364,34)-(364,72) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                        #line hidden
                        #line (364,73)-(364,75) 37 "MetaModelGenerator.mxg"
                        __cb.Write(">(");
                        #line hidden
                        #line (364,76)-(364,90) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop));
                        #line hidden
                        #line (364,91)-(364,92) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (364,92)-(364,93) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (364,93)-(364,100) 37 "MetaModelGenerator.mxg"
                        __cb.Write("value);");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first54) __cb.AppendLine();
                }
                if (!__first53) __cb.AppendLine();
                __cb.Push("    ");
                #line (367,9)-(367,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first55 = true;
            #line (371,6)-(371,55) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first55)
                {
                    __first55 = false;
                }
                #line (372,10)-(372,52) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                #line (373,10)-(373,73) 17 "MetaModelGenerator.mxg"
                var actualOp = info.OverridingOperations.FirstOrDefault() ?? op;
                #line hidden
                
                __cb.Push("    ");
                #line (374,10)-(374,59) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.UnderlyingOperation.ReturnType));
                #line hidden
                #line (374,60)-(374,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (374,62)-(374,103) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.DeclaringType.UnderlyingType));
                #line hidden
                #line (374,104)-(374,105) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (374,106)-(374,113) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (374,114)-(374,115) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first56 = true;
                #line (374,116)-(374,173) 17 "MetaModelGenerator.mxg"
                foreach (var param in op.UnderlyingOperation.Parameters) 
                #line hidden
                
                {
                    if (__first56)
                    {
                        __first56 = false;
                    }
                    else
                    {
                        __cb.Push("    ");
                        __cb.DontIgnoreLastLineEnd = true;
                        #line (374,183)-(374,187) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (374,189)-(374,215) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (374,216)-(374,217) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (374,218)-(374,228) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (374,242)-(374,243) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (374,243)-(374,244) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (374,244)-(374,246) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (374,246)-(374,247) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (374,248)-(374,255) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (374,256)-(374,270) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (374,271)-(374,298) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.DeclaringType.Name);
                #line hidden
                #line (374,299)-(374,300) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (374,301)-(374,314) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.Name);
                #line hidden
                #line (374,315)-(374,320) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this");
                #line hidden
                var __first57 = true;
                #line (374,321)-(374,383) 17 "MetaModelGenerator.mxg"
                foreach (var param in actualOp.UnderlyingOperation.Parameters)
                #line hidden
                
                {
                    if (__first57)
                    {
                        __first57 = false;
                    }
                    #line (374,384)-(374,385) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (374,385)-(374,386) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (374,387)-(374,397) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (374,411)-(374,413) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first55) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (377,5)-(377,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (377,13)-(377,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,14)-(377,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (377,19)-(377,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,20)-(377,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (377,26)-(377,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,27)-(377,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (377,28)-(377,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (377,29)-(377,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (378,5)-(378,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (379,9)-(379,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (379,15)-(379,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,16)-(379,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (379,22)-(379,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,23)-(379,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (379,31)-(379,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,32)-(379,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (379,38)-(379,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,39)-(379,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (379,47)-(379,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,48)-(379,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (379,49)-(379,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,50)-(379,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (379,53)-(379,54) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (379,54)-(379,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (381,9)-(381,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (381,16)-(381,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,17)-(381,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (381,25)-(381,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,26)-(381,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (381,95)-(381,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (381,96)-(381,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (382,9)-(382,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (382,16)-(382,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,17)-(382,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (382,25)-(382,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,26)-(382,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (382,95)-(382,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,96)-(382,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (383,9)-(383,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (383,16)-(383,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,17)-(383,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (383,25)-(383,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,26)-(383,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (383,94)-(383,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (383,95)-(383,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (384,9)-(384,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (384,16)-(384,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,17)-(384,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (384,25)-(384,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,26)-(384,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (384,94)-(384,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,95)-(384,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (385,9)-(385,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (385,16)-(385,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,17)-(385,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (385,25)-(385,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,26)-(385,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (385,94)-(385,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (385,95)-(385,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (386,9)-(386,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (386,16)-(386,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,17)-(386,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (386,25)-(386,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,26)-(386,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (386,90)-(386,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,91)-(386,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (386,107)-(386,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,108)-(386,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (387,9)-(387,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (387,16)-(387,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,17)-(387,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (387,25)-(387,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,26)-(387,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (387,99)-(387,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,100)-(387,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (387,120)-(387,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,121)-(387,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (388,9)-(388,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (388,16)-(388,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,17)-(388,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (388,25)-(388,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,26)-(388,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (388,95)-(388,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,96)-(388,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (389,9)-(389,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (389,16)-(389,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,17)-(389,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (389,25)-(389,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,26)-(389,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (389,95)-(389,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,96)-(389,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (390,9)-(390,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (390,16)-(390,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (390,17)-(390,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (390,25)-(390,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (390,26)-(390,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (390,95)-(390,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (390,96)-(390,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (391,9)-(391,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (391,16)-(391,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,17)-(391,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (391,25)-(391,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,26)-(391,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (391,100)-(391,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,101)-(391,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (391,122)-(391,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,123)-(391,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (393,9)-(393,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (393,16)-(393,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,17)-(393,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info()");
            #line hidden
            #line (393,25)-(393,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (394,9)-(394,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (395,13)-(395,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes");
            #line hidden
            #line (395,23)-(395,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,24)-(395,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (395,25)-(395,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,26)-(395,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first58 = true;
            #line (395,69)-(395,107) 13 "MetaModelGenerator.mxg"
            foreach (var bt in metaCls.BaseTypes) 
            #line hidden
            
            {
                if (__first58)
                {
                    __first58 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (395,117)-(395,121) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (395,123)-(395,135) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (395,149)-(395,151) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (396,13)-(396,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes");
            #line hidden
            #line (396,26)-(396,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,27)-(396,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (396,28)-(396,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,29)-(396,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first59 = true;
            #line (396,72)-(396,113) 13 "MetaModelGenerator.mxg"
            foreach (var bt in metaCls.AllBaseTypes) 
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
                    #line (396,123)-(396,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (396,129)-(396,141) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (396,155)-(396,157) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (397,13)-(397,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties");
            #line hidden
            #line (397,32)-(397,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,33)-(397,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (397,34)-(397,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (397,35)-(397,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first60 = true;
            #line (397,77)-(397,126) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties) 
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
                    #line (397,136)-(397,140) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (397,142)-(397,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (397,170)-(397,172) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (398,13)-(398,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties");
            #line hidden
            #line (398,35)-(398,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (398,36)-(398,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (398,37)-(398,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (398,38)-(398,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first61 = true;
            #line (398,80)-(398,132) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties) 
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
                    #line (398,142)-(398,146) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (398,148)-(398,162) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (398,176)-(398,178) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (399,13)-(399,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties");
            #line hidden
            #line (399,30)-(399,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (399,31)-(399,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (399,32)-(399,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (399,33)-(399,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first62 = true;
            #line (399,75)-(399,122) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties) 
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
                    #line (399,132)-(399,136) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (399,138)-(399,152) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (399,166)-(399,168) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (400,13)-(400,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (400,16)-(400,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,17)-(400,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName");
            #line hidden
            #line (400,39)-(400,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,40)-(400,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (400,41)-(400,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,42)-(400,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (400,85)-(400,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,86)-(400,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first63 = true;
            #line (401,14)-(401,60) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties)
            #line hidden
            
            {
                if (__first63)
                {
                    __first63 = false;
                }
                __cb.Push("            ");
                #line (402,17)-(402,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("publicPropertiesByName.Add(\"");
                #line hidden
                #line (402,46)-(402,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (402,56)-(402,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (402,58)-(402,59) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (402,60)-(402,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (402,75)-(402,77) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first63) __cb.AppendLine();
            __cb.Push("            ");
            #line (404,13)-(404,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName");
            #line hidden
            #line (404,36)-(404,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (404,37)-(404,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (404,38)-(404,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (404,39)-(404,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (405,13)-(405,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (405,16)-(405,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,17)-(405,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos");
            #line hidden
            #line (405,35)-(405,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,36)-(405,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (405,37)-(405,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,38)-(405,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelProperty,");
            #line hidden
            #line (405,90)-(405,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,91)-(405,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first64 = true;
            #line (406,14)-(406,65) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first64)
                {
                    __first64 = false;
                }
                #line (407,18)-(407,61) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                #line (408,18)-(408,38) 17 "MetaModelGenerator.mxg"
                var slot = info.Slot;
                #line hidden
                
                __cb.Push("            ");
                #line (409,17)-(409,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelPropertyInfos.Add(");
                #line hidden
                #line (409,41)-(409,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (409,56)-(409,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,57)-(409,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,58)-(409,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (409,61)-(409,62) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,62)-(409,85) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertyInfo(new");
                #line hidden
                #line (409,85)-(409,86) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,86)-(409,106) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertySlot(");
                #line hidden
                #line (409,107)-(409,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperty));
                #line hidden
                #line (409,135)-(409,136) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,136)-(409,137) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,138)-(409,167) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperties));
                #line hidden
                #line (409,168)-(409,169) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,169)-(409,170) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,171)-(409,214) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpValue(prop.Type, prop.DefaultValue));
                #line hidden
                #line (409,215)-(409,216) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,216)-(409,217) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,218)-(409,238) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.Flags));
                #line hidden
                #line (409,239)-(409,241) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (409,241)-(409,242) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,243)-(409,276) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OppositeProperties));
                #line hidden
                #line (409,277)-(409,278) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,278)-(409,279) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,280)-(409,314) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettedProperties));
                #line hidden
                #line (409,315)-(409,316) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,316)-(409,317) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,318)-(409,353) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettingProperties));
                #line hidden
                #line (409,354)-(409,355) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,355)-(409,356) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,357)-(409,391) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefinedProperties));
                #line hidden
                #line (409,392)-(409,393) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,393)-(409,394) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,395)-(409,430) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefiningProperties));
                #line hidden
                #line (409,431)-(409,432) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,432)-(409,433) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,434)-(409,465) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HiddenProperties));
                #line hidden
                #line (409,466)-(409,467) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (409,467)-(409,468) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (409,469)-(409,500) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HidingProperties));
                #line hidden
                #line (409,501)-(409,504) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first64) __cb.AppendLine();
            __cb.Push("            ");
            #line (411,13)-(411,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos");
            #line hidden
            #line (411,32)-(411,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,33)-(411,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (411,34)-(411,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (411,35)-(411,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (413,13)-(413,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations");
            #line hidden
            #line (413,32)-(413,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (413,33)-(413,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (413,34)-(413,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (413,35)-(413,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first65 = true;
            #line (413,78)-(413,125) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.DeclaredOperations) 
            #line hidden
            
            {
                if (__first65)
                {
                    __first65 = false;
                }
                else
                {
                    __cb.Push("            ");
                    __cb.DontIgnoreLastLineEnd = true;
                    #line (413,135)-(413,139) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (413,141)-(413,153) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (413,167)-(413,169) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (414,13)-(414,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations");
            #line hidden
            #line (414,35)-(414,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,36)-(414,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (414,37)-(414,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (414,38)-(414,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first66 = true;
            #line (414,81)-(414,131) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations) 
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
                    #line (414,141)-(414,145) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (414,147)-(414,159) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (414,173)-(414,175) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (415,13)-(415,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations");
            #line hidden
            #line (415,30)-(415,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (415,31)-(415,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (415,32)-(415,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (415,33)-(415,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first67 = true;
            #line (415,76)-(415,121) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.PublicOperations) 
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
                    #line (415,131)-(415,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (415,137)-(415,149) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (415,163)-(415,165) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (416,13)-(416,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (416,16)-(416,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,17)-(416,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos");
            #line hidden
            #line (416,36)-(416,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,37)-(416,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (416,38)-(416,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,39)-(416,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelOperation,");
            #line hidden
            #line (416,92)-(416,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,93)-(416,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first68 = true;
            #line (417,14)-(417,63) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first68)
                {
                    __first68 = false;
                }
                #line (418,14)-(418,56) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                __cb.Push("                ");
                #line (419,17)-(419,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelOperationInfos.Add(");
                #line hidden
                #line (419,42)-(419,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
                #line (419,55)-(419,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (419,56)-(419,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (419,57)-(419,60) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (419,60)-(419,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (419,61)-(419,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelOperationInfo(");
                #line hidden
                #line (419,83)-(419,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridenOperations));
                #line hidden
                #line (419,118)-(419,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (419,119)-(419,120) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (419,121)-(419,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridingOperations));
                #line hidden
                #line (419,157)-(419,160) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first68) __cb.AppendLine();
            __cb.Push("            ");
            #line (421,13)-(421,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos");
            #line hidden
            #line (421,33)-(421,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,34)-(421,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (421,35)-(421,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,36)-(421,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (422,9)-(422,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (424,9)-(424,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (424,15)-(424,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,16)-(424,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (424,24)-(424,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,25)-(424,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (424,36)-(424,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,37)-(424,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (424,46)-(424,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,47)-(424,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (424,49)-(424,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (424,51)-(424,58) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (424,59)-(424,70) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (425,9)-(425,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (425,15)-(425,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,16)-(425,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (425,24)-(425,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,25)-(425,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (425,35)-(425,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,36)-(425,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (425,44)-(425,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,45)-(425,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (425,47)-(425,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (425,48)-(425,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (425,56)-(425,64) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (425,65)-(425,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (427,9)-(427,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (427,15)-(427,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,16)-(427,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (427,24)-(427,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,25)-(427,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (427,35)-(427,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,36)-(427,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (427,46)-(427,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (427,47)-(427,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (427,49)-(427,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first69 = true;
            #line (427,51)-(427,82) 13 "MetaModelGenerator.mxg"
            if (metaCls.SymbolType is null)
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (427,83)-(427,90) 29 "MetaModelGenerator.mxg"
                __cb.Write("default");
                #line hidden
            }
            #line (427,91)-(427,95) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (427,96)-(427,103) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (427,104)-(427,132) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.SymbolType));
                #line hidden
                #line (427,133)-(427,134) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (427,142)-(427,143) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (428,9)-(428,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (428,15)-(428,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,16)-(428,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (428,24)-(428,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,25)-(428,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (428,41)-(428,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,42)-(428,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("NameProperty");
            #line hidden
            #line (428,54)-(428,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (428,55)-(428,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (428,57)-(428,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first70 = true;
            #line (428,59)-(428,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.NameProperty is null)
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (428,93)-(428,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (428,98)-(428,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (428,104)-(428,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.NameProperty));
                #line hidden
            }
            #line (428,143)-(428,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (429,9)-(429,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (429,15)-(429,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,16)-(429,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (429,24)-(429,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,25)-(429,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (429,41)-(429,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,42)-(429,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("TypeProperty");
            #line hidden
            #line (429,54)-(429,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,55)-(429,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (429,57)-(429,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first71 = true;
            #line (429,59)-(429,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.TypeProperty is null)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (429,93)-(429,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (429,98)-(429,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (429,104)-(429,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.TypeProperty));
                #line hidden
            }
            #line (429,143)-(429,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (430,9)-(430,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (430,15)-(430,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,16)-(430,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (430,24)-(430,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,25)-(430,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (430,94)-(430,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,95)-(430,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("BaseTypes");
            #line hidden
            #line (430,104)-(430,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,105)-(430,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (430,107)-(430,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,108)-(430,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (431,9)-(431,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (431,15)-(431,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,16)-(431,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (431,24)-(431,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,25)-(431,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (431,94)-(431,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,95)-(431,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllBaseTypes");
            #line hidden
            #line (431,107)-(431,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,108)-(431,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (431,110)-(431,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (431,111)-(431,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (432,9)-(432,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (432,15)-(432,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,16)-(432,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (432,24)-(432,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,25)-(432,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (432,93)-(432,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,94)-(432,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredProperties");
            #line hidden
            #line (432,112)-(432,113) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,113)-(432,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (432,115)-(432,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,116)-(432,136) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (433,9)-(433,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (433,15)-(433,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,16)-(433,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (433,24)-(433,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,25)-(433,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (433,93)-(433,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,94)-(433,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredProperties");
            #line hidden
            #line (433,115)-(433,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,116)-(433,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (433,118)-(433,119) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,119)-(433,142) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (434,9)-(434,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (434,15)-(434,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,16)-(434,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (434,24)-(434,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,25)-(434,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (434,93)-(434,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,94)-(434,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicProperties");
            #line hidden
            #line (434,110)-(434,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,111)-(434,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (434,113)-(434,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,114)-(434,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (435,9)-(435,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (435,15)-(435,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,16)-(435,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (435,24)-(435,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,25)-(435,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (435,94)-(435,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,95)-(435,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredOperations");
            #line hidden
            #line (435,113)-(435,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,114)-(435,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (435,116)-(435,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,117)-(435,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (436,9)-(436,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (436,15)-(436,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,16)-(436,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (436,24)-(436,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,25)-(436,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (436,94)-(436,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,95)-(436,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredOperations");
            #line hidden
            #line (436,116)-(436,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,117)-(436,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (436,119)-(436,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,120)-(436,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (437,9)-(437,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (437,15)-(437,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,16)-(437,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (437,24)-(437,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,25)-(437,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (437,94)-(437,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,95)-(437,111) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicOperations");
            #line hidden
            #line (437,111)-(437,112) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,112)-(437,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (437,114)-(437,115) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,115)-(437,133) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (439,9)-(439,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (439,18)-(439,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,19)-(439,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (439,27)-(439,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,28)-(439,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (439,92)-(439,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,93)-(439,109) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (439,109)-(439,110) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,110)-(439,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicPropertiesByName");
            #line hidden
            #line (439,132)-(439,133) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,133)-(439,135) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (439,135)-(439,136) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,136)-(439,160) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (440,9)-(440,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (440,18)-(440,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,19)-(440,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (440,27)-(440,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,28)-(440,101) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (440,101)-(440,102) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,102)-(440,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (440,122)-(440,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,123)-(440,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelPropertyInfos");
            #line hidden
            #line (440,141)-(440,142) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,142)-(440,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (440,144)-(440,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,145)-(440,165) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (441,9)-(441,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (441,18)-(441,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,19)-(441,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (441,27)-(441,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,28)-(441,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (441,102)-(441,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,103)-(441,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (441,124)-(441,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,125)-(441,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelOperationInfos");
            #line hidden
            #line (441,144)-(441,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,145)-(441,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (441,147)-(441,148) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,148)-(441,169) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (443,9)-(443,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (443,15)-(443,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,16)-(443,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (443,24)-(443,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,25)-(443,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (443,40)-(443,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,41)-(443,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("Create(__Model?");
            #line hidden
            #line (443,56)-(443,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,57)-(443,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (443,62)-(443,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,63)-(443,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (443,64)-(443,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,65)-(443,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (443,70)-(443,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,71)-(443,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (443,78)-(443,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,79)-(443,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("id");
            #line hidden
            #line (443,81)-(443,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,82)-(443,83) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (443,83)-(443,84) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (443,84)-(443,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (444,9)-(444,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (445,13)-(445,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (445,16)-(445,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,17)-(445,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (445,23)-(445,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,24)-(445,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (445,25)-(445,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,26)-(445,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (445,29)-(445,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,31)-(445,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (445,40)-(445,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(id);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (446,13)-(446,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (446,15)-(446,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,16)-(446,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("(model");
            #line hidden
            #line (446,22)-(446,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,23)-(446,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (446,25)-(446,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,26)-(446,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (446,29)-(446,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,30)-(446,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (446,35)-(446,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,36)-(446,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("model.AttachObject(result);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (447,13)-(447,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (447,19)-(447,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (447,20)-(447,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (448,9)-(448,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (450,9)-(450,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (450,15)-(450,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,16)-(450,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (450,24)-(450,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,25)-(450,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (450,31)-(450,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,32)-(450,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ToString()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (451,9)-(451,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (452,13)-(452,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (452,19)-(452,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (452,20)-(452,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (452,22)-(452,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (452,30)-(452,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(".");
            #line hidden
            #line (452,32)-(452,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (452,41)-(452,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("Info\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (453,9)-(453,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (454,5)-(454,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (455,1)-(455,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (458,9)-(458,47) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomInterface(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (459,1)-(459,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (459,9)-(459,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,10)-(459,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (459,19)-(459,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (459,20)-(459,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (459,28)-(459,35) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (459,36)-(459,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (460,1)-(460,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (461,5)-(461,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (461,8)-(461,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (461,9)-(461,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (462,5)-(462,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (462,8)-(462,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,9)-(462,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (462,20)-(462,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,21)-(462,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (462,24)-(462,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,25)-(462,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (462,28)-(462,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,29)-(462,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (462,33)-(462,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,34)-(462,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (462,39)-(462,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (462,41)-(462,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (463,5)-(463,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (463,8)-(463,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (463,9)-(463,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (464,5)-(464,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (464,9)-(464,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,11)-(464,18) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (464,19)-(464,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (464,22)-(464,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (464,30)-(464,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,31)-(464,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first72 = true;
            #line (466,6)-(466,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                __cb.Push("    ");
                #line (467,9)-(467,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (467,12)-(467,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (467,13)-(467,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (468,9)-(468,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (468,12)-(468,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (468,13)-(468,24) 29 "MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (468,24)-(468,25) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (468,25)-(468,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (468,28)-(468,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (468,29)-(468,32) 29 "MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (468,32)-(468,33) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (468,33)-(468,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (468,38)-(468,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (468,40)-(468,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (469,9)-(469,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (469,12)-(469,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (469,13)-(469,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (470,9)-(470,13) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (470,13)-(470,14) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (470,15)-(470,23) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (470,24)-(470,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (470,26)-(470,34) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (470,35)-(470,36) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (470,36)-(470,43) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first72) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (474,6)-(474,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                var __first74 = true;
                #line (475,10)-(475,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first74)
                    {
                        __first74 = false;
                    }
                    __cb.Push("    ");
                    #line (476,13)-(476,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (476,16)-(476,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (476,17)-(476,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (477,13)-(477,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (477,16)-(477,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,17)-(477,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (477,28)-(477,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,29)-(477,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (477,31)-(477,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,32)-(477,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (477,35)-(477,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,36)-(477,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (477,43)-(477,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,44)-(477,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (477,52)-(477,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (477,54)-(477,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (477,63)-(477,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (477,65)-(477,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (478,13)-(478,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (478,16)-(478,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (478,17)-(478,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (479,14)-(479,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (479,40)-(479,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (479,42)-(479,50) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (479,51)-(479,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (479,53)-(479,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (479,63)-(479,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (479,65)-(479,73) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (479,74)-(479,75) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (479,75)-(479,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first74) __cb.AppendLine();
            }
            if (!__first73) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first75 = true;
            #line (484,6)-(484,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first75)
                {
                    __first75 = false;
                }
                var __first76 = true;
                #line (485,10)-(485,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first76)
                    {
                        __first76 = false;
                    }
                    __cb.Push("    ");
                    #line (486,13)-(486,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (486,16)-(486,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (486,17)-(486,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (487,13)-(487,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (487,16)-(487,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (487,17)-(487,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (487,31)-(487,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (487,32)-(487,34) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (487,34)-(487,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (487,35)-(487,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (487,38)-(487,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (487,39)-(487,48) 33 "MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (487,48)-(487,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (487,50)-(487,58) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (487,59)-(487,60) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (487,61)-(487,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (488,13)-(488,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (488,16)-(488,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (488,17)-(488,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (489,14)-(489,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (489,44)-(489,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (489,46)-(489,54) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (489,55)-(489,56) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (489,57)-(489,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (489,65)-(489,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (489,67)-(489,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (489,76)-(489,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (489,77)-(489,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first77 = true;
                    #line (489,83)-(489,119) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first77)
                        {
                            __first77 = false;
                        }
                        #line (489,120)-(489,121) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (489,121)-(489,122) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (489,123)-(489,149) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (489,150)-(489,151) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (489,152)-(489,162) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (489,176)-(489,178) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first76) __cb.AppendLine();
            }
            if (!__first75) __cb.AppendLine();
            __cb.Push("");
            #line (493,1)-(493,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (496,9)-(496,52) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomImplementation(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (497,1)-(497,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (497,9)-(497,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,10)-(497,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (497,18)-(497,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,19)-(497,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (497,24)-(497,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,25)-(497,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (497,32)-(497,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (497,40)-(497,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (497,58)-(497,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,59)-(497,60) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (497,60)-(497,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (497,61)-(497,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (497,69)-(497,76) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (497,77)-(497,91) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (498,1)-(498,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (499,5)-(499,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (499,8)-(499,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (499,9)-(499,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (500,5)-(500,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (500,8)-(500,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,9)-(500,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (500,20)-(500,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,21)-(500,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (500,24)-(500,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,25)-(500,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (500,28)-(500,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,29)-(500,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (500,33)-(500,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,34)-(500,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (500,39)-(500,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (500,41)-(500,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (501,5)-(501,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (501,8)-(501,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (501,9)-(501,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (502,5)-(502,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (502,11)-(502,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,12)-(502,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (502,19)-(502,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,20)-(502,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (502,24)-(502,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,26)-(502,33) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (502,34)-(502,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (502,37)-(502,44) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (502,45)-(502,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,46)-(502,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (503,5)-(503,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (504,5)-(504,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first78 = true;
            #line (506,6)-(506,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first78)
                {
                    __first78 = false;
                }
                __cb.Push("    ");
                #line (507,9)-(507,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (507,12)-(507,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (507,13)-(507,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (508,9)-(508,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (508,12)-(508,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,13)-(508,24) 29 "MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (508,24)-(508,25) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,25)-(508,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (508,28)-(508,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,29)-(508,32) 29 "MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (508,32)-(508,33) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,33)-(508,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (508,38)-(508,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (508,40)-(508,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (509,9)-(509,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (509,12)-(509,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (509,13)-(509,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (510,9)-(510,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (510,15)-(510,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (510,16)-(510,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("virtual");
                #line hidden
                #line (510,23)-(510,24) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (510,24)-(510,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (510,28)-(510,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (510,30)-(510,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (510,39)-(510,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (510,41)-(510,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (510,50)-(510,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (510,51)-(510,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (511,9)-(511,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (512,9)-(512,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first78) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first79 = true;
            #line (516,6)-(516,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                var __first80 = true;
                #line (517,10)-(517,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first80)
                    {
                        __first80 = false;
                    }
                    __cb.Push("    ");
                    #line (518,13)-(518,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (518,16)-(518,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (518,17)-(518,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (519,13)-(519,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (519,16)-(519,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,17)-(519,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (519,28)-(519,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,29)-(519,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (519,31)-(519,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,32)-(519,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (519,35)-(519,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,36)-(519,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (519,43)-(519,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,44)-(519,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (519,52)-(519,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (519,54)-(519,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (519,63)-(519,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (519,65)-(519,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (520,13)-(520,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (520,16)-(520,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (520,17)-(520,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (521,13)-(521,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (521,19)-(521,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (521,20)-(521,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (521,28)-(521,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (521,30)-(521,55) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (521,56)-(521,57) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (521,58)-(521,66) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (521,67)-(521,68) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (521,69)-(521,78) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (521,79)-(521,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (521,81)-(521,89) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (521,90)-(521,91) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (521,91)-(521,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first80) __cb.AppendLine();
            }
            if (!__first79) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first81 = true;
            #line (526,6)-(526,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first81)
                {
                    __first81 = false;
                }
                var __first82 = true;
                #line (527,10)-(527,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first82)
                    {
                        __first82 = false;
                    }
                    __cb.Push("    ");
                    #line (528,13)-(528,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (528,16)-(528,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (528,17)-(528,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (529,13)-(529,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (529,16)-(529,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,17)-(529,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (529,31)-(529,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,32)-(529,34) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (529,34)-(529,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,35)-(529,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (529,38)-(529,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,39)-(529,48) 33 "MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (529,48)-(529,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (529,50)-(529,58) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (529,59)-(529,60) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (529,61)-(529,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (530,13)-(530,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (530,16)-(530,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (530,17)-(530,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (531,13)-(531,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (531,19)-(531,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (531,20)-(531,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (531,28)-(531,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (531,30)-(531,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (531,60)-(531,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (531,62)-(531,70) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (531,71)-(531,72) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (531,73)-(531,80) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (531,81)-(531,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (531,83)-(531,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (531,92)-(531,93) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (531,93)-(531,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first83 = true;
                    #line (531,99)-(531,135) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first83)
                        {
                            __first83 = false;
                        }
                        #line (531,136)-(531,137) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (531,137)-(531,138) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (531,139)-(531,165) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (531,166)-(531,167) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (531,168)-(531,178) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (531,192)-(531,194) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first82) __cb.AppendLine();
            }
            if (!__first81) __cb.AppendLine();
            __cb.Push("");
            #line (535,1)-(535,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}