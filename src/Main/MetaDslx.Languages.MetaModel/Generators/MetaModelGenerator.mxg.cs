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
            #line (173,31)-(173,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(_model,");
            #line hidden
            #line (173,51)-(173,52) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (173,52)-(173,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("this);");
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
            var __first23 = true;
            #line (177,18)-(177,38) 13 "MetaModelGenerator.mxg"
            if (IsMetaMetaModel)
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (177,39)-(177,42) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (177,42)-(177,43) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,43)-(177,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaModelFactory(_model,");
                #line hidden
                #line (177,69)-(177,70) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,70)-(177,75) 29 "MetaModelGenerator.mxg"
                __cb.Write("this)");
                #line hidden
            }
            #line (177,76)-(177,80) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first23)
                {
                    __first23 = false;
                }
                #line (177,81)-(177,84) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (177,84)-(177,85) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (177,85)-(177,111) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaModelFactory(_model)");
                #line hidden
            }
            #line (177,119)-(177,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first24 = true;
            #line (178,10)-(178,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first24)
                {
                    __first24 = false;
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
            if (!__first24) __cb.AppendLine();
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
            var __first25 = true;
            #line (182,10)-(182,38) 13 "MetaModelGenerator.mxg"
            foreach (var obj in Objects)
            #line hidden
            
            {
                if (__first25)
                {
                    __first25 = false;
                }
                var __first26 = true;
                #line (183,14)-(183,50) 17 "MetaModelGenerator.mxg"
                foreach (var child in obj.MChildren)
                #line hidden
                
                {
                    if (__first26)
                    {
                        __first26 = false;
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
                if (!__first26) __cb.AppendLine();
                var __first27 = true;
                #line (186,14)-(186,62) 17 "MetaModelGenerator.mxg"
                foreach (var prop in obj.MInfo.PublicProperties)
                #line hidden
                
                {
                    if (__first27)
                    {
                        __first27 = false;
                    }
                    #line (187,18)-(187,47) 21 "MetaModelGenerator.mxg"
                    var slot = obj.MGetSlot(prop);
                    #line hidden
                    
                    var __first28 = true;
                    #line (188,18)-(188,54) 21 "MetaModelGenerator.mxg"
                    if (slot != null && !slot.IsDefault)
                    #line hidden
                    
                    {
                        if (__first28)
                        {
                            __first28 = false;
                        }
                        var __first29 = true;
                        #line (189,22)-(189,44) 25 "MetaModelGenerator.mxg"
                        if (prop.IsCollection)
                        #line hidden
                        
                        {
                            if (__first29)
                            {
                                __first29 = false;
                            }
                            var __first30 = true;
                            #line (190,26)-(190,60) 29 "MetaModelGenerator.mxg"
                            foreach (var value in slot.Values)
                            #line hidden
                            
                            {
                                if (__first30)
                                {
                                    __first30 = false;
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
                            if (!__first30) __cb.AppendLine();
                        }
                        #line (193,22)-(193,48) 25 "MetaModelGenerator.mxg"
                        else if (!prop.IsReadOnly)
                        #line hidden
                        
                        {
                            if (__first29)
                            {
                                __first29 = false;
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
                        if (!__first29) __cb.AppendLine();
                    }
                    if (!__first28) __cb.AppendLine();
                }
                if (!__first27) __cb.AppendLine();
            }
            if (!__first25) __cb.AppendLine();
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
            var __first31 = true;
            #line (219,6)-(219,70) 13 "MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first31)
                {
                    __first31 = false;
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
            if (!__first31) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first32 = true;
            #line (223,6)-(223,70) 13 "MetaModelGenerator.mxg"
            foreach (var c in mm.Parent.Declarations.OfType<MetaConstant>())
            #line hidden
            
            {
                if (__first32)
                {
                    __first32 = false;
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
            if (!__first32) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first33 = true;
            #line (227,6)-(227,32) 13 "MetaModelGenerator.mxg"
            foreach (var enm in Enums)
            #line hidden
            
            {
                if (__first33)
                {
                    __first33 = false;
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
            if (!__first33) __cb.AppendLine();
            var __first34 = true;
            #line (230,6)-(230,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first34)
                {
                    __first34 = false;
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
                var __first35 = true;
                #line (232,6)-(232,42) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties)
                #line hidden
                
                {
                    if (__first35)
                    {
                        __first35 = false;
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
                if (!__first35) __cb.AppendLine();
                var __first36 = true;
                #line (235,6)-(235,40) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first36)
                    {
                        __first36 = false;
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
                if (!__first36) __cb.AppendLine();
            }
            if (!__first34) __cb.AppendLine();
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
            __cb.Push("    ");
            #line (250,5)-(250,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (250,13)-(250,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,15)-(250,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (250,23)-(250,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelFactory(__Model");
            #line hidden
            #line (250,43)-(250,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,44)-(250,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("model,");
            #line hidden
            #line (250,50)-(250,51) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,52)-(250,59) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (250,60)-(250,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (250,61)-(250,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (251,9)-(251,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (251,10)-(251,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,11)-(251,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(model,");
            #line hidden
            #line (251,22)-(251,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (251,23)-(251,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("metaModel)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (252,5)-(252,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (253,5)-(253,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first37 = true;
            #line (255,6)-(255,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first37)
                {
                    __first37 = false;
                }
                __cb.Push("    ");
                #line (256,9)-(256,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (256,15)-(256,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,17)-(256,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (256,31)-(256,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,33)-(256,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (256,42)-(256,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(string?");
                #line hidden
                #line (256,50)-(256,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,51)-(256,53) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (256,53)-(256,54) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,54)-(256,55) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (256,55)-(256,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (256,56)-(256,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (257,9)-(257,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (258,13)-(258,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (258,19)-(258,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,20)-(258,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (258,22)-(258,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (258,36)-(258,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (258,38)-(258,45) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (258,46)-(258,47) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (258,48)-(258,56) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (258,57)-(258,75) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(Model,");
                #line hidden
                #line (258,75)-(258,76) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (258,76)-(258,81) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (259,9)-(259,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first37) __cb.AppendLine();
            __cb.Push("");
            #line (262,1)-(262,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (264,1)-(264,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (264,7)-(264,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,8)-(264,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (264,13)-(264,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,15)-(264,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (264,23)-(264,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory");
            #line hidden
            #line (264,40)-(264,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,41)-(264,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (264,42)-(264,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (264,43)-(264,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MultiModelFactory");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (265,1)-(265,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (266,5)-(266,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (266,11)-(266,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (266,13)-(266,20) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (266,21)-(266,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelMultiFactory()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (267,9)-(267,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (267,10)-(267,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,11)-(267,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(new");
            #line hidden
            #line (267,19)-(267,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,20)-(267,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (267,32)-(267,36) 24 "MetaModelGenerator.mxg"
            __cb.Write("[]");
            #line hidden
            #line (267,37)-(267,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,38)-(267,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            #line (267,39)-(267,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,41)-(267,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (267,49)-(267,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance");
            #line hidden
            #line (267,59)-(267,60) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (267,60)-(267,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("})");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (268,5)-(268,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (269,5)-(269,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first38 = true;
            #line (271,6)-(271,60) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes.Where(c => !c.IsAbstract))
            #line hidden
            
            {
                if (__first38)
                {
                    __first38 = false;
                }
                __cb.Push("    ");
                #line (272,9)-(272,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (272,15)-(272,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (272,17)-(272,30) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (272,31)-(272,32) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (272,33)-(272,41) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (272,42)-(272,50) 29 "MetaModelGenerator.mxg"
                __cb.Write("(__Model");
                #line hidden
                #line (272,50)-(272,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (272,51)-(272,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("model,");
                #line hidden
                #line (272,57)-(272,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (272,58)-(272,65) 29 "MetaModelGenerator.mxg"
                __cb.Write("string?");
                #line hidden
                #line (272,65)-(272,66) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (272,66)-(272,68) 29 "MetaModelGenerator.mxg"
                __cb.Write("id");
                #line hidden
                #line (272,68)-(272,69) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (272,69)-(272,70) 29 "MetaModelGenerator.mxg"
                __cb.Write("=");
                #line hidden
                #line (272,70)-(272,71) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (272,71)-(272,76) 29 "MetaModelGenerator.mxg"
                __cb.Write("null)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (273,9)-(273,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("        ");
                #line (274,13)-(274,19) 29 "MetaModelGenerator.mxg"
                __cb.Write("return");
                #line hidden
                #line (274,19)-(274,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (274,20)-(274,21) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (274,22)-(274,35) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(cls));
                #line hidden
                #line (274,36)-(274,37) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (274,38)-(274,45) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (274,46)-(274,47) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (274,48)-(274,56) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (274,57)-(274,75) 29 "MetaModelGenerator.mxg"
                __cb.Write("Info.Create(model,");
                #line hidden
                #line (274,75)-(274,76) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (274,76)-(274,81) 29 "MetaModelGenerator.mxg"
                __cb.Write("id)!;");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (275,9)-(275,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first38) __cb.AppendLine();
            __cb.Push("");
            #line (278,1)-(278,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (282,9)-(282,50) 22 "MetaModelGenerator.mxg"
        public string GenerateEnum(MetaModel mm, MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (283,1)-(283,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (283,7)-(283,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (283,8)-(283,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("enum");
            #line hidden
            #line (283,12)-(283,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (283,14)-(283,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (284,1)-(284,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first39 = true;
            #line (285,6)-(285,39) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first39)
                {
                    __first39 = false;
                }
                __cb.Push("    ");
                #line (286,10)-(286,18) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (286,19)-(286,20) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first39) __cb.AppendLine();
            __cb.Push("");
            #line (288,1)-(288,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (291,9)-(291,54) 22 "MetaModelGenerator.mxg"
        public string GenerateEnumInfo(MetaModel mm, MetaEnum enm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (292,1)-(292,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (292,9)-(292,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,10)-(292,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (292,15)-(292,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,16)-(292,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (292,19)-(292,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (292,28)-(292,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (292,33)-(292,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,34)-(292,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (292,35)-(292,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (292,36)-(292,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelEnumInfo");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (293,1)-(293,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (294,5)-(294,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (294,11)-(294,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,12)-(294,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (294,18)-(294,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,19)-(294,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (294,27)-(294,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,28)-(294,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (294,31)-(294,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (294,40)-(294,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info");
            #line hidden
            #line (294,45)-(294,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,46)-(294,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (294,54)-(294,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,55)-(294,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (294,56)-(294,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,57)-(294,60) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (294,60)-(294,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (294,61)-(294,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (294,64)-(294,72) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (294,73)-(294,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (296,5)-(296,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (296,12)-(296,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,13)-(296,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (296,21)-(296,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,22)-(296,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (296,81)-(296,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (296,82)-(296,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (297,5)-(297,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (297,12)-(297,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,13)-(297,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (297,21)-(297,22) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,22)-(297,86) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (297,86)-(297,87) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,87)-(297,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (297,100)-(297,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (297,101)-(297,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (299,5)-(299,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (299,12)-(299,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (299,13)-(299,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("__");
            #line hidden
            #line (299,16)-(299,24) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (299,25)-(299,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Info()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (300,5)-(300,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (301,9)-(301,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals");
            #line hidden
            #line (301,18)-(301,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,19)-(301,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (301,20)-(301,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (301,21)-(301,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<string>(");
            #line hidden
            var __first40 = true;
            #line (301,54)-(301,88) 13 "MetaModelGenerator.mxg"
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
                    #line (301,98)-(301,102) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (301,104)-(301,142) 28 "MetaModelGenerator.mxg"
                __cb.Write(StringUtilities.EncodeString(lit.Name));
                #line hidden
            }
            #line (301,156)-(301,158) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (302,9)-(302,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (302,12)-(302,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,13)-(302,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName");
            #line hidden
            #line (302,27)-(302,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,28)-(302,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (302,29)-(302,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,30)-(302,73) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (302,73)-(302,74) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (302,74)-(302,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first41 = true;
            #line (303,10)-(303,43) 13 "MetaModelGenerator.mxg"
            foreach (var lit in enm.Literals)
            #line hidden
            
            {
                if (__first41)
                {
                    __first41 = false;
                }
                __cb.Push("        ");
                #line (304,13)-(304,33) 29 "MetaModelGenerator.mxg"
                __cb.Write("literalsByName.Add(\"");
                #line hidden
                #line (304,34)-(304,42) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (304,43)-(304,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (304,45)-(304,46) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (304,46)-(304,69) 29 "MetaModelGenerator.mxg"
                __cb.Write("__MetaSymbol.FromValue(");
                #line hidden
                #line (304,70)-(304,78) 28 "MetaModelGenerator.mxg"
                __cb.Write(enm.Name);
                #line hidden
                #line (304,79)-(304,80) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (304,81)-(304,89) 28 "MetaModelGenerator.mxg"
                __cb.Write(lit.Name);
                #line hidden
                #line (304,90)-(304,93) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first41) __cb.AppendLine();
            __cb.Push("        ");
            #line (306,9)-(306,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName");
            #line hidden
            #line (306,24)-(306,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,25)-(306,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (306,26)-(306,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (306,27)-(306,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("literalsByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (307,5)-(307,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (309,5)-(309,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (309,11)-(309,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,12)-(309,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (309,20)-(309,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,21)-(309,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (309,32)-(309,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,33)-(309,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (309,42)-(309,43) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,43)-(309,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (309,45)-(309,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (309,47)-(309,54) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (309,55)-(309,66) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (310,5)-(310,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (310,11)-(310,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,12)-(310,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (310,20)-(310,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,21)-(310,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (310,31)-(310,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,32)-(310,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (310,40)-(310,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,41)-(310,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (310,43)-(310,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (310,44)-(310,51) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (310,52)-(310,60) 24 "MetaModelGenerator.mxg"
            __cb.Write(enm.Name);
            #line hidden
            #line (310,61)-(310,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (311,5)-(311,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (311,11)-(311,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,12)-(311,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (311,20)-(311,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,21)-(311,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<string>");
            #line hidden
            #line (311,80)-(311,81) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,81)-(311,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("Literals");
            #line hidden
            #line (311,89)-(311,90) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,90)-(311,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (311,92)-(311,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (311,93)-(311,103) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literals;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (312,5)-(312,14) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (312,14)-(312,15) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,15)-(312,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (312,23)-(312,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,24)-(312,88) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (312,88)-(312,89) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,89)-(312,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaSymbol>");
            #line hidden
            #line (312,102)-(312,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,103)-(312,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("LiteralsByName");
            #line hidden
            #line (312,117)-(312,118) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,118)-(312,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (312,120)-(312,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (312,121)-(312,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_literalsByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (313,1)-(313,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (316,9)-(316,56) 22 "MetaModelGenerator.mxg"
        public string GenerateInterface(MetaModel mm, MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (317,2)-(317,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            #line (318,1)-(318,7) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (318,7)-(318,8) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (318,8)-(318,17) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (318,17)-(318,18) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (318,19)-(318,27) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            var __first42 = true;
            #line (318,29)-(318,53) 13 "MetaModelGenerator.mxg"
            if (cls.BaseTypes.Any())
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (318,54)-(318,55) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (318,55)-(318,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (318,56)-(318,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first43 = true;
                #line (318,58)-(318,92) 17 "MetaModelGenerator.mxg"
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
                        #line (318,102)-(318,106) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (318,107)-(318,115) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::");
                    #line hidden
                    #line (318,116)-(318,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(bt.FullName);
                    #line hidden
                }
            }
            #line (318,142)-(318,146) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first42)
                {
                    __first42 = false;
                }
                #line (318,147)-(318,148) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (318,148)-(318,149) 29 "MetaModelGenerator.mxg"
                __cb.Write(":");
                #line hidden
                #line (318,149)-(318,150) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (318,150)-(318,164) 29 "MetaModelGenerator.mxg"
                __cb.Write("__IModelObject");
                #line hidden
            }
            if (!__first42) __cb.AppendLine();
            __cb.Push("");
            #line (319,1)-(319,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first44 = true;
            #line (320,6)-(320,54) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.DeclaredProperties)
            #line hidden
            
            {
                if (__first44)
                {
                    __first44 = false;
                }
                #line (321,10)-(321,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                __cb.Push("    ");
                var __first45 = true;
                #line (322,10)-(322,47) 17 "MetaModelGenerator.mxg"
                if (info.HiddenProperties.Length > 0)
                #line hidden
                
                {
                    if (__first45)
                    {
                        __first45 = false;
                    }
                    #line (322,48)-(322,51) 33 "MetaModelGenerator.mxg"
                    __cb.Write("new");
                    #line hidden
                    #line (322,51)-(322,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (322,61)-(322,182) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                #line hidden
                #line (322,183)-(322,184) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (322,185)-(322,194) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (322,195)-(322,196) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (322,196)-(322,197) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                #line (322,197)-(322,198) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (322,198)-(322,202) 29 "MetaModelGenerator.mxg"
                __cb.Write("get;");
                #line hidden
                #line (322,202)-(322,203) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                var __first46 = true;
                #line (322,204)-(322,224) 17 "MetaModelGenerator.mxg"
                if (HasSetter(prop))
                #line hidden
                
                {
                    if (__first46)
                    {
                        __first46 = false;
                    }
                    #line (322,225)-(322,229) 33 "MetaModelGenerator.mxg"
                    __cb.Write("set;");
                    #line hidden
                    #line (322,229)-(322,230) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                }
                #line (322,238)-(322,239) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first44) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first47 = true;
            #line (325,6)-(325,40) 13 "MetaModelGenerator.mxg"
            foreach (var op in cls.Operations)
            #line hidden
            
            {
                if (__first47)
                {
                    __first47 = false;
                }
                __cb.Push("    ");
                #line (326,10)-(326,33) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.ReturnType));
                #line hidden
                #line (326,34)-(326,35) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (326,36)-(326,43) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (326,44)-(326,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first48 = true;
                #line (326,46)-(326,83) 17 "MetaModelGenerator.mxg"
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
                        #line (326,93)-(326,97) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (326,99)-(326,119) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(param.Type));
                    #line hidden
                    #line (326,120)-(326,121) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (326,122)-(326,132) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (326,146)-(326,148) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first47) __cb.AppendLine();
            __cb.Push("");
            #line (328,1)-(328,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (331,9)-(331,52) 22 "MetaModelGenerator.mxg"
        public string GenerateClass(MetaModel mm, MetaClass cls)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            #line (332,2)-(332,119) 13 "MetaModelGenerator.mxg"
            var metaCls = Graph.GetMetaClass(MetaDslx.CodeAnalysis.MetaType.FromModelObject((MetaDslx.Modeling.IModelObject)cls));
            #line hidden
            
            __cb.Push("");
            #line (333,1)-(333,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (333,9)-(333,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,10)-(333,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (333,15)-(333,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,17)-(333,25) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (333,26)-(333,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl");
            #line hidden
            #line (333,31)-(333,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,32)-(333,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (333,33)-(333,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,34)-(333,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModelObject,");
            #line hidden
            #line (333,52)-(333,53) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (333,54)-(333,62) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (334,1)-(334,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (335,5)-(335,12) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (335,12)-(335,13) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (335,14)-(335,22) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (335,23)-(335,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(string?");
            #line hidden
            #line (335,36)-(335,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (335,37)-(335,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("id)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (336,9)-(336,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (336,10)-(336,11) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (336,11)-(336,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("base(id)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (337,5)-(337,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first49 = true;
            #line (338,10)-(338,45) 13 "MetaModelGenerator.mxg"
            foreach (var slot in metaCls.Slots)
            #line hidden
            
            {
                if (__first49)
                {
                    __first49 = false;
                }
                #line (339,14)-(339,102) 17 "MetaModelGenerator.mxg"
                var defaultValue = ToCSharpValue(slot.SlotProperty.Type, slot.SlotProperty.DefaultValue);
                #line hidden
                
                var __first50 = true;
                #line (340,14)-(340,83) 17 "MetaModelGenerator.mxg"
                if (!string.IsNullOrEmpty(defaultValue) && defaultValue != "default")
                #line hidden
                
                {
                    if (__first50)
                    {
                        __first50 = false;
                    }
                    __cb.Push("        ");
                    #line (341,17)-(341,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write("((__IModelObject)this).MGetSlot(");
                    #line hidden
                    #line (341,50)-(341,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty));
                    #line hidden
                    #line (341,78)-(341,86) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")?.Add((");
                    #line hidden
                    #line (341,87)-(341,119) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(slot.SlotProperty.Type));
                    #line hidden
                    #line (341,120)-(341,121) 33 "MetaModelGenerator.mxg"
                    __cb.Write(")");
                    #line hidden
                    #line (341,122)-(341,178) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpValue(slot.SlotProperty.Type, slot.DefaultValue));
                    #line hidden
                    #line (341,179)-(341,181) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first50) __cb.AppendLine();
            }
            if (!__first49) __cb.AppendLine();
            var __first51 = true;
            #line (344,10)-(344,66) 13 "MetaModelGenerator.mxg"
            foreach (var baseType in metaCls.AllBaseTypes.Reverse())
            #line hidden
            
            {
                if (__first51)
                {
                    __first51 = false;
                }
                __cb.Push("        ");
                #line (345,14)-(345,21) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (345,22)-(345,36) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (345,37)-(345,50) 28 "MetaModelGenerator.mxg"
                __cb.Write(baseType.Name);
                #line hidden
                #line (345,51)-(345,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first51) __cb.AppendLine();
            __cb.Push("        ");
            #line (347,10)-(347,17) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (347,18)-(347,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(".__CustomImpl.");
            #line hidden
            #line (347,33)-(347,41) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (347,42)-(347,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("(this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (348,5)-(348,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (350,5)-(350,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (350,11)-(350,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,12)-(350,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (350,20)-(350,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,21)-(350,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            #line (350,37)-(350,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,38)-(350,43) 25 "MetaModelGenerator.mxg"
            __cb.Write("MInfo");
            #line hidden
            #line (350,43)-(350,44) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,44)-(350,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (350,46)-(350,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (350,47)-(350,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info.Instance;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first52 = true;
            #line (352,6)-(352,57) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first52)
                {
                    __first52 = false;
                }
                #line (353,10)-(353,53) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                var __first53 = true;
                #line (354,10)-(354,54) 17 "MetaModelGenerator.mxg"
                if (metaCls.PublicProperties.Contains(prop))
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (355,13)-(355,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (355,19)-(355,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,21)-(355,142) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (355,143)-(355,144) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (355,145)-(355,154) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (356,10)-(356,14) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first53)
                    {
                        __first53 = false;
                    }
                    __cb.Push("    ");
                    #line (357,14)-(357,17) 32 "MetaModelGenerator.mxg"
                    __cb.Write("[");
                    #line hidden
                    #line (357,18)-(357,119) 33 "MetaModelGenerator.mxg"
                    __cb.Write("global::System.Diagnostics.DebuggerBrowsable(global::System.Diagnostics.DebuggerBrowsableState.Never)");
                    #line hidden
                    #line (357,120)-(357,123) 32 "MetaModelGenerator.mxg"
                    __cb.Write("]");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (358,14)-(358,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.UnderlyingProperty.IsDerived ? ToCSharpOpType(prop.UnderlyingProperty.Type) : ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (358,136)-(358,137) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (358,138)-(358,181) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.DeclaringType.UnderlyingType));
                    #line hidden
                    #line (358,182)-(358,183) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (358,184)-(358,193) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first53) __cb.AppendLine();
                __cb.Push("    ");
                #line (360,9)-(360,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                var __first54 = true;
                #line (361,14)-(361,52) 17 "MetaModelGenerator.mxg"
                if (prop.UnderlyingProperty.IsDerived)
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    #line (362,18)-(362,81) 21 "MetaModelGenerator.mxg"
                    var actualProp = info.HidingProperties.FirstOrDefault() ?? prop;
                    #line hidden
                    
                    __cb.Push("        ");
                    #line (363,17)-(363,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (363,20)-(363,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (363,21)-(363,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (363,23)-(363,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (363,25)-(363,32) 32 "MetaModelGenerator.mxg"
                    __cb.Write(mm.Name);
                    #line hidden
                    #line (363,33)-(363,47) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".__CustomImpl.");
                    #line hidden
                    #line (363,48)-(363,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.DeclaringType.Name);
                    #line hidden
                    #line (363,78)-(363,79) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (363,80)-(363,95) 32 "MetaModelGenerator.mxg"
                    __cb.Write(actualProp.Name);
                    #line hidden
                    #line (363,96)-(363,103) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(this);");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (364,14)-(364,41) 17 "MetaModelGenerator.mxg"
                else if (prop.IsCollection)
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    __cb.Push("        ");
                    #line (365,17)-(365,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (365,20)-(365,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (365,21)-(365,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (365,23)-(365,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (365,24)-(365,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGetCollection<");
                    #line hidden
                    #line (365,40)-(365,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.Type));
                    #line hidden
                    #line (365,60)-(365,62) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (365,63)-(365,77) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (365,78)-(365,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                }
                #line (366,14)-(366,18) 17 "MetaModelGenerator.mxg"
                else
                #line hidden
                
                {
                    if (__first54)
                    {
                        __first54 = false;
                    }
                    __cb.Push("        ");
                    #line (367,17)-(367,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write("get");
                    #line hidden
                    #line (367,20)-(367,21) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (367,21)-(367,23) 33 "MetaModelGenerator.mxg"
                    __cb.Write("=>");
                    #line hidden
                    #line (367,23)-(367,24) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (367,24)-(367,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write("MGet<");
                    #line hidden
                    #line (367,30)-(367,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                    #line hidden
                    #line (367,69)-(367,71) 33 "MetaModelGenerator.mxg"
                    __cb.Write(">(");
                    #line hidden
                    #line (367,72)-(367,86) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharp(prop));
                    #line hidden
                    #line (367,87)-(367,89) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    var __first55 = true;
                    #line (368,18)-(368,38) 21 "MetaModelGenerator.mxg"
                    if (HasSetter(prop))
                    #line hidden
                    
                    {
                        if (__first55)
                        {
                            __first55 = false;
                        }
                        __cb.Push("        ");
                        #line (369,21)-(369,24) 37 "MetaModelGenerator.mxg"
                        __cb.Write("set");
                        #line hidden
                        #line (369,24)-(369,25) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (369,25)-(369,27) 37 "MetaModelGenerator.mxg"
                        __cb.Write("=>");
                        #line hidden
                        #line (369,27)-(369,28) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (369,28)-(369,33) 37 "MetaModelGenerator.mxg"
                        __cb.Write("MSet<");
                        #line hidden
                        #line (369,34)-(369,72) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop.UnderlyingProperty.Type));
                        #line hidden
                        #line (369,73)-(369,75) 37 "MetaModelGenerator.mxg"
                        __cb.Write(">(");
                        #line hidden
                        #line (369,76)-(369,90) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharp(prop));
                        #line hidden
                        #line (369,91)-(369,92) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (369,92)-(369,93) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (369,93)-(369,100) 37 "MetaModelGenerator.mxg"
                        __cb.Write("value);");
                        #line hidden
                        __cb.WriteLine();
                        __cb.Pop();
                    }
                    if (!__first55) __cb.AppendLine();
                }
                if (!__first54) __cb.AppendLine();
                __cb.Push("    ");
                #line (372,9)-(372,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first52) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first56 = true;
            #line (376,6)-(376,55) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first56)
                {
                    __first56 = false;
                }
                #line (377,10)-(377,52) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                #line (378,10)-(378,73) 17 "MetaModelGenerator.mxg"
                var actualOp = info.OverridingOperations.FirstOrDefault() ?? op;
                #line hidden
                
                __cb.Push("    ");
                #line (379,10)-(379,59) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpOpType(op.UnderlyingOperation.ReturnType));
                #line hidden
                #line (379,60)-(379,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (379,62)-(379,103) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op.DeclaringType.UnderlyingType));
                #line hidden
                #line (379,104)-(379,105) 29 "MetaModelGenerator.mxg"
                __cb.Write(".");
                #line hidden
                #line (379,106)-(379,113) 28 "MetaModelGenerator.mxg"
                __cb.Write(op.Name);
                #line hidden
                #line (379,114)-(379,115) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                var __first57 = true;
                #line (379,116)-(379,173) 17 "MetaModelGenerator.mxg"
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
                        #line (379,183)-(379,187) 36 "MetaModelGenerator.mxg"
                        __cb.Write(", ");
                        #line hidden
                        __cb.DontIgnoreLastLineEnd = false;
                        __cb.Pop();
                    }
                    #line (379,189)-(379,215) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(param.Type));
                    #line hidden
                    #line (379,216)-(379,217) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (379,218)-(379,228) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (379,242)-(379,243) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
                #line (379,243)-(379,244) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (379,244)-(379,246) 29 "MetaModelGenerator.mxg"
                __cb.Write("=>");
                #line hidden
                #line (379,246)-(379,247) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (379,248)-(379,255) 28 "MetaModelGenerator.mxg"
                __cb.Write(mm.Name);
                #line hidden
                #line (379,256)-(379,270) 29 "MetaModelGenerator.mxg"
                __cb.Write(".__CustomImpl.");
                #line hidden
                #line (379,271)-(379,298) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.DeclaringType.Name);
                #line hidden
                #line (379,299)-(379,300) 29 "MetaModelGenerator.mxg"
                __cb.Write("_");
                #line hidden
                #line (379,301)-(379,314) 28 "MetaModelGenerator.mxg"
                __cb.Write(actualOp.Name);
                #line hidden
                #line (379,315)-(379,320) 29 "MetaModelGenerator.mxg"
                __cb.Write("(this");
                #line hidden
                var __first58 = true;
                #line (379,321)-(379,383) 17 "MetaModelGenerator.mxg"
                foreach (var param in actualOp.UnderlyingOperation.Parameters)
                #line hidden
                
                {
                    if (__first58)
                    {
                        __first58 = false;
                    }
                    #line (379,384)-(379,385) 33 "MetaModelGenerator.mxg"
                    __cb.Write(",");
                    #line hidden
                    #line (379,385)-(379,386) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (379,387)-(379,397) 32 "MetaModelGenerator.mxg"
                    __cb.Write(param.Name);
                    #line hidden
                }
                #line (379,411)-(379,413) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first56) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (382,5)-(382,13) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (382,13)-(382,14) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,14)-(382,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (382,19)-(382,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,20)-(382,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (382,26)-(382,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,27)-(382,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (382,28)-(382,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (382,29)-(382,45) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelClassInfo");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (383,5)-(383,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (384,9)-(384,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (384,15)-(384,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,16)-(384,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("static");
            #line hidden
            #line (384,22)-(384,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,23)-(384,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (384,31)-(384,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,32)-(384,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info");
            #line hidden
            #line (384,38)-(384,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,39)-(384,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("Instance");
            #line hidden
            #line (384,47)-(384,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,48)-(384,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (384,49)-(384,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,50)-(384,53) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (384,53)-(384,54) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (384,54)-(384,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
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
            #line (386,26)-(386,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (386,95)-(386,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (386,96)-(386,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
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
            #line (387,26)-(387,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (387,95)-(387,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (387,96)-(387,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
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
            #line (388,26)-(388,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (388,94)-(388,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (388,95)-(388,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
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
            #line (389,26)-(389,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (389,94)-(389,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (389,95)-(389,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
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
            #line (390,26)-(390,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (390,94)-(390,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (390,95)-(390,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
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
            #line (391,26)-(391,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (391,90)-(391,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,91)-(391,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (391,107)-(391,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (391,108)-(391,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (392,9)-(392,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (392,16)-(392,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,17)-(392,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (392,25)-(392,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,26)-(392,99) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (392,99)-(392,100) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,100)-(392,120) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (392,120)-(392,121) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (392,121)-(392,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
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
            __cb.Write("readonly");
            #line hidden
            #line (393,25)-(393,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,26)-(393,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (393,95)-(393,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (393,96)-(393,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (394,9)-(394,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (394,16)-(394,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,17)-(394,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (394,25)-(394,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,26)-(394,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (394,95)-(394,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (394,96)-(394,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (395,9)-(395,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (395,16)-(395,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,17)-(395,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (395,25)-(395,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,26)-(395,95) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (395,95)-(395,96) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (395,96)-(395,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (396,9)-(396,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (396,16)-(396,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,17)-(396,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("readonly");
            #line hidden
            #line (396,25)-(396,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,26)-(396,100) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (396,100)-(396,101) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,101)-(396,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (396,122)-(396,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (396,123)-(396,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (398,9)-(398,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("private");
            #line hidden
            #line (398,16)-(398,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (398,17)-(398,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("__Info()");
            #line hidden
            #line (398,25)-(398,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (399,9)-(399,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (400,13)-(400,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes");
            #line hidden
            #line (400,23)-(400,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,24)-(400,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (400,25)-(400,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (400,26)-(400,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first59 = true;
            #line (400,69)-(400,107) 13 "MetaModelGenerator.mxg"
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
                    #line (400,117)-(400,121) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (400,123)-(400,135) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (400,149)-(400,151) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (401,13)-(401,26) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes");
            #line hidden
            #line (401,26)-(401,27) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (401,27)-(401,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (401,28)-(401,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (401,29)-(401,71) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelClassInfo>(");
            #line hidden
            var __first60 = true;
            #line (401,72)-(401,113) 13 "MetaModelGenerator.mxg"
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
                    #line (401,123)-(401,127) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (401,129)-(401,141) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(bt));
                #line hidden
            }
            #line (401,155)-(401,157) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (402,13)-(402,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties");
            #line hidden
            #line (402,32)-(402,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,33)-(402,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (402,34)-(402,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (402,35)-(402,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first61 = true;
            #line (402,77)-(402,126) 13 "MetaModelGenerator.mxg"
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
                    #line (402,136)-(402,140) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (402,142)-(402,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (402,170)-(402,172) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (403,13)-(403,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties");
            #line hidden
            #line (403,35)-(403,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,36)-(403,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (403,37)-(403,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (403,38)-(403,79) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first62 = true;
            #line (403,80)-(403,132) 13 "MetaModelGenerator.mxg"
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
                    #line (403,142)-(403,146) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (403,148)-(403,162) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (403,176)-(403,178) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (404,13)-(404,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties");
            #line hidden
            #line (404,30)-(404,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (404,31)-(404,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (404,32)-(404,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (404,33)-(404,74) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelProperty>(");
            #line hidden
            var __first63 = true;
            #line (404,75)-(404,122) 13 "MetaModelGenerator.mxg"
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
                    #line (404,132)-(404,136) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (404,138)-(404,152) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
            }
            #line (404,166)-(404,168) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
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
            #line (405,17)-(405,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName");
            #line hidden
            #line (405,39)-(405,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,40)-(405,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (405,41)-(405,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,42)-(405,85) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<string,");
            #line hidden
            #line (405,85)-(405,86) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (405,86)-(405,105) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first64 = true;
            #line (406,14)-(406,60) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.PublicProperties)
            #line hidden
            
            {
                if (__first64)
                {
                    __first64 = false;
                }
                __cb.Push("            ");
                #line (407,17)-(407,45) 29 "MetaModelGenerator.mxg"
                __cb.Write("publicPropertiesByName.Add(\"");
                #line hidden
                #line (407,46)-(407,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(prop.Name);
                #line hidden
                #line (407,56)-(407,58) 29 "MetaModelGenerator.mxg"
                __cb.Write("\",");
                #line hidden
                #line (407,58)-(407,59) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (407,60)-(407,74) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (407,75)-(407,77) 29 "MetaModelGenerator.mxg"
                __cb.Write(");");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first64) __cb.AppendLine();
            __cb.Push("            ");
            #line (409,13)-(409,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName");
            #line hidden
            #line (409,36)-(409,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,37)-(409,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (409,38)-(409,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (409,39)-(409,76) 25 "MetaModelGenerator.mxg"
            __cb.Write("publicPropertiesByName.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (410,13)-(410,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (410,16)-(410,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,17)-(410,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos");
            #line hidden
            #line (410,35)-(410,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,36)-(410,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (410,37)-(410,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,38)-(410,90) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelProperty,");
            #line hidden
            #line (410,90)-(410,91) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (410,91)-(410,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first65 = true;
            #line (411,14)-(411,65) 13 "MetaModelGenerator.mxg"
            foreach (var prop in metaCls.AllDeclaredProperties)
            #line hidden
            
            {
                if (__first65)
                {
                    __first65 = false;
                }
                #line (412,18)-(412,61) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelPropertyInfos[prop];
                #line hidden
                
                #line (413,18)-(413,38) 17 "MetaModelGenerator.mxg"
                var slot = info.Slot;
                #line hidden
                
                __cb.Push("            ");
                #line (414,17)-(414,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelPropertyInfos.Add(");
                #line hidden
                #line (414,41)-(414,55) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(prop));
                #line hidden
                #line (414,56)-(414,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,57)-(414,58) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,58)-(414,61) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (414,61)-(414,62) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,62)-(414,85) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertyInfo(new");
                #line hidden
                #line (414,85)-(414,86) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,86)-(414,106) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelPropertySlot(");
                #line hidden
                #line (414,107)-(414,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperty));
                #line hidden
                #line (414,135)-(414,136) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,136)-(414,137) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,138)-(414,167) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.SlotProperties));
                #line hidden
                #line (414,168)-(414,169) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,169)-(414,170) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,171)-(414,214) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharpValue(prop.Type, prop.DefaultValue));
                #line hidden
                #line (414,215)-(414,216) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,216)-(414,217) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,218)-(414,238) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(slot.Flags));
                #line hidden
                #line (414,239)-(414,241) 29 "MetaModelGenerator.mxg"
                __cb.Write("),");
                #line hidden
                #line (414,241)-(414,242) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,243)-(414,276) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OppositeProperties));
                #line hidden
                #line (414,277)-(414,278) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,278)-(414,279) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,280)-(414,314) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettedProperties));
                #line hidden
                #line (414,315)-(414,316) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,316)-(414,317) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,318)-(414,353) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.SubsettingProperties));
                #line hidden
                #line (414,354)-(414,355) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,355)-(414,356) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,357)-(414,391) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefinedProperties));
                #line hidden
                #line (414,392)-(414,393) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,393)-(414,394) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,395)-(414,430) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.RedefiningProperties));
                #line hidden
                #line (414,431)-(414,432) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,432)-(414,433) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,434)-(414,465) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HiddenProperties));
                #line hidden
                #line (414,466)-(414,467) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (414,467)-(414,468) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (414,469)-(414,500) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.HidingProperties));
                #line hidden
                #line (414,501)-(414,504) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first65) __cb.AppendLine();
            __cb.Push("            ");
            #line (416,13)-(416,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos");
            #line hidden
            #line (416,32)-(416,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,33)-(416,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (416,34)-(416,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (416,35)-(416,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelPropertyInfos.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (418,13)-(418,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations");
            #line hidden
            #line (418,32)-(418,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,33)-(418,34) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (418,34)-(418,35) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (418,35)-(418,77) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first66 = true;
            #line (418,78)-(418,125) 13 "MetaModelGenerator.mxg"
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
                    #line (418,135)-(418,139) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (418,141)-(418,153) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (418,167)-(418,169) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (419,13)-(419,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations");
            #line hidden
            #line (419,35)-(419,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,36)-(419,37) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (419,37)-(419,38) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (419,38)-(419,80) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first67 = true;
            #line (419,81)-(419,131) 13 "MetaModelGenerator.mxg"
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
                    #line (419,141)-(419,145) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (419,147)-(419,159) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (419,173)-(419,175) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (420,13)-(420,30) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations");
            #line hidden
            #line (420,30)-(420,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,31)-(420,32) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (420,32)-(420,33) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (420,33)-(420,75) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableArray.Create<__ModelOperation>(");
            #line hidden
            var __first68 = true;
            #line (420,76)-(420,121) 13 "MetaModelGenerator.mxg"
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
                    #line (420,131)-(420,135) 32 "MetaModelGenerator.mxg"
                    __cb.Write(", ");
                    #line hidden
                    __cb.DontIgnoreLastLineEnd = false;
                    __cb.Pop();
                }
                #line (420,137)-(420,149) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
            }
            #line (420,163)-(420,165) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (421,13)-(421,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (421,16)-(421,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,17)-(421,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos");
            #line hidden
            #line (421,36)-(421,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,37)-(421,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (421,38)-(421,39) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,39)-(421,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ImmutableDictionary.CreateBuilder<__ModelOperation,");
            #line hidden
            #line (421,92)-(421,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (421,93)-(421,117) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            var __first69 = true;
            #line (422,14)-(422,63) 13 "MetaModelGenerator.mxg"
            foreach (var op in metaCls.AllDeclaredOperations)
            #line hidden
            
            {
                if (__first69)
                {
                    __first69 = false;
                }
                #line (423,14)-(423,56) 17 "MetaModelGenerator.mxg"
                var info = metaCls.ModelOperationInfos[op];
                #line hidden
                
                __cb.Push("                ");
                #line (424,17)-(424,41) 29 "MetaModelGenerator.mxg"
                __cb.Write("modelOperationInfos.Add(");
                #line hidden
                #line (424,42)-(424,54) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(op));
                #line hidden
                #line (424,55)-(424,56) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (424,56)-(424,57) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (424,57)-(424,60) 29 "MetaModelGenerator.mxg"
                __cb.Write("new");
                #line hidden
                #line (424,60)-(424,61) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (424,61)-(424,82) 29 "MetaModelGenerator.mxg"
                __cb.Write("__ModelOperationInfo(");
                #line hidden
                #line (424,83)-(424,117) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridenOperations));
                #line hidden
                #line (424,118)-(424,119) 29 "MetaModelGenerator.mxg"
                __cb.Write(",");
                #line hidden
                #line (424,119)-(424,120) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (424,121)-(424,156) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(info.OverridingOperations));
                #line hidden
                #line (424,157)-(424,160) 29 "MetaModelGenerator.mxg"
                __cb.Write("));");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first69) __cb.AppendLine();
            __cb.Push("            ");
            #line (426,13)-(426,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos");
            #line hidden
            #line (426,33)-(426,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,34)-(426,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (426,35)-(426,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (426,36)-(426,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("modelOperationInfos.ToImmutable();");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (427,9)-(427,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
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
            #line (429,25)-(429,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaModel");
            #line hidden
            #line (429,36)-(429,37) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,37)-(429,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaModel");
            #line hidden
            #line (429,46)-(429,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,47)-(429,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (429,49)-(429,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (429,51)-(429,58) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (429,59)-(429,70) 25 "MetaModelGenerator.mxg"
            __cb.Write(".MInstance;");
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
            #line (430,25)-(430,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (430,35)-(430,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,36)-(430,44) 25 "MetaModelGenerator.mxg"
            __cb.Write("MetaType");
            #line hidden
            #line (430,44)-(430,45) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,45)-(430,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (430,47)-(430,48) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (430,48)-(430,55) 25 "MetaModelGenerator.mxg"
            __cb.Write("typeof(");
            #line hidden
            #line (430,56)-(430,64) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (430,65)-(430,67) 25 "MetaModelGenerator.mxg"
            __cb.Write(");");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
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
            #line (432,25)-(432,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("__MetaType");
            #line hidden
            #line (432,35)-(432,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,36)-(432,46) 25 "MetaModelGenerator.mxg"
            __cb.Write("SymbolType");
            #line hidden
            #line (432,46)-(432,47) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (432,47)-(432,49) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (432,49)-(432,50) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first70 = true;
            #line (432,51)-(432,82) 13 "MetaModelGenerator.mxg"
            if (metaCls.SymbolType is null)
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (432,83)-(432,90) 29 "MetaModelGenerator.mxg"
                __cb.Write("default");
                #line hidden
            }
            #line (432,91)-(432,95) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first70)
                {
                    __first70 = false;
                }
                #line (432,96)-(432,103) 29 "MetaModelGenerator.mxg"
                __cb.Write("typeof(");
                #line hidden
                #line (432,104)-(432,132) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.SymbolType));
                #line hidden
                #line (432,133)-(432,134) 29 "MetaModelGenerator.mxg"
                __cb.Write(")");
                #line hidden
            }
            #line (432,142)-(432,143) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
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
            #line (433,25)-(433,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (433,41)-(433,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,42)-(433,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("NameProperty");
            #line hidden
            #line (433,54)-(433,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (433,55)-(433,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (433,57)-(433,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first71 = true;
            #line (433,59)-(433,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.NameProperty is null)
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (433,93)-(433,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (433,98)-(433,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first71)
                {
                    __first71 = false;
                }
                #line (433,104)-(433,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.NameProperty));
                #line hidden
            }
            #line (433,143)-(433,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
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
            #line (434,25)-(434,41) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty?");
            #line hidden
            #line (434,41)-(434,42) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,42)-(434,54) 25 "MetaModelGenerator.mxg"
            __cb.Write("TypeProperty");
            #line hidden
            #line (434,54)-(434,55) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (434,55)-(434,57) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (434,57)-(434,58) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            var __first72 = true;
            #line (434,59)-(434,92) 13 "MetaModelGenerator.mxg"
            if (metaCls.TypeProperty is null)
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (434,93)-(434,97) 29 "MetaModelGenerator.mxg"
                __cb.Write("null");
                #line hidden
            }
            #line (434,98)-(434,102) 13 "MetaModelGenerator.mxg"
            else
            #line hidden
            
            {
                if (__first72)
                {
                    __first72 = false;
                }
                #line (434,104)-(434,134) 28 "MetaModelGenerator.mxg"
                __cb.Write(ToCSharp(metaCls.TypeProperty));
                #line hidden
            }
            #line (434,143)-(434,144) 25 "MetaModelGenerator.mxg"
            __cb.Write(";");
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
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (435,94)-(435,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,95)-(435,104) 25 "MetaModelGenerator.mxg"
            __cb.Write("BaseTypes");
            #line hidden
            #line (435,104)-(435,105) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,105)-(435,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (435,107)-(435,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (435,108)-(435,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("_baseTypes;");
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
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelClassInfo>");
            #line hidden
            #line (436,94)-(436,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,95)-(436,107) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllBaseTypes");
            #line hidden
            #line (436,107)-(436,108) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,108)-(436,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (436,110)-(436,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (436,111)-(436,125) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allBaseTypes;");
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
            #line (437,25)-(437,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (437,93)-(437,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,94)-(437,112) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredProperties");
            #line hidden
            #line (437,112)-(437,113) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,113)-(437,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (437,115)-(437,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (437,116)-(437,136) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (438,9)-(438,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (438,15)-(438,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,16)-(438,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (438,24)-(438,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,25)-(438,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (438,93)-(438,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,94)-(438,115) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredProperties");
            #line hidden
            #line (438,115)-(438,116) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,116)-(438,118) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (438,118)-(438,119) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (438,119)-(438,142) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (439,9)-(439,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (439,15)-(439,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,16)-(439,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (439,24)-(439,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,25)-(439,93) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelProperty>");
            #line hidden
            #line (439,93)-(439,94) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,94)-(439,110) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicProperties");
            #line hidden
            #line (439,110)-(439,111) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,111)-(439,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (439,113)-(439,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (439,114)-(439,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicProperties;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (440,9)-(440,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (440,15)-(440,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,16)-(440,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (440,24)-(440,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,25)-(440,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (440,94)-(440,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,95)-(440,113) 25 "MetaModelGenerator.mxg"
            __cb.Write("DeclaredOperations");
            #line hidden
            #line (440,113)-(440,114) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,114)-(440,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (440,116)-(440,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (440,117)-(440,137) 25 "MetaModelGenerator.mxg"
            __cb.Write("_declaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (441,9)-(441,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (441,15)-(441,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,16)-(441,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (441,24)-(441,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,25)-(441,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (441,94)-(441,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,95)-(441,116) 25 "MetaModelGenerator.mxg"
            __cb.Write("AllDeclaredOperations");
            #line hidden
            #line (441,116)-(441,117) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,117)-(441,119) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (441,119)-(441,120) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (441,120)-(441,143) 25 "MetaModelGenerator.mxg"
            __cb.Write("_allDeclaredOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (442,9)-(442,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (442,15)-(442,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,16)-(442,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (442,24)-(442,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,25)-(442,94) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableArray<__ModelOperation>");
            #line hidden
            #line (442,94)-(442,95) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,95)-(442,111) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicOperations");
            #line hidden
            #line (442,111)-(442,112) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,112)-(442,114) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (442,114)-(442,115) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (442,115)-(442,133) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicOperations;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (444,9)-(444,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (444,18)-(444,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,19)-(444,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (444,27)-(444,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,28)-(444,92) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<string,");
            #line hidden
            #line (444,92)-(444,93) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,93)-(444,109) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelProperty>");
            #line hidden
            #line (444,109)-(444,110) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,110)-(444,132) 25 "MetaModelGenerator.mxg"
            __cb.Write("PublicPropertiesByName");
            #line hidden
            #line (444,132)-(444,133) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,133)-(444,135) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (444,135)-(444,136) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (444,136)-(444,160) 25 "MetaModelGenerator.mxg"
            __cb.Write("_publicPropertiesByName;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (445,9)-(445,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (445,18)-(445,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,19)-(445,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (445,27)-(445,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,28)-(445,101) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelProperty,");
            #line hidden
            #line (445,101)-(445,102) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,102)-(445,122) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelPropertyInfo>");
            #line hidden
            #line (445,122)-(445,123) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,123)-(445,141) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelPropertyInfos");
            #line hidden
            #line (445,141)-(445,142) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,142)-(445,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (445,144)-(445,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (445,145)-(445,165) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelPropertyInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (446,9)-(446,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("protected");
            #line hidden
            #line (446,18)-(446,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,19)-(446,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (446,27)-(446,28) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,28)-(446,102) 25 "MetaModelGenerator.mxg"
            __cb.Write("global::System.Collections.Immutable.ImmutableDictionary<__ModelOperation,");
            #line hidden
            #line (446,102)-(446,103) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,103)-(446,124) 25 "MetaModelGenerator.mxg"
            __cb.Write("__ModelOperationInfo>");
            #line hidden
            #line (446,124)-(446,125) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,125)-(446,144) 25 "MetaModelGenerator.mxg"
            __cb.Write("ModelOperationInfos");
            #line hidden
            #line (446,144)-(446,145) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,145)-(446,147) 25 "MetaModelGenerator.mxg"
            __cb.Write("=>");
            #line hidden
            #line (446,147)-(446,148) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (446,148)-(446,169) 25 "MetaModelGenerator.mxg"
            __cb.Write("_modelOperationInfos;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (448,9)-(448,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (448,15)-(448,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,16)-(448,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (448,24)-(448,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,25)-(448,40) 25 "MetaModelGenerator.mxg"
            __cb.Write("__IModelObject?");
            #line hidden
            #line (448,40)-(448,41) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,41)-(448,56) 25 "MetaModelGenerator.mxg"
            __cb.Write("Create(__Model?");
            #line hidden
            #line (448,56)-(448,57) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,57)-(448,62) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (448,62)-(448,63) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,63)-(448,64) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (448,64)-(448,65) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,65)-(448,70) 25 "MetaModelGenerator.mxg"
            __cb.Write("null,");
            #line hidden
            #line (448,70)-(448,71) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,71)-(448,78) 25 "MetaModelGenerator.mxg"
            __cb.Write("string?");
            #line hidden
            #line (448,78)-(448,79) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,79)-(448,81) 25 "MetaModelGenerator.mxg"
            __cb.Write("id");
            #line hidden
            #line (448,81)-(448,82) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,82)-(448,83) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (448,83)-(448,84) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (448,84)-(448,89) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (449,9)-(449,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (450,13)-(450,16) 25 "MetaModelGenerator.mxg"
            __cb.Write("var");
            #line hidden
            #line (450,16)-(450,17) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,17)-(450,23) 25 "MetaModelGenerator.mxg"
            __cb.Write("result");
            #line hidden
            #line (450,23)-(450,24) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,24)-(450,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("=");
            #line hidden
            #line (450,25)-(450,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,26)-(450,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("new");
            #line hidden
            #line (450,29)-(450,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (450,31)-(450,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (450,40)-(450,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("_Impl(id);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (451,13)-(451,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("if");
            #line hidden
            #line (451,15)-(451,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,16)-(451,22) 25 "MetaModelGenerator.mxg"
            __cb.Write("(model");
            #line hidden
            #line (451,22)-(451,23) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,23)-(451,25) 25 "MetaModelGenerator.mxg"
            __cb.Write("is");
            #line hidden
            #line (451,25)-(451,26) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,26)-(451,29) 25 "MetaModelGenerator.mxg"
            __cb.Write("not");
            #line hidden
            #line (451,29)-(451,30) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,30)-(451,35) 25 "MetaModelGenerator.mxg"
            __cb.Write("null)");
            #line hidden
            #line (451,35)-(451,36) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (451,36)-(451,63) 25 "MetaModelGenerator.mxg"
            __cb.Write("model.AttachObject(result);");
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
            #line (452,20)-(452,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("result;");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (453,9)-(453,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (455,9)-(455,15) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (455,15)-(455,16) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,16)-(455,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("override");
            #line hidden
            #line (455,24)-(455,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,25)-(455,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("string");
            #line hidden
            #line (455,31)-(455,32) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (455,32)-(455,42) 25 "MetaModelGenerator.mxg"
            __cb.Write("ToString()");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (456,9)-(456,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("            ");
            #line (457,13)-(457,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("return");
            #line hidden
            #line (457,19)-(457,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (457,20)-(457,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("\"");
            #line hidden
            #line (457,22)-(457,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (457,30)-(457,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(".");
            #line hidden
            #line (457,32)-(457,40) 24 "MetaModelGenerator.mxg"
            __cb.Write(cls.Name);
            #line hidden
            #line (457,41)-(457,47) 25 "MetaModelGenerator.mxg"
            __cb.Write("Info\";");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("        ");
            #line (458,9)-(458,10) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (459,5)-(459,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (460,1)-(460,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (463,9)-(463,47) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomInterface(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (464,1)-(464,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (464,9)-(464,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,10)-(464,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("interface");
            #line hidden
            #line (464,19)-(464,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (464,20)-(464,27) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (464,28)-(464,35) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (464,36)-(464,50) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (465,1)-(465,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (466,5)-(466,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (466,8)-(466,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (466,9)-(466,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (467,5)-(467,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (467,8)-(467,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,9)-(467,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (467,20)-(467,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,21)-(467,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (467,24)-(467,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,25)-(467,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (467,28)-(467,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,29)-(467,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (467,33)-(467,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,34)-(467,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (467,39)-(467,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (467,41)-(467,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (468,5)-(468,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (468,8)-(468,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (468,9)-(468,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (469,5)-(469,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (469,9)-(469,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,11)-(469,18) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (469,19)-(469,21) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (469,22)-(469,29) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (469,30)-(469,31) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (469,31)-(469,38) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this);");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first73 = true;
            #line (471,6)-(471,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first73)
                {
                    __first73 = false;
                }
                __cb.Push("    ");
                #line (472,9)-(472,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (472,12)-(472,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (472,13)-(472,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (473,9)-(473,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (473,12)-(473,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,13)-(473,24) 29 "MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (473,24)-(473,25) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,25)-(473,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (473,28)-(473,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,29)-(473,32) 29 "MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (473,32)-(473,33) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,33)-(473,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (473,38)-(473,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (473,40)-(473,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (474,9)-(474,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (474,12)-(474,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (474,13)-(474,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (475,9)-(475,13) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (475,13)-(475,14) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (475,15)-(475,23) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (475,24)-(475,25) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (475,26)-(475,34) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (475,35)-(475,36) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (475,36)-(475,43) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this);");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first73) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first74 = true;
            #line (479,6)-(479,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first74)
                {
                    __first74 = false;
                }
                var __first75 = true;
                #line (480,10)-(480,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first75)
                    {
                        __first75 = false;
                    }
                    __cb.Push("    ");
                    #line (481,13)-(481,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (481,16)-(481,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (481,17)-(481,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (482,13)-(482,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (482,16)-(482,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (482,17)-(482,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (482,28)-(482,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (482,29)-(482,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (482,31)-(482,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (482,32)-(482,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (482,35)-(482,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (482,36)-(482,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (482,43)-(482,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (482,44)-(482,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (482,52)-(482,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (482,54)-(482,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (482,63)-(482,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (482,65)-(482,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (483,13)-(483,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (483,16)-(483,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (483,17)-(483,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (484,14)-(484,39) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (484,40)-(484,41) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (484,42)-(484,50) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (484,51)-(484,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (484,53)-(484,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (484,63)-(484,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (484,65)-(484,73) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (484,74)-(484,75) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (484,75)-(484,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.WriteLine();
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
            #line (489,6)-(489,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first76)
                {
                    __first76 = false;
                }
                var __first77 = true;
                #line (490,10)-(490,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first77)
                    {
                        __first77 = false;
                    }
                    __cb.Push("    ");
                    #line (491,13)-(491,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (491,16)-(491,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (491,17)-(491,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (492,13)-(492,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (492,16)-(492,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (492,17)-(492,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (492,31)-(492,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (492,32)-(492,34) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (492,34)-(492,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (492,35)-(492,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (492,38)-(492,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (492,39)-(492,48) 33 "MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (492,48)-(492,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (492,50)-(492,58) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (492,59)-(492,60) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (492,61)-(492,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (493,13)-(493,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (493,16)-(493,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (493,17)-(493,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (494,14)-(494,43) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (494,44)-(494,45) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (494,46)-(494,54) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (494,55)-(494,56) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (494,57)-(494,64) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (494,65)-(494,66) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (494,67)-(494,75) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (494,76)-(494,77) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (494,77)-(494,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first78 = true;
                    #line (494,83)-(494,119) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first78)
                        {
                            __first78 = false;
                        }
                        #line (494,120)-(494,121) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (494,121)-(494,122) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (494,123)-(494,149) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (494,150)-(494,151) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (494,152)-(494,162) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (494,176)-(494,178) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first77) __cb.AppendLine();
            }
            if (!__first76) __cb.AppendLine();
            __cb.Push("");
            #line (498,1)-(498,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
        #line (501,9)-(501,52) 22 "MetaModelGenerator.mxg"
        public string GenerateCustomImplementation(MetaModel mm)
        #line hidden
        {
            var __cb = global::MetaDslx.CodeGeneration.CodeBuilder.GetInstance();
            __cb.Push("");
            #line (502,1)-(502,9) 25 "MetaModelGenerator.mxg"
            __cb.Write("internal");
            #line hidden
            #line (502,9)-(502,10) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,10)-(502,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("abstract");
            #line hidden
            #line (502,18)-(502,19) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,19)-(502,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("class");
            #line hidden
            #line (502,24)-(502,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,25)-(502,31) 25 "MetaModelGenerator.mxg"
            __cb.Write("Custom");
            #line hidden
            #line (502,32)-(502,39) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (502,40)-(502,58) 25 "MetaModelGenerator.mxg"
            __cb.Write("ImplementationBase");
            #line hidden
            #line (502,58)-(502,59) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,59)-(502,60) 25 "MetaModelGenerator.mxg"
            __cb.Write(":");
            #line hidden
            #line (502,60)-(502,61) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (502,61)-(502,68) 25 "MetaModelGenerator.mxg"
            __cb.Write("ICustom");
            #line hidden
            #line (502,69)-(502,76) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (502,77)-(502,91) 25 "MetaModelGenerator.mxg"
            __cb.Write("Implementation");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("");
            #line (503,1)-(503,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (504,5)-(504,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (504,8)-(504,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (504,9)-(504,18) 25 "MetaModelGenerator.mxg"
            __cb.Write("<summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (505,5)-(505,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (505,8)-(505,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,9)-(505,20) 25 "MetaModelGenerator.mxg"
            __cb.Write("Constructor");
            #line hidden
            #line (505,20)-(505,21) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,21)-(505,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("for");
            #line hidden
            #line (505,24)-(505,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,25)-(505,28) 25 "MetaModelGenerator.mxg"
            __cb.Write("the");
            #line hidden
            #line (505,28)-(505,29) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,29)-(505,33) 25 "MetaModelGenerator.mxg"
            __cb.Write("meta");
            #line hidden
            #line (505,33)-(505,34) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,34)-(505,39) 25 "MetaModelGenerator.mxg"
            __cb.Write("model");
            #line hidden
            #line (505,39)-(505,40) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (505,41)-(505,48) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (506,5)-(506,8) 25 "MetaModelGenerator.mxg"
            __cb.Write("///");
            #line hidden
            #line (506,8)-(506,9) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (506,9)-(506,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("</summary>");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (507,5)-(507,11) 25 "MetaModelGenerator.mxg"
            __cb.Write("public");
            #line hidden
            #line (507,11)-(507,12) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,12)-(507,19) 25 "MetaModelGenerator.mxg"
            __cb.Write("virtual");
            #line hidden
            #line (507,19)-(507,20) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,20)-(507,24) 25 "MetaModelGenerator.mxg"
            __cb.Write("void");
            #line hidden
            #line (507,24)-(507,25) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,26)-(507,33) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (507,34)-(507,36) 25 "MetaModelGenerator.mxg"
            __cb.Write("(I");
            #line hidden
            #line (507,37)-(507,44) 24 "MetaModelGenerator.mxg"
            __cb.Write(mm.Name);
            #line hidden
            #line (507,45)-(507,46) 25 "MetaModelGenerator.mxg"
            __cb.Write(" ");
            #line hidden
            #line (507,46)-(507,52) 25 "MetaModelGenerator.mxg"
            __cb.Write("_this)");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (508,5)-(508,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("{");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.Push("    ");
            #line (509,5)-(509,6) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            __cb.WriteLine();
            __cb.Pop();
            var __first79 = true;
            #line (511,6)-(511,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first79)
                {
                    __first79 = false;
                }
                __cb.Push("    ");
                #line (512,9)-(512,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (512,12)-(512,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (512,13)-(512,22) 29 "MetaModelGenerator.mxg"
                __cb.Write("<summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (513,9)-(513,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (513,12)-(513,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (513,13)-(513,24) 29 "MetaModelGenerator.mxg"
                __cb.Write("Constructor");
                #line hidden
                #line (513,24)-(513,25) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (513,25)-(513,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("for");
                #line hidden
                #line (513,28)-(513,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (513,29)-(513,32) 29 "MetaModelGenerator.mxg"
                __cb.Write("the");
                #line hidden
                #line (513,32)-(513,33) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (513,33)-(513,38) 29 "MetaModelGenerator.mxg"
                __cb.Write("class");
                #line hidden
                #line (513,38)-(513,39) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (513,40)-(513,48) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (514,9)-(514,12) 29 "MetaModelGenerator.mxg"
                __cb.Write("///");
                #line hidden
                #line (514,12)-(514,13) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (514,13)-(514,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("</summary>");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (515,9)-(515,15) 29 "MetaModelGenerator.mxg"
                __cb.Write("public");
                #line hidden
                #line (515,15)-(515,16) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (515,16)-(515,23) 29 "MetaModelGenerator.mxg"
                __cb.Write("virtual");
                #line hidden
                #line (515,23)-(515,24) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (515,24)-(515,28) 29 "MetaModelGenerator.mxg"
                __cb.Write("void");
                #line hidden
                #line (515,28)-(515,29) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (515,30)-(515,38) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (515,39)-(515,40) 29 "MetaModelGenerator.mxg"
                __cb.Write("(");
                #line hidden
                #line (515,41)-(515,49) 28 "MetaModelGenerator.mxg"
                __cb.Write(cls.Name);
                #line hidden
                #line (515,50)-(515,51) 29 "MetaModelGenerator.mxg"
                __cb.Write(" ");
                #line hidden
                #line (515,51)-(515,57) 29 "MetaModelGenerator.mxg"
                __cb.Write("_this)");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (516,9)-(516,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("{");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.Push("    ");
                #line (517,9)-(517,10) 29 "MetaModelGenerator.mxg"
                __cb.Write("}");
                #line hidden
                __cb.WriteLine();
                __cb.Pop();
                __cb.WriteLine();
                __cb.Pop();
            }
            if (!__first79) __cb.AppendLine();
            __cb.WriteLine();
            __cb.Pop();
            var __first80 = true;
            #line (521,6)-(521,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first80)
                {
                    __first80 = false;
                }
                var __first81 = true;
                #line (522,10)-(522,70) 17 "MetaModelGenerator.mxg"
                foreach (var prop in cls.Properties.Where(p => p.IsDerived))
                #line hidden
                
                {
                    if (__first81)
                    {
                        __first81 = false;
                    }
                    __cb.Push("    ");
                    #line (523,13)-(523,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (523,16)-(523,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (523,17)-(523,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (524,13)-(524,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (524,16)-(524,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (524,17)-(524,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Computation");
                    #line hidden
                    #line (524,28)-(524,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (524,29)-(524,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (524,31)-(524,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (524,32)-(524,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (524,35)-(524,36) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (524,36)-(524,43) 33 "MetaModelGenerator.mxg"
                    __cb.Write("derived");
                    #line hidden
                    #line (524,43)-(524,44) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (524,44)-(524,52) 33 "MetaModelGenerator.mxg"
                    __cb.Write("property");
                    #line hidden
                    #line (524,52)-(524,53) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (524,54)-(524,62) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (524,63)-(524,64) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (524,65)-(524,74) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (525,13)-(525,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (525,16)-(525,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (525,17)-(525,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (526,13)-(526,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (526,19)-(526,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (526,20)-(526,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (526,28)-(526,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (526,30)-(526,55) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(prop.Type));
                    #line hidden
                    #line (526,56)-(526,57) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (526,58)-(526,66) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (526,67)-(526,68) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (526,69)-(526,78) 32 "MetaModelGenerator.mxg"
                    __cb.Write(prop.Name);
                    #line hidden
                    #line (526,79)-(526,80) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (526,81)-(526,89) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (526,90)-(526,91) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (526,91)-(526,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this);");
                    #line hidden
                    __cb.WriteLine();
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
            #line (531,6)-(531,34) 13 "MetaModelGenerator.mxg"
            foreach (var cls in Classes)
            #line hidden
            
            {
                if (__first82)
                {
                    __first82 = false;
                }
                var __first83 = true;
                #line (532,10)-(532,44) 17 "MetaModelGenerator.mxg"
                foreach (var op in cls.Operations)
                #line hidden
                
                {
                    if (__first83)
                    {
                        __first83 = false;
                    }
                    __cb.Push("    ");
                    #line (533,13)-(533,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (533,16)-(533,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (533,17)-(533,26) 33 "MetaModelGenerator.mxg"
                    __cb.Write("<summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (534,13)-(534,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (534,16)-(534,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (534,17)-(534,31) 33 "MetaModelGenerator.mxg"
                    __cb.Write("Implementation");
                    #line hidden
                    #line (534,31)-(534,32) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (534,32)-(534,34) 33 "MetaModelGenerator.mxg"
                    __cb.Write("of");
                    #line hidden
                    #line (534,34)-(534,35) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (534,35)-(534,38) 33 "MetaModelGenerator.mxg"
                    __cb.Write("the");
                    #line hidden
                    #line (534,38)-(534,39) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (534,39)-(534,48) 33 "MetaModelGenerator.mxg"
                    __cb.Write("operation");
                    #line hidden
                    #line (534,48)-(534,49) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (534,50)-(534,58) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (534,59)-(534,60) 33 "MetaModelGenerator.mxg"
                    __cb.Write(".");
                    #line hidden
                    #line (534,61)-(534,68) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (535,13)-(535,16) 33 "MetaModelGenerator.mxg"
                    __cb.Write("///");
                    #line hidden
                    #line (535,16)-(535,17) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (535,17)-(535,27) 33 "MetaModelGenerator.mxg"
                    __cb.Write("</summary>");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.Push("    ");
                    #line (536,13)-(536,19) 33 "MetaModelGenerator.mxg"
                    __cb.Write("public");
                    #line hidden
                    #line (536,19)-(536,20) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (536,20)-(536,28) 33 "MetaModelGenerator.mxg"
                    __cb.Write("abstract");
                    #line hidden
                    #line (536,28)-(536,29) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (536,30)-(536,59) 32 "MetaModelGenerator.mxg"
                    __cb.Write(ToCSharpOpType(op.ReturnType));
                    #line hidden
                    #line (536,60)-(536,61) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (536,62)-(536,70) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (536,71)-(536,72) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_");
                    #line hidden
                    #line (536,73)-(536,80) 32 "MetaModelGenerator.mxg"
                    __cb.Write(op.Name);
                    #line hidden
                    #line (536,81)-(536,82) 33 "MetaModelGenerator.mxg"
                    __cb.Write("(");
                    #line hidden
                    #line (536,83)-(536,91) 32 "MetaModelGenerator.mxg"
                    __cb.Write(cls.Name);
                    #line hidden
                    #line (536,92)-(536,93) 33 "MetaModelGenerator.mxg"
                    __cb.Write(" ");
                    #line hidden
                    #line (536,93)-(536,98) 33 "MetaModelGenerator.mxg"
                    __cb.Write("_this");
                    #line hidden
                    var __first84 = true;
                    #line (536,99)-(536,135) 21 "MetaModelGenerator.mxg"
                    foreach (var param in op.Parameters)
                    #line hidden
                    
                    {
                        if (__first84)
                        {
                            __first84 = false;
                        }
                        #line (536,136)-(536,137) 37 "MetaModelGenerator.mxg"
                        __cb.Write(",");
                        #line hidden
                        #line (536,137)-(536,138) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (536,139)-(536,165) 36 "MetaModelGenerator.mxg"
                        __cb.Write(ToCSharpOpType(param.Type));
                        #line hidden
                        #line (536,166)-(536,167) 37 "MetaModelGenerator.mxg"
                        __cb.Write(" ");
                        #line hidden
                        #line (536,168)-(536,178) 36 "MetaModelGenerator.mxg"
                        __cb.Write(param.Name);
                        #line hidden
                    }
                    #line (536,192)-(536,194) 33 "MetaModelGenerator.mxg"
                    __cb.Write(");");
                    #line hidden
                    __cb.WriteLine();
                    __cb.Pop();
                    __cb.WriteLine();
                    __cb.Pop();
                }
                if (!__first83) __cb.AppendLine();
            }
            if (!__first82) __cb.AppendLine();
            __cb.Push("");
            #line (540,1)-(540,2) 25 "MetaModelGenerator.mxg"
            __cb.Write("}");
            #line hidden
            __cb.WriteLine();
            __cb.Pop();
            return __cb.ToStringAndFree();
        }
        
    }}